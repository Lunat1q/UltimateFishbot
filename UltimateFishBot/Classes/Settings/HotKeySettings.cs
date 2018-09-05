using System.ComponentModel;
using System.Windows.Input;
using Newtonsoft.Json;
using UltimateFishBot.Helpers;

namespace UltimateFishBot.Settings
{
    internal class HotKeySettings
    {
        [DefaultValue("Shift+Ctrl+S")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public KeyStroke StartStopKey { get; set; } = new KeyStroke(Key.S, KeyModifier.Ctrl | KeyModifier.Shift);

        [DefaultValue("Shift+Alt+C")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public KeyStroke CursorCaptureKey { get; set; } = new KeyStroke(Key.C, KeyModifier.Alt | KeyModifier.Shift);
        
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

        [DefaultValue("4")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string RaftKey { get; set; } = "4";

        [DefaultValue("5")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string CharmKey { get; set; } = "5";
    }
}