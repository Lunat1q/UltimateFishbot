//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UltimateFishBot.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /*[global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int ScanningStepsLow {
            get {
                return ((int)(this["ScanningStepsLow"]));
            }
            set {
                this["ScanningStepsLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("23")]
        public int ScanningDelayLow {
            get {
                return ((int)(this["ScanningDelayLow"]));
            }
            set {
                this["ScanningDelayLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int ScanningRetries {
            get {
                return ((int)(this["ScanningRetries"]));
            }
            set {
                this["ScanningRetries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1500")]
        public int CastingDelayLow {
            get {
                return ((int)(this["CastingDelayLow"]));
            }
            set {
                this["CastingDelayLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2600")]
        public int LootingDelayLow {
            get {
                return ((int)(this["LootingDelayLow"]));
            }
            set {
                this["LootingDelayLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public long SplashLimit {
            get {
                return ((long)(this["SplashLimit"]));
            }
            set {
                this["SplashLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Startup {
            get {
                return ((int)(this["Startup"]));
            }
            set {
                this["Startup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Wow")]
        public string ProcName {
            get {
                return ((string)(this["ProcName"]));
            }
            set {
                this["ProcName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoLure {
            get {
                return ((bool)(this["AutoLure"]));
            }
            set {
                this["AutoLure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoHearth {
            get {
                return ((bool)(this["AutoHearth"]));
            }
            set {
                this["AutoHearth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SwapGear {
            get {
                return ((bool)(this["SwapGear"]));
            }
            set {
                this["SwapGear"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAltKey {
            get {
                return ((bool)(this["UseAltKey"]));
            }
            set {
                this["UseAltKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string FishKey {
            get {
                return ((string)(this["FishKey"]));
            }
            set {
                this["FishKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string LureKey {
            get {
                return ((string)(this["LureKey"]));
            }
            set {
                this["LureKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public string HearthKey {
            get {
                return ((string)(this["HearthKey"]));
            }
            set {
                this["HearthKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public string FishGearKey {
            get {
                return ((string)(this["FishGearKey"]));
            }
            set {
                this["FishGearKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string NormGearKey {
            get {
                return ((string)(this["NormGearKey"]));
            }
            set {
                this["NormGearKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int HearthTime {
            get {
                return ((int)(this["HearthTime"]));
            }
            set {
                this["HearthTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public string RaftKey {
            get {
                return ((string)(this["RaftKey"]));
            }
            set {
                this["RaftKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public string CharmKey {
            get {
                return ((string)(this["CharmKey"]));
            }
            set {
                this["CharmKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoRaft {
            get {
                return ((bool)(this["AutoRaft"]));
            }
            set {
                this["AutoRaft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoCharm {
            get {
                return ((bool)(this["AutoCharm"]));
            }
            set {
                this["AutoCharm"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShiftLoot {
            get {
                return ((bool)(this["ShiftLoot"]));
            }
            set {
                this["ShiftLoot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("21500")]
        public int FishWaitLow {
            get {
                return ((int)(this["FishWaitLow"]));
            }
            set {
                this["FishWaitLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AudioDevice {
            get {
                return ((string)(this["AudioDevice"]));
            }
            set {
                this["AudioDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoBait {
            get {
                return ((bool)(this["AutoBait"]));
            }
            set {
                this["AutoBait"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CycleThroughBaitList {
            get {
                return ((bool)(this["CycleThroughBaitList"]));
            }
            set {
                this["CycleThroughBaitList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public string BaitKey1 {
            get {
                return ((string)(this["BaitKey1"]));
            }
            set {
                this["BaitKey1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public string BaitKey2 {
            get {
                return ((string)(this["BaitKey2"]));
            }
            set {
                this["BaitKey2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public string BaitKey3 {
            get {
                return ((string)(this["BaitKey3"]));
            }
            set {
                this["BaitKey3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9")]
        public string BaitKey4 {
            get {
                return ((string)(this["BaitKey4"]));
            }
            set {
                this["BaitKey4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string BaitKey5 {
            get {
                return ((string)(this["BaitKey5"]));
            }
            set {
                this["BaitKey5"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(")")]
        public string BaitKey6 {
            get {
                return ((string)(this["BaitKey6"]));
            }
            set {
                this["BaitKey6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-")]
        public string BaitKey7 {
            get {
                return ((string)(this["BaitKey7"]));
            }
            set {
                this["BaitKey7"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CheckCursor {
            get {
                return ((bool)(this["CheckCursor"]));
            }
            set {
                this["CheckCursor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int LureTime {
            get {
                return ((int)(this["LureTime"]));
            }
            set {
                this["LureTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int RaftTime {
            get {
                return ((int)(this["RaftTime"]));
            }
            set {
                this["RaftTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int CharmTime {
            get {
                return ((int)(this["CharmTime"]));
            }
            set {
                this["CharmTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int BaitTime {
            get {
                return ((int)(this["BaitTime"]));
            }
            set {
                this["BaitTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AntiAfk {
            get {
                return ((bool)(this["AntiAfk"]));
            }
            set {
                this["AntiAfk"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int AntiAfkTime {
            get {
                return ((int)(this["AntiAfkTime"]));
            }
            set {
                this["AntiAfkTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int AntiAfkMoves {
            get {
                return ((int)(this["AntiAfkMoves"]));
            }
            set {
                this["AntiAfkMoves"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AlternativeRoute {
            get {
                return ((bool)(this["AlternativeRoute"]));
            }
            set {
                this["AlternativeRoute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point minScanXY {
            get {
                return ((global::System.Drawing.Point)(this["minScanXY"]));
            }
            set {
                this["minScanXY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point maxScanXY {
            get {
                return ((global::System.Drawing.Point)(this["maxScanXY"]));
            }
            set {
                this["maxScanXY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool customScanArea {
            get {
                return ((bool)(this["customScanArea"]));
            }
            set {
                this["customScanArea"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+Shift+S")]
        public global::System.Windows.Forms.Keys StartStopHotKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["StartStopHotKey"]));
            }
            set {
                this["StartStopHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Txt2speech {
            get {
                return ((bool)(this["Txt2speech"]));
            }
            set {
                this["Txt2speech"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AverageSound {
            get {
                return ((bool)(this["AverageSound"]));
            }
            set {
                this["AverageSound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+Shift+C")]
        public global::System.Windows.Forms.Keys CursorCaptureHotKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["CursorCaptureHotKey"]));
            }
            set {
                this["CursorCaptureHotKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RightClickCast {
            get {
                return ((bool)(this["RightClickCast"]));
            }
            set {
                this["RightClickCast"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1800")]
        public int CastingDelayHigh {
            get {
                return ((int)(this["CastingDelayHigh"]));
            }
            set {
                this["CastingDelayHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3000")]
        public int LootingDelayHigh {
            get {
                return ((int)(this["LootingDelayHigh"]));
            }
            set {
                this["LootingDelayHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22200")]
        public int FishWaitHigh {
            get {
                return ((int)(this["FishWaitHigh"]));
            }
            set {
                this["FishWaitHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        public int ScanningDelayHigh {
            get {
                return ((int)(this["ScanningDelayHigh"]));
            }
            set {
                this["ScanningDelayHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int ScanningStepsHigh {
            get {
                return ((int)(this["ScanningStepsHigh"]));
            }
            set {
                this["ScanningStepsHigh"] = value;
            }
        }
        */
    }
}
