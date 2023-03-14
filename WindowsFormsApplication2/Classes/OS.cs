using System;
using System.Management;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200004D RID: 77
	internal class OS
	{
		// Token: 0x06000367 RID: 871 RVA: 0x0008DA10 File Offset: 0x0008BC10
		public OS()
		{
			foreach (ManagementBaseObject managementBaseObject in WMIQuery.WMIExecQuery(WMIQuery.OS.Query))
			{
				this.Caption = managementBaseObject[WMIQuery.OS.Caption].ToString();
				this.Architecture = managementBaseObject[WMIQuery.OS.Architecture].ToString();
				this.BuildNumber = managementBaseObject[WMIQuery.OS.BuildNumber].ToString();
				this.Version = managementBaseObject[WMIQuery.OS.Version].ToString();
				this.SerialNumber = managementBaseObject[WMIQuery.OS.SerialNumber].ToString();
				this.LastBootUpTime = managementBaseObject[WMIQuery.OS.LastBootUpTime].ToString();
				this.ContryCode = managementBaseObject[WMIQuery.OS.CountryCode].ToString();
				this.CurrentTimeZone = managementBaseObject[WMIQuery.OS.CurrentTimeZone].ToString();
				string[] array = (string[])managementBaseObject[WMIQuery.OS.MUILanguages];
				this.Language = managementBaseObject[WMIQuery.OS.Language].ToString();
				this.InstallTime = ManagementDateTimeConverter.ToDateTime(managementBaseObject[WMIQuery.OS.InstallDate].ToString());
				this.MUILanguages = string.Join(", ", array);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000024EB File Offset: 0x000006EB
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000024F3 File Offset: 0x000006F3
		public string Caption { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000024FC File Offset: 0x000006FC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00002504 File Offset: 0x00000704
		public string Architecture { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000250D File Offset: 0x0000070D
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00002515 File Offset: 0x00000715
		public string BuildNumber { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000251E File Offset: 0x0000071E
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00002526 File Offset: 0x00000726
		public string Version { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000252F File Offset: 0x0000072F
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00002537 File Offset: 0x00000737
		public string SerialNumber { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00002540 File Offset: 0x00000740
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00002548 File Offset: 0x00000748
		public string ProductKey { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00002551 File Offset: 0x00000751
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00002559 File Offset: 0x00000759
		public string ContryCode { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00002562 File Offset: 0x00000762
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000256A File Offset: 0x0000076A
		public string CurrentTimeZone { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00002573 File Offset: 0x00000773
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0000257B File Offset: 0x0000077B
		public string MUILanguages { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00002584 File Offset: 0x00000784
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000258C File Offset: 0x0000078C
		public string Language { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002595 File Offset: 0x00000795
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0000259D File Offset: 0x0000079D
		public string LastBootUpTime { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000025A6 File Offset: 0x000007A6
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000025AE File Offset: 0x000007AE
		public DateTime InstallTime { get; set; }
	}
}
