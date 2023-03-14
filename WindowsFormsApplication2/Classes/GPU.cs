using System;
using System.Management;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200004C RID: 76
	internal class GPU
	{
		// Token: 0x06000352 RID: 850 RVA: 0x0008D8CC File Offset: 0x0008BACC
		public GPU()
		{
			foreach (ManagementBaseObject managementBaseObject in WMIQuery.WMIExecQuery(WMIQuery.GPU.Query))
			{
				this.AdapterCompatiability = managementBaseObject[WMIQuery.GPU.AdapterCompatibility].ToString();
				this.AdapterRAM = managementBaseObject[WMIQuery.GPU.AdapterRAM].ToString();
				this.Caption = managementBaseObject[WMIQuery.GPU.Caption].ToString();
				this.CurrentRefreshRate = managementBaseObject[WMIQuery.GPU.CurrentRefreshRate].ToString();
				this.DriverDate = managementBaseObject[WMIQuery.GPU.DriverDate].ToString();
				this.DriverVersion = managementBaseObject[WMIQuery.GPU.DriverVersion].ToString();
				this.MaxRefreshRate = managementBaseObject[WMIQuery.GPU.MaxRefreshRate].ToString();
				this.MinRefreshRate = managementBaseObject[WMIQuery.GPU.MinRefreshRate].ToString();
				this.VideoModeDescription = managementBaseObject[WMIQuery.GPU.VideoModeDescription].ToString();
				this.VideoProcessor = managementBaseObject[WMIQuery.GPU.VideoProcessor].ToString();
			}
			this.DriverDate = this.DriverDate.Split(new char[] { '.' })[0];
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00002441 File Offset: 0x00000641
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00002449 File Offset: 0x00000649
		public string AdapterCompatiability { get; private set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00002452 File Offset: 0x00000652
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000245A File Offset: 0x0000065A
		public string AdapterRAM { get; private set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00002463 File Offset: 0x00000663
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0000246B File Offset: 0x0000066B
		public string Caption { get; private set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00002474 File Offset: 0x00000674
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0000247C File Offset: 0x0000067C
		public string CurrentRefreshRate { get; private set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00002485 File Offset: 0x00000685
		// (set) Token: 0x0600035C RID: 860 RVA: 0x0000248D File Offset: 0x0000068D
		public string DriverDate { get; private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00002496 File Offset: 0x00000696
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0000249E File Offset: 0x0000069E
		public string DriverVersion { get; private set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000024A7 File Offset: 0x000006A7
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000024AF File Offset: 0x000006AF
		public string MaxRefreshRate { get; private set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000361 RID: 865 RVA: 0x000024B8 File Offset: 0x000006B8
		// (set) Token: 0x06000362 RID: 866 RVA: 0x000024C0 File Offset: 0x000006C0
		public string MinRefreshRate { get; private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000024C9 File Offset: 0x000006C9
		// (set) Token: 0x06000364 RID: 868 RVA: 0x000024D1 File Offset: 0x000006D1
		public string VideoModeDescription { get; private set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000024DA File Offset: 0x000006DA
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000024E2 File Offset: 0x000006E2
		public string VideoProcessor { get; private set; }
	}
}
