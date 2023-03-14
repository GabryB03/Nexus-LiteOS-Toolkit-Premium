using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000011 RID: 17
	public class Activate : UserControl
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000187C8 File Offset: 0x000169C8
		public static Activate Instance
		{
			get
			{
				if (Activate._instace == null)
				{
					Activate._instace = new Activate();
				}
				return Activate._instace;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000187F0 File Offset: 0x000169F0
		public Activate()
		{
			this.InitializeComponent();
			if (!this.DEBUG)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker
				{
					WorkerSupportsCancellation = false
				};
				backgroundWorker.RunWorkerAsync();
				BackgroundWorker backgroundWorker2 = new BackgroundWorker
				{
					WorkerSupportsCancellation = false
				};
				backgroundWorker2.DoWork += this.BackgroundWorker_InitWMI;
				backgroundWorker2.RunWorkerCompleted += this.BackgroundWorker_InitCompleted;
				backgroundWorker2.RunWorkerAsync();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001887C File Offset: 0x00016A7C
		private void BackgroundWorker_InitCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					base.Invalidate();
					num = 3;
				}
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.DoWork += delegate(object sender, DoWorkEventArgs e)
					{
						Thread.Sleep(6 + sizeof(float));
					};
					num = 5;
				}
				if (num == 6)
				{
					backgroundWorker.RunWorkerAsync();
					num = 7;
				}
				if (num == 5)
				{
					backgroundWorker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
					{
						int num2 = 0;
						do
						{
							if (num2 == 2)
							{
								base.Invalidate();
								num2 = 3;
							}
							if (num2 == 1)
							{
								this.Text = "Computer information";
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 3);
					};
					num = 6;
				}
				if (num == 3)
				{
					backgroundWorker = new BackgroundWorker();
					num = 4;
				}
				if (num == 1)
				{
					this.PrintSummaryInformation(this.MB_Caption, this.BIOS_Base_Board_Manufacturer, this.BIOS_Base_Board_Version, this.BIOS_Release_Date, this.BIOS_Version, this.BIOS_Vendor, this.OS_Install_Time, this.OS_Last_Boot_Up_Time, this.GPU_Current_Refresh_Rate, this.GPU_Max_Refresh_Rate, this.GPU_Min_Refresh_Rate, this.CPU_L2CACHE, this.CPU_L3CACHE);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00018A24 File Offset: 0x00016C24
		public void PrintSummaryInformation(Label MB_Caption, Label BIOS_Base_Board_Manufacturer, Label BIOS_Base_Board_Version, Label BIOS_Release_Date, Label BIOS_Version, Label BIOS_Vendor, Label OS_Install_Time, Label OS_Last_Boot_Up_Time, Label GPU_Current_Refresh_Rate, Label GPU_Max_Refresh_Rate, Label GPU_Min_Refresh_Rate, Label CPU_L2CACHE, Label CPU_L3CACHE)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					BIOS_Base_Board_Version.Text = this.bios.BaseVersion;
					num = 4;
				}
				DateTime installTime;
				if (num == 7)
				{
					installTime = this.os.InstallTime;
					num = 8;
				}
				if (num == 11)
				{
					GPU_Current_Refresh_Rate.Text = this.gpu.CurrentRefreshRate + "hz";
					num = 12;
				}
				if (num == 15)
				{
					CPU_L3CACHE.Text = string.Format("{0:F2} Mb", (float)this.cpu.L3CacheSize / 1024f);
					num = 16;
				}
				if (num == 14)
				{
					CPU_L2CACHE.Text = string.Format("{0:F2} Mb", (float)this.cpu.L2CacheSize / 1024f);
					num = 15;
				}
				if (num == 13)
				{
					GPU_Min_Refresh_Rate.Text = this.gpu.MinRefreshRate + "hz";
					num = 14;
				}
				if (num == 12)
				{
					GPU_Max_Refresh_Rate.Text = this.gpu.MaxRefreshRate + "hz";
					num = 13;
				}
				if (num == 10)
				{
					DateTime dateTime;
					OS_Last_Boot_Up_Time.Text = dateTime.ToString();
					num = 11;
				}
				if (num == 9)
				{
					DateTime dateTime = ManagementDateTimeConverter.ToDateTime(this.os.LastBootUpTime);
					num = 10;
				}
				if (num == 8)
				{
					OS_Install_Time.Text = installTime.ToString();
					num = 9;
				}
				if (num == 6)
				{
					BIOS_Vendor.Text = this.bios.BiosVendor;
					num = 7;
				}
				if (num == 5)
				{
					BIOS_Version.Text = this.bios.BiosVersion;
					num = 6;
				}
				if (num == 4)
				{
					BIOS_Release_Date.Text = this.bios.ReleaseDate;
					num = 5;
				}
				if (num == 2)
				{
					BIOS_Base_Board_Manufacturer.Text = this.bios.BaseManufacturer;
					num = 3;
				}
				if (num == 1)
				{
					MB_Caption.Text = this.bios.BaseProduct;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 16);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00018D48 File Offset: 0x00016F48
		private void BackgroundWorker_InitWMI(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.ram = new RAM();
					num = 4;
				}
				if (num == 6)
				{
					this.os = new OS();
					num = 7;
				}
				if (num == 5)
				{
					this.gpu = new GPU();
					num = 6;
				}
				if (num == 4)
				{
					this.disk = new Disk();
					num = 5;
				}
				if (num == 2)
				{
					this.bios = new Bios();
					num = 3;
				}
				if (num == 1)
				{
					this.cpu = new CPU();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00018E68 File Offset: 0x00017068
		private void button22_Click(object sender, EventArgs e)
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

		// Token: 0x06000095 RID: 149 RVA: 0x00018EC8 File Offset: 0x000170C8
		private void button24_Click(object sender, EventArgs e)
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

		// Token: 0x06000096 RID: 150 RVA: 0x00018F28 File Offset: 0x00017128
		private void button21_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Process.Start("https://dsc.gg/nexustoolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00018F88 File Offset: 0x00017188
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00018FE4 File Offset: 0x000171E4
		private void button17_Click(object sender, EventArgs e)
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

		// Token: 0x06000099 RID: 153 RVA: 0x00019044 File Offset: 0x00017244
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

		// Token: 0x0600009A RID: 154 RVA: 0x000190BC File Offset: 0x000172BC
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.label4 = new Label();
					num = 4;
				}
				if (num == 7)
				{
					this.BIOS_Base_Board_Version = new Label();
					num = 8;
				}
				if (num == 11)
				{
					this.label5 = new Label();
					num = 12;
				}
				if (num == 15)
				{
					this.BIOS_Release_Date = new Label();
					num = 16;
				}
				if (num == 19)
				{
					this.label17 = new Label();
					num = 20;
				}
				if (num == 22)
				{
					this.CPU_L3CACHE = new Label();
					num = 23;
				}
				if (num == 26)
				{
					this.OS_Install_Time = new Label();
					num = 27;
				}
				if (num == 30)
				{
					this.GPU_Current_Refresh_Rate = new Label();
					num = 31;
				}
				if (num == 34)
				{
					this.label26 = new Label();
					num = 35;
				}
				if (num == 38)
				{
					((ISupportInitialize)this.pictureBox2).BeginInit();
					num = 39;
				}
				if (num == 41)
				{
					this.groupBox3.SuspendLayout();
					num = 42;
				}
				if (num == 45)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 46;
				}
				if (num == 49)
				{
					this.label1.Size = new Size(329, 53);
					num = 50;
				}
				if (num == 53)
				{
					this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 54;
				}
				if (num == 57)
				{
					this.label4.Size = new Size(220, 19);
					num = 58;
				}
				if (num == 60)
				{
					this.groupBox2.Controls.Add(this.pictureBox2);
					num = 61;
				}
				if (num == 64)
				{
					this.groupBox2.Controls.Add(this.label8);
					num = 65;
				}
				if (num == 68)
				{
					this.groupBox2.ForeColor = Color.White;
					num = 69;
				}
				if (num == 72)
				{
					this.groupBox2.TabIndex = 89;
					num = 73;
				}
				if (num == 76)
				{
					this.pictureBox2.Location = new Point(402, 197);
					num = 77;
				}
				if (num == 80)
				{
					this.pictureBox2.TabIndex = 13;
					num = 81;
				}
				if (num == 83)
				{
					this.MB_Caption.Location = new Point(140, 33);
					num = 84;
				}
				if (num == 87)
				{
					this.MB_Caption.Text = "Loading...";
					num = 88;
				}
				if (num == 91)
				{
					this.BIOS_Base_Board_Version.Size = new Size(67, 23);
					num = 92;
				}
				if (num == 95)
				{
					this.BIOS_Base_Board_Manufacturer.Location = new Point(102, 74);
					num = 96;
				}
				if (num == 99)
				{
					this.BIOS_Base_Board_Manufacturer.Text = "Loading...";
					num = 100;
				}
				if (num == 102)
				{
					this.label8.Name = "label8";
					num = 103;
				}
				if (num == 106)
				{
					this.label7.AutoSize = true;
					num = 107;
				}
				if (num == 110)
				{
					this.label7.TabIndex = 4;
					num = 111;
				}
				if (num == 114)
				{
					this.label5.Name = "label5";
					num = 115;
				}
				if (num == 118)
				{
					this.groupBox1.Controls.Add(this.pictureBox1);
					num = 119;
				}
				if (num == 121)
				{
					this.groupBox1.Controls.Add(this.BIOS_Version);
					num = 122;
				}
				if (num == 125)
				{
					this.groupBox1.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 126;
				}
				if (num == 129)
				{
					this.groupBox1.Size = new Size(472, 258);
					num = 130;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 133)
				{
					this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 134;
				}
				if (num == 137)
				{
					this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 138;
				}
				if (num == 141)
				{
					this.BIOS_Vendor.Location = new Point(94, 115);
					num = 142;
				}
				if (num == 144)
				{
					this.BIOS_Vendor.TabIndex = 3;
					num = 145;
				}
				if (num == 148)
				{
					this.BIOS_Release_Date.Name = "BIOS_Release_Date";
					num = 149;
				}
				if (num == 152)
				{
					this.BIOS_Version.AutoSize = true;
					num = 153;
				}
				if (num == 156)
				{
					this.BIOS_Version.TabIndex = 5;
					num = 157;
				}
				if (num == 160)
				{
					this.label15.Name = "label15";
					num = 161;
				}
				if (num == 163)
				{
					this.label15.Text = "BIOS Vendor :";
					num = 164;
				}
				if (num == 167)
				{
					this.label16.Size = new Size(95, 23);
					num = 168;
				}
				if (num == 171)
				{
					this.label17.Location = new Point(6, 33);
					num = 172;
				}
				if (num == 175)
				{
					this.label17.Text = "BIOS Release Date :";
					num = 176;
				}
				if (num == 179)
				{
					this.groupBox3.Controls.Add(this.label10);
					num = 180;
				}
				if (num == 182)
				{
					this.groupBox3.Controls.Add(this.GPU_Min_Refresh_Rate);
					num = 183;
				}
				if (num == 186)
				{
					this.groupBox3.Controls.Add(this.label23);
					num = 187;
				}
				if (num == 190)
				{
					this.groupBox3.Controls.Add(this.label27);
					num = 191;
				}
				if (num == 194)
				{
					this.groupBox3.Name = "groupBox3";
					num = 195;
				}
				if (num == 198)
				{
					this.groupBox3.Text = "Other Information";
					num = 199;
				}
				if (num == 202)
				{
					this.pictureBox3.Size = new Size(64, 64);
					num = 203;
				}
				if (num == 205)
				{
					this.pictureBox3.TabStop = false;
					num = 206;
				}
				if (num == 209)
				{
					this.CPU_L3CACHE.Size = new Size(67, 23);
					num = 210;
				}
				if (num == 213)
				{
					this.CPU_L2CACHE.Location = new Point(74, 238);
					num = 214;
				}
				if (num == 217)
				{
					this.CPU_L2CACHE.Text = "Loading...";
					num = 218;
				}
				if (num == 221)
				{
					this.label10.Size = new Size(74, 23);
					num = 222;
				}
				if (num == 224)
				{
					this.label3.AutoSize = true;
					num = 225;
				}
				if (num == 228)
				{
					this.label3.TabIndex = 9;
					num = 229;
				}
				if (num == 232)
				{
					this.OS_Install_Time.Name = "OS_Install_Time";
					num = 233;
				}
				if (num == 236)
				{
					this.GPU_Min_Refresh_Rate.AutoSize = true;
					num = 237;
				}
				if (num == 240)
				{
					this.GPU_Min_Refresh_Rate.TabIndex = 8;
					num = 241;
				}
				if (num == 243)
				{
					this.GPU_Max_Refresh_Rate.Location = new Point(165, 156);
					num = 244;
				}
				if (num == 247)
				{
					this.GPU_Max_Refresh_Rate.Text = "Loading...";
					num = 248;
				}
				if (num == 251)
				{
					this.OS_Last_Boot_Up_Time.Size = new Size(67, 23);
					num = 252;
				}
				if (num == 255)
				{
					this.GPU_Current_Refresh_Rate.Location = new Point(149, 115);
					num = 256;
				}
				if (num == 259)
				{
					this.GPU_Current_Refresh_Rate.Text = "Loading...";
					num = 260;
				}
				if (num == 262)
				{
					this.label23.Name = "label23";
					num = 263;
				}
				if (num == 266)
				{
					this.label24.AutoSize = true;
					num = 267;
				}
				if (num == 270)
				{
					this.label24.TabIndex = 5;
					num = 271;
				}
				if (num == 274)
				{
					this.label25.Name = "label25";
					num = 275;
				}
				if (num == 278)
				{
					this.label26.AutoSize = true;
					num = 279;
				}
				if (num == 282)
				{
					this.label26.TabIndex = 3;
					num = 283;
				}
				if (num == 285)
				{
					this.label27.Location = new Point(6, 33);
					num = 286;
				}
				if (num == 289)
				{
					this.label27.Text = "OS Install Time :";
					num = 290;
				}
				if (num == 293)
				{
					this.back_btn.CustomImages.Parent = this.back_btn;
					num = 294;
				}
				if (num == 297)
				{
					this.back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 298;
				}
				if (num == 301)
				{
					this.back_btn.ForeColor = Color.White;
					num = 302;
				}
				if (num == 304)
				{
					this.back_btn.Name = "back_btn";
					num = 305;
				}
				if (num == 308)
				{
					this.back_btn.Text = "Back";
					num = 309;
				}
				if (num == 312)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 313;
				}
				if (num == 316)
				{
					base.Controls.Add(this.groupBox2);
					num = 317;
				}
				if (num == 320)
				{
					base.Size = new Size(1006, 669);
					num = 321;
				}
				if (num == 323)
				{
					((ISupportInitialize)this.pictureBox2).EndInit();
					num = 324;
				}
				if (num == 327)
				{
					this.groupBox3.ResumeLayout(false);
					num = 328;
				}
				if (num == 331)
				{
					base.PerformLayout();
					num = 332;
				}
				if (num == 330)
				{
					base.ResumeLayout(false);
					num = 331;
				}
				if (num == 329)
				{
					((ISupportInitialize)this.pictureBox3).EndInit();
					num = 330;
				}
				if (num == 328)
				{
					this.groupBox3.PerformLayout();
					num = 329;
				}
				if (num == 326)
				{
					((ISupportInitialize)this.pictureBox1).EndInit();
					num = 327;
				}
				if (num == 325)
				{
					this.groupBox1.PerformLayout();
					num = 326;
				}
				if (num == 324)
				{
					this.groupBox1.ResumeLayout(false);
					num = 325;
				}
				if (num == 322)
				{
					this.groupBox2.PerformLayout();
					num = 323;
				}
				if (num == 321)
				{
					this.groupBox2.ResumeLayout(false);
					num = 322;
				}
				if (num == 319)
				{
					base.Name = "activate";
					num = 320;
				}
				if (num == 318)
				{
					base.Controls.Add(this.label1);
					num = 319;
				}
				if (num == 317)
				{
					base.Controls.Add(this.label4);
					num = 318;
				}
				if (num == 315)
				{
					base.Controls.Add(this.groupBox1);
					num = 316;
				}
				if (num == 314)
				{
					base.Controls.Add(this.groupBox3);
					num = 315;
				}
				if (num == 313)
				{
					base.Controls.Add(this.back_btn);
					num = 314;
				}
				if (num == 311)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 312;
				}
				if (num == 310)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 311;
				}
				if (num == 309)
				{
					this.back_btn.Click += this.siticoneRoundedButton1_Click;
					num = 310;
				}
				if (num == 307)
				{
					this.back_btn.TabIndex = 92;
					num = 308;
				}
				if (num == 306)
				{
					this.back_btn.Size = new Size(88, 30);
					num = 307;
				}
				if (num == 305)
				{
					this.back_btn.ShadowDecoration.Parent = this.back_btn;
					num = 306;
				}
				if (num == 303)
				{
					this.back_btn.Location = new Point(882, 56);
					num = 304;
				}
				if (num == 302)
				{
					this.back_btn.HoverState.Parent = this.back_btn;
					num = 303;
				}
				if (num == 300)
				{
					this.back_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 301;
				}
				if (num == 299)
				{
					this.back_btn.FillColor = Color.Transparent;
					num = 300;
				}
				if (num == 298)
				{
					this.back_btn.DisabledState.Parent = this.back_btn;
					num = 299;
				}
				if (num == 296)
				{
					this.back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 297;
				}
				if (num == 295)
				{
					this.back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 296;
				}
				if (num == 294)
				{
					this.back_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 295;
				}
				if (num == 292)
				{
					this.back_btn.CheckedState.Parent = this.back_btn;
					num = 293;
				}
				if (num == 291)
				{
					this.back_btn.BorderRadius = 14;
					num = 292;
				}
				if (num == 290)
				{
					this.back_btn.BackColor = Color.FromArgb(38, 38, 38);
					num = 291;
				}
				if (num == 288)
				{
					this.label27.TabIndex = 2;
					num = 289;
				}
				if (num == 287)
				{
					this.label27.Size = new Size(110, 23);
					num = 288;
				}
				if (num == 286)
				{
					this.label27.Name = "label27";
					num = 287;
				}
				if (num == 284)
				{
					this.label27.AutoSize = true;
					num = 285;
				}
				if (num == 283)
				{
					this.label26.Text = "Last Boot Up Time :";
					num = 284;
				}
				if (num == 281)
				{
					this.label26.Size = new Size(130, 23);
					num = 282;
				}
				if (num == 280)
				{
					this.label26.Name = "label26";
					num = 281;
				}
				if (num == 279)
				{
					this.label26.Location = new Point(6, 74);
					num = 280;
				}
				if (num == 277)
				{
					this.label25.Text = "Maximum Refresh Rate :";
					num = 278;
				}
				if (num == 276)
				{
					this.label25.TabIndex = 4;
					num = 277;
				}
				if (num == 275)
				{
					this.label25.Size = new Size(163, 23);
					num = 276;
				}
				if (num == 273)
				{
					this.label25.Location = new Point(6, 156);
					num = 274;
				}
				if (num == 272)
				{
					this.label25.AutoSize = true;
					num = 273;
				}
				if (num == 271)
				{
					this.label24.Text = "Minimum Refresh Rate :";
					num = 272;
				}
				if (num == 269)
				{
					this.label24.Size = new Size(159, 23);
					num = 270;
				}
				if (num == 268)
				{
					this.label24.Name = "label24";
					num = 269;
				}
				if (num == 267)
				{
					this.label24.Location = new Point(6, 197);
					num = 268;
				}
				if (num == 265)
				{
					this.label23.Text = "Current Refresh Rate :";
					num = 266;
				}
				if (num == 264)
				{
					this.label23.TabIndex = 6;
					num = 265;
				}
				if (num == 263)
				{
					this.label23.Size = new Size(147, 23);
					num = 264;
				}
				if (num == 261)
				{
					this.label23.Location = new Point(6, 115);
					num = 262;
				}
				if (num == 260)
				{
					this.label23.AutoSize = true;
					num = 261;
				}
				if (num == 258)
				{
					this.GPU_Current_Refresh_Rate.TabIndex = 3;
					num = 259;
				}
				if (num == 257)
				{
					this.GPU_Current_Refresh_Rate.Size = new Size(67, 23);
					num = 258;
				}
				if (num == 256)
				{
					this.GPU_Current_Refresh_Rate.Name = "GPU_Current_Refresh_Rate";
					num = 257;
				}
				if (num == 254)
				{
					this.GPU_Current_Refresh_Rate.AutoSize = true;
					num = 255;
				}
				if (num == 253)
				{
					this.OS_Last_Boot_Up_Time.Text = "Loading...";
					num = 254;
				}
				if (num == 252)
				{
					this.OS_Last_Boot_Up_Time.TabIndex = 5;
					num = 253;
				}
				if (num == 250)
				{
					this.OS_Last_Boot_Up_Time.Name = "OS_Last_Boot_Up_Time";
					num = 251;
				}
				if (num == 249)
				{
					this.OS_Last_Boot_Up_Time.Location = new Point(132, 74);
					num = 250;
				}
				if (num == 248)
				{
					this.OS_Last_Boot_Up_Time.AutoSize = true;
					num = 249;
				}
				if (num == 246)
				{
					this.GPU_Max_Refresh_Rate.TabIndex = 7;
					num = 247;
				}
				if (num == 245)
				{
					this.GPU_Max_Refresh_Rate.Size = new Size(67, 23);
					num = 246;
				}
				if (num == 244)
				{
					this.GPU_Max_Refresh_Rate.Name = "GPU_Max_Refresh_Rate";
					num = 245;
				}
				if (num == 242)
				{
					this.GPU_Max_Refresh_Rate.AutoSize = true;
					num = 243;
				}
				if (num == 241)
				{
					this.GPU_Min_Refresh_Rate.Text = "Loading...";
					num = 242;
				}
				if (num == 239)
				{
					this.GPU_Min_Refresh_Rate.Size = new Size(67, 23);
					num = 240;
				}
				if (num == 238)
				{
					this.GPU_Min_Refresh_Rate.Name = "GPU_Min_Refresh_Rate";
					num = 239;
				}
				if (num == 237)
				{
					this.GPU_Min_Refresh_Rate.Location = new Point(165, 197);
					num = 238;
				}
				if (num == 235)
				{
					this.OS_Install_Time.Text = "Loading...";
					num = 236;
				}
				if (num == 234)
				{
					this.OS_Install_Time.TabIndex = 0;
					num = 235;
				}
				if (num == 233)
				{
					this.OS_Install_Time.Size = new Size(67, 23);
					num = 234;
				}
				if (num == 231)
				{
					this.OS_Install_Time.Location = new Point(112, 33);
					num = 232;
				}
				if (num == 230)
				{
					this.OS_Install_Time.AutoSize = true;
					num = 231;
				}
				if (num == 229)
				{
					this.label3.Text = "L2 Cache :";
					num = 230;
				}
				if (num == 227)
				{
					this.label3.Size = new Size(74, 23);
					num = 228;
				}
				if (num == 226)
				{
					this.label3.Name = "label3";
					num = 227;
				}
				if (num == 225)
				{
					this.label3.Location = new Point(6, 238);
					num = 226;
				}
				if (num == 223)
				{
					this.label10.Text = "L3 Cache :";
					num = 224;
				}
				if (num == 222)
				{
					this.label10.TabIndex = 10;
					num = 223;
				}
				if (num == 220)
				{
					this.label10.Name = "label10";
					num = 221;
				}
				if (num == 219)
				{
					this.label10.Location = new Point(6, 279);
					num = 220;
				}
				if (num == 218)
				{
					this.label10.AutoSize = true;
					num = 219;
				}
				if (num == 216)
				{
					this.CPU_L2CACHE.TabIndex = 11;
					num = 217;
				}
				if (num == 215)
				{
					this.CPU_L2CACHE.Size = new Size(67, 23);
					num = 216;
				}
				if (num == 214)
				{
					this.CPU_L2CACHE.Name = "CPU_L2CACHE";
					num = 215;
				}
				if (num == 212)
				{
					this.CPU_L2CACHE.AutoSize = true;
					num = 213;
				}
				if (num == 211)
				{
					this.CPU_L3CACHE.Text = "Loading...";
					num = 212;
				}
				if (num == 210)
				{
					this.CPU_L3CACHE.TabIndex = 12;
					num = 211;
				}
				if (num == 208)
				{
					this.CPU_L3CACHE.Name = "CPU_L3CACHE";
					num = 209;
				}
				if (num == 207)
				{
					this.CPU_L3CACHE.Location = new Point(74, 279);
					num = 208;
				}
				if (num == 206)
				{
					this.CPU_L3CACHE.AutoSize = true;
					num = 207;
				}
				if (num == 204)
				{
					this.pictureBox3.TabIndex = 14;
					num = 205;
				}
				if (num == 203)
				{
					this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 204;
				}
				if (num == 201)
				{
					this.pictureBox3.Name = "pictureBox3";
					num = 202;
				}
				if (num == 200)
				{
					this.pictureBox3.Location = new Point(386, 473);
					num = 201;
				}
				if (num == 199)
				{
					this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
					num = 200;
				}
				if (num == 197)
				{
					this.groupBox3.TabStop = false;
					num = 198;
				}
				if (num == 196)
				{
					this.groupBox3.TabIndex = 91;
					num = 197;
				}
				if (num == 195)
				{
					this.groupBox3.Size = new Size(456, 543);
					num = 196;
				}
				if (num == 193)
				{
					this.groupBox3.Location = new Point(520, 92);
					num = 194;
				}
				if (num == 192)
				{
					this.groupBox3.ForeColor = Color.White;
					num = 193;
				}
				if (num == 191)
				{
					this.groupBox3.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 192;
				}
				if (num == 189)
				{
					this.groupBox3.Controls.Add(this.label26);
					num = 190;
				}
				if (num == 188)
				{
					this.groupBox3.Controls.Add(this.label25);
					num = 189;
				}
				if (num == 187)
				{
					this.groupBox3.Controls.Add(this.label24);
					num = 188;
				}
				if (num == 185)
				{
					this.groupBox3.Controls.Add(this.GPU_Current_Refresh_Rate);
					num = 186;
				}
				if (num == 184)
				{
					this.groupBox3.Controls.Add(this.OS_Last_Boot_Up_Time);
					num = 185;
				}
				if (num == 183)
				{
					this.groupBox3.Controls.Add(this.GPU_Max_Refresh_Rate);
					num = 184;
				}
				if (num == 181)
				{
					this.groupBox3.Controls.Add(this.OS_Install_Time);
					num = 182;
				}
				if (num == 180)
				{
					this.groupBox3.Controls.Add(this.label3);
					num = 181;
				}
				if (num == 178)
				{
					this.groupBox3.Controls.Add(this.CPU_L2CACHE);
					num = 179;
				}
				if (num == 177)
				{
					this.groupBox3.Controls.Add(this.CPU_L3CACHE);
					num = 178;
				}
				if (num == 176)
				{
					this.groupBox3.Controls.Add(this.pictureBox3);
					num = 177;
				}
				if (num == 174)
				{
					this.label17.TabIndex = 2;
					num = 175;
				}
				if (num == 173)
				{
					this.label17.Size = new Size(133, 23);
					num = 174;
				}
				if (num == 172)
				{
					this.label17.Name = "label17";
					num = 173;
				}
				if (num == 170)
				{
					this.label17.AutoSize = true;
					num = 171;
				}
				if (num == 169)
				{
					this.label16.Text = "BIOS Version :";
					num = 170;
				}
				if (num == 168)
				{
					this.label16.TabIndex = 3;
					num = 169;
				}
				if (num == 166)
				{
					this.label16.Name = "label16";
					num = 167;
				}
				if (num == 165)
				{
					this.label16.Location = new Point(6, 74);
					num = 166;
				}
				if (num == 164)
				{
					this.label16.AutoSize = true;
					num = 165;
				}
				if (num == 162)
				{
					this.label15.TabIndex = 4;
					num = 163;
				}
				if (num == 161)
				{
					this.label15.Size = new Size(94, 23);
					num = 162;
				}
				if (num == 159)
				{
					this.label15.Location = new Point(6, 115);
					num = 160;
				}
				if (num == 158)
				{
					this.label15.AutoSize = true;
					num = 159;
				}
				if (num == 157)
				{
					this.BIOS_Version.Text = "Loading...";
					num = 158;
				}
				if (num == 155)
				{
					this.BIOS_Version.Size = new Size(67, 23);
					num = 156;
				}
				if (num == 154)
				{
					this.BIOS_Version.Name = "BIOS_Version";
					num = 155;
				}
				if (num == 153)
				{
					this.BIOS_Version.Location = new Point(94, 74);
					num = 154;
				}
				if (num == 151)
				{
					this.BIOS_Release_Date.Text = "Loading...";
					num = 152;
				}
				if (num == 150)
				{
					this.BIOS_Release_Date.TabIndex = 0;
					num = 151;
				}
				if (num == 149)
				{
					this.BIOS_Release_Date.Size = new Size(67, 23);
					num = 150;
				}
				if (num == 147)
				{
					this.BIOS_Release_Date.Location = new Point(134, 33);
					num = 148;
				}
				if (num == 146)
				{
					this.BIOS_Release_Date.AutoSize = true;
					num = 147;
				}
				if (num == 145)
				{
					this.BIOS_Vendor.Text = "Loading...";
					num = 146;
				}
				if (num == 143)
				{
					this.BIOS_Vendor.Size = new Size(67, 23);
					num = 144;
				}
				if (num == 142)
				{
					this.BIOS_Vendor.Name = "BIOS_Vendor";
					num = 143;
				}
				if (num == 140)
				{
					this.BIOS_Vendor.AutoSize = true;
					num = 141;
				}
				if (num == 139)
				{
					this.pictureBox1.TabStop = false;
					num = 140;
				}
				if (num == 138)
				{
					this.pictureBox1.TabIndex = 14;
					num = 139;
				}
				if (num == 136)
				{
					this.pictureBox1.Size = new Size(64, 64);
					num = 137;
				}
				if (num == 135)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 136;
				}
				if (num == 134)
				{
					this.pictureBox1.Location = new Point(402, 188);
					num = 135;
				}
				if (num == 132)
				{
					this.groupBox1.Text = "BIOS Information";
					num = 133;
				}
				if (num == 131)
				{
					this.groupBox1.TabStop = false;
					num = 132;
				}
				if (num == 130)
				{
					this.groupBox1.TabIndex = 90;
					num = 131;
				}
				if (num == 128)
				{
					this.groupBox1.Name = "groupBox1";
					num = 129;
				}
				if (num == 127)
				{
					this.groupBox1.Location = new Point(27, 377);
					num = 128;
				}
				if (num == 126)
				{
					this.groupBox1.ForeColor = Color.White;
					num = 127;
				}
				if (num == 124)
				{
					this.groupBox1.Controls.Add(this.label17);
					num = 125;
				}
				if (num == 123)
				{
					this.groupBox1.Controls.Add(this.label16);
					num = 124;
				}
				if (num == 122)
				{
					this.groupBox1.Controls.Add(this.label15);
					num = 123;
				}
				if (num == 120)
				{
					this.groupBox1.Controls.Add(this.BIOS_Release_Date);
					num = 121;
				}
				if (num == 119)
				{
					this.groupBox1.Controls.Add(this.BIOS_Vendor);
					num = 120;
				}
				if (num == 117)
				{
					this.label5.Text = "Motherboard Name :";
					num = 118;
				}
				if (num == 116)
				{
					this.label5.TabIndex = 2;
					num = 117;
				}
				if (num == 115)
				{
					this.label5.Size = new Size(140, 23);
					num = 116;
				}
				if (num == 113)
				{
					this.label5.Location = new Point(6, 33);
					num = 114;
				}
				if (num == 112)
				{
					this.label5.AutoSize = true;
					num = 113;
				}
				if (num == 111)
				{
					this.label7.Text = "Manufacturer :";
					num = 112;
				}
				if (num == 109)
				{
					this.label7.Size = new Size(102, 23);
					num = 110;
				}
				if (num == 108)
				{
					this.label7.Name = "label7";
					num = 109;
				}
				if (num == 107)
				{
					this.label7.Location = new Point(6, 74);
					num = 108;
				}
				if (num == 105)
				{
					this.label8.Text = "Baseboard Version :";
					num = 106;
				}
				if (num == 104)
				{
					this.label8.TabIndex = 5;
					num = 105;
				}
				if (num == 103)
				{
					this.label8.Size = new Size(130, 23);
					num = 104;
				}
				if (num == 101)
				{
					this.label8.Location = new Point(6, 115);
					num = 102;
				}
				if (num == 100)
				{
					this.label8.AutoSize = true;
					num = 101;
				}
				if (num == 98)
				{
					this.BIOS_Base_Board_Manufacturer.TabIndex = 5;
					num = 99;
				}
				if (num == 97)
				{
					this.BIOS_Base_Board_Manufacturer.Size = new Size(67, 23);
					num = 98;
				}
				if (num == 96)
				{
					this.BIOS_Base_Board_Manufacturer.Name = "BIOS_Base_Board_Manufacturer";
					num = 97;
				}
				if (num == 94)
				{
					this.BIOS_Base_Board_Manufacturer.AutoSize = true;
					num = 95;
				}
				if (num == 93)
				{
					this.BIOS_Base_Board_Version.Text = "Loading...";
					num = 94;
				}
				if (num == 92)
				{
					this.BIOS_Base_Board_Version.TabIndex = 7;
					num = 93;
				}
				if (num == 90)
				{
					this.BIOS_Base_Board_Version.Name = "BIOS_Base_Board_Version";
					num = 91;
				}
				if (num == 89)
				{
					this.BIOS_Base_Board_Version.Location = new Point(130, 115);
					num = 90;
				}
				if (num == 88)
				{
					this.BIOS_Base_Board_Version.AutoSize = true;
					num = 89;
				}
				if (num == 86)
				{
					this.MB_Caption.TabIndex = 0;
					num = 87;
				}
				if (num == 85)
				{
					this.MB_Caption.Size = new Size(67, 23);
					num = 86;
				}
				if (num == 84)
				{
					this.MB_Caption.Name = "MB_Caption";
					num = 85;
				}
				if (num == 82)
				{
					this.MB_Caption.AutoSize = true;
					num = 83;
				}
				if (num == 81)
				{
					this.pictureBox2.TabStop = false;
					num = 82;
				}
				if (num == 79)
				{
					this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 80;
				}
				if (num == 78)
				{
					this.pictureBox2.Size = new Size(64, 64);
					num = 79;
				}
				if (num == 77)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 78;
				}
				if (num == 75)
				{
					this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 76;
				}
				if (num == 74)
				{
					this.groupBox2.Text = "Motherboard Information";
					num = 75;
				}
				if (num == 73)
				{
					this.groupBox2.TabStop = false;
					num = 74;
				}
				if (num == 71)
				{
					this.groupBox2.Size = new Size(472, 270);
					num = 72;
				}
				if (num == 70)
				{
					this.groupBox2.Name = "groupBox2";
					num = 71;
				}
				if (num == 69)
				{
					this.groupBox2.Location = new Point(27, 92);
					num = 70;
				}
				if (num == 67)
				{
					this.groupBox2.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 68;
				}
				if (num == 66)
				{
					this.groupBox2.Controls.Add(this.label5);
					num = 67;
				}
				if (num == 65)
				{
					this.groupBox2.Controls.Add(this.label7);
					num = 66;
				}
				if (num == 63)
				{
					this.groupBox2.Controls.Add(this.BIOS_Base_Board_Manufacturer);
					num = 64;
				}
				if (num == 62)
				{
					this.groupBox2.Controls.Add(this.BIOS_Base_Board_Version);
					num = 63;
				}
				if (num == 61)
				{
					this.groupBox2.Controls.Add(this.MB_Caption);
					num = 62;
				}
				if (num == 59)
				{
					this.label4.Text = "Get informaation about you hardware";
					num = 60;
				}
				if (num == 58)
				{
					this.label4.TabIndex = 88;
					num = 59;
				}
				if (num == 56)
				{
					this.label4.Name = "label4";
					num = 57;
				}
				if (num == 55)
				{
					this.label4.Location = new Point(23, 53);
					num = 56;
				}
				if (num == 54)
				{
					this.label4.ForeColor = Color.Silver;
					num = 55;
				}
				if (num == 52)
				{
					this.label4.AutoSize = true;
					num = 53;
				}
				if (num == 51)
				{
					this.label1.Text = "System Information";
					num = 52;
				}
				if (num == 50)
				{
					this.label1.TabIndex = 5;
					num = 51;
				}
				if (num == 48)
				{
					this.label1.Name = "label1";
					num = 49;
				}
				if (num == 47)
				{
					this.label1.Location = new Point(18, 0);
					num = 48;
				}
				if (num == 46)
				{
					this.label1.ForeColor = Color.White;
					num = 47;
				}
				if (num == 44)
				{
					this.label1.AutoSize = true;
					num = 45;
				}
				if (num == 43)
				{
					base.SuspendLayout();
					num = 44;
				}
				if (num == 42)
				{
					((ISupportInitialize)this.pictureBox3).BeginInit();
					num = 43;
				}
				if (num == 40)
				{
					((ISupportInitialize)this.pictureBox1).BeginInit();
					num = 41;
				}
				if (num == 39)
				{
					this.groupBox1.SuspendLayout();
					num = 40;
				}
				if (num == 37)
				{
					this.groupBox2.SuspendLayout();
					num = 38;
				}
				if (num == 36)
				{
					this.back_btn = new SiticoneRoundedButton();
					num = 37;
				}
				if (num == 35)
				{
					this.label27 = new Label();
					num = 36;
				}
				if (num == 33)
				{
					this.label25 = new Label();
					num = 34;
				}
				if (num == 32)
				{
					this.label24 = new Label();
					num = 33;
				}
				if (num == 31)
				{
					this.label23 = new Label();
					num = 32;
				}
				if (num == 29)
				{
					this.OS_Last_Boot_Up_Time = new Label();
					num = 30;
				}
				if (num == 28)
				{
					this.GPU_Max_Refresh_Rate = new Label();
					num = 29;
				}
				if (num == 27)
				{
					this.GPU_Min_Refresh_Rate = new Label();
					num = 28;
				}
				if (num == 25)
				{
					this.label3 = new Label();
					num = 26;
				}
				if (num == 24)
				{
					this.label10 = new Label();
					num = 25;
				}
				if (num == 23)
				{
					this.CPU_L2CACHE = new Label();
					num = 24;
				}
				if (num == 21)
				{
					this.pictureBox3 = new PictureBox();
					num = 22;
				}
				if (num == 20)
				{
					this.groupBox3 = new GroupBox();
					num = 21;
				}
				if (num == 18)
				{
					this.label16 = new Label();
					num = 19;
				}
				if (num == 17)
				{
					this.label15 = new Label();
					num = 18;
				}
				if (num == 16)
				{
					this.BIOS_Version = new Label();
					num = 17;
				}
				if (num == 14)
				{
					this.BIOS_Vendor = new Label();
					num = 15;
				}
				if (num == 13)
				{
					this.pictureBox1 = new PictureBox();
					num = 14;
				}
				if (num == 12)
				{
					this.groupBox1 = new GroupBox();
					num = 13;
				}
				if (num == 10)
				{
					this.label7 = new Label();
					num = 11;
				}
				if (num == 9)
				{
					this.label8 = new Label();
					num = 10;
				}
				if (num == 8)
				{
					this.BIOS_Base_Board_Manufacturer = new Label();
					num = 9;
				}
				if (num == 6)
				{
					this.MB_Caption = new Label();
					num = 7;
				}
				if (num == 5)
				{
					this.pictureBox2 = new PictureBox();
					num = 6;
				}
				if (num == 4)
				{
					this.groupBox2 = new GroupBox();
					num = 5;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Activate));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 332);
		}

		// Token: 0x040000BA RID: 186
		private CPU cpu;

		// Token: 0x040000BB RID: 187
		private Bios bios;

		// Token: 0x040000BC RID: 188
		private RAM ram;

		// Token: 0x040000BD RID: 189
		private Disk disk;

		// Token: 0x040000BE RID: 190
		private GPU gpu;

		// Token: 0x040000BF RID: 191
		private OS os;

		// Token: 0x040000C0 RID: 192
		private readonly bool DEBUG = false;

		// Token: 0x040000C1 RID: 193
		private static Activate _instace;

		// Token: 0x040000C2 RID: 194
		private IContainer components = null;

		// Token: 0x040000C3 RID: 195
		private Label label1;

		// Token: 0x040000C4 RID: 196
		private Label label4;

		// Token: 0x040000C5 RID: 197
		private GroupBox groupBox2;

		// Token: 0x040000C6 RID: 198
		private Label BIOS_Base_Board_Version;

		// Token: 0x040000C7 RID: 199
		private Label BIOS_Base_Board_Manufacturer;

		// Token: 0x040000C8 RID: 200
		private Label label8;

		// Token: 0x040000C9 RID: 201
		private Label label7;

		// Token: 0x040000CA RID: 202
		private Label label5;

		// Token: 0x040000CB RID: 203
		private Label MB_Caption;

		// Token: 0x040000CC RID: 204
		private GroupBox groupBox1;

		// Token: 0x040000CD RID: 205
		private Label BIOS_Release_Date;

		// Token: 0x040000CE RID: 206
		private Label BIOS_Version;

		// Token: 0x040000CF RID: 207
		private Label BIOS_Vendor;

		// Token: 0x040000D0 RID: 208
		private Label label15;

		// Token: 0x040000D1 RID: 209
		private Label label16;

		// Token: 0x040000D2 RID: 210
		private Label label17;

		// Token: 0x040000D3 RID: 211
		private GroupBox groupBox3;

		// Token: 0x040000D4 RID: 212
		private Label OS_Install_Time;

		// Token: 0x040000D5 RID: 213
		private Label GPU_Min_Refresh_Rate;

		// Token: 0x040000D6 RID: 214
		private Label GPU_Max_Refresh_Rate;

		// Token: 0x040000D7 RID: 215
		private Label OS_Last_Boot_Up_Time;

		// Token: 0x040000D8 RID: 216
		private Label GPU_Current_Refresh_Rate;

		// Token: 0x040000D9 RID: 217
		private Label label23;

		// Token: 0x040000DA RID: 218
		private Label label24;

		// Token: 0x040000DB RID: 219
		private Label label25;

		// Token: 0x040000DC RID: 220
		private Label label26;

		// Token: 0x040000DD RID: 221
		private Label label27;

		// Token: 0x040000DE RID: 222
		private SiticoneRoundedButton back_btn;

		// Token: 0x040000DF RID: 223
		private Label label3;

		// Token: 0x040000E0 RID: 224
		private Label label10;

		// Token: 0x040000E1 RID: 225
		private Label CPU_L3CACHE;

		// Token: 0x040000E2 RID: 226
		private Label CPU_L2CACHE;

		// Token: 0x040000E3 RID: 227
		private PictureBox pictureBox2;

		// Token: 0x040000E4 RID: 228
		private PictureBox pictureBox1;

		// Token: 0x040000E5 RID: 229
		private PictureBox pictureBox3;
	}
}
