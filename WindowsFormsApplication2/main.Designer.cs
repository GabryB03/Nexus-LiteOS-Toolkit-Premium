namespace WindowsFormsApplication2
{
	// Token: 0x02000009 RID: 9
	public partial class main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000067D0 File Offset: 0x000049D0
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

		// Token: 0x06000048 RID: 72 RVA: 0x00006848 File Offset: 0x00004A48
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 14)
				{
					this.tweaks = new global::System.Windows.Forms.Button();
					num = 15;
				}
				if (num == 29)
				{
					this.label11 = new global::System.Windows.Forms.Label();
					num = 30;
				}
				if (num == 44)
				{
					this.minimize_tray = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
					num = 45;
				}
				if (num == 59)
				{
					this.contextMenuStrip1.SuspendLayout();
					num = 60;
				}
				if (num == 74)
				{
					this.panel1.Controls.Add(this.pictureBox5);
					num = 75;
				}
				if (num == 89)
				{
					this.game_B.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 90;
				}
				if (num == 104)
				{
					this.sys_info.FlatAppearance.BorderSize = 0;
					num = 105;
				}
				if (num == 119)
				{
					this.cleanup.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 120;
				}
				if (num == 133)
				{
					this.cleanup.Text = "Cleanup";
					num = 134;
				}
				if (num == 148)
				{
					this.home.Size = new global::System.Drawing.Size(208, 48);
					num = 149;
				}
				if (num == 163)
				{
					this.opt.Margin = new global::System.Windows.Forms.Padding(1);
					num = 164;
				}
				if (num == 178)
				{
					this.DLs.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 179;
				}
				if (num == 193)
				{
					this.UWP.ForeColor = global::System.Drawing.Color.White;
					num = 194;
				}
				if (num == 208)
				{
					this.g_opt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 209;
				}
				if (num == 223)
				{
					this.COS.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 224;
				}
				if (num == 238)
				{
					this.COS.Click += new global::System.EventHandler(this.button7_Click);
					num = 239;
				}
				if (num == 253)
				{
					this.g_tweaks.Text = "Gaming Tweaks";
					num = 254;
				}
				if (num == 267)
				{
					this.tweaks.Size = new global::System.Drawing.Size(220, 48);
					num = 268;
				}
				if (num == 282)
				{
					this.context.Margin = new global::System.Windows.Forms.Padding(1);
					num = 283;
				}
				if (num == 297)
				{
					this.cb_lowpriostandbylist.Location = new global::System.Drawing.Point(17, 126);
					num = 298;
				}
				if (num == 312)
				{
					this.pictureBox5.TabStop = false;
					num = 313;
				}
				if (num == 327)
				{
					this.cb_standbylist.AutoSize = true;
					num = 328;
				}
				if (num == 342)
				{
					this.cb_standbylist.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 343;
				}
				if (num == 357)
				{
					this.cb_workingset.UncheckedState.BorderThickness = 0;
					num = 358;
				}
				if (num == 372)
				{
					this.cb_modifiedlist.UncheckedState.BorderRadius = 0;
					num = 373;
				}
				if (num == 386)
				{
					this.panel2.Controls.Add(this.label13);
					num = 387;
				}
				if (num == 401)
				{
					this.panel2.Location = new global::System.Drawing.Point(210, 34);
					num = 402;
				}
				if (num == 416)
				{
					this.label13.Location = new global::System.Drawing.Point(154, 480);
					num = 417;
				}
				if (num == 431)
				{
					this.pictureBox4.Name = "pictureBox4";
					num = 432;
				}
				if (num == 446)
				{
					this.label10.ForeColor = global::System.Drawing.Color.Silver;
					num = 447;
				}
				if (num == 461)
				{
					this.pictureBox3.Location = new global::System.Drawing.Point(96, 299);
					num = 462;
				}
				if (num == 476)
				{
					this.label6.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 477;
				}
				if (num == 491)
				{
					this.label4.AutoSize = true;
					num = 492;
				}
				if (num == 506)
				{
					this.label3.Text = "Features";
					num = 507;
				}
				if (num == 520)
				{
					this.pictureBox2.TabIndex = 9;
					num = 521;
				}
				if (num == 535)
				{
					this.minimize.BorderColor = global::System.Drawing.Color.Transparent;
					num = 536;
				}
				if (num == 550)
				{
					this.siticoneButton1.BorderRadius = 10;
					num = 551;
				}
				if (num == 565)
				{
					this.siticoneButton1.Location = new global::System.Drawing.Point(872, -2);
					num = 566;
				}
				if (num == 580)
				{
					this.siticoneControlBox1.Name = "siticoneControlBox1";
					num = 581;
				}
				if (num == 595)
				{
					this.minimize_tray.Size = new global::System.Drawing.Size(43, 38);
					num = 596;
				}
				if (num == 610)
				{
					this.cleanMemoryToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
					num = 611;
				}
				if (num == 625)
				{
					this.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
					num = 626;
				}
				if (num == 639)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
					num = 640;
				}
				if (num == 644)
				{
					base.ResumeLayout(false);
					num = 645;
				}
				if (num == 643)
				{
					this.contextMenuStrip1.ResumeLayout(false);
					num = 644;
				}
				if (num == 642)
				{
					this.panel3.ResumeLayout(false);
					num = 643;
				}
				if (num == 641)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
					num = 642;
				}
				if (num == 640)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
					num = 641;
				}
				if (num == 638)
				{
					this.panel2.PerformLayout();
					num = 639;
				}
				if (num == 637)
				{
					this.panel2.ResumeLayout(false);
					num = 638;
				}
				if (num == 636)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
					num = 637;
				}
				if (num == 635)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
					num = 636;
				}
				if (num == 634)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
					num = 635;
				}
				if (num == 633)
				{
					this.panel1.PerformLayout();
					num = 634;
				}
				if (num == 632)
				{
					this.panel1.ResumeLayout(false);
					num = 633;
				}
				if (num == 631)
				{
					base.Load += new global::System.EventHandler(this.main_Load);
					num = 632;
				}
				if (num == 630)
				{
					this.Text = "Nexus LiteOS Toolkit";
					num = 631;
				}
				if (num == 629)
				{
					base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
					num = 630;
				}
				if (num == 628)
				{
					base.Name = "main";
					num = 629;
				}
				global::System.ComponentModel.ComponentResourceManager componentResourceManager;
				if (num == 627)
				{
					base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
					num = 628;
				}
				if (num == 626)
				{
					base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
					num = 627;
				}
				if (num == 624)
				{
					base.Controls.Add(this.panel1);
					num = 625;
				}
				if (num == 623)
				{
					base.Controls.Add(this.panel2);
					num = 624;
				}
				if (num == 622)
				{
					base.Controls.Add(this.panel3);
					num = 623;
				}
				if (num == 621)
				{
					base.ControlBox = false;
					num = 622;
				}
				if (num == 620)
				{
					base.ClientSize = new global::System.Drawing.Size(1215, 712);
					num = 621;
				}
				if (num == 619)
				{
					this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 620;
				}
				if (num == 618)
				{
					base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
					num = 619;
				}
				if (num == 617)
				{
					base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
					num = 618;
				}
				if (num == 616)
				{
					this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.exitToolStripMenuItem_Click);
					num = 617;
				}
				if (num == 615)
				{
					this.exitToolStripMenuItem.Text = "Exit";
					num = 616;
				}
				if (num == 614)
				{
					this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
					num = 615;
				}
				if (num == 613)
				{
					this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
					num = 614;
				}
				if (num == 612)
				{
					this.cleanMemoryToolStripMenuItem.Click += new global::System.EventHandler(this.cleanMemoryToolStripMenuItem_Click);
					num = 613;
				}
				if (num == 611)
				{
					this.cleanMemoryToolStripMenuItem.Text = "Clean Memory";
					num = 612;
				}
				if (num == 609)
				{
					this.cleanMemoryToolStripMenuItem.Name = "cleanMemoryToolStripMenuItem";
					num = 610;
				}
				if (num == 608)
				{
					this.openToolStripMenuItem.Click += new global::System.EventHandler(this.openToolStripMenuItem_Click);
					num = 609;
				}
				if (num == 607)
				{
					this.openToolStripMenuItem.Text = "Open";
					num = 608;
				}
				if (num == 606)
				{
					this.openToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
					num = 607;
				}
				if (num == 605)
				{
					this.openToolStripMenuItem.Name = "openToolStripMenuItem";
					num = 606;
				}
				if (num == 604)
				{
					this.contextMenuStrip1.Size = new global::System.Drawing.Size(153, 70);
					num = 605;
				}
				if (num == 603)
				{
					this.contextMenuStrip1.Name = "contextMenuStrip1";
					num = 604;
				}
				if (num == 602)
				{
					this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem, this.cleanMemoryToolStripMenuItem, this.exitToolStripMenuItem });
					num = 603;
				}
				if (num == 601)
				{
					this.notifyIcon1.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
					num = 602;
				}
				if (num == 600)
				{
					this.notifyIcon1.Text = "Nexus LiteOS Toolkit [Premium]";
					num = 601;
				}
				if (num == 599)
				{
					this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
					num = 600;
				}
				if (num == 598)
				{
					this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
					num = 599;
				}
				if (num == 597)
				{
					this.minimize_tray.Click += new global::System.EventHandler(this.minimize_tray_Click);
					num = 598;
				}
				if (num == 596)
				{
					this.minimize_tray.TabIndex = 33;
					num = 597;
				}
				if (num == 594)
				{
					this.minimize_tray.ShadowDecoration.Parent = this.minimize_tray;
					num = 595;
				}
				if (num == 593)
				{
					this.minimize_tray.Name = "minimize_tray";
					num = 594;
				}
				if (num == 592)
				{
					this.minimize_tray.Location = new global::System.Drawing.Point(915, -2);
					num = 593;
				}
				if (num == 591)
				{
					this.minimize_tray.IconColor = global::System.Drawing.Color.White;
					num = 592;
				}
				if (num == 590)
				{
					this.minimize_tray.HoverState.Parent = this.minimize_tray;
					num = 591;
				}
				if (num == 589)
				{
					this.minimize_tray.FillColor = global::System.Drawing.Color.Transparent;
					num = 590;
				}
				if (num == 588)
				{
					this.minimize_tray.ControlBoxType = 0;
					num = 589;
				}
				if (num == 587)
				{
					this.minimize_tray.BorderRadius = 10;
					num = 588;
				}
				if (num == 586)
				{
					this.minimize_tray.BackColor = global::System.Drawing.Color.Transparent;
					num = 587;
				}
				if (num == 585)
				{
					this.minimize_tray.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
					num = 586;
				}
				if (num == 584)
				{
					this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
					num = 585;
				}
				if (num == 583)
				{
					this.siticoneControlBox1.TabIndex = 10;
					num = 584;
				}
				if (num == 582)
				{
					this.siticoneControlBox1.Size = new global::System.Drawing.Size(43, 38);
					num = 583;
				}
				if (num == 581)
				{
					this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
					num = 582;
				}
				if (num == 579)
				{
					this.siticoneControlBox1.Location = new global::System.Drawing.Point(959, -2);
					num = 580;
				}
				if (num == 578)
				{
					this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
					num = 579;
				}
				if (num == 577)
				{
					this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
					num = 578;
				}
				if (num == 576)
				{
					this.siticoneControlBox1.HoverState.IconColor = global::System.Drawing.Color.White;
					num = 577;
				}
				if (num == 575)
				{
					this.siticoneControlBox1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
					num = 576;
				}
				if (num == 574)
				{
					this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
					num = 575;
				}
				if (num == 573)
				{
					this.siticoneControlBox1.BorderRadius = 10;
					num = 574;
				}
				if (num == 572)
				{
					this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
					num = 573;
				}
				if (num == 571)
				{
					this.siticoneControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
					num = 572;
				}
				if (num == 570)
				{
					this.siticoneButton1.Click += new global::System.EventHandler(this.siticoneButton1_Click);
					num = 571;
				}
				if (num == 569)
				{
					this.siticoneButton1.TabIndex = 32;
					num = 570;
				}
				if (num == 568)
				{
					this.siticoneButton1.Size = new global::System.Drawing.Size(43, 38);
					num = 569;
				}
				if (num == 567)
				{
					this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
					num = 568;
				}
				if (num == 566)
				{
					this.siticoneButton1.Name = "siticoneButton1";
					num = 567;
				}
				if (num == 564)
				{
					this.siticoneButton1.ImageSize = new global::System.Drawing.Size(30, 30);
					num = 565;
				}
				if (num == 563)
				{
					this.siticoneButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneButton1.Image");
					num = 564;
				}
				if (num == 562)
				{
					this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
					num = 563;
				}
				if (num == 561)
				{
					this.siticoneButton1.HoverState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
					num = 562;
				}
				if (num == 560)
				{
					this.siticoneButton1.ForeColor = global::System.Drawing.Color.White;
					num = 561;
				}
				if (num == 559)
				{
					this.siticoneButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
					num = 560;
				}
				if (num == 558)
				{
					this.siticoneButton1.FillColor = global::System.Drawing.Color.Transparent;
					num = 559;
				}
				if (num == 557)
				{
					this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
					num = 558;
				}
				if (num == 556)
				{
					this.siticoneButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
					num = 557;
				}
				if (num == 555)
				{
					this.siticoneButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
					num = 556;
				}
				if (num == 554)
				{
					this.siticoneButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
					num = 555;
				}
				if (num == 553)
				{
					this.siticoneButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
					num = 554;
				}
				if (num == 552)
				{
					this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
					num = 553;
				}
				if (num == 551)
				{
					this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
					num = 552;
				}
				if (num == 549)
				{
					this.siticoneButton1.BackColor = global::System.Drawing.Color.Transparent;
					num = 550;
				}
				if (num == 548)
				{
					this.minimize.Click += new global::System.EventHandler(this.minimize_Click);
					num = 549;
				}
				if (num == 547)
				{
					this.minimize.TabIndex = 11;
					num = 548;
				}
				if (num == 546)
				{
					this.minimize.Size = new global::System.Drawing.Size(43, 38);
					num = 547;
				}
				if (num == 545)
				{
					this.minimize.ShadowDecoration.Parent = this.minimize;
					num = 546;
				}
				if (num == 544)
				{
					this.minimize.Name = "minimize";
					num = 545;
				}
				if (num == 543)
				{
					this.minimize.Location = new global::System.Drawing.Point(915, -2);
					num = 544;
				}
				if (num == 542)
				{
					this.minimize.IconColor = global::System.Drawing.Color.White;
					num = 543;
				}
				if (num == 541)
				{
					this.minimize.HoverState.Parent = this.minimize;
					num = 542;
				}
				if (num == 540)
				{
					this.minimize.ForeColor = global::System.Drawing.Color.Transparent;
					num = 541;
				}
				if (num == 539)
				{
					this.minimize.FillColor = global::System.Drawing.Color.Transparent;
					num = 540;
				}
				if (num == 538)
				{
					this.minimize.ControlBoxType = 0;
					num = 539;
				}
				if (num == 537)
				{
					this.minimize.ControlBoxStyle = 1;
					num = 538;
				}
				if (num == 536)
				{
					this.minimize.BorderRadius = 10;
					num = 537;
				}
				if (num == 534)
				{
					this.minimize.BackColor = global::System.Drawing.Color.Transparent;
					num = 535;
				}
				if (num == 533)
				{
					this.minimize.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
					num = 534;
				}
				if (num == 532)
				{
					this.panel3.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel3_Paint);
					num = 533;
				}
				if (num == 531)
				{
					this.panel3.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
					num = 532;
				}
				if (num == 530)
				{
					this.panel3.TabIndex = 9;
					num = 531;
				}
				if (num == 529)
				{
					this.panel3.Size = new global::System.Drawing.Size(1006, 38);
					num = 530;
				}
				if (num == 528)
				{
					this.panel3.Name = "panel3";
					num = 529;
				}
				if (num == 527)
				{
					this.panel3.Location = new global::System.Drawing.Point(210, 0);
					num = 528;
				}
				if (num == 526)
				{
					this.panel3.Controls.Add(this.minimize_tray);
					num = 527;
				}
				if (num == 525)
				{
					this.panel3.Controls.Add(this.siticoneControlBox1);
					num = 526;
				}
				if (num == 524)
				{
					this.panel3.Controls.Add(this.siticoneButton1);
					num = 525;
				}
				if (num == 523)
				{
					this.panel3.Controls.Add(this.minimize);
					num = 524;
				}
				if (num == 522)
				{
					this.panel3.BackColor = global::System.Drawing.Color.FromArgb(38, 38, 38);
					num = 523;
				}
				if (num == 521)
				{
					this.pictureBox2.TabStop = false;
					num = 522;
				}
				if (num == 519)
				{
					this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 520;
				}
				if (num == 518)
				{
					this.pictureBox2.Size = new global::System.Drawing.Size(64, 64);
					num = 519;
				}
				if (num == 517)
				{
					this.pictureBox2.Name = "pictureBox2";
					num = 518;
				}
				if (num == 516)
				{
					this.pictureBox2.Location = new global::System.Drawing.Point(96, 141);
					num = 517;
				}
				if (num == 515)
				{
					this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
					num = 516;
				}
				if (num == 514)
				{
					this.label2.Text = "The Ultimate all-in-one tool";
					num = 515;
				}
				if (num == 513)
				{
					this.label2.TabIndex = 8;
					num = 514;
				}
				if (num == 512)
				{
					this.label2.Size = new global::System.Drawing.Size(253, 30);
					num = 513;
				}
				if (num == 511)
				{
					this.label2.Name = "label2";
					num = 512;
				}
				if (num == 510)
				{
					this.label2.Location = new global::System.Drawing.Point(371, 81);
					num = 511;
				}
				if (num == 509)
				{
					this.label2.ForeColor = global::System.Drawing.Color.White;
					num = 510;
				}
				if (num == 508)
				{
					this.label2.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 509;
				}
				if (num == 507)
				{
					this.label2.AutoSize = true;
					num = 508;
				}
				if (num == 505)
				{
					this.label3.TabIndex = 10;
					num = 506;
				}
				if (num == 504)
				{
					this.label3.Size = new global::System.Drawing.Size(87, 30);
					num = 505;
				}
				if (num == 503)
				{
					this.label3.Name = "label3";
					num = 504;
				}
				if (num == 502)
				{
					this.label3.Location = new global::System.Drawing.Point(150, 160);
					num = 503;
				}
				if (num == 501)
				{
					this.label3.ForeColor = global::System.Drawing.Color.White;
					num = 502;
				}
				if (num == 500)
				{
					this.label3.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 501;
				}
				if (num == 499)
				{
					this.label3.AutoSize = true;
					num = 500;
				}
				if (num == 498)
				{
					this.label4.Text = "Nexus LiteOS Toolkit comes with plenty of features. Cleanup Windows, some basic tweaks to enable or disable windows features";
					num = 499;
				}
				if (num == 497)
				{
					this.label4.TabIndex = 11;
					num = 498;
				}
				if (num == 496)
				{
					this.label4.Size = new global::System.Drawing.Size(709, 19);
					num = 497;
				}
				if (num == 495)
				{
					this.label4.Name = "label4";
					num = 496;
				}
				if (num == 494)
				{
					this.label4.Location = new global::System.Drawing.Point(151, 194);
					num = 495;
				}
				if (num == 493)
				{
					this.label4.ForeColor = global::System.Drawing.Color.Silver;
					num = 494;
				}
				if (num == 492)
				{
					this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 493;
				}
				if (num == 490)
				{
					this.label5.Text = "(hidden features as well). Some advanced tweaks meant for gamers, Manage Windows apps ex. adding Microsoft Store or Xbox";
					num = 491;
				}
				if (num == 489)
				{
					this.label5.TabIndex = 12;
					num = 490;
				}
				if (num == 488)
				{
					this.label5.Size = new global::System.Drawing.Size(711, 19);
					num = 489;
				}
				if (num == 487)
				{
					this.label5.Name = "label5";
					num = 488;
				}
				if (num == 486)
				{
					this.label5.Location = new global::System.Drawing.Point(151, 213);
					num = 487;
				}
				if (num == 485)
				{
					this.label5.ForeColor = global::System.Drawing.Color.Silver;
					num = 486;
				}
				if (num == 484)
				{
					this.label5.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 485;
				}
				if (num == 483)
				{
					this.label5.AutoSize = true;
					num = 484;
				}
				if (num == 482)
				{
					this.label6.Text = "or deleting them. Add handy context menus using a huge set of presets. Manage user account related settings. Download over";
					num = 483;
				}
				if (num == 481)
				{
					this.label6.TabIndex = 13;
					num = 482;
				}
				if (num == 480)
				{
					this.label6.Size = new global::System.Drawing.Size(699, 19);
					num = 481;
				}
				if (num == 479)
				{
					this.label6.Name = "label6";
					num = 480;
				}
				if (num == 478)
				{
					this.label6.Location = new global::System.Drawing.Point(151, 233);
					num = 479;
				}
				if (num == 477)
				{
					this.label6.ForeColor = global::System.Drawing.Color.Silver;
					num = 478;
				}
				if (num == 475)
				{
					this.label6.AutoSize = true;
					num = 476;
				}
				if (num == 474)
				{
					this.label7.Text = "100+ software (cracked/freeware) with ease. And much, MUCH more!";
					num = 475;
				}
				if (num == 473)
				{
					this.label7.TabIndex = 14;
					num = 474;
				}
				if (num == 472)
				{
					this.label7.Size = new global::System.Drawing.Size(385, 19);
					num = 473;
				}
				if (num == 471)
				{
					this.label7.Name = "label7";
					num = 472;
				}
				if (num == 470)
				{
					this.label7.Location = new global::System.Drawing.Point(151, 252);
					num = 471;
				}
				if (num == 469)
				{
					this.label7.ForeColor = global::System.Drawing.Color.Silver;
					num = 470;
				}
				if (num == 468)
				{
					this.label7.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 469;
				}
				if (num == 467)
				{
					this.label7.AutoSize = true;
					num = 468;
				}
				if (num == 466)
				{
					this.pictureBox3.TabStop = false;
					num = 467;
				}
				if (num == 465)
				{
					this.pictureBox3.TabIndex = 15;
					num = 466;
				}
				if (num == 464)
				{
					this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 465;
				}
				if (num == 463)
				{
					this.pictureBox3.Size = new global::System.Drawing.Size(64, 64);
					num = 464;
				}
				if (num == 462)
				{
					this.pictureBox3.Name = "pictureBox3";
					num = 463;
				}
				if (num == 460)
				{
					this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
					num = 461;
				}
				if (num == 459)
				{
					this.label8.Text = "Tweaks/Basic Info";
					num = 460;
				}
				if (num == 458)
				{
					this.label8.TabIndex = 16;
					num = 459;
				}
				if (num == 457)
				{
					this.label8.Size = new global::System.Drawing.Size(169, 30);
					num = 458;
				}
				if (num == 456)
				{
					this.label8.Name = "label8";
					num = 457;
				}
				if (num == 455)
				{
					this.label8.Location = new global::System.Drawing.Point(150, 320);
					num = 456;
				}
				if (num == 454)
				{
					this.label8.ForeColor = global::System.Drawing.Color.White;
					num = 455;
				}
				if (num == 453)
				{
					this.label8.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 454;
				}
				if (num == 452)
				{
					this.label8.AutoSize = true;
					num = 453;
				}
				if (num == 451)
				{
					this.label10.Text = "The tweaks provided in the tool will perfectly optimize your gaming experience. Every software have bugs/issues in it, if anything";
					num = 452;
				}
				if (num == 450)
				{
					this.label10.TabIndex = 18;
					num = 451;
				}
				if (num == 449)
				{
					this.label10.Size = new global::System.Drawing.Size(713, 19);
					num = 450;
				}
				if (num == 448)
				{
					this.label10.Name = "label10";
					num = 449;
				}
				if (num == 447)
				{
					this.label10.Location = new global::System.Drawing.Point(151, 350);
					num = 448;
				}
				if (num == 445)
				{
					this.label10.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 446;
				}
				if (num == 444)
				{
					this.label10.AutoSize = true;
					num = 445;
				}
				if (num == 443)
				{
					this.label11.Text = "is wrong with the toolkit (broken links or some bug) that bug/issue will be fixed by an update";
					num = 444;
				}
				if (num == 442)
				{
					this.label11.TabIndex = 19;
					num = 443;
				}
				if (num == 441)
				{
					this.label11.Size = new global::System.Drawing.Size(520, 19);
					num = 442;
				}
				if (num == 440)
				{
					this.label11.Name = "label11";
					num = 441;
				}
				if (num == 439)
				{
					this.label11.Location = new global::System.Drawing.Point(151, 369);
					num = 440;
				}
				if (num == 438)
				{
					this.label11.ForeColor = global::System.Drawing.Color.Silver;
					num = 439;
				}
				if (num == 437)
				{
					this.label11.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 438;
				}
				if (num == 436)
				{
					this.label11.AutoSize = true;
					num = 437;
				}
				if (num == 435)
				{
					this.pictureBox4.TabStop = false;
					num = 436;
				}
				if (num == 434)
				{
					this.pictureBox4.TabIndex = 20;
					num = 435;
				}
				if (num == 433)
				{
					this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 434;
				}
				if (num == 432)
				{
					this.pictureBox4.Size = new global::System.Drawing.Size(64, 64);
					num = 433;
				}
				if (num == 430)
				{
					this.pictureBox4.Location = new global::System.Drawing.Point(96, 427);
					num = 431;
				}
				if (num == 429)
				{
					this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
					num = 430;
				}
				if (num == 428)
				{
					this.label12.Text = "Game Booster";
					num = 429;
				}
				if (num == 427)
				{
					this.label12.TabIndex = 21;
					num = 428;
				}
				if (num == 426)
				{
					this.label12.Size = new global::System.Drawing.Size(136, 30);
					num = 427;
				}
				if (num == 425)
				{
					this.label12.Name = "label12";
					num = 426;
				}
				if (num == 424)
				{
					this.label12.Location = new global::System.Drawing.Point(150, 446);
					num = 425;
				}
				if (num == 423)
				{
					this.label12.ForeColor = global::System.Drawing.Color.White;
					num = 424;
				}
				if (num == 422)
				{
					this.label12.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 423;
				}
				if (num == 421)
				{
					this.label12.AutoSize = true;
					num = 422;
				}
				if (num == 420)
				{
					this.label13.Text = componentResourceManager.GetString("label13.Text");
					num = 421;
				}
				if (num == 419)
				{
					this.label13.TabIndex = 22;
					num = 420;
				}
				if (num == 418)
				{
					this.label13.Size = new global::System.Drawing.Size(737, 38);
					num = 419;
				}
				if (num == 417)
				{
					this.label13.Name = "label13";
					num = 418;
				}
				if (num == 415)
				{
					this.label13.ForeColor = global::System.Drawing.Color.Silver;
					num = 416;
				}
				if (num == 414)
				{
					this.label13.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 415;
				}
				if (num == 413)
				{
					this.label13.AutoSize = true;
					num = 414;
				}
				if (num == 412)
				{
					this.label16.Text = "Thank you for believing in this project!";
					num = 413;
				}
				if (num == 411)
				{
					this.label16.TabIndex = 27;
					num = 412;
				}
				if (num == 410)
				{
					this.label16.Size = new global::System.Drawing.Size(353, 30);
					num = 411;
				}
				if (num == 409)
				{
					this.label16.Name = "label16";
					num = 410;
				}
				if (num == 408)
				{
					this.label16.Location = new global::System.Drawing.Point(318, 583);
					num = 409;
				}
				if (num == 407)
				{
					this.label16.ForeColor = global::System.Drawing.Color.White;
					num = 408;
				}
				if (num == 406)
				{
					this.label16.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 407;
				}
				if (num == 405)
				{
					this.label16.AutoSize = true;
					num = 406;
				}
				if (num == 404)
				{
					this.panel2.TabIndex = 5;
					num = 405;
				}
				if (num == 403)
				{
					this.panel2.Size = new global::System.Drawing.Size(1006, 679);
					num = 404;
				}
				if (num == 402)
				{
					this.panel2.Name = "panel2";
					num = 403;
				}
				if (num == 400)
				{
					this.panel2.Controls.Add(this.pictureBox2);
					num = 401;
				}
				if (num == 399)
				{
					this.panel2.Controls.Add(this.label1);
					num = 400;
				}
				if (num == 398)
				{
					this.panel2.Controls.Add(this.label2);
					num = 399;
				}
				if (num == 397)
				{
					this.panel2.Controls.Add(this.label3);
					num = 398;
				}
				if (num == 396)
				{
					this.panel2.Controls.Add(this.label4);
					num = 397;
				}
				if (num == 395)
				{
					this.panel2.Controls.Add(this.label5);
					num = 396;
				}
				if (num == 394)
				{
					this.panel2.Controls.Add(this.label6);
					num = 395;
				}
				if (num == 393)
				{
					this.panel2.Controls.Add(this.label7);
					num = 394;
				}
				if (num == 392)
				{
					this.panel2.Controls.Add(this.pictureBox3);
					num = 393;
				}
				if (num == 391)
				{
					this.panel2.Controls.Add(this.label8);
					num = 392;
				}
				if (num == 390)
				{
					this.panel2.Controls.Add(this.label10);
					num = 391;
				}
				if (num == 389)
				{
					this.panel2.Controls.Add(this.label11);
					num = 390;
				}
				if (num == 388)
				{
					this.panel2.Controls.Add(this.pictureBox4);
					num = 389;
				}
				if (num == 387)
				{
					this.panel2.Controls.Add(this.label12);
					num = 388;
				}
				if (num == 385)
				{
					this.panel2.Controls.Add(this.label16);
					num = 386;
				}
				if (num == 384)
				{
					this.panel2.BackColor = global::System.Drawing.Color.FromArgb(38, 38, 38);
					num = 385;
				}
				if (num == 383)
				{
					this.label1.Text = "Nexus LiteOS Toolkit";
					num = 384;
				}
				if (num == 382)
				{
					this.label1.TabIndex = 4;
					num = 383;
				}
				if (num == 381)
				{
					this.label1.Size = new global::System.Drawing.Size(418, 63);
					num = 382;
				}
				if (num == 380)
				{
					this.label1.Name = "label1";
					num = 381;
				}
				if (num == 379)
				{
					this.label1.Location = new global::System.Drawing.Point(293, 18);
					num = 380;
				}
				if (num == 378)
				{
					this.label1.ForeColor = global::System.Drawing.Color.White;
					num = 379;
				}
				if (num == 377)
				{
					this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 30f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 378;
				}
				if (num == 376)
				{
					this.label1.BackColor = global::System.Drawing.Color.Transparent;
					num = 377;
				}
				if (num == 375)
				{
					this.label1.AutoSize = true;
					num = 376;
				}
				if (num == 374)
				{
					this.cb_modifiedlist.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 375;
				}
				if (num == 373)
				{
					this.cb_modifiedlist.UncheckedState.BorderThickness = 0;
					num = 374;
				}
				if (num == 371)
				{
					this.cb_modifiedlist.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 372;
				}
				if (num == 370)
				{
					this.cb_modifiedlist.Text = "Clear Modified List";
					num = 371;
				}
				if (num == 369)
				{
					this.cb_modifiedlist.TabIndex = 140;
					num = 370;
				}
				if (num == 368)
				{
					this.cb_modifiedlist.Size = new global::System.Drawing.Size(123, 22);
					num = 369;
				}
				if (num == 367)
				{
					this.cb_modifiedlist.Name = "cb_modifiedlist";
					num = 368;
				}
				if (num == 366)
				{
					this.cb_modifiedlist.Location = new global::System.Drawing.Point(39, 5);
					num = 367;
				}
				if (num == 365)
				{
					this.cb_modifiedlist.ForeColor = global::System.Drawing.Color.White;
					num = 366;
				}
				if (num == 364)
				{
					this.cb_modifiedlist.Font = new global::System.Drawing.Font("Josefin Sans", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 365;
				}
				if (num == 363)
				{
					this.cb_modifiedlist.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 364;
				}
				if (num == 362)
				{
					this.cb_modifiedlist.CheckedState.BorderThickness = 0;
					num = 363;
				}
				if (num == 361)
				{
					this.cb_modifiedlist.CheckedState.BorderRadius = 0;
					num = 362;
				}
				if (num == 360)
				{
					this.cb_modifiedlist.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 361;
				}
				if (num == 359)
				{
					this.cb_modifiedlist.AutoSize = true;
					num = 360;
				}
				if (num == 358)
				{
					this.cb_workingset.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 359;
				}
				if (num == 356)
				{
					this.cb_workingset.UncheckedState.BorderRadius = 0;
					num = 357;
				}
				if (num == 355)
				{
					this.cb_workingset.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 356;
				}
				if (num == 354)
				{
					this.cb_workingset.Text = "Clear Working Set";
					num = 355;
				}
				if (num == 353)
				{
					this.cb_workingset.TabIndex = 141;
					num = 354;
				}
				if (num == 352)
				{
					this.cb_workingset.Size = new global::System.Drawing.Size(117, 22);
					num = 353;
				}
				if (num == 351)
				{
					this.cb_workingset.Name = "cb_workingset";
					num = 352;
				}
				if (num == 350)
				{
					this.cb_workingset.Location = new global::System.Drawing.Point(39, 35);
					num = 351;
				}
				if (num == 349)
				{
					this.cb_workingset.ForeColor = global::System.Drawing.Color.White;
					num = 350;
				}
				if (num == 348)
				{
					this.cb_workingset.Font = new global::System.Drawing.Font("Josefin Sans", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 349;
				}
				if (num == 347)
				{
					this.cb_workingset.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 348;
				}
				if (num == 346)
				{
					this.cb_workingset.CheckedState.BorderThickness = 0;
					num = 347;
				}
				if (num == 345)
				{
					this.cb_workingset.CheckedState.BorderRadius = 0;
					num = 346;
				}
				if (num == 344)
				{
					this.cb_workingset.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 345;
				}
				if (num == 343)
				{
					this.cb_workingset.AutoSize = true;
					num = 344;
				}
				if (num == 341)
				{
					this.cb_standbylist.UncheckedState.BorderThickness = 0;
					num = 342;
				}
				if (num == 340)
				{
					this.cb_standbylist.UncheckedState.BorderRadius = 0;
					num = 341;
				}
				if (num == 339)
				{
					this.cb_standbylist.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 340;
				}
				if (num == 338)
				{
					this.cb_standbylist.Text = "Clear Standby List";
					num = 339;
				}
				if (num == 337)
				{
					this.cb_standbylist.TabIndex = 139;
					num = 338;
				}
				if (num == 336)
				{
					this.cb_standbylist.Size = new global::System.Drawing.Size(119, 22);
					num = 337;
				}
				if (num == 335)
				{
					this.cb_standbylist.Name = "cb_standbylist";
					num = 336;
				}
				if (num == 334)
				{
					this.cb_standbylist.Location = new global::System.Drawing.Point(39, 63);
					num = 335;
				}
				if (num == 333)
				{
					this.cb_standbylist.ForeColor = global::System.Drawing.Color.White;
					num = 334;
				}
				if (num == 332)
				{
					this.cb_standbylist.Font = new global::System.Drawing.Font("Josefin Sans", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 333;
				}
				if (num == 331)
				{
					this.cb_standbylist.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 332;
				}
				if (num == 330)
				{
					this.cb_standbylist.CheckedState.BorderThickness = 0;
					num = 331;
				}
				if (num == 329)
				{
					this.cb_standbylist.CheckedState.BorderRadius = 0;
					num = 330;
				}
				if (num == 328)
				{
					this.cb_standbylist.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 329;
				}
				if (num == 326)
				{
					this.pictureBox1.TabStop = false;
					num = 327;
				}
				if (num == 325)
				{
					this.pictureBox1.TabIndex = 3;
					num = 326;
				}
				if (num == 324)
				{
					this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 325;
				}
				if (num == 323)
				{
					this.pictureBox1.Size = new global::System.Drawing.Size(136, 136);
					num = 324;
				}
				if (num == 322)
				{
					this.pictureBox1.Name = "pictureBox1";
					num = 323;
				}
				if (num == 321)
				{
					this.pictureBox1.Location = new global::System.Drawing.Point(39, -10);
					num = 322;
				}
				if (num == 320)
				{
					this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
					num = 321;
				}
				if (num == 319)
				{
					this.pictureBox6.TabStop = false;
					num = 320;
				}
				if (num == 318)
				{
					this.pictureBox6.TabIndex = 10;
					num = 319;
				}
				if (num == 317)
				{
					this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 318;
				}
				if (num == 316)
				{
					this.pictureBox6.Size = new global::System.Drawing.Size(136, 136);
					num = 317;
				}
				if (num == 315)
				{
					this.pictureBox6.Name = "pictureBox6";
					num = 316;
				}
				if (num == 314)
				{
					this.pictureBox6.Location = new global::System.Drawing.Point(-180, 0);
					num = 315;
				}
				if (num == 313)
				{
					this.pictureBox6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox6.Image");
					num = 314;
				}
				if (num == 311)
				{
					this.pictureBox5.TabIndex = 28;
					num = 312;
				}
				if (num == 310)
				{
					this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					num = 311;
				}
				if (num == 309)
				{
					this.pictureBox5.Size = new global::System.Drawing.Size(180, 180);
					num = 310;
				}
				if (num == 308)
				{
					this.pictureBox5.Name = "pictureBox5";
					num = 309;
				}
				if (num == 307)
				{
					this.pictureBox5.Location = new global::System.Drawing.Point(-180, 0);
					num = 308;
				}
				if (num == 306)
				{
					this.pictureBox5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox5.Image");
					num = 307;
				}
				if (num == 305)
				{
					this.cb_lowpriostandbylist.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 306;
				}
				if (num == 304)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderThickness = 0;
					num = 305;
				}
				if (num == 303)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderRadius = 0;
					num = 304;
				}
				if (num == 302)
				{
					this.cb_lowpriostandbylist.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
					num = 303;
				}
				if (num == 301)
				{
					this.cb_lowpriostandbylist.Text = "Clear Standby List (Low Priority)";
					num = 302;
				}
				if (num == 300)
				{
					this.cb_lowpriostandbylist.TabIndex = 142;
					num = 301;
				}
				if (num == 299)
				{
					this.cb_lowpriostandbylist.Size = new global::System.Drawing.Size(189, 22);
					num = 300;
				}
				if (num == 298)
				{
					this.cb_lowpriostandbylist.Name = "cb_lowpriostandbylist";
					num = 299;
				}
				if (num == 296)
				{
					this.cb_lowpriostandbylist.ForeColor = global::System.Drawing.Color.White;
					num = 297;
				}
				if (num == 295)
				{
					this.cb_lowpriostandbylist.Font = new global::System.Drawing.Font("Josefin Sans", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 296;
				}
				if (num == 294)
				{
					this.cb_lowpriostandbylist.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 295;
				}
				if (num == 293)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderThickness = 0;
					num = 294;
				}
				if (num == 292)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderRadius = 0;
					num = 293;
				}
				if (num == 291)
				{
					this.cb_lowpriostandbylist.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
					num = 292;
				}
				if (num == 290)
				{
					this.cb_lowpriostandbylist.AutoSize = true;
					num = 291;
				}
				if (num == 289)
				{
					this.context.Click += new global::System.EventHandler(this.button8_Click);
					num = 290;
				}
				if (num == 288)
				{
					this.context.UseVisualStyleBackColor = false;
					num = 289;
				}
				if (num == 287)
				{
					this.context.Text = "Context Menu";
					num = 288;
				}
				if (num == 286)
				{
					this.context.TabStop = false;
					num = 287;
				}
				if (num == 285)
				{
					this.context.TabIndex = 5;
					num = 286;
				}
				if (num == 284)
				{
					this.context.Size = new global::System.Drawing.Size(228, 48);
					num = 285;
				}
				if (num == 283)
				{
					this.context.Name = "context";
					num = 284;
				}
				if (num == 281)
				{
					this.context.Location = new global::System.Drawing.Point(2, 555);
					num = 282;
				}
				if (num == 280)
				{
					this.context.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 281;
				}
				if (num == 279)
				{
					this.context.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("context.Image");
					num = 280;
				}
				if (num == 278)
				{
					this.context.ForeColor = global::System.Drawing.Color.White;
					num = 279;
				}
				if (num == 277)
				{
					this.context.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 278;
				}
				if (num == 276)
				{
					this.context.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 277;
				}
				if (num == 275)
				{
					this.context.FlatAppearance.BorderSize = 0;
					num = 276;
				}
				if (num == 274)
				{
					this.context.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 275;
				}
				if (num == 273)
				{
					this.context.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 274;
				}
				if (num == 272)
				{
					this.tweaks.Click += new global::System.EventHandler(this.button5_Click);
					num = 273;
				}
				if (num == 271)
				{
					this.tweaks.UseVisualStyleBackColor = false;
					num = 272;
				}
				if (num == 270)
				{
					this.tweaks.Text = "Tweaks";
					num = 271;
				}
				if (num == 269)
				{
					this.tweaks.TabStop = false;
					num = 270;
				}
				if (num == 268)
				{
					this.tweaks.TabIndex = 5;
					num = 269;
				}
				if (num == 266)
				{
					this.tweaks.Name = "tweaks";
					num = 267;
				}
				if (num == 265)
				{
					this.tweaks.Margin = new global::System.Windows.Forms.Padding(1);
					num = 266;
				}
				if (num == 264)
				{
					this.tweaks.Location = new global::System.Drawing.Point(1, 260);
					num = 265;
				}
				if (num == 263)
				{
					this.tweaks.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 264;
				}
				if (num == 262)
				{
					this.tweaks.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tweaks.Image");
					num = 263;
				}
				if (num == 261)
				{
					this.tweaks.ForeColor = global::System.Drawing.Color.White;
					num = 262;
				}
				if (num == 260)
				{
					this.tweaks.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 261;
				}
				if (num == 259)
				{
					this.tweaks.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 260;
				}
				if (num == 258)
				{
					this.tweaks.FlatAppearance.BorderSize = 0;
					num = 259;
				}
				if (num == 257)
				{
					this.tweaks.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 258;
				}
				if (num == 256)
				{
					this.tweaks.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 257;
				}
				if (num == 255)
				{
					this.g_tweaks.Click += new global::System.EventHandler(this.button6_Click);
					num = 256;
				}
				if (num == 254)
				{
					this.g_tweaks.UseVisualStyleBackColor = false;
					num = 255;
				}
				if (num == 252)
				{
					this.g_tweaks.TabStop = false;
					num = 253;
				}
				if (num == 251)
				{
					this.g_tweaks.TabIndex = 5;
					num = 252;
				}
				if (num == 250)
				{
					this.g_tweaks.Size = new global::System.Drawing.Size(241, 48);
					num = 251;
				}
				if (num == 249)
				{
					this.g_tweaks.Name = "g_tweaks";
					num = 250;
				}
				if (num == 248)
				{
					this.g_tweaks.Margin = new global::System.Windows.Forms.Padding(1);
					num = 249;
				}
				if (num == 247)
				{
					this.g_tweaks.Location = new global::System.Drawing.Point(0, 360);
					num = 248;
				}
				if (num == 246)
				{
					this.g_tweaks.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 247;
				}
				if (num == 245)
				{
					this.g_tweaks.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("g_tweaks.Image");
					num = 246;
				}
				if (num == 244)
				{
					this.g_tweaks.ForeColor = global::System.Drawing.Color.White;
					num = 245;
				}
				if (num == 243)
				{
					this.g_tweaks.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 244;
				}
				if (num == 242)
				{
					this.g_tweaks.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 243;
				}
				if (num == 241)
				{
					this.g_tweaks.FlatAppearance.BorderSize = 0;
					num = 242;
				}
				if (num == 240)
				{
					this.g_tweaks.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 241;
				}
				if (num == 239)
				{
					this.g_tweaks.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 240;
				}
				if (num == 237)
				{
					this.COS.UseVisualStyleBackColor = false;
					num = 238;
				}
				if (num == 236)
				{
					this.COS.Text = "CompactOS";
					num = 237;
				}
				if (num == 235)
				{
					this.COS.TabStop = false;
					num = 236;
				}
				if (num == 234)
				{
					this.COS.TabIndex = 5;
					num = 235;
				}
				if (num == 233)
				{
					this.COS.Size = new global::System.Drawing.Size(228, 48);
					num = 234;
				}
				if (num == 232)
				{
					this.COS.Name = "COS";
					num = 233;
				}
				if (num == 231)
				{
					this.COS.Margin = new global::System.Windows.Forms.Padding(1);
					num = 232;
				}
				if (num == 230)
				{
					this.COS.Location = new global::System.Drawing.Point(1, 505);
					num = 231;
				}
				if (num == 229)
				{
					this.COS.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 230;
				}
				if (num == 228)
				{
					this.COS.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("COS.Image");
					num = 229;
				}
				if (num == 227)
				{
					this.COS.ForeColor = global::System.Drawing.Color.White;
					num = 228;
				}
				if (num == 226)
				{
					this.COS.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 227;
				}
				if (num == 225)
				{
					this.COS.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 226;
				}
				if (num == 224)
				{
					this.COS.FlatAppearance.BorderSize = 0;
					num = 225;
				}
				if (num == 222)
				{
					this.COS.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 223;
				}
				if (num == 221)
				{
					this.g_opt.Click += new global::System.EventHandler(this.button9_Click);
					num = 222;
				}
				if (num == 220)
				{
					this.g_opt.UseVisualStyleBackColor = false;
					num = 221;
				}
				if (num == 219)
				{
					this.g_opt.Text = "Game Optimizations";
					num = 220;
				}
				if (num == 218)
				{
					this.g_opt.TabStop = false;
					num = 219;
				}
				if (num == 217)
				{
					this.g_opt.TabIndex = 6;
					num = 218;
				}
				if (num == 216)
				{
					this.g_opt.Size = new global::System.Drawing.Size(251, 48);
					num = 217;
				}
				if (num == 215)
				{
					this.g_opt.Name = "g_opt";
					num = 216;
				}
				if (num == 214)
				{
					this.g_opt.Margin = new global::System.Windows.Forms.Padding(1);
					num = 215;
				}
				if (num == 213)
				{
					this.g_opt.Location = new global::System.Drawing.Point(1, 410);
					num = 214;
				}
				if (num == 212)
				{
					this.g_opt.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 213;
				}
				if (num == 211)
				{
					this.g_opt.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("g_opt.Image");
					num = 212;
				}
				if (num == 210)
				{
					this.g_opt.ForeColor = global::System.Drawing.Color.White;
					num = 211;
				}
				if (num == 209)
				{
					this.g_opt.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 210;
				}
				if (num == 207)
				{
					this.g_opt.FlatAppearance.BorderSize = 0;
					num = 208;
				}
				if (num == 206)
				{
					this.g_opt.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 207;
				}
				if (num == 205)
				{
					this.g_opt.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 206;
				}
				if (num == 204)
				{
					this.UWP.Click += new global::System.EventHandler(this.button10_Click);
					num = 205;
				}
				if (num == 203)
				{
					this.UWP.UseVisualStyleBackColor = false;
					num = 204;
				}
				if (num == 202)
				{
					this.UWP.Text = "Windows Apps";
					num = 203;
				}
				if (num == 201)
				{
					this.UWP.TabStop = false;
					num = 202;
				}
				if (num == 200)
				{
					this.UWP.TabIndex = 7;
					num = 201;
				}
				if (num == 199)
				{
					this.UWP.Size = new global::System.Drawing.Size(228, 48);
					num = 200;
				}
				if (num == 198)
				{
					this.UWP.Name = "UWP";
					num = 199;
				}
				if (num == 197)
				{
					this.UWP.Margin = new global::System.Windows.Forms.Padding(1);
					num = 198;
				}
				if (num == 196)
				{
					this.UWP.Location = new global::System.Drawing.Point(1, 605);
					num = 197;
				}
				if (num == 195)
				{
					this.UWP.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 196;
				}
				if (num == 194)
				{
					this.UWP.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UWP.Image");
					num = 195;
				}
				if (num == 192)
				{
					this.UWP.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 193;
				}
				if (num == 191)
				{
					this.UWP.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 192;
				}
				if (num == 190)
				{
					this.UWP.FlatAppearance.BorderSize = 0;
					num = 191;
				}
				if (num == 189)
				{
					this.UWP.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 190;
				}
				if (num == 188)
				{
					this.UWP.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 189;
				}
				if (num == 187)
				{
					this.DLs.Click += new global::System.EventHandler(this.button11_Click);
					num = 188;
				}
				if (num == 186)
				{
					this.DLs.UseVisualStyleBackColor = false;
					num = 187;
				}
				if (num == 185)
				{
					this.DLs.Text = "Downloads";
					num = 186;
				}
				if (num == 184)
				{
					this.DLs.TabStop = false;
					num = 185;
				}
				if (num == 183)
				{
					this.DLs.TabIndex = 8;
					num = 184;
				}
				if (num == 182)
				{
					this.DLs.Size = new global::System.Drawing.Size(211, 48);
					num = 183;
				}
				if (num == 181)
				{
					this.DLs.Name = "DLs";
					num = 182;
				}
				if (num == 180)
				{
					this.DLs.Margin = new global::System.Windows.Forms.Padding(1);
					num = 181;
				}
				if (num == 179)
				{
					this.DLs.Location = new global::System.Drawing.Point(1, 655);
					num = 180;
				}
				if (num == 177)
				{
					this.DLs.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DLs.Image");
					num = 178;
				}
				if (num == 176)
				{
					this.DLs.ForeColor = global::System.Drawing.Color.White;
					num = 177;
				}
				if (num == 175)
				{
					this.DLs.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 176;
				}
				if (num == 174)
				{
					this.DLs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 175;
				}
				if (num == 173)
				{
					this.DLs.FlatAppearance.BorderSize = 0;
					num = 174;
				}
				if (num == 172)
				{
					this.DLs.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 173;
				}
				if (num == 171)
				{
					this.DLs.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 172;
				}
				if (num == 170)
				{
					this.opt.Click += new global::System.EventHandler(this.button12_Click);
					num = 171;
				}
				if (num == 169)
				{
					this.opt.UseVisualStyleBackColor = false;
					num = 170;
				}
				if (num == 168)
				{
					this.opt.Text = "Expert Tweaks";
					num = 169;
				}
				if (num == 167)
				{
					this.opt.TabStop = false;
					num = 168;
				}
				if (num == 166)
				{
					this.opt.TabIndex = 9;
					num = 167;
				}
				if (num == 165)
				{
					this.opt.Size = new global::System.Drawing.Size(228, 48);
					num = 166;
				}
				if (num == 164)
				{
					this.opt.Name = "opt";
					num = 165;
				}
				if (num == 162)
				{
					this.opt.Location = new global::System.Drawing.Point(0, 310);
					num = 163;
				}
				if (num == 161)
				{
					this.opt.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 162;
				}
				if (num == 160)
				{
					this.opt.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("opt.Image");
					num = 161;
				}
				if (num == 159)
				{
					this.opt.ForeColor = global::System.Drawing.Color.White;
					num = 160;
				}
				if (num == 158)
				{
					this.opt.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 159;
				}
				if (num == 157)
				{
					this.opt.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 158;
				}
				if (num == 156)
				{
					this.opt.FlatAppearance.BorderSize = 0;
					num = 157;
				}
				if (num == 155)
				{
					this.opt.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 156;
				}
				if (num == 154)
				{
					this.opt.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 155;
				}
				if (num == 153)
				{
					this.home.Click += new global::System.EventHandler(this.button3_Click);
					num = 154;
				}
				if (num == 152)
				{
					this.home.UseVisualStyleBackColor = false;
					num = 153;
				}
				if (num == 151)
				{
					this.home.Text = "Home";
					num = 152;
				}
				if (num == 150)
				{
					this.home.TabStop = false;
					num = 151;
				}
				if (num == 149)
				{
					this.home.TabIndex = 4;
					num = 150;
				}
				if (num == 147)
				{
					this.home.Name = "home";
					num = 148;
				}
				if (num == 146)
				{
					this.home.Margin = new global::System.Windows.Forms.Padding(1);
					num = 147;
				}
				if (num == 145)
				{
					this.home.Location = new global::System.Drawing.Point(3, 110);
					num = 146;
				}
				if (num == 144)
				{
					this.home.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 145;
				}
				if (num == 143)
				{
					this.home.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("home.Image");
					num = 144;
				}
				if (num == 142)
				{
					this.home.ForeColor = global::System.Drawing.Color.White;
					num = 143;
				}
				if (num == 141)
				{
					this.home.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 142;
				}
				if (num == 140)
				{
					this.home.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 141;
				}
				if (num == 139)
				{
					this.home.FlatAppearance.BorderSize = 0;
					num = 140;
				}
				if (num == 138)
				{
					this.home.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 139;
				}
				if (num == 137)
				{
					this.home.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
					num = 138;
				}
				if (num == 136)
				{
					this.home.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 137;
				}
				if (num == 135)
				{
					this.cleanup.Click += new global::System.EventHandler(this.button4_Click);
					num = 136;
				}
				if (num == 134)
				{
					this.cleanup.UseVisualStyleBackColor = false;
					num = 135;
				}
				if (num == 132)
				{
					this.cleanup.TabStop = false;
					num = 133;
				}
				if (num == 131)
				{
					this.cleanup.TabIndex = 5;
					num = 132;
				}
				if (num == 130)
				{
					this.cleanup.Size = new global::System.Drawing.Size(220, 48);
					num = 131;
				}
				if (num == 129)
				{
					this.cleanup.Name = "cleanup";
					num = 130;
				}
				if (num == 128)
				{
					this.cleanup.Margin = new global::System.Windows.Forms.Padding(1);
					num = 129;
				}
				if (num == 127)
				{
					this.cleanup.Location = new global::System.Drawing.Point(0, 210);
					num = 128;
				}
				if (num == 126)
				{
					this.cleanup.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 127;
				}
				if (num == 125)
				{
					this.cleanup.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cleanup.Image");
					num = 126;
				}
				if (num == 124)
				{
					this.cleanup.ForeColor = global::System.Drawing.Color.White;
					num = 125;
				}
				if (num == 123)
				{
					this.cleanup.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 124;
				}
				if (num == 122)
				{
					this.cleanup.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 123;
				}
				if (num == 121)
				{
					this.cleanup.FlatAppearance.BorderSize = 0;
					num = 122;
				}
				if (num == 120)
				{
					this.cleanup.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 121;
				}
				if (num == 118)
				{
					this.sys_info.Click += new global::System.EventHandler(this.button13_Click);
					num = 119;
				}
				if (num == 117)
				{
					this.sys_info.UseVisualStyleBackColor = false;
					num = 118;
				}
				if (num == 116)
				{
					this.sys_info.Text = "System Info";
					num = 117;
				}
				if (num == 115)
				{
					this.sys_info.TabStop = false;
					num = 116;
				}
				if (num == 114)
				{
					this.sys_info.TabIndex = 10;
					num = 115;
				}
				if (num == 113)
				{
					this.sys_info.Size = new global::System.Drawing.Size(220, 48);
					num = 114;
				}
				if (num == 112)
				{
					this.sys_info.Name = "sys_info";
					num = 113;
				}
				if (num == 111)
				{
					this.sys_info.Margin = new global::System.Windows.Forms.Padding(1);
					num = 112;
				}
				if (num == 110)
				{
					this.sys_info.Location = new global::System.Drawing.Point(0, 160);
					num = 111;
				}
				if (num == 109)
				{
					this.sys_info.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 110;
				}
				if (num == 108)
				{
					this.sys_info.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("sys_info.Image");
					num = 109;
				}
				if (num == 107)
				{
					this.sys_info.ForeColor = global::System.Drawing.Color.White;
					num = 108;
				}
				if (num == 106)
				{
					this.sys_info.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
					num = 107;
				}
				if (num == 105)
				{
					this.sys_info.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 106;
				}
				if (num == 103)
				{
					this.sys_info.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 104;
				}
				if (num == 102)
				{
					this.sys_info.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 103;
				}
				if (num == 101)
				{
					this.game_B.Click += new global::System.EventHandler(this.game_B_Click);
					num = 102;
				}
				if (num == 100)
				{
					this.game_B.UseVisualStyleBackColor = false;
					num = 101;
				}
				if (num == 99)
				{
					this.game_B.Text = "Game Booster";
					num = 100;
				}
				if (num == 98)
				{
					this.game_B.TabStop = false;
					num = 99;
				}
				if (num == 97)
				{
					this.game_B.TabIndex = 28;
					num = 98;
				}
				if (num == 96)
				{
					this.game_B.Size = new global::System.Drawing.Size(226, 48);
					num = 97;
				}
				if (num == 95)
				{
					this.game_B.Name = "game_B";
					num = 96;
				}
				if (num == 94)
				{
					this.game_B.Margin = new global::System.Windows.Forms.Padding(1);
					num = 95;
				}
				if (num == 93)
				{
					this.game_B.Location = new global::System.Drawing.Point(0, 460);
					num = 94;
				}
				if (num == 92)
				{
					this.game_B.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
					num = 93;
				}
				if (num == 91)
				{
					this.game_B.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("game_B.Image");
					num = 92;
				}
				if (num == 90)
				{
					this.game_B.ForeColor = global::System.Drawing.Color.White;
					num = 91;
				}
				if (num == 88)
				{
					this.game_B.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
					num = 89;
				}
				if (num == 87)
				{
					this.game_B.FlatAppearance.BorderSize = 0;
					num = 88;
				}
				if (num == 86)
				{
					this.game_B.Cursor = global::System.Windows.Forms.Cursors.Hand;
					num = 87;
				}
				if (num == 85)
				{
					this.game_B.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
					num = 86;
				}
				if (num == 84)
				{
					this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
					num = 85;
				}
				if (num == 83)
				{
					this.panel1.TabIndex = 0;
					num = 84;
				}
				if (num == 82)
				{
					this.panel1.Size = new global::System.Drawing.Size(209, 720);
					num = 83;
				}
				if (num == 81)
				{
					this.panel1.Name = "panel1";
					num = 82;
				}
				if (num == 80)
				{
					this.panel1.Location = new global::System.Drawing.Point(-5, -1);
					num = 81;
				}
				if (num == 79)
				{
					this.panel1.Controls.Add(this.cb_modifiedlist);
					num = 80;
				}
				if (num == 78)
				{
					this.panel1.Controls.Add(this.cb_workingset);
					num = 79;
				}
				if (num == 77)
				{
					this.panel1.Controls.Add(this.cb_standbylist);
					num = 78;
				}
				if (num == 76)
				{
					this.panel1.Controls.Add(this.pictureBox1);
					num = 77;
				}
				if (num == 75)
				{
					this.panel1.Controls.Add(this.pictureBox6);
					num = 76;
				}
				if (num == 73)
				{
					this.panel1.Controls.Add(this.cb_lowpriostandbylist);
					num = 74;
				}
				if (num == 72)
				{
					this.panel1.Controls.Add(this.context);
					num = 73;
				}
				if (num == 71)
				{
					this.panel1.Controls.Add(this.tweaks);
					num = 72;
				}
				if (num == 70)
				{
					this.panel1.Controls.Add(this.g_tweaks);
					num = 71;
				}
				if (num == 69)
				{
					this.panel1.Controls.Add(this.COS);
					num = 70;
				}
				if (num == 68)
				{
					this.panel1.Controls.Add(this.g_opt);
					num = 69;
				}
				if (num == 67)
				{
					this.panel1.Controls.Add(this.UWP);
					num = 68;
				}
				if (num == 66)
				{
					this.panel1.Controls.Add(this.DLs);
					num = 67;
				}
				if (num == 65)
				{
					this.panel1.Controls.Add(this.opt);
					num = 66;
				}
				if (num == 64)
				{
					this.panel1.Controls.Add(this.home);
					num = 65;
				}
				if (num == 63)
				{
					this.panel1.Controls.Add(this.cleanup);
					num = 64;
				}
				if (num == 62)
				{
					this.panel1.Controls.Add(this.sys_info);
					num = 63;
				}
				if (num == 61)
				{
					this.panel1.Controls.Add(this.game_B);
					num = 62;
				}
				if (num == 60)
				{
					base.SuspendLayout();
					num = 61;
				}
				if (num == 58)
				{
					this.panel3.SuspendLayout();
					num = 59;
				}
				if (num == 57)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
					num = 58;
				}
				if (num == 56)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
					num = 57;
				}
				if (num == 55)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
					num = 56;
				}
				if (num == 54)
				{
					this.panel2.SuspendLayout();
					num = 55;
				}
				if (num == 53)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
					num = 54;
				}
				if (num == 52)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
					num = 53;
				}
				if (num == 51)
				{
					((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
					num = 52;
				}
				if (num == 50)
				{
					this.panel1.SuspendLayout();
					num = 51;
				}
				if (num == 49)
				{
					this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
					num = 50;
				}
				if (num == 48)
				{
					this.cleanMemoryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
					num = 49;
				}
				if (num == 47)
				{
					this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
					num = 48;
				}
				if (num == 46)
				{
					this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
					num = 47;
				}
				if (num == 45)
				{
					this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
					num = 46;
				}
				if (num == 43)
				{
					this.siticoneControlBox1 = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
					num = 44;
				}
				if (num == 42)
				{
					this.siticoneButton1 = new global::Siticone.Desktop.UI.WinForms.SiticoneButton();
					num = 43;
				}
				if (num == 41)
				{
					this.minimize = new global::Siticone.Desktop.UI.WinForms.SiticoneControlBox();
					num = 42;
				}
				if (num == 40)
				{
					this.panel3 = new global::System.Windows.Forms.Panel();
					num = 41;
				}
				if (num == 39)
				{
					this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
					num = 40;
				}
				if (num == 38)
				{
					this.label2 = new global::System.Windows.Forms.Label();
					num = 39;
				}
				if (num == 37)
				{
					this.label3 = new global::System.Windows.Forms.Label();
					num = 38;
				}
				if (num == 36)
				{
					this.label4 = new global::System.Windows.Forms.Label();
					num = 37;
				}
				if (num == 35)
				{
					this.label5 = new global::System.Windows.Forms.Label();
					num = 36;
				}
				if (num == 34)
				{
					this.label6 = new global::System.Windows.Forms.Label();
					num = 35;
				}
				if (num == 33)
				{
					this.label7 = new global::System.Windows.Forms.Label();
					num = 34;
				}
				if (num == 32)
				{
					this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
					num = 33;
				}
				if (num == 31)
				{
					this.label8 = new global::System.Windows.Forms.Label();
					num = 32;
				}
				if (num == 30)
				{
					this.label10 = new global::System.Windows.Forms.Label();
					num = 31;
				}
				if (num == 28)
				{
					this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
					num = 29;
				}
				if (num == 27)
				{
					this.label12 = new global::System.Windows.Forms.Label();
					num = 28;
				}
				if (num == 26)
				{
					this.label13 = new global::System.Windows.Forms.Label();
					num = 27;
				}
				if (num == 25)
				{
					this.label16 = new global::System.Windows.Forms.Label();
					num = 26;
				}
				if (num == 24)
				{
					this.panel2 = new global::System.Windows.Forms.Panel();
					num = 25;
				}
				if (num == 23)
				{
					this.label1 = new global::System.Windows.Forms.Label();
					num = 24;
				}
				if (num == 22)
				{
					this.cb_modifiedlist = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
					num = 23;
				}
				if (num == 21)
				{
					this.cb_workingset = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
					num = 22;
				}
				if (num == 20)
				{
					this.cb_standbylist = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
					num = 21;
				}
				if (num == 19)
				{
					this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
					num = 20;
				}
				if (num == 18)
				{
					this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
					num = 19;
				}
				if (num == 17)
				{
					this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
					num = 18;
				}
				if (num == 16)
				{
					this.cb_lowpriostandbylist = new global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
					num = 17;
				}
				if (num == 15)
				{
					this.context = new global::System.Windows.Forms.Button();
					num = 16;
				}
				if (num == 13)
				{
					this.g_tweaks = new global::System.Windows.Forms.Button();
					num = 14;
				}
				if (num == 12)
				{
					this.COS = new global::System.Windows.Forms.Button();
					num = 13;
				}
				if (num == 11)
				{
					this.g_opt = new global::System.Windows.Forms.Button();
					num = 12;
				}
				if (num == 10)
				{
					this.UWP = new global::System.Windows.Forms.Button();
					num = 11;
				}
				if (num == 9)
				{
					this.DLs = new global::System.Windows.Forms.Button();
					num = 10;
				}
				if (num == 8)
				{
					this.opt = new global::System.Windows.Forms.Button();
					num = 9;
				}
				if (num == 7)
				{
					this.home = new global::System.Windows.Forms.Button();
					num = 8;
				}
				if (num == 6)
				{
					this.cleanup = new global::System.Windows.Forms.Button();
					num = 7;
				}
				if (num == 5)
				{
					this.sys_info = new global::System.Windows.Forms.Button();
					num = 6;
				}
				if (num == 4)
				{
					this.game_B = new global::System.Windows.Forms.Button();
					num = 5;
				}
				if (num == 3)
				{
					this.panel1 = new global::System.Windows.Forms.Panel();
					num = 4;
				}
				if (num == 2)
				{
					componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.main));
					num = 3;
				}
				if (num == 1)
				{
					this.components = new global::System.ComponentModel.Container();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 645);
		}

		// Token: 0x04000035 RID: 53
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button home;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button context;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Button COS;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button g_tweaks;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button tweaks;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button cleanup;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button g_opt;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Button UWP;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button DLs;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button opt;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button sys_info;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000055 RID: 85
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000056 RID: 86
		private global::Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;

		// Token: 0x04000057 RID: 87
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox minimize_tray;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripMenuItem cleanMemoryToolStripMenuItem;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x0400005D RID: 93
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox cb_lowpriostandbylist;

		// Token: 0x0400005E RID: 94
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox cb_workingset;

		// Token: 0x0400005F RID: 95
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox cb_modifiedlist;

		// Token: 0x04000060 RID: 96
		private global::Siticone.Desktop.UI.WinForms.SiticoneCheckBox cb_standbylist;

		// Token: 0x04000061 RID: 97
		private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox minimize;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Button game_B;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.PictureBox pictureBox6;
	}
}
