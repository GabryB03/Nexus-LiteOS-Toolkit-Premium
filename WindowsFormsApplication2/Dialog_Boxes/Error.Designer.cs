namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000020 RID: 32
	public partial class Error : global::System.Windows.Forms.Form
	{
		// Token: 0x0600024A RID: 586 RVA: 0x00080348 File Offset: 0x0007E548
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

		// Token: 0x0600024B RID: 587 RVA: 0x000803C0 File Offset: 0x0007E5C0
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 4;
				}
				if (num == 6)
				{
					this.label9 = new global::System.Windows.Forms.Label();
					num = 7;
				}
				if (num == 9)
				{
					this.label3 = new global::System.Windows.Forms.Label();
					num = 10;
				}
				if (num == 12)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 13;
				}
				if (num == 15)
				{
					this.panel1.Size = new global::System.Drawing.Size(524, 32);
					num = 16;
				}
				if (num == 19)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(43, 15);
					num = 20;
				}
				if (num == 22)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 23;
				}
				if (num == 25)
				{
					this.label1.AutoSize = true;
					num = 26;
				}
				if (num == 28)
				{
					this.label1.Location = new global::System.Drawing.Point(99, 29);
					num = 29;
				}
				if (num == 31)
				{
					this.label1.TabIndex = 278;
					num = 32;
				}
				if (num == 34)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 35;
				}
				if (num == 38)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 39;
				}
				if (num == 41)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 42;
				}
				if (num == 44)
				{
					this.button1.Name = "button1";
					num = 45;
				}
				if (num == 47)
				{
					this.button1.TabStop = false;
					num = 48;
				}
				if (num == 50)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 51;
				}
				if (num == 54)
				{
					this.label9.ForeColor = global::System.Drawing.Color.Silver;
					num = 55;
				}
				if (num == 57)
				{
					this.label9.Size = new global::System.Drawing.Size(430, 19);
					num = 58;
				}
				if (num == 60)
				{
					this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.SteelBlue;
					num = 61;
				}
				if (num == 63)
				{
					this.linkLabel1.Location = new global::System.Drawing.Point(9, 154);
					num = 64;
				}
				if (num == 66)
				{
					this.linkLabel1.TabIndex = 282;
					num = 67;
				}
				if (num == 69)
				{
					this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 70;
				}
				if (num == 73)
				{
					this.label2.ForeColor = global::System.Drawing.Color.Silver;
					num = 74;
				}
				if (num == 76)
				{
					this.label2.Size = new global::System.Drawing.Size(407, 19);
					num = 77;
				}
				if (num == 79)
				{
					this.label3.AutoSize = true;
					num = 80;
				}
				if (num == 82)
				{
					this.label3.Location = new global::System.Drawing.Point(195, 113);
					num = 83;
				}
				if (num == 85)
				{
					this.label3.TabIndex = 283;
					num = 86;
				}
				if (num == 88)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 89;
				}
				if (num == 92)
				{
					base.Controls.Add(this.label3);
					num = 93;
				}
				if (num == 95)
				{
					base.Controls.Add(this.label9);
					num = 96;
				}
				if (num == 98)
				{
					base.Controls.Add(this.button1);
					num = 99;
				}
				if (num == 101)
				{
					base.Name = "Error";
					num = 102;
				}
				if (num == 104)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 105;
				}
				if (num == 108)
				{
					base.ResumeLayout(false);
					num = 109;
				}
				if (num == 109)
				{
					base.PerformLayout();
					num = 110;
				}
				if (num == 107)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 108;
				}
				if (num == 106)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Error_KeyDown);
					num = 107;
				}
				if (num == 105)
				{
					this.Text = "Error";
					num = 106;
				}
				if (num == 103)
				{
					base.ShowInTaskbar = false;
					num = 104;
				}
				if (num == 102)
				{
					base.ShowIcon = false;
					num = 103;
				}
				if (num == 100)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 101;
				}
				if (num == 99)
				{
					base.Controls.Add(this.panel1);
					num = 100;
				}
				if (num == 97)
				{
					base.Controls.Add(this.label1);
					num = 98;
				}
				if (num == 96)
				{
					base.Controls.Add(this.pictureBox1);
					num = 97;
				}
				if (num == 94)
				{
					base.Controls.Add(this.label2);
					num = 95;
				}
				if (num == 93)
				{
					base.Controls.Add(this.linkLabel1);
					num = 94;
				}
				if (num == 91)
				{
					base.ControlBox = false;
					num = 92;
				}
				if (num == 90)
				{
					base.ClientSize = new global::System.Drawing.Size(440, 183);
					num = 91;
				}
				if (num == 89)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 90;
				}
				if (num == 87)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 88;
				}
				if (num == 86)
				{
					this.label3.Text = "still exists";
					num = 87;
				}
				if (num == 84)
				{
					this.label3.Size = new global::System.Drawing.Size(60, 19);
					num = 85;
				}
				if (num == 83)
				{
					this.label3.Name = "label3";
					num = 84;
				}
				if (num == 81)
				{
					this.label3.ForeColor = global::System.Drawing.Color.Silver;
					num = 82;
				}
				if (num == 80)
				{
					this.label3.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 81;
				}
				if (num == 78)
				{
					this.label2.Text = " are connected to internet, or use Cloudflare/Google DNS if the problem";
					num = 79;
				}
				if (num == 77)
				{
					this.label2.TabIndex = 281;
					num = 78;
				}
				if (num == 75)
				{
					this.label2.Name = "label2";
					num = 76;
				}
				if (num == 74)
				{
					this.label2.Location = new global::System.Drawing.Point(16, 97);
					num = 75;
				}
				if (num == 72)
				{
					this.label2.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 73;
				}
				if (num == 71)
				{
					this.label2.AutoSize = true;
					num = 72;
				}
				if (num == 70)
				{
					this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
					num = 71;
				}
				if (num == 68)
				{
					this.linkLabel1.Text = "Report a broken link Here";
					num = 69;
				}
				if (num == 67)
				{
					this.linkLabel1.TabStop = true;
					num = 68;
				}
				if (num == 65)
				{
					this.linkLabel1.Size = new global::System.Drawing.Size(129, 13);
					num = 66;
				}
				if (num == 64)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 65;
				}
				if (num == 62)
				{
					this.linkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 63;
				}
				if (num == 61)
				{
					this.linkLabel1.AutoSize = true;
					num = 62;
				}
				if (num == 59)
				{
					this.label9.Text = "Toolkit was unable to download the file, please try again. Make sure that you";
					num = 60;
				}
				if (num == 58)
				{
					this.label9.TabIndex = 280;
					num = 59;
				}
				if (num == 56)
				{
					this.label9.Name = "label9";
					num = 57;
				}
				if (num == 55)
				{
					this.label9.Location = new global::System.Drawing.Point(6, 78);
					num = 56;
				}
				if (num == 53)
				{
					this.label9.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 54;
				}
				if (num == 52)
				{
					this.label9.AutoSize = true;
					num = 53;
				}
				if (num == 51)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
					num = 52;
				}
				if (num == 49)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 50;
				}
				if (num == 48)
				{
					this.button1.Text = "Close";
					num = 49;
				}
				if (num == 46)
				{
					this.button1.TabIndex = 279;
					num = 47;
				}
				if (num == 45)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 46;
				}
				if (num == 43)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 44;
				}
				if (num == 42)
				{
					this.button1.Location = new global::System.Drawing.Point(345, 143);
					num = 43;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 40)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 41;
				}
				if (num == 39)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 40;
				}
				if (num == 37)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 38;
				}
				if (num == 36)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 37;
				}
				if (num == 35)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 36;
				}
				if (num == 33)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 34;
				}
				if (num == 32)
				{
					this.label1.Text = "Couldn't Download File!";
					num = 33;
				}
				if (num == 30)
				{
					this.label1.Size = new global::System.Drawing.Size(254, 34);
					num = 31;
				}
				if (num == 29)
				{
					this.label1.Name = "label1";
					num = 30;
				}
				if (num == 27)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 28;
				}
				if (num == 26)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 27;
				}
				if (num == 24)
				{
					this.pictureBox1.TabStop = false;
					num = 25;
				}
				if (num == 23)
				{
					this.pictureBox1.TabIndex = 277;
					num = 24;
				}
				if (num == 21)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 22;
				}
				if (num == 20)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 21;
				}
				if (num == 18)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 19;
				}
				if (num == 17)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 18;
				}
				if (num == 16)
				{
					this.panel1.TabIndex = 276;
					num = 17;
				}
				if (num == 14)
				{
					this.panel1.Name = "panel1";
					num = 15;
				}
				if (num == 13)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 14;
				}
				if (num == 11)
				{
					base.SuspendLayout();
					num = 12;
				}
				if (num == 10)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 11;
				}
				if (num == 8)
				{
					this.label2 = new global::System.Windows.Forms.Label();
					num = 9;
				}
				if (num == 7)
				{
					this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
					num = 8;
				}
				if (num == 5)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 6;
				}
				if (num == 4)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 5;
				}
				if (num == 2)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.Error));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 110);
		}

		// Token: 0x040002C2 RID: 706
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.Label label3;
	}
}
