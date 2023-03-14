using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2
{
	// Token: 0x02000003 RID: 3
	internal static class Cleaner
	{
		// Token: 0x06000014 RID: 20
		[DllImport("Shell32.dll")]
		private static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

		// Token: 0x06000015 RID: 21 RVA: 0x00003D74 File Offset: 0x00001F74
		internal static void PreviewFolder(string path)
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
				if (File.Exists(path))
				{
					Cleaner.PreviewCleanList.Add(path);
				}
				else
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					foreach (FileInfo fileInfo in directoryInfo.GetFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							Cleaner.PreviewCleanList.Add(fileInfo.FullName);
						}
						catch
						{
						}
					}
					foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories("*", SearchOption.AllDirectories))
					{
						try
						{
							Cleaner.PreviewCleanList.Add(directoryInfo2.FullName);
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003E8C File Offset: 0x0000208C
		internal static void Clean()
		{
			int num = 0;
			List<string>.Enumerator enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = Cleaner.PreviewCleanList.GetEnumerator();
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
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					try
					{
						if (Directory.Exists(text))
						{
							Directory.Delete(text);
						}
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			using (cleared cleared = new cleared())
			{
				cleared.ShowDialog();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003F64 File Offset: 0x00002164
		internal static void EmptyRecycleBin()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Cleaner.SHEmptyRecycleBin(IntPtr.Zero, null, (RecycleFlag)5);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003FB8 File Offset: 0x000021B8
		internal static void PreviewTemp()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Cleaner.PreviewFolder(Cleaner.TempFolder);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004018 File Offset: 0x00002218
		internal static void PreviewMinidumps()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.OSDriveWindows, "Minidump"));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004080 File Offset: 0x00002280
		internal static void PreviewErrorReports()
		{
			int num = 0;
			do
			{
				if (num == 8)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProgramData, "Microsoft\\Windows\\WER\\ERC"));
					num = 9;
				}
				if (num == 7)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProgramData, "Microsoft\\Windows\\WER\\Temp"));
					num = 8;
				}
				if (num == 6)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProgramData, "Microsoft\\Windows\\WER\\ReportQueue"));
					num = 7;
				}
				if (num == 5)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProgramData, "Microsoft\\Windows\\WER\\ReportArchive"));
					num = 6;
				}
				if (num == 4)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ERC"));
					num = 5;
				}
				if (num == 3)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Windows\\WER\\Temp"));
					num = 4;
				}
				if (num == 2)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportQueue"));
					num = 3;
				}
				if (num == 1)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportArchive"));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004218 File Offset: 0x00002418
		internal static void PreviewEdgeClean(bool cache, bool cookies)
		{
			int num = 0;
			for (;;)
			{
				if (num == 14)
				{
					num = 15;
				}
				if (num == 20)
				{
					goto IL_3B;
				}
				goto IL_5E;
				IL_4B:
				if (num == 16)
				{
					goto IL_3B;
				}
				int num2;
				if (num == 15)
				{
					num2 = 0;
					num = 16;
				}
				string[] array;
				if (num == 13)
				{
					array = Cleaner.edgeCookies;
					num = 14;
				}
				if (num == 12)
				{
					if (!cookies)
					{
						break;
					}
					num = 13;
				}
				if (num == 11)
				{
					goto IL_182;
				}
				IL_18E:
				if (num == 10)
				{
					goto IL_F2;
				}
				goto IL_11A;
				IL_107:
				if (num == 6)
				{
					goto IL_F2;
				}
				int num3;
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				string[] array2;
				if (num == 3)
				{
					array2 = Cleaner.edgeCache;
					num = 4;
				}
				if (num == 2)
				{
					if (!cache)
					{
						goto IL_182;
					}
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_11A:
				if (num == 9)
				{
					num3++;
					num = 10;
				}
				string text;
				if (num == 8)
				{
					Cleaner.PreviewFolder(text);
					num = 9;
				}
				if (num == 7)
				{
					goto IL_FA;
				}
				goto IL_107;
				IL_F2:
				if (num3 >= array2.Length)
				{
					num = 11;
					goto IL_11A;
				}
				IL_FA:
				text = array2[num3];
				num = 8;
				goto IL_107;
				IL_182:
				num = 12;
				goto IL_18E;
				IL_41:
				string text2 = array[num2];
				num = 18;
				goto IL_4B;
				IL_3B:
				if (num2 < array.Length)
				{
					goto IL_41;
				}
				num = 21;
				IL_5E:
				if (num == 19)
				{
					num2++;
					num = 20;
				}
				if (num == 18)
				{
					Cleaner.PreviewFolder(text2);
					num = 19;
				}
				if (num == 17)
				{
					goto IL_41;
				}
				goto IL_4B;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004414 File Offset: 0x00002614
		internal static void PreviewFireFoxClean(bool cache, bool cookies)
		{
			int num = 0;
			IEnumerator<string> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = Directory.EnumerateDirectories(Cleaner.firefoxRoaming).GetEnumerator();
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
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					if (text.ToLowerInvariant().Contains("release"))
					{
						if (cookies)
						{
							Cleaner.PreviewFolder(Path.Combine(text, "cookies.sqlite"));
						}
						if (cache)
						{
							Cleaner.PreviewFolder(Path.Combine(text, "shader-cache"));
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (cache)
			{
				foreach (string text2 in Directory.EnumerateDirectories(Cleaner.firefoxLocal))
				{
					if (text2.ToLowerInvariant().Contains("release"))
					{
						Cleaner.PreviewFolder(Path.Combine(text2, "cache2"));
					}
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000453C File Offset: 0x0000273C
		internal static void PreviewBraveClean(bool cache, bool cookies)
		{
			int num = 0;
			for (;;)
			{
				if (num == 14)
				{
					num = 15;
				}
				if (num == 20)
				{
					goto IL_3B;
				}
				goto IL_5E;
				IL_4B:
				if (num == 16)
				{
					goto IL_3B;
				}
				int num2;
				if (num == 15)
				{
					num2 = 0;
					num = 16;
				}
				string[] array;
				if (num == 13)
				{
					array = Cleaner.braveCookiesDirs;
					num = 14;
				}
				if (num == 12)
				{
					if (!cookies)
					{
						break;
					}
					num = 13;
				}
				if (num == 11)
				{
					goto IL_18C;
				}
				IL_198:
				if (num == 10)
				{
					goto IL_FC;
				}
				goto IL_124;
				IL_111:
				if (num == 6)
				{
					goto IL_FC;
				}
				int num3;
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				string[] array2;
				if (num == 3)
				{
					array2 = Cleaner.braveUserDataCacheDirs;
					num = 4;
				}
				if (num == 2)
				{
					if (!cache)
					{
						goto IL_18C;
					}
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_124:
				if (num == 9)
				{
					num3++;
					num = 10;
				}
				string text;
				if (num == 8)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.braveFolder, text));
					num = 9;
				}
				if (num == 7)
				{
					goto IL_104;
				}
				goto IL_111;
				IL_FC:
				if (num3 >= array2.Length)
				{
					num = 11;
					goto IL_124;
				}
				IL_104:
				text = array2[num3];
				num = 8;
				goto IL_111;
				IL_18C:
				num = 12;
				goto IL_198;
				IL_41:
				string text2 = array[num2];
				num = 18;
				goto IL_4B;
				IL_3B:
				if (num2 < array.Length)
				{
					goto IL_41;
				}
				num = 21;
				IL_5E:
				if (num == 19)
				{
					num2++;
					num = 20;
				}
				if (num == 18)
				{
					Cleaner.PreviewFolder(text2);
					num = 19;
				}
				if (num == 17)
				{
					goto IL_41;
				}
				goto IL_4B;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004744 File Offset: 0x00002944
		internal static void PreviewChromeClean(bool cache, bool cookies)
		{
			int num = 0;
			for (;;)
			{
				if (num == 14)
				{
					num = 15;
				}
				if (num == 20)
				{
					goto IL_3B;
				}
				goto IL_5E;
				IL_4B:
				if (num == 16)
				{
					goto IL_3B;
				}
				int num2;
				if (num == 15)
				{
					num2 = 0;
					num = 16;
				}
				string[] array;
				if (num == 13)
				{
					array = Cleaner.chromeCookiesDirs;
					num = 14;
				}
				if (num == 12)
				{
					if (!cookies)
					{
						break;
					}
					num = 13;
				}
				if (num == 11)
				{
					goto IL_18C;
				}
				IL_198:
				if (num == 10)
				{
					goto IL_FC;
				}
				goto IL_124;
				IL_111:
				if (num == 6)
				{
					goto IL_FC;
				}
				int num3;
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				string[] array2;
				if (num == 3)
				{
					array2 = Cleaner.chromeUserDataCacheDirs;
					num = 4;
				}
				if (num == 2)
				{
					if (!cache)
					{
						goto IL_18C;
					}
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_124:
				if (num == 9)
				{
					num3++;
					num = 10;
				}
				string text;
				if (num == 8)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.chromeFolder, text));
					num = 9;
				}
				if (num == 7)
				{
					goto IL_104;
				}
				goto IL_111;
				IL_FC:
				if (num3 >= array2.Length)
				{
					num = 11;
					goto IL_124;
				}
				IL_104:
				text = array2[num3];
				num = 8;
				goto IL_111;
				IL_18C:
				num = 12;
				goto IL_198;
				IL_41:
				string text2 = array[num2];
				num = 18;
				goto IL_4B;
				IL_3B:
				if (num2 < array.Length)
				{
					goto IL_41;
				}
				num = 21;
				IL_5E:
				if (num == 19)
				{
					num2++;
					num = 20;
				}
				if (num == 18)
				{
					Cleaner.PreviewFolder(text2);
					num = 19;
				}
				if (num == 17)
				{
					goto IL_41;
				}
				goto IL_4B;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000494C File Offset: 0x00002B4C
		internal static void PreviewVivaldiClean(bool cache)
		{
			int num = 0;
			for (;;)
			{
				if (num == 10)
				{
					goto IL_38;
				}
				goto IL_5B;
				IL_48:
				if (num == 6)
				{
					goto IL_38;
				}
				int num2;
				if (num == 5)
				{
					num2 = 0;
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				string[] array;
				if (num == 3)
				{
					array = Cleaner.vivaldiUserDataCacheDirs;
					num = 4;
				}
				if (num == 2)
				{
					if (!cache)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 11)
				{
					continue;
				}
				break;
				IL_5B:
				if (num == 9)
				{
					num2++;
					num = 10;
				}
				string text;
				if (num == 8)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.vivaldiFolder, text));
					num = 9;
				}
				if (num == 7)
				{
					goto IL_3E;
				}
				goto IL_48;
				IL_38:
				if (num2 >= array.Length)
				{
					num = 11;
					goto IL_5B;
				}
				IL_3E:
				text = array[num2];
				num = 8;
				goto IL_48;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004A64 File Offset: 0x00002C64
		internal static void PreviewOperaGXClean(bool cache, bool cookies)
		{
			int num = 0;
			for (;;)
			{
				if (num == 14)
				{
					num = 15;
				}
				if (num == 20)
				{
					goto IL_3B;
				}
				goto IL_5E;
				IL_4B:
				if (num == 16)
				{
					goto IL_3B;
				}
				int num2;
				if (num == 15)
				{
					num2 = 0;
					num = 16;
				}
				string[] array;
				if (num == 13)
				{
					array = Cleaner.operaGXCookiesDirs;
					num = 14;
				}
				if (num == 12)
				{
					if (!cookies)
					{
						break;
					}
					num = 13;
				}
				if (num == 11)
				{
					goto IL_18C;
				}
				IL_198:
				if (num == 10)
				{
					goto IL_FC;
				}
				goto IL_124;
				IL_111:
				if (num == 6)
				{
					goto IL_FC;
				}
				int num3;
				if (num == 5)
				{
					num3 = 0;
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				string[] array2;
				if (num == 3)
				{
					array2 = Cleaner.operaGXUserDataCacheDirs;
					num = 4;
				}
				if (num == 2)
				{
					if (!cache)
					{
						goto IL_18C;
					}
					num = 3;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_124:
				if (num == 9)
				{
					num3++;
					num = 10;
				}
				string text;
				if (num == 8)
				{
					Cleaner.PreviewFolder(Path.Combine(Cleaner.operaGXFolder, text));
					num = 9;
				}
				if (num == 7)
				{
					goto IL_104;
				}
				goto IL_111;
				IL_FC:
				if (num3 >= array2.Length)
				{
					num = 11;
					goto IL_124;
				}
				IL_104:
				text = array2[num3];
				num = 8;
				goto IL_111;
				IL_18C:
				num = 12;
				goto IL_198;
				IL_41:
				string text2 = array[num2];
				num = 18;
				goto IL_4B;
				IL_3B:
				if (num2 < array.Length)
				{
					goto IL_41;
				}
				num = 21;
				IL_5E:
				if (num == 19)
				{
					num2++;
					num = 20;
				}
				if (num == 18)
				{
					Cleaner.PreviewFolder(text2);
					num = 19;
				}
				if (num == 17)
				{
					goto IL_41;
				}
				goto IL_4B;
			}
		}

		// Token: 0x04000004 RID: 4
		internal static readonly string System32Folder = Environment.GetFolderPath(Environment.SpecialFolder.System);

		// Token: 0x04000005 RID: 5
		internal static readonly string TempFolder = Path.GetTempPath();

		// Token: 0x04000006 RID: 6
		internal static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000007 RID: 7
		internal static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		// Token: 0x04000008 RID: 8
		internal static readonly string ProfileAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000009 RID: 9
		internal static readonly string OSDriveWindows = Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine);

		// Token: 0x0400000A RID: 10
		private static string chromeFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\Google\\Chrome\\User Data");

		// Token: 0x0400000B RID: 11
		private static string[] chromeUserDataCacheDirs = new string[]
		{
			"Default\\Cache", "Default\\Code Cache\\", "Default\\GPUCache\\", "ShaderCache", "Default\\Service Worker\\CacheStorage\\", "Default\\Service Worker\\ScriptCache\\", "GrShaderCache\\GPUCache\\", "Default\\File System\\", "Default\\JumpListIconsMostVisited\\", "Default\\JumpListIconsRecentClosed\\",
			"Default\\Service Worker\\Database"
		};

		// Token: 0x0400000C RID: 12
		private static string[] chromeCookiesDirs = new string[]
		{
			Path.Combine(Cleaner.ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\IndexedDB"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Cookies"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Cookies-journal")
		};

		// Token: 0x0400000D RID: 13
		private static string firefoxRoaming = Path.Combine(Cleaner.ProfileAppDataRoaming, "Mozilla\\Firefox\\Profiles");

		// Token: 0x0400000E RID: 14
		private static string firefoxLocal = Path.Combine(Cleaner.ProfileAppDataLocal, "Mozilla\\Firefox\\Profiles");

		// Token: 0x0400000F RID: 15
		private static string[] edgeCookies = new string[]
		{
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Cookies"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\IndexedDB")
		};

		// Token: 0x04000010 RID: 16
		private static string[] edgeCache = new string[]
		{
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Cache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Code Cache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\GPUCache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\ShaderCache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\CacheStorage"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\ScriptCache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\GrShaderCache\\GPUCache"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\Database")
		};

		// Token: 0x04000011 RID: 17
		private static string braveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\BraveSoftware\\Brave-Browser\\User Data");

		// Token: 0x04000012 RID: 18
		private static string[] braveUserDataCacheDirs = new string[]
		{
			"Default\\Cache", "Default\\Code Cache\\", "Default\\GPUCache\\", "ShaderCache", "Default\\Service Worker\\CacheStorage\\", "Default\\Service Worker\\ScriptCache\\", "GrShaderCache\\GPUCache\\", "Default\\File System\\", "Default\\JumpListIconsMostVisited\\", "Default\\JumpListIconsRecentClosed\\",
			"Default\\Service Worker\\Database"
		};

		// Token: 0x04000013 RID: 19
		private static string[] braveCookiesDirs = new string[]
		{
			Path.Combine(Cleaner.ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\IndexedDB"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies"),
			Path.Combine(Cleaner.ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies-journal")
		};

		// Token: 0x04000014 RID: 20
		private static string vivaldiFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\Vivaldi\\User Data");

		// Token: 0x04000015 RID: 21
		private static string[] vivaldiUserDataCacheDirs = new string[] { "Default\\Cache", "Default\\Code Cache" };

		// Token: 0x04000016 RID: 22
		private static string operaGXFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\Opera Software\\Opera GX Stable\\");

		// Token: 0x04000017 RID: 23
		private static string[] operaGXUserDataCacheDirs = new string[] { "Cache", "System Cache" };

		// Token: 0x04000018 RID: 24
		private static string[] operaGXCookiesDirs = new string[] { Path.Combine(Cleaner.operaGXFolder, "Profile\\Cookies") };

		// Token: 0x04000019 RID: 25
		internal static List<string> PreviewCleanList = new List<string>();
	}
}
