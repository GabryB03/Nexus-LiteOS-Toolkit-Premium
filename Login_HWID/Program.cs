using System;
using System.Windows.Forms;

namespace Login_HWID
{
	// Token: 0x02000050 RID: 80
	internal static class Program
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00091400 File Offset: 0x0008F600
		[STAThread]
		private static void Main()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Application.EnableVisualStyles();
					num = 2;
				}
				if (num == 2)
				{
					num = 3;
				}
				if (num == 3)
				{
					Application.SetCompatibleTextRenderingDefault(false);
					num = 4;
				}
				if (num == 4)
				{
					Application.Run(new Login());
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}
	}
}
