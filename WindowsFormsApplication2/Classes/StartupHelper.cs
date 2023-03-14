using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000041 RID: 65
	internal static class StartupHelper
	{
		// Token: 0x06000303 RID: 771 RVA: 0x0008C584 File Offset: 0x0008A784
		private static void GetRegistryStartupItemsHelper(ref List<StartupItem> list, StartupItemLocation location, StartupItemType type)
		{
			int num = 0;
			RegistryKey registryKey;
			string text;
			for (;;)
			{
				if (num == 2)
				{
					registryKey = null;
					num = 3;
				}
				if (num != 4)
				{
					goto IL_1E;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_1E;
				}
				goto IL_62;
				IL_2AF:
				if (num == 8)
				{
					text = StartupHelper.LocalMachineRun;
					num = 9;
				}
				if (num == 6)
				{
					bool flag2 = type == StartupItemType.Run;
					num = 7;
				}
				if (num == 5)
				{
					registryKey = Registry.LocalMachine;
					num = 6;
				}
				if (num == 3)
				{
					flag = location == StartupItemLocation.HKLM;
					num = 4;
				}
				if (num == 1)
				{
					text = string.Empty;
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
				IL_142:
				bool flag3;
				if (num == 36)
				{
					if (!flag3)
					{
						return;
					}
					num = 37;
				}
				if (num == 34)
				{
					text = StartupHelper.CurrentUserRunOnce;
					num = 35;
				}
				if (num == 32)
				{
					goto IL_18B;
				}
				IL_19E:
				if (num == 31)
				{
					goto IL_26A;
				}
				if (num == 29)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_18B;
					}
					num = 30;
				}
				if (num == 27)
				{
					registryKey = Registry.CurrentUser;
					num = 28;
				}
				if (num == 25)
				{
					goto IL_23A;
				}
				IL_24D:
				if (num == 24)
				{
					goto IL_26A;
				}
				bool flag5;
				if (num == 22)
				{
					if (!flag5)
					{
						goto IL_26A;
					}
					num = 23;
				}
				if (num == 20)
				{
					goto IL_26A;
				}
				if (num == 19)
				{
					text = StartupHelper.LocalMachineRunWoW;
					num = 20;
				}
				bool flag6;
				if (num == 17)
				{
					flag6 = type == StartupItemType.Run;
					num = 18;
				}
				bool flag7;
				if (num == 15)
				{
					if (!flag7)
					{
						goto IL_23A;
					}
					num = 16;
				}
				if (num == 13)
				{
					goto IL_26A;
				}
				if (num == 12)
				{
					text = StartupHelper.LocalMachineRunOnce;
					num = 13;
				}
				if (num == 10)
				{
					goto IL_29C;
				}
				goto IL_2AF;
				IL_23A:
				bool flag8 = location == StartupItemLocation.HKCU;
				num = 26;
				goto IL_24D;
				IL_18B:
				bool flag9 = type == StartupItemType.RunOnce;
				num = 33;
				goto IL_19E;
				IL_75:
				if (num == 16)
				{
					registryKey = Registry.LocalMachine;
					num = 17;
				}
				if (num != 18)
				{
					goto IL_9F;
				}
				if (flag6)
				{
					num = 19;
					goto IL_9F;
				}
				goto IL_A9;
				IL_BC:
				if (num == 23)
				{
					text = StartupHelper.LocalMachineRunOnceWow;
					num = 24;
				}
				if (num == 26)
				{
					if (!flag8)
					{
						goto IL_26A;
					}
					num = 27;
				}
				if (num == 28)
				{
					bool flag4 = type == StartupItemType.Run;
					num = 29;
				}
				if (num == 30)
				{
					text = StartupHelper.CurrentUserRun;
					num = 31;
				}
				if (num == 33)
				{
					if (!flag9)
					{
						goto IL_26A;
					}
					num = 34;
				}
				if (num != 35)
				{
					goto IL_142;
				}
				goto IL_26A;
				IL_9F:
				if (num != 21)
				{
					goto IL_BC;
				}
				IL_A9:
				flag5 = type == StartupItemType.RunOnce;
				num = 22;
				goto IL_BC;
				IL_1E:
				if (num == 7)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_29C;
					}
					num = 8;
				}
				if (num == 9)
				{
					goto IL_26A;
				}
				bool flag10;
				if (num == 11)
				{
					if (!flag10)
					{
						goto IL_26A;
					}
					num = 12;
				}
				if (num == 14)
				{
					goto IL_62;
				}
				goto IL_75;
				IL_29C:
				flag10 = type == StartupItemType.RunOnce;
				num = 11;
				goto IL_2AF;
				IL_26A:
				flag3 = registryKey != null;
				num = 36;
				goto IL_142;
				IL_62:
				flag7 = location == StartupItemLocation.HKLMWoW;
				num = 15;
				goto IL_75;
			}
			try
			{
				RegistryKey registryKey2 = registryKey.OpenSubKey(text, true);
				if (registryKey2 != null)
				{
					string[] valueNames = registryKey2.GetValueNames();
					foreach (string text2 in valueNames)
					{
						try
						{
							RegistryStartupItem registryStartupItem = new RegistryStartupItem();
							registryStartupItem.Name = text2;
							registryStartupItem.FileLocation = registryKey2.GetValue(text2).ToString();
							registryStartupItem.Key = registryKey2;
							registryStartupItem.RegistryLocation = location;
							registryStartupItem.StartupType = type;
							list.Add(registryStartupItem);
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0008C9B4 File Offset: 0x0008ABB4
		private static void GetFolderStartupItemsHelper(ref List<StartupItem> list, string[] files, string[] shortcuts)
		{
			int num = 0;
			for (;;)
			{
				if (num == 2)
				{
					num = 3;
				}
				if (num == 4)
				{
					goto IL_2D;
				}
				if (num == 5)
				{
					goto IL_36;
				}
				IL_40:
				int num2;
				if (num == 3)
				{
					num2 = 0;
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
				string text;
				if (num == 6)
				{
					try
					{
						FolderStartupItem folderStartupItem = new FolderStartupItem();
						folderStartupItem.Name = Path.GetFileNameWithoutExtension(text);
						folderStartupItem.FileLocation = text;
						folderStartupItem.Shortcut = text;
						folderStartupItem.RegistryLocation = StartupItemLocation.Folder;
						list.Add(folderStartupItem);
					}
					catch (Exception)
					{
					}
					num2++;
					goto IL_2D;
				}
				continue;
				IL_36:
				text = files[num2];
				num = 6;
				goto IL_40;
				IL_2D:
				if (num2 < files.Length)
				{
					goto IL_36;
				}
				break;
			}
			foreach (string text2 in shortcuts)
			{
				try
				{
					FolderStartupItem folderStartupItem2 = new FolderStartupItem();
					folderStartupItem2.Name = Path.GetFileNameWithoutExtension(text2);
					folderStartupItem2.FileLocation = Utils.GetShortcutTargetFile(text2);
					folderStartupItem2.Shortcut = text2;
					folderStartupItem2.RegistryLocation = StartupItemLocation.Folder;
					list.Add(folderStartupItem2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0008CB24 File Offset: 0x0008AD24
		internal static List<StartupItem> GetStartupItems()
		{
			int num = 0;
			List<StartupItem> list2;
			for (;;)
			{
				List<StartupItem> list;
				if (num == 2)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKLM, StartupItemType.Run);
					num = 3;
				}
				if (num == 4)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKCU, StartupItemType.Run);
					num = 5;
				}
				if (num != 7)
				{
					goto IL_42;
				}
				bool is64BitOperatingSystem;
				if (is64BitOperatingSystem)
				{
					num = 8;
					goto IL_42;
				}
				goto IL_1F3;
				IL_204:
				if (num == 8)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKLMWoW, StartupItemType.Run);
					num = 9;
				}
				if (num == 6)
				{
					is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
					num = 7;
				}
				if (num == 5)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKCU, StartupItemType.RunOnce);
					num = 6;
				}
				if (num == 3)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKLM, StartupItemType.RunOnce);
					num = 4;
				}
				if (num == 1)
				{
					list = new List<StartupItem>();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 22)
				{
					break;
				}
				continue;
				IL_42:
				if (num == 9)
				{
					StartupHelper.GetRegistryStartupItemsHelper(ref list, StartupItemLocation.HKLMWoW, StartupItemType.RunOnce);
					num = 10;
				}
				if (num != 11)
				{
					goto IL_79;
				}
				bool flag;
				if (flag)
				{
					num = 12;
					goto IL_79;
				}
				goto IL_162;
				IL_174:
				if (num == 13)
				{
					string[] files = Directory.GetFiles(StartupHelper.CurrentUserStartupFolder, "*.lnk", SearchOption.AllDirectories);
					num = 14;
				}
				if (num == 12)
				{
					string[] array = (from s in Directory.EnumerateFiles(StartupHelper.CurrentUserStartupFolder, "*.*", SearchOption.AllDirectories)
						where (s.EndsWith(".exe") ? (-3 + sizeof(float)) : (s.EndsWith(".bat") ? 1 : 0)) != 0
						select s).ToArray<string>();
					num = 13;
				}
				if (num == 10)
				{
					goto IL_1F3;
				}
				goto IL_204;
				IL_79:
				if (num == 14)
				{
					string[] files;
					string[] array;
					StartupHelper.GetFolderStartupItemsHelper(ref list, array, files);
					num = 15;
				}
				if (num != 16)
				{
					goto IL_A8;
				}
				bool flag2;
				if (flag2)
				{
					num = 17;
					goto IL_A8;
				}
				goto IL_E5;
				IL_EE:
				if (num == 19)
				{
					string[] array2;
					string[] files2;
					StartupHelper.GetFolderStartupItemsHelper(ref list, array2, files2);
					num = 20;
				}
				if (num == 17)
				{
					string[] array2 = (from s in Directory.EnumerateFiles(StartupHelper.LocalMachineStartupFolder, "*.*", SearchOption.AllDirectories)
						where (s.EndsWith(".exe") ? (-3 + sizeof(float)) : (s.EndsWith(".bat") ? 1 : 0)) != 0
						select s).ToArray<string>();
					num = 18;
				}
				if (num == 15)
				{
					goto IL_162;
				}
				goto IL_174;
				IL_A8:
				if (num == 18)
				{
					string[] files2 = Directory.GetFiles(StartupHelper.LocalMachineStartupFolder, "*.lnk", SearchOption.AllDirectories);
					num = 19;
				}
				if (num == 21)
				{
					break;
				}
				if (num != 20)
				{
					goto IL_EE;
				}
				IL_E5:
				list2 = list;
				num = 21;
				goto IL_EE;
				IL_162:
				flag2 = Directory.Exists(StartupHelper.LocalMachineStartupFolder);
				num = 16;
				goto IL_174;
				IL_1F3:
				flag = Directory.Exists(StartupHelper.CurrentUserStartupFolder);
				num = 11;
				goto IL_204;
			}
			return list2;
		}

		// Token: 0x04000391 RID: 913
		internal static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000392 RID: 914
		internal static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		// Token: 0x04000393 RID: 915
		internal static readonly string LocalMachineRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

		// Token: 0x04000394 RID: 916
		internal static readonly string LocalMachineRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

		// Token: 0x04000395 RID: 917
		internal static readonly string LocalMachineRunWoW = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";

		// Token: 0x04000396 RID: 918
		internal static readonly string LocalMachineRunOnceWow = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

		// Token: 0x04000397 RID: 919
		internal static readonly string CurrentUserRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

		// Token: 0x04000398 RID: 920
		internal static readonly string CurrentUserRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

		// Token: 0x04000399 RID: 921
		internal static readonly string LocalMachineStartupFolder = StartupHelper.ProgramData + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

		// Token: 0x0400039A RID: 922
		internal static readonly string CurrentUserStartupFolder = StartupHelper.ProfileAppDataRoaming + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
	}
}
