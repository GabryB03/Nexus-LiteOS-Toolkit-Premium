using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200005A RID: 90
	public class DlAppCard : UserControl
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x0000267F File Offset: 0x0000087F
		public DlAppCard()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000A5354 File Offset: 0x000A3554
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

		// Token: 0x060003EF RID: 1007 RVA: 0x000A53CC File Offset: 0x000A35CC
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.appImage = new PictureBox();
					num = 3;
				}
				if (num == 5)
				{
					this.size = new Label();
					num = 6;
				}
				if (num == 8)
				{
					this.appTitle.AutoSize = true;
					num = 9;
				}
				if (num == 11)
				{
					this.appTitle.CheckedState.BorderThickness = 0;
					num = 12;
				}
				if (num == 14)
				{
					this.appTitle.ForeColor = Color.White;
					num = 15;
				}
				if (num == 17)
				{
					this.appTitle.Size = new Size(111, 34);
					num = 18;
				}
				if (num == 20)
				{
					this.appTitle.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 21;
				}
				if (num == 23)
				{
					this.appTitle.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 24;
				}
				if (num == 26)
				{
					this.appImage.Size = new Size(32, 32);
					num = 27;
				}
				if (num == 29)
				{
					this.appImage.TabStop = false;
					num = 30;
				}
				if (num == 32)
				{
					this.version.ForeColor = Color.White;
					num = 33;
				}
				if (num == 35)
				{
					this.version.Size = new Size(0, 30);
					num = 36;
				}
				if (num == 38)
				{
					this.type.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 39;
				}
				if (num == 41)
				{
					this.type.Name = "type";
					num = 42;
				}
				if (num == 44)
				{
					this.size.AutoSize = true;
					num = 45;
				}
				if (num == 47)
				{
					this.size.Location = new Point(808, 7);
					num = 48;
				}
				if (num == 50)
				{
					this.size.TabIndex = 6;
					num = 51;
				}
				if (num == 53)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 54;
				}
				if (num == 56)
				{
					base.Controls.Add(this.version);
					num = 57;
				}
				if (num == 59)
				{
					base.Name = "DlAppCard";
					num = 60;
				}
				if (num == 62)
				{
					base.ResumeLayout(false);
					num = 63;
				}
				if (num == 63)
				{
					base.PerformLayout();
					num = 64;
				}
				if (num == 61)
				{
					((ISupportInitialize)this.appImage).EndInit();
					num = 62;
				}
				if (num == 60)
				{
					base.Size = new Size(931, 39);
					num = 61;
				}
				if (num == 58)
				{
					base.Controls.Add(this.appTitle);
					num = 59;
				}
				if (num == 57)
				{
					base.Controls.Add(this.appImage);
					num = 58;
				}
				if (num == 55)
				{
					base.Controls.Add(this.type);
					num = 56;
				}
				if (num == 54)
				{
					base.Controls.Add(this.size);
					num = 55;
				}
				if (num == 52)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 53;
				}
				if (num == 51)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 52;
				}
				if (num == 49)
				{
					this.size.Size = new Size(0, 30);
					num = 50;
				}
				if (num == 48)
				{
					this.size.Name = "size";
					num = 49;
				}
				if (num == 46)
				{
					this.size.ForeColor = Color.White;
					num = 47;
				}
				if (num == 45)
				{
					this.size.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 46;
				}
				if (num == 43)
				{
					this.type.TabIndex = 5;
					num = 44;
				}
				if (num == 42)
				{
					this.type.Size = new Size(0, 30);
					num = 43;
				}
				if (num == 40)
				{
					this.type.Location = new Point(645, 4);
					num = 41;
				}
				if (num == 39)
				{
					this.type.ForeColor = Color.White;
					num = 40;
				}
				if (num == 37)
				{
					this.type.AutoSize = true;
					num = 38;
				}
				if (num == 36)
				{
					this.version.TabIndex = 4;
					num = 37;
				}
				if (num == 34)
				{
					this.version.Name = "version";
					num = 35;
				}
				if (num == 33)
				{
					this.version.Location = new Point(395, 7);
					num = 34;
				}
				if (num == 31)
				{
					this.version.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 32;
				}
				if (num == 30)
				{
					this.version.AutoSize = true;
					num = 31;
				}
				if (num == 28)
				{
					this.appImage.TabIndex = 2;
					num = 29;
				}
				if (num == 27)
				{
					this.appImage.SizeMode = PictureBoxSizeMode.Zoom;
					num = 28;
				}
				if (num == 25)
				{
					this.appImage.Name = "appImage";
					num = 26;
				}
				if (num == 24)
				{
					this.appImage.Location = new Point(0, 3);
					num = 25;
				}
				if (num == 22)
				{
					this.appTitle.UncheckedState.BorderThickness = 0;
					num = 23;
				}
				if (num == 21)
				{
					this.appTitle.UncheckedState.BorderRadius = 0;
					num = 22;
				}
				if (num == 19)
				{
					this.appTitle.Text = "App Title";
					num = 20;
				}
				if (num == 18)
				{
					this.appTitle.TabIndex = 1;
					num = 19;
				}
				if (num == 16)
				{
					this.appTitle.Name = "appTitle";
					num = 17;
				}
				if (num == 15)
				{
					this.appTitle.Location = new Point(38, 3);
					num = 16;
				}
				if (num == 13)
				{
					this.appTitle.Font = new Font("Josefin Sans", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 14;
				}
				if (num == 12)
				{
					this.appTitle.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 13;
				}
				if (num == 10)
				{
					this.appTitle.CheckedState.BorderRadius = 0;
					num = 11;
				}
				if (num == 9)
				{
					this.appTitle.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 10;
				}
				if (num == 7)
				{
					base.SuspendLayout();
					num = 8;
				}
				if (num == 6)
				{
					((ISupportInitialize)this.appImage).BeginInit();
					num = 7;
				}
				if (num == 4)
				{
					this.type = new Label();
					num = 5;
				}
				if (num == 3)
				{
					this.version = new Label();
					num = 4;
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
			while (num != 64);
		}

		// Token: 0x04000463 RID: 1123
		private IContainer components = null;

		// Token: 0x04000464 RID: 1124
		public SiticoneCheckBox appTitle;

		// Token: 0x04000465 RID: 1125
		public PictureBox appImage;

		// Token: 0x04000466 RID: 1126
		public Label version;

		// Token: 0x04000467 RID: 1127
		public Label type;

		// Token: 0x04000468 RID: 1128
		public Label size;
	}
}
