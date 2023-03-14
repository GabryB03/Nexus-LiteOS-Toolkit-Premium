namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x02000078 RID: 120
	public partial class no_update : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A45 RID: 2629 RVA: 0x0018EB54 File Offset: 0x0018CD54
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

		// Token: 0x06000A46 RID: 2630 RVA: 0x0018EBCC File Offset: 0x0018CDCC
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 12)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 13;
				}
				if (num == 24)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 25;
				}
				if (num == 36)
				{
					this.panel1.Location = new global::System.Drawing.Point(-5, -3);
					num = 37;
				}
				if (num == 49)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 50;
				}
				if (num == 61)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.no_update_KeyDown);
					num = 62;
				}
				if (num == 64)
				{
					base.PerformLayout();
					num = 65;
				}
				if (num == 63)
				{
					base.ResumeLayout(false);
					num = 64;
				}
				if (num == 62)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
					num = 63;
				}
				if (num == 60)
				{
					this.Text = "no_update";
					num = 61;
				}
				if (num == 59)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 60;
				}
				if (num == 58)
				{
					base.ShowInTaskbar = false;
					num = 59;
				}
				if (num == 57)
				{
					base.Name = "no_update";
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
					base.Controls.Add(this.label1);
					num = 55;
				}
				if (num == 53)
				{
					base.Controls.Add(this.button1);
					num = 54;
				}
				if (num == 52)
				{
					base.Controls.Add(this.pictureBox2);
					num = 53;
				}
				if (num == 51)
				{
					base.ClientSize = new global::System.Drawing.Size(372, 154);
					num = 52;
				}
				if (num == 50)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 51;
				}
				if (num == 48)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 49;
				}
				if (num == 47)
				{
					this.pictureBox2.TabStop = false;
					num = 48;
				}
				if (num == 46)
				{
					this.pictureBox2.TabIndex = 305;
					num = 47;
				}
				if (num == 45)
				{
					this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 46;
				}
				if (num == 44)
				{
					this.pictureBox2.Size = new global::System.Drawing.Size(60, 60);
					num = 45;
				}
				if (num == 43)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 44;
				}
				if (num == 42)
				{
					this.pictureBox2.Location = new global::System.Drawing.Point(13, 33);
					num = 43;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 41)
				{
					this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 42;
				}
				if (num == 40)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 41;
				}
				if (num == 39)
				{
					this.panel1.TabIndex = 300;
					num = 40;
				}
				if (num == 38)
				{
					this.panel1.Size = new global::System.Drawing.Size(417, 32);
					num = 39;
				}
				if (num == 37)
				{
					this.panel1.Name = "panel1";
					num = 38;
				}
				if (num == 35)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 36;
				}
				if (num == 34)
				{
					this.label1.Text = "Updated To Latest Version!";
					num = 35;
				}
				if (num == 33)
				{
					this.label1.TabIndex = 301;
					num = 34;
				}
				if (num == 32)
				{
					this.label1.Size = new global::System.Drawing.Size(289, 34);
					num = 33;
				}
				if (num == 31)
				{
					this.label1.Name = "label1";
					num = 32;
				}
				if (num == 30)
				{
					this.label1.Location = new global::System.Drawing.Point(66, 46);
					num = 31;
				}
				if (num == 29)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 30;
				}
				if (num == 28)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 29;
				}
				if (num == 27)
				{
					this.label1.AutoSize = true;
					num = 28;
				}
				if (num == 26)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 27;
				}
				if (num == 25)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 26;
				}
				if (num == 23)
				{
					this.button1.Text = "Close";
					num = 24;
				}
				if (num == 22)
				{
					this.button1.TabStop = false;
					num = 23;
				}
				if (num == 21)
				{
					this.button1.TabIndex = 302;
					num = 22;
				}
				if (num == 20)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 21;
				}
				if (num == 19)
				{
					this.button1.Name = "button1";
					num = 20;
				}
				if (num == 18)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 19;
				}
				if (num == 17)
				{
					this.button1.Location = new global::System.Drawing.Point(270, 107);
					num = 18;
				}
				if (num == 16)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 17;
				}
				if (num == 15)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 16;
				}
				if (num == 14)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 15;
				}
				if (num == 13)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 14;
				}
				if (num == 11)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 12;
				}
				if (num == 10)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 11;
				}
				if (num == 9)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 10;
				}
				if (num == 8)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 9;
				}
				if (num == 7)
				{
					base.SuspendLayout();
					num = 8;
				}
				if (num == 6)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
					num = 7;
				}
				if (num == 5)
				{
					this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
					num = 6;
				}
				if (num == 4)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 5;
				}
				if (num == 3)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 4;
				}
				if (num == 2)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Dialog_Boxes.no_update));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 65);
		}

		// Token: 0x04000A1E RID: 2590
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000A1F RID: 2591
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000A20 RID: 2592
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A21 RID: 2593
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000A22 RID: 2594
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
