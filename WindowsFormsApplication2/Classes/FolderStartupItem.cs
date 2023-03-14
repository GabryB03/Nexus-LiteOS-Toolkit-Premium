using System;
using System.IO;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000044 RID: 68
	internal class FolderStartupItem : StartupItem
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000022BC File Offset: 0x000004BC
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000022C4 File Offset: 0x000004C4
		internal string Shortcut { get; set; }

		// Token: 0x0600031A RID: 794 RVA: 0x0008CF9C File Offset: 0x0008B19C
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
				if (File.Exists(this.Shortcut))
				{
					File.Delete(this.Shortcut);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0008D004 File Offset: 0x0008B204
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
				Utils.FindFile(base.FileLocation);
			}
			catch (Exception)
			{
			}
		}
	}
}
