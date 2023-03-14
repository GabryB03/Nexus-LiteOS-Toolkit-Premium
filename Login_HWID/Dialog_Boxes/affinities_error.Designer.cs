namespace Login_HWID.Dialog_Boxes
{
	// Token: 0x0200006F RID: 111
	public partial class affinities_error : global::System.Windows.Forms.Form
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x00187B1C File Offset: 0x00185D1C
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

		// Token: 0x060009EC RID: 2540 RVA: 0x00187B94 File Offset: 0x00185D94
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 12)
				{
					this.label1.Location = new global::System.Drawing.Point(73, 33);
					num = 13;
				}
				if (num == 24)
				{
					this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 25;
				}
				if (num == 36)
				{
					this.button1.TabIndex = 288;
					num = 37;
				}
				if (num == 49)
				{
					this.label4.AutoSize = true;
					num = 50;
				}
				if (num == 61)
				{
					base.Controls.Add(this.label4);
					num = 62;
				}
				if (num == 73)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
					num = 74;
				}
				if (num == 75)
				{
					base.PerformLayout();
					num = 76;
				}
				if (num == 74)
				{
					base.ResumeLayout(false);
					num = 75;
				}
				if (num == 72)
				{
					base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.affinities_error_KeyDown);
					num = 73;
				}
				if (num == 71)
				{
					this.Text = "affinities_error";
					num = 72;
				}
				if (num == 70)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
					num = 71;
				}
				if (num == 69)
				{
					base.ShowInTaskbar = false;
					num = 70;
				}
				if (num == 68)
				{
					base.ShowIcon = false;
					num = 69;
				}
				if (num == 67)
				{
					base.Name = "affinities_error";
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
					base.Controls.Add(this.pictureBox2);
					num = 63;
				}
				if (num == 60)
				{
					base.ClientSize = new global::System.Drawing.Size(284, 136);
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
					this.label4.Text = "Please select at least one core";
					num = 57;
				}
				if (num == 55)
				{
					this.label4.TabIndex = 316;
					num = 56;
				}
				if (num == 54)
				{
					this.label4.Size = new global::System.Drawing.Size(171, 19);
					num = 55;
				}
				if (num == 53)
				{
					this.label4.Name = "label4";
					num = 54;
				}
				if (num == 52)
				{
					this.label4.Location = new global::System.Drawing.Point(75, 67);
					num = 53;
				}
				if (num == 51)
				{
					this.label4.ForeColor = global::System.Drawing.Color.Silver;
					num = 52;
				}
				if (num == 50)
				{
					this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 51;
				}
				if (num == 48)
				{
					this.pictureBox2.TabStop = false;
					num = 49;
				}
				if (num == 47)
				{
					this.pictureBox2.TabIndex = 315;
					num = 48;
				}
				if (num == 46)
				{
					this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 47;
				}
				if (num == 45)
				{
					this.pictureBox2.Size = new global::System.Drawing.Size(60, 60);
					num = 46;
				}
				if (num == 44)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 45;
				}
				if (num == 43)
				{
					this.pictureBox2.Location = new global::System.Drawing.Point(18, 21);
					num = 44;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 42)
				{
					this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 43;
				}
				if (num == 41)
				{
					this.button1.Click += new global::System.EventHandler(this.button1_Click);
					num = 42;
				}
				if (num == 40)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 41;
				}
				if (num == 39)
				{
					this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
					num = 40;
				}
				if (num == 38)
				{
					this.button1.Text = "Close";
					num = 39;
				}
				if (num == 37)
				{
					this.button1.TabStop = false;
					num = 38;
				}
				if (num == 35)
				{
					this.button1.Size = new global::System.Drawing.Size(85, 30);
					num = 36;
				}
				if (num == 34)
				{
					this.button1.Name = "button1";
					num = 35;
				}
				if (num == 33)
				{
					this.button1.Margin = new global::System.Windows.Forms.Padding(1);
					num = 34;
				}
				if (num == 32)
				{
					this.button1.Location = new global::System.Drawing.Point(189, 96);
					num = 33;
				}
				if (num == 31)
				{
					this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 32;
				}
				if (num == 30)
				{
					this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
					num = 31;
				}
				if (num == 29)
				{
					this.button1.ForeColor = global::System.Drawing.Color.White;
					num = 30;
				}
				if (num == 28)
				{
					this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 29;
				}
				if (num == 27)
				{
					this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 28;
				}
				if (num == 26)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 27;
				}
				if (num == 25)
				{
					this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 26;
				}
				if (num == 23)
				{
					this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 24;
				}
				if (num == 22)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 23;
				}
				if (num == 21)
				{
					this.panel1.TabIndex = 286;
					num = 22;
				}
				if (num == 20)
				{
					this.panel1.Size = new global::System.Drawing.Size(388, 32);
					num = 21;
				}
				if (num == 19)
				{
					this.panel1.Name = "panel1";
					num = 20;
				}
				if (num == 18)
				{
					this.panel1.Location = new global::System.Drawing.Point(0, -2);
					num = 19;
				}
				if (num == 17)
				{
					this.panel1.BackColor = global::System.Drawing.Color.Transparent;
					num = 18;
				}
				if (num == 16)
				{
					this.label1.Text = "Error!";
					num = 17;
				}
				if (num == 15)
				{
					this.label1.TabIndex = 287;
					num = 16;
				}
				if (num == 14)
				{
					this.label1.Size = new global::System.Drawing.Size(72, 34);
					num = 15;
				}
				if (num == 13)
				{
					this.label1.Name = "label1";
					num = 14;
				}
				if (num == 11)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 12;
				}
				if (num == 10)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 11;
				}
				if (num == 9)
				{
					this.label1.AutoSize = true;
					num = 10;
				}
				if (num == 8)
				{
					base.SuspendLayout();
					num = 9;
				}
				if (num == 7)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
					num = 8;
				}
				if (num == 6)
				{
					this.label4 = new global::System.Windows.Forms.Label();
					num = 7;
				}
				if (num == 5)
				{
					this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
					num = 6;
				}
				if (num == 4)
				{
					this.button1 = new global::System.Windows.Forms.Button();
					num = 5;
				}
				if (num == 3)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Dialog_Boxes.affinities_error));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 76);
		}

		// Token: 0x040009CE RID: 2510
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009CF RID: 2511
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040009D0 RID: 2512
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009D1 RID: 2513
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040009D2 RID: 2514
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040009D3 RID: 2515
		private global::System.Windows.Forms.Label label4;
	}
}
