namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000E RID: 14
	public partial class custom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00014C54 File Offset: 0x00012E54
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

		// Token: 0x06000074 RID: 116 RVA: 0x00014CCC File Offset: 0x00012ECC
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
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 5;
				}
				if (num == 7)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 8;
				}
				if (num == 9)
				{
					this.label1.AutoSize = true;
					num = 10;
				}
				if (num == 11)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 12;
				}
				if (num == 14)
				{
					this.label1.Size = new global::System.Drawing.Size(236, 34);
					num = 15;
				}
				if (num == 16)
				{
					this.label1.Text = "Download Completed!";
					num = 17;
				}
				if (num == 18)
				{
					this.button7.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 19;
				}
				if (num == 21)
				{
					this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 22;
				}
				if (num == 23)
				{
					this.button7.ForeColor = global::System.Drawing.Color.White;
					num = 24;
				}
				if (num == 25)
				{
					this.button7.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 26;
				}
				if (num == 28)
				{
					this.button7.Name = "button7";
					num = 29;
				}
				if (num == 30)
				{
					this.button7.TabIndex = 269;
					num = 31;
				}
				if (num == 32)
				{
					this.button7.Text = "Open Folder";
					num = 33;
				}
				if (num == 35)
				{
					this.button7.Click += new global::System.EventHandler(this.button7_Click);
					num = 36;
				}
				if (num == 37)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(22, 18);
					num = 38;
				}
				if (num == 39)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 40;
				}
				if (num == 42)
				{
					this.pictureBox1.TabStop = false;
					num = 43;
				}
				if (num == 44)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 45;
				}
				if (num == 46)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 47;
				}
				if (num == 49)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 50;
				}
				if (num == 51)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 52;
				}
				if (num == 53)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 54;
				}
				if (num == 56)
				{
					this.button1.TabIndex = 270;
					num = 57;
				}
				if (num == 58)
				{
					this.button1.Text = "Close";
					num = 59;
				}
				if (num == 61)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 62;
				}
				if (num == 63)
				{
					this.panel1.Name = "panel1";
					num = 64;
				}
				if (num == 65)
				{
					this.panel1.TabIndex = 271;
					num = 66;
				}
				if (num == 68)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 69;
				}
				if (num == 70)
				{
					base.ClientSize = new global::System.Drawing.Size(361, 146);
					num = 71;
				}
				if (num == 72)
				{
					base.Controls.Add(this.pictureBox1);
					num = 73;
				}
				if (num == 75)
				{
					base.Controls.Add(this.button1);
					num = 76;
				}
				if (num == 77)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 78;
				}
				if (num == 79)
				{
					base.ShowIcon = false;
					num = 80;
				}
				if (num == 82)
				{
					this.Text = "msgbox";
					num = 83;
				}
				if (num == 84)
				{
					base.ResumeLayout(false);
					num = 85;
				}
				if (num == 85)
				{
					base.PerformLayout();
					num = 86;
				}
				if (num == 83)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 84;
				}
				if (num == 81)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 82;
				}
				if (num == 80)
				{
					base.ShowInTaskbar = false;
					num = 81;
				}
				if (num == 78)
				{
					base.Name = "custom";
					num = 79;
				}
				if (num == 76)
				{
					base.Controls.Add(this.button7);
					num = 77;
				}
				if (num == 74)
				{
					base.Controls.Add(this.label1);
					num = 75;
				}
				if (num == 73)
				{
					base.Controls.Add(this.panel1);
					num = 74;
				}
				if (num == 71)
				{
					base.ControlBox = false;
					num = 72;
				}
				if (num == 69)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 70;
				}
				if (num == 67)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 68;
				}
				if (num == 66)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 67;
				}
				if (num == 64)
				{
					this.panel1.Size = new global::System.Drawing.Size(388, 32);
					num = 65;
				}
				if (num == 62)
				{
					this.panel1.Location = new global::System.Drawing.Point(1, -8);
					num = 63;
				}
				if (num == 60)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 61;
				}
				if (num == 59)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 60;
				}
				if (num == 57)
				{
					this.button1.TabStop = false;
					num = 58;
				}
				if (num == 55)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 56;
				}
				if (num == 54)
				{
					this.button1.Name = "button1";
					num = 55;
				}
				if (num == 52)
				{
					this.button1.Location = new global::System.Drawing.Point(227, 95);
					num = 53;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 50)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 51;
				}
				if (num == 48)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 49;
				}
				if (num == 47)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 48;
				}
				if (num == 45)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 46;
				}
				if (num == 43)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 44;
				}
				if (num == 41)
				{
					this.pictureBox1.TabIndex = 0;
					num = 42;
				}
				if (num == 40)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 41;
				}
				if (num == 38)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 39;
				}
				if (num == 36)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 37;
				}
				if (num == 34)
				{
					this.button7.UseVisualStyleBackColor = false;
					num = 35;
				}
				if (num == 33)
				{
					this.button7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 34;
				}
				if (num == 31)
				{
					this.button7.TabStop = false;
					num = 32;
				}
				if (num == 29)
				{
					this.button7.Size = new global::System.Drawing.Size(134, 30);
					num = 30;
				}
				if (num == 27)
				{
					this.button7.Margin = new global::System.Windows.Forms.Padding(1);
					num = 28;
				}
				if (num == 26)
				{
					this.button7.Location = new global::System.Drawing.Point(34, 95);
					num = 27;
				}
				if (num == 24)
				{
					this.button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button7.Image");
					num = 25;
				}
				if (num == 22)
				{
					this.button7.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 23;
				}
				if (num == 20)
				{
					this.button7.FlatAppearance.BorderSize = 0;
					num = 21;
				}
				if (num == 19)
				{
					this.button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 20;
				}
				if (num == 17)
				{
					this.button7.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 18;
				}
				if (num == 15)
				{
					this.label1.TabIndex = 1;
					num = 16;
				}
				if (num == 13)
				{
					this.label1.Name = "label1";
					num = 14;
				}
				if (num == 12)
				{
					this.label1.Location = new global::System.Drawing.Point(78, 32);
					num = 13;
				}
				if (num == 10)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 11;
				}
				if (num == 8)
				{
					base.SuspendLayout();
					num = 9;
				}
				if (num == 6)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 7;
				}
				if (num == 5)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 6;
				}
				if (num == 3)
				{
					this.button7 = new global::System.Windows.Forms.Button();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.User_Controls.custom));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 86);
		}

		// Token: 0x0400009D RID: 157
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Button button7;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Panel panel1;
	}
}
