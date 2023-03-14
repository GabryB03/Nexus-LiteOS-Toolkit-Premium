using System;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200003F RID: 63
	public class RegistryTools
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x0008B688 File Offset: 0x00089888
		public static bool ValueExists(RegistryKey RegistryKeyPath, string ValueName)
		{
			int num = 0;
			bool flag;
			do
			{
				if (num == 2)
				{
					flag = false;
					num = 3;
				}
				if (num == 1)
				{
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
				string[] valueNames = RegistryKeyPath.GetValueNames();
				flag = ArrayHelper.InArray(valueNames, ValueName);
			}
			catch
			{
			}
			return flag;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0008B710 File Offset: 0x00089910
		public static bool ValueExists(RegistryKey RootKey, string RegPath, string ValueName)
		{
			int num = 0;
			bool flag;
			do
			{
				if (num == 2)
				{
					flag = false;
					num = 3;
				}
				if (num == 1)
				{
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
				RegistryKey registryKey = RootKey.OpenSubKey(RegPath);
				if (registryKey != null)
				{
					string[] valueNames = registryKey.GetValueNames();
					registryKey.Close();
					flag = ArrayHelper.InArray(valueNames, ValueName);
				}
			}
			catch
			{
			}
			return flag;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0008B7AC File Offset: 0x000899AC
		public static bool KeyExists(RegistryKey RootKey, string RegistryPath)
		{
			int num = 0;
			bool flag;
			do
			{
				if (num == 2)
				{
					flag = false;
					num = 3;
				}
				if (num == 1)
				{
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
				RegistryKey registryKey = RootKey.OpenSubKey(RegistryPath);
				if (registryKey != null)
				{
					registryKey.Close();
					flag = true;
				}
			}
			catch
			{
			}
			return flag;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0008B83C File Offset: 0x00089A3C
		public static bool KeyExists(string FullPath)
		{
			int num = 0;
			bool flag;
			string text;
			string text2;
			do
			{
				if (num == 2)
				{
					flag = false;
					num = 3;
				}
				if (num == 4)
				{
					text = "";
					num = 5;
				}
				if (num == 7)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_D5;
					}
					num = 8;
				}
				if (num == 6)
				{
					bool flag2 = text2.Length > 0;
					num = 7;
				}
				if (num == 5)
				{
					RegistryTools.ParseKey(FullPath, out text2, out text);
					num = 6;
				}
				if (num == 3)
				{
					text2 = "";
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
			}
			while (num != 8);
			try
			{
				text2 = RegistryTools.ExpandRooKeyName(text2);
				RegistryKey registryKey = RegistryTools.StringToRegistryKey(text2, RegistryTools.RegistryAccessMode.Read);
				if (registryKey != null)
				{
					if (text.Length == 0)
					{
						registryKey.Close();
						bool flag3 = true;
						flag = true;
						return flag3;
					}
					flag = RegistryTools.KeyExists(registryKey, text);
					registryKey.Close();
				}
			}
			catch
			{
			}
			return flag;
			IL_D5:
			return flag;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0008B98C File Offset: 0x00089B8C
		public static string ExpandRooKeyName(string RootKeyString)
		{
			int num = 0;
			string text4;
			for (;;)
			{
				string text;
				if (num == 2)
				{
					text = RootKeyString.ToUpper();
					num = 3;
				}
				string text2;
				uint num2;
				if (num == 4)
				{
					num2 = <PrivateImplementationDetails>.ComputeStringHash(text2);
					num = 5;
				}
				if (num != 7)
				{
					goto IL_3D;
				}
				if (num2 != 457190004U)
				{
					num = 8;
					goto IL_3D;
				}
				goto IL_256;
				IL_11F:
				if (num == 20)
				{
					goto IL_1CC;
				}
				IL_1DD:
				if (num == 19)
				{
					goto IL_3F1;
				}
				if (num == 17)
				{
					goto IL_2F4;
				}
				if (num == 15)
				{
					goto IL_1B1;
				}
				IL_1BF:
				if (num == 13)
				{
					goto IL_14C;
				}
				IL_15D:
				string text3;
				if (num != 12)
				{
					if (num == 10)
					{
						goto IL_3F1;
					}
					if (num == 8)
					{
						goto IL_1F0;
					}
					if (num == 6)
					{
						if (num2 > 1097425318U)
						{
							goto IL_281;
						}
						num = 7;
					}
					if (num == 5)
					{
						if (num2 > 1568329430U)
						{
							goto IL_1B1;
						}
						num = 6;
					}
					if (num == 3)
					{
						text2 = text;
						num = 4;
					}
					if (num == 1)
					{
						text3 = "";
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 50)
					{
						break;
					}
					continue;
				}
				IL_14C:
				if (num2 != 1568329430U)
				{
					num = 14;
					goto IL_15D;
				}
				goto IL_324;
				IL_1B1:
				if (num2 <= 1713765061U)
				{
					num = 16;
					goto IL_1BF;
				}
				IL_1CC:
				if (num2 != 1923548787U)
				{
					num = 21;
					goto IL_1DD;
				}
				goto IL_2B4;
				IL_22E:
				if (num == 22)
				{
					goto IL_21B;
				}
				goto IL_11F;
				IL_203:
				if (!(text2 == "HKEY_CLASSES_ROOT"))
				{
					num = 25;
					goto IL_22E;
				}
				goto IL_382;
				IL_1F0:
				if (num2 != 1097425318U)
				{
					num = 10;
					goto IL_420;
				}
				goto IL_203;
				IL_3D:
				if (num == 9)
				{
					goto IL_1F0;
				}
				goto IL_420;
				IL_D8:
				if (num == 31 || num == 29 || num == 27 || num == 25)
				{
					goto IL_3F1;
				}
				if (num == 24)
				{
					goto IL_203;
				}
				goto IL_22E;
				IL_271:
				if (num == 32)
				{
					goto IL_256;
				}
				goto IL_D8;
				IL_2A7:
				if (num == 34)
				{
					goto IL_23E;
				}
				goto IL_271;
				IL_2C7:
				if (num == 36)
				{
					goto IL_294;
				}
				goto IL_2A7;
				IL_2B4:
				if (!(text2 == "HKU"))
				{
					num = 39;
					goto IL_2C7;
				}
				goto IL_2D4;
				IL_2E1:
				if (num == 45)
				{
					goto IL_3F1;
				}
				if (num == 43 || num == 41 || num == 39)
				{
					goto IL_3F1;
				}
				if (num == 38)
				{
					goto IL_2B4;
				}
				goto IL_2C7;
				IL_3DE:
				if (num == 46)
				{
					goto IL_2D4;
				}
				goto IL_2E1;
				IL_3F1:
				text4 = text3;
				num = 49;
				goto IL_3DE;
				IL_3FD:
				if (num == 21)
				{
					goto IL_21B;
				}
				if (num == 23)
				{
					goto IL_3F1;
				}
				if (num != 26)
				{
					goto IL_31A;
				}
				goto IL_307;
				IL_410:
				if (num == 14)
				{
					goto IL_3F1;
				}
				if (num == 16)
				{
					if (num2 == 1596321728U)
					{
						goto IL_341;
					}
					num = 17;
				}
				if (num == 18)
				{
					goto IL_2F4;
				}
				goto IL_3FD;
				IL_281:
				if (num2 != 1198714601U)
				{
					num = 12;
					goto IL_410;
				}
				goto IL_294;
				IL_2D4:
				text3 = "HKEY_USERS";
				num = 47;
				goto IL_2E1;
				IL_294:
				if (!(text2 == "HKEY_USERS"))
				{
					num = 37;
					goto IL_2A7;
				}
				goto IL_2D4;
				IL_23E:
				if (!(text2 == "HKLM"))
				{
					num = 35;
					goto IL_271;
				}
				goto IL_3B0;
				IL_21B:
				if (num2 != 2536015487U)
				{
					num = 23;
					goto IL_11F;
				}
				goto IL_23E;
				IL_256:
				if (!(text2 == "HKEY_LOCAL_MACHINE"))
				{
					num = 33;
					goto IL_D8;
				}
				goto IL_3B0;
				IL_354:
				if (num == 33 || num == 35 || num == 37)
				{
					goto IL_3F1;
				}
				if (num == 40)
				{
					goto IL_382;
				}
				goto IL_38F;
				IL_341:
				if (!(text2 == "HKCU"))
				{
					num = 31;
					goto IL_354;
				}
				goto IL_399;
				IL_337:
				if (num == 30)
				{
					goto IL_341;
				}
				goto IL_354;
				IL_324:
				if (!(text2 == "HKEY_CURRENT_USER"))
				{
					num = 29;
					goto IL_337;
				}
				goto IL_399;
				IL_31A:
				if (num == 28)
				{
					goto IL_324;
				}
				goto IL_337;
				IL_307:
				if (!(text2 == "HKCR"))
				{
					num = 27;
					goto IL_31A;
				}
				goto IL_382;
				IL_2F4:
				if (num2 != 1713765061U)
				{
					num = 19;
					goto IL_3FD;
				}
				goto IL_307;
				IL_3BD:
				if (num == 47)
				{
					goto IL_3F1;
				}
				if (num == 49)
				{
					break;
				}
				if (num != 48)
				{
					goto IL_3DE;
				}
				goto IL_3F1;
				IL_3B0:
				text3 = "HKEY_LOCAL_MACHINE";
				num = 45;
				goto IL_3BD;
				IL_3A6:
				if (num == 44)
				{
					goto IL_3B0;
				}
				goto IL_3BD;
				IL_399:
				text3 = "HKEY_CURRENT_USER";
				num = 43;
				goto IL_3A6;
				IL_38F:
				if (num == 42)
				{
					goto IL_399;
				}
				goto IL_3A6;
				IL_382:
				text3 = "HKEY_CLASSES_ROOT";
				num = 41;
				goto IL_38F;
				IL_420:
				if (num == 11)
				{
					goto IL_281;
				}
				goto IL_410;
			}
			return text4;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0008BE3C File Offset: 0x0008A03C
		public static void ParseKey(string FullPath, out string RootKey, out string SubKey)
		{
			int num = 0;
			string[] array;
			do
			{
				if (num == 2)
				{
					SubKey = "";
					num = 3;
				}
				if (num == 4)
				{
					RootKey = RegistryTools.ExpandRooKeyName(array[0]);
					num = 5;
				}
				if (num == 5)
				{
					if (RootKey.Length <= 0)
					{
						goto IL_E2;
					}
					num = 6;
				}
				if (num == 3)
				{
					array = FullPath.Split(new char[] { '\\' });
					num = 4;
				}
				if (num == 1)
				{
					RootKey = "";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			bool flag = array.Length > 1;
			goto IL_E7;
			IL_E2:
			flag = false;
			IL_E7:
			if (flag)
			{
				int num2 = 1;
				while (num2 < array.Length && array[num2].Length != 0)
				{
					SubKey += ((SubKey.Length == 0) ? array[num2] : ("\\" + array[num2]));
					num2++;
				}
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0008BF88 File Offset: 0x0008A188
		public static RegistryKey StringToRegistryKey(string FullPath, RegistryTools.RegistryAccessMode registryAccessMode)
		{
			int num = 0;
			string text2;
			RegistryKey registryKey;
			RegistryKey registryKey2;
			for (;;)
			{
				string text;
				if (num == 2)
				{
					text = "";
					num = 3;
				}
				if (num == 4)
				{
					RegistryTools.ParseKey(FullPath, out text, out text2);
					num = 5;
				}
				if (num == 7)
				{
					registryKey = null;
					num = 8;
				}
				if (num != 9)
				{
					goto IL_51;
				}
				bool flag;
				if (flag)
				{
					num = 10;
					goto IL_51;
				}
				goto IL_193;
				IL_11E:
				if (num == 22)
				{
					goto IL_17A;
				}
				IL_186:
				if (num == 20)
				{
					goto IL_14D;
				}
				IL_159:
				if (num == 19)
				{
					goto IL_193;
				}
				if (num == 17)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_193;
					}
					num = 18;
				}
				if (num == 15)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_14D;
					}
					num = 16;
				}
				if (num == 13)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_17A;
					}
					num = 14;
				}
				string text3;
				if (num == 12)
				{
					bool flag4 = !(text3 == "HKEY_CURRENT_USER");
					num = 13;
				}
				if (num == 10)
				{
					bool flag5 = !(text3 == "HKEY_CLASSES_ROOT");
					num = 11;
				}
				if (num == 8)
				{
					flag = (text3 = text) != null;
					num = 9;
				}
				if (num == 6)
				{
					bool flag6;
					if (!flag6)
					{
						return registryKey2;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag6 = text.Length > 0;
					num = 6;
				}
				if (num == 3)
				{
					text2 = "";
					num = 4;
				}
				if (num == 1)
				{
					registryKey2 = null;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 27)
				{
					break;
				}
				continue;
				IL_14D:
				registryKey = Registry.LocalMachine;
				num = 21;
				goto IL_159;
				IL_17A:
				registryKey = Registry.CurrentUser;
				num = 23;
				goto IL_186;
				IL_112:
				registryKey = Registry.ClassesRoot;
				num = 25;
				goto IL_11E;
				IL_51:
				if (num == 11)
				{
					bool flag5;
					if (!flag5)
					{
						goto IL_112;
					}
					num = 12;
				}
				if (num == 14)
				{
					bool flag3 = !(text3 == "HKEY_LOCAL_MACHINE");
					num = 15;
				}
				if (num == 16)
				{
					bool flag2 = text3 == "HKEY_USERS";
					num = 17;
				}
				if (num == 18)
				{
					registryKey = Registry.Users;
					num = 19;
				}
				if (num == 21 || num == 23)
				{
					goto IL_193;
				}
				if (num == 26)
				{
					if (text2.Length <= 0)
					{
						goto IL_2A8;
					}
					num = 27;
				}
				if (num == 25)
				{
					goto IL_193;
				}
				IL_108:
				if (num == 24)
				{
					goto IL_112;
				}
				goto IL_11E;
				IL_193:
				registryKey2 = registryKey;
				num = 26;
				goto IL_108;
			}
			bool flag7 = registryKey2 != null;
			goto IL_2AD;
			IL_2A8:
			flag7 = false;
			IL_2AD:
			if (flag7)
			{
				try
				{
					if (registryAccessMode == RegistryTools.RegistryAccessMode.Create)
					{
						registryKey2 = registryKey.CreateSubKey(text2);
					}
					else
					{
						registryKey2 = registryKey.OpenSubKey(text2, registryAccessMode == RegistryTools.RegistryAccessMode.Write);
					}
				}
				catch
				{
					registryKey.Close();
					registryKey2 = null;
				}
			}
			registryKey.Close();
			return registryKey2;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0008C29C File Offset: 0x0008A49C
		public static void ParseKeyToExistedPart(string FullPath, out string RootKey, out string SubKey)
		{
			int num = 0;
			string[] array;
			RegistryKey registryKey;
			int num2;
			do
			{
				if (num == 2)
				{
					SubKey = "";
					num = 3;
				}
				if (num == 4)
				{
					RootKey = RegistryTools.ExpandRooKeyName(array[0]);
					num = 5;
				}
				if (num == 7)
				{
					registryKey = RegistryTools.StringToRegistryKey(RootKey, RegistryTools.RegistryAccessMode.Read);
					num = 8;
				}
				if (num == 9)
				{
					bool flag;
					if (!flag)
					{
						return;
					}
					num = 10;
				}
				if (num == 11)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_20F;
					}
					num = 12;
				}
				if (num == 14)
				{
					goto IL_1F6;
				}
				if (num == 13)
				{
					num2 = 1;
					num = 14;
				}
				if (num == 12)
				{
					num = 13;
				}
				if (num == 10)
				{
					bool flag2 = array.Length > 1;
					num = 11;
				}
				if (num == 8)
				{
					bool flag = registryKey != null;
					num = 9;
				}
				if (num == 6)
				{
					bool flag3;
					if (!flag3)
					{
						return;
					}
					num = 7;
				}
				if (num == 5)
				{
					bool flag3 = RootKey.Length > 0;
					num = 6;
				}
				if (num == 3)
				{
					array = FullPath.Split(new char[] { '\\' });
					num = 4;
				}
				if (num == 1)
				{
					RootKey = "";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 15);
			IL_1A8:
			string text = SubKey + ((SubKey.Length != 0) ? ("\\" + array[num2]) : array[num2]);
			if (!RegistryTools.KeyExists(registryKey, text))
			{
				goto IL_20F;
			}
			SubKey = text;
			num2++;
			IL_1F6:
			if (num2 < array.Length && array[num2].Length != 0)
			{
				goto IL_1A8;
			}
			IL_20F:
			registryKey.Close();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0008C4C0 File Offset: 0x0008A6C0
		public static void DeleteSubKeyTree(ref RegistryKey reg, string SubKeyToDelete)
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
				reg.DeleteSubKeyTree(SubKeyToDelete);
			}
			catch
			{
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0008C524 File Offset: 0x0008A724
		public static void AddSeparatorAbove(ref RegistryKey reg)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					reg.SetValue("CommandFlags", 32, RegistryValueKind.DWord);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000137E0 File Offset: 0x000119E0
		public static void DeleteRegValues(string[] values, RegistryKey key)
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
					goto IL_33;
				}
				IL_3D:
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
						key.DeleteValue(text);
					}
					catch
					{
					}
					num2++;
					goto IL_2D;
				}
				continue;
				IL_33:
				text = values[num2];
				num = 6;
				goto IL_3D;
				IL_2D:
				if (num2 < values.Length)
				{
					goto IL_33;
				}
				break;
			}
		}

		// Token: 0x02000040 RID: 64
		public enum RegistryAccessMode
		{
			// Token: 0x0400038E RID: 910
			Read,
			// Token: 0x0400038F RID: 911
			Write,
			// Token: 0x04000390 RID: 912
			Create
		}
	}
}
