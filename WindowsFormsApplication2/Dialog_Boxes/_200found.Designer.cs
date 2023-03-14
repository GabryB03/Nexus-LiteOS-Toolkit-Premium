namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001A RID: 26
	public partial class _200found : global::System.Windows.Forms.Form
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0007B8E4 File Offset: 0x00079AE4
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

		// Token: 0x0600020D RID: 525 RVA: 0x0007B95C File Offset: 0x00079B5C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 3;
				}
				if (num == 4)
				{
					this.label9 = new global::System.Windows.Forms.Label();
					num = 5;
				}
				if (num == 6)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 7;
				}
				if (num == 8)
				{
					base.SuspendLayout();
					num = 9;
				}
				if (num == 10)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 11;
				}
				if (num == 12)
				{
					this.panel1.Size = new global::System.Drawing.Size(388, 32);
					num = 13;
				}
				if (num == 14)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 15;
				}
				if (num == 16)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 17;
				}
				if (num == 18)
				{
					this.label1.Location = new global::System.Drawing.Point(81, 29);
					num = 19;
				}
				if (num == 20)
				{
					this.label1.Size = new global::System.Drawing.Size(197, 34);
					num = 21;
				}
				if (num == 22)
				{
					this.label1.Text = "Game Files Found";
					num = 23;
				}
				if (num == 25)
				{
					this.label9.ForeColor = global::System.Drawing.Color.Silver;
					num = 26;
				}
				if (num == 27)
				{
					this.label9.Name = "label9";
					num = 28;
				}
				if (num == 29)
				{
					this.label9.TabIndex = 283;
					num = 30;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 31)
				{
					this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 32;
				}
				if (num == 33)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 34;
				}
				if (num == 35)
				{
					this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 36;
				}
				if (num == 37)
				{
					this.pictureBox2.TabStop = false;
					num = 38;
				}
				if (num == 39)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 40;
				}
				if (num == 41)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 42;
				}
				if (num == 43)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 44;
				}
				if (num == 45)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 46;
				}
				if (num == 48)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 49;
				}
				if (num == 50)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 51;
				}
				if (num == 52)
				{
					this.button1.TabStop = false;
					num = 53;
				}
				if (num == 54)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 55;
				}
				if (num == 56)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 57;
				}
				if (num == 58)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 59;
				}
				if (num == 60)
				{
					base.ClientSize = new global::System.Drawing.Size(343, 160);
					num = 61;
				}
				if (num == 62)
				{
					base.Controls.Add(this.label1);
					num = 63;
				}
				if (num == 64)
				{
					base.Controls.Add(this.label9);
					num = 65;
				}
				if (num == 66)
				{
					base.Controls.Add(this.panel1);
					num = 67;
				}
				if (num == 68)
				{
					base.Name = "_200found";
					num = 69;
				}
				if (num == 71)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 72;
				}
				if (num == 73)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this._200found_KeyDown);
					num = 74;
				}
				if (num == 75)
				{
					base.ResumeLayout(false);
					num = 76;
				}
				if (num == 76)
				{
					base.PerformLayout();
					num = 77;
				}
				if (num == 74)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
					num = 75;
				}
				if (num == 72)
				{
					this.Text = "_200found";
					num = 73;
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
				if (num == 67)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 68;
				}
				if (num == 65)
				{
					base.Controls.Add(this.button1);
					num = 66;
				}
				if (num == 63)
				{
					base.Controls.Add(this.pictureBox2);
					num = 64;
				}
				if (num == 61)
				{
					base.ControlBox = false;
					num = 62;
				}
				if (num == 59)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 60;
				}
				if (num == 57)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 58;
				}
				if (num == 55)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 56;
				}
				if (num == 53)
				{
					this.button1.Text = "Close";
					num = 54;
				}
				if (num == 51)
				{
					this.button1.TabIndex = 282;
					num = 52;
				}
				if (num == 49)
				{
					this.button1.Name = "button1";
					num = 50;
				}
				if (num == 47)
				{
					this.button1.Location = new global::System.Drawing.Point(248, 120);
					num = 48;
				}
				if (num == 46)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 47;
				}
				if (num == 44)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 45;
				}
				if (num == 42)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 43;
				}
				if (num == 40)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 41;
				}
				if (num == 38)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 39;
				}
				if (num == 36)
				{
					this.pictureBox2.TabIndex = 284;
					num = 37;
				}
				if (num == 34)
				{
					this.pictureBox2.Size = new global::System.Drawing.Size(60, 60);
					num = 35;
				}
				if (num == 32)
				{
					this.pictureBox2.Location = new global::System.Drawing.Point(32, 17);
					num = 33;
				}
				if (num == 30)
				{
					this.label9.Text = "Required game files found, you can now continue\r\noptimizing your game";
					num = 31;
				}
				if (num == 28)
				{
					this.label9.Size = new global::System.Drawing.Size(279, 38);
					num = 29;
				}
				if (num == 26)
				{
					this.label9.Location = new global::System.Drawing.Point(25, 75);
					num = 27;
				}
				if (num == 24)
				{
					this.label9.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 25;
				}
				if (num == 23)
				{
					this.label9.AutoSize = true;
					num = 24;
				}
				if (num == 21)
				{
					this.label1.TabIndex = 280;
					num = 22;
				}
				if (num == 19)
				{
					this.label1.Name = "label1";
					num = 20;
				}
				if (num == 17)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 18;
				}
				if (num == 15)
				{
					this.label1.AutoSize = true;
					num = 16;
				}
				if (num == 13)
				{
					this.panel1.TabIndex = 278;
					num = 14;
				}
				if (num == 11)
				{
					this.panel1.Name = "panel1";
					num = 12;
				}
				if (num == 9)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 10;
				}
				if (num == 7)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
					num = 8;
				}
				if (num == 5)
				{
					this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
					num = 6;
				}
				if (num == 3)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes._200found));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 77);
		}

		// Token: 0x0400028B RID: 651
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
