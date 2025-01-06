
namespace HideVolumeOSD
{
    partial class UserSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxToggleHotkey = new System.Windows.Forms.TextBox();
            this.checkBoxToggleHotkey = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonBig = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.checkBoxClockPos = new System.Windows.Forms.CheckBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSystemTrayVolume = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxToggleHotkey);
            this.groupBox1.Controls.Add(this.checkBoxToggleHotkey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxOffset);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.checkBoxClockPos);
            this.groupBox1.Controls.Add(this.labelDelay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarDelay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxSystemTrayVolume);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sytem tray volume display";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "key";
            // 
            // textBoxToggleHotkey
            // 
            this.textBoxToggleHotkey.Enabled = false;
            this.textBoxToggleHotkey.Location = new System.Drawing.Point(34, 270);
            this.textBoxToggleHotkey.Name = "textBoxToggleHotkey";
            this.textBoxToggleHotkey.Size = new System.Drawing.Size(48, 20);
            this.textBoxToggleHotkey.TabIndex = 16;
            this.textBoxToggleHotkey.Enter += new System.EventHandler(this.textBoxToggleHotkey_Enter);
            this.textBoxToggleHotkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxToggleHotkey_KeyPress);
            this.textBoxToggleHotkey.Leave += new System.EventHandler(this.textBoxToggleHotkey_Leave);
            this.textBoxToggleHotkey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBoxToggleHotkey_PreviewKeyDown);
            // 
            // checkBoxToggleHotkey
            // 
            this.checkBoxToggleHotkey.AutoSize = true;
            this.checkBoxToggleHotkey.Location = new System.Drawing.Point(11, 247);
            this.checkBoxToggleHotkey.Name = "checkBoxToggleHotkey";
            this.checkBoxToggleHotkey.Size = new System.Drawing.Size(94, 17);
            this.checkBoxToggleHotkey.TabIndex = 15;
            this.checkBoxToggleHotkey.Text = "Toggle hotkey";
            this.checkBoxToggleHotkey.UseVisualStyleBackColor = true;
            this.checkBoxToggleHotkey.CheckedChanged += new System.EventHandler(this.checkBoxToggleHotkey_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "pixel offset from right";
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(34, 192);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(48, 20);
            this.textBoxOffset.TabIndex = 13;
            this.textBoxOffset.TextChanged += new System.EventHandler(this.textBoxOffset_TextChanged);
            this.textBoxOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOffset_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonBig);
            this.groupBox3.Controls.Add(this.radioButtonMedium);
            this.groupBox3.Controls.Add(this.radioButtonSmall);
            this.groupBox3.Location = new System.Drawing.Point(291, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(102, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size of display";
            // 
            // radioButtonBig
            // 
            this.radioButtonBig.AutoSize = true;
            this.radioButtonBig.Location = new System.Drawing.Point(17, 70);
            this.radioButtonBig.Name = "radioButtonBig";
            this.radioButtonBig.Size = new System.Drawing.Size(40, 17);
            this.radioButtonBig.TabIndex = 12;
            this.radioButtonBig.TabStop = true;
            this.radioButtonBig.Text = "Big";
            this.radioButtonBig.UseVisualStyleBackColor = true;
            this.radioButtonBig.CheckedChanged += new System.EventHandler(this.radioButtonBig_CheckedChanged);
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(17, 47);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMedium.TabIndex = 11;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            this.radioButtonMedium.CheckedChanged += new System.EventHandler(this.radioButtonMedium_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(17, 24);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSmall.TabIndex = 10;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDark);
            this.groupBox2.Controls.Add(this.radioButtonLight);
            this.groupBox2.Location = new System.Drawing.Point(291, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 80);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display style";
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.Location = new System.Drawing.Point(17, 46);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDark.TabIndex = 9;
            this.radioButtonDark.TabStop = true;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.radioButtonDark_CheckedChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Location = new System.Drawing.Point(17, 23);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(48, 17);
            this.radioButtonLight.TabIndex = 8;
            this.radioButtonLight.TabStop = true;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.radioButtonLight_CheckedChanged);
            // 
            // checkBoxClockPos
            // 
            this.checkBoxClockPos.AutoSize = true;
            this.checkBoxClockPos.Location = new System.Drawing.Point(11, 169);
            this.checkBoxClockPos.Name = "checkBoxClockPos";
            this.checkBoxClockPos.Size = new System.Drawing.Size(103, 17);
            this.checkBoxClockPos.TabIndex = 10;
            this.checkBoxClockPos.Text = "Show near Time";
            this.checkBoxClockPos.UseVisualStyleBackColor = true;
            this.checkBoxClockPos.CheckedChanged += new System.EventHandler(this.checkBoxClockPos_CheckedChanged);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(218, 61);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(41, 13);
            this.labelDelay.TabIndex = 6;
            this.labelDelay.Text = "600 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2000 ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "200 ms";
            // 
            // trackBarDelay
            // 
            this.trackBarDelay.AutoSize = false;
            this.trackBarDelay.LargeChange = 400;
            this.trackBarDelay.Location = new System.Drawing.Point(34, 89);
            this.trackBarDelay.Maximum = 2000;
            this.trackBarDelay.Minimum = 200;
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(179, 45);
            this.trackBarDelay.SmallChange = 200;
            this.trackBarDelay.TabIndex = 3;
            this.trackBarDelay.TickFrequency = 200;
            this.trackBarDelay.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDelay.Value = 600;
            this.trackBarDelay.Scroll += new System.EventHandler(this.trackBarDelay_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Display time after volume key release:";
            // 
            // checkBoxSystemTrayVolume
            // 
            this.checkBoxSystemTrayVolume.AutoSize = true;
            this.checkBoxSystemTrayVolume.Location = new System.Drawing.Point(11, 29);
            this.checkBoxSystemTrayVolume.Name = "checkBoxSystemTrayVolume";
            this.checkBoxSystemTrayVolume.Size = new System.Drawing.Size(156, 17);
            this.checkBoxSystemTrayVolume.TabIndex = 0;
            this.checkBoxSystemTrayVolume.Text = "Show volume in system tray";
            this.checkBoxSystemTrayVolume.UseVisualStyleBackColor = true;
            this.checkBoxSystemTrayVolume.CheckedChanged += new System.EventHandler(this.checkBoxSystemTrayVolume_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(344, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 358);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSystemTrayVolume;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxClockPos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonBig;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDark;
        private System.Windows.Forms.RadioButton radioButtonLight;
        private System.Windows.Forms.TextBox textBoxOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBoxToggleHotkey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxToggleHotkey;
    }
}