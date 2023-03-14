using System;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000049 RID: 73
	public class Bios
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0008D6E8 File Offset: 0x0008B8E8
		public Bios()
		{
			this.BaseManufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardManufacturer);
			this.BaseProduct = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardProduct);
			this.BaseVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BaseBoardVersion);
			this.ReleaseDate = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosReleaseDate);
			this.BiosVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosVersion);
			this.BiosVendor = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.BiosVendor);
			this.SystemProductName = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemProductName);
			this.SystemManufacturer = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemManufacturer);
			this.SystemVersion = Untill.ReadRegistry(Registry.LocalMachine, WMIQuery.Bios.Query, WMIQuery.Bios.SystemVersion);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00002304 File Offset: 0x00000504
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000230C File Offset: 0x0000050C
		public string BaseManufacturer { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00002315 File Offset: 0x00000515
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000231D File Offset: 0x0000051D
		public string BaseProduct { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00002326 File Offset: 0x00000526
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000232E File Offset: 0x0000052E
		public string BaseVersion { get; private set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00002337 File Offset: 0x00000537
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000233F File Offset: 0x0000053F
		public string ReleaseDate { get; private set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00002348 File Offset: 0x00000548
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00002350 File Offset: 0x00000550
		public string BiosVersion { get; private set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00002359 File Offset: 0x00000559
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002361 File Offset: 0x00000561
		public string BiosVendor { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000236A File Offset: 0x0000056A
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002372 File Offset: 0x00000572
		public string SystemProductName { get; private set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000237B File Offset: 0x0000057B
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002383 File Offset: 0x00000583
		public string SystemManufacturer { get; private set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000238C File Offset: 0x0000058C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002394 File Offset: 0x00000594
		public string SystemVersion { get; private set; }
	}
}
