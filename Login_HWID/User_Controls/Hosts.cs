using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000068 RID: 104
	public class Hosts : UserControl
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0016A098 File Offset: 0x00168298
		public static Hosts Instance
		{
			get
			{
				if (Hosts._instace == null)
				{
					Hosts._instace = new Hosts();
				}
				return Hosts._instace;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0016A0C0 File Offset: 0x001682C0
		public Hosts()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0016A130 File Offset: 0x00168330
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
					goto IL_34;
				}
				string text;
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_34;
				}
				goto IL_87;
				IL_99:
				if (num == 11)
				{
					goto IL_EC;
				}
				IL_FE:
				if (num == 10)
				{
					break;
				}
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_111;
					}
					num = 10;
				}
				if (num == 7)
				{
					if (text == "Xmas")
					{
						goto IL_EC;
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
				if (num == 18)
				{
					break;
				}
				continue;
				IL_EC:
				this.Xmas_theme();
				num = 12;
				goto IL_FE;
				IL_123:
				if (num == 14)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_87;
				}
				goto IL_99;
				IL_34:
				if (num == 12 || num == 16 || num == 17)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_111;
				}
				goto IL_123;
				IL_87:
				this.Halloween();
				num = 14;
				goto IL_99;
				IL_111:
				this.AccentColor();
				num = 16;
				goto IL_123;
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0016A37C File Offset: 0x0016857C
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

		// Token: 0x0600095C RID: 2396 RVA: 0x0016A3F4 File Offset: 0x001685F4
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

		// Token: 0x0600095D RID: 2397 RVA: 0x0016A458 File Offset: 0x00168658
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.read_only.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 8)
				{
					this.reset.FillColor = Color.FromArgb(255, 128, 0);
					num = 9;
				}
				if (num == 7)
				{
					this.undo.FillColor = Color.FromArgb(255, 128, 0);
					num = 8;
				}
				if (num == 6)
				{
					this.save.FillColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 5)
				{
					this.read_only.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 6;
				}
				if (num == 3)
				{
					this.hosts_loc.VisitedLinkColor = Color.FromArgb(255, 128, 0);
					num = 4;
				}
				if (num == 2)
				{
					this.hosts_loc.LinkColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.hosts_loc.ActiveLinkColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0016A62C File Offset: 0x0016882C
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 4)
				{
					this.hosts_loc.VisitedLinkColor = accentColor;
					num = 5;
				}
				if (num == 8)
				{
					this.undo.FillColor = accentColor;
					num = 9;
				}
				if (num == 9)
				{
					this.reset.FillColor = accentColor;
					num = 10;
				}
				if (num == 7)
				{
					this.save.FillColor = accentColor;
					num = 8;
				}
				if (num == 6)
				{
					this.read_only.CheckedState.BorderColor = accentColor;
					num = 7;
				}
				if (num == 5)
				{
					this.read_only.CheckedState.FillColor = accentColor;
					num = 6;
				}
				if (num == 3)
				{
					this.hosts_loc.LinkColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.hosts_loc.ActiveLinkColor = accentColor;
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
			while (num != 10);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0016A7DC File Offset: 0x001689DC
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.read_only.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 8)
				{
					this.reset.FillColor = Color.FromArgb(29, 158, 255);
					num = 9;
				}
				if (num == 7)
				{
					this.undo.FillColor = Color.FromArgb(29, 158, 255);
					num = 8;
				}
				if (num == 6)
				{
					this.save.FillColor = Color.FromArgb(29, 158, 255);
					num = 7;
				}
				if (num == 5)
				{
					this.read_only.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 6;
				}
				if (num == 3)
				{
					this.hosts_loc.VisitedLinkColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 2)
				{
					this.hosts_loc.LinkColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.hosts_loc.ActiveLinkColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0016A9B0 File Offset: 0x00168BB0
		private void optimization_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.backup = File.ReadAllText(this.HostsPath).ToString();
					num = 3;
				}
				if (num == 1)
				{
					this.hosts_editor.Text = File.ReadAllText(this.HostsPath).ToString();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0016AA5C File Offset: 0x00168C5C
		private void hosts_loc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("explorer.exe", Environment.ExpandEnvironmentVariables("%SystemDrive%\\Windows\\System32\\drivers\\etc\\"));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0016AAC4 File Offset: 0x00168CC4
		private void back_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					IPv4.Instance.Show();
					num = 5;
				}
				if (num == 3)
				{
					IPv4.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					IPv4.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					base.Controls.Add(IPv4.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0016AB70 File Offset: 0x00168D70
		private void undo_Click(object sender, EventArgs e)
		{
			int num = 0;
			reverted reverted;
			for (;;)
			{
				bool @checked;
				if (num == 4)
				{
					@checked = this.read_only.Checked;
					num = 5;
				}
				if (num == 8)
				{
					goto IL_48;
				}
				IL_54:
				if (num != 7)
				{
					if (num == 6)
					{
						File.SetAttributes(this.HostsPath, FileAttributes.ReadOnly);
						num = 7;
					}
					if (num == 5)
					{
						if (!@checked)
						{
							goto IL_48;
						}
						num = 6;
					}
					if (num == 3)
					{
						File.WriteAllText(this.HostsPath, this.backup);
						num = 4;
					}
					if (num == 2)
					{
						this.hosts_editor.Text = this.backup;
						num = 3;
					}
					if (num == 1)
					{
						File.SetAttributes(this.HostsPath, FileAttributes.Normal);
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 9)
					{
						break;
					}
					continue;
				}
				IL_48:
				reverted = new reverted();
				num = 9;
				goto IL_54;
			}
			try
			{
				reverted.ShowDialog(this);
			}
			finally
			{
				if (reverted != null)
				{
					((IDisposable)reverted).Dispose();
				}
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0016ACC0 File Offset: 0x00168EC0
		private void reset_Click(object sender, EventArgs e)
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
				File.SetAttributes(this.HostsPath, FileAttributes.Normal);
				this.hosts_editor.Text = this.defaulthosts;
				File.WriteAllText(this.HostsPath, this.defaulthosts);
				if (this.read_only.Checked)
				{
					File.SetAttributes(this.HostsPath, FileAttributes.ReadOnly);
				}
				using (reverted reverted = new reverted())
				{
					reverted.ShowDialog(this);
				}
			}
			catch (Exception)
			{
				using (dns dns = new dns())
				{
					dns.ShowDialog(this);
				}
				this.hosts_editor.Text = File.ReadAllText(this.HostsPath).ToString();
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0016ADE0 File Offset: 0x00168FE0
		private void save_Click(object sender, EventArgs e)
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
				if (string.IsNullOrEmpty(this.hosts_editor.Text) || string.IsNullOrWhiteSpace(this.hosts_editor.Text))
				{
					File.SetAttributes(this.HostsPath, FileAttributes.Normal);
					File.WriteAllText(this.HostsPath, this.defaulthosts);
					if (this.read_only.Checked)
					{
						File.SetAttributes(this.HostsPath, FileAttributes.ReadOnly);
					}
					using (applied applied = new applied())
					{
						applied.ShowDialog(this);
						goto IL_131;
					}
				}
				File.SetAttributes(this.HostsPath, FileAttributes.Normal);
				File.WriteAllText(this.HostsPath, this.hosts_editor.Text);
				if (this.read_only.Checked)
				{
					File.SetAttributes(this.HostsPath, FileAttributes.ReadOnly);
				}
				using (applied applied2 = new applied())
				{
					applied2.ShowDialog(this);
				}
				IL_131:;
			}
			catch (Exception)
			{
				using (dns dns = new dns())
				{
					dns.ShowDialog(this);
				}
				this.hosts_editor.Text = File.ReadAllText(this.HostsPath).ToString();
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0016AFC8 File Offset: 0x001691C8
		private void refresh_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.hosts_editor.Text = File.ReadAllText(this.HostsPath).ToString();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00018F88 File Offset: 0x00017188
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0016B03C File Offset: 0x0016923C
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

		// Token: 0x06000969 RID: 2409 RVA: 0x0016B0B4 File Offset: 0x001692B4
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.hosts_editor = new RichTextBox();
					num = 5;
				}
				if (num == 8)
				{
					this.back_btn = new SiticoneRoundedButton();
					num = 9;
				}
				if (num == 12)
				{
					this.refresh = new SiticoneButton();
					num = 13;
				}
				if (num == 16)
				{
					this.label37.AutoSize = true;
					num = 17;
				}
				if (num == 20)
				{
					this.label37.Name = "label37";
					num = 21;
				}
				if (num == 24)
				{
					this.label1.AutoSize = true;
					num = 25;
				}
				if (num == 28)
				{
					this.label1.Name = "label1";
					num = 29;
				}
				if (num == 32)
				{
					this.label2.AutoSize = true;
					num = 33;
				}
				if (num == 36)
				{
					this.label2.Name = "label2";
					num = 37;
				}
				if (num == 40)
				{
					this.hosts_editor.BackColor = Color.FromArgb(38, 38, 38);
					num = 41;
				}
				if (num == 44)
				{
					this.hosts_editor.Location = new Point(27, 145);
					num = 45;
				}
				if (num == 48)
				{
					this.hosts_editor.Text = "";
					num = 49;
				}
				if (num == 53)
				{
					this.save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 54;
				}
				if (num == 57)
				{
					this.save.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 58;
				}
				if (num == 61)
				{
					this.save.Location = new Point(722, 236);
					num = 62;
				}
				if (num == 65)
				{
					this.save.TabIndex = 310;
					num = 66;
				}
				if (num == 69)
				{
					this.undo.CustomImages.Parent = this.undo;
					num = 70;
				}
				if (num == 73)
				{
					this.undo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 74;
				}
				if (num == 77)
				{
					this.undo.ForeColor = Color.White;
					num = 78;
				}
				if (num == 81)
				{
					this.undo.Name = "undo";
					num = 82;
				}
				if (num == 85)
				{
					this.undo.Text = "Undo Changes";
					num = 86;
				}
				if (num == 89)
				{
					this.reset.DisabledState.BorderColor = Color.DarkGray;
					num = 90;
				}
				if (num == 93)
				{
					this.reset.DisabledState.Parent = this.reset;
					num = 94;
				}
				if (num == 97)
				{
					this.reset.HoverState.Parent = this.reset;
					num = 98;
				}
				if (num == 102)
				{
					this.reset.Size = new Size(256, 38);
					num = 103;
				}
				if (num == 106)
				{
					this.back_btn.BackColor = Color.Transparent;
					num = 107;
				}
				if (num == 110)
				{
					this.back_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 111;
				}
				if (num == 114)
				{
					this.back_btn.DisabledState.Parent = this.back_btn;
					num = 115;
				}
				if (num == 118)
				{
					this.back_btn.HoverState.Parent = this.back_btn;
					num = 119;
				}
				if (num == 122)
				{
					this.back_btn.Size = new Size(88, 30);
					num = 123;
				}
				if (num == 126)
				{
					this.hosts_loc.ActiveLinkColor = Color.DeepSkyBlue;
					num = 127;
				}
				if (num == 130)
				{
					this.hosts_loc.Location = new Point(717, 145);
					num = 131;
				}
				if (num == 134)
				{
					this.hosts_loc.TabStop = true;
					num = 135;
				}
				if (num == 138)
				{
					this.read_only.AutoSize = true;
					num = 139;
				}
				if (num == 142)
				{
					this.read_only.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 143;
				}
				if (num == 146)
				{
					this.read_only.Name = "read_only";
					num = 147;
				}
				if (num == 151)
				{
					this.read_only.UncheckedState.BorderRadius = 0;
					num = 152;
				}
				if (num == 155)
				{
					this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 156;
				}
				if (num == 159)
				{
					this.label5.Size = new Size(225, 19);
					num = 160;
				}
				if (num == 163)
				{
					this.refresh.CustomImages.Parent = this.refresh;
					num = 164;
				}
				if (num == 167)
				{
					this.refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 168;
				}
				if (num == 171)
				{
					this.refresh.ForeColor = Color.White;
					num = 172;
				}
				if (num == 175)
				{
					this.refresh.Name = "refresh";
					num = 176;
				}
				if (num == 179)
				{
					this.refresh.Text = "Refresh";
					num = 180;
				}
				if (num == 183)
				{
					this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
					num = 184;
				}
				if (num == 187)
				{
					this.siticoneRoundedButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 188;
				}
				if (num == 191)
				{
					this.siticoneRoundedButton1.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 192;
				}
				if (num == 195)
				{
					this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
					num = 196;
				}
				if (num == 200)
				{
					this.siticoneRoundedButton1.Click += this.siticoneRoundedButton1_Click;
					num = 201;
				}
				if (num == 204)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 205;
				}
				if (num == 208)
				{
					this.siticoneVScrollBar1.Maximum = 2861;
					num = 209;
				}
				if (num == 212)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 503);
					num = 213;
				}
				if (num == 216)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 217;
				}
				if (num == 220)
				{
					base.Controls.Add(this.siticoneRoundedButton1);
					num = 221;
				}
				if (num == 224)
				{
					base.Controls.Add(this.hosts_loc);
					num = 225;
				}
				if (num == 228)
				{
					base.Controls.Add(this.save);
					num = 229;
				}
				if (num == 232)
				{
					base.Controls.Add(this.label1);
					num = 233;
				}
				if (num == 236)
				{
					base.ResumeLayout(false);
					num = 237;
				}
				if (num == 237)
				{
					base.PerformLayout();
					num = 238;
				}
				if (num == 235)
				{
					base.Load += this.optimization_Load;
					num = 236;
				}
				if (num == 234)
				{
					base.Size = new Size(1006, 669);
					num = 235;
				}
				if (num == 233)
				{
					base.Name = "Hosts";
					num = 234;
				}
				if (num == 231)
				{
					base.Controls.Add(this.label37);
					num = 232;
				}
				if (num == 230)
				{
					base.Controls.Add(this.label2);
					num = 231;
				}
				if (num == 229)
				{
					base.Controls.Add(this.hosts_editor);
					num = 230;
				}
				if (num == 227)
				{
					base.Controls.Add(this.undo);
					num = 228;
				}
				if (num == 226)
				{
					base.Controls.Add(this.reset);
					num = 227;
				}
				if (num == 225)
				{
					base.Controls.Add(this.back_btn);
					num = 226;
				}
				if (num == 223)
				{
					base.Controls.Add(this.read_only);
					num = 224;
				}
				if (num == 222)
				{
					base.Controls.Add(this.label5);
					num = 223;
				}
				if (num == 221)
				{
					base.Controls.Add(this.refresh);
					num = 222;
				}
				if (num == 219)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 220;
				}
				if (num == 218)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 219;
				}
				if (num == 217)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 218;
				}
				if (num == 215)
				{
					this.siticoneVScrollBar1.ThumbSize = 503f;
					num = 216;
				}
				if (num == 214)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 215;
				}
				if (num == 213)
				{
					this.siticoneVScrollBar1.TabIndex = 337;
					num = 214;
				}
				if (num == 211)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 212;
				}
				if (num == 210)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 211;
				}
				if (num == 209)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 210;
				}
				if (num == 207)
				{
					this.siticoneVScrollBar1.Location = new Point(681, 145);
					num = 208;
				}
				if (num == 206)
				{
					this.siticoneVScrollBar1.LargeChange = 100;
					num = 207;
				}
				if (num == 205)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 206;
				}
				if (num == 203)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 204;
				}
				if (num == 202)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 203;
				}
				if (num == 201)
				{
					this.siticoneVScrollBar1.BindingContainer = this.hosts_editor;
					num = 202;
				}
				if (num == 199)
				{
					this.siticoneRoundedButton1.Text = "Back";
					num = 200;
				}
				if (num == 198)
				{
					this.siticoneRoundedButton1.TabIndex = 324;
					num = 199;
				}
				if (num == 197)
				{
					this.siticoneRoundedButton1.Size = new Size(88, 30);
					num = 198;
				}
				if (num == 196)
				{
					this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
					num = 197;
				}
				if (num == 194)
				{
					this.siticoneRoundedButton1.Location = new Point(782, 53);
					num = 195;
				}
				if (num == 193)
				{
					this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
					num = 194;
				}
				if (num == 192)
				{
					this.siticoneRoundedButton1.ForeColor = Color.White;
					num = 193;
				}
				if (num == 190)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 191;
				}
				if (num == 189)
				{
					this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
					num = 190;
				}
				if (num == 188)
				{
					this.siticoneRoundedButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 189;
				}
				if (num == 186)
				{
					this.siticoneRoundedButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 187;
				}
				if (num == 185)
				{
					this.siticoneRoundedButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 186;
				}
				if (num == 184)
				{
					this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
					num = 185;
				}
				if (num == 182)
				{
					this.siticoneRoundedButton1.BorderRadius = 14;
					num = 183;
				}
				if (num == 181)
				{
					this.siticoneRoundedButton1.BackColor = Color.Transparent;
					num = 182;
				}
				if (num == 180)
				{
					this.refresh.Click += this.refresh_Click;
					num = 181;
				}
				if (num == 178)
				{
					this.refresh.TabIndex = 323;
					num = 179;
				}
				if (num == 177)
				{
					this.refresh.Size = new Size(99, 38);
					num = 178;
				}
				if (num == 176)
				{
					this.refresh.ShadowDecoration.Parent = this.refresh;
					num = 177;
				}
				if (num == 174)
				{
					this.refresh.Location = new Point(600, 101);
					num = 175;
				}
				if (num == 173)
				{
					this.refresh.ImageSize = new Size(30, 30);
					num = 174;
				}
				if (num == 172)
				{
					this.refresh.HoverState.Parent = this.refresh;
					num = 173;
				}
				if (num == 170)
				{
					this.refresh.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 171;
				}
				if (num == 169)
				{
					this.refresh.FillColor = Color.FromArgb(38, 38, 38);
					num = 170;
				}
				if (num == 168)
				{
					this.refresh.DisabledState.Parent = this.refresh;
					num = 169;
				}
				if (num == 166)
				{
					this.refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 167;
				}
				if (num == 165)
				{
					this.refresh.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 166;
				}
				if (num == 164)
				{
					this.refresh.DisabledState.BorderColor = Color.DarkGray;
					num = 165;
				}
				if (num == 162)
				{
					this.refresh.CheckedState.Parent = this.refresh;
					num = 163;
				}
				if (num == 161)
				{
					this.label5.Text = "(Protect hosts file from being modified)";
					num = 162;
				}
				if (num == 160)
				{
					this.label5.TabIndex = 322;
					num = 161;
				}
				if (num == 158)
				{
					this.label5.Name = "label5";
					num = 159;
				}
				if (num == 157)
				{
					this.label5.Location = new Point(718, 204);
					num = 158;
				}
				if (num == 156)
				{
					this.label5.ForeColor = Color.Silver;
					num = 157;
				}
				if (num == 154)
				{
					this.label5.AutoSize = true;
					num = 155;
				}
				if (num == 153)
				{
					this.read_only.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 154;
				}
				if (num == 152)
				{
					this.read_only.UncheckedState.BorderThickness = 0;
					num = 153;
				}
				if (num == 150)
				{
					this.read_only.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 151;
				}
				if (num == 149)
				{
					this.read_only.Text = "Read Only";
					num = 150;
				}
				if (num == 148)
				{
					this.read_only.TabIndex = 320;
					num = 149;
				}
				if (num == 147)
				{
					this.read_only.Size = new Size(102, 28);
					num = 148;
				}
				if (num == 145)
				{
					this.read_only.Location = new Point(722, 173);
					num = 146;
				}
				if (num == 144)
				{
					this.read_only.ForeColor = Color.White;
					num = 145;
				}
				if (num == 143)
				{
					this.read_only.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 144;
				}
				if (num == 141)
				{
					this.read_only.CheckedState.BorderThickness = 0;
					num = 142;
				}
				if (num == 140)
				{
					this.read_only.CheckedState.BorderRadius = 0;
					num = 141;
				}
				if (num == 139)
				{
					this.read_only.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 140;
				}
				if (num == 137)
				{
					this.hosts_loc.LinkClicked += this.hosts_loc_LinkClicked;
					num = 138;
				}
				if (num == 136)
				{
					this.hosts_loc.VisitedLinkColor = Color.DeepSkyBlue;
					num = 137;
				}
				if (num == 135)
				{
					this.hosts_loc.Text = "Open file location";
					num = 136;
				}
				if (num == 133)
				{
					this.hosts_loc.TabIndex = 319;
					num = 134;
				}
				if (num == 132)
				{
					this.hosts_loc.Size = new Size(140, 25);
					num = 133;
				}
				if (num == 131)
				{
					this.hosts_loc.Name = "hosts_loc";
					num = 132;
				}
				if (num == 129)
				{
					this.hosts_loc.LinkColor = Color.DeepSkyBlue;
					num = 130;
				}
				if (num == 128)
				{
					this.hosts_loc.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 129;
				}
				if (num == 127)
				{
					this.hosts_loc.AutoSize = true;
					num = 128;
				}
				if (num == 125)
				{
					this.back_btn.Click += this.back_btn_Click;
					num = 126;
				}
				if (num == 124)
				{
					this.back_btn.Text = "Next";
					num = 125;
				}
				if (num == 123)
				{
					this.back_btn.TabIndex = 313;
					num = 124;
				}
				if (num == 121)
				{
					this.back_btn.ShadowDecoration.Parent = this.back_btn;
					num = 122;
				}
				if (num == 120)
				{
					this.back_btn.Name = "back_btn";
					num = 121;
				}
				if (num == 119)
				{
					this.back_btn.Location = new Point(876, 53);
					num = 120;
				}
				if (num == 117)
				{
					this.back_btn.ForeColor = Color.White;
					num = 118;
				}
				if (num == 116)
				{
					this.back_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 117;
				}
				if (num == 115)
				{
					this.back_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 116;
				}
				if (num == 113)
				{
					this.back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 114;
				}
				if (num == 112)
				{
					this.back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 113;
				}
				if (num == 111)
				{
					this.back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 112;
				}
				if (num == 109)
				{
					this.back_btn.CustomImages.Parent = this.back_btn;
					num = 110;
				}
				if (num == 108)
				{
					this.back_btn.CheckedState.Parent = this.back_btn;
					num = 109;
				}
				if (num == 107)
				{
					this.back_btn.BorderRadius = 14;
					num = 108;
				}
				if (num == 105)
				{
					this.reset.Click += this.reset_Click;
					num = 106;
				}
				if (num == 104)
				{
					this.reset.Text = "Reset Hosts";
					num = 105;
				}
				if (num == 103)
				{
					this.reset.TabIndex = 312;
					num = 104;
				}
				if (num == 101)
				{
					this.reset.ShadowDecoration.Parent = this.reset;
					num = 102;
				}
				if (num == 100)
				{
					this.reset.Name = "reset";
					num = 101;
				}
				if (num == 99)
				{
					this.reset.Location = new Point(722, 324);
					num = 100;
				}
				if (num == 98)
				{
					this.reset.ImageSize = new Size(30, 30);
					num = 99;
				}
				if (num == 96)
				{
					this.reset.ForeColor = Color.White;
					num = 97;
				}
				if (num == 95)
				{
					this.reset.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 96;
				}
				if (num == 94)
				{
					this.reset.FillColor = Color.DodgerBlue;
					num = 95;
				}
				if (num == 92)
				{
					this.reset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 93;
				}
				if (num == 91)
				{
					this.reset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 92;
				}
				if (num == 90)
				{
					this.reset.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 91;
				}
				if (num == 88)
				{
					this.reset.CustomImages.Parent = this.reset;
					num = 89;
				}
				if (num == 87)
				{
					this.reset.CheckedState.Parent = this.reset;
					num = 88;
				}
				if (num == 86)
				{
					this.undo.Click += this.undo_Click;
					num = 87;
				}
				if (num == 84)
				{
					this.undo.TabIndex = 311;
					num = 85;
				}
				if (num == 83)
				{
					this.undo.Size = new Size(256, 38);
					num = 84;
				}
				if (num == 82)
				{
					this.undo.ShadowDecoration.Parent = this.undo;
					num = 83;
				}
				if (num == 80)
				{
					this.undo.Location = new Point(722, 280);
					num = 81;
				}
				if (num == 79)
				{
					this.undo.ImageSize = new Size(30, 30);
					num = 80;
				}
				if (num == 78)
				{
					this.undo.HoverState.Parent = this.undo;
					num = 79;
				}
				if (num == 76)
				{
					this.undo.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 77;
				}
				if (num == 75)
				{
					this.undo.FillColor = Color.DodgerBlue;
					num = 76;
				}
				if (num == 74)
				{
					this.undo.DisabledState.Parent = this.undo;
					num = 75;
				}
				if (num == 72)
				{
					this.undo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 73;
				}
				if (num == 71)
				{
					this.undo.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 72;
				}
				if (num == 70)
				{
					this.undo.DisabledState.BorderColor = Color.DarkGray;
					num = 71;
				}
				if (num == 68)
				{
					this.undo.CheckedState.Parent = this.undo;
					num = 69;
				}
				if (num == 67)
				{
					this.save.Click += this.save_Click;
					num = 68;
				}
				if (num == 66)
				{
					this.save.Text = "Save";
					num = 67;
				}
				if (num == 64)
				{
					this.save.Size = new Size(256, 38);
					num = 65;
				}
				if (num == 63)
				{
					this.save.ShadowDecoration.Parent = this.save;
					num = 64;
				}
				if (num == 62)
				{
					this.save.Name = "save";
					num = 63;
				}
				if (num == 60)
				{
					this.save.ImageSize = new Size(30, 30);
					num = 61;
				}
				if (num == 59)
				{
					this.save.HoverState.Parent = this.save;
					num = 60;
				}
				if (num == 58)
				{
					this.save.ForeColor = Color.White;
					num = 59;
				}
				if (num == 56)
				{
					this.save.FillColor = Color.DodgerBlue;
					num = 57;
				}
				if (num == 55)
				{
					this.save.DisabledState.Parent = this.save;
					num = 56;
				}
				if (num == 54)
				{
					this.save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 55;
				}
				if (num == 52)
				{
					this.save.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 53;
				}
				if (num == 51)
				{
					this.save.DisabledState.BorderColor = Color.DarkGray;
					num = 52;
				}
				if (num == 50)
				{
					this.save.CustomImages.Parent = this.save;
					num = 51;
				}
				if (num == 49)
				{
					this.save.CheckedState.Parent = this.save;
					num = 50;
				}
				if (num == 47)
				{
					this.hosts_editor.TabIndex = 114;
					num = 48;
				}
				if (num == 46)
				{
					this.hosts_editor.Size = new Size(672, 503);
					num = 47;
				}
				if (num == 45)
				{
					this.hosts_editor.Name = "hosts_editor";
					num = 46;
				}
				if (num == 43)
				{
					this.hosts_editor.ForeColor = Color.White;
					num = 44;
				}
				if (num == 42)
				{
					this.hosts_editor.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 43;
				}
				if (num == 41)
				{
					this.hosts_editor.BorderStyle = BorderStyle.None;
					num = 42;
				}
				if (num == 39)
				{
					this.label2.Text = "Hosts Editor";
					num = 40;
				}
				if (num == 38)
				{
					this.label2.TabIndex = 113;
					num = 39;
				}
				if (num == 37)
				{
					this.label2.Size = new Size(138, 33);
					num = 38;
				}
				if (num == 35)
				{
					this.label2.Location = new Point(21, 92);
					num = 36;
				}
				if (num == 34)
				{
					this.label2.ForeColor = Color.White;
					num = 35;
				}
				if (num == 33)
				{
					this.label2.Font = new Font("Josefin Sans SemiBold", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 34;
				}
				if (num == 31)
				{
					this.label1.Text = "Expert Tweaks";
					num = 32;
				}
				if (num == 30)
				{
					this.label1.TabIndex = 111;
					num = 31;
				}
				if (num == 29)
				{
					this.label1.Size = new Size(248, 53);
					num = 30;
				}
				if (num == 27)
				{
					this.label1.Location = new Point(18, 0);
					num = 28;
				}
				if (num == 26)
				{
					this.label1.ForeColor = Color.White;
					num = 27;
				}
				if (num == 25)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 26;
				}
				if (num == 23)
				{
					this.label37.Text = "Edit Hosts file with ease!";
					num = 24;
				}
				if (num == 22)
				{
					this.label37.TabIndex = 112;
					num = 23;
				}
				if (num == 21)
				{
					this.label37.Size = new Size(141, 19);
					num = 22;
				}
				if (num == 19)
				{
					this.label37.Location = new Point(23, 53);
					num = 20;
				}
				if (num == 18)
				{
					this.label37.ForeColor = Color.Silver;
					num = 19;
				}
				if (num == 17)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 18;
				}
				if (num == 15)
				{
					base.SuspendLayout();
					num = 16;
				}
				if (num == 14)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 15;
				}
				if (num == 13)
				{
					this.siticoneRoundedButton1 = new SiticoneRoundedButton();
					num = 14;
				}
				if (num == 11)
				{
					this.label5 = new Label();
					num = 12;
				}
				if (num == 10)
				{
					this.read_only = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 9)
				{
					this.hosts_loc = new LinkLabel();
					num = 10;
				}
				if (num == 7)
				{
					this.reset = new SiticoneButton();
					num = 8;
				}
				if (num == 6)
				{
					this.undo = new SiticoneButton();
					num = 7;
				}
				if (num == 5)
				{
					this.save = new SiticoneButton();
					num = 6;
				}
				if (num == 3)
				{
					this.label2 = new Label();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					this.label37 = new Label();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 238);
		}

		// Token: 0x04000903 RID: 2307
		private string HostsPath = Environment.ExpandEnvironmentVariables("%SystemDrive%\\Windows\\System32\\drivers\\etc\\hosts");

		// Token: 0x04000904 RID: 2308
		private string backup;

		// Token: 0x04000905 RID: 2309
		private string defaulthosts = "# Copyright (c) 1993-2006 Microsoft Corp.\r\n#\r\n# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\r\n#\r\n# This file contains the mappings of IP addresses to host names. Each\r\n# entry should be kept on an individual line. The IP address should\r\n# be placed in the first column followed by the corresponding host name.\r\n# The IP address and the host name should be separated by at least one\r\n# space.\r\n#\r\n# Additionally, comments (such as these) may be inserted on individual\r\n# lines or following the machine name denoted by a '#' symbol.\r\n#\r\n# For example:\r\n#\r\n#      102.54.94.97     rhino.acme.com          # source server\r\n#       38.25.63.10     x.acme.com              # x client host\r\n\r\n# localhost name resolution is handle within DNS itself.\r\n#       127.0.0.1       localhost\n#       ::1             localhost";

		// Token: 0x04000906 RID: 2310
		private static WebClient _client = new WebClient
		{
			Encoding = Encoding.UTF8
		};

		// Token: 0x04000907 RID: 2311
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000908 RID: 2312
		private static Hosts _instace;

		// Token: 0x04000909 RID: 2313
		private IContainer components = null;

		// Token: 0x0400090A RID: 2314
		private Label label37;

		// Token: 0x0400090B RID: 2315
		private Label label1;

		// Token: 0x0400090C RID: 2316
		private Label label2;

		// Token: 0x0400090D RID: 2317
		private RichTextBox hosts_editor;

		// Token: 0x0400090E RID: 2318
		private SiticoneButton save;

		// Token: 0x0400090F RID: 2319
		private SiticoneButton undo;

		// Token: 0x04000910 RID: 2320
		private SiticoneButton reset;

		// Token: 0x04000911 RID: 2321
		private SiticoneRoundedButton back_btn;

		// Token: 0x04000912 RID: 2322
		private LinkLabel hosts_loc;

		// Token: 0x04000913 RID: 2323
		private SiticoneCheckBox read_only;

		// Token: 0x04000914 RID: 2324
		private Label label5;

		// Token: 0x04000915 RID: 2325
		private SiticoneButton refresh;

		// Token: 0x04000916 RID: 2326
		private SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000917 RID: 2327
		private SiticoneVScrollBar siticoneVScrollBar1;
	}
}
