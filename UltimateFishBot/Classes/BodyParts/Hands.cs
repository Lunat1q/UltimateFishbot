using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using UltimateFishBot.Helpers;
using UltimateFishBot.Settings;

namespace UltimateFishBot.BodyParts
{
    internal class Hands
    {
        private Cursor _mCursor;
        private int _mBaitIndex;
        private string[] _mBaitKeys;
        private IntPtr _wow;

        private int _aCastingDelay;
        private int _aLootingDelay;

        public Hands(IntPtr wowWindow)
        {
            _wow = wowWindow;
            _mBaitIndex = 0;
            if (Cursor.Current != null) _mCursor = new Cursor(Cursor.Current.Handle);
            UpdateKeys();
        }

        public void SetWow(IntPtr wowWindow) {
            _wow = wowWindow;
        }

        private void UpdateKeys()
        {
            _mBaitKeys = new[]
            {
                SettingsController.Instance.HotKeys.BaitKey1,
                SettingsController.Instance.HotKeys.BaitKey2,
                SettingsController.Instance.HotKeys.BaitKey3,
                SettingsController.Instance.HotKeys.BaitKey4,
                SettingsController.Instance.HotKeys.BaitKey5,
                SettingsController.Instance.HotKeys.BaitKey6,
                SettingsController.Instance.HotKeys.BaitKey7,
            };
        }

        public async Task Cast(CancellationToken token)
        {
            if (SettingsController.Instance.RightClickCast)  {
                Win32.SendMouseDblRightClick(_wow);
            } else {
                Win32.SendKey(SettingsController.Instance.HotKeys.FishKey);
                Log.Information("Sent key: " + SettingsController.Instance.HotKeys.FishKey);
            }
            var rnd = new Random();
            _aCastingDelay = rnd.Next(SettingsController.Instance.CastingDelayLow, SettingsController.Instance.CastingDelayHigh);
            await Task.Delay(_aCastingDelay, token);
        }

        public async Task Loot()
        {
            Win32.SendMouseClick(_wow);
            Log.Information("Send Loot.");
            Random rnd = new Random();
            _aLootingDelay = rnd.Next(SettingsController.Instance.LootingDelayLow, SettingsController.Instance.LootingDelayHigh);
            await Task.Delay(_aLootingDelay);
        }

        public void ResetBaitIndex()
        {
            _mBaitIndex = 0;
        }

        public async Task DoAction(NeededAction action, Mouth mouth, CancellationToken cancellationToken)
        {
            string actionKey = "";
            int sleepTime = 0;

            switch (action)
            {
                case NeededAction.HearthStone:
                    {
                        actionKey = SettingsController.Instance.HotKeys.HearthKey;
                        mouth.Say(Translate.GetTranslate("manager", "LABEL_HEARTHSTONE"));
                        sleepTime = 0;
                        break;
                    }
                case NeededAction.Lure:
                    {
                        actionKey = SettingsController.Instance.HotKeys.LureKey;
                        mouth.Say(Translate.GetTranslate("manager", "LABEL_APPLY_LURE"));
                        sleepTime = 3;
                        break;
                    }
                case NeededAction.Charm:
                    {
                        actionKey = SettingsController.Instance.HotKeys.CharmKey;
                        mouth.Say(Translate.GetTranslate("manager", "LABEL_APPLY_CHARM"));
                        sleepTime = 3;
                        break;
                    }
                case NeededAction.Raft:
                    {
                        actionKey = SettingsController.Instance.HotKeys.RaftKey;
                        mouth.Say(Translate.GetTranslate("manager", "LABEL_APPLY_RAFT"));
                        sleepTime = 2;
                        break;
                    }
                case NeededAction.Bait:
                    {
                        int baitIndex = 0;

                        if (SettingsController.Instance.CycleThroughBaitList)
                        {
                            if (_mBaitIndex >= 6)
                                _mBaitIndex = 0;

                            baitIndex = _mBaitIndex++;
                        }

                        actionKey = _mBaitKeys[baitIndex];
                        mouth.Say(Translate.GetTranslate("manager", "LABEL_APPLY_BAIT", baitIndex));
                        sleepTime = 3;
                        break;
                    }
                default:
                    return;
            }

            Log.Information("Send key start: " + actionKey);
            Win32.ActivateWow(_wow);
            await Task.Delay(1000, cancellationToken);
            Win32.SendKey(actionKey);
            Log.Information("Sent key: "+actionKey);
            await Task.Delay(sleepTime * 1000, cancellationToken);
        }
    }
}
