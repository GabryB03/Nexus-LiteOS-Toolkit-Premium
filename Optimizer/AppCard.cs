using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Login_HWID;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;

namespace Optimizer
{
	// Token: 0x02000002 RID: 2
	public class AppCard : UserControl
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00003294 File Offset: 0x00001494
		public AppCard()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000032EC File Offset: 0x000014EC
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\");
					num = 2;
				}
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Theme");
					num = 3;
				}
				object obj;
				if (num == 4)
				{
					object obj2;
					obj = obj2;
					num = 5;
				}
				string text;
				if (num == 5)
				{
					text = obj as string;
					num = 6;
				}
				if (num != 7)
				{
					goto IL_9D;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_9D;
				}
				goto IL_F9;
				IL_189:
				if (num == 10)
				{
					break;
				}
				if (num == 6)
				{
					if (text == null)
					{
						break;
					}
					num = 7;
				}
				if (num == 3)
				{
					object obj2 = value;
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					break;
				}
				continue;
				IL_14A:
				if (num == 16 || num == 17)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_177;
				}
				goto IL_189;
				IL_10B:
				if (num == 12 || num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_138;
				}
				goto IL_14A;
				IL_9D:
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_177;
					}
					num = 9;
				}
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_138;
					}
					num = 10;
				}
				if (num == 11)
				{
					goto IL_F9;
				}
				goto IL_10B;
				IL_177:
				this.Halloween();
				num = 14;
				goto IL_189;
				IL_138:
				this.AccentColor();
				num = 16;
				goto IL_14A;
				IL_F9:
				this.Xmas_theme();
				num = 12;
				goto IL_10B;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003524 File Offset: 0x00001724
		private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (e.Category == UserPreferenceCategory.General)
					{
						goto IL_58;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag = e.Category == UserPreferenceCategory.VisualStyle;
			goto IL_5D;
			IL_58:
			flag = true;
			IL_5D:
			if (flag)
			{
				this.LoadTheme();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000359C File Offset: 0x0000179C
		private void Form_Disposed(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					SystemEvents.UserPreferenceChanged -= this.UserPreferenceChanged;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003600 File Offset: 0x00001800
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.appTitle.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.appTitle.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000036A4 File Offset: 0x000018A4
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 3)
				{
					this.appTitle.CheckedState.BorderColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.appTitle.CheckedState.FillColor = accentColor;
					num = 3;
				}
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003760 File Offset: 0x00001960
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.appTitle.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.appTitle.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003804 File Offset: 0x00001A04
		private void AppCard_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003844 File Offset: 0x00001A44
		protected override void Dispose(bool disposing)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (!disposing)
					{
						goto Block_4;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag = this.components != null;
			goto IL_4D;
			Block_4:
			flag = false;
			IL_4D:
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000038BC File Offset: 0x00001ABC
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 14)
				{
					this.appTitle.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 15;
				}
				if (num == 29)
				{
					base.PerformLayout();
					num = 30;
				}
				if (num == 28)
				{
					base.ResumeLayout(false);
					num = 29;
				}
				if (num == 27)
				{
					base.Load += this.AppCard_Load;
					num = 28;
				}
				if (num == 26)
				{
					base.Size = new Size(101, 33);
					num = 27;
				}
				if (num == 25)
				{
					base.Name = "AppCard";
					num = 26;
				}
				if (num == 24)
				{
					this.ForeColor = Color.White;
					num = 25;
				}
				if (num == 23)
				{
					this.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
					num = 24;
				}
				if (num == 22)
				{
					this.DoubleBuffered = true;
					num = 23;
				}
				if (num == 21)
				{
					base.Controls.Add(this.appTitle);
					num = 22;
				}
				if (num == 20)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 21;
				}
				if (num == 19)
				{
					base.AutoScaleMode = AutoScaleMode.Dpi;
					num = 20;
				}
				if (num == 18)
				{
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = 19;
				}
				if (num == 17)
				{
					this.appTitle.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 18;
				}
				if (num == 16)
				{
					this.appTitle.UncheckedState.BorderThickness = 0;
					num = 17;
				}
				if (num == 15)
				{
					this.appTitle.UncheckedState.BorderRadius = 0;
					num = 16;
				}
				if (num == 13)
				{
					this.appTitle.Text = "App Title";
					num = 14;
				}
				if (num == 12)
				{
					this.appTitle.TabIndex = 0;
					num = 13;
				}
				if (num == 11)
				{
					this.appTitle.Size = new Size(93, 28);
					num = 12;
				}
				if (num == 10)
				{
					this.appTitle.Name = "appTitle";
					num = 11;
				}
				if (num == 9)
				{
					this.appTitle.Location = new Point(4, 4);
					num = 10;
				}
				if (num == 8)
				{
					this.appTitle.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 9;
				}
				if (num == 7)
				{
					this.appTitle.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 8;
				}
				if (num == 6)
				{
					this.appTitle.CheckedState.BorderThickness = 0;
					num = 7;
				}
				if (num == 5)
				{
					this.appTitle.CheckedState.BorderRadius = 0;
					num = 6;
				}
				if (num == 4)
				{
					this.appTitle.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 5;
				}
				if (num == 3)
				{
					this.appTitle.AutoSize = true;
					num = 4;
				}
				if (num == 2)
				{
					base.SuspendLayout();
					num = 3;
				}
				if (num == 1)
				{
					this.appTitle = new SiticoneCheckBox();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 30);
		}

		// Token: 0x04000001 RID: 1
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000002 RID: 2
		private IContainer components = null;

		// Token: 0x04000003 RID: 3
		public SiticoneCheckBox appTitle;
	}
}
