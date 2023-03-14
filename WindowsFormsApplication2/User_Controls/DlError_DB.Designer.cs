namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000F RID: 15
	public partial class DlError_DB : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00015C28 File Offset: 0x00013E28
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

		// Token: 0x06000080 RID: 128 RVA: 0x00015CA0 File Offset: 0x00013EA0
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 3;
				}
				if (num == 4)
				{
					this.closebtn = new global::System.Windows.Forms.Button();
					num = 5;
				}
				if (num == 7)
				{
					this.txtInfo = new global::System.Windows.Forms.TextBox();
					num = 8;
				}
				if (num == 9)
				{
					base.SuspendLayout();
					num = 10;
				}
				if (num == 11)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 12;
				}
				if (num == 14)
				{
					this.label1.Name = "label1";
					num = 15;
				}
				if (num == 16)
				{
					this.label1.TabIndex = 1;
					num = 17;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 18)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 19;
				}
				if (num == 21)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 22;
				}
				if (num == 23)
				{
					this.pictureBox1.TabIndex = 0;
					num = 24;
				}
				if (num == 25)
				{
					this.closebtn.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 26;
				}
				if (num == 28)
				{
					this.closebtn.FlatAppearance.BorderSize = 0;
					num = 29;
				}
				if (num == 30)
				{
					this.closebtn.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 31;
				}
				if (num == 32)
				{
					this.closebtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("closebtn.Image");
					num = 33;
				}
				if (num == 35)
				{
					this.closebtn.Margin = new global::System.Windows.Forms.Padding(1);
					num = 36;
				}
				if (num == 37)
				{
					this.closebtn.Size = new global::System.Drawing.Size(85, 30);
					num = 38;
				}
				if (num == 39)
				{
					this.closebtn.TabStop = false;
					num = 40;
				}
				if (num == 42)
				{
					this.closebtn.UseVisualStyleBackColor = false;
					num = 43;
				}
				if (num == 44)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 45;
				}
				if (num == 46)
				{
					this.panel1.Name = "panel1";
					num = 47;
				}
				if (num == 49)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 50;
				}
				if (num == 51)
				{
					this.dl_location.Name = "dl_location";
					num = 52;
				}
				if (num == 53)
				{
					this.dl_location.TabIndex = 272;
					num = 54;
				}
				if (num == 56)
				{
					this.txtInfo.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
					num = 57;
				}
				if (num == 58)
				{
					this.txtInfo.ForeColor = global::System.Drawing.Color.White;
					num = 59;
				}
				if (num == 61)
				{
					this.txtInfo.Multiline = true;
					num = 62;
				}
				if (num == 63)
				{
					this.txtInfo.ReadOnly = true;
					num = 64;
				}
				if (num == 65)
				{
					this.txtInfo.Size = new global::System.Drawing.Size(454, 394);
					num = 66;
				}
				if (num == 68)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 69;
				}
				if (num == 70)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 71;
				}
				if (num == 72)
				{
					base.ControlBox = false;
					num = 73;
				}
				if (num == 75)
				{
					base.Controls.Add(this.panel1);
					num = 76;
				}
				if (num == 77)
				{
					base.Controls.Add(this.closebtn);
					num = 78;
				}
				if (num == 79)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 80;
				}
				if (num == 82)
				{
					base.Name = "DlError_DB";
					num = 83;
				}
				if (num == 84)
				{
					base.ShowInTaskbar = false;
					num = 85;
				}
				if (num == 86)
				{
					this.Text = "msgbox";
					num = 87;
				}
				if (num == 89)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 90;
				}
				if (num == 91)
				{
					base.PerformLayout();
					num = 92;
				}
				if (num == 90)
				{
					base.ResumeLayout(false);
					num = 91;
				}
				if (num == 88)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.custom_KeyDown);
					num = 89;
				}
				if (num == 87)
				{
					base.Load += new global::System.EventHandler(this.custom_Load);
					num = 88;
				}
				if (num == 85)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 86;
				}
				if (num == 83)
				{
					base.ShowIcon = false;
					num = 84;
				}
				if (num == 81)
				{
					this.MinimumSize = new global::System.Drawing.Size(467, 525);
					num = 82;
				}
				if (num == 80)
				{
					this.MaximumSize = new global::System.Drawing.Size(467, 525);
					num = 81;
				}
				if (num == 78)
				{
					base.Controls.Add(this.dl_location);
					num = 79;
				}
				if (num == 76)
				{
					base.Controls.Add(this.label1);
					num = 77;
				}
				if (num == 74)
				{
					base.Controls.Add(this.pictureBox1);
					num = 75;
				}
				if (num == 73)
				{
					base.Controls.Add(this.txtInfo);
					num = 74;
				}
				if (num == 71)
				{
					base.ClientSize = new global::System.Drawing.Size(467, 525);
					num = 72;
				}
				if (num == 69)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 70;
				}
				if (num == 67)
				{
					this.txtInfo.Text = "Download Log :";
					num = 68;
				}
				if (num == 66)
				{
					this.txtInfo.TabIndex = 277;
					num = 67;
				}
				if (num == 64)
				{
					this.txtInfo.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
					num = 65;
				}
				if (num == 62)
				{
					this.txtInfo.Name = "txtInfo";
					num = 63;
				}
				if (num == 60)
				{
					this.txtInfo.Margin = new global::System.Windows.Forms.Padding(2);
					num = 61;
				}
				if (num == 59)
				{
					this.txtInfo.Location = new global::System.Drawing.Point(11, 90);
					num = 60;
				}
				if (num == 57)
				{
					this.txtInfo.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 58;
				}
				if (num == 55)
				{
					this.txtInfo.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 56;
				}
				if (num == 54)
				{
					this.txtInfo.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
					num = 55;
				}
				if (num == 52)
				{
					this.dl_location.Size = new global::System.Drawing.Size(18, 20);
					num = 53;
				}
				if (num == 50)
				{
					this.dl_location.Location = new global::System.Drawing.Point(125, 39);
					num = 51;
				}
				if (num == 48)
				{
					this.panel1.TabIndex = 271;
					num = 49;
				}
				if (num == 47)
				{
					this.panel1.Size = new global::System.Drawing.Size(487, 32);
					num = 48;
				}
				if (num == 45)
				{
					this.panel1.Location = new global::System.Drawing.Point(1, -8);
					num = 46;
				}
				if (num == 43)
				{
					this.closebtn.Click += new global::System.EventHandler(this.button1_Click);
					num = 44;
				}
				if (num == 41)
				{
					this.closebtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 42;
				}
				if (num == 40)
				{
					this.closebtn.Text = "Close";
					num = 41;
				}
				if (num == 38)
				{
					this.closebtn.TabIndex = 270;
					num = 39;
				}
				if (num == 36)
				{
					this.closebtn.Name = "closebtn";
					num = 37;
				}
				if (num == 34)
				{
					this.closebtn.Location = new global::System.Drawing.Point(380, 487);
					num = 35;
				}
				if (num == 33)
				{
					this.closebtn.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 34;
				}
				if (num == 31)
				{
					this.closebtn.ForeColor = global::System.Drawing.Color.White;
					num = 32;
				}
				if (num == 29)
				{
					this.closebtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 30;
				}
				if (num == 27)
				{
					this.closebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 28;
				}
				if (num == 26)
				{
					this.closebtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 27;
				}
				if (num == 24)
				{
					this.pictureBox1.TabStop = false;
					num = 25;
				}
				if (num == 22)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 23;
				}
				if (num == 20)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 21;
				}
				if (num == 19)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(102, 13);
					num = 20;
				}
				if (num == 17)
				{
					this.label1.Text = "Download Failed!";
					num = 18;
				}
				if (num == 15)
				{
					this.label1.Size = new global::System.Drawing.Size(189, 34);
					num = 16;
				}
				if (num == 13)
				{
					this.label1.Location = new global::System.Drawing.Point(158, 27);
					num = 14;
				}
				if (num == 12)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 13;
				}
				if (num == 10)
				{
					this.label1.AutoSize = true;
					num = 11;
				}
				if (num == 8)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 9;
				}
				if (num == 6)
				{
					this.dl_location = new global::System.Windows.Forms.TextBox();
					num = 7;
				}
				if (num == 5)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 6;
				}
				if (num == 3)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.User_Controls.DlError_DB));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 92);
		}

		// Token: 0x040000A6 RID: 166
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Button closebtn;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TextBox dl_location;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.TextBox txtInfo;
	}
}
