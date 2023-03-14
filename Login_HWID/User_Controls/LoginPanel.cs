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
using WindowsFormsApplication2;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000066 RID: 102
	public class LoginPanel : UserControl
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0015AB00 File Offset: 0x00158D00
		public static LoginPanel Instance
		{
			get
			{
				if (LoginPanel._instace == null)
				{
					LoginPanel._instace = new LoginPanel();
				}
				return LoginPanel._instace;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0015AB28 File Offset: 0x00158D28
		public LoginPanel()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0015AB94 File Offset: 0x00158D94
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\");
					num = 2;
				}
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Theme");
					num = 3;
				}
				object obj;
				if (num == 3)
				{
					obj = value;
					num = 4;
				}
				object obj2;
				if (num == 4)
				{
					obj2 = obj;
					num = 5;
				}
				string text;
				if (num == 5)
				{
					text = obj2 as string;
					num = 6;
				}
				if (num == 6)
				{
					if (text == null)
					{
						break;
					}
					num = 7;
				}
				if (num != 7)
				{
					goto IL_DA;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_DA;
				}
				goto IL_11D;
				IL_16E:
				if (num == 16 || num == 17)
				{
					break;
				}
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_1AB;
					}
					num = 9;
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
				IL_1BD:
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_15C;
				}
				goto IL_16E;
				IL_12F:
				if (num == 12)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_1AB;
				}
				goto IL_1BD;
				IL_DA:
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_15C;
					}
					num = 10;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 11)
				{
					goto IL_11D;
				}
				goto IL_12F;
				IL_15C:
				this.AccentColor();
				num = 16;
				goto IL_16E;
				IL_1AB:
				this.Halloween();
				num = 14;
				goto IL_1BD;
				IL_11D:
				this.Xmas_theme();
				num = 12;
				goto IL_12F;
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0015ADD0 File Offset: 0x00158FD0
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

		// Token: 0x06000924 RID: 2340 RVA: 0x0015AE48 File Offset: 0x00159048
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

		// Token: 0x06000925 RID: 2341 RVA: 0x0015AEAC File Offset: 0x001590AC
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(255, 69, 0);
					num = 2;
				}
				if (num == 2)
				{
					this.label1.ForeColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 3)
				{
					this.label1.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 5)
				{
					this.linkLabel1.LinkColor = Color.FromArgb(255, 128, 0);
					num = 6;
				}
				if (num == 6)
				{
					this.linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 7)
				{
					this.pictureBox5.Location = new Point(66, -11);
					num = 8;
				}
				if (num == 9)
				{
					this.siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 10;
				}
				if (num == 8)
				{
					this.siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0015B09C File Offset: 0x0015929C
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 2)
				{
					this.siticoneRoundedButton3.FillColor = accentColor;
					num = 3;
				}
				if (num == 3)
				{
					this.label1.ForeColor = accentColor;
					num = 4;
				}
				if (num == 4)
				{
					this.label1.BringToFront();
					num = 5;
				}
				if (num == 5)
				{
					this.linkLabel1.ActiveLinkColor = accentColor;
					num = 6;
				}
				if (num == 6)
				{
					this.linkLabel1.LinkColor = accentColor;
					num = 7;
				}
				if (num == 7)
				{
					this.linkLabel1.VisitedLinkColor = accentColor;
					num = 8;
				}
				if (num == 9)
				{
					this.siticoneCheckBox1.CheckedState.FillColor = accentColor;
					num = 10;
				}
				if (num == 8)
				{
					this.siticoneCheckBox1.CheckedState.BorderColor = accentColor;
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0015B248 File Offset: 0x00159448
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 2)
				{
					this.label1.ForeColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 3)
				{
					this.label1.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 5)
				{
					this.linkLabel1.LinkColor = Color.FromArgb(29, 158, 255);
					num = 6;
				}
				if (num == 6)
				{
					this.linkLabel1.VisitedLinkColor = Color.FromArgb(29, 158, 255);
					num = 7;
				}
				if (num == 7)
				{
					this.pictureBox6.Location = new Point(84, 0);
					num = 8;
				}
				if (num == 9)
				{
					this.siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 10;
				}
				if (num == 8)
				{
					this.siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0015B438 File Offset: 0x00159638
		private void Login_Panel_Load(object sender, EventArgs e)
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
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
				object value = registryKey.GetValue("ProcessorNameString");
				if (value != null)
				{
					this.processor.Text = value.ToString();
				}
				this.hwid = UHWIDEngine.SimpleUid;
				this.textBox1.Text = this.hwid;
				this.textBox1.ReadOnly = true;
				this.textBox1.Text = this.textBox1.Text.Replace(" ", "");
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
				object value2 = registryKey2.GetValue("Username");
				if (value2 != null)
				{
					this.Username.Text = value2.ToString();
					this.siticoneCheckBox1.CheckState = CheckState.Checked;
				}
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://docs.google.com/document/d/1ZcF6ZDbk-Pz4pNamEjCuFpHwO1LbIe-Uwpii3JujCME/");
				if (text.Contains(this.lbl_ver.Text))
				{
					RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					object value3 = registryKey3.GetValue("Auto Login");
					if (value3 != null)
					{
						this.auto.CheckState = CheckState.Checked;
					}
					if (!this.auto.Checked)
					{
						goto IL_3AF;
					}
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					if (registryKey4 == null)
					{
						goto IL_3AF;
					}
					if (string.IsNullOrEmpty(this.Username.Text))
					{
						using (LoginUser_Error loginUser_Error = new LoginUser_Error())
						{
							loginUser_Error.ShowDialog(this);
							goto IL_3AF;
						}
					}
					WebClient webClient2 = new WebClient();
					try
					{
						string text2 = webClient2.DownloadString("https://docs.google.com/document/d/16CLtfMH9uqQyt19CfviPSIy66icqqeMQc1xQ9kk0ago/");
						if (text2.Contains(this.textBox1.Text))
						{
							string text3 = this.Username.Text;
							string environmentVariable = Environment.GetEnvironmentVariable("UserName");
							LoginPanel.HWIDLog("https://discord.com/api/webhooks/938358881556525077/ecqt7jfvnNNSBIDsMYIeRZR8OzPk8fzbCH0xg0GOoy6akHmKT2ZiAdSOaPFPgVNnqhKs", string.Concat(new string[]
							{
								"{\"username\": \"Authenticator\",\"embeds\":[    {\"description\":\"**User Account - **",
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
								"\\n\\r**Client Version - **",
								this.lbl_ver.Text,
								"\", \"title\":\"New Login Session\", \"color\":1018364}]  }"
							}));
							main main = new main();
							main.Show();
							((Form)base.TopLevelControl).Hide();
						}
						else
						{
							using (update update = new update())
							{
								update.ShowDialog(this);
							}
						}
						goto IL_3AF;
					}
					catch (WebException)
					{
						using (Login_Error login_Error = new Login_Error())
						{
							login_Error.ShowDialog(this);
						}
						goto IL_3AF;
					}
				}
				using (update_avail update_avail = new update_avail())
				{
					update_avail.ShowDialog(this);
				}
				base.Hide();
				IL_3AF:;
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

		// Token: 0x06000929 RID: 2345 RVA: 0x0015B8D0 File Offset: 0x00159AD0
		public static void HWIDLog(string URL, string escapedjson)
		{
			int num = 0;
			WebRequest webRequest;
			StreamWriter streamWriter;
			do
			{
				if (num == 1)
				{
					webRequest = WebRequest.Create(URL);
					num = 2;
				}
				if (num == 2)
				{
					webRequest.ContentType = "application/json";
					num = 3;
				}
				if (num == 3)
				{
					webRequest.Method = "POST";
					num = 4;
				}
				if (num == 4)
				{
					streamWriter = new StreamWriter(webRequest.GetRequestStream());
					num = 5;
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

		// Token: 0x0600092A RID: 2346 RVA: 0x00018F28 File Offset: 0x00017128
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

		// Token: 0x0600092B RID: 2347 RVA: 0x0015B9E8 File Offset: 0x00159BE8
		private void siticoneRoundedButton3_Click_1(object sender, EventArgs e)
		{
			int num = 0;
			LoginUser_Error loginUser_Error;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = string.IsNullOrEmpty(this.Username.Text);
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						goto IL_77;
					}
					num = 3;
				}
				if (num == 3)
				{
					loginUser_Error = new LoginUser_Error();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			goto IL_21F;
			IL_77:
			WebClient webClient = new WebClient();
			try
			{
				string text = webClient.DownloadString("https://docs.google.com/document/d/16CLtfMH9uqQyt19CfviPSIy66icqqeMQc1xQ9kk0ago/");
				if (text.Contains(this.textBox1.Text))
				{
					string text2 = this.Username.Text;
					string environmentVariable = Environment.GetEnvironmentVariable("UserName");
					LoginPanel.HWIDLog("https://discord.com/api/webhooks/938358881556525077/ecqt7jfvnNNSBIDsMYIeRZR8OzPk8fzbCH0xg0GOoy6akHmKT2ZiAdSOaPFPgVNnqhKs", string.Concat(new string[]
					{
						"{\"username\": \"Authenticator\",\"embeds\":[    {\"description\":\"**User Account - **",
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
						"\\n\\r**Client Version - **",
						this.lbl_ver.Text,
						"\", \"title\":\"New Login Session\", \"color\":1018364}]  }"
					}));
					main main = new main();
					main.Show();
					((Form)base.TopLevelControl).Hide();
				}
				else
				{
					using (update update = new update())
					{
						update.ShowDialog(this);
					}
				}
				goto IL_236;
			}
			catch (WebException)
			{
				using (Login_Error login_Error = new Login_Error())
				{
					login_Error.ShowDialog(this);
				}
				goto IL_236;
			}
			try
			{
				IL_21F:
				loginUser_Error.ShowDialog(this);
			}
			finally
			{
				if (loginUser_Error != null)
				{
					((IDisposable)loginUser_Error).Dispose();
				}
			}
			IL_236:
			if (this.siticoneCheckBox1.Checked)
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
				if (registryKey != null)
				{
					registryKey.SetValue("Username", this.Username.Text);
				}
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0015BCD4 File Offset: 0x00159ED4
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

		// Token: 0x0600092D RID: 2349 RVA: 0x0015BD4C File Offset: 0x00159F4C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				ComponentResourceManager componentResourceManager;
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(LoginPanel));
					num = 2;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 3)
				{
					this.textBox1 = new TextBox();
					num = 4;
				}
				if (num == 4)
				{
					this.linkLabel1 = new LinkLabel();
					num = 5;
				}
				if (num == 5)
				{
					this.siticoneCheckBox1 = new SiticoneCheckBox();
					num = 6;
				}
				if (num == 6)
				{
					this.lbl_ver = new Label();
					num = 7;
				}
				if (num == 7)
				{
					this.siticoneRoundedButton3 = new SiticoneRoundedButton();
					num = 8;
				}
				if (num == 9)
				{
					this.processor = new TextBox();
					num = 10;
				}
				if (num == 10)
				{
					this.auto = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 11)
				{
					this.pictureBox4 = new PictureBox();
					num = 12;
				}
				if (num == 12)
				{
					this.pictureBox1 = new PictureBox();
					num = 13;
				}
				if (num == 13)
				{
					this.pictureBox5 = new PictureBox();
					num = 14;
				}
				if (num == 14)
				{
					this.pictureBox6 = new PictureBox();
					num = 15;
				}
				if (num == 15)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 16;
				}
				if (num == 16)
				{
					((ISupportInitialize)this.pictureBox1).BeginInit();
					num = 17;
				}
				if (num == 18)
				{
					((ISupportInitialize)this.pictureBox6).BeginInit();
					num = 19;
				}
				if (num == 19)
				{
					base.SuspendLayout();
					num = 20;
				}
				if (num == 20)
				{
					this.label1.AutoSize = true;
					num = 21;
				}
				if (num == 21)
				{
					this.label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 22;
				}
				if (num == 22)
				{
					this.label1.ForeColor = Color.FromArgb(94, 148, 255);
					num = 23;
				}
				if (num == 23)
				{
					this.label1.Location = new Point(91, 152);
					num = 24;
				}
				if (num == 24)
				{
					this.label1.Name = "label1";
					num = 25;
				}
				if (num == 25)
				{
					this.label1.Size = new Size(129, 17);
					num = 26;
				}
				if (num == 27)
				{
					this.label1.Text = "Login Your Account";
					num = 28;
				}
				if (num == 28)
				{
					this.textBox1.Location = new Point(108, 315);
					num = 29;
				}
				if (num == 29)
				{
					this.textBox1.Name = "textBox1";
					num = 30;
				}
				if (num == 30)
				{
					this.textBox1.Size = new Size(100, 20);
					num = 31;
				}
				if (num == 31)
				{
					this.textBox1.TabIndex = 293;
					num = 32;
				}
				if (num == 32)
				{
					this.linkLabel1.ActiveLinkColor = Color.DeepSkyBlue;
					num = 33;
				}
				if (num == 33)
				{
					this.linkLabel1.AutoSize = true;
					num = 34;
				}
				if (num == 34)
				{
					this.linkLabel1.LinkColor = Color.DeepSkyBlue;
					num = 35;
				}
				if (num == 36)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 37;
				}
				if (num == 37)
				{
					this.linkLabel1.Size = new Size(106, 13);
					num = 38;
				}
				if (num == 38)
				{
					this.linkLabel1.TabIndex = 296;
					num = 39;
				}
				if (num == 39)
				{
					this.linkLabel1.TabStop = true;
					num = 40;
				}
				if (num == 40)
				{
					this.linkLabel1.Text = "dsc.gg/NexusToolkit";
					num = 41;
				}
				if (num == 41)
				{
					this.linkLabel1.VisitedLinkColor = Color.DeepSkyBlue;
					num = 42;
				}
				if (num == 42)
				{
					this.linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
					num = 43;
				}
				if (num == 44)
				{
					this.siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 45;
				}
				if (num == 45)
				{
					this.siticoneCheckBox1.CheckedState.BorderRadius = 0;
					num = 46;
				}
				if (num == 46)
				{
					this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
					num = 47;
				}
				if (num == 47)
				{
					this.siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 48;
				}
				if (num == 48)
				{
					this.siticoneCheckBox1.ForeColor = Color.White;
					num = 49;
				}
				if (num == 49)
				{
					this.siticoneCheckBox1.Location = new Point(68, 256);
					num = 50;
				}
				if (num == 50)
				{
					this.siticoneCheckBox1.Name = "siticoneCheckBox1";
					num = 51;
				}
				if (num == 51)
				{
					this.siticoneCheckBox1.Size = new Size(101, 17);
					num = 52;
				}
				if (num == 53)
				{
					this.siticoneCheckBox1.Text = "Save Login Info";
					num = 54;
				}
				if (num == 54)
				{
					this.siticoneCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 55;
				}
				if (num == 55)
				{
					this.siticoneCheckBox1.UncheckedState.BorderRadius = 0;
					num = 56;
				}
				if (num == 56)
				{
					this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
					num = 57;
				}
				if (num == 57)
				{
					this.siticoneCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 58;
				}
				if (num == 58)
				{
					this.lbl_ver.AutoSize = true;
					num = 59;
				}
				if (num == 59)
				{
					this.lbl_ver.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 60;
				}
				if (num == 60)
				{
					this.lbl_ver.ForeColor = Color.Silver;
					num = 61;
				}
				if (num == 62)
				{
					this.lbl_ver.Name = "lbl_ver";
					num = 63;
				}
				if (num == 63)
				{
					this.lbl_ver.Size = new Size(35, 19);
					num = 64;
				}
				if (num == 64)
				{
					this.lbl_ver.TabIndex = 301;
					num = 65;
				}
				if (num == 65)
				{
					this.lbl_ver.Text = "v4.79";
					num = 66;
				}
				if (num == 66)
				{
					this.siticoneRoundedButton3.BorderRadius = 17;
					num = 67;
				}
				if (num == 67)
				{
					this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
					num = 68;
				}
				if (num == 68)
				{
					this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
					num = 69;
				}
				if (num == 69)
				{
					this.siticoneRoundedButton3.DisabledState.BorderColor = Color.DarkGray;
					num = 70;
				}
				if (num == 71)
				{
					this.siticoneRoundedButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 72;
				}
				if (num == 72)
				{
					this.siticoneRoundedButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 73;
				}
				if (num == 73)
				{
					this.siticoneRoundedButton3.DisabledState.Parent = this.siticoneRoundedButton3;
					num = 74;
				}
				if (num == 74)
				{
					this.siticoneRoundedButton3.FillColor = Color.DeepSkyBlue;
					num = 75;
				}
				if (num == 75)
				{
					this.siticoneRoundedButton3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = 76;
				}
				if (num == 76)
				{
					this.siticoneRoundedButton3.ForeColor = Color.White;
					num = 77;
				}
				if (num == 77)
				{
					this.siticoneRoundedButton3.HoverState.Parent = this.siticoneRoundedButton3;
					num = 78;
				}
				if (num == 78)
				{
					this.siticoneRoundedButton3.Location = new Point(68, 306);
					num = 79;
				}
				if (num == 80)
				{
					this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
					num = 81;
				}
				if (num == 81)
				{
					this.siticoneRoundedButton3.Size = new Size(180, 37);
					num = 82;
				}
				if (num == 82)
				{
					this.siticoneRoundedButton3.TabIndex = 303;
					num = 83;
				}
				if (num == 83)
				{
					this.siticoneRoundedButton3.Text = "Login";
					num = 84;
				}
				if (num == 84)
				{
					this.siticoneRoundedButton3.Click += this.siticoneRoundedButton3_Click_1;
					num = 85;
				}
				if (num == 85)
				{
					this.Username.Cursor = Cursors.IBeam;
					num = 86;
				}
				if (num == 86)
				{
					this.Username.DefaultText = "";
					num = 87;
				}
				if (num == 88)
				{
					this.Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 89;
				}
				if (num == 89)
				{
					this.Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 90;
				}
				if (num == 90)
				{
					this.Username.DisabledState.Parent = this.Username;
					num = 91;
				}
				if (num == 91)
				{
					this.Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 92;
				}
				if (num == 92)
				{
					this.Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 93;
				}
				if (num == 93)
				{
					this.Username.FocusedState.Parent = this.Username;
					num = 94;
				}
				if (num == 94)
				{
					this.Username.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 95;
				}
				if (num == 95)
				{
					this.Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 96;
				}
				if (num == 97)
				{
					this.Username.Location = new Point(68, 211);
					num = 98;
				}
				if (num == 98)
				{
					this.Username.Name = "Username";
					num = 99;
				}
				if (num == 99)
				{
					this.Username.PasswordChar = '\0';
					num = 100;
				}
				if (num == 100)
				{
					this.Username.PlaceholderText = "";
					num = 101;
				}
				if (num == 101)
				{
					this.Username.SelectedText = "";
					num = 102;
				}
				if (num == 102)
				{
					this.Username.ShadowDecoration.Parent = this.Username;
					num = 103;
				}
				if (num == 103)
				{
					this.Username.Size = new Size(180, 28);
					num = 104;
				}
				if (num == 104)
				{
					this.Username.TabIndex = 306;
					num = 105;
				}
				if (num == 106)
				{
					this.processor.Location = new Point(193, 315);
					num = 107;
				}
				if (num == 107)
				{
					this.processor.Name = "processor";
					num = 108;
				}
				if (num == 108)
				{
					this.processor.Size = new Size(14, 20);
					num = 109;
				}
				if (num == 109)
				{
					this.processor.TabIndex = 307;
					num = 110;
				}
				if (num == 110)
				{
					this.auto.AutoSize = true;
					num = 111;
				}
				if (num == 111)
				{
					this.auto.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 112;
				}
				if (num == 112)
				{
					this.auto.CheckedState.BorderRadius = 0;
					num = 113;
				}
				if (num == 113)
				{
					this.auto.CheckedState.BorderThickness = 0;
					num = 114;
				}
				if (num == 115)
				{
					this.auto.ForeColor = Color.White;
					num = 116;
				}
				if (num == 116)
				{
					this.auto.Location = new Point(108, 68);
					num = 117;
				}
				if (num == 117)
				{
					this.auto.Name = "auto";
					num = 118;
				}
				if (num == 118)
				{
					this.auto.Size = new Size(77, 17);
					num = 119;
				}
				if (num == 119)
				{
					this.auto.TabIndex = 308;
					num = 120;
				}
				if (num == 120)
				{
					this.auto.Text = "Auto Login";
					num = 121;
				}
				if (num == 121)
				{
					this.auto.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 122;
				}
				if (num == 123)
				{
					this.auto.UncheckedState.BorderThickness = 0;
					num = 124;
				}
				if (num == 124)
				{
					this.auto.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 125;
				}
				if (num == 125)
				{
					this.pictureBox4.BackColor = Color.Transparent;
					num = 126;
				}
				if (num == 126)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 127;
				}
				if (num == 127)
				{
					this.pictureBox4.Location = new Point(13, 200);
					num = 128;
				}
				if (num == 128)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 129;
				}
				if (num == 129)
				{
					this.pictureBox4.Size = new Size(48, 48);
					num = 130;
				}
				if (num == 130)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 131;
				}
				if (num == 132)
				{
					this.pictureBox4.TabStop = false;
					num = 133;
				}
				if (num == 133)
				{
					this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 134;
				}
				if (num == 134)
				{
					this.pictureBox1.Location = new Point(84, 0);
					num = 135;
				}
				if (num == 135)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 136;
				}
				if (num == 136)
				{
					this.pictureBox1.Size = new Size(136, 136);
					num = 137;
				}
				if (num == 137)
				{
					this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 138;
				}
				if (num == 138)
				{
					this.pictureBox1.TabIndex = 287;
					num = 139;
				}
				if (num == 139)
				{
					this.pictureBox1.TabStop = false;
					num = 140;
				}
				if (num == 141)
				{
					this.pictureBox5.Location = new Point(-180, 0);
					num = 142;
				}
				if (num == 142)
				{
					this.pictureBox5.Name = "pictureBox5";
					num = 143;
				}
				if (num == 143)
				{
					this.pictureBox5.Size = new Size(180, 180);
					num = 144;
				}
				if (num == 144)
				{
					this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 145;
				}
				if (num == 145)
				{
					this.pictureBox5.TabIndex = 309;
					num = 146;
				}
				if (num == 146)
				{
					this.pictureBox5.TabStop = false;
					num = 147;
				}
				if (num == 147)
				{
					this.pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
					num = 148;
				}
				if (num == 148)
				{
					this.pictureBox6.Location = new Point(-180, 0);
					num = 149;
				}
				if (num == 150)
				{
					this.pictureBox6.Size = new Size(136, 136);
					num = 151;
				}
				if (num == 151)
				{
					this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 152;
				}
				if (num == 152)
				{
					this.pictureBox6.TabIndex = 310;
					num = 153;
				}
				if (num == 153)
				{
					this.pictureBox6.TabStop = false;
					num = 154;
				}
				if (num == 154)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 155;
				}
				if (num == 155)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 156;
				}
				if (num == 156)
				{
					this.BackColor = Color.FromArgb(28, 28, 28);
					num = 157;
				}
				if (num == 157)
				{
					base.Controls.Add(this.pictureBox6);
					num = 158;
				}
				if (num == 159)
				{
					base.Controls.Add(this.Username);
					num = 160;
				}
				if (num == 160)
				{
					base.Controls.Add(this.lbl_ver);
					num = 161;
				}
				if (num == 161)
				{
					base.Controls.Add(this.siticoneCheckBox1);
					num = 162;
				}
				if (num == 162)
				{
					base.Controls.Add(this.linkLabel1);
					num = 163;
				}
				if (num == 163)
				{
					base.Controls.Add(this.pictureBox4);
					num = 164;
				}
				if (num == 164)
				{
					base.Controls.Add(this.label1);
					num = 165;
				}
				if (num == 165)
				{
					base.Controls.Add(this.pictureBox1);
					num = 166;
				}
				if (num == 167)
				{
					base.Controls.Add(this.textBox1);
					num = 168;
				}
				if (num == 168)
				{
					base.Controls.Add(this.processor);
					num = 169;
				}
				if (num == 169)
				{
					base.Controls.Add(this.auto);
					num = 170;
				}
				if (num == 170)
				{
					base.Name = "LoginPanel";
					num = 171;
				}
				if (num == 171)
				{
					base.Size = new Size(303, 423);
					num = 172;
				}
				if (num == 172)
				{
					base.Load += this.Login_Panel_Load;
					num = 173;
				}
				if (num == 173)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 174;
				}
				if (num == 174)
				{
					((ISupportInitialize)this.pictureBox1).EndInit();
					num = 175;
				}
				if (num == 176)
				{
					((ISupportInitialize)this.pictureBox6).EndInit();
					num = 177;
				}
				if (num == 177)
				{
					base.ResumeLayout(false);
					num = 178;
				}
				if (num == 178)
				{
					base.PerformLayout();
					num = 179;
				}
				if (num == 175)
				{
					((ISupportInitialize)this.pictureBox5).EndInit();
					num = 176;
				}
				if (num == 166)
				{
					base.Controls.Add(this.siticoneRoundedButton3);
					num = 167;
				}
				if (num == 158)
				{
					base.Controls.Add(this.pictureBox5);
					num = 159;
				}
				if (num == 149)
				{
					this.pictureBox6.Name = "pictureBox6";
					num = 150;
				}
				if (num == 140)
				{
					this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
					num = 141;
				}
				if (num == 131)
				{
					this.pictureBox4.TabIndex = 291;
					num = 132;
				}
				if (num == 122)
				{
					this.auto.UncheckedState.BorderRadius = 0;
					num = 123;
				}
				if (num == 114)
				{
					this.auto.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 115;
				}
				if (num == 105)
				{
					this.Username.TextAlign = HorizontalAlignment.Center;
					num = 106;
				}
				if (num == 96)
				{
					this.Username.HoverState.Parent = this.Username;
					num = 97;
				}
				if (num == 87)
				{
					this.Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 88;
				}
				if (num == 79)
				{
					this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
					num = 80;
				}
				if (num == 70)
				{
					this.siticoneRoundedButton3.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 71;
				}
				if (num == 61)
				{
					this.lbl_ver.Location = new Point(12, 407);
					num = 62;
				}
				if (num == 52)
				{
					this.siticoneCheckBox1.TabIndex = 297;
					num = 53;
				}
				if (num == 43)
				{
					this.siticoneCheckBox1.AutoSize = true;
					num = 44;
				}
				if (num == 35)
				{
					this.linkLabel1.Location = new Point(204, 413);
					num = 36;
				}
				if (num == 26)
				{
					this.label1.TabIndex = 288;
					num = 27;
				}
				if (num == 17)
				{
					((ISupportInitialize)this.pictureBox5).BeginInit();
					num = 18;
				}
				if (num == 8)
				{
					this.Username = new SiticoneTextBox();
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 179);
		}

		// Token: 0x040008CB RID: 2251
		private CPU cpu;

		// Token: 0x040008CC RID: 2252
		private Bios bios;

		// Token: 0x040008CD RID: 2253
		private GPU gpu;

		// Token: 0x040008CE RID: 2254
		private static LoginPanel _instace;

		// Token: 0x040008CF RID: 2255
		private string hwid;

		// Token: 0x040008D0 RID: 2256
		private string diskname = DiskId.GetDiskName();

		// Token: 0x040008D1 RID: 2257
		private string disktype = DiskId.GetDiskType();

		// Token: 0x040008D2 RID: 2258
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040008D3 RID: 2259
		private IContainer components = null;

		// Token: 0x040008D4 RID: 2260
		private PictureBox pictureBox1;

		// Token: 0x040008D5 RID: 2261
		private Label label1;

		// Token: 0x040008D6 RID: 2262
		private PictureBox pictureBox4;

		// Token: 0x040008D7 RID: 2263
		private TextBox textBox1;

		// Token: 0x040008D8 RID: 2264
		private LinkLabel linkLabel1;

		// Token: 0x040008D9 RID: 2265
		private SiticoneCheckBox siticoneCheckBox1;

		// Token: 0x040008DA RID: 2266
		private Label lbl_ver;

		// Token: 0x040008DB RID: 2267
		private SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x040008DC RID: 2268
		private SiticoneTextBox Username;

		// Token: 0x040008DD RID: 2269
		private TextBox processor;

		// Token: 0x040008DE RID: 2270
		private SiticoneCheckBox auto;

		// Token: 0x040008DF RID: 2271
		private PictureBox pictureBox5;

		// Token: 0x040008E0 RID: 2272
		private PictureBox pictureBox6;
	}
}
