using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001A RID: 26
	public partial class _200found : Form
	{
		// Token: 0x06000204 RID: 516
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000205 RID: 517 RVA: 0x0007B7D0 File Offset: 0x000799D0
		public _200found()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(_200found.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000207 RID: 519
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000208 RID: 520
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000209 RID: 521 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x0600020A RID: 522 RVA: 0x0007B82C File Offset: 0x00079A2C
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
					_200found.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					_200found.ReleaseCapture();
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

		// Token: 0x0600020B RID: 523 RVA: 0x00014010 File Offset: 0x00012210
		private void _200found_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000288 RID: 648
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000289 RID: 649
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400028A RID: 650
		public const int HT_CAPTION = 2;
	}
}
