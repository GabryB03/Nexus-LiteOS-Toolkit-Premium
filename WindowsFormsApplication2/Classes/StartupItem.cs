using System;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000043 RID: 67
	internal class StartupItem
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00002278 File Offset: 0x00000478
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002280 File Offset: 0x00000480
		internal string Name { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00002289 File Offset: 0x00000489
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00002291 File Offset: 0x00000491
		internal string FileLocation { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000229A File Offset: 0x0000049A
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000022A2 File Offset: 0x000004A2
		internal StartupItemLocation RegistryLocation { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000022AB File Offset: 0x000004AB
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000022B3 File Offset: 0x000004B3
		internal StartupItemType StartupType { get; set; }

		// Token: 0x06000313 RID: 787 RVA: 0x00003804 File Offset: 0x00001A04
		internal virtual void Remove()
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
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003804 File Offset: 0x00001A04
		internal virtual void LocateFile()
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
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003804 File Offset: 0x00001A04
		internal virtual void LocateKey()
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
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0008CE9C File Offset: 0x0008B09C
		public override string ToString()
		{
			int num = 0;
			string text;
			for (;;)
			{
				if (num != 2)
				{
					goto IL_0B;
				}
				bool flag;
				if (flag)
				{
					num = 3;
					goto IL_0B;
				}
				goto IL_40;
				IL_6D:
				if (num == 5)
				{
					break;
				}
				if (num == 3)
				{
					StartupItemLocation registryLocation = this.RegistryLocation;
					num = 4;
				}
				if (num == 1)
				{
					flag = this.RegistryLocation == StartupItemLocation.Folder;
					num = 2;
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
				IL_0B:
				if (num == 4)
				{
					StartupItemLocation registryLocation;
					text = registryLocation.ToString();
					num = 5;
				}
				if (num == 7)
				{
					break;
				}
				if (num != 6)
				{
					goto IL_6D;
				}
				IL_40:
				text = string.Format("{0}:{1}", this.RegistryLocation, this.StartupType);
				num = 7;
				goto IL_6D;
			}
			return text;
		}
	}
}
