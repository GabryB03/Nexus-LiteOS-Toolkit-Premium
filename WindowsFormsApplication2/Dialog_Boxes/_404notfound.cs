using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001B RID: 27
	public partial class _404notfound : Form
	{
		// Token: 0x0600020E RID: 526
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600020F RID: 527 RVA: 0x0007C4B4 File Offset: 0x0007A6B4
		public _404notfound()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(_404notfound.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000211 RID: 529
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000212 RID: 530
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000213 RID: 531 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000214 RID: 532 RVA: 0x0007C510 File Offset: 0x0007A710
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 4)
				{
					_404notfound.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					_404notfound.ReleaseCapture();
					num = 4;
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

		// Token: 0x06000215 RID: 533 RVA: 0x00014010 File Offset: 0x00012210
		private void _404notfound_KeyDown(object sender, KeyEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 3)
				{
					base.Close();
					num = 4;
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

		// Token: 0x04000291 RID: 657
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000292 RID: 658
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000293 RID: 659
		public const int HT_CAPTION = 2;
	}
}
