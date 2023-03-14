using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000017 RID: 23
	public class Home : UserControl
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000580F4 File Offset: 0x000562F4
		public static Home Instance
		{
			get
			{
				if (Home._instace == null)
				{
					Home._instace = new Home();
				}
				return Home._instace;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000020D8 File Offset: 0x000002D8
		public Home()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00018EC8 File Offset: 0x000170C8
		private void button15_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.youtube.com/theworldofpc");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00018E68 File Offset: 0x00017068
		private void button18_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.instagram.com/theworldofpc.yt");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		private void button17_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.paypal.com/paypalme/supportme7147");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0005811C File Offset: 0x0005631C
		private void button16_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://www.buymeacoffee.com/TheWorldOfPC");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001CB80 File Offset: 0x0001AD80
		private void button19_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://dsc.gg/NexusToolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00018FE4 File Offset: 0x000171E4
		private void button17_Click_1(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://twitter.com/TheWorldOfPC");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0005817C File Offset: 0x0005637C
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

		// Token: 0x06000164 RID: 356 RVA: 0x000581F4 File Offset: 0x000563F4
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.label8 = new Label();
					num = 3;
				}
				if (num == 5)
				{
					this.label6 = new Label();
					num = 6;
				}
				if (num == 8)
				{
					this.label3 = new Label();
					num = 9;
				}
				if (num == 10)
				{
					this.label1 = new Label();
					num = 11;
				}
				if (num == 13)
				{
					this.label10 = new Label();
					num = 14;
				}
				if (num == 16)
				{
					this.label12 = new Label();
					num = 17;
				}
				if (num == 18)
				{
					((ISupportInitialize)this.pictureBox3).BeginInit();
					num = 19;
				}
				if (num == 21)
				{
					base.SuspendLayout();
					num = 22;
				}
				if (num == 24)
				{
					this.label8.ForeColor = Color.White;
					num = 25;
				}
				if (num == 27)
				{
					this.label8.Size = new Size(169, 30);
					num = 28;
				}
				if (num == 29)
				{
					this.label8.Text = "Tweaks/Basic Info";
					num = 30;
				}
				if (num == 32)
				{
					this.pictureBox3.Name = "pictureBox3";
					num = 33;
				}
				if (num == 35)
				{
					this.pictureBox3.TabIndex = 33;
					num = 36;
				}
				if (num == 37)
				{
					this.label7.AutoSize = true;
					num = 38;
				}
				if (num == 40)
				{
					this.label7.Location = new Point(151, 252);
					num = 41;
				}
				if (num == 43)
				{
					this.label7.TabIndex = 32;
					num = 44;
				}
				if (num == 45)
				{
					this.label6.AutoSize = true;
					num = 46;
				}
				if (num == 48)
				{
					this.label6.Location = new Point(151, 233);
					num = 49;
				}
				if (num == 51)
				{
					this.label6.TabIndex = 31;
					num = 52;
				}
				if (num == 54)
				{
					this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 55;
				}
				if (num == 56)
				{
					this.label5.Location = new Point(151, 213);
					num = 57;
				}
				if (num == 59)
				{
					this.label5.TabIndex = 30;
					num = 60;
				}
				if (num == 62)
				{
					this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 63;
				}
				if (num == 64)
				{
					this.label4.Location = new Point(151, 194);
					num = 65;
				}
				if (num == 67)
				{
					this.label4.TabIndex = 29;
					num = 68;
				}
				if (num == 70)
				{
					this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 71;
				}
				if (num == 72)
				{
					this.label3.Location = new Point(150, 160);
					num = 73;
				}
				if (num == 75)
				{
					this.label3.TabIndex = 28;
					num = 76;
				}
				if (num == 78)
				{
					this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 79;
				}
				if (num == 81)
				{
					this.label2.Name = "label2";
					num = 82;
				}
				if (num == 83)
				{
					this.label2.TabIndex = 26;
					num = 84;
				}
				if (num == 86)
				{
					this.label1.BackColor = Color.Transparent;
					num = 87;
				}
				if (num == 89)
				{
					this.label1.Location = new Point(293, 18);
					num = 90;
				}
				if (num == 91)
				{
					this.label1.Size = new Size(418, 63);
					num = 92;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 94)
				{
					this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 95;
				}
				if (num == 97)
				{
					this.pictureBox2.Size = new Size(64, 64);
					num = 98;
				}
				if (num == 99)
				{
					this.pictureBox2.TabIndex = 27;
					num = 100;
				}
				if (num == 102)
				{
					this.label16.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 103;
				}
				if (num == 105)
				{
					this.label16.Name = "label16";
					num = 106;
				}
				if (num == 108)
				{
					this.label16.Text = "Thank you for believing in this project!";
					num = 109;
				}
				if (num == 110)
				{
					this.label10.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 111;
				}
				if (num == 113)
				{
					this.label10.Name = "label10";
					num = 114;
				}
				if (num == 116)
				{
					this.label10.Text = "The tweaks provided in the tool will perfectly optimize your gaming experience. Every software have bugs/issues in it, if anything";
					num = 117;
				}
				if (num == 118)
				{
					this.label11.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 119;
				}
				if (num == 121)
				{
					this.label11.Name = "label11";
					num = 122;
				}
				if (num == 124)
				{
					this.label11.Text = "is wrong with the toolkit (broken links or some bug) that bug/issue will be fixed by an update";
					num = 125;
				}
				if (num == 126)
				{
					this.label13.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 127;
				}
				if (num == 129)
				{
					this.label13.Name = "label13";
					num = 130;
				}
				if (num == 132)
				{
					this.label13.Text = componentResourceManager.GetString("label13.Text");
					num = 133;
				}
				if (num == 135)
				{
					this.label12.ForeColor = Color.White;
					num = 136;
				}
				if (num == 137)
				{
					this.label12.Name = "label12";
					num = 138;
				}
				if (num == 140)
				{
					this.label12.Text = "Game Booster";
					num = 141;
				}
				if (num == 143)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 144;
				}
				if (num == 145)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 146;
				}
				if (num == 148)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 149;
				}
				if (num == 151)
				{
					base.Controls.Add(this.label13);
					num = 152;
				}
				if (num == 153)
				{
					base.Controls.Add(this.pictureBox4);
					num = 154;
				}
				if (num == 156)
				{
					base.Controls.Add(this.label16);
					num = 157;
				}
				if (num == 159)
				{
					base.Controls.Add(this.label7);
					num = 160;
				}
				if (num == 162)
				{
					base.Controls.Add(this.label4);
					num = 163;
				}
				if (num == 164)
				{
					base.Controls.Add(this.label2);
					num = 165;
				}
				if (num == 167)
				{
					base.Name = "home";
					num = 168;
				}
				if (num == 170)
				{
					((ISupportInitialize)this.pictureBox2).EndInit();
					num = 171;
				}
				if (num == 172)
				{
					base.ResumeLayout(false);
					num = 173;
				}
				if (num == 173)
				{
					base.PerformLayout();
					num = 174;
				}
				if (num == 171)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 172;
				}
				if (num == 169)
				{
					((ISupportInitialize)this.pictureBox3).EndInit();
					num = 170;
				}
				if (num == 168)
				{
					base.Size = new Size(1006, 669);
					num = 169;
				}
				if (num == 166)
				{
					base.Controls.Add(this.pictureBox2);
					num = 167;
				}
				if (num == 165)
				{
					base.Controls.Add(this.label1);
					num = 166;
				}
				if (num == 163)
				{
					base.Controls.Add(this.label3);
					num = 164;
				}
				if (num == 161)
				{
					base.Controls.Add(this.label5);
					num = 162;
				}
				if (num == 160)
				{
					base.Controls.Add(this.label6);
					num = 161;
				}
				if (num == 158)
				{
					base.Controls.Add(this.pictureBox3);
					num = 159;
				}
				if (num == 157)
				{
					base.Controls.Add(this.label8);
					num = 158;
				}
				if (num == 155)
				{
					base.Controls.Add(this.label10);
					num = 156;
				}
				if (num == 154)
				{
					base.Controls.Add(this.label11);
					num = 155;
				}
				if (num == 152)
				{
					base.Controls.Add(this.label12);
					num = 153;
				}
				if (num == 150)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 151;
				}
				if (num == 149)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 150;
				}
				if (num == 147)
				{
					this.pictureBox4.TabStop = false;
					num = 148;
				}
				if (num == 146)
				{
					this.pictureBox4.TabIndex = 97;
					num = 147;
				}
				if (num == 144)
				{
					this.pictureBox4.Size = new Size(64, 64);
					num = 145;
				}
				if (num == 142)
				{
					this.pictureBox4.Location = new Point(96, 427);
					num = 143;
				}
				if (num == 141)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 142;
				}
				if (num == 139)
				{
					this.label12.TabIndex = 98;
					num = 140;
				}
				if (num == 138)
				{
					this.label12.Size = new Size(136, 30);
					num = 139;
				}
				if (num == 136)
				{
					this.label12.Location = new Point(150, 446);
					num = 137;
				}
				if (num == 134)
				{
					this.label12.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 135;
				}
				if (num == 133)
				{
					this.label12.AutoSize = true;
					num = 134;
				}
				if (num == 131)
				{
					this.label13.TabIndex = 99;
					num = 132;
				}
				if (num == 130)
				{
					this.label13.Size = new Size(737, 38);
					num = 131;
				}
				if (num == 128)
				{
					this.label13.Location = new Point(154, 480);
					num = 129;
				}
				if (num == 127)
				{
					this.label13.ForeColor = Color.Silver;
					num = 128;
				}
				if (num == 125)
				{
					this.label13.AutoSize = true;
					num = 126;
				}
				if (num == 123)
				{
					this.label11.TabIndex = 96;
					num = 124;
				}
				if (num == 122)
				{
					this.label11.Size = new Size(520, 19);
					num = 123;
				}
				if (num == 120)
				{
					this.label11.Location = new Point(151, 369);
					num = 121;
				}
				if (num == 119)
				{
					this.label11.ForeColor = Color.Silver;
					num = 120;
				}
				if (num == 117)
				{
					this.label11.AutoSize = true;
					num = 118;
				}
				if (num == 115)
				{
					this.label10.TabIndex = 95;
					num = 116;
				}
				if (num == 114)
				{
					this.label10.Size = new Size(713, 19);
					num = 115;
				}
				if (num == 112)
				{
					this.label10.Location = new Point(151, 350);
					num = 113;
				}
				if (num == 111)
				{
					this.label10.ForeColor = Color.Silver;
					num = 112;
				}
				if (num == 109)
				{
					this.label10.AutoSize = true;
					num = 110;
				}
				if (num == 107)
				{
					this.label16.TabIndex = 43;
					num = 108;
				}
				if (num == 106)
				{
					this.label16.Size = new Size(353, 30);
					num = 107;
				}
				if (num == 104)
				{
					this.label16.Location = new Point(318, 583);
					num = 105;
				}
				if (num == 103)
				{
					this.label16.ForeColor = Color.White;
					num = 104;
				}
				if (num == 101)
				{
					this.label16.AutoSize = true;
					num = 102;
				}
				if (num == 100)
				{
					this.pictureBox2.TabStop = false;
					num = 101;
				}
				if (num == 98)
				{
					this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 99;
				}
				if (num == 96)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 97;
				}
				if (num == 95)
				{
					this.pictureBox2.Location = new Point(96, 141);
					num = 96;
				}
				if (num == 93)
				{
					this.label1.Text = "Nexus LiteOS Toolkit";
					num = 94;
				}
				if (num == 92)
				{
					this.label1.TabIndex = 25;
					num = 93;
				}
				if (num == 90)
				{
					this.label1.Name = "label1";
					num = 91;
				}
				if (num == 88)
				{
					this.label1.ForeColor = Color.White;
					num = 89;
				}
				if (num == 87)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 30f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 88;
				}
				if (num == 85)
				{
					this.label1.AutoSize = true;
					num = 86;
				}
				if (num == 84)
				{
					this.label2.Text = "The Ultimate all-in-one tool";
					num = 85;
				}
				if (num == 82)
				{
					this.label2.Size = new Size(253, 30);
					num = 83;
				}
				if (num == 80)
				{
					this.label2.Location = new Point(371, 81);
					num = 81;
				}
				if (num == 79)
				{
					this.label2.ForeColor = Color.White;
					num = 80;
				}
				if (num == 77)
				{
					this.label2.AutoSize = true;
					num = 78;
				}
				if (num == 76)
				{
					this.label3.Text = "Features";
					num = 77;
				}
				if (num == 74)
				{
					this.label3.Size = new Size(87, 30);
					num = 75;
				}
				if (num == 73)
				{
					this.label3.Name = "label3";
					num = 74;
				}
				if (num == 71)
				{
					this.label3.ForeColor = Color.White;
					num = 72;
				}
				if (num == 69)
				{
					this.label3.AutoSize = true;
					num = 70;
				}
				if (num == 68)
				{
					this.label4.Text = "Nexus LiteOS Toolkit comes with plenty of features. Cleanup Windows, some basic tweaks to enable or disable windows features";
					num = 69;
				}
				if (num == 66)
				{
					this.label4.Size = new Size(709, 19);
					num = 67;
				}
				if (num == 65)
				{
					this.label4.Name = "label4";
					num = 66;
				}
				if (num == 63)
				{
					this.label4.ForeColor = Color.Silver;
					num = 64;
				}
				if (num == 61)
				{
					this.label4.AutoSize = true;
					num = 62;
				}
				if (num == 60)
				{
					this.label5.Text = "(hidden features as well). Some advanced tweaks meant for gamers, Manage Windows apps ex. adding Microsoft Store or Xbox";
					num = 61;
				}
				if (num == 58)
				{
					this.label5.Size = new Size(711, 19);
					num = 59;
				}
				if (num == 57)
				{
					this.label5.Name = "label5";
					num = 58;
				}
				if (num == 55)
				{
					this.label5.ForeColor = Color.Silver;
					num = 56;
				}
				if (num == 53)
				{
					this.label5.AutoSize = true;
					num = 54;
				}
				if (num == 52)
				{
					this.label6.Text = "or deleting them. Add handy context menus using a huge set of presets. Manage user account related settings. Download over";
					num = 53;
				}
				if (num == 50)
				{
					this.label6.Size = new Size(699, 19);
					num = 51;
				}
				if (num == 49)
				{
					this.label6.Name = "label6";
					num = 50;
				}
				if (num == 47)
				{
					this.label6.ForeColor = Color.Silver;
					num = 48;
				}
				if (num == 46)
				{
					this.label6.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 47;
				}
				if (num == 44)
				{
					this.label7.Text = "100+ software (cracked/freeware) with ease. And much, MUCH more!";
					num = 45;
				}
				if (num == 42)
				{
					this.label7.Size = new Size(385, 19);
					num = 43;
				}
				if (num == 41)
				{
					this.label7.Name = "label7";
					num = 42;
				}
				if (num == 39)
				{
					this.label7.ForeColor = Color.Silver;
					num = 40;
				}
				if (num == 38)
				{
					this.label7.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 39;
				}
				if (num == 36)
				{
					this.pictureBox3.TabStop = false;
					num = 37;
				}
				if (num == 34)
				{
					this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 35;
				}
				if (num == 33)
				{
					this.pictureBox3.Size = new Size(64, 64);
					num = 34;
				}
				if (num == 31)
				{
					this.pictureBox3.Location = new Point(96, 299);
					num = 32;
				}
				if (num == 30)
				{
					this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
					num = 31;
				}
				if (num == 28)
				{
					this.label8.TabIndex = 34;
					num = 29;
				}
				if (num == 26)
				{
					this.label8.Name = "label8";
					num = 27;
				}
				if (num == 25)
				{
					this.label8.Location = new Point(150, 320);
					num = 26;
				}
				if (num == 23)
				{
					this.label8.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 24;
				}
				if (num == 22)
				{
					this.label8.AutoSize = true;
					num = 23;
				}
				if (num == 20)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 21;
				}
				if (num == 19)
				{
					((ISupportInitialize)this.pictureBox2).BeginInit();
					num = 20;
				}
				if (num == 17)
				{
					this.pictureBox4 = new PictureBox();
					num = 18;
				}
				if (num == 15)
				{
					this.label13 = new Label();
					num = 16;
				}
				if (num == 14)
				{
					this.label11 = new Label();
					num = 15;
				}
				if (num == 12)
				{
					this.label16 = new Label();
					num = 13;
				}
				if (num == 11)
				{
					this.pictureBox2 = new PictureBox();
					num = 12;
				}
				if (num == 9)
				{
					this.label2 = new Label();
					num = 10;
				}
				if (num == 7)
				{
					this.label4 = new Label();
					num = 8;
				}
				if (num == 6)
				{
					this.label5 = new Label();
					num = 7;
				}
				if (num == 4)
				{
					this.label7 = new Label();
					num = 5;
				}
				if (num == 3)
				{
					this.pictureBox3 = new PictureBox();
					num = 4;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Home));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 174);
		}

		// Token: 0x040001E4 RID: 484
		private static Home _instace;

		// Token: 0x040001E5 RID: 485
		private IContainer components = null;

		// Token: 0x040001E6 RID: 486
		private Label label8;

		// Token: 0x040001E7 RID: 487
		private PictureBox pictureBox3;

		// Token: 0x040001E8 RID: 488
		private Label label7;

		// Token: 0x040001E9 RID: 489
		private Label label6;

		// Token: 0x040001EA RID: 490
		private Label label5;

		// Token: 0x040001EB RID: 491
		private Label label4;

		// Token: 0x040001EC RID: 492
		private Label label3;

		// Token: 0x040001ED RID: 493
		private Label label2;

		// Token: 0x040001EE RID: 494
		private Label label1;

		// Token: 0x040001EF RID: 495
		private PictureBox pictureBox2;

		// Token: 0x040001F0 RID: 496
		private Label label16;

		// Token: 0x040001F1 RID: 497
		private Label label10;

		// Token: 0x040001F2 RID: 498
		private Label label11;

		// Token: 0x040001F3 RID: 499
		private Label label13;

		// Token: 0x040001F4 RID: 500
		private Label label12;

		// Token: 0x040001F5 RID: 501
		private PictureBox pictureBox4;
	}
}
