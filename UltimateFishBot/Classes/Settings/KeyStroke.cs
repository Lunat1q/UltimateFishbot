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

        public KeyStroke()
        {
        }

        public KeyStroke(Key hotKey, KeyModifier modifiers)
        {
            HotKey = hotKey;
            Modifiers = modifiers;
        }

        public static implicit operator KeyStroke(string input)
        {
            var converter = new System.Windows.Input.KeyConverter();
            var convertFromString = converter.ConvertFromString(input);
            if (convertFromString != null)
            {
                var keys = (Key) convertFromString;
            }
            return new KeyStroke();
        }

        public static implicit operator string(KeyStroke stroke)
        {
            return stroke.ToString();
        }
    }
}