using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000022 RID: 34
	public partial class g_404 : Form
	{
		// Token: 0x06000256 RID: 598
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000257 RID: 599 RVA: 0x00081F64 File Offset: 0x00080164
		public g_404()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(g_404.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000259 RID: 601
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600025A RID: 602
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600025B RID: 603 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x0600025C RID: 604 RVA: 0x00081FC0 File Offset: 0x000801C0
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					g_404.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					g_404.SendMessage(base.Handle, 161, 2, 0);
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

		// Token: 0x0600025D RID: 605 RVA: 0x0007F710 File Offset: 0x0007D910
		private void g_404_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040002D4 RID: 724
		private Point mouseOffset;

		// Token: 0x040002D5 RID: 725
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002D6 RID: 726
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002D7 RID: 727
		public const int HT_CAPTION = 2;
	}
}
