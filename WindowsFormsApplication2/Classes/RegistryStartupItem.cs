using System;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000045 RID: 69
	internal class RegistryStartupItem : StartupItem
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000022D5 File Offset: 0x000004D5
		// (set) Token: 0x0600031E RID: 798 RVA: 0x000022DD File Offset: 0x000004DD
		internal RegistryKey Key { get; set; }

		// Token: 0x0600031F RID: 799 RVA: 0x0008D05C File Offset: 0x0008B25C
		internal override void LocateKey()
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
				Utils.FindKeyInRegistry(this.Key.ToString());
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0008D0B8 File Offset: 0x0008B2B8
		internal override void Remove()
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
				this.Key.DeleteValue(base.Name, false);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0008D120 File Offset: 0x0008B320
		internal override void LocateFile()
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
				Utils.FindFile(this.SanitizePath(base.FileLocation));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0008D180 File Offset: 0x0008B380
		internal string SanitizePath(string s)
		{
			int num = 0;
			string text;
			for (;;)
			{
				if (num == 1)
				{
					s = s.Replace("\"", string.Empty);
					num = 2;
				}
				if (num == 2)
				{
					goto IL_4E;
				}
				if (num == 3)
				{
					goto IL_20;
				}
				goto IL_35;
				IL_3F:
				bool flag;
				if (num == 6)
				{
					if (flag)
					{
						goto IL_20;
					}
					num = 7;
				}
				int num2;
				if (num == 7)
				{
					num2 = s.IndexOf(".exe");
					num = 8;
				}
				if (num == 8)
				{
					s = s.Substring(0, num2 + 4);
					num = 9;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 9)
				{
					text = s.Trim();
					num = 10;
				}
				if (num == 4)
				{
					s = s.Substring(0, num2);
					num = 5;
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
				IL_35:
				if (num != 5)
				{
					goto IL_3F;
				}
				IL_4E:
				flag = s.Contains("/");
				num = 6;
				goto IL_3F;
				IL_20:
				num2 = s.LastIndexOf("/");
				num = 4;
				goto IL_35;
			}
			return text;
		}
	}
}
