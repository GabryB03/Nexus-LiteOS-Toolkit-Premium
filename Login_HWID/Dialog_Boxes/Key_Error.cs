using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x02000075 RID: 117
	public partial class Key_Error : Form
	{
		// Token: 0x06000A1F RID: 2591
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000A20 RID: 2592 RVA: 0x0018C414 File Offset: 0x0018A614
		public Key_Error()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Key_Error.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000A22 RID: 2594
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000A23 RID: 2595
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000A24 RID: 2596 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000A25 RID: 2597 RVA: 0x0018C470 File Offset: 0x0018A670
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					Key_Error.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					Key_Error.ReleaseCapture();
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

		// Token: 0x06000A26 RID: 2598 RVA: 0x0007F710 File Offset: 0x0007D910
		private void Key_Error_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A00 RID: 2560
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000A01 RID: 2561
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000A02 RID: 2562
		public const int HT_CAPTION = 2;
	}
}
