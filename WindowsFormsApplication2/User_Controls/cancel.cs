using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000D RID: 13
	public partial class cancel : Form
	{
		// Token: 0x06000061 RID: 97
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000062 RID: 98 RVA: 0x00013EA0 File Offset: 0x000120A0
		public cancel()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(cancel.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000065 RID: 101
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000066 RID: 102
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000067 RID: 103 RVA: 0x00013F58 File Offset: 0x00012158
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
					cancel.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					cancel.ReleaseCapture();
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

		// Token: 0x06000068 RID: 104 RVA: 0x00014010 File Offset: 0x00012210
		private void cancel_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000090 RID: 144
		private Point mouseOffset;

		// Token: 0x04000091 RID: 145
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000092 RID: 146
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000093 RID: 147
		public const int HT_CAPTION = 2;
	}
}
