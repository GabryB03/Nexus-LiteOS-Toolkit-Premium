using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001F RID: 31
	public partial class dns : Form
	{
		// Token: 0x06000237 RID: 567
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000238 RID: 568 RVA: 0x0007F600 File Offset: 0x0007D800
		public dns()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(dns.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x0600023A RID: 570
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600023B RID: 571
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600023C RID: 572 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x0600023D RID: 573 RVA: 0x0007F65C File Offset: 0x0007D85C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					dns.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					dns.SendMessage(base.Handle, 161, 2, 0);
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

		// Token: 0x0600023E RID: 574 RVA: 0x0007F710 File Offset: 0x0007D910
		private void dns_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040002B5 RID: 693
		private Point mouseOffset;

		// Token: 0x040002B6 RID: 694
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002B7 RID: 695
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002B8 RID: 696
		public const int HT_CAPTION = 2;
	}
}
