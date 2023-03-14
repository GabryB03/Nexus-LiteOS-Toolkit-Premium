namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200007A RID: 122
	public partial class update_avail : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00190308 File Offset: 0x0018E508
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

		// Token: 0x06000A5A RID: 2650 RVA: 0x00190380 File Offset: 0x0018E580
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
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 25;
				}
				if (num == 36)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 37;
				}
				if (num == 49)
				{
					this.label2.AutoSize = true;
					num = 50;
				}
				if (num == 61)
				{
					base.Controls.Add(this.label2);
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
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.update_avail_KeyDown);
					num = 72;
				}
				if (num == 70)
				{
					this.Text = "update_avail";
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
					base.Name = "update_avail";
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
					base.Controls.Add(this.pictureBox1);
					num = 63;
				}
				if (num == 60)
				{
					base.ClientSize = new global::System.Drawing.Size(345, 170);
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
					this.label2.Text = "Download the latest update from discord server";
					num = 57;
				}
				if (num == 55)
				{
					this.label2.TabIndex = 313;
					num = 56;
				}
				if (num == 54)
				{
					this.label2.Size = new global::System.Drawing.Size(292, 20);
					num = 55;
				}
				if (num == 53)
				{
					this.label2.Name = "label2";
					num = 54;
				}
				if (num == 52)
				{
					this.label2.Location = new global::System.Drawing.Point(24, 100);
					num = 53;
				}
				if (num == 51)
				{
					this.label2.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
					num = 52;
				}
				if (num == 50)
				{
					this.label2.Font = new global::System.Drawing.Font("Josefin Sans", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 51;
				}
				if (num == 48)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 49;
				}
				if (num == 47)
				{
					this.panel1.TabIndex = 309;
					num = 48;
				}
				if (num == 46)
				{
					this.panel1.Size = new global::System.Drawing.Size(417, 32);
					num = 47;
				}
				if (num == 45)
				{
					this.panel1.Name = "panel1";
					num = 46;
				}
				if (num == 44)
				{
					this.panel1.Location = new global::System.Drawing.Point(1, 0);
					num = 45;
				}
				if (num == 43)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 44;
				}
				if (num == 42)
				{
					this.label1.Text = "Update Available!";
					num = 43;
				}
				if (num == 41)
				{
					this.label1.TabIndex = 310;
					num = 42;
				}
				if (num == 40)
				{
					this.label1.Size = new global::System.Drawing.Size(195, 34);
					num = 41;
				}
				if (num == 39)
				{
					this.label1.Name = "label1";
					num = 40;
				}
				if (num == 38)
				{
					this.label1.Location = new global::System.Drawing.Point(104, 51);
					num = 39;
				}
				if (num == 37)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 38;
				}
				if (num == 35)
				{
					this.label1.AutoSize = true;
					num = 36;
				}
				if (num == 34)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 35;
				}
				if (num == 33)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 34;
				}
				if (num == 32)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 33;
				}
				if (num == 31)
				{
					this.button1.Text = "Close";
					num = 32;
				}
				if (num == 30)
				{
					this.button1.TabStop = false;
					num = 31;
				}
				if (num == 29)
				{
					this.button1.TabIndex = 311;
					num = 30;
				}
				if (num == 28)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 29;
				}
				if (num == 27)
				{
					this.button1.Name = "button1";
					num = 28;
				}
				if (num == 26)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 27;
				}
				if (num == 25)
				{
					this.button1.Location = new global::System.Drawing.Point(250, 130);
					num = 26;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 23)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 24;
				}
				if (num == 22)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 23;
				}
				if (num == 21)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 22;
				}
				if (num == 20)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 21;
				}
				if (num == 19)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 20;
				}
				if (num == 18)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 19;
				}
				if (num == 17)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 18;
				}
				if (num == 16)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 17;
				}
				if (num == 15)
				{
					this.pictureBox1.TabStop = false;
					num = 16;
				}
				if (num == 14)
				{
					this.pictureBox1.TabIndex = 312;
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
					this.pictureBox1.Location = new global::System.Drawing.Point(38, 28);
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
					this.label2 = new global::System.Windows.Forms.Label();
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
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Dialog_Boxes.update_avail));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 75);
		}

		// Token: 0x04000A32 RID: 2610
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000A33 RID: 2611
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000A34 RID: 2612
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000A35 RID: 2613
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A36 RID: 2614
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000A37 RID: 2615
		private global::System.Windows.Forms.Label label2;
	}
}
