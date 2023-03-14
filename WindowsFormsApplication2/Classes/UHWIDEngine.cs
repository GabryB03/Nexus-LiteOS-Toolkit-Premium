using System;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000046 RID: 70
	public static class UHWIDEngine
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000022E6 File Offset: 0x000004E6
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000022ED File Offset: 0x000004ED
		public static string SimpleUid { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000022F5 File Offset: 0x000004F5
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000022FC File Offset: 0x000004FC
		public static string AdvancedUid { get; private set; }

		// Token: 0x06000328 RID: 808 RVA: 0x0008D2D8 File Offset: 0x0008B4D8
		static UHWIDEngine()
		{
			string diskId = DiskId.GetDiskId();
			string cpuId = CpuId.GetCpuId();
			string windowsId = WindowsId.GetWindowsId();
			DiskId.GetDiskName();
			UHWIDEngine.SimpleUid = diskId + "-" + cpuId;
			UHWIDEngine.AdvancedUid = UHWIDEngine.SimpleUid + windowsId;
		}
	}
}
