using System.ComponentModel;
using Newtonsoft.Json;
using UltimateFishBot.BodyParts;

namespace UltimateFishBot.Settings
{
    internal class BotSettings
    {
        [DefaultValue(1800)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int CastingDelayHigh { get; set; } = 1800;

        [DefaultValue(3000)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int LootingDelayHigh { get; set; } = 3000;

        [DefaultValue(1500)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int CastingDelayLow { get; set; } = 1500;

        [DefaultValue(15)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int HearthTime { get; set; } = 15;

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
        public bool RightClickCast { get; set; } = false;

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

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoRaft { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoCharm { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool ShiftLoot { get; set; } = false;

        [DefaultValue("")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string AudioDevice { get; set; } = "";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AutoBait { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool CycleThroughBaitList { get; set; } = false;

        [DefaultValue("English")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string Language { get; set; } = "English";

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
        public AntiAfkMoves AntiAfkMoves { get; set; } = 0;

        [DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AlternativeRoute { get; set; } = true;
        
        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool Txt2speech { get; set; } = false;

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool AverageSound { get; set; } = false;

        public HotKeySettings HotKeys { get; set; }

        public ScanSettings Scan { get; set; }

        public BotSettings()
        {
            HotKeys = new HotKeySettings();
            Scan = new ScanSettings();
        }
    }
}