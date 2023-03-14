using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Login_HWID;
using Login_HWID.Class;
using Login_HWID.User_Controls;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000018 RID: 24
	public class Tweaks : UserControl
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00059C44 File Offset: 0x00057E44
		public static Tweaks Instance
		{
			get
			{
				if (Tweaks._instace == null)
				{
					Tweaks._instace = new Tweaks();
				}
				return Tweaks._instace;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00059C6C File Offset: 0x00057E6C
		public Tweaks()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
			this.ReadSettings();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00059CF8 File Offset: 0x00057EF8
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
					goto IL_57;
				}
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_57;
				}
				goto IL_74;
				IL_86:
				if (num != 16 && num != 17)
				{
					if (num == 15)
					{
						goto IL_132;
					}
					IL_144:
					if (num == 14)
					{
						break;
					}
					if (num != 12)
					{
						if (num == 11)
						{
							goto IL_F6;
						}
						IL_115:
						if (num == 9)
						{
							if (text == "Accent Color")
							{
								goto IL_132;
							}
							num = 10;
						}
						if (num == 7)
						{
							if (text == "Xmas")
							{
								goto IL_F6;
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
						IL_F6:
						this.Xmas_theme();
						num = 12;
						goto IL_115;
					}
					break;
					IL_132:
					this.AccentColor();
					num = 16;
					goto IL_144;
				}
				break;
				IL_74:
				this.Halloween();
				num = 14;
				goto IL_86;
				IL_57:
				if (num == 10)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_74;
				}
				goto IL_86;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00059F44 File Offset: 0x00058144
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

		// Token: 0x06000169 RID: 361 RVA: 0x00059FBC File Offset: 0x000581BC
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

		// Token: 0x0600016A RID: 362 RVA: 0x0005A020 File Offset: 0x00058220
		private void Halloween()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.panel1.Controls.OfType<CheckBox>().GetEnumerator();
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

		// Token: 0x0600016B RID: 363 RVA: 0x0005A0F0 File Offset: 0x000582F0
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
					enumerator = this.panel1.Controls.OfType<CheckBox>().GetEnumerator();
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

		// Token: 0x0600016C RID: 364 RVA: 0x0005A1E8 File Offset: 0x000583E8
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.panel1.Controls.OfType<CheckBox>().GetEnumerator();
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

		// Token: 0x0600016D RID: 365 RVA: 0x0005A2B8 File Offset: 0x000584B8
		private void tweaks_Load(object sender, EventArgs e)
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
					value = registryKey.GetValue("Disable_Ads");
					num = 3;
				}
				if (num != 4)
				{
					goto IL_3A;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_3A;
				}
				goto IL_67;
				IL_7A:
				if (num != 8)
				{
					goto IL_8E;
				}
				bool flag2;
				if (flag2)
				{
					num = 9;
					goto IL_8E;
				}
				goto IL_BB;
				IL_CE:
				if (num != 12)
				{
					goto IL_E5;
				}
				bool flag3;
				if (flag3)
				{
					num = 13;
					goto IL_E5;
				}
				goto IL_F7A;
				IL_F8D:
				object value2;
				if (num == 11)
				{
					flag3 = value2 != null;
					num = 12;
				}
				object value3;
				if (num == 7)
				{
					flag2 = value3 != null;
					num = 8;
				}
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 146)
				{
					break;
				}
				continue;
				IL_E5:
				if (num == 13)
				{
					this.automain.CheckState = CheckState.Checked;
					num = 14;
				}
				object value4;
				bool flag4;
				if (num == 15)
				{
					flag4 = value4 != null;
					num = 16;
				}
				if (num != 16)
				{
					goto IL_136;
				}
				if (flag4)
				{
					num = 17;
					goto IL_136;
				}
				goto IL_F5D;
				IL_F70:
				if (num == 14)
				{
					goto IL_F7A;
				}
				goto IL_F8D;
				IL_136:
				if (num == 17)
				{
					this.cortana.CheckState = CheckState.Checked;
					num = 18;
				}
				object value5;
				bool flag5;
				if (num == 19)
				{
					flag5 = value5 != null;
					num = 20;
				}
				if (num != 20)
				{
					goto IL_187;
				}
				if (flag5)
				{
					num = 21;
					goto IL_187;
				}
				goto IL_F40;
				IL_F53:
				if (num == 18)
				{
					goto IL_F5D;
				}
				goto IL_F70;
				IL_187:
				if (num == 21)
				{
					this.dlblock.CheckState = CheckState.Checked;
					num = 22;
				}
				object value6;
				bool flag6;
				if (num == 23)
				{
					flag6 = value6 != null;
					num = 24;
				}
				if (num != 24)
				{
					goto IL_1D5;
				}
				if (flag6)
				{
					num = 25;
					goto IL_1D5;
				}
				goto IL_1DF;
				IL_1F2:
				object value7;
				bool flag7;
				if (num == 27)
				{
					flag7 = value7 != null;
					num = 28;
				}
				if (num != 28)
				{
					goto IL_21D;
				}
				if (flag7)
				{
					num = 29;
					goto IL_21D;
				}
				goto IL_227;
				IL_23A:
				object value8;
				bool flag8;
				if (num == 31)
				{
					flag8 = value8 != null;
					num = 32;
				}
				if (num != 32)
				{
					goto IL_265;
				}
				if (flag8)
				{
					num = 33;
					goto IL_265;
				}
				goto IL_26F;
				IL_282:
				object value9;
				bool flag9;
				if (num == 35)
				{
					flag9 = value9 != null;
					num = 36;
				}
				if (num == 37)
				{
					this.storeup.CheckState = CheckState.Checked;
					num = 38;
				}
				if (num == 38)
				{
					goto IL_E95;
				}
				IL_EA8:
				object value10;
				bool flag10;
				if (num == 39)
				{
					flag10 = value10 != null;
					num = 40;
				}
				if (num == 41)
				{
					this.wallpaper.CheckState = CheckState.Checked;
					num = 42;
				}
				if (num == 42)
				{
					goto IL_E4F;
				}
				IL_E62:
				object value11;
				bool flag11;
				if (num == 43)
				{
					flag11 = value11 != null;
					num = 44;
				}
				if (num == 45)
				{
					this.sysres.CheckState = CheckState.Checked;
					num = 46;
				}
				if (num == 46)
				{
					goto IL_E05;
				}
				IL_E25:
				if (num != 48)
				{
					goto IL_33B;
				}
				bool flag12;
				if (flag12)
				{
					num = 49;
					goto IL_33B;
				}
				goto IL_368;
				IL_37B:
				if (num != 52)
				{
					goto IL_38F;
				}
				bool flag13;
				if (flag13)
				{
					num = 53;
					goto IL_38F;
				}
				goto IL_3BC;
				IL_3CF:
				if (num != 56)
				{
					goto IL_3E3;
				}
				bool flag14;
				if (flag14)
				{
					num = 57;
					goto IL_3E3;
				}
				goto IL_410;
				IL_423:
				if (num != 60)
				{
					goto IL_43A;
				}
				bool flag15;
				if (flag15)
				{
					num = 61;
					goto IL_43A;
				}
				goto IL_D88;
				IL_D9B:
				object value12;
				if (num == 59)
				{
					flag15 = value12 != null;
					num = 60;
				}
				object value13;
				if (num == 55)
				{
					flag14 = value13 != null;
					num = 56;
				}
				object value14;
				if (num == 51)
				{
					flag13 = value14 != null;
					num = 52;
				}
				object value15;
				if (num == 47)
				{
					flag12 = value15 != null;
					num = 48;
				}
				if (num == 44)
				{
					if (!flag11)
					{
						goto IL_E05;
					}
					num = 45;
				}
				if (num == 40)
				{
					if (!flag10)
					{
						goto IL_E4F;
					}
					num = 41;
				}
				if (num == 36)
				{
					if (!flag9)
					{
						goto IL_E95;
					}
					num = 37;
				}
				if (num == 33)
				{
					this.mrt.CheckState = CheckState.Checked;
					num = 34;
				}
				if (num == 29)
				{
					this.errror.CheckState = CheckState.Checked;
					num = 30;
				}
				if (num == 25)
				{
					this.driver.CheckState = CheckState.Checked;
					num = 26;
				}
				if (num == 22)
				{
					goto IL_F40;
				}
				goto IL_F53;
				IL_43A:
				if (num == 61)
				{
					this.timeline.CheckState = CheckState.Checked;
					num = 62;
				}
				object value16;
				bool flag16;
				if (num == 63)
				{
					flag16 = value16 != null;
					num = 64;
				}
				if (num != 64)
				{
					goto IL_48B;
				}
				if (flag16)
				{
					num = 65;
					goto IL_48B;
				}
				goto IL_D6B;
				IL_D7E:
				if (num == 62)
				{
					goto IL_D88;
				}
				goto IL_D9B;
				IL_48B:
				if (num == 65)
				{
					this.winup.CheckState = CheckState.Checked;
					num = 66;
				}
				object value17;
				bool flag17;
				if (num == 67)
				{
					flag17 = value17 != null;
					num = 68;
				}
				if (num != 68)
				{
					goto IL_4DC;
				}
				if (flag17)
				{
					num = 69;
					goto IL_4DC;
				}
				goto IL_D4E;
				IL_D61:
				if (num == 66)
				{
					goto IL_D6B;
				}
				goto IL_D7E;
				IL_4DC:
				if (num == 69)
				{
					this.photo.CheckState = CheckState.Checked;
					num = 70;
				}
				object value18;
				bool flag18;
				if (num == 71)
				{
					flag18 = value18 != null;
					num = 72;
				}
				if (num != 72)
				{
					goto IL_52A;
				}
				if (flag18)
				{
					num = 73;
					goto IL_52A;
				}
				goto IL_534;
				IL_547:
				object value19;
				bool flag19;
				if (num == 75)
				{
					flag19 = value19 != null;
					num = 76;
				}
				if (num != 76)
				{
					goto IL_572;
				}
				if (flag19)
				{
					num = 77;
					goto IL_572;
				}
				goto IL_57C;
				IL_58F:
				object value20;
				bool flag20;
				if (num == 79)
				{
					flag20 = value20 != null;
					num = 80;
				}
				if (num != 80)
				{
					goto IL_5BA;
				}
				if (flag20)
				{
					num = 81;
					goto IL_5BA;
				}
				goto IL_5C4;
				IL_5D7:
				object value21;
				bool flag21;
				if (num == 83)
				{
					flag21 = value21 != null;
					num = 84;
				}
				if (num == 85)
				{
					this.mmcss.CheckState = CheckState.Checked;
					num = 86;
				}
				if (num == 86)
				{
					goto IL_CA3;
				}
				IL_CB6:
				object value22;
				bool flag22;
				if (num == 87)
				{
					flag22 = value22 != null;
					num = 88;
				}
				if (num == 89)
				{
					this.spectre.CheckState = CheckState.Checked;
					num = 90;
				}
				if (num == 90)
				{
					goto IL_C5D;
				}
				IL_C70:
				object value23;
				bool flag23;
				if (num == 91)
				{
					flag23 = value23 != null;
					num = 92;
				}
				if (num == 93)
				{
					this.large.CheckState = CheckState.Checked;
					num = 94;
				}
				if (num == 94)
				{
					goto IL_C13;
				}
				IL_C33:
				if (num != 96)
				{
					goto IL_690;
				}
				bool flag24;
				if (flag24)
				{
					num = 97;
					goto IL_690;
				}
				goto IL_6BD;
				IL_6D0:
				if (num != 100)
				{
					goto IL_6E4;
				}
				bool flag25;
				if (flag25)
				{
					num = 101;
					goto IL_6E4;
				}
				goto IL_711;
				IL_724:
				if (num != 104)
				{
					goto IL_738;
				}
				bool flag26;
				if (flag26)
				{
					num = 105;
					goto IL_738;
				}
				goto IL_765;
				IL_778:
				if (num != 108)
				{
					goto IL_78F;
				}
				bool flag27;
				if (flag27)
				{
					num = 109;
					goto IL_78F;
				}
				goto IL_B96;
				IL_BA9:
				object value24;
				if (num == 107)
				{
					flag27 = value24 != null;
					num = 108;
				}
				object value25;
				if (num == 103)
				{
					flag26 = value25 != null;
					num = 104;
				}
				object value26;
				if (num == 99)
				{
					flag25 = value26 != null;
					num = 100;
				}
				object value27;
				if (num == 95)
				{
					flag24 = value27 != null;
					num = 96;
				}
				if (num == 92)
				{
					if (!flag23)
					{
						goto IL_C13;
					}
					num = 93;
				}
				if (num == 88)
				{
					if (!flag22)
					{
						goto IL_C5D;
					}
					num = 89;
				}
				if (num == 84)
				{
					if (!flag21)
					{
						goto IL_CA3;
					}
					num = 85;
				}
				if (num == 81)
				{
					this.boot.CheckState = CheckState.Checked;
					num = 82;
				}
				if (num == 77)
				{
					this.power.CheckState = CheckState.Checked;
					num = 78;
				}
				if (num == 73)
				{
					this.sysmain.CheckState = CheckState.Checked;
					num = 74;
				}
				if (num == 70)
				{
					goto IL_D4E;
				}
				goto IL_D61;
				IL_78F:
				if (num == 109)
				{
					this.fast_start.CheckState = CheckState.Checked;
					num = 110;
				}
				object value28;
				bool flag28;
				if (num == 111)
				{
					flag28 = value28 != null;
					num = 112;
				}
				if (num != 112)
				{
					goto IL_7E0;
				}
				if (flag28)
				{
					num = 113;
					goto IL_7E0;
				}
				goto IL_B79;
				IL_B8C:
				if (num == 110)
				{
					goto IL_B96;
				}
				goto IL_BA9;
				IL_7E0:
				if (num == 113)
				{
					this.hiber.CheckState = CheckState.Checked;
					num = 114;
				}
				object value29;
				bool flag29;
				if (num == 115)
				{
					flag29 = value29 != null;
					num = 116;
				}
				if (num != 116)
				{
					goto IL_831;
				}
				if (flag29)
				{
					num = 117;
					goto IL_831;
				}
				goto IL_B5C;
				IL_B6F:
				if (num == 114)
				{
					goto IL_B79;
				}
				goto IL_B8C;
				IL_831:
				if (num == 117)
				{
					this.lockscr.CheckState = CheckState.Checked;
					num = 118;
				}
				object value30;
				bool flag30;
				if (num == 119)
				{
					flag30 = value30 != null;
					num = 120;
				}
				if (num != 120)
				{
					goto IL_87F;
				}
				if (flag30)
				{
					num = 121;
					goto IL_87F;
				}
				goto IL_889;
				IL_89C:
				object value31;
				bool flag31;
				if (num == 123)
				{
					flag31 = value31 != null;
					num = 124;
				}
				if (num != 124)
				{
					goto IL_8C7;
				}
				if (flag31)
				{
					num = 125;
					goto IL_8C7;
				}
				goto IL_8D1;
				IL_8E4:
				object value32;
				bool flag32;
				if (num == 127)
				{
					flag32 = value32 != null;
					num = 128;
				}
				if (num != 128)
				{
					goto IL_90F;
				}
				if (flag32)
				{
					num = 129;
					goto IL_90F;
				}
				goto IL_919;
				IL_92C:
				object value33;
				bool flag33;
				if (num == 131)
				{
					flag33 = value33 != null;
					num = 132;
				}
				if (num == 133)
				{
					this.uac_admin.CheckState = CheckState.Checked;
					num = 134;
				}
				if (num == 134)
				{
					goto IL_AB1;
				}
				IL_AC4:
				object value34;
				bool flag34;
				if (num == 135)
				{
					flag34 = value34 != null;
					num = 136;
				}
				if (num == 137)
				{
					this.hpet.CheckState = CheckState.Checked;
					num = 138;
				}
				if (num == 138)
				{
					goto IL_A6B;
				}
				IL_A7E:
				object value35;
				bool flag35;
				if (num == 139)
				{
					flag35 = value35 != null;
					num = 140;
				}
				if (num == 141)
				{
					this.sticky_keys.CheckState = CheckState.Checked;
					num = 142;
				}
				if (num == 142)
				{
					goto IL_A27;
				}
				IL_A44:
				if (num == 144)
				{
					bool flag36;
					if (!flag36)
					{
						break;
					}
					num = 145;
				}
				if (num == 145)
				{
					this.ntfs.CheckState = CheckState.Checked;
					num = 146;
				}
				object value36;
				if (num == 143)
				{
					bool flag36 = value36 != null;
					num = 144;
				}
				if (num == 140)
				{
					if (!flag35)
					{
						goto IL_A27;
					}
					num = 141;
				}
				if (num == 136)
				{
					if (!flag34)
					{
						goto IL_A6B;
					}
					num = 137;
				}
				if (num == 132)
				{
					if (!flag33)
					{
						goto IL_AB1;
					}
					num = 133;
				}
				if (num == 129)
				{
					this.admin.CheckState = CheckState.Checked;
					num = 130;
				}
				if (num == 125)
				{
					this.uac.CheckState = CheckState.Checked;
					num = 126;
				}
				if (num == 121)
				{
					this.prt_spool.CheckState = CheckState.Checked;
					num = 122;
				}
				if (num == 118)
				{
					goto IL_B5C;
				}
				goto IL_B6F;
				IL_A27:
				value36 = registryKey.GetValue("NTFS_Timestamp");
				num = 143;
				goto IL_A44;
				IL_A6B:
				value35 = registryKey.GetValue("Disable_Sticky_keys");
				num = 139;
				goto IL_A7E;
				IL_AB1:
				value34 = registryKey.GetValue("Disable_HPET");
				num = 135;
				goto IL_AC4;
				IL_90F:
				if (num != 130)
				{
					goto IL_92C;
				}
				IL_919:
				value33 = registryKey.GetValue("Enable_AdminUAC");
				num = 131;
				goto IL_92C;
				IL_8C7:
				if (num != 126)
				{
					goto IL_8E4;
				}
				IL_8D1:
				value32 = registryKey.GetValue("Enable_AdminAcc");
				num = 127;
				goto IL_8E4;
				IL_87F:
				if (num != 122)
				{
					goto IL_89C;
				}
				IL_889:
				value31 = registryKey.GetValue("Disable_UAC");
				num = 123;
				goto IL_89C;
				IL_B5C:
				value30 = registryKey.GetValue("Disable_Print");
				num = 119;
				goto IL_B6F;
				IL_B79:
				value29 = registryKey.GetValue("Disable_LockScreen");
				num = 115;
				goto IL_B8C;
				IL_B96:
				value28 = registryKey.GetValue("Disable_Hibernation");
				num = 111;
				goto IL_BA9;
				IL_738:
				if (num == 105)
				{
					this.clipboard.CheckState = CheckState.Checked;
					num = 106;
				}
				if (num != 106)
				{
					goto IL_778;
				}
				IL_765:
				value24 = registryKey.GetValue("Disable_FastStartup");
				num = 107;
				goto IL_778;
				IL_6E4:
				if (num == 101)
				{
					this.cortana_bar.CheckState = CheckState.Checked;
					num = 102;
				}
				if (num != 102)
				{
					goto IL_724;
				}
				IL_711:
				value25 = registryKey.GetValue("Disable_Clip");
				num = 103;
				goto IL_724;
				IL_690:
				if (num == 97)
				{
					this.action.CheckState = CheckState.Checked;
					num = 98;
				}
				if (num != 98)
				{
					goto IL_6D0;
				}
				IL_6BD:
				value26 = registryKey.GetValue("Disable_CortanaBAR");
				num = 99;
				goto IL_6D0;
				IL_C13:
				value27 = registryKey.GetValue("Disable_ActionCenter");
				num = 95;
				goto IL_C33;
				IL_C5D:
				value23 = registryKey.GetValue("Disable_LargeSystemCache");
				num = 91;
				goto IL_C70;
				IL_CA3:
				value22 = registryKey.GetValue("Disable_Spectre_Meltdown");
				num = 87;
				goto IL_CB6;
				IL_5BA:
				if (num != 82)
				{
					goto IL_5D7;
				}
				IL_5C4:
				value21 = registryKey.GetValue("Disable_mmcss");
				num = 83;
				goto IL_5D7;
				IL_572:
				if (num != 78)
				{
					goto IL_58F;
				}
				IL_57C:
				value20 = registryKey.GetValue("Disable_Boot_Tracing");
				num = 79;
				goto IL_58F;
				IL_52A:
				if (num != 74)
				{
					goto IL_547;
				}
				IL_534:
				value19 = registryKey.GetValue("Disable_Power_Throttling");
				num = 75;
				goto IL_547;
				IL_D4E:
				value18 = registryKey.GetValue("Disable_Symain");
				num = 71;
				goto IL_D61;
				IL_D6B:
				value17 = registryKey.GetValue("Enable_Classic");
				num = 67;
				goto IL_D7E;
				IL_D88:
				value16 = registryKey.GetValue("Disable_Windows_Update");
				num = 63;
				goto IL_D9B;
				IL_3E3:
				if (num == 57)
				{
					this.inkspace.CheckState = CheckState.Checked;
					num = 58;
				}
				if (num != 58)
				{
					goto IL_423;
				}
				IL_410:
				value12 = registryKey.GetValue("Disable_Timeline");
				num = 59;
				goto IL_423;
				IL_38F:
				if (num == 53)
				{
					this.windef.CheckState = CheckState.Checked;
					num = 54;
				}
				if (num != 54)
				{
					goto IL_3CF;
				}
				IL_3BC:
				value13 = registryKey.GetValue("Disable_Inkspace");
				num = 55;
				goto IL_3CF;
				IL_33B:
				if (num == 49)
				{
					this.tele.CheckState = CheckState.Checked;
					num = 50;
				}
				if (num != 50)
				{
					goto IL_37B;
				}
				IL_368:
				value14 = registryKey.GetValue("Disable_Windows_Defender");
				num = 51;
				goto IL_37B;
				IL_E05:
				value15 = registryKey.GetValue("Disable_Telemetry");
				num = 47;
				goto IL_E25;
				IL_E4F:
				value11 = registryKey.GetValue("Disable_System_Restore");
				num = 43;
				goto IL_E62;
				IL_E95:
				value10 = registryKey.GetValue("Disable_Wallpaper_Redcution");
				num = 39;
				goto IL_EA8;
				IL_265:
				if (num != 34)
				{
					goto IL_282;
				}
				IL_26F:
				value9 = registryKey.GetValue("Disable_Store_Up");
				num = 35;
				goto IL_282;
				IL_21D:
				if (num != 30)
				{
					goto IL_23A;
				}
				IL_227:
				value8 = registryKey.GetValue("Disable_MRT_Updates");
				num = 31;
				goto IL_23A;
				IL_1D5:
				if (num != 26)
				{
					goto IL_1F2;
				}
				IL_1DF:
				value7 = registryKey.GetValue("Disable_Error_Rep");
				num = 27;
				goto IL_1F2;
				IL_F40:
				value6 = registryKey.GetValue("Disable_Automatic_Driver_Up");
				num = 23;
				goto IL_F53;
				IL_F5D:
				value5 = registryKey.GetValue("Disable_Automatic_Dl_Block");
				num = 19;
				goto IL_F70;
				IL_F7A:
				value4 = registryKey.GetValue("Disable_Cortana");
				num = 15;
				goto IL_F8D;
				IL_8E:
				if (num == 9)
				{
					this.lookup.CheckState = CheckState.Checked;
					num = 10;
				}
				if (num != 10)
				{
					goto IL_CE;
				}
				IL_BB:
				value2 = registryKey.GetValue("Disable_Automatic_Maintenance");
				num = 11;
				goto IL_CE;
				IL_3A:
				if (num == 5)
				{
					this.ads.CheckState = CheckState.Checked;
					num = 6;
				}
				if (num != 6)
				{
					goto IL_7A;
				}
				IL_67:
				value3 = registryKey.GetValue("Disable_App_Lookup");
				num = 7;
				goto IL_7A;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0005B2DC File Offset: 0x000594DC
		private void action_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.action.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Disable_ActionCenter");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 1, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_ActionCenter", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 0, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0005B404 File Offset: 0x00059604
		private void ads_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent");
					num = 2;
				}
				RegistryKey registryKey2;
				if (num == 2)
				{
					registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager");
					num = 3;
				}
				RegistryKey registryKey3;
				if (num == 4)
				{
					registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 5;
				}
				RegistryKey registryKey4;
				if (num == 5)
				{
					registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 6;
				}
				RegistryKey registryKey5;
				if (num == 6)
				{
					registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 7;
				}
				RegistryKey registryKey6;
				if (num == 8)
				{
					registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 9;
				}
				RegistryKey registryKey7;
				if (num == 9)
				{
					registryKey7 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 10;
				}
				RegistryKey registryKey8;
				if (num == 10)
				{
					registryKey8 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 11;
				}
				if (num != 12)
				{
					goto IL_107;
				}
				bool @checked;
				if (@checked)
				{
					num = 13;
					goto IL_107;
				}
				goto IL_294;
				IL_2A5:
				if (num == 27)
				{
					registryKey2.DeleteValue("SilentInstalledAppsEnabled");
					num = 28;
				}
				if (num == 28)
				{
					RegistryKey registryKey9;
					registryKey9.SetValue("SystemPaneSuggestionsEnabled", 1, RegistryValueKind.DWord);
					num = 29;
				}
				if (num == 30)
				{
					registryKey4.SetValue("SoftLandingEnabled", 1, RegistryValueKind.DWord);
					num = 31;
				}
				if (num == 31)
				{
					registryKey5.SetValue("RotatingLockScreenOverlayEnabled", 1, RegistryValueKind.DWord);
					num = 32;
				}
				if (num == 32)
				{
					registryKey5.SetValue("RotatingLockScreenEnabled", 1, RegistryValueKind.DWord);
					num = 33;
				}
				if (num == 34)
				{
					registryKey6.SetValue("SubscribedContent-338393Enabled", 1, RegistryValueKind.DWord);
					num = 35;
				}
				if (num == 35)
				{
					registryKey7.SetValue("SubscribedContent-314563Enabled", 1, RegistryValueKind.DWord);
					num = 36;
				}
				if (num == 37)
				{
					this.toolkit.DeleteValue("Disable_Ads");
					num = 38;
				}
				if (num == 36)
				{
					registryKey8.SetValue("SubscribedContent-314563Enabled", 1, RegistryValueKind.DWord);
					num = 37;
				}
				if (num == 33)
				{
					RegistryKey registryKey10;
					registryKey10.SetValue("SubscribedContent-310093Enabled", 1, RegistryValueKind.DWord);
					num = 34;
				}
				if (num == 29)
				{
					registryKey3.SetValue("ShowSyncProviderNotifications", 1, RegistryValueKind.DWord);
					num = 30;
				}
				if (num == 25)
				{
					break;
				}
				if (num == 22)
				{
					registryKey6.SetValue("SubscribedContent-338393Enabled", 0, RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 18)
				{
					registryKey4.SetValue("SoftLandingEnabled", 0, RegistryValueKind.DWord);
					num = 19;
				}
				if (num == 14)
				{
					registryKey.SetValue("DisableWindowsConsumerFeatures", 1, RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 11)
				{
					@checked = this.ads.Checked;
					num = 12;
				}
				if (num == 7)
				{
					RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
					num = 8;
				}
				if (num == 3)
				{
					RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager");
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 38)
				{
					break;
				}
				continue;
				IL_107:
				if (num == 13)
				{
					this.toolkit.SetValue("Disable_Ads", 1);
					num = 14;
				}
				if (num == 15)
				{
					registryKey2.SetValue("SilentInstalledAppsEnabled", 0, RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					RegistryKey registryKey9;
					registryKey9.SetValue("SystemPaneSuggestionsEnabled", 0, RegistryValueKind.DWord);
					num = 17;
				}
				if (num == 17)
				{
					registryKey3.SetValue("ShowSyncProviderNotifications", 0, RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 19)
				{
					registryKey5.SetValue("RotatingLockScreenOverlayEnabled", 0, RegistryValueKind.DWord);
					num = 20;
				}
				if (num == 20)
				{
					registryKey5.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
					num = 21;
				}
				if (num == 21)
				{
					RegistryKey registryKey10;
					registryKey10.SetValue("SubscribedContent-310093Enabled", 0, RegistryValueKind.DWord);
					num = 22;
				}
				if (num == 23)
				{
					registryKey7.SetValue("SubscribedContent-314563Enabled", 0, RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					registryKey8.SetValue("SubscribedContent-353698Enabled", 0, RegistryValueKind.DWord);
					num = 25;
				}
				if (num != 26)
				{
					goto IL_2A5;
				}
				IL_294:
				registryKey.DeleteValue("DisableWindowsConsumerFeatures");
				num = 27;
				goto IL_2A5;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0005B9AC File Offset: 0x00059BAC
		private void lookup_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsStore");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.lookup.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("AutoDownload", 2, RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_App_Lookup", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_App_Lookup");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_BC;
					}
					IL_CD:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_BC;
						}
						num = 4;
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
					IL_BC:
					registryKey.DeleteValue("AutoDownload");
					num = 8;
					goto IL_CD;
				}
				break;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0005BAE0 File Offset: 0x00059CE0
		private void automain_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.automain.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("MaintenanceDisabled", 1);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Automatic_Maintenance", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Automatic_Maintenance");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("MaintenanceDisabled");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0005BC10 File Offset: 0x00059E10
		private void cortana_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search");
					num = 2;
				}
				RegistryKey registryKey2;
				if (num == 2)
				{
					registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search");
					num = 3;
				}
				if (num != 4)
				{
					goto IL_3E;
				}
				bool @checked;
				if (@checked)
				{
					num = 5;
					goto IL_3E;
				}
				goto IL_9F;
				IL_B0:
				if (num == 10)
				{
					registryKey2.DeleteValue("SearchboxTaskbarMode");
					num = 11;
				}
				if (num == 11)
				{
					this.toolkit.DeleteValue("Disable_Cortana");
					num = 12;
				}
				if (num == 7)
				{
					this.toolkit.SetValue("Disable_Cortana", 1);
					num = 8;
				}
				if (num == 3)
				{
					@checked = this.cortana.Checked;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					break;
				}
				continue;
				IL_3E:
				if (num == 5)
				{
					registryKey.SetValue("AllowCortana", 0);
					num = 6;
				}
				if (num == 6)
				{
					registryKey2.SetValue("SearchboxTaskbarMode", 0);
					num = 7;
				}
				if (num == 8)
				{
					break;
				}
				if (num != 9)
				{
					goto IL_B0;
				}
				IL_9F:
				registryKey.DeleteValue("AllowCortana");
				num = 10;
				goto IL_B0;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0005BD9C File Offset: 0x00059F9C
		private void cortana_bar_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.cortana_bar.Checked;
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
				goto IL_E4;
				IL_108:
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 1, RegistryValueKind.DWord);
					num = 4;
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
				IL_21:
				if (num == 4)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Search", "SearchboxTaskbar", 1, RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_CortanaBAR", 1);
					num = 6;
				}
				if (num == 6)
				{
					break;
				}
				if (num == 8)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Search", "SearchboxTaskbar", 0, RegistryValueKind.DWord);
					num = 9;
				}
				if (num == 9)
				{
					this.toolkit.DeleteValue("Disable_CortanaBAR");
					num = 10;
				}
				if (num != 7)
				{
					goto IL_108;
				}
				IL_E4:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);
				num = 8;
				goto IL_108;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0005BF24 File Offset: 0x0005A124
		private void clipboard_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\cbdhsvc");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.clipboard.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("Start", "4", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Clip", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Clip");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_D2:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.SetValue("Start", "2", RegistryValueKind.DWord);
					num = 8;
					goto IL_D2;
				}
				break;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0005C05C File Offset: 0x0005A25C
		private void dlblock_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.dlblock.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("SaveZoneInformation", 1);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Automatic_Dl_Block", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Automatic_Dl_Block");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("SaveZoneInformation");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0005C18C File Offset: 0x0005A38C
		private void driver_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.driver.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("ExcludeWUDriversInQualityUpdate", 1, RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Automatic_Driver_Up", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Automatic_Driver_Up");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_BC;
					}
					IL_CD:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_BC;
						}
						num = 4;
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
					IL_BC:
					registryKey.DeleteValue("ExcludeWUDriversInQualityUpdate");
					num = 8;
					goto IL_CD;
				}
				break;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0005C2C0 File Offset: 0x0005A4C0
		private void errror_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\Windows Error Reporting");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.errror.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("Disabled", 1);
					num = 5;
				}
				if (num == 5)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 4, RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					this.toolkit.SetValue("Disable_Error_Rep", 1);
					num = 7;
				}
				if (num == 8)
				{
					goto IL_F4;
				}
				IL_118:
				if (num == 9)
				{
					registryKey.DeleteValue("Disabled");
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.DeleteValue("Disable_Error_Rep");
					num = 11;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 3)
				{
					if (!@checked)
					{
						goto IL_F4;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_F4:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 2, RegistryValueKind.DWord);
				num = 9;
				goto IL_118;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0005C450 File Offset: 0x0005A650
		private void fast_start_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.fast_start.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_6E:
				ProcessStartInfo processStartInfo;
				if (num == 8)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 9;
				}
				if (num == 9)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 10;
				}
				if (num == 10)
				{
					processStartInfo.Arguments = "/C cmd.exe powercfg -hibernate on";
					num = 11;
				}
				Process process;
				if (num == 12)
				{
					process.Start();
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 1, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 14)
				{
					this.toolkit.DeleteValue("Disable_FastStartup");
					num = 15;
				}
				if (num == 11)
				{
					process.StartInfo = processStartInfo;
					num = 12;
				}
				if (num == 7)
				{
					processStartInfo = new ProcessStartInfo();
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 0, RegistryValueKind.DWord);
					num = 4;
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
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_FastStartup", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_6E;
				}
				IL_62:
				process = new Process();
				num = 7;
				goto IL_6E;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0005C624 File Offset: 0x0005A824
		private void hiber_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.hiber.Checked;
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
				goto IL_D2;
				IL_DF:
				ProcessStartInfo processStartInfo;
				if (num == 13)
				{
					processStartInfo = new ProcessStartInfo();
					num = 14;
				}
				if (num == 15)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 16;
				}
				if (num == 16)
				{
					processStartInfo.Arguments = "/C cmd.exe powercfg -hibernate off";
					num = 17;
				}
				Process process;
				if (num == 17)
				{
					process.StartInfo = processStartInfo;
					num = 18;
				}
				RegistryKey registryKey;
				if (num == 19)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations");
					num = 20;
				}
				bool flag;
				if (num == 20)
				{
					flag = registryKey != null;
					num = 21;
				}
				if (num == 21)
				{
					if (!flag)
					{
						break;
					}
					num = 22;
				}
				if (num == 23)
				{
					registryKey.Close();
					num = 24;
				}
				if (num == 22)
				{
					registryKey.DeleteValue("Disable_Hibernation");
					num = 23;
				}
				if (num == 18)
				{
					process.Start();
					num = 19;
				}
				if (num == 14)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 15;
				}
				if (num == 11)
				{
					break;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 7)
				{
					processStartInfo2.Arguments = "/C cmd.exe powercfg -hibernate on";
					num = 8;
				}
				Process process2;
				if (num == 3)
				{
					process2 = new Process();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 24)
				{
					break;
				}
				continue;
				IL_21:
				if (num == 4)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 5;
				}
				if (num == 5)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 6;
				}
				if (num == 6)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 7;
				}
				if (num == 8)
				{
					process2.StartInfo = processStartInfo2;
					num = 9;
				}
				if (num == 9)
				{
					process2.Start();
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.SetValue("Disable_Hibernation", 1);
					num = 11;
				}
				if (num != 12)
				{
					goto IL_DF;
				}
				IL_D2:
				process = new Process();
				num = 13;
				goto IL_DF;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0005C8B0 File Offset: 0x0005AAB0
		private void lockscr_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.lockscr.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Disable_LockScreen");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 1, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_LockScreen", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 0, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0005C9D8 File Offset: 0x0005ABD8
		private void mrt_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\MRT");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.mrt.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("DontOfferThroughWUAU", 1);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_MRT_Updates", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_MRT_Updates");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("DontOfferThroughWUAU");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0005CB08 File Offset: 0x0005AD08
		private void prt_spool_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.prt_spool.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Disable_Print");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 4, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_Print", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 2, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0005CC30 File Offset: 0x0005AE30
		private void storeup_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsStore");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.storeup.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("AutoDownload", 2);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Store_Up", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Store_Up");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("AutoDownload");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0005CD60 File Offset: 0x0005AF60
		private void sysres_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.sysres.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("DisableSR", 1);
					num = 5;
				}
				if (num == 5)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vds", "Start", 4, RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					this.toolkit.SetValue("Disable_System_Restore", 1);
					num = 7;
				}
				if (num == 8)
				{
					goto IL_F4;
				}
				IL_118:
				if (num == 9)
				{
					registryKey.DeleteValue("DisableSR");
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.DeleteValue("Disable_System_Restore");
					num = 11;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 3)
				{
					if (!@checked)
					{
						goto IL_F4;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_F4:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WerSvc", "Start", 2, RegistryValueKind.DWord);
				num = 9;
				goto IL_118;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0005CEF0 File Offset: 0x0005B0F0
		private void tele_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.tele.Checked;
					num = 3;
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
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 7;
				}
				if (num == 8)
				{
					processStartInfo.Arguments = "/c sc.exe config DiagTrack start= disabled";
					num = 9;
				}
				if (num == 9)
				{
					process.StartInfo = processStartInfo;
					num = 10;
				}
				if (num == 10)
				{
					process.Start();
					num = 11;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 12)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 13;
				}
				if (num == 13)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 14;
				}
				if (num == 15)
				{
					processStartInfo2.Arguments = " /c sc.exe stop DiagTrack";
					num = 16;
				}
				Process process2;
				if (num == 16)
				{
					process2.StartInfo = processStartInfo2;
					num = 17;
				}
				if (num == 17)
				{
					process2.Start();
					num = 18;
				}
				ProcessStartInfo processStartInfo3;
				if (num == 19)
				{
					processStartInfo3 = new ProcessStartInfo();
					num = 20;
				}
				if (num == 20)
				{
					processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
					num = 21;
				}
				if (num == 21)
				{
					processStartInfo3.FileName = "cmd.exe";
					num = 22;
				}
				Process process3;
				if (num == 23)
				{
					process3.StartInfo = processStartInfo3;
					num = 24;
				}
				if (num == 24)
				{
					process3.Start();
					num = 25;
				}
				ProcessStartInfo processStartInfo4;
				if (num == 26)
				{
					processStartInfo4 = new ProcessStartInfo();
					num = 27;
				}
				if (num == 27)
				{
					processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
					num = 28;
				}
				if (num == 28)
				{
					processStartInfo4.FileName = "cmd.exe";
					num = 29;
				}
				Process process4;
				if (num == 30)
				{
					process4.StartInfo = processStartInfo4;
					num = 31;
				}
				if (num == 31)
				{
					process4.Start();
					num = 32;
				}
				Process process5;
				if (num == 32)
				{
					process5 = new Process();
					num = 33;
				}
				ProcessStartInfo processStartInfo5;
				if (num == 34)
				{
					processStartInfo5.WindowStyle = ProcessWindowStyle.Hidden;
					num = 35;
				}
				if (num == 35)
				{
					processStartInfo5.FileName = "cmd.exe";
					num = 36;
				}
				if (num == 37)
				{
					process5.StartInfo = processStartInfo5;
					num = 38;
				}
				if (num == 38)
				{
					process5.Start();
					num = 39;
				}
				Process process6;
				if (num == 39)
				{
					process6 = new Process();
					num = 40;
				}
				ProcessStartInfo processStartInfo6;
				if (num == 41)
				{
					processStartInfo6.WindowStyle = ProcessWindowStyle.Hidden;
					num = 42;
				}
				if (num == 42)
				{
					processStartInfo6.FileName = "cmd.exe";
					num = 43;
				}
				if (num == 43)
				{
					processStartInfo6.Arguments = " /c sc.exe stop diagnosticshub.standardcollector.service";
					num = 44;
				}
				if (num == 45)
				{
					process6.Start();
					num = 46;
				}
				if (num == 46)
				{
					registryKey.SetValue("AllowTelemetry", 0, RegistryValueKind.DWord);
					num = 47;
				}
				if (num != 48)
				{
					if (num == 49)
					{
						goto IL_7B9;
					}
					IL_7C6:
					ProcessStartInfo processStartInfo7;
					if (num == 50)
					{
						processStartInfo7 = new ProcessStartInfo();
						num = 51;
					}
					if (num == 52)
					{
						processStartInfo7.FileName = "cmd.exe";
						num = 53;
					}
					if (num == 53)
					{
						processStartInfo7.Arguments = " /c sc.exe config dmwappushservice start= demand";
						num = 54;
					}
					Process process7;
					if (num == 54)
					{
						process7.StartInfo = processStartInfo7;
						num = 55;
					}
					Process process8;
					if (num == 56)
					{
						process8 = new Process();
						num = 57;
					}
					ProcessStartInfo processStartInfo8;
					if (num == 57)
					{
						processStartInfo8 = new ProcessStartInfo();
						num = 58;
					}
					if (num == 58)
					{
						processStartInfo8.WindowStyle = ProcessWindowStyle.Hidden;
						num = 59;
					}
					if (num == 60)
					{
						processStartInfo8.Arguments = " /c sc.exe config diagnosticshub.standardcollector.service start= demand";
						num = 61;
					}
					if (num == 61)
					{
						process8.StartInfo = processStartInfo8;
						num = 62;
					}
					Process process9;
					if (num == 63)
					{
						process9 = new Process();
						num = 64;
					}
					ProcessStartInfo processStartInfo9;
					if (num == 64)
					{
						processStartInfo9 = new ProcessStartInfo();
						num = 65;
					}
					if (num == 65)
					{
						processStartInfo9.WindowStyle = ProcessWindowStyle.Hidden;
						num = 66;
					}
					if (num == 67)
					{
						processStartInfo9.Arguments = " /c sc.exe config DiagTrack start= auto";
						num = 68;
					}
					if (num == 68)
					{
						process9.StartInfo = processStartInfo9;
						num = 69;
					}
					if (num == 69)
					{
						process9.Start();
						num = 70;
					}
					ProcessStartInfo processStartInfo10;
					if (num == 71)
					{
						processStartInfo10 = new ProcessStartInfo();
						num = 72;
					}
					if (num == 72)
					{
						processStartInfo10.WindowStyle = ProcessWindowStyle.Hidden;
						num = 73;
					}
					if (num == 74)
					{
						processStartInfo10.Arguments = " /c sc.exe start DiagTrack";
						num = 75;
					}
					Process process10;
					if (num == 75)
					{
						process10.StartInfo = processStartInfo10;
						num = 76;
					}
					if (num == 76)
					{
						process10.Start();
						num = 77;
					}
					if (num == 78)
					{
						this.toolkit.DeleteValue("Disable_Telemetry");
						num = 79;
					}
					if (num == 77)
					{
						registryKey.DeleteValue("AllowTelemetry");
						num = 78;
					}
					if (num == 73)
					{
						processStartInfo10.FileName = "cmd.exe";
						num = 74;
					}
					if (num == 70)
					{
						process10 = new Process();
						num = 71;
					}
					if (num == 66)
					{
						processStartInfo9.FileName = "cmd.exe";
						num = 67;
					}
					if (num == 62)
					{
						process8.Start();
						num = 63;
					}
					if (num == 59)
					{
						processStartInfo8.FileName = "cmd.exe";
						num = 60;
					}
					if (num == 55)
					{
						process7.Start();
						num = 56;
					}
					if (num == 51)
					{
						processStartInfo7.WindowStyle = ProcessWindowStyle.Hidden;
						num = 52;
					}
					if (num == 47)
					{
						this.toolkit.SetValue("Disable_Telemetry", 1);
						num = 48;
					}
					if (num == 44)
					{
						process6.StartInfo = processStartInfo6;
						num = 45;
					}
					if (num == 40)
					{
						processStartInfo6 = new ProcessStartInfo();
						num = 41;
					}
					if (num == 36)
					{
						processStartInfo5.Arguments = " /c sc.exe config diagnosticshub.standardcollector.service start= disabled";
						num = 37;
					}
					if (num == 33)
					{
						processStartInfo5 = new ProcessStartInfo();
						num = 34;
					}
					if (num == 29)
					{
						processStartInfo4.Arguments = " /c sc.exe stop dmwappushservice";
						num = 30;
					}
					if (num == 25)
					{
						process4 = new Process();
						num = 26;
					}
					if (num == 22)
					{
						processStartInfo3.Arguments = " /c sc.exe config dmwappushservice start= disabled";
						num = 23;
					}
					if (num == 18)
					{
						process3 = new Process();
						num = 19;
					}
					if (num == 14)
					{
						processStartInfo2.FileName = "cmd.exe";
						num = 15;
					}
					if (num == 11)
					{
						process2 = new Process();
						num = 12;
					}
					if (num == 7)
					{
						processStartInfo.FileName = "cmd.exe";
						num = 8;
					}
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_7B9;
						}
						num = 4;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 79)
					{
						break;
					}
					continue;
					IL_7B9:
					process7 = new Process();
					num = 50;
					goto IL_7C6;
				}
				break;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0005D730 File Offset: 0x0005B930
		private void uac_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.uac.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Disable_UAC");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 0, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_UAC", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 1, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0005D858 File Offset: 0x0005BA58
		private void wallpaper_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.wallpaper.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("JPEGImportQuality", 256, RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Wallpaper_Redcution", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Wallpaper_Redcution");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_BC;
					}
					IL_CD:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_BC;
						}
						num = 4;
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
					IL_BC:
					registryKey.DeleteValue("JPEGImportQuality");
					num = 8;
					goto IL_CD;
				}
				break;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0005D98C File Offset: 0x0005BB8C
		private void windef_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
					num = 2;
				}
				RegistryKey registryKey2;
				if (num == 2)
				{
					registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
					num = 3;
				}
				bool @checked;
				if (num == 4)
				{
					@checked = this.windef.Checked;
					num = 5;
				}
				if (num != 5)
				{
					goto IL_60;
				}
				if (@checked)
				{
					num = 6;
					goto IL_60;
				}
				goto IL_202;
				IL_222:
				if (num == 21)
				{
					registryKey2.SetValue("DisableBehaviorMonitoring", 0, RegistryValueKind.DWord);
					num = 22;
				}
				if (num == 23)
				{
					registryKey2.SetValue("DisableScanOnRealtimeEnable", 0, RegistryValueKind.DWord);
					num = 24;
				}
				if (num == 24)
				{
					registryKey2.SetValue("DisableRealtimeMonitoring", 0, RegistryValueKind.DWord);
					num = 25;
				}
				if (num == 26)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppContainer\\Storage\\microsoft.microsoftedge_8wekyb3d8bbwe\\MicrosoftEdge\\PhishingFilter", "EnabledV9", 1, RegistryValueKind.DWord);
					num = 27;
				}
				if (num == 27)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 0, RegistryValueKind.DWord);
					num = 28;
				}
				if (num == 28)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", 1, RegistryValueKind.DWord);
					num = 29;
				}
				if (num == 30)
				{
					RegistryKey registryKey3;
					registryKey3.DeleteValue("SubmitSamplesConsent");
					num = 31;
				}
				RegistryKey registryKey4;
				if (num == 31)
				{
					registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet");
					num = 32;
				}
				if (num == 32)
				{
					registryKey4.DeleteValue("HideSystray");
					num = 33;
				}
				if (num == 33)
				{
					this.toolkit.DeleteValue("Disable_Windows_Defender");
					num = 34;
				}
				if (num == 29)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DontReportInfectionInformation", 0, RegistryValueKind.DWord);
					num = 30;
				}
				if (num == 25)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", 1, RegistryValueKind.DWord);
					num = 26;
				}
				if (num == 22)
				{
					registryKey2.SetValue("DisableOnAccessProtection", 0, RegistryValueKind.DWord);
					num = 23;
				}
				if (num == 18)
				{
					this.toolkit.SetValue("Disable_Windows_Defender", 1);
					num = 19;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", 0, RegistryValueKind.DWord);
					num = 15;
				}
				if (num == 11)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost", "EnableWebContentEvaluation", 0, RegistryValueKind.DWord);
					num = 12;
				}
				if (num == 7)
				{
					registryKey2.SetValue("DisableBehaviorMonitoring", 1, RegistryValueKind.DWord);
					num = 8;
				}
				if (num == 3)
				{
					RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender Security Center\\Systray");
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 34)
				{
					break;
				}
				continue;
				IL_60:
				if (num == 6)
				{
					registryKey.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
					num = 7;
				}
				if (num == 8)
				{
					registryKey2.SetValue("DisableOnAccessProtection", 1, RegistryValueKind.DWord);
					num = 9;
				}
				if (num == 9)
				{
					registryKey2.SetValue("DisableScanOnRealtimeEnable", 1, RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					registryKey2.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
					num = 11;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\CurrentVersion\\AppContainer\\Storage\\microsoft.microsoftedge_8wekyb3d8bbwe\\MicrosoftEdge\\PhishingFilter", "EnabledV9", 0, RegistryValueKind.DWord);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1, RegistryValueKind.DWord);
					num = 14;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", 2, RegistryValueKind.DWord);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DontReportInfectionInformation", 1, RegistryValueKind.DWord);
					num = 17;
				}
				if (num == 17)
				{
					RegistryKey registryKey3;
					registryKey3.SetValue("HideSystray", 1, RegistryValueKind.DWord);
					num = 18;
				}
				if (num == 19)
				{
					break;
				}
				if (num != 20)
				{
					goto IL_222;
				}
				IL_202:
				registryKey.SetValue("DisableAntiSpyware", 0, RegistryValueKind.DWord);
				num = 21;
				goto IL_222;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0005DEE0 File Offset: 0x0005C0E0
		private void inkspace_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.inkspace.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("AllowWindowsInkWorkspace", 1);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Inkspace", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Inkspace");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("AllowWindowsInkWorkspace");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0005E010 File Offset: 0x0005C210
		private void timeline_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.timeline.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("EnableActivityFeed", 0);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Timeline", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Timeline");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("EnableActivityFeed");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0005E140 File Offset: 0x0005C340
		private void winup_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\WindowsUpdate");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.winup.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("DoNotConnectToWindowsUpdateInternetLocations", 1, RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					registryKey.SetValue("WUServer", "localserver.localdomain.wsus", RegistryValueKind.String);
					num = 6;
				}
				if (num == 6)
				{
					registryKey.SetValue("WUStatusServer", "localserver.localdomain.wsus", RegistryValueKind.String);
					num = 7;
				}
				if (num == 8)
				{
					this.toolkit.SetValue("Disable_Windows_Update", 1);
					num = 9;
				}
				if (num != 9)
				{
					if (num == 10)
					{
						goto IL_176;
					}
					IL_187:
					if (num == 12)
					{
						registryKey.DeleteValue("WUStatusServer");
						num = 13;
					}
					if (num == 13)
					{
						registryKey.DeleteValue("UpdateServiceUrlAlternate");
						num = 14;
					}
					if (num == 14)
					{
						this.toolkit.DeleteValue("Disable_Windows_Update");
						num = 15;
					}
					if (num == 11)
					{
						registryKey.DeleteValue("WUServer");
						num = 12;
					}
					if (num == 7)
					{
						registryKey.SetValue("UpdateServiceUrlAlternate", "wsus.localdomain.localserver", RegistryValueKind.String);
						num = 8;
					}
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_176;
						}
						num = 4;
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
					IL_176:
					registryKey.DeleteValue("DoNotConnectToWindowsUpdateInternetLocations");
					num = 11;
					goto IL_187;
				}
				break;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0005E344 File Offset: 0x0005C544
		private void photo_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows Photo Viewer\\Capabilities\\FileAssociations");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.photo.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue(".bmp", "PhotoViewer.FileAssoc.Tiff");
					num = 5;
				}
				if (num == 5)
				{
					registryKey.SetValue(".dib", "PhotoViewer.FileAssoc.Tiff");
					num = 6;
				}
				if (num == 6)
				{
					registryKey.SetValue(".gif", "PhotoViewer.FileAssoc.Tiff");
					num = 7;
				}
				if (num == 8)
				{
					registryKey.SetValue(".jpe", "PhotoViewer.FileAssoc.Tiff");
					num = 9;
				}
				if (num == 9)
				{
					registryKey.SetValue(".jpeg", "PhotoViewer.FileAssoc.Tiff");
					num = 10;
				}
				if (num == 10)
				{
					registryKey.SetValue(".jpg", "PhotoViewer.FileAssoc.Tiff");
					num = 11;
				}
				if (num == 12)
				{
					registryKey.SetValue(".png", "PhotoViewer.FileAssoc.Tiff");
					num = 13;
				}
				if (num == 13)
				{
					this.toolkit.SetValue("Enable_Classic", 1);
					num = 14;
				}
				if (num == 15)
				{
					goto IL_284;
				}
				IL_295:
				if (num == 16)
				{
					registryKey.DeleteValue(".dib");
					num = 17;
				}
				if (num == 17)
				{
					registryKey.DeleteValue(".gif");
					num = 18;
				}
				if (num == 19)
				{
					registryKey.DeleteValue(".jpe");
					num = 20;
				}
				if (num == 20)
				{
					registryKey.DeleteValue(".jpeg");
					num = 21;
				}
				if (num == 21)
				{
					registryKey.DeleteValue(".jpg");
					num = 22;
				}
				if (num == 23)
				{
					registryKey.DeleteValue(".png");
					num = 24;
				}
				if (num == 24)
				{
					this.toolkit.DeleteValue("Enable_Classic");
					num = 25;
				}
				if (num == 22)
				{
					registryKey.DeleteValue(".jxr");
					num = 23;
				}
				if (num == 18)
				{
					registryKey.DeleteValue(".jfif");
					num = 19;
				}
				if (num == 14)
				{
					break;
				}
				if (num == 11)
				{
					registryKey.SetValue(".jxr", "PhotoViewer.FileAssoc.Tiff");
					num = 12;
				}
				if (num == 7)
				{
					registryKey.SetValue(".jfif", "PhotoViewer.FileAssoc.Tiff");
					num = 8;
				}
				if (num == 3)
				{
					if (!@checked)
					{
						goto IL_284;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 25)
				{
					break;
				}
				continue;
				IL_284:
				registryKey.DeleteValue(".bmp");
				num = 16;
				goto IL_295;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0005E654 File Offset: 0x0005C854
		private void admin_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.admin.Checked;
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
				goto IL_D2;
				IL_DF:
				ProcessStartInfo processStartInfo;
				if (num == 13)
				{
					processStartInfo = new ProcessStartInfo();
					num = 14;
				}
				if (num == 15)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 16;
				}
				if (num == 16)
				{
					processStartInfo.Arguments = "/C cmd.exe net user administrator /active:no";
					num = 17;
				}
				Process process;
				if (num == 17)
				{
					process.StartInfo = processStartInfo;
					num = 18;
				}
				if (num == 19)
				{
					this.toolkit.DeleteValue("Enable_AdminAcc");
					num = 20;
				}
				if (num == 18)
				{
					process.Start();
					num = 19;
				}
				if (num == 14)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 15;
				}
				if (num == 11)
				{
					break;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 7)
				{
					processStartInfo2.Arguments = "/C cmd.exe net user administrator /active:yes";
					num = 8;
				}
				Process process2;
				if (num == 3)
				{
					process2 = new Process();
					num = 4;
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
				IL_21:
				if (num == 4)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 5;
				}
				if (num == 5)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 6;
				}
				if (num == 6)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 7;
				}
				if (num == 8)
				{
					process2.StartInfo = processStartInfo2;
					num = 9;
				}
				if (num == 9)
				{
					process2.Start();
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.SetValue("Enable_AdminAcc", 1);
					num = 11;
				}
				if (num != 12)
				{
					goto IL_DF;
				}
				IL_D2:
				process = new Process();
				num = 13;
				goto IL_DF;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0005E880 File Offset: 0x0005CA80
		private void uac_admin_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.uac_admin.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Enable_AdminUAC");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "ValidateAdminCodeSignatures", 1, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Enable_AdminUAC", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "ValidateAdminCodeSignatures", 0, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0005E9A8 File Offset: 0x0005CBA8
		private void hpet_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.hpet.Checked;
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
				goto IL_D2;
				IL_DF:
				ProcessStartInfo processStartInfo;
				if (num == 13)
				{
					processStartInfo = new ProcessStartInfo();
					num = 14;
				}
				if (num == 15)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 16;
				}
				if (num == 16)
				{
					processStartInfo.Arguments = "/C cmd.exe bcdedit /set useplatformclock true";
					num = 17;
				}
				Process process;
				if (num == 17)
				{
					process.StartInfo = processStartInfo;
					num = 18;
				}
				if (num == 19)
				{
					this.toolkit.DeleteValue("Disable_HPET");
					num = 20;
				}
				if (num == 18)
				{
					process.Start();
					num = 19;
				}
				if (num == 14)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					num = 15;
				}
				if (num == 11)
				{
					break;
				}
				ProcessStartInfo processStartInfo2;
				if (num == 7)
				{
					processStartInfo2.Arguments = "/C cmd.exe bcdedit /deletevalue useplatformclock";
					num = 8;
				}
				Process process2;
				if (num == 3)
				{
					process2 = new Process();
					num = 4;
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
				IL_21:
				if (num == 4)
				{
					processStartInfo2 = new ProcessStartInfo();
					num = 5;
				}
				if (num == 5)
				{
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					num = 6;
				}
				if (num == 6)
				{
					processStartInfo2.FileName = "cmd.exe";
					num = 7;
				}
				if (num == 8)
				{
					process2.StartInfo = processStartInfo2;
					num = 9;
				}
				if (num == 9)
				{
					process2.Start();
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.SetValue("Disable_HPET", 1);
					num = 11;
				}
				if (num != 12)
				{
					goto IL_DF;
				}
				IL_D2:
				process = new Process();
				num = 13;
				goto IL_DF;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0005EBD4 File Offset: 0x0005CDD4
		private void power_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.power.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Power_Throttling", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Power_Throttling");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_C8:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.DeleteValue("PowerThrottlingOff");
					num = 8;
					goto IL_C8;
				}
				break;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0005ED04 File Offset: 0x0005CF04
		private void sysmain_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.sysmain.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					registryKey.SetValue("EnableSuperfetch", "0", RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					this.toolkit.SetValue("Disable_Symain", 1);
					num = 7;
				}
				if (num == 8)
				{
					goto IL_EB;
				}
				IL_FC:
				if (num == 9)
				{
					registryKey.DeleteValue("EnableSuperfetch");
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.DeleteValue("Disable_Symain");
					num = 11;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 3)
				{
					if (!@checked)
					{
						goto IL_EB;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_EB:
				registryKey.DeleteValue("EnablePrefetcher");
				num = 9;
				goto IL_FC;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0005EE78 File Offset: 0x0005D078
		private void boot_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.boot.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("EnableBoottrace", "0", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_Boot_Tracing", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_Boot_Tracing");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_D2:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.SetValue("EnableBoottrace", "1", RegistryValueKind.DWord);
					num = 8;
					goto IL_D2;
				}
				break;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0005EFB0 File Offset: 0x0005D1B0
		private void mmcss_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.mmcss.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_62;
				IL_86:
				if (num == 7)
				{
					this.toolkit.DeleteValue("Disable_mmcss");
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MMCSS", "Start", 4, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 4)
				{
					this.toolkit.SetValue("Disable_mmcss", 1);
					num = 5;
				}
				if (num == 5)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_86;
				}
				IL_62:
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MMCSS", "Start", 3, RegistryValueKind.DWord);
				num = 7;
				goto IL_86;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
		private void spectre_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.spectre.Checked;
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
				goto IL_A7;
				IL_C0:
				if (num == 7)
				{
					this.toolkit.SetValue("Disable_Spectre_Meltdown", 1);
					num = 8;
				}
				RegistryKey registryKey;
				if (num == 3)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
					num = 4;
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
				IL_21:
				if (num == 4)
				{
					registryKey.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					registryKey.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					registryKey.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
					num = 7;
				}
				if (num == 8)
				{
					break;
				}
				if (num != 9)
				{
					goto IL_C0;
				}
				IL_A7:
				this.toolkit.DeleteValue("Disable_Spectre_Meltdown");
				num = 10;
				goto IL_C0;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0005F23C File Offset: 0x0005D43C
		private void large_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.large.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("DisablePagingExecutive", "1", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					registryKey.SetValue("LargeSystemCache", "1", RegistryValueKind.DWord);
					num = 6;
				}
				if (num == 6)
				{
					this.toolkit.SetValue("Disable_LargeSystemCache", 1);
					num = 7;
				}
				if (num == 8)
				{
					goto IL_EB;
				}
				IL_FC:
				if (num == 9)
				{
					registryKey.SetValue("LargeSystemCache", "0", RegistryValueKind.DWord);
					num = 10;
				}
				if (num == 10)
				{
					this.toolkit.DeleteValue("Disable_LargeSystemCache");
					num = 11;
				}
				if (num == 7)
				{
					break;
				}
				if (num == 3)
				{
					if (!@checked)
					{
						goto IL_EB;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					break;
				}
				continue;
				IL_EB:
				registryKey.DeleteValue("DisablePagingExecutive");
				num = 9;
				goto IL_FC;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0005F3BC File Offset: 0x0005D5BC
		private void FTH_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\FTH", true);
					num = 2;
				}
				bool @checked;
				if (num == 2)
				{
					@checked = this.FTH.Checked;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.SetValue("Enabled", "0", RegistryValueKind.DWord);
					num = 5;
				}
				if (num == 5)
				{
					this.toolkit.SetValue("Disable_FTH", 1);
					num = 6;
				}
				if (num != 6)
				{
					if (num == 8)
					{
						this.toolkit.DeleteValue("Disable_FTH");
						num = 9;
					}
					if (num == 7)
					{
						goto IL_B7;
					}
					IL_D2:
					if (num == 3)
					{
						if (!@checked)
						{
							goto IL_B7;
						}
						num = 4;
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
					IL_B7:
					registryKey.SetValue("Enabled", "1", RegistryValueKind.DWord);
					num = 8;
					goto IL_D2;
				}
				break;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		private void sticky_keys_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.sticky_keys.Checked;
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
				goto IL_1F9;
				IL_218:
				if (num == 7)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\Keyboard Response", "Flags", "122", RegistryValueKind.String);
					num = 8;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\StickyKeys", "Flags", "506", RegistryValueKind.String);
					num = 4;
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
				IL_21:
				if (num == 4)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\Keyboard Response", "Flags", "122", RegistryValueKind.String);
					num = 5;
				}
				if (num == 5)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\ToggleKeys", "Flags", "58", RegistryValueKind.String);
					num = 6;
				}
				if (num == 6)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\StickyKeys", "Flags", "506", RegistryValueKind.String);
					num = 7;
				}
				if (num == 8)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\ToggleKeys", "Flags", "58", RegistryValueKind.String);
					num = 9;
				}
				if (num == 9)
				{
					this.toolkit.SetValue("Disable_Sticky_keys", 1);
					num = 10;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 12)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\Keyboard Response", "Flags", "126", RegistryValueKind.String);
					num = 13;
				}
				if (num == 13)
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\ToggleKeys", "Flags", "62", RegistryValueKind.String);
					num = 14;
				}
				if (num == 15)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\Keyboard Response", "Flags", "126", RegistryValueKind.String);
					num = 16;
				}
				if (num == 16)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\ToggleKeys", "Flags", "62", RegistryValueKind.String);
					num = 17;
				}
				if (num == 17)
				{
					this.toolkit.DeleteValue("Disable_Sticky_keys");
					num = 18;
				}
				if (num == 14)
				{
					Registry.SetValue("HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\StickyKeys", "Flags", "510", RegistryValueKind.String);
					num = 15;
				}
				if (num != 11)
				{
					goto IL_218;
				}
				IL_1F9:
				Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Accessibility\\StickyKeys", "Flags", "510", RegistryValueKind.String);
				num = 12;
				goto IL_218;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
		private void ntfs_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.ntfs.Checked;
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
				goto IL_E8;
				IL_F8:
				if (num == 7)
				{
					break;
				}
				if (num == 3)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Optimizations");
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 13)
				{
					break;
				}
				continue;
				IL_21:
				object value;
				if (num == 4)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("NTFS_Timestamp");
					num = 5;
				}
				bool flag;
				if (num == 5)
				{
					flag = value != null;
					num = 6;
				}
				if (num != 6)
				{
					goto IL_67;
				}
				if (flag)
				{
					num = 7;
					goto IL_67;
				}
				goto IL_71;
				IL_81:
				if (num == 9)
				{
					this.toolkit.SetValue("NTFS_Timestamp", 1);
					num = 10;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 12)
				{
					this.toolkit.DeleteValue("NTFS_Timestamp");
					num = 13;
				}
				if (num == 11)
				{
					goto IL_E8;
				}
				goto IL_F8;
				IL_67:
				if (num != 8)
				{
					goto IL_81;
				}
				IL_71:
				Utils.RunCommand("fsutil behavior set disablelastaccess 1");
				num = 9;
				goto IL_81;
				IL_E8:
				Utils.RunCommand("fsutil behavior set disablelastaccess 2");
				num = 12;
				goto IL_F8;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0005F928 File Offset: 0x0005DB28
		private void win11_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.panel1.Controls.Add(Windows11.Instance);
					num = 2;
				}
				if (num == 2)
				{
					Windows11.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 4)
				{
					this.panel1.AutoScroll = false;
					num = 5;
				}
				if (num == 5)
				{
					this.panel1.Size = new Size(977, 585);
					num = 6;
				}
				if (num == 6)
				{
					this.win11_img.Location = new Point(23, 14);
					num = 7;
				}
				if (num == 8)
				{
					this.label2.Location = new Point(85, 52);
					num = 9;
				}
				if (num == 9)
				{
					this.label1.Location = new Point(1061, 101);
					num = 10;
				}
				if (num == 10)
				{
					this.label9.Location = new Point(1066, 154);
					num = 11;
				}
				if (num == 12)
				{
					this.back_btn.Location = new Point(876, 53);
					num = 13;
				}
				if (num == 11)
				{
					this.win11.Location = new Point(1059, 101);
					num = 12;
				}
				if (num == 7)
				{
					this.lbl1.Location = new Point(82, 14);
					num = 8;
				}
				if (num == 3)
				{
					Windows11.Instance.BringToFront();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 13);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0005FB50 File Offset: 0x0005DD50
		private void back_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.panel1.Controls.Remove(Windows11.Instance);
					num = 2;
				}
				if (num == 2)
				{
					this.panel1.AutoScroll = true;
					num = 3;
				}
				if (num == 4)
				{
					this.back_btn.Location = new Point(1059, 101);
					num = 5;
				}
				if (num == 5)
				{
					this.win11.Location = new Point(790, 33);
					num = 6;
				}
				if (num == 6)
				{
					this.win11_img.Location = new Point(1059, 27);
					num = 7;
				}
				if (num == 8)
				{
					this.lbl1.Location = new Point(1118, 34);
					num = 9;
				}
				if (num == 9)
				{
					this.label1.Location = new Point(18, 0);
					num = 10;
				}
				if (num == 10)
				{
					this.label9.Location = new Point(23, 53);
					num = 11;
				}
				if (num == 11)
				{
					this.win11.Location = new Point(790, 33);
					num = 12;
				}
				if (num == 7)
				{
					this.label2.Location = new Point(1121, 65);
					num = 8;
				}
				if (num == 3)
				{
					this.panel1.Size = new Size(977, 561);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0005FD6C File Offset: 0x0005DF6C
		private void PopulateTreeView()
		{
			int num = 0;
			IEnumerator<TreeData<string>> enumerator;
			do
			{
				if (num == 1)
				{
					this.settings_tw.Nodes.Clear();
					num = 2;
				}
				SettingsPage settingsPage;
				if (num == 2)
				{
					settingsPage = new SettingsPage();
					num = 3;
				}
				if (num == 4)
				{
					TreeData<string> uricommandList;
					enumerator = uricommandList.Children.GetEnumerator();
					num = 5;
				}
				if (num == 3)
				{
					TreeData<string> uricommandList = settingsPage.GetURICommandList();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			try
			{
				while (enumerator.MoveNext())
				{
					TreeData<string> treeData = enumerator.Current;
					TreeNode treeNode = new TreeNode(treeData.Data);
					treeNode.Name = treeData.Name;
					this.settings_tw.Nodes.Add(treeNode);
					this.ChildNodesFromTreeData(treeData, treeNode);
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

		// Token: 0x06000196 RID: 406 RVA: 0x0005FED4 File Offset: 0x0005E0D4
		private void ChildNodesFromTreeData(TreeData<string> item, TreeNode ParentNode)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (!item.HasChildren)
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
			bool flag = item.Level < 1;
			goto IL_56;
			Block_4:
			flag = false;
			IL_56:
			if (flag)
			{
				foreach (TreeData<string> treeData in item.Children)
				{
					TreeNode treeNode = new TreeNode(treeData.Data);
					treeNode.Name = treeData.Name;
					ParentNode.Nodes.Add(treeNode);
					this.ChildNodesFromTreeData(treeData, treeNode);
				}
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0005FFAC File Offset: 0x0005E1AC
		private void ShowHidePages()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (this.hide_sel.Checked)
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
			string text = "showonly:";
			goto IL_50;
			Block_4:
			text = "hide:";
			IL_50:
			string text2 = text;
			List<TreeNode> checkedNodes = this.GetCheckedNodes();
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(this.Settings_Page);
			if (registryKey != null)
			{
				if (checkedNodes.Count == 0)
				{
					registryKey.DeleteValue("SettingsPageVisibility", false);
				}
				else
				{
					foreach (TreeNode treeNode in checkedNodes)
					{
						string text3 = treeNode.Name.Substring(treeNode.Name.IndexOf(":") + 1);
						text2 = text2 + text3 + ";";
					}
					registryKey.SetValue("SettingsPageVisibility", text2, RegistryValueKind.String);
				}
				registryKey.Close();
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000600DC File Offset: 0x0005E2DC
		private string GetRegistryPolicyValue()
		{
			int num = 0;
			string text2;
			for (;;)
			{
				string text;
				if (num == 1)
				{
					text = "";
					num = 2;
				}
				RegistryKey registryKey;
				if (num == 2)
				{
					registryKey = Registry.LocalMachine.OpenSubKey(this.Settings_Page);
					num = 3;
				}
				if (num != 4)
				{
					goto IL_57;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_57;
				}
				goto IL_C5;
				IL_D6:
				if (num == 3)
				{
					flag = registryKey != null;
					num = 4;
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
				IL_57:
				if (num == 5)
				{
					text = registryKey.GetValue("SettingsPageVisibility", "").ToString();
					num = 6;
				}
				if (num == 6)
				{
					registryKey.Close();
					num = 7;
				}
				if (num == 8)
				{
					break;
				}
				if (num != 7)
				{
					goto IL_D6;
				}
				IL_C5:
				text2 = text;
				num = 8;
				goto IL_D6;
			}
			return text2;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00060234 File Offset: 0x0005E434
		public void ReadSettings()
		{
			int num = 0;
			for (;;)
			{
				if (num == 1)
				{
					this.PopulateTreeView();
					num = 2;
				}
				string text;
				if (num == 2)
				{
					text = this.GetRegistryPolicyValue();
					num = 3;
				}
				if (num != 4)
				{
					goto IL_3B;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_3B;
				}
				goto IL_284;
				IL_356:
				bool flag2;
				if (num == 18)
				{
					flag2 = true;
					num = 19;
				}
				bool flag3;
				if (num == 14)
				{
					if (!flag3)
					{
						goto IL_37A;
					}
					num = 15;
				}
				if (num == 11)
				{
					num = 12;
				}
				bool flag4;
				if (num == 7)
				{
					flag4 = text.StartsWith("hide:");
					num = 8;
				}
				if (num == 3)
				{
					flag = text.Length > 0;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 41)
				{
					break;
				}
				continue;
				IL_332:
				string[] array;
				if (num == 25)
				{
					string[] array2;
					array = array2;
					num = 26;
				}
				if (num == 22)
				{
					goto IL_350;
				}
				goto IL_356;
				IL_2F2:
				if (num == 33)
				{
					bool flag5;
					if (!flag5)
					{
						goto IL_26A;
					}
					num = 34;
				}
				if (num == 29)
				{
					goto IL_325;
				}
				goto IL_332;
				IL_295:
				bool firstTimeExpand;
				if (num == 38)
				{
					if (!firstTimeExpand)
					{
						break;
					}
					num = 39;
				}
				if (num == 39)
				{
					this.settings_tw.ExpandAll();
					num = 40;
				}
				if (num == 40)
				{
					this.FirstTimeExpand = false;
					num = 41;
				}
				if (num != 36)
				{
					goto IL_2F2;
				}
				goto IL_305;
				IL_27A:
				if (num == 37)
				{
					goto IL_284;
				}
				goto IL_295;
				IL_397:
				bool flag6;
				if (num == 20)
				{
					if (!flag6)
					{
						goto IL_350;
					}
					num = 21;
				}
				if (num == 21)
				{
					break;
				}
				string[] array3;
				if (num == 23)
				{
					array3 = new string[] { ";" };
					num = 24;
				}
				if (num == 24)
				{
					string[] array2 = text.Split(array3, StringSplitOptions.RemoveEmptyEntries);
					num = 25;
				}
				if (num == 26)
				{
					num = 27;
				}
				int num2;
				if (num == 27)
				{
					num2 = 0;
					num = 28;
				}
				if (num == 28)
				{
					goto IL_305;
				}
				string text3;
				string text2;
				if (num == 30)
				{
					text2 = "ms-settings:" + text3;
					num = 31;
				}
				TreeNode[] array4;
				if (num == 31)
				{
					array4 = this.settings_tw.Nodes.Find(text2, true);
					num = 32;
				}
				if (num == 32)
				{
					bool flag5 = array4.Length != 0;
					num = 33;
				}
				if (num == 34)
				{
					array4[0].Checked = array4.Length == 1;
					num = 35;
				}
				if (num == 35)
				{
					goto IL_26A;
				}
				goto IL_27A;
				IL_3B:
				if (num == 5)
				{
					num = 6;
				}
				if (num == 6)
				{
					flag2 = false;
					num = 7;
				}
				if (num != 8)
				{
					goto IL_75;
				}
				if (flag4)
				{
					num = 9;
					goto IL_75;
				}
				goto IL_D4;
				IL_E7:
				if (num == 15)
				{
					this.show_sel.Checked = true;
					num = 16;
				}
				if (num == 16)
				{
					text = text.Substring(9);
					num = 17;
				}
				if (num == 17)
				{
					num = 18;
				}
				if (num == 19)
				{
					goto IL_37A;
				}
				goto IL_397;
				IL_75:
				if (num == 9)
				{
					this.hide_sel.Checked = true;
					num = 10;
				}
				if (num == 10)
				{
					text = text.Substring(5);
					num = 11;
				}
				if (num == 12)
				{
					flag2 = true;
					num = 13;
				}
				if (num != 13)
				{
					goto IL_E7;
				}
				IL_D4:
				flag3 = text.StartsWith("showonly:");
				num = 14;
				goto IL_E7;
				IL_350:
				num = 23;
				goto IL_356;
				IL_325:
				text3 = array[num2];
				num = 30;
				goto IL_332;
				IL_305:
				if (num2 >= array.Length)
				{
					num = 37;
					goto IL_2F2;
				}
				goto IL_325;
				IL_284:
				firstTimeExpand = this.FirstTimeExpand;
				num = 38;
				goto IL_295;
				IL_26A:
				num2++;
				num = 36;
				goto IL_27A;
				IL_37A:
				flag6 = !flag2;
				num = 20;
				goto IL_397;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0006067C File Offset: 0x0005E87C
		public List<TreeNode> GetCheckedNodes()
		{
			int num = 0;
			List<TreeNode> list2;
			do
			{
				List<TreeNode> list;
				if (num == 1)
				{
					list = new List<TreeNode>();
					num = 2;
				}
				if (num == 2)
				{
					this.FindChecked(this.settings_tw.Nodes, list);
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 3)
				{
					list2 = list;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			return list2;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00060744 File Offset: 0x0005E944
		private void FindChecked(TreeNodeCollection nodes, List<TreeNode> list)
		{
			int num = 0;
			IEnumerator enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = nodes.GetEnumerator();
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
					object obj = enumerator.Current;
					TreeNode treeNode = (TreeNode)obj;
					if (treeNode.Checked)
					{
						list.Add(treeNode);
					}
					this.FindChecked(treeNode.Nodes, list);
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
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000607F8 File Offset: 0x0005E9F8
		private void settings_tw_AfterCheck(object sender, TreeViewEventArgs e)
		{
			int num = 0;
			TreeNode node;
			IEnumerator enumerator;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = e.Action > TreeViewAction.Unknown;
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						return;
					}
					num = 3;
				}
				if (num == 4)
				{
					enumerator = node.Nodes.GetEnumerator();
					num = 5;
				}
				if (num == 3)
				{
					node = e.Node;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					TreeNode treeNode = (TreeNode)obj;
					treeNode.Checked = node.Checked;
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
			this.ShowHidePages();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000608F0 File Offset: 0x0005EAF0
		private void show_sel_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.ShowHidePages();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0006094C File Offset: 0x0005EB4C
		private void revert_settings_pg_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.LocalMachine.CreateSubKey(this.Settings_Page);
					num = 2;
				}
				bool flag;
				if (num == 2)
				{
					flag = registryKey != null;
					num = 3;
				}
				if (num == 4)
				{
					registryKey.DeleteValue("SettingsPageVisibility", false);
					num = 5;
				}
				if (num == 5)
				{
					registryKey.Close();
					num = 6;
				}
				if (num == 6)
				{
					goto IL_61;
				}
				IL_70:
				if (num == 3)
				{
					if (!flag)
					{
						goto IL_61;
					}
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 7)
				{
					continue;
				}
				break;
				IL_61:
				this.ReadSettings();
				num = 7;
				goto IL_70;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00060A24 File Offset: 0x0005EC24
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

		// Token: 0x060001A0 RID: 416 RVA: 0x00060A9C File Offset: 0x0005EC9C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				ComponentResourceManager componentResourceManager;
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Tweaks));
					num = 2;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 4)
				{
					this.panel1 = new Panel();
					num = 5;
				}
				if (num == 5)
				{
					this.revert_settings_pg = new SiticoneRoundedButton();
					num = 6;
				}
				if (num == 6)
				{
					this.label4 = new Label();
					num = 7;
				}
				if (num == 8)
				{
					this.hide_sel = new SiticoneRadioButton();
					num = 9;
				}
				if (num == 9)
				{
					this.show_sel = new SiticoneRadioButton();
					num = 10;
				}
				if (num == 10)
				{
					this.settings_tw = new TreeView();
					num = 11;
				}
				if (num == 12)
				{
					this.sticky_keys = new SiticoneCheckBox();
					num = 13;
				}
				if (num == 13)
				{
					this.FTH = new SiticoneCheckBox();
					num = 14;
				}
				if (num == 15)
				{
					this.uac = new SiticoneCheckBox();
					num = 16;
				}
				if (num == 16)
				{
					this.boot = new SiticoneCheckBox();
					num = 17;
				}
				if (num == 17)
				{
					this.spectre = new SiticoneCheckBox();
					num = 18;
				}
				if (num == 19)
				{
					this.large = new SiticoneCheckBox();
					num = 20;
				}
				if (num == 20)
				{
					this.admin = new SiticoneCheckBox();
					num = 21;
				}
				if (num == 21)
				{
					this.inkspace = new SiticoneCheckBox();
					num = 22;
				}
				if (num == 23)
				{
					this.prt_spool = new SiticoneCheckBox();
					num = 24;
				}
				if (num == 24)
				{
					this.windef = new SiticoneCheckBox();
					num = 25;
				}
				if (num == 26)
				{
					this.winup = new SiticoneCheckBox();
					num = 27;
				}
				if (num == 27)
				{
					this.sysmain = new SiticoneCheckBox();
					num = 28;
				}
				if (num == 28)
				{
					this.timeline = new SiticoneCheckBox();
					num = 29;
				}
				if (num == 30)
				{
					this.lookup = new SiticoneCheckBox();
					num = 31;
				}
				if (num == 31)
				{
					this.storeup = new SiticoneCheckBox();
					num = 32;
				}
				if (num == 32)
				{
					this.wallpaper = new SiticoneCheckBox();
					num = 33;
				}
				if (num == 34)
				{
					this.power = new SiticoneCheckBox();
					num = 35;
				}
				if (num == 35)
				{
					this.label14 = new Label();
					num = 36;
				}
				if (num == 37)
				{
					this.tele = new SiticoneCheckBox();
					num = 38;
				}
				if (num == 38)
				{
					this.label15 = new Label();
					num = 39;
				}
				if (num == 39)
				{
					this.sysres = new SiticoneCheckBox();
					num = 40;
				}
				if (num == 41)
				{
					this.action = new SiticoneCheckBox();
					num = 42;
				}
				if (num == 42)
				{
					this.hpet = new SiticoneCheckBox();
					num = 43;
				}
				if (num == 43)
				{
					this.automain = new SiticoneCheckBox();
					num = 44;
				}
				if (num == 45)
				{
					this.errror = new SiticoneCheckBox();
					num = 46;
				}
				if (num == 46)
				{
					this.cortana_bar = new SiticoneCheckBox();
					num = 47;
				}
				if (num == 48)
				{
					this.driver = new SiticoneCheckBox();
					num = 49;
				}
				if (num == 49)
				{
					this.fast_start = new SiticoneCheckBox();
					num = 50;
				}
				if (num == 50)
				{
					this.win11 = new SiticoneButton();
					num = 51;
				}
				if (num == 52)
				{
					this.win11_img = new PictureBox();
					num = 53;
				}
				if (num == 53)
				{
					this.back_btn = new SiticoneRoundedButton();
					num = 54;
				}
				if (num == 54)
				{
					this.label2 = new Label();
					num = 55;
				}
				if (num == 56)
				{
					this.panel1.SuspendLayout();
					num = 57;
				}
				if (num == 57)
				{
					((ISupportInitialize)this.win11_img).BeginInit();
					num = 58;
				}
				if (num == 58)
				{
					base.SuspendLayout();
					num = 59;
				}
				if (num == 60)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 61;
				}
				if (num == 61)
				{
					this.label1.ForeColor = Color.White;
					num = 62;
				}
				if (num == 63)
				{
					this.label1.Name = "label1";
					num = 64;
				}
				if (num == 64)
				{
					this.label1.Size = new Size(136, 53);
					num = 65;
				}
				if (num == 65)
				{
					this.label1.TabIndex = 1;
					num = 66;
				}
				if (num == 67)
				{
					this.label9.AutoSize = true;
					num = 68;
				}
				if (num == 68)
				{
					this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 69;
				}
				if (num == 69)
				{
					this.label9.ForeColor = Color.Silver;
					num = 70;
				}
				if (num == 71)
				{
					this.label9.Name = "label9";
					num = 72;
				}
				if (num == 72)
				{
					this.label9.Size = new Size(355, 19);
					num = 73;
				}
				if (num == 74)
				{
					this.label9.Text = "Enable/Disable Windows feature and configure hidden settings";
					num = 75;
				}
				if (num == 75)
				{
					this.panel1.AutoScroll = true;
					num = 76;
				}
				if (num == 76)
				{
					this.panel1.Controls.Add(this.revert_settings_pg);
					num = 77;
				}
				if (num == 78)
				{
					this.panel1.Controls.Add(this.label3);
					num = 79;
				}
				if (num == 79)
				{
					this.panel1.Controls.Add(this.hide_sel);
					num = 80;
				}
				if (num == 80)
				{
					this.panel1.Controls.Add(this.show_sel);
					num = 81;
				}
				if (num == 82)
				{
					this.panel1.Controls.Add(this.ntfs);
					num = 83;
				}
				if (num == 83)
				{
					this.panel1.Controls.Add(this.sticky_keys);
					num = 84;
				}
				if (num == 85)
				{
					this.panel1.Controls.Add(this.mrt);
					num = 86;
				}
				if (num == 86)
				{
					this.panel1.Controls.Add(this.uac);
					num = 87;
				}
				if (num == 87)
				{
					this.panel1.Controls.Add(this.boot);
					num = 88;
				}
				if (num == 89)
				{
					this.panel1.Controls.Add(this.uac_admin);
					num = 90;
				}
				if (num == 90)
				{
					this.panel1.Controls.Add(this.large);
					num = 91;
				}
				if (num == 91)
				{
					this.panel1.Controls.Add(this.admin);
					num = 92;
				}
				if (num == 93)
				{
					this.panel1.Controls.Add(this.photo);
					num = 94;
				}
				if (num == 94)
				{
					this.panel1.Controls.Add(this.prt_spool);
					num = 95;
				}
				if (num == 96)
				{
					this.panel1.Controls.Add(this.mmcss);
					num = 97;
				}
				if (num == 97)
				{
					this.panel1.Controls.Add(this.winup);
					num = 98;
				}
				if (num == 98)
				{
					this.panel1.Controls.Add(this.sysmain);
					num = 99;
				}
				if (num == 100)
				{
					this.panel1.Controls.Add(this.ads);
					num = 101;
				}
				if (num == 101)
				{
					this.panel1.Controls.Add(this.lookup);
					num = 102;
				}
				if (num == 102)
				{
					this.panel1.Controls.Add(this.storeup);
					num = 103;
				}
				if (num == 104)
				{
					this.panel1.Controls.Add(this.lockscr);
					num = 105;
				}
				if (num == 105)
				{
					this.panel1.Controls.Add(this.power);
					num = 106;
				}
				if (num == 106)
				{
					this.panel1.Controls.Add(this.label14);
					num = 107;
				}
				if (num == 108)
				{
					this.panel1.Controls.Add(this.tele);
					num = 109;
				}
				if (num == 109)
				{
					this.panel1.Controls.Add(this.label15);
					num = 110;
				}
				if (num == 111)
				{
					this.panel1.Controls.Add(this.hiber);
					num = 112;
				}
				if (num == 112)
				{
					this.panel1.Controls.Add(this.action);
					num = 113;
				}
				if (num == 113)
				{
					this.panel1.Controls.Add(this.hpet);
					num = 114;
				}
				if (num == 115)
				{
					this.panel1.Controls.Add(this.clipboard);
					num = 116;
				}
				if (num == 116)
				{
					this.panel1.Controls.Add(this.errror);
					num = 117;
				}
				if (num == 117)
				{
					this.panel1.Controls.Add(this.cortana_bar);
					num = 118;
				}
				if (num == 119)
				{
					this.panel1.Controls.Add(this.driver);
					num = 120;
				}
				if (num == 120)
				{
					this.panel1.Controls.Add(this.fast_start);
					num = 121;
				}
				if (num == 122)
				{
					this.panel1.Name = "panel1";
					num = 123;
				}
				if (num == 123)
				{
					this.panel1.Size = new Size(977, 561);
					num = 124;
				}
				if (num == 124)
				{
					this.panel1.TabIndex = 114;
					num = 125;
				}
				if (num == 126)
				{
					this.revert_settings_pg.BorderRadius = 14;
					num = 127;
				}
				if (num == 127)
				{
					this.revert_settings_pg.CheckedState.Parent = this.revert_settings_pg;
					num = 128;
				}
				if (num == 128)
				{
					this.revert_settings_pg.CustomImages.Parent = this.revert_settings_pg;
					num = 129;
				}
				if (num == 130)
				{
					this.revert_settings_pg.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 131;
				}
				if (num == 131)
				{
					this.revert_settings_pg.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 132;
				}
				if (num == 133)
				{
					this.revert_settings_pg.DisabledState.Parent = this.revert_settings_pg;
					num = 134;
				}
				if (num == 134)
				{
					this.revert_settings_pg.FillColor = Color.FromArgb(38, 38, 38);
					num = 135;
				}
				if (num == 135)
				{
					this.revert_settings_pg.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 136;
				}
				if (num == 137)
				{
					this.revert_settings_pg.HoverState.Parent = this.revert_settings_pg;
					num = 138;
				}
				if (num == 138)
				{
					this.revert_settings_pg.Location = new Point(484, 1299);
					num = 139;
				}
				if (num == 139)
				{
					this.revert_settings_pg.Name = "revert_settings_pg";
					num = 140;
				}
				if (num == 141)
				{
					this.revert_settings_pg.Size = new Size(136, 30);
					num = 142;
				}
				if (num == 142)
				{
					this.revert_settings_pg.TabIndex = 342;
					num = 143;
				}
				if (num == 144)
				{
					this.revert_settings_pg.Click += this.revert_settings_pg_Click;
					num = 145;
				}
				if (num == 145)
				{
					this.label4.AutoSize = true;
					num = 146;
				}
				if (num == 146)
				{
					this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 147;
				}
				if (num == 148)
				{
					this.label4.Location = new Point(17, 1118);
					num = 149;
				}
				if (num == 149)
				{
					this.label4.Name = "label4";
					num = 150;
				}
				if (num == 150)
				{
					this.label4.Size = new Size(461, 38);
					num = 151;
				}
				if (num == 152)
				{
					this.label4.Text = "Windows 10 allows hiding pages of the Settings App.\r\nCheck the pages you want to hide or show. (Might not work for Windows 11 Users)";
					num = 153;
				}
				if (num == 153)
				{
					this.label3.AutoSize = true;
					num = 154;
				}
				if (num == 154)
				{
					this.label3.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 155;
				}
				if (num == 156)
				{
					this.label3.Location = new Point(16, 1087);
					num = 157;
				}
				if (num == 157)
				{
					this.label3.Name = "label3";
					num = 158;
				}
				if (num == 159)
				{
					this.label3.TabIndex = 340;
					num = 160;
				}
				if (num == 160)
				{
					this.label3.Text = "Hide Pages from Settings App";
					num = 161;
				}
				if (num == 161)
				{
					this.hide_sel.AutoSize = true;
					num = 162;
				}
				if (num == 163)
				{
					this.hide_sel.CheckedState.BorderThickness = 0;
					num = 164;
				}
				if (num == 164)
				{
					this.hide_sel.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 165;
				}
				if (num == 165)
				{
					this.hide_sel.CheckedState.InnerColor = Color.White;
					num = 166;
				}
				if (num == 167)
				{
					this.hide_sel.Font = new Font("Josefin Sans", 12.75f);
					num = 168;
				}
				if (num == 168)
				{
					this.hide_sel.ForeColor = Color.White;
					num = 169;
				}
				if (num == 170)
				{
					this.hide_sel.Name = "hide_sel";
					num = 171;
				}
				if (num == 171)
				{
					this.hide_sel.Size = new Size(136, 31);
					num = 172;
				}
				if (num == 172)
				{
					this.hide_sel.TabIndex = 339;
					num = 173;
				}
				if (num == 174)
				{
					this.hide_sel.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 175;
				}
				if (num == 175)
				{
					this.hide_sel.UncheckedState.BorderThickness = 2;
					num = 176;
				}
				if (num == 176)
				{
					this.hide_sel.UncheckedState.FillColor = Color.Transparent;
					num = 177;
				}
				if (num == 178)
				{
					this.show_sel.AutoSize = true;
					num = 179;
				}
				if (num == 179)
				{
					this.show_sel.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 180;
				}
				if (num == 181)
				{
					this.show_sel.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 182;
				}
				if (num == 182)
				{
					this.show_sel.CheckedState.InnerColor = Color.White;
					num = 183;
				}
				if (num == 183)
				{
					this.show_sel.CheckedState.InnerOffset = -4;
					num = 184;
				}
				if (num == 185)
				{
					this.show_sel.ForeColor = Color.White;
					num = 186;
				}
				if (num == 186)
				{
					this.show_sel.Location = new Point(484, 1225);
					num = 187;
				}
				if (num == 187)
				{
					this.show_sel.Name = "show_sel";
					num = 188;
				}
				if (num == 189)
				{
					this.show_sel.TabIndex = 338;
					num = 190;
				}
				if (num == 190)
				{
					this.show_sel.Text = "Show Selected";
					num = 191;
				}
				if (num == 192)
				{
					this.show_sel.UncheckedState.BorderThickness = 2;
					num = 193;
				}
				if (num == 193)
				{
					this.show_sel.UncheckedState.FillColor = Color.Transparent;
					num = 194;
				}
				if (num == 194)
				{
					this.show_sel.UncheckedState.InnerColor = Color.Transparent;
					num = 195;
				}
				if (num == 196)
				{
					this.settings_tw.BackColor = Color.FromArgb(38, 38, 38);
					num = 197;
				}
				if (num == 197)
				{
					this.settings_tw.CheckBoxes = true;
					num = 198;
				}
				if (num == 198)
				{
					this.settings_tw.Font = new Font("Josefin Sans", 12.75f);
					num = 199;
				}
				if (num == 200)
				{
					this.settings_tw.LineColor = Color.White;
					num = 201;
				}
				if (num == 201)
				{
					this.settings_tw.Location = new Point(21, 1197);
					num = 202;
				}
				if (num == 202)
				{
					this.settings_tw.Name = "settings_tw";
					num = 203;
				}
				if (num == 204)
				{
					this.settings_tw.TabIndex = 337;
					num = 205;
				}
				if (num == 205)
				{
					this.settings_tw.AfterCheck += this.settings_tw_AfterCheck;
					num = 206;
				}
				if (num == 207)
				{
					this.ntfs.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 208;
				}
				if (num == 208)
				{
					this.ntfs.CheckedState.BorderRadius = 0;
					num = 209;
				}
				if (num == 209)
				{
					this.ntfs.CheckedState.BorderThickness = 0;
					num = 210;
				}
				if (num == 211)
				{
					this.ntfs.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 212;
				}
				if (num == 212)
				{
					this.ntfs.ForeColor = Color.White;
					num = 213;
				}
				if (num == 213)
				{
					this.ntfs.Location = new Point(484, 878);
					num = 214;
				}
				if (num == 215)
				{
					this.ntfs.Size = new Size(204, 28);
					num = 216;
				}
				if (num == 216)
				{
					this.ntfs.TabIndex = 130;
					num = 217;
				}
				if (num == 218)
				{
					this.ntfs.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 219;
				}
				if (num == 219)
				{
					this.ntfs.UncheckedState.BorderRadius = 0;
					num = 220;
				}
				if (num == 220)
				{
					this.ntfs.UncheckedState.BorderThickness = 0;
					num = 221;
				}
				if (num == 222)
				{
					this.ntfs.CheckedChanged += this.ntfs_CheckedChanged;
					num = 223;
				}
				if (num == 223)
				{
					this.sticky_keys.AutoSize = true;
					num = 224;
				}
				if (num == 224)
				{
					this.sticky_keys.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 225;
				}
				if (num == 226)
				{
					this.sticky_keys.CheckedState.BorderThickness = 0;
					num = 227;
				}
				if (num == 227)
				{
					this.sticky_keys.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 228;
				}
				if (num == 229)
				{
					this.sticky_keys.ForeColor = Color.White;
					num = 230;
				}
				if (num == 230)
				{
					this.sticky_keys.Location = new Point(484, 113);
					num = 231;
				}
				if (num == 231)
				{
					this.sticky_keys.Name = "sticky_keys";
					num = 232;
				}
				if (num == 233)
				{
					this.sticky_keys.TabIndex = 129;
					num = 234;
				}
				if (num == 234)
				{
					this.sticky_keys.Text = "Disable Sticky Keys";
					num = 235;
				}
				if (num == 235)
				{
					this.sticky_keys.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 236;
				}
				if (num == 237)
				{
					this.sticky_keys.UncheckedState.BorderThickness = 0;
					num = 238;
				}
				if (num == 238)
				{
					this.sticky_keys.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 239;
				}
				if (num == 240)
				{
					this.FTH.AutoSize = true;
					num = 241;
				}
				if (num == 241)
				{
					this.FTH.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 242;
				}
				if (num == 242)
				{
					this.FTH.CheckedState.BorderRadius = 0;
					num = 243;
				}
				if (num == 244)
				{
					this.FTH.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 245;
				}
				if (num == 245)
				{
					this.FTH.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 246;
				}
				if (num == 246)
				{
					this.FTH.ForeColor = Color.White;
					num = 247;
				}
				if (num == 248)
				{
					this.FTH.Name = "FTH";
					num = 249;
				}
				if (num == 249)
				{
					this.FTH.Size = new Size(222, 28);
					num = 250;
				}
				if (num == 250)
				{
					this.FTH.TabIndex = 127;
					num = 251;
				}
				if (num == 252)
				{
					this.FTH.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 253;
				}
				if (num == 253)
				{
					this.FTH.UncheckedState.BorderRadius = 0;
					num = 254;
				}
				if (num == 255)
				{
					this.FTH.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 256;
				}
				if (num == 256)
				{
					this.FTH.CheckedChanged += this.FTH_CheckedChanged;
					num = 257;
				}
				if (num == 257)
				{
					this.mrt.AutoSize = true;
					num = 258;
				}
				if (num == 259)
				{
					this.mrt.CheckedState.BorderRadius = 0;
					num = 260;
				}
				if (num == 260)
				{
					this.mrt.CheckedState.BorderThickness = 0;
					num = 261;
				}
				if (num == 261)
				{
					this.mrt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 262;
				}
				if (num == 263)
				{
					this.mrt.ForeColor = Color.White;
					num = 264;
				}
				if (num == 264)
				{
					this.mrt.Location = new Point(21, 713);
					num = 265;
				}
				if (num == 266)
				{
					this.mrt.Size = new Size(180, 28);
					num = 267;
				}
				if (num == 267)
				{
					this.mrt.TabIndex = 126;
					num = 268;
				}
				if (num == 268)
				{
					this.mrt.Text = "Disable MRT Updates";
					num = 269;
				}
				if (num == 270)
				{
					this.mrt.UncheckedState.BorderRadius = 0;
					num = 271;
				}
				if (num == 271)
				{
					this.mrt.UncheckedState.BorderThickness = 0;
					num = 272;
				}
				if (num == 272)
				{
					this.mrt.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 273;
				}
				if (num == 274)
				{
					this.uac.AutoSize = true;
					num = 275;
				}
				if (num == 275)
				{
					this.uac.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 276;
				}
				if (num == 277)
				{
					this.uac.CheckedState.BorderThickness = 0;
					num = 278;
				}
				if (num == 278)
				{
					this.uac.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 279;
				}
				if (num == 279)
				{
					this.uac.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 280;
				}
				if (num == 281)
				{
					this.uac.Location = new Point(484, 313);
					num = 282;
				}
				if (num == 282)
				{
					this.uac.Name = "uac";
					num = 283;
				}
				if (num == 283)
				{
					this.uac.Size = new Size(116, 28);
					num = 284;
				}
				if (num == 285)
				{
					this.uac.Text = "Disable UAC";
					num = 286;
				}
				if (num == 286)
				{
					this.uac.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 287;
				}
				if (num == 288)
				{
					this.uac.UncheckedState.BorderThickness = 0;
					num = 289;
				}
				if (num == 289)
				{
					this.uac.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 290;
				}
				if (num == 290)
				{
					this.uac.CheckedChanged += this.uac_CheckedChanged;
					num = 291;
				}
				if (num == 292)
				{
					this.boot.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 293;
				}
				if (num == 293)
				{
					this.boot.CheckedState.BorderRadius = 0;
					num = 294;
				}
				if (num == 294)
				{
					this.boot.CheckedState.BorderThickness = 0;
					num = 295;
				}
				if (num == 296)
				{
					this.boot.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 297;
				}
				if (num == 297)
				{
					this.boot.ForeColor = Color.White;
					num = 298;
				}
				if (num == 298)
				{
					this.boot.Location = new Point(21, 1019);
					num = 299;
				}
				if (num == 300)
				{
					this.boot.Size = new Size(171, 28);
					num = 301;
				}
				if (num == 301)
				{
					this.boot.TabIndex = 118;
					num = 302;
				}
				if (num == 303)
				{
					this.boot.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 304;
				}
				if (num == 304)
				{
					this.boot.UncheckedState.BorderRadius = 0;
					num = 305;
				}
				if (num == 305)
				{
					this.boot.UncheckedState.BorderThickness = 0;
					num = 306;
				}
				if (num == 307)
				{
					this.boot.CheckedChanged += this.boot_CheckedChanged;
					num = 308;
				}
				if (num == 308)
				{
					this.spectre.AutoSize = true;
					num = 309;
				}
				if (num == 309)
				{
					this.spectre.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 310;
				}
				if (num == 311)
				{
					this.spectre.CheckedState.BorderThickness = 0;
					num = 312;
				}
				if (num == 312)
				{
					this.spectre.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 313;
				}
				if (num == 314)
				{
					this.spectre.ForeColor = Color.White;
					num = 315;
				}
				if (num == 315)
				{
					this.spectre.Location = new Point(484, 925);
					num = 316;
				}
				if (num == 316)
				{
					this.spectre.Name = "spectre";
					num = 317;
				}
				if (num == 318)
				{
					this.spectre.TabIndex = 117;
					num = 319;
				}
				if (num == 319)
				{
					this.spectre.Text = "Disable Spectre and Meltdown";
					num = 320;
				}
				if (num == 320)
				{
					this.spectre.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 321;
				}
				if (num == 322)
				{
					this.spectre.UncheckedState.BorderThickness = 0;
					num = 323;
				}
				if (num == 323)
				{
					this.spectre.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 324;
				}
				if (num == 325)
				{
					this.uac_admin.AutoSize = true;
					num = 326;
				}
				if (num == 326)
				{
					this.uac_admin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 327;
				}
				if (num == 327)
				{
					this.uac_admin.CheckedState.BorderRadius = 0;
					num = 328;
				}
				if (num == 329)
				{
					this.uac_admin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 330;
				}
				if (num == 330)
				{
					this.uac_admin.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 331;
				}
				if (num == 331)
				{
					this.uac_admin.ForeColor = Color.White;
					num = 332;
				}
				if (num == 333)
				{
					this.uac_admin.Name = "uac_admin";
					num = 334;
				}
				if (num == 334)
				{
					this.uac_admin.Size = new Size(246, 28);
					num = 335;
				}
				if (num == 336)
				{
					this.uac_admin.Text = "Enable UAC for Admin Account";
					num = 337;
				}
				if (num == 337)
				{
					this.uac_admin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 338;
				}
				if (num == 338)
				{
					this.uac_admin.UncheckedState.BorderRadius = 0;
					num = 339;
				}
				if (num == 340)
				{
					this.uac_admin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 341;
				}
				if (num == 341)
				{
					this.uac_admin.CheckedChanged += this.uac_admin_CheckedChanged;
					num = 342;
				}
				if (num == 342)
				{
					this.large.AutoSize = true;
					num = 343;
				}
				if (num == 344)
				{
					this.large.CheckedState.BorderRadius = 0;
					num = 345;
				}
				if (num == 345)
				{
					this.large.CheckedState.BorderThickness = 0;
					num = 346;
				}
				if (num == 346)
				{
					this.large.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 347;
				}
				if (num == 348)
				{
					this.large.ForeColor = Color.White;
					num = 349;
				}
				if (num == 349)
				{
					this.large.Location = new Point(484, 972);
					num = 350;
				}
				if (num == 351)
				{
					this.large.Size = new Size(212, 28);
					num = 352;
				}
				if (num == 352)
				{
					this.large.TabIndex = 116;
					num = 353;
				}
				if (num == 353)
				{
					this.large.Text = "Enable LargeSystemCache";
					num = 354;
				}
				if (num == 355)
				{
					this.large.UncheckedState.BorderRadius = 0;
					num = 356;
				}
				if (num == 356)
				{
					this.large.UncheckedState.BorderThickness = 0;
					num = 357;
				}
				if (num == 357)
				{
					this.large.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 358;
				}
				if (num == 359)
				{
					this.admin.AutoSize = true;
					num = 360;
				}
				if (num == 360)
				{
					this.admin.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 361;
				}
				if (num == 362)
				{
					this.admin.CheckedState.BorderThickness = 0;
					num = 363;
				}
				if (num == 363)
				{
					this.admin.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 364;
				}
				if (num == 364)
				{
					this.admin.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 365;
				}
				if (num == 366)
				{
					this.admin.Location = new Point(484, 663);
					num = 367;
				}
				if (num == 367)
				{
					this.admin.Name = "admin";
					num = 368;
				}
				if (num == 368)
				{
					this.admin.Size = new Size(290, 28);
					num = 369;
				}
				if (num == 370)
				{
					this.admin.Text = "Enable Default Administrator Account";
					num = 371;
				}
				if (num == 371)
				{
					this.admin.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 372;
				}
				if (num == 373)
				{
					this.admin.UncheckedState.BorderThickness = 0;
					num = 374;
				}
				if (num == 374)
				{
					this.admin.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 375;
				}
				if (num == 375)
				{
					this.admin.CheckedChanged += this.admin_CheckedChanged;
					num = 376;
				}
				if (num == 377)
				{
					this.inkspace.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 378;
				}
				if (num == 378)
				{
					this.inkspace.CheckedState.BorderRadius = 0;
					num = 379;
				}
				if (num == 379)
				{
					this.inkspace.CheckedState.BorderThickness = 0;
					num = 380;
				}
				if (num == 381)
				{
					this.inkspace.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 382;
				}
				if (num == 382)
				{
					this.inkspace.ForeColor = Color.White;
					num = 383;
				}
				if (num == 384)
				{
					this.inkspace.Name = "inkspace";
					num = 385;
				}
				if (num == 385)
				{
					this.inkspace.Size = new Size(249, 28);
					num = 386;
				}
				if (num == 386)
				{
					this.inkspace.TabIndex = 2;
					num = 387;
				}
				if (num == 388)
				{
					this.inkspace.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 389;
				}
				if (num == 389)
				{
					this.inkspace.UncheckedState.BorderRadius = 0;
					num = 390;
				}
				if (num == 390)
				{
					this.inkspace.UncheckedState.BorderThickness = 0;
					num = 391;
				}
				if (num == 392)
				{
					this.inkspace.CheckedChanged += this.inkspace_CheckedChanged;
					num = 393;
				}
				if (num == 393)
				{
					this.photo.AutoSize = true;
					num = 394;
				}
				if (num == 394)
				{
					this.photo.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 395;
				}
				if (num == 396)
				{
					this.photo.CheckedState.BorderThickness = 0;
					num = 397;
				}
				if (num == 397)
				{
					this.photo.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 398;
				}
				if (num == 399)
				{
					this.photo.ForeColor = Color.White;
					num = 400;
				}
				if (num == 400)
				{
					this.photo.Location = new Point(484, 613);
					num = 401;
				}
				if (num == 401)
				{
					this.photo.Name = "photo";
					num = 402;
				}
				if (num == 403)
				{
					this.photo.TabIndex = 15;
					num = 404;
				}
				if (num == 404)
				{
					this.photo.Text = "Enable Classic Photo Viewer";
					num = 405;
				}
				if (num == 405)
				{
					this.photo.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 406;
				}
				if (num == 407)
				{
					this.photo.UncheckedState.BorderThickness = 0;
					num = 408;
				}
				if (num == 408)
				{
					this.photo.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 409;
				}
				if (num == 410)
				{
					this.prt_spool.AutoSize = true;
					num = 411;
				}
				if (num == 411)
				{
					this.prt_spool.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 412;
				}
				if (num == 412)
				{
					this.prt_spool.CheckedState.BorderRadius = 0;
					num = 413;
				}
				if (num == 414)
				{
					this.prt_spool.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 415;
				}
				if (num == 415)
				{
					this.prt_spool.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 416;
				}
				if (num == 416)
				{
					this.prt_spool.ForeColor = Color.White;
					num = 417;
				}
				if (num == 418)
				{
					this.prt_spool.Name = "prt_spool";
					num = 419;
				}
				if (num == 419)
				{
					this.prt_spool.Size = new Size(174, 28);
					num = 420;
				}
				if (num == 421)
				{
					this.prt_spool.Text = "Disable Print Spooler";
					num = 422;
				}
				if (num == 422)
				{
					this.prt_spool.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 423;
				}
				if (num == 423)
				{
					this.prt_spool.UncheckedState.BorderRadius = 0;
					num = 424;
				}
				if (num == 425)
				{
					this.prt_spool.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 426;
				}
				if (num == 426)
				{
					this.prt_spool.CheckedChanged += this.prt_spool_CheckedChanged;
					num = 427;
				}
				if (num == 427)
				{
					this.windef.AutoSize = true;
					num = 428;
				}
				if (num == 429)
				{
					this.windef.CheckedState.BorderRadius = 0;
					num = 430;
				}
				if (num == 430)
				{
					this.windef.CheckedState.BorderThickness = 0;
					num = 431;
				}
				if (num == 432)
				{
					this.windef.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 433;
				}
				if (num == 433)
				{
					this.windef.ForeColor = Color.White;
					num = 434;
				}
				if (num == 434)
				{
					this.windef.Location = new Point(484, 413);
					num = 435;
				}
				if (num == 436)
				{
					this.windef.Size = new Size(214, 28);
					num = 437;
				}
				if (num == 437)
				{
					this.windef.TabIndex = 5;
					num = 438;
				}
				if (num == 438)
				{
					this.windef.Text = "Disable Windows Defender";
					num = 439;
				}
				if (num == 440)
				{
					this.windef.UncheckedState.BorderRadius = 0;
					num = 441;
				}
				if (num == 441)
				{
					this.windef.UncheckedState.BorderThickness = 0;
					num = 442;
				}
				if (num == 442)
				{
					this.windef.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 443;
				}
				if (num == 444)
				{
					this.mmcss.AutoSize = true;
					num = 445;
				}
				if (num == 445)
				{
					this.mmcss.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 446;
				}
				if (num == 447)
				{
					this.mmcss.CheckedState.BorderThickness = 0;
					num = 448;
				}
				if (num == 448)
				{
					this.mmcss.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 449;
				}
				if (num == 449)
				{
					this.mmcss.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 450;
				}
				if (num == 451)
				{
					this.mmcss.Location = new Point(484, 831);
					num = 452;
				}
				if (num == 452)
				{
					this.mmcss.Name = "mmcss";
					num = 453;
				}
				if (num == 453)
				{
					this.mmcss.Size = new Size(141, 28);
					num = 454;
				}
				if (num == 455)
				{
					this.mmcss.Text = "Disable MMCSS";
					num = 456;
				}
				if (num == 456)
				{
					this.mmcss.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 457;
				}
				if (num == 458)
				{
					this.mmcss.UncheckedState.BorderThickness = 0;
					num = 459;
				}
				if (num == 459)
				{
					this.mmcss.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 460;
				}
				if (num == 460)
				{
					this.mmcss.CheckedChanged += this.mmcss_CheckedChanged;
					num = 461;
				}
				if (num == 462)
				{
					this.winup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 463;
				}
				if (num == 463)
				{
					this.winup.CheckedState.BorderRadius = 0;
					num = 464;
				}
				if (num == 464)
				{
					this.winup.CheckedState.BorderThickness = 0;
					num = 465;
				}
				if (num == 466)
				{
					this.winup.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 467;
				}
				if (num == 467)
				{
					this.winup.ForeColor = Color.White;
					num = 468;
				}
				if (num == 469)
				{
					this.winup.Name = "winup";
					num = 470;
				}
				if (num == 470)
				{
					this.winup.Size = new Size(207, 28);
					num = 471;
				}
				if (num == 471)
				{
					this.winup.TabIndex = 7;
					num = 472;
				}
				if (num == 473)
				{
					this.winup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 474;
				}
				if (num == 474)
				{
					this.winup.UncheckedState.BorderRadius = 0;
					num = 475;
				}
				if (num == 475)
				{
					this.winup.UncheckedState.BorderThickness = 0;
					num = 476;
				}
				if (num == 477)
				{
					this.winup.CheckedChanged += this.winup_CheckedChanged;
					num = 478;
				}
				if (num == 478)
				{
					this.sysmain.AutoSize = true;
					num = 479;
				}
				if (num == 480)
				{
					this.sysmain.CheckedState.BorderRadius = 0;
					num = 481;
				}
				if (num == 481)
				{
					this.sysmain.CheckedState.BorderThickness = 0;
					num = 482;
				}
				if (num == 482)
				{
					this.sysmain.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 483;
				}
				if (num == 484)
				{
					this.sysmain.ForeColor = Color.White;
					num = 485;
				}
				if (num == 485)
				{
					this.sysmain.Location = new Point(21, 972);
					num = 486;
				}
				if (num == 486)
				{
					this.sysmain.Name = "sysmain";
					num = 487;
				}
				if (num == 488)
				{
					this.sysmain.TabIndex = 111;
					num = 489;
				}
				if (num == 489)
				{
					this.sysmain.Text = "Disable Prefetch/Superfetch";
					num = 490;
				}
				if (num == 490)
				{
					this.sysmain.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 491;
				}
				if (num == 492)
				{
					this.sysmain.UncheckedState.BorderThickness = 0;
					num = 493;
				}
				if (num == 493)
				{
					this.sysmain.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 494;
				}
				if (num == 495)
				{
					this.timeline.AutoSize = true;
					num = 496;
				}
				if (num == 496)
				{
					this.timeline.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 497;
				}
				if (num == 497)
				{
					this.timeline.CheckedState.BorderRadius = 0;
					num = 498;
				}
				if (num == 499)
				{
					this.timeline.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 500;
				}
				if (num == 500)
				{
					this.timeline.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 501;
				}
				if (num == 501)
				{
					this.timeline.ForeColor = Color.White;
					num = 502;
				}
				if (num == 503)
				{
					this.timeline.Name = "timeline";
					num = 504;
				}
				if (num == 504)
				{
					this.timeline.Size = new Size(207, 28);
					num = 505;
				}
				if (num == 506)
				{
					this.timeline.Text = "Disable Windows Timeline";
					num = 507;
				}
				if (num == 507)
				{
					this.timeline.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 508;
				}
				if (num == 508)
				{
					this.timeline.UncheckedState.BorderRadius = 0;
					num = 509;
				}
				if (num == 510)
				{
					this.timeline.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 511;
				}
				if (num == 511)
				{
					this.timeline.CheckedChanged += this.timeline_CheckedChanged;
					num = 512;
				}
				if (num == 512)
				{
					this.ads.AutoSize = true;
					num = 513;
				}
				if (num == 514)
				{
					this.ads.CheckedState.BorderRadius = 0;
					num = 515;
				}
				if (num == 515)
				{
					this.ads.CheckedState.BorderThickness = 0;
					num = 516;
				}
				if (num == 517)
				{
					this.ads.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 518;
				}
				if (num == 518)
				{
					this.ads.ForeColor = Color.White;
					num = 519;
				}
				if (num == 519)
				{
					this.ads.Location = new Point(21, 113);
					num = 520;
				}
				if (num == 521)
				{
					this.ads.Size = new Size(255, 28);
					num = 522;
				}
				if (num == 522)
				{
					this.ads.TabIndex = 0;
					num = 523;
				}
				if (num == 523)
				{
					this.ads.Text = "Disable Ads and Unwanted Apps";
					num = 524;
				}
				if (num == 525)
				{
					this.ads.UncheckedState.BorderRadius = 0;
					num = 526;
				}
				if (num == 526)
				{
					this.ads.UncheckedState.BorderThickness = 0;
					num = 527;
				}
				if (num == 528)
				{
					this.ads.CheckedChanged += this.ads_CheckedChanged;
					num = 529;
				}
				if (num == 529)
				{
					this.lookup.AutoSize = true;
					num = 530;
				}
				if (num == 530)
				{
					this.lookup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 531;
				}
				if (num == 532)
				{
					this.lookup.CheckedState.BorderThickness = 0;
					num = 533;
				}
				if (num == 533)
				{
					this.lookup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 534;
				}
				if (num == 534)
				{
					this.lookup.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 535;
				}
				if (num == 536)
				{
					this.lookup.Location = new Point(21, 163);
					num = 537;
				}
				if (num == 537)
				{
					this.lookup.Name = "lookup";
					num = 538;
				}
				if (num == 538)
				{
					this.lookup.Size = new Size(234, 28);
					num = 539;
				}
				if (num == 540)
				{
					this.lookup.Text = "Disable App Look Up in Store";
					num = 541;
				}
				if (num == 541)
				{
					this.lookup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 542;
				}
				if (num == 543)
				{
					this.lookup.UncheckedState.BorderThickness = 0;
					num = 544;
				}
				if (num == 544)
				{
					this.lookup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 545;
				}
				if (num == 545)
				{
					this.lookup.CheckedChanged += this.lookup_CheckedChanged;
					num = 546;
				}
				if (num == 547)
				{
					this.storeup.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 548;
				}
				if (num == 548)
				{
					this.storeup.CheckedState.BorderRadius = 0;
					num = 549;
				}
				if (num == 549)
				{
					this.storeup.CheckedState.BorderThickness = 0;
					num = 550;
				}
				if (num == 551)
				{
					this.storeup.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 552;
				}
				if (num == 552)
				{
					this.storeup.ForeColor = Color.White;
					num = 553;
				}
				if (num == 554)
				{
					this.storeup.Name = "storeup";
					num = 555;
				}
				if (num == 555)
				{
					this.storeup.Size = new Size(254, 28);
					num = 556;
				}
				if (num == 556)
				{
					this.storeup.TabIndex = 4;
					num = 557;
				}
				if (num == 558)
				{
					this.storeup.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 559;
				}
				if (num == 559)
				{
					this.storeup.UncheckedState.BorderRadius = 0;
					num = 560;
				}
				if (num == 560)
				{
					this.storeup.UncheckedState.BorderThickness = 0;
					num = 561;
				}
				if (num == 562)
				{
					this.storeup.CheckedChanged += this.storeup_CheckedChanged;
					num = 563;
				}
				if (num == 563)
				{
					this.wallpaper.AutoSize = true;
					num = 564;
				}
				if (num == 565)
				{
					this.wallpaper.CheckedState.BorderRadius = 0;
					num = 566;
				}
				if (num == 566)
				{
					this.wallpaper.CheckedState.BorderThickness = 0;
					num = 567;
				}
				if (num == 567)
				{
					this.wallpaper.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 568;
				}
				if (num == 569)
				{
					this.wallpaper.ForeColor = Color.White;
					num = 570;
				}
				if (num == 570)
				{
					this.wallpaper.Location = new Point(484, 363);
					num = 571;
				}
				if (num == 571)
				{
					this.wallpaper.Name = "wallpaper";
					num = 572;
				}
				if (num == 573)
				{
					this.wallpaper.TabIndex = 16;
					num = 574;
				}
				if (num == 574)
				{
					this.wallpaper.Text = "Disable Wallpaper Quality Reduction";
					num = 575;
				}
				if (num == 576)
				{
					this.wallpaper.UncheckedState.BorderRadius = 0;
					num = 577;
				}
				if (num == 577)
				{
					this.wallpaper.UncheckedState.BorderThickness = 0;
					num = 578;
				}
				if (num == 578)
				{
					this.wallpaper.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 579;
				}
				if (num == 580)
				{
					this.lockscr.AutoSize = true;
					num = 581;
				}
				if (num == 581)
				{
					this.lockscr.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 582;
				}
				if (num == 582)
				{
					this.lockscr.CheckedState.BorderRadius = 0;
					num = 583;
				}
				if (num == 584)
				{
					this.lockscr.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 585;
				}
				if (num == 585)
				{
					this.lockscr.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 586;
				}
				if (num == 586)
				{
					this.lockscr.ForeColor = Color.White;
					num = 587;
				}
				if (num == 588)
				{
					this.lockscr.Name = "lockscr";
					num = 589;
				}
				if (num == 589)
				{
					this.lockscr.Size = new Size(167, 28);
					num = 590;
				}
				if (num == 591)
				{
					this.lockscr.Text = "Disable Lock Screen";
					num = 592;
				}
				if (num == 592)
				{
					this.lockscr.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 593;
				}
				if (num == 593)
				{
					this.lockscr.UncheckedState.BorderRadius = 0;
					num = 594;
				}
				if (num == 595)
				{
					this.lockscr.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 596;
				}
				if (num == 596)
				{
					this.lockscr.CheckedChanged += this.lockscr_CheckedChanged;
					num = 597;
				}
				if (num == 597)
				{
					this.power.AutoSize = true;
					num = 598;
				}
				if (num == 599)
				{
					this.power.CheckedState.BorderRadius = 0;
					num = 600;
				}
				if (num == 600)
				{
					this.power.CheckedState.BorderThickness = 0;
					num = 601;
				}
				if (num == 602)
				{
					this.power.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 603;
				}
				if (num == 603)
				{
					this.power.ForeColor = Color.White;
					num = 604;
				}
				if (num == 604)
				{
					this.power.Location = new Point(21, 925);
					num = 605;
				}
				if (num == 606)
				{
					this.power.Size = new Size(197, 28);
					num = 607;
				}
				if (num == 607)
				{
					this.power.TabIndex = 110;
					num = 608;
				}
				if (num == 608)
				{
					this.power.Text = "Disable Power Throttling";
					num = 609;
				}
				if (num == 610)
				{
					this.power.UncheckedState.BorderRadius = 0;
					num = 611;
				}
				if (num == 611)
				{
					this.power.UncheckedState.BorderThickness = 0;
					num = 612;
				}
				if (num == 613)
				{
					this.power.CheckedChanged += this.power_CheckedChanged;
					num = 614;
				}
				if (num == 614)
				{
					this.label14.AutoSize = true;
					num = 615;
				}
				if (num == 615)
				{
					this.label14.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 616;
				}
				if (num == 617)
				{
					this.label14.Location = new Point(16, 775);
					num = 618;
				}
				if (num == 618)
				{
					this.label14.Name = "label14";
					num = 619;
				}
				if (num == 619)
				{
					this.label14.Size = new Size(149, 28);
					num = 620;
				}
				if (num == 621)
				{
					this.label14.Text = "Miscellaneous";
					num = 622;
				}
				if (num == 622)
				{
					this.cortana.AutoSize = true;
					num = 623;
				}
				if (num == 624)
				{
					this.cortana.CheckedState.BorderRadius = 0;
					num = 625;
				}
				if (num == 625)
				{
					this.cortana.CheckedState.BorderThickness = 0;
					num = 626;
				}
				if (num == 626)
				{
					this.cortana.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 627;
				}
				if (num == 628)
				{
					this.cortana.ForeColor = Color.White;
					num = 629;
				}
				if (num == 629)
				{
					this.cortana.Location = new Point(21, 263);
					num = 630;
				}
				if (num == 630)
				{
					this.cortana.Name = "cortana";
					num = 631;
				}
				if (num == 632)
				{
					this.cortana.TabIndex = 3;
					num = 633;
				}
				if (num == 633)
				{
					this.cortana.Text = "Disable Cortana";
					num = 634;
				}
				if (num == 634)
				{
					this.cortana.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 635;
				}
				if (num == 636)
				{
					this.cortana.UncheckedState.BorderThickness = 0;
					num = 637;
				}
				if (num == 637)
				{
					this.cortana.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 638;
				}
				if (num == 639)
				{
					this.tele.AutoSize = true;
					num = 640;
				}
				if (num == 640)
				{
					this.tele.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 641;
				}
				if (num == 641)
				{
					this.tele.CheckedState.BorderRadius = 0;
					num = 642;
				}
				if (num == 643)
				{
					this.tele.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 644;
				}
				if (num == 644)
				{
					this.tele.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 645;
				}
				if (num == 645)
				{
					this.tele.ForeColor = Color.White;
					num = 646;
				}
				if (num == 647)
				{
					this.tele.Name = "tele";
					num = 648;
				}
				if (num == 648)
				{
					this.tele.Size = new Size(150, 28);
					num = 649;
				}
				if (num == 650)
				{
					this.tele.Text = "Disable Telemetry";
					num = 651;
				}
				if (num == 651)
				{
					this.tele.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 652;
				}
				if (num == 652)
				{
					this.tele.UncheckedState.BorderRadius = 0;
					num = 653;
				}
				if (num == 654)
				{
					this.tele.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 655;
				}
				if (num == 655)
				{
					this.tele.CheckedChanged += this.tele_CheckedChanged;
					num = 656;
				}
				if (num == 656)
				{
					this.label15.AutoSize = true;
					num = 657;
				}
				if (num == 658)
				{
					this.label15.ForeColor = Color.White;
					num = 659;
				}
				if (num == 659)
				{
					this.label15.Location = new Point(16, 17);
					num = 660;
				}
				if (num == 661)
				{
					this.label15.Size = new Size(156, 28);
					num = 662;
				}
				if (num == 662)
				{
					this.label15.TabIndex = 18;
					num = 663;
				}
				if (num == 663)
				{
					this.label15.Text = "Recommended";
					num = 664;
				}
				if (num == 665)
				{
					this.sysres.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 666;
				}
				if (num == 666)
				{
					this.sysres.CheckedState.BorderRadius = 0;
					num = 667;
				}
				if (num == 667)
				{
					this.sysres.CheckedState.BorderThickness = 0;
					num = 668;
				}
				if (num == 669)
				{
					this.sysres.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 670;
				}
				if (num == 670)
				{
					this.sysres.ForeColor = Color.White;
					num = 671;
				}
				if (num == 672)
				{
					this.sysres.Name = "sysres";
					num = 673;
				}
				if (num == 673)
				{
					this.sysres.Size = new Size(188, 28);
					num = 674;
				}
				if (num == 674)
				{
					this.sysres.TabIndex = 14;
					num = 675;
				}
				if (num == 676)
				{
					this.sysres.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 677;
				}
				if (num == 677)
				{
					this.sysres.UncheckedState.BorderRadius = 0;
					num = 678;
				}
				if (num == 678)
				{
					this.sysres.UncheckedState.BorderThickness = 0;
					num = 679;
				}
				if (num == 680)
				{
					this.sysres.CheckedChanged += this.sysres_CheckedChanged;
					num = 681;
				}
				if (num == 681)
				{
					this.hiber.AutoSize = true;
					num = 682;
				}
				if (num == 682)
				{
					this.hiber.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 683;
				}
				if (num == 684)
				{
					this.hiber.CheckedState.BorderThickness = 0;
					num = 685;
				}
				if (num == 685)
				{
					this.hiber.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 686;
				}
				if (num == 687)
				{
					this.hiber.ForeColor = Color.White;
					num = 688;
				}
				if (num == 688)
				{
					this.hiber.Location = new Point(20, 613);
					num = 689;
				}
				if (num == 689)
				{
					this.hiber.Name = "hiber";
					num = 690;
				}
				if (num == 691)
				{
					this.hiber.TabIndex = 118;
					num = 692;
				}
				if (num == 692)
				{
					this.hiber.Text = "Disable Hibernation";
					num = 693;
				}
				if (num == 693)
				{
					this.hiber.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 694;
				}
				if (num == 695)
				{
					this.hiber.UncheckedState.BorderThickness = 0;
					num = 696;
				}
				if (num == 696)
				{
					this.hiber.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 697;
				}
				if (num == 698)
				{
					this.action.AutoSize = true;
					num = 699;
				}
				if (num == 699)
				{
					this.action.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 700;
				}
				if (num == 700)
				{
					this.action.CheckedState.BorderRadius = 0;
					num = 701;
				}
				if (num == 702)
				{
					this.action.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 703;
				}
				if (num == 703)
				{
					this.action.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 704;
				}
				if (num == 704)
				{
					this.action.ForeColor = Color.White;
					num = 705;
				}
				if (num == 706)
				{
					this.action.Name = "action";
					num = 707;
				}
				if (num == 707)
				{
					this.action.Size = new Size(178, 28);
					num = 708;
				}
				if (num == 709)
				{
					this.action.Text = "Disable Action Center";
					num = 710;
				}
				if (num == 710)
				{
					this.action.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 711;
				}
				if (num == 711)
				{
					this.action.UncheckedState.BorderRadius = 0;
					num = 712;
				}
				if (num == 713)
				{
					this.action.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 714;
				}
				if (num == 714)
				{
					this.action.CheckedChanged += this.action_CheckedChanged;
					num = 715;
				}
				if (num == 715)
				{
					this.hpet.AutoSize = true;
					num = 716;
				}
				if (num == 717)
				{
					this.hpet.CheckedState.BorderRadius = 0;
					num = 718;
				}
				if (num == 718)
				{
					this.hpet.CheckedState.BorderThickness = 0;
					num = 719;
				}
				if (num == 720)
				{
					this.hpet.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 721;
				}
				if (num == 721)
				{
					this.hpet.ForeColor = Color.White;
					num = 722;
				}
				if (num == 722)
				{
					this.hpet.Location = new Point(21, 878);
					num = 723;
				}
				if (num == 724)
				{
					this.hpet.Size = new Size(125, 28);
					num = 725;
				}
				if (num == 725)
				{
					this.hpet.TabIndex = 117;
					num = 726;
				}
				if (num == 726)
				{
					this.hpet.Text = "Disable HPET";
					num = 727;
				}
				if (num == 728)
				{
					this.hpet.UncheckedState.BorderRadius = 0;
					num = 729;
				}
				if (num == 729)
				{
					this.hpet.UncheckedState.BorderThickness = 0;
					num = 730;
				}
				if (num == 730)
				{
					this.hpet.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 731;
				}
				if (num == 732)
				{
					this.automain.AutoSize = true;
					num = 733;
				}
				if (num == 733)
				{
					this.automain.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 734;
				}
				if (num == 735)
				{
					this.automain.CheckedState.BorderThickness = 0;
					num = 736;
				}
				if (num == 736)
				{
					this.automain.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 737;
				}
				if (num == 737)
				{
					this.automain.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 738;
				}
				if (num == 739)
				{
					this.automain.Location = new Point(21, 213);
					num = 740;
				}
				if (num == 740)
				{
					this.automain.Name = "automain";
					num = 741;
				}
				if (num == 741)
				{
					this.automain.Size = new Size(247, 28);
					num = 742;
				}
				if (num == 743)
				{
					this.automain.Text = "Disable Automatic Maintenance";
					num = 744;
				}
				if (num == 744)
				{
					this.automain.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 745;
				}
				if (num == 746)
				{
					this.automain.UncheckedState.BorderThickness = 0;
					num = 747;
				}
				if (num == 747)
				{
					this.automain.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 748;
				}
				if (num == 748)
				{
					this.automain.CheckedChanged += this.automain_CheckedChanged;
					num = 749;
				}
				if (num == 750)
				{
					this.clipboard.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 751;
				}
				if (num == 751)
				{
					this.clipboard.CheckedState.BorderRadius = 0;
					num = 752;
				}
				if (num == 752)
				{
					this.clipboard.CheckedState.BorderThickness = 0;
					num = 753;
				}
				if (num == 754)
				{
					this.clipboard.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 755;
				}
				if (num == 755)
				{
					this.clipboard.ForeColor = Color.White;
					num = 756;
				}
				if (num == 757)
				{
					this.clipboard.Name = "clipboard";
					num = 758;
				}
				if (num == 758)
				{
					this.clipboard.Size = new Size(153, 28);
					num = 759;
				}
				if (num == 759)
				{
					this.clipboard.TabIndex = 119;
					num = 760;
				}
				if (num == 761)
				{
					this.clipboard.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 762;
				}
				if (num == 762)
				{
					this.clipboard.UncheckedState.BorderRadius = 0;
					num = 763;
				}
				if (num == 763)
				{
					this.clipboard.UncheckedState.BorderThickness = 0;
					num = 764;
				}
				if (num == 765)
				{
					this.clipboard.CheckedChanged += this.clipboard_CheckedChanged;
					num = 766;
				}
				if (num == 766)
				{
					this.errror.AutoSize = true;
					num = 767;
				}
				if (num == 768)
				{
					this.errror.CheckedState.BorderRadius = 0;
					num = 769;
				}
				if (num == 769)
				{
					this.errror.CheckedState.BorderThickness = 0;
					num = 770;
				}
				if (num == 770)
				{
					this.errror.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 771;
				}
				if (num == 772)
				{
					this.errror.ForeColor = Color.White;
					num = 773;
				}
				if (num == 773)
				{
					this.errror.Location = new Point(21, 513);
					num = 774;
				}
				if (num == 774)
				{
					this.errror.Name = "errror";
					num = 775;
				}
				if (num == 776)
				{
					this.errror.TabIndex = 6;
					num = 777;
				}
				if (num == 777)
				{
					this.errror.Text = "Disable Error Reporting";
					num = 778;
				}
				if (num == 778)
				{
					this.errror.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 779;
				}
				if (num == 780)
				{
					this.errror.UncheckedState.BorderThickness = 0;
					num = 781;
				}
				if (num == 781)
				{
					this.errror.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 782;
				}
				if (num == 783)
				{
					this.cortana_bar.AutoSize = true;
					num = 784;
				}
				if (num == 784)
				{
					this.cortana_bar.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 785;
				}
				if (num == 785)
				{
					this.cortana_bar.CheckedState.BorderRadius = 0;
					num = 786;
				}
				if (num == 787)
				{
					this.cortana_bar.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 788;
				}
				if (num == 788)
				{
					this.cortana_bar.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 789;
				}
				if (num == 789)
				{
					this.cortana_bar.ForeColor = Color.White;
					num = 790;
				}
				if (num == 791)
				{
					this.cortana_bar.Name = "cortana_bar";
					num = 792;
				}
				if (num == 792)
				{
					this.cortana_bar.Size = new Size(233, 28);
					num = 793;
				}
				if (num == 794)
				{
					this.cortana_bar.Text = "Disable Cortana (Search Bar)";
					num = 795;
				}
				if (num == 795)
				{
					this.cortana_bar.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 796;
				}
				if (num == 796)
				{
					this.cortana_bar.UncheckedState.BorderRadius = 0;
					num = 797;
				}
				if (num == 798)
				{
					this.cortana_bar.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 799;
				}
				if (num == 799)
				{
					this.cortana_bar.CheckedChanged += this.cortana_bar_CheckedChanged;
					num = 800;
				}
				if (num == 800)
				{
					this.dlblock.AutoSize = true;
					num = 801;
				}
				if (num == 802)
				{
					this.dlblock.CheckedState.BorderRadius = 0;
					num = 803;
				}
				if (num == 803)
				{
					this.dlblock.CheckedState.BorderThickness = 0;
					num = 804;
				}
				if (num == 805)
				{
					this.dlblock.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 806;
				}
				if (num == 806)
				{
					this.dlblock.ForeColor = Color.White;
					num = 807;
				}
				if (num == 807)
				{
					this.dlblock.Location = new Point(20, 413);
					num = 808;
				}
				if (num == 809)
				{
					this.dlblock.Size = new Size(219, 28);
					num = 810;
				}
				if (num == 810)
				{
					this.dlblock.TabIndex = 11;
					num = 811;
				}
				if (num == 811)
				{
					this.dlblock.Text = "Disable Downloads Blocking";
					num = 812;
				}
				if (num == 813)
				{
					this.dlblock.UncheckedState.BorderRadius = 0;
					num = 814;
				}
				if (num == 814)
				{
					this.dlblock.UncheckedState.BorderThickness = 0;
					num = 815;
				}
				if (num == 816)
				{
					this.dlblock.CheckedChanged += this.dlblock_CheckedChanged;
					num = 817;
				}
				if (num == 817)
				{
					this.driver.AutoSize = true;
					num = 818;
				}
				if (num == 818)
				{
					this.driver.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 819;
				}
				if (num == 820)
				{
					this.driver.CheckedState.BorderThickness = 0;
					num = 821;
				}
				if (num == 821)
				{
					this.driver.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 822;
				}
				if (num == 822)
				{
					this.driver.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 823;
				}
				if (num == 824)
				{
					this.driver.Location = new Point(20, 463);
					num = 825;
				}
				if (num == 825)
				{
					this.driver.Name = "driver";
					num = 826;
				}
				if (num == 826)
				{
					this.driver.Size = new Size(189, 28);
					num = 827;
				}
				if (num == 828)
				{
					this.driver.Text = "Disable Driver Updates";
					num = 829;
				}
				if (num == 829)
				{
					this.driver.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 830;
				}
				if (num == 831)
				{
					this.driver.UncheckedState.BorderThickness = 0;
					num = 832;
				}
				if (num == 832)
				{
					this.driver.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 833;
				}
				if (num == 833)
				{
					this.driver.CheckedChanged += this.driver_CheckedChanged;
					num = 834;
				}
				if (num == 835)
				{
					this.fast_start.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 836;
				}
				if (num == 836)
				{
					this.fast_start.CheckedState.BorderRadius = 0;
					num = 837;
				}
				if (num == 837)
				{
					this.fast_start.CheckedState.BorderThickness = 0;
					num = 838;
				}
				if (num == 839)
				{
					this.fast_start.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 840;
				}
				if (num == 840)
				{
					this.fast_start.ForeColor = Color.White;
					num = 841;
				}
				if (num == 842)
				{
					this.fast_start.Name = "fast_start";
					num = 843;
				}
				if (num == 843)
				{
					this.fast_start.Size = new Size(169, 28);
					num = 844;
				}
				if (num == 844)
				{
					this.fast_start.TabIndex = 115;
					num = 845;
				}
				if (num == 846)
				{
					this.fast_start.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 847;
				}
				if (num == 847)
				{
					this.fast_start.UncheckedState.BorderRadius = 0;
					num = 848;
				}
				if (num == 848)
				{
					this.fast_start.UncheckedState.BorderThickness = 0;
					num = 849;
				}
				if (num == 850)
				{
					this.fast_start.CheckedChanged += this.fast_start_CheckedChanged;
					num = 851;
				}
				if (num == 851)
				{
					this.win11.BorderRadius = 15;
					num = 852;
				}
				if (num == 853)
				{
					this.win11.CustomImages.Parent = this.win11;
					num = 854;
				}
				if (num == 854)
				{
					this.win11.DisabledState.BorderColor = Color.Transparent;
					num = 855;
				}
				if (num == 855)
				{
					this.win11.DisabledState.CustomBorderColor = Color.Transparent;
					num = 856;
				}
				if (num == 857)
				{
					this.win11.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 858;
				}
				if (num == 858)
				{
					this.win11.DisabledState.Parent = this.win11;
					num = 859;
				}
				if (num == 859)
				{
					this.win11.FillColor = Color.FromArgb(38, 38, 38);
					num = 860;
				}
				if (num == 861)
				{
					this.win11.ForeColor = Color.White;
					num = 862;
				}
				if (num == 862)
				{
					this.win11.HoverState.Parent = this.win11;
					num = 863;
				}
				if (num == 864)
				{
					this.win11.Location = new Point(790, 33);
					num = 865;
				}
				if (num == 865)
				{
					this.win11.Name = "win11";
					num = 866;
				}
				if (num == 866)
				{
					this.win11.ShadowDecoration.Parent = this.win11;
					num = 867;
				}
				if (num == 868)
				{
					this.win11.TabIndex = 115;
					num = 869;
				}
				if (num == 869)
				{
					this.win11.Text = "Windows 11 Options";
					num = 870;
				}
				if (num == 870)
				{
					this.win11.Click += this.win11_Click;
					num = 871;
				}
				if (num == 872)
				{
					this.lbl1.Font = new Font("Josefin Sans", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 873;
				}
				if (num == 873)
				{
					this.lbl1.ForeColor = Color.White;
					num = 874;
				}
				if (num == 874)
				{
					this.lbl1.Location = new Point(1118, 27);
					num = 875;
				}
				if (num == 876)
				{
					this.lbl1.Size = new Size(231, 38);
					num = 877;
				}
				if (num == 877)
				{
					this.lbl1.TabIndex = 117;
					num = 878;
				}
				if (num == 879)
				{
					this.win11_img.Image = (Image)componentResourceManager.GetObject("win11_img.Image");
					num = 880;
				}
				if (num == 880)
				{
					this.win11_img.Location = new Point(1059, 31);
					num = 881;
				}
				if (num == 881)
				{
					this.win11_img.Name = "win11_img";
					num = 882;
				}
				if (num == 883)
				{
					this.win11_img.TabIndex = 116;
					num = 884;
				}
				if (num == 884)
				{
					this.win11_img.TabStop = false;
					num = 885;
				}
				if (num == 885)
				{
					this.back_btn.BackColor = Color.Transparent;
					num = 886;
				}
				if (num == 887)
				{
					this.back_btn.CheckedState.Parent = this.back_btn;
					num = 888;
				}
				if (num == 888)
				{
					this.back_btn.CustomImages.Parent = this.back_btn;
					num = 889;
				}
				if (num == 890)
				{
					this.back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 891;
				}
				if (num == 891)
				{
					this.back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 892;
				}
				if (num == 892)
				{
					this.back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 893;
				}
				if (num == 894)
				{
					this.back_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 895;
				}
				if (num == 895)
				{
					this.back_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 896;
				}
				if (num == 896)
				{
					this.back_btn.ForeColor = Color.White;
					num = 897;
				}
				if (num == 898)
				{
					this.back_btn.Location = new Point(1059, 101);
					num = 899;
				}
				if (num == 899)
				{
					this.back_btn.Name = "back_btn";
					num = 900;
				}
				if (num == 901)
				{
					this.back_btn.Size = new Size(88, 30);
					num = 902;
				}
				if (num == 902)
				{
					this.back_btn.TabIndex = 124;
					num = 903;
				}
				if (num == 903)
				{
					this.back_btn.Text = "Back";
					num = 904;
				}
				if (num == 905)
				{
					this.label2.AutoSize = true;
					num = 906;
				}
				if (num == 906)
				{
					this.label2.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 907;
				}
				if (num == 907)
				{
					this.label2.ForeColor = Color.Silver;
					num = 908;
				}
				if (num == 909)
				{
					this.label2.Name = "label2";
					num = 910;
				}
				if (num == 910)
				{
					this.label2.Size = new Size(256, 19);
					num = 911;
				}
				if (num == 912)
				{
					this.label2.Text = "Restart your PC to let the changes take place";
					num = 913;
				}
				if (num == 913)
				{
					this.siticoneVScrollBar1.BindingContainer = this.panel1;
					num = 914;
				}
				if (num == 914)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 915;
				}
				if (num == 916)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 917;
				}
				if (num == 917)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 918;
				}
				if (num == 918)
				{
					this.siticoneVScrollBar1.LargeChange = 100;
					num = 919;
				}
				if (num == 920)
				{
					this.siticoneVScrollBar1.Maximum = 1526;
					num = 921;
				}
				if (num == 921)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 922;
				}
				if (num == 922)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 923;
				}
				if (num == 924)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 561);
					num = 925;
				}
				if (num == 925)
				{
					this.siticoneVScrollBar1.SmallChange = 5;
					num = 926;
				}
				if (num == 927)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 928;
				}
				if (num == 928)
				{
					this.siticoneVScrollBar1.ThumbSize = 215f;
					num = 929;
				}
				if (num == 929)
				{
					this.siticoneVScrollBar1.Value = 772;
					num = 930;
				}
				if (num == 931)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 932;
				}
				if (num == 932)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 933;
				}
				if (num == 933)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 934;
				}
				if (num == 935)
				{
					base.Controls.Add(this.back_btn);
					num = 936;
				}
				if (num == 936)
				{
					base.Controls.Add(this.lbl1);
					num = 937;
				}
				if (num == 938)
				{
					base.Controls.Add(this.win11);
					num = 939;
				}
				if (num == 939)
				{
					base.Controls.Add(this.panel1);
					num = 940;
				}
				if (num == 940)
				{
					base.Controls.Add(this.label9);
					num = 941;
				}
				if (num == 942)
				{
					base.Name = "Tweaks";
					num = 943;
				}
				if (num == 943)
				{
					base.Size = new Size(1422, 669);
					num = 944;
				}
				if (num == 944)
				{
					base.Load += this.tweaks_Load;
					num = 945;
				}
				if (num == 946)
				{
					this.panel1.PerformLayout();
					num = 947;
				}
				if (num == 947)
				{
					((ISupportInitialize)this.win11_img).EndInit();
					num = 948;
				}
				if (num == 949)
				{
					base.PerformLayout();
					num = 950;
				}
				if (num == 948)
				{
					base.ResumeLayout(false);
					num = 949;
				}
				if (num == 945)
				{
					this.panel1.ResumeLayout(false);
					num = 946;
				}
				if (num == 941)
				{
					base.Controls.Add(this.label1);
					num = 942;
				}
				if (num == 937)
				{
					base.Controls.Add(this.win11_img);
					num = 938;
				}
				if (num == 934)
				{
					base.Controls.Add(this.label2);
					num = 935;
				}
				if (num == 930)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 931;
				}
				if (num == 926)
				{
					this.siticoneVScrollBar1.TabIndex = 336;
					num = 927;
				}
				if (num == 923)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 924;
				}
				if (num == 919)
				{
					this.siticoneVScrollBar1.Location = new Point(972, 84);
					num = 920;
				}
				if (num == 915)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 916;
				}
				if (num == 911)
				{
					this.label2.TabIndex = 125;
					num = 912;
				}
				if (num == 908)
				{
					this.label2.Location = new Point(1121, 65);
					num = 909;
				}
				if (num == 904)
				{
					this.back_btn.Click += this.back_btn_Click;
					num = 905;
				}
				if (num == 900)
				{
					this.back_btn.ShadowDecoration.Parent = this.back_btn;
					num = 901;
				}
				if (num == 897)
				{
					this.back_btn.HoverState.Parent = this.back_btn;
					num = 898;
				}
				if (num == 893)
				{
					this.back_btn.DisabledState.Parent = this.back_btn;
					num = 894;
				}
				if (num == 889)
				{
					this.back_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 890;
				}
				if (num == 886)
				{
					this.back_btn.BorderRadius = 14;
					num = 887;
				}
				if (num == 882)
				{
					this.win11_img.Size = new Size(53, 53);
					num = 883;
				}
				if (num == 878)
				{
					this.lbl1.Text = "Windows 11 Options";
					num = 879;
				}
				if (num == 875)
				{
					this.lbl1.Name = "lbl1";
					num = 876;
				}
				if (num == 871)
				{
					this.lbl1.AutoSize = true;
					num = 872;
				}
				if (num == 867)
				{
					this.win11.Size = new Size(200, 45);
					num = 868;
				}
				if (num == 863)
				{
					this.win11.Image = (Image)componentResourceManager.GetObject("win11.Image");
					num = 864;
				}
				if (num == 860)
				{
					this.win11.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 861;
				}
				if (num == 856)
				{
					this.win11.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
					num = 857;
				}
				if (num == 852)
				{
					this.win11.CheckedState.Parent = this.win11;
					num = 853;
				}
				if (num == 849)
				{
					this.fast_start.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 850;
				}
				if (num == 845)
				{
					this.fast_start.Text = "Disable Fast Startup";
					num = 846;
				}
				if (num == 841)
				{
					this.fast_start.Location = new Point(21, 563);
					num = 842;
				}
				if (num == 838)
				{
					this.fast_start.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 839;
				}
				if (num == 834)
				{
					this.fast_start.AutoSize = true;
					num = 835;
				}
				if (num == 830)
				{
					this.driver.UncheckedState.BorderRadius = 0;
					num = 831;
				}
				if (num == 827)
				{
					this.driver.TabIndex = 10;
					num = 828;
				}
				if (num == 823)
				{
					this.driver.ForeColor = Color.White;
					num = 824;
				}
				if (num == 819)
				{
					this.driver.CheckedState.BorderRadius = 0;
					num = 820;
				}
				if (num == 815)
				{
					this.dlblock.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 816;
				}
				if (num == 812)
				{
					this.dlblock.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 813;
				}
				if (num == 808)
				{
					this.dlblock.Name = "dlblock";
					num = 809;
				}
				if (num == 804)
				{
					this.dlblock.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 805;
				}
				if (num == 801)
				{
					this.dlblock.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 802;
				}
				if (num == 797)
				{
					this.cortana_bar.UncheckedState.BorderThickness = 0;
					num = 798;
				}
				if (num == 793)
				{
					this.cortana_bar.TabIndex = 116;
					num = 794;
				}
				if (num == 790)
				{
					this.cortana_bar.Location = new Point(21, 313);
					num = 791;
				}
				if (num == 786)
				{
					this.cortana_bar.CheckedState.BorderThickness = 0;
					num = 787;
				}
				if (num == 782)
				{
					this.errror.CheckedChanged += this.errror_CheckedChanged;
					num = 783;
				}
				if (num == 779)
				{
					this.errror.UncheckedState.BorderRadius = 0;
					num = 780;
				}
				if (num == 775)
				{
					this.errror.Size = new Size(193, 28);
					num = 776;
				}
				if (num == 771)
				{
					this.errror.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 772;
				}
				if (num == 767)
				{
					this.errror.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 768;
				}
				if (num == 764)
				{
					this.clipboard.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 765;
				}
				if (num == 760)
				{
					this.clipboard.Text = "Disable Clipboard";
					num = 761;
				}
				if (num == 756)
				{
					this.clipboard.Location = new Point(21, 363);
					num = 757;
				}
				if (num == 753)
				{
					this.clipboard.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 754;
				}
				if (num == 749)
				{
					this.clipboard.AutoSize = true;
					num = 750;
				}
				if (num == 745)
				{
					this.automain.UncheckedState.BorderRadius = 0;
					num = 746;
				}
				if (num == 742)
				{
					this.automain.TabIndex = 12;
					num = 743;
				}
				if (num == 738)
				{
					this.automain.ForeColor = Color.White;
					num = 739;
				}
				if (num == 734)
				{
					this.automain.CheckedState.BorderRadius = 0;
					num = 735;
				}
				if (num == 731)
				{
					this.hpet.CheckedChanged += this.hpet_CheckedChanged;
					num = 732;
				}
				if (num == 727)
				{
					this.hpet.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 728;
				}
				if (num == 723)
				{
					this.hpet.Name = "hpet";
					num = 724;
				}
				if (num == 719)
				{
					this.hpet.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 720;
				}
				if (num == 716)
				{
					this.hpet.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 717;
				}
				if (num == 712)
				{
					this.action.UncheckedState.BorderThickness = 0;
					num = 713;
				}
				if (num == 708)
				{
					this.action.TabIndex = 120;
					num = 709;
				}
				if (num == 705)
				{
					this.action.Location = new Point(21, 63);
					num = 706;
				}
				if (num == 701)
				{
					this.action.CheckedState.BorderThickness = 0;
					num = 702;
				}
				if (num == 697)
				{
					this.hiber.CheckedChanged += this.hiber_CheckedChanged;
					num = 698;
				}
				if (num == 694)
				{
					this.hiber.UncheckedState.BorderRadius = 0;
					num = 695;
				}
				if (num == 690)
				{
					this.hiber.Size = new Size(166, 28);
					num = 691;
				}
				if (num == 686)
				{
					this.hiber.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 687;
				}
				if (num == 683)
				{
					this.hiber.CheckedState.BorderRadius = 0;
					num = 684;
				}
				if (num == 679)
				{
					this.sysres.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 680;
				}
				if (num == 675)
				{
					this.sysres.Text = "Disable System Restore";
					num = 676;
				}
				if (num == 671)
				{
					this.sysres.Location = new Point(484, 213);
					num = 672;
				}
				if (num == 668)
				{
					this.sysres.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 669;
				}
				if (num == 664)
				{
					this.sysres.AutoSize = true;
					num = 665;
				}
				if (num == 660)
				{
					this.label15.Name = "label15";
					num = 661;
				}
				if (num == 657)
				{
					this.label15.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 658;
				}
				if (num == 653)
				{
					this.tele.UncheckedState.BorderThickness = 0;
					num = 654;
				}
				if (num == 649)
				{
					this.tele.TabIndex = 13;
					num = 650;
				}
				if (num == 646)
				{
					this.tele.Location = new Point(484, 263);
					num = 647;
				}
				if (num == 642)
				{
					this.tele.CheckedState.BorderThickness = 0;
					num = 643;
				}
				if (num == 638)
				{
					this.cortana.CheckedChanged += this.cortana_CheckedChanged;
					num = 639;
				}
				if (num == 635)
				{
					this.cortana.UncheckedState.BorderRadius = 0;
					num = 636;
				}
				if (num == 631)
				{
					this.cortana.Size = new Size(140, 28);
					num = 632;
				}
				if (num == 627)
				{
					this.cortana.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 628;
				}
				if (num == 623)
				{
					this.cortana.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 624;
				}
				if (num == 620)
				{
					this.label14.TabIndex = 64;
					num = 621;
				}
				if (num == 616)
				{
					this.label14.ForeColor = Color.White;
					num = 617;
				}
				if (num == 612)
				{
					this.power.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 613;
				}
				if (num == 609)
				{
					this.power.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 610;
				}
				if (num == 605)
				{
					this.power.Name = "power";
					num = 606;
				}
				if (num == 601)
				{
					this.power.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 602;
				}
				if (num == 598)
				{
					this.power.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 599;
				}
				if (num == 594)
				{
					this.lockscr.UncheckedState.BorderThickness = 0;
					num = 595;
				}
				if (num == 590)
				{
					this.lockscr.TabIndex = 121;
					num = 591;
				}
				if (num == 587)
				{
					this.lockscr.Location = new Point(20, 663);
					num = 588;
				}
				if (num == 583)
				{
					this.lockscr.CheckedState.BorderThickness = 0;
					num = 584;
				}
				if (num == 579)
				{
					this.wallpaper.CheckedChanged += this.wallpaper_CheckedChanged;
					num = 580;
				}
				if (num == 575)
				{
					this.wallpaper.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 576;
				}
				if (num == 572)
				{
					this.wallpaper.Size = new Size(284, 28);
					num = 573;
				}
				if (num == 568)
				{
					this.wallpaper.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 569;
				}
				if (num == 564)
				{
					this.wallpaper.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 565;
				}
				if (num == 561)
				{
					this.storeup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 562;
				}
				if (num == 557)
				{
					this.storeup.Text = "Disable Store Auto-Apps Update";
					num = 558;
				}
				if (num == 553)
				{
					this.storeup.Location = new Point(484, 163);
					num = 554;
				}
				if (num == 550)
				{
					this.storeup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 551;
				}
				if (num == 546)
				{
					this.storeup.AutoSize = true;
					num = 547;
				}
				if (num == 542)
				{
					this.lookup.UncheckedState.BorderRadius = 0;
					num = 543;
				}
				if (num == 539)
				{
					this.lookup.TabIndex = 1;
					num = 540;
				}
				if (num == 535)
				{
					this.lookup.ForeColor = Color.White;
					num = 536;
				}
				if (num == 531)
				{
					this.lookup.CheckedState.BorderRadius = 0;
					num = 532;
				}
				if (num == 527)
				{
					this.ads.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 528;
				}
				if (num == 524)
				{
					this.ads.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 525;
				}
				if (num == 520)
				{
					this.ads.Name = "ads";
					num = 521;
				}
				if (num == 516)
				{
					this.ads.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 517;
				}
				if (num == 513)
				{
					this.ads.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 514;
				}
				if (num == 509)
				{
					this.timeline.UncheckedState.BorderThickness = 0;
					num = 510;
				}
				if (num == 505)
				{
					this.timeline.TabIndex = 8;
					num = 506;
				}
				if (num == 502)
				{
					this.timeline.Location = new Point(484, 513);
					num = 503;
				}
				if (num == 498)
				{
					this.timeline.CheckedState.BorderThickness = 0;
					num = 499;
				}
				if (num == 494)
				{
					this.sysmain.CheckedChanged += this.sysmain_CheckedChanged;
					num = 495;
				}
				if (num == 491)
				{
					this.sysmain.UncheckedState.BorderRadius = 0;
					num = 492;
				}
				if (num == 487)
				{
					this.sysmain.Size = new Size(222, 28);
					num = 488;
				}
				if (num == 483)
				{
					this.sysmain.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 484;
				}
				if (num == 479)
				{
					this.sysmain.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 480;
				}
				if (num == 476)
				{
					this.winup.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 477;
				}
				if (num == 472)
				{
					this.winup.Text = "Disable Windows Updates";
					num = 473;
				}
				if (num == 468)
				{
					this.winup.Location = new Point(484, 563);
					num = 469;
				}
				if (num == 465)
				{
					this.winup.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 466;
				}
				if (num == 461)
				{
					this.winup.AutoSize = true;
					num = 462;
				}
				if (num == 457)
				{
					this.mmcss.UncheckedState.BorderRadius = 0;
					num = 458;
				}
				if (num == 454)
				{
					this.mmcss.TabIndex = 112;
					num = 455;
				}
				if (num == 450)
				{
					this.mmcss.ForeColor = Color.White;
					num = 451;
				}
				if (num == 446)
				{
					this.mmcss.CheckedState.BorderRadius = 0;
					num = 447;
				}
				if (num == 443)
				{
					this.windef.CheckedChanged += this.windef_CheckedChanged;
					num = 444;
				}
				if (num == 439)
				{
					this.windef.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 440;
				}
				if (num == 435)
				{
					this.windef.Name = "windef";
					num = 436;
				}
				if (num == 431)
				{
					this.windef.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 432;
				}
				if (num == 428)
				{
					this.windef.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 429;
				}
				if (num == 424)
				{
					this.prt_spool.UncheckedState.BorderThickness = 0;
					num = 425;
				}
				if (num == 420)
				{
					this.prt_spool.TabIndex = 124;
					num = 421;
				}
				if (num == 417)
				{
					this.prt_spool.Location = new Point(484, 63);
					num = 418;
				}
				if (num == 413)
				{
					this.prt_spool.CheckedState.BorderThickness = 0;
					num = 414;
				}
				if (num == 409)
				{
					this.photo.CheckedChanged += this.photo_CheckedChanged;
					num = 410;
				}
				if (num == 406)
				{
					this.photo.UncheckedState.BorderRadius = 0;
					num = 407;
				}
				if (num == 402)
				{
					this.photo.Size = new Size(223, 28);
					num = 403;
				}
				if (num == 398)
				{
					this.photo.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 399;
				}
				if (num == 395)
				{
					this.photo.CheckedState.BorderRadius = 0;
					num = 396;
				}
				if (num == 391)
				{
					this.inkspace.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 392;
				}
				if (num == 387)
				{
					this.inkspace.Text = "Disable Windows Ink Workspace";
					num = 388;
				}
				if (num == 383)
				{
					this.inkspace.Location = new Point(484, 463);
					num = 384;
				}
				if (num == 380)
				{
					this.inkspace.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 381;
				}
				if (num == 376)
				{
					this.inkspace.AutoSize = true;
					num = 377;
				}
				if (num == 372)
				{
					this.admin.UncheckedState.BorderRadius = 0;
					num = 373;
				}
				if (num == 369)
				{
					this.admin.TabIndex = 122;
					num = 370;
				}
				if (num == 365)
				{
					this.admin.ForeColor = Color.White;
					num = 366;
				}
				if (num == 361)
				{
					this.admin.CheckedState.BorderRadius = 0;
					num = 362;
				}
				if (num == 358)
				{
					this.large.CheckedChanged += this.large_CheckedChanged;
					num = 359;
				}
				if (num == 354)
				{
					this.large.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 355;
				}
				if (num == 350)
				{
					this.large.Name = "large";
					num = 351;
				}
				if (num == 347)
				{
					this.large.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 348;
				}
				if (num == 343)
				{
					this.large.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 344;
				}
				if (num == 339)
				{
					this.uac_admin.UncheckedState.BorderThickness = 0;
					num = 340;
				}
				if (num == 335)
				{
					this.uac_admin.TabIndex = 123;
					num = 336;
				}
				if (num == 332)
				{
					this.uac_admin.Location = new Point(484, 713);
					num = 333;
				}
				if (num == 328)
				{
					this.uac_admin.CheckedState.BorderThickness = 0;
					num = 329;
				}
				if (num == 324)
				{
					this.spectre.CheckedChanged += this.spectre_CheckedChanged;
					num = 325;
				}
				if (num == 321)
				{
					this.spectre.UncheckedState.BorderRadius = 0;
					num = 322;
				}
				if (num == 317)
				{
					this.spectre.Size = new Size(239, 28);
					num = 318;
				}
				if (num == 313)
				{
					this.spectre.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 314;
				}
				if (num == 310)
				{
					this.spectre.CheckedState.BorderRadius = 0;
					num = 311;
				}
				if (num == 306)
				{
					this.boot.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 307;
				}
				if (num == 302)
				{
					this.boot.Text = "Disable Boot Tracing";
					num = 303;
				}
				if (num == 299)
				{
					this.boot.Name = "boot";
					num = 300;
				}
				if (num == 295)
				{
					this.boot.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 296;
				}
				if (num == 291)
				{
					this.boot.AutoSize = true;
					num = 292;
				}
				if (num == 287)
				{
					this.uac.UncheckedState.BorderRadius = 0;
					num = 288;
				}
				if (num == 284)
				{
					this.uac.TabIndex = 125;
					num = 285;
				}
				if (num == 280)
				{
					this.uac.ForeColor = Color.White;
					num = 281;
				}
				if (num == 276)
				{
					this.uac.CheckedState.BorderRadius = 0;
					num = 277;
				}
				if (num == 273)
				{
					this.mrt.CheckedChanged += this.mrt_CheckedChanged;
					num = 274;
				}
				if (num == 269)
				{
					this.mrt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 270;
				}
				if (num == 265)
				{
					this.mrt.Name = "mrt";
					num = 266;
				}
				if (num == 262)
				{
					this.mrt.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 263;
				}
				if (num == 258)
				{
					this.mrt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 259;
				}
				if (num == 254)
				{
					this.FTH.UncheckedState.BorderThickness = 0;
					num = 255;
				}
				if (num == 251)
				{
					this.FTH.Text = "Disable Fault Tolerant Heap";
					num = 252;
				}
				if (num == 247)
				{
					this.FTH.Location = new Point(21, 831);
					num = 248;
				}
				if (num == 243)
				{
					this.FTH.CheckedState.BorderThickness = 0;
					num = 244;
				}
				if (num == 239)
				{
					this.sticky_keys.CheckedChanged += this.sticky_keys_CheckedChanged;
					num = 240;
				}
				if (num == 236)
				{
					this.sticky_keys.UncheckedState.BorderRadius = 0;
					num = 237;
				}
				if (num == 232)
				{
					this.sticky_keys.Size = new Size(160, 28);
					num = 233;
				}
				if (num == 228)
				{
					this.sticky_keys.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 229;
				}
				if (num == 225)
				{
					this.sticky_keys.CheckedState.BorderRadius = 0;
					num = 226;
				}
				if (num == 221)
				{
					this.ntfs.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 222;
				}
				if (num == 217)
				{
					this.ntfs.Text = "Disable NTFS Timestamp";
					num = 218;
				}
				if (num == 214)
				{
					this.ntfs.Name = "ntfs";
					num = 215;
				}
				if (num == 210)
				{
					this.ntfs.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 211;
				}
				if (num == 206)
				{
					this.ntfs.AutoSize = true;
					num = 207;
				}
				if (num == 203)
				{
					this.settings_tw.Size = new Size(411, 330);
					num = 204;
				}
				if (num == 199)
				{
					this.settings_tw.ForeColor = Color.White;
					num = 200;
				}
				if (num == 195)
				{
					this.show_sel.CheckedChanged += this.show_sel_CheckedChanged;
					num = 196;
				}
				if (num == 191)
				{
					this.show_sel.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 192;
				}
				if (num == 188)
				{
					this.show_sel.Size = new Size(139, 31);
					num = 189;
				}
				if (num == 184)
				{
					this.show_sel.Font = new Font("Josefin Sans", 12.75f);
					num = 185;
				}
				if (num == 180)
				{
					this.show_sel.CheckedState.BorderThickness = 0;
					num = 181;
				}
				if (num == 177)
				{
					this.hide_sel.UncheckedState.InnerColor = Color.Transparent;
					num = 178;
				}
				if (num == 173)
				{
					this.hide_sel.Text = "Hide Selected";
					num = 174;
				}
				if (num == 169)
				{
					this.hide_sel.Location = new Point(484, 1262);
					num = 170;
				}
				if (num == 166)
				{
					this.hide_sel.CheckedState.InnerOffset = -4;
					num = 167;
				}
				if (num == 162)
				{
					this.hide_sel.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 163;
				}
				if (num == 158)
				{
					this.label3.Size = new Size(312, 28);
					num = 159;
				}
				if (num == 155)
				{
					this.label3.ForeColor = Color.White;
					num = 156;
				}
				if (num == 151)
				{
					this.label4.TabIndex = 341;
					num = 152;
				}
				if (num == 147)
				{
					this.label4.ForeColor = Color.Silver;
					num = 148;
				}
				if (num == 143)
				{
					this.revert_settings_pg.Text = "Revert Changes";
					num = 144;
				}
				if (num == 140)
				{
					this.revert_settings_pg.ShadowDecoration.Parent = this.revert_settings_pg;
					num = 141;
				}
				if (num == 136)
				{
					this.revert_settings_pg.ForeColor = Color.White;
					num = 137;
				}
				if (num == 132)
				{
					this.revert_settings_pg.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 133;
				}
				if (num == 129)
				{
					this.revert_settings_pg.DisabledState.BorderColor = Color.DarkGray;
					num = 130;
				}
				if (num == 125)
				{
					this.revert_settings_pg.BackColor = Color.Transparent;
					num = 126;
				}
				if (num == 121)
				{
					this.panel1.Location = new Point(13, 84);
					num = 122;
				}
				if (num == 118)
				{
					this.panel1.Controls.Add(this.dlblock);
					num = 119;
				}
				if (num == 114)
				{
					this.panel1.Controls.Add(this.automain);
					num = 115;
				}
				if (num == 110)
				{
					this.panel1.Controls.Add(this.sysres);
					num = 111;
				}
				if (num == 107)
				{
					this.panel1.Controls.Add(this.cortana);
					num = 108;
				}
				if (num == 103)
				{
					this.panel1.Controls.Add(this.wallpaper);
					num = 104;
				}
				if (num == 99)
				{
					this.panel1.Controls.Add(this.timeline);
					num = 100;
				}
				if (num == 95)
				{
					this.panel1.Controls.Add(this.windef);
					num = 96;
				}
				if (num == 92)
				{
					this.panel1.Controls.Add(this.inkspace);
					num = 93;
				}
				if (num == 88)
				{
					this.panel1.Controls.Add(this.spectre);
					num = 89;
				}
				if (num == 84)
				{
					this.panel1.Controls.Add(this.FTH);
					num = 85;
				}
				if (num == 81)
				{
					this.panel1.Controls.Add(this.settings_tw);
					num = 82;
				}
				if (num == 77)
				{
					this.panel1.Controls.Add(this.label4);
					num = 78;
				}
				if (num == 73)
				{
					this.label9.TabIndex = 45;
					num = 74;
				}
				if (num == 70)
				{
					this.label9.Location = new Point(23, 53);
					num = 71;
				}
				if (num == 66)
				{
					this.label1.Text = "Tweaks";
					num = 67;
				}
				if (num == 62)
				{
					this.label1.Location = new Point(18, 0);
					num = 63;
				}
				if (num == 59)
				{
					this.label1.AutoSize = true;
					num = 60;
				}
				if (num == 55)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 56;
				}
				if (num == 51)
				{
					this.lbl1 = new Label();
					num = 52;
				}
				if (num == 47)
				{
					this.dlblock = new SiticoneCheckBox();
					num = 48;
				}
				if (num == 44)
				{
					this.clipboard = new SiticoneCheckBox();
					num = 45;
				}
				if (num == 40)
				{
					this.hiber = new SiticoneCheckBox();
					num = 41;
				}
				if (num == 36)
				{
					this.cortana = new SiticoneCheckBox();
					num = 37;
				}
				if (num == 33)
				{
					this.lockscr = new SiticoneCheckBox();
					num = 34;
				}
				if (num == 29)
				{
					this.ads = new SiticoneCheckBox();
					num = 30;
				}
				if (num == 25)
				{
					this.mmcss = new SiticoneCheckBox();
					num = 26;
				}
				if (num == 22)
				{
					this.photo = new SiticoneCheckBox();
					num = 23;
				}
				if (num == 18)
				{
					this.uac_admin = new SiticoneCheckBox();
					num = 19;
				}
				if (num == 14)
				{
					this.mrt = new SiticoneCheckBox();
					num = 15;
				}
				if (num == 11)
				{
					this.ntfs = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 7)
				{
					this.label3 = new Label();
					num = 8;
				}
				if (num == 3)
				{
					this.label9 = new Label();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 950);
		}

		// Token: 0x040001F6 RID: 502
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040001F7 RID: 503
		private static Tweaks _instace;

		// Token: 0x040001F8 RID: 504
		private RegistryKey toolkit = Registry.CurrentUser.CreateSubKey("Nexus LiteOS Toolkit\\Optimizations", RegistryKeyPermissionCheck.ReadWriteSubTree);

		// Token: 0x040001F9 RID: 505
		private string Settings_Page = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";

		// Token: 0x040001FA RID: 506
		private bool FirstTimeExpand = true;

		// Token: 0x040001FB RID: 507
		private IContainer components = null;

		// Token: 0x040001FC RID: 508
		private Label label1;

		// Token: 0x040001FD RID: 509
		private Label label9;

		// Token: 0x040001FE RID: 510
		private Panel panel1;

		// Token: 0x040001FF RID: 511
		private SiticoneCheckBox boot;

		// Token: 0x04000200 RID: 512
		private SiticoneCheckBox spectre;

		// Token: 0x04000201 RID: 513
		private SiticoneCheckBox large;

		// Token: 0x04000202 RID: 514
		private SiticoneCheckBox mmcss;

		// Token: 0x04000203 RID: 515
		private SiticoneCheckBox sysmain;

		// Token: 0x04000204 RID: 516
		private SiticoneCheckBox power;

		// Token: 0x04000205 RID: 517
		private Label label14;

		// Token: 0x04000206 RID: 518
		private Label label15;

		// Token: 0x04000207 RID: 519
		private SiticoneCheckBox wallpaper;

		// Token: 0x04000208 RID: 520
		private SiticoneCheckBox photo;

		// Token: 0x04000209 RID: 521
		private SiticoneCheckBox sysres;

		// Token: 0x0400020A RID: 522
		private SiticoneCheckBox tele;

		// Token: 0x0400020B RID: 523
		private SiticoneCheckBox automain;

		// Token: 0x0400020C RID: 524
		private SiticoneCheckBox dlblock;

		// Token: 0x0400020D RID: 525
		private SiticoneCheckBox driver;

		// Token: 0x0400020E RID: 526
		private SiticoneCheckBox timeline;

		// Token: 0x0400020F RID: 527
		private SiticoneCheckBox winup;

		// Token: 0x04000210 RID: 528
		private SiticoneCheckBox errror;

		// Token: 0x04000211 RID: 529
		private SiticoneCheckBox windef;

		// Token: 0x04000212 RID: 530
		private SiticoneCheckBox storeup;

		// Token: 0x04000213 RID: 531
		private SiticoneCheckBox cortana;

		// Token: 0x04000214 RID: 532
		private SiticoneCheckBox inkspace;

		// Token: 0x04000215 RID: 533
		private SiticoneCheckBox lookup;

		// Token: 0x04000216 RID: 534
		private SiticoneCheckBox ads;

		// Token: 0x04000217 RID: 535
		private SiticoneCheckBox admin;

		// Token: 0x04000218 RID: 536
		private SiticoneCheckBox lockscr;

		// Token: 0x04000219 RID: 537
		private SiticoneCheckBox action;

		// Token: 0x0400021A RID: 538
		private SiticoneCheckBox clipboard;

		// Token: 0x0400021B RID: 539
		private SiticoneCheckBox hiber;

		// Token: 0x0400021C RID: 540
		private SiticoneCheckBox hpet;

		// Token: 0x0400021D RID: 541
		private SiticoneCheckBox cortana_bar;

		// Token: 0x0400021E RID: 542
		private SiticoneCheckBox fast_start;

		// Token: 0x0400021F RID: 543
		private SiticoneCheckBox uac;

		// Token: 0x04000220 RID: 544
		private SiticoneCheckBox prt_spool;

		// Token: 0x04000221 RID: 545
		private SiticoneCheckBox uac_admin;

		// Token: 0x04000222 RID: 546
		private SiticoneCheckBox mrt;

		// Token: 0x04000223 RID: 547
		private SiticoneCheckBox FTH;

		// Token: 0x04000224 RID: 548
		private SiticoneButton win11;

		// Token: 0x04000225 RID: 549
		private Label lbl1;

		// Token: 0x04000226 RID: 550
		private PictureBox win11_img;

		// Token: 0x04000227 RID: 551
		private SiticoneRoundedButton back_btn;

		// Token: 0x04000228 RID: 552
		private Label label2;

		// Token: 0x04000229 RID: 553
		private SiticoneCheckBox sticky_keys;

		// Token: 0x0400022A RID: 554
		private SiticoneCheckBox ntfs;

		// Token: 0x0400022B RID: 555
		private SiticoneVScrollBar siticoneVScrollBar1;

		// Token: 0x0400022C RID: 556
		private TreeView settings_tw;

		// Token: 0x0400022D RID: 557
		private SiticoneRadioButton hide_sel;

		// Token: 0x0400022E RID: 558
		private SiticoneRadioButton show_sel;

		// Token: 0x0400022F RID: 559
		private Label label3;

		// Token: 0x04000230 RID: 560
		private Label label4;

		// Token: 0x04000231 RID: 561
		private SiticoneRoundedButton revert_settings_pg;
	}
}
