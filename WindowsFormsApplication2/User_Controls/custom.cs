using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000E RID: 14
	public partial class custom : Form
	{
		// Token: 0x0600006B RID: 107
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600006C RID: 108 RVA: 0x00014ABC File Offset: 0x00012CBC
		public custom()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(custom.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00014B18 File Offset: 0x00012D18
		private void button7_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					base.Close();
					num = 3;
				}
				if (num == 1)
				{
					Process.Start("explorer.exe", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000070 RID: 112
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000071 RID: 113
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000072 RID: 114 RVA: 0x00014B9C File Offset: 0x00012D9C
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
					custom.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					custom.ReleaseCapture();
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

		// Token: 0x04000099 RID: 153
		private Point mouseOffset;

		// Token: 0x0400009A RID: 154
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400009B RID: 155
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400009C RID: 156
		public const int HT_CAPTION = 2;
	}
}
