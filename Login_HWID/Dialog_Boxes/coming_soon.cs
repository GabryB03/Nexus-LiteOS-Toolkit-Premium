using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x02000071 RID: 113
	public partial class coming_soon : Form
	{
		// Token: 0x060009F7 RID: 2551
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x060009F8 RID: 2552 RVA: 0x00189304 File Offset: 0x00187504
		public coming_soon()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(coming_soon.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x060009FA RID: 2554
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060009FB RID: 2555
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060009FC RID: 2556 RVA: 0x00013EFC File Offset: 0x000120FC
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Close();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00189360 File Offset: 0x00187560
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					coming_soon.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					coming_soon.ReleaseCapture();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = e.Button == MouseButtons.Left;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0007F710 File Offset: 0x0007D910
		private void coming_soon_KeyDown(object sender, KeyEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					base.Close();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = e.KeyCode == Keys.Return;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x040009DD RID: 2525
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040009DE RID: 2526
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040009DF RID: 2527
		public const int HT_CAPTION = 2;
	}
}
