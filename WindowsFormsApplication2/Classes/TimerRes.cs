using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200002F RID: 47
	internal class TimerRes
	{
		// Token: 0x060002B2 RID: 690
		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern void NtSetTimerResolution(uint DesiredResolution, bool SetResolution, ref uint CurrentResolution);

		// Token: 0x060002B3 RID: 691
		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern int NtQueryTimerResolution(out uint MinimumResolution, out uint MaximumResolution, out uint ActualResolution);

		// Token: 0x060002B4 RID: 692 RVA: 0x00088944 File Offset: 0x00086B44
		public static void SetTimerRes(bool enabled, uint value)
		{
			int num = 0;
			while (num != 8)
			{
				if (num == 7)
				{
					goto IL_55;
				}
				IL_6E:
				if (num == 6)
				{
					break;
				}
				if (num == 5)
				{
					goto IL_32;
				}
				IL_4B:
				if (num == 4)
				{
					goto IL_55;
				}
				if (num == 3)
				{
					bool flag;
					if (flag)
					{
						goto IL_32;
					}
					num = 4;
				}
				if (num == 2)
				{
					bool flag = enabled;
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
				if (num != 9)
				{
					continue;
				}
				break;
				IL_32:
				TimerRes.NtSetTimerResolution(value, true, ref TimerRes.CurrentResolution);
				num = 6;
				goto IL_4B;
				IL_55:
				TimerRes.NtSetTimerResolution(value, false, ref TimerRes.CurrentResolution);
				num = 8;
				goto IL_6E;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00088A20 File Offset: 0x00086C20
		public static TimerRes.Timer Get()
		{
			int num = 0;
			TimerRes.Timer timer;
			while (num != 4)
			{
				TimerRes.Timer timer2;
				if (num == 3)
				{
					timer = timer2;
					num = 4;
				}
				if (num == 2)
				{
					TimerRes.NtQueryTimerResolution(out timer2.min, out timer2.max, out timer2.cur);
					num = 3;
				}
				if (num == 1)
				{
					timer2 = default(TimerRes.Timer);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 5)
				{
					break;
				}
			}
			return timer;
		}

		// Token: 0x0400032C RID: 812
		public static uint CurrentResolution;

		// Token: 0x02000030 RID: 48
		public struct Timer
		{
			// Token: 0x0400032D RID: 813
			public uint min;

			// Token: 0x0400032E RID: 814
			public uint max;

			// Token: 0x0400032F RID: 815
			public uint cur;
		}
	}
}
