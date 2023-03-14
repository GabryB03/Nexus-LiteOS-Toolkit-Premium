using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200007D RID: 125
	public partial class Validated : Form
	{
		// Token: 0x06000A71 RID: 2673
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000A72 RID: 2674 RVA: 0x00192818 File Offset: 0x00190A18
		public Validated()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Login_HWID.Dialog_Boxes.Validated.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000A74 RID: 2676
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000A75 RID: 2677
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000A76 RID: 2678 RVA: 0x00192874 File Offset: 0x00190A74
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://discord.gg/QjJW5cHxGB");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000A78 RID: 2680 RVA: 0x001928D4 File Offset: 0x00190AD4
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					Login_HWID.Dialog_Boxes.Validated.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					Login_HWID.Dialog_Boxes.Validated.ReleaseCapture();
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

		// Token: 0x06000A79 RID: 2681 RVA: 0x0007F710 File Offset: 0x0007D910
		private void Validated_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A4D RID: 2637
		private Point mouseOffset;

		// Token: 0x04000A4E RID: 2638
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000A4F RID: 2639
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000A50 RID: 2640
		public const int HT_CAPTION = 2;
	}
}
