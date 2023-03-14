using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2
{
	// Token: 0x0200000B RID: 11
	internal class Utils
	{
		// Token: 0x06000058 RID: 88 RVA: 0x000137E0 File Offset: 0x000119E0
		public static void DeleteRegValues(string[] values, RegistryKey key)
		{
			int num = 0;
			for (;;)
			{
				if (num == 2)
				{
					num = 3;
				}
				if (num == 4)
				{
					goto IL_2D;
				}
				if (num == 5)
				{
					goto IL_33;
				}
				IL_3D:
				int num2;
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				string text;
				if (num == 6)
				{
					try
					{
						key.DeleteValue(text);
					}
					catch
					{
					}
					num2++;
					goto IL_2D;
				}
				continue;
				IL_33:
				text = values[num2];
				num = 6;
				goto IL_3D;
				IL_2D:
				if (num2 < values.Length)
				{
					goto IL_33;
				}
				break;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0001389C File Offset: 0x00011A9C
		public static bool DownloadFile(string url, string filename)
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
			bool flag;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile(new Uri(url), filename);
				}
				flag = true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00013924 File Offset: 0x00011B24
		internal static string GetShortcutTargetFile(string shortcutFilename)
		{
			/*
An exception occurred when decompiling this method (0600005A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String WindowsFormsApplication2.Utils::GetShortcutTargetFile(System.String)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1610
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1602
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 247
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1618
*/;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00013B04 File Offset: 0x00011D04
		internal static void FindKeyInRegistry(string key)
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
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", key);
				Process.Start("regedit");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00013B6C File Offset: 0x00011D6C
		internal static void FindFile(string fileName)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 3)
				{
					Process.Start("explorer.exe", "/select, \"" + fileName + "\"");
					num = 4;
				}
				if (num == 1)
				{
					bool flag = File.Exists(fileName);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00013C28 File Offset: 0x00011E28
		internal static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
		{
			int num = 0;
			IEnumerator enumerator;
			List<Control> list;
			do
			{
				if (num == 2)
				{
					enumerator = parent.Controls.GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					list = new List<Control>();
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
					object obj = enumerator.Current;
					Control control = (Control)obj;
					list.AddRange(Utils.GetSelfAndChildrenRecursive(control));
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			list.Add(parent);
			return list;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00013D2C File Offset: 0x00011F2C
		internal static void TryDeleteRegistryValue(bool localMachine, string path, string valueName)
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
				if (localMachine)
				{
					Registry.LocalMachine.OpenSubKey(path, true).DeleteValue(valueName, false);
				}
				if (!localMachine)
				{
					Registry.CurrentUser.OpenSubKey(path, true).DeleteValue(valueName, false);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00013DCC File Offset: 0x00011FCC
		internal static void RunCommand(string command)
		{
			int num = 0;
			Process process;
			do
			{
				if (num == 1)
				{
					process = new Process();
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
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "/C " + command;
				process.StartInfo.CreateNoWindow = true;
				try
				{
					process.Start();
					process.WaitForExit();
					process.Close();
				}
				catch (Exception)
				{
				}
			}
			finally
			{
				if (process != null)
				{
					((IDisposable)process).Dispose();
				}
			}
		}
	}
}
