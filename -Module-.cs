using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsDebuggerPresent();

	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x06000003 RID: 3
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x06000004 RID: 4 RVA: 0x00003018 File Offset: 0x00001218
	public static void AntiDebugCheck()
	{
		bool flag = false;
		<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag);
		if (<Module>.IsDebuggerPresent() || Debugger.IsAttached || flag)
		{
			Environment.Exit(0);
		}
		try
		{
			<Module>.CloseHandle((IntPtr)4657);
		}
		catch (Exception)
		{
			Environment.Exit(0);
		}
	}

	// Token: 0x06000005 RID: 5
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	// Token: 0x06000006 RID: 6 RVA: 0x00003090 File Offset: 0x00001290
	public static bool IsEmulated()
	{
		long num = (long)Environment.TickCount;
		Thread.Sleep(500);
		long num2 = (long)Environment.TickCount;
		return num2 - num < 500L;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000030D4 File Offset: 0x000012D4
	public static bool IsModulePresent(string string_0)
	{
		return <Module>.GetModuleHandle(string_0) != IntPtr.Zero;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00003108 File Offset: 0x00001308
	public static bool CheckForVMwareAndVirtualBox()
	{
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
		{
			using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					string text = managementBaseObject["Manufacturer"].ToString().ToLower();
					string text2 = managementBaseObject["Model"].ToString();
					if ((text == "microsoft corporation" && text2.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware"))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00003200 File Offset: 0x00001400
	public static void AntiVMCheck()
	{
		string[] array = new string[] { "SbieDll.dll", "cmdvrt32.dll", "SxIn.dll", "cuckoomon.dll" };
		for (int i = 0; i < array.Length; i++)
		{
			if (<Module>.IsModulePresent(array[i]))
			{
				Environment.Exit(0);
			}
		}
		if (<Module>.CheckForVMwareAndVirtualBox() || <Module>.IsEmulated())
		{
			Environment.Exit(0);
		}
	}
}
