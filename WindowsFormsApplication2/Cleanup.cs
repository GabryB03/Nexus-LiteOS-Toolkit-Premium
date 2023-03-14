using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Login_HWID;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;

namespace WindowsFormsApplication2
{
	// Token: 0x0200000A RID: 10
	public class Cleanup : UserControl
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
		public static Cleanup Instance
		{
			get
			{
				if (Cleanup._instace == null)
				{
					Cleanup._instace = new Cleanup();
				}
				return Cleanup._instace;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public Cleanup()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000CD34 File Offset: 0x0000AF34
		private void LoadTheme()
		{
			int num = 0;
			while (num != 14 && num != 17 && num != 16)
			{
				if (num == 15)
				{
					goto IL_116;
				}
				IL_128:
				if (num == 13)
				{
					goto IL_EE;
				}
				IL_100:
				if (num == 12)
				{
					break;
				}
				if (num == 11)
				{
					goto IL_C6;
				}
				IL_D8:
				if (num == 10)
				{
					break;
				}
				string text;
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_116;
					}
					num = 10;
				}
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_EE;
					}
					num = 9;
				}
				if (num == 7)
				{
					if (text == "Xmas")
					{
						goto IL_C6;
					}
					num = 8;
				}
				if (num == 6)
				{
					if (text == null)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					object obj;
					text = obj as string;
					num = 6;
				}
				if (num == 4)
				{
					object obj2;
					object obj = obj2;
					num = 5;
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
				if (num != 18)
				{
					continue;
				}
				break;
				IL_C6:
				this.Xmas_theme();
				num = 12;
				goto IL_D8;
				IL_EE:
				this.Halloween();
				num = 14;
				goto IL_100;
				IL_116:
				this.AccentColor();
				num = 16;
				goto IL_128;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000CF84 File Offset: 0x0000B184
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

		// Token: 0x0600004D RID: 77 RVA: 0x0000CFFC File Offset: 0x0000B1FC
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

		// Token: 0x0600004E RID: 78 RVA: 0x0000D060 File Offset: 0x0000B260
		private void Halloween()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = base.Controls.OfType<CheckBox>().GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				while (enumerator.MoveNext())
				{
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.clean.FillColor = Color.FromArgb(255, 128, 0);
			this.cleanmgr.FillColor = Color.FromArgb(255, 128, 0);
			this.winsxs.FillColor = Color.FromArgb(255, 128, 0);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000D190 File Offset: 0x0000B390
		private void AccentColor()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			Color accentColor;
			do
			{
				if (num == 2)
				{
					enumerator = base.Controls.OfType<CheckBox>().GetEnumerator();
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
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = accentColor;
					siticoneCheckBox.CheckedState.FillColor = accentColor;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.clean.FillColor = accentColor;
			this.cleanmgr.FillColor = accentColor;
			this.winsxs.FillColor = accentColor;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = base.Controls.OfType<CheckBox>().GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				while (enumerator.MoveNext())
				{
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.clean.FillColor = Color.FromArgb(29, 158, 255);
			this.cleanmgr.FillColor = Color.FromArgb(29, 158, 255);
			this.winsxs.FillColor = Color.FromArgb(29, 158, 255);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		private void winsxs_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				Process process;
				if (num == 8)
				{
					process.Start();
					num = 9;
				}
				ProcessStartInfo processStartInfo;
				if (num == 7)
				{
					process.StartInfo = processStartInfo;
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Verb = "runas";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Arguments = "/C Dism.exe /online /Cleanup-Image /StartComponentCleanup /ResetBase";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 4;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		private void cleanmgr_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				Process process;
				if (num == 8)
				{
					process.Start();
					num = 9;
				}
				ProcessStartInfo processStartInfo;
				if (num == 7)
				{
					process.StartInfo = processStartInfo;
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Verb = "runas";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Arguments = "/C cmd.exe /c Cleanmgr /sageset:65535 & Cleanmgr /sagerun:65535";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 4;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		private void Flush_DNS()
		{
			int num = 0;
			do
			{
				Process process;
				if (num == 8)
				{
					process.Start();
					num = 9;
				}
				ProcessStartInfo processStartInfo;
				if (num == 7)
				{
					process.StartInfo = processStartInfo;
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Verb = "runas";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Arguments = "/C ipconfig /flushdns";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 4;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		private void clean_Click(object sender, EventArgs e)
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
				if (this.temp.Checked)
				{
					Cleaner.PreviewTemp();
				}
				if (this.bsod.Checked)
				{
					Cleaner.PreviewMinidumps();
				}
				if (this.error_rep.Checked)
				{
					Cleaner.PreviewErrorReports();
				}
				if (this.dns.Checked)
				{
					this.Flush_DNS();
				}
				if (this.internet.Checked)
				{
					Process.Start("C:\\Windows\\SysWOW64\\lv-LV\\Cookies.exe");
				}
				if (this.temp_internet.Checked)
				{
					Process.Start("C:\\Windows\\SysWOW64\\lv-LV\\net_temp.exe");
				}
				Cleaner.PreviewChromeClean(this.chromeCache.Checked, this.chromeCookies.Checked);
				Cleaner.PreviewFireFoxClean(this.firefoxCache.Checked, this.firefoxCookies.Checked);
				Cleaner.PreviewEdgeClean(this.edgeCache.Checked, this.edgeCookies.Checked);
				Cleaner.PreviewBraveClean(this.braveCache.Checked, this.braveCookies.Checked);
				Cleaner.PreviewVivaldiClean(this.vivaldiCache.Checked);
				Cleaner.PreviewOperaGXClean(this.operagxCache.Checked, this.operagxCookies.Checked);
			}
			catch (Exception)
			{
			}
			finally
			{
				this._cleanPreviewList = Cleaner.PreviewCleanList;
				this._cleanPreviewList.Sort();
				ListBox.ObjectCollection items = this.listCleanPreview.Items;
				object[] array = this._cleanPreviewList.ToArray();
				items.AddRange(array);
				for (int i = 0; i < this.listCleanPreview.Items.Count; i++)
				{
					this.listCleanPreview.SetItemChecked(i, true);
				}
				this.CleanPC();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000D928 File Offset: 0x0000BB28
		private void CleanPC()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			for (;;)
			{
				if (num == 14)
				{
					enumerator = base.Controls.OfType<CheckBox>().GetEnumerator();
					num = 15;
				}
				if (num == 13)
				{
					Cleaner.PreviewCleanList.Clear();
					num = 14;
				}
				if (num == 12)
				{
					this.listCleanPreview.Items.Clear();
					num = 13;
				}
				if (num == 11)
				{
					goto IL_62;
				}
				IL_6D:
				if (num == 10)
				{
					Cleaner.EmptyRecycleBin();
					num = 11;
				}
				if (num == 9)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_62;
					}
					num = 10;
				}
				if (num == 8)
				{
					bool @checked = this.recycle_bin.Checked;
					num = 9;
				}
				if (num != 7)
				{
					goto IL_BC;
				}
				bool flag;
				if (!flag)
				{
					num = 8;
					goto IL_BC;
				}
				goto IL_D3;
				IL_FD:
				if (num == 3)
				{
					goto IL_107;
				}
				int num2;
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 15)
				{
					break;
				}
				continue;
				IL_125:
				if (num == 5)
				{
					num2++;
					num = 6;
				}
				if (num == 4)
				{
					goto IL_D3;
				}
				goto IL_FD;
				IL_BC:
				if (num == 6)
				{
					goto IL_107;
				}
				goto IL_125;
				IL_D3:
				Cleaner.PreviewCleanList.Add(this.listCleanPreview.CheckedItems[num2].ToString());
				num = 5;
				goto IL_FD;
				IL_107:
				flag = num2 < this.listCleanPreview.CheckedItems.Count;
				num = 7;
				goto IL_125;
				IL_62:
				Cleaner.Clean();
				num = 12;
				goto IL_6D;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.Checked = false;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000DB28 File Offset: 0x0000BD28
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

		// Token: 0x06000057 RID: 87 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 4)
				{
					this.dns = new SiticoneCheckBox();
					num = 5;
				}
				if (num == 7)
				{
					this.temp_internet = new SiticoneCheckBox();
					num = 8;
				}
				if (num == 9)
				{
					this.error_rep = new SiticoneCheckBox();
					num = 10;
				}
				if (num == 11)
				{
					this.cleanmgr = new SiticoneButton();
					num = 12;
				}
				if (num == 14)
				{
					this.pictureBox1 = new PictureBox();
					num = 15;
				}
				if (num == 16)
				{
					this.label3 = new Label();
					num = 17;
				}
				if (num == 18)
				{
					this.label4 = new Label();
					num = 19;
				}
				if (num == 21)
				{
					this.braveCache = new SiticoneCheckBox();
					num = 22;
				}
				if (num == 23)
				{
					this.pictureBox4 = new PictureBox();
					num = 24;
				}
				if (num == 25)
				{
					this.chromeCache = new SiticoneCheckBox();
					num = 26;
				}
				if (num == 28)
				{
					this.firefoxCookies = new SiticoneCheckBox();
					num = 29;
				}
				if (num == 30)
				{
					this.label6 = new Label();
					num = 31;
				}
				if (num == 32)
				{
					this.listCleanPreview = new CheckedListBox();
					num = 33;
				}
				if (num == 35)
				{
					this.label7 = new Label();
					num = 36;
				}
				if (num == 37)
				{
					this.label8 = new Label();
					num = 38;
				}
				if (num == 39)
				{
					this.pictureBox7 = new PictureBox();
					num = 40;
				}
				if (num == 42)
				{
					((ISupportInitialize)this.pictureBox3).BeginInit();
					num = 43;
				}
				if (num == 44)
				{
					((ISupportInitialize)this.pictureBox5).BeginInit();
					num = 45;
				}
				if (num == 46)
				{
					((ISupportInitialize)this.pictureBox7).BeginInit();
					num = 47;
				}
				if (num == 49)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 50;
				}
				if (num == 51)
				{
					this.label1.Location = new Point(18, 0);
					num = 52;
				}
				if (num == 53)
				{
					this.label1.Size = new Size(152, 53);
					num = 54;
				}
				if (num == 56)
				{
					this.label9.AutoSize = true;
					num = 57;
				}
				if (num == 58)
				{
					this.label9.ForeColor = Color.Silver;
					num = 59;
				}
				if (num == 61)
				{
					this.label9.Size = new Size(192, 19);
					num = 62;
				}
				if (num == 63)
				{
					this.label9.Text = "Cleanup leftovers/temporary files";
					num = 64;
				}
				if (num == 65)
				{
					this.dns.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 66;
				}
				if (num == 68)
				{
					this.dns.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 69;
				}
				if (num == 70)
				{
					this.dns.ForeColor = Color.White;
					num = 71;
				}
				if (num == 72)
				{
					this.dns.Name = "dns";
					num = 73;
				}
				if (num == 75)
				{
					this.dns.Text = "DNS Cache";
					num = 76;
				}
				if (num == 77)
				{
					this.dns.UncheckedState.BorderRadius = 0;
					num = 78;
				}
				if (num == 79)
				{
					this.dns.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 80;
				}
				if (num == 82)
				{
					this.internet.CheckedState.BorderRadius = 0;
					num = 83;
				}
				if (num == 84)
				{
					this.internet.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 85;
				}
				if (num == 86)
				{
					this.internet.ForeColor = Color.White;
					num = 87;
				}
				if (num == 89)
				{
					this.internet.Size = new Size(138, 28);
					num = 90;
				}
				if (num == 91)
				{
					this.internet.Text = "Internet Cookies";
					num = 92;
				}
				if (num == 93)
				{
					this.internet.UncheckedState.BorderRadius = 0;
					num = 94;
				}
				if (num == 96)
				{
					this.temp.AutoSize = true;
					num = 97;
				}
				if (num == 98)
				{
					this.temp.CheckedState.BorderRadius = 0;
					num = 99;
				}
				if (num == 100)
				{
					this.temp.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 101;
				}
				if (num == 103)
				{
					this.temp.Location = new Point(79, 316);
					num = 104;
				}
				if (num == 105)
				{
					this.temp.Size = new Size(137, 28);
					num = 106;
				}
				if (num == 107)
				{
					this.temp.Text = "Temporary Files";
					num = 108;
				}
				if (num == 110)
				{
					this.temp.UncheckedState.BorderThickness = 0;
					num = 111;
				}
				if (num == 112)
				{
					this.temp_internet.AutoSize = true;
					num = 113;
				}
				if (num == 115)
				{
					this.temp_internet.CheckedState.BorderThickness = 0;
					num = 116;
				}
				if (num == 117)
				{
					this.temp_internet.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 118;
				}
				if (num == 119)
				{
					this.temp_internet.Location = new Point(79, 351);
					num = 120;
				}
				if (num == 122)
				{
					this.temp_internet.TabIndex = 122;
					num = 123;
				}
				if (num == 124)
				{
					this.temp_internet.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 125;
				}
				if (num == 126)
				{
					this.temp_internet.UncheckedState.BorderThickness = 0;
					num = 127;
				}
				if (num == 129)
				{
					this.bsod.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 130;
				}
				if (num == 131)
				{
					this.bsod.CheckedState.BorderThickness = 0;
					num = 132;
				}
				if (num == 133)
				{
					this.bsod.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 134;
				}
				if (num == 136)
				{
					this.bsod.Name = "bsod";
					num = 137;
				}
				if (num == 138)
				{
					this.bsod.TabIndex = 123;
					num = 139;
				}
				if (num == 140)
				{
					this.bsod.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 141;
				}
				if (num == 143)
				{
					this.bsod.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 144;
				}
				if (num == 145)
				{
					this.error_rep.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 146;
				}
				if (num == 147)
				{
					this.error_rep.CheckedState.BorderThickness = 0;
					num = 148;
				}
				if (num == 150)
				{
					this.error_rep.ForeColor = Color.White;
					num = 151;
				}
				if (num == 152)
				{
					this.error_rep.Name = "error_rep";
					num = 153;
				}
				if (num == 154)
				{
					this.error_rep.TabIndex = 124;
					num = 155;
				}
				if (num == 157)
				{
					this.error_rep.UncheckedState.BorderRadius = 0;
					num = 158;
				}
				if (num == 159)
				{
					this.error_rep.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 160;
				}
				if (num == 161)
				{
					this.recycle_bin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 162;
				}
				if (num == 164)
				{
					this.recycle_bin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 165;
				}
				if (num == 166)
				{
					this.recycle_bin.ForeColor = Color.White;
					num = 167;
				}
				if (num == 169)
				{
					this.recycle_bin.Size = new Size(154, 28);
					num = 170;
				}
				if (num == 171)
				{
					this.recycle_bin.Text = "Empty Recycle Bin";
					num = 172;
				}
				if (num == 173)
				{
					this.recycle_bin.UncheckedState.BorderRadius = 0;
					num = 174;
				}
				if (num == 176)
				{
					this.cleanmgr.CheckedState.Parent = this.cleanmgr;
					num = 177;
				}
				if (num == 178)
				{
					this.cleanmgr.DisabledState.BorderColor = Color.DarkGray;
					num = 179;
				}
				if (num == 180)
				{
					this.cleanmgr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 181;
				}
				if (num == 183)
				{
					this.cleanmgr.FillColor = Color.DodgerBlue;
					num = 184;
				}
				if (num == 185)
				{
					this.cleanmgr.ForeColor = Color.White;
					num = 186;
				}
				if (num == 187)
				{
					this.cleanmgr.ImageSize = new Size(30, 30);
					num = 188;
				}
				if (num == 190)
				{
					this.cleanmgr.ShadowDecoration.Parent = this.cleanmgr;
					num = 191;
				}
				if (num == 192)
				{
					this.cleanmgr.TabIndex = 311;
					num = 193;
				}
				if (num == 194)
				{
					this.cleanmgr.Click += this.cleanmgr_Click;
					num = 195;
				}
				if (num == 197)
				{
					this.winsxs.DisabledState.BorderColor = Color.DarkGray;
					num = 198;
				}
				if (num == 199)
				{
					this.winsxs.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 200;
				}
				if (num == 201)
				{
					this.winsxs.DisabledState.Parent = this.winsxs;
					num = 202;
				}
				if (num == 204)
				{
					this.winsxs.ForeColor = Color.White;
					num = 205;
				}
				if (num == 206)
				{
					this.winsxs.ImageSize = new Size(30, 30);
					num = 207;
				}
				if (num == 208)
				{
					this.winsxs.Name = "winsxs";
					num = 209;
				}
				if (num == 211)
				{
					this.winsxs.TabIndex = 312;
					num = 212;
				}
				if (num == 213)
				{
					this.winsxs.Click += this.winsxs_Click;
					num = 214;
				}
				if (num == 215)
				{
					this.clean.CustomImages.Parent = this.clean;
					num = 216;
				}
				if (num == 218)
				{
					this.clean.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 219;
				}
				if (num == 220)
				{
					this.clean.DisabledState.Parent = this.clean;
					num = 221;
				}
				if (num == 223)
				{
					this.clean.ForeColor = Color.White;
					num = 224;
				}
				if (num == 225)
				{
					this.clean.ImageSize = new Size(30, 30);
					num = 226;
				}
				if (num == 227)
				{
					this.clean.Name = "clean";
					num = 228;
				}
				if (num == 230)
				{
					this.clean.TabIndex = 313;
					num = 231;
				}
				if (num == 232)
				{
					this.clean.Click += this.clean_Click;
					num = 233;
				}
				if (num == 234)
				{
					this.pictureBox1.Location = new Point(38, 97);
					num = 235;
				}
				if (num == 237)
				{
					this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 238;
				}
				if (num == 239)
				{
					this.pictureBox1.TabStop = false;
					num = 240;
				}
				if (num == 241)
				{
					this.label2.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 242;
				}
				if (num == 244)
				{
					this.label2.Name = "label2";
					num = 245;
				}
				if (num == 246)
				{
					this.label2.TabIndex = 315;
					num = 247;
				}
				if (num == 248)
				{
					this.label3.AutoSize = true;
					num = 249;
				}
				if (num == 251)
				{
					this.label3.Location = new Point(74, 419);
					num = 252;
				}
				if (num == 253)
				{
					this.label3.Size = new Size(62, 30);
					num = 254;
				}
				if (num == 255)
				{
					this.label3.Text = "Brave";
					num = 256;
				}
				if (num == 258)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 259;
				}
				if (num == 260)
				{
					this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 261;
				}
				if (num == 262)
				{
					this.pictureBox2.TabStop = false;
					num = 263;
				}
				if (num == 265)
				{
					this.label4.ForeColor = Color.White;
					num = 266;
				}
				if (num == 267)
				{
					this.label4.Name = "label4";
					num = 268;
				}
				if (num == 269)
				{
					this.label4.TabIndex = 319;
					num = 270;
				}
				if (num == 272)
				{
					this.pictureBox3.Location = new Point(412, 97);
					num = 273;
				}
				if (num == 274)
				{
					this.pictureBox3.Size = new Size(30, 30);
					num = 275;
				}
				if (num == 276)
				{
					this.pictureBox3.TabIndex = 318;
					num = 277;
				}
				if (num == 279)
				{
					this.braveCookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 280;
				}
				if (num == 281)
				{
					this.braveCookies.CheckedState.BorderThickness = 0;
					num = 282;
				}
				if (num == 284)
				{
					this.braveCookies.ForeColor = Color.White;
					num = 285;
				}
				if (num == 286)
				{
					this.braveCookies.Name = "braveCookies";
					num = 287;
				}
				if (num == 288)
				{
					this.braveCookies.TabIndex = 321;
					num = 289;
				}
				if (num == 291)
				{
					this.braveCookies.UncheckedState.BorderRadius = 0;
					num = 292;
				}
				if (num == 293)
				{
					this.braveCookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 294;
				}
				if (num == 295)
				{
					this.braveCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 296;
				}
				if (num == 298)
				{
					this.braveCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 299;
				}
				if (num == 300)
				{
					this.braveCache.ForeColor = Color.White;
					num = 301;
				}
				if (num == 302)
				{
					this.braveCache.Name = "braveCache";
					num = 303;
				}
				if (num == 305)
				{
					this.braveCache.Text = "Cache";
					num = 306;
				}
				if (num == 307)
				{
					this.braveCache.UncheckedState.BorderRadius = 0;
					num = 308;
				}
				if (num == 309)
				{
					this.braveCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 310;
				}
				if (num == 312)
				{
					this.label5.ForeColor = Color.White;
					num = 313;
				}
				if (num == 314)
				{
					this.label5.Name = "label5";
					num = 315;
				}
				if (num == 316)
				{
					this.label5.TabIndex = 323;
					num = 317;
				}
				if (num == 319)
				{
					this.pictureBox4.Location = new Point(412, 255);
					num = 320;
				}
				if (num == 321)
				{
					this.pictureBox4.Size = new Size(30, 30);
					num = 322;
				}
				if (num == 323)
				{
					this.pictureBox4.TabIndex = 322;
					num = 324;
				}
				if (num == 326)
				{
					this.chromeCookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 327;
				}
				if (num == 328)
				{
					this.chromeCookies.CheckedState.BorderThickness = 0;
					num = 329;
				}
				if (num == 330)
				{
					this.chromeCookies.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 331;
				}
				if (num == 333)
				{
					this.chromeCookies.Name = "chromeCookies";
					num = 334;
				}
				if (num == 335)
				{
					this.chromeCookies.TabIndex = 325;
					num = 336;
				}
				if (num == 338)
				{
					this.chromeCookies.UncheckedState.BorderRadius = 0;
					num = 339;
				}
				if (num == 340)
				{
					this.chromeCookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 341;
				}
				if (num == 342)
				{
					this.chromeCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 343;
				}
				if (num == 345)
				{
					this.chromeCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 346;
				}
				if (num == 347)
				{
					this.chromeCache.ForeColor = Color.White;
					num = 348;
				}
				if (num == 349)
				{
					this.chromeCache.Name = "chromeCache";
					num = 350;
				}
				if (num == 352)
				{
					this.chromeCache.Text = "Cache";
					num = 353;
				}
				if (num == 354)
				{
					this.chromeCache.UncheckedState.BorderRadius = 0;
					num = 355;
				}
				if (num == 356)
				{
					this.chromeCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 357;
				}
				if (num == 359)
				{
					this.edgeCookies.CheckedState.BorderRadius = 0;
					num = 360;
				}
				if (num == 361)
				{
					this.edgeCookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 362;
				}
				if (num == 363)
				{
					this.edgeCookies.ForeColor = Color.White;
					num = 364;
				}
				if (num == 366)
				{
					this.edgeCookies.Size = new Size(80, 28);
					num = 367;
				}
				if (num == 368)
				{
					this.edgeCookies.Text = "Cookies";
					num = 369;
				}
				if (num == 370)
				{
					this.edgeCookies.UncheckedState.BorderRadius = 0;
					num = 371;
				}
				if (num == 373)
				{
					this.edgeCache.AutoSize = true;
					num = 374;
				}
				if (num == 375)
				{
					this.edgeCache.CheckedState.BorderRadius = 0;
					num = 376;
				}
				if (num == 377)
				{
					this.edgeCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 378;
				}
				if (num == 380)
				{
					this.edgeCache.Location = new Point(453, 303);
					num = 381;
				}
				if (num == 382)
				{
					this.edgeCache.Size = new Size(71, 28);
					num = 383;
				}
				if (num == 384)
				{
					this.edgeCache.Text = "Cache";
					num = 385;
				}
				if (num == 387)
				{
					this.edgeCache.UncheckedState.BorderThickness = 0;
					num = 388;
				}
				if (num == 389)
				{
					this.firefoxCookies.AutoSize = true;
					num = 390;
				}
				if (num == 392)
				{
					this.firefoxCookies.CheckedState.BorderThickness = 0;
					num = 393;
				}
				if (num == 394)
				{
					this.firefoxCookies.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 395;
				}
				if (num == 396)
				{
					this.firefoxCookies.Location = new Point(453, 502);
					num = 397;
				}
				if (num == 399)
				{
					this.firefoxCookies.TabIndex = 331;
					num = 400;
				}
				if (num == 401)
				{
					this.firefoxCookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 402;
				}
				if (num == 403)
				{
					this.firefoxCookies.UncheckedState.BorderThickness = 0;
					num = 404;
				}
				if (num == 406)
				{
					this.firefoxCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 407;
				}
				if (num == 408)
				{
					this.firefoxCache.CheckedState.BorderThickness = 0;
					num = 409;
				}
				if (num == 410)
				{
					this.firefoxCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 411;
				}
				if (num == 413)
				{
					this.firefoxCache.Name = "firefoxCache";
					num = 414;
				}
				if (num == 415)
				{
					this.firefoxCache.TabIndex = 330;
					num = 416;
				}
				if (num == 417)
				{
					this.firefoxCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 418;
				}
				if (num == 420)
				{
					this.firefoxCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 421;
				}
				if (num == 422)
				{
					this.label6.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 423;
				}
				if (num == 424)
				{
					this.label6.Location = new Point(448, 419);
					num = 425;
				}
				if (num == 427)
				{
					this.label6.TabIndex = 329;
					num = 428;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 429)
				{
					this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
					num = 430;
				}
				if (num == 431)
				{
					this.pictureBox5.Name = "pictureBox5";
					num = 432;
				}
				if (num == 434)
				{
					this.pictureBox5.TabIndex = 328;
					num = 435;
				}
				if (num == 436)
				{
					this.listCleanPreview.FormattingEnabled = true;
					num = 437;
				}
				if (num == 438)
				{
					this.listCleanPreview.Name = "listCleanPreview";
					num = 439;
				}
				if (num == 441)
				{
					this.operagxCookies.AutoSize = true;
					num = 442;
				}
				if (num == 443)
				{
					this.operagxCookies.CheckedState.BorderRadius = 0;
					num = 444;
				}
				if (num == 446)
				{
					this.operagxCookies.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 447;
				}
				if (num == 448)
				{
					this.operagxCookies.Location = new Point(784, 176);
					num = 449;
				}
				if (num == 450)
				{
					this.operagxCookies.Size = new Size(80, 28);
					num = 451;
				}
				if (num == 453)
				{
					this.operagxCookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 454;
				}
				if (num == 455)
				{
					this.operagxCookies.UncheckedState.BorderThickness = 0;
					num = 456;
				}
				if (num == 457)
				{
					this.operagxCache.AutoSize = true;
					num = 458;
				}
				if (num == 460)
				{
					this.operagxCache.CheckedState.BorderThickness = 0;
					num = 461;
				}
				if (num == 462)
				{
					this.operagxCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 463;
				}
				if (num == 464)
				{
					this.operagxCache.Location = new Point(784, 141);
					num = 465;
				}
				if (num == 467)
				{
					this.operagxCache.TabIndex = 335;
					num = 468;
				}
				if (num == 469)
				{
					this.operagxCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 470;
				}
				if (num == 471)
				{
					this.operagxCache.UncheckedState.BorderThickness = 0;
					num = 472;
				}
				if (num == 474)
				{
					this.label7.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 475;
				}
				if (num == 476)
				{
					this.label7.Location = new Point(779, 97);
					num = 477;
				}
				if (num == 478)
				{
					this.label7.Size = new Size(101, 30);
					num = 479;
				}
				if (num == 481)
				{
					this.vivaldiCache.AutoSize = true;
					num = 482;
				}
				if (num == 483)
				{
					this.vivaldiCache.CheckedState.BorderRadius = 0;
					num = 484;
				}
				if (num == 485)
				{
					this.vivaldiCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 486;
				}
				if (num == 488)
				{
					this.vivaldiCache.Location = new Point(784, 299);
					num = 489;
				}
				if (num == 490)
				{
					this.vivaldiCache.Size = new Size(71, 28);
					num = 491;
				}
				if (num == 492)
				{
					this.vivaldiCache.Text = "Cache";
					num = 493;
				}
				if (num == 495)
				{
					this.vivaldiCache.UncheckedState.BorderThickness = 0;
					num = 496;
				}
				if (num == 497)
				{
					this.label8.AutoSize = true;
					num = 498;
				}
				if (num == 500)
				{
					this.label8.Location = new Point(779, 255);
					num = 501;
				}
				if (num == 502)
				{
					this.label8.Size = new Size(73, 30);
					num = 503;
				}
				if (num == 504)
				{
					this.label8.Text = "Vivaldi";
					num = 505;
				}
				if (num == 507)
				{
					this.pictureBox6.Name = "pictureBox6";
					num = 508;
				}
				if (num == 509)
				{
					this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 510;
				}
				if (num == 511)
				{
					this.pictureBox6.TabStop = false;
					num = 512;
				}
				if (num == 514)
				{
					this.pictureBox7.Name = "pictureBox7";
					num = 515;
				}
				if (num == 516)
				{
					this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 517;
				}
				if (num == 518)
				{
					this.pictureBox7.TabStop = false;
					num = 519;
				}
				if (num == 521)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 522;
				}
				if (num == 523)
				{
					base.Controls.Add(this.label8);
					num = 524;
				}
				if (num == 525)
				{
					base.Controls.Add(this.operagxCookies);
					num = 526;
				}
				if (num == 528)
				{
					base.Controls.Add(this.pictureBox6);
					num = 529;
				}
				if (num == 530)
				{
					base.Controls.Add(this.firefoxCookies);
					num = 531;
				}
				if (num == 532)
				{
					base.Controls.Add(this.label6);
					num = 533;
				}
				if (num == 535)
				{
					base.Controls.Add(this.edgeCache);
					num = 536;
				}
				if (num == 537)
				{
					base.Controls.Add(this.chromeCache);
					num = 538;
				}
				if (num == 539)
				{
					base.Controls.Add(this.pictureBox4);
					num = 540;
				}
				if (num == 542)
				{
					base.Controls.Add(this.label4);
					num = 543;
				}
				if (num == 544)
				{
					base.Controls.Add(this.label3);
					num = 545;
				}
				if (num == 546)
				{
					base.Controls.Add(this.label2);
					num = 547;
				}
				if (num == 549)
				{
					base.Controls.Add(this.winsxs);
					num = 550;
				}
				if (num == 551)
				{
					base.Controls.Add(this.recycle_bin);
					num = 552;
				}
				if (num == 553)
				{
					base.Controls.Add(this.bsod);
					num = 554;
				}
				if (num == 556)
				{
					base.Controls.Add(this.internet);
					num = 557;
				}
				if (num == 558)
				{
					base.Controls.Add(this.label9);
					num = 559;
				}
				if (num == 561)
				{
					base.Size = new Size(1006, 669);
					num = 562;
				}
				if (num == 563)
				{
					((ISupportInitialize)this.pictureBox2).EndInit();
					num = 564;
				}
				if (num == 565)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 566;
				}
				if (num == 568)
				{
					((ISupportInitialize)this.pictureBox7).EndInit();
					num = 569;
				}
				if (num == 570)
				{
					base.PerformLayout();
					num = 571;
				}
				if (num == 569)
				{
					base.ResumeLayout(false);
					num = 570;
				}
				if (num == 567)
				{
					((ISupportInitialize)this.pictureBox6).EndInit();
					num = 568;
				}
				if (num == 566)
				{
					((ISupportInitialize)this.pictureBox5).EndInit();
					num = 567;
				}
				if (num == 564)
				{
					((ISupportInitialize)this.pictureBox3).EndInit();
					num = 565;
				}
				if (num == 562)
				{
					((ISupportInitialize)this.pictureBox1).EndInit();
					num = 563;
				}
				if (num == 560)
				{
					base.Name = "Cleanup";
					num = 561;
				}
				if (num == 559)
				{
					base.Controls.Add(this.label1);
					num = 560;
				}
				if (num == 557)
				{
					base.Controls.Add(this.dns);
					num = 558;
				}
				if (num == 555)
				{
					base.Controls.Add(this.temp);
					num = 556;
				}
				if (num == 554)
				{
					base.Controls.Add(this.temp_internet);
					num = 555;
				}
				if (num == 552)
				{
					base.Controls.Add(this.error_rep);
					num = 553;
				}
				if (num == 550)
				{
					base.Controls.Add(this.cleanmgr);
					num = 551;
				}
				if (num == 548)
				{
					base.Controls.Add(this.clean);
					num = 549;
				}
				if (num == 547)
				{
					base.Controls.Add(this.pictureBox1);
					num = 548;
				}
				if (num == 545)
				{
					base.Controls.Add(this.pictureBox2);
					num = 546;
				}
				if (num == 543)
				{
					base.Controls.Add(this.pictureBox3);
					num = 544;
				}
				if (num == 541)
				{
					base.Controls.Add(this.braveCache);
					num = 542;
				}
				if (num == 540)
				{
					base.Controls.Add(this.braveCookies);
					num = 541;
				}
				if (num == 538)
				{
					base.Controls.Add(this.label5);
					num = 539;
				}
				if (num == 536)
				{
					base.Controls.Add(this.chromeCookies);
					num = 537;
				}
				if (num == 534)
				{
					base.Controls.Add(this.edgeCookies);
					num = 535;
				}
				if (num == 533)
				{
					base.Controls.Add(this.pictureBox5);
					num = 534;
				}
				if (num == 531)
				{
					base.Controls.Add(this.firefoxCache);
					num = 532;
				}
				if (num == 529)
				{
					base.Controls.Add(this.listCleanPreview);
					num = 530;
				}
				if (num == 527)
				{
					base.Controls.Add(this.label7);
					num = 528;
				}
				if (num == 526)
				{
					base.Controls.Add(this.operagxCache);
					num = 527;
				}
				if (num == 524)
				{
					base.Controls.Add(this.pictureBox7);
					num = 525;
				}
				if (num == 522)
				{
					base.Controls.Add(this.vivaldiCache);
					num = 523;
				}
				if (num == 520)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 521;
				}
				if (num == 519)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 520;
				}
				if (num == 517)
				{
					this.pictureBox7.TabIndex = 337;
					num = 518;
				}
				if (num == 515)
				{
					this.pictureBox7.Size = new Size(30, 30);
					num = 516;
				}
				if (num == 513)
				{
					this.pictureBox7.Location = new Point(743, 255);
					num = 514;
				}
				if (num == 512)
				{
					this.pictureBox7.Image = (Image)componentResourceManager.GetObject("pictureBox7.Image");
					num = 513;
				}
				if (num == 510)
				{
					this.pictureBox6.TabIndex = 333;
					num = 511;
				}
				if (num == 508)
				{
					this.pictureBox6.Size = new Size(30, 30);
					num = 509;
				}
				if (num == 506)
				{
					this.pictureBox6.Location = new Point(743, 97);
					num = 507;
				}
				if (num == 505)
				{
					this.pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
					num = 506;
				}
				if (num == 503)
				{
					this.label8.TabIndex = 338;
					num = 504;
				}
				if (num == 501)
				{
					this.label8.Name = "label8";
					num = 502;
				}
				if (num == 499)
				{
					this.label8.ForeColor = Color.White;
					num = 500;
				}
				if (num == 498)
				{
					this.label8.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 499;
				}
				if (num == 496)
				{
					this.vivaldiCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 497;
				}
				if (num == 494)
				{
					this.vivaldiCache.UncheckedState.BorderRadius = 0;
					num = 495;
				}
				if (num == 493)
				{
					this.vivaldiCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 494;
				}
				if (num == 491)
				{
					this.vivaldiCache.TabIndex = 339;
					num = 492;
				}
				if (num == 489)
				{
					this.vivaldiCache.Name = "vivaldiCache";
					num = 490;
				}
				if (num == 487)
				{
					this.vivaldiCache.ForeColor = Color.White;
					num = 488;
				}
				if (num == 486)
				{
					this.vivaldiCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 487;
				}
				if (num == 484)
				{
					this.vivaldiCache.CheckedState.BorderThickness = 0;
					num = 485;
				}
				if (num == 482)
				{
					this.vivaldiCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 483;
				}
				if (num == 480)
				{
					this.label7.Text = "Opera GX";
					num = 481;
				}
				if (num == 479)
				{
					this.label7.TabIndex = 334;
					num = 480;
				}
				if (num == 477)
				{
					this.label7.Name = "label7";
					num = 478;
				}
				if (num == 475)
				{
					this.label7.ForeColor = Color.White;
					num = 476;
				}
				if (num == 473)
				{
					this.label7.AutoSize = true;
					num = 474;
				}
				if (num == 472)
				{
					this.operagxCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 473;
				}
				if (num == 470)
				{
					this.operagxCache.UncheckedState.BorderRadius = 0;
					num = 471;
				}
				if (num == 468)
				{
					this.operagxCache.Text = "Cache";
					num = 469;
				}
				if (num == 466)
				{
					this.operagxCache.Size = new Size(71, 28);
					num = 467;
				}
				if (num == 465)
				{
					this.operagxCache.Name = "operagxCache";
					num = 466;
				}
				if (num == 463)
				{
					this.operagxCache.ForeColor = Color.White;
					num = 464;
				}
				if (num == 461)
				{
					this.operagxCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 462;
				}
				if (num == 459)
				{
					this.operagxCache.CheckedState.BorderRadius = 0;
					num = 460;
				}
				if (num == 458)
				{
					this.operagxCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 459;
				}
				if (num == 456)
				{
					this.operagxCookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 457;
				}
				if (num == 454)
				{
					this.operagxCookies.UncheckedState.BorderRadius = 0;
					num = 455;
				}
				if (num == 452)
				{
					this.operagxCookies.Text = "Cookies";
					num = 453;
				}
				if (num == 451)
				{
					this.operagxCookies.TabIndex = 336;
					num = 452;
				}
				if (num == 449)
				{
					this.operagxCookies.Name = "operagxCookies";
					num = 450;
				}
				if (num == 447)
				{
					this.operagxCookies.ForeColor = Color.White;
					num = 448;
				}
				if (num == 445)
				{
					this.operagxCookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 446;
				}
				if (num == 444)
				{
					this.operagxCookies.CheckedState.BorderThickness = 0;
					num = 445;
				}
				if (num == 442)
				{
					this.operagxCookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 443;
				}
				if (num == 440)
				{
					this.listCleanPreview.TabIndex = 332;
					num = 441;
				}
				if (num == 439)
				{
					this.listCleanPreview.Size = new Size(28, 94);
					num = 440;
				}
				if (num == 437)
				{
					this.listCleanPreview.Location = new Point(-180, -10);
					num = 438;
				}
				if (num == 435)
				{
					this.pictureBox5.TabStop = false;
					num = 436;
				}
				if (num == 433)
				{
					this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 434;
				}
				if (num == 432)
				{
					this.pictureBox5.Size = new Size(30, 30);
					num = 433;
				}
				if (num == 430)
				{
					this.pictureBox5.Location = new Point(412, 419);
					num = 431;
				}
				if (num == 428)
				{
					this.label6.Text = "Mozilla Firefox";
					num = 429;
				}
				if (num == 426)
				{
					this.label6.Size = new Size(141, 30);
					num = 427;
				}
				if (num == 425)
				{
					this.label6.Name = "label6";
					num = 426;
				}
				if (num == 423)
				{
					this.label6.ForeColor = Color.White;
					num = 424;
				}
				if (num == 421)
				{
					this.label6.AutoSize = true;
					num = 422;
				}
				if (num == 419)
				{
					this.firefoxCache.UncheckedState.BorderThickness = 0;
					num = 420;
				}
				if (num == 418)
				{
					this.firefoxCache.UncheckedState.BorderRadius = 0;
					num = 419;
				}
				if (num == 416)
				{
					this.firefoxCache.Text = "Cache";
					num = 417;
				}
				if (num == 414)
				{
					this.firefoxCache.Size = new Size(71, 28);
					num = 415;
				}
				if (num == 412)
				{
					this.firefoxCache.Location = new Point(453, 467);
					num = 413;
				}
				if (num == 411)
				{
					this.firefoxCache.ForeColor = Color.White;
					num = 412;
				}
				if (num == 409)
				{
					this.firefoxCache.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 410;
				}
				if (num == 407)
				{
					this.firefoxCache.CheckedState.BorderRadius = 0;
					num = 408;
				}
				if (num == 405)
				{
					this.firefoxCache.AutoSize = true;
					num = 406;
				}
				if (num == 404)
				{
					this.firefoxCookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 405;
				}
				if (num == 402)
				{
					this.firefoxCookies.UncheckedState.BorderRadius = 0;
					num = 403;
				}
				if (num == 400)
				{
					this.firefoxCookies.Text = "Cookies";
					num = 401;
				}
				if (num == 398)
				{
					this.firefoxCookies.Size = new Size(80, 28);
					num = 399;
				}
				if (num == 397)
				{
					this.firefoxCookies.Name = "firefoxCookies";
					num = 398;
				}
				if (num == 395)
				{
					this.firefoxCookies.ForeColor = Color.White;
					num = 396;
				}
				if (num == 393)
				{
					this.firefoxCookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 394;
				}
				if (num == 391)
				{
					this.firefoxCookies.CheckedState.BorderRadius = 0;
					num = 392;
				}
				if (num == 390)
				{
					this.firefoxCookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 391;
				}
				if (num == 388)
				{
					this.edgeCache.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 389;
				}
				if (num == 386)
				{
					this.edgeCache.UncheckedState.BorderRadius = 0;
					num = 387;
				}
				if (num == 385)
				{
					this.edgeCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 386;
				}
				if (num == 383)
				{
					this.edgeCache.TabIndex = 326;
					num = 384;
				}
				if (num == 381)
				{
					this.edgeCache.Name = "edgeCache";
					num = 382;
				}
				if (num == 379)
				{
					this.edgeCache.ForeColor = Color.White;
					num = 380;
				}
				if (num == 378)
				{
					this.edgeCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 379;
				}
				if (num == 376)
				{
					this.edgeCache.CheckedState.BorderThickness = 0;
					num = 377;
				}
				if (num == 374)
				{
					this.edgeCache.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 375;
				}
				if (num == 372)
				{
					this.edgeCookies.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 373;
				}
				if (num == 371)
				{
					this.edgeCookies.UncheckedState.BorderThickness = 0;
					num = 372;
				}
				if (num == 369)
				{
					this.edgeCookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 370;
				}
				if (num == 367)
				{
					this.edgeCookies.TabIndex = 327;
					num = 368;
				}
				if (num == 365)
				{
					this.edgeCookies.Name = "edgeCookies";
					num = 366;
				}
				if (num == 364)
				{
					this.edgeCookies.Location = new Point(453, 338);
					num = 365;
				}
				if (num == 362)
				{
					this.edgeCookies.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 363;
				}
				if (num == 360)
				{
					this.edgeCookies.CheckedState.BorderThickness = 0;
					num = 361;
				}
				if (num == 358)
				{
					this.edgeCookies.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 359;
				}
				if (num == 357)
				{
					this.edgeCookies.AutoSize = true;
					num = 358;
				}
				if (num == 355)
				{
					this.chromeCache.UncheckedState.BorderThickness = 0;
					num = 356;
				}
				if (num == 353)
				{
					this.chromeCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 354;
				}
				if (num == 351)
				{
					this.chromeCache.TabIndex = 324;
					num = 352;
				}
				if (num == 350)
				{
					this.chromeCache.Size = new Size(71, 28);
					num = 351;
				}
				if (num == 348)
				{
					this.chromeCache.Location = new Point(453, 141);
					num = 349;
				}
				if (num == 346)
				{
					this.chromeCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 347;
				}
				if (num == 344)
				{
					this.chromeCache.CheckedState.BorderThickness = 0;
					num = 345;
				}
				if (num == 343)
				{
					this.chromeCache.CheckedState.BorderRadius = 0;
					num = 344;
				}
				if (num == 341)
				{
					this.chromeCache.AutoSize = true;
					num = 342;
				}
				if (num == 339)
				{
					this.chromeCookies.UncheckedState.BorderThickness = 0;
					num = 340;
				}
				if (num == 337)
				{
					this.chromeCookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 338;
				}
				if (num == 336)
				{
					this.chromeCookies.Text = "Cookies";
					num = 337;
				}
				if (num == 334)
				{
					this.chromeCookies.Size = new Size(80, 28);
					num = 335;
				}
				if (num == 332)
				{
					this.chromeCookies.Location = new Point(453, 176);
					num = 333;
				}
				if (num == 331)
				{
					this.chromeCookies.ForeColor = Color.White;
					num = 332;
				}
				if (num == 329)
				{
					this.chromeCookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 330;
				}
				if (num == 327)
				{
					this.chromeCookies.CheckedState.BorderRadius = 0;
					num = 328;
				}
				if (num == 325)
				{
					this.chromeCookies.AutoSize = true;
					num = 326;
				}
				if (num == 324)
				{
					this.pictureBox4.TabStop = false;
					num = 325;
				}
				if (num == 322)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 323;
				}
				if (num == 320)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 321;
				}
				if (num == 318)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 319;
				}
				if (num == 317)
				{
					this.label5.Text = "Microsoft Edge";
					num = 318;
				}
				if (num == 315)
				{
					this.label5.Size = new Size(144, 30);
					num = 316;
				}
				if (num == 313)
				{
					this.label5.Location = new Point(448, 255);
					num = 314;
				}
				if (num == 311)
				{
					this.label5.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 312;
				}
				if (num == 310)
				{
					this.label5.AutoSize = true;
					num = 311;
				}
				if (num == 308)
				{
					this.braveCache.UncheckedState.BorderThickness = 0;
					num = 309;
				}
				if (num == 306)
				{
					this.braveCache.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 307;
				}
				if (num == 304)
				{
					this.braveCache.TabIndex = 320;
					num = 305;
				}
				if (num == 303)
				{
					this.braveCache.Size = new Size(71, 28);
					num = 304;
				}
				if (num == 301)
				{
					this.braveCache.Location = new Point(79, 465);
					num = 302;
				}
				if (num == 299)
				{
					this.braveCache.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 300;
				}
				if (num == 297)
				{
					this.braveCache.CheckedState.BorderThickness = 0;
					num = 298;
				}
				if (num == 296)
				{
					this.braveCache.CheckedState.BorderRadius = 0;
					num = 297;
				}
				if (num == 294)
				{
					this.braveCache.AutoSize = true;
					num = 295;
				}
				if (num == 292)
				{
					this.braveCookies.UncheckedState.BorderThickness = 0;
					num = 293;
				}
				if (num == 290)
				{
					this.braveCookies.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 291;
				}
				if (num == 289)
				{
					this.braveCookies.Text = "Cookies";
					num = 290;
				}
				if (num == 287)
				{
					this.braveCookies.Size = new Size(80, 28);
					num = 288;
				}
				if (num == 285)
				{
					this.braveCookies.Location = new Point(79, 500);
					num = 286;
				}
				if (num == 283)
				{
					this.braveCookies.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 284;
				}
				if (num == 282)
				{
					this.braveCookies.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 283;
				}
				if (num == 280)
				{
					this.braveCookies.CheckedState.BorderRadius = 0;
					num = 281;
				}
				if (num == 278)
				{
					this.braveCookies.AutoSize = true;
					num = 279;
				}
				if (num == 277)
				{
					this.pictureBox3.TabStop = false;
					num = 278;
				}
				if (num == 275)
				{
					this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 276;
				}
				if (num == 273)
				{
					this.pictureBox3.Name = "pictureBox3";
					num = 274;
				}
				if (num == 271)
				{
					this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
					num = 272;
				}
				if (num == 270)
				{
					this.label4.Text = "Google Chrome";
					num = 271;
				}
				if (num == 268)
				{
					this.label4.Size = new Size(146, 30);
					num = 269;
				}
				if (num == 266)
				{
					this.label4.Location = new Point(448, 97);
					num = 267;
				}
				if (num == 264)
				{
					this.label4.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 265;
				}
				if (num == 263)
				{
					this.label4.AutoSize = true;
					num = 264;
				}
				if (num == 261)
				{
					this.pictureBox2.TabIndex = 316;
					num = 262;
				}
				if (num == 259)
				{
					this.pictureBox2.Size = new Size(30, 35);
					num = 260;
				}
				if (num == 257)
				{
					this.pictureBox2.Location = new Point(38, 419);
					num = 258;
				}
				if (num == 256)
				{
					this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 257;
				}
				if (num == 254)
				{
					this.label3.TabIndex = 317;
					num = 255;
				}
				if (num == 252)
				{
					this.label3.Name = "label3";
					num = 253;
				}
				if (num == 250)
				{
					this.label3.ForeColor = Color.White;
					num = 251;
				}
				if (num == 249)
				{
					this.label3.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 250;
				}
				if (num == 247)
				{
					this.label2.Text = "Windows";
					num = 248;
				}
				if (num == 245)
				{
					this.label2.Size = new Size(90, 30);
					num = 246;
				}
				if (num == 243)
				{
					this.label2.Location = new Point(74, 97);
					num = 244;
				}
				if (num == 242)
				{
					this.label2.ForeColor = Color.White;
					num = 243;
				}
				if (num == 240)
				{
					this.label2.AutoSize = true;
					num = 241;
				}
				if (num == 238)
				{
					this.pictureBox1.TabIndex = 314;
					num = 239;
				}
				if (num == 236)
				{
					this.pictureBox1.Size = new Size(30, 30);
					num = 237;
				}
				if (num == 235)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 236;
				}
				if (num == 233)
				{
					this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 234;
				}
				if (num == 231)
				{
					this.clean.Text = "Clean";
					num = 232;
				}
				if (num == 229)
				{
					this.clean.Size = new Size(161, 38);
					num = 230;
				}
				if (num == 228)
				{
					this.clean.ShadowDecoration.Parent = this.clean;
					num = 229;
				}
				if (num == 226)
				{
					this.clean.Location = new Point(481, 602);
					num = 227;
				}
				if (num == 224)
				{
					this.clean.HoverState.Parent = this.clean;
					num = 225;
				}
				if (num == 222)
				{
					this.clean.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 223;
				}
				if (num == 221)
				{
					this.clean.FillColor = Color.DodgerBlue;
					num = 222;
				}
				if (num == 219)
				{
					this.clean.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 220;
				}
				if (num == 217)
				{
					this.clean.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 218;
				}
				if (num == 216)
				{
					this.clean.DisabledState.BorderColor = Color.DarkGray;
					num = 217;
				}
				if (num == 214)
				{
					this.clean.CheckedState.Parent = this.clean;
					num = 215;
				}
				if (num == 212)
				{
					this.winsxs.Text = "WinSxS Cleanup";
					num = 213;
				}
				if (num == 210)
				{
					this.winsxs.Size = new Size(161, 38);
					num = 211;
				}
				if (num == 209)
				{
					this.winsxs.ShadowDecoration.Parent = this.winsxs;
					num = 210;
				}
				if (num == 207)
				{
					this.winsxs.Location = new Point(815, 602);
					num = 208;
				}
				if (num == 205)
				{
					this.winsxs.HoverState.Parent = this.winsxs;
					num = 206;
				}
				if (num == 203)
				{
					this.winsxs.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 204;
				}
				if (num == 202)
				{
					this.winsxs.FillColor = Color.DodgerBlue;
					num = 203;
				}
				if (num == 200)
				{
					this.winsxs.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 201;
				}
				if (num == 198)
				{
					this.winsxs.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 199;
				}
				if (num == 196)
				{
					this.winsxs.CustomImages.Parent = this.winsxs;
					num = 197;
				}
				if (num == 195)
				{
					this.winsxs.CheckedState.Parent = this.winsxs;
					num = 196;
				}
				if (num == 193)
				{
					this.cleanmgr.Text = "Disk Cleanup";
					num = 194;
				}
				if (num == 191)
				{
					this.cleanmgr.Size = new Size(161, 38);
					num = 192;
				}
				if (num == 189)
				{
					this.cleanmgr.Name = "cleanmgr";
					num = 190;
				}
				if (num == 188)
				{
					this.cleanmgr.Location = new Point(648, 602);
					num = 189;
				}
				if (num == 186)
				{
					this.cleanmgr.HoverState.Parent = this.cleanmgr;
					num = 187;
				}
				if (num == 184)
				{
					this.cleanmgr.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 185;
				}
				if (num == 182)
				{
					this.cleanmgr.DisabledState.Parent = this.cleanmgr;
					num = 183;
				}
				if (num == 181)
				{
					this.cleanmgr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 182;
				}
				if (num == 179)
				{
					this.cleanmgr.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 180;
				}
				if (num == 177)
				{
					this.cleanmgr.CustomImages.Parent = this.cleanmgr;
					num = 178;
				}
				if (num == 175)
				{
					this.recycle_bin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 176;
				}
				if (num == 174)
				{
					this.recycle_bin.UncheckedState.BorderThickness = 0;
					num = 175;
				}
				if (num == 172)
				{
					this.recycle_bin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 173;
				}
				if (num == 170)
				{
					this.recycle_bin.TabIndex = 125;
					num = 171;
				}
				if (num == 168)
				{
					this.recycle_bin.Name = "recycle_bin";
					num = 169;
				}
				if (num == 167)
				{
					this.recycle_bin.Location = new Point(79, 211);
					num = 168;
				}
				if (num == 165)
				{
					this.recycle_bin.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 166;
				}
				if (num == 163)
				{
					this.recycle_bin.CheckedState.BorderThickness = 0;
					num = 164;
				}
				if (num == 162)
				{
					this.recycle_bin.CheckedState.BorderRadius = 0;
					num = 163;
				}
				if (num == 160)
				{
					this.recycle_bin.AutoSize = true;
					num = 161;
				}
				if (num == 158)
				{
					this.error_rep.UncheckedState.BorderThickness = 0;
					num = 159;
				}
				if (num == 156)
				{
					this.error_rep.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 157;
				}
				if (num == 155)
				{
					this.error_rep.Text = "Error Reports";
					num = 156;
				}
				if (num == 153)
				{
					this.error_rep.Size = new Size(122, 28);
					num = 154;
				}
				if (num == 151)
				{
					this.error_rep.Location = new Point(79, 246);
					num = 152;
				}
				if (num == 149)
				{
					this.error_rep.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 150;
				}
				if (num == 148)
				{
					this.error_rep.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 149;
				}
				if (num == 146)
				{
					this.error_rep.CheckedState.BorderRadius = 0;
					num = 147;
				}
				if (num == 144)
				{
					this.error_rep.AutoSize = true;
					num = 145;
				}
				if (num == 142)
				{
					this.bsod.UncheckedState.BorderThickness = 0;
					num = 143;
				}
				if (num == 141)
				{
					this.bsod.UncheckedState.BorderRadius = 0;
					num = 142;
				}
				if (num == 139)
				{
					this.bsod.Text = "BSOD Minidumps";
					num = 140;
				}
				if (num == 137)
				{
					this.bsod.Size = new Size(150, 28);
					num = 138;
				}
				if (num == 135)
				{
					this.bsod.Location = new Point(79, 141);
					num = 136;
				}
				if (num == 134)
				{
					this.bsod.ForeColor = Color.White;
					num = 135;
				}
				if (num == 132)
				{
					this.bsod.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 133;
				}
				if (num == 130)
				{
					this.bsod.CheckedState.BorderRadius = 0;
					num = 131;
				}
				if (num == 128)
				{
					this.bsod.AutoSize = true;
					num = 129;
				}
				if (num == 127)
				{
					this.temp_internet.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 128;
				}
				if (num == 125)
				{
					this.temp_internet.UncheckedState.BorderRadius = 0;
					num = 126;
				}
				if (num == 123)
				{
					this.temp_internet.Text = "Temporary Internet Files";
					num = 124;
				}
				if (num == 121)
				{
					this.temp_internet.Size = new Size(195, 28);
					num = 122;
				}
				if (num == 120)
				{
					this.temp_internet.Name = "temp_internet";
					num = 121;
				}
				if (num == 118)
				{
					this.temp_internet.ForeColor = Color.White;
					num = 119;
				}
				if (num == 116)
				{
					this.temp_internet.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 117;
				}
				if (num == 114)
				{
					this.temp_internet.CheckedState.BorderRadius = 0;
					num = 115;
				}
				if (num == 113)
				{
					this.temp_internet.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 114;
				}
				if (num == 111)
				{
					this.temp.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 112;
				}
				if (num == 109)
				{
					this.temp.UncheckedState.BorderRadius = 0;
					num = 110;
				}
				if (num == 108)
				{
					this.temp.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 109;
				}
				if (num == 106)
				{
					this.temp.TabIndex = 121;
					num = 107;
				}
				if (num == 104)
				{
					this.temp.Name = "temp";
					num = 105;
				}
				if (num == 102)
				{
					this.temp.ForeColor = Color.White;
					num = 103;
				}
				if (num == 101)
				{
					this.temp.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 102;
				}
				if (num == 99)
				{
					this.temp.CheckedState.BorderThickness = 0;
					num = 100;
				}
				if (num == 97)
				{
					this.temp.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 98;
				}
				if (num == 95)
				{
					this.internet.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 96;
				}
				if (num == 94)
				{
					this.internet.UncheckedState.BorderThickness = 0;
					num = 95;
				}
				if (num == 92)
				{
					this.internet.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 93;
				}
				if (num == 90)
				{
					this.internet.TabIndex = 120;
					num = 91;
				}
				if (num == 88)
				{
					this.internet.Name = "internet";
					num = 89;
				}
				if (num == 87)
				{
					this.internet.Location = new Point(79, 281);
					num = 88;
				}
				if (num == 85)
				{
					this.internet.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 86;
				}
				if (num == 83)
				{
					this.internet.CheckedState.BorderThickness = 0;
					num = 84;
				}
				if (num == 81)
				{
					this.internet.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 82;
				}
				if (num == 80)
				{
					this.internet.AutoSize = true;
					num = 81;
				}
				if (num == 78)
				{
					this.dns.UncheckedState.BorderThickness = 0;
					num = 79;
				}
				if (num == 76)
				{
					this.dns.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 77;
				}
				if (num == 74)
				{
					this.dns.TabIndex = 119;
					num = 75;
				}
				if (num == 73)
				{
					this.dns.Size = new Size(109, 28);
					num = 74;
				}
				if (num == 71)
				{
					this.dns.Location = new Point(79, 176);
					num = 72;
				}
				if (num == 69)
				{
					this.dns.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 70;
				}
				if (num == 67)
				{
					this.dns.CheckedState.BorderThickness = 0;
					num = 68;
				}
				if (num == 66)
				{
					this.dns.CheckedState.BorderRadius = 0;
					num = 67;
				}
				if (num == 64)
				{
					this.dns.AutoSize = true;
					num = 65;
				}
				if (num == 62)
				{
					this.label9.TabIndex = 88;
					num = 63;
				}
				if (num == 60)
				{
					this.label9.Name = "label9";
					num = 61;
				}
				if (num == 59)
				{
					this.label9.Location = new Point(23, 53);
					num = 60;
				}
				if (num == 57)
				{
					this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 58;
				}
				if (num == 55)
				{
					this.label1.Text = "Cleanup";
					num = 56;
				}
				if (num == 54)
				{
					this.label1.TabIndex = 0;
					num = 55;
				}
				if (num == 52)
				{
					this.label1.Name = "label1";
					num = 53;
				}
				if (num == 50)
				{
					this.label1.ForeColor = Color.White;
					num = 51;
				}
				if (num == 48)
				{
					this.label1.AutoSize = true;
					num = 49;
				}
				if (num == 47)
				{
					base.SuspendLayout();
					num = 48;
				}
				if (num == 45)
				{
					((ISupportInitialize)this.pictureBox6).BeginInit();
					num = 46;
				}
				if (num == 43)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 44;
				}
				if (num == 41)
				{
					((ISupportInitialize)this.pictureBox2).BeginInit();
					num = 42;
				}
				if (num == 40)
				{
					((ISupportInitialize)this.pictureBox1).BeginInit();
					num = 41;
				}
				if (num == 38)
				{
					this.pictureBox6 = new PictureBox();
					num = 39;
				}
				if (num == 36)
				{
					this.vivaldiCache = new SiticoneCheckBox();
					num = 37;
				}
				if (num == 34)
				{
					this.operagxCache = new SiticoneCheckBox();
					num = 35;
				}
				if (num == 33)
				{
					this.operagxCookies = new SiticoneCheckBox();
					num = 34;
				}
				if (num == 31)
				{
					this.pictureBox5 = new PictureBox();
					num = 32;
				}
				if (num == 29)
				{
					this.firefoxCache = new SiticoneCheckBox();
					num = 30;
				}
				if (num == 27)
				{
					this.edgeCache = new SiticoneCheckBox();
					num = 28;
				}
				if (num == 26)
				{
					this.edgeCookies = new SiticoneCheckBox();
					num = 27;
				}
				if (num == 24)
				{
					this.chromeCookies = new SiticoneCheckBox();
					num = 25;
				}
				if (num == 22)
				{
					this.label5 = new Label();
					num = 23;
				}
				if (num == 20)
				{
					this.braveCookies = new SiticoneCheckBox();
					num = 21;
				}
				if (num == 19)
				{
					this.pictureBox3 = new PictureBox();
					num = 20;
				}
				if (num == 17)
				{
					this.pictureBox2 = new PictureBox();
					num = 18;
				}
				if (num == 15)
				{
					this.label2 = new Label();
					num = 16;
				}
				if (num == 13)
				{
					this.clean = new SiticoneButton();
					num = 14;
				}
				if (num == 12)
				{
					this.winsxs = new SiticoneButton();
					num = 13;
				}
				if (num == 10)
				{
					this.recycle_bin = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 8)
				{
					this.bsod = new SiticoneCheckBox();
					num = 9;
				}
				if (num == 6)
				{
					this.temp = new SiticoneCheckBox();
					num = 7;
				}
				if (num == 5)
				{
					this.internet = new SiticoneCheckBox();
					num = 6;
				}
				if (num == 3)
				{
					this.label9 = new Label();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Cleanup));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 571);
		}

		// Token: 0x04000065 RID: 101
		private static Cleanup _instace;

		// Token: 0x04000066 RID: 102
		private List<string> _cleanPreviewList;

		// Token: 0x04000067 RID: 103
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000068 RID: 104
		private IContainer components = null;

		// Token: 0x04000069 RID: 105
		private Label label1;

		// Token: 0x0400006A RID: 106
		private Label label9;

		// Token: 0x0400006B RID: 107
		private SiticoneCheckBox dns;

		// Token: 0x0400006C RID: 108
		private SiticoneCheckBox internet;

		// Token: 0x0400006D RID: 109
		private SiticoneCheckBox temp;

		// Token: 0x0400006E RID: 110
		private SiticoneCheckBox temp_internet;

		// Token: 0x0400006F RID: 111
		private SiticoneCheckBox bsod;

		// Token: 0x04000070 RID: 112
		private SiticoneCheckBox error_rep;

		// Token: 0x04000071 RID: 113
		private SiticoneCheckBox recycle_bin;

		// Token: 0x04000072 RID: 114
		private SiticoneButton cleanmgr;

		// Token: 0x04000073 RID: 115
		private SiticoneButton winsxs;

		// Token: 0x04000074 RID: 116
		private SiticoneButton clean;

		// Token: 0x04000075 RID: 117
		private PictureBox pictureBox1;

		// Token: 0x04000076 RID: 118
		private Label label2;

		// Token: 0x04000077 RID: 119
		private Label label3;

		// Token: 0x04000078 RID: 120
		private PictureBox pictureBox2;

		// Token: 0x04000079 RID: 121
		private Label label4;

		// Token: 0x0400007A RID: 122
		private PictureBox pictureBox3;

		// Token: 0x0400007B RID: 123
		private SiticoneCheckBox braveCookies;

		// Token: 0x0400007C RID: 124
		private SiticoneCheckBox braveCache;

		// Token: 0x0400007D RID: 125
		private Label label5;

		// Token: 0x0400007E RID: 126
		private PictureBox pictureBox4;

		// Token: 0x0400007F RID: 127
		private SiticoneCheckBox chromeCookies;

		// Token: 0x04000080 RID: 128
		private SiticoneCheckBox chromeCache;

		// Token: 0x04000081 RID: 129
		private SiticoneCheckBox edgeCookies;

		// Token: 0x04000082 RID: 130
		private SiticoneCheckBox edgeCache;

		// Token: 0x04000083 RID: 131
		private SiticoneCheckBox firefoxCookies;

		// Token: 0x04000084 RID: 132
		private SiticoneCheckBox firefoxCache;

		// Token: 0x04000085 RID: 133
		private Label label6;

		// Token: 0x04000086 RID: 134
		private PictureBox pictureBox5;

		// Token: 0x04000087 RID: 135
		private CheckedListBox listCleanPreview;

		// Token: 0x04000088 RID: 136
		private SiticoneCheckBox operagxCookies;

		// Token: 0x04000089 RID: 137
		private SiticoneCheckBox operagxCache;

		// Token: 0x0400008A RID: 138
		private Label label7;

		// Token: 0x0400008B RID: 139
		private SiticoneCheckBox vivaldiCache;

		// Token: 0x0400008C RID: 140
		private Label label8;

		// Token: 0x0400008D RID: 141
		private PictureBox pictureBox6;

		// Token: 0x0400008E RID: 142
		private PictureBox pictureBox7;
	}
}
