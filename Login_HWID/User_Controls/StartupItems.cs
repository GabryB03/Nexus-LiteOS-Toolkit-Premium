using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200006A RID: 106
	public class StartupItems : UserControl
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00172BA0 File Offset: 0x00170DA0
		public static StartupItems Instance
		{
			get
			{
				if (StartupItems._instace == null)
				{
					StartupItems._instace = new StartupItems();
				}
				return StartupItems._instace;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00172BC8 File Offset: 0x00170DC8
		public StartupItems()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00172C28 File Offset: 0x00170E28
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				object obj;
				if (num == 4)
				{
					object obj2;
					obj = obj2;
					num = 5;
				}
				if (num != 8)
				{
					goto IL_34;
				}
				string text;
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_34;
				}
				goto IL_87;
				IL_99:
				if (num == 11)
				{
					goto IL_EC;
				}
				IL_FE:
				if (num == 10)
				{
					break;
				}
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_111;
					}
					num = 10;
				}
				if (num == 7)
				{
					if (text == "Xmas")
					{
						goto IL_EC;
					}
					num = 8;
				}
				if (num == 6)
				{
					if (text == null)
					{
						break;
					}
					num = 7;
				}
				if (num == 5)
				{
					text = obj as string;
					num = 6;
				}
				if (num == 3)
				{
					object value;
					object obj2 = value;
					num = 4;
				}
				if (num == 2)
				{
					RegistryKey registryKey;
					object value = registryKey.GetValue("Theme");
					num = 3;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					break;
				}
				continue;
				IL_EC:
				this.Xmas_theme();
				num = 12;
				goto IL_FE;
				IL_123:
				if (num == 14)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_87;
				}
				goto IL_99;
				IL_34:
				if (num == 12 || num == 16 || num == 17)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_111;
				}
				goto IL_123;
				IL_87:
				this.Halloween();
				num = 14;
				goto IL_99;
				IL_111:
				this.AccentColor();
				num = 16;
				goto IL_123;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00172E74 File Offset: 0x00171074
		private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					if (e.Category == UserPreferenceCategory.General)
					{
						goto IL_58;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			bool flag = e.Category == UserPreferenceCategory.VisualStyle;
			goto IL_5D;
			IL_58:
			flag = true;
			IL_5D:
			if (flag)
			{
				this.LoadTheme();
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00172EEC File Offset: 0x001710EC
		private void Form_Disposed(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					SystemEvents.UserPreferenceChanged -= this.UserPreferenceChanged;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00172F50 File Offset: 0x00171150
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.delete.FillColor = Color.FromArgb(255, 128, 0);
					num = 4;
				}
				if (num == 2)
				{
					this.refresh.FillColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.open_file.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00173020 File Offset: 0x00171220
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 4)
				{
					this.delete.FillColor = accentColor;
					num = 5;
				}
				if (num == 3)
				{
					this.refresh.FillColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.open_file.FillColor = accentColor;
					num = 3;
				}
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00173100 File Offset: 0x00171300
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.delete.FillColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 2)
				{
					this.refresh.FillColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.open_file.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x001731D0 File Offset: 0x001713D0
		private void GetStartupItems()
		{
			int num = 0;
			for (;;)
			{
				int num2;
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				ListViewItem listViewItem;
				if (num == 8)
				{
					listViewItem.SubItems.Add(this._startUpItems[num2].ToString());
					num = 9;
				}
				if (num != 12)
				{
					goto IL_4E;
				}
				bool flag;
				if (!flag)
				{
					num = 13;
					goto IL_4E;
				}
				goto IL_C0;
				IL_E0:
				if (num == 5)
				{
					goto IL_EA;
				}
				if (num == 3)
				{
					num = 4;
				}
				if (num == 2)
				{
					this.listStartupItems.Items.Clear();
					num = 3;
				}
				if (num == 1)
				{
					this._startUpItems = StartupHelper.GetStartupItems();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 13)
				{
					continue;
				}
				break;
				IL_102:
				if (num == 10)
				{
					num2++;
					num = 11;
				}
				if (num == 9)
				{
					this.listStartupItems.Items.Add(listViewItem);
					num = 10;
				}
				if (num == 7)
				{
					listViewItem.SubItems.Add(this._startUpItems[num2].FileLocation);
					num = 8;
				}
				if (num == 6)
				{
					goto IL_C0;
				}
				goto IL_E0;
				IL_4E:
				if (num == 11)
				{
					goto IL_EA;
				}
				goto IL_102;
				IL_C0:
				listViewItem = new ListViewItem(this._startUpItems[num2].Name);
				num = 7;
				goto IL_E0;
				IL_EA:
				flag = num2 < this._startUpItems.Count;
				num = 12;
				goto IL_102;
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00173388 File Offset: 0x00171588
		private void startup_item_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.GetStartupItems();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x001733E4 File Offset: 0x001715E4
		private void delete_Click(object sender, EventArgs e)
		{
			int num = 0;
			IEnumerator enumerator;
			string text;
			for (;;)
			{
				if (num == 4)
				{
					goto IL_25;
				}
				IL_31:
				if (num == 5)
				{
					enumerator = this.listStartupItems.CheckedItems.GetEnumerator();
					num = 6;
				}
				if (num == 3)
				{
					return;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_25;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = this.listStartupItems.CheckedItems.Count <= 0;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 6)
				{
					continue;
				}
				break;
				IL_25:
				text = string.Empty;
				num = 5;
				goto IL_31;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + listViewItem.Text + Environment.NewLine;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			foreach (object obj2 in this.listStartupItems.CheckedIndices)
			{
				int num2 = (int)obj2;
				this._startUpItems[num2].Remove();
			}
			this.GetStartupItems();
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00173570 File Offset: 0x00171770
		private void open_file_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this._startUpItems[this.listStartupItems.SelectedIndices[0]].LocateFile();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						break;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = this.listStartupItems.SelectedItems.Count == 1;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00173388 File Offset: 0x00171588
		private void refresh_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.GetStartupItems();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00018F88 File Offset: 0x00017188
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

		// Token: 0x0600098E RID: 2446 RVA: 0x00173624 File Offset: 0x00171824
		private void next_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					Hosts.Instance.Show();
					num = 5;
				}
				if (num == 3)
				{
					Hosts.Instance.BringToFront();
					num = 4;
				}
				if (num == 2)
				{
					Hosts.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 1)
				{
					base.Controls.Add(Hosts.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x001736D0 File Offset: 0x001718D0
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

		// Token: 0x06000990 RID: 2448 RVA: 0x00173748 File Offset: 0x00171948
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.header1 = new ColumnHeader();
					num = 5;
				}
				if (num == 8)
				{
					this.open_file = new SiticoneButton();
					num = 9;
				}
				if (num == 12)
				{
					base.SuspendLayout();
					num = 13;
				}
				if (num == 16)
				{
					this.label37.Location = new Point(23, 53);
					num = 17;
				}
				if (num == 20)
				{
					this.label37.Text = "Manage Startup Items";
					num = 21;
				}
				if (num == 24)
				{
					this.label1.Location = new Point(18, 0);
					num = 25;
				}
				if (num == 28)
				{
					this.label1.Text = "Expert Tweaks";
					num = 29;
				}
				if (num == 32)
				{
					this.listStartupItems.Columns.AddRange(new ColumnHeader[] { this.header1, this.Location });
					num = 33;
				}
				if (num == 36)
				{
					this.listStartupItems.HideSelection = false;
					num = 37;
				}
				if (num == 40)
				{
					this.listStartupItems.Name = "listStartupItems";
					num = 41;
				}
				if (num == 44)
				{
					this.listStartupItems.UseCompatibleStateImageBehavior = false;
					num = 45;
				}
				if (num == 48)
				{
					this.Location.Text = "Location";
					num = 49;
				}
				if (num == 53)
				{
					this.delete.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 54;
				}
				if (num == 57)
				{
					this.delete.FillColor = Color.DodgerBlue;
					num = 58;
				}
				if (num == 61)
				{
					this.delete.ImageSize = new Size(30, 30);
					num = 62;
				}
				if (num == 65)
				{
					this.delete.Size = new Size(139, 38);
					num = 66;
				}
				if (num == 69)
				{
					this.refresh.CheckedState.Parent = this.refresh;
					num = 70;
				}
				if (num == 73)
				{
					this.refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 74;
				}
				if (num == 77)
				{
					this.refresh.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 78;
				}
				if (num == 81)
				{
					this.refresh.Location = new Point(707, 617);
					num = 82;
				}
				if (num == 85)
				{
					this.refresh.TabIndex = 314;
					num = 86;
				}
				if (num == 89)
				{
					this.open_file.CustomImages.Parent = this.open_file;
					num = 90;
				}
				if (num == 93)
				{
					this.open_file.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 94;
				}
				if (num == 97)
				{
					this.open_file.ForeColor = Color.White;
					num = 98;
				}
				if (num == 102)
				{
					this.open_file.ShadowDecoration.Parent = this.open_file;
					num = 103;
				}
				if (num == 106)
				{
					this.open_file.Click += this.open_file_Click;
					num = 107;
				}
				if (num == 110)
				{
					this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
					num = 111;
				}
				if (num == 114)
				{
					this.siticoneRoundedButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 115;
				}
				if (num == 118)
				{
					this.siticoneRoundedButton1.ForeColor = Color.White;
					num = 119;
				}
				if (num == 122)
				{
					this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
					num = 123;
				}
				if (num == 126)
				{
					this.siticoneRoundedButton1.Click += this.siticoneRoundedButton1_Click;
					num = 127;
				}
				if (num == 130)
				{
					this.next_btn.CustomImages.Parent = this.next_btn;
					num = 131;
				}
				if (num == 134)
				{
					this.next_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 135;
				}
				if (num == 138)
				{
					this.next_btn.ForeColor = Color.White;
					num = 139;
				}
				if (num == 142)
				{
					this.next_btn.ShadowDecoration.Parent = this.next_btn;
					num = 143;
				}
				if (num == 146)
				{
					this.next_btn.Click += this.next_btn_Click;
					num = 147;
				}
				if (num == 151)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 152;
				}
				if (num == 155)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 156;
				}
				if (num == 159)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 160;
				}
				if (num == 163)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 164;
				}
				if (num == 167)
				{
					base.Controls.Add(this.open_file);
					num = 168;
				}
				if (num == 171)
				{
					base.Controls.Add(this.label37);
					num = 172;
				}
				if (num == 175)
				{
					base.Load += this.startup_item_Load;
					num = 176;
				}
				if (num == 177)
				{
					base.PerformLayout();
					num = 178;
				}
				if (num == 176)
				{
					base.ResumeLayout(false);
					num = 177;
				}
				if (num == 174)
				{
					base.Size = new Size(1006, 669);
					num = 175;
				}
				if (num == 173)
				{
					base.Name = "startup_item";
					num = 174;
				}
				if (num == 172)
				{
					base.Controls.Add(this.label1);
					num = 173;
				}
				if (num == 170)
				{
					base.Controls.Add(this.listStartupItems);
					num = 171;
				}
				if (num == 169)
				{
					base.Controls.Add(this.refresh);
					num = 170;
				}
				if (num == 168)
				{
					base.Controls.Add(this.delete);
					num = 169;
				}
				if (num == 166)
				{
					base.Controls.Add(this.next_btn);
					num = 167;
				}
				if (num == 165)
				{
					base.Controls.Add(this.siticoneRoundedButton1);
					num = 166;
				}
				if (num == 164)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 165;
				}
				if (num == 162)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 163;
				}
				if (num == 161)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 162;
				}
				if (num == 160)
				{
					this.siticoneVScrollBar1.ThumbSize = 503f;
					num = 161;
				}
				if (num == 158)
				{
					this.siticoneVScrollBar1.TabIndex = 338;
					num = 159;
				}
				if (num == 157)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 498);
					num = 158;
				}
				if (num == 156)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 157;
				}
				if (num == 154)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 155;
				}
				if (num == 153)
				{
					this.siticoneVScrollBar1.Location = new Point(973, 103);
					num = 154;
				}
				if (num == 152)
				{
					this.siticoneVScrollBar1.LargeChange = 100;
					num = 153;
				}
				if (num == 150)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 151;
				}
				if (num == 149)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 150;
				}
				if (num == 148)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 149;
				}
				if (num == 147)
				{
					this.siticoneVScrollBar1.BindingContainer = this.listStartupItems;
					num = 148;
				}
				if (num == 145)
				{
					this.next_btn.Text = "Next";
					num = 146;
				}
				if (num == 144)
				{
					this.next_btn.TabIndex = 334;
					num = 145;
				}
				if (num == 143)
				{
					this.next_btn.Size = new Size(88, 30);
					num = 144;
				}
				if (num == 141)
				{
					this.next_btn.Name = "next_btn";
					num = 142;
				}
				if (num == 140)
				{
					this.next_btn.Location = new Point(876, 53);
					num = 141;
				}
				if (num == 139)
				{
					this.next_btn.HoverState.Parent = this.next_btn;
					num = 140;
				}
				if (num == 137)
				{
					this.next_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 138;
				}
				if (num == 136)
				{
					this.next_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 137;
				}
				if (num == 135)
				{
					this.next_btn.DisabledState.Parent = this.next_btn;
					num = 136;
				}
				if (num == 133)
				{
					this.next_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 134;
				}
				if (num == 132)
				{
					this.next_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 133;
				}
				if (num == 131)
				{
					this.next_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 132;
				}
				if (num == 129)
				{
					this.next_btn.CheckedState.Parent = this.next_btn;
					num = 130;
				}
				if (num == 128)
				{
					this.next_btn.BorderRadius = 14;
					num = 129;
				}
				if (num == 127)
				{
					this.next_btn.BackColor = Color.Transparent;
					num = 128;
				}
				if (num == 125)
				{
					this.siticoneRoundedButton1.Text = "Back";
					num = 126;
				}
				if (num == 124)
				{
					this.siticoneRoundedButton1.TabIndex = 335;
					num = 125;
				}
				if (num == 123)
				{
					this.siticoneRoundedButton1.Size = new Size(88, 30);
					num = 124;
				}
				if (num == 121)
				{
					this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
					num = 122;
				}
				if (num == 120)
				{
					this.siticoneRoundedButton1.Location = new Point(782, 53);
					num = 121;
				}
				if (num == 119)
				{
					this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
					num = 120;
				}
				if (num == 117)
				{
					this.siticoneRoundedButton1.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 118;
				}
				if (num == 116)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 117;
				}
				if (num == 115)
				{
					this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
					num = 116;
				}
				if (num == 113)
				{
					this.siticoneRoundedButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 114;
				}
				if (num == 112)
				{
					this.siticoneRoundedButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 113;
				}
				if (num == 111)
				{
					this.siticoneRoundedButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 112;
				}
				if (num == 109)
				{
					this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
					num = 110;
				}
				if (num == 108)
				{
					this.siticoneRoundedButton1.BorderRadius = 14;
					num = 109;
				}
				if (num == 107)
				{
					this.siticoneRoundedButton1.BackColor = Color.Transparent;
					num = 108;
				}
				if (num == 105)
				{
					this.open_file.Text = "Open File Location";
					num = 106;
				}
				if (num == 104)
				{
					this.open_file.TabIndex = 316;
					num = 105;
				}
				if (num == 103)
				{
					this.open_file.Size = new Size(186, 38);
					num = 104;
				}
				if (num == 101)
				{
					this.open_file.Name = "open_file";
					num = 102;
				}
				if (num == 100)
				{
					this.open_file.Location = new Point(515, 617);
					num = 101;
				}
				if (num == 99)
				{
					this.open_file.ImageSize = new Size(30, 30);
					num = 100;
				}
				if (num == 98)
				{
					this.open_file.HoverState.Parent = this.open_file;
					num = 99;
				}
				if (num == 96)
				{
					this.open_file.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 97;
				}
				if (num == 95)
				{
					this.open_file.FillColor = Color.DodgerBlue;
					num = 96;
				}
				if (num == 94)
				{
					this.open_file.DisabledState.Parent = this.open_file;
					num = 95;
				}
				if (num == 92)
				{
					this.open_file.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 93;
				}
				if (num == 91)
				{
					this.open_file.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 92;
				}
				if (num == 90)
				{
					this.open_file.DisabledState.BorderColor = Color.DarkGray;
					num = 91;
				}
				if (num == 88)
				{
					this.open_file.CheckedState.Parent = this.open_file;
					num = 89;
				}
				if (num == 87)
				{
					this.refresh.Click += this.refresh_Click;
					num = 88;
				}
				if (num == 86)
				{
					this.refresh.Text = "Refresh";
					num = 87;
				}
				if (num == 84)
				{
					this.refresh.Size = new Size(139, 38);
					num = 85;
				}
				if (num == 83)
				{
					this.refresh.ShadowDecoration.Parent = this.refresh;
					num = 84;
				}
				if (num == 82)
				{
					this.refresh.Name = "refresh";
					num = 83;
				}
				if (num == 80)
				{
					this.refresh.ImageSize = new Size(30, 30);
					num = 81;
				}
				if (num == 79)
				{
					this.refresh.HoverState.Parent = this.refresh;
					num = 80;
				}
				if (num == 78)
				{
					this.refresh.ForeColor = Color.White;
					num = 79;
				}
				if (num == 76)
				{
					this.refresh.FillColor = Color.DodgerBlue;
					num = 77;
				}
				if (num == 75)
				{
					this.refresh.DisabledState.Parent = this.refresh;
					num = 76;
				}
				if (num == 74)
				{
					this.refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 75;
				}
				if (num == 72)
				{
					this.refresh.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 73;
				}
				if (num == 71)
				{
					this.refresh.DisabledState.BorderColor = Color.DarkGray;
					num = 72;
				}
				if (num == 70)
				{
					this.refresh.CustomImages.Parent = this.refresh;
					num = 71;
				}
				if (num == 68)
				{
					this.delete.Click += this.delete_Click;
					num = 69;
				}
				if (num == 67)
				{
					this.delete.Text = "Delete";
					num = 68;
				}
				if (num == 66)
				{
					this.delete.TabIndex = 315;
					num = 67;
				}
				if (num == 64)
				{
					this.delete.ShadowDecoration.Parent = this.delete;
					num = 65;
				}
				if (num == 63)
				{
					this.delete.Name = "delete";
					num = 64;
				}
				if (num == 62)
				{
					this.delete.Location = new Point(852, 617);
					num = 63;
				}
				if (num == 60)
				{
					this.delete.HoverState.Parent = this.delete;
					num = 61;
				}
				if (num == 59)
				{
					this.delete.ForeColor = Color.White;
					num = 60;
				}
				if (num == 58)
				{
					this.delete.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 59;
				}
				if (num == 56)
				{
					this.delete.DisabledState.Parent = this.delete;
					num = 57;
				}
				if (num == 55)
				{
					this.delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 56;
				}
				if (num == 54)
				{
					this.delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 55;
				}
				if (num == 52)
				{
					this.delete.DisabledState.BorderColor = Color.DarkGray;
					num = 53;
				}
				if (num == 51)
				{
					this.delete.CustomImages.Parent = this.delete;
					num = 52;
				}
				if (num == 50)
				{
					this.delete.CheckedState.Parent = this.delete;
					num = 51;
				}
				if (num == 49)
				{
					this.Location.Width = 700;
					num = 50;
				}
				if (num == 47)
				{
					this.header1.Width = 200;
					num = 48;
				}
				if (num == 46)
				{
					this.header1.Text = "Name";
					num = 47;
				}
				if (num == 45)
				{
					this.listStartupItems.View = View.Details;
					num = 46;
				}
				if (num == 43)
				{
					this.listStartupItems.TabIndex = 0;
					num = 44;
				}
				if (num == 42)
				{
					this.listStartupItems.Size = new Size(979, 498);
					num = 43;
				}
				if (num == 41)
				{
					this.listStartupItems.ShowGroups = false;
					num = 42;
				}
				if (num == 39)
				{
					this.listStartupItems.MultiSelect = false;
					num = 40;
				}
				if (num == 38)
				{
					this.listStartupItems.Margin = new Padding(2);
					num = 39;
				}
				if (num == 37)
				{
					this.listStartupItems.Location = new Point(12, 103);
					num = 38;
				}
				if (num == 35)
				{
					this.listStartupItems.FullRowSelect = true;
					num = 36;
				}
				if (num == 34)
				{
					this.listStartupItems.ForeColor = Color.White;
					num = 35;
				}
				if (num == 33)
				{
					this.listStartupItems.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 34;
				}
				if (num == 31)
				{
					this.listStartupItems.CheckBoxes = true;
					num = 32;
				}
				if (num == 30)
				{
					this.listStartupItems.BorderStyle = BorderStyle.None;
					num = 31;
				}
				if (num == 29)
				{
					this.listStartupItems.BackColor = Color.FromArgb(38, 38, 38);
					num = 30;
				}
				if (num == 27)
				{
					this.label1.TabIndex = 120;
					num = 28;
				}
				if (num == 26)
				{
					this.label1.Size = new Size(248, 53);
					num = 27;
				}
				if (num == 25)
				{
					this.label1.Name = "label1";
					num = 26;
				}
				if (num == 23)
				{
					this.label1.ForeColor = Color.White;
					num = 24;
				}
				if (num == 22)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 23;
				}
				if (num == 21)
				{
					this.label1.AutoSize = true;
					num = 22;
				}
				if (num == 19)
				{
					this.label37.TabIndex = 121;
					num = 20;
				}
				if (num == 18)
				{
					this.label37.Size = new Size(132, 19);
					num = 19;
				}
				if (num == 17)
				{
					this.label37.Name = "label37";
					num = 18;
				}
				if (num == 15)
				{
					this.label37.ForeColor = Color.Silver;
					num = 16;
				}
				if (num == 14)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 15;
				}
				if (num == 13)
				{
					this.label37.AutoSize = true;
					num = 14;
				}
				if (num == 11)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 12;
				}
				if (num == 10)
				{
					this.next_btn = new SiticoneRoundedButton();
					num = 11;
				}
				if (num == 9)
				{
					this.siticoneRoundedButton1 = new SiticoneRoundedButton();
					num = 10;
				}
				if (num == 7)
				{
					this.refresh = new SiticoneButton();
					num = 8;
				}
				if (num == 6)
				{
					this.delete = new SiticoneButton();
					num = 7;
				}
				if (num == 5)
				{
					this.Location = new ColumnHeader();
					num = 6;
				}
				if (num == 3)
				{
					this.listStartupItems = new ListView();
					num = 4;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					this.label37 = new Label();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 178);
		}

		// Token: 0x04000935 RID: 2357
		private List<StartupItem> _startUpItems = new List<StartupItem>();

		// Token: 0x04000936 RID: 2358
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000937 RID: 2359
		private static StartupItems _instace;

		// Token: 0x04000938 RID: 2360
		private IContainer components = null;

		// Token: 0x04000939 RID: 2361
		private Label label37;

		// Token: 0x0400093A RID: 2362
		private Label label1;

		// Token: 0x0400093B RID: 2363
		private ListView listStartupItems;

		// Token: 0x0400093C RID: 2364
		private ColumnHeader header1;

		// Token: 0x0400093D RID: 2365
		private new ColumnHeader Location;

		// Token: 0x0400093E RID: 2366
		private SiticoneButton delete;

		// Token: 0x0400093F RID: 2367
		private SiticoneButton refresh;

		// Token: 0x04000940 RID: 2368
		private SiticoneButton open_file;

		// Token: 0x04000941 RID: 2369
		private SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000942 RID: 2370
		private SiticoneRoundedButton next_btn;

		// Token: 0x04000943 RID: 2371
		private SiticoneVScrollBar siticoneVScrollBar1;
	}
}
