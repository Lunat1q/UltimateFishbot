using System;
using System.Windows.Input;

namespace UltimateFishBot.Settings
{
    internal class BotSettings
    {
        public HotKeySettings HotKeys { get; set; }

        public BotSettings(Properties.Settings appSettings)
        {
            HotKeys = new HotKeySettings
            {
                StartStopKey = appSettings.StartStopHotKey.ToKeyStroke(),
                CursorCaptureKey = appSettings.CursorCaptureHotKey.ToKeyStroke()
            };
        }
    }
}