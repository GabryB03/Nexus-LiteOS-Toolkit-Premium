using System;
using Microsoft.Win32;
using WindowsFormsApplication2.Classes;

namespace Login_HWID.Class
{
	// Token: 0x02000082 RID: 130
	public static class WinVer
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x00195100 File Offset: 0x00193300
		public static int GetOSBuildNumber()
		{
			int num = 0;
			int num3;
			for (;;)
			{
				int num2;
				if (num == 2)
				{
					num2 = 0;
					num = 3;
				}
				RegistryKey registryKey;
				bool flag;
				if (num == 4)
				{
					flag = registryKey != null;
					num = 5;
				}
				string text;
				if (num == 6)
				{
					text = registryKey.GetValue("CurrentBuild", "").ToString();
					num = 7;
				}
				if (num == 9)
				{
					num = 10;
				}
				if (num == 11)
				{
					goto IL_D8;
				}
				IL_E4:
				if (num == 13)
				{
					break;
				}
				if (num == 12)
				{
					goto IL_B7;
				}
				IL_C0:
				if (num == 10)
				{
					num2 = 0;
					num = 11;
				}
				if (num == 8)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_D8;
					}
					num = 9;
				}
				if (num == 7)
				{
					bool flag2 = !int.TryParse(text, out num2);
					num = 8;
				}
				if (num == 5)
				{
					if (!flag)
					{
						goto IL_B7;
					}
					num = 6;
				}
				if (num == 3)
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
					num = 4;
				}
				if (num == 1)
				{
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
				IL_B7:
				num3 = num2;
				num = 13;
				goto IL_C0;
				IL_D8:
				registryKey.Close();
				num = 12;
				goto IL_E4;
			}
			return num3;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00195274 File Offset: 0x00193474
		public static string GetDisplayVersion()
		{
			int num = 0;
			string text2;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 2)
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
					num = 3;
				}
				if (num != 4)
				{
					goto IL_2A;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_2A;
				}
				goto IL_60;
				IL_A0:
				if (num == 8)
				{
					registryKey.Close();
					num = 9;
				}
				string text;
				if (num == 7)
				{
					text = registryKey.GetValue("DisplayVersion", "").ToString().ToUpper();
					num = 8;
				}
				if (num == 5)
				{
					bool flag2 = RegistryTools.ValueExists(registryKey, "DisplayVersion");
					num = 6;
				}
				if (num == 3)
				{
					flag = registryKey != null;
					num = 4;
				}
				if (num == 1)
				{
					text = "";
					num = 2;
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
				IL_71:
				if (num == 12)
				{
					break;
				}
				if (num == 10)
				{
					goto IL_8E;
				}
				goto IL_A0;
				IL_2A:
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_8E;
					}
					num = 7;
				}
				if (num == 9 || num == 11)
				{
					goto IL_60;
				}
				goto IL_71;
				IL_8E:
				text = "-";
				num = 11;
				goto IL_A0;
				IL_60:
				text2 = text;
				num = 12;
				goto IL_71;
			}
			return text2;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0019543C File Offset: 0x0019363C
		public static WinVer.WindowsVersion GetWindowsVersion()
		{
			int num = 0;
			WinVer.WindowsVersion windowsVersion;
			int osbuildNumber;
			string displayVersion;
			for (;;)
			{
				if (num == 2)
				{
					windowsVersion = WinVer.WindowsVersion.Unknown;
					num = 3;
				}
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						goto IL_4D9;
					}
					num = 5;
				}
				if (num == 6)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1507_TH1_RTM;
					num = 7;
				}
				bool flag2;
				if (num == 9)
				{
					flag2 = osbuildNumber >= 10586;
					num = 10;
				}
				if (num == 11)
				{
					num = 12;
				}
				if (num == 13)
				{
					goto IL_2D1;
				}
				IL_2E8:
				if (num == 15)
				{
					num = 16;
				}
				if (num != 18)
				{
					goto IL_92;
				}
				bool flag3;
				if (flag3)
				{
					num = 19;
					goto IL_92;
				}
				goto IL_23D;
				IL_24D:
				if (num == 19)
				{
					num = 20;
				}
				if (num == 17)
				{
					goto IL_278;
				}
				IL_28F:
				if (num == 16)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1607_RS1_AnniversaryUpdate;
					num = 17;
				}
				bool flag4;
				if (num == 14)
				{
					if (!flag4)
					{
						goto IL_278;
					}
					num = 15;
				}
				if (num == 12)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1511_TH2;
					num = 13;
				}
				if (num == 10)
				{
					if (!flag2)
					{
						goto IL_2D1;
					}
					num = 11;
				}
				if (num == 8)
				{
					displayVersion = WinVer.GetDisplayVersion();
					num = 9;
				}
				if (num == 7)
				{
					osbuildNumber = WinVer.GetOSBuildNumber();
					num = 8;
				}
				if (num == 5)
				{
					num = 6;
				}
				if (num == 3)
				{
					bool flag = Environment.OSVersion.Version.Major == 10;
					num = 4;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 39)
				{
					break;
				}
				continue;
				IL_278:
				flag3 = osbuildNumber >= 14900;
				num = 18;
				goto IL_28F;
				IL_92:
				if (num == 20)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1703_RS2_CreatorsUpdate;
					num = 21;
				}
				if (num != 22)
				{
					goto IL_BF;
				}
				bool flag5;
				if (flag5)
				{
					num = 23;
					goto IL_BF;
				}
				goto IL_213;
				IL_223:
				if (num == 23)
				{
					num = 24;
				}
				if (num == 21)
				{
					goto IL_23D;
				}
				goto IL_24D;
				IL_BF:
				if (num == 24)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1709_RS3_FallCreatorsUpdate;
					num = 25;
				}
				if (num == 27)
				{
					num = 28;
				}
				if (num == 29)
				{
					goto IL_1DB;
				}
				IL_1EB:
				if (num == 31)
				{
					num = 32;
				}
				if (num != 34)
				{
					goto IL_10C;
				}
				bool flag6;
				if (flag6)
				{
					num = 35;
					goto IL_10C;
				}
				goto IL_14D;
				IL_15E:
				if (num == 35)
				{
					num = 36;
				}
				if (num == 33)
				{
					goto IL_189;
				}
				IL_199:
				if (num == 32)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1809_RS5_October2018Update;
					num = 33;
				}
				bool flag7;
				if (num == 30)
				{
					if (!flag7)
					{
						goto IL_189;
					}
					num = 31;
				}
				if (num == 28)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1803_RS4_April2018Update;
					num = 29;
				}
				bool flag8;
				if (num == 26)
				{
					if (!flag8)
					{
						goto IL_1DB;
					}
					num = 27;
				}
				if (num == 25)
				{
					goto IL_213;
				}
				goto IL_223;
				IL_189:
				flag6 = osbuildNumber > 17999;
				num = 34;
				goto IL_199;
				IL_10C:
				if (num == 36)
				{
					windowsVersion = WinVer.WindowsVersion.Windows10_1903_19H1_May2019Update;
					num = 37;
				}
				if (num == 38)
				{
					if (displayVersion == "1909")
					{
						goto IL_3BC;
					}
					num = 39;
				}
				if (num != 37)
				{
					goto IL_15E;
				}
				IL_14D:
				if (osbuildNumber >= 18362)
				{
					num = 38;
					goto IL_15E;
				}
				goto IL_3C3;
				IL_1DB:
				flag7 = osbuildNumber > 17134;
				num = 30;
				goto IL_1EB;
				IL_213:
				flag8 = osbuildNumber > 16299;
				num = 26;
				goto IL_223;
				IL_23D:
				flag5 = osbuildNumber > 15063;
				num = 22;
				goto IL_24D;
				IL_2D1:
				flag4 = osbuildNumber >= 14000;
				num = 14;
				goto IL_2E8;
			}
			bool flag9 = osbuildNumber == 18363;
			goto IL_3C8;
			IL_3BC:
			flag9 = true;
			goto IL_3C8;
			IL_3C3:
			flag9 = false;
			IL_3C8:
			if (flag9)
			{
				windowsVersion = WinVer.WindowsVersion.Windows10_1909_19H2_November2019Update;
			}
			if (osbuildNumber > 18836)
			{
				windowsVersion = WinVer.WindowsVersion.Windows10_2004_20H1_May2020Udate;
			}
			if (osbuildNumber >= 19041 && ((osbuildNumber == 19041 && displayVersion == "20H2") || osbuildNumber == 19042))
			{
				windowsVersion = WinVer.WindowsVersion.Windows10_20H2_October2020Udate;
			}
			if (osbuildNumber >= 19042 && ((osbuildNumber == 19041 && displayVersion == "21H1") || osbuildNumber == 19043))
			{
				windowsVersion = WinVer.WindowsVersion.Windows10_21H1_May2021Udate;
			}
			if (osbuildNumber >= 19043 && ((osbuildNumber == 19043 && displayVersion == "21H2") || osbuildNumber == 19044))
			{
				windowsVersion = WinVer.WindowsVersion.Windows10_21H2;
			}
			if (osbuildNumber >= 19500)
			{
				windowsVersion = WinVer.WindowsVersion.Windows11_RTM;
			}
			if (osbuildNumber >= 22600)
			{
				windowsVersion = WinVer.WindowsVersion.Windows11_22H2;
			}
			if (osbuildNumber >= 25000)
			{
				windowsVersion = WinVer.WindowsVersion.Windows11_23H2;
			}
			IL_4D9:
			if (Environment.OSVersion.Version.Major == 6)
			{
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					windowsVersion = WinVer.WindowsVersion.Vista;
					break;
				case 1:
					windowsVersion = WinVer.WindowsVersion.Windows7;
					break;
				case 2:
					windowsVersion = WinVer.WindowsVersion.Windows8;
					break;
				case 3:
				{
					windowsVersion = WinVer.WindowsVersion.Windows81;
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
					if (registryKey != null)
					{
						string text = registryKey.GetValue("BuildLabEx", "").ToString();
						string[] array = text.Split(new char[] { '.' });
						if (array.Length > 1)
						{
							string text2 = array[1];
							int num2 = 0;
							if (int.TryParse(text2, out num2) && num2 >= 17031)
							{
								windowsVersion = WinVer.WindowsVersion.Windows81u1;
							}
						}
						registryKey.Close();
					}
					break;
				}
				}
			}
			return windowsVersion;
		}

		// Token: 0x02000083 RID: 131
		public enum WindowsVersion
		{
			// Token: 0x04000A72 RID: 2674
			Unknown = -1,
			// Token: 0x04000A73 RID: 2675
			Windows2000,
			// Token: 0x04000A74 RID: 2676
			XP,
			// Token: 0x04000A75 RID: 2677
			Server2003,
			// Token: 0x04000A76 RID: 2678
			Vista,
			// Token: 0x04000A77 RID: 2679
			Windows7,
			// Token: 0x04000A78 RID: 2680
			Windows8,
			// Token: 0x04000A79 RID: 2681
			Windows81,
			// Token: 0x04000A7A RID: 2682
			Windows81u1,
			// Token: 0x04000A7B RID: 2683
			Windows10_1507_TH1_RTM,
			// Token: 0x04000A7C RID: 2684
			Windows10_1511_TH2,
			// Token: 0x04000A7D RID: 2685
			Windows10_1607_RS1_AnniversaryUpdate,
			// Token: 0x04000A7E RID: 2686
			Windows10_1703_RS2_CreatorsUpdate,
			// Token: 0x04000A7F RID: 2687
			Windows10_1709_RS3_FallCreatorsUpdate,
			// Token: 0x04000A80 RID: 2688
			Windows10_1803_RS4_April2018Update,
			// Token: 0x04000A81 RID: 2689
			Windows10_1809_RS5_October2018Update,
			// Token: 0x04000A82 RID: 2690
			Windows10_1903_19H1_May2019Update,
			// Token: 0x04000A83 RID: 2691
			Windows10_1909_19H2_November2019Update,
			// Token: 0x04000A84 RID: 2692
			Windows10_2004_20H1_May2020Udate,
			// Token: 0x04000A85 RID: 2693
			Windows10_20H2_October2020Udate,
			// Token: 0x04000A86 RID: 2694
			Windows10_21H1_May2021Udate,
			// Token: 0x04000A87 RID: 2695
			Windows10_21H2,
			// Token: 0x04000A88 RID: 2696
			Windows11_RTM,
			// Token: 0x04000A89 RID: 2697
			Windows11_22H2,
			// Token: 0x04000A8A RID: 2698
			Windows11_23H2,
			// Token: 0x04000A8B RID: 2699
			Windows10_InsiderPreview = 65000
		}
	}
}
