using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001C RID: 28
	public partial class added : Form
	{
		// Token: 0x06000218 RID: 536
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000219 RID: 537 RVA: 0x0007D320 File Offset: 0x0007B520
		public added()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(added.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x0600021B RID: 539
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600021C RID: 540
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600021D RID: 541 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x0600021E RID: 542 RVA: 0x0007D37C File Offset: 0x0007B57C
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
					added.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					added.ReleaseCapture();
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

		// Token: 0x0600021F RID: 543 RVA: 0x0007D434 File Offset: 0x0007B634
		private void added_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				object value;
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("AMOLED Mode");
					num = 3;
				}
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 5;
				}
				if (num == 6)
				{
					this.button1.BackColor = Color.FromArgb(0, 0, 0);
					num = 7;
				}
				if (num == 5)
				{
					this.BackColor = Color.FromArgb(0, 0, 0);
					num = 6;
				}
				if (num == 3)
				{
					bool flag = value != null;
					num = 4;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00014010 File Offset: 0x00012210
		private void added_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x0400029B RID: 667
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400029C RID: 668
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400029D RID: 669
		public const int HT_CAPTION = 2;
	}
}
