using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200007B RID: 123
	public partial class update_error : Form
	{
		// Token: 0x06000A5C RID: 2652
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000A5D RID: 2653 RVA: 0x00190E9C File Offset: 0x0018F09C
		public update_error()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(update_error.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000066D8 File Offset: 0x000048D8
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Application.ExitThread();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000A60 RID: 2656
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000A61 RID: 2657
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000A62 RID: 2658 RVA: 0x00190EF8 File Offset: 0x0018F0F8
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					update_error.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					update_error.ReleaseCapture();
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

		// Token: 0x06000A63 RID: 2659 RVA: 0x0007F710 File Offset: 0x0007D910
		private void update_error_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A38 RID: 2616
		public static Point newpoint = default(Point);

		// Token: 0x04000A39 RID: 2617
		public static int x;

		// Token: 0x04000A3A RID: 2618
		public static int y;

		// Token: 0x04000A3B RID: 2619
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000A3C RID: 2620
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000A3D RID: 2621
		public const int HT_CAPTION = 2;
	}
}
