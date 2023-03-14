using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000067 RID: 103
	public class one_click_opt : UserControl
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0015D90C File Offset: 0x0015BB0C
		public static one_click_opt Instance
		{
			get
			{
				if (one_click_opt._instace == null)
				{
					one_click_opt._instace = new one_click_opt();
				}
				return one_click_opt._instace;
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0015D934 File Offset: 0x0015BB34
		public one_click_opt()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0015D98C File Offset: 0x0015BB8C
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

		// Token: 0x06000931 RID: 2353 RVA: 0x0015DBC8 File Offset: 0x0015BDC8
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

		// Token: 0x06000932 RID: 2354 RVA: 0x0015DC40 File Offset: 0x0015BE40
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

		// Token: 0x06000933 RID: 2355 RVA: 0x0015DCA4 File Offset: 0x0015BEA4
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
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0015DD70 File Offset: 0x0015BF70
		private void AccentColor()
		{
			int num = 0;
			Color accentColor;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = base.Controls.OfType<CheckBox>().GetEnumerator();
					num = 3;
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
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0015DE64 File Offset: 0x0015C064
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
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0015DF30 File Offset: 0x0015C130
		private void next_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Controls.Add(Debloat.Instance);
					num = 2;
				}
				if (num == 2)
				{
					Debloat.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 3)
				{
					Debloat.Instance.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					Debloat.Instance.Show();
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0015DFDC File Offset: 0x0015C1DC
		private void one_click_opt_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 2;
				}
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Disable_Services");
					num = 3;
				}
				bool flag;
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num != 4)
				{
					goto IL_4F;
				}
				if (flag)
				{
					num = 5;
					goto IL_4F;
				}
				goto IL_7C;
				IL_8F:
				object value2;
				bool flag2;
				if (num == 7)
				{
					flag2 = value2 != null;
					num = 8;
				}
				if (num == 9)
				{
					this.Tasks.CheckState = CheckState.Checked;
					num = 10;
				}
				if (num == 10)
				{
					goto IL_47E;
				}
				IL_491:
				object value3;
				bool flag3;
				if (num == 11)
				{
					flag3 = value3 != null;
					num = 12;
				}
				if (num != 12)
				{
					goto IL_F0;
				}
				if (flag3)
				{
					num = 13;
					goto IL_F0;
				}
				goto IL_11D;
				IL_130:
				object value4;
				bool flag4;
				if (num == 15)
				{
					flag4 = value4 != null;
					num = 16;
				}
				if (num != 16)
				{
					goto IL_15B;
				}
				if (flag4)
				{
					num = 17;
					goto IL_15B;
				}
				goto IL_165;
				IL_178:
				object value5;
				bool flag5;
				if (num == 19)
				{
					flag5 = value5 != null;
					num = 20;
				}
				if (num != 20)
				{
					goto IL_1A3;
				}
				if (flag5)
				{
					num = 21;
					goto IL_1A3;
				}
				goto IL_1D0;
				IL_1E3:
				object value6;
				bool flag6;
				if (num == 23)
				{
					flag6 = value6 != null;
					num = 24;
				}
				if (num != 24)
				{
					goto IL_211;
				}
				if (flag6)
				{
					num = 25;
					goto IL_211;
				}
				goto IL_43A;
				IL_44D:
				if (num == 17)
				{
					this.Disable.CheckState = CheckState.Checked;
					num = 18;
				}
				if (num == 8)
				{
					if (!flag2)
					{
						goto IL_47E;
					}
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 46)
				{
					break;
				}
				continue;
				IL_211:
				if (num == 25)
				{
					this.chrome.CheckState = CheckState.Checked;
					num = 26;
				}
				object value7;
				bool flag7;
				if (num == 27)
				{
					flag7 = value7 != null;
					num = 28;
				}
				if (num != 28)
				{
					goto IL_25F;
				}
				if (flag7)
				{
					num = 29;
					goto IL_25F;
				}
				goto IL_28C;
				IL_29F:
				object value8;
				bool flag8;
				if (num == 31)
				{
					flag8 = value8 != null;
					num = 32;
				}
				if (num != 32)
				{
					goto IL_2CA;
				}
				if (flag8)
				{
					num = 33;
					goto IL_2CA;
				}
				goto IL_2F7;
				IL_30A:
				if (num != 36)
				{
					goto IL_31E;
				}
				bool flag9;
				if (flag9)
				{
					num = 37;
					goto IL_31E;
				}
				goto IL_34B;
				IL_35E:
				object value9;
				bool flag10;
				if (num == 39)
				{
					flag10 = value9 != null;
					num = 40;
				}
				if (num != 40)
				{
					goto IL_389;
				}
				if (flag10)
				{
					num = 41;
					goto IL_389;
				}
				goto IL_3B6;
				IL_3C8:
				if (num == 44)
				{
					bool flag11;
					if (!flag11)
					{
						break;
					}
					num = 45;
				}
				if (num == 45)
				{
					this.office_telemetry.CheckState = CheckState.Checked;
					num = 46;
				}
				if (num == 43)
				{
					bool flag11 = value9 != null;
					num = 44;
				}
				object value10;
				if (num == 35)
				{
					flag9 = value10 != null;
					num = 36;
				}
				if (num == 26)
				{
					goto IL_43A;
				}
				goto IL_44D;
				IL_389:
				if (num == 41)
				{
					this.nvidia.CheckState = CheckState.Checked;
					num = 42;
				}
				if (num != 42)
				{
					goto IL_3C8;
				}
				IL_3B6:
				registryKey.GetValue("DisableOfficeTelemtry");
				num = 43;
				goto IL_3C8;
				IL_31E:
				if (num == 37)
				{
					this.steam.CheckState = CheckState.Checked;
					num = 38;
				}
				if (num != 38)
				{
					goto IL_35E;
				}
				IL_34B:
				value9 = registryKey.GetValue("Nvidia_Telemtery");
				num = 39;
				goto IL_35E;
				IL_2CA:
				if (num == 33)
				{
					this.brave.CheckState = CheckState.Checked;
					num = 34;
				}
				if (num != 34)
				{
					goto IL_30A;
				}
				IL_2F7:
				value10 = registryKey.GetValue("Optimize_Steam");
				num = 35;
				goto IL_30A;
				IL_25F:
				if (num == 29)
				{
					this.firefox.CheckState = CheckState.Checked;
					num = 30;
				}
				if (num != 30)
				{
					goto IL_29F;
				}
				IL_28C:
				value8 = registryKey.GetValue("Optimize_Brave");
				num = 31;
				goto IL_29F;
				IL_43A:
				value7 = registryKey.GetValue("Optimize_Firefox");
				num = 27;
				goto IL_44D;
				IL_1A3:
				if (num == 21)
				{
					this.discord.CheckState = CheckState.Checked;
					num = 22;
				}
				if (num != 22)
				{
					goto IL_1E3;
				}
				IL_1D0:
				value6 = registryKey.GetValue("Optimize_Chrome");
				num = 23;
				goto IL_1E3;
				IL_15B:
				if (num != 18)
				{
					goto IL_178;
				}
				IL_165:
				value5 = registryKey.GetValue("Optimize_Discord");
				num = 19;
				goto IL_178;
				IL_F0:
				if (num == 13)
				{
					this.Pause.CheckState = CheckState.Checked;
					num = 14;
				}
				if (num != 14)
				{
					goto IL_130;
				}
				IL_11D:
				value4 = registryKey.GetValue("Disable_Updates");
				num = 15;
				goto IL_130;
				IL_47E:
				value3 = registryKey.GetValue("Pause_Updates");
				num = 11;
				goto IL_491;
				IL_4F:
				if (num == 5)
				{
					this.useless_services.CheckState = CheckState.Checked;
					num = 6;
				}
				if (num != 6)
				{
					goto IL_8F;
				}
				IL_7C:
				value2 = registryKey.GetValue("Disable_Tasks");
				num = 7;
				goto IL_8F;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0015E4E4 File Offset: 0x0015C6E4
		private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.useless_services.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_4FF;
				IL_A85:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 75)
				{
					break;
				}
				continue;
				IL_523:
				if (num == 44)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 3, RegistryValueKind.DWord);
					num = 45;
				}
				if (num == 45)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\OneSyncSvc", "Start", 3, RegistryValueKind.DWord);
					num = 46;
				}
				if (num == 46)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MessagingService", "Start", 3, RegistryValueKind.DWord);
					num = 47;
				}
				if (num == 47)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wercplsupport", "Start", 3, RegistryValueKind.DWord);
					num = 48;
				}
				if (num == 48)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PcaSvc", "Start", 3, RegistryValueKind.DWord);
					num = 49;
				}
				if (num == 49)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", 3, RegistryValueKind.DWord);
					num = 50;
				}
				if (num == 50)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RetailDemo", "Start", 3, RegistryValueKind.DWord);
					num = 51;
				}
				if (num == 51)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", 3, RegistryValueKind.DWord);
					num = 52;
				}
				if (num == 53)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TermService", "Start", 3, RegistryValueKind.DWord);
					num = 54;
				}
				if (num == 54)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\UmRdpService", "Start", 3, RegistryValueKind.DWord);
					num = 55;
				}
				if (num == 55)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SessionEnv", "Start", 3, RegistryValueKind.DWord);
					num = 56;
				}
				if (num == 56)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TroubleshootingSvc", "Start", 3, RegistryValueKind.DWord);
					num = 57;
				}
				if (num == 57)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MapsBroker", "Start", 3, RegistryValueKind.DWord);
					num = 58;
				}
				if (num == 58)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lfsvc", "Start", 3, RegistryValueKind.DWord);
					num = 59;
				}
				if (num == 59)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 3, RegistryValueKind.DWord);
					num = 60;
				}
				if (num == 60)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Themes", "Start", 3, RegistryValueKind.DWord);
					num = 61;
				}
				ProcessStartInfo processStartInfo;
				if (num == 62)
				{
					processStartInfo = new ProcessStartInfo();
					num = 63;
				}
				if (num == 63)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 64;
				}
				if (num == 64)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 65;
				}
				if (num == 65)
				{
					processStartInfo.Arguments = "/C sc config DPS start= demand";
					num = 66;
				}
				if (num == 66)
				{
					processStartInfo.Verb = "runas";
					num = 67;
				}
				Process process;
				if (num == 67)
				{
					process.StartInfo = processStartInfo;
					num = 68;
				}
				if (num == 68)
				{
					process.Start();
					num = 69;
				}
				if (num == 69)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WSearch", "Start", 3, RegistryValueKind.DWord);
					num = 70;
				}
				RegistryKey registryKey;
				bool flag;
				if (num == 71)
				{
					flag = registryKey != null;
					num = 72;
				}
				if (num == 72)
				{
					if (!flag)
					{
						break;
					}
					num = 73;
				}
				if (num == 73)
				{
					registryKey.DeleteValue("Disable_Services", false);
					num = 74;
				}
				if (num == 74)
				{
					registryKey.Close();
					num = 75;
				}
				if (num == 70)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 71;
				}
				if (num == 61)
				{
					process = new Process();
					num = 62;
				}
				if (num == 52)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\shpamsvc", "Start", 3, RegistryValueKind.DWord);
					num = 53;
				}
				if (num == 43)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", 3, RegistryValueKind.DWord);
					num = 44;
				}
				Process process2;
				if (num == 35)
				{
					process2.Start();
					num = 36;
				}
				if (num == 26)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Themes", "Start", 4, RegistryValueKind.DWord);
					num = 27;
				}
				if (num == 17)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", 4, RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 8)
				{
					goto IL_A61;
				}
				goto IL_A85;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Disable_Services");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_A61;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", 4, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 4, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\OneSyncSvc", "Start", 4, RegistryValueKind.DWord);
					num = 12;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MessagingService", "Start", 4, RegistryValueKind.DWord);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wercplsupport", "Start", 4, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PcaSvc", "Start", 4, RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", 4, RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RetailDemo", "Start", 4, RegistryValueKind.DWord);
					num = 17;
				}
				if (num == 18)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\shpamsvc", "Start", 4, RegistryValueKind.DWord);
					num = 19;
				}
				if (num == 19)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TermService", "Start", 4, RegistryValueKind.DWord);
					num = 20;
				}
				if (num == 20)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\UmRdpService", "Start", 4, RegistryValueKind.DWord);
					num = 21;
				}
				if (num == 21)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SessionEnv", "Start", 4, RegistryValueKind.DWord);
					num = 22;
				}
				if (num == 22)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TroubleshootingSvc", "Start", 4, RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 23)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MapsBroker", "Start", 4, RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lfsvc", "Start", 4, RegistryValueKind.DWord);
					num = 25;
				}
				if (num == 25)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 4, RegistryValueKind.DWord);
					num = 26;
				}
				if (num == 27)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WSearch", "Start", 4, RegistryValueKind.DWord);
					num = 28;
				}
				if (num == 28)
				{
					process2 = new Process();
					num = 29;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 29)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 30;
				}
				if (num == 30)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 31;
				}
				if (num == 31)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 32;
				}
				if (num == 32)
				{
					processStartInfo2.Arguments = "/C sc config DPS start= disabled";
					num = 33;
				}
				if (num == 33)
				{
					processStartInfo2.Verb = "runas";
					num = 34;
				}
				if (num == 34)
				{
					process2.StartInfo = processStartInfo2;
					num = 35;
				}
				RegistryKey registryKey3;
				if (num == 36)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 37;
				}
				bool flag3;
				if (num == 37)
				{
					flag3 = registryKey3 != null;
					num = 38;
				}
				if (num == 38)
				{
					if (!flag3)
					{
						break;
					}
					num = 39;
				}
				if (num == 39)
				{
					registryKey3.SetValue("Disable_Services", 1);
					num = 40;
				}
				if (num == 40)
				{
					registryKey3.Close();
					num = 41;
				}
				if (num == 41)
				{
					break;
				}
				if (num == 42)
				{
					goto IL_4FF;
				}
				goto IL_523;
				IL_A61:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", 4, RegistryValueKind.DWord);
				num = 9;
				goto IL_A85;
				IL_4FF:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", 3, RegistryValueKind.DWord);
				num = 43;
				goto IL_523;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0015EFBC File Offset: 0x0015D1BC
		private void Tasks_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.Tasks.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_13A;
				IL_1DD:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					break;
				}
				continue;
				IL_151:
				RegistryKey registryKey;
				bool flag;
				if (num == 16)
				{
					flag = registryKey != null;
					num = 17;
				}
				if (num == 18)
				{
					registryKey.DeleteValue("Disable_Tasks", false);
					num = 19;
				}
				if (num == 19)
				{
					registryKey.Close();
					num = 20;
				}
				if (num == 17)
				{
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 8)
				{
					goto IL_1BE;
				}
				goto IL_1DD;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Disable_Tasks");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_1BE;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				RegistryKey registryKey3;
				if (num == 9)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 10;
				}
				bool flag3;
				if (num == 10)
				{
					flag3 = registryKey3 != null;
					num = 11;
				}
				if (num == 11)
				{
					if (!flag3)
					{
						break;
					}
					num = 12;
				}
				if (num == 12)
				{
					registryKey3.SetValue("Disable_Tasks", 1);
					num = 13;
				}
				if (num == 13)
				{
					registryKey3.Close();
					num = 14;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_13A;
				}
				goto IL_151;
				IL_1BE:
				base.BeginInvoke(new Action(delegate
				{
					int num2 = 0;
					Error error;
					do
					{
						if (num2 == 3)
						{
							error = new Error();
							num2 = 4;
						}
						if (num2 == 2)
						{
							bool flag4;
							if (!flag4)
							{
								goto IL_77;
							}
							num2 = 3;
						}
						if (num2 == 1)
						{
							bool flag4 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081166327118561380/schd.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\schd.bat");
							num2 = 2;
						}
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 4);
					try
					{
						error.ShowDialog(this);
					}
					finally
					{
						if (error != null)
						{
							((IDisposable)error).Dispose();
						}
					}
					return;
					IL_77:
					Process process = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Bin\\schd.bat");
					process.WaitForExit();
					File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\schd.bat");
				}));
				num = 9;
				goto IL_1DD;
				IL_13A:
				registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 16;
				goto IL_151;
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0015F1EC File Offset: 0x0015D3EC
		private void Pause_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.Pause.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_401;
				IL_68B:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 50)
				{
					break;
				}
				continue;
				IL_425:
				if (num == 34)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UpdatePolicy\\Settings", "PausedQualityStatus", 0, RegistryValueKind.DWord);
					num = 35;
				}
				RegistryKey registryKey;
				bool flag;
				if (num == 36)
				{
					flag = registryKey != null;
					num = 37;
				}
				if (num != 37)
				{
					goto IL_481;
				}
				if (flag)
				{
					num = 38;
					goto IL_481;
				}
				goto IL_547;
				IL_55E:
				RegistryKey registryKey2;
				bool flag2;
				if (num == 46)
				{
					flag2 = registryKey2 != null;
					num = 47;
				}
				if (num == 47)
				{
					if (!flag2)
					{
						break;
					}
					num = 48;
				}
				if (num == 48)
				{
					registryKey2.DeleteValue("Pause_Updates", false);
					num = 49;
				}
				if (num == 49)
				{
					registryKey2.Close();
					num = 50;
				}
				if (num == 43)
				{
					registryKey.DeleteValue("PauseQualityUpdatesEndTime", false);
					num = 44;
				}
				if (num == 35)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings");
					num = 36;
				}
				if (num == 26)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PauseQualityUpdatesEndTime", "2069-06-09T10:38:56Z", RegistryValueKind.String);
					num = 27;
				}
				if (num == 17)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "FlightCommitted", 0, RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 8)
				{
					goto IL_667;
				}
				goto IL_68B;
				IL_481:
				if (num == 38)
				{
					registryKey.DeleteValue("PendingRebootStartTime", false);
					num = 39;
				}
				if (num == 39)
				{
					registryKey.DeleteValue("PauseFeatureUpdatesStartTime", false);
					num = 40;
				}
				if (num == 40)
				{
					registryKey.DeleteValue("PauseQualityUpdatesStartTime", false);
					num = 41;
				}
				if (num == 41)
				{
					registryKey.DeleteValue("PauseUpdatesExpiryTime", false);
					num = 42;
				}
				if (num == 42)
				{
					registryKey.DeleteValue("PauseFeatureUpdatesEndTime", false);
					num = 43;
				}
				if (num == 44)
				{
					registryKey.Close();
					num = 45;
				}
				if (num != 45)
				{
					goto IL_55E;
				}
				IL_547:
				registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 46;
				goto IL_55E;
				IL_21:
				RegistryKey registryKey3;
				if (num == 3)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey3.GetValue("Pause_Updates");
					num = 5;
				}
				bool flag3;
				if (num == 5)
				{
					flag3 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag3)
					{
						goto IL_667;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UpdatePolicy\\Settings", "PausedQualityStatus", 1, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX", "IsConvergedUpdateStackEnabled", 1, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "ActiveHoursEnd", 17, RegistryValueKind.DWord);
					num = 12;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "ActiveHoursStart", 8, RegistryValueKind.DWord);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "AllowAutoWindowsUpdateDownloadOverMeteredNetwork", 0, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "DeferFeatureUpdatesPeriodInDays", 0, RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "DeferQualityUpdatesPeriodInDays", 0, RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "ExcludeWUDriversInQualityUpdate", 0, RegistryValueKind.DWord);
					num = 17;
				}
				if (num == 18)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "LastToastAction", 0, RegistryValueKind.DWord);
					num = 19;
				}
				if (num == 19)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "UxOption", 0, RegistryValueKind.DWord);
					num = 20;
				}
				if (num == 20)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "InsiderProgramEnabled", 0, RegistryValueKind.DWord);
					num = 21;
				}
				if (num == 21)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PendingRebootStartTime", "2019-07-28T03:07:38Z", RegistryValueKind.String);
					num = 22;
				}
				if (num == 22)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PauseFeatureUpdatesStartTime", "2019-07-28T03:07:38Z", RegistryValueKind.String);
					num = 23;
				}
				if (num == 23)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PauseQualityUpdatesStartTime", "2019-07-28T03:07:38Z", RegistryValueKind.String);
					num = 24;
				}
				if (num == 24)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PauseUpdatesExpiryTime", "2069-06-09T10:38:56Z", RegistryValueKind.String);
					num = 25;
				}
				if (num == 25)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings", "PauseFeatureUpdatesEndTime", "2069-06-09T10:38:56Z", RegistryValueKind.String);
					num = 26;
				}
				RegistryKey registryKey4;
				if (num == 27)
				{
					registryKey4 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 28;
				}
				bool flag4;
				if (num == 28)
				{
					flag4 = registryKey4 != null;
					num = 29;
				}
				if (num == 29)
				{
					if (!flag4)
					{
						break;
					}
					num = 30;
				}
				if (num == 30)
				{
					registryKey4.SetValue("Pause_Updates", 1);
					num = 31;
				}
				if (num == 31)
				{
					registryKey4.Close();
					num = 32;
				}
				if (num == 32)
				{
					break;
				}
				if (num == 33)
				{
					goto IL_401;
				}
				goto IL_425;
				IL_667:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UpdatePolicy\\Settings", "PausedFeatureStatus", 1, RegistryValueKind.DWord);
				num = 9;
				goto IL_68B;
				IL_401:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UpdatePolicy\\Settings", "PausedFeatureStatus", 0, RegistryValueKind.DWord);
				num = 34;
				goto IL_425;
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0015F8C8 File Offset: 0x0015DAC8
		private void Disable_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.Disable.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_1FA;
				IL_3DF:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_21E:
				if (num == 21)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\StorSvc", "Start", 3, RegistryValueKind.DWord);
					num = 22;
				}
				if (num == 22)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\UsoSvc", "Start", 2, RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 23)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TokenBroker", "Start", 3, RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LicenseManager", "Start", 3, RegistryValueKind.DWord);
					num = 25;
				}
				if (num == 25)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wuauserv", "Start", 3, RegistryValueKind.DWord);
					num = 26;
				}
				RegistryKey registryKey;
				bool flag;
				if (num == 27)
				{
					flag = registryKey != null;
					num = 28;
				}
				if (num == 28)
				{
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 29)
				{
					registryKey.DeleteValue("Disable_Updates", false);
					num = 30;
				}
				if (num == 30)
				{
					registryKey.Close();
					num = 31;
				}
				if (num == 26)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 27;
				}
				RegistryKey registryKey2;
				if (num == 17)
				{
					registryKey2.SetValue("Disable_Updates", 1);
					num = 18;
				}
				if (num == 8)
				{
					goto IL_3BB;
				}
				goto IL_3DF;
				IL_21:
				RegistryKey registryKey3;
				if (num == 3)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey3.GetValue("Disable_Updates");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_3BB;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\StorSvc", "Start", 4, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\UsoSvc", "Start", 4, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TokenBroker", "Start", 4, RegistryValueKind.DWord);
					num = 12;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LicenseManager", "Start", 4, RegistryValueKind.DWord);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wuauserv", "Start", 4, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 15;
				}
				bool flag3;
				if (num == 15)
				{
					flag3 = registryKey2 != null;
					num = 16;
				}
				if (num == 16)
				{
					if (!flag3)
					{
						break;
					}
					num = 17;
				}
				if (num == 18)
				{
					registryKey2.Close();
					num = 19;
				}
				if (num == 19)
				{
					break;
				}
				if (num == 20)
				{
					goto IL_1FA;
				}
				goto IL_21E;
				IL_3BB:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc", "Start", 4, RegistryValueKind.DWord);
				num = 9;
				goto IL_3DF;
				IL_1FA:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc", "Start", 2, RegistryValueKind.DWord);
				num = 21;
				goto IL_21E;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0015FCF8 File Offset: 0x0015DEF8
		private void discord_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.discord.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_13A;
				IL_26C:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 25)
				{
					break;
				}
				continue;
				IL_151:
				RegistryKey registryKey;
				bool flag;
				if (num == 16)
				{
					flag = registryKey != null;
					num = 17;
				}
				if (num == 18)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey, "Discord.exe");
					num = 19;
				}
				if (num == 19)
				{
					registryKey.Close();
					num = 20;
				}
				if (num == 20)
				{
					goto IL_205;
				}
				IL_21C:
				RegistryKey registryKey2;
				bool flag2;
				if (num == 21)
				{
					flag2 = registryKey2 != null;
					num = 22;
				}
				if (num == 22)
				{
					if (!flag2)
					{
						break;
					}
					num = 23;
				}
				if (num == 23)
				{
					registryKey2.DeleteValue("Optimize_Discord", false);
					num = 24;
				}
				if (num == 24)
				{
					registryKey2.Close();
					num = 25;
				}
				if (num == 17)
				{
					if (!flag)
					{
						goto IL_205;
					}
					num = 18;
				}
				if (num == 8)
				{
					goto IL_248;
				}
				goto IL_26C;
				IL_205:
				registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 21;
				goto IL_21C;
				IL_21:
				RegistryKey registryKey3;
				if (num == 3)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey3.GetValue("Optimize_Discord");
					num = 5;
				}
				bool flag3;
				if (num == 5)
				{
					flag3 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag3)
					{
						goto IL_248;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				RegistryKey registryKey4;
				if (num == 9)
				{
					registryKey4 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 10;
				}
				bool flag4;
				if (num == 10)
				{
					flag4 = registryKey4 != null;
					num = 11;
				}
				if (num == 11)
				{
					if (!flag4)
					{
						break;
					}
					num = 12;
				}
				if (num == 12)
				{
					registryKey4.SetValue("Optimize_Discord", 1);
					num = 13;
				}
				if (num == 13)
				{
					registryKey4.Close();
					num = 14;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_13A;
				}
				goto IL_151;
				IL_248:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Discord.exe", "UseLargePages", 1, RegistryValueKind.DWord);
				num = 9;
				goto IL_26C;
				IL_13A:
				registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options");
				num = 16;
				goto IL_151;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0015FFB8 File Offset: 0x0015E1B8
		private void chrome_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.chrome.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_29F;
				IL_2CE:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 28)
				{
					break;
				}
				continue;
				IL_2A5:
				if (num == 8)
				{
					goto IL_2AF;
				}
				goto IL_2CE;
				IL_21:
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey.GetValue("Optimize_Chrome");
					num = 5;
				}
				bool flag;
				if (num == 5)
				{
					flag = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag)
					{
						goto IL_2AF;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome", "ChromeCleanupReportingEnabled", 0);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome", "ChromeCleanupEnabled", 0);
					num = 11;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 12;
				}
				bool flag2;
				if (num == 12)
				{
					flag2 = registryKey2 != null;
					num = 13;
				}
				if (num == 13)
				{
					if (!flag2)
					{
						break;
					}
					num = 14;
				}
				if (num == 14)
				{
					registryKey2.SetValue("Optimize_Chrome", 1);
					num = 15;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 16)
				{
					break;
				}
				if (num == 18)
				{
					Utils.TryDeleteRegistryValue(true, "SOFTWARE\\Policies\\Google\\Chrome", "MetricsReportingEnabled");
					num = 19;
				}
				if (num == 19)
				{
					num = 20;
				}
				if (num == 20)
				{
					Utils.TryDeleteRegistryValue(true, "SOFTWARE\\Policies\\Google\\Chrome", "ChromeCleanupReportingEnabled");
					num = 21;
				}
				if (num == 21)
				{
					num = 22;
				}
				if (num == 22)
				{
					Utils.TryDeleteRegistryValue(true, "SOFTWARE\\Policies\\Google\\Chrome", "ChromeCleanupEnabled");
					num = 23;
				}
				RegistryKey registryKey3;
				if (num == 23)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 24;
				}
				bool flag3;
				if (num == 24)
				{
					flag3 = registryKey3 != null;
					num = 25;
				}
				if (num == 25)
				{
					if (!flag3)
					{
						break;
					}
					num = 26;
				}
				if (num == 27)
				{
					registryKey3.Close();
					num = 28;
				}
				if (num == 26)
				{
					registryKey3.DeleteValue("Optimize_Chrome", false);
					num = 27;
				}
				if (num == 17)
				{
					goto IL_29F;
				}
				goto IL_2A5;
				IL_2AF:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome", "MetricsReportingEnabled", 0);
				num = 9;
				goto IL_2CE;
				IL_29F:
				num = 18;
				goto IL_2A5;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x001602D8 File Offset: 0x0015E4D8
		private void firefox_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.firefox.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_18A;
				IL_2D3:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 29)
				{
					break;
				}
				continue;
				IL_190:
				if (num == 19)
				{
					Utils.TryDeleteRegistryValue(true, "SOFTWARE\\Policies\\Mozilla\\Firefox", "DisableTelemetry");
					num = 20;
				}
				if (num == 20)
				{
					num = 21;
				}
				if (num == 21)
				{
					Utils.TryDeleteRegistryValue(true, "SOFTWARE\\Policies\\Mozilla\\Firefox", "DisableDefaultBrowserAgent");
					num = 22;
				}
				if (num == 22)
				{
					Utils.RunCommand("schtasks.exe /change /enable /tn \"\\Mozilla\\Firefox Default Browser Agent 308046B0AF4A39CB\"");
					num = 23;
				}
				if (num == 23)
				{
					Utils.RunCommand("schtasks.exe /change /enable /tn \"\\Mozilla\\Firefox Default Browser Agent D2CEEC440E2074BD\"");
					num = 24;
				}
				RegistryKey registryKey;
				if (num == 24)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 25;
				}
				bool flag;
				if (num == 25)
				{
					flag = registryKey != null;
					num = 26;
				}
				if (num == 27)
				{
					registryKey.DeleteValue("Optimize_Firefox", false);
					num = 28;
				}
				if (num == 28)
				{
					registryKey.Close();
					num = 29;
				}
				if (num == 26)
				{
					if (!flag)
					{
						break;
					}
					num = 27;
				}
				if (num == 17)
				{
					break;
				}
				if (num == 8)
				{
					goto IL_2B4;
				}
				goto IL_2D3;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Optimize_Firefox");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_2B4;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox", "DisableDefaultBrowserAgent", 1);
					num = 10;
				}
				if (num == 10)
				{
					Utils.RunCommand("schtasks.exe /change /disable /tn \"\\Mozilla\\Firefox Default Browser Agent 308046B0AF4A39CB\"");
					num = 11;
				}
				if (num == 11)
				{
					Utils.RunCommand("schtasks.exe /change /disable /tn \"\\Mozilla\\Firefox Default Browser Agent D2CEEC440E2074BD\"");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 12)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 13;
				}
				bool flag3;
				if (num == 13)
				{
					flag3 = registryKey3 != null;
					num = 14;
				}
				if (num == 14)
				{
					if (!flag3)
					{
						break;
					}
					num = 15;
				}
				if (num == 15)
				{
					registryKey3.SetValue("Optimize_Firefox", 1);
					num = 16;
				}
				if (num == 16)
				{
					registryKey3.Close();
					num = 17;
				}
				if (num == 18)
				{
					goto IL_18A;
				}
				goto IL_190;
				IL_2B4:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox", "DisableTelemetry", 1);
				num = 9;
				goto IL_2D3;
				IL_18A:
				num = 19;
				goto IL_190;
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x001605FC File Offset: 0x0015E7FC
		private void brave_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.brave.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_13A;
				IL_1DD:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					break;
				}
				continue;
				IL_151:
				RegistryKey registryKey;
				bool flag;
				if (num == 16)
				{
					flag = registryKey != null;
					num = 17;
				}
				if (num == 18)
				{
					registryKey.DeleteValue("Optimize_Brave", false);
					num = 19;
				}
				if (num == 19)
				{
					registryKey.Close();
					num = 20;
				}
				if (num == 17)
				{
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 8)
				{
					goto IL_1BE;
				}
				goto IL_1DD;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Optimize_Brave");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_1BE;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				RegistryKey registryKey3;
				if (num == 9)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 10;
				}
				bool flag3;
				if (num == 10)
				{
					flag3 = registryKey3 != null;
					num = 11;
				}
				if (num == 11)
				{
					if (!flag3)
					{
						break;
					}
					num = 12;
				}
				if (num == 12)
				{
					registryKey3.SetValue("Optimize_Brave", 1);
					num = 13;
				}
				if (num == 13)
				{
					registryKey3.Close();
					num = 14;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_13A;
				}
				goto IL_151;
				IL_1BE:
				base.BeginInvoke(new Action(delegate
				{
					int num2 = 0;
					Error error;
					do
					{
						if (num2 == 3)
						{
							error = new Error();
							num2 = 4;
						}
						if (num2 == 2)
						{
							bool flag4;
							if (!flag4)
							{
								goto IL_77;
							}
							num2 = 3;
						}
						if (num2 == 1)
						{
							bool flag4 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1009800393376669736/brave.exe", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\brave.exe");
							num2 = 2;
						}
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 4);
					try
					{
						error.ShowDialog(this);
					}
					finally
					{
						if (error != null)
						{
							((IDisposable)error).Dispose();
						}
					}
					return;
					IL_77:
					Process process = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Downloads\\brave.exe");
					process.WaitForExit();
					File.Delete("C:\\Nexus_LiteOS_Toolkit\\Downloads\\brave.exe");
				}));
				num = 9;
				goto IL_1DD;
				IL_13A:
				registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 16;
				goto IL_151;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0016082C File Offset: 0x0015EA2C
		private void steam_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.steam.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_13A;
				IL_1DD:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					break;
				}
				continue;
				IL_151:
				RegistryKey registryKey;
				bool flag;
				if (num == 16)
				{
					flag = registryKey != null;
					num = 17;
				}
				if (num == 18)
				{
					registryKey.DeleteValue("Optimize_Steam", false);
					num = 19;
				}
				if (num == 19)
				{
					registryKey.Close();
					num = 20;
				}
				if (num == 17)
				{
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 8)
				{
					goto IL_1BE;
				}
				goto IL_1DD;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Optimize_Steam");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_1BE;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				RegistryKey registryKey3;
				if (num == 9)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 10;
				}
				bool flag3;
				if (num == 10)
				{
					flag3 = registryKey3 != null;
					num = 11;
				}
				if (num == 11)
				{
					if (!flag3)
					{
						break;
					}
					num = 12;
				}
				if (num == 12)
				{
					registryKey3.SetValue("Optimize_Steam", 1);
					num = 13;
				}
				if (num == 13)
				{
					registryKey3.Close();
					num = 14;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_13A;
				}
				goto IL_151;
				IL_1BE:
				base.BeginInvoke(new Action(delegate
				{
					int num2 = 0;
					Error error;
					do
					{
						if (num2 == 3)
						{
							error = new Error();
							num2 = 4;
						}
						if (num2 == 2)
						{
							bool flag4;
							if (!flag4)
							{
								goto IL_77;
							}
							num2 = 3;
						}
						if (num2 == 1)
						{
							bool flag4 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1009800330415968376/Steam.reg", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\Steam.reg");
							num2 = 2;
						}
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 4);
					try
					{
						error.ShowDialog(this);
					}
					finally
					{
						if (error != null)
						{
							((IDisposable)error).Dispose();
						}
					}
					return;
					IL_77:
					Process process = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Downloads\\Steam.reg");
					process.WaitForExit();
					File.Delete("C:\\Nexus_LiteOS_Toolkit\\Downloads\\Steam.reg");
				}));
				num = 9;
				goto IL_1DD;
				IL_13A:
				registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 16;
				goto IL_151;
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00160A5C File Offset: 0x0015EC5C
		private void nvidia_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.nvidia.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_1BF;
				IL_33E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 33)
				{
					break;
				}
				continue;
				IL_1DE:
				if (num == 22)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmRepOnLogon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
					num = 23;
				}
				if (num == 23)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmRep_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
					num = 24;
				}
				if (num == 24)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmMon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
					num = 25;
				}
				if (num == 25)
				{
					Utils.RunCommand("net.exe start NvTelemetryContainer");
					num = 26;
				}
				if (num == 27)
				{
					Utils.RunCommand("sc.exe start NvTelemetryContainer");
					num = 28;
				}
				RegistryKey registryKey;
				if (num == 28)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 29;
				}
				bool flag;
				if (num == 29)
				{
					flag = registryKey != null;
					num = 30;
				}
				if (num == 30)
				{
					if (!flag)
					{
						break;
					}
					num = 31;
				}
				if (num == 31)
				{
					registryKey.DeleteValue("Nvidia_Telemtery", false);
					num = 32;
				}
				if (num == 32)
				{
					registryKey.Close();
					num = 33;
				}
				if (num == 26)
				{
					Utils.RunCommand("sc.exe config NvTelemetryContainer start= enabled");
					num = 27;
				}
				if (num == 17)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 18;
				}
				if (num == 8)
				{
					goto IL_31F;
				}
				goto IL_33E;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Nvidia_Telemtery");
					num = 5;
				}
				bool flag3;
				if (num == 5)
				{
					flag3 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag3)
					{
						goto IL_31F;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmRepOnLogon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
					num = 10;
				}
				if (num == 10)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmRep_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
					num = 11;
				}
				if (num == 11)
				{
					Utils.RunCommand("schtasks.exe /change /tn NvTmMon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
					num = 12;
				}
				if (num == 12)
				{
					Utils.RunCommand("net.exe stop NvTelemetryContainer");
					num = 13;
				}
				if (num == 13)
				{
					Utils.RunCommand("sc.exe config NvTelemetryContainer start= disabled");
					num = 14;
				}
				if (num == 14)
				{
					Utils.RunCommand("sc.exe stop NvTelemetryContainer");
					num = 15;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 16;
				}
				if (num == 16)
				{
					bool flag2 = registryKey3 != null;
					num = 17;
				}
				if (num == 18)
				{
					registryKey3.SetValue("Nvidia_Telemtery", 1);
					num = 19;
				}
				if (num == 19)
				{
					registryKey3.Close();
					num = 20;
				}
				if (num == 20)
				{
					break;
				}
				if (num == 21)
				{
					goto IL_1BF;
				}
				goto IL_1DE;
				IL_31F:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NvTelemetryContainer", "Start", 4);
				num = 9;
				goto IL_33E;
				IL_1BF:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NvTelemetryContainer", "Start", 2);
				num = 22;
				goto IL_1DE;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00160DEC File Offset: 0x0015EFEC
		private void activate_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				Process process;
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "iwr -useb https://massgrave.dev/get | iex";
					num = 5;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00160F20 File Offset: 0x0015F120
		private void basic_tweaks_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 2;
				}
				bool flag;
				if (num == 2)
				{
					flag = registryKey != null;
					num = 3;
				}
				if (num != 3)
				{
					goto IL_33;
				}
				if (flag)
				{
					num = 4;
					goto IL_33;
				}
				goto IL_62;
				IL_78:
				RegistryKey registryKey2;
				bool flag2;
				if (num == 6)
				{
					flag2 = registryKey2 != null;
					num = 7;
				}
				if (num != 7)
				{
					goto IL_A2;
				}
				if (flag2)
				{
					num = 8;
					goto IL_A2;
				}
				goto IL_C2;
				IL_D9:
				RegistryKey registryKey3;
				bool flag3;
				if (num == 11)
				{
					flag3 = registryKey3 != null;
					num = 12;
				}
				if (num != 12)
				{
					goto IL_104;
				}
				if (flag3)
				{
					num = 13;
					goto IL_104;
				}
				goto IL_150;
				IL_167:
				RegistryKey registryKey4;
				bool flag4;
				if (num == 16)
				{
					flag4 = registryKey4 != null;
					num = 17;
				}
				if (num == 18)
				{
					registryKey4.SetValue("SystemPaneSuggestionsEnabled", 0, RegistryValueKind.DWord);
					num = 19;
				}
				if (num == 19)
				{
					registryKey4.Close();
					num = 20;
				}
				if (num == 20)
				{
					goto IL_185F;
				}
				IL_1876:
				RegistryKey registryKey5;
				bool flag5;
				if (num == 21)
				{
					flag5 = registryKey5 != null;
					num = 22;
				}
				if (num != 22)
				{
					goto IL_1E7;
				}
				if (flag5)
				{
					num = 23;
					goto IL_1E7;
				}
				goto IL_233;
				IL_24A:
				if (num != 27)
				{
					goto IL_25E;
				}
				bool flag6;
				if (flag6)
				{
					num = 28;
					goto IL_25E;
				}
				goto IL_2AA;
				IL_2C1:
				RegistryKey registryKey6;
				bool flag7;
				if (num == 31)
				{
					flag7 = registryKey6 != null;
					num = 32;
				}
				if (num != 32)
				{
					goto IL_2EC;
				}
				if (flag7)
				{
					num = 33;
					goto IL_2EC;
				}
				goto IL_34C;
				IL_363:
				RegistryKey registryKey7;
				bool flag8;
				if (num == 37)
				{
					flag8 = registryKey7 != null;
					num = 38;
				}
				if (num != 38)
				{
					goto IL_38E;
				}
				if (flag8)
				{
					num = 39;
					goto IL_38E;
				}
				goto IL_3DA;
				IL_3F1:
				RegistryKey registryKey8;
				bool flag9;
				if (num == 42)
				{
					flag9 = registryKey8 != null;
					num = 43;
				}
				if (num == 44)
				{
					registryKey8.SetValue("SubscribedContent-338393Enabled", 0, RegistryValueKind.DWord);
					num = 45;
				}
				if (num == 45)
				{
					registryKey8.Close();
					num = 46;
				}
				if (num == 46)
				{
					goto IL_17E7;
				}
				IL_17FE:
				RegistryKey registryKey9;
				bool flag10;
				if (num == 47)
				{
					flag10 = registryKey9 != null;
					num = 48;
				}
				if (num != 48)
				{
					goto IL_471;
				}
				if (flag10)
				{
					num = 49;
					goto IL_471;
				}
				goto IL_4BD;
				IL_4D4:
				if (num != 53)
				{
					goto IL_4E8;
				}
				bool flag11;
				if (flag11)
				{
					num = 54;
					goto IL_4E8;
				}
				goto IL_534;
				IL_54B:
				RegistryKey registryKey10;
				bool flag12;
				if (num == 57)
				{
					flag12 = registryKey10 != null;
					num = 58;
				}
				if (num != 58)
				{
					goto IL_579;
				}
				if (flag12)
				{
					num = 59;
					goto IL_579;
				}
				goto IL_17AB;
				IL_17C2:
				RegistryKey registryKey11;
				if (num == 52)
				{
					flag11 = registryKey11 != null;
					num = 53;
				}
				if (num == 43)
				{
					if (!flag9)
					{
						goto IL_17E7;
					}
					num = 44;
				}
				if (num == 35)
				{
					registryKey6.Close();
					num = 36;
				}
				RegistryKey registryKey12;
				if (num == 26)
				{
					flag6 = registryKey12 != null;
					num = 27;
				}
				if (num == 17)
				{
					if (!flag4)
					{
						goto IL_185F;
					}
					num = 18;
				}
				if (num == 8)
				{
					registryKey2.SetValue("DisableWindowsConsumerFeatures", 1, RegistryValueKind.DWord);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 225)
				{
					break;
				}
				continue;
				IL_579:
				if (num == 59)
				{
					registryKey10.SetValue("AutoDownload", 2, RegistryValueKind.DWord);
					num = 60;
				}
				if (num == 60)
				{
					registryKey10.Close();
					num = 61;
				}
				RegistryKey registryKey13;
				bool flag13;
				if (num == 62)
				{
					flag13 = registryKey13 != null;
					num = 63;
				}
				if (num != 63)
				{
					goto IL_5E6;
				}
				if (flag13)
				{
					num = 64;
					goto IL_5E6;
				}
				goto IL_616;
				IL_62D:
				RegistryKey registryKey14;
				bool flag14;
				if (num == 66)
				{
					flag14 = registryKey14 != null;
					num = 67;
				}
				if (num != 67)
				{
					goto IL_65B;
				}
				if (flag14)
				{
					num = 68;
					goto IL_65B;
				}
				goto IL_178A;
				IL_17A1:
				if (num == 61)
				{
					goto IL_17AB;
				}
				goto IL_17C2;
				IL_65B:
				if (num == 68)
				{
					registryKey14.SetValue("MaintenanceDisabled", 1);
					num = 69;
				}
				if (num == 69)
				{
					registryKey14.Close();
					num = 70;
				}
				RegistryKey registryKey15;
				bool flag15;
				if (num == 71)
				{
					flag15 = registryKey15 != null;
					num = 72;
				}
				if (num != 72)
				{
					goto IL_6C3;
				}
				if (flag15)
				{
					num = 73;
					goto IL_6C3;
				}
				goto IL_6F3;
				IL_70A:
				RegistryKey registryKey16;
				bool flag16;
				if (num == 75)
				{
					flag16 = registryKey16 != null;
					num = 76;
				}
				if (num != 76)
				{
					goto IL_738;
				}
				if (flag16)
				{
					num = 77;
					goto IL_738;
				}
				goto IL_1769;
				IL_1780:
				if (num == 70)
				{
					goto IL_178A;
				}
				goto IL_17A1;
				IL_738:
				if (num == 77)
				{
					registryKey16.SetValue("SaveZoneInformation", 1);
					num = 78;
				}
				if (num == 78)
				{
					registryKey16.Close();
					num = 79;
				}
				RegistryKey registryKey17;
				bool flag17;
				if (num == 80)
				{
					flag17 = registryKey17 != null;
					num = 81;
				}
				if (num != 81)
				{
					goto IL_7A0;
				}
				if (flag17)
				{
					num = 82;
					goto IL_7A0;
				}
				goto IL_7D0;
				IL_7E7:
				RegistryKey registryKey18;
				bool flag18;
				if (num == 84)
				{
					flag18 = registryKey18 != null;
					num = 85;
				}
				if (num != 85)
				{
					goto IL_812;
				}
				if (flag18)
				{
					num = 86;
					goto IL_812;
				}
				goto IL_847;
				IL_85E:
				RegistryKey registryKey19;
				bool flag19;
				if (num == 89)
				{
					flag19 = registryKey19 != null;
					num = 90;
				}
				if (num != 90)
				{
					goto IL_889;
				}
				if (flag19)
				{
					num = 91;
					goto IL_889;
				}
				goto IL_8B9;
				IL_8D0:
				RegistryKey registryKey20;
				bool flag20;
				if (num == 93)
				{
					flag20 = registryKey20 != null;
					num = 94;
				}
				if (num != 94)
				{
					goto IL_8FB;
				}
				if (flag20)
				{
					num = 95;
					goto IL_8FB;
				}
				goto IL_92B;
				IL_94F:
				RegistryKey registryKey21;
				if (num == 98)
				{
					registryKey21 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 99;
				}
				bool flag21;
				if (num == 99)
				{
					flag21 = registryKey21 != null;
					num = 100;
				}
				if (num != 100)
				{
					goto IL_99B;
				}
				if (flag21)
				{
					num = 101;
					goto IL_99B;
				}
				goto IL_9CB;
				IL_9EF:
				RegistryKey registryKey22;
				if (num == 103)
				{
					registryKey22 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 104;
				}
				bool flag22;
				if (num == 104)
				{
					flag22 = registryKey22 != null;
					num = 105;
				}
				if (num == 106)
				{
					registryKey22.SetValue("Disable_Print", 1);
					num = 107;
				}
				if (num == 107)
				{
					goto IL_16F5;
				}
				IL_170C:
				RegistryKey registryKey23;
				bool flag23;
				if (num == 108)
				{
					flag23 = registryKey23 != null;
					num = 109;
				}
				if (num != 109)
				{
					goto IL_A74;
				}
				if (flag23)
				{
					num = 110;
					goto IL_A74;
				}
				goto IL_AA4;
				IL_ABB:
				RegistryKey registryKey24;
				bool flag24;
				if (num == 112)
				{
					flag24 = registryKey24 != null;
					num = 113;
				}
				if (num != 113)
				{
					goto IL_AE6;
				}
				if (flag24)
				{
					num = 114;
					goto IL_AE6;
				}
				goto IL_AF0;
				IL_AFD:
				ProcessStartInfo processStartInfo;
				if (num == 116)
				{
					processStartInfo = new ProcessStartInfo();
					num = 117;
				}
				if (num == 117)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 118;
				}
				if (num == 118)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 119;
				}
				if (num == 119)
				{
					processStartInfo.Arguments = "/c sc.exe config DiagTrack start= disabled";
					num = 120;
				}
				Process process;
				if (num == 120)
				{
					process.StartInfo = processStartInfo;
					num = 121;
				}
				if (num == 121)
				{
					process.Start();
					num = 122;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 123)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 124;
				}
				if (num == 124)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 125;
				}
				if (num == 125)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 126;
				}
				if (num == 126)
				{
					processStartInfo2.Arguments = " /c sc.exe stop DiagTrack";
					num = 127;
				}
				Process process2;
				if (num == 127)
				{
					process2.StartInfo = processStartInfo2;
					num = 128;
				}
				if (num == 128)
				{
					process2.Start();
					num = 129;
				}
				Process process3;
				if (num == 129)
				{
					process3 = new Process();
					num = 130;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 130)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 131;
				}
				if (num == 132)
				{
					processStartInfo3.FileName = "cmd.exe";
					num = 133;
				}
				if (num == 133)
				{
					processStartInfo3.Arguments = " /c sc.exe config dmwappushservice start= disabled";
					num = 134;
				}
				if (num == 134)
				{
					process3.StartInfo = processStartInfo3;
					num = 135;
				}
				if (num == 135)
				{
					process3.Start();
					num = 136;
				}
				Process process4;
				if (num == 136)
				{
					process4 = new Process();
					num = 137;
				}
				ProcessStartInfo processStartInfo4;
				if (num == 137)
				{
					processStartInfo4 = new ProcessStartInfo();
					num = 138;
				}
				if (num == 138)
				{
					processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
					num = 139;
				}
				if (num == 139)
				{
					processStartInfo4.FileName = "cmd.exe";
					num = 140;
				}
				if (num == 141)
				{
					process4.StartInfo = processStartInfo4;
					num = 142;
				}
				if (num == 142)
				{
					process4.Start();
					num = 143;
				}
				Process process5;
				if (num == 143)
				{
					process5 = new Process();
					num = 144;
				}
				ProcessStartInfo processStartInfo5;
				if (num == 144)
				{
					processStartInfo5 = new ProcessStartInfo();
					num = 145;
				}
				if (num == 145)
				{
					processStartInfo5.WindowStyle = ProcessWindowStyle.Hidden;
					num = 146;
				}
				if (num == 146)
				{
					processStartInfo5.FileName = "cmd.exe";
					num = 147;
				}
				if (num == 147)
				{
					processStartInfo5.Arguments = " /c sc.exe config diagnosticshub.standardcollector.service start= disabled";
					num = 148;
				}
				if (num == 148)
				{
					process5.StartInfo = processStartInfo5;
					num = 149;
				}
				Process process6;
				if (num == 150)
				{
					process6 = new Process();
					num = 151;
				}
				ProcessStartInfo processStartInfo6;
				if (num == 151)
				{
					processStartInfo6 = new ProcessStartInfo();
					num = 152;
				}
				if (num == 152)
				{
					processStartInfo6.WindowStyle = ProcessWindowStyle.Hidden;
					num = 153;
				}
				if (num == 153)
				{
					processStartInfo6.FileName = "cmd.exe";
					num = 154;
				}
				if (num == 154)
				{
					processStartInfo6.Arguments = " /c sc.exe stop diagnosticshub.standardcollector.service";
					num = 155;
				}
				if (num == 155)
				{
					process6.StartInfo = processStartInfo6;
					num = 156;
				}
				if (num == 156)
				{
					process6.Start();
					num = 157;
				}
				RegistryKey registryKey25;
				if (num == 157)
				{
					registryKey25 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
					num = 158;
				}
				if (num != 159)
				{
					goto IL_EE6;
				}
				bool flag25;
				if (flag25)
				{
					num = 160;
					goto IL_EE6;
				}
				goto IL_F3C;
				IL_F53:
				RegistryKey registryKey26;
				bool flag26;
				if (num == 164)
				{
					flag26 = registryKey26 != null;
					num = 165;
				}
				if (num != 165)
				{
					goto IL_F7E;
				}
				if (flag26)
				{
					num = 166;
					goto IL_F7E;
				}
				goto IL_F88;
				IL_FAC:
				RegistryKey registryKey27;
				if (num == 168)
				{
					registryKey27 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 169;
				}
				bool flag27;
				if (num == 169)
				{
					flag27 = registryKey27 != null;
					num = 170;
				}
				if (num != 170)
				{
					goto IL_FF8;
				}
				if (flag27)
				{
					num = 171;
					goto IL_FF8;
				}
				goto IL_1028;
				IL_103F:
				RegistryKey registryKey28;
				bool flag28;
				if (num == 173)
				{
					flag28 = registryKey28 != null;
					num = 174;
				}
				if (num != 174)
				{
					goto IL_106A;
				}
				if (flag28)
				{
					num = 175;
					goto IL_106A;
				}
				goto IL_108B;
				IL_10A2:
				RegistryKey registryKey29;
				bool flag29;
				if (num == 178)
				{
					flag29 = registryKey29 != null;
					num = 179;
				}
				if (num != 179)
				{
					goto IL_10CD;
				}
				if (flag29)
				{
					num = 180;
					goto IL_10CD;
				}
				goto IL_10FD;
				IL_1114:
				RegistryKey registryKey30;
				bool flag30;
				if (num == 182)
				{
					flag30 = registryKey30 != null;
					num = 183;
				}
				if (num != 183)
				{
					goto IL_113F;
				}
				if (flag30)
				{
					num = 184;
					goto IL_113F;
				}
				goto IL_1149;
				IL_1160:
				RegistryKey registryKey31;
				bool flag31;
				if (num == 186)
				{
					flag31 = registryKey31 != null;
					num = 187;
				}
				if (num != 187)
				{
					goto IL_118B;
				}
				if (flag31)
				{
					num = 188;
					goto IL_118B;
				}
				goto IL_11BB;
				IL_11C8:
				ProcessStartInfo processStartInfo7;
				if (num == 190)
				{
					processStartInfo7 = new ProcessStartInfo();
					num = 191;
				}
				if (num == 191)
				{
					processStartInfo7.WindowStyle = ProcessWindowStyle.Hidden;
					num = 192;
				}
				if (num == 192)
				{
					processStartInfo7.FileName = "cmd.exe";
					num = 193;
				}
				Process process7;
				if (num == 194)
				{
					process7.StartInfo = processStartInfo7;
					num = 195;
				}
				if (num == 195)
				{
					process7.Start();
					num = 196;
				}
				RegistryKey registryKey32;
				if (num == 196)
				{
					registryKey32 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 197;
				}
				bool flag32;
				if (num == 197)
				{
					flag32 = registryKey32 != null;
					num = 198;
				}
				if (num != 198)
				{
					goto IL_1294;
				}
				if (flag32)
				{
					num = 199;
					goto IL_1294;
				}
				goto IL_12C4;
				IL_12E8:
				RegistryKey registryKey33;
				if (num == 201)
				{
					registryKey33 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 202;
				}
				if (num != 203)
				{
					goto IL_131D;
				}
				bool flag33;
				if (flag33)
				{
					num = 204;
					goto IL_131D;
				}
				goto IL_134D;
				IL_1369:
				RegistryKey registryKey34;
				bool flag34;
				if (num == 206)
				{
					flag34 = registryKey34 != null;
					num = 207;
				}
				if (num != 207)
				{
					goto IL_1394;
				}
				if (flag34)
				{
					num = 208;
					goto IL_1394;
				}
				goto IL_13EA;
				IL_1401:
				RegistryKey registryKey35;
				bool flag35;
				if (num == 212)
				{
					flag35 = registryKey35 != null;
					num = 213;
				}
				if (num != 213)
				{
					goto IL_142C;
				}
				if (flag35)
				{
					num = 214;
					goto IL_142C;
				}
				goto IL_145C;
				IL_1473:
				RegistryKey registryKey36;
				bool flag36;
				if (num == 216)
				{
					flag36 = registryKey36 != null;
					num = 217;
				}
				if (num != 217)
				{
					goto IL_149E;
				}
				if (flag36)
				{
					num = 218;
					goto IL_149E;
				}
				goto IL_14CE;
				IL_14E5:
				RegistryKey registryKey37;
				bool flag37;
				if (num == 221)
				{
					flag37 = registryKey37 != null;
					num = 222;
				}
				if (num != 222)
				{
					goto IL_1510;
				}
				if (flag37)
				{
					num = 223;
					goto IL_1510;
				}
				goto IL_1540;
				IL_154D:
				if (num == 219)
				{
					registryKey36.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
					num = 220;
				}
				if (num == 210)
				{
					registryKey34.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
					num = 211;
				}
				if (num == 202)
				{
					flag33 = registryKey33 != null;
					num = 203;
				}
				if (num == 193)
				{
					processStartInfo7.Arguments = "/C cmd.exe bcdedit /deletevalue useplatformclock";
					num = 194;
				}
				if (num == 184)
				{
					registryKey30.SetValue("AllowWindowsInkWorkspace", 1);
					num = 185;
				}
				if (num == 175)
				{
					registryKey28.SetValue("JPEGImportQuality", 256, RegistryValueKind.DWord);
					num = 176;
				}
				if (num == 166)
				{
					registryKey26.SetValue("Disable_Telemetry", 1);
					num = 167;
				}
				if (num == 158)
				{
					flag25 = registryKey25 != null;
					num = 159;
				}
				if (num == 149)
				{
					process5.Start();
					num = 150;
				}
				if (num == 140)
				{
					processStartInfo4.Arguments = " /c sc.exe stop dmwappushservice";
					num = 141;
				}
				if (num == 131)
				{
					processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
					num = 132;
				}
				if (num == 122)
				{
					process2 = new Process();
					num = 123;
				}
				if (num == 114)
				{
					registryKey24.SetValue("Disable_Store_Up", 1);
					num = 115;
				}
				if (num == 105)
				{
					if (!flag22)
					{
						goto IL_16F5;
					}
					num = 106;
				}
				if (num == 96)
				{
					registryKey20.Close();
					num = 97;
				}
				if (num == 87)
				{
					registryKey18.Close();
					num = 88;
				}
				if (num == 79)
				{
					goto IL_1769;
				}
				goto IL_1780;
				IL_1510:
				if (num == 223)
				{
					registryKey37.SetValue("Disable_Symain", 1);
					num = 224;
				}
				if (num != 224)
				{
					goto IL_154D;
				}
				IL_1540:
				applied = new applied();
				num = 225;
				goto IL_154D;
				IL_149E:
				if (num == 218)
				{
					registryKey36.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
					num = 219;
				}
				if (num != 220)
				{
					goto IL_14E5;
				}
				IL_14CE:
				registryKey37 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 221;
				goto IL_14E5;
				IL_142C:
				if (num == 214)
				{
					registryKey35.SetValue("Disable_Spectre_Meltdown", 1);
					num = 215;
				}
				if (num != 215)
				{
					goto IL_1473;
				}
				IL_145C:
				registryKey36 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
				num = 216;
				goto IL_1473;
				IL_1394:
				if (num == 208)
				{
					registryKey34.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
					num = 209;
				}
				if (num == 209)
				{
					registryKey34.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
					num = 210;
				}
				if (num != 211)
				{
					goto IL_1401;
				}
				IL_13EA:
				registryKey35 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 212;
				goto IL_1401;
				IL_131D:
				if (num == 204)
				{
					registryKey33.SetValue("Disable_mmcss", 1);
					num = 205;
				}
				if (num != 205)
				{
					goto IL_1369;
				}
				IL_134D:
				registryKey34 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
				num = 206;
				goto IL_1369;
				IL_1294:
				if (num == 199)
				{
					registryKey32.SetValue("Disable_HPET", 1);
					num = 200;
				}
				if (num != 200)
				{
					goto IL_12E8;
				}
				IL_12C4:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MMCSS", "Start", 4, RegistryValueKind.DWord);
				num = 201;
				goto IL_12E8;
				IL_118B:
				if (num == 188)
				{
					registryKey31.SetValue("Disable_Inkspace", 1);
					num = 189;
				}
				if (num != 189)
				{
					goto IL_11C8;
				}
				IL_11BB:
				process7 = new Process();
				num = 190;
				goto IL_11C8;
				IL_113F:
				if (num != 185)
				{
					goto IL_1160;
				}
				IL_1149:
				registryKey31 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 186;
				goto IL_1160;
				IL_10CD:
				if (num == 180)
				{
					registryKey29.SetValue("Disable_Wallpaper_Redcution", 1);
					num = 181;
				}
				if (num != 181)
				{
					goto IL_1114;
				}
				IL_10FD:
				registryKey30 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace");
				num = 182;
				goto IL_1114;
				IL_106A:
				if (num == 176)
				{
					registryKey28.Close();
					num = 177;
				}
				if (num != 177)
				{
					goto IL_10A2;
				}
				IL_108B:
				registryKey29 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 178;
				goto IL_10A2;
				IL_FF8:
				if (num == 171)
				{
					registryKey27.SetValue("Disable_UAC", 1);
					num = 172;
				}
				if (num != 172)
				{
					goto IL_103F;
				}
				IL_1028:
				registryKey28 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
				num = 173;
				goto IL_103F;
				IL_F7E:
				if (num != 167)
				{
					goto IL_FAC;
				}
				IL_F88:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 0, RegistryValueKind.DWord);
				num = 168;
				goto IL_FAC;
				IL_EE6:
				if (num == 160)
				{
					registryKey25.SetValue("AllowTelemetry", 0, RegistryValueKind.DWord);
					num = 161;
				}
				if (num == 161)
				{
					registryKey25.Close();
					num = 162;
				}
				if (num != 162 && num != 163)
				{
					goto IL_F53;
				}
				IL_F3C:
				registryKey26 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 164;
				goto IL_F53;
				IL_AE6:
				if (num != 115)
				{
					goto IL_AFD;
				}
				IL_AF0:
				process = new Process();
				num = 116;
				goto IL_AFD;
				IL_A74:
				if (num == 110)
				{
					registryKey23.SetValue("AutoDownload", 2);
					num = 111;
				}
				if (num != 111)
				{
					goto IL_ABB;
				}
				IL_AA4:
				registryKey24 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 112;
				goto IL_ABB;
				IL_16F5:
				registryKey23 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsStore");
				num = 108;
				goto IL_170C;
				IL_99B:
				if (num == 101)
				{
					registryKey21.SetValue("Disable_Error_Rep", 1);
					num = 102;
				}
				if (num != 102)
				{
					goto IL_9EF;
				}
				IL_9CB:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 4, RegistryValueKind.DWord);
				num = 103;
				goto IL_9EF;
				IL_8FB:
				if (num == 95)
				{
					registryKey20.SetValue("Disabled", 1);
					num = 96;
				}
				if (num != 97)
				{
					goto IL_94F;
				}
				IL_92B:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 4, RegistryValueKind.DWord);
				num = 98;
				goto IL_94F;
				IL_889:
				if (num == 91)
				{
					registryKey19.SetValue("Disable_Automatic_Driver_Up", 1);
					num = 92;
				}
				if (num != 92)
				{
					goto IL_8D0;
				}
				IL_8B9:
				registryKey20 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\Windows Error Reporting");
				num = 93;
				goto IL_8D0;
				IL_812:
				if (num == 86)
				{
					registryKey18.SetValue("ExcludeWUDriversInQualityUpdate", 1, RegistryValueKind.DWord);
					num = 87;
				}
				if (num != 88)
				{
					goto IL_85E;
				}
				IL_847:
				registryKey19 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 89;
				goto IL_85E;
				IL_7A0:
				if (num == 82)
				{
					registryKey17.SetValue("Disable_Automatic_Dl_Block", 1);
					num = 83;
				}
				if (num != 83)
				{
					goto IL_7E7;
				}
				IL_7D0:
				registryKey18 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate");
				num = 84;
				goto IL_7E7;
				IL_1769:
				registryKey17 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 80;
				goto IL_1780;
				IL_6C3:
				if (num == 73)
				{
					registryKey15.SetValue("Disable_Automatic_Maintenance", 1);
					num = 74;
				}
				if (num != 74)
				{
					goto IL_70A;
				}
				IL_6F3:
				registryKey16 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
				num = 75;
				goto IL_70A;
				IL_178A:
				registryKey15 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 71;
				goto IL_17A1;
				IL_5E6:
				if (num == 64)
				{
					registryKey13.SetValue("Disable_App_Lookup", 1);
					num = 65;
				}
				if (num != 65)
				{
					goto IL_62D;
				}
				IL_616:
				registryKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
				num = 66;
				goto IL_62D;
				IL_17AB:
				registryKey13 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 62;
				goto IL_17C2;
				IL_4E8:
				if (num == 54)
				{
					registryKey11.SetValue("SubscribedContent-353698Enabled", 0, RegistryValueKind.DWord);
					num = 55;
				}
				if (num == 55)
				{
					registryKey11.Close();
					num = 56;
				}
				if (num != 56)
				{
					goto IL_54B;
				}
				IL_534:
				registryKey10 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsStore");
				num = 57;
				goto IL_54B;
				IL_471:
				if (num == 49)
				{
					registryKey9.SetValue("SubscribedContent-314563Enabled", 0, RegistryValueKind.DWord);
					num = 50;
				}
				if (num == 50)
				{
					registryKey9.Close();
					num = 51;
				}
				if (num != 51)
				{
					goto IL_4D4;
				}
				IL_4BD:
				registryKey11 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 52;
				goto IL_4D4;
				IL_17E7:
				registryKey9 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 47;
				goto IL_17FE;
				IL_38E:
				if (num == 39)
				{
					registryKey7.SetValue("SubscribedContent-310093Enabled", 0, RegistryValueKind.DWord);
					num = 40;
				}
				if (num == 40)
				{
					registryKey7.Close();
					num = 41;
				}
				if (num != 41)
				{
					goto IL_3F1;
				}
				IL_3DA:
				registryKey8 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 42;
				goto IL_3F1;
				IL_2EC:
				if (num == 33)
				{
					registryKey6.SetValue("RotatingLockScreenOverlayEnabled", 0, RegistryValueKind.DWord);
					num = 34;
				}
				if (num == 34)
				{
					registryKey6.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
					num = 35;
				}
				if (num != 36)
				{
					goto IL_363;
				}
				IL_34C:
				registryKey7 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 37;
				goto IL_363;
				IL_25E:
				if (num == 28)
				{
					registryKey12.SetValue("SoftLandingEnabled", 0, RegistryValueKind.DWord);
					num = 29;
				}
				if (num == 29)
				{
					registryKey12.Close();
					num = 30;
				}
				if (num != 30)
				{
					goto IL_2C1;
				}
				IL_2AA:
				registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 31;
				goto IL_2C1;
				IL_1E7:
				if (num == 23)
				{
					registryKey5.SetValue("ShowSyncProviderNotifications", 0, RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					registryKey5.Close();
					num = 25;
				}
				if (num != 25)
				{
					goto IL_24A;
				}
				IL_233:
				registryKey12 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 26;
				goto IL_24A;
				IL_185F:
				registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				num = 21;
				goto IL_1876;
				IL_104:
				if (num == 13)
				{
					registryKey3.SetValue("SilentInstalledAppsEnabled", 0, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					registryKey3.Close();
					num = 15;
				}
				if (num != 15)
				{
					goto IL_167;
				}
				IL_150:
				registryKey4 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager");
				num = 16;
				goto IL_167;
				IL_A2:
				if (num == 9)
				{
					registryKey2.Close();
					num = 10;
				}
				if (num != 10)
				{
					goto IL_D9;
				}
				IL_C2:
				registryKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager");
				num = 11;
				goto IL_D9;
				IL_33:
				if (num == 4)
				{
					registryKey.SetValue("Disable_Ads", 1);
					num = 5;
				}
				if (num != 5)
				{
					goto IL_78;
				}
				IL_62:
				registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent");
				num = 6;
				goto IL_78;
			}
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00162864 File Offset: 0x00160A64
		private void debloat_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				Process process;
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 3)
				{
					processStartInfo.FileName = "C:\\Windows\\SysWOW64\\lv-LV\\Debloater.exe";
					num = 4;
				}
				if (num == 4)
				{
					processStartInfo.Verb = "runas";
					num = 5;
				}
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
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00162974 File Offset: 0x00160B74
		private void disk_cleanup_Click(object sender, EventArgs e)
		{
			int num = 0;
			cleared cleared;
			do
			{
				if (num == 1)
				{
					Process.Start("cmd.exe", "/c del /s /q \"%temp%\"");
					num = 2;
				}
				if (num == 2)
				{
					Process.Start("C:\\Windows\\SysWOW64\\lv-LV\\net_temp.exe");
					num = 3;
				}
				if (num == 3)
				{
					Process.Start("C:\\Windows\\SysWOW64\\lv-LV\\Cookies.exe");
					num = 4;
				}
				Process process;
				if (num == 4)
				{
					process = new Process();
					num = 5;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo = new ProcessStartInfo();
					num = 6;
				}
				if (num == 6)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 7;
				}
				if (num == 7)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 8;
				}
				if (num == 9)
				{
					processStartInfo.Verb = "runas";
					num = 10;
				}
				if (num == 10)
				{
					process.StartInfo = processStartInfo;
					num = 11;
				}
				if (num == 11)
				{
					process.Start();
					num = 12;
				}
				if (num == 12)
				{
					process.WaitForExit();
					num = 13;
				}
				if (num == 13)
				{
					cleared = new cleared();
					num = 14;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/C ipconfig /flushdns";
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 14);
			try
			{
				cleared.ShowDialog(this);
			}
			finally
			{
				if (cleared != null)
				{
					((IDisposable)cleared).Dispose();
				}
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00162B20 File Offset: 0x00160D20
		private void disable_def_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
					num = 2;
				}
				bool flag;
				if (num == 2)
				{
					flag = registryKey != null;
					num = 3;
				}
				if (num != 3)
				{
					goto IL_33;
				}
				if (flag)
				{
					num = 4;
					goto IL_33;
				}
				goto IL_67;
				IL_7D:
				RegistryKey registryKey2;
				bool flag2;
				if (num == 6)
				{
					flag2 = registryKey2 != null;
					num = 7;
				}
				if (num != 7)
				{
					goto IL_AA;
				}
				if (flag2)
				{
					num = 8;
					goto IL_AA;
				}
				goto IL_132;
				IL_156:
				if (num == 13)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppContainer\\Storage\\microsoft.microsoftedge_8wekyb3d8bbwe\\MicrosoftEdge\\PhishingFilter", "EnabledV9", 0, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1, RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", 0, RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", 2, RegistryValueKind.DWord);
					num = 17;
				}
				RegistryKey registryKey3;
				if (num == 18)
				{
					registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender Security Center\\Systray");
					num = 19;
				}
				bool flag3;
				if (num == 19)
				{
					flag3 = registryKey3 != null;
					num = 20;
				}
				if (num != 20)
				{
					goto IL_25A;
				}
				if (flag3)
				{
					num = 21;
					goto IL_25A;
				}
				goto IL_28F;
				IL_2A6:
				RegistryKey registryKey4;
				bool flag4;
				if (num == 23)
				{
					flag4 = registryKey4 != null;
					num = 24;
				}
				if (num != 24)
				{
					goto IL_2D4;
				}
				if (flag4)
				{
					num = 25;
					goto IL_2D4;
				}
				goto IL_3E8;
				IL_3FF:
				if (num == 17)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DontReportInfectionInformation", 1, RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 8)
				{
					registryKey2.SetValue("DisableBehaviorMonitoring", 1, RegistryValueKind.DWord);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 36)
				{
					break;
				}
				continue;
				IL_2D4:
				if (num == 25)
				{
					registryKey4.SetValue("Disable_Windows_Defender", 1);
					num = 26;
				}
				RegistryKey registryKey5;
				bool flag5;
				if (num == 27)
				{
					flag5 = registryKey5 != null;
					num = 28;
				}
				if (num != 28)
				{
					goto IL_325;
				}
				if (flag5)
				{
					num = 29;
					goto IL_325;
				}
				goto IL_35F;
				IL_376:
				RegistryKey registryKey6;
				bool flag6;
				if (num == 32)
				{
					flag6 = registryKey6 != null;
					num = 33;
				}
				if (num != 33)
				{
					goto IL_3A1;
				}
				if (flag6)
				{
					num = 34;
					goto IL_3A1;
				}
				goto IL_3D1;
				IL_3DE:
				if (num == 26)
				{
					goto IL_3E8;
				}
				goto IL_3FF;
				IL_3A1:
				if (num == 34)
				{
					registryKey6.SetValue("Disable_MRT_Updates", 1);
					num = 35;
				}
				if (num != 35)
				{
					goto IL_3DE;
				}
				IL_3D1:
				applied = new applied();
				num = 36;
				goto IL_3DE;
				IL_325:
				if (num == 29)
				{
					registryKey5.SetValue("DontOfferThroughWUAU", 1);
					num = 30;
				}
				if (num != 30 && num != 31)
				{
					goto IL_376;
				}
				IL_35F:
				registryKey6 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 32;
				goto IL_376;
				IL_3E8:
				registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\MRT");
				num = 27;
				goto IL_3FF;
				IL_25A:
				if (num == 21)
				{
					registryKey3.SetValue("HideSystray", 1, RegistryValueKind.DWord);
					num = 22;
				}
				if (num != 22)
				{
					goto IL_2A6;
				}
				IL_28F:
				registryKey4 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
				num = 23;
				goto IL_2A6;
				IL_AA:
				if (num == 9)
				{
					registryKey2.SetValue("DisableOnAccessProtection", 1, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					registryKey2.SetValue("DisableScanOnRealtimeEnable", 1, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 11)
				{
					registryKey2.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
					num = 12;
				}
				if (num != 12)
				{
					goto IL_156;
				}
				IL_132:
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", 0, RegistryValueKind.DWord);
				num = 13;
				goto IL_156;
				IL_33:
				if (num == 4)
				{
					registryKey.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
					num = 5;
				}
				if (num != 5)
				{
					goto IL_7D;
				}
				IL_67:
				registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				num = 6;
				goto IL_7D;
			}
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000352BC File Offset: 0x000334BC
		private void gamingtweaks_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				if (num == 1)
				{
					applied = new applied();
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
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00162FF4 File Offset: 0x001611F4
		private void performance_tweaks_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			for (;;)
			{
				if (num == 1)
				{
					Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\sys.reg");
					num = 2;
				}
				RegistryKey registryKey;
				if (num == 2)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
					num = 3;
				}
				bool flag;
				if (num == 3)
				{
					flag = registryKey != null;
					num = 4;
				}
				if (num != 4)
				{
					goto IL_53;
				}
				if (flag)
				{
					num = 5;
					goto IL_53;
				}
				goto IL_98;
				IL_BC:
				if (num == 9)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MultitaskingView\\AllUpView", "AllUpView", 0, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\MultitaskingView\\AllUpView", "Remove TaskView", 1, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "AltTabSettings", 1, RegistryValueKind.DWord);
					num = 12;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\amdlog", "Start", 4, RegistryValueKind.DWord);
					num = 13;
				}
				RegistryKey registryKey2;
				if (num == 13)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 14;
				}
				if (num == 14)
				{
					registryKey2.SetValue("ExtendedUIHoverTime", "00030000", RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 15)
				{
					registryKey2.SetValue("DontPrettyPath", "1", RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					registryKey2.SetValue("ListviewShadow", "0", RegistryValueKind.DWord);
					num = 17;
				}
				RegistryKey registryKey3;
				if (num == 18)
				{
					registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DWM");
					num = 19;
				}
				if (num == 19)
				{
					registryKey3.SetValue("DWMWA_TRANSITIONS_FORCEDISABLED", "1", RegistryValueKind.DWord);
					num = 20;
				}
				if (num == 20)
				{
					registryKey3.SetValue("DisallowAnimations", "1", RegistryValueKind.DWord);
					num = 21;
				}
				RegistryKey registryKey4;
				if (num == 21)
				{
					registryKey4 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy");
					num = 22;
				}
				if (num == 22)
				{
					registryKey4.SetValue("DisableTaggedEnergyLogging", "1", RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 23)
				{
					registryKey4.SetValue("TelemetryMaxApplication", "0", RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					registryKey4.SetValue("TelemetryMaxTagPerApplication", "0", RegistryValueKind.DWord);
					num = 25;
				}
				RegistryKey registryKey5;
				if (num == 25)
				{
					registryKey5 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
					num = 26;
				}
				if (num == 27)
				{
					registryKey5.SetValue("FontSmoothingType", "2", RegistryValueKind.DWord);
					num = 28;
				}
				RegistryKey registryKey6;
				if (num == 28)
				{
					registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
					num = 29;
				}
				bool flag2;
				if (num == 29)
				{
					flag2 = registryKey6 != null;
					num = 30;
				}
				if (num != 30)
				{
					goto IL_396;
				}
				if (flag2)
				{
					num = 31;
					goto IL_396;
				}
				goto IL_3DD;
				IL_3F9:
				RegistryKey registryKey7;
				if (num == 34)
				{
					registryKey7 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop\\WindowMetrics", true);
					num = 35;
				}
				RegistryKey registryKey8;
				if (num == 36)
				{
					registryKey8.SetValue("DragFullWindows", "0", RegistryValueKind.String);
					num = 37;
				}
				if (num == 37)
				{
					registryKey8.SetValue("FontSmoothing", "0", RegistryValueKind.String);
					num = 38;
				}
				if (num == 38)
				{
					registryKey8.SetValue("MenuShowDelay", "0", RegistryValueKind.String);
					num = 39;
				}
				if (num == 39)
				{
					registryKey8.SetValue("UserPreferencesMask", new byte[] { 144, 18, 3, 128, 16, 0, 0, 0 }, RegistryValueKind.Binary);
					num = 40;
				}
				if (num == 40)
				{
					registryKey7.SetValue("MinAnimate", "0", RegistryValueKind.String);
					num = 41;
				}
				if (num == 41)
				{
					RegistryKey registryKey9;
					registryKey9.SetValue("VisualFXSetting", "2", RegistryValueKind.DWord);
					num = 42;
				}
				RegistryKey registryKey10;
				if (num == 42)
				{
					registryKey10 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
					num = 43;
				}
				if (num != 44)
				{
					goto IL_548;
				}
				bool flag3;
				if (flag3)
				{
					num = 45;
					goto IL_548;
				}
				goto IL_58F;
				IL_5AE:
				if (num == 48)
				{
					one_click_opt.CSRSS.SetValue("IoPriority", "3", RegistryValueKind.DWord);
					num = 49;
				}
				if (num == 49)
				{
					one_click_opt.CSRSS.SetValue("IoPriorityClass", "3", RegistryValueKind.DWord);
					num = 50;
				}
				RegistryKey registryKey11;
				if (num == 50)
				{
					registryKey11 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
					num = 51;
				}
				bool flag4;
				if (num == 51)
				{
					flag4 = registryKey11 != null;
					num = 52;
				}
				if (num == 53)
				{
					registryKey11.SetValue("CSRSS_Priority", 1);
					num = 54;
				}
				if (num == 54)
				{
					registryKey11.Close();
					num = 55;
				}
				if (num == 55)
				{
					goto IL_8B6;
				}
				IL_8D5:
				if (num == 56)
				{
					one_click_opt.GameConfigStore.SetValue("GameDVR_FSEBehavior", "2", RegistryValueKind.DWord);
					num = 57;
				}
				if (num == 57)
				{
					one_click_opt.GameConfigStore.SetValue("GameDVR_HonorUserFSEBehaviorMode", "1", RegistryValueKind.DWord);
					num = 58;
				}
				if (num == 58)
				{
					one_click_opt.GameConfigStore.SetValue("GameDVR_FSEBehaviorMode", "2", RegistryValueKind.DWord);
					num = 59;
				}
				if (num == 59)
				{
					one_click_opt.GameConfigStore.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", "1", RegistryValueKind.DWord);
					num = 60;
				}
				bool flag5;
				if (num == 60)
				{
					flag5 = one_click_opt.children != null;
					num = 61;
				}
				if (num == 62)
				{
					Registry.CurrentUser.DeleteSubKeyTree("SYSTEM\\GameConfigStore\\Children");
					num = 63;
				}
				if (num == 63)
				{
					goto IL_86F;
				}
				IL_88C:
				if (num != 64)
				{
					goto IL_74F;
				}
				bool flag6;
				if (flag6)
				{
					num = 65;
					goto IL_74F;
				}
				goto IL_778;
				IL_797:
				if (num == 67)
				{
					one_click_opt.GameBar.SetValue("AutoGameModeEnabled", "0", RegistryValueKind.DWord);
					num = 68;
				}
				RegistryKey registryKey12;
				if (num == 68)
				{
					registryKey12 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
					num = 69;
				}
				bool flag7;
				if (num == 69)
				{
					flag7 = registryKey12 != null;
					num = 70;
				}
				if (num == 71)
				{
					registryKey12.SetValue("Disable_FSO", 1);
					num = 72;
				}
				if (num == 72)
				{
					registryKey12.Close();
					num = 73;
				}
				if (num == 73)
				{
					goto IL_840;
				}
				IL_84D:
				if (num == 70)
				{
					if (!flag7)
					{
						goto IL_840;
					}
					num = 71;
				}
				if (num == 61)
				{
					if (!flag5)
					{
						goto IL_86F;
					}
					num = 62;
				}
				if (num == 52)
				{
					if (!flag4)
					{
						goto IL_8B6;
					}
					num = 53;
				}
				if (num == 43)
				{
					flag3 = registryKey10 != null;
					num = 44;
				}
				if (num == 35)
				{
					RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects", true);
					num = 36;
				}
				if (num == 26)
				{
					registryKey5.SetValue("FontSmoothing", "2", RegistryValueKind.String);
					num = 27;
				}
				if (num == 17)
				{
					registryKey2.SetValue("TaskbarAnimations", "0", RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 8)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power", "EnergyEstimationEnabled", 0, RegistryValueKind.DWord);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 74)
				{
					break;
				}
				continue;
				IL_840:
				applied = new applied();
				num = 74;
				goto IL_84D;
				IL_74F:
				if (num == 65)
				{
					Registry.CurrentUser.DeleteSubKeyTree("SYSTEM\\GameConfigStore\\Parents");
					num = 66;
				}
				if (num != 66)
				{
					goto IL_797;
				}
				IL_778:
				one_click_opt.GameBar.SetValue("AllowAutoGameMode", "0", RegistryValueKind.DWord);
				num = 67;
				goto IL_797;
				IL_86F:
				flag6 = one_click_opt.parents != null;
				num = 64;
				goto IL_88C;
				IL_8B6:
				one_click_opt.GameConfigStore.SetValue("GameDVR_Enabled", "0", RegistryValueKind.DWord);
				num = 56;
				goto IL_8D5;
				IL_548:
				if (num == 45)
				{
					registryKey10.SetValue("Visual_Tweaks", 1);
					num = 46;
				}
				if (num == 46)
				{
					registryKey10.Close();
					num = 47;
				}
				if (num != 47)
				{
					goto IL_5AE;
				}
				IL_58F:
				one_click_opt.CSRSS.SetValue("CpuPriorityClass", "4", RegistryValueKind.DWord);
				num = 48;
				goto IL_5AE;
				IL_396:
				if (num == 31)
				{
					registryKey6.SetValue("DWM_Optimization", 1);
					num = 32;
				}
				if (num == 32)
				{
					registryKey6.Close();
					num = 33;
				}
				if (num != 33)
				{
					goto IL_3F9;
				}
				IL_3DD:
				registryKey8 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop", true);
				num = 34;
				goto IL_3F9;
				IL_53:
				if (num == 5)
				{
					registryKey.SetValue("System_Profile_Tweaks", 1);
					num = 6;
				}
				if (num == 6)
				{
					registryKey.Close();
					num = 7;
				}
				if (num != 7)
				{
					goto IL_BC;
				}
				IL_98:
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\DWM", "EnableAeroPeek", 0, RegistryValueKind.DWord);
				num = 8;
				goto IL_BC;
			}
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00163A34 File Offset: 0x00161C34
		private void siticoneButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			Error error;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1080087865729490994/BCD.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\BCD.bat");
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						goto IL_7A;
					}
					num = 3;
				}
				if (num == 3)
				{
					error = new Error();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			goto IL_D4;
			IL_7A:
			one_click_opt.p.StartInfo.FileName = "C:\\Nexus_LiteOS_Toolkit\\Bin\\BCD.bat";
			one_click_opt.p.Start();
			one_click_opt.p.WaitForExit();
			File.Delete(one_click_opt.p.StartInfo.FileName);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
				return;
			}
			try
			{
				IL_D4:
				error.ShowDialog(this);
			}
			finally
			{
				if (error != null)
				{
					((IDisposable)error).Dispose();
				}
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00163B48 File Offset: 0x00161D48
		private void siticoneButton2_Click(object sender, EventArgs e)
		{
			int num = 0;
			Error error;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1080087898843529296/network.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\Network.bat");
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						goto IL_7A;
					}
					num = 3;
				}
				if (num == 3)
				{
					error = new Error();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			goto IL_D4;
			IL_7A:
			one_click_opt.p.StartInfo.FileName = "C:\\Nexus_LiteOS_Toolkit\\Bin\\Network.bat";
			one_click_opt.p.Start();
			one_click_opt.p.WaitForExit();
			File.Delete(one_click_opt.p.StartInfo.FileName);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
				return;
			}
			try
			{
				IL_D4:
				error.ShowDialog(this);
			}
			finally
			{
				if (error != null)
				{
					((IDisposable)error).Dispose();
				}
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00163C5C File Offset: 0x00161E5C
		private void siticoneButton3_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						Error error;
						do
						{
							if (num2 == 3)
							{
								error = new Error();
								num2 = 4;
							}
							if (num2 == 2)
							{
								bool flag;
								if (!flag)
								{
									goto IL_77;
								}
								num2 = 3;
							}
							if (num2 == 1)
							{
								bool flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081160877987868702/DisableTelemetryTasks.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\Telemetry.bat");
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 4);
						try
						{
							error.ShowDialog(this);
						}
						finally
						{
							if (error != null)
							{
								((IDisposable)error).Dispose();
							}
						}
						return;
						IL_77:
						Process process = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Bin\\Telemetry.bat");
						process.WaitForExit();
						File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\Telemetry.bat");
					}));
					num = 2;
				}
				if (num == 2)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "RotatingLockScreenOverlayEnabled", "0", RegistryValueKind.DWord);
					num = 3;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "RotatingLockScreenEnabled", "0", RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 4)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "DisableWindowsSpotlightFeatures", "1", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "DisableTailoredExperiencesWithDiagnosticData", "1", RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge", "SpotlightExperiencesAndRecommendationsEnabled", 0);
					num = 7;
				}
				if (num == 7)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge", "SpotlightExperiencesAndRecommendationsEnabled", 0);
					num = 8;
				}
				if (num == 9)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DoNotShowFeedbackNotifications", 1);
					num = 10;
				}
				if (num == 10)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds", "EnableFeeds", 0);
					num = 11;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo", "Enabled", 0);
					num = 12;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Bluetooth", "AllowAdvertising", 0);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AdvertisingInfo", "DisabledByGroupPolicy", 1);
					num = 14;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\TabletPC", "PreventHandwritingDataSharing", 1);
					num = 15;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\TextInput", "AllowLinguisticDataCollection", 0);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\InputPersonalization", "AllowInputPersonalization", 0);
					num = 17;
				}
				if (num == 18)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge", "PersonalizationReportingEnabled", 0);
					num = 19;
				}
				if (num == 19)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge", "UserFeedbackAllowed", 0);
					num = 20;
				}
				if (num == 20)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge", "UserFeedbackAllowed", 0);
					num = 21;
				}
				if (num == 21)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SearchSettings", "SafeSearchMode", 0, RegistryValueKind.DWord);
					num = 22;
				}
				if (num == 22)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "UploadUserActivities", 0);
					num = 23;
				}
				if (num == 23)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "AllowCrossDeviceClipboard", 0);
					num = 24;
				}
				if (num == 24)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\Messaging", "AllowMessageSync", 0);
					num = 25;
				}
				if (num == 25)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync", "DisableCredentialsSettingSync", 2);
					num = 26;
				}
				if (num == 27)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync", "DisableApplicationSettingSync", 2);
					num = 28;
				}
				if (num == 28)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync", "DisableApplicationSettingSyncUserOverride", 1);
					num = 29;
				}
				if (num == 29)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy", "LetAppsActivateWithVoice", 2);
					num = 30;
				}
				if (num == 30)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\FindMyDevice", "AllowFindMyDevice", "0", RegistryValueKind.DWord);
					num = 31;
				}
				if (num == 31)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Settings\\FindMyDevice", "LocationSyncEnabled", "0", RegistryValueKind.DWord);
					num = 32;
				}
				if (num == 32)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableActivityFeed", "0", RegistryValueKind.DWord);
					num = 33;
				}
				if (num == 33)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableCdp", "0", RegistryValueKind.DWord);
					num = 34;
				}
				if (num == 34)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", "0", RegistryValueKind.DWord);
					num = 35;
				}
				if (num == 36)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack", "ShowedToastAtLevel", "1", RegistryValueKind.DWord);
					num = 37;
				}
				if (num == 37)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack", "ShowedToastAtLevel", "1", RegistryValueKind.DWord);
					num = 38;
				}
				if (num == 38)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Speech_OneCore\\Settings\\OnlineSpeechPrivacy", "HasAccepted", "0", RegistryValueKind.DWord);
					num = 39;
				}
				if (num == 39)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", "Deny", RegistryValueKind.String);
					num = 40;
				}
				if (num == 40)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Settings\\FindMyDevice", "LocationSyncEnabled", "0", RegistryValueKind.DWord);
					num = 41;
				}
				if (num == 41)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors", "DisableLocation", 1, RegistryValueKind.DWord);
					num = 42;
				}
				if (num == 42)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors", "DisableLocationScripting", 1, RegistryValueKind.DWord);
					num = 43;
				}
				if (num == 44)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", "SensorPermissionState", "0", RegistryValueKind.DWord);
					num = 45;
				}
				if (num == 45)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\lfsvc\\Service\\Configuration", "Status", "0", RegistryValueKind.DWord);
					num = 46;
				}
				if (num == 46)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds", "ShellFeedsTaskbarOpenOnHover", "0", RegistryValueKind.DWord);
					num = 47;
				}
				if (num == 47)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CDP", "CdpSessionUserAuthzPolicy", "0", RegistryValueKind.DWord);
					num = 48;
				}
				if (num == 48)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CDP", "NearShareChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);
					num = 49;
				}
				if (num == 49)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CDP", "RomeSdkChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);
					num = 50;
				}
				if (num == 50)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\CurrentVersion\\Software Protection Platform", "NoGenTicket", "1", RegistryValueKind.DWord);
					num = 51;
				}
				if (num == 51)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo", "Enabled", "0", RegistryValueKind.DWord);
					num = 52;
				}
				if (num == 53)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost\\EnableWebContentEvaluation", "Enabled", "0", RegistryValueKind.DWord);
					num = 54;
				}
				if (num == 54)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\International\\User Profile", "HttpAcceptLanguageOptOut", "1", RegistryValueKind.DWord);
					num = 55;
				}
				if (num == 55)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SmartGlass", "UserAuthPolicy", "0", RegistryValueKind.DWord);
					num = 56;
				}
				if (num == 56)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Personalization\\Settings", "AcceptedPrivacyPolicy", "0", RegistryValueKind.DWord);
					num = 57;
				}
				if (num == 57)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Language", "Enabled", "0", RegistryValueKind.DWord);
					num = 58;
				}
				if (num == 58)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\InputPersonalization", "RestrictImplicitTextCollection", "1", RegistryValueKind.DWord);
					num = 59;
				}
				if (num == 59)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\InputPersonalization", "RestrictImplicitInkCollection", "1", RegistryValueKind.DWord);
					num = 60;
				}
				if (num == 60)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\InputPersonalization\\TrainedDataStore", "HarvestContacts", "0", RegistryValueKind.DWord);
					num = 61;
				}
				if (num == 62)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy", "LetAppsSyncWithDevices", "2", RegistryValueKind.DWord);
					num = 63;
				}
				if (num == 63)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\LooselyCoupled", "Value", "Deny", RegistryValueKind.String);
					num = 64;
				}
				if (num == 64)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", "MaxTelemetryAllowed", "0", RegistryValueKind.DWord);
					num = 65;
				}
				if (num == 65)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "UploadUserActivities", "0", RegistryValueKind.DWord);
					num = 66;
				}
				if (num == 66)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Siuf\\Rules", "PeriodInNanoSeconds", "0", RegistryValueKind.DWord);
					num = 67;
				}
				if (num == 67)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Siuf\\Rules", "NumberOfSIUFInPeriod", "0", RegistryValueKind.DWord);
					num = 68;
				}
				if (num == 68)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);
					num = 69;
				}
				if (num == 69)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);
					num = 70;
				}
				if (num == 71)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);
					num = 72;
				}
				if (num == 72)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Connect", "AllowProjectionToPC", "0", RegistryValueKind.DWord);
					num = 73;
				}
				if (num == 73)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System", "EnableMmx", 0, RegistryValueKind.DWord);
					num = 74;
				}
				if (num == 74)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System", "RSoPLogging", 0, RegistryValueKind.DWord);
					num = 75;
				}
				if (num == 75)
				{
					applied = new applied();
					num = 76;
				}
				if (num == 70)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\WMI\\AutoLogger\\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);
					num = 71;
				}
				if (num == 61)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Input\\TIPC", "Enabled", "0", RegistryValueKind.DWord);
					num = 62;
				}
				if (num == 52)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", "0", RegistryValueKind.DWord);
					num = 53;
				}
				if (num == 43)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors", "DisableWindowsLocationProvider", 1, RegistryValueKind.DWord);
					num = 44;
				}
				if (num == 35)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", "0", RegistryValueKind.DWord);
					num = 36;
				}
				if (num == 26)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync", "DisableCredentialsSettingSyncUserOverride", 1);
					num = 27;
				}
				if (num == 17)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge", "PersonalizationReportingEnabled", 0);
					num = 18;
				}
				if (num == 8)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableCloudOptimizedContent", 1);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 76);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x001648D0 File Offset: 0x00162AD0
		private void siticoneCheckBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.office_telemetry.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_21;
				}
				if (@checked)
				{
					num = 3;
					goto IL_21;
				}
				goto IL_163;
				IL_25B:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 23)
				{
					break;
				}
				continue;
				IL_182:
				RegistryKey registryKey;
				if (num == 18)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 19;
				}
				bool flag;
				if (num == 19)
				{
					flag = registryKey != null;
					num = 20;
				}
				if (num == 20)
				{
					if (!flag)
					{
						break;
					}
					num = 21;
				}
				if (num == 21)
				{
					registryKey.DeleteValue("DisableOfficeTelemtry", false);
					num = 22;
				}
				if (num == 22)
				{
					registryKey.Close();
					num = 23;
				}
				if (num == 17)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						Error error;
						do
						{
							if (num2 == 3)
							{
								error = new Error();
								num2 = 4;
							}
							if (num2 == 2)
							{
								bool flag4;
								if (!flag4)
								{
									goto IL_77;
								}
								num2 = 3;
							}
							if (num2 == 1)
							{
								bool flag4 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081160877258047498/EnableOfficeTelemetry.reg", "C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.reg");
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 4);
						try
						{
							error.ShowDialog(this);
						}
						finally
						{
							if (error != null)
							{
								((IDisposable)error).Dispose();
							}
						}
						return;
						IL_77:
						Process process = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.reg");
						process.WaitForExit();
						File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.reg");
					}));
					num = 18;
				}
				if (num == 8)
				{
					goto IL_23C;
				}
				goto IL_25B;
				IL_21:
				RegistryKey registryKey2;
				if (num == 3)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				object value;
				if (num == 4)
				{
					value = registryKey2.GetValue("Disable_Services");
					num = 5;
				}
				bool flag2;
				if (num == 5)
				{
					flag2 = value != null;
					num = 6;
				}
				if (num == 6)
				{
					if (!flag2)
					{
						goto IL_23C;
					}
					num = 7;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 9)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num3 = 0;
						Error error2;
						do
						{
							if (num3 == 3)
							{
								error2 = new Error();
								num3 = 4;
							}
							if (num3 == 2)
							{
								bool flag5;
								if (!flag5)
								{
									goto IL_77;
								}
								num3 = 3;
							}
							if (num3 == 1)
							{
								bool flag5 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081160876519858206/DisableOfficeTelemetry.reg", "C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.reg");
								num3 = 2;
							}
							if (num3 == 0)
							{
								num3 = 1;
							}
						}
						while (num3 != 4);
						try
						{
							error2.ShowDialog(this);
						}
						finally
						{
							if (error2 != null)
							{
								((IDisposable)error2).Dispose();
							}
						}
						return;
						IL_77:
						Process process2 = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.reg");
						process2.WaitForExit();
						File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.reg");
					}));
					num = 10;
				}
				RegistryKey registryKey3;
				if (num == 10)
				{
					registryKey3 = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 11;
				}
				bool flag3;
				if (num == 11)
				{
					flag3 = registryKey3 != null;
					num = 12;
				}
				if (num == 12)
				{
					if (!flag3)
					{
						break;
					}
					num = 13;
				}
				if (num == 13)
				{
					registryKey3.SetValue("DisableOfficeTelemtry", 1);
					num = 14;
				}
				if (num == 14)
				{
					registryKey3.Close();
					num = 15;
				}
				if (num == 15)
				{
					break;
				}
				if (num == 16)
				{
					goto IL_163;
				}
				goto IL_182;
				IL_23C:
				base.BeginInvoke(new Action(delegate
				{
					int num4 = 0;
					Error error3;
					do
					{
						if (num4 == 3)
						{
							error3 = new Error();
							num4 = 4;
						}
						if (num4 == 2)
						{
							bool flag6;
							if (!flag6)
							{
								goto IL_77;
							}
							num4 = 3;
						}
						if (num4 == 1)
						{
							bool flag6 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081160876884766740/DisableOfficeTelemetryTasks.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.bat");
							num4 = 2;
						}
						if (num4 == 0)
						{
							num4 = 1;
						}
					}
					while (num4 != 4);
					try
					{
						error3.ShowDialog(this);
					}
					finally
					{
						if (error3 != null)
						{
							((IDisposable)error3).Dispose();
						}
					}
					return;
					IL_77:
					Process process3 = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.bat");
					process3.WaitForExit();
					File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\DisableOfficeTelemetryTasks.bat");
				}));
				num = 9;
				goto IL_25B;
				IL_163:
				base.BeginInvoke(new Action(delegate
				{
					int num5 = 0;
					Error error4;
					do
					{
						if (num5 == 3)
						{
							error4 = new Error();
							num5 = 4;
						}
						if (num5 == 2)
						{
							bool flag7;
							if (!flag7)
							{
								goto IL_77;
							}
							num5 = 3;
						}
						if (num5 == 1)
						{
							bool flag7 = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1081163027094720563/EnableOfficeTelemetryTasks.bat", "C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.bat");
							num5 = 2;
						}
						if (num5 == 0)
						{
							num5 = 1;
						}
					}
					while (num5 != 4);
					try
					{
						error4.ShowDialog(this);
					}
					finally
					{
						if (error4 != null)
						{
							((IDisposable)error4).Dispose();
						}
					}
					return;
					IL_77:
					Process process4 = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.bat");
					process4.WaitForExit();
					File.Delete("C:\\Nexus_LiteOS_Toolkit\\Bin\\EnableOfficeTelemetry.bat");
				}));
				num = 17;
				goto IL_182;
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00164B7C File Offset: 0x00162D7C
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

		// Token: 0x0600094E RID: 2382 RVA: 0x00164BF4 File Offset: 0x00162DF4
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.next_btn = new SiticoneRoundedButton();
					num = 5;
				}
				if (num == 8)
				{
					this.Pause = new SiticoneCheckBox();
					num = 9;
				}
				if (num == 12)
				{
					this.brave = new SiticoneCheckBox();
					num = 13;
				}
				if (num == 16)
				{
					this.activate_btn = new SiticoneButton();
					num = 17;
				}
				if (num == 20)
				{
					this.debloat_btn = new SiticoneButton();
					num = 21;
				}
				if (num == 24)
				{
					this.siticoneButton3 = new SiticoneButton();
					num = 25;
				}
				if (num == 28)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 29;
				}
				if (num == 32)
				{
					this.label37.Size = new Size(186, 19);
					num = 33;
				}
				if (num == 36)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 37;
				}
				if (num == 40)
				{
					this.label1.Size = new Size(248, 53);
					num = 41;
				}
				if (num == 44)
				{
					this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 45;
				}
				if (num == 48)
				{
					this.label2.Size = new Size(202, 30);
					num = 49;
				}
				if (num == 53)
				{
					this.next_btn.CheckedState.Parent = this.next_btn;
					num = 54;
				}
				if (num == 57)
				{
					this.next_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 58;
				}
				if (num == 61)
				{
					this.next_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 62;
				}
				if (num == 65)
				{
					this.next_btn.Name = "next_btn";
					num = 66;
				}
				if (num == 69)
				{
					this.next_btn.Text = "Next";
					num = 70;
				}
				if (num == 73)
				{
					this.label3.ForeColor = Color.White;
					num = 74;
				}
				if (num == 77)
				{
					this.label3.TabIndex = 327;
					num = 78;
				}
				if (num == 81)
				{
					this.useless_services.CheckedState.BorderRadius = 0;
					num = 82;
				}
				if (num == 85)
				{
					this.useless_services.ForeColor = Color.White;
					num = 86;
				}
				if (num == 89)
				{
					this.useless_services.TabIndex = 328;
					num = 90;
				}
				if (num == 93)
				{
					this.useless_services.UncheckedState.BorderThickness = 0;
					num = 94;
				}
				if (num == 97)
				{
					this.Tasks.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 98;
				}
				if (num == 102)
				{
					this.Tasks.ForeColor = Color.White;
					num = 103;
				}
				if (num == 106)
				{
					this.Tasks.TabIndex = 329;
					num = 107;
				}
				if (num == 110)
				{
					this.Tasks.UncheckedState.BorderThickness = 0;
					num = 111;
				}
				if (num == 114)
				{
					this.Pause.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 115;
				}
				if (num == 118)
				{
					this.Pause.Font = new Font("Josefin Sans", 12f);
					num = 119;
				}
				if (num == 122)
				{
					this.Pause.Size = new Size(219, 29);
					num = 123;
				}
				if (num == 126)
				{
					this.Pause.UncheckedState.BorderRadius = 0;
					num = 127;
				}
				if (num == 130)
				{
					this.Disable.AutoSize = true;
					num = 131;
				}
				if (num == 134)
				{
					this.Disable.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 135;
				}
				if (num == 138)
				{
					this.Disable.Name = "Disable";
					num = 139;
				}
				if (num == 142)
				{
					this.Disable.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 143;
				}
				if (num == 146)
				{
					this.Disable.CheckedChanged += this.Disable_CheckedChanged;
					num = 147;
				}
				if (num == 151)
				{
					this.chrome.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 152;
				}
				if (num == 155)
				{
					this.chrome.Name = "chrome";
					num = 156;
				}
				if (num == 159)
				{
					this.chrome.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 160;
				}
				if (num == 163)
				{
					this.chrome.CheckedChanged += this.chrome_CheckedChanged;
					num = 164;
				}
				if (num == 167)
				{
					this.firefox.CheckedState.BorderThickness = 0;
					num = 168;
				}
				if (num == 171)
				{
					this.firefox.Location = new Point(539, 435);
					num = 172;
				}
				if (num == 175)
				{
					this.firefox.Text = "Optimize Firefox";
					num = 176;
				}
				if (num == 179)
				{
					this.firefox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 180;
				}
				if (num == 183)
				{
					this.brave.CheckedState.BorderRadius = 0;
					num = 184;
				}
				if (num == 187)
				{
					this.brave.ForeColor = Color.White;
					num = 188;
				}
				if (num == 191)
				{
					this.brave.TabIndex = 334;
					num = 192;
				}
				if (num == 195)
				{
					this.brave.UncheckedState.BorderThickness = 0;
					num = 196;
				}
				if (num == 200)
				{
					this.discord.CheckedState.BorderRadius = 0;
					num = 201;
				}
				if (num == 204)
				{
					this.discord.ForeColor = Color.White;
					num = 205;
				}
				if (num == 208)
				{
					this.discord.TabIndex = 336;
					num = 209;
				}
				if (num == 212)
				{
					this.discord.UncheckedState.BorderThickness = 0;
					num = 213;
				}
				if (num == 216)
				{
					this.steam.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 217;
				}
				if (num == 220)
				{
					this.steam.Font = new Font("Josefin Sans", 12f);
					num = 221;
				}
				if (num == 224)
				{
					this.steam.Size = new Size(146, 29);
					num = 225;
				}
				if (num == 228)
				{
					this.steam.UncheckedState.BorderRadius = 0;
					num = 229;
				}
				if (num == 232)
				{
					this.nvidia.AutoSize = true;
					num = 233;
				}
				if (num == 236)
				{
					this.nvidia.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 237;
				}
				if (num == 240)
				{
					this.nvidia.Name = "nvidia";
					num = 241;
				}
				if (num == 244)
				{
					this.nvidia.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 245;
				}
				if (num == 248)
				{
					this.nvidia.CheckedChanged += this.nvidia_CheckedChanged;
					num = 249;
				}
				if (num == 253)
				{
					this.activate_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 254;
				}
				if (num == 257)
				{
					this.activate_btn.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 258;
				}
				if (num == 261)
				{
					this.activate_btn.Location = new Point(33, 146);
					num = 262;
				}
				if (num == 265)
				{
					this.activate_btn.TabIndex = 340;
					num = 266;
				}
				if (num == 269)
				{
					this.disk_cleanup.CustomImages.Parent = this.disk_cleanup;
					num = 270;
				}
				if (num == 273)
				{
					this.disk_cleanup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 274;
				}
				if (num == 277)
				{
					this.disk_cleanup.ForeColor = Color.White;
					num = 278;
				}
				if (num == 281)
				{
					this.disk_cleanup.Name = "disk_cleanup";
					num = 282;
				}
				if (num == 285)
				{
					this.disk_cleanup.Text = "Disk Cleanup";
					num = 286;
				}
				if (num == 289)
				{
					this.basic_tweaks_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 290;
				}
				if (num == 293)
				{
					this.basic_tweaks_btn.DisabledState.Parent = this.basic_tweaks_btn;
					num = 294;
				}
				if (num == 297)
				{
					this.basic_tweaks_btn.HoverState.Parent = this.basic_tweaks_btn;
					num = 298;
				}
				if (num == 302)
				{
					this.basic_tweaks_btn.Size = new Size(240, 42);
					num = 303;
				}
				if (num == 306)
				{
					this.disable_def_btn.CheckedState.Parent = this.disable_def_btn;
					num = 307;
				}
				if (num == 310)
				{
					this.disable_def_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 311;
				}
				if (num == 314)
				{
					this.disable_def_btn.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 315;
				}
				if (num == 318)
				{
					this.disable_def_btn.Location = new Point(383, 205);
					num = 319;
				}
				if (num == 322)
				{
					this.disable_def_btn.TabIndex = 343;
					num = 323;
				}
				if (num == 326)
				{
					this.debloat_btn.CustomImages.Parent = this.debloat_btn;
					num = 327;
				}
				if (num == 330)
				{
					this.debloat_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 331;
				}
				if (num == 334)
				{
					this.debloat_btn.ForeColor = Color.White;
					num = 335;
				}
				if (num == 338)
				{
					this.debloat_btn.Name = "debloat_btn";
					num = 339;
				}
				if (num == 342)
				{
					this.debloat_btn.Text = "Debloat Windows";
					num = 343;
				}
				if (num == 346)
				{
					this.performance_tweaks_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 347;
				}
				if (num == 351)
				{
					this.performance_tweaks_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 352;
				}
				if (num == 355)
				{
					this.performance_tweaks_btn.ImageSize = new Size(30, 30);
					num = 356;
				}
				if (num == 359)
				{
					this.performance_tweaks_btn.Size = new Size(240, 42);
					num = 360;
				}
				if (num == 363)
				{
					this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
					num = 364;
				}
				if (num == 367)
				{
					this.siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 368;
				}
				if (num == 371)
				{
					this.siticoneButton1.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 372;
				}
				if (num == 375)
				{
					this.siticoneButton1.Location = new Point(733, 146);
					num = 376;
				}
				if (num == 379)
				{
					this.siticoneButton1.TabIndex = 348;
					num = 380;
				}
				if (num == 383)
				{
					this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
					num = 384;
				}
				if (num == 387)
				{
					this.siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 388;
				}
				if (num == 391)
				{
					this.siticoneButton2.ForeColor = Color.White;
					num = 392;
				}
				if (num == 395)
				{
					this.siticoneButton2.Name = "siticoneButton2";
					num = 396;
				}
				if (num == 400)
				{
					this.siticoneButton2.Click += this.siticoneButton2_Click;
					num = 401;
				}
				if (num == 404)
				{
					this.siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 405;
				}
				if (num == 408)
				{
					this.siticoneButton3.FillColor = Color.FromArgb(38, 38, 38);
					num = 409;
				}
				if (num == 412)
				{
					this.siticoneButton3.ImageSize = new Size(30, 30);
					num = 413;
				}
				if (num == 416)
				{
					this.siticoneButton3.Size = new Size(240, 42);
					num = 417;
				}
				if (num == 420)
				{
					this.office_telemetry.AutoSize = true;
					num = 421;
				}
				if (num == 424)
				{
					this.office_telemetry.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 425;
				}
				if (num == 428)
				{
					this.office_telemetry.Name = "office_telemetry";
					num = 429;
				}
				if (num == 432)
				{
					this.office_telemetry.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 433;
				}
				if (num == 436)
				{
					this.office_telemetry.CheckedChanged += this.siticoneCheckBox1_CheckedChanged_1;
					num = 437;
				}
				if (num == 440)
				{
					base.Controls.Add(this.office_telemetry);
					num = 441;
				}
				if (num == 444)
				{
					base.Controls.Add(this.performance_tweaks_btn);
					num = 445;
				}
				if (num == 449)
				{
					base.Controls.Add(this.activate_btn);
					num = 450;
				}
				if (num == 453)
				{
					base.Controls.Add(this.brave);
					num = 454;
				}
				if (num == 457)
				{
					base.Controls.Add(this.Pause);
					num = 458;
				}
				if (num == 461)
				{
					base.Controls.Add(this.next_btn);
					num = 462;
				}
				if (num == 465)
				{
					base.Name = "one_click_opt";
					num = 466;
				}
				if (num == 469)
				{
					base.PerformLayout();
					num = 470;
				}
				if (num == 468)
				{
					base.ResumeLayout(false);
					num = 469;
				}
				if (num == 467)
				{
					base.Load += this.one_click_opt_Load;
					num = 468;
				}
				if (num == 466)
				{
					base.Size = new Size(1006, 669);
					num = 467;
				}
				if (num == 464)
				{
					base.Controls.Add(this.label1);
					num = 465;
				}
				if (num == 463)
				{
					base.Controls.Add(this.label37);
					num = 464;
				}
				if (num == 462)
				{
					base.Controls.Add(this.label2);
					num = 463;
				}
				if (num == 460)
				{
					base.Controls.Add(this.label3);
					num = 461;
				}
				if (num == 459)
				{
					base.Controls.Add(this.useless_services);
					num = 460;
				}
				if (num == 458)
				{
					base.Controls.Add(this.Tasks);
					num = 459;
				}
				if (num == 456)
				{
					base.Controls.Add(this.Disable);
					num = 457;
				}
				if (num == 455)
				{
					base.Controls.Add(this.chrome);
					num = 456;
				}
				if (num == 454)
				{
					base.Controls.Add(this.firefox);
					num = 455;
				}
				if (num == 452)
				{
					base.Controls.Add(this.steam);
					num = 453;
				}
				if (num == 451)
				{
					base.Controls.Add(this.discord);
					num = 452;
				}
				if (num == 450)
				{
					base.Controls.Add(this.nvidia);
					num = 451;
				}
				if (num == 448)
				{
					base.Controls.Add(this.disk_cleanup);
					num = 449;
				}
				if (num == 447)
				{
					base.Controls.Add(this.basic_tweaks_btn);
					num = 448;
				}
				if (num == 446)
				{
					base.Controls.Add(this.disable_def_btn);
					num = 447;
				}
				if (num == 445)
				{
					base.Controls.Add(this.debloat_btn);
					num = 446;
				}
				if (num == 443)
				{
					base.Controls.Add(this.siticoneButton1);
					num = 444;
				}
				if (num == 442)
				{
					base.Controls.Add(this.siticoneButton2);
					num = 443;
				}
				if (num == 441)
				{
					base.Controls.Add(this.siticoneButton3);
					num = 442;
				}
				if (num == 439)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 440;
				}
				if (num == 438)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 439;
				}
				if (num == 437)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 438;
				}
				if (num == 435)
				{
					this.office_telemetry.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 436;
				}
				if (num == 434)
				{
					this.office_telemetry.UncheckedState.BorderThickness = 0;
					num = 435;
				}
				if (num == 433)
				{
					this.office_telemetry.UncheckedState.BorderRadius = 0;
					num = 434;
				}
				if (num == 431)
				{
					this.office_telemetry.Text = "Disable Microsoft Office Telemetry";
					num = 432;
				}
				if (num == 430)
				{
					this.office_telemetry.TabIndex = 351;
					num = 431;
				}
				if (num == 429)
				{
					this.office_telemetry.Size = new Size(279, 29);
					num = 430;
				}
				if (num == 427)
				{
					this.office_telemetry.Location = new Point(49, 591);
					num = 428;
				}
				if (num == 426)
				{
					this.office_telemetry.ForeColor = Color.White;
					num = 427;
				}
				if (num == 425)
				{
					this.office_telemetry.Font = new Font("Josefin Sans", 12f);
					num = 426;
				}
				if (num == 423)
				{
					this.office_telemetry.CheckedState.BorderThickness = 0;
					num = 424;
				}
				if (num == 422)
				{
					this.office_telemetry.CheckedState.BorderRadius = 0;
					num = 423;
				}
				if (num == 421)
				{
					this.office_telemetry.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 422;
				}
				if (num == 419)
				{
					this.siticoneButton3.Click += this.siticoneButton3_Click;
					num = 420;
				}
				if (num == 418)
				{
					this.siticoneButton3.Text = "Enhance Privacy";
					num = 419;
				}
				if (num == 417)
				{
					this.siticoneButton3.TabIndex = 350;
					num = 418;
				}
				if (num == 415)
				{
					this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
					num = 416;
				}
				if (num == 414)
				{
					this.siticoneButton3.Name = "siticoneButton3";
					num = 415;
				}
				if (num == 413)
				{
					this.siticoneButton3.Location = new Point(33, 264);
					num = 414;
				}
				if (num == 411)
				{
					this.siticoneButton3.HoverState.Parent = this.siticoneButton3;
					num = 412;
				}
				if (num == 410)
				{
					this.siticoneButton3.ForeColor = Color.White;
					num = 411;
				}
				if (num == 409)
				{
					this.siticoneButton3.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 410;
				}
				if (num == 407)
				{
					this.siticoneButton3.DisabledState.Parent = this.siticoneButton3;
					num = 408;
				}
				if (num == 406)
				{
					this.siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 407;
				}
				if (num == 405)
				{
					this.siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 406;
				}
				if (num == 403)
				{
					this.siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
					num = 404;
				}
				if (num == 402)
				{
					this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
					num = 403;
				}
				if (num == 401)
				{
					this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
					num = 402;
				}
				if (num == 399)
				{
					this.siticoneButton2.Text = "Network Tweaks";
					num = 400;
				}
				if (num == 398)
				{
					this.siticoneButton2.TabIndex = 349;
					num = 399;
				}
				if (num == 397)
				{
					this.siticoneButton2.Size = new Size(240, 42);
					num = 398;
				}
				if (num == 396)
				{
					this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
					num = 397;
				}
				if (num == 394)
				{
					this.siticoneButton2.Location = new Point(383, 264);
					num = 395;
				}
				if (num == 393)
				{
					this.siticoneButton2.ImageSize = new Size(30, 30);
					num = 394;
				}
				if (num == 392)
				{
					this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
					num = 393;
				}
				if (num == 390)
				{
					this.siticoneButton2.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 391;
				}
				if (num == 389)
				{
					this.siticoneButton2.FillColor = Color.FromArgb(38, 38, 38);
					num = 390;
				}
				if (num == 388)
				{
					this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
					num = 389;
				}
				if (num == 386)
				{
					this.siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 387;
				}
				if (num == 385)
				{
					this.siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 386;
				}
				if (num == 384)
				{
					this.siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
					num = 385;
				}
				if (num == 382)
				{
					this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
					num = 383;
				}
				if (num == 381)
				{
					this.siticoneButton1.Click += this.siticoneButton1_Click;
					num = 382;
				}
				if (num == 380)
				{
					this.siticoneButton1.Text = "BCD Tweaks";
					num = 381;
				}
				if (num == 378)
				{
					this.siticoneButton1.Size = new Size(240, 42);
					num = 379;
				}
				if (num == 377)
				{
					this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
					num = 378;
				}
				if (num == 376)
				{
					this.siticoneButton1.Name = "siticoneButton1";
					num = 377;
				}
				if (num == 374)
				{
					this.siticoneButton1.ImageSize = new Size(30, 30);
					num = 375;
				}
				if (num == 373)
				{
					this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
					num = 374;
				}
				if (num == 372)
				{
					this.siticoneButton1.ForeColor = Color.White;
					num = 373;
				}
				if (num == 370)
				{
					this.siticoneButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 371;
				}
				if (num == 369)
				{
					this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
					num = 370;
				}
				if (num == 368)
				{
					this.siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 369;
				}
				if (num == 366)
				{
					this.siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 367;
				}
				if (num == 365)
				{
					this.siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 366;
				}
				if (num == 364)
				{
					this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
					num = 365;
				}
				if (num == 362)
				{
					this.performance_tweaks_btn.Click += this.performance_tweaks_btn_Click;
					num = 363;
				}
				if (num == 361)
				{
					this.performance_tweaks_btn.Text = "Performance Tweaks";
					num = 362;
				}
				if (num == 360)
				{
					this.performance_tweaks_btn.TabIndex = 347;
					num = 361;
				}
				if (num == 358)
				{
					this.performance_tweaks_btn.ShadowDecoration.Parent = this.performance_tweaks_btn;
					num = 359;
				}
				if (num == 357)
				{
					this.performance_tweaks_btn.Name = "performance_tweaks_btn";
					num = 358;
				}
				if (num == 356)
				{
					this.performance_tweaks_btn.Location = new Point(733, 264);
					num = 357;
				}
				if (num == 354)
				{
					this.performance_tweaks_btn.HoverState.Parent = this.performance_tweaks_btn;
					num = 355;
				}
				if (num == 353)
				{
					this.performance_tweaks_btn.ForeColor = Color.White;
					num = 354;
				}
				if (num == 352)
				{
					this.performance_tweaks_btn.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 353;
				}
				if (num == 350)
				{
					this.performance_tweaks_btn.DisabledState.Parent = this.performance_tweaks_btn;
					num = 351;
				}
				if (num == 349)
				{
					this.performance_tweaks_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 350;
				}
				if (num == 348)
				{
					this.performance_tweaks_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 349;
				}
				if (num == 347)
				{
					this.performance_tweaks_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 348;
				}
				if (num == 345)
				{
					this.performance_tweaks_btn.CustomImages.Parent = this.performance_tweaks_btn;
					num = 346;
				}
				if (num == 344)
				{
					this.performance_tweaks_btn.CheckedState.Parent = this.performance_tweaks_btn;
					num = 345;
				}
				if (num == 343)
				{
					this.debloat_btn.Click += this.debloat_btn_Click;
					num = 344;
				}
				if (num == 341)
				{
					this.debloat_btn.TabIndex = 344;
					num = 342;
				}
				if (num == 340)
				{
					this.debloat_btn.Size = new Size(240, 42);
					num = 341;
				}
				if (num == 339)
				{
					this.debloat_btn.ShadowDecoration.Parent = this.debloat_btn;
					num = 340;
				}
				if (num == 337)
				{
					this.debloat_btn.Location = new Point(733, 205);
					num = 338;
				}
				if (num == 336)
				{
					this.debloat_btn.ImageSize = new Size(30, 30);
					num = 337;
				}
				if (num == 335)
				{
					this.debloat_btn.HoverState.Parent = this.debloat_btn;
					num = 336;
				}
				if (num == 333)
				{
					this.debloat_btn.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 334;
				}
				if (num == 332)
				{
					this.debloat_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 333;
				}
				if (num == 331)
				{
					this.debloat_btn.DisabledState.Parent = this.debloat_btn;
					num = 332;
				}
				if (num == 329)
				{
					this.debloat_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 330;
				}
				if (num == 328)
				{
					this.debloat_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 329;
				}
				if (num == 327)
				{
					this.debloat_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 328;
				}
				if (num == 325)
				{
					this.debloat_btn.CheckedState.Parent = this.debloat_btn;
					num = 326;
				}
				if (num == 324)
				{
					this.disable_def_btn.Click += this.disable_def_btn_Click;
					num = 325;
				}
				if (num == 323)
				{
					this.disable_def_btn.Text = "Disable Windows Defender";
					num = 324;
				}
				if (num == 321)
				{
					this.disable_def_btn.Size = new Size(240, 42);
					num = 322;
				}
				if (num == 320)
				{
					this.disable_def_btn.ShadowDecoration.Parent = this.disable_def_btn;
					num = 321;
				}
				if (num == 319)
				{
					this.disable_def_btn.Name = "disable_def_btn";
					num = 320;
				}
				if (num == 317)
				{
					this.disable_def_btn.ImageSize = new Size(30, 30);
					num = 318;
				}
				if (num == 316)
				{
					this.disable_def_btn.HoverState.Parent = this.disable_def_btn;
					num = 317;
				}
				if (num == 315)
				{
					this.disable_def_btn.ForeColor = Color.White;
					num = 316;
				}
				if (num == 313)
				{
					this.disable_def_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 314;
				}
				if (num == 312)
				{
					this.disable_def_btn.DisabledState.Parent = this.disable_def_btn;
					num = 313;
				}
				if (num == 311)
				{
					this.disable_def_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 312;
				}
				if (num == 309)
				{
					this.disable_def_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 310;
				}
				if (num == 308)
				{
					this.disable_def_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 309;
				}
				if (num == 307)
				{
					this.disable_def_btn.CustomImages.Parent = this.disable_def_btn;
					num = 308;
				}
				if (num == 305)
				{
					this.basic_tweaks_btn.Click += this.basic_tweaks_btn_Click;
					num = 306;
				}
				if (num == 304)
				{
					this.basic_tweaks_btn.Text = "Basic Tweaks";
					num = 305;
				}
				if (num == 303)
				{
					this.basic_tweaks_btn.TabIndex = 342;
					num = 304;
				}
				if (num == 301)
				{
					this.basic_tweaks_btn.ShadowDecoration.Parent = this.basic_tweaks_btn;
					num = 302;
				}
				if (num == 300)
				{
					this.basic_tweaks_btn.Name = "basic_tweaks_btn";
					num = 301;
				}
				if (num == 299)
				{
					this.basic_tweaks_btn.Location = new Point(383, 146);
					num = 300;
				}
				if (num == 298)
				{
					this.basic_tweaks_btn.ImageSize = new Size(30, 30);
					num = 299;
				}
				if (num == 296)
				{
					this.basic_tweaks_btn.ForeColor = Color.White;
					num = 297;
				}
				if (num == 295)
				{
					this.basic_tweaks_btn.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 296;
				}
				if (num == 294)
				{
					this.basic_tweaks_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 295;
				}
				if (num == 292)
				{
					this.basic_tweaks_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 293;
				}
				if (num == 291)
				{
					this.basic_tweaks_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 292;
				}
				if (num == 290)
				{
					this.basic_tweaks_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 291;
				}
				if (num == 288)
				{
					this.basic_tweaks_btn.CustomImages.Parent = this.basic_tweaks_btn;
					num = 289;
				}
				if (num == 287)
				{
					this.basic_tweaks_btn.CheckedState.Parent = this.basic_tweaks_btn;
					num = 288;
				}
				if (num == 286)
				{
					this.disk_cleanup.Click += this.disk_cleanup_Click;
					num = 287;
				}
				if (num == 284)
				{
					this.disk_cleanup.TabIndex = 341;
					num = 285;
				}
				if (num == 283)
				{
					this.disk_cleanup.Size = new Size(240, 42);
					num = 284;
				}
				if (num == 282)
				{
					this.disk_cleanup.ShadowDecoration.Parent = this.disk_cleanup;
					num = 283;
				}
				if (num == 280)
				{
					this.disk_cleanup.Location = new Point(33, 205);
					num = 281;
				}
				if (num == 279)
				{
					this.disk_cleanup.ImageSize = new Size(30, 30);
					num = 280;
				}
				if (num == 278)
				{
					this.disk_cleanup.HoverState.Parent = this.disk_cleanup;
					num = 279;
				}
				if (num == 276)
				{
					this.disk_cleanup.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 277;
				}
				if (num == 275)
				{
					this.disk_cleanup.FillColor = Color.FromArgb(38, 38, 38);
					num = 276;
				}
				if (num == 274)
				{
					this.disk_cleanup.DisabledState.Parent = this.disk_cleanup;
					num = 275;
				}
				if (num == 272)
				{
					this.disk_cleanup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 273;
				}
				if (num == 271)
				{
					this.disk_cleanup.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 272;
				}
				if (num == 270)
				{
					this.disk_cleanup.DisabledState.BorderColor = Color.DarkGray;
					num = 271;
				}
				if (num == 268)
				{
					this.disk_cleanup.CheckedState.Parent = this.disk_cleanup;
					num = 269;
				}
				if (num == 267)
				{
					this.activate_btn.Click += this.activate_btn_Click;
					num = 268;
				}
				if (num == 266)
				{
					this.activate_btn.Text = "Activate Windows/Office";
					num = 267;
				}
				if (num == 264)
				{
					this.activate_btn.Size = new Size(240, 42);
					num = 265;
				}
				if (num == 263)
				{
					this.activate_btn.ShadowDecoration.Parent = this.activate_btn;
					num = 264;
				}
				if (num == 262)
				{
					this.activate_btn.Name = "activate_btn";
					num = 263;
				}
				if (num == 260)
				{
					this.activate_btn.ImageSize = new Size(30, 30);
					num = 261;
				}
				if (num == 259)
				{
					this.activate_btn.HoverState.Parent = this.activate_btn;
					num = 260;
				}
				if (num == 258)
				{
					this.activate_btn.ForeColor = Color.White;
					num = 259;
				}
				if (num == 256)
				{
					this.activate_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 257;
				}
				if (num == 255)
				{
					this.activate_btn.DisabledState.Parent = this.activate_btn;
					num = 256;
				}
				if (num == 254)
				{
					this.activate_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 255;
				}
				if (num == 252)
				{
					this.activate_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 253;
				}
				if (num == 251)
				{
					this.activate_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 252;
				}
				if (num == 250)
				{
					this.activate_btn.CustomImages.Parent = this.activate_btn;
					num = 251;
				}
				if (num == 249)
				{
					this.activate_btn.CheckedState.Parent = this.activate_btn;
					num = 250;
				}
				if (num == 247)
				{
					this.nvidia.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 248;
				}
				if (num == 246)
				{
					this.nvidia.UncheckedState.BorderThickness = 0;
					num = 247;
				}
				if (num == 245)
				{
					this.nvidia.UncheckedState.BorderRadius = 0;
					num = 246;
				}
				if (num == 243)
				{
					this.nvidia.Text = "Disable Nvidia Telemetry";
					num = 244;
				}
				if (num == 242)
				{
					this.nvidia.TabIndex = 337;
					num = 243;
				}
				if (num == 241)
				{
					this.nvidia.Size = new Size(209, 29);
					num = 242;
				}
				if (num == 239)
				{
					this.nvidia.Location = new Point(49, 552);
					num = 240;
				}
				if (num == 238)
				{
					this.nvidia.ForeColor = Color.White;
					num = 239;
				}
				if (num == 237)
				{
					this.nvidia.Font = new Font("Josefin Sans", 12f);
					num = 238;
				}
				if (num == 235)
				{
					this.nvidia.CheckedState.BorderThickness = 0;
					num = 236;
				}
				if (num == 234)
				{
					this.nvidia.CheckedState.BorderRadius = 0;
					num = 235;
				}
				if (num == 233)
				{
					this.nvidia.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 234;
				}
				if (num == 231)
				{
					this.steam.CheckedChanged += this.steam_CheckedChanged;
					num = 232;
				}
				if (num == 230)
				{
					this.steam.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 231;
				}
				if (num == 229)
				{
					this.steam.UncheckedState.BorderThickness = 0;
					num = 230;
				}
				if (num == 227)
				{
					this.steam.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 228;
				}
				if (num == 226)
				{
					this.steam.Text = "Optimize Steam";
					num = 227;
				}
				if (num == 225)
				{
					this.steam.TabIndex = 335;
					num = 226;
				}
				if (num == 223)
				{
					this.steam.Name = "steam";
					num = 224;
				}
				if (num == 222)
				{
					this.steam.Location = new Point(539, 513);
					num = 223;
				}
				if (num == 221)
				{
					this.steam.ForeColor = Color.White;
					num = 222;
				}
				if (num == 219)
				{
					this.steam.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 220;
				}
				if (num == 218)
				{
					this.steam.CheckedState.BorderThickness = 0;
					num = 219;
				}
				if (num == 217)
				{
					this.steam.CheckedState.BorderRadius = 0;
					num = 218;
				}
				if (num == 215)
				{
					this.steam.AutoSize = true;
					num = 216;
				}
				if (num == 214)
				{
					this.discord.CheckedChanged += this.discord_CheckedChanged;
					num = 215;
				}
				if (num == 213)
				{
					this.discord.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 214;
				}
				if (num == 211)
				{
					this.discord.UncheckedState.BorderRadius = 0;
					num = 212;
				}
				if (num == 210)
				{
					this.discord.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 211;
				}
				if (num == 209)
				{
					this.discord.Text = "Optimize Discord";
					num = 210;
				}
				if (num == 207)
				{
					this.discord.Size = new Size(155, 29);
					num = 208;
				}
				if (num == 206)
				{
					this.discord.Name = "discord";
					num = 207;
				}
				if (num == 205)
				{
					this.discord.Location = new Point(539, 552);
					num = 206;
				}
				if (num == 203)
				{
					this.discord.Font = new Font("Josefin Sans", 12f);
					num = 204;
				}
				if (num == 202)
				{
					this.discord.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 203;
				}
				if (num == 201)
				{
					this.discord.CheckedState.BorderThickness = 0;
					num = 202;
				}
				if (num == 199)
				{
					this.discord.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 200;
				}
				if (num == 198)
				{
					this.discord.AutoSize = true;
					num = 199;
				}
				if (num == 197)
				{
					this.brave.CheckedChanged += this.brave_CheckedChanged;
					num = 198;
				}
				if (num == 196)
				{
					this.brave.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 197;
				}
				if (num == 194)
				{
					this.brave.UncheckedState.BorderRadius = 0;
					num = 195;
				}
				if (num == 193)
				{
					this.brave.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 194;
				}
				if (num == 192)
				{
					this.brave.Text = "Optimize Brave";
					num = 193;
				}
				if (num == 190)
				{
					this.brave.Size = new Size(142, 29);
					num = 191;
				}
				if (num == 189)
				{
					this.brave.Name = "brave";
					num = 190;
				}
				if (num == 188)
				{
					this.brave.Location = new Point(539, 474);
					num = 189;
				}
				if (num == 186)
				{
					this.brave.Font = new Font("Josefin Sans", 12f);
					num = 187;
				}
				if (num == 185)
				{
					this.brave.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 186;
				}
				if (num == 184)
				{
					this.brave.CheckedState.BorderThickness = 0;
					num = 185;
				}
				if (num == 182)
				{
					this.brave.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 183;
				}
				if (num == 181)
				{
					this.brave.AutoSize = true;
					num = 182;
				}
				if (num == 180)
				{
					this.firefox.CheckedChanged += this.firefox_CheckedChanged;
					num = 181;
				}
				if (num == 178)
				{
					this.firefox.UncheckedState.BorderThickness = 0;
					num = 179;
				}
				if (num == 177)
				{
					this.firefox.UncheckedState.BorderRadius = 0;
					num = 178;
				}
				if (num == 176)
				{
					this.firefox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 177;
				}
				if (num == 174)
				{
					this.firefox.TabIndex = 333;
					num = 175;
				}
				if (num == 173)
				{
					this.firefox.Size = new Size(150, 29);
					num = 174;
				}
				if (num == 172)
				{
					this.firefox.Name = "firefox";
					num = 173;
				}
				if (num == 170)
				{
					this.firefox.ForeColor = Color.White;
					num = 171;
				}
				if (num == 169)
				{
					this.firefox.Font = new Font("Josefin Sans", 12f);
					num = 170;
				}
				if (num == 168)
				{
					this.firefox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 169;
				}
				if (num == 166)
				{
					this.firefox.CheckedState.BorderRadius = 0;
					num = 167;
				}
				if (num == 165)
				{
					this.firefox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 166;
				}
				if (num == 164)
				{
					this.firefox.AutoSize = true;
					num = 165;
				}
				if (num == 162)
				{
					this.chrome.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 163;
				}
				if (num == 161)
				{
					this.chrome.UncheckedState.BorderThickness = 0;
					num = 162;
				}
				if (num == 160)
				{
					this.chrome.UncheckedState.BorderRadius = 0;
					num = 161;
				}
				if (num == 158)
				{
					this.chrome.Text = "Optimize Chrome";
					num = 159;
				}
				if (num == 157)
				{
					this.chrome.TabIndex = 332;
					num = 158;
				}
				if (num == 156)
				{
					this.chrome.Size = new Size(157, 29);
					num = 157;
				}
				if (num == 154)
				{
					this.chrome.Location = new Point(539, 396);
					num = 155;
				}
				if (num == 153)
				{
					this.chrome.ForeColor = Color.White;
					num = 154;
				}
				if (num == 152)
				{
					this.chrome.Font = new Font("Josefin Sans", 12f);
					num = 153;
				}
				if (num == 150)
				{
					this.chrome.CheckedState.BorderThickness = 0;
					num = 151;
				}
				if (num == 149)
				{
					this.chrome.CheckedState.BorderRadius = 0;
					num = 150;
				}
				if (num == 148)
				{
					this.chrome.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 149;
				}
				if (num == 147)
				{
					this.chrome.AutoSize = true;
					num = 148;
				}
				if (num == 145)
				{
					this.Disable.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 146;
				}
				if (num == 144)
				{
					this.Disable.UncheckedState.BorderThickness = 0;
					num = 145;
				}
				if (num == 143)
				{
					this.Disable.UncheckedState.BorderRadius = 0;
					num = 144;
				}
				if (num == 141)
				{
					this.Disable.Text = "Disable Windows Updates (Store won't work)";
					num = 142;
				}
				if (num == 140)
				{
					this.Disable.TabIndex = 331;
					num = 141;
				}
				if (num == 139)
				{
					this.Disable.Size = new Size(356, 29);
					num = 140;
				}
				if (num == 137)
				{
					this.Disable.Location = new Point(49, 513);
					num = 138;
				}
				if (num == 136)
				{
					this.Disable.ForeColor = Color.White;
					num = 137;
				}
				if (num == 135)
				{
					this.Disable.Font = new Font("Josefin Sans", 12f);
					num = 136;
				}
				if (num == 133)
				{
					this.Disable.CheckedState.BorderThickness = 0;
					num = 134;
				}
				if (num == 132)
				{
					this.Disable.CheckedState.BorderRadius = 0;
					num = 133;
				}
				if (num == 131)
				{
					this.Disable.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 132;
				}
				if (num == 129)
				{
					this.Pause.CheckedChanged += this.Pause_CheckedChanged;
					num = 130;
				}
				if (num == 128)
				{
					this.Pause.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 129;
				}
				if (num == 127)
				{
					this.Pause.UncheckedState.BorderThickness = 0;
					num = 128;
				}
				if (num == 125)
				{
					this.Pause.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 126;
				}
				if (num == 124)
				{
					this.Pause.Text = "Disable Windows Updates";
					num = 125;
				}
				if (num == 123)
				{
					this.Pause.TabIndex = 330;
					num = 124;
				}
				if (num == 121)
				{
					this.Pause.Name = "Pause";
					num = 122;
				}
				if (num == 120)
				{
					this.Pause.Location = new Point(49, 474);
					num = 121;
				}
				if (num == 119)
				{
					this.Pause.ForeColor = Color.White;
					num = 120;
				}
				if (num == 117)
				{
					this.Pause.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 118;
				}
				if (num == 116)
				{
					this.Pause.CheckedState.BorderThickness = 0;
					num = 117;
				}
				if (num == 115)
				{
					this.Pause.CheckedState.BorderRadius = 0;
					num = 116;
				}
				if (num == 113)
				{
					this.Pause.AutoSize = true;
					num = 114;
				}
				if (num == 112)
				{
					this.Tasks.CheckedChanged += this.Tasks_CheckedChanged;
					num = 113;
				}
				if (num == 111)
				{
					this.Tasks.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 112;
				}
				if (num == 109)
				{
					this.Tasks.UncheckedState.BorderRadius = 0;
					num = 110;
				}
				if (num == 108)
				{
					this.Tasks.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 109;
				}
				if (num == 107)
				{
					this.Tasks.Text = "Disable Useless Scheduled Tasks";
					num = 108;
				}
				if (num == 105)
				{
					this.Tasks.Size = new Size(262, 29);
					num = 106;
				}
				if (num == 104)
				{
					this.Tasks.Name = "Tasks";
					num = 105;
				}
				if (num == 103)
				{
					this.Tasks.Location = new Point(49, 435);
					num = 104;
				}
				if (num == 101)
				{
					this.Tasks.Font = new Font("Josefin Sans", 12f);
					num = 102;
				}
				if (num == 100)
				{
					this.Tasks.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 101;
				}
				if (num == 99)
				{
					this.Tasks.CheckedState.BorderThickness = 0;
					num = 100;
				}
				if (num == 98)
				{
					this.Tasks.CheckedState.BorderRadius = 0;
					num = 99;
				}
				if (num == 96)
				{
					this.Tasks.AutoSize = true;
					num = 97;
				}
				if (num == 95)
				{
					this.useless_services.CheckedChanged += this.siticoneCheckBox1_CheckedChanged;
					num = 96;
				}
				if (num == 94)
				{
					this.useless_services.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 95;
				}
				if (num == 92)
				{
					this.useless_services.UncheckedState.BorderRadius = 0;
					num = 93;
				}
				if (num == 91)
				{
					this.useless_services.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 92;
				}
				if (num == 90)
				{
					this.useless_services.Text = "Disable Useless Services";
					num = 91;
				}
				if (num == 88)
				{
					this.useless_services.Size = new Size(204, 29);
					num = 89;
				}
				if (num == 87)
				{
					this.useless_services.Name = "useless_services";
					num = 88;
				}
				if (num == 86)
				{
					this.useless_services.Location = new Point(49, 396);
					num = 87;
				}
				if (num == 84)
				{
					this.useless_services.Font = new Font("Josefin Sans", 12f);
					num = 85;
				}
				if (num == 83)
				{
					this.useless_services.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 84;
				}
				if (num == 82)
				{
					this.useless_services.CheckedState.BorderThickness = 0;
					num = 83;
				}
				if (num == 80)
				{
					this.useless_services.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 81;
				}
				if (num == 79)
				{
					this.useless_services.AutoSize = true;
					num = 80;
				}
				if (num == 78)
				{
					this.label3.Text = "Miscellaneous";
					num = 79;
				}
				if (num == 76)
				{
					this.label3.Size = new Size(135, 30);
					num = 77;
				}
				if (num == 75)
				{
					this.label3.Name = "label3";
					num = 76;
				}
				if (num == 74)
				{
					this.label3.Location = new Point(22, 348);
					num = 75;
				}
				if (num == 72)
				{
					this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 73;
				}
				if (num == 71)
				{
					this.label3.AutoSize = true;
					num = 72;
				}
				if (num == 70)
				{
					this.next_btn.Click += this.next_btn_Click;
					num = 71;
				}
				if (num == 68)
				{
					this.next_btn.TabIndex = 326;
					num = 69;
				}
				if (num == 67)
				{
					this.next_btn.Size = new Size(88, 30);
					num = 68;
				}
				if (num == 66)
				{
					this.next_btn.ShadowDecoration.Parent = this.next_btn;
					num = 67;
				}
				if (num == 64)
				{
					this.next_btn.Location = new Point(876, 53);
					num = 65;
				}
				if (num == 63)
				{
					this.next_btn.HoverState.Parent = this.next_btn;
					num = 64;
				}
				if (num == 62)
				{
					this.next_btn.ForeColor = Color.White;
					num = 63;
				}
				if (num == 60)
				{
					this.next_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 61;
				}
				if (num == 59)
				{
					this.next_btn.DisabledState.Parent = this.next_btn;
					num = 60;
				}
				if (num == 58)
				{
					this.next_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 59;
				}
				if (num == 56)
				{
					this.next_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 57;
				}
				if (num == 55)
				{
					this.next_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 56;
				}
				if (num == 54)
				{
					this.next_btn.CustomImages.Parent = this.next_btn;
					num = 55;
				}
				if (num == 52)
				{
					this.next_btn.BorderRadius = 14;
					num = 53;
				}
				if (num == 51)
				{
					this.next_btn.BackColor = Color.Transparent;
					num = 52;
				}
				if (num == 50)
				{
					this.label2.Text = "One - Click Optimizer";
					num = 51;
				}
				if (num == 49)
				{
					this.label2.TabIndex = 115;
					num = 50;
				}
				if (num == 47)
				{
					this.label2.Name = "label2";
					num = 48;
				}
				if (num == 46)
				{
					this.label2.Location = new Point(22, 92);
					num = 47;
				}
				if (num == 45)
				{
					this.label2.ForeColor = Color.White;
					num = 46;
				}
				if (num == 43)
				{
					this.label2.AutoSize = true;
					num = 44;
				}
				if (num == 42)
				{
					this.label1.Text = "Expert Tweaks";
					num = 43;
				}
				if (num == 41)
				{
					this.label1.TabIndex = 113;
					num = 42;
				}
				if (num == 39)
				{
					this.label1.Name = "label1";
					num = 40;
				}
				if (num == 38)
				{
					this.label1.Location = new Point(18, 0);
					num = 39;
				}
				if (num == 37)
				{
					this.label1.ForeColor = Color.White;
					num = 38;
				}
				if (num == 35)
				{
					this.label1.AutoSize = true;
					num = 36;
				}
				if (num == 34)
				{
					this.label37.Text = "One-Click Optimizer for newbies";
					num = 35;
				}
				if (num == 33)
				{
					this.label37.TabIndex = 114;
					num = 34;
				}
				if (num == 31)
				{
					this.label37.Name = "label37";
					num = 32;
				}
				if (num == 30)
				{
					this.label37.Location = new Point(23, 53);
					num = 31;
				}
				if (num == 29)
				{
					this.label37.ForeColor = Color.Silver;
					num = 30;
				}
				if (num == 27)
				{
					this.label37.AutoSize = true;
					num = 28;
				}
				if (num == 26)
				{
					base.SuspendLayout();
					num = 27;
				}
				if (num == 25)
				{
					this.office_telemetry = new SiticoneCheckBox();
					num = 26;
				}
				if (num == 23)
				{
					this.siticoneButton2 = new SiticoneButton();
					num = 24;
				}
				if (num == 22)
				{
					this.siticoneButton1 = new SiticoneButton();
					num = 23;
				}
				if (num == 21)
				{
					this.performance_tweaks_btn = new SiticoneButton();
					num = 22;
				}
				if (num == 19)
				{
					this.disable_def_btn = new SiticoneButton();
					num = 20;
				}
				if (num == 18)
				{
					this.basic_tweaks_btn = new SiticoneButton();
					num = 19;
				}
				if (num == 17)
				{
					this.disk_cleanup = new SiticoneButton();
					num = 18;
				}
				if (num == 15)
				{
					this.nvidia = new SiticoneCheckBox();
					num = 16;
				}
				if (num == 14)
				{
					this.steam = new SiticoneCheckBox();
					num = 15;
				}
				if (num == 13)
				{
					this.discord = new SiticoneCheckBox();
					num = 14;
				}
				if (num == 11)
				{
					this.firefox = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 10)
				{
					this.chrome = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 9)
				{
					this.Disable = new SiticoneCheckBox();
					num = 10;
				}
				if (num == 7)
				{
					this.Tasks = new SiticoneCheckBox();
					num = 8;
				}
				if (num == 6)
				{
					this.useless_services = new SiticoneCheckBox();
					num = 7;
				}
				if (num == 5)
				{
					this.label3 = new Label();
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
			while (num != 470);
		}

		// Token: 0x040008E1 RID: 2273
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040008E2 RID: 2274
		private static one_click_opt _instace;

		// Token: 0x040008E3 RID: 2275
		private static RegistryKey CSRSS = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe\\PerfOptions");

		// Token: 0x040008E4 RID: 2276
		private static RegistryKey GameConfigStore = Registry.CurrentUser.CreateSubKey("SYSTEM\\GameConfigStore", true);

		// Token: 0x040008E5 RID: 2277
		private static RegistryKey GameBar = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\GameBar", true);

		// Token: 0x040008E6 RID: 2278
		private static RegistryKey children = Registry.CurrentUser.CreateSubKey("SYSTEM\\GameConfigStore\\Children", true);

		// Token: 0x040008E7 RID: 2279
		private static RegistryKey parents = Registry.CurrentUser.CreateSubKey("SYSTEM\\GameConfigStore\\Parents", true);

		// Token: 0x040008E8 RID: 2280
		public static Process p = new Process();

		// Token: 0x040008E9 RID: 2281
		private IContainer components = null;

		// Token: 0x040008EA RID: 2282
		private Label label37;

		// Token: 0x040008EB RID: 2283
		private Label label1;

		// Token: 0x040008EC RID: 2284
		private Label label2;

		// Token: 0x040008ED RID: 2285
		private SiticoneRoundedButton next_btn;

		// Token: 0x040008EE RID: 2286
		private Label label3;

		// Token: 0x040008EF RID: 2287
		private SiticoneCheckBox useless_services;

		// Token: 0x040008F0 RID: 2288
		private SiticoneCheckBox Tasks;

		// Token: 0x040008F1 RID: 2289
		private SiticoneCheckBox Pause;

		// Token: 0x040008F2 RID: 2290
		private SiticoneCheckBox Disable;

		// Token: 0x040008F3 RID: 2291
		private SiticoneCheckBox chrome;

		// Token: 0x040008F4 RID: 2292
		private SiticoneCheckBox firefox;

		// Token: 0x040008F5 RID: 2293
		private SiticoneCheckBox brave;

		// Token: 0x040008F6 RID: 2294
		private SiticoneCheckBox discord;

		// Token: 0x040008F7 RID: 2295
		private SiticoneCheckBox steam;

		// Token: 0x040008F8 RID: 2296
		private SiticoneCheckBox nvidia;

		// Token: 0x040008F9 RID: 2297
		private SiticoneButton activate_btn;

		// Token: 0x040008FA RID: 2298
		private SiticoneButton disk_cleanup;

		// Token: 0x040008FB RID: 2299
		private SiticoneButton basic_tweaks_btn;

		// Token: 0x040008FC RID: 2300
		private SiticoneButton disable_def_btn;

		// Token: 0x040008FD RID: 2301
		private SiticoneButton debloat_btn;

		// Token: 0x040008FE RID: 2302
		private SiticoneButton performance_tweaks_btn;

		// Token: 0x040008FF RID: 2303
		private SiticoneButton siticoneButton1;

		// Token: 0x04000900 RID: 2304
		private SiticoneButton siticoneButton2;

		// Token: 0x04000901 RID: 2305
		private SiticoneButton siticoneButton3;

		// Token: 0x04000902 RID: 2306
		private SiticoneCheckBox office_telemetry;
	}
}
