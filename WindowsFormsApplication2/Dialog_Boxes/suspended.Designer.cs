namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000028 RID: 40
	public partial class suspended : global::System.Windows.Forms.Form
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000867A4 File Offset: 0x000849A4
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

		// Token: 0x0600029C RID: 668 RVA: 0x0008681C File Offset: 0x00084A1C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 15)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(18, 17);
					num = 16;
				}
				if (num == 31)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 32;
				}
				if (num == 46)
				{
					this.label1.TabIndex = 283;
					num = 47;
				}
				if (num == 62)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.suspended_KeyDown);
					num = 63;
				}
				if (num == 65)
				{
					base.PerformLayout();
					num = 66;
				}
				if (num == 64)
				{
					base.ResumeLayout(false);
					num = 65;
				}
				if (num == 63)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 64;
				}
				if (num == 61)
				{
					this.Text = "cleared";
					num = 62;
				}
				if (num == 60)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 61;
				}
				if (num == 59)
				{
					base.ShowInTaskbar = false;
					num = 60;
				}
				if (num == 58)
				{
					base.ShowIcon = false;
					num = 59;
				}
				if (num == 57)
				{
					base.Name = "suspended";
					num = 58;
				}
				if (num == 56)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 57;
				}
				if (num == 55)
				{
					base.Controls.Add(this.panel1);
					num = 56;
				}
				if (num == 54)
				{
					base.Controls.Add(this.button1);
					num = 55;
				}
				if (num == 53)
				{
					base.Controls.Add(this.pictureBox1);
					num = 54;
				}
				if (num == 52)
				{
					base.Controls.Add(this.label1);
					num = 53;
				}
				if (num == 51)
				{
					base.ClientSize = new global::System.Drawing.Size(299, 123);
					num = 52;
				}
				if (num == 50)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 51;
				}
				if (num == 49)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 50;
				}
				if (num == 48)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 49;
				}
				if (num == 47)
				{
					this.label1.Text = "Suspended Winlogon.exe";
					num = 48;
				}
				if (num == 45)
				{
					this.label1.Size = new global::System.Drawing.Size(226, 30);
					num = 46;
				}
				if (num == 44)
				{
					this.label1.Name = "label1";
					num = 45;
				}
				if (num == 43)
				{
					this.label1.Location = new global::System.Drawing.Point(66, 34);
					num = 44;
				}
				if (num == 42)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 43;
				}
				if (num == 41)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 42;
				}
				if (num == 40)
				{
					this.label1.AutoSize = true;
					num = 41;
				}
				if (num == 39)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 40;
				}
				if (num == 38)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 39;
				}
				if (num == 37)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 38;
				}
				if (num == 36)
				{
					this.button1.Text = "Close";
					num = 37;
				}
				if (num == 35)
				{
					this.button1.TabStop = false;
					num = 36;
				}
				if (num == 34)
				{
					this.button1.TabIndex = 284;
					num = 35;
				}
				if (num == 33)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 34;
				}
				if (num == 32)
				{
					this.button1.Name = "button1";
					num = 33;
				}
				if (num == 30)
				{
					this.button1.Location = new global::System.Drawing.Point(207, 83);
					num = 31;
				}
				if (num == 29)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 30;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 28)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 29;
				}
				if (num == 27)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 28;
				}
				if (num == 26)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 27;
				}
				if (num == 25)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 26;
				}
				if (num == 24)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 25;
				}
				if (num == 23)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 24;
				}
				if (num == 22)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 23;
				}
				if (num == 21)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 22;
				}
				if (num == 20)
				{
					this.pictureBox1.TabStop = false;
					num = 21;
				}
				if (num == 19)
				{
					this.pictureBox1.TabIndex = 285;
					num = 20;
				}
				if (num == 18)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 19;
				}
				if (num == 17)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 18;
				}
				if (num == 16)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 17;
				}
				if (num == 14)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 15;
				}
				if (num == 13)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 14;
				}
				if (num == 12)
				{
					this.panel1.TabIndex = 278;
					num = 13;
				}
				if (num == 11)
				{
					this.panel1.Size = new global::System.Drawing.Size(388, 32);
					num = 12;
				}
				if (num == 10)
				{
					this.panel1.Name = "panel1";
					num = 11;
				}
				if (num == 9)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 10;
				}
				if (num == 8)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 9;
				}
				if (num == 7)
				{
					base.SuspendLayout();
					num = 8;
				}
				if (num == 6)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
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
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 4;
				}
				if (num == 2)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.suspended));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 66);
		}

		// Token: 0x04000310 RID: 784
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.Label label1;
	}
}
