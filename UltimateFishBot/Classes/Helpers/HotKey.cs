using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using UltimateFishBot.Servicing;

namespace UltimateFishBot.Helpers
{
    /// <summary>
    /// https://stackoverflow.com/questions/48935/how-can-i-register-a-global-hot-key-to-say-ctrlshiftletter-using-wpf-and-ne
    /// </summary>
    internal class HotKey : IDisposable
    {
        private static readonly Dictionary<int, HotKey> DictHotKeyToCalBackProc;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, UInt32 fsModifiers, UInt32 vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int WmHotKey = 0x0312;

        private bool _disposed = false;
        private static int _globalHotKeyId;

        public Key Key { get; private set; }
        public KeyModifier KeyModifiers { get; private set; }
        public Action<HotKey> Action { get; private set; }
        public Action ActionEmpty { get; private set; }
        public int Id { get; set; }

        //TODO: WinForms solution, remove when moving to WPF
        #region WinForms->Wpf bridge
        internal delegate void WinFormsMessageBridgeDelegate(ref MSG msg, ref bool handled);
        #endregion

        static HotKey()
        {
            DictHotKeyToCalBackProc = new Dictionary<int, HotKey>();

            //TODO: WinForms solution, remove when moving to WPF
            #region WinForms->Wpf bridge
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
            var winFormsMessaging = new WinFormsMessaging(ComponentDispatcher_ThreadFilterMessage);
            Application.AddMessageFilter(winFormsMessaging);
            #endregion
        }

        private static void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            // Look up the hot key in the dictionary
            if (msg.message == WmHotKey && !handled)
            {
                HotKey hotkey;
                if (DictHotKeyToCalBackProc.TryGetValue((int)msg.wParam, out hotkey))
                {
                    hotkey.Action?.Invoke(hotkey);
                    hotkey.ActionEmpty?.Invoke();
                    handled = true;
                }
            }
        }

        // ******************************************************************
        public HotKey(Key k, KeyModifier keyModifiers, Action<HotKey> action, bool register = true)
        {
            Key = k;
            KeyModifiers = keyModifiers;
            Action = action;
            if (register)
            {
                Register();
            }
        }

        // ******************************************************************
        public HotKey(Key k, KeyModifier keyModifiers, Action actionEmpty, bool register = true)
        {
            Key = k;
            KeyModifiers = keyModifiers;
            ActionEmpty = actionEmpty;
            if (register)
            {
                Register();
            }
        }

        private static int IssueGlobalId()
        {
            return _globalHotKeyId++;
        }

        // ******************************************************************
        public void Register()
        {
            int virtualKeyCode = KeyInterop.VirtualKeyFromKey(Key);
            Id = IssueGlobalId(); //virtualKeyCode + ((int)KeyModifiers * 0x10000);
            bool result = RegisterHotKey(IntPtr.Zero, Id, (UInt32)KeyModifiers, (UInt32)virtualKeyCode);

            Debug.Print(result + ", " + Id + ", " + virtualKeyCode);

            if (result)
            {
                DictHotKeyToCalBackProc.Add(Id, this);
            }
            else
            {
                throw new Exception("Error during key binding.");
            }
        }

        // ******************************************************************
        public void Unregister()
        {
            HotKey hotKey;
            if (DictHotKeyToCalBackProc.TryGetValue(Id, out hotKey))
            {
                UnregisterHotKey(IntPtr.Zero, Id);
                DictHotKeyToCalBackProc.Remove(Id);
            }
        }

        // ******************************************************************
        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // ******************************************************************
        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be _disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be _disposed.
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this._disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    Unregister();
                }

                // Note disposing has been done.
                _disposed = true;
            }
        }
    }

    // ******************************************************************
    [Flags]
    public enum KeyModifier
    {
        None = 0x0000,
        Alt = 0x0001,
        Ctrl = 0x0002,
        NoRepeat = 0x4000,
        Shift = 0x0004,
        Win = 0x0008
    }
}