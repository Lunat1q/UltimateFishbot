using System;
using System.Windows.Input;
using UltimateFishBot.Helpers;

namespace UltimateFishBot.Settings
{
    internal class KeyStroke
    {
        public Key HotKey { get; set; }

        public KeyModifier Modifiers { get; set; }

        public override string ToString()
        {
            return $"{Modifiers} + {HotKey}";
        }
    }
}