using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x02000076 RID: 118
	public partial class LoginUser_Error : Form
	{
		// Token: 0x06000A29 RID: 2601
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000A2A RID: 2602 RVA: 0x0018D0D0 File Offset: 0x0018B2D0
		public LoginUser_Error()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(LoginUser_Error.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000A2C RID: 2604
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000A2D RID: 2605
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000A2E RID: 2606 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000A2F RID: 2607 RVA: 0x0018D12C File Offset: 0x0018B32C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					LoginUser_Error.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					LoginUser_Error.ReleaseCapture();
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

		// Token: 0x06000A30 RID: 2608 RVA: 0x0007F710 File Offset: 0x0007D910
		private void LoginUser_Error_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000A09 RID: 2569
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000A0A RID: 2570
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000A0B RID: 2571
		public const int HT_CAPTION = 2;
	}
}
