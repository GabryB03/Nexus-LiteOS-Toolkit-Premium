using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x02000093 RID: 147
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00195B4C File Offset: 0x00193D4C
		private static string CultureToString(CultureInfo culture)
		{
			int num = 0;
			while (num != 2)
			{
				if (num == 1)
				{
					if (culture != null)
					{
						goto IL_5D;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 3)
				{
					continue;
				}
				IL_5D:
				return culture.Name;
			}
			return "";
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00195BC0 File Offset: 0x00193DC0
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			int num = 0;
			Assembly assembly;
			for (;;)
			{
				Assembly[] assemblies;
				if (num == 2)
				{
					AppDomain currentDomain;
					assemblies = currentDomain.GetAssemblies();
					num = 3;
				}
				if (num == 4)
				{
					num = 5;
				}
				if (num == 6)
				{
					goto IL_C0;
				}
				AssemblyName name2;
				if (num == 9)
				{
					if (!string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase))
					{
						goto IL_132;
					}
					num = 10;
				}
				if (num == 11)
				{
					break;
				}
				if (num == 10)
				{
					if (!string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
					{
						goto IL_132;
					}
					num = 11;
				}
				if (num == 8)
				{
					name2 = assembly.GetName();
					num = 9;
				}
				if (num == 7)
				{
					goto IL_CB;
				}
				IL_D8:
				int num2;
				if (num == 5)
				{
					num2 = 0;
					num = 6;
				}
				Assembly[] array;
				if (num == 3)
				{
					array = assemblies;
					num = 4;
				}
				if (num == 1)
				{
					AppDomain currentDomain = AppDomain.CurrentDomain;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 12)
				{
					goto IL_132;
				}
				continue;
				IL_CB:
				assembly = array[num2];
				num = 8;
				goto IL_D8;
				IL_C0:
				if (num2 < array.Length)
				{
					goto IL_CB;
				}
				goto IL_160;
				IL_132:
				num2++;
				goto IL_C0;
			}
			return assembly;
			IL_160:
			return null;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00195D30 File Offset: 0x00193F30
		private static void CopyTo(Stream source, Stream destination)
		{
			int num = 0;
			for (;;)
			{
				byte[] array;
				if (num == 2)
				{
					array = new byte[81920];
					num = 3;
				}
				if (num == 4)
				{
					goto IL_41;
				}
				IL_57:
				if (num == 5)
				{
					goto IL_18;
				}
				IL_34:
				if (num != 3)
				{
					if (num == 1)
					{
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num != 6)
					{
						continue;
					}
					break;
				}
				IL_18:
				int num2;
				if ((num2 = source.Read(array, 0, array.Length)) == 0)
				{
					num = 6;
					goto IL_34;
				}
				IL_41:
				destination.Write(array, 0, num2);
				num = 5;
				goto IL_57;
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00195DF0 File Offset: 0x00193FF0
		private static Stream LoadStream(string fullName)
		{
			int num = 0;
			Assembly executingAssembly;
			do
			{
				if (num == 2)
				{
					if (!fullName.EndsWith(".compressed"))
					{
						goto Block_7;
					}
					num = 3;
				}
				if (num == 4)
				{
					goto IL_90;
				}
				if (num == 3)
				{
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName);
					num = 4;
				}
				if (num == 1)
				{
					executingAssembly = Assembly.GetExecutingAssembly();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			Stream stream;
			return stream;
			Block_7:
			return executingAssembly.GetManifestResourceStream(fullName);
			try
			{
				IL_90:
				Stream manifestResourceStream;
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					AssemblyLoader.CopyTo(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					stream = memoryStream;
				}
			}
			finally
			{
				Stream manifestResourceStream;
				if (manifestResourceStream != null)
				{
					((IDisposable)manifestResourceStream).Dispose();
				}
			}
			return stream;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00195EEC File Offset: 0x001940EC
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			int num = 0;
			string text;
			while (num != 2)
			{
				if (num == 1)
				{
					if (!resourceNames.TryGetValue(name, out text))
					{
						goto IL_6E;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 3)
				{
					continue;
				}
				IL_6E:
				return null;
			}
			return AssemblyLoader.LoadStream(text);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00195F68 File Offset: 0x00194168
		private static byte[] ReadStream(Stream stream)
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 2)
				{
					stream.Read(array, 0, array.Length);
					num = 3;
				}
				if (num == 1)
				{
					array = new byte[stream.Length];
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			return array;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00195FE0 File Offset: 0x001941E0
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			int num = 0;
			string text;
			for (;;)
			{
				if (num != 2)
				{
					goto IL_0E;
				}
				if (requestedAssemblyName.CultureInfo != null)
				{
					num = 3;
					goto IL_0E;
				}
				goto IL_83;
				IL_61:
				if (num == 3)
				{
					if (string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
					{
						goto IL_83;
					}
					num = 4;
				}
				if (num == 1)
				{
					text = requestedAssemblyName.Name.ToLowerInvariant();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 7)
				{
					break;
				}
				continue;
				IL_0E:
				if (num == 4)
				{
					text = requestedAssemblyName.CultureInfo.Name + "." + text;
					num = 5;
				}
				if (num == 6)
				{
					goto IL_127;
				}
				if (num != 5)
				{
					goto IL_61;
				}
				IL_83:
				Stream stream = AssemblyLoader.LoadStream(assemblyNames, text);
				num = 6;
				goto IL_61;
			}
			Assembly assembly;
			return assembly;
			byte[] array;
			try
			{
				IL_127:
				Stream stream;
				if (stream == null)
				{
					return null;
				}
				array = AssemblyLoader.ReadStream(stream);
			}
			finally
			{
				Stream stream;
				if (stream != null)
				{
					((IDisposable)stream).Dispose();
				}
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] array2 = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(array, array2);
				}
			}
			return Assembly.Load(array);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x001961B4 File Offset: 0x001943B4
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					num = 3;
				}
				if (num == 4)
				{
					goto IL_7D;
				}
				if (num == 5)
				{
					goto IL_CD;
				}
				if (num == 3)
				{
					bool flag = false;
					num = 4;
				}
				if (num == 1)
				{
					object obj = AssemblyLoader.nullCacheLock;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			Assembly assembly;
			return assembly;
			try
			{
				IL_7D:
				bool flag;
				object obj;
				Monitor.Enter(obj, ref flag);
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			finally
			{
				bool flag;
				if (flag)
				{
					object obj;
					Monitor.Exit(obj);
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly2 = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly2 != null)
			{
				return assembly2;
			}
			IL_CD:
			assembly2 = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly2 == null)
			{
				object obj2 = AssemblyLoader.nullCacheLock;
				lock (obj2)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly2 = Assembly.Load(assemblyName);
				}
			}
			return assembly2;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0019631C File Offset: 0x0019451C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("aspose.zip", "costura.aspose.zip.dll.compressed");
			AssemblyLoader.assemblyNames.Add("buttoncircle.formsplugin.abstractions", "costura.buttoncircle.formsplugin.abstractions.dll.compressed");
			AssemblyLoader.symbolNames.Add("buttoncircle.formsplugin.abstractions", "costura.buttoncircle.formsplugin.abstractions.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.xaml.behaviors", "costura.microsoft.xaml.behaviors.dll.compressed");
			AssemblyLoader.symbolNames.Add("microsoft.xaml.behaviors", "costura.microsoft.xaml.behaviors.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("neodynamic.webcontrols.imagedraw", "costura.neodynamic.webcontrols.imagedraw.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("nhotkey", "costura.nhotkey.dll.compressed");
			AssemblyLoader.symbolNames.Add("nhotkey", "costura.nhotkey.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("nhotkey.windowsforms", "costura.nhotkey.windowsforms.dll.compressed");
			AssemblyLoader.symbolNames.Add("nhotkey.windowsforms", "costura.nhotkey.windowsforms.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("siticone.desktop.ui", "costura.siticone.desktop.ui.dll.compressed");
			AssemblyLoader.assemblyNames.Add("syncfusion.core.xforms", "costura.syncfusion.core.xforms.dll.compressed");
			AssemblyLoader.assemblyNames.Add("syncfusion.licensing", "costura.syncfusion.licensing.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.drawing.common", "costura.system.drawing.common.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.encoding.codepages", "costura.system.text.encoding.codepages.dll.compressed");
			AssemblyLoader.assemblyNames.Add("xamarin.forms.core", "costura.xamarin.forms.core.dll.compressed");
			AssemblyLoader.symbolNames.Add("xamarin.forms.core", "costura.xamarin.forms.core.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("xamarin.forms.platform", "costura.xamarin.forms.platform.dll.compressed");
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0019655C File Offset: 0x0019475C
		public static void Attach()
		{
			int num = 0;
			while (num != 2)
			{
				AppDomain currentDomain;
				if (num == 4)
				{
					currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
					num = 5;
				}
				if (num == 3)
				{
					goto IL_3F;
				}
				IL_4B:
				if (num == 1)
				{
					if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) != 1)
					{
						goto IL_3F;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 5)
				{
					continue;
				}
				return;
				IL_3F:
				currentDomain = AppDomain.CurrentDomain;
				num = 4;
				goto IL_4B;
			}
		}

		// Token: 0x04000A90 RID: 2704
		private static object nullCacheLock = new object();

		// Token: 0x04000A91 RID: 2705
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x04000A92 RID: 2706
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x04000A93 RID: 2707
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x04000A94 RID: 2708
		private static int isAttached;
	}
}
