namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x02000073 RID: 115
	public partial class game_on : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0018ABC4 File Offset: 0x00188DC4
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

		// Token: 0x06000A14 RID: 2580 RVA: 0x0018AC3C File Offset: 0x00188E3C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 12)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 13;
				}
				if (num == 24)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 25;
				}
				if (num == 36)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 37;
				}
				if (num == 49)
				{
					this.label1.TabIndex = 311;
					num = 50;
				}
				if (num == 61)
				{
					base.Controls.Add(this.pictureBox1);
					num = 62;
				}
				if (num == 73)
				{
					base.ResumeLayout(false);
					num = 74;
				}
				if (num == 74)
				{
					base.PerformLayout();
					num = 75;
				}
				if (num == 72)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 73;
				}
				if (num == 71)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.game_on_KeyDown);
					num = 72;
				}
				if (num == 70)
				{
					this.Text = "game_on";
					num = 71;
				}
				if (num == 69)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 70;
				}
				if (num == 68)
				{
					base.ShowInTaskbar = false;
					num = 69;
				}
				if (num == 67)
				{
					base.Name = "game_on";
					num = 68;
				}
				if (num == 66)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 67;
				}
				if (num == 65)
				{
					base.Controls.Add(this.panel1);
					num = 66;
				}
				if (num == 64)
				{
					base.Controls.Add(this.label1);
					num = 65;
				}
				if (num == 63)
				{
					base.Controls.Add(this.button1);
					num = 64;
				}
				if (num == 62)
				{
					base.Controls.Add(this.label4);
					num = 63;
				}
				if (num == 60)
				{
					base.ClientSize = new global::System.Drawing.Size(385, 175);
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
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 57;
				}
				if (num == 55)
				{
					this.panel1.TabIndex = 310;
					num = 56;
				}
				if (num == 54)
				{
					this.panel1.Size = new global::System.Drawing.Size(417, 32);
					num = 55;
				}
				if (num == 53)
				{
					this.panel1.Name = "panel1";
					num = 54;
				}
				if (num == 52)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 53;
				}
				if (num == 51)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 52;
				}
				if (num == 50)
				{
					this.label1.Text = "Game Booster Activated";
					num = 51;
				}
				if (num == 48)
				{
					this.label1.Size = new global::System.Drawing.Size(261, 34);
					num = 49;
				}
				if (num == 47)
				{
					this.label1.Name = "label1";
					num = 48;
				}
				if (num == 46)
				{
					this.label1.Location = new global::System.Drawing.Point(75, 29);
					num = 47;
				}
				if (num == 45)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 46;
				}
				if (num == 44)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 45;
				}
				if (num == 43)
				{
					this.label1.AutoSize = true;
					num = 44;
				}
				if (num == 42)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 43;
				}
				if (num == 41)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 42;
				}
				if (num == 40)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 41;
				}
				if (num == 39)
				{
					this.button1.Text = "Close";
					num = 40;
				}
				if (num == 38)
				{
					this.button1.TabStop = false;
					num = 39;
				}
				if (num == 37)
				{
					this.button1.TabIndex = 312;
					num = 38;
				}
				if (num == 35)
				{
					this.button1.Name = "button1";
					num = 36;
				}
				if (num == 34)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 35;
				}
				if (num == 33)
				{
					this.button1.Location = new global::System.Drawing.Point(290, 135);
					num = 34;
				}
				if (num == 32)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 33;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 31)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 32;
				}
				if (num == 30)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 31;
				}
				if (num == 29)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 30;
				}
				if (num == 28)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 29;
				}
				if (num == 27)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 28;
				}
				if (num == 26)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 27;
				}
				if (num == 25)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 26;
				}
				if (num == 23)
				{
					this.label4.Text = "Game Booster have been activated. Your game will be\r\nlaunched soon!";
					num = 24;
				}
				if (num == 22)
				{
					this.label4.TabIndex = 313;
					num = 23;
				}
				if (num == 21)
				{
					this.label4.Size = new global::System.Drawing.Size(303, 38);
					num = 22;
				}
				if (num == 20)
				{
					this.label4.Name = "label4";
					num = 21;
				}
				if (num == 19)
				{
					this.label4.Location = new global::System.Drawing.Point(33, 78);
					num = 20;
				}
				if (num == 18)
				{
					this.label4.ForeColor = global::System.Drawing.Color.Silver;
					num = 19;
				}
				if (num == 17)
				{
					this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 18;
				}
				if (num == 16)
				{
					this.label4.AutoSize = true;
					num = 17;
				}
				if (num == 15)
				{
					this.pictureBox1.TabStop = false;
					num = 16;
				}
				if (num == 14)
				{
					this.pictureBox1.TabIndex = 314;
					num = 15;
				}
				if (num == 13)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 14;
				}
				if (num == 11)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 12;
				}
				if (num == 10)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(19, 15);
					num = 11;
				}
				if (num == 9)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
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
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 7;
				}
				if (num == 5)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 6;
				}
				if (num == 4)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 5;
				}
				if (num == 3)
				{
					this.label4 = new global::System.Windows.Forms.Label();
					num = 4;
				}
				if (num == 2)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Dialog_Boxes.game_on));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 75);
		}

		// Token: 0x040009F1 RID: 2545
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009F2 RID: 2546
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040009F3 RID: 2547
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040009F4 RID: 2548
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040009F5 RID: 2549
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009F6 RID: 2550
		private global::System.Windows.Forms.Panel panel1;
	}
}
