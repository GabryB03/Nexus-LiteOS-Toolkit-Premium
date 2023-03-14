using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Login_HWID
{
	// Token: 0x02000051 RID: 81
	internal class Theme
	{
		// Token: 0x060003A8 RID: 936
		[DllImport("uxtheme.dll", EntryPoint = "#95")]
		private static extern uint uxtheme_95(uint dwImmersiveColorSet, uint dwImmersiveColorType, bool bIgnoreHighContrast, uint dwHighContrastCacheMode);

		// Token: 0x060003A9 RID: 937
		[DllImport("uxtheme.dll", EntryPoint = "#96")]
		private static extern uint uxtheme_96(IntPtr pName);

		// Token: 0x060003AA RID: 938
		[DllImport("uxtheme.dll", EntryPoint = "#98")]
		private static extern int uxtheme_98(bool bForceCheckRegistry, bool bSkipCheckOnFail);

		// Token: 0x060003AB RID: 939 RVA: 0x0009148C File Offset: 0x0008F68C
		public static Color GetAccentColor()
		{
			int num = 0;
			Color color;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				int num2;
				if (num == 2)
				{
					num2 = Theme.uxtheme_98(false, false);
					num = 3;
				}
				uint num3;
				if (num == 3)
				{
					num3 = Theme.uxtheme_96(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
					num = 4;
				}
				if (num == 5)
				{
					uint num4;
					color = Theme.ConvertDWordColorToRGB(num4);
					num = 6;
				}
				if (num == 6)
				{
					break;
				}
				if (num == 4)
				{
					uint num4 = Theme.uxtheme_95((uint)num2, num3, false, 0U);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
			return color;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00091560 File Offset: 0x0008F760
		private static Color ConvertDWordColorToRGB(uint colorSetEx)
		{
			int num = 0;
			Color color;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				byte b;
				if (num == 2)
				{
					b = (byte)(255U & colorSetEx);
					num = 3;
				}
				if (num == 3)
				{
					num = 4;
				}
				if (num == 5)
				{
					num = 6;
				}
				byte b2;
				if (num == 6)
				{
					b2 = (byte)((16711680U & colorSetEx) >> 16);
					num = 7;
				}
				if (num == 7)
				{
					byte b3;
					color = Color.FromArgb((int)b, (int)b3, (int)b2);
					num = 8;
				}
				if (num == 8)
				{
					break;
				}
				if (num == 4)
				{
					byte b3 = (byte)((65280U & colorSetEx) >> 8);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
			return color;
		}
	}
}
