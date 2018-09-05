using System.ComponentModel;
using Newtonsoft.Json;
using UltimateFishBot.Classes.Settings;

namespace UltimateFishBot.Settings
{
    internal class ScanSettings
    {
        [DefaultValue(15)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int ScanningStepsLow { get; set; } = 15;

        [DefaultValue(23)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int ScanningDelayLow { get; set; } = 23;

        [DefaultValue(2)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int ScanningRetries { get; set; } = 2;

        [DefaultValue("0, 0")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Coords MinScanXY { get; set; } = new Coords(0, 0);

        [DefaultValue("0, 0")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Coords MaxScanXY { get; set; } = new Coords(0, 0);

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool CustomScanArea { get; set; } = false;

        [DefaultValue("Alt+Shift+C")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string CursorCaptureHotKey { get; set; } = "Alt+Shift+C";

        [DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public bool RightClickCast { get; set; } = false;

        [DefaultValue(1800)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int CastingDelayHigh { get; set; } = 1800;

        [DefaultValue(3000)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int LootingDelayHigh { get; set; } = 3000;

        [DefaultValue(22200)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int FishWaitHigh { get; set; } = 22200;

        [DefaultValue(32)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int ScanningDelayHigh { get; set; } = 32;

        [DefaultValue(30)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public int ScanningStepsHigh { get; set; } = 30;
    }
}