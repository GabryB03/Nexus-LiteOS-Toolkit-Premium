using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000021 RID: 33
	public partial class gb_404 : Form
	{
		// Token: 0x0600024C RID: 588
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600024D RID: 589 RVA: 0x00081410 File Offset: 0x0007F610
		public gb_404()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(gb_404.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x0600024F RID: 591
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000250 RID: 592
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000251 RID: 593 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000252 RID: 594 RVA: 0x0008146C File Offset: 0x0007F66C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					gb_404.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					gb_404.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
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

		// Token: 0x06000253 RID: 595 RVA: 0x0007F710 File Offset: 0x0007D910
		private void gb_404_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040002CB RID: 715
		private Point mouseOffset;

		// Token: 0x040002CC RID: 716
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002CD RID: 717
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002CE RID: 718
		public const int HT_CAPTION = 2;
	}
}
