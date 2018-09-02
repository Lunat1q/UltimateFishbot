using System.Windows.Forms;
using System.Windows.Input;
using UltimateFishBot.Helpers;

namespace UltimateFishBot.Settings
{
    internal static class KeyConverter
    {
        public static KeyStroke ToKeyStroke(this Keys keys)
        {
            var modifiers = RemoveAndReturnModifiers(ref keys);
            var key = KeyInterop.KeyFromVirtualKey((int) keys);
            return new KeyStroke {HotKey = key, Modifiers = modifiers};
        }

        private static KeyModifier RemoveAndReturnModifiers(ref Keys key)
        {
            var modifiers = KeyModifier.None;

            modifiers |= RemoveAndReturnModifier(ref key, Keys.Shift, KeyModifier.Shift);
            modifiers |= RemoveAndReturnModifier(ref key, Keys.Control, KeyModifier.Ctrl);
            modifiers |= RemoveAndReturnModifier(ref key, Keys.Alt, KeyModifier.Alt);

            return modifiers;
        }

        private static KeyModifier RemoveAndReturnModifier(ref Keys key, Keys keyModifier, KeyModifier modifier)
        {
            if ((key & keyModifier) == 0) return KeyModifier.None;
            key &= ~keyModifier;
            return modifier;
        }
    }
}