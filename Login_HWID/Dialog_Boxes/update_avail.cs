using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200007A RID: 122
	public partial class update_avail : Form
	{
		// Token: 0x06000A51 RID: 2641
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000A52 RID: 2642 RVA: 0x001901FC File Offset: 0x0018E3FC
		public update_avail()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(update_avail.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000066D8 File Offset: 0x000048D8
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

		// Token: 0x06000A55 RID: 2645
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000A56 RID: 2646
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000A57 RID: 2647 RVA: 0x00190258 File Offset: 0x0018E458
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					update_avail.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					update_avail.ReleaseCapture();
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x0007F710 File Offset: 0x0007D910
		private void update_avail_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A2C RID: 2604
		public static Point newpoint = default(Point);

		// Token: 0x04000A2D RID: 2605
		public static int x;

		// Token: 0x04000A2E RID: 2606
		public static int y;

		// Token: 0x04000A2F RID: 2607
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000A30 RID: 2608
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000A31 RID: 2609
		public const int HT_CAPTION = 2;
	}
}
