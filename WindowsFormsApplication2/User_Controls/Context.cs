using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Login_HWID;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000014 RID: 20
	public class Context : UserControl
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0001F188 File Offset: 0x0001D388
		public static Context Instance
		{
			get
			{
				if (Context._instace == null)
				{
					Context._instace = new Context();
				}
				return Context._instace;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		public Context()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0001F23C File Offset: 0x0001D43C
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				object obj;
				if (num == 3)
				{
					object value;
					obj = value;
					num = 4;
				}
				if (num != 7)
				{
					goto IL_34;
				}
				string text;
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_34;
				}
				goto IL_41;
				IL_53:
				if (num == 15)
				{
					goto IL_111;
				}
				IL_123:
				if (num == 17)
				{
					break;
				}
				if (num != 16 && num != 14)
				{
					if (num == 13)
					{
						goto IL_EC;
					}
					IL_FE:
					if (num == 12)
					{
						break;
					}
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
					if (num == 8)
					{
						if (text == "Halloween")
						{
							goto IL_EC;
						}
						num = 9;
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
						object obj2;
						text = obj2 as string;
						num = 6;
					}
					if (num == 4)
					{
						object obj2 = obj;
						num = 5;
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
					this.Halloween();
					num = 14;
					goto IL_FE;
				}
				break;
				IL_111:
				this.AccentColor();
				num = 16;
				goto IL_123;
				IL_34:
				if (num != 11)
				{
					goto IL_53;
				}
				IL_41:
				this.Xmas_theme();
				num = 12;
				goto IL_53;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0001F488 File Offset: 0x0001D688
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

		// Token: 0x060000B3 RID: 179 RVA: 0x0001F500 File Offset: 0x0001D700
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

		// Token: 0x060000B4 RID: 180 RVA: 0x0001F564 File Offset: 0x0001D764
		private void Halloween()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.tabPage3.Controls.OfType<CheckBox>().GetEnumerator();
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
			this.siticoneTabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(255, 125, 0);
			this.siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(255, 125, 0);
			this.checkDefaultIcon.CheckedState.FillColor = Color.FromArgb(255, 125, 0);
			this.checkDefaultIcon.CheckedState.BorderColor = Color.FromArgb(255, 125, 0);
			this.checkShift.CheckedState.FillColor = Color.FromArgb(255, 125, 0);
			this.checkShift.CheckedState.BorderColor = Color.FromArgb(255, 125, 0);
			this.refresh_list.FillColor = Color.FromArgb(255, 125, 0);
			this.delete.FillColor = Color.FromArgb(255, 125, 0);
			this.del_all.FillColor = Color.FromArgb(255, 125, 0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001F784 File Offset: 0x0001D984
		private void AccentColor()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			Color accentColor;
			do
			{
				if (num == 2)
				{
					enumerator = this.tabPage3.Controls.OfType<CheckBox>().GetEnumerator();
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
			this.siticoneTabControl1.TabButtonSelectedState.FillColor = accentColor;
			this.siticoneTabControl1.TabButtonSelectedState.InnerColor = accentColor;
			this.checkDefaultIcon.CheckedState.FillColor = accentColor;
			this.checkDefaultIcon.CheckedState.BorderColor = accentColor;
			this.checkShift.CheckedState.FillColor = accentColor;
			this.checkShift.CheckedState.BorderColor = accentColor;
			this.refresh_list.FillColor = accentColor;
			this.delete.FillColor = accentColor;
			this.del_all.FillColor = accentColor;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001F93C File Offset: 0x0001DB3C
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.tabPage3.Controls.OfType<CheckBox>().GetEnumerator();
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
			this.siticoneTabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 158, 255);
			this.siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(29, 158, 255);
			this.checkDefaultIcon.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
			this.checkDefaultIcon.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
			this.checkShift.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
			this.checkShift.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
			this.refresh_list.FillColor = Color.FromArgb(29, 158, 255);
			this.delete.FillColor = Color.FromArgb(29, 158, 255);
			this.del_all.FillColor = Color.FromArgb(29, 158, 255);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		private void GetDesktopItems()
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					num = 4;
				}
				if (num != 7)
				{
					goto IL_21;
				}
				bool flag;
				if (flag)
				{
					num = 8;
					goto IL_21;
				}
				goto IL_12C;
				IL_107:
				if (num == 5)
				{
					goto IL_111;
				}
				int num2;
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num == 2)
				{
					this.ctxt_menu.Items.Clear();
					num = 3;
				}
				if (num == 1)
				{
					this._desktopItems = context_class.GetDesktopItems();
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
				IL_A6:
				if (num == 8)
				{
					this.ctxt_menu.Items.Add(this._desktopItems[num2]);
					num = 9;
				}
				if (num == 6)
				{
					goto IL_E4;
				}
				goto IL_107;
				IL_12C:
				num2++;
				num = 10;
				goto IL_A6;
				IL_E4:
				flag = !string.IsNullOrEmpty(this._desktopItems[num2]);
				num = 7;
				goto IL_107;
				IL_21:
				bool flag2;
				if (num == 11)
				{
					if (flag2)
					{
						goto IL_E4;
					}
					num = 12;
				}
				if (num == 14)
				{
					this.ctxt_menu.SelectedIndex = 0;
					num = 15;
				}
				if (num == 13)
				{
					bool flag3;
					if (!flag3)
					{
						break;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag3 = this._desktopItems.Count > 0;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_111;
				}
				IL_141:
				if (num == 9)
				{
					goto IL_12C;
				}
				goto IL_A6;
				IL_111:
				flag2 = num2 < this._desktopItems.Count;
				num = 11;
				goto IL_141;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0001FD48 File Offset: 0x0001DF48
		private void check_context()
		{
			int num = 0;
			for (;;)
			{
				if (num != 3)
				{
					goto IL_0B;
				}
				bool flag;
				if (flag)
				{
					num = 4;
					goto IL_0B;
				}
				goto IL_D9A;
				IL_DB0:
				RegistryKey registryKey;
				if (num == 5)
				{
					registryKey.Close();
					num = 6;
				}
				if (num == 4)
				{
					this.adv_startup.Checked = true;
					num = 5;
				}
				if (num == 2)
				{
					flag = registryKey != null;
					num = 3;
				}
				if (num == 1)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\AdvancedBootOptions");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 129)
				{
					break;
				}
				continue;
				IL_D9A:
				RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\AppMode");
				num = 7;
				goto IL_DB0;
				IL_0B:
				bool flag2;
				if (num == 7)
				{
					flag2 = registryKey2 != null;
					num = 8;
				}
				if (num == 11)
				{
					goto IL_D54;
				}
				IL_D6B:
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					this.clip.Checked = true;
					num = 20;
				}
				RegistryKey registryKey4;
				bool flag3;
				if (num == 22)
				{
					flag3 = registryKey4 != null;
					num = 23;
				}
				if (num == 26)
				{
					goto IL_BF6;
				}
				IL_C0D:
				RegistryKey registryKey5;
				if (num == 30)
				{
					registryKey5.Close();
					num = 31;
				}
				if (num == 34)
				{
					this.compact.Checked = true;
					num = 35;
				}
				if (num != 38)
				{
					goto IL_B7;
				}
				bool flag4;
				if (flag4)
				{
					num = 39;
					goto IL_B7;
				}
				goto IL_C1;
				IL_D8:
				RegistryKey registryKey6;
				if (num == 45)
				{
					registryKey6.Close();
					num = 46;
				}
				if (num == 49)
				{
					this.kill.Checked = true;
					num = 50;
				}
				if (num != 53)
				{
					goto IL_129;
				}
				bool flag5;
				if (flag5)
				{
					num = 54;
					goto IL_129;
				}
				goto IL_939;
				IL_950:
				RegistryKey registryKey7;
				if (num == 55)
				{
					registryKey7.Close();
					num = 56;
				}
				if (num == 54)
				{
					this.openwith_nat.Checked = true;
					num = 55;
				}
				if (num == 52)
				{
					flag5 = registryKey7 != null;
					num = 53;
				}
				if (num == 51)
				{
					goto IL_9BC;
				}
				IL_9D3:
				RegistryKey registryKey8;
				if (num == 50)
				{
					registryKey8.Close();
					num = 51;
				}
				if (num == 48)
				{
					bool flag6;
					if (!flag6)
					{
						goto IL_9BC;
					}
					num = 49;
				}
				if (num == 47)
				{
					bool flag6 = registryKey8 != null;
					num = 48;
				}
				if (num == 46)
				{
					goto IL_A24;
				}
				IL_A3F:
				if (num == 44)
				{
					this.hash.Checked = true;
					num = 45;
				}
				if (num == 43)
				{
					bool flag7;
					if (!flag7)
					{
						goto IL_A24;
					}
					num = 44;
				}
				if (num == 42)
				{
					bool flag7 = registryKey6 != null;
					num = 43;
				}
				RegistryKey registryKey9;
				if (num == 40)
				{
					registryKey9.Close();
					num = 41;
				}
				if (num == 39)
				{
					this.control_pnl.Checked = true;
					num = 40;
				}
				if (num == 37)
				{
					flag4 = registryKey9 != null;
					num = 38;
				}
				if (num == 36)
				{
					goto IL_AED;
				}
				IL_B04:
				RegistryKey registryKey10;
				if (num == 35)
				{
					registryKey10.Close();
					num = 36;
				}
				if (num == 33)
				{
					bool flag8;
					if (!flag8)
					{
						goto IL_AED;
					}
					num = 34;
				}
				if (num == 32)
				{
					bool flag8 = registryKey10 != null;
					num = 33;
				}
				if (num == 31)
				{
					goto IL_B55;
				}
				IL_B6C:
				if (num == 29)
				{
					this.cmd_ctxt_admin.Checked = true;
					num = 30;
				}
				if (num == 28)
				{
					bool flag9;
					if (!flag9)
					{
						goto IL_B55;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag9 = registryKey5 != null;
					num = 28;
				}
				if (num == 25)
				{
					registryKey4.Close();
					num = 26;
				}
				if (num == 24)
				{
					this.cmd_ctxt.Checked = true;
					num = 25;
				}
				if (num == 23)
				{
					if (!flag3)
					{
						goto IL_BF6;
					}
					num = 24;
				}
				if (num == 21)
				{
					goto IL_C4D;
				}
				IL_C64:
				RegistryKey registryKey11;
				if (num == 20)
				{
					registryKey11.Close();
					num = 21;
				}
				if (num == 18)
				{
					bool flag10;
					if (!flag10)
					{
						goto IL_C4D;
					}
					num = 19;
				}
				if (num == 17)
				{
					bool flag10 = registryKey11 != null;
					num = 18;
				}
				if (num == 16)
				{
					goto IL_CB5;
				}
				IL_CCC:
				if (num == 14)
				{
					this.bt.Checked = true;
					num = 15;
				}
				if (num == 13)
				{
					bool flag11;
					if (!flag11)
					{
						goto IL_CB5;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag11 = registryKey3 != null;
					num = 13;
				}
				if (num == 10)
				{
					registryKey2.Close();
					num = 11;
				}
				if (num == 9)
				{
					this.app_mode.Checked = true;
					num = 10;
				}
				if (num == 8)
				{
					if (!flag2)
					{
						goto IL_D54;
					}
					num = 9;
				}
				if (num == 6)
				{
					goto IL_D9A;
				}
				goto IL_DB0;
				IL_CB5:
				registryKey11 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\ClipboardHistory");
				num = 17;
				goto IL_CCC;
				IL_C4D:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("LibraryFolder\\shell\\cmd2");
				num = 22;
				goto IL_C64;
				IL_B55:
				registryKey10 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\CompactOS");
				num = 32;
				goto IL_B6C;
				IL_AED:
				registryKey9 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\ControlPanel");
				num = 37;
				goto IL_B04;
				IL_A24:
				registryKey8 = Registry.ClassesRoot.OpenSubKey(this.REG_KILL_PATH);
				num = 47;
				goto IL_A3F;
				IL_9BC:
				registryKey7 = Registry.ClassesRoot.OpenSubKey("batfile\\shell\\Open with\\command");
				num = 52;
				goto IL_9D3;
				IL_939:
				RegistryKey registryKey12 = Registry.ClassesRoot.OpenSubKey("Directory\\Background\\Shell\\OpenElevatedPS");
				num = 57;
				goto IL_950;
				IL_129:
				bool flag12;
				if (num == 57)
				{
					flag12 = registryKey12 != null;
					num = 58;
				}
				if (num == 60)
				{
					registryKey12.Close();
					num = 61;
				}
				if (num == 64)
				{
					this.res_explorer.Checked = true;
					num = 65;
				}
				if (num != 68)
				{
					goto IL_191;
				}
				bool flag13;
				if (flag13)
				{
					num = 69;
					goto IL_191;
				}
				goto IL_802;
				IL_819:
				RegistryKey registryKey13;
				if (num == 70)
				{
					registryKey13.Close();
					num = 71;
				}
				if (num == 69)
				{
					this.res_startmenu.Checked = true;
					num = 70;
				}
				if (num == 67)
				{
					flag13 = registryKey13 != null;
					num = 68;
				}
				if (num == 66)
				{
					goto IL_885;
				}
				IL_89C:
				RegistryKey registryKey14;
				if (num == 65)
				{
					registryKey14.Close();
					num = 66;
				}
				if (num == 63)
				{
					bool flag14;
					if (!flag14)
					{
						goto IL_885;
					}
					num = 64;
				}
				if (num == 62)
				{
					bool flag14 = registryKey14 != null;
					num = 63;
				}
				if (num == 61)
				{
					goto IL_8ED;
				}
				IL_904:
				if (num == 59)
				{
					this.powershell_admin.Checked = true;
					num = 60;
				}
				if (num == 58)
				{
					if (!flag12)
					{
						goto IL_8ED;
					}
					num = 59;
				}
				if (num == 56)
				{
					goto IL_939;
				}
				goto IL_950;
				IL_8ED:
				registryKey14 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\RestartExplorer");
				num = 62;
				goto IL_904;
				IL_885:
				registryKey13 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\RestartStartMenu");
				num = 67;
				goto IL_89C;
				IL_802:
				RegistryKey registryKey15 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell\\ScreenSnip\\command");
				num = 72;
				goto IL_819;
				IL_191:
				bool flag15;
				if (num == 72)
				{
					flag15 = registryKey15 != null;
					num = 73;
				}
				if (num == 76)
				{
					goto IL_7BC;
				}
				IL_7D3:
				RegistryKey registryKey16;
				if (num == 80)
				{
					registryKey16.Close();
					num = 81;
				}
				if (num != 83)
				{
					goto IL_1D2;
				}
				bool flag16;
				if (flag16)
				{
					num = 84;
					goto IL_1D2;
				}
				goto IL_698;
				IL_6AF:
				RegistryKey registryKey17;
				if (num == 85)
				{
					registryKey17.Close();
					num = 86;
				}
				if (num == 84)
				{
					this.taskmgr.Checked = true;
					num = 85;
				}
				if (num == 82)
				{
					flag16 = registryKey17 != null;
					num = 83;
				}
				if (num == 81)
				{
					goto IL_71B;
				}
				IL_732:
				if (num == 79)
				{
					this.takeown.Checked = true;
					num = 80;
				}
				if (num == 78)
				{
					bool flag17;
					if (!flag17)
					{
						goto IL_71B;
					}
					num = 79;
				}
				if (num == 77)
				{
					bool flag17 = registryKey16 != null;
					num = 78;
				}
				if (num == 75)
				{
					registryKey15.Close();
					num = 76;
				}
				if (num == 74)
				{
					this.snip.Checked = true;
					num = 75;
				}
				if (num == 73)
				{
					if (!flag15)
					{
						goto IL_7BC;
					}
					num = 74;
				}
				if (num == 71)
				{
					goto IL_802;
				}
				goto IL_819;
				IL_71B:
				registryKey17 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\taskmgr");
				num = 82;
				goto IL_732;
				IL_698:
				RegistryKey registryKey18 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\WindowsMode");
				num = 87;
				goto IL_6AF;
				IL_1D2:
				bool flag18;
				if (num == 87)
				{
					flag18 = registryKey18 != null;
					num = 88;
				}
				if (num == 91)
				{
					goto IL_64E;
				}
				IL_669:
				RegistryKey registryKey19;
				if (num == 95)
				{
					registryKey19.Close();
					num = 96;
				}
				if (num == 99)
				{
					this.settings.Checked = true;
					num = 100;
				}
				RegistryKey registryKey20;
				bool flag19;
				if (num == 102)
				{
					flag19 = registryKey20 != null;
					num = 103;
				}
				if (num == 106)
				{
					goto IL_4EE;
				}
				IL_505:
				RegistryKey registryKey21;
				if (num == 110)
				{
					registryKey21.Close();
					num = 111;
				}
				if (num == 114)
				{
					this.snip_classic.Checked = true;
					num = 115;
				}
				bool flag20;
				if (num == 118)
				{
					object value;
					flag20 = value != null;
					num = 119;
				}
				if (num == 121)
				{
					goto IL_37F;
				}
				IL_393:
				if (num == 125)
				{
					goto IL_2F5;
				}
				IL_309:
				if (num == 128)
				{
					this.safe_mode.Checked = true;
					num = 129;
				}
				if (num == 127)
				{
					bool flag21;
					if (!flag21)
					{
						break;
					}
					num = 128;
				}
				object value2;
				if (num == 126)
				{
					bool flag21 = value2 != null;
					num = 127;
				}
				if (num == 124)
				{
					this.run_priority.Checked = true;
					num = 125;
				}
				if (num == 123)
				{
					bool flag22;
					if (!flag22)
					{
						goto IL_2F5;
					}
					num = 124;
				}
				object value3;
				if (num == 122)
				{
					bool flag22 = value3 != null;
					num = 123;
				}
				if (num == 120)
				{
					this.bash.Checked = true;
					num = 121;
				}
				if (num == 119)
				{
					if (!flag20)
					{
						goto IL_37F;
					}
					num = 120;
				}
				RegistryKey registryKey22;
				if (num == 117)
				{
					object value = registryKey22.GetValue("Open Bash");
					num = 118;
				}
				if (num == 116)
				{
					goto IL_3E5;
				}
				IL_3FC:
				RegistryKey registryKey23;
				if (num == 115)
				{
					registryKey23.Close();
					num = 116;
				}
				if (num == 113)
				{
					bool flag23;
					if (!flag23)
					{
						goto IL_3E5;
					}
					num = 114;
				}
				if (num == 112)
				{
					bool flag23 = registryKey23 != null;
					num = 113;
				}
				if (num == 111)
				{
					goto IL_44D;
				}
				IL_464:
				if (num == 109)
				{
					this.shutdown.Checked = true;
					num = 110;
				}
				if (num == 108)
				{
					bool flag24;
					if (!flag24)
					{
						goto IL_44D;
					}
					num = 109;
				}
				if (num == 107)
				{
					bool flag24 = registryKey21 != null;
					num = 108;
				}
				if (num == 105)
				{
					registryKey20.Close();
					num = 106;
				}
				if (num == 104)
				{
					this.sfc.Checked = true;
					num = 105;
				}
				if (num == 103)
				{
					if (!flag19)
					{
						goto IL_4EE;
					}
					num = 104;
				}
				if (num == 101)
				{
					goto IL_545;
				}
				IL_55C:
				RegistryKey registryKey24;
				if (num == 100)
				{
					registryKey24.Close();
					num = 101;
				}
				if (num == 98)
				{
					bool flag25;
					if (!flag25)
					{
						goto IL_545;
					}
					num = 99;
				}
				if (num == 97)
				{
					bool flag25 = registryKey24 != null;
					num = 98;
				}
				if (num == 96)
				{
					goto IL_5AD;
				}
				IL_5C4:
				if (num == 94)
				{
					this.win_tools.Checked = true;
					num = 95;
				}
				if (num == 93)
				{
					bool flag26;
					if (!flag26)
					{
						goto IL_5AD;
					}
					num = 94;
				}
				if (num == 92)
				{
					bool flag26 = registryKey19 != null;
					num = 93;
				}
				if (num == 90)
				{
					registryKey18.Close();
					num = 91;
				}
				if (num == 89)
				{
					this.win_mode.Checked = true;
					num = 90;
				}
				if (num == 88)
				{
					if (!flag18)
					{
						goto IL_64E;
					}
					num = 89;
				}
				if (num == 86)
				{
					goto IL_698;
				}
				goto IL_6AF;
				IL_5AD:
				registryKey24 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\Settings");
				num = 97;
				goto IL_5C4;
				IL_545:
				registryKey20 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\SFCScannow");
				num = 102;
				goto IL_55C;
				IL_44D:
				registryKey23 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\SnippingTool");
				num = 112;
				goto IL_464;
				IL_3E5:
				registryKey22 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit\\Context Menu");
				num = 117;
				goto IL_3FC;
				IL_2F5:
				value2 = registryKey22.GetValue("Safe Mode");
				num = 126;
				goto IL_309;
				IL_37F:
				value3 = registryKey22.GetValue("Run Priority");
				num = 122;
				goto IL_393;
				IL_4EE:
				registryKey21 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\ShutDown");
				num = 107;
				goto IL_505;
				IL_64E:
				registryKey19 = Registry.ClassesRoot.OpenSubKey(this.REG_BASE_PATH);
				num = 92;
				goto IL_669;
				IL_7BC:
				registryKey16 = Registry.ClassesRoot.OpenSubKey("*\\shell\\TakeOwnership");
				num = 77;
				goto IL_7D3;
				IL_C1:
				registryKey6 = Registry.ClassesRoot.OpenSubKey("*\\shell\\Hash");
				num = 42;
				goto IL_D8;
				IL_B7:
				if (num == 41)
				{
					goto IL_C1;
				}
				goto IL_D8;
				IL_BF6:
				registryKey5 = Registry.ClassesRoot.OpenSubKey("Directory\\Background\\Shell\\OpenElevatedCmd");
				num = 27;
				goto IL_C0D;
				IL_D54:
				registryKey3 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell\\Bluetooth");
				num = 12;
				goto IL_D6B;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		private void context_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.icon_browse.Enabled = false;
					num = 4;
				}
				if (num == 2)
				{
					this.check_context();
					num = 3;
				}
				if (num == 1)
				{
					this.GetDesktopItems();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00020C3C File Offset: 0x0001EE3C
		private void Reset()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.checkShift.Checked = false;
					num = 4;
				}
				if (num == 7)
				{
					this.to_add.Text = "http://";
					num = 8;
				}
				if (num == 6)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool @checked = this.link.Checked;
					num = 6;
				}
				if (num == 4)
				{
					this.menu_txtbox.Clear();
					num = 5;
				}
				if (num == 2)
				{
					this.icon_txtbox.Clear();
					num = 3;
				}
				if (num == 1)
				{
					this.to_add.Clear();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00020D50 File Offset: 0x0001EF50
		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.menu_txtbox.Text = this.openFileDialog1.SafeFileName.Replace(".exe", string.Empty);
					num = 3;
				}
				if (num == 1)
				{
					this.to_add.Text = this.openFileDialog1.FileName;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00020E04 File Offset: 0x0001F004
		private void file_browse_FileOk(object sender, CancelEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.menu_txtbox.Text = this.file_browse.SafeFileName;
					num = 3;
				}
				if (num == 1)
				{
					this.to_add.Text = this.file_browse.FileName;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		private void program_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.add_grpbox.Text = "Program to add";
					num = 4;
				}
				if (num == 7)
				{
					this.to_add.ReadOnly = true;
					num = 8;
				}
				if (num == 9)
				{
					this._desktopItemType = DesktopItemType.Program;
					num = 10;
				}
				if (num == 8)
				{
					this.browse.Enabled = true;
					num = 9;
				}
				if (num == 6)
				{
					this.icon_txtbox.Clear();
					num = 7;
				}
				if (num == 5)
				{
					this.to_add.Clear();
					num = 6;
				}
				if (num == 4)
				{
					this.checkDefaultIcon.Text = "Use program's default icon";
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.program.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00021000 File Offset: 0x0001F200
		private void link_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.add_grpbox.Text = "Link to add";
					num = 4;
				}
				if (num == 7)
				{
					this.browse.Enabled = false;
					num = 8;
				}
				if (num == 8)
				{
					this._desktopItemType = DesktopItemType.Link;
					num = 9;
				}
				if (num == 6)
				{
					this.to_add.ReadOnly = false;
					num = 7;
				}
				if (num == 5)
				{
					this.checkDefaultIcon.Text = "Download website's icon (favicon)";
					num = 6;
				}
				if (num == 4)
				{
					this.to_add.Text = "https://";
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.link.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0002113C File Offset: 0x0001F33C
		private void folder_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.add_grpbox.Text = "Folder to add";
					num = 4;
				}
				if (num == 7)
				{
					this.to_add.ReadOnly = true;
					num = 8;
				}
				if (num == 9)
				{
					this._desktopItemType = DesktopItemType.Folder;
					num = 10;
				}
				if (num == 8)
				{
					this.browse.Enabled = true;
					num = 9;
				}
				if (num == 6)
				{
					this.icon_txtbox.Clear();
					num = 7;
				}
				if (num == 5)
				{
					this.to_add.Clear();
					num = 6;
				}
				if (num == 4)
				{
					this.checkDefaultIcon.Text = "Use program's default icon";
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.folder.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00021294 File Offset: 0x0001F494
		private void file_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.add_grpbox.Text = "File to add";
					num = 4;
				}
				if (num == 7)
				{
					this.to_add.ReadOnly = true;
					num = 8;
				}
				if (num == 9)
				{
					this._desktopItemType = DesktopItemType.File;
					num = 10;
				}
				if (num == 8)
				{
					this.browse.Enabled = true;
					num = 9;
				}
				if (num == 6)
				{
					this.icon_txtbox.Clear();
					num = 7;
				}
				if (num == 5)
				{
					this.to_add.Clear();
					num = 6;
				}
				if (num == 4)
				{
					this.checkDefaultIcon.Text = "Use program's default icon";
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.file.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000213EC File Offset: 0x0001F5EC
		private void cmd_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.add_grpbox.Text = "Command to add";
					num = 4;
				}
				if (num == 7)
				{
					this.to_add.ReadOnly = false;
					num = 8;
				}
				if (num == 9)
				{
					this._desktopItemType = DesktopItemType.Command;
					num = 10;
				}
				if (num == 8)
				{
					this.browse.Enabled = false;
					num = 9;
				}
				if (num == 6)
				{
					this.icon_txtbox.Clear();
					num = 7;
				}
				if (num == 5)
				{
					this.to_add.Clear();
					num = 6;
				}
				if (num == 4)
				{
					this.checkDefaultIcon.Text = "Use program's default icon";
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.cmd.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00021544 File Offset: 0x0001F744
		private void position_cbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					this._desktopItemPosition = DesktopTypePosition.Top;
					num = 4;
				}
				if (num == 7)
				{
					goto IL_59;
				}
				IL_78:
				if (num == 9)
				{
					this._desktopItemPosition = DesktopTypePosition.Bottom;
					num = 10;
				}
				bool flag;
				if (num == 8)
				{
					if (!flag)
					{
						break;
					}
					num = 9;
				}
				if (num == 6)
				{
					this._desktopItemPosition = DesktopTypePosition.Middle;
					num = 7;
				}
				bool flag2;
				if (num == 5)
				{
					if (!flag2)
					{
						goto IL_59;
					}
					num = 6;
				}
				if (num == 4)
				{
					goto IL_A9;
				}
				IL_C8:
				if (num == 2)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_A9;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag3 = this.position_cbox.Text == "Top";
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
				IL_A9:
				flag2 = this.position_cbox.Text == "Middle";
				num = 5;
				goto IL_C8;
				IL_59:
				flag = this.position_cbox.Text == "Bottom";
				num = 8;
				goto IL_78;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00021698 File Offset: 0x0001F898
		private void browse_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num != 3)
				{
					goto IL_0B;
				}
				DesktopItemType desktopItemType;
				switch (desktopItemType)
				{
				case DesktopItemType.Program:
					goto IL_10C;
				case DesktopItemType.Folder:
					goto IL_15;
				case DesktopItemType.Link:
					return;
				case DesktopItemType.File:
					goto IL_4E;
				default:
					num = 4;
					goto IL_0B;
				}
				IL_121:
				if (num == 4)
				{
					break;
				}
				if (num == 2)
				{
					DesktopItemType desktopItemType2;
					desktopItemType = desktopItemType2;
					num = 3;
				}
				if (num == 1)
				{
					DesktopItemType desktopItemType2 = this._desktopItemType;
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
				IL_63:
				if (num == 10)
				{
					int num2;
					this.menu_txtbox.Text = this.folderBrowserDialog1.SelectedPath.Remove(0, num2 + 1);
					num = 11;
				}
				if (num == 9)
				{
					int num2 = this.folderBrowserDialog1.SelectedPath.LastIndexOf("\\");
					num = 10;
				}
				if (num == 8)
				{
					this.to_add.Text = this.folderBrowserDialog1.SelectedPath;
					num = 9;
				}
				if (num == 6)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_10C;
				}
				goto IL_121;
				IL_2A:
				if (num == 11 || num == 13)
				{
					break;
				}
				if (num == 12)
				{
					goto IL_4E;
				}
				goto IL_63;
				IL_0B:
				if (num == 7)
				{
					goto IL_15;
				}
				goto IL_2A;
				IL_10C:
				this.openFileDialog1.ShowDialog();
				num = 6;
				goto IL_121;
				IL_4E:
				this.file_browse.ShowDialog();
				num = 13;
				goto IL_63;
				IL_15:
				this.folderBrowserDialog1.ShowDialog();
				num = 8;
				goto IL_2A;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0002184C File Offset: 0x0001FA4C
		private void save_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					if (string.IsNullOrEmpty(this.menu_txtbox.Text))
					{
						goto IL_A6;
					}
					num = 4;
				}
				if (num == 2)
				{
					if (string.IsNullOrEmpty(this.to_add.Text))
					{
						goto IL_A6;
					}
					num = 3;
				}
				if (num == 1)
				{
					if (this.checkDefaultIcon.Checked)
					{
						goto IL_AD;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			bool flag = string.IsNullOrEmpty(this.icon_txtbox.Text);
			goto IL_B2;
			IL_A6:
			flag = true;
			goto IL_B2;
			IL_AD:
			flag = false;
			IL_B2:
			if (!flag && (!this.checkDefaultIcon.Checked || (!string.IsNullOrEmpty(this.to_add.Text) && !string.IsNullOrEmpty(this.menu_txtbox.Text))))
			{
				string text = string.Empty;
				switch (this._desktopItemType)
				{
				case DesktopItemType.Program:
					if (this.checkDefaultIcon.Checked)
					{
						text = this.to_add.Text;
					}
					else
					{
						text = this.icon_txtbox.Text;
					}
					context_class.AddItem(this.menu_txtbox.Text, this.to_add.Text, text, this._desktopItemPosition, this.checkShift.Checked, DesktopItemType.Program);
					break;
				case DesktopItemType.Folder:
					if (this.checkDefaultIcon.Checked)
					{
						text = context_class.FolderDefaultIcon;
					}
					else
					{
						text = this.icon_txtbox.Text;
					}
					context_class.AddItem(this.menu_txtbox.Text, this.to_add.Text, text, this._desktopItemPosition, this.checkShift.Checked, DesktopItemType.Folder);
					break;
				case DesktopItemType.Link:
					if (this.checkDefaultIcon.Checked)
					{
						text = context_class.DownloadFavicon(this.to_add.Text, this.menu_txtbox.Text);
					}
					else
					{
						text = this.icon_txtbox.Text;
					}
					context_class.AddItem(this.menu_txtbox.Text, this.to_add.Text, text, this._desktopItemPosition, this.checkShift.Checked, DesktopItemType.Link);
					break;
				case DesktopItemType.File:
					if (!this.checkDefaultIcon.Checked)
					{
						text = this.icon_txtbox.Text;
					}
					context_class.AddItem(this.menu_txtbox.Text, this.to_add.Text, text, this._desktopItemPosition, this.checkShift.Checked, DesktopItemType.File);
					break;
				case DesktopItemType.Command:
					if (!this.checkDefaultIcon.Checked)
					{
						text = this.icon_txtbox.Text;
					}
					context_class.AddItem(this.menu_txtbox.Text, this.to_add.Text, text, this._desktopItemPosition, this.checkShift.Checked, DesktopItemType.Command);
					break;
				}
				this.GetDesktopItems();
				this.Reset();
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00021BCC File Offset: 0x0001FDCC
		private void icon_browse_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num != 3)
				{
					goto IL_0E;
				}
				DesktopItemType desktopItemType;
				switch (desktopItemType)
				{
				case DesktopItemType.Program:
					goto IL_FF;
				case DesktopItemType.Folder:
					goto IL_1B;
				case DesktopItemType.Link:
					goto IL_BA;
				case DesktopItemType.File:
					goto IL_40;
				case DesktopItemType.Command:
					goto IL_75;
				default:
					num = 4;
					goto IL_0E;
				}
				IL_117:
				if (num == 4)
				{
					break;
				}
				if (num == 2)
				{
					DesktopItemType desktopItemType2;
					desktopItemType = desktopItemType2;
					num = 3;
				}
				if (num == 1)
				{
					DesktopItemType desktopItemType2 = this._desktopItemType;
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
				IL_D2:
				if (num == 8 || num == 6)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_FF;
				}
				goto IL_117;
				IL_8D:
				if (num == 12 || num == 10)
				{
					break;
				}
				if (num == 9)
				{
					goto IL_BA;
				}
				goto IL_D2;
				IL_58:
				if (num == 14)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_75;
				}
				goto IL_8D;
				IL_33:
				if (num == 11)
				{
					goto IL_40;
				}
				goto IL_58;
				IL_0E:
				if (num == 7)
				{
					goto IL_1B;
				}
				goto IL_33;
				IL_FF:
				this.icon_dialog.ShowDialog();
				num = 6;
				goto IL_117;
				IL_BA:
				this.icon_dialog.ShowDialog();
				num = 10;
				goto IL_D2;
				IL_75:
				this.icon_dialog.ShowDialog();
				num = 14;
				goto IL_8D;
				IL_40:
				this.icon_dialog.ShowDialog();
				num = 12;
				goto IL_58;
				IL_1B:
				this.icon_dialog.ShowDialog();
				num = 8;
				goto IL_33;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		private void icon_dialog_FileOk(object sender, CancelEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.icon_txtbox.Text = this.icon_dialog.FileName;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00021E14 File Offset: 0x00020014
		private void checkDefaultIcon_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					this.icon_browse.Enabled = false;
					num = 4;
				}
				if (num == 5)
				{
					goto IL_25;
				}
				IL_3E:
				if (num == 4)
				{
					break;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_25;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.checkDefaultIcon.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_25:
				this.icon_browse.Enabled = true;
				num = 6;
				goto IL_3E;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00021EDC File Offset: 0x000200DC
		private void refresh_list_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.check_context();
					num = 3;
				}
				if (num == 1)
				{
					this.GetDesktopItems();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00021F58 File Offset: 0x00020158
		private void delete_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					context_class.RemoveItem(this.ctxt_menu.SelectedItem.ToString());
					num = 4;
				}
				if (num == 5)
				{
					this.check_context();
					num = 6;
				}
				if (num == 4)
				{
					this.GetDesktopItems();
					num = 5;
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
					bool flag = this.ctxt_menu.SelectedItems.Count == 1;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00022030 File Offset: 0x00020230
		private void del_all_Click(object sender, EventArgs e)
		{
			int num = 0;
			IEnumerator enumerator;
			List<string> list;
			do
			{
				if (num == 2)
				{
					enumerator = this.ctxt_menu.Items.GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					list = new List<string>();
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
					object obj = enumerator.Current;
					string text = (string)obj;
					list.Add(text);
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			context_class.RemoveAllItems(list);
			this.check_context();
			this.GetDesktopItems();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00022134 File Offset: 0x00020334
		private void adv_startup_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\AdvancedBootOptions");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "cmd.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.Close();
					num = 12;
				}
				if (num == 15)
				{
					goto IL_205;
				}
				IL_221:
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3.Close();
					num = 20;
				}
				if (num == 18)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey3, "AdvancedBootOptions");
					num = 19;
				}
				if (num == 17)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 16)
				{
					bool flag = registryKey3 != null;
					num = 17;
				}
				if (num == 14 || num == 13)
				{
					break;
				}
				if (num == 12)
				{
					registryKey.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey2.SetValue("", "shutdown.exe /r /o /f /t 0");
					num = 11;
				}
				if (num == 9)
				{
					registryKey2 = registryKey.CreateSubKey("Command");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Advanced startup options");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_205;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.adv_startup.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					break;
				}
				continue;
				IL_205:
				registryKey3 = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell");
				num = 16;
				goto IL_221;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00022414 File Offset: 0x00020614
		private void app_mode_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\AppMode");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "themecpl.dll,-1");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Light");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-5412");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					goto IL_2CE;
				}
				IL_2EA:
				RegistryKey registryKey4;
				if (num == 30)
				{
					registryKey4.Close();
					num = 31;
				}
				if (num == 29)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "AppMode");
					num = 30;
				}
				if (num == 28)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag = registryKey4 != null;
					num = 28;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 24)
				{
					registryKey.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v AppsUseLightTheme /t REG_DWORD /d 0 /f");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "Dark");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\02Dark");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v AppsUseLightTheme /t REG_DWORD /d 1 /f");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-5411");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\01Light");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Top");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "App mode");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_2CE;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.app_mode.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_2CE:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 27;
				goto IL_2EA;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00022798 File Offset: 0x00020998
		private void attributes_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\attributes.reg");
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 7)
				{
					registryKey.SetValue("Attributes", 1);
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 14)
				{
					registryKey2.DeleteValue("Attributes", false);
					num = 15;
				}
				if (num == 13)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag = registryKey2 != null;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_132;
				}
				IL_148:
				if (num == 9)
				{
					break;
				}
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag2 = registryKey != null;
					num = 6;
				}
				if (num == 4)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_132;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.attributes.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_132:
				Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\R_attributes.reg");
				num = 11;
				goto IL_148;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00022968 File Offset: 0x00020B68
		private void bt_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\Bluetooth");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "bthudtask.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Bluetooth Devices");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3.SetValue("", "fsquirt.exe");
					num = 20;
				}
				if (num == 22)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\3Options");
					num = 23;
				}
				if (num == 26)
				{
					registryKey3.SetValue("", "rundll32.exe shell32.dll,Control_RunDLL bthprops.cpl,,1");
					num = 27;
				}
				if (num == 30)
				{
					registryKey2.SetValue("MUIVerb", "COM Ports");
					num = 31;
				}
				if (num == 34)
				{
					registryKey2.Close();
					num = 35;
				}
				if (num == 38)
				{
					registryKey3.SetValue("", "rundll32.exe shell32.dll,Control_RunDLL bthprops.cpl,,3");
					num = 39;
				}
				if (num == 41)
				{
					registryKey.Close();
					num = 42;
				}
				if (num == 45)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 46;
				}
				RegistryKey registryKey4;
				if (num == 47)
				{
					registryKey4.Close();
					num = 48;
				}
				if (num == 46)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "Bluetooth");
					num = 47;
				}
				if (num == 44)
				{
					bool flag = registryKey4 != null;
					num = 45;
				}
				if (num == 43)
				{
					goto IL_4AE;
				}
				IL_4CA:
				if (num == 42)
				{
					break;
				}
				if (num == 40)
				{
					registryKey2.Close();
					num = 41;
				}
				if (num == 39)
				{
					registryKey3.Close();
					num = 40;
				}
				if (num == 37)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 38;
				}
				if (num == 36)
				{
					registryKey2.SetValue("MUIVerb", "Hardware");
					num = 37;
				}
				if (num == 35)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\5Hardware");
					num = 36;
				}
				if (num == 33)
				{
					registryKey3.Close();
					num = 34;
				}
				if (num == 32)
				{
					registryKey3.SetValue("", "rundll32.exe shell32.dll,Control_RunDLL bthprops.cpl,,2");
					num = 33;
				}
				if (num == 31)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 32;
				}
				if (num == 29)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\4COMPorts");
					num = 30;
				}
				if (num == 28)
				{
					registryKey2.Close();
					num = 29;
				}
				if (num == 27)
				{
					registryKey3.Close();
					num = 28;
				}
				if (num == 25)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 26;
				}
				if (num == 24)
				{
					registryKey2.SetValue("CommandFlags", 32, RegistryValueKind.DWord);
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.SetValue("MUIVerb", "Options");
					num = 24;
				}
				if (num == 21)
				{
					registryKey2.Close();
					num = 22;
				}
				if (num == 20)
				{
					registryKey3.Close();
					num = 21;
				}
				if (num == 18)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2.SetValue("MUIVerb", "Bluetooth File Transfer");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\2BluetoothFileTransfer");
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.Close();
					num = 15;
				}
				if (num == 13)
				{
					registryKey3.SetValue("", "explorer shell:::{28803F59-3A75-4058-995F-4EE5503B023C}");
					num = 14;
				}
				if (num == 12)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\1BluetoothDevices");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Bluetooth");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_4AE;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.bt.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 48)
				{
					break;
				}
				continue;
				IL_4AE:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 44;
				goto IL_4CA;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00022EBC File Offset: 0x000210BC
		private void clip_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\ClipboardHistory");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "Shell32.dll,-16763");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Enable Clipboard History");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "Shell32.dll,-16763");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					goto IL_2CE;
				}
				IL_2EA:
				RegistryKey registryKey4;
				if (num == 30)
				{
					registryKey4.Close();
					num = 31;
				}
				if (num == 29)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "ClipboardHistory");
					num = 30;
				}
				if (num == 28)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag = registryKey4 != null;
					num = 28;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 24)
				{
					registryKey.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "reg add hkcu\\software\\microsoft\\clipboard /v enableclipboardhistory /t reg_dword /d 0 /f");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "Disable Clipboard History");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\2Disable");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "reg add hkcu\\software\\microsoft\\clipboard /v enableclipboardhistory /t reg_dword /d 1 /f");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "DxpTaskSync.dll,-52");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\1Enable");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Top");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Clipboard History");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_2CE;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.clip.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_2CE:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 27;
				goto IL_2EA;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00023240 File Offset: 0x00021440
		private void cmd_ctxt_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\cmd2");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 8;
				}
				if (num == 11)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\cmd2\\command");
					num = 12;
				}
				RegistryKey registryKey2;
				bool flag;
				if (num == 15)
				{
					flag = registryKey2 != null;
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 20;
				}
				if (num == 22)
				{
					registryKey2 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\shell\\cmd2\\command");
					num = 23;
				}
				RegistryKey registryKey3;
				bool flag2;
				if (num == 26)
				{
					flag2 = registryKey3 != null;
					num = 27;
				}
				if (num == 30)
				{
					registryKey3.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 31;
				}
				if (num == 34)
				{
					registryKey3.SetValue("", "cmd.exe /s /k pushd \"%V\"");
					num = 35;
				}
				if (num == 38)
				{
					bool flag3;
					if (!flag3)
					{
						break;
					}
					num = 39;
				}
				RegistryKey registryKey4;
				if (num == 41)
				{
					registryKey4.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 42;
				}
				if (num == 45)
				{
					registryKey4.SetValue("", "cmd.exe /s /k pushd \"%V\"");
					num = 46;
				}
				RegistryKey registryKey5;
				bool flag4;
				if (num == 49)
				{
					flag4 = registryKey5 != null;
					num = 50;
				}
				if (num == 53)
				{
					goto IL_328;
				}
				IL_344:
				RegistryKey registryKey6;
				if (num == 57)
				{
					registryKey6.Close();
					num = 58;
				}
				if (num != 60)
				{
					goto IL_1A4;
				}
				bool flag5;
				if (flag5)
				{
					num = 61;
					goto IL_1A4;
				}
				goto IL_20F;
				IL_22B:
				RegistryKey registryKey7;
				if (num == 62)
				{
					registryKey7.Close();
					num = 63;
				}
				if (num == 61)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey7, "cmd2");
					num = 62;
				}
				if (num == 59)
				{
					flag5 = registryKey7 != null;
					num = 60;
				}
				if (num == 58)
				{
					goto IL_290;
				}
				IL_2AC:
				if (num == 56)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey6, "cmd2");
					num = 57;
				}
				if (num == 55)
				{
					bool flag6;
					if (!flag6)
					{
						goto IL_290;
					}
					num = 56;
				}
				if (num == 54)
				{
					bool flag6 = registryKey6 != null;
					num = 55;
				}
				if (num == 52)
				{
					registryKey5.Close();
					num = 53;
				}
				if (num == 51)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey5, "cmd2");
					num = 52;
				}
				if (num == 50)
				{
					if (!flag4)
					{
						goto IL_328;
					}
					num = 51;
				}
				if (num == 48)
				{
					goto IL_77F;
				}
				IL_79B:
				if (num == 47)
				{
					break;
				}
				if (num == 46)
				{
					registryKey4.Close();
					num = 47;
				}
				if (num == 44)
				{
					registryKey4 = Registry.ClassesRoot.CreateSubKey("LibraryFolder\\shell\\cmd2\\command");
					num = 45;
				}
				if (num == 43)
				{
					registryKey4.Close();
					num = 44;
				}
				if (num == 42)
				{
					registryKey4.SetValue("Icon", "cmd.exe", RegistryValueKind.String);
					num = 43;
				}
				if (num == 40)
				{
					registryKey4.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 41;
				}
				if (num == 39)
				{
					registryKey4.SetValue("", "Open CMD Here", RegistryValueKind.String);
					num = 40;
				}
				if (num == 37)
				{
					bool flag3 = registryKey4 != null;
					num = 38;
				}
				if (num == 36)
				{
					goto IL_51F;
				}
				IL_536:
				if (num == 35)
				{
					registryKey3.Close();
					num = 36;
				}
				if (num == 33)
				{
					registryKey3 = Registry.ClassesRoot.CreateSubKey("Drive\\shell\\cmd2\\command");
					num = 34;
				}
				if (num == 32)
				{
					registryKey3.Close();
					num = 33;
				}
				if (num == 31)
				{
					registryKey3.SetValue("Icon", "cmd.exe", RegistryValueKind.String);
					num = 32;
				}
				if (num == 29)
				{
					registryKey3.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 30;
				}
				if (num == 28)
				{
					registryKey3.SetValue("", "Open CMD Here", RegistryValueKind.String);
					num = 29;
				}
				if (num == 27)
				{
					if (!flag2)
					{
						goto IL_51F;
					}
					num = 28;
				}
				if (num == 25)
				{
					goto IL_620;
				}
				IL_637:
				if (num == 24)
				{
					registryKey2.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.SetValue("", "cmd.exe /s /k pushd \"%V\"");
					num = 24;
				}
				if (num == 21)
				{
					registryKey2.Close();
					num = 22;
				}
				if (num == 20)
				{
					registryKey2.SetValue("Icon", "cmd.exe", RegistryValueKind.String);
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 19;
				}
				if (num == 17)
				{
					registryKey2.SetValue("", "Open CMD Here", RegistryValueKind.String);
					num = 18;
				}
				if (num == 16)
				{
					if (!flag)
					{
						goto IL_620;
					}
					num = 17;
				}
				if (num == 14)
				{
					goto IL_721;
				}
				IL_737:
				if (num == 13)
				{
					registryKey.Close();
					num = 14;
				}
				if (num == 12)
				{
					registryKey.SetValue("", "cmd.exe /s /k pushd \"%V\"");
					num = 13;
				}
				if (num == 10)
				{
					registryKey.Close();
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("Icon", "cmd.exe", RegistryValueKind.String);
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("", "Open CMD Here", RegistryValueKind.String);
					num = 7;
				}
				if (num == 5)
				{
					bool flag7;
					if (!flag7)
					{
						goto IL_721;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag7 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_77F;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.cmd_ctxt.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 68)
				{
					break;
				}
				continue;
				IL_721:
				registryKey2 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\shell\\cmd2");
				num = 15;
				goto IL_737;
				IL_620:
				registryKey3 = Registry.ClassesRoot.CreateSubKey("Drive\\shell\\cmd2");
				num = 26;
				goto IL_637;
				IL_51F:
				registryKey4 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\shell\\cmd2");
				num = 37;
				goto IL_536;
				IL_77F:
				registryKey5 = Registry.ClassesRoot.CreateSubKey("Directory\\shell", true);
				num = 49;
				goto IL_79B;
				IL_290:
				registryKey7 = Registry.ClassesRoot.CreateSubKey("Drive\\shell", true);
				num = 59;
				goto IL_2AC;
				IL_1A4:
				RegistryKey registryKey8;
				bool flag8;
				if (num == 64)
				{
					flag8 = registryKey8 != null;
					num = 65;
				}
				if (num == 67)
				{
					registryKey8.Close();
					num = 68;
				}
				if (num == 66)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey8, "cmd2");
					num = 67;
				}
				if (num == 65)
				{
					if (!flag8)
					{
						break;
					}
					num = 66;
				}
				if (num != 63)
				{
					goto IL_22B;
				}
				IL_20F:
				registryKey8 = Registry.ClassesRoot.CreateSubKey("LibraryFolder\\shell", true);
				num = 64;
				goto IL_22B;
				IL_328:
				registryKey6 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\shell", true);
				num = 54;
				goto IL_344;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00023A64 File Offset: 0x00021C64
		private void cmd_ctxt_admin_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\Shell\\OpenElevatedCmd");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "imageres.dll,-5324");
					num = 8;
				}
				if (num == 11)
				{
					registryKey.Close();
					num = 12;
				}
				RegistryKey registryKey2;
				if (num == 15)
				{
					registryKey2.SetValue("", "Open CMD As Administrator");
					num = 16;
				}
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3.Close();
					num = 20;
				}
				RegistryKey registryKey4;
				bool flag;
				if (num == 22)
				{
					flag = registryKey4 != null;
					num = 23;
				}
				RegistryKey registryKey5;
				if (num == 26)
				{
					registryKey5 = registryKey4.CreateSubKey("Command");
					num = 27;
				}
				if (num == 30)
				{
					goto IL_416;
				}
				IL_42D:
				RegistryKey registryKey6;
				if (num == 34)
				{
					registryKey6.SetValue("Icon", "imageres.dll,-5324");
					num = 35;
				}
				if (num == 38)
				{
					registryKey6.Close();
					num = 39;
				}
				if (num == 41)
				{
					RegistryKey registryKey7 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 42;
				}
				if (num == 40)
				{
					goto IL_3FD;
				}
				IL_403:
				if (num == 39)
				{
					break;
				}
				RegistryKey registryKey8;
				if (num == 37)
				{
					registryKey8.Close();
					num = 38;
				}
				if (num == 36)
				{
					registryKey8.SetValue("", "-Powershell windowstyle hidden -Command “Start-Process cmd -ArgumentList ‘/s,/k,pushd,%V’ -Verb RunAs”");
					num = 37;
				}
				if (num == 35)
				{
					registryKey8 = registryKey6.CreateSubKey("Command");
					num = 36;
				}
				if (num == 33)
				{
					registryKey6.SetValue("", "Open CMD As Administrator");
					num = 34;
				}
				if (num == 32)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 33;
				}
				if (num == 31)
				{
					bool flag2 = registryKey6 != null;
					num = 32;
				}
				if (num == 29)
				{
					registryKey4.Close();
					num = 30;
				}
				if (num == 28)
				{
					registryKey5.Close();
					num = 29;
				}
				if (num == 27)
				{
					registryKey5.SetValue("", "-Powershell windowstyle hidden -Command “Start-Process cmd -ArgumentList ‘/s,/k,pushd,%V’ -Verb RunAs”");
					num = 28;
				}
				if (num == 25)
				{
					registryKey4.SetValue("Icon", "imageres.dll,-5324");
					num = 26;
				}
				if (num == 24)
				{
					registryKey4.SetValue("", "Open CMD As Administrator");
					num = 25;
				}
				if (num == 23)
				{
					if (!flag)
					{
						goto IL_416;
					}
					num = 24;
				}
				if (num == 21)
				{
					goto IL_2D1;
				}
				IL_2E8:
				if (num == 20)
				{
					registryKey2.Close();
					num = 21;
				}
				if (num == 18)
				{
					registryKey3.SetValue("", "-Powershell windowstyle hidden -Command “Start-Process cmd -ArgumentList ‘/s,/k,pushd,%V’ -Verb RunAs”");
					num = 19;
				}
				if (num == 17)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-5324");
					num = 17;
				}
				if (num == 14)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_2D1;
					}
					num = 15;
				}
				if (num == 13)
				{
					bool flag3 = registryKey2 != null;
					num = 14;
				}
				if (num == 12)
				{
					goto IL_39E;
				}
				IL_3B4:
				RegistryKey registryKey9;
				if (num == 10)
				{
					registryKey9.Close();
					num = 11;
				}
				if (num == 9)
				{
					registryKey9.SetValue("", "-Powershell windowstyle hidden -Command “Start-Process cmd -ArgumentList ‘/s,/k,pushd,%V’ -Verb RunAs”");
					num = 10;
				}
				if (num == 8)
				{
					registryKey9 = registryKey.CreateSubKey("Command");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("", "Open CMD As Administrator");
					num = 7;
				}
				if (num == 5)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_39E;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag4 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_3FD;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.cmd_ctxt_admin.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 42)
				{
					goto Block_44;
				}
				continue;
				IL_39E:
				registryKey2 = Registry.ClassesRoot.CreateSubKey("Drive\\Shell\\OpenElevatedCmd");
				num = 13;
				goto IL_3B4;
				IL_2D1:
				registryKey4 = Registry.ClassesRoot.CreateSubKey("LibraryFolder\\background\\Shell\\OpenElevatedCmd");
				num = 22;
				goto IL_2E8;
				IL_3FD:
				num = 41;
				goto IL_403;
				IL_416:
				registryKey6 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\Shell\\OpenElevatedCmd");
				num = 31;
				goto IL_42D;
			}
			return;
			Block_44:
			try
			{
				RegistryKey registryKey7;
				using (RegistryKey registryKey10 = registryKey7.OpenSubKey("Directory\\\\Background\\\\Shell\\\\OpenElevatedCmd"))
				{
					if (registryKey10 != null)
					{
						string text = "Directory\\Background\\Shell\\";
						using (RegistryKey registryKey11 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey11.DeleteSubKeyTree("OpenElevatedCmd", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey7;
				if (registryKey7 != null)
				{
					((IDisposable)registryKey7).Dispose();
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00023FC4 File Offset: 0x000221C4
		private void compact_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\CompactOS");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "%SystemRoot%\\System32\\cmd.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Compact OS state");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 20;
				}
				if (num == 22)
				{
					registryKey2.Close();
					num = 23;
				}
				if (num == 26)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 27;
				}
				if (num == 30)
				{
					registryKey.Close();
					num = 31;
				}
				if (num == 34)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 35;
				}
				RegistryKey registryKey4;
				if (num == 36)
				{
					registryKey4.Close();
					num = 37;
				}
				if (num == 35)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "CompactOS");
					num = 36;
				}
				if (num == 33)
				{
					bool flag = registryKey4 != null;
					num = 34;
				}
				if (num == 32)
				{
					goto IL_37C;
				}
				IL_398:
				if (num == 31)
				{
					break;
				}
				if (num == 29)
				{
					registryKey2.Close();
					num = 30;
				}
				if (num == 28)
				{
					registryKey3.Close();
					num = 29;
				}
				if (num == 27)
				{
					registryKey3.SetValue("", "PowerShell -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/k,compact /compactos:never' -Verb RunAs\"");
					num = 28;
				}
				if (num == 25)
				{
					registryKey2.SetValue("HasLUAShield", "");
					num = 26;
				}
				if (num == 24)
				{
					registryKey2.SetValue("MUIVerb", "Uncompress system files");
					num = 25;
				}
				if (num == 23)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\03CompactOSUncompress");
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.Close();
					num = 22;
				}
				if (num == 20)
				{
					registryKey3.SetValue("", "PowerShell.exe -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/k,compact /compactos:always' -Verb RunAs\"");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("HasLUAShield", "");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2.SetValue("MUIVerb", "Compress system files");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\02CompactOSCompress");
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.Close();
					num = 15;
				}
				if (num == 13)
				{
					registryKey3.SetValue("", "cmd.exe /s /k compact /compactos:query");
					num = 14;
				}
				if (num == 12)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\01CompactOSStatus");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Compact OS");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_37C;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.compact.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 37)
				{
					break;
				}
				continue;
				IL_37C:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 33;
				goto IL_398;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000243E4 File Offset: 0x000225E4
		private void control_pnl_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			RegistryKey registryKey4;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\ControlPanel");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "imageres.dll,-27");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "@shell32.dll,-31061");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-27");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-27");
					num = 27;
				}
				if (num == 30)
				{
					registryKey3.Close();
					num = 31;
				}
				if (num == 34)
				{
					goto IL_372;
				}
				IL_378:
				if (num == 35)
				{
					registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 36;
				}
				if (num == 33)
				{
					return;
				}
				if (num == 32)
				{
					registryKey.Close();
					num = 33;
				}
				if (num == 31)
				{
					registryKey2.Close();
					num = 32;
				}
				if (num == 29)
				{
					registryKey3.SetValue("", "explorer.exe shell:::{ED7BA470-8E54-465E-825C-99712043E01C}");
					num = 30;
				}
				if (num == 28)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 29;
				}
				if (num == 27)
				{
					registryKey2.SetValue("CommandFlags", 32, RegistryValueKind.DWord);
					num = 28;
				}
				if (num == 25)
				{
					registryKey2.SetValue("MUIVerb", "@shell32.dll,-32537");
					num = 26;
				}
				if (num == 24)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\3ControlPanelCmd");
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "explorer.exe shell:::{21EC2020-3AEA-1069-A2DD-08002B30309D}");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "@shell32.dll,-31062");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\2ControlPanelCmd");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "explorer.exe shell:::{26EE0668-A00A-44D7-9371-BEB064C98683}");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-27");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\1ControlPanelCmd");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "@shell32.dll,-4161");
					num = 7;
				}
				if (num == 5)
				{
					bool flag;
					if (!flag)
					{
						return;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_372;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.control_pnl.Checked;
					num = 2;
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
				IL_372:
				num = 35;
				goto IL_378;
			}
			try
			{
				using (RegistryKey registryKey5 = registryKey4.OpenSubKey("DesktopBackground\\\\shell\\\\ControlPanel"))
				{
					if (registryKey5 != null)
					{
						string text = "DesktopBackground\\shell\\";
						using (RegistryKey registryKey6 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey6.DeleteSubKeyTree("ControlPanel", true);
						}
					}
				}
			}
			finally
			{
				if (registryKey4 != null)
				{
					((IDisposable)registryKey4).Dispose();
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00024890 File Offset: 0x00022A90
		private void hash_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("*\\shell\\Hash");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("SubCommands", "");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("", "powershell - noexit get - filehash - literalpath '%1' - algorithm SHA1 | format - list");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.SetValue("MUIVerb", "SHA256");
					num = 16;
				}
				if (num == 19)
				{
					registryKey3.Close();
					num = 20;
				}
				if (num == 22)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 23;
				}
				if (num == 26)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\04Menu");
					num = 27;
				}
				if (num == 30)
				{
					registryKey2.Close();
					num = 31;
				}
				if (num == 34)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 35;
				}
				if (num == 38)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\06Menu");
					num = 39;
				}
				if (num == 41)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm MD5 | format-list");
					num = 42;
				}
				if (num == 45)
				{
					registryKey3.SetValue("MUIVerb", "RIPEMD160");
					num = 46;
				}
				if (num == 49)
				{
					registryKey3.Close();
					num = 50;
				}
				if (num == 53)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 54;
				}
				if (num == 57)
				{
					registryKey.Close();
					num = 58;
				}
				if (num == 60)
				{
					RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 61;
				}
				if (num == 59)
				{
					goto IL_61E;
				}
				IL_624:
				if (num == 58)
				{
					break;
				}
				if (num == 56)
				{
					registryKey3.Close();
					num = 57;
				}
				if (num == 55)
				{
					registryKey2.Close();
					num = 56;
				}
				if (num == 54)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm SHA1 | format-list;get-filehash -literalpath '%1' -algorithm SHA256 | format-list;get-filehash -literalpath '%1' -algorithm SHA384 | format-list;get-filehash -literalpath '%1' -algorithm SHA512 | format-list;get-filehash -literalpath '%1' -algorithm MACTripleDES | format-list;get-filehash -literalpath '%1' -algorithm MD5 | format-list;get-filehash -literalpath '%1' -algorithm RIPEMD160 | format-list");
					num = 55;
				}
				if (num == 52)
				{
					Registry.SetValue("HKEY_CLASSES_ROOT\\*\\shell\\hash\\shell\\08menu", "CommandFlags", 32, RegistryValueKind.DWord);
					num = 53;
				}
				if (num == 51)
				{
					registryKey3.SetValue("MUIVerb", "Show all");
					num = 52;
				}
				if (num == 50)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\08Menu");
					num = 51;
				}
				if (num == 48)
				{
					registryKey2.Close();
					num = 49;
				}
				if (num == 47)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm RIPEMD160 | format-list");
					num = 48;
				}
				if (num == 46)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 47;
				}
				if (num == 44)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\07Menu");
					num = 45;
				}
				if (num == 43)
				{
					registryKey3.Close();
					num = 44;
				}
				if (num == 42)
				{
					registryKey2.Close();
					num = 43;
				}
				if (num == 40)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 41;
				}
				if (num == 39)
				{
					registryKey3.SetValue("MUIVerb", "MD5");
					num = 40;
				}
				if (num == 37)
				{
					registryKey3.Close();
					num = 38;
				}
				if (num == 36)
				{
					registryKey2.Close();
					num = 37;
				}
				if (num == 35)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm MACTripleDES | format-list");
					num = 36;
				}
				if (num == 33)
				{
					registryKey3.SetValue("MUIVerb", "MACTripleDES");
					num = 34;
				}
				if (num == 32)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\05Menu");
					num = 33;
				}
				if (num == 31)
				{
					registryKey3.Close();
					num = 32;
				}
				if (num == 29)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm SHA512 | format-list");
					num = 30;
				}
				if (num == 28)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 29;
				}
				if (num == 27)
				{
					registryKey3.SetValue("MUIVerb", "SHA512");
					num = 28;
				}
				if (num == 25)
				{
					registryKey3.Close();
					num = 26;
				}
				if (num == 24)
				{
					registryKey2.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm SHA384 | format-list");
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("MUIVerb", "SHA384");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\03Menu");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.Close();
					num = 19;
				}
				if (num == 17)
				{
					registryKey2.SetValue("", "powershell -noexit get-filehash -literalpath '%1' -algorithm SHA256 | format-list");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 17;
				}
				if (num == 14)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\02Menu");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3.Close();
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey3.CreateSubKey("Command");
					num = 11;
				}
				if (num == 9)
				{
					registryKey3.SetValue("MUIVerb", "SHA1");
					num = 10;
				}
				if (num == 8)
				{
					registryKey3 = registryKey.CreateSubKey("shell\\01Menu");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Hash");
					num = 7;
				}
				if (num == 5)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_61E;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.hash.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 61)
				{
					goto Block_62;
				}
				continue;
				IL_61E:
				num = 60;
				goto IL_624;
			}
			return;
			Block_62:
			try
			{
				RegistryKey registryKey4;
				using (RegistryKey registryKey5 = registryKey4.OpenSubKey("*\\shell\\Hash"))
				{
					if (registryKey5 != null)
					{
						string text = "*\\shell\\";
						using (RegistryKey registryKey6 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey6.DeleteSubKeyTree("Hash", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey4;
				if (registryKey4 != null)
				{
					((IDisposable)registryKey4).Dispose();
				}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00024FD4 File Offset: 0x000231D4
		private void kill_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey(this.REG_KILL_PATH);
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "%SystemRoot%\\\\System32\\\\imageres.dll,-98");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.Close();
					num = 12;
				}
				if (num == 15)
				{
					RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					num = 16;
				}
				if (num == 14)
				{
					goto IL_141;
				}
				IL_147:
				if (num == 13)
				{
					break;
				}
				if (num == 12)
				{
					registryKey.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey2.SetValue("", "cmd.exe /K taskkill.exe /F /FI \"status eq NOT RESPONDING\"");
					num = 11;
				}
				if (num == 9)
				{
					registryKey2 = registryKey.CreateSubKey("Command");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Top");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Kill not responding tasks");
					num = 7;
				}
				if (num == 5)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_141;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.kill.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					goto Block_17;
				}
				continue;
				IL_141:
				num = 15;
				goto IL_147;
			}
			return;
			Block_17:
			try
			{
				RegistryKey registryKey3;
				using (RegistryKey registryKey4 = registryKey3.OpenSubKey("SOFTWARE\\Classes\\DesktopBackground\\Shell\\KillNotResponding"))
				{
					if (registryKey4 != null)
					{
						string text = "SOFTWARE\\Classes\\DesktopBackground\\Shell";
						using (RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey(text, true))
						{
							registryKey5.DeleteSubKeyTree("KillNotResponding", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey3;
				if (registryKey3 != null)
				{
					((IDisposable)registryKey3).Dispose();
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0002523C File Offset: 0x0002343C
		private void bash_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\bash.reg");
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 7)
				{
					registryKey.SetValue("Open Bash", 1);
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 14)
				{
					registryKey2.DeleteValue("Open Bash", false);
					num = 15;
				}
				if (num == 13)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag = registryKey2 != null;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_132;
				}
				IL_148:
				if (num == 9)
				{
					break;
				}
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag2 = registryKey != null;
					num = 6;
				}
				if (num == 4)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_132;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.bash.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_132:
				Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\R_bash.reg");
				num = 11;
				goto IL_148;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0002540C File Offset: 0x0002360C
		private void openwith_nat_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					num = 4;
				}
				if (num == 7)
				{
					goto IL_53;
				}
				if (num == 11)
				{
					bool flag;
					if (!flag)
					{
						goto IL_365;
					}
					num = 12;
				}
				RegistryKey registryKey;
				bool flag2;
				if (num == 15)
				{
					flag2 = registryKey != null;
					num = 16;
				}
				if (num != 19)
				{
					goto IL_27F;
				}
				goto IL_365;
				IL_6B:
				int num2;
				if (num == 6)
				{
					num2 = 0;
					num = 7;
				}
				if (num == 5)
				{
					num = 6;
				}
				string[] array;
				if (num == 4)
				{
					array = new string[] { "batfile", "cmdfile" };
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_D0;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.openwith_nat.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 35)
				{
					break;
				}
				continue;
				IL_5E:
				string text = array[num2];
				num = 9;
				goto IL_6B;
				IL_53:
				if (num2 < array.Length)
				{
					goto IL_5E;
				}
				num = 21;
				IL_22C:
				if (num == 18)
				{
					registryKey.Close();
					num = 19;
				}
				if (num == 17)
				{
					registryKey.SetValue("MUIVerb", "@shell32.dll,-9016", RegistryValueKind.ExpandString);
					num = 18;
				}
				if (num == 16)
				{
					if (!flag2)
					{
						goto IL_365;
					}
					num = 17;
				}
				if (num == 14)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey(text + "\\shell\\Open with", true);
					num = 15;
				}
				if (num == 13)
				{
					registryKey.Close();
					num = 14;
				}
				if (num == 12)
				{
					registryKey.SetValue("", "{09799AFB-AD67-11d1-ABCD-00C04FC30936}", RegistryValueKind.String);
					num = 13;
				}
				if (num == 10)
				{
					bool flag = registryKey != null;
					num = 11;
				}
				if (num == 9)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey(text + "\\shell\\Open with\\command");
					num = 10;
				}
				if (num == 8)
				{
					goto IL_5E;
				}
				goto IL_6B;
				IL_D6:
				if (num == 26)
				{
					goto IL_FE;
				}
				if (num == 30)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_119;
					}
					num = 31;
				}
				if (num == 34)
				{
					goto IL_FE;
				}
				goto IL_10F;
				IL_1B7:
				int num3;
				if (num == 25)
				{
					num3 = 0;
					num = 26;
				}
				if (num == 24)
				{
					num = 25;
				}
				string[] array2;
				if (num == 23)
				{
					array2 = new string[] { "batfile", "cmdfile" };
					num = 24;
				}
				if (num == 21)
				{
					break;
				}
				if (num != 20)
				{
					goto IL_22C;
				}
				goto IL_53;
				IL_1AA:
				string text2 = array2[num3];
				num = 28;
				goto IL_1B7;
				IL_FE:
				if (num3 >= array2.Length)
				{
					num = 35;
					goto IL_10F;
				}
				goto IL_1AA;
				IL_129:
				RegistryKey registryKey2;
				if (num == 32)
				{
					registryKey2.Close();
					num = 33;
				}
				if (num == 31)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey2, "Open with");
					num = 32;
				}
				if (num == 29)
				{
					bool flag3 = registryKey2 != null;
					num = 30;
				}
				if (num == 28)
				{
					registryKey2 = Registry.ClassesRoot.OpenSubKey(text2 + "\\shell", true);
					num = 29;
				}
				if (num == 27)
				{
					goto IL_1AA;
				}
				goto IL_1B7;
				IL_119:
				num3++;
				num = 34;
				goto IL_129;
				IL_10F:
				if (num == 33)
				{
					goto IL_119;
				}
				goto IL_129;
				IL_27F:
				if (num == 22)
				{
					goto IL_D0;
				}
				goto IL_D6;
				IL_365:
				num2++;
				num = 20;
				goto IL_27F;
				IL_D0:
				num = 23;
				goto IL_D6;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000257F0 File Offset: 0x000239F0
		private void powershell_admin_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\Shell\\OpenElevatedPS");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "powershell.exe");
					num = 8;
				}
				if (num == 11)
				{
					registryKey.Close();
					num = 12;
				}
				RegistryKey registryKey2;
				if (num == 15)
				{
					registryKey2.SetValue("", "Open Powershell As Administrator");
					num = 16;
				}
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3.Close();
					num = 20;
				}
				RegistryKey registryKey4;
				bool flag;
				if (num == 22)
				{
					flag = registryKey4 != null;
					num = 23;
				}
				RegistryKey registryKey5;
				if (num == 26)
				{
					registryKey5 = registryKey4.CreateSubKey("Command");
					num = 27;
				}
				if (num == 30)
				{
					goto IL_416;
				}
				IL_42D:
				RegistryKey registryKey6;
				if (num == 34)
				{
					registryKey6.SetValue("Icon", "powershell.exe");
					num = 35;
				}
				if (num == 38)
				{
					registryKey6.Close();
					num = 39;
				}
				if (num == 41)
				{
					RegistryKey registryKey7 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 42;
				}
				if (num == 40)
				{
					goto IL_3FD;
				}
				IL_403:
				if (num == 39)
				{
					break;
				}
				RegistryKey registryKey8;
				if (num == 37)
				{
					registryKey8.Close();
					num = 38;
				}
				if (num == 36)
				{
					registryKey8.SetValue("", "Powershell.exe -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/c,pushd %V && powershell' -Verb RunAs\"");
					num = 37;
				}
				if (num == 35)
				{
					registryKey8 = registryKey6.CreateSubKey("Command");
					num = 36;
				}
				if (num == 33)
				{
					registryKey6.SetValue("", "Open Powershell As Administrator");
					num = 34;
				}
				if (num == 32)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 33;
				}
				if (num == 31)
				{
					bool flag2 = registryKey6 != null;
					num = 32;
				}
				if (num == 29)
				{
					registryKey4.Close();
					num = 30;
				}
				if (num == 28)
				{
					registryKey5.Close();
					num = 29;
				}
				if (num == 27)
				{
					registryKey5.SetValue("", "Powershell.exe -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/c,pushd %V && powershell' -Verb RunAs\"");
					num = 28;
				}
				if (num == 25)
				{
					registryKey4.SetValue("Icon", "powershell.exe");
					num = 26;
				}
				if (num == 24)
				{
					registryKey4.SetValue("", "Open Powershell As Administrator");
					num = 25;
				}
				if (num == 23)
				{
					if (!flag)
					{
						goto IL_416;
					}
					num = 24;
				}
				if (num == 21)
				{
					goto IL_2D1;
				}
				IL_2E8:
				if (num == 20)
				{
					registryKey2.Close();
					num = 21;
				}
				if (num == 18)
				{
					registryKey3.SetValue("", "Powershell.exe -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/c,pushd %V && powershell' -Verb RunAs\"");
					num = 19;
				}
				if (num == 17)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.SetValue("Icon", "powershell.exe");
					num = 17;
				}
				if (num == 14)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_2D1;
					}
					num = 15;
				}
				if (num == 13)
				{
					bool flag3 = registryKey2 != null;
					num = 14;
				}
				if (num == 12)
				{
					goto IL_39E;
				}
				IL_3B4:
				RegistryKey registryKey9;
				if (num == 10)
				{
					registryKey9.Close();
					num = 11;
				}
				if (num == 9)
				{
					registryKey9.SetValue("", "Powershell.exe -windowstyle hidden -Command \"Start-Process cmd.exe -ArgumentList '/s,/c,pushd %V && powershell' -Verb RunAs\"");
					num = 10;
				}
				if (num == 8)
				{
					registryKey9 = registryKey.CreateSubKey("Command");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("", "Open Powershell As Administrator");
					num = 7;
				}
				if (num == 5)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_39E;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag4 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_3FD;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.powershell_admin.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 42)
				{
					goto Block_44;
				}
				continue;
				IL_39E:
				registryKey2 = Registry.ClassesRoot.CreateSubKey("Drive\\Shell\\OpenElevatedPS");
				num = 13;
				goto IL_3B4;
				IL_2D1:
				registryKey4 = Registry.ClassesRoot.CreateSubKey("LibraryFolder\\background\\Shell\\OpenElevatedPS");
				num = 22;
				goto IL_2E8;
				IL_3FD:
				num = 41;
				goto IL_403;
				IL_416:
				registryKey6 = Registry.ClassesRoot.CreateSubKey("Directory\\Background\\Shell\\OpenElevatedPS");
				num = 31;
				goto IL_42D;
			}
			return;
			Block_44:
			try
			{
				RegistryKey registryKey7;
				using (RegistryKey registryKey10 = registryKey7.OpenSubKey("Directory\\\\Background\\\\Shell\\\\OpenElevatedPS"))
				{
					if (registryKey10 != null)
					{
						string text = "Directory\\Background\\Shell\\";
						using (RegistryKey registryKey11 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey11.DeleteSubKeyTree("OpenElevatedPS", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey7;
				if (registryKey7 != null)
				{
					((IDisposable)registryKey7).Dispose();
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00025D50 File Offset: 0x00023F50
		private void res_explorer_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
					num = 4;
				}
				RegistryKey registryKey2;
				if (num == 7)
				{
					registryKey2.SetValue("MUIVerb", "Restart Explorer");
					num = 8;
				}
				RegistryKey registryKey3;
				if (num == 11)
				{
					registryKey3 = registryKey2.CreateSubKey("shell\\01RestartExplorer");
					num = 12;
				}
				RegistryKey registryKey4;
				if (num == 15)
				{
					registryKey4.SetValue("", "cmd.exe /c taskkill /f /im explorer.exe  & start explorer.exe");
					num = 16;
				}
				if (num == 19)
				{
					registryKey3.SetValue("MUIVerb", "Restart Explorer with pause");
					num = 20;
				}
				if (num == 22)
				{
					registryKey4.SetValue("", "cmd.exe /c @echo off & echo The explorer.exe process will be terminated & echo. & taskkill /f /im explorer.exe & echo. & echo Done & echo. & echo Press any key to start explorer.exe process & pause>NUL & start explorer.exe & exit");
					num = 23;
				}
				if (num != 26)
				{
					RegistryKey registryKey5;
					if (num == 30)
					{
						RegistryTools.DeleteSubKeyTree(ref registryKey5, "RestartExplorer");
						num = 31;
					}
					if (num == 31)
					{
						registryKey5.Close();
						num = 32;
					}
					if (num == 29)
					{
						bool flag;
						if (!flag)
						{
							break;
						}
						num = 30;
					}
					if (num == 28)
					{
						bool flag = registryKey5 != null;
						num = 29;
					}
					if (num == 27)
					{
						goto IL_300;
					}
					IL_31C:
					if (num == 25)
					{
						registryKey2.Close();
						num = 26;
					}
					if (num == 24)
					{
						registryKey3.Close();
						num = 25;
					}
					if (num == 23)
					{
						registryKey4.Close();
						num = 24;
					}
					if (num == 21)
					{
						registryKey4 = registryKey3.CreateSubKey("Command");
						num = 22;
					}
					if (num == 20)
					{
						registryKey3.SetValue("Icon", "%SystemRoot%\\system32\\cmd.exe", RegistryValueKind.ExpandString);
						num = 21;
					}
					if (num == 18)
					{
						registryKey3 = registryKey2.CreateSubKey("shell\\02RestartWithPause");
						num = 19;
					}
					if (num == 17)
					{
						registryKey3.Close();
						num = 18;
					}
					if (num == 16)
					{
						registryKey4.Close();
						num = 17;
					}
					if (num == 14)
					{
						registryKey4 = registryKey3.CreateSubKey("Command");
						num = 15;
					}
					if (num == 13)
					{
						registryKey3.SetValue("Icon", "%SystemRoot%\\explorer.exe", RegistryValueKind.ExpandString);
						num = 14;
					}
					if (num == 12)
					{
						registryKey3.SetValue("MUIVerb", "Restart Explorer");
						num = 13;
					}
					if (num == 10)
					{
						registryKey2.SetValue("SubCommands", "");
						num = 11;
					}
					if (num == 9)
					{
						registryKey2.SetValue("Position", "Bottom");
						num = 10;
					}
					if (num == 8)
					{
						registryKey2.SetValue("Icon", "%SystemRoot%\\explorer.exe", RegistryValueKind.ExpandString);
						num = 9;
					}
					if (num == 6)
					{
						registryKey2 = registryKey.CreateSubKey("RestartExplorer");
						num = 7;
					}
					if (num == 5)
					{
						bool flag2;
						if (!flag2)
						{
							break;
						}
						num = 6;
					}
					if (num == 4)
					{
						bool flag2 = registryKey != null;
						num = 5;
					}
					if (num == 2)
					{
						bool @checked;
						if (!@checked)
						{
							goto IL_300;
						}
						num = 3;
					}
					if (num == 1)
					{
						bool @checked = this.res_explorer.Checked;
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 32)
					{
						break;
					}
					continue;
					IL_300:
					registryKey5 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
					num = 28;
					goto IL_31C;
				}
				break;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00026108 File Offset: 0x00024308
		private void res_startmenu_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\RestartStartMenu");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "%SystemRoot%\\System32\\UNP\\UNPUX.dll,-101");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.Close();
					num = 12;
				}
				RegistryKey registryKey3;
				bool flag;
				if (num == 15)
				{
					flag = registryKey3 != null;
					num = 16;
				}
				if (num == 18)
				{
					registryKey3.Close();
					num = 19;
				}
				if (num == 17)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey3, "RestartStartMenu");
					num = 18;
				}
				if (num == 16)
				{
					if (!flag)
					{
						break;
					}
					num = 17;
				}
				if (num == 14)
				{
					goto IL_180;
				}
				IL_19B:
				if (num == 13)
				{
					break;
				}
				if (num == 12)
				{
					registryKey.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey2.SetValue("", "cmd.exe /c taskkill /im \"StartMenuExperienceHost.exe\" /f & start \"%SystemRoot%\\SystemApps\\Microsoft.Windows.StartMenuExperienceHost_cw5n1h2txyewy\\StartMenuExperienceHost.exe\"");
					num = 11;
				}
				if (num == 9)
				{
					registryKey2 = registryKey.CreateSubKey("command");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Restart Start Menu");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_180;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.res_startmenu.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 19)
				{
					break;
				}
				continue;
				IL_180:
				registryKey3 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 15;
				goto IL_19B;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0002632C File Offset: 0x0002452C
		private void run_priority_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\run_priority.reg");
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 7)
				{
					registryKey.SetValue("Run Priority", 1);
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 14)
				{
					registryKey2.DeleteValue("Run Priority", false);
					num = 15;
				}
				if (num == 13)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag = registryKey2 != null;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_132;
				}
				IL_148:
				if (num == 9)
				{
					break;
				}
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag2 = registryKey != null;
					num = 6;
				}
				if (num == 4)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_132;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.run_priority.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_132:
				Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\R_run_priority.reg");
				num = 11;
				goto IL_148;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000264FC File Offset: 0x000246FC
		private void safe_mode_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 3)
				{
					Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\safe_mode.reg");
					num = 4;
				}
				RegistryKey registryKey;
				if (num == 7)
				{
					registryKey.SetValue("Safe Mode", 1);
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 12;
				}
				if (num == 15)
				{
					registryKey2.Close();
					num = 16;
				}
				if (num == 14)
				{
					registryKey2.DeleteValue("Safe Mode", false);
					num = 15;
				}
				if (num == 13)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 14;
				}
				if (num == 12)
				{
					bool flag = registryKey2 != null;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_132;
				}
				IL_148:
				if (num == 9)
				{
					break;
				}
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag2 = registryKey != null;
					num = 6;
				}
				if (num == 4)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Context Menu");
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_132;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.safe_mode.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					break;
				}
				continue;
				IL_132:
				Process.Start("regedit.exe", "/s C:\\Windows\\SysWOW64\\lv-LV\\ctxt\\R_safe_mode.reg");
				num = 11;
				goto IL_148;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000266CC File Offset: 0x000248CC
		private void snip_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\Shell\\ScreenSnip");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "%SystemRoot%\\System32\\shell32.dll,259", RegistryValueKind.String);
					num = 8;
				}
				if (num == 11)
				{
					registryKey.Close();
					num = 12;
				}
				if (num == 15)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 16;
				}
				RegistryKey registryKey2;
				if (num == 17)
				{
					registryKey2.Close();
					num = 18;
				}
				if (num == 16)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey2, "ScreenSnip");
					num = 17;
				}
				if (num == 14)
				{
					bool flag = registryKey2 != null;
					num = 15;
				}
				if (num == 13)
				{
					goto IL_16C;
				}
				IL_182:
				if (num == 12)
				{
					break;
				}
				if (num == 10)
				{
					registryKey.SetValue("", "explorer.exe ms-screenclip:");
					num = 11;
				}
				if (num == 9)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\Shell\\ScreenSnip\\command");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Screen Snip", RegistryValueKind.String);
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_16C;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.snip.Checked;
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
				IL_16C:
				registryKey2 = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\Shell");
				num = 14;
				goto IL_182;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000268D8 File Offset: 0x00024AD8
		private void takeown_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("*\\shell\\TakeOwnership");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("HasLUAShield", "", RegistryValueKind.String);
					num = 8;
				}
				if (num == 11)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("*\\shell\\TakeOwnership\\command");
					num = 12;
				}
				if (num == 15)
				{
					goto IL_30D;
				}
				IL_323:
				if (num == 19)
				{
					registryKey.SetValue("HasLUAShield", "", RegistryValueKind.String);
					num = 20;
				}
				if (num == 22)
				{
					registryKey.SetValue("AppliesTo", "NOT (System.ItemPathDisplay:=\"C:\\Users\" OR System.ItemPathDisplay:=\"C:\\ProgramData\" OR System.ItemPathDisplay:=\"C:\\Windows\" OR System.ItemPathDisplay:=\"C:\\Windows\\System32\" OR System.ItemPathDisplay:=\"C:\\Program Files\" OR System.ItemPathDisplay:=\"C:\\Program Files (x86)\")", RegistryValueKind.String);
					num = 23;
				}
				if (num == 26)
				{
					registryKey.SetValue("IsolatedCommand", "powershell.exe -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/c takeown /f \\\"%1\\\" /r /d y /skipsl && icacls \\\"%1\\\" /grant *S-1-3-4:F /t /c /l & pause' -Verb runAs\"");
					num = 27;
				}
				if (num == 30)
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 31;
				}
				if (num == 29)
				{
					goto IL_2F4;
				}
				IL_2FA:
				if (num == 28)
				{
					break;
				}
				if (num == 27)
				{
					registryKey.Close();
					num = 28;
				}
				if (num == 25)
				{
					registryKey.SetValue("", "powershell.exe -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/c takeown /f \\\"%1\\\"  /r /d y /skipsl && icacls \\\"%1\\\" /grant *S-1-3-4:F /t /c /l & pause' -Verb runAs\"");
					num = 26;
				}
				if (num == 24)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\TakeOwnership\\command");
					num = 25;
				}
				if (num == 23)
				{
					registryKey.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 22;
				}
				if (num == 20)
				{
					registryKey.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 21;
				}
				if (num == 18)
				{
					registryKey.SetValue("", "Take Ownership", RegistryValueKind.String);
					num = 19;
				}
				if (num == 17)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 16)
				{
					bool flag = registryKey != null;
					num = 17;
				}
				if (num == 14)
				{
					registryKey.Close();
					num = 15;
				}
				if (num == 13)
				{
					registryKey.SetValue("IsolatedCommand", "powershell.exe -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/c takeown /f \\\"%1\\\" && icacls \\\"%1\\\" /grant *S-1-3-4:F /c /l & pause' -Verb runAs\"");
					num = 14;
				}
				if (num == 12)
				{
					registryKey.SetValue("", "powershell.exe -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/c takeown /f \\\"%1\\\" && icacls \\\"%1\\\" /grant *S-1-3-4:F /c /l & pause' -Verb runAs\"");
					num = 13;
				}
				if (num == 10)
				{
					registryKey.Close();
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("NeverDefault", "", RegistryValueKind.String);
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("NoWorkingDirectory", "", RegistryValueKind.String);
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("", "Take Ownership", RegistryValueKind.String);
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_30D;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_2F4;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.takeown.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					goto Block_33;
				}
				continue;
				IL_2F4:
				num = 30;
				goto IL_2FA;
				IL_30D:
				registryKey = Registry.ClassesRoot.CreateSubKey("Directory\\shell\\TakeOwnership");
				num = 16;
				goto IL_323;
			}
			return;
			Block_33:
			try
			{
				RegistryKey registryKey2;
				using (RegistryKey registryKey3 = registryKey2.OpenSubKey("*\\shell\\TakeOwnership"))
				{
					if (registryKey3 != null)
					{
						string text = "*\\shell\\";
						using (RegistryKey registryKey4 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey4.DeleteSubKeyTree("TakeOwnership", true);
						}
						string text2 = "Directory\\shell";
						using (RegistryKey registryKey5 = Registry.ClassesRoot.OpenSubKey(text2, true))
						{
							registryKey5.DeleteSubKeyTree("TakeOwnership", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey2;
				if (registryKey2 != null)
				{
					((IDisposable)registryKey2).Dispose();
				}
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00026D74 File Offset: 0x00024F74
		private void taskmgr_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
					num = 4;
				}
				RegistryKey registryKey2;
				if (num == 7)
				{
					registryKey2.SetValue("MUIVerb", "Task Manager");
					num = 8;
				}
				RegistryKey registryKey3;
				if (num == 11)
				{
					registryKey3.SetValue("", "taskmgr.exe");
					num = 12;
				}
				if (num == 15)
				{
					goto IL_17D;
				}
				IL_199:
				RegistryKey registryKey4;
				if (num == 18)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "taskmgr");
					num = 19;
				}
				if (num == 17)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 18;
				}
				if (num == 16)
				{
					bool flag = registryKey4 != null;
					num = 17;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 13)
				{
					registryKey2.Close();
					num = 14;
				}
				if (num == 12)
				{
					registryKey3.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 11;
				}
				if (num == 9)
				{
					registryKey2.SetValue("Position", "Bottom");
					num = 10;
				}
				if (num == 8)
				{
					registryKey2.SetValue("Icon", "%SystemRoot%\\System32\\taskmgr.exe", RegistryValueKind.ExpandString);
					num = 9;
				}
				if (num == 6)
				{
					registryKey2 = registryKey.CreateSubKey("taskmgr");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_17D;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.taskmgr.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 19)
				{
					break;
				}
				continue;
				IL_17D:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 16;
				goto IL_199;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00026FB0 File Offset: 0x000251B0
		private void win_tools_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey(this.REG_BASE_PATH);
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "imageres.dll,-114");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.Close();
					num = 12;
				}
				if (num == 15)
				{
					RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 16;
				}
				if (num == 14)
				{
					goto IL_141;
				}
				IL_147:
				if (num == 13)
				{
					break;
				}
				if (num == 12)
				{
					registryKey.Close();
					num = 13;
				}
				if (num == 10)
				{
					registryKey2.SetValue("", "explorer.exe shell:::{D20EA4E1-3957-11d2-A40B-0C5020524153}");
					num = 11;
				}
				if (num == 9)
				{
					registryKey2 = registryKey.CreateSubKey("command");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Windows Tools");
					num = 7;
				}
				if (num == 5)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_141;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.win_tools.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 16)
				{
					goto Block_17;
				}
				continue;
				IL_141:
				num = 15;
				goto IL_147;
			}
			return;
			Block_17:
			try
			{
				RegistryKey registryKey3;
				using (RegistryKey registryKey4 = registryKey3.OpenSubKey("DesktopBackground\\\\Shell\\\\WindowsTools"))
				{
					if (registryKey4 != null)
					{
						string text = "DesktopBackground\\Shell";
						using (RegistryKey registryKey5 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey5.DeleteSubKeyTree("WindowsTools", true);
						}
					}
				}
			}
			finally
			{
				RegistryKey registryKey3;
				if (registryKey3 != null)
				{
					((IDisposable)registryKey3).Dispose();
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00027218 File Offset: 0x00025418
		private void win_mode_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\WindowsMode");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "themecpl.dll,-1");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Light");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-5412");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					goto IL_2CE;
				}
				IL_2EA:
				RegistryKey registryKey4;
				if (num == 30)
				{
					registryKey4.Close();
					num = 31;
				}
				if (num == 29)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "WindowsMode");
					num = 30;
				}
				if (num == 28)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag = registryKey4 != null;
					num = 28;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 24)
				{
					registryKey.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v SystemUsesLightTheme /t REG_DWORD /d 0 /f");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "Dark");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\02Dark");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v SystemUsesLightTheme /t REG_DWORD /d 1 /f");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "imageres.dll,-5411");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\01Light");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Top");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Windows mode");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_2CE;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.win_mode.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_2CE:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 27;
				goto IL_2EA;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0002759C File Offset: 0x0002579C
		private void settings_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\Settings");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "SystemSettingsBroker.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Settings");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("MUIVerb", "Devices");
					num = 20;
				}
				if (num == 22)
				{
					registryKey2.SetValue("CommandFlags", 32, RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 26)
				{
					registryKey2.Close();
					num = 27;
				}
				if (num == 30)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:bluetooth");
					num = 31;
				}
				if (num == 34)
				{
					registryKey2.Close();
					num = 35;
				}
				if (num == 38)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:network");
					num = 39;
				}
				if (num == 41)
				{
					registryKey3.Close();
					num = 42;
				}
				if (num == 45)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 46;
				}
				if (num == 49)
				{
					registryKey3.Close();
					num = 50;
				}
				if (num == 53)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 54;
				}
				if (num == 57)
				{
					registryKey3.Close();
					num = 58;
				}
				if (num == 60)
				{
					registryKey2.SetValue("MUIVerb", "Accounts");
					num = 61;
				}
				if (num == 64)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 65;
				}
				if (num == 68)
				{
					registryKey2.SetValue("MUIVerb", "Time && language");
					num = 69;
				}
				if (num == 72)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 73;
				}
				if (num == 76)
				{
					registryKey2.SetValue("MUIVerb", "Gaming");
					num = 77;
				}
				if (num == 80)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 81;
				}
				if (num == 83)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\10Ease");
					num = 84;
				}
				if (num == 87)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 88;
				}
				if (num == 91)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\11Cortana");
					num = 92;
				}
				if (num == 95)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 96;
				}
				if (num == 99)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\12Privacy");
					num = 100;
				}
				if (num == 102)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:privacy");
					num = 103;
				}
				if (num == 106)
				{
					registryKey2.Close();
					num = 107;
				}
				if (num == 110)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:windowsupdate");
					num = 111;
				}
				if (num == 114)
				{
					registryKey2.Close();
					num = 115;
				}
				if (num == 118)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:holographic");
					num = 119;
				}
				if (num == 121)
				{
					registryKey3.Close();
					num = 122;
				}
				if (num == 125)
				{
					goto IL_DE8;
				}
				IL_E04:
				RegistryKey registryKey4;
				if (num == 129)
				{
					registryKey4.Close();
					num = 130;
				}
				if (num == 128)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "Settings");
					num = 129;
				}
				if (num == 127)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 128;
				}
				if (num == 126)
				{
					bool flag = registryKey4 != null;
					num = 127;
				}
				if (num == 124)
				{
					break;
				}
				if (num == 123)
				{
					registryKey.Close();
					num = 124;
				}
				if (num == 122)
				{
					registryKey2.Close();
					num = 123;
				}
				if (num == 120)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 121;
				}
				if (num == 119)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 120;
				}
				if (num == 117)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 118;
				}
				if (num == 116)
				{
					registryKey2.SetValue("MUIVerb", "Mixed Reality");
					num = 117;
				}
				if (num == 115)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\14Mixed");
					num = 116;
				}
				if (num == 113)
				{
					registryKey3.Close();
					num = 114;
				}
				if (num == 112)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 113;
				}
				if (num == 111)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 112;
				}
				if (num == 109)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 110;
				}
				if (num == 108)
				{
					registryKey2.SetValue("MUIVerb", "Update && security");
					num = 109;
				}
				if (num == 107)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\13Update");
					num = 108;
				}
				if (num == 105)
				{
					registryKey3.Close();
					num = 106;
				}
				if (num == 104)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 105;
				}
				if (num == 103)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 104;
				}
				if (num == 101)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 102;
				}
				if (num == 100)
				{
					registryKey2.SetValue("MUIVerb", "Privacy");
					num = 101;
				}
				if (num == 98)
				{
					registryKey2.Close();
					num = 99;
				}
				if (num == 97)
				{
					registryKey3.Close();
					num = 98;
				}
				if (num == 96)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 97;
				}
				if (num == 94)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:cortana");
					num = 95;
				}
				if (num == 93)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 94;
				}
				if (num == 92)
				{
					registryKey2.SetValue("MUIVerb", "Cortana");
					num = 93;
				}
				if (num == 90)
				{
					registryKey2.Close();
					num = 91;
				}
				if (num == 89)
				{
					registryKey3.Close();
					num = 90;
				}
				if (num == 88)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 89;
				}
				if (num == 86)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:easeofaccess-narrator");
					num = 87;
				}
				if (num == 85)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 86;
				}
				if (num == 84)
				{
					registryKey2.SetValue("MUIVerb", "Ease of Access");
					num = 85;
				}
				if (num == 82)
				{
					registryKey2.Close();
					num = 83;
				}
				if (num == 81)
				{
					registryKey3.Close();
					num = 82;
				}
				if (num == 79)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 80;
				}
				if (num == 78)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:gaming-gamebar");
					num = 79;
				}
				if (num == 77)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 78;
				}
				if (num == 75)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\09Gaming");
					num = 76;
				}
				if (num == 74)
				{
					registryKey2.Close();
					num = 75;
				}
				if (num == 73)
				{
					registryKey3.Close();
					num = 74;
				}
				if (num == 71)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 72;
				}
				if (num == 70)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:dateandtime");
					num = 71;
				}
				if (num == 69)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 70;
				}
				if (num == 67)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\08Time");
					num = 68;
				}
				if (num == 66)
				{
					registryKey2.Close();
					num = 67;
				}
				if (num == 65)
				{
					registryKey3.Close();
					num = 66;
				}
				if (num == 63)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 64;
				}
				if (num == 62)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:yourinfo");
					num = 63;
				}
				if (num == 61)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 62;
				}
				if (num == 59)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\07Accounts");
					num = 60;
				}
				if (num == 58)
				{
					registryKey2.Close();
					num = 59;
				}
				if (num == 56)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 57;
				}
				if (num == 55)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 56;
				}
				if (num == 54)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:appsfeatures");
					num = 55;
				}
				if (num == 52)
				{
					registryKey2.SetValue("MUIVerb", "Apps");
					num = 53;
				}
				if (num == 51)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\06Apps");
					num = 52;
				}
				if (num == 50)
				{
					registryKey2.Close();
					num = 51;
				}
				if (num == 48)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 49;
				}
				if (num == 47)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 48;
				}
				if (num == 46)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:personalization");
					num = 47;
				}
				if (num == 44)
				{
					registryKey2.SetValue("MUIVerb", "Personalization");
					num = 45;
				}
				if (num == 43)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\05Personalization");
					num = 44;
				}
				if (num == 42)
				{
					registryKey2.Close();
					num = 43;
				}
				if (num == 40)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 41;
				}
				if (num == 39)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 40;
				}
				if (num == 37)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 38;
				}
				if (num == 36)
				{
					registryKey2.SetValue("MUIVerb", "Network && Internet");
					num = 37;
				}
				if (num == 35)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\04Network");
					num = 36;
				}
				if (num == 33)
				{
					registryKey3.Close();
					num = 34;
				}
				if (num == 32)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 33;
				}
				if (num == 31)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 32;
				}
				if (num == 29)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 30;
				}
				if (num == 28)
				{
					registryKey2.SetValue("MUIVerb", "Devices");
					num = 29;
				}
				if (num == 27)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\03Devices");
					num = 28;
				}
				if (num == 25)
				{
					registryKey3.Close();
					num = 26;
				}
				if (num == 24)
				{
					registryKey3.SetValue("DelegateExecute", "{556FF0D6-A1EE-49E5-9FA4-90AE116AD744}");
					num = 25;
				}
				if (num == 23)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 24;
				}
				if (num == 21)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:display");
					num = 22;
				}
				if (num == 20)
				{
					registryKey2.SetValue("Icon", "bootux.dll,-1032");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\02System");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2.Close();
					num = 18;
				}
				if (num == 16)
				{
					registryKey3.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 15;
				}
				if (num == 13)
				{
					registryKey2.SetValue("SettingsURI", "ms-settings:");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "SystemSettingsBroker.exe");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\01Settings");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Settings");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_DE8;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.settings.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 130)
				{
					break;
				}
				continue;
				IL_DE8:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 126;
				goto IL_E04;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00028438 File Offset: 0x00026638
		private void sfc_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\SFCScannow");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "cmd.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("HasLUAShield", "");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("MUIVerb", "View log for SFC");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					goto IL_3C0;
				}
				IL_3DC:
				RegistryKey registryKey4;
				if (num == 30)
				{
					registryKey4.Close();
					num = 31;
				}
				if (num == 29)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "SFCScannow");
					num = 30;
				}
				if (num == 28)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag = registryKey4 != null;
					num = 28;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 24)
				{
					registryKey.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "PowerShell (Select-String [SR] $env:windir\\Logs\\CBS\\CBS.log -s).Line >\"$env:userprofile\\Desktop\\SFC_LOG.txt\"; Start-Process -FilePath \"notepad.exe\" -ArgumentList \"$env:userprofile\\Desktop\\SFC_LOG.txt\"");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("Icon", "notepad.exe");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\02ViewLog");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "PowerShell -windowstyle hidden -command \"Start-Process cmd -ArgumentList '/s,/k, sfc.exe /scannow' -Verb runAs\"");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("MUIVerb", "Run SFC /Scannow");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\01Scannow");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "SFC /Scannow");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_3C0;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.sfc.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_3C0:
				registryKey4 = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell");
				num = 27;
				goto IL_3DC;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000288D0 File Offset: 0x00026AD0
		private void shutdown_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			RegistryKey registryKey4;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\ShutDown");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "shell32.dll,-28");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "Shut down instantly");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "shell32.dll,-28");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					registryKey2.SetValue("Icon", "shell32.dll,-16739");
					num = 27;
				}
				if (num == 30)
				{
					registryKey3.Close();
					num = 31;
				}
				if (num == 34)
				{
					registryKey2.SetValue("Icon", "shell32.dll,-16739");
					num = 35;
				}
				if (num == 38)
				{
					registryKey2.Close();
					num = 39;
				}
				if (num == 41)
				{
					goto IL_436;
				}
				IL_43C:
				if (num == 42)
				{
					registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
					num = 43;
				}
				if (num == 40)
				{
					return;
				}
				if (num == 39)
				{
					registryKey.Close();
					num = 40;
				}
				if (num == 37)
				{
					registryKey3.Close();
					num = 38;
				}
				if (num == 36)
				{
					registryKey3.SetValue("", "shutdown -r");
					num = 37;
				}
				if (num == 35)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 36;
				}
				if (num == 33)
				{
					registryKey2.SetValue("MUIVerb", "Restart with warning");
					num = 34;
				}
				if (num == 32)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\004RestartWarning");
					num = 33;
				}
				if (num == 31)
				{
					registryKey2.Close();
					num = 32;
				}
				if (num == 29)
				{
					registryKey3.SetValue("", "shutdown -r -f -t 0");
					num = 30;
				}
				if (num == 28)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 29;
				}
				if (num == 27)
				{
					registryKey2.SetValue("CommandFlags", 32, RegistryValueKind.DWord);
					num = 28;
				}
				if (num == 25)
				{
					registryKey2.SetValue("MUIVerb", "Restart instantly");
					num = 26;
				}
				if (num == 24)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\003RestartInstantly");
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "shutdown -s");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "Shut down with warning");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\002ShutdownWarning");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "shutdown -s -f -t 0");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "shell32.dll,-28");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\001ShutdownInstantly");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "Shut Down");
					num = 7;
				}
				if (num == 5)
				{
					bool flag;
					if (!flag)
					{
						return;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_436;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.shutdown.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 43)
				{
					break;
				}
				continue;
				IL_436:
				num = 42;
				goto IL_43C;
			}
			try
			{
				using (RegistryKey registryKey5 = registryKey4.OpenSubKey("DesktopBackground\\\\shell\\\\ShutDown"))
				{
					if (registryKey5 != null)
					{
						string text = "DesktopBackground\\shell";
						using (RegistryKey registryKey6 = Registry.ClassesRoot.OpenSubKey(text, true))
						{
							registryKey6.DeleteSubKeyTree("ShutDown", true);
						}
					}
				}
			}
			finally
			{
				if (registryKey4 != null)
				{
					((IDisposable)registryKey4).Dispose();
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00028E40 File Offset: 0x00027040
		private void snip_classic_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.ClassesRoot.CreateSubKey("DesktopBackground\\shell\\SnippingTool");
					num = 4;
				}
				if (num == 7)
				{
					registryKey.SetValue("Icon", "SnippingTool.exe");
					num = 8;
				}
				RegistryKey registryKey2;
				if (num == 11)
				{
					registryKey2.SetValue("MUIVerb", "@SnippingTool.exe,-101");
					num = 12;
				}
				RegistryKey registryKey3;
				if (num == 15)
				{
					registryKey3.Close();
					num = 16;
				}
				if (num == 19)
				{
					registryKey2.SetValue("Icon", "SnippingTool.exe");
					num = 20;
				}
				if (num == 22)
				{
					registryKey3.Close();
					num = 23;
				}
				if (num == 26)
				{
					goto IL_2CE;
				}
				IL_2EA:
				RegistryKey registryKey4;
				if (num == 30)
				{
					registryKey4.Close();
					num = 31;
				}
				if (num == 29)
				{
					RegistryTools.DeleteSubKeyTree(ref registryKey4, "SnippingTool");
					num = 30;
				}
				if (num == 28)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 29;
				}
				if (num == 27)
				{
					bool flag = registryKey4 != null;
					num = 28;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 24)
				{
					registryKey.Close();
					num = 25;
				}
				if (num == 23)
				{
					registryKey2.Close();
					num = 24;
				}
				if (num == 21)
				{
					registryKey3.SetValue("", "SnippingTool.exe /clip");
					num = 22;
				}
				if (num == 20)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 21;
				}
				if (num == 18)
				{
					registryKey2.SetValue("MUIVerb", "@SnippingTool.exe,-15052");
					num = 19;
				}
				if (num == 17)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\2SnippingToolRegion");
					num = 18;
				}
				if (num == 16)
				{
					registryKey2.Close();
					num = 17;
				}
				if (num == 14)
				{
					registryKey3.SetValue("", "SnippingTool.exe");
					num = 15;
				}
				if (num == 13)
				{
					registryKey3 = registryKey2.CreateSubKey("Command");
					num = 14;
				}
				if (num == 12)
				{
					registryKey2.SetValue("Icon", "SnippingTool.exe");
					num = 13;
				}
				if (num == 10)
				{
					registryKey2 = registryKey.CreateSubKey("shell\\1SnippingTool");
					num = 11;
				}
				if (num == 9)
				{
					registryKey.SetValue("SubCommands", "");
					num = 10;
				}
				if (num == 8)
				{
					registryKey.SetValue("Position", "Bottom");
					num = 9;
				}
				if (num == 6)
				{
					registryKey.SetValue("MUIVerb", "@SnippingTool.exe,-101");
					num = 7;
				}
				if (num == 5)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 6;
				}
				if (num == 4)
				{
					bool flag2 = registryKey != null;
					num = 5;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_2CE;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.snip.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 31)
				{
					break;
				}
				continue;
				IL_2CE:
				registryKey4 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\shell", true);
				num = 27;
				goto IL_2EA;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000291C4 File Offset: 0x000273C4
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

		// Token: 0x060000E7 RID: 231 RVA: 0x0002923C File Offset: 0x0002743C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.siticoneTabControl1 = new SiticoneTabControl();
					num = 4;
				}
				if (num == 7)
				{
					this.menu_txtbox = new SiticoneTextBox();
					num = 8;
				}
				if (num == 11)
				{
					this.checkDefaultIcon = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 15)
				{
					this.checkShift = new SiticoneCheckBox();
					num = 16;
				}
				if (num == 19)
				{
					this.cmd = new RadioButton();
					num = 20;
				}
				if (num == 22)
				{
					this.folder = new RadioButton();
					num = 23;
				}
				if (num == 26)
				{
					this.label3 = new Label();
					num = 27;
				}
				if (num == 30)
				{
					this.ctxt_menu = new ListBox();
					num = 31;
				}
				if (num == 34)
				{
					this.sfc = new SiticoneCheckBox();
					num = 35;
				}
				if (num == 38)
				{
					this.shutdown = new SiticoneCheckBox();
					num = 39;
				}
				if (num == 41)
				{
					this.safe_mode = new SiticoneCheckBox();
					num = 42;
				}
				if (num == 45)
				{
					this.powershell_admin = new SiticoneCheckBox();
					num = 46;
				}
				if (num == 49)
				{
					this.hash = new SiticoneCheckBox();
					num = 50;
				}
				if (num == 53)
				{
					this.cmd_ctxt = new SiticoneCheckBox();
					num = 54;
				}
				if (num == 57)
				{
					this.app_mode = new SiticoneCheckBox();
					num = 58;
				}
				if (num == 60)
				{
					this.openFileDialog1 = new OpenFileDialog();
					num = 61;
				}
				if (num == 64)
				{
					this.siticoneTabControl1.SuspendLayout();
					num = 65;
				}
				if (num == 68)
				{
					this.ico.SuspendLayout();
					num = 69;
				}
				if (num == 72)
				{
					this.tabPage3.SuspendLayout();
					num = 73;
				}
				if (num == 76)
				{
					this.label1.ForeColor = Color.White;
					num = 77;
				}
				if (num == 80)
				{
					this.label1.TabIndex = 1;
					num = 81;
				}
				if (num == 83)
				{
					this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 84;
				}
				if (num == 87)
				{
					this.label9.Size = new Size(274, 19);
					num = 88;
				}
				if (num == 91)
				{
					this.siticoneTabControl1.Controls.Add(this.tabPage1);
					num = 92;
				}
				if (num == 95)
				{
					this.siticoneTabControl1.ItemSize = new Size(180, 40);
					num = 96;
				}
				if (num == 99)
				{
					this.siticoneTabControl1.Size = new Size(1006, 587);
					num = 100;
				}
				if (num == 102)
				{
					this.siticoneTabControl1.TabButtonHoverState.Font = new Font("Josefin Sans Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 103;
				}
				if (num == 106)
				{
					this.siticoneTabControl1.TabButtonIdleState.FillColor = Color.FromArgb(38, 38, 38);
					num = 107;
				}
				if (num == 110)
				{
					this.siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
					num = 111;
				}
				if (num == 114)
				{
					this.siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.DodgerBlue;
					num = 115;
				}
				if (num == 118)
				{
					this.siticoneTabControl1.TabMenuOrientation = 1;
					num = 119;
				}
				if (num == 121)
				{
					this.tabPage1.Controls.Add(this.txt_on_menu);
					num = 122;
				}
				if (num == 125)
				{
					this.tabPage1.Controls.Add(this.item_type);
					num = 126;
				}
				if (num == 129)
				{
					this.tabPage1.Name = "tabPage1";
					num = 130;
				}
				if (num == 133)
				{
					this.tabPage1.Text = "Add/Modify";
					num = 134;
				}
				if (num == 137)
				{
					this.save.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 138;
				}
				if (num == 141)
				{
					this.save.FillColor = Color.FromArgb(38, 38, 38);
					num = 142;
				}
				if (num == 144)
				{
					this.save.HoverState.Parent = this.save;
					num = 145;
				}
				if (num == 148)
				{
					this.save.ShadowDecoration.Parent = this.save;
					num = 149;
				}
				if (num == 152)
				{
					this.save.Click += this.save_Click;
					num = 153;
				}
				if (num == 156)
				{
					this.txt_on_menu.Name = "txt_on_menu";
					num = 157;
				}
				if (num == 160)
				{
					this.txt_on_menu.Text = "Text on Menu";
					num = 161;
				}
				if (num == 163)
				{
					this.menu_txtbox.Cursor = Cursors.IBeam;
					num = 164;
				}
				if (num == 167)
				{
					this.menu_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 168;
				}
				if (num == 171)
				{
					this.menu_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 172;
				}
				if (num == 175)
				{
					this.menu_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 176;
				}
				if (num == 179)
				{
					this.menu_txtbox.PasswordChar = '\0';
					num = 180;
				}
				if (num == 182)
				{
					this.menu_txtbox.ShadowDecoration.Parent = this.menu_txtbox;
					num = 183;
				}
				if (num == 186)
				{
					this.position.ForeColor = Color.White;
					num = 187;
				}
				if (num == 190)
				{
					this.position.TabIndex = 319;
					num = 191;
				}
				if (num == 194)
				{
					this.position_cbox.DrawMode = DrawMode.OwnerDrawFixed;
					num = 195;
				}
				if (num == 198)
				{
					this.position_cbox.FocusedState.Parent = this.position_cbox;
					num = 199;
				}
				if (num == 202)
				{
					this.position_cbox.ItemHeight = 30;
					num = 203;
				}
				if (num == 205)
				{
					this.position_cbox.Location = new Point(6, 30);
					num = 206;
				}
				if (num == 209)
				{
					this.position_cbox.StartIndex = 1;
					num = 210;
				}
				if (num == 213)
				{
					this.ico.Controls.Add(this.checkDefaultIcon);
					num = 214;
				}
				if (num == 217)
				{
					this.ico.Location = new Point(24, 264);
					num = 218;
				}
				if (num == 221)
				{
					this.ico.TabStop = false;
					num = 222;
				}
				if (num == 224)
				{
					this.checkDefaultIcon.Checked = true;
					num = 225;
				}
				if (num == 228)
				{
					this.checkDefaultIcon.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 229;
				}
				if (num == 232)
				{
					this.checkDefaultIcon.Size = new Size(212, 28);
					num = 233;
				}
				if (num == 236)
				{
					this.checkDefaultIcon.UncheckedState.BorderRadius = 0;
					num = 237;
				}
				if (num == 240)
				{
					this.icon_txtbox.BackColor = Color.Transparent;
					num = 241;
				}
				if (num == 243)
				{
					this.icon_txtbox.DefaultText = "";
					num = 244;
				}
				if (num == 247)
				{
					this.icon_txtbox.DisabledState.Parent = this.icon_txtbox;
					num = 248;
				}
				if (num == 251)
				{
					this.icon_txtbox.FocusedState.Parent = this.icon_txtbox;
					num = 252;
				}
				if (num == 255)
				{
					this.icon_txtbox.HoverState.Parent = this.icon_txtbox;
					num = 256;
				}
				if (num == 259)
				{
					this.icon_txtbox.PlaceholderText = "";
					num = 260;
				}
				if (num == 262)
				{
					this.icon_txtbox.ShadowDecoration.Parent = this.icon_txtbox;
					num = 263;
				}
				if (num == 266)
				{
					this.icon_browse.CustomImages.Parent = this.icon_browse;
					num = 267;
				}
				if (num == 270)
				{
					this.icon_browse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 271;
				}
				if (num == 274)
				{
					this.icon_browse.ForeColor = Color.White;
					num = 275;
				}
				if (num == 278)
				{
					this.icon_browse.Name = "icon_browse";
					num = 279;
				}
				if (num == 282)
				{
					this.icon_browse.Text = "Browse...";
					num = 283;
				}
				if (num == 285)
				{
					this.add_grpbox.Controls.Add(this.to_add);
					num = 286;
				}
				if (num == 289)
				{
					this.add_grpbox.Name = "add_grpbox";
					num = 290;
				}
				if (num == 293)
				{
					this.add_grpbox.Text = "Program to add";
					num = 294;
				}
				if (num == 297)
				{
					this.checkShift.CheckedState.BorderThickness = 0;
					num = 298;
				}
				if (num == 301)
				{
					this.checkShift.Size = new Size(271, 28);
					num = 302;
				}
				if (num == 304)
				{
					this.checkShift.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 305;
				}
				if (num == 308)
				{
					this.to_add.BackColor = Color.Transparent;
					num = 309;
				}
				if (num == 312)
				{
					this.to_add.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 313;
				}
				if (num == 316)
				{
					this.to_add.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 317;
				}
				if (num == 320)
				{
					this.to_add.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 321;
				}
				if (num == 323)
				{
					this.to_add.HoverState.Parent = this.to_add;
					num = 324;
				}
				if (num == 327)
				{
					this.to_add.PlaceholderText = "";
					num = 328;
				}
				if (num == 331)
				{
					this.to_add.Size = new Size(647, 28);
					num = 332;
				}
				if (num == 335)
				{
					this.browse.DisabledState.BorderColor = Color.DarkGray;
					num = 336;
				}
				if (num == 339)
				{
					this.browse.DisabledState.Parent = this.browse;
					num = 340;
				}
				if (num == 343)
				{
					this.browse.HoverState.Parent = this.browse;
					num = 344;
				}
				if (num == 346)
				{
					this.browse.Name = "browse";
					num = 347;
				}
				if (num == 350)
				{
					this.browse.Text = "Browse...";
					num = 351;
				}
				if (num == 354)
				{
					this.item_type.Controls.Add(this.link);
					num = 355;
				}
				if (num == 358)
				{
					this.item_type.Location = new Point(24, 51);
					num = 359;
				}
				if (num == 362)
				{
					this.item_type.TabStop = false;
					num = 363;
				}
				if (num == 365)
				{
					this.cmd.Location = new Point(26, 26);
					num = 366;
				}
				if (num == 369)
				{
					this.cmd.Text = "Command";
					num = 370;
				}
				if (num == 373)
				{
					this.file.Location = new Point(238, 26);
					num = 374;
				}
				if (num == 377)
				{
					this.file.Text = "File";
					num = 378;
				}
				if (num == 381)
				{
					this.link.Location = new Point(594, 26);
					num = 382;
				}
				if (num == 384)
				{
					this.link.TabIndex = 2;
					num = 385;
				}
				if (num == 388)
				{
					this.folder.AutoSize = true;
					num = 389;
				}
				if (num == 392)
				{
					this.folder.TabIndex = 1;
					num = 393;
				}
				if (num == 396)
				{
					this.program.AutoSize = true;
					num = 397;
				}
				if (num == 400)
				{
					this.program.Size = new Size(87, 28);
					num = 401;
				}
				if (num == 404)
				{
					this.program.UseVisualStyleBackColor = true;
					num = 405;
				}
				if (num == 407)
				{
					this.label2.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 408;
				}
				if (num == 411)
				{
					this.label2.Size = new Size(201, 33);
					num = 412;
				}
				if (num == 415)
				{
					this.tabPage2.Controls.Add(this.label3);
					num = 416;
				}
				if (num == 419)
				{
					this.tabPage2.Controls.Add(this.ctxt_menu);
					num = 420;
				}
				if (num == 423)
				{
					this.tabPage2.Size = new Size(998, 539);
					num = 424;
				}
				if (num == 426)
				{
					this.label3.AutoSize = true;
					num = 427;
				}
				if (num == 430)
				{
					this.label3.Name = "label3";
					num = 431;
				}
				if (num == 434)
				{
					this.del_all.CheckedState.Parent = this.del_all;
					num = 435;
				}
				if (num == 438)
				{
					this.del_all.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 439;
				}
				if (num == 442)
				{
					this.del_all.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 443;
				}
				if (num == 445)
				{
					this.del_all.ImageSize = new Size(30, 30);
					num = 446;
				}
				if (num == 449)
				{
					this.del_all.Size = new Size(256, 38);
					num = 450;
				}
				if (num == 453)
				{
					this.delete.CheckedState.Parent = this.delete;
					num = 454;
				}
				if (num == 457)
				{
					this.delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 458;
				}
				if (num == 461)
				{
					this.delete.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 462;
				}
				if (num == 464)
				{
					this.delete.ImageSize = new Size(30, 30);
					num = 465;
				}
				if (num == 468)
				{
					this.delete.Size = new Size(256, 38);
					num = 469;
				}
				if (num == 472)
				{
					this.refresh_list.CheckedState.Parent = this.refresh_list;
					num = 473;
				}
				if (num == 476)
				{
					this.refresh_list.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 477;
				}
				if (num == 480)
				{
					this.refresh_list.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 481;
				}
				if (num == 484)
				{
					this.refresh_list.Location = new Point(434, 58);
					num = 485;
				}
				if (num == 487)
				{
					this.refresh_list.Size = new Size(256, 38);
					num = 488;
				}
				if (num == 491)
				{
					this.ctxt_menu.BackColor = Color.FromArgb(38, 38, 38);
					num = 492;
				}
				if (num == 495)
				{
					this.ctxt_menu.ItemHeight = 25;
					num = 496;
				}
				if (num == 499)
				{
					this.ctxt_menu.TabIndex = 46;
					num = 500;
				}
				if (num == 503)
				{
					this.tabPage3.Controls.Add(this.sfc);
					num = 504;
				}
				if (num == 506)
				{
					this.tabPage3.Controls.Add(this.snip_classic);
					num = 507;
				}
				if (num == 510)
				{
					this.tabPage3.Controls.Add(this.safe_mode);
					num = 511;
				}
				if (num == 514)
				{
					this.tabPage3.Controls.Add(this.powershell_admin);
					num = 515;
				}
				if (num == 518)
				{
					this.tabPage3.Controls.Add(this.hash);
					num = 519;
				}
				if (num == 522)
				{
					this.tabPage3.Controls.Add(this.cmd_ctxt);
					num = 523;
				}
				if (num == 525)
				{
					this.tabPage3.Controls.Add(this.attributes);
					num = 526;
				}
				if (num == 529)
				{
					this.tabPage3.Location = new Point(4, 4);
					num = 530;
				}
				if (num == 533)
				{
					this.tabPage3.Text = "Presets";
					num = 534;
				}
				if (num == 537)
				{
					this.win_mode.CheckedState.BorderThickness = 0;
					num = 538;
				}
				if (num == 541)
				{
					this.win_mode.ImageAlign = ContentAlignment.MiddleLeft;
					num = 542;
				}
				if (num == 545)
				{
					this.win_mode.TabIndex = 345;
					num = 546;
				}
				if (num == 548)
				{
					this.win_mode.UncheckedState.BorderRadius = 0;
					num = 549;
				}
				if (num == 552)
				{
					this.win_tools.AutoSize = true;
					num = 553;
				}
				if (num == 556)
				{
					this.win_tools.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 557;
				}
				if (num == 560)
				{
					this.win_tools.Location = new Point(765, 149);
					num = 561;
				}
				if (num == 564)
				{
					this.win_tools.Text = "Windows Tools";
					num = 565;
				}
				if (num == 567)
				{
					this.win_tools.UncheckedState.BorderThickness = 0;
					num = 568;
				}
				if (num == 571)
				{
					this.sfc.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 572;
				}
				if (num == 575)
				{
					this.sfc.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 576;
				}
				if (num == 579)
				{
					this.sfc.Name = "sfc";
					num = 580;
				}
				if (num == 583)
				{
					this.sfc.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 584;
				}
				if (num == 586)
				{
					this.sfc.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 587;
				}
				if (num == 590)
				{
					this.taskmgr.CheckedState.BorderRadius = 0;
					num = 591;
				}
				if (num == 594)
				{
					this.taskmgr.ForeColor = Color.White;
					num = 595;
				}
				if (num == 598)
				{
					this.taskmgr.Size = new Size(133, 29);
					num = 599;
				}
				if (num == 602)
				{
					this.taskmgr.UncheckedState.BorderRadius = 0;
					num = 603;
				}
				if (num == 606)
				{
					this.takeown.AutoSize = true;
					num = 607;
				}
				if (num == 609)
				{
					this.takeown.CheckedState.BorderThickness = 0;
					num = 610;
				}
				if (num == 613)
				{
					this.takeown.ImageAlign = ContentAlignment.MiddleLeft;
					num = 614;
				}
				if (num == 617)
				{
					this.takeown.TabIndex = 341;
					num = 618;
				}
				if (num == 621)
				{
					this.takeown.UncheckedState.BorderThickness = 0;
					num = 622;
				}
				if (num == 625)
				{
					this.snip_classic.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 626;
				}
				if (num == 628)
				{
					this.snip_classic.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 629;
				}
				if (num == 632)
				{
					this.snip_classic.Location = new Point(765, 333);
					num = 633;
				}
				if (num == 636)
				{
					this.snip_classic.Text = "Snipping Tool";
					num = 637;
				}
				if (num == 640)
				{
					this.snip_classic.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 641;
				}
				if (num == 644)
				{
					this.shutdown.CheckedState.BorderRadius = 0;
					num = 645;
				}
				if (num == 647)
				{
					this.shutdown.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 648;
				}
				if (num == 651)
				{
					this.shutdown.Name = "shutdown";
					num = 652;
				}
				if (num == 655)
				{
					this.shutdown.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 656;
				}
				if (num == 659)
				{
					this.shutdown.CheckedChanged += this.shutdown_CheckedChanged;
					num = 660;
				}
				if (num == 663)
				{
					this.settings.CheckedState.BorderThickness = 0;
					num = 664;
				}
				if (num == 666)
				{
					this.settings.ForeColor = Color.White;
					num = 667;
				}
				if (num == 670)
				{
					this.settings.Size = new Size(90, 29);
					num = 671;
				}
				if (num == 674)
				{
					this.settings.UncheckedState.BorderRadius = 0;
					num = 675;
				}
				if (num == 678)
				{
					this.snip.AutoSize = true;
					num = 679;
				}
				if (num == 682)
				{
					this.snip.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 683;
				}
				if (num == 686)
				{
					this.snip.Location = new Point(402, 425);
					num = 687;
				}
				if (num == 689)
				{
					this.snip.TabIndex = 337;
					num = 690;
				}
				if (num == 693)
				{
					this.snip.UncheckedState.BorderThickness = 0;
					num = 694;
				}
				if (num == 697)
				{
					this.safe_mode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 698;
				}
				if (num == 701)
				{
					this.safe_mode.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 702;
				}
				if (num == 705)
				{
					this.safe_mode.Name = "safe_mode";
					num = 706;
				}
				if (num == 708)
				{
					this.safe_mode.Text = "Safe Mode";
					num = 709;
				}
				if (num == 712)
				{
					this.safe_mode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 713;
				}
				if (num == 716)
				{
					this.run_priority.CheckedState.BorderRadius = 0;
					num = 717;
				}
				if (num == 720)
				{
					this.run_priority.ForeColor = Color.White;
					num = 721;
				}
				if (num == 724)
				{
					this.run_priority.Size = new Size(153, 29);
					num = 725;
				}
				if (num == 727)
				{
					this.run_priority.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 728;
				}
				if (num == 731)
				{
					this.run_priority.CheckedChanged += this.run_priority_CheckedChanged;
					num = 732;
				}
				if (num == 735)
				{
					this.res_startmenu.CheckedState.BorderThickness = 0;
					num = 736;
				}
				if (num == 739)
				{
					this.res_startmenu.ImageAlign = ContentAlignment.MiddleLeft;
					num = 740;
				}
				if (num == 743)
				{
					this.res_startmenu.TabIndex = 334;
					num = 744;
				}
				if (num == 747)
				{
					this.res_startmenu.UncheckedState.BorderThickness = 0;
					num = 748;
				}
				if (num == 750)
				{
					this.res_explorer.AutoSize = true;
					num = 751;
				}
				if (num == 754)
				{
					this.res_explorer.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 755;
				}
				if (num == 758)
				{
					this.res_explorer.Location = new Point(402, 241);
					num = 759;
				}
				if (num == 762)
				{
					this.res_explorer.Text = "Restart Explorer";
					num = 763;
				}
				if (num == 766)
				{
					this.res_explorer.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 767;
				}
				if (num == 769)
				{
					this.powershell_admin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 770;
				}
				if (num == 773)
				{
					this.powershell_admin.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 774;
				}
				if (num == 777)
				{
					this.powershell_admin.Name = "powershell_admin";
					num = 778;
				}
				if (num == 781)
				{
					this.powershell_admin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 782;
				}
				if (num == 785)
				{
					this.powershell_admin.CheckedChanged += this.powershell_admin_CheckedChanged;
					num = 786;
				}
				if (num == 788)
				{
					this.openwith_nat.CheckedState.BorderRadius = 0;
					num = 789;
				}
				if (num == 792)
				{
					this.openwith_nat.ForeColor = Color.White;
					num = 793;
				}
				if (num == 796)
				{
					this.openwith_nat.Size = new Size(248, 29);
					num = 797;
				}
				if (num == 800)
				{
					this.openwith_nat.UncheckedState.BorderRadius = 0;
					num = 801;
				}
				if (num == 804)
				{
					this.bash.AutoSize = true;
					num = 805;
				}
				if (num == 808)
				{
					this.bash.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 809;
				}
				if (num == 811)
				{
					this.bash.ImageAlign = ContentAlignment.MiddleLeft;
					num = 812;
				}
				if (num == 815)
				{
					this.bash.TabIndex = 329;
					num = 816;
				}
				if (num == 819)
				{
					this.bash.UncheckedState.BorderThickness = 0;
					num = 820;
				}
				if (num == 823)
				{
					this.kill.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 824;
				}
				if (num == 827)
				{
					this.kill.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 828;
				}
				if (num == 830)
				{
					this.kill.Location = new Point(402, 57);
					num = 831;
				}
				if (num == 834)
				{
					this.kill.Text = "Kill Not Responding Tasks";
					num = 835;
				}
				if (num == 838)
				{
					this.kill.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 839;
				}
				if (num == 842)
				{
					this.hash.CheckedState.BorderRadius = 0;
					num = 843;
				}
				if (num == 846)
				{
					this.hash.ForeColor = Color.White;
					num = 847;
				}
				if (num == 849)
				{
					this.hash.Name = "hash";
					num = 850;
				}
				if (num == 853)
				{
					this.hash.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 854;
				}
				if (num == 857)
				{
					this.hash.CheckedChanged += this.hash_CheckedChanged;
					num = 858;
				}
				if (num == 861)
				{
					this.control_pnl.CheckedState.BorderThickness = 0;
					num = 862;
				}
				if (num == 865)
				{
					this.control_pnl.ImageAlign = ContentAlignment.MiddleLeft;
					num = 866;
				}
				if (num == 868)
				{
					this.control_pnl.Size = new Size(130, 29);
					num = 869;
				}
				if (num == 872)
				{
					this.control_pnl.UncheckedState.BorderRadius = 0;
					num = 873;
				}
				if (num == 876)
				{
					this.compact.AutoSize = true;
					num = 877;
				}
				if (num == 880)
				{
					this.compact.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 881;
				}
				if (num == 884)
				{
					this.compact.Location = new Point(34, 379);
					num = 885;
				}
				if (num == 888)
				{
					this.compact.Text = "CompactOS";
					num = 889;
				}
				if (num == 891)
				{
					this.compact.UncheckedState.BorderThickness = 0;
					num = 892;
				}
				if (num == 895)
				{
					this.cmd_ctxt_admin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 896;
				}
				if (num == 899)
				{
					this.cmd_ctxt_admin.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 900;
				}
				if (num == 903)
				{
					this.cmd_ctxt_admin.Name = "cmd_ctxt_admin";
					num = 904;
				}
				if (num == 907)
				{
					this.cmd_ctxt_admin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 908;
				}
				if (num == 910)
				{
					this.cmd_ctxt_admin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 911;
				}
				if (num == 914)
				{
					this.cmd_ctxt.CheckedState.BorderRadius = 0;
					num = 915;
				}
				if (num == 918)
				{
					this.cmd_ctxt.ForeColor = Color.White;
					num = 919;
				}
				if (num == 922)
				{
					this.cmd_ctxt.Size = new Size(162, 29);
					num = 923;
				}
				if (num == 926)
				{
					this.cmd_ctxt.UncheckedState.BorderRadius = 0;
					num = 927;
				}
				if (num == 929)
				{
					this.cmd_ctxt.CheckedChanged += this.cmd_ctxt_CheckedChanged;
					num = 930;
				}
				if (num == 933)
				{
					this.clip.CheckedState.BorderThickness = 0;
					num = 934;
				}
				if (num == 937)
				{
					this.clip.ImageAlign = ContentAlignment.MiddleLeft;
					num = 938;
				}
				if (num == 941)
				{
					this.clip.TabIndex = 322;
					num = 942;
				}
				if (num == 945)
				{
					this.clip.UncheckedState.BorderThickness = 0;
					num = 946;
				}
				if (num == 949)
				{
					this.bt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 950;
				}
				if (num == 952)
				{
					this.bt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 953;
				}
				if (num == 956)
				{
					this.bt.Location = new Point(34, 195);
					num = 957;
				}
				if (num == 960)
				{
					this.bt.Text = "Bluetooth";
					num = 961;
				}
				if (num == 964)
				{
					this.bt.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 965;
				}
				if (num == 968)
				{
					this.attributes.CheckedState.BorderRadius = 0;
					num = 969;
				}
				if (num == 971)
				{
					this.attributes.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 972;
				}
				if (num == 975)
				{
					this.attributes.Name = "attributes";
					num = 976;
				}
				if (num == 979)
				{
					this.attributes.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 980;
				}
				if (num == 983)
				{
					this.attributes.CheckedChanged += this.attributes_CheckedChanged;
					num = 984;
				}
				if (num == 987)
				{
					this.app_mode.CheckedState.BorderThickness = 0;
					num = 988;
				}
				if (num == 990)
				{
					this.app_mode.ForeColor = Color.White;
					num = 991;
				}
				if (num == 994)
				{
					this.app_mode.Size = new Size(106, 29);
					num = 995;
				}
				if (num == 998)
				{
					this.app_mode.UncheckedState.BorderRadius = 0;
					num = 999;
				}
				if (num == 1002)
				{
					this.adv_startup.AutoSize = true;
					num = 1003;
				}
				if (num == 1006)
				{
					this.adv_startup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1007;
				}
				if (num == 1010)
				{
					this.adv_startup.Location = new Point(34, 57);
					num = 1011;
				}
				if (num == 1013)
				{
					this.adv_startup.TabIndex = 318;
					num = 1014;
				}
				if (num == 1017)
				{
					this.adv_startup.UncheckedState.BorderThickness = 0;
					num = 1018;
				}
				if (num == 1021)
				{
					this.label4.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1022;
				}
				if (num == 1025)
				{
					this.label4.Size = new Size(84, 33);
					num = 1026;
				}
				if (num == 1029)
				{
					this.openFileDialog1.FileOk += this.openFileDialog1_FileOk;
					num = 1030;
				}
				if (num == 1032)
				{
					this.icon_dialog.FileName = "openFileDialog2";
					num = 1033;
				}
				if (num == 1036)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 1037;
				}
				if (num == 1040)
				{
					base.Name = "context";
					num = 1041;
				}
				if (num == 1044)
				{
					this.tabPage1.ResumeLayout(false);
					num = 1045;
				}
				if (num == 1048)
				{
					this.ico.ResumeLayout(false);
					num = 1049;
				}
				if (num == 1051)
				{
					this.add_grpbox.PerformLayout();
					num = 1052;
				}
				if (num == 1055)
				{
					this.tabPage2.PerformLayout();
					num = 1056;
				}
				if (num == 1059)
				{
					base.PerformLayout();
					num = 1060;
				}
				if (num == 1058)
				{
					base.ResumeLayout(false);
					num = 1059;
				}
				if (num == 1057)
				{
					this.tabPage3.PerformLayout();
					num = 1058;
				}
				if (num == 1056)
				{
					this.tabPage3.ResumeLayout(false);
					num = 1057;
				}
				if (num == 1054)
				{
					this.tabPage2.ResumeLayout(false);
					num = 1055;
				}
				if (num == 1053)
				{
					this.item_type.PerformLayout();
					num = 1054;
				}
				if (num == 1052)
				{
					this.item_type.ResumeLayout(false);
					num = 1053;
				}
				if (num == 1050)
				{
					this.add_grpbox.ResumeLayout(false);
					num = 1051;
				}
				if (num == 1049)
				{
					this.ico.PerformLayout();
					num = 1050;
				}
				if (num == 1047)
				{
					this.position.ResumeLayout(false);
					num = 1048;
				}
				if (num == 1046)
				{
					this.txt_on_menu.ResumeLayout(false);
					num = 1047;
				}
				if (num == 1045)
				{
					this.tabPage1.PerformLayout();
					num = 1046;
				}
				if (num == 1043)
				{
					this.siticoneTabControl1.ResumeLayout(false);
					num = 1044;
				}
				if (num == 1042)
				{
					base.Load += this.context_Load;
					num = 1043;
				}
				if (num == 1041)
				{
					base.Size = new Size(1006, 679);
					num = 1042;
				}
				if (num == 1039)
				{
					base.Controls.Add(this.label1);
					num = 1040;
				}
				if (num == 1038)
				{
					base.Controls.Add(this.label9);
					num = 1039;
				}
				if (num == 1037)
				{
					base.Controls.Add(this.siticoneTabControl1);
					num = 1038;
				}
				if (num == 1035)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 1036;
				}
				if (num == 1034)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 1035;
				}
				if (num == 1033)
				{
					this.icon_dialog.FileOk += this.icon_dialog_FileOk;
					num = 1034;
				}
				if (num == 1031)
				{
					this.file_browse.FileOk += this.file_browse_FileOk;
					num = 1032;
				}
				if (num == 1030)
				{
					this.file_browse.FileName = "openFileDialog2";
					num = 1031;
				}
				if (num == 1028)
				{
					this.openFileDialog1.FileName = "openFileDialog1";
					num = 1029;
				}
				if (num == 1027)
				{
					this.label4.Text = "Presets";
					num = 1028;
				}
				if (num == 1026)
				{
					this.label4.TabIndex = 316;
					num = 1027;
				}
				if (num == 1024)
				{
					this.label4.Name = "label4";
					num = 1025;
				}
				if (num == 1023)
				{
					this.label4.Location = new Point(18, 3);
					num = 1024;
				}
				if (num == 1022)
				{
					this.label4.ForeColor = Color.White;
					num = 1023;
				}
				if (num == 1020)
				{
					this.label4.AutoSize = true;
					num = 1021;
				}
				if (num == 1019)
				{
					this.adv_startup.CheckedChanged += this.adv_startup_CheckedChanged;
					num = 1020;
				}
				if (num == 1018)
				{
					this.adv_startup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1019;
				}
				if (num == 1016)
				{
					this.adv_startup.UncheckedState.BorderRadius = 0;
					num = 1017;
				}
				if (num == 1015)
				{
					this.adv_startup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1016;
				}
				if (num == 1014)
				{
					this.adv_startup.Text = "Advanced Startup Options";
					num = 1015;
				}
				if (num == 1012)
				{
					this.adv_startup.Size = new Size(223, 29);
					num = 1013;
				}
				if (num == 1011)
				{
					this.adv_startup.Name = "adv_startup";
					num = 1012;
				}
				if (num == 1009)
				{
					this.adv_startup.ImageAlign = ContentAlignment.MiddleLeft;
					num = 1010;
				}
				if (num == 1008)
				{
					this.adv_startup.ForeColor = Color.White;
					num = 1009;
				}
				if (num == 1007)
				{
					this.adv_startup.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1008;
				}
				if (num == 1005)
				{
					this.adv_startup.CheckedState.BorderThickness = 0;
					num = 1006;
				}
				if (num == 1004)
				{
					this.adv_startup.CheckedState.BorderRadius = 0;
					num = 1005;
				}
				if (num == 1003)
				{
					this.adv_startup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1004;
				}
				if (num == 1001)
				{
					this.app_mode.CheckedChanged += this.app_mode_CheckedChanged;
					num = 1002;
				}
				if (num == 1000)
				{
					this.app_mode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1001;
				}
				if (num == 999)
				{
					this.app_mode.UncheckedState.BorderThickness = 0;
					num = 1000;
				}
				if (num == 997)
				{
					this.app_mode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 998;
				}
				if (num == 996)
				{
					this.app_mode.Text = "App Mode";
					num = 997;
				}
				if (num == 995)
				{
					this.app_mode.TabIndex = 319;
					num = 996;
				}
				if (num == 993)
				{
					this.app_mode.Name = "app_mode";
					num = 994;
				}
				if (num == 992)
				{
					this.app_mode.Location = new Point(34, 103);
					num = 993;
				}
				if (num == 991)
				{
					this.app_mode.ImageAlign = ContentAlignment.MiddleLeft;
					num = 992;
				}
				if (num == 989)
				{
					this.app_mode.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 990;
				}
				if (num == 988)
				{
					this.app_mode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 989;
				}
				if (num == 986)
				{
					this.app_mode.CheckedState.BorderRadius = 0;
					num = 987;
				}
				if (num == 985)
				{
					this.app_mode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 986;
				}
				if (num == 984)
				{
					this.app_mode.AutoSize = true;
					num = 985;
				}
				if (num == 982)
				{
					this.attributes.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 983;
				}
				if (num == 981)
				{
					this.attributes.UncheckedState.BorderThickness = 0;
					num = 982;
				}
				if (num == 980)
				{
					this.attributes.UncheckedState.BorderRadius = 0;
					num = 981;
				}
				if (num == 978)
				{
					this.attributes.Text = "Attributes";
					num = 979;
				}
				if (num == 977)
				{
					this.attributes.TabIndex = 320;
					num = 978;
				}
				if (num == 976)
				{
					this.attributes.Size = new Size(103, 29);
					num = 977;
				}
				if (num == 974)
				{
					this.attributes.Location = new Point(34, 149);
					num = 975;
				}
				if (num == 973)
				{
					this.attributes.ImageAlign = ContentAlignment.MiddleLeft;
					num = 974;
				}
				if (num == 972)
				{
					this.attributes.ForeColor = Color.White;
					num = 973;
				}
				if (num == 970)
				{
					this.attributes.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 971;
				}
				if (num == 969)
				{
					this.attributes.CheckedState.BorderThickness = 0;
					num = 970;
				}
				if (num == 967)
				{
					this.attributes.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 968;
				}
				if (num == 966)
				{
					this.attributes.AutoSize = true;
					num = 967;
				}
				if (num == 965)
				{
					this.bt.CheckedChanged += this.bt_CheckedChanged;
					num = 966;
				}
				if (num == 963)
				{
					this.bt.UncheckedState.BorderThickness = 0;
					num = 964;
				}
				if (num == 962)
				{
					this.bt.UncheckedState.BorderRadius = 0;
					num = 963;
				}
				if (num == 961)
				{
					this.bt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 962;
				}
				if (num == 959)
				{
					this.bt.TabIndex = 321;
					num = 960;
				}
				if (num == 958)
				{
					this.bt.Size = new Size(101, 29);
					num = 959;
				}
				if (num == 957)
				{
					this.bt.Name = "bt";
					num = 958;
				}
				if (num == 955)
				{
					this.bt.ImageAlign = ContentAlignment.MiddleLeft;
					num = 956;
				}
				if (num == 954)
				{
					this.bt.ForeColor = Color.White;
					num = 955;
				}
				if (num == 953)
				{
					this.bt.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 954;
				}
				if (num == 951)
				{
					this.bt.CheckedState.BorderThickness = 0;
					num = 952;
				}
				if (num == 950)
				{
					this.bt.CheckedState.BorderRadius = 0;
					num = 951;
				}
				if (num == 948)
				{
					this.bt.AutoSize = true;
					num = 949;
				}
				if (num == 947)
				{
					this.clip.CheckedChanged += this.clip_CheckedChanged;
					num = 948;
				}
				if (num == 946)
				{
					this.clip.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 947;
				}
				if (num == 944)
				{
					this.clip.UncheckedState.BorderRadius = 0;
					num = 945;
				}
				if (num == 943)
				{
					this.clip.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 944;
				}
				if (num == 942)
				{
					this.clip.Text = "Clipboard History";
					num = 943;
				}
				if (num == 940)
				{
					this.clip.Size = new Size(159, 29);
					num = 941;
				}
				if (num == 939)
				{
					this.clip.Name = "clip";
					num = 940;
				}
				if (num == 938)
				{
					this.clip.Location = new Point(34, 241);
					num = 939;
				}
				if (num == 936)
				{
					this.clip.ForeColor = Color.White;
					num = 937;
				}
				if (num == 935)
				{
					this.clip.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 936;
				}
				if (num == 934)
				{
					this.clip.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 935;
				}
				if (num == 932)
				{
					this.clip.CheckedState.BorderRadius = 0;
					num = 933;
				}
				if (num == 931)
				{
					this.clip.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 932;
				}
				if (num == 930)
				{
					this.clip.AutoSize = true;
					num = 931;
				}
				if (num == 928)
				{
					this.cmd_ctxt.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 929;
				}
				if (num == 927)
				{
					this.cmd_ctxt.UncheckedState.BorderThickness = 0;
					num = 928;
				}
				if (num == 925)
				{
					this.cmd_ctxt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 926;
				}
				if (num == 924)
				{
					this.cmd_ctxt.Text = "Command Prompt";
					num = 925;
				}
				if (num == 923)
				{
					this.cmd_ctxt.TabIndex = 323;
					num = 924;
				}
				if (num == 921)
				{
					this.cmd_ctxt.Name = "cmd_ctxt";
					num = 922;
				}
				if (num == 920)
				{
					this.cmd_ctxt.Location = new Point(34, 287);
					num = 921;
				}
				if (num == 919)
				{
					this.cmd_ctxt.ImageAlign = ContentAlignment.MiddleLeft;
					num = 920;
				}
				if (num == 917)
				{
					this.cmd_ctxt.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 918;
				}
				if (num == 916)
				{
					this.cmd_ctxt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 917;
				}
				if (num == 915)
				{
					this.cmd_ctxt.CheckedState.BorderThickness = 0;
					num = 916;
				}
				if (num == 913)
				{
					this.cmd_ctxt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 914;
				}
				if (num == 912)
				{
					this.cmd_ctxt.AutoSize = true;
					num = 913;
				}
				if (num == 911)
				{
					this.cmd_ctxt_admin.CheckedChanged += this.cmd_ctxt_admin_CheckedChanged;
					num = 912;
				}
				if (num == 909)
				{
					this.cmd_ctxt_admin.UncheckedState.BorderThickness = 0;
					num = 910;
				}
				if (num == 908)
				{
					this.cmd_ctxt_admin.UncheckedState.BorderRadius = 0;
					num = 909;
				}
				if (num == 906)
				{
					this.cmd_ctxt_admin.Text = "Command Prompt (As Admin)";
					num = 907;
				}
				if (num == 905)
				{
					this.cmd_ctxt_admin.TabIndex = 324;
					num = 906;
				}
				if (num == 904)
				{
					this.cmd_ctxt_admin.Size = new Size(248, 29);
					num = 905;
				}
				if (num == 902)
				{
					this.cmd_ctxt_admin.Location = new Point(34, 333);
					num = 903;
				}
				if (num == 901)
				{
					this.cmd_ctxt_admin.ImageAlign = ContentAlignment.MiddleLeft;
					num = 902;
				}
				if (num == 900)
				{
					this.cmd_ctxt_admin.ForeColor = Color.White;
					num = 901;
				}
				if (num == 898)
				{
					this.cmd_ctxt_admin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 899;
				}
				if (num == 897)
				{
					this.cmd_ctxt_admin.CheckedState.BorderThickness = 0;
					num = 898;
				}
				if (num == 896)
				{
					this.cmd_ctxt_admin.CheckedState.BorderRadius = 0;
					num = 897;
				}
				if (num == 894)
				{
					this.cmd_ctxt_admin.AutoSize = true;
					num = 895;
				}
				if (num == 893)
				{
					this.compact.CheckedChanged += this.compact_CheckedChanged;
					num = 894;
				}
				if (num == 892)
				{
					this.compact.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 893;
				}
				if (num == 890)
				{
					this.compact.UncheckedState.BorderRadius = 0;
					num = 891;
				}
				if (num == 889)
				{
					this.compact.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 890;
				}
				if (num == 887)
				{
					this.compact.TabIndex = 325;
					num = 888;
				}
				if (num == 886)
				{
					this.compact.Size = new Size(118, 29);
					num = 887;
				}
				if (num == 885)
				{
					this.compact.Name = "compact";
					num = 886;
				}
				if (num == 883)
				{
					this.compact.ImageAlign = ContentAlignment.MiddleLeft;
					num = 884;
				}
				if (num == 882)
				{
					this.compact.ForeColor = Color.White;
					num = 883;
				}
				if (num == 881)
				{
					this.compact.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 882;
				}
				if (num == 879)
				{
					this.compact.CheckedState.BorderThickness = 0;
					num = 880;
				}
				if (num == 878)
				{
					this.compact.CheckedState.BorderRadius = 0;
					num = 879;
				}
				if (num == 877)
				{
					this.compact.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 878;
				}
				if (num == 875)
				{
					this.control_pnl.CheckedChanged += this.control_pnl_CheckedChanged;
					num = 876;
				}
				if (num == 874)
				{
					this.control_pnl.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 875;
				}
				if (num == 873)
				{
					this.control_pnl.UncheckedState.BorderThickness = 0;
					num = 874;
				}
				if (num == 871)
				{
					this.control_pnl.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 872;
				}
				if (num == 870)
				{
					this.control_pnl.Text = "Control Panel";
					num = 871;
				}
				if (num == 869)
				{
					this.control_pnl.TabIndex = 326;
					num = 870;
				}
				if (num == 867)
				{
					this.control_pnl.Name = "control_pnl";
					num = 868;
				}
				if (num == 866)
				{
					this.control_pnl.Location = new Point(34, 425);
					num = 867;
				}
				if (num == 864)
				{
					this.control_pnl.ForeColor = Color.White;
					num = 865;
				}
				if (num == 863)
				{
					this.control_pnl.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 864;
				}
				if (num == 862)
				{
					this.control_pnl.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 863;
				}
				if (num == 860)
				{
					this.control_pnl.CheckedState.BorderRadius = 0;
					num = 861;
				}
				if (num == 859)
				{
					this.control_pnl.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 860;
				}
				if (num == 858)
				{
					this.control_pnl.AutoSize = true;
					num = 859;
				}
				if (num == 856)
				{
					this.hash.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 857;
				}
				if (num == 855)
				{
					this.hash.UncheckedState.BorderThickness = 0;
					num = 856;
				}
				if (num == 854)
				{
					this.hash.UncheckedState.BorderRadius = 0;
					num = 855;
				}
				if (num == 852)
				{
					this.hash.Text = "File Hash";
					num = 853;
				}
				if (num == 851)
				{
					this.hash.TabIndex = 327;
					num = 852;
				}
				if (num == 850)
				{
					this.hash.Size = new Size(99, 29);
					num = 851;
				}
				if (num == 848)
				{
					this.hash.Location = new Point(34, 471);
					num = 849;
				}
				if (num == 847)
				{
					this.hash.ImageAlign = ContentAlignment.MiddleLeft;
					num = 848;
				}
				if (num == 845)
				{
					this.hash.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 846;
				}
				if (num == 844)
				{
					this.hash.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 845;
				}
				if (num == 843)
				{
					this.hash.CheckedState.BorderThickness = 0;
					num = 844;
				}
				if (num == 841)
				{
					this.hash.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 842;
				}
				if (num == 840)
				{
					this.hash.AutoSize = true;
					num = 841;
				}
				if (num == 839)
				{
					this.kill.CheckedChanged += this.kill_CheckedChanged;
					num = 840;
				}
				if (num == 837)
				{
					this.kill.UncheckedState.BorderThickness = 0;
					num = 838;
				}
				if (num == 836)
				{
					this.kill.UncheckedState.BorderRadius = 0;
					num = 837;
				}
				if (num == 835)
				{
					this.kill.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 836;
				}
				if (num == 833)
				{
					this.kill.TabIndex = 328;
					num = 834;
				}
				if (num == 832)
				{
					this.kill.Size = new Size(220, 29);
					num = 833;
				}
				if (num == 831)
				{
					this.kill.Name = "kill";
					num = 832;
				}
				if (num == 829)
				{
					this.kill.ImageAlign = ContentAlignment.MiddleLeft;
					num = 830;
				}
				if (num == 828)
				{
					this.kill.ForeColor = Color.White;
					num = 829;
				}
				if (num == 826)
				{
					this.kill.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 827;
				}
				if (num == 825)
				{
					this.kill.CheckedState.BorderThickness = 0;
					num = 826;
				}
				if (num == 824)
				{
					this.kill.CheckedState.BorderRadius = 0;
					num = 825;
				}
				if (num == 822)
				{
					this.kill.AutoSize = true;
					num = 823;
				}
				if (num == 821)
				{
					this.bash.CheckedChanged += this.bash_CheckedChanged;
					num = 822;
				}
				if (num == 820)
				{
					this.bash.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 821;
				}
				if (num == 818)
				{
					this.bash.UncheckedState.BorderRadius = 0;
					num = 819;
				}
				if (num == 817)
				{
					this.bash.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 818;
				}
				if (num == 816)
				{
					this.bash.Text = "Open Bash Here";
					num = 817;
				}
				if (num == 814)
				{
					this.bash.Size = new Size(151, 29);
					num = 815;
				}
				if (num == 813)
				{
					this.bash.Name = "bash";
					num = 814;
				}
				if (num == 812)
				{
					this.bash.Location = new Point(402, 103);
					num = 813;
				}
				if (num == 810)
				{
					this.bash.ForeColor = Color.White;
					num = 811;
				}
				if (num == 809)
				{
					this.bash.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 810;
				}
				if (num == 807)
				{
					this.bash.CheckedState.BorderThickness = 0;
					num = 808;
				}
				if (num == 806)
				{
					this.bash.CheckedState.BorderRadius = 0;
					num = 807;
				}
				if (num == 805)
				{
					this.bash.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 806;
				}
				if (num == 803)
				{
					this.openwith_nat.CheckedChanged += this.openwith_nat_CheckedChanged;
					num = 804;
				}
				if (num == 802)
				{
					this.openwith_nat.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 803;
				}
				if (num == 801)
				{
					this.openwith_nat.UncheckedState.BorderThickness = 0;
					num = 802;
				}
				if (num == 799)
				{
					this.openwith_nat.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 800;
				}
				if (num == 798)
				{
					this.openwith_nat.Text = "Open With for Bat/CMD Files";
					num = 799;
				}
				if (num == 797)
				{
					this.openwith_nat.TabIndex = 330;
					num = 798;
				}
				if (num == 795)
				{
					this.openwith_nat.Name = "openwith_nat";
					num = 796;
				}
				if (num == 794)
				{
					this.openwith_nat.Location = new Point(402, 149);
					num = 795;
				}
				if (num == 793)
				{
					this.openwith_nat.ImageAlign = ContentAlignment.MiddleLeft;
					num = 794;
				}
				if (num == 791)
				{
					this.openwith_nat.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 792;
				}
				if (num == 790)
				{
					this.openwith_nat.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 791;
				}
				if (num == 789)
				{
					this.openwith_nat.CheckedState.BorderThickness = 0;
					num = 790;
				}
				if (num == 787)
				{
					this.openwith_nat.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 788;
				}
				if (num == 786)
				{
					this.openwith_nat.AutoSize = true;
					num = 787;
				}
				if (num == 784)
				{
					this.powershell_admin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 785;
				}
				if (num == 783)
				{
					this.powershell_admin.UncheckedState.BorderThickness = 0;
					num = 784;
				}
				if (num == 782)
				{
					this.powershell_admin.UncheckedState.BorderRadius = 0;
					num = 783;
				}
				if (num == 780)
				{
					this.powershell_admin.Text = "Powershell (As Admin)";
					num = 781;
				}
				if (num == 779)
				{
					this.powershell_admin.TabIndex = 332;
					num = 780;
				}
				if (num == 778)
				{
					this.powershell_admin.Size = new Size(193, 29);
					num = 779;
				}
				if (num == 776)
				{
					this.powershell_admin.Location = new Point(402, 195);
					num = 777;
				}
				if (num == 775)
				{
					this.powershell_admin.ImageAlign = ContentAlignment.MiddleLeft;
					num = 776;
				}
				if (num == 774)
				{
					this.powershell_admin.ForeColor = Color.White;
					num = 775;
				}
				if (num == 772)
				{
					this.powershell_admin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 773;
				}
				if (num == 771)
				{
					this.powershell_admin.CheckedState.BorderThickness = 0;
					num = 772;
				}
				if (num == 770)
				{
					this.powershell_admin.CheckedState.BorderRadius = 0;
					num = 771;
				}
				if (num == 768)
				{
					this.powershell_admin.AutoSize = true;
					num = 769;
				}
				if (num == 767)
				{
					this.res_explorer.CheckedChanged += this.res_explorer_CheckedChanged;
					num = 768;
				}
				if (num == 765)
				{
					this.res_explorer.UncheckedState.BorderThickness = 0;
					num = 766;
				}
				if (num == 764)
				{
					this.res_explorer.UncheckedState.BorderRadius = 0;
					num = 765;
				}
				if (num == 763)
				{
					this.res_explorer.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 764;
				}
				if (num == 761)
				{
					this.res_explorer.TabIndex = 333;
					num = 762;
				}
				if (num == 760)
				{
					this.res_explorer.Size = new Size(148, 29);
					num = 761;
				}
				if (num == 759)
				{
					this.res_explorer.Name = "res_explorer";
					num = 760;
				}
				if (num == 757)
				{
					this.res_explorer.ImageAlign = ContentAlignment.MiddleLeft;
					num = 758;
				}
				if (num == 756)
				{
					this.res_explorer.ForeColor = Color.White;
					num = 757;
				}
				if (num == 755)
				{
					this.res_explorer.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 756;
				}
				if (num == 753)
				{
					this.res_explorer.CheckedState.BorderThickness = 0;
					num = 754;
				}
				if (num == 752)
				{
					this.res_explorer.CheckedState.BorderRadius = 0;
					num = 753;
				}
				if (num == 751)
				{
					this.res_explorer.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 752;
				}
				if (num == 749)
				{
					this.res_startmenu.CheckedChanged += this.res_startmenu_CheckedChanged;
					num = 750;
				}
				if (num == 748)
				{
					this.res_startmenu.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 749;
				}
				if (num == 746)
				{
					this.res_startmenu.UncheckedState.BorderRadius = 0;
					num = 747;
				}
				if (num == 745)
				{
					this.res_startmenu.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 746;
				}
				if (num == 744)
				{
					this.res_startmenu.Text = "Restart Start Menu";
					num = 745;
				}
				if (num == 742)
				{
					this.res_startmenu.Size = new Size(171, 29);
					num = 743;
				}
				if (num == 741)
				{
					this.res_startmenu.Name = "res_startmenu";
					num = 742;
				}
				if (num == 740)
				{
					this.res_startmenu.Location = new Point(402, 287);
					num = 741;
				}
				if (num == 738)
				{
					this.res_startmenu.ForeColor = Color.White;
					num = 739;
				}
				if (num == 737)
				{
					this.res_startmenu.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 738;
				}
				if (num == 736)
				{
					this.res_startmenu.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 737;
				}
				if (num == 734)
				{
					this.res_startmenu.CheckedState.BorderRadius = 0;
					num = 735;
				}
				if (num == 733)
				{
					this.res_startmenu.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 734;
				}
				if (num == 732)
				{
					this.res_startmenu.AutoSize = true;
					num = 733;
				}
				if (num == 730)
				{
					this.run_priority.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 731;
				}
				if (num == 729)
				{
					this.run_priority.UncheckedState.BorderThickness = 0;
					num = 730;
				}
				if (num == 728)
				{
					this.run_priority.UncheckedState.BorderRadius = 0;
					num = 729;
				}
				if (num == 726)
				{
					this.run_priority.Text = "Run with Priority";
					num = 727;
				}
				if (num == 725)
				{
					this.run_priority.TabIndex = 335;
					num = 726;
				}
				if (num == 723)
				{
					this.run_priority.Name = "run_priority";
					num = 724;
				}
				if (num == 722)
				{
					this.run_priority.Location = new Point(402, 333);
					num = 723;
				}
				if (num == 721)
				{
					this.run_priority.ImageAlign = ContentAlignment.MiddleLeft;
					num = 722;
				}
				if (num == 719)
				{
					this.run_priority.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 720;
				}
				if (num == 718)
				{
					this.run_priority.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 719;
				}
				if (num == 717)
				{
					this.run_priority.CheckedState.BorderThickness = 0;
					num = 718;
				}
				if (num == 715)
				{
					this.run_priority.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 716;
				}
				if (num == 714)
				{
					this.run_priority.AutoSize = true;
					num = 715;
				}
				if (num == 713)
				{
					this.safe_mode.CheckedChanged += this.safe_mode_CheckedChanged;
					num = 714;
				}
				if (num == 711)
				{
					this.safe_mode.UncheckedState.BorderThickness = 0;
					num = 712;
				}
				if (num == 710)
				{
					this.safe_mode.UncheckedState.BorderRadius = 0;
					num = 711;
				}
				if (num == 709)
				{
					this.safe_mode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 710;
				}
				if (num == 707)
				{
					this.safe_mode.TabIndex = 336;
					num = 708;
				}
				if (num == 706)
				{
					this.safe_mode.Size = new Size(109, 29);
					num = 707;
				}
				if (num == 704)
				{
					this.safe_mode.Location = new Point(402, 379);
					num = 705;
				}
				if (num == 703)
				{
					this.safe_mode.ImageAlign = ContentAlignment.MiddleLeft;
					num = 704;
				}
				if (num == 702)
				{
					this.safe_mode.ForeColor = Color.White;
					num = 703;
				}
				if (num == 700)
				{
					this.safe_mode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 701;
				}
				if (num == 699)
				{
					this.safe_mode.CheckedState.BorderThickness = 0;
					num = 700;
				}
				if (num == 698)
				{
					this.safe_mode.CheckedState.BorderRadius = 0;
					num = 699;
				}
				if (num == 696)
				{
					this.safe_mode.AutoSize = true;
					num = 697;
				}
				if (num == 695)
				{
					this.snip.CheckedChanged += this.snip_CheckedChanged;
					num = 696;
				}
				if (num == 694)
				{
					this.snip.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 695;
				}
				if (num == 692)
				{
					this.snip.UncheckedState.BorderRadius = 0;
					num = 693;
				}
				if (num == 691)
				{
					this.snip.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 692;
				}
				if (num == 690)
				{
					this.snip.Text = "Screen Snip";
					num = 691;
				}
				if (num == 688)
				{
					this.snip.Size = new Size(114, 29);
					num = 689;
				}
				if (num == 687)
				{
					this.snip.Name = "snip";
					num = 688;
				}
				if (num == 685)
				{
					this.snip.ImageAlign = ContentAlignment.MiddleLeft;
					num = 686;
				}
				if (num == 684)
				{
					this.snip.ForeColor = Color.White;
					num = 685;
				}
				if (num == 683)
				{
					this.snip.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 684;
				}
				if (num == 681)
				{
					this.snip.CheckedState.BorderThickness = 0;
					num = 682;
				}
				if (num == 680)
				{
					this.snip.CheckedState.BorderRadius = 0;
					num = 681;
				}
				if (num == 679)
				{
					this.snip.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 680;
				}
				if (num == 677)
				{
					this.settings.CheckedChanged += this.settings_CheckedChanged;
					num = 678;
				}
				if (num == 676)
				{
					this.settings.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 677;
				}
				if (num == 675)
				{
					this.settings.UncheckedState.BorderThickness = 0;
					num = 676;
				}
				if (num == 673)
				{
					this.settings.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 674;
				}
				if (num == 672)
				{
					this.settings.Text = "Settings";
					num = 673;
				}
				if (num == 671)
				{
					this.settings.TabIndex = 338;
					num = 672;
				}
				if (num == 669)
				{
					this.settings.Name = "settings";
					num = 670;
				}
				if (num == 668)
				{
					this.settings.Location = new Point(765, 195);
					num = 669;
				}
				if (num == 667)
				{
					this.settings.ImageAlign = ContentAlignment.MiddleLeft;
					num = 668;
				}
				if (num == 665)
				{
					this.settings.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 666;
				}
				if (num == 664)
				{
					this.settings.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 665;
				}
				if (num == 662)
				{
					this.settings.CheckedState.BorderRadius = 0;
					num = 663;
				}
				if (num == 661)
				{
					this.settings.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 662;
				}
				if (num == 660)
				{
					this.settings.AutoSize = true;
					num = 661;
				}
				if (num == 658)
				{
					this.shutdown.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 659;
				}
				if (num == 657)
				{
					this.shutdown.UncheckedState.BorderThickness = 0;
					num = 658;
				}
				if (num == 656)
				{
					this.shutdown.UncheckedState.BorderRadius = 0;
					num = 657;
				}
				if (num == 654)
				{
					this.shutdown.Text = "Shutdown";
					num = 655;
				}
				if (num == 653)
				{
					this.shutdown.TabIndex = 339;
					num = 654;
				}
				if (num == 652)
				{
					this.shutdown.Size = new Size(102, 29);
					num = 653;
				}
				if (num == 650)
				{
					this.shutdown.Location = new Point(765, 287);
					num = 651;
				}
				if (num == 649)
				{
					this.shutdown.ImageAlign = ContentAlignment.MiddleLeft;
					num = 650;
				}
				if (num == 648)
				{
					this.shutdown.ForeColor = Color.White;
					num = 649;
				}
				if (num == 646)
				{
					this.shutdown.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 647;
				}
				if (num == 645)
				{
					this.shutdown.CheckedState.BorderThickness = 0;
					num = 646;
				}
				if (num == 643)
				{
					this.shutdown.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 644;
				}
				if (num == 642)
				{
					this.shutdown.AutoSize = true;
					num = 643;
				}
				if (num == 641)
				{
					this.snip_classic.CheckedChanged += this.snip_classic_CheckedChanged;
					num = 642;
				}
				if (num == 639)
				{
					this.snip_classic.UncheckedState.BorderThickness = 0;
					num = 640;
				}
				if (num == 638)
				{
					this.snip_classic.UncheckedState.BorderRadius = 0;
					num = 639;
				}
				if (num == 637)
				{
					this.snip_classic.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 638;
				}
				if (num == 635)
				{
					this.snip_classic.TabIndex = 340;
					num = 636;
				}
				if (num == 634)
				{
					this.snip_classic.Size = new Size(128, 29);
					num = 635;
				}
				if (num == 633)
				{
					this.snip_classic.Name = "snip_classic";
					num = 634;
				}
				if (num == 631)
				{
					this.snip_classic.ImageAlign = ContentAlignment.MiddleLeft;
					num = 632;
				}
				if (num == 630)
				{
					this.snip_classic.ForeColor = Color.White;
					num = 631;
				}
				if (num == 629)
				{
					this.snip_classic.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 630;
				}
				if (num == 627)
				{
					this.snip_classic.CheckedState.BorderThickness = 0;
					num = 628;
				}
				if (num == 626)
				{
					this.snip_classic.CheckedState.BorderRadius = 0;
					num = 627;
				}
				if (num == 624)
				{
					this.snip_classic.AutoSize = true;
					num = 625;
				}
				if (num == 623)
				{
					this.takeown.CheckedChanged += this.takeown_CheckedChanged;
					num = 624;
				}
				if (num == 622)
				{
					this.takeown.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 623;
				}
				if (num == 620)
				{
					this.takeown.UncheckedState.BorderRadius = 0;
					num = 621;
				}
				if (num == 619)
				{
					this.takeown.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 620;
				}
				if (num == 618)
				{
					this.takeown.Text = "Take Ownership";
					num = 619;
				}
				if (num == 616)
				{
					this.takeown.Size = new Size(145, 29);
					num = 617;
				}
				if (num == 615)
				{
					this.takeown.Name = "takeown";
					num = 616;
				}
				if (num == 614)
				{
					this.takeown.Location = new Point(402, 471);
					num = 615;
				}
				if (num == 612)
				{
					this.takeown.ForeColor = Color.White;
					num = 613;
				}
				if (num == 611)
				{
					this.takeown.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 612;
				}
				if (num == 610)
				{
					this.takeown.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 611;
				}
				if (num == 608)
				{
					this.takeown.CheckedState.BorderRadius = 0;
					num = 609;
				}
				if (num == 607)
				{
					this.takeown.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 608;
				}
				if (num == 605)
				{
					this.taskmgr.CheckedChanged += this.taskmgr_CheckedChanged;
					num = 606;
				}
				if (num == 604)
				{
					this.taskmgr.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 605;
				}
				if (num == 603)
				{
					this.taskmgr.UncheckedState.BorderThickness = 0;
					num = 604;
				}
				if (num == 601)
				{
					this.taskmgr.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 602;
				}
				if (num == 600)
				{
					this.taskmgr.Text = "Task Manager";
					num = 601;
				}
				if (num == 599)
				{
					this.taskmgr.TabIndex = 342;
					num = 600;
				}
				if (num == 597)
				{
					this.taskmgr.Name = "taskmgr";
					num = 598;
				}
				if (num == 596)
				{
					this.taskmgr.Location = new Point(765, 57);
					num = 597;
				}
				if (num == 595)
				{
					this.taskmgr.ImageAlign = ContentAlignment.MiddleLeft;
					num = 596;
				}
				if (num == 593)
				{
					this.taskmgr.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 594;
				}
				if (num == 592)
				{
					this.taskmgr.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 593;
				}
				if (num == 591)
				{
					this.taskmgr.CheckedState.BorderThickness = 0;
					num = 592;
				}
				if (num == 589)
				{
					this.taskmgr.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 590;
				}
				if (num == 588)
				{
					this.taskmgr.AutoSize = true;
					num = 589;
				}
				if (num == 587)
				{
					this.sfc.CheckedChanged += this.sfc_CheckedChanged;
					num = 588;
				}
				if (num == 585)
				{
					this.sfc.UncheckedState.BorderThickness = 0;
					num = 586;
				}
				if (num == 584)
				{
					this.sfc.UncheckedState.BorderRadius = 0;
					num = 585;
				}
				if (num == 582)
				{
					this.sfc.Text = "SFC/Scannow";
					num = 583;
				}
				if (num == 581)
				{
					this.sfc.TabIndex = 343;
					num = 582;
				}
				if (num == 580)
				{
					this.sfc.Size = new Size(129, 29);
					num = 581;
				}
				if (num == 578)
				{
					this.sfc.Location = new Point(765, 241);
					num = 579;
				}
				if (num == 577)
				{
					this.sfc.ImageAlign = ContentAlignment.MiddleLeft;
					num = 578;
				}
				if (num == 576)
				{
					this.sfc.ForeColor = Color.White;
					num = 577;
				}
				if (num == 574)
				{
					this.sfc.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 575;
				}
				if (num == 573)
				{
					this.sfc.CheckedState.BorderThickness = 0;
					num = 574;
				}
				if (num == 572)
				{
					this.sfc.CheckedState.BorderRadius = 0;
					num = 573;
				}
				if (num == 570)
				{
					this.sfc.AutoSize = true;
					num = 571;
				}
				if (num == 569)
				{
					this.win_tools.CheckedChanged += this.win_tools_CheckedChanged;
					num = 570;
				}
				if (num == 568)
				{
					this.win_tools.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 569;
				}
				if (num == 566)
				{
					this.win_tools.UncheckedState.BorderRadius = 0;
					num = 567;
				}
				if (num == 565)
				{
					this.win_tools.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 566;
				}
				if (num == 563)
				{
					this.win_tools.TabIndex = 344;
					num = 564;
				}
				if (num == 562)
				{
					this.win_tools.Size = new Size(137, 29);
					num = 563;
				}
				if (num == 561)
				{
					this.win_tools.Name = "win_tools";
					num = 562;
				}
				if (num == 559)
				{
					this.win_tools.ImageAlign = ContentAlignment.MiddleLeft;
					num = 560;
				}
				if (num == 558)
				{
					this.win_tools.ForeColor = Color.White;
					num = 559;
				}
				if (num == 557)
				{
					this.win_tools.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 558;
				}
				if (num == 555)
				{
					this.win_tools.CheckedState.BorderThickness = 0;
					num = 556;
				}
				if (num == 554)
				{
					this.win_tools.CheckedState.BorderRadius = 0;
					num = 555;
				}
				if (num == 553)
				{
					this.win_tools.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 554;
				}
				if (num == 551)
				{
					this.win_mode.CheckedChanged += this.win_mode_CheckedChanged;
					num = 552;
				}
				if (num == 550)
				{
					this.win_mode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 551;
				}
				if (num == 549)
				{
					this.win_mode.UncheckedState.BorderThickness = 0;
					num = 550;
				}
				if (num == 547)
				{
					this.win_mode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 548;
				}
				if (num == 546)
				{
					this.win_mode.Text = "Windows Mode";
					num = 547;
				}
				if (num == 544)
				{
					this.win_mode.Size = new Size(142, 29);
					num = 545;
				}
				if (num == 543)
				{
					this.win_mode.Name = "win_mode";
					num = 544;
				}
				if (num == 542)
				{
					this.win_mode.Location = new Point(765, 103);
					num = 543;
				}
				if (num == 540)
				{
					this.win_mode.ForeColor = Color.White;
					num = 541;
				}
				if (num == 539)
				{
					this.win_mode.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 540;
				}
				if (num == 538)
				{
					this.win_mode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 539;
				}
				if (num == 536)
				{
					this.win_mode.CheckedState.BorderRadius = 0;
					num = 537;
				}
				if (num == 535)
				{
					this.win_mode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 536;
				}
				if (num == 534)
				{
					this.win_mode.AutoSize = true;
					num = 535;
				}
				if (num == 532)
				{
					this.tabPage3.TabIndex = 2;
					num = 533;
				}
				if (num == 531)
				{
					this.tabPage3.Size = new Size(998, 539);
					num = 532;
				}
				if (num == 530)
				{
					this.tabPage3.Name = "tabPage3";
					num = 531;
				}
				if (num == 528)
				{
					this.tabPage3.Controls.Add(this.label4);
					num = 529;
				}
				if (num == 527)
				{
					this.tabPage3.Controls.Add(this.adv_startup);
					num = 528;
				}
				if (num == 526)
				{
					this.tabPage3.Controls.Add(this.app_mode);
					num = 527;
				}
				if (num == 524)
				{
					this.tabPage3.Controls.Add(this.bt);
					num = 525;
				}
				if (num == 523)
				{
					this.tabPage3.Controls.Add(this.clip);
					num = 524;
				}
				if (num == 521)
				{
					this.tabPage3.Controls.Add(this.cmd_ctxt_admin);
					num = 522;
				}
				if (num == 520)
				{
					this.tabPage3.Controls.Add(this.compact);
					num = 521;
				}
				if (num == 519)
				{
					this.tabPage3.Controls.Add(this.control_pnl);
					num = 520;
				}
				if (num == 517)
				{
					this.tabPage3.Controls.Add(this.kill);
					num = 518;
				}
				if (num == 516)
				{
					this.tabPage3.Controls.Add(this.bash);
					num = 517;
				}
				if (num == 515)
				{
					this.tabPage3.Controls.Add(this.openwith_nat);
					num = 516;
				}
				if (num == 513)
				{
					this.tabPage3.Controls.Add(this.res_explorer);
					num = 514;
				}
				if (num == 512)
				{
					this.tabPage3.Controls.Add(this.res_startmenu);
					num = 513;
				}
				if (num == 511)
				{
					this.tabPage3.Controls.Add(this.run_priority);
					num = 512;
				}
				if (num == 509)
				{
					this.tabPage3.Controls.Add(this.snip);
					num = 510;
				}
				if (num == 508)
				{
					this.tabPage3.Controls.Add(this.settings);
					num = 509;
				}
				if (num == 507)
				{
					this.tabPage3.Controls.Add(this.shutdown);
					num = 508;
				}
				if (num == 505)
				{
					this.tabPage3.Controls.Add(this.takeown);
					num = 506;
				}
				if (num == 504)
				{
					this.tabPage3.Controls.Add(this.taskmgr);
					num = 505;
				}
				if (num == 502)
				{
					this.tabPage3.Controls.Add(this.win_tools);
					num = 503;
				}
				if (num == 501)
				{
					this.tabPage3.Controls.Add(this.win_mode);
					num = 502;
				}
				if (num == 500)
				{
					this.tabPage3.BackColor = Color.FromArgb(38, 38, 38);
					num = 501;
				}
				if (num == 498)
				{
					this.ctxt_menu.Size = new Size(387, 454);
					num = 499;
				}
				if (num == 497)
				{
					this.ctxt_menu.Name = "ctxt_menu";
					num = 498;
				}
				if (num == 496)
				{
					this.ctxt_menu.Location = new Point(23, 58);
					num = 497;
				}
				if (num == 494)
				{
					this.ctxt_menu.FormattingEnabled = true;
					num = 495;
				}
				if (num == 493)
				{
					this.ctxt_menu.ForeColor = Color.White;
					num = 494;
				}
				if (num == 492)
				{
					this.ctxt_menu.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 493;
				}
				if (num == 490)
				{
					this.refresh_list.Click += this.refresh_list_Click;
					num = 491;
				}
				if (num == 489)
				{
					this.refresh_list.Text = "Refresh";
					num = 490;
				}
				if (num == 488)
				{
					this.refresh_list.TabIndex = 312;
					num = 489;
				}
				if (num == 486)
				{
					this.refresh_list.ShadowDecoration.Parent = this.refresh_list;
					num = 487;
				}
				if (num == 485)
				{
					this.refresh_list.Name = "refresh_list";
					num = 486;
				}
				if (num == 483)
				{
					this.refresh_list.ImageSize = new Size(30, 30);
					num = 484;
				}
				if (num == 482)
				{
					this.refresh_list.HoverState.Parent = this.refresh_list;
					num = 483;
				}
				if (num == 481)
				{
					this.refresh_list.ForeColor = Color.White;
					num = 482;
				}
				if (num == 479)
				{
					this.refresh_list.FillColor = Color.DodgerBlue;
					num = 480;
				}
				if (num == 478)
				{
					this.refresh_list.DisabledState.Parent = this.refresh_list;
					num = 479;
				}
				if (num == 477)
				{
					this.refresh_list.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 478;
				}
				if (num == 475)
				{
					this.refresh_list.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 476;
				}
				if (num == 474)
				{
					this.refresh_list.DisabledState.BorderColor = Color.DarkGray;
					num = 475;
				}
				if (num == 473)
				{
					this.refresh_list.CustomImages.Parent = this.refresh_list;
					num = 474;
				}
				if (num == 471)
				{
					this.delete.Click += this.delete_Click;
					num = 472;
				}
				if (num == 470)
				{
					this.delete.Text = "Delete";
					num = 471;
				}
				if (num == 469)
				{
					this.delete.TabIndex = 313;
					num = 470;
				}
				if (num == 467)
				{
					this.delete.ShadowDecoration.Parent = this.delete;
					num = 468;
				}
				if (num == 466)
				{
					this.delete.Name = "delete";
					num = 467;
				}
				if (num == 465)
				{
					this.delete.Location = new Point(434, 102);
					num = 466;
				}
				if (num == 463)
				{
					this.delete.HoverState.Parent = this.delete;
					num = 464;
				}
				if (num == 462)
				{
					this.delete.ForeColor = Color.White;
					num = 463;
				}
				if (num == 460)
				{
					this.delete.FillColor = Color.DodgerBlue;
					num = 461;
				}
				if (num == 459)
				{
					this.delete.DisabledState.Parent = this.delete;
					num = 460;
				}
				if (num == 458)
				{
					this.delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 459;
				}
				if (num == 456)
				{
					this.delete.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 457;
				}
				if (num == 455)
				{
					this.delete.DisabledState.BorderColor = Color.DarkGray;
					num = 456;
				}
				if (num == 454)
				{
					this.delete.CustomImages.Parent = this.delete;
					num = 455;
				}
				if (num == 452)
				{
					this.del_all.Click += this.del_all_Click;
					num = 453;
				}
				if (num == 451)
				{
					this.del_all.Text = "Delete All";
					num = 452;
				}
				if (num == 450)
				{
					this.del_all.TabIndex = 314;
					num = 451;
				}
				if (num == 448)
				{
					this.del_all.ShadowDecoration.Parent = this.del_all;
					num = 449;
				}
				if (num == 447)
				{
					this.del_all.Name = "del_all";
					num = 448;
				}
				if (num == 446)
				{
					this.del_all.Location = new Point(434, 146);
					num = 447;
				}
				if (num == 444)
				{
					this.del_all.HoverState.Parent = this.del_all;
					num = 445;
				}
				if (num == 443)
				{
					this.del_all.ForeColor = Color.White;
					num = 444;
				}
				if (num == 441)
				{
					this.del_all.FillColor = Color.DodgerBlue;
					num = 442;
				}
				if (num == 440)
				{
					this.del_all.DisabledState.Parent = this.del_all;
					num = 441;
				}
				if (num == 439)
				{
					this.del_all.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 440;
				}
				if (num == 437)
				{
					this.del_all.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 438;
				}
				if (num == 436)
				{
					this.del_all.DisabledState.BorderColor = Color.DarkGray;
					num = 437;
				}
				if (num == 435)
				{
					this.del_all.CustomImages.Parent = this.del_all;
					num = 436;
				}
				if (num == 433)
				{
					this.label3.Text = "Remove Entries";
					num = 434;
				}
				if (num == 432)
				{
					this.label3.TabIndex = 315;
					num = 433;
				}
				if (num == 431)
				{
					this.label3.Size = new Size(163, 33);
					num = 432;
				}
				if (num == 429)
				{
					this.label3.Location = new Point(18, 3);
					num = 430;
				}
				if (num == 428)
				{
					this.label3.ForeColor = Color.White;
					num = 429;
				}
				if (num == 427)
				{
					this.label3.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 428;
				}
				if (num == 425)
				{
					this.tabPage2.Text = "Remove";
					num = 426;
				}
				if (num == 424)
				{
					this.tabPage2.TabIndex = 1;
					num = 425;
				}
				if (num == 422)
				{
					this.tabPage2.Padding = new Padding(3);
					num = 423;
				}
				if (num == 421)
				{
					this.tabPage2.Name = "tabPage2";
					num = 422;
				}
				if (num == 420)
				{
					this.tabPage2.Location = new Point(4, 4);
					num = 421;
				}
				if (num == 418)
				{
					this.tabPage2.Controls.Add(this.refresh_list);
					num = 419;
				}
				if (num == 417)
				{
					this.tabPage2.Controls.Add(this.delete);
					num = 418;
				}
				if (num == 416)
				{
					this.tabPage2.Controls.Add(this.del_all);
					num = 417;
				}
				if (num == 414)
				{
					this.tabPage2.BackColor = Color.FromArgb(38, 38, 38);
					num = 415;
				}
				if (num == 413)
				{
					this.label2.Text = "Add/Modify Entries";
					num = 414;
				}
				if (num == 412)
				{
					this.label2.TabIndex = 2;
					num = 413;
				}
				if (num == 410)
				{
					this.label2.Name = "label2";
					num = 411;
				}
				if (num == 409)
				{
					this.label2.Location = new Point(18, 3);
					num = 410;
				}
				if (num == 408)
				{
					this.label2.ForeColor = Color.White;
					num = 409;
				}
				if (num == 406)
				{
					this.label2.AutoSize = true;
					num = 407;
				}
				if (num == 405)
				{
					this.program.CheckedChanged += this.program_CheckedChanged;
					num = 406;
				}
				if (num == 403)
				{
					this.program.Text = "Program";
					num = 404;
				}
				if (num == 402)
				{
					this.program.TabStop = true;
					num = 403;
				}
				if (num == 401)
				{
					this.program.TabIndex = 0;
					num = 402;
				}
				if (num == 399)
				{
					this.program.Name = "program";
					num = 400;
				}
				if (num == 398)
				{
					this.program.Location = new Point(766, 26);
					num = 399;
				}
				if (num == 397)
				{
					this.program.Checked = true;
					num = 398;
				}
				if (num == 395)
				{
					this.folder.CheckedChanged += this.folder_CheckedChanged;
					num = 396;
				}
				if (num == 394)
				{
					this.folder.UseVisualStyleBackColor = true;
					num = 395;
				}
				if (num == 393)
				{
					this.folder.Text = "Folder";
					num = 394;
				}
				if (num == 391)
				{
					this.folder.Size = new Size(71, 28);
					num = 392;
				}
				if (num == 390)
				{
					this.folder.Name = "folder";
					num = 391;
				}
				if (num == 389)
				{
					this.folder.Location = new Point(407, 26);
					num = 390;
				}
				if (num == 387)
				{
					this.link.CheckedChanged += this.link_CheckedChanged;
					num = 388;
				}
				if (num == 386)
				{
					this.link.UseVisualStyleBackColor = true;
					num = 387;
				}
				if (num == 385)
				{
					this.link.Text = "Link";
					num = 386;
				}
				if (num == 383)
				{
					this.link.Size = new Size(56, 28);
					num = 384;
				}
				if (num == 382)
				{
					this.link.Name = "link";
					num = 383;
				}
				if (num == 380)
				{
					this.link.AutoSize = true;
					num = 381;
				}
				if (num == 379)
				{
					this.file.CheckedChanged += this.file_CheckedChanged;
					num = 380;
				}
				if (num == 378)
				{
					this.file.UseVisualStyleBackColor = true;
					num = 379;
				}
				if (num == 376)
				{
					this.file.TabIndex = 3;
					num = 377;
				}
				if (num == 375)
				{
					this.file.Size = new Size(53, 28);
					num = 376;
				}
				if (num == 374)
				{
					this.file.Name = "file";
					num = 375;
				}
				if (num == 372)
				{
					this.file.AutoSize = true;
					num = 373;
				}
				if (num == 371)
				{
					this.cmd.CheckedChanged += this.cmd_CheckedChanged;
					num = 372;
				}
				if (num == 370)
				{
					this.cmd.UseVisualStyleBackColor = true;
					num = 371;
				}
				if (num == 368)
				{
					this.cmd.TabIndex = 4;
					num = 369;
				}
				if (num == 367)
				{
					this.cmd.Size = new Size(96, 28);
					num = 368;
				}
				if (num == 366)
				{
					this.cmd.Name = "cmd";
					num = 367;
				}
				if (num == 364)
				{
					this.cmd.AutoSize = true;
					num = 365;
				}
				if (num == 363)
				{
					this.item_type.Text = "Item Type";
					num = 364;
				}
				if (num == 361)
				{
					this.item_type.TabIndex = 3;
					num = 362;
				}
				if (num == 360)
				{
					this.item_type.Size = new Size(938, 71);
					num = 361;
				}
				if (num == 359)
				{
					this.item_type.Name = "item_type";
					num = 360;
				}
				if (num == 357)
				{
					this.item_type.ForeColor = Color.White;
					num = 358;
				}
				if (num == 356)
				{
					this.item_type.Controls.Add(this.program);
					num = 357;
				}
				if (num == 355)
				{
					this.item_type.Controls.Add(this.folder);
					num = 356;
				}
				if (num == 353)
				{
					this.item_type.Controls.Add(this.file);
					num = 354;
				}
				if (num == 352)
				{
					this.item_type.Controls.Add(this.cmd);
					num = 353;
				}
				if (num == 351)
				{
					this.browse.Click += this.browse_Click;
					num = 352;
				}
				if (num == 349)
				{
					this.browse.TabIndex = 316;
					num = 350;
				}
				if (num == 348)
				{
					this.browse.Size = new Size(80, 29);
					num = 349;
				}
				if (num == 347)
				{
					this.browse.ShadowDecoration.Parent = this.browse;
					num = 348;
				}
				if (num == 345)
				{
					this.browse.Location = new Point(679, 39);
					num = 346;
				}
				if (num == 344)
				{
					this.browse.ImageSize = new Size(30, 30);
					num = 345;
				}
				if (num == 342)
				{
					this.browse.ForeColor = Color.White;
					num = 343;
				}
				if (num == 341)
				{
					this.browse.Font = new Font("Segoe UI", 9f);
					num = 342;
				}
				if (num == 340)
				{
					this.browse.FillColor = Color.FromArgb(38, 38, 38);
					num = 341;
				}
				if (num == 338)
				{
					this.browse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 339;
				}
				if (num == 337)
				{
					this.browse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 338;
				}
				if (num == 336)
				{
					this.browse.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 337;
				}
				if (num == 334)
				{
					this.browse.CustomImages.Parent = this.browse;
					num = 335;
				}
				if (num == 333)
				{
					this.browse.CheckedState.Parent = this.browse;
					num = 334;
				}
				if (num == 332)
				{
					this.to_add.TabIndex = 315;
					num = 333;
				}
				if (num == 330)
				{
					this.to_add.ShadowDecoration.Parent = this.to_add;
					num = 331;
				}
				if (num == 329)
				{
					this.to_add.SelectedText = "";
					num = 330;
				}
				if (num == 328)
				{
					this.to_add.ReadOnly = true;
					num = 329;
				}
				if (num == 326)
				{
					this.to_add.PasswordChar = '\0';
					num = 327;
				}
				if (num == 325)
				{
					this.to_add.Name = "to_add";
					num = 326;
				}
				if (num == 324)
				{
					this.to_add.Location = new Point(26, 39);
					num = 325;
				}
				if (num == 322)
				{
					this.to_add.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 323;
				}
				if (num == 321)
				{
					this.to_add.ForeColor = Color.White;
					num = 322;
				}
				if (num == 319)
				{
					this.to_add.FocusedState.Parent = this.to_add;
					num = 320;
				}
				if (num == 318)
				{
					this.to_add.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 319;
				}
				if (num == 317)
				{
					this.to_add.FillColor = Color.FromArgb(38, 38, 38);
					num = 318;
				}
				if (num == 315)
				{
					this.to_add.DisabledState.Parent = this.to_add;
					num = 316;
				}
				if (num == 314)
				{
					this.to_add.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 315;
				}
				if (num == 313)
				{
					this.to_add.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 314;
				}
				if (num == 311)
				{
					this.to_add.DefaultText = "";
					num = 312;
				}
				if (num == 310)
				{
					this.to_add.Cursor = Cursors.IBeam;
					num = 311;
				}
				if (num == 309)
				{
					this.to_add.BorderColor = Color.Gray;
					num = 310;
				}
				if (num == 307)
				{
					this.checkShift.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 308;
				}
				if (num == 306)
				{
					this.checkShift.UncheckedState.BorderThickness = 0;
					num = 307;
				}
				if (num == 305)
				{
					this.checkShift.UncheckedState.BorderRadius = 0;
					num = 306;
				}
				if (num == 303)
				{
					this.checkShift.Text = "Show only when Shift key is pressed";
					num = 304;
				}
				if (num == 302)
				{
					this.checkShift.TabIndex = 317;
					num = 303;
				}
				if (num == 300)
				{
					this.checkShift.Name = "checkShift";
					num = 301;
				}
				if (num == 299)
				{
					this.checkShift.Location = new Point(26, 73);
					num = 300;
				}
				if (num == 298)
				{
					this.checkShift.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 299;
				}
				if (num == 296)
				{
					this.checkShift.CheckedState.BorderRadius = 0;
					num = 297;
				}
				if (num == 295)
				{
					this.checkShift.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 296;
				}
				if (num == 294)
				{
					this.checkShift.AutoSize = true;
					num = 295;
				}
				if (num == 292)
				{
					this.add_grpbox.TabStop = false;
					num = 293;
				}
				if (num == 291)
				{
					this.add_grpbox.TabIndex = 317;
					num = 292;
				}
				if (num == 290)
				{
					this.add_grpbox.Size = new Size(938, 114);
					num = 291;
				}
				if (num == 288)
				{
					this.add_grpbox.Location = new Point(24, 136);
					num = 289;
				}
				if (num == 287)
				{
					this.add_grpbox.ForeColor = Color.White;
					num = 288;
				}
				if (num == 286)
				{
					this.add_grpbox.Controls.Add(this.browse);
					num = 287;
				}
				if (num == 284)
				{
					this.add_grpbox.Controls.Add(this.checkShift);
					num = 285;
				}
				if (num == 283)
				{
					this.icon_browse.Click += this.icon_browse_Click;
					num = 284;
				}
				if (num == 281)
				{
					this.icon_browse.TabIndex = 316;
					num = 282;
				}
				if (num == 280)
				{
					this.icon_browse.Size = new Size(80, 29);
					num = 281;
				}
				if (num == 279)
				{
					this.icon_browse.ShadowDecoration.Parent = this.icon_browse;
					num = 280;
				}
				if (num == 277)
				{
					this.icon_browse.Location = new Point(679, 39);
					num = 278;
				}
				if (num == 276)
				{
					this.icon_browse.ImageSize = new Size(30, 30);
					num = 277;
				}
				if (num == 275)
				{
					this.icon_browse.HoverState.Parent = this.icon_browse;
					num = 276;
				}
				if (num == 273)
				{
					this.icon_browse.Font = new Font("Segoe UI", 9f);
					num = 274;
				}
				if (num == 272)
				{
					this.icon_browse.FillColor = Color.FromArgb(38, 38, 38);
					num = 273;
				}
				if (num == 271)
				{
					this.icon_browse.DisabledState.Parent = this.icon_browse;
					num = 272;
				}
				if (num == 269)
				{
					this.icon_browse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 270;
				}
				if (num == 268)
				{
					this.icon_browse.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 269;
				}
				if (num == 267)
				{
					this.icon_browse.DisabledState.BorderColor = Color.DarkGray;
					num = 268;
				}
				if (num == 265)
				{
					this.icon_browse.CheckedState.Parent = this.icon_browse;
					num = 266;
				}
				if (num == 264)
				{
					this.icon_txtbox.TabIndex = 315;
					num = 265;
				}
				if (num == 263)
				{
					this.icon_txtbox.Size = new Size(647, 28);
					num = 264;
				}
				if (num == 261)
				{
					this.icon_txtbox.SelectedText = "";
					num = 262;
				}
				if (num == 260)
				{
					this.icon_txtbox.ReadOnly = true;
					num = 261;
				}
				if (num == 258)
				{
					this.icon_txtbox.PasswordChar = '\0';
					num = 259;
				}
				if (num == 257)
				{
					this.icon_txtbox.Name = "icon_txtbox";
					num = 258;
				}
				if (num == 256)
				{
					this.icon_txtbox.Location = new Point(26, 39);
					num = 257;
				}
				if (num == 254)
				{
					this.icon_txtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 255;
				}
				if (num == 253)
				{
					this.icon_txtbox.ForeColor = Color.White;
					num = 254;
				}
				if (num == 252)
				{
					this.icon_txtbox.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 253;
				}
				if (num == 250)
				{
					this.icon_txtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 251;
				}
				if (num == 249)
				{
					this.icon_txtbox.FillColor = Color.FromArgb(38, 38, 38);
					num = 250;
				}
				if (num == 248)
				{
					this.icon_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 249;
				}
				if (num == 246)
				{
					this.icon_txtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 247;
				}
				if (num == 245)
				{
					this.icon_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 246;
				}
				if (num == 244)
				{
					this.icon_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 245;
				}
				if (num == 242)
				{
					this.icon_txtbox.Cursor = Cursors.IBeam;
					num = 243;
				}
				if (num == 241)
				{
					this.icon_txtbox.BorderColor = Color.Gray;
					num = 242;
				}
				if (num == 239)
				{
					this.checkDefaultIcon.CheckedChanged += this.checkDefaultIcon_CheckedChanged;
					num = 240;
				}
				if (num == 238)
				{
					this.checkDefaultIcon.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 239;
				}
				if (num == 237)
				{
					this.checkDefaultIcon.UncheckedState.BorderThickness = 0;
					num = 238;
				}
				if (num == 235)
				{
					this.checkDefaultIcon.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 236;
				}
				if (num == 234)
				{
					this.checkDefaultIcon.Text = "Use program's default icon";
					num = 235;
				}
				if (num == 233)
				{
					this.checkDefaultIcon.TabIndex = 318;
					num = 234;
				}
				if (num == 231)
				{
					this.checkDefaultIcon.Name = "checkDefaultIcon";
					num = 232;
				}
				if (num == 230)
				{
					this.checkDefaultIcon.Location = new Point(26, 73);
					num = 231;
				}
				if (num == 229)
				{
					this.checkDefaultIcon.CheckState = CheckState.Checked;
					num = 230;
				}
				if (num == 227)
				{
					this.checkDefaultIcon.CheckedState.BorderThickness = 0;
					num = 228;
				}
				if (num == 226)
				{
					this.checkDefaultIcon.CheckedState.BorderRadius = 0;
					num = 227;
				}
				if (num == 225)
				{
					this.checkDefaultIcon.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 226;
				}
				if (num == 223)
				{
					this.checkDefaultIcon.AutoSize = true;
					num = 224;
				}
				if (num == 222)
				{
					this.ico.Text = "Icon file (optional)";
					num = 223;
				}
				if (num == 220)
				{
					this.ico.TabIndex = 318;
					num = 221;
				}
				if (num == 219)
				{
					this.ico.Size = new Size(938, 114);
					num = 220;
				}
				if (num == 218)
				{
					this.ico.Name = "ico";
					num = 219;
				}
				if (num == 216)
				{
					this.ico.ForeColor = Color.White;
					num = 217;
				}
				if (num == 215)
				{
					this.ico.Controls.Add(this.icon_browse);
					num = 216;
				}
				if (num == 214)
				{
					this.ico.Controls.Add(this.icon_txtbox);
					num = 215;
				}
				if (num == 212)
				{
					this.position_cbox.SelectedIndexChanged += this.position_cbox_SelectedIndexChanged;
					num = 213;
				}
				if (num == 211)
				{
					this.position_cbox.TextAlign = HorizontalAlignment.Center;
					num = 212;
				}
				if (num == 210)
				{
					this.position_cbox.TabIndex = 0;
					num = 211;
				}
				if (num == 208)
				{
					this.position_cbox.Size = new Size(194, 36);
					num = 209;
				}
				if (num == 207)
				{
					this.position_cbox.ShadowDecoration.Parent = this.position_cbox;
					num = 208;
				}
				if (num == 206)
				{
					this.position_cbox.Name = "position_cbox";
					num = 207;
				}
				if (num == 204)
				{
					this.position_cbox.ItemsAppearance.Parent = this.position_cbox;
					num = 205;
				}
				if (num == 203)
				{
					this.position_cbox.Items.AddRange(new object[] { "Top", "Middle", "Bottom" });
					num = 204;
				}
				if (num == 201)
				{
					this.position_cbox.HoverState.Parent = this.position_cbox;
					num = 202;
				}
				if (num == 200)
				{
					this.position_cbox.ForeColor = Color.Black;
					num = 201;
				}
				if (num == 199)
				{
					this.position_cbox.Font = new Font("Segoe UI", 10f);
					num = 200;
				}
				if (num == 197)
				{
					this.position_cbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 198;
				}
				if (num == 196)
				{
					this.position_cbox.FocusedColor = Color.FromArgb(94, 148, 255);
					num = 197;
				}
				if (num == 195)
				{
					this.position_cbox.DropDownStyle = ComboBoxStyle.DropDownList;
					num = 196;
				}
				if (num == 193)
				{
					this.position_cbox.BackColor = Color.Transparent;
					num = 194;
				}
				if (num == 192)
				{
					this.position.Text = "Position";
					num = 193;
				}
				if (num == 191)
				{
					this.position.TabStop = false;
					num = 192;
				}
				if (num == 189)
				{
					this.position.Size = new Size(206, 75);
					num = 190;
				}
				if (num == 188)
				{
					this.position.Name = "position";
					num = 189;
				}
				if (num == 187)
				{
					this.position.Location = new Point(24, 392);
					num = 188;
				}
				if (num == 185)
				{
					this.position.Controls.Add(this.position_cbox);
					num = 186;
				}
				if (num == 184)
				{
					this.menu_txtbox.TabIndex = 316;
					num = 185;
				}
				if (num == 183)
				{
					this.menu_txtbox.Size = new Size(692, 28);
					num = 184;
				}
				if (num == 181)
				{
					this.menu_txtbox.SelectedText = "";
					num = 182;
				}
				if (num == 180)
				{
					this.menu_txtbox.PlaceholderText = "";
					num = 181;
				}
				if (num == 178)
				{
					this.menu_txtbox.Name = "menu_txtbox";
					num = 179;
				}
				if (num == 177)
				{
					this.menu_txtbox.Location = new Point(13, 30);
					num = 178;
				}
				if (num == 176)
				{
					this.menu_txtbox.HoverState.Parent = this.menu_txtbox;
					num = 177;
				}
				if (num == 174)
				{
					this.menu_txtbox.ForeColor = Color.White;
					num = 175;
				}
				if (num == 173)
				{
					this.menu_txtbox.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 174;
				}
				if (num == 172)
				{
					this.menu_txtbox.FocusedState.Parent = this.menu_txtbox;
					num = 173;
				}
				if (num == 170)
				{
					this.menu_txtbox.FillColor = Color.FromArgb(38, 38, 38);
					num = 171;
				}
				if (num == 169)
				{
					this.menu_txtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 170;
				}
				if (num == 168)
				{
					this.menu_txtbox.DisabledState.Parent = this.menu_txtbox;
					num = 169;
				}
				if (num == 166)
				{
					this.menu_txtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 167;
				}
				if (num == 165)
				{
					this.menu_txtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 166;
				}
				if (num == 164)
				{
					this.menu_txtbox.DefaultText = "";
					num = 165;
				}
				if (num == 162)
				{
					this.menu_txtbox.BorderColor = Color.Gray;
					num = 163;
				}
				if (num == 161)
				{
					this.menu_txtbox.BackColor = Color.Transparent;
					num = 162;
				}
				if (num == 159)
				{
					this.txt_on_menu.TabStop = false;
					num = 160;
				}
				if (num == 158)
				{
					this.txt_on_menu.TabIndex = 320;
					num = 159;
				}
				if (num == 157)
				{
					this.txt_on_menu.Size = new Size(720, 75);
					num = 158;
				}
				if (num == 155)
				{
					this.txt_on_menu.Location = new Point(242, 392);
					num = 156;
				}
				if (num == 154)
				{
					this.txt_on_menu.ForeColor = Color.White;
					num = 155;
				}
				if (num == 153)
				{
					this.txt_on_menu.Controls.Add(this.menu_txtbox);
					num = 154;
				}
				if (num == 151)
				{
					this.save.Text = "Add to Context Menu";
					num = 152;
				}
				if (num == 150)
				{
					this.save.TabIndex = 321;
					num = 151;
				}
				if (num == 149)
				{
					this.save.Size = new Size(222, 38);
					num = 150;
				}
				if (num == 147)
				{
					this.save.Name = "save";
					num = 148;
				}
				if (num == 146)
				{
					this.save.Location = new Point(740, 484);
					num = 147;
				}
				if (num == 145)
				{
					this.save.ImageSize = new Size(30, 30);
					num = 146;
				}
				if (num == 143)
				{
					this.save.ForeColor = Color.White;
					num = 144;
				}
				if (num == 142)
				{
					this.save.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 143;
				}
				if (num == 140)
				{
					this.save.DisabledState.Parent = this.save;
					num = 141;
				}
				if (num == 139)
				{
					this.save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 140;
				}
				if (num == 138)
				{
					this.save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 139;
				}
				if (num == 136)
				{
					this.save.DisabledState.BorderColor = Color.DarkGray;
					num = 137;
				}
				if (num == 135)
				{
					this.save.CustomImages.Parent = this.save;
					num = 136;
				}
				if (num == 134)
				{
					this.save.CheckedState.Parent = this.save;
					num = 135;
				}
				if (num == 132)
				{
					this.tabPage1.TabIndex = 0;
					num = 133;
				}
				if (num == 131)
				{
					this.tabPage1.Size = new Size(998, 539);
					num = 132;
				}
				if (num == 130)
				{
					this.tabPage1.Padding = new Padding(3);
					num = 131;
				}
				if (num == 128)
				{
					this.tabPage1.Location = new Point(4, 4);
					num = 129;
				}
				if (num == 127)
				{
					this.tabPage1.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 128;
				}
				if (num == 126)
				{
					this.tabPage1.Controls.Add(this.label2);
					num = 127;
				}
				if (num == 124)
				{
					this.tabPage1.Controls.Add(this.add_grpbox);
					num = 125;
				}
				if (num == 123)
				{
					this.tabPage1.Controls.Add(this.ico);
					num = 124;
				}
				if (num == 122)
				{
					this.tabPage1.Controls.Add(this.position);
					num = 123;
				}
				if (num == 120)
				{
					this.tabPage1.Controls.Add(this.save);
					num = 121;
				}
				if (num == 119)
				{
					this.tabPage1.BackColor = Color.FromArgb(38, 38, 38);
					num = 120;
				}
				if (num == 117)
				{
					this.siticoneTabControl1.TabMenuBackColor = Color.FromArgb(38, 38, 38);
					num = 118;
				}
				if (num == 116)
				{
					this.siticoneTabControl1.TabIndex = 46;
					num = 117;
				}
				if (num == 115)
				{
					this.siticoneTabControl1.TabButtonSize = new Size(180, 40);
					num = 116;
				}
				if (num == 113)
				{
					this.siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
					num = 114;
				}
				if (num == 112)
				{
					this.siticoneTabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10f);
					num = 113;
				}
				if (num == 111)
				{
					this.siticoneTabControl1.TabButtonSelectedState.FillColor = Color.DodgerBlue;
					num = 112;
				}
				if (num == 109)
				{
					this.siticoneTabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(38, 38, 38);
					num = 110;
				}
				if (num == 108)
				{
					this.siticoneTabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
					num = 109;
				}
				if (num == 107)
				{
					this.siticoneTabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10f);
					num = 108;
				}
				if (num == 105)
				{
					this.siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
					num = 106;
				}
				if (num == 104)
				{
					this.siticoneTabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(38, 38, 38);
					num = 105;
				}
				if (num == 103)
				{
					this.siticoneTabControl1.TabButtonHoverState.ForeColor = Color.White;
					num = 104;
				}
				if (num == 101)
				{
					this.siticoneTabControl1.TabButtonHoverState.FillColor = Color.FromArgb(38, 38, 38);
					num = 102;
				}
				if (num == 100)
				{
					this.siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
					num = 101;
				}
				if (num == 98)
				{
					this.siticoneTabControl1.SelectedIndex = 0;
					num = 99;
				}
				if (num == 97)
				{
					this.siticoneTabControl1.Name = "siticoneTabControl1";
					num = 98;
				}
				if (num == 96)
				{
					this.siticoneTabControl1.Location = new Point(0, 92);
					num = 97;
				}
				if (num == 94)
				{
					this.siticoneTabControl1.Font = new Font("Josefin Sans Light", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 95;
				}
				if (num == 93)
				{
					this.siticoneTabControl1.Controls.Add(this.tabPage3);
					num = 94;
				}
				if (num == 92)
				{
					this.siticoneTabControl1.Controls.Add(this.tabPage2);
					num = 93;
				}
				if (num == 90)
				{
					this.siticoneTabControl1.Alignment = TabAlignment.Bottom;
					num = 91;
				}
				if (num == 89)
				{
					this.label9.Text = "Add useful options to the context menu for ease";
					num = 90;
				}
				if (num == 88)
				{
					this.label9.TabIndex = 44;
					num = 89;
				}
				if (num == 86)
				{
					this.label9.Name = "label9";
					num = 87;
				}
				if (num == 85)
				{
					this.label9.Location = new Point(23, 53);
					num = 86;
				}
				if (num == 84)
				{
					this.label9.ForeColor = Color.Silver;
					num = 85;
				}
				if (num == 82)
				{
					this.label9.AutoSize = true;
					num = 83;
				}
				if (num == 81)
				{
					this.label1.Text = "Context Menu";
					num = 82;
				}
				if (num == 79)
				{
					this.label1.Size = new Size(243, 53);
					num = 80;
				}
				if (num == 78)
				{
					this.label1.Name = "label1";
					num = 79;
				}
				if (num == 77)
				{
					this.label1.Location = new Point(18, 0);
					num = 78;
				}
				if (num == 75)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 76;
				}
				if (num == 74)
				{
					this.label1.AutoSize = true;
					num = 75;
				}
				if (num == 73)
				{
					base.SuspendLayout();
					num = 74;
				}
				if (num == 71)
				{
					this.tabPage2.SuspendLayout();
					num = 72;
				}
				if (num == 70)
				{
					this.item_type.SuspendLayout();
					num = 71;
				}
				if (num == 69)
				{
					this.add_grpbox.SuspendLayout();
					num = 70;
				}
				if (num == 67)
				{
					this.position.SuspendLayout();
					num = 68;
				}
				if (num == 66)
				{
					this.txt_on_menu.SuspendLayout();
					num = 67;
				}
				if (num == 65)
				{
					this.tabPage1.SuspendLayout();
					num = 66;
				}
				if (num == 63)
				{
					this.icon_dialog = new OpenFileDialog();
					num = 64;
				}
				if (num == 62)
				{
					this.file_browse = new OpenFileDialog();
					num = 63;
				}
				if (num == 61)
				{
					this.folderBrowserDialog1 = new FolderBrowserDialog();
					num = 62;
				}
				if (num == 59)
				{
					this.label4 = new Label();
					num = 60;
				}
				if (num == 58)
				{
					this.adv_startup = new SiticoneCheckBox();
					num = 59;
				}
				if (num == 56)
				{
					this.attributes = new SiticoneCheckBox();
					num = 57;
				}
				if (num == 55)
				{
					this.bt = new SiticoneCheckBox();
					num = 56;
				}
				if (num == 54)
				{
					this.clip = new SiticoneCheckBox();
					num = 55;
				}
				if (num == 52)
				{
					this.cmd_ctxt_admin = new SiticoneCheckBox();
					num = 53;
				}
				if (num == 51)
				{
					this.compact = new SiticoneCheckBox();
					num = 52;
				}
				if (num == 50)
				{
					this.control_pnl = new SiticoneCheckBox();
					num = 51;
				}
				if (num == 48)
				{
					this.kill = new SiticoneCheckBox();
					num = 49;
				}
				if (num == 47)
				{
					this.bash = new SiticoneCheckBox();
					num = 48;
				}
				if (num == 46)
				{
					this.openwith_nat = new SiticoneCheckBox();
					num = 47;
				}
				if (num == 44)
				{
					this.res_explorer = new SiticoneCheckBox();
					num = 45;
				}
				if (num == 43)
				{
					this.res_startmenu = new SiticoneCheckBox();
					num = 44;
				}
				if (num == 42)
				{
					this.run_priority = new SiticoneCheckBox();
					num = 43;
				}
				if (num == 40)
				{
					this.snip = new SiticoneCheckBox();
					num = 41;
				}
				if (num == 39)
				{
					this.settings = new SiticoneCheckBox();
					num = 40;
				}
				if (num == 37)
				{
					this.snip_classic = new SiticoneCheckBox();
					num = 38;
				}
				if (num == 36)
				{
					this.takeown = new SiticoneCheckBox();
					num = 37;
				}
				if (num == 35)
				{
					this.taskmgr = new SiticoneCheckBox();
					num = 36;
				}
				if (num == 33)
				{
					this.win_tools = new SiticoneCheckBox();
					num = 34;
				}
				if (num == 32)
				{
					this.win_mode = new SiticoneCheckBox();
					num = 33;
				}
				if (num == 31)
				{
					this.tabPage3 = new TabPage();
					num = 32;
				}
				if (num == 29)
				{
					this.refresh_list = new SiticoneButton();
					num = 30;
				}
				if (num == 28)
				{
					this.delete = new SiticoneButton();
					num = 29;
				}
				if (num == 27)
				{
					this.del_all = new SiticoneButton();
					num = 28;
				}
				if (num == 25)
				{
					this.tabPage2 = new TabPage();
					num = 26;
				}
				if (num == 24)
				{
					this.label2 = new Label();
					num = 25;
				}
				if (num == 23)
				{
					this.program = new RadioButton();
					num = 24;
				}
				if (num == 21)
				{
					this.link = new RadioButton();
					num = 22;
				}
				if (num == 20)
				{
					this.file = new RadioButton();
					num = 21;
				}
				if (num == 18)
				{
					this.item_type = new GroupBox();
					num = 19;
				}
				if (num == 17)
				{
					this.browse = new SiticoneButton();
					num = 18;
				}
				if (num == 16)
				{
					this.to_add = new SiticoneTextBox();
					num = 17;
				}
				if (num == 14)
				{
					this.add_grpbox = new GroupBox();
					num = 15;
				}
				if (num == 13)
				{
					this.icon_browse = new SiticoneButton();
					num = 14;
				}
				if (num == 12)
				{
					this.icon_txtbox = new SiticoneTextBox();
					num = 13;
				}
				if (num == 10)
				{
					this.ico = new GroupBox();
					num = 11;
				}
				if (num == 9)
				{
					this.position_cbox = new SiticoneComboBox();
					num = 10;
				}
				if (num == 8)
				{
					this.position = new GroupBox();
					num = 9;
				}
				if (num == 6)
				{
					this.txt_on_menu = new GroupBox();
					num = 7;
				}
				if (num == 5)
				{
					this.save = new SiticoneButton();
					num = 6;
				}
				if (num == 4)
				{
					this.tabPage1 = new TabPage();
					num = 5;
				}
				if (num == 2)
				{
					this.label9 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					this.label1 = new Label();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1060);
		}

		// Token: 0x040000FA RID: 250
		private static Context _instace;

		// Token: 0x040000FB RID: 251
		private List<string> _desktopItems = new List<string>();

		// Token: 0x040000FC RID: 252
		private DesktopItemType _desktopItemType = DesktopItemType.Program;

		// Token: 0x040000FD RID: 253
		private DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Middle;

		// Token: 0x040000FE RID: 254
		private string REG_KILL_PATH = "DesktopBackground\\shell\\KillNotResponding";

		// Token: 0x040000FF RID: 255
		private string REG_BASE_PATH = "DesktopBackground\\Shell\\WindowsTools";

		// Token: 0x04000100 RID: 256
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000101 RID: 257
		private IContainer components = null;

		// Token: 0x04000102 RID: 258
		private Label label1;

		// Token: 0x04000103 RID: 259
		private Label label9;

		// Token: 0x04000104 RID: 260
		private SiticoneTabControl siticoneTabControl1;

		// Token: 0x04000105 RID: 261
		private TabPage tabPage1;

		// Token: 0x04000106 RID: 262
		private TabPage tabPage2;

		// Token: 0x04000107 RID: 263
		private ListBox ctxt_menu;

		// Token: 0x04000108 RID: 264
		private Label label2;

		// Token: 0x04000109 RID: 265
		private GroupBox item_type;

		// Token: 0x0400010A RID: 266
		private RadioButton program;

		// Token: 0x0400010B RID: 267
		private RadioButton file;

		// Token: 0x0400010C RID: 268
		private RadioButton link;

		// Token: 0x0400010D RID: 269
		private RadioButton folder;

		// Token: 0x0400010E RID: 270
		private RadioButton cmd;

		// Token: 0x0400010F RID: 271
		private GroupBox add_grpbox;

		// Token: 0x04000110 RID: 272
		private SiticoneTextBox to_add;

		// Token: 0x04000111 RID: 273
		private SiticoneButton browse;

		// Token: 0x04000112 RID: 274
		private GroupBox ico;

		// Token: 0x04000113 RID: 275
		private SiticoneTextBox icon_txtbox;

		// Token: 0x04000114 RID: 276
		private SiticoneButton icon_browse;

		// Token: 0x04000115 RID: 277
		private GroupBox position;

		// Token: 0x04000116 RID: 278
		private GroupBox txt_on_menu;

		// Token: 0x04000117 RID: 279
		private SiticoneTextBox menu_txtbox;

		// Token: 0x04000118 RID: 280
		private SiticoneCheckBox checkShift;

		// Token: 0x04000119 RID: 281
		private SiticoneComboBox position_cbox;

		// Token: 0x0400011A RID: 282
		private SiticoneButton save;

		// Token: 0x0400011B RID: 283
		private OpenFileDialog openFileDialog1;

		// Token: 0x0400011C RID: 284
		private FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x0400011D RID: 285
		private OpenFileDialog file_browse;

		// Token: 0x0400011E RID: 286
		private OpenFileDialog icon_dialog;

		// Token: 0x0400011F RID: 287
		private SiticoneCheckBox checkDefaultIcon;

		// Token: 0x04000120 RID: 288
		private SiticoneButton delete;

		// Token: 0x04000121 RID: 289
		private SiticoneButton refresh_list;

		// Token: 0x04000122 RID: 290
		private SiticoneButton del_all;

		// Token: 0x04000123 RID: 291
		private Label label3;

		// Token: 0x04000124 RID: 292
		private Label label4;

		// Token: 0x04000125 RID: 293
		private SiticoneCheckBox adv_startup;

		// Token: 0x04000126 RID: 294
		private SiticoneCheckBox takeown;

		// Token: 0x04000127 RID: 295
		private SiticoneCheckBox snip_classic;

		// Token: 0x04000128 RID: 296
		private SiticoneCheckBox shutdown;

		// Token: 0x04000129 RID: 297
		private SiticoneCheckBox settings;

		// Token: 0x0400012A RID: 298
		private SiticoneCheckBox snip;

		// Token: 0x0400012B RID: 299
		private SiticoneCheckBox safe_mode;

		// Token: 0x0400012C RID: 300
		private SiticoneCheckBox run_priority;

		// Token: 0x0400012D RID: 301
		private SiticoneCheckBox res_startmenu;

		// Token: 0x0400012E RID: 302
		private SiticoneCheckBox res_explorer;

		// Token: 0x0400012F RID: 303
		private SiticoneCheckBox powershell_admin;

		// Token: 0x04000130 RID: 304
		private SiticoneCheckBox openwith_nat;

		// Token: 0x04000131 RID: 305
		private SiticoneCheckBox bash;

		// Token: 0x04000132 RID: 306
		private SiticoneCheckBox kill;

		// Token: 0x04000133 RID: 307
		private SiticoneCheckBox hash;

		// Token: 0x04000134 RID: 308
		private SiticoneCheckBox control_pnl;

		// Token: 0x04000135 RID: 309
		private SiticoneCheckBox compact;

		// Token: 0x04000136 RID: 310
		private SiticoneCheckBox cmd_ctxt_admin;

		// Token: 0x04000137 RID: 311
		private SiticoneCheckBox cmd_ctxt;

		// Token: 0x04000138 RID: 312
		private SiticoneCheckBox clip;

		// Token: 0x04000139 RID: 313
		private SiticoneCheckBox bt;

		// Token: 0x0400013A RID: 314
		private SiticoneCheckBox attributes;

		// Token: 0x0400013B RID: 315
		private SiticoneCheckBox app_mode;

		// Token: 0x0400013C RID: 316
		private SiticoneCheckBox taskmgr;

		// Token: 0x0400013D RID: 317
		private SiticoneCheckBox sfc;

		// Token: 0x0400013E RID: 318
		private SiticoneCheckBox win_tools;

		// Token: 0x0400013F RID: 319
		private SiticoneCheckBox win_mode;

		// Token: 0x04000140 RID: 320
		public TabPage tabPage3;
	}
}
