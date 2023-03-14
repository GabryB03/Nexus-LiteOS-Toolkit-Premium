using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000029 RID: 41
	public partial class update : Form
	{
		// Token: 0x0600029D RID: 669
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600029E RID: 670 RVA: 0x000871CC File Offset: 0x000853CC
		public update()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(update.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x060002A0 RID: 672
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060002A1 RID: 673
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060002A2 RID: 674 RVA: 0x00087228 File Offset: 0x00085428
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 7)
				{
					goto IL_4E;
				}
				IL_5D:
				if (num != 6)
				{
					RegistryKey registryKey;
					if (num == 5)
					{
						registryKey.Close();
						num = 6;
					}
					if (num == 4)
					{
						registryKey.DeleteValue("Auto Login", false);
						num = 5;
					}
					if (num == 3)
					{
						bool flag;
						if (!flag)
						{
							goto IL_4E;
						}
						num = 4;
					}
					if (num == 2)
					{
						bool flag = registryKey != null;
						num = 3;
					}
					if (num == 1)
					{
						registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Nexus LiteOS Toolkit");
						num = 2;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num != 8)
					{
						continue;
					}
					break;
				}
				IL_4E:
				base.Close();
				num = 8;
				goto IL_5D;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00087304 File Offset: 0x00085504
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					update.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					update.ReleaseCapture();
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

		// Token: 0x060002A4 RID: 676 RVA: 0x0007F710 File Offset: 0x0007D910
		private void update_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x04000315 RID: 789
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000316 RID: 790
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000317 RID: 791
		public const int HT_CAPTION = 2;
	}
}
