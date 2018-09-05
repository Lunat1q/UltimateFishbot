using CoreAudioApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UltimateFishBot.BodyParts;
using UltimateFishBot.Settings;

namespace UltimateFishBot.Forms
{
    public partial class frmSettings : Form
    {
        private static frmSettings inst;
        public static frmSettings GetForm(frmMain main)
        {
            if (inst == null || inst.IsDisposed)
                inst = new frmSettings(main);
            return inst;
        }


        private enum TabulationIndex
        {
            GeneralFishing = 0,
            FindCursor = 1,
            HearingFishing = 2,
            Premium = 3,
            AntiAfk = 4,
            Language = 5
        };

        private frmMain m_mainForm;
        private MMDevice m_SndDevice;
        private KeyStroke _keyStroke;

        public frmSettings(frmMain mainForm)
        {
            InitializeComponent();
            m_mainForm = mainForm;
            m_SndDevice = null;

            tmeAudio.Tick += new EventHandler(tmeAudio_Tick);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            /*
             * Set Text from translate file
             */

            this.Text = Translate.GetTranslate("frmSettings", "TITLE");

            tabSettings.TabPages[(int)TabulationIndex.GeneralFishing].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_GENERAL_FISHING");
            tabSettings.TabPages[(int)TabulationIndex.FindCursor].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_FIND_CURSOR");
            tabSettings.TabPages[(int)TabulationIndex.HearingFishing].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_HEARING_FISH");
            tabSettings.TabPages[(int)TabulationIndex.Premium].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_PREMIUM");
            tabSettings.TabPages[(int)TabulationIndex.AntiAfk].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_ANTI_AFK");
            tabSettings.TabPages[(int)TabulationIndex.Language].Text = Translate.GetTranslate("frmSettings", "TAB_TITLE_LANGUAGE");

            /// General

            LabelDelayCast.Text = Translate.GetTranslate("frmSettings", "LABEL_DELAY_AFTER_CAST");
            LabelDelayCastDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_DELAY_AFTER_CAST_DESC");

            LabelFishWait.Text = Translate.GetTranslate("frmSettings", "LABEL_FISH_WAIT_LIMIT");
            LabelFishWaitDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_FISH_WAIT_LIMIT_DESC");

            LabelDelayLooting.Text = Translate.GetTranslate("frmSettings", "LABEL_DELAY_AFTER_LOOTING");
            LabelDelayLootingDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_DELAY_AFTER_LOOTING_DESC");

            /// Finding the Cursor

            LabelScanningSteps.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_STEPS");
            LabelScanningStepsDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_STEPS_DESC");

            LabelScanningDelay.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_DELAY");
            LabelScanningDelayDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_DELAY_DESC");

            LabelScanningRetries.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_RETRIES");
            LabelScanningRetriesDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_SCANNING_RETRIES_DESC");

            cmbCompareIcon.Text = Translate.GetTranslate("frmSettings", "LABEL_CHECK_ICON");
            LabelCheckCursorIcon.Text = Translate.GetTranslate("frmSettings", "LABEL_CHECK_ICON_DESC");

            ccHotKeyLabel.Text = Translate.GetTranslate("frmSettings", "LABEL_CHECK_CAPTURE_ICON_DESC");

            cmbAlternativeRoute.Text = Translate.GetTranslate("frmSettings", "LABEL_ALTERNATIVE_ROUTE");
            LabelAlternativeRoute.Text = Translate.GetTranslate("frmSettings", "LABEL_ALTERNATIVE_ROUTE_DESC");

            LabelScanArea.Text = Translate.GetTranslate("frmSettings", "LABEL_SCAN_AREA");
            btnSetScanArea.Text = Translate.GetTranslate("frmSettings", "SET_SCANNING_AREA");
            LabelMinXY.Text = Translate.GetTranslate("frmSettings", "START_XY");
            LabelMaxXY.Text = Translate.GetTranslate("frmSettings", "END_XY");

            /// Hearing the Fish

            LabelSplashThreshold.Text = Translate.GetTranslate("frmSettings", "LABEL_SPLASH_THRESHOLD");
            LabelSplashThresholdDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_SPLASH_THRESHOLD_DESC");

            LabelAudioDevice.Text = Translate.GetTranslate("frmSettings", "LABEL_AUDIO_DEVICE");
            LabelAudioDeviceDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_AUDIO_DEVICE_DESC");

            cbSoundAvg.Text = Translate.GetTranslate("frmSettings", "CB_AVG_SND");

            /// Premium Settings
            /// TODO: labelHotKey translation

            LabelCastKey.Text = Translate.GetTranslate("frmSettings", "LABEL_CAST_KEY");
            LabelLureKey.Text = Translate.GetTranslate("frmSettings", "LABEL_LURE_KEY");
            LabelHearthKey.Text = Translate.GetTranslate("frmSettings", "LABEL_HEARTHSTONE_KEY");
            LabelRaftKey.Text = Translate.GetTranslate("frmSettings", "LABEL_RAFT_KEY");
            LabelCharmKey.Text = Translate.GetTranslate("frmSettings", "LABEL_CHARM_KEY");
            LabelBaitKey1.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_1");
            LabelBaitKey2.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_2");
            LabelBaitKey3.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_3");
            LabelBaitKey4.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_4");
            LabelBaitKey5.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_5");
            LabelBaitKey6.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_6");
            LabelBaitKey7.Text = Translate.GetTranslate("frmSettings", "LABEL_BAIT_KEY_7");

            LoadHotKeys();

            LabelCustomizeDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_CUSTOMIZE_DESC");

            cbAlt.Text = Translate.GetTranslate("frmSettings", "CB_ALT_KEY");
            cbAutoLure.Text = Translate.GetTranslate("frmSettings", "CB_AUTO_LURE");
            cbHearth.Text = Translate.GetTranslate("frmSettings", "CB_AUTO_HEARTHSTONE");
            cbApplyRaft.Text = Translate.GetTranslate("frmSettings", "CB_AUTO_RAFT");
            cbApplyCharm.Text = Translate.GetTranslate("frmSettings", "CB_AUTO_CHARM");
            cbAutoBait.Text = Translate.GetTranslate("frmSettings", "CB_AUTO_BAIT");
            cbCycleThroughBaitList.Text = Translate.GetTranslate("frmSettings", "CB_CYCLE_THROUGH_BAIT_LIST");
            cbShiftLoot.Text = Translate.GetTranslate("frmSettings", "CB_SHIFT_LOOT");

            LabelProcessName.Text = Translate.GetTranslate("frmSettings", "LABEL_PROCESS_NAME");
            LabelProcessNameDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_PROCESS_NAME_DESC");

            /// Anti Afk

            LoadAntiAfkMovements();
            cbAntiAfk.Text = Translate.GetTranslate("frmSettings", "CB_ANTI_AFK");

            /// Language Settings

            labelLanguage.Text = Translate.GetTranslate("frmSettings", "LABEL_LANGUAGE");
            labelLanguageDesc.Text = Translate.GetTranslate("frmSettings", "LABEL_LANGUAGE_DESC");

            /// Buttons

            buttonSave.Text = Translate.GetTranslate("frmSettings", "BUTTON_SAVE");
            buttonCancel.Text = Translate.GetTranslate("frmSettings", "BUTTON_CANCEL");

            /*
             * Set Settings from save
             */

            /// General
            txtCastDelayLow.Text = SettingsController.Instance.CastingDelayLow.ToString();
            txtLootingDelayLow.Text = SettingsController.Instance.LootingDelayLow.ToString();
            txtFishWaitLow.Text = SettingsController.Instance.Scan.FishWaitLow.ToString();
            txtCastDelayHigh.Text = SettingsController.Instance.CastingDelayHigh.ToString();
            txtLootingDelayHigh.Text = SettingsController.Instance.LootingDelayHigh.ToString();
            txtFishWaitHigh.Text = SettingsController.Instance.Scan.FishWaitHigh.ToString();

            /// Finding the Cursor
            txtDelayLow.Text = SettingsController.Instance.Scan.ScanningDelayLow.ToString();
            txtScanStepsLow.Text = SettingsController.Instance.Scan.ScanningStepsLow.ToString();
            txtDelayHigh.Text = SettingsController.Instance.Scan.ScanningDelayHigh.ToString();
            txtScanStepsHigh.Text = SettingsController.Instance.Scan.ScanningStepsHigh.ToString();
            txtRetries.Text = SettingsController.Instance.Scan.ScanningRetries.ToString();
            cmbCompareIcon.Checked = SettingsController.Instance.Scan.CheckCursor;
            cmbAlternativeRoute.Checked = SettingsController.Instance.AlternativeRoute;
            ccHotKey.Text = new KeysConverter().ConvertToString(SettingsController.Instance.Scan.CursorCaptureHotKey);
            customAreaCheckbox.Checked = SettingsController.Instance.Scan.CustomScanArea;
            txtMinXY.Text = SettingsController.Instance.Scan.MinScanXY.ToString();
            txtMaxXY.Text = SettingsController.Instance.Scan.MaxScanXY.ToString();

            /// Hearing the Fish
            txtSplash.Text = SettingsController.Instance.SplashLimit.ToString();
            LoadAudioDevices();
            cbSoundAvg.Checked = SettingsController.Instance.AverageSound;

            /// Premium Settings
            txtProcName.Text = SettingsController.Instance.ProcName;
            cbAutoLure.Checked = SettingsController.Instance.AutoLure;
            cbHearth.Checked = SettingsController.Instance.SwapGear;
            cbAlt.Checked = SettingsController.Instance.UseAltKey;

            txtFishKey.Text = SettingsController.Instance.HotKeys.FishKey;
            txtLureKey.Text = SettingsController.Instance.HotKeys.LureKey;
            txtHearthKey.Text = SettingsController.Instance.HotKeys.HearthKey;
            cbHearth.Checked = SettingsController.Instance.AutoHearth;
            txtHearthTime.Text = SettingsController.Instance.HearthTime.ToString();

            // MoP Premium (Angler's Raft & Ancient Pandaren Fishing Charm)
            txtCharmKey.Text = SettingsController.Instance.HotKeys.CharmKey;
            txtRaftKey.Text = SettingsController.Instance.HotKeys.RaftKey;
            cbApplyRaft.Checked = SettingsController.Instance.AutoRaft;
            cbApplyCharm.Checked = SettingsController.Instance.AutoCharm;
            cbShiftLoot.Checked = SettingsController.Instance.ShiftLoot;

            // WoD Premium (Bait)
            txtBaitKey1.Text = SettingsController.Instance.HotKeys.BaitKey1;
            txtBaitKey2.Text = SettingsController.Instance.HotKeys.BaitKey2;
            txtBaitKey3.Text = SettingsController.Instance.HotKeys.BaitKey3;
            txtBaitKey4.Text = SettingsController.Instance.HotKeys.BaitKey4;
            txtBaitKey5.Text = SettingsController.Instance.HotKeys.BaitKey5;
            txtBaitKey6.Text = SettingsController.Instance.HotKeys.BaitKey6;
            txtBaitKey7.Text = SettingsController.Instance.HotKeys.BaitKey7;
            cbAutoBait.Checked = SettingsController.Instance.AutoBait;
            cbCycleThroughBaitList.Checked = SettingsController.Instance.CycleThroughBaitList;

            //Times
            txtLureTime.Text = SettingsController.Instance.LureTime.ToString();
            txtHearthTime.Text = SettingsController.Instance.HearthTime.ToString();
            txtRaftTime.Text = SettingsController.Instance.RaftTime.ToString();
            txtCharmTime.Text = SettingsController.Instance.CharmTime.ToString();
            txtBaitTime.Text = SettingsController.Instance.BaitTime.ToString();

            /// Anti Afk
            cbAntiAfk.Checked = SettingsController.Instance.AntiAfk;
            txtAntiAfkTimer.Text = SettingsController.Instance.AntiAfkTime.ToString();
            cmbMovements.SelectedIndex = (int)SettingsController.Instance.AntiAfkMoves;

            /// Languages
            chkTxt2speech.Checked = SettingsController.Instance.Txt2speech;
            LoadLanguages();


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            m_mainForm.ReloadHotKeys();
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some changes may start working only after application restart."); //Needs translation support
            /// General
            SettingsController.Instance.CastingDelayLow = int.Parse(txtCastDelayLow.Text);
            SettingsController.Instance.LootingDelayLow = int.Parse(txtLootingDelayLow.Text);
            SettingsController.Instance.Scan.FishWaitLow = int.Parse(txtFishWaitLow.Text);
            SettingsController.Instance.CastingDelayHigh = int.Parse(txtCastDelayHigh.Text);
            SettingsController.Instance.LootingDelayHigh = int.Parse(txtLootingDelayHigh.Text);
            SettingsController.Instance.Scan.FishWaitHigh = int.Parse(txtFishWaitHigh.Text);

            /// Finding the Cursor
            SettingsController.Instance.Scan.ScanningDelayLow = int.Parse(txtDelayLow.Text);
            SettingsController.Instance.Scan.ScanningDelayHigh = int.Parse(txtDelayHigh.Text);
            SettingsController.Instance.Scan.ScanningStepsLow = int.Parse(txtScanStepsLow.Text);
            SettingsController.Instance.Scan.ScanningStepsHigh = int.Parse(txtScanStepsHigh.Text);
            SettingsController.Instance.Scan.ScanningRetries = int.Parse(txtRetries.Text);
            SettingsController.Instance.Scan.CheckCursor = cmbCompareIcon.Checked;
            SettingsController.Instance.AlternativeRoute = cmbAlternativeRoute.Checked;
            SettingsController.Instance.Scan.CustomScanArea = customAreaCheckbox.Checked;
            SettingsController.Instance.Scan.CursorCaptureHotKey = ccHotKey.Text;
            

            /// Hearing the Fish
            SettingsController.Instance.SplashLimit = int.Parse(txtSplash.Text);
            SettingsController.Instance.AudioDevice = (string)cmbAudio.SelectedValue;
            SettingsController.Instance.AverageSound = cbSoundAvg.Checked;

            /// Premium Settings

            SettingsController.Instance.ProcName = txtProcName.Text;
            SettingsController.Instance.AutoLure = cbAutoLure.Checked;
            SettingsController.Instance.SwapGear = cbHearth.Checked;
            SettingsController.Instance.UseAltKey = cbAlt.Checked;
            SettingsController.Instance.RightClickCast = cbDblRclickCast.Checked;

            SettingsController.Instance.HotKeys.FishKey = txtFishKey.Text;
            SettingsController.Instance.HotKeys.LureKey = txtLureKey.Text;
            SettingsController.Instance.HotKeys.HearthKey = txtHearthKey.Text;
            SettingsController.Instance.AutoHearth = cbHearth.Checked;

            // MoP Premium (Angler's Raft & Ancient Pandaren Fishing Charm)
            SettingsController.Instance.HotKeys.CharmKey = txtCharmKey.Text;
            SettingsController.Instance.HotKeys.RaftKey = txtRaftKey.Text;
            SettingsController.Instance.AutoRaft = cbApplyRaft.Checked;
            SettingsController.Instance.AutoCharm = cbApplyCharm.Checked;
            SettingsController.Instance.ShiftLoot = cbShiftLoot.Checked;

            // WoD Premium (Bait)
            SettingsController.Instance.HotKeys.BaitKey1 = txtBaitKey1.Text;
            SettingsController.Instance.HotKeys.BaitKey2 = txtBaitKey2.Text;
            SettingsController.Instance.HotKeys.BaitKey3 = txtBaitKey3.Text;
            SettingsController.Instance.HotKeys.BaitKey4 = txtBaitKey4.Text;
            SettingsController.Instance.HotKeys.BaitKey5 = txtBaitKey5.Text;
            SettingsController.Instance.HotKeys.BaitKey6 = txtBaitKey6.Text;
            SettingsController.Instance.HotKeys.BaitKey7 = txtBaitKey7.Text;
            SettingsController.Instance.AutoBait = cbAutoBait.Checked;
            SettingsController.Instance.CycleThroughBaitList = cbCycleThroughBaitList.Checked;

            SaveHotKeys();

            //Times
            SettingsController.Instance.LureTime = int.Parse(txtLureTime.Text);
            SettingsController.Instance.HearthTime = int.Parse(txtHearthTime.Text);
            SettingsController.Instance.RaftTime = int.Parse(txtRaftTime.Text);
            SettingsController.Instance.CharmTime = int.Parse(txtCharmTime.Text);
            SettingsController.Instance.BaitTime = int.Parse(txtBaitTime.Text);

            /// Anti Afk
            SettingsController.Instance.AntiAfk = cbAntiAfk.Checked;
            SettingsController.Instance.AntiAfkTime = int.Parse(txtAntiAfkTimer.Text);
            SettingsController.Instance.AntiAfkMoves = (AntiAfkMoves)cmbMovements.SelectedIndex;

            /// Language
            SettingsController.Instance.Txt2speech = chkTxt2speech.Checked;
            if ((string)cmbLanguage.SelectedItem != SettingsController.Instance.Language)
            {
                SettingsController.Instance.Language = (string)cmbLanguage.SelectedItem;
                SettingsController.Save();

                MessageBox.Show(Translate.GetTranslate("frmSettings", "LABEL_LANGUAGE_CHANGE"),
                                Translate.GetTranslate("frmSettings", "TITLE_LANGUAGE_CHANGE"));

                Thread.Sleep(1000);
                Application.Restart();
            }
            else
            {
                SettingsController.Save();
                this.Close();
            }

        }

        private void tabSettings_SelectedIndexChanged(Object sender, EventArgs e)
        {
            tmeAudio.Enabled = (tabSettings.SelectedIndex == 2);
        }

        private void LoadAudioDevices()
        {
            List<Tuple<string, string>> audioDevices = new List<Tuple<string, string>>();
            audioDevices.Add(new Tuple<string, string>("Default", ""));

            try
            {
                MMDeviceEnumerator sndDevEnum = new MMDeviceEnumerator();
                MMDeviceCollection audioCollection = sndDevEnum.EnumerateAudioEndPoints(EDataFlow.eRender, EDeviceState.DEVICE_STATEMASK_ALL);

                // Try to add each audio endpoint to our collection
                for (int i = 0; i < audioCollection.Count; ++i)
                {
                    MMDevice device = audioCollection[i];
                    audioDevices.Add(new Tuple<string, string>(device.FriendlyName, device.ID));
                }
            }
            catch (Exception)
            { }

            // Setup the display
            cmbAudio.Items.Clear();
            cmbAudio.DisplayMember = "Item1";
            cmbAudio.ValueMember = "Item2";
            cmbAudio.DataSource = audioDevices;
            cmbAudio.SelectedValue = SettingsController.Instance.AudioDevice;
        }

        private void LoadLanguages()
        {
            string[] languageFiles = Directory.GetFiles("./Resources/", "*.xml");
            cmbLanguage.Items.Clear();

            foreach (string file in languageFiles)
            {
                string tmpFile = file.Substring(12); // Remove the "./Resources/" part
                tmpFile = tmpFile.Substring(0, tmpFile.Length - 4); // Remove the  ".xml" part
                cmbLanguage.Items.Add(tmpFile);
            }

            cmbLanguage.SelectedItem = SettingsController.Instance.Language;
        }

        private void LoadAntiAfkMovements()
        {
            cmbMovements.Items.Clear();

            foreach (string movements in Translate.GetTranslates("frmSettings", "CMB_ANTIAFK_MOVE"))
                cmbMovements.Items.Add(movements);
        }

        private void tmeAudio_Tick(Object sender, EventArgs e)
        {
            if (m_SndDevice != null)
            {
                try
                {
                    int currentVolumnLevel = (int)(m_SndDevice.AudioMeterInformation.MasterPeakValue * 100);
                    pgbSoundLevel.Value = currentVolumnLevel;
                    lblAudioLevel.Text = currentVolumnLevel.ToString();
                }
                catch (Exception)
                {
                    pgbSoundLevel.Value = 0;
                    lblAudioLevel.Text = "0";
                }
            }
            else
            {
                pgbSoundLevel.Value = 0;
                lblAudioLevel.Text = "0";
            }
        }

        private void cmbAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MMDeviceEnumerator sndDevEnum = new MMDeviceEnumerator();

            if (!string.IsNullOrEmpty((string)cmbAudio.SelectedValue))
                m_SndDevice = sndDevEnum.GetDevice((string)cmbAudio.SelectedValue);
            else
                m_SndDevice = sndDevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
        }

        private void LoadHotKeys()
        {
            _keyStroke = SettingsController.Instance.HotKeys.StartStopKey;
            txtHotKey.Text = SettingsController.Instance.HotKeys.StartStopKey;
            m_mainForm.UnregisterHotKeys();
        }

        private void SaveHotKeys()
        {
            SettingsController.Instance.HotKeys.StartStopKey = _keyStroke;
            m_mainForm.ReloadHotKeys();
        }

        private void txtHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            _keyStroke = e.KeyData.ToKeyStroke();
            txtHotKey.Text = _keyStroke;
        }

        private void customAreaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (customAreaCheckbox.Checked)
            {
                btnSetScanArea.Enabled = true;
                txtMinXY.Enabled = true;
                txtMaxXY.Enabled = true;
            }
            else
            {
                btnSetScanArea.Enabled = false;
                txtMinXY.Enabled = false;
                txtMaxXY.Enabled = false;
            }
        }

        private void btnSetScanArea_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translate.GetTranslate("frmSettings", "SCAN_MESSAGE"), Translate.GetTranslate("frmSettings", "SCAN_TITLE"), MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmOverlay.GetForm(this).Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translate.GetTranslate("frmSettings", "RESET_MESSAGE"), Translate.GetTranslate("frmSettings", "RESET_TITLE"), MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SettingsController.Reset();
                Application.Restart();
            }
        }
    }
}
