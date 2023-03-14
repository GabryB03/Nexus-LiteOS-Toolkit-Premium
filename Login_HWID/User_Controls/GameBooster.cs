using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000062 RID: 98
	public class GameBooster : UserControl
	{
		// Token: 0x06000413 RID: 1043
		[DllImport("Memory Cleaner.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int CleanMemory(bool standbylist, bool modifiedlist, bool workingset, bool lowpriostandbylist);

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000A9404 File Offset: 0x000A7604
		public static GameBooster Instance
		{
			get
			{
				if (GameBooster._instace == null)
				{
					GameBooster._instace = new GameBooster();
				}
				return GameBooster._instace;
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000A942C File Offset: 0x000A762C
		public GameBooster()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000A9484 File Offset: 0x000A7684
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				object value;
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("Theme");
					num = 3;
				}
				string text;
				if (num == 5)
				{
					object obj;
					text = obj as string;
					num = 6;
				}
				if (num != 8)
				{
					goto IL_5A;
				}
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_5A;
				}
				goto IL_F1;
				IL_A0:
				if (num == 12 || num == 10)
				{
					break;
				}
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_DD;
					}
					num = 10;
				}
				if (num == 7)
				{
					if (text == "Xmas")
					{
						goto IL_13B;
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
				if (num == 4)
				{
					object obj2;
					object obj = obj2;
					num = 5;
				}
				if (num == 3)
				{
					object obj2 = value;
					num = 4;
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
				IL_F1:
				this.Halloween();
				num = 14;
				goto IL_A0;
				IL_105:
				if (num == 13)
				{
					goto IL_F1;
				}
				goto IL_A0;
				IL_DD:
				this.AccentColor();
				num = 16;
				goto IL_105;
				IL_14D:
				if (num == 14)
				{
					break;
				}
				if (num == 17 || num == 16)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_DD;
				}
				goto IL_105;
				IL_13B:
				this.Xmas_theme();
				num = 12;
				goto IL_14D;
				IL_5A:
				if (num == 11)
				{
					goto IL_13B;
				}
				goto IL_14D;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000A96D8 File Offset: 0x000A78D8
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

		// Token: 0x06000418 RID: 1048 RVA: 0x000A9750 File Offset: 0x000A7950
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

		// Token: 0x06000419 RID: 1049 RVA: 0x000A97B4 File Offset: 0x000A79B4
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.admin.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.admin.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000A9858 File Offset: 0x000A7A58
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 2)
				{
					this.admin.CheckedState.FillColor = accentColor;
					num = 3;
				}
				if (num == 3)
				{
					this.admin.CheckedState.BorderColor = accentColor;
					num = 4;
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
			while (num != 4);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000A9914 File Offset: 0x000A7B14
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.admin.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.admin.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000A99B8 File Offset: 0x000A7BB8
		private void game_booster_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Valorant Location");
					num = 3;
				}
				if (num == 5)
				{
					this.riot_client = value.ToString();
					num = 6;
				}
				if (num != 8)
				{
					goto IL_55;
				}
				bool flag;
				if (flag)
				{
					num = 9;
					goto IL_55;
				}
				goto IL_165;
				IL_180:
				object value2;
				if (num == 9)
				{
					this.steam_client = value2.ToString();
					num = 10;
				}
				if (num == 7)
				{
					flag = value2 != null;
					num = 8;
				}
				if (num == 6)
				{
					goto IL_1D7;
				}
				IL_1F2:
				if (num == 4)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_1D7;
					}
					num = 5;
				}
				if (num == 3)
				{
					bool flag2 = value != null;
					num = 4;
				}
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
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
				IL_1D7:
				value2 = registryKey.GetValue("Steam Location");
				num = 7;
				goto IL_1F2;
				IL_55:
				object value3;
				bool flag3;
				if (num == 11)
				{
					flag3 = value3 != null;
					num = 12;
				}
				if (num == 14)
				{
					goto IL_104;
				}
				IL_11F:
				object value4;
				if (num == 17)
				{
					this.genshin_launcher = value4.ToString();
					num = 18;
				}
				if (num == 16)
				{
					bool flag4;
					if (!flag4)
					{
						break;
					}
					num = 17;
				}
				if (num == 15)
				{
					bool flag4 = value4 != null;
					num = 16;
				}
				if (num == 13)
				{
					this.fortnite = value3.ToString();
					num = 14;
				}
				if (num == 12)
				{
					if (!flag3)
					{
						goto IL_104;
					}
					num = 13;
				}
				if (num == 10)
				{
					goto IL_165;
				}
				goto IL_180;
				IL_104:
				value4 = registryKey.GetValue("Genshin Location");
				num = 15;
				goto IL_11F;
				IL_165:
				value3 = registryKey.GetValue("Fortnite Location");
				num = 11;
				goto IL_180;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000A9C74 File Offset: 0x000A7E74
		private void browse_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				OpenFileDialog openFileDialog;
				if (num == 2)
				{
					openFileDialog.InitialDirectory = "c:\\";
					num = 3;
				}
				if (num == 5)
				{
					openFileDialog.RestoreDirectory = true;
					num = 6;
				}
				if (num == 8)
				{
					this.game_location.Text = openFileDialog.FileName;
					num = 9;
				}
				if (num == 7)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 8;
				}
				if (num == 6)
				{
					bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
					num = 7;
				}
				if (num == 4)
				{
					openFileDialog.FilterIndex = 0;
					num = 5;
				}
				if (num == 3)
				{
					openFileDialog.Filter = "Executables (*.exe) | *.exe|All files (*.*)|*.*";
					num = 4;
				}
				if (num == 1)
				{
					openFileDialog = new OpenFileDialog();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000A9D8C File Offset: 0x000A7F8C
		private void Boost_Click(object sender, EventArgs e)
		{
			int num = 0;
			g_opt g_opt;
			do
			{
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto Block_9;
					}
					num = 3;
				}
				if (num == 5)
				{
					g_opt = new g_opt();
					num = 6;
				}
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						goto IL_1FB;
					}
					num = 5;
				}
				if (num == 3)
				{
					bool flag = string.IsNullOrEmpty(this.game_location.Text);
					num = 4;
				}
				if (num == 1)
				{
					bool @checked = this.admin.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				g_opt.ShowDialog();
			}
			finally
			{
				if (g_opt != null)
				{
					((IDisposable)g_opt).Dispose();
				}
			}
			return;
			Block_9:
			if (string.IsNullOrEmpty(this.game_location.Text))
			{
				using (g_opt g_opt2 = new g_opt())
				{
					g_opt2.ShowDialog();
					return;
				}
			}
			GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C taskkill /F /IM explorer.exe",
					Verb = "runas"
				}
			}.Start();
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_on.exe",
				Verb = "runas"
			};
			process.Start();
			process.WaitForExit();
			using (game_on game_on = new game_on())
			{
				game_on.ShowDialog();
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += this.Worker_Boost;
			backgroundWorker.RunWorkerAsync();
			return;
			IL_1FB:
			GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C taskkill /F /IM explorer.exe",
					Verb = "runas"
				}
			}.Start();
			Process process2 = new Process();
			process2.StartInfo = new ProcessStartInfo
			{
				FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
				Verb = "runas"
			};
			process2.Start();
			process2.WaitForExit();
			using (game_on game_on2 = new game_on())
			{
				game_on2.ShowDialog();
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_BoostAdmin;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000AA0EC File Offset: 0x000A82EC
		private void Worker_BoostAdmin(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Game_Booster_admin();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000AA148 File Offset: 0x000A8348
		private void Game_Booster_admin()
		{
			int num = 0;
			game_off game_off;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				Process process;
				if (num == 5)
				{
					process.StartInfo = processStartInfo;
					num = 6;
				}
				Process process2;
				if (num == 8)
				{
					process2 = new Process();
					num = 9;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 11)
				{
					processStartInfo2.Verb = "runas";
					num = 12;
				}
				Process process3;
				if (num == 14)
				{
					process3 = new Process();
					num = 15;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 17)
				{
					processStartInfo3.Verb = "runas";
					num = 18;
				}
				if (num == 20)
				{
					process3.WaitForExit();
					num = 21;
				}
				if (num == 21)
				{
					game_off = new game_off();
					num = 22;
				}
				if (num == 19)
				{
					process3.Start();
					num = 20;
				}
				if (num == 18)
				{
					process3.StartInfo = processStartInfo3;
					num = 19;
				}
				if (num == 16)
				{
					processStartInfo3.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 16;
				}
				if (num == 13)
				{
					process2.Start();
					num = 14;
				}
				if (num == 12)
				{
					process2.StartInfo = processStartInfo2;
					num = 13;
				}
				if (num == 10)
				{
					processStartInfo2.FileName = "C:\\Windows\\explorer.exe";
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 10;
				}
				if (num == 7)
				{
					process.WaitForExit();
					num = 8;
				}
				if (num == 6)
				{
					process.Start();
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Verb = "runas";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.browse.Text;
					num = 4;
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
			while (num != 22);
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

		// Token: 0x06000421 RID: 1057 RVA: 0x000AA480 File Offset: 0x000A8680
		private void Worker_Boost(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Game_Booster();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000AA4DC File Offset: 0x000A86DC
		private void Game_Booster()
		{
			int num = 0;
			game_off game_off;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				Process process;
				if (num == 5)
				{
					process.Start();
					num = 6;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 8)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 9;
				}
				Process process2;
				if (num == 11)
				{
					process2.StartInfo = processStartInfo2;
					num = 12;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 14)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 15;
				}
				Process process3;
				if (num == 17)
				{
					process3.StartInfo = processStartInfo3;
					num = 18;
				}
				if (num == 20)
				{
					game_off = new game_off();
					num = 21;
				}
				if (num == 19)
				{
					process3.WaitForExit();
					num = 20;
				}
				if (num == 18)
				{
					process3.Start();
					num = 19;
				}
				if (num == 16)
				{
					processStartInfo3.Verb = "runas";
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo3.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 16;
				}
				if (num == 13)
				{
					process3 = new Process();
					num = 14;
				}
				if (num == 12)
				{
					process2.Start();
					num = 13;
				}
				if (num == 10)
				{
					processStartInfo2.Verb = "runas";
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo2.FileName = "C:\\Windows\\explorer.exe";
					num = 10;
				}
				if (num == 7)
				{
					process2 = new Process();
					num = 8;
				}
				if (num == 6)
				{
					process.WaitForExit();
					num = 7;
				}
				if (num == 4)
				{
					process.StartInfo = processStartInfo;
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.browse.Text;
					num = 4;
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
			while (num != 21);
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

		// Token: 0x06000423 RID: 1059 RVA: 0x000AA7F0 File Offset: 0x000A89F0
		private void enable_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				Process process;
				if (num == 2)
				{
					process = new Process();
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 6;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 11)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 12;
				}
				Process process2;
				if (num == 14)
				{
					process2.StartInfo = processStartInfo2;
					num = 15;
				}
				if (num == 17)
				{
					game_on = new game_on();
					num = 18;
				}
				if (num == 16)
				{
					process2.WaitForExit();
					num = 17;
				}
				if (num == 15)
				{
					process2.Start();
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2.Verb = "runas";
					num = 14;
				}
				if (num == 12)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_on.exe";
					num = 13;
				}
				if (num == 10)
				{
					process2 = new Process();
					num = 11;
				}
				if (num == 9)
				{
					process.Start();
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo = new ProcessStartInfo();
					num = 4;
				}
				if (num == 1)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
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

		// Token: 0x06000424 RID: 1060 RVA: 0x000AAA28 File Offset: 0x000A8C28
		private void disable_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_off game_off;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				Process process;
				if (num == 5)
				{
					process.StartInfo = processStartInfo;
					num = 6;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 8)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 9;
				}
				Process process2;
				if (num == 11)
				{
					process2.StartInfo = processStartInfo2;
					num = 12;
				}
				if (num == 14)
				{
					game_off = new game_off();
					num = 15;
				}
				if (num == 13)
				{
					process2.WaitForExit();
					num = 14;
				}
				if (num == 12)
				{
					process2.Start();
					num = 13;
				}
				if (num == 10)
				{
					processStartInfo2.Verb = "runas";
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 10;
				}
				if (num == 7)
				{
					process2 = new Process();
					num = 8;
				}
				if (num == 6)
				{
					process.Start();
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Verb = "runas";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = "C:\\Windows\\explorer.exe";
					num = 4;
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

		// Token: 0x06000425 RID: 1061 RVA: 0x000AAC70 File Offset: 0x000A8E70
		private void launch_val_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.riot_client);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\Riot Client\\RiotClientServices.exe"))
			{
				this.riot_client = folderBrowserDialog.SelectedPath + "\\Riot Client\\RiotClientServices.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Valorant Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\Riot Client\\RiotClientServices.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_Val;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_Val;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000AB0E4 File Offset: 0x000A92E4
		private void Worker_Val(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_val();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000AB140 File Offset: 0x000A9340
		private void Boost_val()
		{
			int num = 0;
			game_off game_off;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 11)
				{
					processStartInfo2.FileName = "C:\\Windows\\explorer.exe";
					num = 12;
				}
				Process process2;
				if (num == 14)
				{
					process2.Start();
					num = 15;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 17)
				{
					processStartInfo3.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 18;
				}
				Process process3;
				if (num == 20)
				{
					process3.Start();
					num = 21;
				}
				if (num == 22)
				{
					game_off = new game_off();
					num = 23;
				}
				if (num == 21)
				{
					process3.WaitForExit();
					num = 22;
				}
				if (num == 19)
				{
					process3.StartInfo = processStartInfo3;
					num = 20;
				}
				if (num == 18)
				{
					processStartInfo3.Verb = "runas";
					num = 19;
				}
				if (num == 16)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 17;
				}
				if (num == 15)
				{
					process3 = new Process();
					num = 16;
				}
				if (num == 13)
				{
					process2.StartInfo = processStartInfo2;
					num = 14;
				}
				if (num == 12)
				{
					processStartInfo2.Verb = "runas";
					num = 13;
				}
				if (num == 10)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 11;
				}
				if (num == 9)
				{
					process2 = new Process();
					num = 10;
				}
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = " --launch-product=valorant --launch-patchline=live";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.riot_client;
					num = 4;
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
			while (num != 23);
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

		// Token: 0x06000428 RID: 1064 RVA: 0x000AB498 File Offset: 0x000A9698
		private void launch_pubg_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.steam_client);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\steam.exe"))
			{
				this.steam_client = folderBrowserDialog.SelectedPath + "\\steam.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Steam Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\steam.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_pubg;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_pubg;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000AB90C File Offset: 0x000A9B0C
		private void Worker_pubg(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_pubg();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000AB968 File Offset: 0x000A9B68
		private void Boost_pubg()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = " steam://rungameid/578080";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.steam_client;
					num = 4;
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
			while (num != 8);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		private void launch_csgo_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.steam_client);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\steam.exe"))
			{
				this.steam_client = folderBrowserDialog.SelectedPath + "\\steam.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Steam Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\steam.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_csgo;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_csgo;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000ABF14 File Offset: 0x000AA114
		private void Worker_csgo(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_csgo();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000ABF70 File Offset: 0x000AA170
		private void Boost_csgo()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = " steam://rungameid/730";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.steam_client;
					num = 4;
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
			while (num != 8);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000AC0A8 File Offset: 0x000AA2A8
		private void launch_LoL_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.riot_client);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\Riot Client\\RiotClientServices.exe"))
			{
				this.riot_client = folderBrowserDialog.SelectedPath + "\\Riot Client\\RiotClientServices.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Riot Client Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\Riot Client\\RiotClientServices.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_LoL;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_LoL;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000AC51C File Offset: 0x000AA71C
		private void Worker_LoL(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_LoL();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000AC578 File Offset: 0x000AA778
		private void Boost_LoL()
		{
			int num = 0;
			game_off game_off;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 11)
				{
					processStartInfo2.FileName = "C:\\Windows\\explorer.exe";
					num = 12;
				}
				Process process2;
				if (num == 14)
				{
					process2.Start();
					num = 15;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 17)
				{
					processStartInfo3.FileName = "C:\\Windows\\SysWOW64\\Lv-lv\\game_off.exe";
					num = 18;
				}
				Process process3;
				if (num == 20)
				{
					process3.Start();
					num = 21;
				}
				if (num == 22)
				{
					game_off = new game_off();
					num = 23;
				}
				if (num == 21)
				{
					process3.WaitForExit();
					num = 22;
				}
				if (num == 19)
				{
					process3.StartInfo = processStartInfo3;
					num = 20;
				}
				if (num == 18)
				{
					processStartInfo3.Verb = "runas";
					num = 19;
				}
				if (num == 16)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 17;
				}
				if (num == 15)
				{
					process3 = new Process();
					num = 16;
				}
				if (num == 13)
				{
					process2.StartInfo = processStartInfo2;
					num = 14;
				}
				if (num == 12)
				{
					processStartInfo2.Verb = "runas";
					num = 13;
				}
				if (num == 10)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 11;
				}
				if (num == 9)
				{
					process2 = new Process();
					num = 10;
				}
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = " --launch-product=league_of_legends --launch-patchline=live";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.riot_client;
					num = 4;
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
			while (num != 23);
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

		// Token: 0x06000431 RID: 1073 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
		private void launch_apex_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.steam_client);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\steam.exe"))
			{
				this.steam_client = folderBrowserDialog.SelectedPath + "\\steam.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Steam Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\steam.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_apex;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_apex;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000ACD44 File Offset: 0x000AAF44
		private void Worker_apex(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_apex();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000ACDA0 File Offset: 0x000AAFA0
		private void Boost_apex()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = " steam://rungameid/1172470";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.steam_client;
					num = 4;
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
			while (num != 8);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		private void launch_fn_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.fortnite);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe"))
			{
				this.fortnite = folderBrowserDialog.SelectedPath + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Fortnite Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_fn;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_fn;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000AD34C File Offset: 0x000AB54C
		private void Worker_fn(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_fn();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000AD3A8 File Offset: 0x000AB5A8
		private void Boost_fn()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				Process process;
				if (num == 5)
				{
					process.StartInfo = processStartInfo;
					num = 6;
				}
				if (num == 6)
				{
					process.Start();
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Verb = "runas";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.fortnite;
					num = 4;
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
			while (num != 7);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000AD4BC File Offset: 0x000AB6BC
		private void launch_genshin_Click(object sender, EventArgs e)
		{
			int num = 0;
			game_on game_on;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto Block_22;
					}
					num = 3;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C taskkill /F /IM explorer.exe";
					num = 9;
				}
				Process process;
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 14)
				{
					processStartInfo2.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe";
					num = 15;
				}
				Process process2;
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				if (num == 19)
				{
					game_on = new game_on();
					num = 20;
				}
				if (num == 18)
				{
					process2.WaitForExit();
					num = 19;
				}
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 15)
				{
					processStartInfo2.Verb = "runas";
					num = 16;
				}
				if (num == 13)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 14;
				}
				if (num == 12)
				{
					process2 = new Process();
					num = 13;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				if (num == 3)
				{
					GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.genshin_launcher);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 20);
			goto IL_405;
			Block_22:
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			if (File.Exists(folderBrowserDialog.SelectedPath + "\\Genshin Impact game\\GenshinImpact.exe"))
			{
				this.genshin_launcher = folderBrowserDialog.SelectedPath + "\\launcher.exe";
				Environment.SpecialFolder rootFolder = folderBrowserDialog.RootFolder;
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Game Booster");
				if (registryKey != null)
				{
					RegistryKey registryKey2 = registryKey;
					string text = "Genshin Location";
					string selectedPath = folderBrowserDialog.SelectedPath;
					registryKey2.SetValue(text, ((selectedPath != null) ? selectedPath.ToString() : null) + "\\launcher.exe");
				}
				GameBooster.CleanMemory(this.cb_standbylist.Checked, this.cb_modifiedlist.Checked, this.cb_workingset.Checked, this.cb_lowpriostandbylist.Checked);
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						WindowStyle = ProcessWindowStyle.Hidden,
						FileName = "cmd.exe",
						Arguments = "/C taskkill /F /IM explorer.exe",
						Verb = "runas"
					}
				}.Start();
				Process process3 = new Process();
				process3.StartInfo = new ProcessStartInfo
				{
					FileName = "C:\\Windows\\SysWOW64\\lv-LV\\game_on.exe",
					Verb = "runas"
				};
				process3.Start();
				process3.WaitForExit();
				using (game_on game_on2 = new game_on())
				{
					game_on2.ShowDialog();
				}
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.Worker_genshin;
				backgroundWorker.RunWorkerAsync();
				return;
			}
			using (gb_404 gb_ = new gb_404())
			{
				gb_.ShowDialog();
				return;
			}
			try
			{
				IL_405:
				game_on.ShowDialog();
			}
			finally
			{
				if (game_on != null)
				{
					((IDisposable)game_on).Dispose();
				}
			}
			BackgroundWorker backgroundWorker2 = new BackgroundWorker();
			backgroundWorker2.DoWork += this.Worker_genshin;
			backgroundWorker2.RunWorkerAsync();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000AD930 File Offset: 0x000ABB30
		private void Worker_genshin(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Boost_genshin();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000AD98C File Offset: 0x000ABB8C
		private void Boost_genshin()
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				Process process;
				if (num == 5)
				{
					process.StartInfo = processStartInfo;
					num = 6;
				}
				if (num == 6)
				{
					process.Start();
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Verb = "runas";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = this.genshin_launcher;
					num = 4;
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
			while (num != 7);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000ADAA0 File Offset: 0x000ABCA0
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

		// Token: 0x0600043B RID: 1083 RVA: 0x000ADB18 File Offset: 0x000ABD18
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 5)
				{
					this.cb_lowpriostandbylist = new SiticoneCheckBox();
					num = 6;
				}
				if (num == 11)
				{
					this.label4 = new Label();
					num = 12;
				}
				if (num == 17)
				{
					this.launch_pubg = new SiticoneButton();
					num = 18;
				}
				if (num == 23)
				{
					this.launch_fn = new SiticoneButton();
					num = 24;
				}
				if (num == 29)
				{
					this.label1.AutoSize = true;
					num = 30;
				}
				if (num == 34)
				{
					this.label1.Size = new Size(243, 53);
					num = 35;
				}
				if (num == 40)
				{
					this.label266.Location = new Point(23, 53);
					num = 41;
				}
				if (num == 46)
				{
					this.cb_lowpriostandbylist.AutoSize = true;
					num = 47;
				}
				if (num == 52)
				{
					this.cb_lowpriostandbylist.CheckState = CheckState.Checked;
					num = 53;
				}
				if (num == 58)
				{
					this.cb_lowpriostandbylist.TabIndex = 326;
					num = 59;
				}
				if (num == 64)
				{
					this.cb_workingset.AutoSize = true;
					num = 65;
				}
				if (num == 69)
				{
					this.cb_workingset.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 70;
				}
				if (num == 75)
				{
					this.cb_workingset.Size = new Size(136, 24);
					num = 76;
				}
				if (num == 81)
				{
					this.cb_workingset.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 82;
				}
				if (num == 87)
				{
					this.cb_modifiedlist.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 88;
				}
				if (num == 93)
				{
					this.cb_modifiedlist.Size = new Size(142, 24);
					num = 94;
				}
				if (num == 98)
				{
					this.cb_modifiedlist.UncheckedState.BorderThickness = 0;
					num = 99;
				}
				if (num == 104)
				{
					this.cb_standbylist.CheckedState.BorderThickness = 0;
					num = 105;
				}
				if (num == 110)
				{
					this.cb_standbylist.Name = "cb_standbylist";
					num = 111;
				}
				if (num == 116)
				{
					this.cb_standbylist.UncheckedState.BorderThickness = 0;
					num = 117;
				}
				if (num == 122)
				{
					this.disable.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 123;
				}
				if (num == 128)
				{
					this.disable.HoverState.Parent = this.disable;
					num = 129;
				}
				if (num == 133)
				{
					this.disable.Size = new Size(100, 38);
					num = 134;
				}
				if (num == 139)
				{
					this.enable.DisabledState.BorderColor = Color.DarkGray;
					num = 140;
				}
				if (num == 145)
				{
					this.enable.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 146;
				}
				if (num == 151)
				{
					this.enable.ShadowDecoration.Parent = this.enable;
					num = 152;
				}
				if (num == 157)
				{
					this.label4.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 158;
				}
				if (num == 162)
				{
					this.label4.TabIndex = 365;
					num = 163;
				}
				if (num == 168)
				{
					this.Boost.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 169;
				}
				if (num == 174)
				{
					this.Boost.HoverState.Parent = this.Boost;
					num = 175;
				}
				if (num == 180)
				{
					this.Boost.TabIndex = 364;
					num = 181;
				}
				if (num == 186)
				{
					this.label3.Location = new Point(22, 129);
					num = 187;
				}
				if (num == 192)
				{
					this.admin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 193;
				}
				if (num == 197)
				{
					this.admin.ForeColor = Color.White;
					num = 198;
				}
				if (num == 203)
				{
					this.admin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 204;
				}
				if (num == 209)
				{
					this.game_location.DefaultText = "";
					num = 210;
				}
				if (num == 215)
				{
					this.game_location.FillColor = Color.FromArgb(38, 38, 38);
					num = 216;
				}
				if (num == 221)
				{
					this.game_location.HoverState.Parent = this.game_location;
					num = 222;
				}
				if (num == 226)
				{
					this.game_location.ReadOnly = true;
					num = 227;
				}
				if (num == 232)
				{
					this.browse.CustomImages.Parent = this.browse;
					num = 233;
				}
				if (num == 238)
				{
					this.browse.FillColor = Color.FromArgb(38, 38, 38);
					num = 239;
				}
				if (num == 244)
				{
					this.browse.Name = "browse";
					num = 245;
				}
				if (num == 250)
				{
					this.launch_pubg.CheckedState.Parent = this.launch_pubg;
					num = 251;
				}
				if (num == 256)
				{
					this.launch_pubg.DisabledState.Parent = this.launch_pubg;
					num = 257;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 261)
				{
					this.launch_pubg.Image = (Image)componentResourceManager.GetObject("launch_pubg.Image");
					num = 262;
				}
				if (num == 267)
				{
					this.launch_pubg.TabIndex = 359;
					num = 268;
				}
				if (num == 273)
				{
					this.launch_csgo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 274;
				}
				if (num == 279)
				{
					this.launch_csgo.HoverState.Parent = this.launch_csgo;
					num = 280;
				}
				if (num == 285)
				{
					this.launch_csgo.Size = new Size(52, 52);
					num = 286;
				}
				if (num == 290)
				{
					this.launch_LoL.DisabledState.BorderColor = Color.DarkGray;
					num = 291;
				}
				if (num == 296)
				{
					this.launch_LoL.Font = new Font("Segoe UI", 9f);
					num = 297;
				}
				if (num == 302)
				{
					this.launch_LoL.Name = "launch_LoL";
					num = 303;
				}
				if (num == 308)
				{
					this.launch_val.CustomImages.Parent = this.launch_val;
					num = 309;
				}
				if (num == 314)
				{
					this.launch_val.FillColor = Color.Transparent;
					num = 315;
				}
				if (num == 320)
				{
					this.launch_val.Location = new Point(327, 582);
					num = 321;
				}
				if (num == 325)
				{
					this.launch_val.Click += this.launch_val_Click;
					num = 326;
				}
				if (num == 331)
				{
					this.label2.Size = new Size(148, 30);
					num = 332;
				}
				if (num == 337)
				{
					this.label5.Location = new Point(509, 561);
					num = 338;
				}
				if (num == 343)
				{
					this.launch_fn.CustomImages.Parent = this.launch_fn;
					num = 344;
				}
				if (num == 349)
				{
					this.launch_fn.FillColor = Color.Transparent;
					num = 350;
				}
				if (num == 354)
				{
					this.launch_fn.ImageSize = new Size(52, 52);
					num = 355;
				}
				if (num == 360)
				{
					this.launch_fn.Click += this.launch_fn_Click;
					num = 361;
				}
				if (num == 366)
				{
					this.launch_apex.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 367;
				}
				if (num == 372)
				{
					this.launch_apex.Image = (Image)componentResourceManager.GetObject("launch_apex.Image");
					num = 373;
				}
				if (num == 378)
				{
					this.launch_apex.TabIndex = 355;
					num = 379;
				}
				if (num == 384)
				{
					this.label6.Name = "label6";
					num = 385;
				}
				if (num == 389)
				{
					this.label7.Font = new Font("Josefin Sans", 8.25f);
					num = 390;
				}
				if (num == 395)
				{
					this.label7.Text = "(CTRL + ALT + D)";
					num = 396;
				}
				if (num == 401)
				{
					this.launch_genshin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 402;
				}
				if (num == 407)
				{
					this.launch_genshin.Image = (Image)componentResourceManager.GetObject("launch_genshin.Image");
					num = 408;
				}
				if (num == 413)
				{
					this.launch_genshin.TabIndex = 374;
					num = 414;
				}
				if (num == 418)
				{
					base.Controls.Add(this.launch_genshin);
					num = 419;
				}
				if (num == 424)
				{
					base.Controls.Add(this.label4);
					num = 425;
				}
				if (num == 430)
				{
					base.Controls.Add(this.launch_pubg);
					num = 431;
				}
				if (num == 436)
				{
					base.Controls.Add(this.label1);
					num = 437;
				}
				if (num == 442)
				{
					base.Controls.Add(this.launch_fn);
					num = 443;
				}
				if (num == 447)
				{
					base.PerformLayout();
					num = 448;
				}
				if (num == 446)
				{
					base.ResumeLayout(false);
					num = 447;
				}
				if (num == 445)
				{
					base.Load += this.game_booster_Load;
					num = 446;
				}
				if (num == 444)
				{
					base.Size = new Size(1006, 681);
					num = 445;
				}
				if (num == 443)
				{
					base.Name = "GameBooster";
					num = 444;
				}
				if (num == 441)
				{
					base.Controls.Add(this.launch_val);
					num = 442;
				}
				if (num == 440)
				{
					base.Controls.Add(this.cb_lowpriostandbylist);
					num = 441;
				}
				if (num == 439)
				{
					base.Controls.Add(this.cb_workingset);
					num = 440;
				}
				if (num == 438)
				{
					base.Controls.Add(this.cb_modifiedlist);
					num = 439;
				}
				if (num == 437)
				{
					base.Controls.Add(this.cb_standbylist);
					num = 438;
				}
				if (num == 435)
				{
					base.Controls.Add(this.label266);
					num = 436;
				}
				if (num == 434)
				{
					base.Controls.Add(this.label2);
					num = 435;
				}
				if (num == 433)
				{
					base.Controls.Add(this.launch_apex);
					num = 434;
				}
				if (num == 432)
				{
					base.Controls.Add(this.launch_LoL);
					num = 433;
				}
				if (num == 431)
				{
					base.Controls.Add(this.launch_csgo);
					num = 432;
				}
				if (num == 429)
				{
					base.Controls.Add(this.browse);
					num = 430;
				}
				if (num == 428)
				{
					base.Controls.Add(this.game_location);
					num = 429;
				}
				if (num == 427)
				{
					base.Controls.Add(this.admin);
					num = 428;
				}
				if (num == 426)
				{
					base.Controls.Add(this.label3);
					num = 427;
				}
				if (num == 425)
				{
					base.Controls.Add(this.Boost);
					num = 426;
				}
				if (num == 423)
				{
					base.Controls.Add(this.enable);
					num = 424;
				}
				if (num == 422)
				{
					base.Controls.Add(this.disable);
					num = 423;
				}
				if (num == 421)
				{
					base.Controls.Add(this.label5);
					num = 422;
				}
				if (num == 420)
				{
					base.Controls.Add(this.label6);
					num = 421;
				}
				if (num == 419)
				{
					base.Controls.Add(this.label7);
					num = 420;
				}
				if (num == 417)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 418;
				}
				if (num == 416)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 417;
				}
				if (num == 415)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 416;
				}
				if (num == 414)
				{
					this.launch_genshin.Click += this.launch_genshin_Click;
					num = 415;
				}
				if (num == 412)
				{
					this.launch_genshin.Size = new Size(52, 52);
					num = 413;
				}
				if (num == 411)
				{
					this.launch_genshin.ShadowDecoration.Parent = this.launch_genshin;
					num = 412;
				}
				if (num == 410)
				{
					this.launch_genshin.Name = "launch_genshin";
					num = 411;
				}
				if (num == 409)
				{
					this.launch_genshin.Location = new Point(385, 582);
					num = 410;
				}
				if (num == 408)
				{
					this.launch_genshin.ImageSize = new Size(50, 50);
					num = 409;
				}
				if (num == 406)
				{
					this.launch_genshin.HoverState.Parent = this.launch_genshin;
					num = 407;
				}
				if (num == 405)
				{
					this.launch_genshin.ForeColor = Color.White;
					num = 406;
				}
				if (num == 404)
				{
					this.launch_genshin.Font = new Font("Segoe UI", 9f);
					num = 405;
				}
				if (num == 403)
				{
					this.launch_genshin.FillColor = Color.Transparent;
					num = 404;
				}
				if (num == 402)
				{
					this.launch_genshin.DisabledState.Parent = this.launch_genshin;
					num = 403;
				}
				if (num == 400)
				{
					this.launch_genshin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 401;
				}
				if (num == 399)
				{
					this.launch_genshin.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 400;
				}
				if (num == 398)
				{
					this.launch_genshin.DisabledState.BorderColor = Color.DarkGray;
					num = 399;
				}
				if (num == 397)
				{
					this.launch_genshin.CustomImages.Parent = this.launch_genshin;
					num = 398;
				}
				if (num == 396)
				{
					this.launch_genshin.CheckedState.Parent = this.launch_genshin;
					num = 397;
				}
				if (num == 394)
				{
					this.label7.TabIndex = 373;
					num = 395;
				}
				if (num == 393)
				{
					this.label7.Size = new Size(96, 18);
					num = 394;
				}
				if (num == 392)
				{
					this.label7.Name = "label7";
					num = 393;
				}
				if (num == 391)
				{
					this.label7.Location = new Point(214, 414);
					num = 392;
				}
				if (num == 390)
				{
					this.label7.ForeColor = Color.Silver;
					num = 391;
				}
				if (num == 388)
				{
					this.label7.AutoSize = true;
					num = 389;
				}
				if (num == 387)
				{
					this.label6.Text = "(CTRL + ALT + E)";
					num = 388;
				}
				if (num == 386)
				{
					this.label6.TabIndex = 372;
					num = 387;
				}
				if (num == 385)
				{
					this.label6.Size = new Size(95, 18);
					num = 386;
				}
				if (num == 383)
				{
					this.label6.Location = new Point(50, 414);
					num = 384;
				}
				if (num == 382)
				{
					this.label6.ForeColor = Color.Silver;
					num = 383;
				}
				if (num == 381)
				{
					this.label6.Font = new Font("Josefin Sans", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 382;
				}
				if (num == 380)
				{
					this.label6.AutoSize = true;
					num = 381;
				}
				if (num == 379)
				{
					this.launch_apex.Click += this.launch_apex_Click;
					num = 380;
				}
				if (num == 377)
				{
					this.launch_apex.Size = new Size(52, 52);
					num = 378;
				}
				if (num == 376)
				{
					this.launch_apex.ShadowDecoration.Parent = this.launch_apex;
					num = 377;
				}
				if (num == 375)
				{
					this.launch_apex.Name = "launch_apex";
					num = 376;
				}
				if (num == 374)
				{
					this.launch_apex.Location = new Point(37, 582);
					num = 375;
				}
				if (num == 373)
				{
					this.launch_apex.ImageSize = new Size(50, 50);
					num = 374;
				}
				if (num == 371)
				{
					this.launch_apex.HoverState.Parent = this.launch_apex;
					num = 372;
				}
				if (num == 370)
				{
					this.launch_apex.ForeColor = Color.White;
					num = 371;
				}
				if (num == 369)
				{
					this.launch_apex.Font = new Font("Segoe UI", 9f);
					num = 370;
				}
				if (num == 368)
				{
					this.launch_apex.FillColor = Color.Transparent;
					num = 369;
				}
				if (num == 367)
				{
					this.launch_apex.DisabledState.Parent = this.launch_apex;
					num = 368;
				}
				if (num == 365)
				{
					this.launch_apex.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 366;
				}
				if (num == 364)
				{
					this.launch_apex.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 365;
				}
				if (num == 363)
				{
					this.launch_apex.DisabledState.BorderColor = Color.DarkGray;
					num = 364;
				}
				if (num == 362)
				{
					this.launch_apex.CustomImages.Parent = this.launch_apex;
					num = 363;
				}
				if (num == 361)
				{
					this.launch_apex.CheckedState.Parent = this.launch_apex;
					num = 362;
				}
				if (num == 359)
				{
					this.launch_fn.TabIndex = 354;
					num = 360;
				}
				if (num == 358)
				{
					this.launch_fn.Size = new Size(52, 52);
					num = 359;
				}
				if (num == 357)
				{
					this.launch_fn.ShadowDecoration.Parent = this.launch_fn;
					num = 358;
				}
				if (num == 356)
				{
					this.launch_fn.Name = "launch_fn";
					num = 357;
				}
				if (num == 355)
				{
					this.launch_fn.Location = new Point(153, 582);
					num = 356;
				}
				if (num == 353)
				{
					this.launch_fn.Image = (Image)componentResourceManager.GetObject("launch_fn.Image");
					num = 354;
				}
				if (num == 352)
				{
					this.launch_fn.HoverState.Parent = this.launch_fn;
					num = 353;
				}
				if (num == 351)
				{
					this.launch_fn.ForeColor = Color.White;
					num = 352;
				}
				if (num == 350)
				{
					this.launch_fn.Font = new Font("Segoe UI", 9f);
					num = 351;
				}
				if (num == 348)
				{
					this.launch_fn.DisabledState.Parent = this.launch_fn;
					num = 349;
				}
				if (num == 347)
				{
					this.launch_fn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 348;
				}
				if (num == 346)
				{
					this.launch_fn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 347;
				}
				if (num == 345)
				{
					this.launch_fn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 346;
				}
				if (num == 344)
				{
					this.launch_fn.DisabledState.BorderColor = Color.DarkGray;
					num = 345;
				}
				if (num == 342)
				{
					this.launch_fn.CheckedState.Parent = this.launch_fn;
					num = 343;
				}
				if (num == 341)
				{
					this.label5.Text = componentResourceManager.GetString("label5.Text");
					num = 342;
				}
				if (num == 340)
				{
					this.label5.TabIndex = 370;
					num = 341;
				}
				if (num == 339)
				{
					this.label5.Size = new Size(379, 95);
					num = 340;
				}
				if (num == 338)
				{
					this.label5.Name = "label5";
					num = 339;
				}
				if (num == 336)
				{
					this.label5.ForeColor = Color.Silver;
					num = 337;
				}
				if (num == 335)
				{
					this.label5.Font = new Font("Josefin Sans", 9f);
					num = 336;
				}
				if (num == 334)
				{
					this.label5.AutoSize = true;
					num = 335;
				}
				if (num == 333)
				{
					this.label2.Text = "• Quick Launch";
					num = 334;
				}
				if (num == 332)
				{
					this.label2.TabIndex = 352;
					num = 333;
				}
				if (num == 330)
				{
					this.label2.Name = "label2";
					num = 331;
				}
				if (num == 329)
				{
					this.label2.Location = new Point(22, 532);
					num = 330;
				}
				if (num == 328)
				{
					this.label2.ForeColor = Color.White;
					num = 329;
				}
				if (num == 327)
				{
					this.label2.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 328;
				}
				if (num == 326)
				{
					this.label2.AutoSize = true;
					num = 327;
				}
				if (num == 324)
				{
					this.launch_val.TabIndex = 353;
					num = 325;
				}
				if (num == 323)
				{
					this.launch_val.Size = new Size(52, 52);
					num = 324;
				}
				if (num == 322)
				{
					this.launch_val.ShadowDecoration.Parent = this.launch_val;
					num = 323;
				}
				if (num == 321)
				{
					this.launch_val.Name = "launch_val";
					num = 322;
				}
				if (num == 319)
				{
					this.launch_val.ImageSize = new Size(50, 50);
					num = 320;
				}
				if (num == 318)
				{
					this.launch_val.Image = (Image)componentResourceManager.GetObject("launch_val.Image");
					num = 319;
				}
				if (num == 317)
				{
					this.launch_val.HoverState.Parent = this.launch_val;
					num = 318;
				}
				if (num == 316)
				{
					this.launch_val.ForeColor = Color.White;
					num = 317;
				}
				if (num == 315)
				{
					this.launch_val.Font = new Font("Segoe UI", 9f);
					num = 316;
				}
				if (num == 313)
				{
					this.launch_val.DisabledState.Parent = this.launch_val;
					num = 314;
				}
				if (num == 312)
				{
					this.launch_val.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 313;
				}
				if (num == 311)
				{
					this.launch_val.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 312;
				}
				if (num == 310)
				{
					this.launch_val.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 311;
				}
				if (num == 309)
				{
					this.launch_val.DisabledState.BorderColor = Color.DarkGray;
					num = 310;
				}
				if (num == 307)
				{
					this.launch_val.CheckedState.Parent = this.launch_val;
					num = 308;
				}
				if (num == 306)
				{
					this.launch_LoL.Click += this.launch_LoL_Click;
					num = 307;
				}
				if (num == 305)
				{
					this.launch_LoL.TabIndex = 356;
					num = 306;
				}
				if (num == 304)
				{
					this.launch_LoL.Size = new Size(52, 52);
					num = 305;
				}
				if (num == 303)
				{
					this.launch_LoL.ShadowDecoration.Parent = this.launch_LoL;
					num = 304;
				}
				if (num == 301)
				{
					this.launch_LoL.Location = new Point(211, 582);
					num = 302;
				}
				if (num == 300)
				{
					this.launch_LoL.ImageSize = new Size(50, 50);
					num = 301;
				}
				if (num == 299)
				{
					this.launch_LoL.Image = (Image)componentResourceManager.GetObject("launch_LoL.Image");
					num = 300;
				}
				if (num == 298)
				{
					this.launch_LoL.HoverState.Parent = this.launch_LoL;
					num = 299;
				}
				if (num == 297)
				{
					this.launch_LoL.ForeColor = Color.White;
					num = 298;
				}
				if (num == 295)
				{
					this.launch_LoL.FillColor = Color.Transparent;
					num = 296;
				}
				if (num == 294)
				{
					this.launch_LoL.DisabledState.Parent = this.launch_LoL;
					num = 295;
				}
				if (num == 293)
				{
					this.launch_LoL.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 294;
				}
				if (num == 292)
				{
					this.launch_LoL.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 293;
				}
				if (num == 291)
				{
					this.launch_LoL.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 292;
				}
				if (num == 289)
				{
					this.launch_LoL.CustomImages.Parent = this.launch_LoL;
					num = 290;
				}
				if (num == 288)
				{
					this.launch_LoL.CheckedState.Parent = this.launch_LoL;
					num = 289;
				}
				if (num == 287)
				{
					this.launch_csgo.Click += this.launch_csgo_Click;
					num = 288;
				}
				if (num == 286)
				{
					this.launch_csgo.TabIndex = 357;
					num = 287;
				}
				if (num == 284)
				{
					this.launch_csgo.ShadowDecoration.Parent = this.launch_csgo;
					num = 285;
				}
				if (num == 283)
				{
					this.launch_csgo.Name = "launch_csgo";
					num = 284;
				}
				if (num == 282)
				{
					this.launch_csgo.Location = new Point(95, 582);
					num = 283;
				}
				if (num == 281)
				{
					this.launch_csgo.ImageSize = new Size(52, 52);
					num = 282;
				}
				if (num == 280)
				{
					this.launch_csgo.Image = (Image)componentResourceManager.GetObject("launch_csgo.Image");
					num = 281;
				}
				if (num == 278)
				{
					this.launch_csgo.ForeColor = Color.White;
					num = 279;
				}
				if (num == 277)
				{
					this.launch_csgo.Font = new Font("Segoe UI", 9f);
					num = 278;
				}
				if (num == 276)
				{
					this.launch_csgo.FillColor = Color.Transparent;
					num = 277;
				}
				if (num == 275)
				{
					this.launch_csgo.DisabledState.Parent = this.launch_csgo;
					num = 276;
				}
				if (num == 274)
				{
					this.launch_csgo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 275;
				}
				if (num == 272)
				{
					this.launch_csgo.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 273;
				}
				if (num == 271)
				{
					this.launch_csgo.DisabledState.BorderColor = Color.DarkGray;
					num = 272;
				}
				if (num == 270)
				{
					this.launch_csgo.CustomImages.Parent = this.launch_csgo;
					num = 271;
				}
				if (num == 269)
				{
					this.launch_csgo.CheckedState.Parent = this.launch_csgo;
					num = 270;
				}
				if (num == 268)
				{
					this.launch_pubg.Click += this.launch_pubg_Click;
					num = 269;
				}
				if (num == 266)
				{
					this.launch_pubg.Size = new Size(52, 52);
					num = 267;
				}
				if (num == 265)
				{
					this.launch_pubg.ShadowDecoration.Parent = this.launch_pubg;
					num = 266;
				}
				if (num == 264)
				{
					this.launch_pubg.Name = "launch_pubg";
					num = 265;
				}
				if (num == 263)
				{
					this.launch_pubg.Location = new Point(269, 582);
					num = 264;
				}
				if (num == 262)
				{
					this.launch_pubg.ImageSize = new Size(50, 50);
					num = 263;
				}
				if (num == 260)
				{
					this.launch_pubg.HoverState.Parent = this.launch_pubg;
					num = 261;
				}
				if (num == 259)
				{
					this.launch_pubg.ForeColor = Color.White;
					num = 260;
				}
				if (num == 258)
				{
					this.launch_pubg.Font = new Font("Segoe UI", 9f);
					num = 259;
				}
				if (num == 257)
				{
					this.launch_pubg.FillColor = Color.Transparent;
					num = 258;
				}
				if (num == 255)
				{
					this.launch_pubg.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 256;
				}
				if (num == 254)
				{
					this.launch_pubg.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 255;
				}
				if (num == 253)
				{
					this.launch_pubg.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 254;
				}
				if (num == 252)
				{
					this.launch_pubg.DisabledState.BorderColor = Color.DarkGray;
					num = 253;
				}
				if (num == 251)
				{
					this.launch_pubg.CustomImages.Parent = this.launch_pubg;
					num = 252;
				}
				if (num == 249)
				{
					this.browse.Click += this.browse_Click;
					num = 250;
				}
				if (num == 248)
				{
					this.browse.Text = "Browse...";
					num = 249;
				}
				if (num == 247)
				{
					this.browse.TabIndex = 360;
					num = 248;
				}
				if (num == 246)
				{
					this.browse.Size = new Size(80, 28);
					num = 247;
				}
				if (num == 245)
				{
					this.browse.ShadowDecoration.Parent = this.browse;
					num = 246;
				}
				if (num == 243)
				{
					this.browse.Location = new Point(722, 192);
					num = 244;
				}
				if (num == 242)
				{
					this.browse.ImageSize = new Size(30, 30);
					num = 243;
				}
				if (num == 241)
				{
					this.browse.HoverState.Parent = this.browse;
					num = 242;
				}
				if (num == 240)
				{
					this.browse.ForeColor = Color.White;
					num = 241;
				}
				if (num == 239)
				{
					this.browse.Font = new Font("Segoe UI", 9f);
					num = 240;
				}
				if (num == 237)
				{
					this.browse.DisabledState.Parent = this.browse;
					num = 238;
				}
				if (num == 236)
				{
					this.browse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 237;
				}
				if (num == 235)
				{
					this.browse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 236;
				}
				if (num == 234)
				{
					this.browse.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 235;
				}
				if (num == 233)
				{
					this.browse.DisabledState.BorderColor = Color.DarkGray;
					num = 234;
				}
				if (num == 231)
				{
					this.browse.CheckedState.Parent = this.browse;
					num = 232;
				}
				if (num == 230)
				{
					this.game_location.TabIndex = 361;
					num = 231;
				}
				if (num == 229)
				{
					this.game_location.Size = new Size(522, 28);
					num = 230;
				}
				if (num == 228)
				{
					this.game_location.ShadowDecoration.Parent = this.game_location;
					num = 229;
				}
				if (num == 227)
				{
					this.game_location.SelectedText = "";
					num = 228;
				}
				if (num == 225)
				{
					this.game_location.PlaceholderText = "";
					num = 226;
				}
				if (num == 224)
				{
					this.game_location.PasswordChar = '\0';
					num = 225;
				}
				if (num == 223)
				{
					this.game_location.Name = "game_location";
					num = 224;
				}
				if (num == 222)
				{
					this.game_location.Location = new Point(194, 192);
					num = 223;
				}
				if (num == 220)
				{
					this.game_location.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 221;
				}
				if (num == 219)
				{
					this.game_location.ForeColor = Color.White;
					num = 220;
				}
				if (num == 218)
				{
					this.game_location.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 219;
				}
				if (num == 217)
				{
					this.game_location.FocusedState.Parent = this.game_location;
					num = 218;
				}
				if (num == 216)
				{
					this.game_location.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 217;
				}
				if (num == 214)
				{
					this.game_location.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 215;
				}
				if (num == 213)
				{
					this.game_location.DisabledState.Parent = this.game_location;
					num = 214;
				}
				if (num == 212)
				{
					this.game_location.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 213;
				}
				if (num == 211)
				{
					this.game_location.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 212;
				}
				if (num == 210)
				{
					this.game_location.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 211;
				}
				if (num == 208)
				{
					this.game_location.Cursor = Cursors.IBeam;
					num = 209;
				}
				if (num == 207)
				{
					this.game_location.BackColor = Color.Transparent;
					num = 208;
				}
				if (num == 206)
				{
					this.admin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 207;
				}
				if (num == 205)
				{
					this.admin.UncheckedState.BorderThickness = 0;
					num = 206;
				}
				if (num == 204)
				{
					this.admin.UncheckedState.BorderRadius = 0;
					num = 205;
				}
				if (num == 202)
				{
					this.admin.Text = "Admin Privilege";
					num = 203;
				}
				if (num == 201)
				{
					this.admin.TabIndex = 362;
					num = 202;
				}
				if (num == 200)
				{
					this.admin.Size = new Size(137, 28);
					num = 201;
				}
				if (num == 199)
				{
					this.admin.Name = "admin";
					num = 200;
				}
				if (num == 198)
				{
					this.admin.Location = new Point(194, 226);
					num = 199;
				}
				if (num == 196)
				{
					this.admin.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 197;
				}
				if (num == 195)
				{
					this.admin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 196;
				}
				if (num == 194)
				{
					this.admin.CheckedState.BorderThickness = 0;
					num = 195;
				}
				if (num == 193)
				{
					this.admin.CheckedState.BorderRadius = 0;
					num = 194;
				}
				if (num == 191)
				{
					this.admin.AutoSize = true;
					num = 192;
				}
				if (num == 190)
				{
					this.label3.Text = "• Browse your game";
					num = 191;
				}
				if (num == 189)
				{
					this.label3.TabIndex = 363;
					num = 190;
				}
				if (num == 188)
				{
					this.label3.Size = new Size(184, 30);
					num = 189;
				}
				if (num == 187)
				{
					this.label3.Name = "label3";
					num = 188;
				}
				if (num == 185)
				{
					this.label3.ForeColor = Color.White;
					num = 186;
				}
				if (num == 184)
				{
					this.label3.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 185;
				}
				if (num == 183)
				{
					this.label3.AutoSize = true;
					num = 184;
				}
				if (num == 182)
				{
					this.Boost.Click += this.Boost_Click;
					num = 183;
				}
				if (num == 181)
				{
					this.Boost.Text = "Boost";
					num = 182;
				}
				if (num == 179)
				{
					this.Boost.Size = new Size(100, 38);
					num = 180;
				}
				if (num == 178)
				{
					this.Boost.ShadowDecoration.Parent = this.Boost;
					num = 179;
				}
				if (num == 177)
				{
					this.Boost.Name = "Boost";
					num = 178;
				}
				if (num == 176)
				{
					this.Boost.Location = new Point(414, 261);
					num = 177;
				}
				if (num == 175)
				{
					this.Boost.ImageSize = new Size(30, 30);
					num = 176;
				}
				if (num == 173)
				{
					this.Boost.ForeColor = Color.White;
					num = 174;
				}
				if (num == 172)
				{
					this.Boost.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 173;
				}
				if (num == 171)
				{
					this.Boost.FillColor = Color.FromArgb(38, 38, 38);
					num = 172;
				}
				if (num == 170)
				{
					this.Boost.DisabledState.Parent = this.Boost;
					num = 171;
				}
				if (num == 169)
				{
					this.Boost.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 170;
				}
				if (num == 167)
				{
					this.Boost.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 168;
				}
				if (num == 166)
				{
					this.Boost.DisabledState.BorderColor = Color.DarkGray;
					num = 167;
				}
				if (num == 165)
				{
					this.Boost.CustomImages.Parent = this.Boost;
					num = 166;
				}
				if (num == 164)
				{
					this.Boost.CheckedState.Parent = this.Boost;
					num = 165;
				}
				if (num == 163)
				{
					this.label4.Text = "• Manual Mode";
					num = 164;
				}
				if (num == 161)
				{
					this.label4.Size = new Size(149, 30);
					num = 162;
				}
				if (num == 160)
				{
					this.label4.Name = "label4";
					num = 161;
				}
				if (num == 159)
				{
					this.label4.Location = new Point(22, 321);
					num = 160;
				}
				if (num == 158)
				{
					this.label4.ForeColor = Color.White;
					num = 159;
				}
				if (num == 156)
				{
					this.label4.AutoSize = true;
					num = 157;
				}
				if (num == 155)
				{
					this.enable.Click += this.enable_Click;
					num = 156;
				}
				if (num == 154)
				{
					this.enable.Text = "Enable";
					num = 155;
				}
				if (num == 153)
				{
					this.enable.TabIndex = 366;
					num = 154;
				}
				if (num == 152)
				{
					this.enable.Size = new Size(100, 38);
					num = 153;
				}
				if (num == 150)
				{
					this.enable.Name = "enable";
					num = 151;
				}
				if (num == 149)
				{
					this.enable.Location = new Point(47, 373);
					num = 150;
				}
				if (num == 148)
				{
					this.enable.ImageSize = new Size(30, 30);
					num = 149;
				}
				if (num == 147)
				{
					this.enable.HoverState.Parent = this.enable;
					num = 148;
				}
				if (num == 146)
				{
					this.enable.ForeColor = Color.White;
					num = 147;
				}
				if (num == 144)
				{
					this.enable.FillColor = Color.FromArgb(38, 38, 38);
					num = 145;
				}
				if (num == 143)
				{
					this.enable.DisabledState.Parent = this.enable;
					num = 144;
				}
				if (num == 142)
				{
					this.enable.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 143;
				}
				if (num == 141)
				{
					this.enable.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 142;
				}
				if (num == 140)
				{
					this.enable.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 141;
				}
				if (num == 138)
				{
					this.enable.CustomImages.Parent = this.enable;
					num = 139;
				}
				if (num == 137)
				{
					this.enable.CheckedState.Parent = this.enable;
					num = 138;
				}
				if (num == 136)
				{
					this.disable.Click += this.disable_Click;
					num = 137;
				}
				if (num == 135)
				{
					this.disable.Text = "Disable";
					num = 136;
				}
				if (num == 134)
				{
					this.disable.TabIndex = 367;
					num = 135;
				}
				if (num == 132)
				{
					this.disable.ShadowDecoration.Parent = this.disable;
					num = 133;
				}
				if (num == 131)
				{
					this.disable.Name = "disable";
					num = 132;
				}
				if (num == 130)
				{
					this.disable.Location = new Point(211, 373);
					num = 131;
				}
				if (num == 129)
				{
					this.disable.ImageSize = new Size(30, 30);
					num = 130;
				}
				if (num == 127)
				{
					this.disable.ForeColor = Color.White;
					num = 128;
				}
				if (num == 126)
				{
					this.disable.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 127;
				}
				if (num == 125)
				{
					this.disable.FillColor = Color.FromArgb(38, 38, 38);
					num = 126;
				}
				if (num == 124)
				{
					this.disable.DisabledState.Parent = this.disable;
					num = 125;
				}
				if (num == 123)
				{
					this.disable.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 124;
				}
				if (num == 121)
				{
					this.disable.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 122;
				}
				if (num == 120)
				{
					this.disable.DisabledState.BorderColor = Color.DarkGray;
					num = 121;
				}
				if (num == 119)
				{
					this.disable.CustomImages.Parent = this.disable;
					num = 120;
				}
				if (num == 118)
				{
					this.disable.CheckedState.Parent = this.disable;
					num = 119;
				}
				if (num == 117)
				{
					this.cb_standbylist.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 118;
				}
				if (num == 115)
				{
					this.cb_standbylist.UncheckedState.BorderRadius = 0;
					num = 116;
				}
				if (num == 114)
				{
					this.cb_standbylist.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 115;
				}
				if (num == 113)
				{
					this.cb_standbylist.Text = "Clear Standby List";
					num = 114;
				}
				if (num == 112)
				{
					this.cb_standbylist.TabIndex = 323;
					num = 113;
				}
				if (num == 111)
				{
					this.cb_standbylist.Size = new Size(139, 24);
					num = 112;
				}
				if (num == 109)
				{
					this.cb_standbylist.Location = new Point(995, 673);
					num = 110;
				}
				if (num == 108)
				{
					this.cb_standbylist.ForeColor = Color.White;
					num = 109;
				}
				if (num == 107)
				{
					this.cb_standbylist.Font = new Font("Josefin Sans", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 108;
				}
				if (num == 106)
				{
					this.cb_standbylist.CheckState = CheckState.Checked;
					num = 107;
				}
				if (num == 105)
				{
					this.cb_standbylist.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 106;
				}
				if (num == 103)
				{
					this.cb_standbylist.CheckedState.BorderRadius = 0;
					num = 104;
				}
				if (num == 102)
				{
					this.cb_standbylist.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 103;
				}
				if (num == 101)
				{
					this.cb_standbylist.Checked = true;
					num = 102;
				}
				if (num == 100)
				{
					this.cb_standbylist.AutoSize = true;
					num = 101;
				}
				if (num == 99)
				{
					this.cb_modifiedlist.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 100;
				}
				if (num == 97)
				{
					this.cb_modifiedlist.UncheckedState.BorderRadius = 0;
					num = 98;
				}
				if (num == 96)
				{
					this.cb_modifiedlist.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 97;
				}
				if (num == 95)
				{
					this.cb_modifiedlist.Text = "Clear Modified List";
					num = 96;
				}
				if (num == 94)
				{
					this.cb_modifiedlist.TabIndex = 324;
					num = 95;
				}
				if (num == 92)
				{
					this.cb_modifiedlist.Name = "cb_modifiedlist";
					num = 93;
				}
				if (num == 91)
				{
					this.cb_modifiedlist.Location = new Point(995, 733);
					num = 92;
				}
				if (num == 90)
				{
					this.cb_modifiedlist.ForeColor = Color.White;
					num = 91;
				}
				if (num == 89)
				{
					this.cb_modifiedlist.Font = new Font("Josefin Sans", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 90;
				}
				if (num == 88)
				{
					this.cb_modifiedlist.CheckState = CheckState.Checked;
					num = 89;
				}
				if (num == 86)
				{
					this.cb_modifiedlist.CheckedState.BorderThickness = 0;
					num = 87;
				}
				if (num == 85)
				{
					this.cb_modifiedlist.CheckedState.BorderRadius = 0;
					num = 86;
				}
				if (num == 84)
				{
					this.cb_modifiedlist.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 85;
				}
				if (num == 83)
				{
					this.cb_modifiedlist.Checked = true;
					num = 84;
				}
				if (num == 82)
				{
					this.cb_modifiedlist.AutoSize = true;
					num = 83;
				}
				if (num == 80)
				{
					this.cb_workingset.UncheckedState.BorderThickness = 0;
					num = 81;
				}
				if (num == 79)
				{
					this.cb_workingset.UncheckedState.BorderRadius = 0;
					num = 80;
				}
				if (num == 78)
				{
					this.cb_workingset.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 79;
				}
				if (num == 77)
				{
					this.cb_workingset.Text = "Clear Working Set";
					num = 78;
				}
				if (num == 76)
				{
					this.cb_workingset.TabIndex = 325;
					num = 77;
				}
				if (num == 74)
				{
					this.cb_workingset.Name = "cb_workingset";
					num = 75;
				}
				if (num == 73)
				{
					this.cb_workingset.Location = new Point(995, 763);
					num = 74;
				}
				if (num == 72)
				{
					this.cb_workingset.ForeColor = Color.White;
					num = 73;
				}
				if (num == 71)
				{
					this.cb_workingset.Font = new Font("Josefin Sans", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 72;
				}
				if (num == 70)
				{
					this.cb_workingset.CheckState = CheckState.Checked;
					num = 71;
				}
				if (num == 68)
				{
					this.cb_workingset.CheckedState.BorderThickness = 0;
					num = 69;
				}
				if (num == 67)
				{
					this.cb_workingset.CheckedState.BorderRadius = 0;
					num = 68;
				}
				if (num == 66)
				{
					this.cb_workingset.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 67;
				}
				if (num == 65)
				{
					this.cb_workingset.Checked = true;
					num = 66;
				}
				if (num == 63)
				{
					this.cb_lowpriostandbylist.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 64;
				}
				if (num == 62)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderThickness = 0;
					num = 63;
				}
				if (num == 61)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderRadius = 0;
					num = 62;
				}
				if (num == 60)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 61;
				}
				if (num == 59)
				{
					this.cb_lowpriostandbylist.Text = "Clear Standby List (Low Priority)";
					num = 60;
				}
				if (num == 57)
				{
					this.cb_lowpriostandbylist.Size = new Size(223, 24);
					num = 58;
				}
				if (num == 56)
				{
					this.cb_lowpriostandbylist.Name = "cb_lowpriostandbylist";
					num = 57;
				}
				if (num == 55)
				{
					this.cb_lowpriostandbylist.Location = new Point(995, 703);
					num = 56;
				}
				if (num == 54)
				{
					this.cb_lowpriostandbylist.ForeColor = Color.White;
					num = 55;
				}
				if (num == 53)
				{
					this.cb_lowpriostandbylist.Font = new Font("Josefin Sans", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 54;
				}
				if (num == 51)
				{
					this.cb_lowpriostandbylist.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 52;
				}
				if (num == 50)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderThickness = 0;
					num = 51;
				}
				if (num == 49)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderRadius = 0;
					num = 50;
				}
				if (num == 48)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 49;
				}
				if (num == 47)
				{
					this.cb_lowpriostandbylist.Checked = true;
					num = 48;
				}
				if (num == 45)
				{
					this.openFileDialog1.FileName = "openFileDialog1";
					num = 46;
				}
				if (num == 44)
				{
					this.label266.Text = "A smart and intelligent game booster that optimizes your Windows to improve game performance when you use it and automatically disables itself when\r\nyou've\u00a0finished gaming.";
					num = 45;
				}
				if (num == 43)
				{
					this.label266.TabIndex = 94;
					num = 44;
				}
				if (num == 42)
				{
					this.label266.Size = new Size(847, 38);
					num = 43;
				}
				if (num == 41)
				{
					this.label266.Name = "label266";
					num = 42;
				}
				if (num == 39)
				{
					this.label266.ForeColor = Color.Silver;
					num = 40;
				}
				if (num == 38)
				{
					this.label266.Font = new Font("Josefin Sans", 9f);
					num = 39;
				}
				if (num == 37)
				{
					this.label266.AutoSize = true;
					num = 38;
				}
				if (num == 36)
				{
					this.label1.Text = "Game Booster";
					num = 37;
				}
				if (num == 35)
				{
					this.label1.TabIndex = 6;
					num = 36;
				}
				if (num == 33)
				{
					this.label1.Name = "label1";
					num = 34;
				}
				if (num == 32)
				{
					this.label1.Location = new Point(18, 0);
					num = 33;
				}
				if (num == 31)
				{
					this.label1.ForeColor = Color.White;
					num = 32;
				}
				if (num == 30)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 31;
				}
				if (num == 28)
				{
					base.SuspendLayout();
					num = 29;
				}
				if (num == 27)
				{
					this.launch_genshin = new SiticoneButton();
					num = 28;
				}
				if (num == 26)
				{
					this.label7 = new Label();
					num = 27;
				}
				if (num == 25)
				{
					this.label6 = new Label();
					num = 26;
				}
				if (num == 24)
				{
					this.launch_apex = new SiticoneButton();
					num = 25;
				}
				if (num == 22)
				{
					this.label5 = new Label();
					num = 23;
				}
				if (num == 21)
				{
					this.label2 = new Label();
					num = 22;
				}
				if (num == 20)
				{
					this.launch_val = new SiticoneButton();
					num = 21;
				}
				if (num == 19)
				{
					this.launch_LoL = new SiticoneButton();
					num = 20;
				}
				if (num == 18)
				{
					this.launch_csgo = new SiticoneButton();
					num = 19;
				}
				if (num == 16)
				{
					this.browse = new SiticoneButton();
					num = 17;
				}
				if (num == 15)
				{
					this.game_location = new SiticoneTextBox();
					num = 16;
				}
				if (num == 14)
				{
					this.admin = new SiticoneCheckBox();
					num = 15;
				}
				if (num == 13)
				{
					this.label3 = new Label();
					num = 14;
				}
				if (num == 12)
				{
					this.Boost = new SiticoneButton();
					num = 13;
				}
				if (num == 10)
				{
					this.enable = new SiticoneButton();
					num = 11;
				}
				if (num == 9)
				{
					this.disable = new SiticoneButton();
					num = 10;
				}
				if (num == 8)
				{
					this.cb_standbylist = new SiticoneCheckBox();
					num = 9;
				}
				if (num == 7)
				{
					this.cb_modifiedlist = new SiticoneCheckBox();
					num = 8;
				}
				if (num == 6)
				{
					this.cb_workingset = new SiticoneCheckBox();
					num = 7;
				}
				if (num == 4)
				{
					this.openFileDialog1 = new OpenFileDialog();
					num = 5;
				}
				if (num == 3)
				{
					this.label266 = new Label();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(GameBooster));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 448);
		}

		// Token: 0x040004A3 RID: 1187
		private static GameBooster _instace;

		// Token: 0x040004A4 RID: 1188
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040004A5 RID: 1189
		private string riot_client;

		// Token: 0x040004A6 RID: 1190
		private string steam_client;

		// Token: 0x040004A7 RID: 1191
		private string fortnite;

		// Token: 0x040004A8 RID: 1192
		private string genshin_launcher;

		// Token: 0x040004A9 RID: 1193
		private IContainer components = null;

		// Token: 0x040004AA RID: 1194
		private Label label1;

		// Token: 0x040004AB RID: 1195
		private Label label266;

		// Token: 0x040004AC RID: 1196
		private OpenFileDialog openFileDialog1;

		// Token: 0x040004AD RID: 1197
		private SiticoneCheckBox cb_lowpriostandbylist;

		// Token: 0x040004AE RID: 1198
		private SiticoneCheckBox cb_workingset;

		// Token: 0x040004AF RID: 1199
		private SiticoneCheckBox cb_modifiedlist;

		// Token: 0x040004B0 RID: 1200
		private SiticoneCheckBox cb_standbylist;

		// Token: 0x040004B1 RID: 1201
		private SiticoneButton disable;

		// Token: 0x040004B2 RID: 1202
		private SiticoneButton enable;

		// Token: 0x040004B3 RID: 1203
		private Label label4;

		// Token: 0x040004B4 RID: 1204
		private SiticoneButton Boost;

		// Token: 0x040004B5 RID: 1205
		private Label label3;

		// Token: 0x040004B6 RID: 1206
		private SiticoneCheckBox admin;

		// Token: 0x040004B7 RID: 1207
		private SiticoneTextBox game_location;

		// Token: 0x040004B8 RID: 1208
		private SiticoneButton browse;

		// Token: 0x040004B9 RID: 1209
		private SiticoneButton launch_pubg;

		// Token: 0x040004BA RID: 1210
		private SiticoneButton launch_csgo;

		// Token: 0x040004BB RID: 1211
		private SiticoneButton launch_LoL;

		// Token: 0x040004BC RID: 1212
		private SiticoneButton launch_val;

		// Token: 0x040004BD RID: 1213
		private Label label2;

		// Token: 0x040004BE RID: 1214
		private Label label5;

		// Token: 0x040004BF RID: 1215
		private SiticoneButton launch_fn;

		// Token: 0x040004C0 RID: 1216
		private SiticoneButton launch_apex;

		// Token: 0x040004C1 RID: 1217
		private Label label6;

		// Token: 0x040004C2 RID: 1218
		private Label label7;

		// Token: 0x040004C3 RID: 1219
		private SiticoneButton launch_genshin;
	}
}
