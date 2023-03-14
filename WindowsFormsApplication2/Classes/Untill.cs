using System;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000031 RID: 49
	public class Untill
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00088AE8 File Offset: 0x00086CE8
		public static string ReadRegistry(RegistryKey key, string root, string subkey)
		{
			int num = 0;
			string text;
			while (num != 12)
			{
				if (num == 11)
				{
					goto IL_3C;
				}
				IL_48:
				if (num == 10)
				{
					break;
				}
				object value;
				if (num == 9)
				{
					text = Convert.ToString(value);
					num = 10;
				}
				if (num == 8)
				{
					bool flag;
					if (!flag)
					{
						goto IL_3C;
					}
					num = 9;
				}
				if (num == 7)
				{
					bool flag = value != null;
					num = 8;
				}
				if (num == 6)
				{
					goto IL_A4;
				}
				IL_B8:
				if (num == 5)
				{
					break;
				}
				if (num == 4)
				{
					text = "null";
					num = 5;
				}
				if (num == 3)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_A4;
					}
					num = 4;
				}
				if (num == 2)
				{
					bool flag2 = key == null;
					num = 3;
				}
				if (num == 1)
				{
					key = key.OpenSubKey(root, false);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 13)
				{
					continue;
				}
				break;
				IL_A4:
				value = key.GetValue(subkey);
				num = 7;
				goto IL_B8;
				IL_3C:
				text = "null";
				num = 12;
				goto IL_48;
			}
			return text;
		}
	}
}
