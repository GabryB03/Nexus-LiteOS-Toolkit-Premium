using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000020 RID: 32
	public partial class Error : Form
	{
		// Token: 0x06000241 RID: 577
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000242 RID: 578 RVA: 0x000801D8 File Offset: 0x0007E3D8
		public Error()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Error.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000244 RID: 580
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000245 RID: 581
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000246 RID: 582 RVA: 0x00080234 File Offset: 0x0007E434
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					Error.ReleaseCapture();
					num = 4;
				}
				if (num == 4)
				{
					Error.SendMessage(base.Handle, 161, 2, 0);
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

		// Token: 0x06000247 RID: 583 RVA: 0x00013EFC File Offset: 0x000120FC
		private void button1_Click_1(object sender, EventArgs e)
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

		// Token: 0x06000248 RID: 584 RVA: 0x000802E8 File Offset: 0x0007E4E8
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://discord.com/channels/1015216380276129852/1015220281436012615");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0007F710 File Offset: 0x0007D910
		private void Error_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040002BE RID: 702
		private Point mouseOffset;

		// Token: 0x040002BF RID: 703
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002C0 RID: 704
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002C1 RID: 705
		public const int HT_CAPTION = 2;
	}
}
