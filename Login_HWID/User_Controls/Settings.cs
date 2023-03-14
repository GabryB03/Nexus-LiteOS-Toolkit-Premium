using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000069 RID: 105
	public class Settings : UserControl
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0016D6F0 File Offset: 0x0016B8F0
		public static Settings Instance
		{
			get
			{
				if (Settings._instace == null)
				{
					Settings._instace = new Settings();
				}
				return Settings._instace;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0016D718 File Offset: 0x0016B918
		public Settings()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0016D770 File Offset: 0x0016B970
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				object obj;
				if (num == 4)
				{
					object obj2;
					obj = obj2;
					num = 5;
				}
				if (num != 8)
				{
					goto IL_2B;
				}
				string text;
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_2B;
				}
				goto IL_BB;
				IL_CA:
				if (num != 13)
				{
					if (num == 11)
					{
						goto IL_118;
					}
					IL_127:
					if (num == 10)
					{
						goto IL_181;
					}
					if (num == 9)
					{
						if (text == "Accent Color")
						{
							goto IL_134;
						}
						num = 10;
					}
					if (num == 7)
					{
						if (text == "Xmas")
						{
							goto IL_118;
						}
						num = 8;
					}
					if (num == 6)
					{
						if (text == null)
						{
							goto IL_181;
						}
						num = 7;
					}
					if (num == 5)
					{
						text = obj as string;
						num = 6;
					}
					if (num == 3)
					{
						object value;
						object obj2 = value;
						num = 4;
					}
					if (num == 2)
					{
						RegistryKey registryKey;
						object value = registryKey.GetValue("Theme");
						num = 3;
					}
					if (num == 1)
					{
						RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\");
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 22)
					{
						break;
					}
					continue;
					IL_118:
					this.Xmas_theme();
					num = 12;
					goto IL_127;
				}
				break;
				IL_143:
				if (num == 15)
				{
					this.comboBox2.SelectedIndex = 2;
					num = 16;
				}
				if (num == 14)
				{
					goto IL_BB;
				}
				goto IL_CA;
				IL_19A:
				if (num == 21)
				{
					break;
				}
				if (num == 19)
				{
					break;
				}
				if (num == 18)
				{
					this.comboBox2.SelectedIndex = 0;
					num = 19;
				}
				if (num == 17)
				{
					goto IL_134;
				}
				goto IL_143;
				IL_2B:
				if (num == 12)
				{
					this.comboBox2.SelectedIndex = 3;
					num = 13;
				}
				if (num == 16)
				{
					break;
				}
				if (num == 20)
				{
					goto IL_181;
				}
				goto IL_19A;
				IL_BB:
				this.Halloween();
				num = 15;
				goto IL_CA;
				IL_134:
				this.AccentColor();
				num = 18;
				goto IL_143;
				IL_181:
				this.comboBox2.SelectedIndex = 1;
				num = 21;
				goto IL_19A;
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0016D9D0 File Offset: 0x0016BBD0
		private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (e.Category == UserPreferenceCategory.General)
					{
						goto IL_58;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag = e.Category == UserPreferenceCategory.VisualStyle;
			goto IL_5D;
			IL_58:
			flag = true;
			IL_5D:
			if (flag)
			{
				this.LoadTheme();
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0016DA48 File Offset: 0x0016BC48
		private void Form_Disposed(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					SystemEvents.UserPreferenceChanged -= this.UserPreferenceChanged;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0016DAAC File Offset: 0x0016BCAC
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.auto.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 3)
				{
					this.auto.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 4;
				}
				if (num == 2)
				{
					this.tray.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.tray.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0016DBC4 File Offset: 0x0016BDC4
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 4)
				{
					this.auto.CheckedState.FillColor = accentColor;
					num = 5;
				}
				if (num == 5)
				{
					this.auto.CheckedState.BorderColor = accentColor;
					num = 6;
				}
				if (num == 3)
				{
					this.tray.CheckedState.BorderColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.tray.CheckedState.FillColor = accentColor;
					num = 3;
				}
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0016DCE0 File Offset: 0x0016BEE0
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.auto.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 3)
				{
					this.auto.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 2)
				{
					this.tray.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.tray.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0016DDF8 File Offset: 0x0016BFF8
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 5;
				}
				RegistryKey registryKey;
				bool flag2;
				if (num == 8)
				{
					flag2 = registryKey != null;
					num = 9;
				}
				FolderBrowserDialog folderBrowserDialog;
				if (num == 10)
				{
					registryKey.SetValue("Default Downloads Location", folderBrowserDialog.SelectedPath);
					num = 11;
				}
				if (num == 9)
				{
					if (!flag2)
					{
						break;
					}
					num = 10;
				}
				if (num == 7)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 8;
				}
				if (num == 6)
				{
					Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
					num = 7;
				}
				if (num == 5)
				{
					this.dl_txtbox.Text = folderBrowserDialog.SelectedPath;
					num = 6;
				}
				if (num == 3)
				{
					DialogResult dialogResult;
					bool flag = dialogResult == DialogResult.OK;
					num = 4;
				}
				if (num == 2)
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					num = 3;
				}
				if (num == 1)
				{
					folderBrowserDialog = new FolderBrowserDialog();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0016DF3C File Offset: 0x0016C13C
		private void siticoneButton4_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 5;
				}
				RegistryKey registryKey;
				bool flag2;
				if (num == 8)
				{
					flag2 = registryKey != null;
					num = 9;
				}
				FolderBrowserDialog folderBrowserDialog;
				if (num == 10)
				{
					registryKey.SetValue("Default Packages Location", folderBrowserDialog.SelectedPath);
					num = 11;
				}
				if (num == 9)
				{
					if (!flag2)
					{
						break;
					}
					num = 10;
				}
				if (num == 7)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 8;
				}
				if (num == 6)
				{
					Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
					num = 7;
				}
				if (num == 5)
				{
					this.pkg_txtbox.Text = folderBrowserDialog.SelectedPath;
					num = 6;
				}
				if (num == 3)
				{
					DialogResult dialogResult;
					bool flag = dialogResult == DialogResult.OK;
					num = 4;
				}
				if (num == 2)
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					num = 3;
				}
				if (num == 1)
				{
					folderBrowserDialog = new FolderBrowserDialog();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0016E080 File Offset: 0x0016C280
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 4)
				{
					registryKey.SetValue("Default Downloads Location", "C:\\Nexus_LiteOS_Toolkit\\Downoloads");
					num = 5;
				}
				if (num == 5)
				{
					goto IL_1C;
				}
				IL_38:
				if (num == 3)
				{
					bool flag;
					if (!flag)
					{
						goto IL_1C;
					}
					num = 4;
				}
				if (num == 2)
				{
					bool flag = registryKey != null;
					num = 3;
				}
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 6)
				{
					continue;
				}
				break;
				IL_1C:
				this.dl_txtbox.Text = "C:\\Nexus_LiteOS_Toolkit\\Downloads";
				num = 6;
				goto IL_38;
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0016E180 File Offset: 0x0016C380
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 4)
				{
					registryKey.SetValue("Default Packages Location", "C:\\Nexus_LiteOS_Toolkit\\Packages");
					num = 5;
				}
				if (num == 5)
				{
					goto IL_1C;
				}
				IL_38:
				if (num == 3)
				{
					bool flag;
					if (!flag)
					{
						goto IL_1C;
					}
					num = 4;
				}
				if (num == 2)
				{
					bool flag = registryKey != null;
					num = 3;
				}
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 6)
				{
					continue;
				}
				break;
				IL_1C:
				this.pkg_txtbox.Text = "C:\\Nexus_LiteOS_Toolkit\\Packages";
				num = 6;
				goto IL_38;
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0016E280 File Offset: 0x0016C480
		private void settings_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num != 4)
				{
					goto IL_0B;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_0B;
				}
				goto IL_13F;
				IL_153:
				object value;
				if (num == 5)
				{
					this.dl_txtbox.Text = value.ToString();
					num = 6;
				}
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 2)
				{
					value = registryKey.GetValue("Default Downloads Location");
					num = 3;
				}
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					break;
				}
				continue;
				IL_0B:
				if (num != 8)
				{
					goto IL_21;
				}
				bool flag2;
				if (flag2)
				{
					num = 9;
					goto IL_21;
				}
				goto IL_E6;
				IL_FA:
				object value2;
				if (num == 9)
				{
					this.pkg_txtbox.Text = value2.ToString();
					num = 10;
				}
				if (num == 7)
				{
					flag2 = value2 != null;
					num = 8;
				}
				if (num == 6)
				{
					goto IL_13F;
				}
				goto IL_153;
				IL_21:
				if (num != 12)
				{
					goto IL_34;
				}
				bool flag3;
				if (flag3)
				{
					num = 13;
					goto IL_34;
				}
				goto IL_8F;
				IL_A3:
				if (num == 13)
				{
					this.tray.CheckState = CheckState.Checked;
					num = 14;
				}
				object value3;
				if (num == 11)
				{
					flag3 = value3 != null;
					num = 12;
				}
				if (num == 10)
				{
					goto IL_E6;
				}
				goto IL_FA;
				IL_34:
				if (num == 16)
				{
					bool flag4;
					if (!flag4)
					{
						break;
					}
					num = 17;
				}
				if (num == 17)
				{
					this.auto.CheckState = CheckState.Checked;
					num = 18;
				}
				object value4;
				if (num == 15)
				{
					bool flag4 = value4 != null;
					num = 16;
				}
				if (num != 14)
				{
					goto IL_A3;
				}
				IL_8F:
				value4 = registryKey.GetValue("Auto Login");
				num = 15;
				goto IL_A3;
				IL_E6:
				value3 = registryKey.GetValue("Tray Icon");
				num = 11;
				goto IL_FA;
				IL_13F:
				value2 = registryKey.GetValue("Default Packages Location");
				num = 7;
				goto IL_153;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0016E498 File Offset: 0x0016C698
		private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				bool flag;
				if (num == 4)
				{
					flag = registryKey != null;
					num = 5;
				}
				if (num != 8)
				{
					RegistryKey registryKey2;
					if (num == 12)
					{
						registryKey2.DeleteValue("Auto Login", false);
						num = 13;
					}
					if (num == 13)
					{
						registryKey2.Close();
						num = 14;
					}
					if (num == 11)
					{
						bool flag2;
						if (!flag2)
						{
							break;
						}
						num = 12;
					}
					if (num == 10)
					{
						bool flag2 = registryKey2 != null;
						num = 11;
					}
					if (num == 9)
					{
						goto IL_F4;
					}
					IL_10A:
					if (num == 7)
					{
						registryKey.Close();
						num = 8;
					}
					if (num == 6)
					{
						registryKey.SetValue("Auto Login", 1);
						num = 7;
					}
					if (num == 5)
					{
						if (!flag)
						{
							break;
						}
						num = 6;
					}
					if (num == 3)
					{
						registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
						num = 4;
					}
					if (num == 2)
					{
						bool @checked;
						if (!@checked)
						{
							goto IL_F4;
						}
						num = 3;
					}
					if (num == 1)
					{
						bool @checked = this.auto.Checked;
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 14)
					{
						break;
					}
					continue;
					IL_F4:
					registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 10;
					goto IL_10A;
				}
				break;
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0016E630 File Offset: 0x0016C830
		private void wallpaper_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				bool flag;
				if (num == 4)
				{
					flag = registryKey != null;
					num = 5;
				}
				if (num != 8)
				{
					RegistryKey registryKey2;
					if (num == 12)
					{
						registryKey2.DeleteValue("Tray Icon", false);
						num = 13;
					}
					if (num == 13)
					{
						registryKey2.Close();
						num = 14;
					}
					if (num == 11)
					{
						bool flag2;
						if (!flag2)
						{
							break;
						}
						num = 12;
					}
					if (num == 10)
					{
						bool flag2 = registryKey2 != null;
						num = 11;
					}
					if (num == 9)
					{
						goto IL_F4;
					}
					IL_10A:
					if (num == 7)
					{
						registryKey.Close();
						num = 8;
					}
					if (num == 6)
					{
						registryKey.SetValue("Tray Icon", 1);
						num = 7;
					}
					if (num == 5)
					{
						if (!flag)
						{
							break;
						}
						num = 6;
					}
					if (num == 3)
					{
						registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit");
						num = 4;
					}
					if (num == 2)
					{
						bool @checked;
						if (!@checked)
						{
							goto IL_F4;
						}
						num = 3;
					}
					if (num == 1)
					{
						bool @checked = this.tray.Checked;
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 14)
					{
						break;
					}
					continue;
					IL_F4:
					registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 10;
					goto IL_10A;
				}
				break;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0016E7C8 File Offset: 0x0016C9C8
		private void button2_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://docs.google.com/document/d/1ZcF6ZDbk-Pz4pNamEjCuFpHwO1LbIe-Uwpii3JujCME/");
				if (text.Contains(this.lbl_ver.Text))
				{
					using (no_update no_update = new no_update())
					{
						no_update.ShowDialog(this);
						goto IL_8D;
					}
				}
				using (update_avail update_avail = new update_avail())
				{
					update_avail.ShowDialog(this);
				}
				IL_8D:;
			}
			catch (WebException)
			{
				using (update_error update_error = new update_error())
				{
					update_error.ShowDialog(this);
				}
				base.Hide();
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00018F28 File Offset: 0x00017128
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://dsc.gg/nexustoolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0016E8C8 File Offset: 0x0016CAC8
		private void RestartApp()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 4)
				{
					processStartInfo.CreateNoWindow = true;
					num = 5;
				}
				if (num == 7)
				{
					Application.Exit();
					num = 8;
				}
				if (num == 6)
				{
					Process.Start(processStartInfo);
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 6;
				}
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 4;
				}
				if (num == 2)
				{
					processStartInfo.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
					num = 3;
				}
				if (num == 1)
				{
					processStartInfo = new ProcessStartInfo();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0016E9C0 File Offset: 0x0016CBC0
		private void siticoneButton1_Click_1(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				bool flag;
				if (num == 4)
				{
					flag = registryKey != null;
					num = 5;
				}
				if (num == 8)
				{
					goto IL_374;
				}
				IL_383:
				RegistryKey registryKey2;
				bool flag2;
				if (num == 12)
				{
					flag2 = registryKey2 != null;
					num = 13;
				}
				if (num == 16)
				{
					goto IL_28C;
				}
				IL_29B:
				RegistryKey registryKey3;
				bool flag3;
				if (num == 20)
				{
					flag3 = registryKey3 != null;
					num = 21;
				}
				if (num == 24)
				{
					goto IL_1A3;
				}
				IL_1B2:
				RegistryKey registryKey4;
				bool flag4;
				if (num == 28)
				{
					flag4 = registryKey4 != null;
					num = 29;
				}
				if (num == 32)
				{
					goto IL_85;
				}
				IL_94:
				if (num == 31)
				{
					registryKey4.Close();
					num = 32;
				}
				if (num == 30)
				{
					registryKey4.SetValue("Theme", "Accent Color", RegistryValueKind.String);
					num = 31;
				}
				if (num == 29)
				{
					if (!flag4)
					{
						goto IL_85;
					}
					num = 30;
				}
				if (num == 27)
				{
					registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 28;
				}
				bool flag5;
				if (num == 26)
				{
					if (!flag5)
					{
						break;
					}
					num = 27;
				}
				if (num == 25)
				{
					goto IL_164;
				}
				IL_184:
				if (num == 23)
				{
					registryKey3.Close();
					num = 24;
				}
				if (num == 22)
				{
					registryKey3.SetValue("Theme", "Default", RegistryValueKind.String);
					num = 23;
				}
				if (num == 21)
				{
					if (!flag3)
					{
						goto IL_1A3;
					}
					num = 22;
				}
				if (num == 19)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 20;
				}
				bool flag6;
				if (num == 18)
				{
					if (!flag6)
					{
						goto IL_164;
					}
					num = 19;
				}
				if (num == 17)
				{
					goto IL_24E;
				}
				IL_26E:
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 14)
				{
					registryKey2.SetValue("Theme", "Halloween", RegistryValueKind.String);
					num = 15;
				}
				if (num == 13)
				{
					if (!flag2)
					{
						goto IL_28C;
					}
					num = 14;
				}
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 12;
				}
				bool flag7;
				if (num == 10)
				{
					if (!flag7)
					{
						goto IL_24E;
					}
					num = 11;
				}
				if (num == 9)
				{
					goto IL_336;
				}
				IL_356:
				if (num == 7)
				{
					registryKey.Close();
					num = 8;
				}
				if (num == 6)
				{
					registryKey.SetValue("Theme", "Xmas", RegistryValueKind.String);
					num = 7;
				}
				if (num == 5)
				{
					if (!flag)
					{
						goto IL_374;
					}
					num = 6;
				}
				if (num == 3)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 4;
				}
				if (num == 2)
				{
					bool flag8;
					if (!flag8)
					{
						goto IL_336;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag8 = this.comboBox2.Text == "Xmas";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 33)
				{
					break;
				}
				continue;
				IL_336:
				flag7 = this.comboBox2.Text == "Halloween";
				num = 10;
				goto IL_356;
				IL_24E:
				flag6 = this.comboBox2.Text == "Default";
				num = 18;
				goto IL_26E;
				IL_164:
				flag5 = this.comboBox2.Text == "Accent Color";
				num = 26;
				goto IL_184;
				IL_85:
				this.RestartApp();
				num = 33;
				goto IL_94;
				IL_1A3:
				this.RestartApp();
				num = 25;
				goto IL_1B2;
				IL_28C:
				this.RestartApp();
				num = 17;
				goto IL_29B;
				IL_374:
				this.RestartApp();
				num = 9;
				goto IL_383;
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
		protected override void Dispose(bool disposing)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (!disposing)
					{
						goto Block_4;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag = this.components != null;
			goto IL_4D;
			Block_4:
			flag = false;
			IL_4D:
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0016EE50 File Offset: 0x0016D050
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.lbl_ver = new Label();
					num = 5;
				}
				if (num == 8)
				{
					this.label7 = new Label();
					num = 9;
				}
				if (num == 12)
				{
					this.comboBox2 = new ComboBox();
					num = 13;
				}
				if (num == 16)
				{
					this.default1 = new SiticoneButton();
					num = 17;
				}
				if (num == 20)
				{
					this.default2 = new SiticoneButton();
					num = 21;
				}
				if (num == 24)
				{
					this.pictureBox4 = new PictureBox();
					num = 25;
				}
				if (num == 28)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 29;
				}
				if (num == 32)
				{
					this.label1.ForeColor = Color.White;
					num = 33;
				}
				if (num == 36)
				{
					this.label1.TabIndex = 122;
					num = 37;
				}
				if (num == 40)
				{
					this.label37.ForeColor = Color.Silver;
					num = 41;
				}
				if (num == 44)
				{
					this.label37.TabIndex = 123;
					num = 45;
				}
				if (num == 48)
				{
					this.lbl_ver.ForeColor = Color.Silver;
					num = 49;
				}
				if (num == 53)
				{
					this.lbl_ver.Text = "v4.79";
					num = 54;
				}
				if (num == 57)
				{
					this.linkLabel1.Location = new Point(821, 634);
					num = 58;
				}
				if (num == 61)
				{
					this.linkLabel1.TabStop = true;
					num = 62;
				}
				if (num == 65)
				{
					this.update_btn.BackColor = Color.FromArgb(38, 38, 38);
					num = 66;
				}
				if (num == 69)
				{
					this.update_btn.FlatStyle = FlatStyle.Flat;
					num = 70;
				}
				if (num == 73)
				{
					this.update_btn.ImageAlign = ContentAlignment.MiddleLeft;
					num = 74;
				}
				if (num == 77)
				{
					this.update_btn.Size = new Size(178, 43);
					num = 78;
				}
				if (num == 81)
				{
					this.update_btn.TextAlign = ContentAlignment.MiddleRight;
					num = 82;
				}
				if (num == 85)
				{
					this.label8.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 86;
				}
				if (num == 89)
				{
					this.label8.Size = new Size(156, 19);
					num = 90;
				}
				if (num == 93)
				{
					this.label7.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 94;
				}
				if (num == 97)
				{
					this.label7.Size = new Size(102, 19);
					num = 98;
				}
				if (num == 102)
				{
					this.label5.ForeColor = Color.Silver;
					num = 103;
				}
				if (num == 106)
				{
					this.label5.TabIndex = 297;
					num = 107;
				}
				if (num == 110)
				{
					this.tray.CheckedState.BorderRadius = 0;
					num = 111;
				}
				if (num == 114)
				{
					this.tray.ForeColor = Color.White;
					num = 115;
				}
				if (num == 118)
				{
					this.tray.TabIndex = 299;
					num = 119;
				}
				if (num == 122)
				{
					this.tray.UncheckedState.BorderThickness = 0;
					num = 123;
				}
				if (num == 126)
				{
					this.auto.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 127;
				}
				if (num == 130)
				{
					this.auto.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 131;
				}
				if (num == 134)
				{
					this.auto.Size = new Size(104, 28);
					num = 135;
				}
				if (num == 138)
				{
					this.auto.UncheckedState.BorderRadius = 0;
					num = 139;
				}
				if (num == 142)
				{
					this.comboBox2.BackColor = Color.White;
					num = 143;
				}
				if (num == 146)
				{
					this.comboBox2.Items.AddRange(new object[] { "Accent Color", "Default", "Halloween", "Xmas" });
					num = 147;
				}
				if (num == 151)
				{
					this.label2.AutoSize = true;
					num = 152;
				}
				if (num == 155)
				{
					this.label2.Name = "label2";
					num = 156;
				}
				if (num == 159)
				{
					this.label10.AutoSize = true;
					num = 160;
				}
				if (num == 163)
				{
					this.label10.Name = "label10";
					num = 164;
				}
				if (num == 167)
				{
					this.browse1.CheckedState.Parent = this.browse1;
					num = 168;
				}
				if (num == 171)
				{
					this.browse1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 172;
				}
				if (num == 175)
				{
					this.browse1.Font = new Font("Segoe UI", 9f);
					num = 176;
				}
				if (num == 179)
				{
					this.browse1.Location = new Point(772, 395);
					num = 180;
				}
				if (num == 183)
				{
					this.browse1.TabIndex = 309;
					num = 184;
				}
				if (num == 187)
				{
					this.default1.CustomImages.Parent = this.default1;
					num = 188;
				}
				if (num == 191)
				{
					this.default1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 192;
				}
				if (num == 195)
				{
					this.default1.ForeColor = Color.White;
					num = 196;
				}
				if (num == 200)
				{
					this.default1.ShadowDecoration.Parent = this.default1;
					num = 201;
				}
				if (num == 204)
				{
					this.default1.Click += this.siticoneButton2_Click;
					num = 205;
				}
				if (num == 208)
				{
					this.dl_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 209;
				}
				if (num == 212)
				{
					this.dl_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 213;
				}
				if (num == 216)
				{
					this.dl_txtbox.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 217;
				}
				if (num == 220)
				{
					this.dl_txtbox.Location = new Point(244, 393);
					num = 221;
				}
				if (num == 224)
				{
					this.dl_txtbox.ReadOnly = true;
					num = 225;
				}
				if (num == 228)
				{
					this.dl_txtbox.TabIndex = 311;
					num = 229;
				}
				if (num == 232)
				{
					this.label12.Location = new Point(43, 428);
					num = 233;
				}
				if (num == 236)
				{
					this.label12.Text = "Default Packages Folder :";
					num = 237;
				}
				if (num == 240)
				{
					this.pkg_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 241;
				}
				if (num == 244)
				{
					this.pkg_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 245;
				}
				if (num == 248)
				{
					this.pkg_txtbox.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 249;
				}
				if (num == 253)
				{
					this.pkg_txtbox.Name = "pkg_txtbox";
					num = 254;
				}
				if (num == 257)
				{
					this.pkg_txtbox.SelectedText = "";
					num = 258;
				}
				if (num == 261)
				{
					this.default2.CheckedState.Parent = this.default2;
					num = 262;
				}
				if (num == 265)
				{
					this.default2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 266;
				}
				if (num == 269)
				{
					this.default2.Font = new Font("Segoe UI", 9f);
					num = 270;
				}
				if (num == 273)
				{
					this.default2.Location = new Point(853, 428);
					num = 274;
				}
				if (num == 277)
				{
					this.default2.TabIndex = 315;
					num = 278;
				}
				if (num == 281)
				{
					this.browse2.CustomImages.Parent = this.browse2;
					num = 282;
				}
				if (num == 285)
				{
					this.browse2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 286;
				}
				if (num == 289)
				{
					this.browse2.ForeColor = Color.White;
					num = 290;
				}
				if (num == 293)
				{
					this.browse2.Name = "browse2";
					num = 294;
				}
				if (num == 297)
				{
					this.browse2.Text = "Browse...";
					num = 298;
				}
				if (num == 302)
				{
					this.label9.Location = new Point(34, 83);
					num = 303;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 306)
				{
					this.label9.Text = componentResourceManager.GetString("label9.Text");
					num = 307;
				}
				if (num == 310)
				{
					this.pictureBox4.Size = new Size(64, 64);
					num = 311;
				}
				if (num == 314)
				{
					this.label3.AutoSize = true;
					num = 315;
				}
				if (num == 318)
				{
					this.label3.Name = "label3";
					num = 319;
				}
				if (num == 322)
				{
					this.label11.AutoSize = true;
					num = 323;
				}
				if (num == 326)
				{
					this.label11.Name = "label11";
					num = 327;
				}
				if (num == 330)
				{
					this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
					num = 331;
				}
				if (num == 334)
				{
					this.siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 335;
				}
				if (num == 338)
				{
					this.siticoneButton1.Font = new Font("Segoe UI", 9f);
					num = 339;
				}
				if (num == 342)
				{
					this.siticoneButton1.Location = new Point(590, 295);
					num = 343;
				}
				if (num == 346)
				{
					this.siticoneButton1.TabIndex = 320;
					num = 347;
				}
				if (num == 351)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 352;
				}
				if (num == 355)
				{
					base.Controls.Add(this.label3);
					num = 356;
				}
				if (num == 359)
				{
					base.Controls.Add(this.pkg_txtbox);
					num = 360;
				}
				if (num == 363)
				{
					base.Controls.Add(this.browse1);
					num = 364;
				}
				if (num == 367)
				{
					base.Controls.Add(this.auto);
					num = 368;
				}
				if (num == 371)
				{
					base.Controls.Add(this.linkLabel1);
					num = 372;
				}
				if (num == 375)
				{
					base.Controls.Add(this.label37);
					num = 376;
				}
				if (num == 379)
				{
					base.Load += this.settings_Load;
					num = 380;
				}
				if (num == 382)
				{
					base.PerformLayout();
					num = 383;
				}
				if (num == 381)
				{
					base.ResumeLayout(false);
					num = 382;
				}
				if (num == 380)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 381;
				}
				if (num == 378)
				{
					base.Size = new Size(1006, 669);
					num = 379;
				}
				if (num == 377)
				{
					base.Name = "Settings";
					num = 378;
				}
				if (num == 376)
				{
					base.Controls.Add(this.label1);
					num = 377;
				}
				if (num == 374)
				{
					base.Controls.Add(this.label7);
					num = 375;
				}
				if (num == 373)
				{
					base.Controls.Add(this.label8);
					num = 374;
				}
				if (num == 372)
				{
					base.Controls.Add(this.update_btn);
					num = 373;
				}
				if (num == 370)
				{
					base.Controls.Add(this.lbl_ver);
					num = 371;
				}
				if (num == 369)
				{
					base.Controls.Add(this.label5);
					num = 370;
				}
				if (num == 368)
				{
					base.Controls.Add(this.tray);
					num = 369;
				}
				if (num == 366)
				{
					base.Controls.Add(this.comboBox2);
					num = 367;
				}
				if (num == 365)
				{
					base.Controls.Add(this.label2);
					num = 366;
				}
				if (num == 364)
				{
					base.Controls.Add(this.label10);
					num = 365;
				}
				if (num == 362)
				{
					base.Controls.Add(this.default1);
					num = 363;
				}
				if (num == 361)
				{
					base.Controls.Add(this.dl_txtbox);
					num = 362;
				}
				if (num == 360)
				{
					base.Controls.Add(this.label12);
					num = 361;
				}
				if (num == 358)
				{
					base.Controls.Add(this.browse2);
					num = 359;
				}
				if (num == 357)
				{
					base.Controls.Add(this.default2);
					num = 358;
				}
				if (num == 356)
				{
					base.Controls.Add(this.pictureBox4);
					num = 357;
				}
				if (num == 354)
				{
					base.Controls.Add(this.label9);
					num = 355;
				}
				if (num == 353)
				{
					base.Controls.Add(this.label11);
					num = 354;
				}
				if (num == 352)
				{
					base.Controls.Add(this.siticoneButton1);
					num = 353;
				}
				if (num == 350)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 351;
				}
				if (num == 349)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 350;
				}
				if (num == 348)
				{
					this.siticoneButton1.Click += this.siticoneButton1_Click_1;
					num = 349;
				}
				if (num == 347)
				{
					this.siticoneButton1.Text = "Apply";
					num = 348;
				}
				if (num == 345)
				{
					this.siticoneButton1.Size = new Size(80, 27);
					num = 346;
				}
				if (num == 344)
				{
					this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
					num = 345;
				}
				if (num == 343)
				{
					this.siticoneButton1.Name = "siticoneButton1";
					num = 344;
				}
				if (num == 341)
				{
					this.siticoneButton1.ImageSize = new Size(30, 30);
					num = 342;
				}
				if (num == 340)
				{
					this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
					num = 341;
				}
				if (num == 339)
				{
					this.siticoneButton1.ForeColor = Color.White;
					num = 340;
				}
				if (num == 337)
				{
					this.siticoneButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 338;
				}
				if (num == 336)
				{
					this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
					num = 337;
				}
				if (num == 335)
				{
					this.siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 336;
				}
				if (num == 333)
				{
					this.siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 334;
				}
				if (num == 332)
				{
					this.siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 333;
				}
				if (num == 331)
				{
					this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
					num = 332;
				}
				if (num == 329)
				{
					this.label11.Text = "_______________________________________________________________________________________________________________________________________";
					num = 330;
				}
				if (num == 328)
				{
					this.label11.TabIndex = 319;
					num = 329;
				}
				if (num == 327)
				{
					this.label11.Size = new Size(953, 18);
					num = 328;
				}
				if (num == 325)
				{
					this.label11.Location = new Point(24, 141);
					num = 326;
				}
				if (num == 324)
				{
					this.label11.ForeColor = Color.DimGray;
					num = 325;
				}
				if (num == 323)
				{
					this.label11.Font = new Font("Gill Sans MT", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 324;
				}
				if (num == 321)
				{
					this.label3.Text = "About";
					num = 322;
				}
				if (num == 320)
				{
					this.label3.TabIndex = 316;
					num = 321;
				}
				if (num == 319)
				{
					this.label3.Size = new Size(94, 43);
					num = 320;
				}
				if (num == 317)
				{
					this.label3.Location = new Point(70, 26);
					num = 318;
				}
				if (num == 316)
				{
					this.label3.ForeColor = Color.White;
					num = 317;
				}
				if (num == 315)
				{
					this.label3.Font = new Font("Josefin Sans SemiBold", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 316;
				}
				if (num == 313)
				{
					this.pictureBox4.TabStop = false;
					num = 314;
				}
				if (num == 312)
				{
					this.pictureBox4.TabIndex = 317;
					num = 313;
				}
				if (num == 311)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 312;
				}
				if (num == 309)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 310;
				}
				if (num == 308)
				{
					this.pictureBox4.Location = new Point(15, 16);
					num = 309;
				}
				if (num == 307)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 308;
				}
				if (num == 305)
				{
					this.label9.TabIndex = 318;
					num = 306;
				}
				if (num == 304)
				{
					this.label9.Size = new Size(822, 38);
					num = 305;
				}
				if (num == 303)
				{
					this.label9.Name = "label9";
					num = 304;
				}
				if (num == 301)
				{
					this.label9.ForeColor = Color.Silver;
					num = 302;
				}
				if (num == 300)
				{
					this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 301;
				}
				if (num == 299)
				{
					this.label9.AutoSize = true;
					num = 300;
				}
				if (num == 298)
				{
					this.browse2.Click += this.siticoneButton4_Click;
					num = 299;
				}
				if (num == 296)
				{
					this.browse2.TabIndex = 314;
					num = 297;
				}
				if (num == 295)
				{
					this.browse2.Size = new Size(80, 27);
					num = 296;
				}
				if (num == 294)
				{
					this.browse2.ShadowDecoration.Parent = this.browse2;
					num = 295;
				}
				if (num == 292)
				{
					this.browse2.Location = new Point(772, 428);
					num = 293;
				}
				if (num == 291)
				{
					this.browse2.ImageSize = new Size(30, 30);
					num = 292;
				}
				if (num == 290)
				{
					this.browse2.HoverState.Parent = this.browse2;
					num = 291;
				}
				if (num == 288)
				{
					this.browse2.Font = new Font("Segoe UI", 9f);
					num = 289;
				}
				if (num == 287)
				{
					this.browse2.FillColor = Color.FromArgb(38, 38, 38);
					num = 288;
				}
				if (num == 286)
				{
					this.browse2.DisabledState.Parent = this.browse2;
					num = 287;
				}
				if (num == 284)
				{
					this.browse2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 285;
				}
				if (num == 283)
				{
					this.browse2.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 284;
				}
				if (num == 282)
				{
					this.browse2.DisabledState.BorderColor = Color.DarkGray;
					num = 283;
				}
				if (num == 280)
				{
					this.browse2.CheckedState.Parent = this.browse2;
					num = 281;
				}
				if (num == 279)
				{
					this.default2.Click += this.siticoneButton3_Click;
					num = 280;
				}
				if (num == 278)
				{
					this.default2.Text = "Default";
					num = 279;
				}
				if (num == 276)
				{
					this.default2.Size = new Size(80, 27);
					num = 277;
				}
				if (num == 275)
				{
					this.default2.ShadowDecoration.Parent = this.default2;
					num = 276;
				}
				if (num == 274)
				{
					this.default2.Name = "default2";
					num = 275;
				}
				if (num == 272)
				{
					this.default2.ImageSize = new Size(30, 30);
					num = 273;
				}
				if (num == 271)
				{
					this.default2.HoverState.Parent = this.default2;
					num = 272;
				}
				if (num == 270)
				{
					this.default2.ForeColor = Color.White;
					num = 271;
				}
				if (num == 268)
				{
					this.default2.FillColor = Color.FromArgb(38, 38, 38);
					num = 269;
				}
				if (num == 267)
				{
					this.default2.DisabledState.Parent = this.default2;
					num = 268;
				}
				if (num == 266)
				{
					this.default2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 267;
				}
				if (num == 264)
				{
					this.default2.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 265;
				}
				if (num == 263)
				{
					this.default2.DisabledState.BorderColor = Color.DarkGray;
					num = 264;
				}
				if (num == 262)
				{
					this.default2.CustomImages.Parent = this.default2;
					num = 263;
				}
				if (num == 260)
				{
					this.pkg_txtbox.TabIndex = 313;
					num = 261;
				}
				if (num == 259)
				{
					this.pkg_txtbox.Size = new Size(522, 28);
					num = 260;
				}
				if (num == 258)
				{
					this.pkg_txtbox.ShadowDecoration.Parent = this.pkg_txtbox;
					num = 259;
				}
				if (num == 256)
				{
					this.pkg_txtbox.ReadOnly = true;
					num = 257;
				}
				if (num == 255)
				{
					this.pkg_txtbox.PlaceholderText = "";
					num = 256;
				}
				if (num == 254)
				{
					this.pkg_txtbox.PasswordChar = '\0';
					num = 255;
				}
				if (num == 252)
				{
					this.pkg_txtbox.Location = new Point(244, 426);
					num = 253;
				}
				if (num == 251)
				{
					this.pkg_txtbox.HoverState.Parent = this.pkg_txtbox;
					num = 252;
				}
				if (num == 250)
				{
					this.pkg_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 251;
				}
				if (num == 249)
				{
					this.pkg_txtbox.ForeColor = Color.White;
					num = 250;
				}
				if (num == 247)
				{
					this.pkg_txtbox.FocusedState.Parent = this.pkg_txtbox;
					num = 248;
				}
				if (num == 246)
				{
					this.pkg_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 247;
				}
				if (num == 245)
				{
					this.pkg_txtbox.FillColor = Color.FromArgb(38, 38, 38);
					num = 246;
				}
				if (num == 243)
				{
					this.pkg_txtbox.DisabledState.Parent = this.pkg_txtbox;
					num = 244;
				}
				if (num == 242)
				{
					this.pkg_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 243;
				}
				if (num == 241)
				{
					this.pkg_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 242;
				}
				if (num == 239)
				{
					this.pkg_txtbox.DefaultText = "";
					num = 240;
				}
				if (num == 238)
				{
					this.pkg_txtbox.Cursor = Cursors.IBeam;
					num = 239;
				}
				if (num == 237)
				{
					this.pkg_txtbox.BackColor = Color.Transparent;
					num = 238;
				}
				if (num == 235)
				{
					this.label12.TabIndex = 312;
					num = 236;
				}
				if (num == 234)
				{
					this.label12.Size = new Size(186, 24);
					num = 235;
				}
				if (num == 233)
				{
					this.label12.Name = "label12";
					num = 234;
				}
				if (num == 231)
				{
					this.label12.ForeColor = Color.Silver;
					num = 232;
				}
				if (num == 230)
				{
					this.label12.Font = new Font("Josefin Sans", 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 231;
				}
				if (num == 229)
				{
					this.label12.AutoSize = true;
					num = 230;
				}
				if (num == 227)
				{
					this.dl_txtbox.Size = new Size(522, 28);
					num = 228;
				}
				if (num == 226)
				{
					this.dl_txtbox.ShadowDecoration.Parent = this.dl_txtbox;
					num = 227;
				}
				if (num == 225)
				{
					this.dl_txtbox.SelectedText = "";
					num = 226;
				}
				if (num == 223)
				{
					this.dl_txtbox.PlaceholderText = "";
					num = 224;
				}
				if (num == 222)
				{
					this.dl_txtbox.PasswordChar = '\0';
					num = 223;
				}
				if (num == 221)
				{
					this.dl_txtbox.Name = "dl_txtbox";
					num = 222;
				}
				if (num == 219)
				{
					this.dl_txtbox.HoverState.Parent = this.dl_txtbox;
					num = 220;
				}
				if (num == 218)
				{
					this.dl_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 219;
				}
				if (num == 217)
				{
					this.dl_txtbox.ForeColor = Color.White;
					num = 218;
				}
				if (num == 215)
				{
					this.dl_txtbox.FocusedState.Parent = this.dl_txtbox;
					num = 216;
				}
				if (num == 214)
				{
					this.dl_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 215;
				}
				if (num == 213)
				{
					this.dl_txtbox.FillColor = Color.FromArgb(38, 38, 38);
					num = 214;
				}
				if (num == 211)
				{
					this.dl_txtbox.DisabledState.Parent = this.dl_txtbox;
					num = 212;
				}
				if (num == 210)
				{
					this.dl_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 211;
				}
				if (num == 209)
				{
					this.dl_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 210;
				}
				if (num == 207)
				{
					this.dl_txtbox.DefaultText = "";
					num = 208;
				}
				if (num == 206)
				{
					this.dl_txtbox.Cursor = Cursors.IBeam;
					num = 207;
				}
				if (num == 205)
				{
					this.dl_txtbox.BackColor = Color.Transparent;
					num = 206;
				}
				if (num == 203)
				{
					this.default1.Text = "Default";
					num = 204;
				}
				if (num == 202)
				{
					this.default1.TabIndex = 310;
					num = 203;
				}
				if (num == 201)
				{
					this.default1.Size = new Size(80, 27);
					num = 202;
				}
				if (num == 199)
				{
					this.default1.Name = "default1";
					num = 200;
				}
				if (num == 198)
				{
					this.default1.Location = new Point(853, 395);
					num = 199;
				}
				if (num == 197)
				{
					this.default1.ImageSize = new Size(30, 30);
					num = 198;
				}
				if (num == 196)
				{
					this.default1.HoverState.Parent = this.default1;
					num = 197;
				}
				if (num == 194)
				{
					this.default1.Font = new Font("Segoe UI", 9f);
					num = 195;
				}
				if (num == 193)
				{
					this.default1.FillColor = Color.FromArgb(38, 38, 38);
					num = 194;
				}
				if (num == 192)
				{
					this.default1.DisabledState.Parent = this.default1;
					num = 193;
				}
				if (num == 190)
				{
					this.default1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 191;
				}
				if (num == 189)
				{
					this.default1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 190;
				}
				if (num == 188)
				{
					this.default1.DisabledState.BorderColor = Color.DarkGray;
					num = 189;
				}
				if (num == 186)
				{
					this.default1.CheckedState.Parent = this.default1;
					num = 187;
				}
				if (num == 185)
				{
					this.browse1.Click += this.siticoneButton1_Click;
					num = 186;
				}
				if (num == 184)
				{
					this.browse1.Text = "Browse...";
					num = 185;
				}
				if (num == 182)
				{
					this.browse1.Size = new Size(80, 27);
					num = 183;
				}
				if (num == 181)
				{
					this.browse1.ShadowDecoration.Parent = this.browse1;
					num = 182;
				}
				if (num == 180)
				{
					this.browse1.Name = "browse1";
					num = 181;
				}
				if (num == 178)
				{
					this.browse1.ImageSize = new Size(30, 30);
					num = 179;
				}
				if (num == 177)
				{
					this.browse1.HoverState.Parent = this.browse1;
					num = 178;
				}
				if (num == 176)
				{
					this.browse1.ForeColor = Color.White;
					num = 177;
				}
				if (num == 174)
				{
					this.browse1.FillColor = Color.FromArgb(38, 38, 38);
					num = 175;
				}
				if (num == 173)
				{
					this.browse1.DisabledState.Parent = this.browse1;
					num = 174;
				}
				if (num == 172)
				{
					this.browse1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 173;
				}
				if (num == 170)
				{
					this.browse1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 171;
				}
				if (num == 169)
				{
					this.browse1.DisabledState.BorderColor = Color.DarkGray;
					num = 170;
				}
				if (num == 168)
				{
					this.browse1.CustomImages.Parent = this.browse1;
					num = 169;
				}
				if (num == 166)
				{
					this.label10.Text = "Default Downloads Folder :";
					num = 167;
				}
				if (num == 165)
				{
					this.label10.TabIndex = 307;
					num = 166;
				}
				if (num == 164)
				{
					this.label10.Size = new Size(195, 24);
					num = 165;
				}
				if (num == 162)
				{
					this.label10.Location = new Point(43, 393);
					num = 163;
				}
				if (num == 161)
				{
					this.label10.ForeColor = Color.Silver;
					num = 162;
				}
				if (num == 160)
				{
					this.label10.Font = new Font("Josefin Sans", 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 161;
				}
				if (num == 158)
				{
					this.label2.Text = "Theme :";
					num = 159;
				}
				if (num == 157)
				{
					this.label2.TabIndex = 302;
					num = 158;
				}
				if (num == 156)
				{
					this.label2.Size = new Size(51, 19);
					num = 157;
				}
				if (num == 154)
				{
					this.label2.Location = new Point(385, 294);
					num = 155;
				}
				if (num == 153)
				{
					this.label2.ForeColor = Color.Silver;
					num = 154;
				}
				if (num == 152)
				{
					this.label2.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 153;
				}
				if (num == 150)
				{
					this.comboBox2.TabIndex = 301;
					num = 151;
				}
				if (num == 149)
				{
					this.comboBox2.Size = new Size(143, 21);
					num = 150;
				}
				if (num == 148)
				{
					this.comboBox2.Name = "comboBox2";
					num = 149;
				}
				if (num == 147)
				{
					this.comboBox2.Location = new Point(441, 295);
					num = 148;
				}
				if (num == 145)
				{
					this.comboBox2.FormattingEnabled = true;
					num = 146;
				}
				if (num == 144)
				{
					this.comboBox2.ForeColor = Color.Black;
					num = 145;
				}
				if (num == 143)
				{
					this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
					num = 144;
				}
				if (num == 141)
				{
					this.auto.CheckedChanged += this.siticoneCheckBox1_CheckedChanged;
					num = 142;
				}
				if (num == 140)
				{
					this.auto.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 141;
				}
				if (num == 139)
				{
					this.auto.UncheckedState.BorderThickness = 0;
					num = 140;
				}
				if (num == 137)
				{
					this.auto.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 138;
				}
				if (num == 136)
				{
					this.auto.Text = "Auto-Login";
					num = 137;
				}
				if (num == 135)
				{
					this.auto.TabIndex = 300;
					num = 136;
				}
				if (num == 133)
				{
					this.auto.Name = "auto";
					num = 134;
				}
				if (num == 132)
				{
					this.auto.Location = new Point(47, 330);
					num = 133;
				}
				if (num == 131)
				{
					this.auto.ForeColor = Color.White;
					num = 132;
				}
				if (num == 129)
				{
					this.auto.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 130;
				}
				if (num == 128)
				{
					this.auto.CheckedState.BorderThickness = 0;
					num = 129;
				}
				if (num == 127)
				{
					this.auto.CheckedState.BorderRadius = 0;
					num = 128;
				}
				if (num == 125)
				{
					this.auto.AutoSize = true;
					num = 126;
				}
				if (num == 124)
				{
					this.tray.CheckedChanged += this.wallpaper_CheckedChanged;
					num = 125;
				}
				if (num == 123)
				{
					this.tray.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 124;
				}
				if (num == 121)
				{
					this.tray.UncheckedState.BorderRadius = 0;
					num = 122;
				}
				if (num == 120)
				{
					this.tray.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 121;
				}
				if (num == 119)
				{
					this.tray.Text = "Minimize as tray icon";
					num = 120;
				}
				if (num == 117)
				{
					this.tray.Size = new Size(174, 28);
					num = 118;
				}
				if (num == 116)
				{
					this.tray.Name = "tray";
					num = 117;
				}
				if (num == 115)
				{
					this.tray.Location = new Point(47, 287);
					num = 116;
				}
				if (num == 113)
				{
					this.tray.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 114;
				}
				if (num == 112)
				{
					this.tray.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 113;
				}
				if (num == 111)
				{
					this.tray.CheckedState.BorderThickness = 0;
					num = 112;
				}
				if (num == 109)
				{
					this.tray.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 110;
				}
				if (num == 108)
				{
					this.tray.AutoSize = true;
					num = 109;
				}
				if (num == 107)
				{
					this.label5.Text = "© The World Of PC 2023";
					num = 108;
				}
				if (num == 105)
				{
					this.label5.Size = new Size(149, 19);
					num = 106;
				}
				if (num == 104)
				{
					this.label5.Name = "label5";
					num = 105;
				}
				if (num == 103)
				{
					this.label5.Location = new Point(833, 610);
					num = 104;
				}
				if (num == 101)
				{
					this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 102;
				}
				if (num == 100)
				{
					this.label5.AutoSize = true;
					num = 101;
				}
				if (num == 99)
				{
					this.label7.Text = "Current Version :";
					num = 100;
				}
				if (num == 98)
				{
					this.label7.TabIndex = 292;
					num = 99;
				}
				if (num == 96)
				{
					this.label7.Name = "label7";
					num = 97;
				}
				if (num == 95)
				{
					this.label7.Location = new Point(285, 539);
					num = 96;
				}
				if (num == 94)
				{
					this.label7.ForeColor = Color.Silver;
					num = 95;
				}
				if (num == 92)
				{
					this.label7.AutoSize = true;
					num = 93;
				}
				if (num == 91)
				{
					this.label8.Text = "Last Updated : 03/03/2023";
					num = 92;
				}
				if (num == 90)
				{
					this.label8.TabIndex = 293;
					num = 91;
				}
				if (num == 88)
				{
					this.label8.Name = "label8";
					num = 89;
				}
				if (num == 87)
				{
					this.label8.Location = new Point(285, 558);
					num = 88;
				}
				if (num == 86)
				{
					this.label8.ForeColor = Color.Silver;
					num = 87;
				}
				if (num == 84)
				{
					this.label8.AutoSize = true;
					num = 85;
				}
				if (num == 83)
				{
					this.update_btn.Click += this.button2_Click;
					num = 84;
				}
				if (num == 82)
				{
					this.update_btn.UseVisualStyleBackColor = false;
					num = 83;
				}
				if (num == 80)
				{
					this.update_btn.Text = "Check For Updates";
					num = 81;
				}
				if (num == 79)
				{
					this.update_btn.TabStop = false;
					num = 80;
				}
				if (num == 78)
				{
					this.update_btn.TabIndex = 294;
					num = 79;
				}
				if (num == 76)
				{
					this.update_btn.Name = "update_btn";
					num = 77;
				}
				if (num == 75)
				{
					this.update_btn.Margin = new Padding(1);
					num = 76;
				}
				if (num == 74)
				{
					this.update_btn.Location = new Point(453, 539);
					num = 75;
				}
				if (num == 72)
				{
					this.update_btn.Image = (Image)componentResourceManager.GetObject("update_btn.Image");
					num = 73;
				}
				if (num == 71)
				{
					this.update_btn.ForeColor = Color.White;
					num = 72;
				}
				if (num == 70)
				{
					this.update_btn.Font = new Font("Josefin Sans SemiBold", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 71;
				}
				if (num == 68)
				{
					this.update_btn.FlatAppearance.BorderSize = 0;
					num = 69;
				}
				if (num == 67)
				{
					this.update_btn.Cursor = Cursors.Hand;
					num = 68;
				}
				if (num == 66)
				{
					this.update_btn.BackgroundImageLayout = ImageLayout.None;
					num = 67;
				}
				if (num == 64)
				{
					this.linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
					num = 65;
				}
				if (num == 63)
				{
					this.linkLabel1.VisitedLinkColor = Color.DeepSkyBlue;
					num = 64;
				}
				if (num == 62)
				{
					this.linkLabel1.Text = "https://www.dsc.gg/NexusToolkit";
					num = 63;
				}
				if (num == 60)
				{
					this.linkLabel1.TabIndex = 295;
					num = 61;
				}
				if (num == 59)
				{
					this.linkLabel1.Size = new Size(169, 13);
					num = 60;
				}
				if (num == 58)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 59;
				}
				if (num == 56)
				{
					this.linkLabel1.LinkColor = Color.DeepSkyBlue;
					num = 57;
				}
				if (num == 55)
				{
					this.linkLabel1.AutoSize = true;
					num = 56;
				}
				if (num == 54)
				{
					this.linkLabel1.ActiveLinkColor = Color.SteelBlue;
					num = 55;
				}
				if (num == 52)
				{
					this.lbl_ver.TabIndex = 296;
					num = 53;
				}
				if (num == 51)
				{
					this.lbl_ver.Size = new Size(35, 19);
					num = 52;
				}
				if (num == 50)
				{
					this.lbl_ver.Name = "lbl_ver";
					num = 51;
				}
				if (num == 49)
				{
					this.lbl_ver.Location = new Point(385, 539);
					num = 50;
				}
				if (num == 47)
				{
					this.lbl_ver.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 48;
				}
				if (num == 46)
				{
					this.lbl_ver.AutoSize = true;
					num = 47;
				}
				if (num == 45)
				{
					this.label37.Text = "Manage toolkit settings and other options (Restart toolkit to let the changes take place)";
					num = 46;
				}
				if (num == 43)
				{
					this.label37.Size = new Size(490, 19);
					num = 44;
				}
				if (num == 42)
				{
					this.label37.Name = "label37";
					num = 43;
				}
				if (num == 41)
				{
					this.label37.Location = new Point(31, 227);
					num = 42;
				}
				if (num == 39)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 40;
				}
				if (num == 38)
				{
					this.label37.AutoSize = true;
					num = 39;
				}
				if (num == 37)
				{
					this.label1.Text = "Settings";
					num = 38;
				}
				if (num == 35)
				{
					this.label1.Size = new Size(150, 53);
					num = 36;
				}
				if (num == 34)
				{
					this.label1.Name = "label1";
					num = 35;
				}
				if (num == 33)
				{
					this.label1.Location = new Point(24, 174);
					num = 34;
				}
				if (num == 31)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 32;
				}
				if (num == 30)
				{
					this.label1.AutoSize = true;
					num = 31;
				}
				if (num == 29)
				{
					base.SuspendLayout();
					num = 30;
				}
				if (num == 27)
				{
					this.siticoneButton1 = new SiticoneButton();
					num = 28;
				}
				if (num == 26)
				{
					this.label11 = new Label();
					num = 27;
				}
				if (num == 25)
				{
					this.label3 = new Label();
					num = 26;
				}
				if (num == 23)
				{
					this.label9 = new Label();
					num = 24;
				}
				if (num == 22)
				{
					this.folderBrowserDialog1 = new FolderBrowserDialog();
					num = 23;
				}
				if (num == 21)
				{
					this.browse2 = new SiticoneButton();
					num = 22;
				}
				if (num == 19)
				{
					this.pkg_txtbox = new SiticoneTextBox();
					num = 20;
				}
				if (num == 18)
				{
					this.label12 = new Label();
					num = 19;
				}
				if (num == 17)
				{
					this.dl_txtbox = new SiticoneTextBox();
					num = 18;
				}
				if (num == 15)
				{
					this.browse1 = new SiticoneButton();
					num = 16;
				}
				if (num == 14)
				{
					this.label10 = new Label();
					num = 15;
				}
				if (num == 13)
				{
					this.label2 = new Label();
					num = 14;
				}
				if (num == 11)
				{
					this.auto = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 10)
				{
					this.tray = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 9)
				{
					this.label5 = new Label();
					num = 10;
				}
				if (num == 7)
				{
					this.label8 = new Label();
					num = 8;
				}
				if (num == 6)
				{
					this.update_btn = new Button();
					num = 7;
				}
				if (num == 5)
				{
					this.linkLabel1 = new LinkLabel();
					num = 6;
				}
				if (num == 3)
				{
					this.label37 = new Label();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Settings));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 383);
		}

		// Token: 0x04000918 RID: 2328
		private static Settings _instace;

		// Token: 0x04000919 RID: 2329
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x0400091A RID: 2330
		private IContainer components = null;

		// Token: 0x0400091B RID: 2331
		private Label label1;

		// Token: 0x0400091C RID: 2332
		private Label label37;

		// Token: 0x0400091D RID: 2333
		private Label lbl_ver;

		// Token: 0x0400091E RID: 2334
		private LinkLabel linkLabel1;

		// Token: 0x0400091F RID: 2335
		private Button update_btn;

		// Token: 0x04000920 RID: 2336
		private Label label8;

		// Token: 0x04000921 RID: 2337
		private Label label7;

		// Token: 0x04000922 RID: 2338
		private Label label5;

		// Token: 0x04000923 RID: 2339
		private SiticoneCheckBox tray;

		// Token: 0x04000924 RID: 2340
		private SiticoneCheckBox auto;

		// Token: 0x04000925 RID: 2341
		private ComboBox comboBox2;

		// Token: 0x04000926 RID: 2342
		private Label label2;

		// Token: 0x04000927 RID: 2343
		private Label label10;

		// Token: 0x04000928 RID: 2344
		private SiticoneButton browse1;

		// Token: 0x04000929 RID: 2345
		private SiticoneButton default1;

		// Token: 0x0400092A RID: 2346
		private SiticoneTextBox dl_txtbox;

		// Token: 0x0400092B RID: 2347
		private Label label12;

		// Token: 0x0400092C RID: 2348
		private SiticoneTextBox pkg_txtbox;

		// Token: 0x0400092D RID: 2349
		private SiticoneButton default2;

		// Token: 0x0400092E RID: 2350
		private SiticoneButton browse2;

		// Token: 0x0400092F RID: 2351
		private FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x04000930 RID: 2352
		private Label label9;

		// Token: 0x04000931 RID: 2353
		private PictureBox pictureBox4;

		// Token: 0x04000932 RID: 2354
		private Label label3;

		// Token: 0x04000933 RID: 2355
		private Label label11;

		// Token: 0x04000934 RID: 2356
		private SiticoneButton siticoneButton1;
	}
}
