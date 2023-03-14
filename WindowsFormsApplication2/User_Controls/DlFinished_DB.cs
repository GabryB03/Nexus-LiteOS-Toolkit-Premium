using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000010 RID: 16
	public partial class DlFinished_DB : Form
	{
		// Token: 0x06000081 RID: 129
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000082 RID: 130 RVA: 0x00016A3C File Offset: 0x00014C3C
		public DlFinished_DB(string info)
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(DlFinished_DB.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			Control.CheckForIllegalCrossThreadCalls = false;
			this.txtInfo.Text = info;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005628 File Offset: 0x00003828
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00016AB0 File Offset: 0x00014CB0
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

		// Token: 0x06000085 RID: 133 RVA: 0x00013EFC File Offset: 0x000120FC
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

		// Token: 0x06000086 RID: 134
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000087 RID: 135
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000088 RID: 136 RVA: 0x00016B3C File Offset: 0x00014D3C
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
					DlFinished_DB.SendMessage(base.Handle, 161, 2, 0);
					num = 5;
				}
				if (num == 3)
				{
					DlFinished_DB.ReleaseCapture();
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

		// Token: 0x06000089 RID: 137 RVA: 0x00016BF4 File Offset: 0x00014DF4
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

		// Token: 0x0600008A RID: 138 RVA: 0x00014010 File Offset: 0x00012210
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

		// Token: 0x0600008B RID: 139 RVA: 0x00016CDC File Offset: 0x00014EDC
		private void button2_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.openbtn.Location = new Point(226, 488);
					num = 3;
				}
				if (num == 4)
				{
					base.Size = new Size(467, 525);
					num = 5;
				}
				if (num == 7)
				{
					base.Region = Region.FromHrgn(DlFinished_DB.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
					num = 8;
				}
				if (num == 8)
				{
					base.CenterToParent();
					num = 9;
				}
				if (num == 6)
				{
					base.FormBorderStyle = FormBorderStyle.None;
					num = 7;
				}
				if (num == 5)
				{
					this.hide_btn.Location = new Point(1, 488);
					num = 6;
				}
				if (num == 3)
				{
					this.txtInfo.Location = new Point(11, 90);
					num = 4;
				}
				if (num == 1)
				{
					this.closebtn.Location = new Point(362, 488);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00016E74 File Offset: 0x00015074
		private void hide_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.closebtn.Location = new Point(320, 94);
					num = 3;
				}
				if (num == 4)
				{
					base.Size = new Size(467, 153);
					num = 5;
				}
				if (num == 7)
				{
					base.Region = Region.FromHrgn(DlFinished_DB.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
					num = 8;
				}
				if (num == 8)
				{
					base.CenterToParent();
					num = 9;
				}
				if (num == 6)
				{
					base.FormBorderStyle = FormBorderStyle.None;
					num = 7;
				}
				if (num == 5)
				{
					this.txtInfo.Location = new Point(11, 194);
					num = 6;
				}
				if (num == 3)
				{
					this.show_btn.Location = new Point(39, 94);
					num = 4;
				}
				if (num == 1)
				{
					this.openbtn.Location = new Point(175, 94);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x040000AD RID: 173
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040000AE RID: 174
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040000AF RID: 175
		public const int HT_CAPTION = 2;
	}
}
