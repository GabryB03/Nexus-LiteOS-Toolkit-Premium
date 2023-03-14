using System;
using System.Management;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200004A RID: 74
	public class CPU
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0008D7E8 File Offset: 0x0008B9E8
		public CPU()
		{
			foreach (ManagementBaseObject managementBaseObject in WMIQuery.WMIExecQuery(WMIQuery.CPU.Query))
			{
				this.Name = managementBaseObject[WMIQuery.CPU.Name].ToString().Trim();
				this.CurrentClock = Convert.ToInt32(managementBaseObject[WMIQuery.CPU.MaxClock]);
				this.Voltage = Convert.ToDouble(managementBaseObject[WMIQuery.CPU.Voltage]) / 10.0;
				this.L2CacheSize = Convert.ToInt32(managementBaseObject[WMIQuery.CPU.L2CacheSize]);
				this.L3CacheSize = Convert.ToInt32(managementBaseObject[WMIQuery.CPU.L3CacheSize]);
				this.CoreCount = Convert.ToInt32(managementBaseObject[WMIQuery.CPU.NumberOfCores]);
				this.ThreadCount = Convert.ToInt32(managementBaseObject[WMIQuery.CPU.ThreadCount]);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000239D File Offset: 0x0000059D
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000023A5 File Offset: 0x000005A5
		public string Name { get; private set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000023AE File Offset: 0x000005AE
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000023B6 File Offset: 0x000005B6
		public int CurrentClock { get; private set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000023BF File Offset: 0x000005BF
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000023C7 File Offset: 0x000005C7
		public double Voltage { get; private set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000023D0 File Offset: 0x000005D0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000023D8 File Offset: 0x000005D8
		public int L2CacheSize { get; private set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000023E1 File Offset: 0x000005E1
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000023E9 File Offset: 0x000005E9
		public int L3CacheSize { get; private set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000023F2 File Offset: 0x000005F2
		// (set) Token: 0x0600034C RID: 844 RVA: 0x000023FA File Offset: 0x000005FA
		public int CoreCount { get; private set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00002403 File Offset: 0x00000603
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000240B File Offset: 0x0000060B
		public int ThreadCount { get; private set; }
	}
}
