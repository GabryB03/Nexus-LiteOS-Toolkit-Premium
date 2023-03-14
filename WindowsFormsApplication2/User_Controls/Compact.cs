using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000013 RID: 19
	public class Compact : UserControl
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		public static Compact Instance
		{
			get
			{
				if (Compact._instace == null)
				{
					Compact._instace = new Compact();
				}
				return Compact._instace;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000020B7 File Offset: 0x000002B7
		public Compact()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		private void button23_Click(object sender, EventArgs e)
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

		// Token: 0x060000A2 RID: 162 RVA: 0x00018E68 File Offset: 0x00017068
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

		// Token: 0x060000A3 RID: 163 RVA: 0x00018EC8 File Offset: 0x000170C8
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

		// Token: 0x060000A4 RID: 164 RVA: 0x0001C34C File Offset: 0x0001A54C
		private void button3_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 9)
				{
					applied = new applied();
					num = 10;
				}
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "compact /c /s /a /i /exe:XPRESS4K C:\\Windows\\System32\\*";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
		private void button2_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 9)
				{
					applied = new applied();
					num = 10;
				}
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "compact /c /s /a /i /exe:XPRESS8K C:\\Windows\\System32\\*";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001C694 File Offset: 0x0001A894
		private void button6_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 9)
				{
					applied = new applied();
					num = 10;
				}
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "compact /c /s /a /i /exe:XPRESS16K C:\\Windows\\System32\\*";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0001C838 File Offset: 0x0001AA38
		private void button4_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 9)
				{
					applied = new applied();
					num = 10;
				}
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "compact /c /s /a /i /exe:LZX C:\\Windows\\System32\\*";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001C9DC File Offset: 0x0001ABDC
		private void button7_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 9)
				{
					applied = new applied();
					num = 10;
				}
				if (num == 8)
				{
					process.WaitForExit();
					num = 9;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "compact /u /a /s /exe C:\\Windows\\System32\\*";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0001CB80 File Offset: 0x0001AD80
		private void button21_Click(object sender, EventArgs e)
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

		// Token: 0x060000AA RID: 170 RVA: 0x00018FE4 File Offset: 0x000171E4
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

		// Token: 0x060000AB RID: 171 RVA: 0x0001CBE0 File Offset: 0x0001ADE0
		private void button5_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.StartInfo = processStartInfo;
					num = 8;
				}
				if (num == 10)
				{
					applied = new applied();
					num = 11;
				}
				if (num == 9)
				{
					process.WaitForExit();
					num = 10;
				}
				if (num == 8)
				{
					process.Start();
					num = 9;
				}
				if (num == 6)
				{
					processStartInfo.Verb = "runas";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Arguments = "/C Compact.exe /CompactOS:always";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0001CD38 File Offset: 0x0001AF38
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 3)
				{
					processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
					num = 4;
				}
				Process process;
				if (num == 7)
				{
					process.StartInfo = processStartInfo;
					num = 8;
				}
				if (num == 10)
				{
					applied = new applied();
					num = 11;
				}
				if (num == 9)
				{
					process.WaitForExit();
					num = 10;
				}
				if (num == 8)
				{
					process.Start();
					num = 9;
				}
				if (num == 6)
				{
					processStartInfo.Verb = "runas";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.Arguments = "/C Compact.exe /CompactOS:never";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo.FileName = "cmd.exe";
					num = 5;
				}
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 1)
				{
					process = new Process();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			try
			{
				applied.ShowDialog(this);
			}
			finally
			{
				if (applied != null)
				{
					((IDisposable)applied).Dispose();
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0001CE90 File Offset: 0x0001B090
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

		// Token: 0x060000AE RID: 174 RVA: 0x0001CF08 File Offset: 0x0001B108
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.label9 = new Label();
					num = 4;
				}
				if (num == 7)
				{
					this.label4 = new Label();
					num = 8;
				}
				if (num == 11)
				{
					this.label8 = new Label();
					num = 12;
				}
				if (num == 15)
				{
					this.button6 = new Button();
					num = 16;
				}
				if (num == 19)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 20;
				}
				if (num == 22)
				{
					this.label1.Name = "label1";
					num = 23;
				}
				if (num == 26)
				{
					this.label2.AutoSize = true;
					num = 27;
				}
				if (num == 30)
				{
					this.label2.Name = "label2";
					num = 31;
				}
				if (num == 34)
				{
					this.label9.AutoSize = true;
					num = 35;
				}
				if (num == 38)
				{
					this.label9.Name = "label9";
					num = 39;
				}
				if (num == 41)
				{
					this.label9.Text = "Compresses OS Binaries to save disk (have no impact on performance)";
					num = 42;
				}
				if (num == 45)
				{
					this.button5.FlatStyle = FlatStyle.Flat;
					num = 46;
				}
				if (num == 49)
				{
					this.button5.Location = new Point(242, 211);
					num = 50;
				}
				if (num == 53)
				{
					this.button5.TabIndex = 93;
					num = 54;
				}
				if (num == 57)
				{
					this.button5.Click += this.button5_Click;
					num = 58;
				}
				if (num == 60)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 61;
				}
				if (num == 64)
				{
					this.button1.ImageAlign = ContentAlignment.MiddleLeft;
					num = 65;
				}
				if (num == 68)
				{
					this.button1.Size = new Size(121, 32);
					num = 69;
				}
				if (num == 72)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 73;
				}
				if (num == 76)
				{
					this.label3.ForeColor = Color.White;
					num = 77;
				}
				if (num == 80)
				{
					this.label3.TabIndex = 95;
					num = 81;
				}
				if (num == 83)
				{
					this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 84;
				}
				if (num == 87)
				{
					this.label4.Size = new Size(183, 19);
					num = 88;
				}
				if (num == 91)
				{
					this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 92;
				}
				if (num == 95)
				{
					this.label5.Size = new Size(373, 19);
					num = 96;
				}
				if (num == 99)
				{
					this.label6.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 100;
				}
				if (num == 102)
				{
					this.label6.Name = "label6";
					num = 103;
				}
				if (num == 106)
				{
					this.label7.AutoSize = true;
					num = 107;
				}
				if (num == 110)
				{
					this.label7.Name = "label7";
					num = 111;
				}
				if (num == 114)
				{
					this.label8.AutoSize = true;
					num = 115;
				}
				if (num == 118)
				{
					this.label8.Name = "label8";
					num = 119;
				}
				if (num == 121)
				{
					this.label8.Text = "NOTE : LZX has a higher overhead, so only use if your CPU is reasonably strong";
					num = 122;
				}
				if (num == 125)
				{
					this.button2.FlatStyle = FlatStyle.Flat;
					num = 126;
				}
				if (num == 129)
				{
					this.button2.Location = new Point(225, 491);
					num = 130;
				}
				if (num == 133)
				{
					this.button2.TabIndex = 102;
					num = 134;
				}
				if (num == 137)
				{
					this.button2.Click += this.button2_Click;
					num = 138;
				}
				if (num == 141)
				{
					this.button3.FlatStyle = FlatStyle.Flat;
					num = 142;
				}
				if (num == 144)
				{
					this.button3.ImageAlign = ContentAlignment.MiddleLeft;
					num = 145;
				}
				if (num == 148)
				{
					this.button3.Size = new Size(121, 32);
					num = 149;
				}
				if (num == 152)
				{
					this.button3.UseVisualStyleBackColor = false;
					num = 153;
				}
				if (num == 156)
				{
					this.button4.FlatAppearance.BorderSize = 0;
					num = 157;
				}
				if (num == 160)
				{
					this.button4.ImageAlign = ContentAlignment.MiddleLeft;
					num = 161;
				}
				if (num == 163)
				{
					this.button4.Name = "button4";
					num = 164;
				}
				if (num == 167)
				{
					this.button4.Text = "LZX";
					num = 168;
				}
				if (num == 171)
				{
					this.button6.Cursor = Cursors.Hand;
					num = 172;
				}
				if (num == 175)
				{
					this.button6.ForeColor = Color.White;
					num = 176;
				}
				if (num == 179)
				{
					this.button6.Name = "button6";
					num = 180;
				}
				if (num == 182)
				{
					this.button6.TabStop = false;
					num = 183;
				}
				if (num == 186)
				{
					this.button7.BackColor = Color.FromArgb(38, 38, 38);
					num = 187;
				}
				if (num == 190)
				{
					this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 191;
				}
				if (num == 194)
				{
					this.button7.Margin = new Padding(1);
					num = 195;
				}
				if (num == 198)
				{
					this.button7.TabStop = false;
					num = 199;
				}
				if (num == 202)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 203;
				}
				if (num == 205)
				{
					base.Controls.Add(this.button7);
					num = 206;
				}
				if (num == 209)
				{
					base.Controls.Add(this.button3);
					num = 210;
				}
				if (num == 213)
				{
					base.Controls.Add(this.label5);
					num = 214;
				}
				if (num == 217)
				{
					base.Controls.Add(this.button5);
					num = 218;
				}
				if (num == 221)
				{
					base.Name = "compact";
					num = 222;
				}
				if (num == 224)
				{
					base.PerformLayout();
					num = 225;
				}
				if (num == 223)
				{
					base.ResumeLayout(false);
					num = 224;
				}
				if (num == 222)
				{
					base.Size = new Size(1006, 669);
					num = 223;
				}
				if (num == 220)
				{
					base.Controls.Add(this.label1);
					num = 221;
				}
				if (num == 219)
				{
					base.Controls.Add(this.label2);
					num = 220;
				}
				if (num == 218)
				{
					base.Controls.Add(this.label9);
					num = 219;
				}
				if (num == 216)
				{
					base.Controls.Add(this.button1);
					num = 217;
				}
				if (num == 215)
				{
					base.Controls.Add(this.label3);
					num = 216;
				}
				if (num == 214)
				{
					base.Controls.Add(this.label4);
					num = 215;
				}
				if (num == 212)
				{
					base.Controls.Add(this.label6);
					num = 213;
				}
				if (num == 211)
				{
					base.Controls.Add(this.label7);
					num = 212;
				}
				if (num == 210)
				{
					base.Controls.Add(this.label8);
					num = 211;
				}
				if (num == 208)
				{
					base.Controls.Add(this.button2);
					num = 209;
				}
				if (num == 207)
				{
					base.Controls.Add(this.button6);
					num = 208;
				}
				if (num == 206)
				{
					base.Controls.Add(this.button4);
					num = 207;
				}
				if (num == 204)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 205;
				}
				if (num == 203)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 204;
				}
				if (num == 201)
				{
					this.button7.Click += this.button7_Click;
					num = 202;
				}
				if (num == 200)
				{
					this.button7.UseVisualStyleBackColor = false;
					num = 201;
				}
				if (num == 199)
				{
					this.button7.Text = "Revert";
					num = 200;
				}
				if (num == 197)
				{
					this.button7.TabIndex = 105;
					num = 198;
				}
				if (num == 196)
				{
					this.button7.Size = new Size(121, 32);
					num = 197;
				}
				if (num == 195)
				{
					this.button7.Name = "button7";
					num = 196;
				}
				if (num == 193)
				{
					this.button7.Location = new Point(819, 491);
					num = 194;
				}
				if (num == 192)
				{
					this.button7.ImageAlign = ContentAlignment.MiddleLeft;
					num = 193;
				}
				if (num == 191)
				{
					this.button7.ForeColor = Color.White;
					num = 192;
				}
				if (num == 189)
				{
					this.button7.FlatStyle = FlatStyle.Flat;
					num = 190;
				}
				if (num == 188)
				{
					this.button7.FlatAppearance.BorderSize = 0;
					num = 189;
				}
				if (num == 187)
				{
					this.button7.Cursor = Cursors.Hand;
					num = 188;
				}
				if (num == 185)
				{
					this.button6.Click += this.button6_Click;
					num = 186;
				}
				if (num == 184)
				{
					this.button6.UseVisualStyleBackColor = false;
					num = 185;
				}
				if (num == 183)
				{
					this.button6.Text = "XPRESS16K";
					num = 184;
				}
				if (num == 181)
				{
					this.button6.TabIndex = 103;
					num = 182;
				}
				if (num == 180)
				{
					this.button6.Size = new Size(121, 32);
					num = 181;
				}
				if (num == 178)
				{
					this.button6.Margin = new Padding(1);
					num = 179;
				}
				if (num == 177)
				{
					this.button6.Location = new Point(423, 491);
					num = 178;
				}
				if (num == 176)
				{
					this.button6.ImageAlign = ContentAlignment.MiddleLeft;
					num = 177;
				}
				if (num == 174)
				{
					this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 175;
				}
				if (num == 173)
				{
					this.button6.FlatStyle = FlatStyle.Flat;
					num = 174;
				}
				if (num == 172)
				{
					this.button6.FlatAppearance.BorderSize = 0;
					num = 173;
				}
				if (num == 170)
				{
					this.button6.BackColor = Color.FromArgb(38, 38, 38);
					num = 171;
				}
				if (num == 169)
				{
					this.button4.Click += this.button4_Click;
					num = 170;
				}
				if (num == 168)
				{
					this.button4.UseVisualStyleBackColor = false;
					num = 169;
				}
				if (num == 166)
				{
					this.button4.TabStop = false;
					num = 167;
				}
				if (num == 165)
				{
					this.button4.TabIndex = 104;
					num = 166;
				}
				if (num == 164)
				{
					this.button4.Size = new Size(121, 32);
					num = 165;
				}
				if (num == 162)
				{
					this.button4.Margin = new Padding(1);
					num = 163;
				}
				if (num == 161)
				{
					this.button4.Location = new Point(621, 491);
					num = 162;
				}
				if (num == 159)
				{
					this.button4.ForeColor = Color.White;
					num = 160;
				}
				if (num == 158)
				{
					this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 159;
				}
				if (num == 157)
				{
					this.button4.FlatStyle = FlatStyle.Flat;
					num = 158;
				}
				if (num == 155)
				{
					this.button4.Cursor = Cursors.Hand;
					num = 156;
				}
				if (num == 154)
				{
					this.button4.BackColor = Color.FromArgb(38, 38, 38);
					num = 155;
				}
				if (num == 153)
				{
					this.button3.Click += this.button3_Click;
					num = 154;
				}
				if (num == 151)
				{
					this.button3.Text = "XPRESS4K";
					num = 152;
				}
				if (num == 150)
				{
					this.button3.TabStop = false;
					num = 151;
				}
				if (num == 149)
				{
					this.button3.TabIndex = 101;
					num = 150;
				}
				if (num == 147)
				{
					this.button3.Name = "button3";
					num = 148;
				}
				if (num == 146)
				{
					this.button3.Margin = new Padding(1);
					num = 147;
				}
				if (num == 145)
				{
					this.button3.Location = new Point(27, 491);
					num = 146;
				}
				if (num == 143)
				{
					this.button3.ForeColor = Color.White;
					num = 144;
				}
				if (num == 142)
				{
					this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 143;
				}
				if (num == 140)
				{
					this.button3.FlatAppearance.BorderSize = 0;
					num = 141;
				}
				if (num == 139)
				{
					this.button3.Cursor = Cursors.Hand;
					num = 140;
				}
				if (num == 138)
				{
					this.button3.BackColor = Color.FromArgb(38, 38, 38);
					num = 139;
				}
				if (num == 136)
				{
					this.button2.UseVisualStyleBackColor = false;
					num = 137;
				}
				if (num == 135)
				{
					this.button2.Text = "XPRESS8K";
					num = 136;
				}
				if (num == 134)
				{
					this.button2.TabStop = false;
					num = 135;
				}
				if (num == 132)
				{
					this.button2.Size = new Size(121, 32);
					num = 133;
				}
				if (num == 131)
				{
					this.button2.Name = "button2";
					num = 132;
				}
				if (num == 130)
				{
					this.button2.Margin = new Padding(1);
					num = 131;
				}
				if (num == 128)
				{
					this.button2.ImageAlign = ContentAlignment.MiddleLeft;
					num = 129;
				}
				if (num == 127)
				{
					this.button2.ForeColor = Color.White;
					num = 128;
				}
				if (num == 126)
				{
					this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 127;
				}
				if (num == 124)
				{
					this.button2.FlatAppearance.BorderSize = 0;
					num = 125;
				}
				if (num == 123)
				{
					this.button2.Cursor = Cursors.Hand;
					num = 124;
				}
				if (num == 122)
				{
					this.button2.BackColor = Color.FromArgb(38, 38, 38);
					num = 123;
				}
				if (num == 120)
				{
					this.label8.TabIndex = 100;
					num = 121;
				}
				if (num == 119)
				{
					this.label8.Size = new Size(457, 19);
					num = 120;
				}
				if (num == 117)
				{
					this.label8.Location = new Point(256, 412);
					num = 118;
				}
				if (num == 116)
				{
					this.label8.ForeColor = Color.Silver;
					num = 117;
				}
				if (num == 115)
				{
					this.label8.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 116;
				}
				if (num == 113)
				{
					this.label7.Text = "LZX : Slowest but strongest";
					num = 114;
				}
				if (num == 112)
				{
					this.label7.TabIndex = 99;
					num = 113;
				}
				if (num == 111)
				{
					this.label7.Size = new Size(159, 19);
					num = 112;
				}
				if (num == 109)
				{
					this.label7.Location = new Point(740, 362);
					num = 110;
				}
				if (num == 108)
				{
					this.label7.ForeColor = Color.Silver;
					num = 109;
				}
				if (num == 107)
				{
					this.label7.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 108;
				}
				if (num == 105)
				{
					this.label6.Text = "XPRESS16K : Slower but stronger";
					num = 106;
				}
				if (num == 104)
				{
					this.label6.TabIndex = 98;
					num = 105;
				}
				if (num == 103)
				{
					this.label6.Size = new Size(191, 19);
					num = 104;
				}
				if (num == 101)
				{
					this.label6.Location = new Point(740, 333);
					num = 102;
				}
				if (num == 100)
				{
					this.label6.ForeColor = Color.Silver;
					num = 101;
				}
				if (num == 98)
				{
					this.label6.AutoSize = true;
					num = 99;
				}
				if (num == 97)
				{
					this.label5.Text = "XPRESS8K : Reasonable balanced between speed and compression";
					num = 98;
				}
				if (num == 96)
				{
					this.label5.TabIndex = 97;
					num = 97;
				}
				if (num == 94)
				{
					this.label5.Name = "label5";
					num = 95;
				}
				if (num == 93)
				{
					this.label5.Location = new Point(23, 362);
					num = 94;
				}
				if (num == 92)
				{
					this.label5.ForeColor = Color.Silver;
					num = 93;
				}
				if (num == 90)
				{
					this.label5.AutoSize = true;
					num = 91;
				}
				if (num == 89)
				{
					this.label4.Text = "XPRESS4K : Fastest but weakest";
					num = 90;
				}
				if (num == 88)
				{
					this.label4.TabIndex = 96;
					num = 89;
				}
				if (num == 86)
				{
					this.label4.Name = "label4";
					num = 87;
				}
				if (num == 85)
				{
					this.label4.Location = new Point(23, 333);
					num = 86;
				}
				if (num == 84)
				{
					this.label4.ForeColor = Color.Silver;
					num = 85;
				}
				if (num == 82)
				{
					this.label4.AutoSize = true;
					num = 83;
				}
				if (num == 81)
				{
					this.label3.Text = "Other Compression Methods :-";
					num = 82;
				}
				if (num == 79)
				{
					this.label3.Size = new Size(305, 33);
					num = 80;
				}
				if (num == 78)
				{
					this.label3.Name = "label3";
					num = 79;
				}
				if (num == 77)
				{
					this.label3.Location = new Point(21, 284);
					num = 78;
				}
				if (num == 75)
				{
					this.label3.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 76;
				}
				if (num == 74)
				{
					this.label3.AutoSize = true;
					num = 75;
				}
				if (num == 73)
				{
					this.button1.Click += this.button1_Click;
					num = 74;
				}
				if (num == 71)
				{
					this.button1.Text = "Disable";
					num = 72;
				}
				if (num == 70)
				{
					this.button1.TabStop = false;
					num = 71;
				}
				if (num == 69)
				{
					this.button1.TabIndex = 94;
					num = 70;
				}
				if (num == 67)
				{
					this.button1.Name = "button1";
					num = 68;
				}
				if (num == 66)
				{
					this.button1.Margin = new Padding(1);
					num = 67;
				}
				if (num == 65)
				{
					this.button1.Location = new Point(621, 211);
					num = 66;
				}
				if (num == 63)
				{
					this.button1.ForeColor = Color.White;
					num = 64;
				}
				if (num == 62)
				{
					this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 63;
				}
				if (num == 61)
				{
					this.button1.FlatStyle = FlatStyle.Flat;
					num = 62;
				}
				if (num == 59)
				{
					this.button1.Cursor = Cursors.Hand;
					num = 60;
				}
				if (num == 58)
				{
					this.button1.BackColor = Color.FromArgb(38, 38, 38);
					num = 59;
				}
				if (num == 56)
				{
					this.button5.UseVisualStyleBackColor = false;
					num = 57;
				}
				if (num == 55)
				{
					this.button5.Text = "Enable";
					num = 56;
				}
				if (num == 54)
				{
					this.button5.TabStop = false;
					num = 55;
				}
				if (num == 52)
				{
					this.button5.Size = new Size(121, 32);
					num = 53;
				}
				if (num == 51)
				{
					this.button5.Name = "button5";
					num = 52;
				}
				if (num == 50)
				{
					this.button5.Margin = new Padding(1);
					num = 51;
				}
				if (num == 48)
				{
					this.button5.ImageAlign = ContentAlignment.MiddleLeft;
					num = 49;
				}
				if (num == 47)
				{
					this.button5.ForeColor = Color.White;
					num = 48;
				}
				if (num == 46)
				{
					this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 47;
				}
				if (num == 44)
				{
					this.button5.FlatAppearance.BorderSize = 0;
					num = 45;
				}
				if (num == 43)
				{
					this.button5.Cursor = Cursors.Hand;
					num = 44;
				}
				if (num == 42)
				{
					this.button5.BackColor = Color.FromArgb(38, 38, 38);
					num = 43;
				}
				if (num == 40)
				{
					this.label9.TabIndex = 92;
					num = 41;
				}
				if (num == 39)
				{
					this.label9.Size = new Size(399, 19);
					num = 40;
				}
				if (num == 37)
				{
					this.label9.Location = new Point(23, 53);
					num = 38;
				}
				if (num == 36)
				{
					this.label9.ForeColor = Color.Silver;
					num = 37;
				}
				if (num == 35)
				{
					this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 36;
				}
				if (num == 33)
				{
					this.label2.Text = "Default Compression :-";
					num = 34;
				}
				if (num == 32)
				{
					this.label2.TabIndex = 2;
					num = 33;
				}
				if (num == 31)
				{
					this.label2.Size = new Size(229, 33);
					num = 32;
				}
				if (num == 29)
				{
					this.label2.Location = new Point(21, 141);
					num = 30;
				}
				if (num == 28)
				{
					this.label2.ForeColor = Color.White;
					num = 29;
				}
				if (num == 27)
				{
					this.label2.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 28;
				}
				if (num == 25)
				{
					this.label1.Text = "CompactOS";
					num = 26;
				}
				if (num == 24)
				{
					this.label1.TabIndex = 1;
					num = 25;
				}
				if (num == 23)
				{
					this.label1.Size = new Size(213, 53);
					num = 24;
				}
				if (num == 21)
				{
					this.label1.Location = new Point(18, 0);
					num = 22;
				}
				if (num == 20)
				{
					this.label1.ForeColor = Color.White;
					num = 21;
				}
				if (num == 18)
				{
					this.label1.AutoSize = true;
					num = 19;
				}
				if (num == 17)
				{
					base.SuspendLayout();
					num = 18;
				}
				if (num == 16)
				{
					this.button7 = new Button();
					num = 17;
				}
				if (num == 14)
				{
					this.button4 = new Button();
					num = 15;
				}
				if (num == 13)
				{
					this.button3 = new Button();
					num = 14;
				}
				if (num == 12)
				{
					this.button2 = new Button();
					num = 13;
				}
				if (num == 10)
				{
					this.label7 = new Label();
					num = 11;
				}
				if (num == 9)
				{
					this.label6 = new Label();
					num = 10;
				}
				if (num == 8)
				{
					this.label5 = new Label();
					num = 9;
				}
				if (num == 6)
				{
					this.label3 = new Label();
					num = 7;
				}
				if (num == 5)
				{
					this.button1 = new Button();
					num = 6;
				}
				if (num == 4)
				{
					this.button5 = new Button();
					num = 5;
				}
				if (num == 2)
				{
					this.label2 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					this.label1 = new Label();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 225);
		}

		// Token: 0x040000E8 RID: 232
		private static Compact _instace;

		// Token: 0x040000E9 RID: 233
		private IContainer components = null;

		// Token: 0x040000EA RID: 234
		private Label label1;

		// Token: 0x040000EB RID: 235
		private Label label2;

		// Token: 0x040000EC RID: 236
		private Label label9;

		// Token: 0x040000ED RID: 237
		private Button button5;

		// Token: 0x040000EE RID: 238
		private Button button1;

		// Token: 0x040000EF RID: 239
		private Label label3;

		// Token: 0x040000F0 RID: 240
		private Label label4;

		// Token: 0x040000F1 RID: 241
		private Label label5;

		// Token: 0x040000F2 RID: 242
		private Label label6;

		// Token: 0x040000F3 RID: 243
		private Label label7;

		// Token: 0x040000F4 RID: 244
		private Label label8;

		// Token: 0x040000F5 RID: 245
		private Button button2;

		// Token: 0x040000F6 RID: 246
		private Button button3;

		// Token: 0x040000F7 RID: 247
		private Button button4;

		// Token: 0x040000F8 RID: 248
		private Button button6;

		// Token: 0x040000F9 RID: 249
		private Button button7;
	}
}
