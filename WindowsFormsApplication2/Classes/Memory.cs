using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200002D RID: 45
	internal class Memory
	{
		// Token: 0x060002AF RID: 687
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool GlobalMemoryStatusEx(out Memory.MEMORYSTATUSEX lpBuffer);

		// Token: 0x060002B0 RID: 688 RVA: 0x000887B0 File Offset: 0x000869B0
		public static ulong Get(int x)
		{
			int num = 0;
			ulong num2;
			for (;;)
			{
				if (num == 15)
				{
					num2 = 0UL;
					num = 16;
				}
				if (num != 16)
				{
					if (num == 14)
					{
						goto IL_B8;
					}
					IL_BE:
					if (num == 13)
					{
						break;
					}
					if (num == 12)
					{
						goto IL_9B;
					}
					IL_A8:
					if (num == 11)
					{
						break;
					}
					if (num == 10)
					{
						goto IL_81;
					}
					IL_8E:
					if (num == 9)
					{
						goto IL_B8;
					}
					if (num == 8)
					{
						goto IL_4F;
					}
					IL_5D:
					int num3;
					Memory.MEMORYSTATUSEX memorystatusex;
					if (num != 7)
					{
						if (num == 6)
						{
							if (num3 == 1)
							{
								goto IL_81;
							}
							num = 7;
						}
						if (num == 5)
						{
							num3 = x;
							num = 6;
						}
						if (num == 4)
						{
							num = 5;
						}
						if (num == 3)
						{
							Memory.GlobalMemoryStatusEx(out memorystatusex);
							num = 4;
						}
						if (num == 2)
						{
							memorystatusex.dwLength = 64U;
							num = 3;
						}
						if (num == 1)
						{
							memorystatusex = default(Memory.MEMORYSTATUSEX);
							num = 2;
						}
						if (num == 0)
						{
							num = 1;
						}
						if (num == 17)
						{
							break;
						}
						continue;
					}
					IL_4F:
					if (num3 != 2)
					{
						num = 9;
						goto IL_5D;
					}
					goto IL_9B;
					IL_81:
					num2 = memorystatusex.ullAvailPhys;
					num = 11;
					goto IL_8E;
					IL_9B:
					num2 = memorystatusex.ullTotalPhys;
					num = 13;
					goto IL_A8;
					IL_B8:
					num = 15;
					goto IL_BE;
				}
				break;
			}
			return num2;
		}

		// Token: 0x0200002E RID: 46
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct MEMORYSTATUSEX
		{
			// Token: 0x04000323 RID: 803
			public uint dwLength;

			// Token: 0x04000324 RID: 804
			public uint dwMemoryLoad;

			// Token: 0x04000325 RID: 805
			public ulong ullTotalPhys;

			// Token: 0x04000326 RID: 806
			public ulong ullAvailPhys;

			// Token: 0x04000327 RID: 807
			public ulong ullTotalPageFile;

			// Token: 0x04000328 RID: 808
			public ulong ullAvailPageFile;

			// Token: 0x04000329 RID: 809
			public ulong ullTotalVirtual;

			// Token: 0x0400032A RID: 810
			public ulong ullAvailVirtual;

			// Token: 0x0400032B RID: 811
			public ulong ullAvailExtendedVirtual;
		}
	}
}
