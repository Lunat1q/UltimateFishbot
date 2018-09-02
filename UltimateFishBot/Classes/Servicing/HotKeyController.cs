using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using UltimateFishBot.Forms;
using UltimateFishBot.Helpers;
using UltimateFishBot.Properties;
using UltimateFishBot.Settings;

namespace UltimateFishBot.Servicing
{
    internal static class HotKeyController
    {
        private static readonly IList<HotKey> RegisteredHotKeys = new List<HotKey>();

        public static void ReloadHotkeys(BotSettings settings, Manager botManager)
        {
            UnregisterHotKeys();

            RegisterHotKey(settings.HotKeys.CursorCaptureKey, botManager.CaptureCursor);
            RegisterHotKey(
                settings.HotKeys.StartStopKey, 
                () => Task.Factory.StartNew(async () =>
                    {
                        try
                        {
                            await botManager.StartOrStop();
                        }
                        catch (TaskCanceledException)
                        {
                            // Do nothing, cancellations are to be expected
                        }
                    },
                    System.Threading.CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.FromCurrentSynchronizationContext())
            );
        }

        private static void RegisterHotKey(KeyStroke keyStroke, Action handler)
        {
            RegisteredHotKeys.Add(new HotKey(keyStroke.HotKey, keyStroke.Modifiers, handler));
        }

        public static void UnregisterHotKeys()
        {
            foreach (var hotKey in RegisteredHotKeys)
            {
                hotKey.Unregister();
                hotKey.Dispose();
            }
            RegisteredHotKeys.Clear();
        }

        private static KeyModifier RemoveAndReturnModifiers(ref Key key)
        {
            var modifiers = KeyModifier.None;

            modifiers |= RemoveAndReturnModifier(ref key, Key.LeftShift, KeyModifier.Shift);
            modifiers |= RemoveAndReturnModifier(ref key, Key.RightShift, KeyModifier.Shift);
            modifiers |= RemoveAndReturnModifier(ref key, Key.LeftCtrl, KeyModifier.Ctrl);
            modifiers |= RemoveAndReturnModifier(ref key, Key.RightCtrl, KeyModifier.Ctrl);
            modifiers |= RemoveAndReturnModifier(ref key, Key.LeftAlt, KeyModifier.Alt);
            modifiers |= RemoveAndReturnModifier(ref key, Key.RightAlt, KeyModifier.Alt);

            return modifiers;
        }

        private static KeyModifier RemoveAndReturnModifier(ref Key key, Key keyModifier, KeyModifier modifier)
        {
            if ((key & keyModifier) == 0) return KeyModifier.None;
            key &= ~keyModifier;
            return modifier;
        }
    }
}