
using System;
using System.Windows.Forms;
using HideVolumeOSD.Properties;

namespace HideVolumeOSD
{
    /// <summary>
    /// 
    /// </summary>
    public class ContextMenus
	{
		/// <summary>
		/// Is the About box displayed?
		/// </summary>
		bool isAboutLoaded = false;
		bool isSettingsLoaded = false;

		HideVolumeOSDLib hideVolumeOSDLib;
		ToolStripMenuItem switchMenu = null;		

		public ContextMenus(NotifyIcon ni)
		{
			hideVolumeOSDLib = new HideVolumeOSDLib(ni);
		}

		/// <summary>
		/// Creates this instance.
		/// </summary>
		/// <returns>ContextMenuStrip</returns>
		public ContextMenuStrip Create()
		{
			hideVolumeOSDLib.Init();

			// Add the default menu options.
			ContextMenuStrip menu = new ContextMenuStrip();

			ToolStripMenuItem item;
			ToolStripSeparator sep;			

			ImageList il = new ImageList();

			il.Images.Add(Resources.Switch);
			il.Images.Add(Resources.SwitchDisabled);
			il.Images.Add(Resources.About);
			il.Images.Add(Resources.Exit);
			
			menu.ImageList = il;

			// Hide OSD
			item = new ToolStripMenuItem();			
			
			if (!Settings.Default.HideOSD)
			{
				item.Text = "Hide Volume OSD";
				item.ImageIndex = 1;
			}
			else
			{
				item.Text = "Show Volume OSD";
				item.ImageIndex = 0;
			}

			item.Click += new EventHandler(Hide_Click);
			item.CheckOnClick = true;
			item.Checked = Settings.Default.HideOSD;

			menu.Items.Add(item);
			switchMenu = item;

			// About
			item = new ToolStripMenuItem();
			item.Text = "Settings...";
			item.Click += new EventHandler(Settings_Click);
			//item.ImageIndex = 2;
			menu.Items.Add(item);

			// About
			item = new ToolStripMenuItem();
			item.Text = "About...";
			item.Click += new EventHandler(About_Click);
			item.ImageIndex = 2;
			menu.Items.Add(item);

			// Separator
			sep = new ToolStripSeparator();
			menu.Items.Add(sep);

			// Exit
			item = new ToolStripMenuItem();
			item.Text = "Exit";
			item.Click += new System.EventHandler(Exit_Click);
			item.ImageIndex = 3;
			menu.Items.Add(item);

			//DarkModeHelper.SwitchMenuTheme(menu);

			return menu;
		}

		public void Switch()
		{
			Hide_Click(this, new EventArgs());
		}

		void Hide_Click(object sender, EventArgs e)
		{
			if (!Settings.Default.HideOSD)
			{
				if (Settings.Default.OSDHideType == 0)
				{
					hideVolumeOSDLib.HideOSD();
				}
				else
				{
					hideVolumeOSDLib.CloseOSD();
				}
				Settings.Default.HideOSD = true;
				switchMenu.ImageIndex = 0;
				switchMenu.Text = "Show Volume OSD";
			}
			else
			{
				hideVolumeOSDLib.ShowOSD();
				Settings.Default.HideOSD = false;
				switchMenu.Image = Resources.SwitchDisabled;
				switchMenu.ImageIndex = 1;
				switchMenu.Text = "Hide Volume OSD";
			}
			
			Settings.Default.Save();
		}

		/// <summary>
		/// Handles the Click event of the UserSettings control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void Settings_Click(object sender, EventArgs e)
		{
			if (!isSettingsLoaded)
			{
				isSettingsLoaded = true;
				new UserSettings().ShowDialog();
				isSettingsLoaded = false;
			}
		}

		/// <summary>
		/// Handles the Click event of the About control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void About_Click(object sender, EventArgs e)
		{
			if (!isAboutLoaded)
			{
				isAboutLoaded = true;
				new AboutBox().ShowDialog();
				isAboutLoaded = false;
			}
		}

		/// <summary>
		/// Processes a menu item.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}