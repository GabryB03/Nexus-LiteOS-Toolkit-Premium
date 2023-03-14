using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000024 RID: 36
	public partial class removed : Form
	{
		// Token: 0x0600026A RID: 618
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600026B RID: 619 RVA: 0x00083794 File Offset: 0x00081994
		public removed()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(removed.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x0600026D RID: 621
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600026E RID: 622
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600026F RID: 623 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000270 RID: 624 RVA: 0x000837F0 File Offset: 0x000819F0
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = e.Button == MouseButtons.Left;
					num = 2;
				}
				if (num == 2)
				{
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 3)
				{
					removed.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					removed.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000838A8 File Offset: 0x00081AA8
		private void removed_KeyDown(object sender, KeyEventArgs e)
		{
			int num = 0;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = e.KeyCode == Keys.Return;
					num = 2;
				}
				if (num == 2)
				{
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
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x040002E7 RID: 743
		private Point mouseOffset;

		// Token: 0x040002E8 RID: 744
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002E9 RID: 745
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002EA RID: 746
		public const int HT_CAPTION = 2;
	}
}
