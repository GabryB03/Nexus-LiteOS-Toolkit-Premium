namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000029 RID: 41
	public partial class update : global::System.Windows.Forms.Form
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x000873B4 File Offset: 0x000855B4
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

		// Token: 0x060002A6 RID: 678 RVA: 0x0008742C File Offset: 0x0008562C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 15)
				{
					this.panel1.Size = new global::System.Drawing.Size(417, 32);
					num = 16;
				}
				if (num == 31)
				{
					this.pictureBox1.TabIndex = 288;
					num = 32;
				}
				if (num == 46)
				{
					this.button1.TabIndex = 287;
					num = 47;
				}
				if (num == 62)
				{
					this.label2.ForeColor = global::System.Drawing.Color.Silver;
					num = 63;
				}
				if (num == 78)
				{
					this.linkLabel1.Location = new global::System.Drawing.Point(13, 152);
					num = 79;
				}
				if (num == 93)
				{
					base.Controls.Add(this.label4);
					num = 94;
				}
				if (num == 107)
				{
					base.PerformLayout();
					num = 108;
				}
				if (num == 106)
				{
					base.ResumeLayout(false);
					num = 107;
				}
				if (num == 105)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 106;
				}
				if (num == 104)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.update_KeyDown);
					num = 105;
				}
				if (num == 103)
				{
					this.Text = "update";
					num = 104;
				}
				if (num == 102)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 103;
				}
				if (num == 101)
				{
					base.ShowInTaskbar = false;
					num = 102;
				}
				if (num == 100)
				{
					base.ShowIcon = false;
					num = 101;
				}
				if (num == 99)
				{
					base.Name = "update";
					num = 100;
				}
				if (num == 98)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 99;
				}
				if (num == 97)
				{
					base.Controls.Add(this.panel1);
					num = 98;
				}
				if (num == 96)
				{
					base.Controls.Add(this.label1);
					num = 97;
				}
				if (num == 95)
				{
					base.Controls.Add(this.button1);
					num = 96;
				}
				if (num == 94)
				{
					base.Controls.Add(this.pictureBox1);
					num = 95;
				}
				if (num == 92)
				{
					base.Controls.Add(this.label2);
					num = 93;
				}
				if (num == 91)
				{
					base.Controls.Add(this.label3);
					num = 92;
				}
				if (num == 90)
				{
					base.Controls.Add(this.linkLabel1);
					num = 91;
				}
				if (num == 89)
				{
					base.ControlBox = false;
					num = 90;
				}
				if (num == 88)
				{
					base.ClientSize = new global::System.Drawing.Size(376, 174);
					num = 89;
				}
				if (num == 87)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 88;
				}
				if (num == 86)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 87;
				}
				if (num == 85)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 86;
				}
				if (num == 84)
				{
					this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 85;
				}
				if (num == 83)
				{
					this.linkLabel1.Text = "Buy a license key!";
					num = 84;
				}
				if (num == 82)
				{
					this.linkLabel1.TabStop = true;
					num = 83;
				}
				if (num == 81)
				{
					this.linkLabel1.TabIndex = 294;
					num = 82;
				}
				if (num == 80)
				{
					this.linkLabel1.Size = new global::System.Drawing.Size(93, 13);
					num = 81;
				}
				if (num == 79)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 80;
				}
				if (num == 77)
				{
					this.linkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 78;
				}
				if (num == 76)
				{
					this.linkLabel1.AutoSize = true;
					num = 77;
				}
				if (num == 75)
				{
					this.label3.Text = "contact me on discord : TheWorldOfPC#2159";
					num = 76;
				}
				if (num == 74)
				{
					this.label3.TabIndex = 291;
					num = 75;
				}
				if (num == 73)
				{
					this.label3.Size = new global::System.Drawing.Size(252, 19);
					num = 74;
				}
				if (num == 72)
				{
					this.label3.Name = "label3";
					num = 73;
				}
				if (num == 71)
				{
					this.label3.Location = new global::System.Drawing.Point(12, 116);
					num = 72;
				}
				if (num == 70)
				{
					this.label3.ForeColor = global::System.Drawing.Color.Silver;
					num = 71;
				}
				if (num == 69)
				{
					this.label3.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 70;
				}
				if (num == 68)
				{
					this.label3.AutoSize = true;
					num = 69;
				}
				if (num == 67)
				{
					this.label2.Text = "HWID Reset, if you have paid and still have no access then";
					num = 68;
				}
				if (num == 66)
				{
					this.label2.TabIndex = 290;
					num = 67;
				}
				if (num == 65)
				{
					this.label2.Size = new global::System.Drawing.Size(332, 19);
					num = 66;
				}
				if (num == 64)
				{
					this.label2.Name = "label2";
					num = 65;
				}
				if (num == 63)
				{
					this.label2.Location = new global::System.Drawing.Point(12, 97);
					num = 64;
				}
				if (num == 61)
				{
					this.label2.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 62;
				}
				if (num == 60)
				{
					this.label2.AutoSize = true;
					num = 61;
				}
				if (num == 59)
				{
					this.label4.Text = "Login info didn't match, if you have changed hardware ask for";
					num = 60;
				}
				if (num == 58)
				{
					this.label4.TabIndex = 289;
					num = 59;
				}
				if (num == 57)
				{
					this.label4.Size = new global::System.Drawing.Size(354, 19);
					num = 58;
				}
				if (num == 56)
				{
					this.label4.Name = "label4";
					num = 57;
				}
				if (num == 55)
				{
					this.label4.Location = new global::System.Drawing.Point(12, 78);
					num = 56;
				}
				if (num == 54)
				{
					this.label4.ForeColor = global::System.Drawing.Color.Silver;
					num = 55;
				}
				if (num == 53)
				{
					this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 54;
				}
				if (num == 52)
				{
					this.label4.AutoSize = true;
					num = 53;
				}
				if (num == 51)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 52;
				}
				if (num == 50)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 51;
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
				if (num == 47)
				{
					this.button1.TabStop = false;
					num = 48;
				}
				if (num == 45)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 46;
				}
				if (num == 44)
				{
					this.button1.Name = "button1";
					num = 45;
				}
				if (num == 43)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 44;
				}
				if (num == 42)
				{
					this.button1.Location = new global::System.Drawing.Point(281, 134);
					num = 43;
				}
				if (num == 41)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 42;
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
				if (num == 38)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 39;
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
				if (num == 34)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 35;
				}
				if (num == 33)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 34;
				}
				if (num == 32)
				{
					this.pictureBox1.TabStop = false;
					num = 33;
				}
				if (num == 30)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 31;
				}
				if (num == 29)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 30;
				}
				if (num == 28)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 29;
				}
				if (num == 27)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(77, 15);
					num = 28;
				}
				if (num == 26)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 27;
				}
				if (num == 25)
				{
					this.label1.Text = "Unauthorized!";
					num = 26;
				}
				if (num == 24)
				{
					this.label1.TabIndex = 286;
					num = 25;
				}
				if (num == 23)
				{
					this.label1.Size = new global::System.Drawing.Size(157, 34);
					num = 24;
				}
				if (num == 22)
				{
					this.label1.Name = "label1";
					num = 23;
				}
				if (num == 21)
				{
					this.label1.Location = new global::System.Drawing.Point(133, 29);
					num = 22;
				}
				if (num == 20)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 21;
				}
				if (num == 19)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 20;
				}
				if (num == 18)
				{
					this.label1.AutoSize = true;
					num = 19;
				}
				if (num == 17)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 18;
				}
				if (num == 16)
				{
					this.panel1.TabIndex = 279;
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
				if (num == 12)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 13;
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
				if (num == 9)
				{
					this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
					num = 10;
				}
				if (num == 8)
				{
					this.label3 = new global::System.Windows.Forms.Label();
					num = 9;
				}
				if (num == 7)
				{
					this.label2 = new global::System.Windows.Forms.Label();
					num = 8;
				}
				if (num == 6)
				{
					this.label4 = new global::System.Windows.Forms.Label();
					num = 7;
				}
				if (num == 5)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 6;
				}
				if (num == 4)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 5;
				}
				if (num == 3)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 4;
				}
				if (num == 2)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.update));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 108);
		}

		// Token: 0x04000318 RID: 792
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.LinkLabel linkLabel1;
	}
}
