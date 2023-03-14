using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Login_HWID.User_Controls;
using Microsoft.Win32;
using NHotkey;
using NHotkey.WindowsForms;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.User_Controls;

namespace WindowsFormsApplication2
{
	// Token: 0x02000009 RID: 9
	public partial class main : Form
	{
		// Token: 0x06000022 RID: 34
		[DllImport("Memory Cleaner.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int CleanMemory(bool standbylist, bool modifiedlist, bool workingset, bool lowpriostandbylist);

		// Token: 0x06000023 RID: 35
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000024 RID: 36 RVA: 0x000050A0 File Offset: 0x000032A0
		public main()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(main.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			try
			{
				HotkeyManager.Current.AddOrReplace("Increment", (Keys)393285, new EventHandler<HotkeyEventArgs>(this.OnIncrement));
				HotkeyManager.Current.AddOrReplace("Decrement", (Keys)393284, new EventHandler<HotkeyEventArgs>(this.OnDecrement));
			}
			catch (HotkeyAlreadyRegisteredException)
			{
				MessageBox.Show("An instance is already running in background.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000051A4 File Offset: 0x000033A4
		private void OnIncrement(object sender, HotkeyEventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				Process process;
				ProcessStartInfo processStartInfo;
				if (num == 14)
				{
					process.StartInfo = processStartInfo;
					num = 15;
				}
				if (num == 17)
				{
					game_on = new game_on();
					num = 18;
				}
				if (num == 16)
				{
					process.WaitForExit();
					num = 17;
				}
				if (num == 15)
				{
					process.Start();
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo.Verb = "runas";
					num = 14;
				}
				if (num == 12)
				{
					processStartInfo.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_on.exe";
					num = 13;
				}
				if (num == 11)
				{
					processStartInfo = new ProcessStartInfo();
					num = 12;
				}
				if (num == 10)
				{
					process = new Process();
					num = 11;
				}
				Process process2;
				if (num == 9)
				{
					process2.Start();
					num = 10;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 8)
				{
					process2.StartInfo = processStartInfo2;
					num = 9;
				}
				if (num == 7)
				{
					processStartInfo2.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo2.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 4;
				}
				if (num == 2)
				{
					process2 = new Process();
					num = 3;
				}
				if (num == 1)
				{
					main.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 18);
			try
			{
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000053E0 File Offset: 0x000035E0
		private void OnDecrement(object sender, HotkeyEventArgs e)
		{
			int num = 0;
			game_off game_off;
			do
			{
				if (num == 14)
				{
					game_off = new game_off();
					num = 15;
				}
				Process process;
				if (num == 13)
				{
					process.WaitForExit();
					num = 14;
				}
				if (num == 12)
				{
					process.Start();
					num = 13;
				}
				ProcessStartInfo processStartInfo;
				if (num == 11)
				{
					process.StartInfo = processStartInfo;
					num = 12;
				}
				if (num == 10)
				{
					processStartInfo.Verb = "runas";
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 10;
				}
				if (num == 8)
				{
					processStartInfo = new ProcessStartInfo();
					num = 9;
				}
				if (num == 7)
				{
					process = new Process();
					num = 8;
				}
				Process process2;
				if (num == 6)
				{
					process2.Start();
					num = 7;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 5)
				{
					process2.StartInfo = processStartInfo2;
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo2.Verb = "runas";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo2.FileName = "C:\\Windows\\explorer.exe";
					num = 4;
				}
				if (num == 2)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process2 = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 15);
			try
			{
				game_off.ShowDialog();
			}
			finally
			{
				if (game_off != null)
				{
					((IDisposable)game_off).Dispose();
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000028 RID: 40
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000029 RID: 41
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600002A RID: 42 RVA: 0x00005654 File Offset: 0x00003854
		private void panel3_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					main.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					main.ReleaseCapture();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = e.Button == MouseButtons.Left;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005704 File Offset: 0x00003904
		private void LoadTheme()
		{
			int num = 0;
			while (num != 14 && num != 13)
			{
				if (num == 12)
				{
					goto IL_A9;
				}
				IL_BB:
				if (num == 11)
				{
					break;
				}
				if (num == 10)
				{
					goto IL_84;
				}
				IL_96:
				if (num == 9)
				{
					break;
				}
				string text;
				if (num == 8)
				{
					if (text == "Xmas")
					{
						goto IL_A9;
					}
					num = 9;
				}
				if (num == 7)
				{
					if (text == "Halloween")
					{
						goto IL_84;
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
				if (num != 15)
				{
					continue;
				}
				break;
				IL_84:
				this.Halloween_theme();
				num = 11;
				goto IL_96;
				IL_A9:
				this.Xmas_theme();
				num = 13;
				goto IL_BB;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000058F0 File Offset: 0x00003AF0
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

		// Token: 0x0600002D RID: 45 RVA: 0x00005968 File Offset: 0x00003B68
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

		// Token: 0x0600002E RID: 46 RVA: 0x000059CC File Offset: 0x00003BCC
		private void Halloween_theme()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.pictureBox5.Location = new Point(26, -34);
					num = 3;
				}
				if (num == 1)
				{
					this.pictureBox1.Location = new Point(-180, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005A58 File Offset: 0x00003C58
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.pictureBox6.Location = new Point(39, -10);
					num = 3;
				}
				if (num == 1)
				{
					this.pictureBox1.Location = new Point(-180, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005AE4 File Offset: 0x00003CE4
		private void button4_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Cleanup.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Cleanup.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Cleanup.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005B78 File Offset: 0x00003D78
		private void button5_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Tweaks.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Tweaks.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Tweaks.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005C0C File Offset: 0x00003E0C
		private void button6_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Gaming.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Gaming.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Gaming.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005CA0 File Offset: 0x00003EA0
		private void button7_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Compact.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Compact.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Compact.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005D34 File Offset: 0x00003F34
		private void button8_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Context.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Context.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Context.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005DC8 File Offset: 0x00003FC8
		private void button9_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					GameOptimizations.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					GameOptimizations.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(GameOptimizations.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005E5C File Offset: 0x0000405C
		private void button10_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					WindowsApp.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					WindowsApp.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(WindowsApp.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005EF0 File Offset: 0x000040F0
		private void button11_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Downloads.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Downloads.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Downloads.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005F84 File Offset: 0x00004184
		private void button12_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					one_click_opt.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					one_click_opt.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(one_click_opt.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006018 File Offset: 0x00004218
		private void button3_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Home.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Home.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Home.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000060AC File Offset: 0x000042AC
		private void button13_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					SystemInfo.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					SystemInfo.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(SystemInfo.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006140 File Offset: 0x00004340
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Settings.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Settings.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(Settings.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000061D4 File Offset: 0x000043D4
		private void game_B_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					GameBooster.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					GameBooster.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					this.panel2.Controls.Add(GameBooster.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006268 File Offset: 0x00004468
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 5)
				{
					this.minimize.Visible = false;
					num = 6;
				}
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 5;
				}
				if (num == 3)
				{
					object value;
					bool flag = value != null;
					num = 4;
				}
				if (num == 2)
				{
					RegistryKey registryKey;
					object value = registryKey.GetValue("Tray Icon");
					num = 3;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006330 File Offset: 0x00004530
		private void cleanMemoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					main.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000063C4 File Offset: 0x000045C4
		private void minimize_tray_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.notifyIcon1.Visible = true;
					num = 3;
				}
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
			while (num != 3);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006434 File Offset: 0x00004634
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.notifyIcon1.Visible = false;
					num = 4;
				}
				if (num == 2)
				{
					base.WindowState = FormWindowState.Normal;
					num = 3;
				}
				if (num == 1)
				{
					base.Show();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000064C0 File Offset: 0x000046C0
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 14)
				{
					goto IL_67;
				}
				IL_79:
				if (num == 17)
				{
					this.cb_lowpriostandbylist.CheckState = CheckState.Checked;
					num = 18;
				}
				if (num == 16)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 17;
				}
				object value;
				if (num == 15)
				{
					bool flag = value != null;
					num = 16;
				}
				if (num == 13)
				{
					this.cb_workingset.CheckState = CheckState.Checked;
					num = 14;
				}
				if (num == 12)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_67;
					}
					num = 13;
				}
				object value2;
				if (num == 11)
				{
					bool flag2 = value2 != null;
					num = 12;
				}
				if (num == 10)
				{
					goto IL_D9;
				}
				IL_EC:
				if (num == 9)
				{
					this.cb_modifiedlist.CheckState = CheckState.Checked;
					num = 10;
				}
				if (num == 8)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_D9;
					}
					num = 9;
				}
				object value3;
				if (num == 7)
				{
					bool flag3 = value3 != null;
					num = 8;
				}
				if (num == 6)
				{
					goto IL_149;
				}
				IL_15C:
				if (num == 5)
				{
					this.cb_standbylist.CheckState = CheckState.Checked;
					num = 6;
				}
				if (num == 4)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_149;
					}
					num = 5;
				}
				if (num == 3)
				{
					object value4;
					bool flag4 = value4 != null;
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 2)
				{
					object value4 = registryKey.GetValue("Clear Standby List");
					num = 3;
				}
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Memory Cleaner");
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
				IL_149:
				value3 = registryKey.GetValue("Clear Modified List");
				num = 7;
				goto IL_15C;
				IL_D9:
				value2 = registryKey.GetValue("Clear Working Set");
				num = 11;
				goto IL_EC;
				IL_67:
				value = registryKey.GetValue("Clear Low Priority Standby List");
				num = 15;
				goto IL_79;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006434 File Offset: 0x00004634
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.notifyIcon1.Visible = false;
					num = 4;
				}
				if (num == 2)
				{
					base.WindowState = FormWindowState.Normal;
					num = 3;
				}
				if (num == 1)
				{
					base.Show();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000066D8 File Offset: 0x000048D8
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

		// Token: 0x06000044 RID: 68 RVA: 0x000066D8 File Offset: 0x000048D8
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

		// Token: 0x06000045 RID: 69 RVA: 0x00006730 File Offset: 0x00004930
		private void minimize_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.WindowState = FormWindowState.Minimized;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006780 File Offset: 0x00004980
		private void main_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.KeyPreview = true;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x04000031 RID: 49
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000032 RID: 50
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000033 RID: 51
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000034 RID: 52
		public const int HT_CAPTION = 2;
	}
}
