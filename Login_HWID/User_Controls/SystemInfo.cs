using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.User_Controls;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200006B RID: 107
	public class SystemInfo : UserControl
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x001753AC File Offset: 0x001735AC
		public static SystemInfo Instance
		{
			get
			{
				if (SystemInfo._instace == null)
				{
					SystemInfo._instace = new SystemInfo();
				}
				return SystemInfo._instace;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x001753D4 File Offset: 0x001735D4
		public SystemInfo()
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

		// Token: 0x06000993 RID: 2451 RVA: 0x00175460 File Offset: 0x00173660
		private void BackgroundWorker_InitCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			int num = 0;
			do
			{
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
				if (num == 2)
				{
					base.Invalidate();
					num = 3;
				}
				if (num == 1)
				{
					this.PrintSummaryInformation(this.Summary_CPU_Caption, this.Summary_CPU_Clock, this.Summary_CPU_Voltage, this.CPU_Core_Label, this.CPU_Thread_Label, this.Summary_OS_Caption, this.Summary_OS_Architecture, this.Summary_OS_BuildNumber, this.Summary_OS_CurrentTimeZoneCode, this.Summary_OS_Version, this.RAM_Clock, this.RAM_Size, this.RAM_Voltage, this.RAM_Total_Virtual_Size, this.RAM_Manafacturer, this.GPU_Caption, this.GPU_RAM, this.GPU_Current_Resolution, this.GPU_Driver_Version, this.GPU_Driver_Date);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0017564C File Offset: 0x0017384C
		public void PrintSummaryInformation(Label CPU_Caption, Label CPU_Clock, Label CPU_Voltage, Label CPU_Core_Label, Label CPU_Thread_Label, Label OS_Caption, Label OS_Architecture, Label OS_BuildNumber, Label OS_CurrentTimeZoneCode, Label OS_Version, Label RAM_Clock, Label RAM_Size, Label RAM_Voltage, Label RAM_Total_Virtual_Size, Label RAM_Manafacturer, Label GPU_Caption, Label GPU_RAM, Label GPU_Current_Resolution, Label GPU_Driver_Version, Label GPU_Driver_Date)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					CPU_Core_Label.Text = this.cpu.CoreCount.ToString();
					num = 5;
				}
				if (num == 8)
				{
					OS_BuildNumber.Text = this.os.BuildNumber;
					num = 9;
				}
				double num2;
				if (num == 12)
				{
					num2 = (double)(this.ram.VirtualSize / 1024f / 1024f / 1024f);
					num = 13;
				}
				if (num == 16)
				{
					RAM_Total_Virtual_Size.Text = string.Format("{0:F2} GB", num2);
					num = 17;
				}
				if (num == 20)
				{
					GPU_Current_Resolution.Text = this.gpu.VideoModeDescription;
					num = 21;
				}
				if (num == 23)
				{
					DateTime dateTime;
					GPU_Driver_Date.Text = string.Format("{0}/{1}/{2}", dateTime.Month, dateTime.Day, dateTime.Year);
					num = 24;
				}
				if (num == 22)
				{
					DateTime dateTime = DateTime.ParseExact(this.gpu.DriverDate, "yyyyMMddHHmmss", null);
					num = 23;
				}
				if (num == 21)
				{
					GPU_Driver_Version.Text = this.gpu.DriverVersion;
					num = 22;
				}
				if (num == 19)
				{
					GPU_RAM.Text = string.Format("{0:F2} GB", (float)Convert.ToInt64(this.gpu.AdapterRAM) / 1024f / 1024f / 1024f);
					num = 20;
				}
				if (num == 18)
				{
					GPU_Caption.Text = this.gpu.Caption;
					num = 19;
				}
				if (num == 17)
				{
					RAM_Manafacturer.Text = this.ram.Manufacturer;
					num = 18;
				}
				if (num == 15)
				{
					RAM_Voltage.Text = string.Format("{0} V", this.ram.Voltage);
					num = 16;
				}
				if (num == 14)
				{
					double num3;
					RAM_Size.Text = string.Format("{0:F2} GB", num3);
					num = 15;
				}
				if (num == 13)
				{
					RAM_Clock.Text = string.Format("{0} Mhz", this.ram.Speed);
					num = 14;
				}
				if (num == 11)
				{
					double num3 = (double)(this.ram.PysicalSize / 1024f / 1024f / 1024f);
					num = 12;
				}
				if (num == 10)
				{
					OS_CurrentTimeZoneCode.Text = this.os.MUILanguages;
					num = 11;
				}
				if (num == 9)
				{
					OS_Version.Text = this.os.Version;
					num = 10;
				}
				if (num == 7)
				{
					OS_Architecture.Text = this.os.Architecture;
					num = 8;
				}
				if (num == 6)
				{
					OS_Caption.Text = this.os.Caption;
					num = 7;
				}
				if (num == 5)
				{
					CPU_Thread_Label.Text = this.cpu.ThreadCount.ToString();
					num = 6;
				}
				if (num == 3)
				{
					CPU_Voltage.Text = string.Format("{0:F3} V", this.cpu.Voltage);
					num = 4;
				}
				if (num == 2)
				{
					CPU_Clock.Text = string.Format("{0:F2} Ghz", (float)this.cpu.CurrentClock / 1000f);
					num = 3;
				}
				if (num == 1)
				{
					CPU_Caption.Text = this.cpu.Name;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 24);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00175B70 File Offset: 0x00173D70
		private void BackgroundWorker_InitWMI(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.disk = new Disk();
					num = 5;
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
				if (num == 3)
				{
					this.ram = new RAM();
					num = 4;
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

		// Token: 0x06000996 RID: 2454 RVA: 0x00003804 File Offset: 0x00001A04
		private void system_info_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00175C90 File Offset: 0x00173E90
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					Activate.Instance.Show();
					num = 5;
				}
				if (num == 3)
				{
					Activate.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Activate.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					base.Controls.Add(Activate.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00175D3C File Offset: 0x00173F3C
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

		// Token: 0x06000999 RID: 2457 RVA: 0x00175DB4 File Offset: 0x00173FB4
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.Summary_OS_CurrentTimeZoneCode = new Label();
					num = 5;
				}
				if (num == 8)
				{
					this.Summary_OS_BuildNumber = new Label();
					num = 9;
				}
				if (num == 12)
				{
					this.label3 = new Label();
					num = 13;
				}
				if (num == 16)
				{
					this.Summary_CPU_Voltage = new Label();
					num = 17;
				}
				if (num == 20)
				{
					this.pictureBox3 = new PictureBox();
					num = 21;
				}
				if (num == 24)
				{
					this.label7 = new Label();
					num = 25;
				}
				if (num == 28)
				{
					this.groupBox3 = new GroupBox();
					num = 29;
				}
				if (num == 32)
				{
					this.mem = new Label();
					num = 33;
				}
				if (num == 36)
				{
					this.Volt = new Label();
					num = 37;
				}
				if (num == 40)
				{
					this.pictureBox1 = new PictureBox();
					num = 41;
				}
				if (num == 44)
				{
					this.vers = new Label();
					num = 45;
				}
				if (num == 48)
				{
					this.label29 = new Label();
					num = 49;
				}
				if (num == 53)
				{
					this.groupBox1.SuspendLayout();
					num = 54;
				}
				if (num == 57)
				{
					((ISupportInitialize)this.pictureBox4).BeginInit();
					num = 58;
				}
				if (num == 61)
				{
					base.SuspendLayout();
					num = 62;
				}
				if (num == 65)
				{
					this.label1.Location = new Point(18, 0);
					num = 66;
				}
				if (num == 69)
				{
					this.label1.Text = "System Information";
					num = 70;
				}
				if (num == 73)
				{
					this.groupBox1.Controls.Add(this.label13);
					num = 74;
				}
				if (num == 77)
				{
					this.groupBox1.Controls.Add(this.label4);
					num = 78;
				}
				if (num == 81)
				{
					this.groupBox1.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 82;
				}
				if (num == 85)
				{
					this.groupBox1.Size = new Size(471, 264);
					num = 86;
				}
				if (num == 89)
				{
					this.Summary_OS_CurrentTimeZoneCode.AutoSize = true;
					num = 90;
				}
				if (num == 93)
				{
					this.Summary_OS_CurrentTimeZoneCode.TabIndex = 11;
					num = 94;
				}
				if (num == 97)
				{
					this.label15.Name = "label15";
					num = 98;
				}
				if (num == 102)
				{
					this.Summary_OS_Version.Location = new Point(62, 156);
					num = 103;
				}
				if (num == 106)
				{
					this.Summary_OS_Version.Text = "Loading...";
					num = 107;
				}
				if (num == 110)
				{
					this.label13.Size = new Size(61, 23);
					num = 111;
				}
				if (num == 114)
				{
					this.Summary_OS_BuildNumber.Location = new Point(104, 115);
					num = 115;
				}
				if (num == 118)
				{
					this.Summary_OS_BuildNumber.Text = "Loading...";
					num = 119;
				}
				if (num == 122)
				{
					this.Summary_OS_Architecture.Size = new Size(67, 23);
					num = 123;
				}
				if (num == 126)
				{
					this.Summary_OS_Caption.Location = new Point(126, 33);
					num = 127;
				}
				if (num == 130)
				{
					this.Summary_OS_Caption.Text = "Loading...";
					num = 131;
				}
				if (num == 134)
				{
					this.label4.Size = new Size(102, 23);
					num = 135;
				}
				if (num == 138)
				{
					this.label3.Location = new Point(6, 74);
					num = 139;
				}
				if (num == 142)
				{
					this.label3.Text = "Architecture :";
					num = 143;
				}
				if (num == 146)
				{
					this.label2.Size = new Size(126, 23);
					num = 147;
				}
				if (num == 151)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 152;
				}
				if (num == 155)
				{
					this.pictureBox2.TabStop = false;
					num = 156;
				}
				if (num == 159)
				{
					this.Summary_CPU_Clock.Size = new Size(67, 23);
					num = 160;
				}
				if (num == 163)
				{
					this.Summary_CPU_Voltage.Location = new Point(100, 115);
					num = 164;
				}
				if (num == 167)
				{
					this.Summary_CPU_Voltage.Text = "Loading...";
					num = 168;
				}
				if (num == 171)
				{
					this.Summary_CPU_Caption.Size = new Size(67, 23);
					num = 172;
				}
				if (num == 175)
				{
					this.groupBox2.Controls.Add(this.pictureBox3);
					num = 176;
				}
				if (num == 179)
				{
					this.groupBox2.Controls.Add(this.label9);
					num = 180;
				}
				if (num == 183)
				{
					this.groupBox2.Controls.Add(this.label5);
					num = 184;
				}
				if (num == 187)
				{
					this.groupBox2.Location = new Point(518, 92);
					num = 188;
				}
				if (num == 191)
				{
					this.groupBox2.TabStop = false;
					num = 192;
				}
				if (num == 195)
				{
					this.CPU_Thread_Label.Name = "CPU_Thread_Label";
					num = 196;
				}
				if (num == 200)
				{
					this.pictureBox3.Location = new Point(387, 194);
					num = 201;
				}
				if (num == 204)
				{
					this.pictureBox3.TabIndex = 22;
					num = 205;
				}
				if (num == 208)
				{
					this.CPU_Core_Label.Name = "CPU_Core_Label";
					num = 209;
				}
				if (num == 212)
				{
					this.label9.AutoSize = true;
					num = 213;
				}
				if (num == 216)
				{
					this.label9.TabIndex = 6;
					num = 217;
				}
				if (num == 220)
				{
					this.label8.Name = "label8";
					num = 221;
				}
				if (num == 224)
				{
					this.label7.AutoSize = true;
					num = 225;
				}
				if (num == 228)
				{
					this.label7.TabIndex = 4;
					num = 229;
				}
				if (num == 232)
				{
					this.label6.Name = "label6";
					num = 233;
				}
				if (num == 236)
				{
					this.label5.AutoSize = true;
					num = 237;
				}
				if (num == 240)
				{
					this.label5.TabIndex = 2;
					num = 241;
				}
				if (num == 244)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 245;
				}
				if (num == 248)
				{
					this.pictureBox4.TabStop = false;
					num = 249;
				}
				if (num == 253)
				{
					this.groupBox3.Controls.Add(this.mem);
					num = 254;
				}
				if (num == 257)
				{
					this.groupBox3.Controls.Add(this.Volt);
					num = 258;
				}
				if (num == 261)
				{
					this.groupBox3.ForeColor = Color.White;
					num = 262;
				}
				if (num == 265)
				{
					this.groupBox3.TabIndex = 9;
					num = 266;
				}
				if (num == 269)
				{
					this.RAM_Clock.Location = new Point(85, 37);
					num = 270;
				}
				if (num == 273)
				{
					this.RAM_Clock.Text = "Loading...";
					num = 274;
				}
				if (num == 277)
				{
					this.maker.Size = new Size(102, 23);
					num = 278;
				}
				if (num == 281)
				{
					this.RAM_Total_Virtual_Size.Location = new Point(149, 160);
					num = 282;
				}
				if (num == 285)
				{
					this.RAM_Total_Virtual_Size.Text = "Loading...";
					num = 286;
				}
				if (num == 289)
				{
					this.mem.Size = new Size(146, 23);
					num = 290;
				}
				if (num == 293)
				{
					this.RAM_Voltage.Location = new Point(98, 119);
					num = 294;
				}
				if (num == 297)
				{
					this.RAM_Voltage.Text = "Loading...";
					num = 298;
				}
				if (num == 302)
				{
					this.RAM_Size.TabIndex = 16;
					num = 303;
				}
				if (num == 306)
				{
					this.RAM_Manafacturer.Name = "RAM_Manafacturer";
					num = 307;
				}
				if (num == 310)
				{
					this.Volt.AutoSize = true;
					num = 311;
				}
				if (num == 314)
				{
					this.Volt.TabIndex = 14;
					num = 315;
				}
				if (num == 318)
				{
					this.Size.Name = "Size";
					num = 319;
				}
				if (num == 322)
				{
					this.Clock.AutoSize = true;
					num = 323;
				}
				if (num == 326)
				{
					this.Clock.TabIndex = 12;
					num = 327;
				}
				if (num == 330)
				{
					this.gpu_info.Controls.Add(this.date);
					num = 331;
				}
				if (num == 334)
				{
					this.gpu_info.Controls.Add(this.GPU_RAM);
					num = 335;
				}
				if (num == 338)
				{
					this.gpu_info.Controls.Add(this.gpu_name);
					num = 339;
				}
				if (num == 342)
				{
					this.gpu_info.Name = "gpu_info";
					num = 343;
				}
				if (num == 346)
				{
					this.gpu_info.Text = "GPU Information";
					num = 347;
				}
				if (num == 351)
				{
					this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 352;
				}
				if (num == 355)
				{
					this.GPU_Caption.Location = new Point(93, 37);
					num = 356;
				}
				if (num == 359)
				{
					this.GPU_Caption.Text = "Loading...";
					num = 360;
				}
				if (num == 363)
				{
					this.date.Size = new Size(89, 23);
					num = 364;
				}
				if (num == 367)
				{
					this.GPU_Driver_Version.Location = new Point(107, 160);
					num = 368;
				}
				if (num == 371)
				{
					this.GPU_Driver_Version.Text = "Loading...";
					num = 372;
				}
				if (num == 375)
				{
					this.vers.Size = new Size(102, 23);
					num = 376;
				}
				if (num == 379)
				{
					this.GPU_Current_Resolution.Location = new Point(136, 119);
					num = 380;
				}
				if (num == 383)
				{
					this.GPU_Current_Resolution.Text = "Loading...";
					num = 384;
				}
				if (num == 387)
				{
					this.GPU_RAM.Size = new Size(67, 23);
					num = 388;
				}
				if (num == 391)
				{
					this.GPU_Driver_Date.Location = new Point(93, 201);
					num = 392;
				}
				if (num == 395)
				{
					this.GPU_Driver_Date.Text = "Loading...";
					num = 396;
				}
				if (num == 400)
				{
					this.label29.TabIndex = 24;
					num = 401;
				}
				if (num == 404)
				{
					this.label30.Name = "label30";
					num = 405;
				}
				if (num == 408)
				{
					this.gpu_name.AutoSize = true;
					num = 409;
				}
				if (num == 412)
				{
					this.gpu_name.TabIndex = 22;
					num = 413;
				}
				if (num == 416)
				{
					this.next_btn.CheckedState.Parent = this.next_btn;
					num = 417;
				}
				if (num == 420)
				{
					this.next_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 421;
				}
				if (num == 424)
				{
					this.next_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 425;
				}
				if (num == 428)
				{
					this.next_btn.Name = "next_btn";
					num = 429;
				}
				if (num == 432)
				{
					this.next_btn.Text = "Next";
					num = 433;
				}
				if (num == 436)
				{
					this.label10.ForeColor = Color.Silver;
					num = 437;
				}
				if (num == 440)
				{
					this.label10.TabIndex = 89;
					num = 441;
				}
				if (num == 444)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 445;
				}
				if (num == 449)
				{
					base.Controls.Add(this.groupBox2);
					num = 450;
				}
				if (num == 453)
				{
					this.groupBox1.ResumeLayout(false);
					num = 454;
				}
				if (num == 457)
				{
					this.groupBox2.PerformLayout();
					num = 458;
				}
				if (num == 461)
				{
					this.groupBox3.PerformLayout();
					num = 462;
				}
				if (num == 465)
				{
					base.ResumeLayout(false);
					num = 466;
				}
				if (num == 466)
				{
					base.PerformLayout();
					num = 467;
				}
				if (num == 464)
				{
					((ISupportInitialize)this.pictureBox1).EndInit();
					num = 465;
				}
				if (num == 463)
				{
					this.gpu_info.PerformLayout();
					num = 464;
				}
				if (num == 462)
				{
					this.gpu_info.ResumeLayout(false);
					num = 463;
				}
				if (num == 460)
				{
					this.groupBox3.ResumeLayout(false);
					num = 461;
				}
				if (num == 459)
				{
					((ISupportInitialize)this.pictureBox4).EndInit();
					num = 460;
				}
				if (num == 458)
				{
					((ISupportInitialize)this.pictureBox3).EndInit();
					num = 459;
				}
				if (num == 456)
				{
					this.groupBox2.ResumeLayout(false);
					num = 457;
				}
				if (num == 455)
				{
					((ISupportInitialize)this.pictureBox2).EndInit();
					num = 456;
				}
				if (num == 454)
				{
					this.groupBox1.PerformLayout();
					num = 455;
				}
				if (num == 452)
				{
					base.Name = "SystemInfo";
					num = 453;
				}
				if (num == 451)
				{
					base.Controls.Add(this.label1);
					num = 452;
				}
				if (num == 450)
				{
					base.Controls.Add(this.groupBox1);
					num = 451;
				}
				if (num == 448)
				{
					base.Controls.Add(this.groupBox3);
					num = 449;
				}
				if (num == 447)
				{
					base.Controls.Add(this.gpu_info);
					num = 448;
				}
				if (num == 446)
				{
					base.Controls.Add(this.next_btn);
					num = 447;
				}
				if (num == 445)
				{
					base.Controls.Add(this.label10);
					num = 446;
				}
				if (num == 443)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 444;
				}
				if (num == 442)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 443;
				}
				if (num == 441)
				{
					this.label10.Text = "Get information about you hardware";
					num = 442;
				}
				if (num == 439)
				{
					this.label10.Size = new Size(213, 19);
					num = 440;
				}
				if (num == 438)
				{
					this.label10.Name = "label10";
					num = 439;
				}
				if (num == 437)
				{
					this.label10.Location = new Point(23, 53);
					num = 438;
				}
				if (num == 435)
				{
					this.label10.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 436;
				}
				if (num == 434)
				{
					this.label10.AutoSize = true;
					num = 435;
				}
				if (num == 433)
				{
					this.next_btn.Click += this.siticoneRoundedButton1_Click;
					num = 434;
				}
				if (num == 431)
				{
					this.next_btn.TabIndex = 11;
					num = 432;
				}
				if (num == 430)
				{
					this.next_btn.Size = new Size(88, 30);
					num = 431;
				}
				if (num == 429)
				{
					this.next_btn.ShadowDecoration.Parent = this.next_btn;
					num = 430;
				}
				if (num == 427)
				{
					this.next_btn.Location = new Point(882, 56);
					num = 428;
				}
				if (num == 426)
				{
					this.next_btn.HoverState.Parent = this.next_btn;
					num = 427;
				}
				if (num == 425)
				{
					this.next_btn.ForeColor = Color.White;
					num = 426;
				}
				if (num == 423)
				{
					this.next_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 424;
				}
				if (num == 422)
				{
					this.next_btn.DisabledState.Parent = this.next_btn;
					num = 423;
				}
				if (num == 421)
				{
					this.next_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 422;
				}
				if (num == 419)
				{
					this.next_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 420;
				}
				if (num == 418)
				{
					this.next_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 419;
				}
				if (num == 417)
				{
					this.next_btn.CustomImages.Parent = this.next_btn;
					num = 418;
				}
				if (num == 415)
				{
					this.next_btn.BorderRadius = 14;
					num = 416;
				}
				if (num == 414)
				{
					this.next_btn.BackColor = Color.Transparent;
					num = 415;
				}
				if (num == 413)
				{
					this.gpu_name.Text = "GPU Name :";
					num = 414;
				}
				if (num == 411)
				{
					this.gpu_name.Size = new Size(86, 23);
					num = 412;
				}
				if (num == 410)
				{
					this.gpu_name.Name = "gpu_name";
					num = 411;
				}
				if (num == 409)
				{
					this.gpu_name.Location = new Point(9, 37);
					num = 410;
				}
				if (num == 407)
				{
					this.label30.Text = "GPU RAM :";
					num = 408;
				}
				if (num == 406)
				{
					this.label30.TabIndex = 23;
					num = 407;
				}
				if (num == 405)
				{
					this.label30.Size = new Size(78, 23);
					num = 406;
				}
				if (num == 403)
				{
					this.label30.Location = new Point(9, 78);
					num = 404;
				}
				if (num == 402)
				{
					this.label30.AutoSize = true;
					num = 403;
				}
				if (num == 401)
				{
					this.label29.Text = "Current Resolution :";
					num = 402;
				}
				if (num == 399)
				{
					this.label29.Size = new Size(131, 23);
					num = 400;
				}
				if (num == 398)
				{
					this.label29.Name = "label29";
					num = 399;
				}
				if (num == 397)
				{
					this.label29.Location = new Point(9, 119);
					num = 398;
				}
				if (num == 396)
				{
					this.label29.AutoSize = true;
					num = 397;
				}
				if (num == 394)
				{
					this.GPU_Driver_Date.TabIndex = 25;
					num = 395;
				}
				if (num == 393)
				{
					this.GPU_Driver_Date.Size = new Size(67, 23);
					num = 394;
				}
				if (num == 392)
				{
					this.GPU_Driver_Date.Name = "GPU_Driver_Date";
					num = 393;
				}
				if (num == 390)
				{
					this.GPU_Driver_Date.AutoSize = true;
					num = 391;
				}
				if (num == 389)
				{
					this.GPU_RAM.Text = "Loading...";
					num = 390;
				}
				if (num == 388)
				{
					this.GPU_RAM.TabIndex = 26;
					num = 389;
				}
				if (num == 386)
				{
					this.GPU_RAM.Name = "GPU_RAM";
					num = 387;
				}
				if (num == 385)
				{
					this.GPU_RAM.Location = new Point(84, 78);
					num = 386;
				}
				if (num == 384)
				{
					this.GPU_RAM.AutoSize = true;
					num = 385;
				}
				if (num == 382)
				{
					this.GPU_Current_Resolution.TabIndex = 27;
					num = 383;
				}
				if (num == 381)
				{
					this.GPU_Current_Resolution.Size = new Size(67, 23);
					num = 382;
				}
				if (num == 380)
				{
					this.GPU_Current_Resolution.Name = "GPU_Current_Resolution";
					num = 381;
				}
				if (num == 378)
				{
					this.GPU_Current_Resolution.AutoSize = true;
					num = 379;
				}
				if (num == 377)
				{
					this.vers.Text = "Driver Version :";
					num = 378;
				}
				if (num == 376)
				{
					this.vers.TabIndex = 28;
					num = 377;
				}
				if (num == 374)
				{
					this.vers.Name = "vers";
					num = 375;
				}
				if (num == 373)
				{
					this.vers.Location = new Point(9, 160);
					num = 374;
				}
				if (num == 372)
				{
					this.vers.AutoSize = true;
					num = 373;
				}
				if (num == 370)
				{
					this.GPU_Driver_Version.TabIndex = 29;
					num = 371;
				}
				if (num == 369)
				{
					this.GPU_Driver_Version.Size = new Size(67, 23);
					num = 370;
				}
				if (num == 368)
				{
					this.GPU_Driver_Version.Name = "GPU_Driver_Version";
					num = 369;
				}
				if (num == 366)
				{
					this.GPU_Driver_Version.AutoSize = true;
					num = 367;
				}
				if (num == 365)
				{
					this.date.Text = "Driver Date :";
					num = 366;
				}
				if (num == 364)
				{
					this.date.TabIndex = 30;
					num = 365;
				}
				if (num == 362)
				{
					this.date.Name = "date";
					num = 363;
				}
				if (num == 361)
				{
					this.date.Location = new Point(9, 201);
					num = 362;
				}
				if (num == 360)
				{
					this.date.AutoSize = true;
					num = 361;
				}
				if (num == 358)
				{
					this.GPU_Caption.TabIndex = 31;
					num = 359;
				}
				if (num == 357)
				{
					this.GPU_Caption.Size = new Size(67, 23);
					num = 358;
				}
				if (num == 356)
				{
					this.GPU_Caption.Name = "GPU_Caption";
					num = 357;
				}
				if (num == 354)
				{
					this.GPU_Caption.AutoSize = true;
					num = 355;
				}
				if (num == 353)
				{
					this.pictureBox1.TabStop = false;
					num = 354;
				}
				if (num == 352)
				{
					this.pictureBox1.TabIndex = 32;
					num = 353;
				}
				if (num == 350)
				{
					this.pictureBox1.Size = new Size(64, 64);
					num = 351;
				}
				if (num == 349)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 350;
				}
				if (num == 348)
				{
					this.pictureBox1.Location = new Point(387, 186);
					num = 349;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 347)
				{
					this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 348;
				}
				if (num == 345)
				{
					this.gpu_info.TabStop = false;
					num = 346;
				}
				if (num == 344)
				{
					this.gpu_info.TabIndex = 10;
					num = 345;
				}
				if (num == 343)
				{
					this.gpu_info.Size = new Size(457, 256);
					num = 344;
				}
				if (num == 341)
				{
					this.gpu_info.Location = new Point(518, 383);
					num = 342;
				}
				if (num == 340)
				{
					this.gpu_info.ForeColor = Color.White;
					num = 341;
				}
				if (num == 339)
				{
					this.gpu_info.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 340;
				}
				if (num == 337)
				{
					this.gpu_info.Controls.Add(this.label30);
					num = 338;
				}
				if (num == 336)
				{
					this.gpu_info.Controls.Add(this.label29);
					num = 337;
				}
				if (num == 335)
				{
					this.gpu_info.Controls.Add(this.GPU_Driver_Date);
					num = 336;
				}
				if (num == 333)
				{
					this.gpu_info.Controls.Add(this.GPU_Current_Resolution);
					num = 334;
				}
				if (num == 332)
				{
					this.gpu_info.Controls.Add(this.vers);
					num = 333;
				}
				if (num == 331)
				{
					this.gpu_info.Controls.Add(this.GPU_Driver_Version);
					num = 332;
				}
				if (num == 329)
				{
					this.gpu_info.Controls.Add(this.GPU_Caption);
					num = 330;
				}
				if (num == 328)
				{
					this.gpu_info.Controls.Add(this.pictureBox1);
					num = 329;
				}
				if (num == 327)
				{
					this.Clock.Text = "RAM Clock :";
					num = 328;
				}
				if (num == 325)
				{
					this.Clock.Size = new Size(83, 23);
					num = 326;
				}
				if (num == 324)
				{
					this.Clock.Name = "Clock";
					num = 325;
				}
				if (num == 323)
				{
					this.Clock.Location = new Point(6, 37);
					num = 324;
				}
				if (num == 321)
				{
					this.Size.Text = "RAM Size :";
					num = 322;
				}
				if (num == 320)
				{
					this.Size.TabIndex = 13;
					num = 321;
				}
				if (num == 319)
				{
					this.Size.Size = new Size(75, 23);
					num = 320;
				}
				if (num == 317)
				{
					this.Size.Location = new Point(6, 78);
					num = 318;
				}
				if (num == 316)
				{
					this.Size.AutoSize = true;
					num = 317;
				}
				if (num == 315)
				{
					this.Volt.Text = "RAM Voltage :";
					num = 316;
				}
				if (num == 313)
				{
					this.Volt.Size = new Size(96, 23);
					num = 314;
				}
				if (num == 312)
				{
					this.Volt.Name = "Volt";
					num = 313;
				}
				if (num == 311)
				{
					this.Volt.Location = new Point(6, 119);
					num = 312;
				}
				if (num == 309)
				{
					this.RAM_Manafacturer.Text = "Loading...";
					num = 310;
				}
				if (num == 308)
				{
					this.RAM_Manafacturer.TabIndex = 15;
					num = 309;
				}
				if (num == 307)
				{
					this.RAM_Manafacturer.Size = new Size(67, 23);
					num = 308;
				}
				if (num == 305)
				{
					this.RAM_Manafacturer.Location = new Point(104, 201);
					num = 306;
				}
				if (num == 304)
				{
					this.RAM_Manafacturer.AutoSize = true;
					num = 305;
				}
				if (num == 303)
				{
					this.RAM_Size.Text = "Loading...";
					num = 304;
				}
				if (num == 301)
				{
					this.RAM_Size.Size = new Size(67, 23);
					num = 302;
				}
				if (num == 300)
				{
					this.RAM_Size.Name = "RAM_Size";
					num = 301;
				}
				if (num == 299)
				{
					this.RAM_Size.Location = new Point(75, 78);
					num = 300;
				}
				if (num == 298)
				{
					this.RAM_Size.AutoSize = true;
					num = 299;
				}
				if (num == 296)
				{
					this.RAM_Voltage.TabIndex = 17;
					num = 297;
				}
				if (num == 295)
				{
					this.RAM_Voltage.Size = new Size(67, 23);
					num = 296;
				}
				if (num == 294)
				{
					this.RAM_Voltage.Name = "RAM_Voltage";
					num = 295;
				}
				if (num == 292)
				{
					this.RAM_Voltage.AutoSize = true;
					num = 293;
				}
				if (num == 291)
				{
					this.mem.Text = "Total Virtual Memory :";
					num = 292;
				}
				if (num == 290)
				{
					this.mem.TabIndex = 18;
					num = 291;
				}
				if (num == 288)
				{
					this.mem.Name = "mem";
					num = 289;
				}
				if (num == 287)
				{
					this.mem.Location = new Point(6, 160);
					num = 288;
				}
				if (num == 286)
				{
					this.mem.AutoSize = true;
					num = 287;
				}
				if (num == 284)
				{
					this.RAM_Total_Virtual_Size.TabIndex = 19;
					num = 285;
				}
				if (num == 283)
				{
					this.RAM_Total_Virtual_Size.Size = new Size(67, 23);
					num = 284;
				}
				if (num == 282)
				{
					this.RAM_Total_Virtual_Size.Name = "RAM_Total_Virtual_Size";
					num = 283;
				}
				if (num == 280)
				{
					this.RAM_Total_Virtual_Size.AutoSize = true;
					num = 281;
				}
				if (num == 279)
				{
					this.maker.Text = "Manufacturer :";
					num = 280;
				}
				if (num == 278)
				{
					this.maker.TabIndex = 20;
					num = 279;
				}
				if (num == 276)
				{
					this.maker.Name = "maker";
					num = 277;
				}
				if (num == 275)
				{
					this.maker.Location = new Point(6, 201);
					num = 276;
				}
				if (num == 274)
				{
					this.maker.AutoSize = true;
					num = 275;
				}
				if (num == 272)
				{
					this.RAM_Clock.TabIndex = 21;
					num = 273;
				}
				if (num == 271)
				{
					this.RAM_Clock.Size = new Size(67, 23);
					num = 272;
				}
				if (num == 270)
				{
					this.RAM_Clock.Name = "RAM_Clock";
					num = 271;
				}
				if (num == 268)
				{
					this.RAM_Clock.AutoSize = true;
					num = 269;
				}
				if (num == 267)
				{
					this.groupBox3.Text = "RAM Information";
					num = 268;
				}
				if (num == 266)
				{
					this.groupBox3.TabStop = false;
					num = 267;
				}
				if (num == 264)
				{
					this.groupBox3.Size = new Size(471, 256);
					num = 265;
				}
				if (num == 263)
				{
					this.groupBox3.Name = "groupBox3";
					num = 264;
				}
				if (num == 262)
				{
					this.groupBox3.Location = new Point(27, 383);
					num = 263;
				}
				if (num == 260)
				{
					this.groupBox3.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 261;
				}
				if (num == 259)
				{
					this.groupBox3.Controls.Add(this.Clock);
					num = 260;
				}
				if (num == 258)
				{
					this.groupBox3.Controls.Add(this.Size);
					num = 259;
				}
				if (num == 256)
				{
					this.groupBox3.Controls.Add(this.RAM_Manafacturer);
					num = 257;
				}
				if (num == 255)
				{
					this.groupBox3.Controls.Add(this.RAM_Size);
					num = 256;
				}
				if (num == 254)
				{
					this.groupBox3.Controls.Add(this.RAM_Voltage);
					num = 255;
				}
				if (num == 252)
				{
					this.groupBox3.Controls.Add(this.RAM_Total_Virtual_Size);
					num = 253;
				}
				if (num == 251)
				{
					this.groupBox3.Controls.Add(this.maker);
					num = 252;
				}
				if (num == 250)
				{
					this.groupBox3.Controls.Add(this.RAM_Clock);
					num = 251;
				}
				if (num == 249)
				{
					this.groupBox3.Controls.Add(this.pictureBox4);
					num = 250;
				}
				if (num == 247)
				{
					this.pictureBox4.TabIndex = 33;
					num = 248;
				}
				if (num == 246)
				{
					this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 247;
				}
				if (num == 245)
				{
					this.pictureBox4.Size = new Size(64, 64);
					num = 246;
				}
				if (num == 243)
				{
					this.pictureBox4.Location = new Point(401, 186);
					num = 244;
				}
				if (num == 242)
				{
					this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 243;
				}
				if (num == 241)
				{
					this.label5.Text = "CPU Name :";
					num = 242;
				}
				if (num == 239)
				{
					this.label5.Size = new Size(85, 23);
					num = 240;
				}
				if (num == 238)
				{
					this.label5.Name = "label5";
					num = 239;
				}
				if (num == 237)
				{
					this.label5.Location = new Point(6, 33);
					num = 238;
				}
				if (num == 235)
				{
					this.label6.Text = "CPU Clock :";
					num = 236;
				}
				if (num == 234)
				{
					this.label6.TabIndex = 3;
					num = 235;
				}
				if (num == 233)
				{
					this.label6.Size = new Size(79, 23);
					num = 234;
				}
				if (num == 231)
				{
					this.label6.Location = new Point(6, 74);
					num = 232;
				}
				if (num == 230)
				{
					this.label6.AutoSize = true;
					num = 231;
				}
				if (num == 229)
				{
					this.label7.Text = "CPU Voltage :";
					num = 230;
				}
				if (num == 227)
				{
					this.label7.Size = new Size(92, 23);
					num = 228;
				}
				if (num == 226)
				{
					this.label7.Name = "label7";
					num = 227;
				}
				if (num == 225)
				{
					this.label7.Location = new Point(6, 115);
					num = 226;
				}
				if (num == 223)
				{
					this.label8.Text = "CPU Cores :";
					num = 224;
				}
				if (num == 222)
				{
					this.label8.TabIndex = 5;
					num = 223;
				}
				if (num == 221)
				{
					this.label8.Size = new Size(81, 23);
					num = 222;
				}
				if (num == 219)
				{
					this.label8.Location = new Point(6, 156);
					num = 220;
				}
				if (num == 218)
				{
					this.label8.AutoSize = true;
					num = 219;
				}
				if (num == 217)
				{
					this.label9.Text = "CPU Threads :";
					num = 218;
				}
				if (num == 215)
				{
					this.label9.Size = new Size(97, 23);
					num = 216;
				}
				if (num == 214)
				{
					this.label9.Name = "label9";
					num = 215;
				}
				if (num == 213)
				{
					this.label9.Location = new Point(9, 197);
					num = 214;
				}
				if (num == 211)
				{
					this.CPU_Core_Label.Text = "Loading...";
					num = 212;
				}
				if (num == 210)
				{
					this.CPU_Core_Label.TabIndex = 7;
					num = 211;
				}
				if (num == 209)
				{
					this.CPU_Core_Label.Size = new Size(67, 23);
					num = 210;
				}
				if (num == 207)
				{
					this.CPU_Core_Label.Location = new Point(80, 156);
					num = 208;
				}
				if (num == 206)
				{
					this.CPU_Core_Label.AutoSize = true;
					num = 207;
				}
				if (num == 205)
				{
					this.pictureBox3.TabStop = false;
					num = 206;
				}
				if (num == 203)
				{
					this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 204;
				}
				if (num == 202)
				{
					this.pictureBox3.Size = new Size(64, 64);
					num = 203;
				}
				if (num == 201)
				{
					this.pictureBox3.Name = "pictureBox3";
					num = 202;
				}
				if (num == 199)
				{
					this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
					num = 200;
				}
				if (num == 198)
				{
					this.CPU_Thread_Label.Text = "Loading...";
					num = 199;
				}
				if (num == 197)
				{
					this.CPU_Thread_Label.TabIndex = 8;
					num = 198;
				}
				if (num == 196)
				{
					this.CPU_Thread_Label.Size = new Size(67, 23);
					num = 197;
				}
				if (num == 194)
				{
					this.CPU_Thread_Label.Location = new Point(100, 197);
					num = 195;
				}
				if (num == 193)
				{
					this.CPU_Thread_Label.AutoSize = true;
					num = 194;
				}
				if (num == 192)
				{
					this.groupBox2.Text = "CPU Information";
					num = 193;
				}
				if (num == 190)
				{
					this.groupBox2.TabIndex = 8;
					num = 191;
				}
				if (num == 189)
				{
					this.groupBox2.Size = new Size(457, 264);
					num = 190;
				}
				if (num == 188)
				{
					this.groupBox2.Name = "groupBox2";
					num = 189;
				}
				if (num == 186)
				{
					this.groupBox2.ForeColor = Color.White;
					num = 187;
				}
				if (num == 185)
				{
					this.groupBox2.Font = new Font("Gill Sans MT", 12f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 186;
				}
				if (num == 184)
				{
					this.groupBox2.Controls.Add(this.Summary_CPU_Caption);
					num = 185;
				}
				if (num == 182)
				{
					this.groupBox2.Controls.Add(this.label6);
					num = 183;
				}
				if (num == 181)
				{
					this.groupBox2.Controls.Add(this.label7);
					num = 182;
				}
				if (num == 180)
				{
					this.groupBox2.Controls.Add(this.label8);
					num = 181;
				}
				if (num == 178)
				{
					this.groupBox2.Controls.Add(this.Summary_CPU_Voltage);
					num = 179;
				}
				if (num == 177)
				{
					this.groupBox2.Controls.Add(this.Summary_CPU_Clock);
					num = 178;
				}
				if (num == 176)
				{
					this.groupBox2.Controls.Add(this.CPU_Core_Label);
					num = 177;
				}
				if (num == 174)
				{
					this.groupBox2.Controls.Add(this.CPU_Thread_Label);
					num = 175;
				}
				if (num == 173)
				{
					this.Summary_CPU_Caption.Text = "Loading...";
					num = 174;
				}
				if (num == 172)
				{
					this.Summary_CPU_Caption.TabIndex = 0;
					num = 173;
				}
				if (num == 170)
				{
					this.Summary_CPU_Caption.Name = "Summary_CPU_Caption";
					num = 171;
				}
				if (num == 169)
				{
					this.Summary_CPU_Caption.Location = new Point(88, 33);
					num = 170;
				}
				if (num == 168)
				{
					this.Summary_CPU_Caption.AutoSize = true;
					num = 169;
				}
				if (num == 166)
				{
					this.Summary_CPU_Voltage.TabIndex = 3;
					num = 167;
				}
				if (num == 165)
				{
					this.Summary_CPU_Voltage.Size = new Size(67, 23);
					num = 166;
				}
				if (num == 164)
				{
					this.Summary_CPU_Voltage.Name = "Summary_CPU_Voltage";
					num = 165;
				}
				if (num == 162)
				{
					this.Summary_CPU_Voltage.AutoSize = true;
					num = 163;
				}
				if (num == 161)
				{
					this.Summary_CPU_Clock.Text = "Loading...";
					num = 162;
				}
				if (num == 160)
				{
					this.Summary_CPU_Clock.TabIndex = 5;
					num = 161;
				}
				if (num == 158)
				{
					this.Summary_CPU_Clock.Name = "Summary_CPU_Clock";
					num = 159;
				}
				if (num == 157)
				{
					this.Summary_CPU_Clock.Location = new Point(80, 74);
					num = 158;
				}
				if (num == 156)
				{
					this.Summary_CPU_Clock.AutoSize = true;
					num = 157;
				}
				if (num == 154)
				{
					this.pictureBox2.TabIndex = 12;
					num = 155;
				}
				if (num == 153)
				{
					this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
					num = 154;
				}
				if (num == 152)
				{
					this.pictureBox2.Size = new Size(64, 64);
					num = 153;
				}
				if (num == 150)
				{
					this.pictureBox2.Location = new Point(401, 194);
					num = 151;
				}
				if (num == 149)
				{
					this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 150;
				}
				if (num == 148)
				{
					this.label2.Text = "Operating System :";
					num = 149;
				}
				if (num == 147)
				{
					this.label2.TabIndex = 1;
					num = 148;
				}
				if (num == 145)
				{
					this.label2.Name = "label2";
					num = 146;
				}
				if (num == 144)
				{
					this.label2.Location = new Point(6, 33);
					num = 145;
				}
				if (num == 143)
				{
					this.label2.AutoSize = true;
					num = 144;
				}
				if (num == 141)
				{
					this.label3.TabIndex = 2;
					num = 142;
				}
				if (num == 140)
				{
					this.label3.Size = new Size(90, 23);
					num = 141;
				}
				if (num == 139)
				{
					this.label3.Name = "label3";
					num = 140;
				}
				if (num == 137)
				{
					this.label3.AutoSize = true;
					num = 138;
				}
				if (num == 136)
				{
					this.label4.Text = "Build Number :";
					num = 137;
				}
				if (num == 135)
				{
					this.label4.TabIndex = 4;
					num = 136;
				}
				if (num == 133)
				{
					this.label4.Name = "label4";
					num = 134;
				}
				if (num == 132)
				{
					this.label4.Location = new Point(6, 115);
					num = 133;
				}
				if (num == 131)
				{
					this.label4.AutoSize = true;
					num = 132;
				}
				if (num == 129)
				{
					this.Summary_OS_Caption.TabIndex = 5;
					num = 130;
				}
				if (num == 128)
				{
					this.Summary_OS_Caption.Size = new Size(67, 23);
					num = 129;
				}
				if (num == 127)
				{
					this.Summary_OS_Caption.Name = "Summary_OS_Caption";
					num = 128;
				}
				if (num == 125)
				{
					this.Summary_OS_Caption.AutoSize = true;
					num = 126;
				}
				if (num == 124)
				{
					this.Summary_OS_Architecture.Text = "Loading...";
					num = 125;
				}
				if (num == 123)
				{
					this.Summary_OS_Architecture.TabIndex = 6;
					num = 124;
				}
				if (num == 121)
				{
					this.Summary_OS_Architecture.Name = "Summary_OS_Architecture";
					num = 122;
				}
				if (num == 120)
				{
					this.Summary_OS_Architecture.Location = new Point(90, 74);
					num = 121;
				}
				if (num == 119)
				{
					this.Summary_OS_Architecture.AutoSize = true;
					num = 120;
				}
				if (num == 117)
				{
					this.Summary_OS_BuildNumber.TabIndex = 7;
					num = 118;
				}
				if (num == 116)
				{
					this.Summary_OS_BuildNumber.Size = new Size(67, 23);
					num = 117;
				}
				if (num == 115)
				{
					this.Summary_OS_BuildNumber.Name = "Summary_OS_BuildNumber";
					num = 116;
				}
				if (num == 113)
				{
					this.Summary_OS_BuildNumber.AutoSize = true;
					num = 114;
				}
				if (num == 112)
				{
					this.label13.Text = "Version :";
					num = 113;
				}
				if (num == 111)
				{
					this.label13.TabIndex = 8;
					num = 112;
				}
				if (num == 109)
				{
					this.label13.Name = "label13";
					num = 110;
				}
				if (num == 108)
				{
					this.label13.Location = new Point(6, 156);
					num = 109;
				}
				if (num == 107)
				{
					this.label13.AutoSize = true;
					num = 108;
				}
				if (num == 105)
				{
					this.Summary_OS_Version.TabIndex = 9;
					num = 106;
				}
				if (num == 104)
				{
					this.Summary_OS_Version.Size = new Size(67, 23);
					num = 105;
				}
				if (num == 103)
				{
					this.Summary_OS_Version.Name = "Summary_OS_Version";
					num = 104;
				}
				if (num == 101)
				{
					this.Summary_OS_Version.AutoSize = true;
					num = 102;
				}
				if (num == 100)
				{
					this.label15.Text = "System Language :";
					num = 101;
				}
				if (num == 99)
				{
					this.label15.TabIndex = 10;
					num = 100;
				}
				if (num == 98)
				{
					this.label15.Size = new Size(124, 23);
					num = 99;
				}
				if (num == 96)
				{
					this.label15.Location = new Point(6, 197);
					num = 97;
				}
				if (num == 95)
				{
					this.label15.AutoSize = true;
					num = 96;
				}
				if (num == 94)
				{
					this.Summary_OS_CurrentTimeZoneCode.Text = "Loading...";
					num = 95;
				}
				if (num == 92)
				{
					this.Summary_OS_CurrentTimeZoneCode.Size = new Size(67, 23);
					num = 93;
				}
				if (num == 91)
				{
					this.Summary_OS_CurrentTimeZoneCode.Name = "Summary_OS_CurrentTimeZoneCode";
					num = 92;
				}
				if (num == 90)
				{
					this.Summary_OS_CurrentTimeZoneCode.Location = new Point(126, 197);
					num = 91;
				}
				if (num == 88)
				{
					this.groupBox1.Text = "OS Information";
					num = 89;
				}
				if (num == 87)
				{
					this.groupBox1.TabStop = false;
					num = 88;
				}
				if (num == 86)
				{
					this.groupBox1.TabIndex = 7;
					num = 87;
				}
				if (num == 84)
				{
					this.groupBox1.Name = "groupBox1";
					num = 85;
				}
				if (num == 83)
				{
					this.groupBox1.Location = new Point(27, 92);
					num = 84;
				}
				if (num == 82)
				{
					this.groupBox1.ForeColor = Color.White;
					num = 83;
				}
				if (num == 80)
				{
					this.groupBox1.Controls.Add(this.pictureBox2);
					num = 81;
				}
				if (num == 79)
				{
					this.groupBox1.Controls.Add(this.label2);
					num = 80;
				}
				if (num == 78)
				{
					this.groupBox1.Controls.Add(this.label3);
					num = 79;
				}
				if (num == 76)
				{
					this.groupBox1.Controls.Add(this.Summary_OS_Caption);
					num = 77;
				}
				if (num == 75)
				{
					this.groupBox1.Controls.Add(this.Summary_OS_Architecture);
					num = 76;
				}
				if (num == 74)
				{
					this.groupBox1.Controls.Add(this.Summary_OS_BuildNumber);
					num = 75;
				}
				if (num == 72)
				{
					this.groupBox1.Controls.Add(this.Summary_OS_Version);
					num = 73;
				}
				if (num == 71)
				{
					this.groupBox1.Controls.Add(this.label15);
					num = 72;
				}
				if (num == 70)
				{
					this.groupBox1.Controls.Add(this.Summary_OS_CurrentTimeZoneCode);
					num = 71;
				}
				if (num == 68)
				{
					this.label1.TabIndex = 6;
					num = 69;
				}
				if (num == 67)
				{
					this.label1.Size = new Size(329, 53);
					num = 68;
				}
				if (num == 66)
				{
					this.label1.Name = "label1";
					num = 67;
				}
				if (num == 64)
				{
					this.label1.ForeColor = Color.White;
					num = 65;
				}
				if (num == 63)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 64;
				}
				if (num == 62)
				{
					this.label1.AutoSize = true;
					num = 63;
				}
				if (num == 60)
				{
					((ISupportInitialize)this.pictureBox1).BeginInit();
					num = 61;
				}
				if (num == 59)
				{
					this.gpu_info.SuspendLayout();
					num = 60;
				}
				if (num == 58)
				{
					this.groupBox3.SuspendLayout();
					num = 59;
				}
				if (num == 56)
				{
					((ISupportInitialize)this.pictureBox3).BeginInit();
					num = 57;
				}
				if (num == 55)
				{
					this.groupBox2.SuspendLayout();
					num = 56;
				}
				if (num == 54)
				{
					((ISupportInitialize)this.pictureBox2).BeginInit();
					num = 55;
				}
				if (num == 52)
				{
					this.label10 = new Label();
					num = 53;
				}
				if (num == 51)
				{
					this.next_btn = new SiticoneRoundedButton();
					num = 52;
				}
				if (num == 50)
				{
					this.gpu_name = new Label();
					num = 51;
				}
				if (num == 49)
				{
					this.label30 = new Label();
					num = 50;
				}
				if (num == 47)
				{
					this.GPU_Driver_Date = new Label();
					num = 48;
				}
				if (num == 46)
				{
					this.GPU_RAM = new Label();
					num = 47;
				}
				if (num == 45)
				{
					this.GPU_Current_Resolution = new Label();
					num = 46;
				}
				if (num == 43)
				{
					this.GPU_Driver_Version = new Label();
					num = 44;
				}
				if (num == 42)
				{
					this.date = new Label();
					num = 43;
				}
				if (num == 41)
				{
					this.GPU_Caption = new Label();
					num = 42;
				}
				if (num == 39)
				{
					this.gpu_info = new GroupBox();
					num = 40;
				}
				if (num == 38)
				{
					this.Clock = new Label();
					num = 39;
				}
				if (num == 37)
				{
					this.Size = new Label();
					num = 38;
				}
				if (num == 35)
				{
					this.RAM_Manafacturer = new Label();
					num = 36;
				}
				if (num == 34)
				{
					this.RAM_Size = new Label();
					num = 35;
				}
				if (num == 33)
				{
					this.RAM_Voltage = new Label();
					num = 34;
				}
				if (num == 31)
				{
					this.RAM_Total_Virtual_Size = new Label();
					num = 32;
				}
				if (num == 30)
				{
					this.maker = new Label();
					num = 31;
				}
				if (num == 29)
				{
					this.RAM_Clock = new Label();
					num = 30;
				}
				if (num == 27)
				{
					this.pictureBox4 = new PictureBox();
					num = 28;
				}
				if (num == 26)
				{
					this.label5 = new Label();
					num = 27;
				}
				if (num == 25)
				{
					this.label6 = new Label();
					num = 26;
				}
				if (num == 23)
				{
					this.label8 = new Label();
					num = 24;
				}
				if (num == 22)
				{
					this.label9 = new Label();
					num = 23;
				}
				if (num == 21)
				{
					this.CPU_Core_Label = new Label();
					num = 22;
				}
				if (num == 19)
				{
					this.CPU_Thread_Label = new Label();
					num = 20;
				}
				if (num == 18)
				{
					this.groupBox2 = new GroupBox();
					num = 19;
				}
				if (num == 17)
				{
					this.Summary_CPU_Caption = new Label();
					num = 18;
				}
				if (num == 15)
				{
					this.Summary_CPU_Clock = new Label();
					num = 16;
				}
				if (num == 14)
				{
					this.pictureBox2 = new PictureBox();
					num = 15;
				}
				if (num == 13)
				{
					this.label2 = new Label();
					num = 14;
				}
				if (num == 11)
				{
					this.label4 = new Label();
					num = 12;
				}
				if (num == 10)
				{
					this.Summary_OS_Caption = new Label();
					num = 11;
				}
				if (num == 9)
				{
					this.Summary_OS_Architecture = new Label();
					num = 10;
				}
				if (num == 7)
				{
					this.label13 = new Label();
					num = 8;
				}
				if (num == 6)
				{
					this.Summary_OS_Version = new Label();
					num = 7;
				}
				if (num == 5)
				{
					this.label15 = new Label();
					num = 6;
				}
				if (num == 3)
				{
					this.groupBox1 = new GroupBox();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(SystemInfo));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 467);
		}

		// Token: 0x04000944 RID: 2372
		private CPU cpu;

		// Token: 0x04000945 RID: 2373
		private Bios bios;

		// Token: 0x04000946 RID: 2374
		private RAM ram;

		// Token: 0x04000947 RID: 2375
		private Disk disk;

		// Token: 0x04000948 RID: 2376
		private GPU gpu;

		// Token: 0x04000949 RID: 2377
		private OS os;

		// Token: 0x0400094A RID: 2378
		private readonly bool DEBUG = false;

		// Token: 0x0400094B RID: 2379
		private static SystemInfo _instace;

		// Token: 0x0400094C RID: 2380
		private IContainer components = null;

		// Token: 0x0400094D RID: 2381
		private Label label1;

		// Token: 0x0400094E RID: 2382
		private GroupBox groupBox1;

		// Token: 0x0400094F RID: 2383
		private GroupBox groupBox2;

		// Token: 0x04000950 RID: 2384
		private GroupBox groupBox3;

		// Token: 0x04000951 RID: 2385
		private GroupBox gpu_info;

		// Token: 0x04000952 RID: 2386
		private Label Summary_CPU_Caption;

		// Token: 0x04000953 RID: 2387
		private Label label2;

		// Token: 0x04000954 RID: 2388
		private Label label3;

		// Token: 0x04000955 RID: 2389
		private Label Summary_CPU_Voltage;

		// Token: 0x04000956 RID: 2390
		private Label label4;

		// Token: 0x04000957 RID: 2391
		private Label Summary_CPU_Clock;

		// Token: 0x04000958 RID: 2392
		private Label label5;

		// Token: 0x04000959 RID: 2393
		private Label label6;

		// Token: 0x0400095A RID: 2394
		private Label label7;

		// Token: 0x0400095B RID: 2395
		private Label label9;

		// Token: 0x0400095C RID: 2396
		private Label label8;

		// Token: 0x0400095D RID: 2397
		private Label CPU_Core_Label;

		// Token: 0x0400095E RID: 2398
		private Label CPU_Thread_Label;

		// Token: 0x0400095F RID: 2399
		private Label Summary_OS_Caption;

		// Token: 0x04000960 RID: 2400
		private Label Summary_OS_BuildNumber;

		// Token: 0x04000961 RID: 2401
		private Label Summary_OS_Architecture;

		// Token: 0x04000962 RID: 2402
		private Label label13;

		// Token: 0x04000963 RID: 2403
		private Label Summary_OS_Version;

		// Token: 0x04000964 RID: 2404
		private Label label15;

		// Token: 0x04000965 RID: 2405
		private Label Summary_OS_CurrentTimeZoneCode;

		// Token: 0x04000966 RID: 2406
		private Label RAM_Clock;

		// Token: 0x04000967 RID: 2407
		private Label maker;

		// Token: 0x04000968 RID: 2408
		private Label RAM_Total_Virtual_Size;

		// Token: 0x04000969 RID: 2409
		private Label mem;

		// Token: 0x0400096A RID: 2410
		private Label RAM_Voltage;

		// Token: 0x0400096B RID: 2411
		private Label RAM_Size;

		// Token: 0x0400096C RID: 2412
		private Label RAM_Manafacturer;

		// Token: 0x0400096D RID: 2413
		private Label Volt;

		// Token: 0x0400096E RID: 2414
		private new Label Size;

		// Token: 0x0400096F RID: 2415
		private Label Clock;

		// Token: 0x04000970 RID: 2416
		private Label GPU_Caption;

		// Token: 0x04000971 RID: 2417
		private Label date;

		// Token: 0x04000972 RID: 2418
		private Label GPU_Driver_Version;

		// Token: 0x04000973 RID: 2419
		private Label vers;

		// Token: 0x04000974 RID: 2420
		private Label GPU_Current_Resolution;

		// Token: 0x04000975 RID: 2421
		private Label GPU_RAM;

		// Token: 0x04000976 RID: 2422
		private Label GPU_Driver_Date;

		// Token: 0x04000977 RID: 2423
		private Label label29;

		// Token: 0x04000978 RID: 2424
		private Label label30;

		// Token: 0x04000979 RID: 2425
		private Label gpu_name;

		// Token: 0x0400097A RID: 2426
		private SiticoneRoundedButton next_btn;

		// Token: 0x0400097B RID: 2427
		private Label label10;

		// Token: 0x0400097C RID: 2428
		private PictureBox pictureBox2;

		// Token: 0x0400097D RID: 2429
		private PictureBox pictureBox1;

		// Token: 0x0400097E RID: 2430
		private PictureBox pictureBox3;

		// Token: 0x0400097F RID: 2431
		private PictureBox pictureBox4;
	}
}
