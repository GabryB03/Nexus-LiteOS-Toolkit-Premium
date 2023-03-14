namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x0200001C RID: 28
	public partial class added : global::System.Windows.Forms.Form
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0007D538 File Offset: 0x0007B738
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

		// Token: 0x06000222 RID: 546 RVA: 0x0007D5B0 File Offset: 0x0007B7B0
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
					this.button1 = new global::System.Windows.Forms.Button();
					num = 5;
				}
				if (num == 6)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 7;
				}
				if (num == 8)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 9;
				}
				if (num == 10)
				{
					this.panel1.Name = "panel1";
					num = 11;
				}
				if (num == 12)
				{
					this.panel1.TabIndex = 277;
					num = 13;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 14)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 15;
				}
				if (num == 16)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 17;
				}
				if (num == 18)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 19;
				}
				if (num == 20)
				{
					this.pictureBox1.TabStop = false;
					num = 21;
				}
				if (num == 22)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 23;
				}
				if (num == 25)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 26;
				}
				if (num == 27)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 28;
				}
				if (num == 29)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 30;
				}
				if (num == 31)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 32;
				}
				if (num == 33)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 34;
				}
				if (num == 35)
				{
					this.button1.TabStop = false;
					num = 36;
				}
				if (num == 37)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 38;
				}
				if (num == 39)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 40;
				}
				if (num == 41)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 42;
				}
				if (num == 43)
				{
					this.label1.Location = new global::System.Drawing.Point(69, 39);
					num = 44;
				}
				if (num == 45)
				{
					this.label1.Size = new global::System.Drawing.Size(266, 34);
					num = 46;
				}
				if (num == 48)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 49;
				}
				if (num == 50)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 51;
				}
				if (num == 52)
				{
					base.Controls.Add(this.pictureBox1);
					num = 53;
				}
				if (num == 54)
				{
					base.Controls.Add(this.label1);
					num = 55;
				}
				if (num == 56)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 57;
				}
				if (num == 58)
				{
					base.ShowIcon = false;
					num = 59;
				}
				if (num == 60)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 61;
				}
				if (num == 62)
				{
					base.Load += new global::System.EventHandler(this.added_Load);
					num = 63;
				}
				if (num == 64)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 65;
				}
				if (num == 66)
				{
					base.PerformLayout();
					num = 67;
				}
				if (num == 65)
				{
					base.ResumeLayout(false);
					num = 66;
				}
				if (num == 63)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.added_KeyDown);
					num = 64;
				}
				if (num == 61)
				{
					this.Text = "added";
					num = 62;
				}
				if (num == 59)
				{
					base.ShowInTaskbar = false;
					num = 60;
				}
				if (num == 57)
				{
					base.Name = "added";
					num = 58;
				}
				if (num == 55)
				{
					base.Controls.Add(this.panel1);
					num = 56;
				}
				if (num == 53)
				{
					base.Controls.Add(this.button1);
					num = 54;
				}
				if (num == 51)
				{
					base.ClientSize = new global::System.Drawing.Size(361, 146);
					num = 52;
				}
				if (num == 49)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 50;
				}
				if (num == 47)
				{
					this.label1.Text = "Added To Context Menu!";
					num = 48;
				}
				if (num == 46)
				{
					this.label1.TabIndex = 280;
					num = 47;
				}
				if (num == 44)
				{
					this.label1.Name = "label1";
					num = 45;
				}
				if (num == 42)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 43;
				}
				if (num == 40)
				{
					this.label1.AutoSize = true;
					num = 41;
				}
				if (num == 38)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 39;
				}
				if (num == 36)
				{
					this.button1.Text = "Close";
					num = 37;
				}
				if (num == 34)
				{
					this.button1.TabIndex = 281;
					num = 35;
				}
				if (num == 32)
				{
					this.button1.Name = "button1";
					num = 33;
				}
				if (num == 30)
				{
					this.button1.Location = new global::System.Drawing.Point(241, 91);
					num = 31;
				}
				if (num == 28)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 29;
				}
				if (num == 26)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 27;
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
				if (num == 21)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 22;
				}
				if (num == 19)
				{
					this.pictureBox1.TabIndex = 282;
					num = 20;
				}
				if (num == 17)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
					num = 18;
				}
				if (num == 15)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(13, 25);
					num = 16;
				}
				if (num == 13)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 14;
				}
				if (num == 11)
				{
					this.panel1.Size = new global::System.Drawing.Size(388, 32);
					num = 12;
				}
				if (num == 9)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 10;
				}
				if (num == 7)
				{
					base.SuspendLayout();
					num = 8;
				}
				if (num == 5)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 6;
				}
				if (num == 3)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.added));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 67);
		}

		// Token: 0x0400029E RID: 670
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Label label1;
	}
}
