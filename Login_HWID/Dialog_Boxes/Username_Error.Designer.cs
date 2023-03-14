namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200007C RID: 124
	public partial class Username_Error : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x00191C48 File Offset: 0x0018FE48
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

		// Token: 0x06000A70 RID: 2672 RVA: 0x00191CC0 File Offset: 0x0018FEC0
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 12)
				{
					this.label4.Location = new global::System.Drawing.Point(76, 78);
					num = 13;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 24)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 25;
				}
				if (num == 36)
				{
					this.label1.AutoSize = true;
					num = 37;
				}
				if (num == 49)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 50;
				}
				if (num == 61)
				{
					base.ControlBox = false;
					num = 62;
				}
				if (num == 73)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Username_Error_KeyDown);
					num = 74;
				}
				if (num == 76)
				{
					base.PerformLayout();
					num = 77;
				}
				if (num == 75)
				{
					base.ResumeLayout(false);
					num = 76;
				}
				if (num == 74)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 75;
				}
				if (num == 72)
				{
					this.Text = "Username_Error";
					num = 73;
				}
				if (num == 71)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 72;
				}
				if (num == 70)
				{
					base.ShowInTaskbar = false;
					num = 71;
				}
				if (num == 69)
				{
					base.ShowIcon = false;
					num = 70;
				}
				if (num == 68)
				{
					base.Name = "Username_Error";
					num = 69;
				}
				if (num == 67)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 68;
				}
				if (num == 66)
				{
					base.Controls.Add(this.panel1);
					num = 67;
				}
				if (num == 65)
				{
					base.Controls.Add(this.label1);
					num = 66;
				}
				if (num == 64)
				{
					base.Controls.Add(this.button1);
					num = 65;
				}
				if (num == 63)
				{
					base.Controls.Add(this.label4);
					num = 64;
				}
				if (num == 62)
				{
					base.Controls.Add(this.pictureBox1);
					num = 63;
				}
				if (num == 60)
				{
					base.ClientSize = new global::System.Drawing.Size(303, 150);
					num = 61;
				}
				if (num == 59)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 60;
				}
				if (num == 58)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 59;
				}
				if (num == 57)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 58;
				}
				if (num == 56)
				{
					this.pictureBox1.TabStop = false;
					num = 57;
				}
				if (num == 55)
				{
					this.pictureBox1.TabIndex = 294;
					num = 56;
				}
				if (num == 54)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 55;
				}
				if (num == 53)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 54;
				}
				if (num == 52)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 53;
				}
				if (num == 51)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(18, 15);
					num = 52;
				}
				if (num == 50)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 51;
				}
				if (num == 48)
				{
					this.panel1.TabIndex = 290;
					num = 49;
				}
				if (num == 47)
				{
					this.panel1.Size = new global::System.Drawing.Size(417, 32);
					num = 48;
				}
				if (num == 46)
				{
					this.panel1.Name = "panel1";
					num = 47;
				}
				if (num == 45)
				{
					this.panel1.Location = new global::System.Drawing.Point(-5, -6);
					num = 46;
				}
				if (num == 44)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 45;
				}
				if (num == 43)
				{
					this.label1.Text = "Error Registration";
					num = 44;
				}
				if (num == 42)
				{
					this.label1.TabIndex = 291;
					num = 43;
				}
				if (num == 41)
				{
					this.label1.Size = new global::System.Drawing.Size(199, 34);
					num = 42;
				}
				if (num == 40)
				{
					this.label1.Name = "label1";
					num = 41;
				}
				if (num == 39)
				{
					this.label1.Location = new global::System.Drawing.Point(74, 29);
					num = 40;
				}
				if (num == 38)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 39;
				}
				if (num == 37)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 38;
				}
				if (num == 35)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 36;
				}
				if (num == 34)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 35;
				}
				if (num == 33)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 34;
				}
				if (num == 32)
				{
					this.button1.Text = "Close";
					num = 33;
				}
				if (num == 31)
				{
					this.button1.TabStop = false;
					num = 32;
				}
				if (num == 30)
				{
					this.button1.TabIndex = 292;
					num = 31;
				}
				if (num == 29)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 30;
				}
				if (num == 28)
				{
					this.button1.Name = "button1";
					num = 29;
				}
				if (num == 27)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 28;
				}
				if (num == 26)
				{
					this.button1.Location = new global::System.Drawing.Point(208, 107);
					num = 27;
				}
				if (num == 25)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 26;
				}
				if (num == 23)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 24;
				}
				if (num == 22)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 23;
				}
				if (num == 21)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 22;
				}
				if (num == 20)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 21;
				}
				if (num == 19)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 20;
				}
				if (num == 18)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 19;
				}
				if (num == 17)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 18;
				}
				if (num == 16)
				{
					this.label4.Text = "Username can't be empty!";
					num = 17;
				}
				if (num == 15)
				{
					this.label4.TabIndex = 293;
					num = 16;
				}
				if (num == 14)
				{
					this.label4.Size = new global::System.Drawing.Size(149, 19);
					num = 15;
				}
				if (num == 13)
				{
					this.label4.Name = "label4";
					num = 14;
				}
				if (num == 11)
				{
					this.label4.ForeColor = global::System.Drawing.Color.Silver;
					num = 12;
				}
				if (num == 10)
				{
					this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 11;
				}
				if (num == 9)
				{
					this.label4.AutoSize = true;
					num = 10;
				}
				if (num == 8)
				{
					base.SuspendLayout();
					num = 9;
				}
				if (num == 7)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 8;
				}
				if (num == 6)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 7;
				}
				if (num == 5)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 6;
				}
				if (num == 4)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 5;
				}
				if (num == 3)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 4;
				}
				if (num == 2)
				{
					this.label4 = new global::System.Windows.Forms.Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Dialog_Boxes.Username_Error));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 77);
		}

		// Token: 0x04000A47 RID: 2631
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000A48 RID: 2632
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000A49 RID: 2633
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000A4A RID: 2634
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A4B RID: 2635
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000A4C RID: 2636
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
