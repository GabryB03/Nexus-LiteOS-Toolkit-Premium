using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200003D RID: 61
	public static class context_class
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0008AC0C File Offset: 0x00088E0C
		private static T DirectCast<T>(object o)
		{
			int num = 0;
			T t;
			while (num != 2)
			{
				if (num == 1)
				{
					t = (T)((object)o);
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
			return t;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0008AC7C File Offset: 0x00088E7C
		internal static void CreateCustomCommand(string file, string keyword)
		{
			int num = 0;
			for (;;)
			{
				if (num != 2)
				{
					goto IL_0B;
				}
				bool flag;
				if (flag)
				{
					num = 3;
					goto IL_0B;
				}
				goto IL_15;
				IL_2A:
				string text;
				if (num == 7)
				{
					Registry.SetValue(text, "Path", file.Substring(0, file.LastIndexOf("\\")));
					num = 8;
				}
				if (num == 6)
				{
					Registry.SetValue(text, "", file);
					num = 7;
				}
				if (num == 5)
				{
					Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\" + keyword);
					num = 6;
				}
				if (num == 3)
				{
					keyword += ".exe";
					num = 4;
				}
				if (num == 1)
				{
					flag = !keyword.EndsWith(".exe");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 8)
				{
					break;
				}
				continue;
				IL_0B:
				if (num != 4)
				{
					goto IL_2A;
				}
				IL_15:
				text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\" + keyword;
				num = 5;
				goto IL_2A;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0008ADB8 File Offset: 0x00088FB8
		internal static List<string> GetCustomCommands()
		{
			int num = 0;
			RegistryKey registryKey;
			List<string> list;
			do
			{
				if (num == 2)
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\");
					num = 3;
				}
				if (num == 1)
				{
					list = new List<string>();
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
				foreach (string text in registryKey.GetSubKeyNames())
				{
					list.Add(text);
				}
			}
			finally
			{
				if (registryKey != null)
				{
					((IDisposable)registryKey).Dispose();
				}
			}
			return list;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0008AE74 File Offset: 0x00089074
		internal static void DeleteCustomCommand(string command)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Registry.LocalMachine.DeleteSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\" + command, false);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0008AED4 File Offset: 0x000890D4
		private static void CreateDefaultCommand(string itemName)
		{
			int num = 0;
			RegistryKey registryKey;
			do
			{
				if (num == 1)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell\\" + itemName, true);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				registryKey.CreateSubKey("command", RegistryKeyPermissionCheck.Default);
			}
			finally
			{
				if (registryKey != null)
				{
					((IDisposable)registryKey).Dispose();
				}
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0008AF64 File Offset: 0x00089164
		internal static List<string> GetDesktopItems()
		{
			int num = 0;
			RegistryKey registryKey;
			List<string> list;
			do
			{
				if (num == 2)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell", false);
					num = 3;
				}
				if (num == 1)
				{
					list = new List<string>();
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
				foreach (string text in registryKey.GetSubKeyNames())
				{
					if (!text.Contains("Gadgets") && !text.Contains("Display") && !text.Contains("Personalize"))
					{
						list.Add(text);
					}
				}
			}
			finally
			{
				if (registryKey != null)
				{
					((IDisposable)registryKey).Dispose();
				}
			}
			return list;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0008B050 File Offset: 0x00089250
		internal static void RemoveItem(string name)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			try
			{
				using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell", true))
				{
					try
					{
						registryKey.DeleteSubKeyTree(name, false);
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0008B0E8 File Offset: 0x000892E8
		internal static void RemoveAllItems(List<string> items)
		{
			int num = 0;
			RegistryKey registryKey;
			do
			{
				if (num == 1)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell", true);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				foreach (string text in items)
				{
					try
					{
						registryKey.DeleteSubKeyTree(text, false);
					}
					catch (Exception)
					{
					}
				}
			}
			finally
			{
				if (registryKey != null)
				{
					((IDisposable)registryKey).Dispose();
				}
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0008B1B4 File Offset: 0x000893B4
		internal static void AddItem(string name, string item, string icon, DesktopTypePosition position, bool shift, DesktopItemType type)
		{
			int num = 0;
			RegistryKey registryKey;
			do
			{
				if (num == 1)
				{
					registryKey = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell", true);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				registryKey.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
			}
			finally
			{
				if (registryKey != null)
				{
					((IDisposable)registryKey).Dispose();
				}
			}
			context_class.CreateDefaultCommand(name);
			if (shift)
			{
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name, "Extended", "");
			}
			else
			{
				using (RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("DesktopBackground\\Shell\\" + name, true))
				{
					registryKey2.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
				}
			}
			Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name, "Icon", icon);
			Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name, "Position", position.ToString());
			switch (type)
			{
			case DesktopItemType.Program:
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name + "\\command", "", item);
				break;
			case DesktopItemType.Folder:
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name + "\\command", "", "explorer " + item);
				break;
			case DesktopItemType.Link:
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name + "\\command", "", "explorer " + item);
				break;
			case DesktopItemType.File:
			{
				string text = "\"";
				string text2 = "explorer.exe";
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name + "\\command", "", string.Concat(new string[] { text2, " ", text, item, text }));
				break;
			}
			case DesktopItemType.Command:
				Registry.SetValue("HKEY_CLASSES_ROOT\\DesktopBackground\\Shell\\" + name + "\\command", "", item);
				break;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0008B430 File Offset: 0x00089630
		internal static string DownloadFavicon(string link, string name)
		{
			int num = 0;
			string text;
			do
			{
				if (num == 1)
				{
					text = string.Empty;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				Uri uri = new Uri(link);
				if (uri.HostNameType == UriHostNameType.Dns)
				{
					Image.FromStream(((HttpWebResponse)WebRequest.Create("http://" + uri.Host + "/favicon.ico").GetResponse()).GetResponseStream()).Save(context_class.tempPath + name + ".ico", ImageFormat.Bmp);
					text = context_class.tempPath + name + ".ico";
				}
			}
			catch (Exception)
			{
			}
			return text;
		}

		// Token: 0x04000388 RID: 904
		internal static string FolderDefaultIcon = "%systemroot%\\system32\\imageres.dll,-112";

		// Token: 0x04000389 RID: 905
		internal static string tempPath = Path.GetTempPath();
	}
}
