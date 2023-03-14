namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000010 RID: 16
	public partial class DlFinished_DB : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0001700C File Offset: 0x0001520C
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

		// Token: 0x0600008E RID: 142 RVA: 0x00017084 File Offset: 0x00015284
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
					this.dl_location = new global::System.Windows.Forms.TextBox();
					num = 5;
				}
				if (num == 7)
				{
					this.show_btn = new global::System.Windows.Forms.Button();
					num = 8;
				}
				if (num == 9)
				{
					this.closebtn = new global::System.Windows.Forms.Button();
					num = 10;
				}
				if (num == 11)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 12;
				}
				if (num == 14)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 15;
				}
				if (num == 16)
				{
					this.label1.Location = new global::System.Drawing.Point(138, 27);
					num = 17;
				}
				if (num == 18)
				{
					this.label1.Size = new global::System.Drawing.Size(236, 34);
					num = 19;
				}
				if (num == 21)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 22;
				}
				if (num == 23)
				{
					this.panel1.Name = "panel1";
					num = 24;
				}
				if (num == 25)
				{
					this.panel1.TabIndex = 271;
					num = 26;
				}
				if (num == 28)
				{
					this.dl_location.Name = "dl_location";
					num = 29;
				}
				if (num == 30)
				{
					this.dl_location.TabIndex = 272;
					num = 31;
				}
				if (num == 32)
				{
					this.txtInfo.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 33;
				}
				if (num == 35)
				{
					this.txtInfo.ForeColor = global::System.Drawing.Color.White;
					num = 36;
				}
				if (num == 37)
				{
					this.txtInfo.Margin = new global::System.Windows.Forms.Padding(2);
					num = 38;
				}
				if (num == 39)
				{
					this.txtInfo.Name = "txtInfo";
					num = 40;
				}
				if (num == 42)
				{
					this.txtInfo.Size = new global::System.Drawing.Size(454, 22);
					num = 43;
				}
				if (num == 44)
				{
					this.txtInfo.Text = "Download Log :";
					num = 45;
				}
				if (num == 46)
				{
					this.hide_btn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 47;
				}
				if (num == 49)
				{
					this.hide_btn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 50;
				}
				if (num == 51)
				{
					this.hide_btn.ForeColor = global::System.Drawing.Color.White;
					num = 52;
				}
				if (num == 53)
				{
					this.hide_btn.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 54;
				}
				if (num == 56)
				{
					this.hide_btn.Name = "hide_btn";
					num = 57;
				}
				if (num == 58)
				{
					this.hide_btn.TabIndex = 278;
					num = 59;
				}
				if (num == 61)
				{
					this.hide_btn.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 62;
				}
				if (num == 63)
				{
					this.hide_btn.Click += new global::System.EventHandler(this.hide_btn_Click);
					num = 64;
				}
				if (num == 65)
				{
					this.show_btn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 66;
				}
				if (num == 68)
				{
					this.show_btn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 69;
				}
				if (num == 70)
				{
					this.show_btn.ForeColor = global::System.Drawing.Color.White;
					num = 71;
				}
				if (num == 72)
				{
					this.show_btn.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 73;
				}
				if (num == 75)
				{
					this.show_btn.Name = "show_btn";
					num = 76;
				}
				if (num == 77)
				{
					this.show_btn.TabIndex = 274;
					num = 78;
				}
				if (num == 79)
				{
					this.show_btn.Text = "Show Details";
					num = 80;
				}
				if (num == 82)
				{
					this.show_btn.Click += new global::System.EventHandler(this.button2_Click);
					num = 83;
				}
				if (num == 84)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(82, 13);
					num = 85;
				}
				if (num == 86)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 87;
				}
				if (num == 89)
				{
					this.pictureBox1.TabStop = false;
					num = 90;
				}
				if (num == 91)
				{
					this.closebtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 92;
				}
				if (num == 93)
				{
					this.closebtn.FlatAppearance.BorderSize = 0;
					num = 94;
				}
				if (num == 96)
				{
					this.closebtn.ForeColor = global::System.Drawing.Color.White;
					num = 97;
				}
				if (num == 98)
				{
					this.closebtn.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 99;
				}
				if (num == 100)
				{
					this.closebtn.Margin = new global::System.Windows.Forms.Padding(1);
					num = 101;
				}
				if (num == 103)
				{
					this.closebtn.TabIndex = 270;
					num = 104;
				}
				if (num == 105)
				{
					this.closebtn.Text = "Close";
					num = 106;
				}
				if (num == 107)
				{
					this.closebtn.UseVisualStyleBackColor = false;
					num = 108;
				}
				if (num == 110)
				{
					this.openbtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 111;
				}
				if (num == 112)
				{
					this.openbtn.FlatAppearance.BorderSize = 0;
					num = 113;
				}
				if (num == 115)
				{
					this.openbtn.ForeColor = global::System.Drawing.Color.White;
					num = 116;
				}
				if (num == 117)
				{
					this.openbtn.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 118;
				}
				if (num == 119)
				{
					this.openbtn.Margin = new global::System.Windows.Forms.Padding(1);
					num = 120;
				}
				if (num == 122)
				{
					this.openbtn.TabIndex = 269;
					num = 123;
				}
				if (num == 124)
				{
					this.openbtn.Text = "Open Folder";
					num = 125;
				}
				if (num == 126)
				{
					this.openbtn.UseVisualStyleBackColor = false;
					num = 127;
				}
				if (num == 129)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 130;
				}
				if (num == 131)
				{
					base.ClientSize = new global::System.Drawing.Size(467, 153);
					num = 132;
				}
				if (num == 133)
				{
					base.Controls.Add(this.hide_btn);
					num = 134;
				}
				if (num == 136)
				{
					base.Controls.Add(this.pictureBox1);
					num = 137;
				}
				if (num == 138)
				{
					base.Controls.Add(this.label1);
					num = 139;
				}
				if (num == 140)
				{
					base.Controls.Add(this.openbtn);
					num = 141;
				}
				if (num == 143)
				{
					this.MaximumSize = new global::System.Drawing.Size(467, 525);
					num = 144;
				}
				if (num == 145)
				{
					base.Name = "DlFinished_DB";
					num = 146;
				}
				if (num == 147)
				{
					base.ShowInTaskbar = false;
					num = 148;
				}
				if (num == 150)
				{
					base.Load += new global::System.EventHandler(this.custom_Load);
					num = 151;
				}
				if (num == 152)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 153;
				}
				if (num == 154)
				{
					base.PerformLayout();
					num = 155;
				}
				if (num == 153)
				{
					base.ResumeLayout(false);
					num = 154;
				}
				if (num == 151)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.custom_KeyDown);
					num = 152;
				}
				if (num == 149)
				{
					this.Text = "msgbox";
					num = 150;
				}
				if (num == 148)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 149;
				}
				if (num == 146)
				{
					base.ShowIcon = false;
					num = 147;
				}
				if (num == 144)
				{
					this.MinimumSize = new global::System.Drawing.Size(467, 153);
					num = 145;
				}
				if (num == 142)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 143;
				}
				if (num == 141)
				{
					base.Controls.Add(this.dl_location);
					num = 142;
				}
				if (num == 139)
				{
					base.Controls.Add(this.closebtn);
					num = 140;
				}
				if (num == 137)
				{
					base.Controls.Add(this.panel1);
					num = 138;
				}
				if (num == 135)
				{
					base.Controls.Add(this.show_btn);
					num = 136;
				}
				if (num == 134)
				{
					base.Controls.Add(this.txtInfo);
					num = 135;
				}
				if (num == 132)
				{
					base.ControlBox = false;
					num = 133;
				}
				if (num == 130)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 131;
				}
				if (num == 128)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 129;
				}
				if (num == 127)
				{
					this.openbtn.Click += new global::System.EventHandler(this.button7_Click);
					num = 128;
				}
				if (num == 125)
				{
					this.openbtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 126;
				}
				if (num == 123)
				{
					this.openbtn.TabStop = false;
					num = 124;
				}
				if (num == 121)
				{
					this.openbtn.Size = new global::System.Drawing.Size(134, 30);
					num = 122;
				}
				if (num == 120)
				{
					this.openbtn.Name = "openbtn";
					num = 121;
				}
				if (num == 118)
				{
					this.openbtn.Location = new global::System.Drawing.Point(175, 94);
					num = 119;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 116)
				{
					this.openbtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openbtn.Image");
					num = 117;
				}
				if (num == 114)
				{
					this.openbtn.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 115;
				}
				if (num == 113)
				{
					this.openbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 114;
				}
				if (num == 111)
				{
					this.openbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 112;
				}
				if (num == 109)
				{
					this.openbtn.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 110;
				}
				if (num == 108)
				{
					this.closebtn.Click += new global::System.EventHandler(this.button1_Click);
					num = 109;
				}
				if (num == 106)
				{
					this.closebtn.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 107;
				}
				if (num == 104)
				{
					this.closebtn.TabStop = false;
					num = 105;
				}
				if (num == 102)
				{
					this.closebtn.Size = new global::System.Drawing.Size(85, 30);
					num = 103;
				}
				if (num == 101)
				{
					this.closebtn.Name = "closebtn";
					num = 102;
				}
				if (num == 99)
				{
					this.closebtn.Location = new global::System.Drawing.Point(320, 94);
					num = 100;
				}
				if (num == 97)
				{
					this.closebtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("closebtn.Image");
					num = 98;
				}
				if (num == 95)
				{
					this.closebtn.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 96;
				}
				if (num == 94)
				{
					this.closebtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 95;
				}
				if (num == 92)
				{
					this.closebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 93;
				}
				if (num == 90)
				{
					this.closebtn.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 91;
				}
				if (num == 88)
				{
					this.pictureBox1.TabIndex = 0;
					num = 89;
				}
				if (num == 87)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 88;
				}
				if (num == 85)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 86;
				}
				if (num == 83)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 84;
				}
				if (num == 81)
				{
					this.show_btn.UseVisualStyleBackColor = false;
					num = 82;
				}
				if (num == 80)
				{
					this.show_btn.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 81;
				}
				if (num == 78)
				{
					this.show_btn.TabStop = false;
					num = 79;
				}
				if (num == 76)
				{
					this.show_btn.Size = new global::System.Drawing.Size(142, 30);
					num = 77;
				}
				if (num == 74)
				{
					this.show_btn.Margin = new global::System.Windows.Forms.Padding(1);
					num = 75;
				}
				if (num == 73)
				{
					this.show_btn.Location = new global::System.Drawing.Point(31, 94);
					num = 74;
				}
				if (num == 71)
				{
					this.show_btn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("show_btn.Image");
					num = 72;
				}
				if (num == 69)
				{
					this.show_btn.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 70;
				}
				if (num == 67)
				{
					this.show_btn.FlatAppearance.BorderSize = 0;
					num = 68;
				}
				if (num == 66)
				{
					this.show_btn.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 67;
				}
				if (num == 64)
				{
					this.show_btn.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 65;
				}
				if (num == 62)
				{
					this.hide_btn.UseVisualStyleBackColor = false;
					num = 63;
				}
				if (num == 60)
				{
					this.hide_btn.Text = "Hide Details";
					num = 61;
				}
				if (num == 59)
				{
					this.hide_btn.TabStop = false;
					num = 60;
				}
				if (num == 57)
				{
					this.hide_btn.Size = new global::System.Drawing.Size(142, 30);
					num = 58;
				}
				if (num == 55)
				{
					this.hide_btn.Margin = new global::System.Windows.Forms.Padding(1);
					num = 56;
				}
				if (num == 54)
				{
					this.hide_btn.Location = new global::System.Drawing.Point(11, 487);
					num = 55;
				}
				if (num == 52)
				{
					this.hide_btn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("hide_btn.Image");
					num = 53;
				}
				if (num == 50)
				{
					this.hide_btn.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 51;
				}
				if (num == 48)
				{
					this.hide_btn.FlatAppearance.BorderSize = 0;
					num = 49;
				}
				if (num == 47)
				{
					this.hide_btn.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 48;
				}
				if (num == 45)
				{
					this.hide_btn.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 46;
				}
				if (num == 43)
				{
					this.txtInfo.TabIndex = 277;
					num = 44;
				}
				if (num == 41)
				{
					this.txtInfo.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
					num = 42;
				}
				if (num == 40)
				{
					this.txtInfo.ReadOnly = true;
					num = 41;
				}
				if (num == 38)
				{
					this.txtInfo.Multiline = true;
					num = 39;
				}
				if (num == 36)
				{
					this.txtInfo.Location = new global::System.Drawing.Point(11, 194);
					num = 37;
				}
				if (num == 34)
				{
					this.txtInfo.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 35;
				}
				if (num == 33)
				{
					this.txtInfo.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
					num = 34;
				}
				if (num == 31)
				{
					this.txtInfo.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
					num = 32;
				}
				if (num == 29)
				{
					this.dl_location.Size = new global::System.Drawing.Size(18, 20);
					num = 30;
				}
				if (num == 27)
				{
					this.dl_location.Location = new global::System.Drawing.Point(105, 39);
					num = 28;
				}
				if (num == 26)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 27;
				}
				if (num == 24)
				{
					this.panel1.Size = new global::System.Drawing.Size(487, 32);
					num = 25;
				}
				if (num == 22)
				{
					this.panel1.Location = new global::System.Drawing.Point(1, -8);
					num = 23;
				}
				if (num == 20)
				{
					this.label1.Text = "Download Completed!";
					num = 21;
				}
				if (num == 19)
				{
					this.label1.TabIndex = 1;
					num = 20;
				}
				if (num == 17)
				{
					this.label1.Name = "label1";
					num = 18;
				}
				if (num == 15)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 16;
				}
				if (num == 13)
				{
					this.label1.AutoSize = true;
					num = 14;
				}
				if (num == 12)
				{
					base.SuspendLayout();
					num = 13;
				}
				if (num == 10)
				{
					this.openbtn = new global::System.Windows.Forms.Button();
					num = 11;
				}
				if (num == 8)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 9;
				}
				if (num == 6)
				{
					this.hide_btn = new global::System.Windows.Forms.Button();
					num = 7;
				}
				if (num == 5)
				{
					this.txtInfo = new global::System.Windows.Forms.TextBox();
					num = 6;
				}
				if (num == 3)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.User_Controls.DlFinished_DB));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 155);
		}

		// Token: 0x040000B0 RID: 176
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Button openbtn;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Button closebtn;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.TextBox dl_location;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Button show_btn;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.TextBox txtInfo;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Button hide_btn;
	}
}
