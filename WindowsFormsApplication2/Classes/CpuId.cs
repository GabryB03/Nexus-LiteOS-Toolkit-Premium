using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200002C RID: 44
	internal static class CpuId
	{
		// Token: 0x060002AB RID: 683
		[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr CallWindowProcW([In] byte[] bytes, IntPtr hWnd, int msg, [In] [Out] byte[] wParam, IntPtr lParam);

		// Token: 0x060002AC RID: 684
		[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool VirtualProtect([In] byte[] bytes, IntPtr size, int newProtect, out int oldProtect);

		// Token: 0x060002AD RID: 685 RVA: 0x00088538 File Offset: 0x00086738
		public static string GetCpuId()
		{
			int num = 0;
			byte[] array;
			do
			{
				if (num == 3)
				{
					if (!CpuId.ExecuteCode(ref array))
					{
						goto Block_6;
					}
					num = 4;
				}
				if (num == 2)
				{
					array = new byte[8];
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
			}
			while (num != 4);
			return string.Format("{0:X8}{1:X8}", BitConverter.ToUInt32(array, 4), BitConverter.ToUInt32(array, 0));
			Block_6:
			return "ND";
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000885E4 File Offset: 0x000867E4
		private static bool ExecuteCode(ref byte[] result)
		{
			int num = 0;
			bool flag;
			while (num != 15)
			{
				byte[] array;
				IntPtr intPtr;
				if (num == 14)
				{
					flag = CpuId.CallWindowProcW(array, IntPtr.Zero, 0, result, intPtr) != IntPtr.Zero;
					num = 15;
				}
				if (num == 13)
				{
					goto IL_57;
				}
				IL_6B:
				if (num == 12)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
					num = 13;
				}
				if (num == 11)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_57;
					}
					num = 12;
				}
				if (num == 10)
				{
					int num2;
					bool flag2 = !CpuId.VirtualProtect(array, intPtr, 64, out num2);
					num = 11;
				}
				if (num == 9)
				{
					goto IL_122;
				}
				IL_132:
				if (num == 8)
				{
					array = new byte[]
					{
						85, 137, 229, 87, 139, 125, 16, 106, 1, 88,
						83, 15, 162, 137, 7, 137, 87, 4, 91, 95,
						137, 236, 93, 194, 16, 0
					};
					num = 9;
				}
				if (num == 7)
				{
					goto IL_112;
				}
				IL_118:
				if (num == 6)
				{
					goto IL_122;
				}
				if (num == 5)
				{
					array = new byte[]
					{
						83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
						65, 137, 0, 65, 137, 80, 4, 91, 195
					};
					num = 6;
				}
				if (num == 4)
				{
					num = 5;
				}
				if (num == 3)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_112;
					}
					num = 4;
				}
				if (num == 2)
				{
					bool flag4;
					bool flag3 = flag4;
					num = 3;
				}
				if (num == 1)
				{
					bool flag4 = IntPtr.Size == 8;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 16)
				{
					continue;
				}
				break;
				IL_112:
				num = 8;
				goto IL_118;
				IL_122:
				intPtr = new IntPtr(array.Length);
				num = 10;
				goto IL_132;
				IL_57:
				intPtr = new IntPtr(result.Length);
				num = 14;
				goto IL_6B;
			}
			return flag;
		}

		// Token: 0x04000322 RID: 802
		private const int PAGE_EXECUTE_READWRITE = 64;
	}
}
