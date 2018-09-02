using System;
using System.Windows.Forms;
using System.Windows.Interop;
using UltimateFishBot.Helpers;

namespace UltimateFishBot.Servicing
{
    internal class WinFormsMessaging : IMessageFilter
    {
        private readonly HotKey.WinFormsMessageBridgeDelegate _threadFilterMessage;

        public WinFormsMessaging(HotKey.WinFormsMessageBridgeDelegate bridgeMessage)
        {
            this._threadFilterMessage = bridgeMessage;
        }

        public bool PreFilterMessage(ref Message m)
        {
            var msg = new MSG {hwnd = m.HWnd, lParam = m.LParam, message = m.Msg, wParam = m.WParam};
            bool res = false;
            _threadFilterMessage(ref msg, ref res);

            return res;
        }
    }
}