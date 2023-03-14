using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000048 RID: 72
	internal class WindowsId
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0008D518 File Offset: 0x0008B718
		public static string GetWindowsId()
		{
			int num = 0;
			string text;
			ManagementObjectCollection.ManagementObjectEnumerator enumerator;
			bool flag;
			do
			{
				if (num == 1)
				{
					text = "";
					num = 2;
				}
				ManagementObjectSearcher managementObjectSearcher;
				if (num == 2)
				{
					managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
					num = 3;
				}
				ManagementObjectCollection managementObjectCollection;
				if (num == 3)
				{
					managementObjectCollection = managementObjectSearcher.Get();
					num = 4;
				}
				if (num == 5)
				{
					enumerator = managementObjectCollection.GetEnumerator();
					num = 6;
				}
				if (num == 4)
				{
					flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object value = managementObject.Properties["Caption"].Value;
					text = ((value != null) ? value.ToString() : null) + Environment.UserName + (string)managementObject.Properties["Version"].Value;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			text = text.Replace(" ", "");
			text = text.Replace("Windows", "");
			text = text.Replace("windows", "");
			text += (flag ? " 64bit" : " 32bit");
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.Default.GetBytes(text));
			return BitConverter.ToString(array).Replace("-", "");
		}
	}
}
