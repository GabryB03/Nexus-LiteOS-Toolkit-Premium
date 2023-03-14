using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200006D RID: 109
	public class Registration : UserControl
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0017A338 File Offset: 0x00178538
		public static Registration Instance
		{
			get
			{
				if (Registration._instace == null)
				{
					Registration._instace = new Registration();
				}
				return Registration._instace;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0017A360 File Offset: 0x00178560
		public Registration()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0017A3CC File Offset: 0x001785CC
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

		// Token: 0x060009A1 RID: 2465 RVA: 0x0017A618 File Offset: 0x00178818
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

		// Token: 0x060009A2 RID: 2466 RVA: 0x0017A690 File Offset: 0x00178890
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

		// Token: 0x060009A3 RID: 2467 RVA: 0x0017A6F4 File Offset: 0x001788F4
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 7)
				{
					this.pictureBox5.Location = new Point(66, -11);
					num = 8;
				}
				if (num == 6)
				{
					this.linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 5)
				{
					this.linkLabel1.LinkColor = Color.FromArgb(255, 128, 0);
					num = 6;
				}
				if (num == 3)
				{
					this.label1.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					this.label1.ForeColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(255, 69, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0017A874 File Offset: 0x00178A74
		private void AccentColor()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.label1.BringToFront();
					num = 5;
				}
				Color accentColor;
				if (num == 7)
				{
					this.linkLabel1.VisitedLinkColor = accentColor;
					num = 8;
				}
				if (num == 6)
				{
					this.linkLabel1.LinkColor = accentColor;
					num = 7;
				}
				if (num == 5)
				{
					this.linkLabel1.ActiveLinkColor = accentColor;
					num = 6;
				}
				if (num == 3)
				{
					this.label1.ForeColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.siticoneRoundedButton3.FillColor = accentColor;
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
			while (num != 8);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0017A9C8 File Offset: 0x00178BC8
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 7)
				{
					this.pictureBox6.Location = new Point(84, 0);
					num = 8;
				}
				if (num == 6)
				{
					this.linkLabel1.VisitedLinkColor = Color.FromArgb(29, 158, 255);
					num = 7;
				}
				if (num == 5)
				{
					this.linkLabel1.LinkColor = Color.FromArgb(29, 158, 255);
					num = 6;
				}
				if (num == 3)
				{
					this.label1.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					this.label1.ForeColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0017AB48 File Offset: 0x00178D48
		public static void HWIDLog(string URL, string escapedjson)
		{
			int num = 0;
			WebRequest webRequest;
			StreamWriter streamWriter;
			do
			{
				if (num == 4)
				{
					streamWriter = new StreamWriter(webRequest.GetRequestStream());
					num = 5;
				}
				if (num == 3)
				{
					webRequest.Method = "POST";
					num = 4;
				}
				if (num == 2)
				{
					webRequest.ContentType = "application/json";
					num = 3;
				}
				if (num == 1)
				{
					webRequest = WebRequest.Create(URL);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			try
			{
				streamWriter.Write(escapedjson);
			}
			finally
			{
				if (streamWriter != null)
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			webRequest.GetResponse();
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0017AC60 File Offset: 0x00178E60
		private void registeration_Load(object sender, EventArgs e)
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
				goto IL_9A;
				IL_AE:
				object value;
				if (num == 5)
				{
					this.processor.Text = value.ToString();
					num = 6;
				}
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("ProcessorNameString");
					num = 3;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 10)
				{
					break;
				}
				continue;
				IL_0B:
				if (num == 8)
				{
					this.textBox1.ReadOnly = true;
					num = 9;
				}
				if (num == 9)
				{
					this.textBox1.Text = this.textBox1.Text.Replace(" ", "");
					num = 10;
				}
				if (num == 7)
				{
					this.textBox1.Text = this.hwid;
					num = 8;
				}
				if (num != 6)
				{
					goto IL_AE;
				}
				IL_9A:
				this.hwid = UHWIDEngine.SimpleUid;
				num = 7;
				goto IL_AE;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00018F28 File Offset: 0x00017128
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

		// Token: 0x060009A9 RID: 2473 RVA: 0x0017ADCC File Offset: 0x00178FCC
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			int num = 0;
			Username_Error username_Error;
			do
			{
				if (num == 3)
				{
					username_Error = new Username_Error();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_8B;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = string.IsNullOrEmpty(this.Username.Text);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			try
			{
				username_Error.ShowDialog(this);
			}
			finally
			{
				if (username_Error != null)
				{
					((IDisposable)username_Error).Dispose();
				}
			}
			IL_8B:
			if (string.IsNullOrEmpty(this.Password.Text))
			{
				using (Key_Error key_Error = new Key_Error())
				{
					key_Error.ShowDialog(this);
					return;
				}
			}
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://docs.google.com/document/d/1A1JMuYEE8l9gg-jdIa9i0b6O34LudSd-Nw1Ax75zVWo/");
				if (text.Contains(this.Password.Text))
				{
					using (Validated validated = new Validated())
					{
						validated.ShowDialog(this);
						string text2 = this.textBox1.Text;
						string environmentVariable = Environment.GetEnvironmentVariable("UserName");
						Registration.HWIDLog("https://discord.com/api/webhooks/938358691667791873/rd8sMi1DMrkt7sxZNxId2nPybr6Xx89MfGy5hygXrkmCOQVlOPPh0m6MDD7-Yd9LDm_c", string.Concat(new string[]
						{
							"{\"username\": \"Authenticator\",\"embeds\":[    {\"description\":\"**User Account :- **",
							environmentVariable,
							"\\n\\r**Username - **",
							this.Username.Text,
							"\\n\\r**HWID - **`",
							this.textBox1.Text,
							"`\\n\\r**Processor Name - **",
							this.processor.Text,
							"\\n\\r**Drive Name - **",
							this.diskname,
							"\\n\\r**Drive Type - **",
							this.disktype,
							"\\n\\r**Key Used - **",
							this.Password.Text,
							"\", \"title\":\"New Registeration Request\", \"color\":1018364}]  }"
						}));
						goto IL_243;
					}
				}
				using (Key_Error key_Error2 = new Key_Error())
				{
					key_Error2.ShowDialog(this);
				}
				IL_243:;
			}
			catch (WebException)
			{
				using (reg_error reg_error = new reg_error())
				{
					reg_error.ShowDialog(this);
				}
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0017B0D8 File Offset: 0x001792D8
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

		// Token: 0x060009AB RID: 2475 RVA: 0x0017B150 File Offset: 0x00179350
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.pictureBox1 = new PictureBox();
					num = 5;
				}
				if (num == 8)
				{
					this.label17 = new Label();
					num = 9;
				}
				if (num == 12)
				{
					this.processor = new TextBox();
					num = 13;
				}
				if (num == 16)
				{
					((ISupportInitialize)this.pictureBox2).BeginInit();
					num = 17;
				}
				if (num == 20)
				{
					((ISupportInitialize)this.pictureBox6).BeginInit();
					num = 21;
				}
				if (num == 24)
				{
					this.pictureBox2.Location = new Point(11, 238);
					num = 25;
				}
				if (num == 28)
				{
					this.pictureBox2.TabIndex = 288;
					num = 29;
				}
				if (num == 32)
				{
					this.pictureBox4.Location = new Point(11, 191);
					num = 33;
				}
				if (num == 36)
				{
					this.pictureBox4.TabIndex = 287;
					num = 37;
				}
				if (num == 40)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 41;
				}
				if (num == 44)
				{
					this.pictureBox1.TabStop = false;
					num = 45;
				}
				if (num == 48)
				{
					this.label1.Location = new Point(81, 152);
					num = 49;
				}
				if (num == 53)
				{
					this.textBox1.Location = new Point(108, 335);
					num = 54;
				}
				if (num == 57)
				{
					this.linkLabel1.ActiveLinkColor = Color.DeepSkyBlue;
					num = 58;
				}
				if (num == 61)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 62;
				}
				if (num == 65)
				{
					this.linkLabel1.Text = "dsc.gg/NexusToolkit";
					num = 66;
				}
				if (num == 69)
				{
					this.label17.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 70;
				}
				if (num == 73)
				{
					this.label17.Size = new Size(35, 19);
					num = 74;
				}
				if (num == 77)
				{
					this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
					num = 78;
				}
				if (num == 81)
				{
					this.siticoneRoundedButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 82;
				}
				if (num == 85)
				{
					this.siticoneRoundedButton3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = 86;
				}
				if (num == 89)
				{
					this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
					num = 90;
				}
				if (num == 93)
				{
					this.siticoneRoundedButton3.Text = "Register";
					num = 94;
				}
				if (num == 97)
				{
					this.Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 98;
				}
				if (num == 102)
				{
					this.Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 103;
				}
				if (num == 106)
				{
					this.Username.HoverState.Parent = this.Username;
					num = 107;
				}
				if (num == 110)
				{
					this.Username.PlaceholderText = "";
					num = 111;
				}
				if (num == 114)
				{
					this.Username.TabIndex = 307;
					num = 115;
				}
				if (num == 118)
				{
					this.Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 119;
				}
				if (num == 122)
				{
					this.Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 123;
				}
				if (num == 126)
				{
					this.Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 127;
				}
				if (num == 130)
				{
					this.Password.PasswordChar = '\0';
					num = 131;
				}
				if (num == 134)
				{
					this.Password.Size = new Size(204, 28);
					num = 135;
				}
				if (num == 138)
				{
					this.processor.Name = "processor";
					num = 139;
				}
				if (num == 142)
				{
					this.mobo.Name = "mobo";
					num = 143;
				}
				if (num == 146)
				{
					this.pictureBox5.Location = new Point(-180, -44);
					num = 147;
				}
				if (num == 151)
				{
					this.pictureBox5.TabStop = false;
					num = 152;
				}
				if (num == 155)
				{
					this.pictureBox6.Size = new Size(136, 136);
					num = 156;
				}
				if (num == 159)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 160;
				}
				if (num == 163)
				{
					base.Controls.Add(this.pictureBox5);
					num = 164;
				}
				if (num == 167)
				{
					base.Controls.Add(this.label17);
					num = 168;
				}
				if (num == 171)
				{
					base.Controls.Add(this.pictureBox1);
					num = 172;
				}
				if (num == 175)
				{
					base.Controls.Add(this.mobo);
					num = 176;
				}
				if (num == 179)
				{
					((ISupportInitialize)this.pictureBox2).EndInit();
					num = 180;
				}
				if (num == 183)
				{
					((ISupportInitialize)this.pictureBox6).EndInit();
					num = 184;
				}
				if (num == 185)
				{
					base.PerformLayout();
					num = 186;
				}
				if (num == 184)
				{
					base.ResumeLayout(false);
					num = 185;
				}
				if (num == 182)
				{
					((ISupportInitialize)this.pictureBox5).EndInit();
					num = 183;
				}
				if (num == 181)
				{
					((ISupportInitialize)this.pictureBox1).EndInit();
					num = 182;
				}
				if (num == 180)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 181;
				}
				if (num == 178)
				{
					base.Load += this.registeration_Load;
					num = 179;
				}
				if (num == 177)
				{
					base.Size = new Size(303, 423);
					num = 178;
				}
				if (num == 176)
				{
					base.Name = "Registration";
					num = 177;
				}
				if (num == 174)
				{
					base.Controls.Add(this.processor);
					num = 175;
				}
				if (num == 173)
				{
					base.Controls.Add(this.textBox1);
					num = 174;
				}
				if (num == 172)
				{
					base.Controls.Add(this.label1);
					num = 173;
				}
				if (num == 170)
				{
					base.Controls.Add(this.pictureBox4);
					num = 171;
				}
				if (num == 169)
				{
					base.Controls.Add(this.pictureBox2);
					num = 170;
				}
				if (num == 168)
				{
					base.Controls.Add(this.linkLabel1);
					num = 169;
				}
				if (num == 166)
				{
					base.Controls.Add(this.siticoneRoundedButton3);
					num = 167;
				}
				if (num == 165)
				{
					base.Controls.Add(this.Username);
					num = 166;
				}
				if (num == 164)
				{
					base.Controls.Add(this.Password);
					num = 165;
				}
				if (num == 162)
				{
					base.Controls.Add(this.pictureBox6);
					num = 163;
				}
				if (num == 161)
				{
					this.BackColor = Color.FromArgb(28, 28, 28);
					num = 162;
				}
				if (num == 160)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 161;
				}
				if (num == 158)
				{
					this.pictureBox6.TabStop = false;
					num = 159;
				}
				if (num == 157)
				{
					this.pictureBox6.TabIndex = 312;
					num = 158;
				}
				if (num == 156)
				{
					this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 157;
				}
				if (num == 154)
				{
					this.pictureBox6.Name = "pictureBox6";
					num = 155;
				}
				if (num == 153)
				{
					this.pictureBox6.Location = new Point(-180, 0);
					num = 154;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 152)
				{
					this.pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
					num = 153;
				}
				if (num == 150)
				{
					this.pictureBox5.TabIndex = 311;
					num = 151;
				}
				if (num == 149)
				{
					this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 150;
				}
				if (num == 148)
				{
					this.pictureBox5.Size = new Size(180, 180);
					num = 149;
				}
				if (num == 147)
				{
					this.pictureBox5.Name = "pictureBox5";
					num = 148;
				}
				if (num == 145)
				{
					this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
					num = 146;
				}
				if (num == 144)
				{
					this.mobo.TabIndex = 310;
					num = 145;
				}
				if (num == 143)
				{
					this.mobo.Size = new Size(20, 20);
					num = 144;
				}
				if (num == 141)
				{
					this.mobo.Location = new Point(108, 335);
					num = 142;
				}
				if (num == 140)
				{
					this.processor.TabIndex = 309;
					num = 141;
				}
				if (num == 139)
				{
					this.processor.Size = new Size(23, 20);
					num = 140;
				}
				if (num == 137)
				{
					this.processor.Location = new Point(185, 335);
					num = 138;
				}
				if (num == 136)
				{
					this.Password.TextAlign = HorizontalAlignment.Center;
					num = 137;
				}
				if (num == 135)
				{
					this.Password.TabIndex = 308;
					num = 136;
				}
				if (num == 133)
				{
					this.Password.ShadowDecoration.Parent = this.Password;
					num = 134;
				}
				if (num == 132)
				{
					this.Password.SelectedText = "";
					num = 133;
				}
				if (num == 131)
				{
					this.Password.PlaceholderText = "";
					num = 132;
				}
				if (num == 129)
				{
					this.Password.Name = "Password";
					num = 130;
				}
				if (num == 128)
				{
					this.Password.Location = new Point(66, 248);
					num = 129;
				}
				if (num == 127)
				{
					this.Password.HoverState.Parent = this.Password;
					num = 128;
				}
				if (num == 125)
				{
					this.Password.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 126;
				}
				if (num == 124)
				{
					this.Password.FocusedState.Parent = this.Password;
					num = 125;
				}
				if (num == 123)
				{
					this.Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 124;
				}
				if (num == 121)
				{
					this.Password.DisabledState.Parent = this.Password;
					num = 122;
				}
				if (num == 120)
				{
					this.Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 121;
				}
				if (num == 119)
				{
					this.Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 120;
				}
				if (num == 117)
				{
					this.Password.DefaultText = "";
					num = 118;
				}
				if (num == 116)
				{
					this.Password.Cursor = Cursors.IBeam;
					num = 117;
				}
				if (num == 115)
				{
					this.Username.TextAlign = HorizontalAlignment.Center;
					num = 116;
				}
				if (num == 113)
				{
					this.Username.Size = new Size(204, 28);
					num = 114;
				}
				if (num == 112)
				{
					this.Username.ShadowDecoration.Parent = this.Username;
					num = 113;
				}
				if (num == 111)
				{
					this.Username.SelectedText = "";
					num = 112;
				}
				if (num == 109)
				{
					this.Username.PasswordChar = '\0';
					num = 110;
				}
				if (num == 108)
				{
					this.Username.Name = "Username";
					num = 109;
				}
				if (num == 107)
				{
					this.Username.Location = new Point(66, 202);
					num = 108;
				}
				if (num == 105)
				{
					this.Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 106;
				}
				if (num == 104)
				{
					this.Username.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 105;
				}
				if (num == 103)
				{
					this.Username.FocusedState.Parent = this.Username;
					num = 104;
				}
				if (num == 101)
				{
					this.Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 102;
				}
				if (num == 100)
				{
					this.Username.DisabledState.Parent = this.Username;
					num = 101;
				}
				if (num == 99)
				{
					this.Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 100;
				}
				if (num == 98)
				{
					this.Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 99;
				}
				if (num == 96)
				{
					this.Username.DefaultText = "";
					num = 97;
				}
				if (num == 95)
				{
					this.Username.Cursor = Cursors.IBeam;
					num = 96;
				}
				if (num == 94)
				{
					this.siticoneRoundedButton3.Click += this.siticoneRoundedButton3_Click;
					num = 95;
				}
				if (num == 92)
				{
					this.siticoneRoundedButton3.TabIndex = 304;
					num = 93;
				}
				if (num == 91)
				{
					this.siticoneRoundedButton3.Size = new Size(180, 37);
					num = 92;
				}
				if (num == 90)
				{
					this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
					num = 91;
				}
				if (num == 88)
				{
					this.siticoneRoundedButton3.Location = new Point(66, 325);
					num = 89;
				}
				if (num == 87)
				{
					this.siticoneRoundedButton3.HoverState.Parent = this.siticoneRoundedButton3;
					num = 88;
				}
				if (num == 86)
				{
					this.siticoneRoundedButton3.ForeColor = Color.White;
					num = 87;
				}
				if (num == 84)
				{
					this.siticoneRoundedButton3.FillColor = Color.DeepSkyBlue;
					num = 85;
				}
				if (num == 83)
				{
					this.siticoneRoundedButton3.DisabledState.Parent = this.siticoneRoundedButton3;
					num = 84;
				}
				if (num == 82)
				{
					this.siticoneRoundedButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 83;
				}
				if (num == 80)
				{
					this.siticoneRoundedButton3.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 81;
				}
				if (num == 79)
				{
					this.siticoneRoundedButton3.DisabledState.BorderColor = Color.DarkGray;
					num = 80;
				}
				if (num == 78)
				{
					this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
					num = 79;
				}
				if (num == 76)
				{
					this.siticoneRoundedButton3.BorderRadius = 17;
					num = 77;
				}
				if (num == 75)
				{
					this.label17.Text = "v4.79";
					num = 76;
				}
				if (num == 74)
				{
					this.label17.TabIndex = 302;
					num = 75;
				}
				if (num == 72)
				{
					this.label17.Name = "label17";
					num = 73;
				}
				if (num == 71)
				{
					this.label17.Location = new Point(12, 407);
					num = 72;
				}
				if (num == 70)
				{
					this.label17.ForeColor = Color.Silver;
					num = 71;
				}
				if (num == 68)
				{
					this.label17.AutoSize = true;
					num = 69;
				}
				if (num == 67)
				{
					this.linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
					num = 68;
				}
				if (num == 66)
				{
					this.linkLabel1.VisitedLinkColor = Color.DeepSkyBlue;
					num = 67;
				}
				if (num == 64)
				{
					this.linkLabel1.TabStop = true;
					num = 65;
				}
				if (num == 63)
				{
					this.linkLabel1.TabIndex = 297;
					num = 64;
				}
				if (num == 62)
				{
					this.linkLabel1.Size = new Size(106, 13);
					num = 63;
				}
				if (num == 60)
				{
					this.linkLabel1.Location = new Point(204, 413);
					num = 61;
				}
				if (num == 59)
				{
					this.linkLabel1.LinkColor = Color.DeepSkyBlue;
					num = 60;
				}
				if (num == 58)
				{
					this.linkLabel1.AutoSize = true;
					num = 59;
				}
				if (num == 56)
				{
					this.textBox1.TabIndex = 289;
					num = 57;
				}
				if (num == 55)
				{
					this.textBox1.Size = new Size(100, 20);
					num = 56;
				}
				if (num == 54)
				{
					this.textBox1.Name = "textBox1";
					num = 55;
				}
				if (num == 52)
				{
					this.label1.Text = "Register Your Account";
					num = 53;
				}
				if (num == 51)
				{
					this.label1.TabIndex = 283;
					num = 52;
				}
				if (num == 50)
				{
					this.label1.Size = new Size(144, 17);
					num = 51;
				}
				if (num == 49)
				{
					this.label1.Name = "label1";
					num = 50;
				}
				if (num == 47)
				{
					this.label1.ForeColor = Color.FromArgb(94, 148, 255);
					num = 48;
				}
				if (num == 46)
				{
					this.label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 47;
				}
				if (num == 45)
				{
					this.label1.AutoSize = true;
					num = 46;
				}
				if (num == 43)
				{
					this.pictureBox1.TabIndex = 286;
					num = 44;
				}
				if (num == 42)
				{
					this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 43;
				}
				if (num == 41)
				{
					this.pictureBox1.Size = new Size(136, 136);
					num = 42;
				}
				if (num == 39)
				{
					this.pictureBox1.Location = new Point(84, 0);
					num = 40;
				}
				if (num == 38)
				{
					this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 39;
				}
				if (num == 37)
				{
					this.pictureBox4.TabStop = false;
					num = 38;
				}
				if (num == 35)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 36;
				}
				if (num == 34)
				{
					this.pictureBox4.Size = new Size(48, 48);
					num = 35;
				}
				if (num == 33)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 34;
				}
				if (num == 31)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 32;
				}
				if (num == 30)
				{
					this.pictureBox4.BackColor = Color.Transparent;
					num = 31;
				}
				if (num == 29)
				{
					this.pictureBox2.TabStop = false;
					num = 30;
				}
				if (num == 27)
				{
					this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 28;
				}
				if (num == 26)
				{
					this.pictureBox2.Size = new Size(48, 48);
					num = 27;
				}
				if (num == 25)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 26;
				}
				if (num == 23)
				{
					this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 24;
				}
				if (num == 22)
				{
					this.pictureBox2.BackColor = Color.Transparent;
					num = 23;
				}
				if (num == 21)
				{
					base.SuspendLayout();
					num = 22;
				}
				if (num == 19)
				{
					((ISupportInitialize)this.pictureBox5).BeginInit();
					num = 20;
				}
				if (num == 18)
				{
					((ISupportInitialize)this.pictureBox1).BeginInit();
					num = 19;
				}
				if (num == 17)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 18;
				}
				if (num == 15)
				{
					this.pictureBox6 = new PictureBox();
					num = 16;
				}
				if (num == 14)
				{
					this.pictureBox5 = new PictureBox();
					num = 15;
				}
				if (num == 13)
				{
					this.mobo = new TextBox();
					num = 14;
				}
				if (num == 11)
				{
					this.Password = new SiticoneTextBox();
					num = 12;
				}
				if (num == 10)
				{
					this.Username = new SiticoneTextBox();
					num = 11;
				}
				if (num == 9)
				{
					this.siticoneRoundedButton3 = new SiticoneRoundedButton();
					num = 10;
				}
				if (num == 7)
				{
					this.linkLabel1 = new LinkLabel();
					num = 8;
				}
				if (num == 6)
				{
					this.textBox1 = new TextBox();
					num = 7;
				}
				if (num == 5)
				{
					this.label1 = new Label();
					num = 6;
				}
				if (num == 3)
				{
					this.pictureBox4 = new PictureBox();
					num = 4;
				}
				if (num == 2)
				{
					this.pictureBox2 = new PictureBox();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Registration));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 186);
		}

		// Token: 0x04000982 RID: 2434
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000983 RID: 2435
		private static Registration _instace;

		// Token: 0x04000984 RID: 2436
		private string hwid;

		// Token: 0x04000985 RID: 2437
		private string diskname = DiskId.GetDiskName();

		// Token: 0x04000986 RID: 2438
		private string disktype = DiskId.GetDiskType();

		// Token: 0x04000987 RID: 2439
		private IContainer components = null;

		// Token: 0x04000988 RID: 2440
		private PictureBox pictureBox2;

		// Token: 0x04000989 RID: 2441
		private PictureBox pictureBox4;

		// Token: 0x0400098A RID: 2442
		private PictureBox pictureBox1;

		// Token: 0x0400098B RID: 2443
		private Label label1;

		// Token: 0x0400098C RID: 2444
		private TextBox textBox1;

		// Token: 0x0400098D RID: 2445
		private LinkLabel linkLabel1;

		// Token: 0x0400098E RID: 2446
		private Label label17;

		// Token: 0x0400098F RID: 2447
		private SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x04000990 RID: 2448
		private SiticoneTextBox Username;

		// Token: 0x04000991 RID: 2449
		private SiticoneTextBox Password;

		// Token: 0x04000992 RID: 2450
		private TextBox processor;

		// Token: 0x04000993 RID: 2451
		private TextBox mobo;

		// Token: 0x04000994 RID: 2452
		private PictureBox pictureBox5;

		// Token: 0x04000995 RID: 2453
		private PictureBox pictureBox6;
	}
}
