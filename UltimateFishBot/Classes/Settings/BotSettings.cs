using System;
using System.ComponentModel;
using System.Windows.Input;
using Newtonsoft.Json;

namespace UltimateFishBot.Settings
{
    internal class BotSettings
    {
        [DefaultValue(1500)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int CastingDelayLow { get; set; } = 1500;

        [DefaultValue(2500)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int LootingDelayLow { get; set; } = 2500;

        [DefaultValue(15)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int SplashLimit { get; set; } = 15;

        [DefaultValue(0)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int Startup { get; set; } = 0;

        [DefaultValue("Wow")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string ProcName { get; set; } = "Wow";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoLure { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoHearth { get; set; } = false;

        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool SwapGear { get; set; } = true;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool UseAltKey { get; set; } = false;

        [DefaultValue("1")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string FishKey { get; set; } = "1";

        [DefaultValue("2")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string LureKey { get; set; } = "2";

        [DefaultValue("3")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string HearthKey { get; set; } = "3";

        [DefaultValue("4")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string FishGearKey { get; set; } = "4";

        [DefaultValue("5")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string NormGearKey { get; set; } = "5";

        [DefaultValue(15)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int HearthTime { get; set; } = 15;

        [DefaultValue("4")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string RaftKey { get; set; } = "4";

        [DefaultValue("5")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string CharmKey { get; set; } = "5";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoRaft { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoCharm { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool ShiftLoot { get; set; } = false;

        [DefaultValue(21500)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int FishWaitLow { get; set; } = 21500;

        [DefaultValue("")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string AudioDevice { get; set; } = "";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoBait { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool CycleThroughBaitList { get; set; } = false;

        [DefaultValue("6")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey1 { get; set; } = "6";

        [DefaultValue("7")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey2 { get; set; } = "7";

        [DefaultValue("8")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey3 { get; set; } = "8";

        [DefaultValue("9")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey4 { get; set; } = "9";

        [DefaultValue("0")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey5 { get; set; } = "0";

        [DefaultValue(")")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey6 { get; set; } = ")";

        [DefaultValue("-")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string BaitKey7 { get; set; } = "-";

        [DefaultValue("English")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Language { get; set; } = "English";

        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool CheckCursor { get; set; } = true;

        [DefaultValue(10)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int LureTime { get; set; } = 10;

        [DefaultValue(8)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int RaftTime { get; set; } = 8;

        [DefaultValue(60)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int CharmTime { get; set; } = 60;

        [DefaultValue(5)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int BaitTime { get; set; } = 5;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AntiAfk { get; set; } = false;

        [DefaultValue(14)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int AntiAfkTime { get; set; } = 14;

        [DefaultValue(0)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int AntiAfkMoves { get; set; } = 0;

        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AlternativeRoute { get; set; } = true;

        [DefaultValue("Ctrl+Shift+S")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string StartStopHotKey { get; set; } = "Ctrl+Shift+S";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool Txt2speech { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AverageSound { get; set; } = false;

        public HotKeySettings HotKeys { get; set; }

        public ScanSettings Scan { get; set; }

        public BotSettings(Properties.Settings appSettings) : this()
        {
            HotKeys = new HotKeySettings
            {
                StartStopKey = appSettings.StartStopHotKey.ToKeyStroke(),
                CursorCaptureKey = appSettings.CursorCaptureHotKey.ToKeyStroke()
            };
        }

        public BotSettings()
        {
            HotKeys = new HotKeySettings();
            Scan = new ScanSettings();
        }
    }
}