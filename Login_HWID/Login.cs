using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Login_HWID.User_Controls;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;

namespace Login_HWID
{
	// Token: 0x0200004F RID: 79
	public partial class Login : Form
	{
		// Token: 0x0600038E RID: 910
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600038F RID: 911 RVA: 0x0008DBF8 File Offset: 0x0008BDF8
		public Login()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Login.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			this.siticoneRoundedButton2.Visible = false;
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0008DC98 File Offset: 0x0008BE98
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
				string text;
				if (num == 5)
				{
					object obj2;
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
					goto IL_BC;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_BC;
				}
				goto IL_102;
				IL_173:
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_190;
					}
					num = 10;
				}
				if (num == 4)
				{
					object obj2 = obj;
					num = 5;
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
				IL_1A2:
				if (num == 16)
				{
					break;
				}
				if (num == 17)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_161;
				}
				goto IL_173;
				IL_114:
				if (num == 12 || num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_190;
				}
				goto IL_1A2;
				IL_BC:
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_161;
					}
					num = 9;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 11)
				{
					goto IL_102;
				}
				goto IL_114;
				IL_161:
				this.Halloween_theme();
				num = 14;
				goto IL_173;
				IL_190:
				this.AccentColor();
				num = 16;
				goto IL_1A2;
				IL_102:
				this.Xmas_theme();
				num = 12;
				goto IL_114;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0008DED8 File Offset: 0x0008C0D8
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

		// Token: 0x06000393 RID: 915 RVA: 0x0008DF50 File Offset: 0x0008C150
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

		// Token: 0x06000394 RID: 916 RVA: 0x0008DFB4 File Offset: 0x0008C1B4
		private void Halloween_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.pictureBox5.Location = new Point(66, -3);
					num = 2;
				}
				if (num == 2)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(255, 69, 0);
					num = 3;
				}
				if (num == 3)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(255, 69, 0);
					num = 4;
				}
				if (num == 5)
				{
					this.label1.BringToFront();
					num = 6;
				}
				if (num == 6)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 7)
				{
					this.linkLabel1.LinkColor = Color.FromArgb(255, 128, 0);
					num = 8;
				}
				if (num == 8)
				{
					this.linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 0);
					num = 9;
				}
				if (num == 4)
				{
					this.label1.ForeColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0008E168 File Offset: 0x0008C368
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
					this.siticoneRoundedButton1.FillColor = accentColor;
					num = 4;
				}
				if (num == 5)
				{
					this.linkLabel1.LinkColor = accentColor;
					num = 6;
				}
				if (num == 6)
				{
					this.linkLabel1.VisitedLinkColor = accentColor;
					num = 7;
				}
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = accentColor;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0008E298 File Offset: 0x0008C498
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.pictureBox6.Location = new Point(84, 0);
					num = 2;
				}
				if (num == 2)
				{
					this.siticoneRoundedButton3.FillColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 3)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(29, 158, 255);
					num = 4;
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
				if (num == 4)
				{
					this.linkLabel1.ActiveLinkColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0008E3FC File Offset: 0x0008C5FC
		private void Login_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 2;
				}
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Username");
					num = 3;
				}
				bool flag;
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 5)
				{
					this.siticoneCheckBox1.CheckState = CheckState.Checked;
					num = 6;
				}
				if (num == 6)
				{
					goto IL_1E6;
				}
				IL_1F9:
				object value2;
				bool flag2;
				if (num == 7)
				{
					flag2 = value2 != null;
					num = 8;
				}
				if (num != 8)
				{
					goto IL_86;
				}
				if (flag2)
				{
					num = 9;
					goto IL_86;
				}
				goto IL_AE;
				IL_C4:
				bool @checked;
				if (num == 12)
				{
					if (!@checked)
					{
						break;
					}
					num = 13;
				}
				bool flag3;
				if (num == 14)
				{
					RegistryKey registryKey2;
					flag3 = registryKey2 != null;
					num = 15;
				}
				if (num == 15)
				{
					if (!flag3)
					{
						return;
					}
					num = 16;
				}
				if (num == 16)
				{
					this.panel2.Controls.Add(LoginPanel.Instance);
					num = 17;
				}
				if (num == 17)
				{
					LoginPanel.Instance.Dock = DockStyle.Fill;
					num = 18;
				}
				if (num == 19)
				{
					this.siticoneRoundedButton2.Visible = true;
					num = 20;
				}
				if (num == 20)
				{
					return;
				}
				if (num == 18)
				{
					LoginPanel.Instance.BringToFront();
					num = 19;
				}
				if (num == 13)
				{
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 14;
				}
				if (num == 9)
				{
					base.WindowState = FormWindowState.Minimized;
					num = 10;
				}
				if (num == 4)
				{
					if (!flag)
					{
						goto IL_1E6;
					}
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_86:
				if (num == 10)
				{
					base.ShowInTaskbar = false;
					num = 11;
				}
				if (num != 11)
				{
					goto IL_C4;
				}
				IL_AE:
				@checked = this.siticoneCheckBox1.Checked;
				num = 12;
				goto IL_C4;
				IL_1E6:
				value2 = registryKey.GetValue("Auto Login");
				num = 7;
				goto IL_1F9;
			}
			try
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://docs.google.com/document/d/1ZcF6ZDbk-Pz4pNamEjCuFpHwO1LbIe-Uwpii3JujCME/edit?usp=sharing");
				if (!text.Contains(this.lbl_ver.Text))
				{
					using (update_avail update_avail = new update_avail())
					{
						update_avail.ShowDialog(this);
					}
					base.Hide();
				}
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

		// Token: 0x06000398 RID: 920
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000399 RID: 921
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600039A RID: 922 RVA: 0x0008E71C File Offset: 0x0008C91C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = e.Button == MouseButtons.Left;
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 3)
				{
					Login.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					Login.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0008E7D4 File Offset: 0x0008C9D4
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.panel2.Controls.Remove(Registration.Instance);
					num = 2;
				}
				if (num == 2)
				{
					this.panel2.Controls.Remove(LoginPanel.Instance);
					num = 3;
				}
				if (num == 3)
				{
					this.siticoneRoundedButton2.Visible = false;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000066D8 File Offset: 0x000048D8
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Application.ExitThread();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00018F28 File Offset: 0x00017128
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

		// Token: 0x0600039E RID: 926 RVA: 0x00018F28 File Offset: 0x00017128
		private void button19_Click(object sender, EventArgs e)
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

		// Token: 0x0600039F RID: 927 RVA: 0x0008E87C File Offset: 0x0008CA7C
		private void button18_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.instagram.com/theworldofpc.yt/");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0008E8DC File Offset: 0x0008CADC
		private void button15_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("http://youtube.com/theworldofpc/");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00018FE4 File Offset: 0x000171E4
		private void button17_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://twitter.com/TheWorldOfPC");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0008E93C File Offset: 0x0008CB3C
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.panel2.Controls.Add(Registration.Instance);
					num = 2;
				}
				if (num == 2)
				{
					Registration.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 3)
				{
					Registration.Instance.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					this.siticoneRoundedButton2.Visible = true;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.panel2.Controls.Add(LoginPanel.Instance);
					num = 2;
				}
				if (num == 2)
				{
					LoginPanel.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 3)
				{
					LoginPanel.Instance.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					this.siticoneRoundedButton2.Visible = true;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x040003D3 RID: 979
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040003D4 RID: 980
		public static Point newpoint = default(Point);

		// Token: 0x040003D5 RID: 981
		public static int x;

		// Token: 0x040003D6 RID: 982
		public static int y;

		// Token: 0x040003D7 RID: 983
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040003D8 RID: 984
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040003D9 RID: 985
		public const int HT_CAPTION = 2;
	}
}
