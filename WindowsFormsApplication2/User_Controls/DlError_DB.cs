using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000F RID: 15
	public partial class DlError_DB : Form
	{
		// Token: 0x06000075 RID: 117
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000076 RID: 118 RVA: 0x00015988 File Offset: 0x00013B88
		public DlError_DB(string info)
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(DlError_DB.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			Control.CheckForIllegalCrossThreadCalls = false;
			this.txtInfo.Text = info;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000159FC File Offset: 0x00013BFC
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
					Process.Start("explorer.exe", this.dl_location.Text);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x0600007A RID: 122
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600007B RID: 123
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600007C RID: 124 RVA: 0x00015A88 File Offset: 0x00013C88
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
					DlError_DB.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					DlError_DB.ReleaseCapture();
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

		// Token: 0x0600007D RID: 125 RVA: 0x00015B40 File Offset: 0x00013D40
		private void custom_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				object value;
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("Default Downloads Location");
					num = 3;
				}
				if (num != 4)
				{
					goto IL_1E;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_1E;
				}
				goto IL_28;
				IL_41:
				if (num == 5)
				{
					this.dl_location.Text = value.ToString();
					num = 6;
				}
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 7)
				{
					continue;
				}
				break;
				IL_1E:
				if (num != 6)
				{
					goto IL_41;
				}
				IL_28:
				this.dl_location.ReadOnly = true;
				num = 7;
				goto IL_41;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00014010 File Offset: 0x00012210
		private void custom_KeyDown(object sender, KeyEventArgs e)
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

		// Token: 0x040000A3 RID: 163
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040000A4 RID: 164
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040000A5 RID: 165
		public const int HT_CAPTION = 2;
	}
}
