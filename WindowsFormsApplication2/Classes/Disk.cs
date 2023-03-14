using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200004B RID: 75
	internal class Disk
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00002414 File Offset: 0x00000614
		public Disk()
		{
			this.VolumeList = new List<DriveInfo>(DriveInfo.GetDrives());
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000242C File Offset: 0x0000062C
		public int VolumeCount
		{
			get
			{
				return this.VolumeList.Count;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00002439 File Offset: 0x00000639
		public List<DriveInfo> VolumeList { get; }
	}
}
