using System;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200004E RID: 78
	internal class RAM
	{
		// Token: 0x06000380 RID: 896 RVA: 0x0008DB50 File Offset: 0x0008BD50
		public RAM()
		{
			foreach (ManagementBaseObject managementBaseObject in WMIQuery.WMIExecQuery(WMIQuery.RAM.Query))
			{
				this.Speed = managementBaseObject[WMIQuery.RAM.Speed].ToString();
				this.Voltage = managementBaseObject[WMIQuery.RAM.ConfiguredVoltage].ToString().Insert(1, ".");
				this.Manufacturer = managementBaseObject[WMIQuery.RAM.Manufacturer].ToString();
			}
			this.PysicalSize = RAM.info.TotalPhysicalMemory;
			this.VirtualSize = RAM.info.TotalVirtualMemory;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000025B7 File Offset: 0x000007B7
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000025BF File Offset: 0x000007BF
		public ulong PysicalSize { get; private set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000025D0 File Offset: 0x000007D0
		public ulong VirtualSize { get; private set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000025D9 File Offset: 0x000007D9
		public ulong AvailablePhysicalSize
		{
			get
			{
				return RAM.info.AvailablePhysicalMemory;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000386 RID: 902 RVA: 0x000025E5 File Offset: 0x000007E5
		public ulong AvailableVirtualSize
		{
			get
			{
				return RAM.info.AvailableVirtualMemory;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000025F1 File Offset: 0x000007F1
		// (set) Token: 0x06000388 RID: 904 RVA: 0x000025F9 File Offset: 0x000007F9
		public string Speed { get; private set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00002602 File Offset: 0x00000802
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000260A File Offset: 0x0000080A
		public string Voltage { get; private set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00002613 File Offset: 0x00000813
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000261B File Offset: 0x0000081B
		public string Manufacturer { get; private set; }

		// Token: 0x040003CD RID: 973
		private static readonly ComputerInfo info = new ComputerInfo();
	}
}
