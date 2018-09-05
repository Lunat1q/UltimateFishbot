using System;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateFishBot.Helpers;
using UltimateFishBot.Properties;
using UltimateFishBot.Servicing;
using UltimateFishBot.Settings;

namespace UltimateFishBot.Forms
{
    public partial class frmMain : Form, IManagerEventHandler
    {
        public frmMain()
        {
            InitializeComponent();

            _manager = new Manager(this, new Progress<string>(text =>
            {
                lblStatus.Text = text;
            }));
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Text      = Translate.GetTranslate("frmMain", "BUTTON_START");
            btnStop.Text       = Translate.GetTranslate("frmMain", "BUTTON_STOP");
            btnSettings.Text   = Translate.GetTranslate("frmMain", "BUTTON_SETTINGS");
            btnStatistics.Text = Translate.GetTranslate("frmMain", "BUTTON_STATISTICS");
            btnHowTo.Text      = Translate.GetTranslate("frmMain", "BUTTON_HTU");
            btnClose.Text      = Translate.GetTranslate("frmMain", "BUTTON_EXIT");
            btnAbout.Text      = Translate.GetTranslate("frmMain", "BUTTON_ABOUT");
            lblStatus.Text     = Translate.GetTranslate("frmMain", "LABEL_STOPPED");
            //this.Text          = "UltimateFishBot - v " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            /* Hide ? */
            ReloadHotKeys();
            await CheckStatus();
        }

        internal void ReloadHotKeys()
        {
            HotKeyController.ReloadHotkeys(SettingsController.Instance, _manager);
        }

        internal void UnregisterHotKeys()
        {
            HotKeyController.UnregisterHotKeys();
        }

        private async Task CheckStatus()
        {
            lblWarn.Text = Translate.GetTranslate("frmMain", "LABEL_CHECKING_STATUS");
            lblWarn.Parent = PictureBox1;

            try
            {
                string result = await (new WebClient().DownloadStringTaskAsync("http://www.robpaulson.com/fishbot/status.txt"));
                if (result.ToLower().Trim() != "safe")
                {
                    lblWarn.Text      = Translate.GetTranslate("frmMain", "LABEL_NO_LONGER_SAFE");
                    lblWarn.ForeColor = Color.Red;
                    lblWarn.BackColor = Color.Black;
                }
                else
                {
                    lblWarn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblWarn.Text = Translate.GetTranslate("frmMain", "LABEL_COULD_NOT_CHECK_STATUS") + ex.Message;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await _manager.StartOrResumeOrPause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _manager.Stop();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings.GetForm(this).Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            frmStats.GetForm(_manager).Show();
        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            frmDirections.GetForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKeys();
        }

        private readonly Manager _manager;
        private static int WM_HOTKEY = 0x0312;


        private void btnAbout_Click(object sender, EventArgs e)
        {
            about.GetForm.Show();
        }

        private void ToggleButtonEnabledRunning()
        {
            btnSettings.Enabled = false;
            btnStop.Enabled     = true;
        }

        private void ToggleButtonEnabledNotRunning()
        {
            btnSettings.Enabled = true;
            btnStop.Enabled     = false;
        }

        public void Started()
        {
            ToggleButtonEnabledRunning();
            btnStart.Text   = Translate.GetTranslate("frmMain", "BUTTON_PAUSE");
            lblStatus.Image = Resources.online;
        }

        public void Stopped()
        {
            ToggleButtonEnabledNotRunning();
            btnStart.Text   = Translate.GetTranslate("frmMain", "BUTTON_START");
            lblStatus.Image = Resources.offline;
        }

        public void Resumed()
        {
            ToggleButtonEnabledRunning();
            btnStart.Text   = Translate.GetTranslate("frmMain", "BUTTON_PAUSE");
            lblStatus.Image = Resources.online;
        }

        public void Paused()
        {
            btnSettings.Enabled = true;
            btnStart.Text       = Translate.GetTranslate("frmMain", "BUTTON_RESUME");
            lblStatus.Image     = Resources.online;
        }
    }
}
