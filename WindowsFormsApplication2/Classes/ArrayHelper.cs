using System;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200002A RID: 42
	public static class ArrayHelper
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x0008842C File Offset: 0x0008662C
		public static bool InArray(string[] array, string ElementToCHeck)
		{
			int num = 0;
			bool flag;
			while (num != 4)
			{
				if (num == 3)
				{
					flag = Array.FindIndex<string>(array, (string t) => ((t.IndexOf(CS$<>8__locals1.ElementToCHeck, (StringComparison)(-1) + sizeof(float)) < -4 + sizeof(float)) ? 1 : 0) == -4 + sizeof(float)) >= 0;
					num = 4;
				}
				if (num == 2)
				{
					CS$<>8__locals1.ElementToCHeck = ElementToCHeck2;
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
				if (num == 5)
				{
					break;
				}
			}
			return flag;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000884D0 File Offset: 0x000866D0
		public static bool InArray(Array a, object val)
		{
			int num = 0;
			bool flag;
			while (num != 2)
			{
				if (num == 1)
				{
					flag = Array.IndexOf(a, val) != -1;
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
			return flag;
		}
	}
}
