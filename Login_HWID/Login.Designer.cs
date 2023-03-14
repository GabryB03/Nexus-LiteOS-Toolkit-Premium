namespace Login_HWID
{
	// Token: 0x0200004F RID: 79
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x0008EAAC File Offset: 0x0008CCAC
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0008EB24 File Offset: 0x0008CD24
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 1)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Login_HWID.Login));
					num = 2;
				}
				if (num == 2)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 3;
				}
				if (num == 3)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 4;
				}
				if (num == 5)
				{
					this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
					num = 6;
				}
				if (num == 6)
				{
					this.panel2 = new global::System.Windows.Forms.Panel();
					num = 7;
				}
				if (num == 7)
				{
					this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
					num = 8;
				}
				if (num == 8)
				{
					this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
					num = 9;
				}
				if (num == 10)
				{
					this.siticoneRoundedButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
					num = 11;
				}
				if (num == 11)
				{
					this.lbl_ver = new global::System.Windows.Forms.Label();
					num = 12;
				}
				if (num == 12)
				{
					this.discord = new global::System.Windows.Forms.Button();
					num = 13;
				}
				if (num == 14)
				{
					this.twitter = new global::System.Windows.Forms.Button();
					num = 15;
				}
				if (num == 15)
				{
					this.yt = new global::System.Windows.Forms.Button();
					num = 16;
				}
				if (num == 16)
				{
					this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
					num = 17;
				}
				if (num == 17)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 18;
				}
				if (num == 19)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 20;
				}
				if (num == 20)
				{
					this.panel1.SuspendLayout();
					num = 21;
				}
				if (num == 21)
				{
					this.panel2.SuspendLayout();
					num = 22;
				}
				if (num == 23)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
					num = 24;
				}
				if (num == 24)
				{
					base.SuspendLayout();
					num = 25;
				}
				if (num == 25)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 26;
				}
				if (num == 26)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(84, 0);
					num = 27;
				}
				if (num == 28)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(136, 136);
					num = 29;
				}
				if (num == 29)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 30;
				}
				if (num == 30)
				{
					this.pictureBox1.TabIndex = 14;
					num = 31;
				}
				if (num == 31)
				{
					this.pictureBox1.TabStop = false;
					num = 32;
				}
				if (num == 33)
				{
					this.panel1.Controls.Add(this.siticoneControlBox1);
					num = 34;
				}
				if (num == 34)
				{
					this.panel1.Location = new global::System.Drawing.Point(-4, -6);
					num = 35;
				}
				if (num == 35)
				{
					this.panel1.Name = "panel1";
					num = 36;
				}
				if (num == 37)
				{
					this.panel1.TabIndex = 278;
					num = 38;
				}
				if (num == 38)
				{
					this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
					num = 39;
				}
				if (num == 39)
				{
					this.siticoneRoundedButton2.BorderRadius = 18;
					num = 40;
				}
				if (num == 40)
				{
					this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
					num = 41;
				}
				if (num == 42)
				{
					this.siticoneRoundedButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
					num = 43;
				}
				if (num == 43)
				{
					this.siticoneRoundedButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
					num = 44;
				}
				if (num == 44)
				{
					this.siticoneRoundedButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
					num = 45;
				}
				if (num == 46)
				{
					this.siticoneRoundedButton2.DisabledState.Parent = this.siticoneRoundedButton2;
					num = 47;
				}
				if (num == 47)
				{
					this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.Transparent;
					num = 48;
				}
				if (num == 48)
				{
					this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
					num = 49;
				}
				if (num == 49)
				{
					this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
					num = 50;
				}
				if (num == 51)
				{
					this.siticoneRoundedButton2.HoverState.Parent = this.siticoneRoundedButton2;
					num = 52;
				}
				if (num == 52)
				{
					this.siticoneRoundedButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneRoundedButton2.Image");
					num = 53;
				}
				if (num == 53)
				{
					this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(9, 9);
					num = 54;
				}
				if (num == 55)
				{
					this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
					num = 56;
				}
				if (num == 56)
				{
					this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(63, 38);
					num = 57;
				}
				if (num == 57)
				{
					this.siticoneRoundedButton2.TabIndex = 15;
					num = 58;
				}
				if (num == 58)
				{
					this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
					num = 59;
				}
				if (num == 60)
				{
					this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
					num = 61;
				}
				if (num == 61)
				{
					this.siticoneControlBox1.BorderRadius = 10;
					num = 62;
				}
				if (num == 62)
				{
					this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
					num = 63;
				}
				if (num == 63)
				{
					this.siticoneControlBox1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
					num = 64;
				}
				if (num == 65)
				{
					this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
					num = 66;
				}
				if (num == 66)
				{
					this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
					num = 67;
				}
				if (num == 67)
				{
					this.siticoneControlBox1.Location = new global::System.Drawing.Point(266, 9);
					num = 68;
				}
				if (num == 69)
				{
					this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
					num = 70;
				}
				if (num == 70)
				{
					this.siticoneControlBox1.Size = new global::System.Drawing.Size(43, 38);
					num = 71;
				}
				if (num == 71)
				{
					this.siticoneControlBox1.TabIndex = 282;
					num = 72;
				}
				if (num == 72)
				{
					this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
					num = 73;
				}
				if (num == 74)
				{
					this.panel2.Controls.Add(this.pictureBox5);
					num = 75;
				}
				if (num == 75)
				{
					this.panel2.Controls.Add(this.siticoneRoundedButton3);
					num = 76;
				}
				if (num == 76)
				{
					this.panel2.Controls.Add(this.siticoneRoundedButton1);
					num = 77;
				}
				if (num == 78)
				{
					this.panel2.Controls.Add(this.discord);
					num = 79;
				}
				if (num == 79)
				{
					this.panel2.Controls.Add(this.ig);
					num = 80;
				}
				if (num == 80)
				{
					this.panel2.Controls.Add(this.twitter);
					num = 81;
				}
				if (num == 81)
				{
					this.panel2.Controls.Add(this.yt);
					num = 82;
				}
				if (num == 83)
				{
					this.panel2.Controls.Add(this.label1);
					num = 84;
				}
				if (num == 84)
				{
					this.panel2.Controls.Add(this.pictureBox1);
					num = 85;
				}
				if (num == 85)
				{
					this.panel2.Controls.Add(this.siticoneCheckBox1);
					num = 86;
				}
				if (num == 87)
				{
					this.panel2.Name = "panel2";
					num = 88;
				}
				if (num == 88)
				{
					this.panel2.Size = new global::System.Drawing.Size(310, 485);
					num = 89;
				}
				if (num == 89)
				{
					this.panel2.TabIndex = 281;
					num = 90;
				}
				if (num == 90)
				{
					this.pictureBox6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox6.Image");
					num = 91;
				}
				if (num == 92)
				{
					this.pictureBox6.Name = "pictureBox6";
					num = 93;
				}
				if (num == 93)
				{
					this.pictureBox6.Size = new global::System.Drawing.Size(136, 136);
					num = 94;
				}
				if (num == 94)
				{
					this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 95;
				}
				if (num == 95)
				{
					this.pictureBox6.TabIndex = 303;
					num = 96;
				}
				if (num == 97)
				{
					this.pictureBox5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox5.Image");
					num = 98;
				}
				if (num == 98)
				{
					this.pictureBox5.Location = new global::System.Drawing.Point(-180, 0);
					num = 99;
				}
				if (num == 99)
				{
					this.pictureBox5.Name = "pictureBox5";
					num = 100;
				}
				if (num == 101)
				{
					this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 102;
				}
				if (num == 102)
				{
					this.pictureBox5.TabIndex = 282;
					num = 103;
				}
				if (num == 103)
				{
					this.pictureBox5.TabStop = false;
					num = 104;
				}
				if (num == 104)
				{
					this.siticoneRoundedButton3.BorderRadius = 16;
					num = 105;
				}
				if (num == 106)
				{
					this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
					num = 107;
				}
				if (num == 107)
				{
					this.siticoneRoundedButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
					num = 108;
				}
				if (num == 108)
				{
					this.siticoneRoundedButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
					num = 109;
				}
				if (num == 110)
				{
					this.siticoneRoundedButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
					num = 111;
				}
				if (num == 111)
				{
					this.siticoneRoundedButton3.DisabledState.Parent = this.siticoneRoundedButton3;
					num = 112;
				}
				if (num == 112)
				{
					this.siticoneRoundedButton3.FillColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 113;
				}
				if (num == 113)
				{
					this.siticoneRoundedButton3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold);
					num = 114;
				}
				if (num == 115)
				{
					this.siticoneRoundedButton3.HoverState.Parent = this.siticoneRoundedButton3;
					num = 116;
				}
				if (num == 116)
				{
					this.siticoneRoundedButton3.Location = new global::System.Drawing.Point(66, 258);
					num = 117;
				}
				if (num == 117)
				{
					this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
					num = 118;
				}
				if (num == 119)
				{
					this.siticoneRoundedButton3.Size = new global::System.Drawing.Size(180, 34);
					num = 120;
				}
				if (num == 120)
				{
					this.siticoneRoundedButton3.TabIndex = 302;
					num = 121;
				}
				if (num == 121)
				{
					this.siticoneRoundedButton3.Text = "Login";
					num = 122;
				}
				if (num == 122)
				{
					this.siticoneRoundedButton3.Click += new global::System.EventHandler(this.siticoneRoundedButton3_Click);
					num = 123;
				}
				if (num == 124)
				{
					this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
					num = 125;
				}
				if (num == 125)
				{
					this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
					num = 126;
				}
				if (num == 126)
				{
					this.siticoneRoundedButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
					num = 127;
				}
				if (num == 127)
				{
					this.siticoneRoundedButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
					num = 128;
				}
				if (num == 129)
				{
					this.siticoneRoundedButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
					num = 130;
				}
				if (num == 130)
				{
					this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
					num = 131;
				}
				if (num == 131)
				{
					this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 132;
				}
				if (num == 133)
				{
					this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
					num = 134;
				}
				if (num == 134)
				{
					this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
					num = 135;
				}
				if (num == 135)
				{
					this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(66, 209);
					num = 136;
				}
				if (num == 136)
				{
					this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
					num = 137;
				}
				if (num == 138)
				{
					this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(180, 34);
					num = 139;
				}
				if (num == 139)
				{
					this.siticoneRoundedButton1.TabIndex = 301;
					num = 140;
				}
				if (num == 140)
				{
					this.siticoneRoundedButton1.Text = "Register";
					num = 141;
				}
				if (num == 142)
				{
					this.lbl_ver.AutoSize = true;
					num = 143;
				}
				if (num == 143)
				{
					this.lbl_ver.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 144;
				}
				if (num == 144)
				{
					this.lbl_ver.ForeColor = global::System.Drawing.Color.Silver;
					num = 145;
				}
				if (num == 145)
				{
					this.lbl_ver.Location = new global::System.Drawing.Point(12, 407);
					num = 146;
				}
				if (num == 147)
				{
					this.lbl_ver.Size = new global::System.Drawing.Size(35, 19);
					num = 148;
				}
				if (num == 148)
				{
					this.lbl_ver.TabIndex = 300;
					num = 149;
				}
				if (num == 149)
				{
					this.lbl_ver.Text = "v4.79";
					num = 150;
				}
				if (num == 150)
				{
					this.discord.BackColor = global::System.Drawing.Color.Transparent;
					num = 151;
				}
				if (num == 152)
				{
					this.discord.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
					num = 153;
				}
				if (num == 153)
				{
					this.discord.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 154;
				}
				if (num == 154)
				{
					this.discord.FlatAppearance.BorderSize = 0;
					num = 155;
				}
				if (num == 156)
				{
					this.discord.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 157;
				}
				if (num == 157)
				{
					this.discord.ForeColor = global::System.Drawing.Color.White;
					num = 158;
				}
				if (num == 158)
				{
					this.discord.Location = new global::System.Drawing.Point(165, 321);
					num = 159;
				}
				if (num == 159)
				{
					this.discord.Margin = new global::System.Windows.Forms.Padding(1);
					num = 160;
				}
				if (num == 161)
				{
					this.discord.Size = new global::System.Drawing.Size(32, 32);
					num = 162;
				}
				if (num == 162)
				{
					this.discord.TabIndex = 299;
					num = 163;
				}
				if (num == 163)
				{
					this.discord.TabStop = false;
					num = 164;
				}
				if (num == 165)
				{
					this.discord.Click += new global::System.EventHandler(this.button19_Click);
					num = 166;
				}
				if (num == 166)
				{
					this.ig.BackColor = global::System.Drawing.Color.Transparent;
					num = 167;
				}
				if (num == 167)
				{
					this.ig.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("ig.BackgroundImage");
					num = 168;
				}
				if (num == 168)
				{
					this.ig.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
					num = 169;
				}
				if (num == 170)
				{
					this.ig.FlatAppearance.BorderSize = 0;
					num = 171;
				}
				if (num == 171)
				{
					this.ig.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 172;
				}
				if (num == 172)
				{
					this.ig.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 173;
				}
				if (num == 174)
				{
					this.ig.Location = new global::System.Drawing.Point(214, 321);
					num = 175;
				}
				if (num == 175)
				{
					this.ig.Margin = new global::System.Windows.Forms.Padding(1);
					num = 176;
				}
				if (num == 176)
				{
					this.ig.Name = "ig";
					num = 177;
				}
				if (num == 177)
				{
					this.ig.Size = new global::System.Drawing.Size(32, 32);
					num = 178;
				}
				if (num == 179)
				{
					this.ig.TabStop = false;
					num = 180;
				}
				if (num == 180)
				{
					this.ig.UseVisualStyleBackColor = false;
					num = 181;
				}
				if (num == 181)
				{
					this.ig.Click += new global::System.EventHandler(this.button18_Click);
					num = 182;
				}
				if (num == 182)
				{
					this.twitter.BackColor = global::System.Drawing.Color.Transparent;
					num = 183;
				}
				if (num == 184)
				{
					this.twitter.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
					num = 185;
				}
				if (num == 185)
				{
					this.twitter.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 186;
				}
				if (num == 186)
				{
					this.twitter.FlatAppearance.BorderSize = 0;
					num = 187;
				}
				if (num == 188)
				{
					this.twitter.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 189;
				}
				if (num == 189)
				{
					this.twitter.ForeColor = global::System.Drawing.Color.White;
					num = 190;
				}
				if (num == 190)
				{
					this.twitter.Location = new global::System.Drawing.Point(67, 321);
					num = 191;
				}
				if (num == 191)
				{
					this.twitter.Margin = new global::System.Windows.Forms.Padding(1);
					num = 192;
				}
				if (num == 193)
				{
					this.twitter.Size = new global::System.Drawing.Size(32, 32);
					num = 194;
				}
				if (num == 194)
				{
					this.twitter.TabIndex = 297;
					num = 195;
				}
				if (num == 195)
				{
					this.twitter.TabStop = false;
					num = 196;
				}
				if (num == 197)
				{
					this.twitter.Click += new global::System.EventHandler(this.button17_Click);
					num = 198;
				}
				if (num == 198)
				{
					this.yt.BackColor = global::System.Drawing.Color.Transparent;
					num = 199;
				}
				if (num == 199)
				{
					this.yt.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("yt.BackgroundImage");
					num = 200;
				}
				if (num == 200)
				{
					this.yt.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
					num = 201;
				}
				if (num == 202)
				{
					this.yt.FlatAppearance.BorderSize = 0;
					num = 203;
				}
				if (num == 203)
				{
					this.yt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 204;
				}
				if (num == 204)
				{
					this.yt.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 205;
				}
				if (num == 206)
				{
					this.yt.Location = new global::System.Drawing.Point(116, 321);
					num = 207;
				}
				if (num == 207)
				{
					this.yt.Margin = new global::System.Windows.Forms.Padding(1);
					num = 208;
				}
				if (num == 208)
				{
					this.yt.Name = "yt";
					num = 209;
				}
				if (num == 209)
				{
					this.yt.Size = new global::System.Drawing.Size(32, 32);
					num = 210;
				}
				if (num == 211)
				{
					this.yt.TabStop = false;
					num = 212;
				}
				if (num == 212)
				{
					this.yt.UseVisualStyleBackColor = false;
					num = 213;
				}
				if (num == 213)
				{
					this.yt.Click += new global::System.EventHandler(this.button15_Click);
					num = 214;
				}
				if (num == 214)
				{
					this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 215;
				}
				if (num == 216)
				{
					this.linkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 217;
				}
				if (num == 217)
				{
					this.linkLabel1.Location = new global::System.Drawing.Point(204, 413);
					num = 218;
				}
				if (num == 218)
				{
					this.linkLabel1.Name = "linkLabel1";
					num = 219;
				}
				if (num == 220)
				{
					this.linkLabel1.TabIndex = 295;
					num = 221;
				}
				if (num == 221)
				{
					this.linkLabel1.TabStop = true;
					num = 222;
				}
				if (num == 222)
				{
					this.linkLabel1.Text = "dsc.gg/NexusToolkit";
					num = 223;
				}
				if (num == 223)
				{
					this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.DeepSkyBlue;
					num = 224;
				}
				if (num == 225)
				{
					this.label1.AutoSize = true;
					num = 226;
				}
				if (num == 226)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 227;
				}
				if (num == 227)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 228;
				}
				if (num == 229)
				{
					this.label1.Name = "label1";
					num = 230;
				}
				if (num == 230)
				{
					this.label1.Size = new global::System.Drawing.Size(203, 31);
					num = 231;
				}
				if (num == 231)
				{
					this.label1.TabIndex = 294;
					num = 232;
				}
				if (num == 232)
				{
					this.label1.Text = "Nexus LiteOS Toolkit";
					num = 233;
				}
				if (num == 234)
				{
					this.siticoneCheckBox1.CheckedState.BorderRadius = 0;
					num = 235;
				}
				if (num == 235)
				{
					this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
					num = 236;
				}
				if (num == 236)
				{
					this.siticoneCheckBox1.CheckMarkColor = global::System.Drawing.Color.Empty;
					num = 237;
				}
				if (num == 238)
				{
					this.siticoneCheckBox1.ForeColor = global::System.Drawing.Color.White;
					num = 239;
				}
				if (num == 239)
				{
					this.siticoneCheckBox1.Location = new global::System.Drawing.Point(99, 65);
					num = 240;
				}
				if (num == 240)
				{
					this.siticoneCheckBox1.Name = "siticoneCheckBox1";
					num = 241;
				}
				if (num == 241)
				{
					this.siticoneCheckBox1.Size = new global::System.Drawing.Size(98, 17);
					num = 242;
				}
				if (num == 243)
				{
					this.siticoneCheckBox1.Text = "Save Login Info";
					num = 244;
				}
				if (num == 244)
				{
					this.siticoneCheckBox1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
					num = 245;
				}
				if (num == 245)
				{
					this.siticoneCheckBox1.UncheckedState.BorderRadius = 0;
					num = 246;
				}
				if (num == 246)
				{
					this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
					num = 247;
				}
				if (num == 248)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 249;
				}
				if (num == 249)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 250;
				}
				if (num == 250)
				{
					base.ClientSize = new global::System.Drawing.Size(310, 485);
					num = 251;
				}
				if (num == 252)
				{
					base.Controls.Add(this.panel2);
					num = 253;
				}
				if (num == 253)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 254;
				}
				if (num == 254)
				{
					base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
					num = 255;
				}
				if (num == 255)
				{
					base.Name = "Login";
					num = 256;
				}
				if (num == 257)
				{
					this.Text = "Nexus LiteOS Toolkit";
					num = 258;
				}
				if (num == 258)
				{
					base.Load += new global::System.EventHandler(this.Login_Load);
					num = 259;
				}
				if (num == 259)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 260;
				}
				if (num == 261)
				{
					this.panel2.ResumeLayout(false);
					num = 262;
				}
				if (num == 262)
				{
					this.panel2.PerformLayout();
					num = 263;
				}
				if (num == 263)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
					num = 264;
				}
				if (num == 264)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
					num = 265;
				}
				if (num == 265)
				{
					base.ResumeLayout(false);
					num = 266;
				}
				if (num == 260)
				{
					this.panel1.ResumeLayout(false);
					num = 261;
				}
				if (num == 256)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 257;
				}
				if (num == 251)
				{
					base.Controls.Add(this.panel1);
					num = 252;
				}
				if (num == 247)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 248;
				}
				if (num == 242)
				{
					this.siticoneCheckBox1.TabIndex = 293;
					num = 243;
				}
				if (num == 237)
				{
					this.siticoneCheckBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 238;
				}
				if (num == 233)
				{
					this.siticoneCheckBox1.AutoSize = true;
					num = 234;
				}
				if (num == 228)
				{
					this.label1.Location = new global::System.Drawing.Point(56, 148);
					num = 229;
				}
				if (num == 224)
				{
					this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
					num = 225;
				}
				if (num == 219)
				{
					this.linkLabel1.Size = new global::System.Drawing.Size(106, 13);
					num = 220;
				}
				if (num == 215)
				{
					this.linkLabel1.AutoSize = true;
					num = 216;
				}
				if (num == 210)
				{
					this.yt.TabIndex = 296;
					num = 211;
				}
				if (num == 205)
				{
					this.yt.ForeColor = global::System.Drawing.Color.White;
					num = 206;
				}
				if (num == 201)
				{
					this.yt.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 202;
				}
				if (num == 196)
				{
					this.twitter.UseVisualStyleBackColor = false;
					num = 197;
				}
				if (num == 192)
				{
					this.twitter.Name = "twitter";
					num = 193;
				}
				if (num == 187)
				{
					this.twitter.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 188;
				}
				if (num == 183)
				{
					this.twitter.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("twitter.BackgroundImage");
					num = 184;
				}
				if (num == 178)
				{
					this.ig.TabIndex = 298;
					num = 179;
				}
				if (num == 173)
				{
					this.ig.ForeColor = global::System.Drawing.Color.White;
					num = 174;
				}
				if (num == 169)
				{
					this.ig.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 170;
				}
				if (num == 164)
				{
					this.discord.UseVisualStyleBackColor = false;
					num = 165;
				}
				if (num == 160)
				{
					this.discord.Name = "discord";
					num = 161;
				}
				if (num == 155)
				{
					this.discord.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 156;
				}
				if (num == 151)
				{
					this.discord.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("discord.BackgroundImage");
					num = 152;
				}
				if (num == 146)
				{
					this.lbl_ver.Name = "lbl_ver";
					num = 147;
				}
				if (num == 141)
				{
					this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
					num = 142;
				}
				if (num == 137)
				{
					this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
					num = 138;
				}
				if (num == 132)
				{
					this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Bold);
					num = 133;
				}
				if (num == 128)
				{
					this.siticoneRoundedButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
					num = 129;
				}
				if (num == 123)
				{
					this.siticoneRoundedButton1.BorderRadius = 16;
					num = 124;
				}
				if (num == 118)
				{
					this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
					num = 119;
				}
				if (num == 114)
				{
					this.siticoneRoundedButton3.ForeColor = global::System.Drawing.Color.White;
					num = 115;
				}
				if (num == 109)
				{
					this.siticoneRoundedButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
					num = 110;
				}
				if (num == 105)
				{
					this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
					num = 106;
				}
				if (num == 100)
				{
					this.pictureBox5.Size = new global::System.Drawing.Size(180, 180);
					num = 101;
				}
				if (num == 96)
				{
					this.pictureBox6.TabStop = false;
					num = 97;
				}
				if (num == 91)
				{
					this.pictureBox6.Location = new global::System.Drawing.Point(-180, 0);
					num = 92;
				}
				if (num == 86)
				{
					this.panel2.Location = new global::System.Drawing.Point(0, 50);
					num = 87;
				}
				if (num == 82)
				{
					this.panel2.Controls.Add(this.linkLabel1);
					num = 83;
				}
				if (num == 77)
				{
					this.panel2.Controls.Add(this.lbl_ver);
					num = 78;
				}
				if (num == 73)
				{
					this.panel2.Controls.Add(this.pictureBox6);
					num = 74;
				}
				if (num == 68)
				{
					this.siticoneControlBox1.Name = "siticoneControlBox1";
					num = 69;
				}
				if (num == 64)
				{
					this.siticoneControlBox1.HoverState.IconColor = global::System.Drawing.Color.White;
					num = 65;
				}
				if (num == 59)
				{
					this.siticoneControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
					num = 60;
				}
				if (num == 54)
				{
					this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
					num = 55;
				}
				if (num == 50)
				{
					this.siticoneRoundedButton2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(38, 38, 38);
					num = 51;
				}
				if (num == 45)
				{
					this.siticoneRoundedButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
					num = 46;
				}
				if (num == 41)
				{
					this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
					num = 42;
				}
				if (num == 36)
				{
					this.panel1.Size = new global::System.Drawing.Size(333, 50);
					num = 37;
				}
				if (num == 32)
				{
					this.panel1.Controls.Add(this.siticoneRoundedButton2);
					num = 33;
				}
				if (num == 27)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 28;
				}
				if (num == 22)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
					num = 23;
				}
				if (num == 18)
				{
					this.siticoneCheckBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
					num = 19;
				}
				if (num == 13)
				{
					this.ig = new global::System.Windows.Forms.Button();
					num = 14;
				}
				if (num == 9)
				{
					this.siticoneRoundedButton3 = new global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
					num = 10;
				}
				if (num == 4)
				{
					this.siticoneRoundedButton2 = new global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 266);
		}

		// Token: 0x040003DA RID: 986
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040003DB RID: 987
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040003DE RID: 990
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;

		// Token: 0x040003DF RID: 991
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003E0 RID: 992
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x040003E1 RID: 993
		private global::System.Windows.Forms.Button discord;

		// Token: 0x040003E2 RID: 994
		private global::System.Windows.Forms.Button ig;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.Forms.Button twitter;

		// Token: 0x040003E4 RID: 996
		private global::System.Windows.Forms.Button yt;

		// Token: 0x040003E5 RID: 997
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x040003E6 RID: 998
		private global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x040003E7 RID: 999
		private global::System.Windows.Forms.Label lbl_ver;

		// Token: 0x040003E8 RID: 1000
		private global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x040003E9 RID: 1001
		private global::Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x040003EA RID: 1002
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040003EB RID: 1003
		private global::System.Windows.Forms.PictureBox pictureBox6;
	}
}
