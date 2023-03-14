using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000032 RID: 50
	public static class WMIQuery
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00088C28 File Offset: 0x00086E28
		public static IEnumerable<ManagementBaseObject> WMIExecQuery(string query)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			WMIQuery.<WMIExecQuery>d__0 <WMIExecQuery>d__ = new WMIQuery.<WMIExecQuery>d__0(-2);
			<WMIExecQuery>d__.<>3__query = query;
			return <WMIExecQuery>d__;
		}

		// Token: 0x02000033 RID: 51
		public static class CPU
		{
			// Token: 0x04000330 RID: 816
			public static readonly string Query = "select * from  Win32_Processor";

			// Token: 0x04000331 RID: 817
			public static readonly string Name = "Name";

			// Token: 0x04000332 RID: 818
			public static readonly string MaxClock = "MaxClockSpeed";

			// Token: 0x04000333 RID: 819
			public static readonly string Voltage = "CurrentVoltage";

			// Token: 0x04000334 RID: 820
			public static readonly string L2CacheSize = "L2CacheSize";

			// Token: 0x04000335 RID: 821
			public static readonly string L3CacheSize = "L3CacheSize";

			// Token: 0x04000336 RID: 822
			public static readonly string NumberOfCores = "NumberOfCores";

			// Token: 0x04000337 RID: 823
			public static readonly string ThreadCount = "ThreadCount";
		}

		// Token: 0x02000034 RID: 52
		public static class Bios
		{
			// Token: 0x04000338 RID: 824
			public static readonly string Query = "HARDWARE\\DESCRIPTION\\System\\BIOS";

			// Token: 0x04000339 RID: 825
			public static readonly string BaseBoardManufacturer = "BaseBoardManufacturer";

			// Token: 0x0400033A RID: 826
			public static readonly string BaseBoardProduct = "BaseBoardProduct";

			// Token: 0x0400033B RID: 827
			public static readonly string BaseBoardVersion = "BaseBoardVersion";

			// Token: 0x0400033C RID: 828
			public static readonly string BiosReleaseDate = "BIOSReleaseDate";

			// Token: 0x0400033D RID: 829
			public static readonly string BiosVersion = "BIOSVersion";

			// Token: 0x0400033E RID: 830
			public static readonly string BiosVendor = "BIOSVendor";

			// Token: 0x0400033F RID: 831
			public static readonly string SystemProductName = "SystemProductName";

			// Token: 0x04000340 RID: 832
			public static readonly string SystemManufacturer = "SystemManufacturer";

			// Token: 0x04000341 RID: 833
			public static readonly string SystemVersion = "SystemVersion";
		}

		// Token: 0x02000035 RID: 53
		public static class RAM
		{
			// Token: 0x04000342 RID: 834
			public static readonly string Query = "select * from  Win32_PhysicalMemory";

			// Token: 0x04000343 RID: 835
			public static readonly string Speed = "Speed";

			// Token: 0x04000344 RID: 836
			public static readonly string ConfiguredVoltage = "ConfiguredVoltage";

			// Token: 0x04000345 RID: 837
			public static readonly string Manufacturer = "Manufacturer";
		}

		// Token: 0x02000036 RID: 54
		public static class Disk
		{
			// Token: 0x04000346 RID: 838
			public static readonly string DiskDriveQuery = "select * from  Win32_DiskDrive";

			// Token: 0x04000347 RID: 839
			public static readonly string LogicalDiskQuery = "select * from  Win32_LogicalDisk";

			// Token: 0x04000348 RID: 840
			public static readonly string LogicalToPartitionQuery = "select * from  Win32_LogicalDiskToPartition";

			// Token: 0x04000349 RID: 841
			public static readonly string Caption = "Caption";

			// Token: 0x0400034A RID: 842
			public static readonly string DeviceID = "DeviceID";

			// Token: 0x0400034B RID: 843
			public static readonly string Model = "Model";

			// Token: 0x0400034C RID: 844
			public static readonly string FileSystem = "FileSystem";

			// Token: 0x0400034D RID: 845
			public static readonly string VolumeName = "VolumeName";

			// Token: 0x0400034E RID: 846
			public static readonly string Size = "Size";

			// Token: 0x0400034F RID: 847
			public static readonly string FreeSpace = "FreeSpace";

			// Token: 0x04000350 RID: 848
			public static readonly string Status = "Status";

			// Token: 0x04000351 RID: 849
			public static readonly string SystemName = "SystemName";

			// Token: 0x04000352 RID: 850
			public static readonly string Name = "Name";

			// Token: 0x04000353 RID: 851
			public static readonly string SerialNumber = "SerialNumber";

			// Token: 0x04000354 RID: 852
			public static readonly string VolumeSerialNumber = "VolumeSerialNumber";

			// Token: 0x04000355 RID: 853
			public static readonly string Signature = "Signature";
		}

		// Token: 0x02000037 RID: 55
		public static class GPU
		{
			// Token: 0x04000356 RID: 854
			public static readonly string Query = "select * from  Win32_VideoController";

			// Token: 0x04000357 RID: 855
			public static readonly string AdapterCompatibility = "AdapterCompatibility";

			// Token: 0x04000358 RID: 856
			public static readonly string AdapterRAM = "AdapterRAM";

			// Token: 0x04000359 RID: 857
			public static readonly string Caption = "Caption";

			// Token: 0x0400035A RID: 858
			public static readonly string CurrentRefreshRate = "CurrentRefreshRate";

			// Token: 0x0400035B RID: 859
			public static readonly string DriverDate = "DriverDate";

			// Token: 0x0400035C RID: 860
			public static readonly string DriverVersion = "DriverVersion";

			// Token: 0x0400035D RID: 861
			public static readonly string MaxRefreshRate = "MaxRefreshRate";

			// Token: 0x0400035E RID: 862
			public static readonly string MinRefreshRate = "MinRefreshRate";

			// Token: 0x0400035F RID: 863
			public static readonly string VideoProcessor = "VideoProcessor";

			// Token: 0x04000360 RID: 864
			public static readonly string VideoModeDescription = "VideoModeDescription";
		}

		// Token: 0x02000038 RID: 56
		public static class OS
		{
			// Token: 0x04000361 RID: 865
			public static readonly string Query = "select * from  Win32_OperatingSystem";

			// Token: 0x04000362 RID: 866
			public static readonly string Caption = "Caption";

			// Token: 0x04000363 RID: 867
			public static readonly string Architecture = "OSArchitecture";

			// Token: 0x04000364 RID: 868
			public static readonly string BuildNumber = "BuildNumber";

			// Token: 0x04000365 RID: 869
			public static readonly string Version = "Version";

			// Token: 0x04000366 RID: 870
			public static readonly string SerialNumber = "SerialNumber";

			// Token: 0x04000367 RID: 871
			public static readonly string LastBootUpTime = "LastBootUpTime";

			// Token: 0x04000368 RID: 872
			public static readonly string CountryCode = "CountryCode";

			// Token: 0x04000369 RID: 873
			public static readonly string CurrentTimeZone = "CurrentTimeZone";

			// Token: 0x0400036A RID: 874
			public static readonly string MUILanguages = "MUILanguages";

			// Token: 0x0400036B RID: 875
			public static readonly string Language = "OSLanguage";

			// Token: 0x0400036C RID: 876
			public static readonly string InstallDate = "InstallDate";
		}
	}
}
