using System;
using System.Management;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200003C RID: 60
	internal class DiskId
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0008A858 File Offset: 0x00088A58
		public static string GetDiskId()
		{
			int num = 0;
			string diskId;
			while (num != 2)
			{
				if (num == 1)
				{
					diskId = DiskId.GetDiskId("");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return diskId;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		public static string GetDiskName()
		{
			int num = 0;
			string diskName;
			while (num != 2)
			{
				if (num == 1)
				{
					diskName = DiskId.GetDiskName("");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return diskName;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0008A938 File Offset: 0x00088B38
		public static string GetDiskType()
		{
			int num = 0;
			string diskType;
			while (num != 2)
			{
				if (num == 1)
				{
					diskType = DiskId.GetDiskType("");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return diskType;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0008A9A8 File Offset: 0x00088BA8
		private static string GetDiskId(string diskLetter)
		{
			int num = 0;
			ManagementObjectCollection.ManagementObjectEnumerator enumerator;
			do
			{
				if (num == 2)
				{
					ManagementObjectSearcher managementObjectSearcher;
					enumerator = managementObjectSearcher.Get().GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject["SerialNumber"] != null)
					{
						return managementObject["SerialNumber"].ToString();
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return string.Empty;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0008AA74 File Offset: 0x00088C74
		private static string GetDiskName(string diskLetter)
		{
			int num = 0;
			ManagementObjectCollection.ManagementObjectEnumerator enumerator;
			do
			{
				if (num == 2)
				{
					ManagementObjectSearcher managementObjectSearcher;
					enumerator = managementObjectSearcher.Get().GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject["Model"] != null)
					{
						return managementObject["Model"].ToString();
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return string.Empty;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0008AB40 File Offset: 0x00088D40
		private static string GetDiskType(string diskLetter)
		{
			int num = 0;
			ManagementObjectCollection.ManagementObjectEnumerator enumerator;
			do
			{
				if (num == 2)
				{
					ManagementObjectSearcher managementObjectSearcher;
					enumerator = managementObjectSearcher.Get().GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject["InterfaceType"] != null)
					{
						return managementObject["InterfaceType"].ToString();
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return string.Empty;
		}
	}
}
