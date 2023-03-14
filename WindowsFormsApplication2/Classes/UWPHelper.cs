using System;
using System.Collections.Generic;
using System.Management.Automation;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000047 RID: 71
	internal static class UWPHelper
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0008D320 File Offset: 0x0008B520
		internal static List<KeyValuePair<string, string>> GetUWPApps()
		{
			int num = 0;
			List<KeyValuePair<string, string>> list;
			PowerShell powerShell;
			do
			{
				if (num == 1)
				{
					list = new List<KeyValuePair<string, string>>();
					num = 2;
				}
				if (num == 2)
				{
					powerShell = PowerShell.Create();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				powerShell.AddScript("Get-AppxPackage | Where {$_.NonRemovable -like \"False\"} | Select  Name,InstallLocation");
				foreach (PSObject psobject in powerShell.Invoke())
				{
					string[] array = psobject.ToString().Replace("@", string.Empty).Replace("{", string.Empty)
						.Replace("}", string.Empty)
						.Replace("Name=", string.Empty)
						.Replace("InstallLocation=", string.Empty)
						.Trim()
						.Split(new char[] { ';' });
					list.Add(new KeyValuePair<string, string>(array[0], array[1]));
				}
			}
			finally
			{
				if (powerShell != null)
				{
					((IDisposable)powerShell).Dispose();
				}
			}
			return list;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0008D47C File Offset: 0x0008B67C
		internal static bool UninstallUWPApp(string appName)
		{
			int num = 0;
			PowerShell powerShell;
			do
			{
				if (num == 1)
				{
					powerShell = PowerShell.Create();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag;
			try
			{
				powerShell.AddScript(string.Format("Get-AppxPackage -AllUsers '{0}' | Remove-AppxPackage", appName));
				powerShell.Invoke();
				flag = powerShell.Streams.Error.Count > 0;
			}
			finally
			{
				if (powerShell != null)
				{
					((IDisposable)powerShell).Dispose();
				}
			}
			return flag;
		}
	}
}
