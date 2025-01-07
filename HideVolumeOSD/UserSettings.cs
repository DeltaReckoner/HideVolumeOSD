using System;
using System.Drawing;
using System.Windows.Forms;

namespace HideVolumeOSD
{
    public partial class UserSettings : Form
    {
        private static bool IsActive;
        private static bool HotkeyBoxFocused;

        public UserSettings()
        {
            InitializeComponent();

            checkBoxSystemTrayVolume.Checked = Settings.Default.VolumeInSystemTray;
            trackBarDelay.Value = Settings.Default.VolumeHideDelay;
            SetDisplaySizeChecked(Settings.Default.VolumeDisplaySize);
            checkBoxClockPos.Checked = Settings.Default.VolumeDisplayNearClock;
            radioButtonLight.Checked = Settings.Default.VolumeDisplayLight;
            radioButtonDark.Checked = !Settings.Default.VolumeDisplayLight;
            radioButtonMinimize.Checked = Settings.Default.OSDHideType == 0 ? true : false;
            radioButtonClose.Checked = Settings.Default.OSDHideType == 1 ? true : false;
            textBoxOffset.Text = Settings.Default.VolumeDisplayOffset.ToString();
            checkBoxToggleHotkey.Checked = Settings.Default.VolumeDisplayHotkeyEnabled;
            textBoxToggleHotkey.Text = Settings.Default.VolumeDisplayHotkey;
            KeyPreview = true;
        }

        // Used to ensure the user settings form is open
        public static bool GetFormActive()
        {
            return IsActive;
        }

        // Used to ensure the hotkey is read only when the text box related to it is in focus
        public static bool GetHotboxKeyFocused()
        {
            return HotkeyBoxFocused;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible)
            {
                Rectangle rect = Screen.FromHandle(this.Handle).Bounds;
                Location = new Point(rect.Width - this.Width - 64, rect.Height - this.Height - 96);
            }
        }


        private void UserSettings_Load(object sender, EventArgs e)
        {
            IsActive = true;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Settings.Default.Save();
            IsActive = false;
        }

        private void trackBarDelay_Scroll(object sender, EventArgs e)
        {
            int value = (sender as TrackBar).Value;
            double indexDbl = (value * 1.0) / trackBarDelay.TickFrequency;
            int index = Convert.ToInt32(Math.Round(indexDbl));

            trackBarDelay.Value = trackBarDelay.TickFrequency * index;

            labelDelay.Text = trackBarDelay.Value.ToString() + " ms";

            Settings.Default.VolumeHideDelay = trackBarDelay.Value;
        }

        private void checkBoxSystemTrayVolume_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.VolumeInSystemTray = checkBoxSystemTrayVolume.Checked;
        }
    
        private void buttonClose_Click(object sender, EventArgs e)
        {
            IsActive = false;
            Close();
        }

        private void SetDisplaySizeChecked(int value)
        {
            switch (value)
            {
                case 0:

                    radioButtonSmall.Checked = true;
                    break;

                case 1:

                    radioButtonMedium.Checked = true;
                    break;

                  
                case 2:
                    radioButtonBig.Checked = true;
                    break;
            }

            Settings.Default.VolumeDisplaySize = value;
            Settings.Default.Save();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked)
            {
                SetDisplaySizeChecked(0);
            }
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMedium.Checked)
            {
                SetDisplaySizeChecked(1);
            }
        }

        private void radioButtonBig_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBig.Checked)
            {
                SetDisplaySizeChecked(2);
            }
        }

        private void checkBoxClockPos_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.VolumeDisplayNearClock = checkBoxClockPos.Checked;
            Settings.Default.Save();
        }


        private void checkBoxToggleHotkey_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.VolumeDisplayHotkeyEnabled = checkBoxToggleHotkey.Checked;
            textBoxToggleHotkey.Enabled = checkBoxToggleHotkey.Checked;
            Settings.Default.Save();
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.VolumeDisplayLight = radioButtonLight.Checked;
            Settings.Default.Save();
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.VolumeDisplayLight = radioButtonLight.Checked;
            Settings.Default.Save();
        }

        private void textBoxOffset_TextChanged(object sender, EventArgs e)
        {
            // Used if the user selects all text in the text box then erases the contents
            bool validNumber = int.TryParse(textBoxOffset.Text, out int value);
            if (validNumber)
            {
                Settings.Default.VolumeDisplayOffset = int.Parse(textBoxOffset.Text);
            }
            else
            {
                Settings.Default.VolumeDisplayOffset = 0;
                textBoxOffset.Text = "0";
            }
        }

        private void textBoxOffset_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Used if the backspace key was entered and there is less than or equal to 1 character in the text box
            Keys key = (Keys)Keys.Parse(typeof(Keys), ((int)e.KeyChar).ToString());
            if (key == Keys.Back && textBoxOffset.Text.Length <= 1)
            {
                e.Handled = true;
                textBoxOffset.Text = "0";
            }
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBoxToggleHotkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxToggleHotkey_Enter(object sender, EventArgs e)
        {
            HotkeyBoxFocused = true;
        }

        private void textBoxToggleHotkey_Leave(object sender, EventArgs e)
        {
            HotkeyBoxFocused = false;
        }

        private void textBoxToggleHotkey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            textBoxToggleHotkey.Text = e.KeyData.ToString();
            Settings.Default.VolumeDisplayHotkey = e.KeyData.ToString();
            Settings.Default.Save();
        }

        private void radioButtonMinimize_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OSDHideType = 0;
            Settings.Default.Save();
        }

        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OSDHideType = 1;
            Settings.Default.Save();
        }
    }
}
