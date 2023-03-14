using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Win32;
using Optimizer;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000056 RID: 86
	public class Debloat : UserControl
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000A1D74 File Offset: 0x0009FF74
		public static Debloat Instance
		{
			get
			{
				if (Debloat._instace == null)
				{
					Debloat._instace = new Debloat();
				}
				return Debloat._instace;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000A1D9C File Offset: 0x0009FF9C
		public Debloat()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000A1E14 File Offset: 0x000A0014
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				object value;
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("Theme");
					num = 3;
				}
				string text;
				if (num == 5)
				{
					object obj;
					text = obj as string;
					num = 6;
				}
				if (num != 8)
				{
					goto IL_5A;
				}
				if (!(text == "Halloween"))
				{
					num = 9;
					goto IL_5A;
				}
				goto IL_F1;
				IL_A0:
				if (num == 12 || num == 10)
				{
					break;
				}
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_DD;
					}
					num = 10;
				}
				if (num == 7)
				{
					if (text == "Xmas")
					{
						goto IL_13B;
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
				if (num == 4)
				{
					object obj2;
					object obj = obj2;
					num = 5;
				}
				if (num == 3)
				{
					object obj2 = value;
					num = 4;
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
				IL_F1:
				this.Halloween();
				num = 14;
				goto IL_A0;
				IL_105:
				if (num == 13)
				{
					goto IL_F1;
				}
				goto IL_A0;
				IL_DD:
				this.AccentColor();
				num = 16;
				goto IL_105;
				IL_14D:
				if (num == 14)
				{
					break;
				}
				if (num == 17 || num == 16)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_DD;
				}
				goto IL_105;
				IL_13B:
				this.Xmas_theme();
				num = 12;
				goto IL_14D;
				IL_5A:
				if (num == 11)
				{
					goto IL_13B;
				}
				goto IL_14D;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000A2068 File Offset: 0x000A0268
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

		// Token: 0x060003D6 RID: 982 RVA: 0x000A20E0 File Offset: 0x000A02E0
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

		// Token: 0x060003D7 RID: 983 RVA: 0x000A2144 File Offset: 0x000A0344
		private void Halloween()
		{
			int num = 0;
			IEnumerator<AppCard> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.panelUwp.Controls.OfType<AppCard>().GetEnumerator();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			try
			{
				while (enumerator.MoveNext())
				{
					AppCard appCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in appCard.Controls.OfType<SiticoneCheckBox>())
					{
						siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
						siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.refreshModernAppsButton.FillColor = Color.FromArgb(255, 128, 0);
			this.uninstallModernAppsButton.FillColor = Color.FromArgb(255, 128, 0);
			this.uni_edge.FillColor = Color.FromArgb(255, 128, 0);
			this.uni_onedrive.FillColor = Color.FromArgb(255, 128, 0);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000A22D4 File Offset: 0x000A04D4
		private void AccentColor()
		{
			int num = 0;
			Color accentColor;
			IEnumerator<AppCard> enumerator;
			do
			{
				if (num == 2)
				{
					this.refreshModernAppsButton.FillColor = accentColor;
					num = 3;
				}
				if (num == 5)
				{
					this.uni_edge.FillColor = accentColor;
					num = 6;
				}
				if (num == 6)
				{
					enumerator = this.panelUwp.Controls.OfType<AppCard>().GetEnumerator();
					num = 7;
				}
				if (num == 4)
				{
					this.uni_onedrive.FillColor = accentColor;
					num = 5;
				}
				if (num == 3)
				{
					this.uninstallModernAppsButton.FillColor = accentColor;
					num = 4;
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
			while (num != 7);
			try
			{
				while (enumerator.MoveNext())
				{
					AppCard appCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in appCard.Controls.OfType<SiticoneCheckBox>())
					{
						siticoneCheckBox.CheckedState.BorderColor = accentColor;
						siticoneCheckBox.CheckedState.FillColor = accentColor;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000A24C0 File Offset: 0x000A06C0
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<AppCard> enumerator;
			do
			{
				if (num == 2)
				{
					this.uninstallModernAppsButton.FillColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 5)
				{
					enumerator = this.panelUwp.Controls.OfType<AppCard>().GetEnumerator();
					num = 6;
				}
				if (num == 4)
				{
					this.uni_onedrive.FillColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 3)
				{
					this.uni_edge.FillColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 1)
				{
					this.refreshModernAppsButton.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				while (enumerator.MoveNext())
				{
					AppCard appCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in appCard.Controls.OfType<SiticoneCheckBox>())
					{
						siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
						siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000A2698 File Offset: 0x000A0898
		private void GetModernApps(bool showAll)
		{
			int num = 0;
			List<KeyValuePair<string, string>>.Enumerator enumerator;
			do
			{
				if (num == 2)
				{
					this.refreshModernAppsButton.Enabled = false;
					num = 3;
				}
				if (num == 5)
				{
					enumerator = this._modernApps.GetEnumerator();
					num = 6;
				}
				if (num == 4)
				{
					this._modernApps = UWPHelper.GetUWPApps();
					num = 5;
				}
				if (num == 3)
				{
					this.panelUwp.Controls.Clear();
					num = 4;
				}
				if (num == 1)
				{
					this.uninstallModernAppsButton.Enabled = false;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			try
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> keyValuePair = enumerator.Current;
					AppCard appCard = new AppCard();
					appCard.AutoSize = true;
					appCard.Anchor = AnchorStyles.None;
					appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
					appCard.appTitle.Text = keyValuePair.Key;
					appCard.Location = new Point(0, this.panelUwp.Controls.Count * (this.DPI_PREFERENCE / 3));
					this.panelUwp.Controls.Add(appCard);
					this.LoadTheme();
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			this.uninstallModernAppsButton.Enabled = true;
			this.refreshModernAppsButton.Enabled = true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000A2864 File Offset: 0x000A0A64
		private void Debloat_Load(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.GetModernApps(this.chkOnlyRemovable.Checked);
					num = 3;
				}
				if (num == 1)
				{
					this.DPI_PREFERENCE = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ThemeManager", "LastLoadedDPI", "96"));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000A290C File Offset: 0x000A0B0C
		private void back_btn_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					StartupItems.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 4)
				{
					StartupItems.Instance.Show();
					num = 5;
				}
				if (num == 3)
				{
					StartupItems.Instance.BringToFront();
					num = 4;
				}
				if (num == 1)
				{
					base.Controls.Add(StartupItems.Instance);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000A29B8 File Offset: 0x000A0BB8
		private void refresh_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.GetModernApps(this.chkOnlyRemovable.Checked);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000A2A24 File Offset: 0x000A0C24
		private void undo_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.UninstallModernApps();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000A2A80 File Offset: 0x000A0C80
		[DebuggerStepThrough]
		private void UninstallModernApps()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					<UninstallModernApps>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
					num = 3;
				}
				if (num == 5)
				{
					<UninstallModernApps>d__.<>t__builder.Start<Debloat.<UninstallModernApps>d__21>(ref <UninstallModernApps>d__);
					num = 6;
				}
				if (num == 4)
				{
					<UninstallModernApps>d__.<>1__state = -1;
					num = 5;
				}
				if (num == 3)
				{
					<UninstallModernApps>d__.<>4__this = this;
					num = 4;
				}
				if (num == 1)
				{
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00018F88 File Offset: 0x00017188
		private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
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

		// Token: 0x060003E1 RID: 993 RVA: 0x000A2B40 File Offset: 0x000A0D40
		private void uni_onedrive_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						Error error;
						do
						{
							if (num2 == 2)
							{
								bool flag;
								if (!flag)
								{
									goto Block_6;
								}
								num2 = 3;
							}
							if (num2 == 3)
							{
								error = new Error();
								num2 = 4;
							}
							if (num2 == 1)
							{
								bool flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1067795373114007654/OneDrive_Uninstaller.cmd", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\OneDrive_Uninstaller.cmd");
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 4);
						goto IL_E0;
						Block_6:
						Debloat.p.StartInfo.FileName = "C:\\Nexus_LiteOS_Toolkit\\Downloads\\OneDrive_Uninstaller.cmd";
						Debloat.p.Start();
						Debloat.p.WaitForExit();
						Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\OneDrive", "DisableFileSyncNGSC", "1", RegistryValueKind.DWord);
						File.Delete("C:\\Nexus_LiteOS_Toolkit\\Downloads\\OneDrive_Uninstaller.cmd");
						using (debloated debloated = new debloated())
						{
							debloated.ShowDialog(this);
							return;
						}
						try
						{
							IL_E0:
							error.ShowDialog(this);
						}
						finally
						{
							if (error != null)
							{
								((IDisposable)error).Dispose();
							}
						}
					}));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000A2BAC File Offset: 0x000A0DAC
		private void uni_edge_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				ProcessStartInfo processStartInfo;
				if (num == 2)
				{
					processStartInfo = new ProcessStartInfo();
					num = 3;
				}
				if (num == 5)
				{
					processStartInfo.Verb = "runas";
					num = 6;
				}
				Process process;
				if (num == 7)
				{
					process.Start();
					num = 8;
				}
				if (num == 6)
				{
					process.StartInfo = processStartInfo;
					num = 7;
				}
				if (num == 4)
				{
					processStartInfo.Arguments = "irm \"https://github.com/mrhaydendp/RemoveEdge/raw/main/RemoveEdge.ps1\" | iex";
					num = 5;
				}
				if (num == 3)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 4;
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
			while (num != 8);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000A2CE0 File Offset: 0x000A0EE0
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

		// Token: 0x060003E4 RID: 996 RVA: 0x000A2D58 File Offset: 0x000A0F58
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.label37 = new Label();
					num = 3;
				}
				if (num == 5)
				{
					this.uninstallModernAppsButton = new SiticoneButton();
					num = 6;
				}
				if (num == 8)
				{
					this.label3 = new Label();
					num = 9;
				}
				if (num == 11)
				{
					this.siticoneRoundedButton1 = new SiticoneRoundedButton();
					num = 12;
				}
				if (num == 14)
				{
					this.uni_edge = new SiticoneButton();
					num = 15;
				}
				if (num == 17)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 18;
				}
				if (num == 20)
				{
					this.label37.Name = "label37";
					num = 21;
				}
				if (num == 23)
				{
					this.label37.Text = "Debloat/Optimize Windows with ease!";
					num = 24;
				}
				if (num == 26)
				{
					this.label1.ForeColor = Color.White;
					num = 27;
				}
				if (num == 29)
				{
					this.label1.Size = new Size(248, 53);
					num = 30;
				}
				if (num == 32)
				{
					this.Disable_Serv.BackColor = Color.FromArgb(28, 28, 28);
					num = 33;
				}
				if (num == 35)
				{
					this.uninstallModernAppsButton.CustomImages.Parent = this.uninstallModernAppsButton;
					num = 36;
				}
				if (num == 38)
				{
					this.uninstallModernAppsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 39;
				}
				if (num == 41)
				{
					this.uninstallModernAppsButton.FillColor = Color.DodgerBlue;
					num = 42;
				}
				if (num == 44)
				{
					this.uninstallModernAppsButton.HoverState.Parent = this.uninstallModernAppsButton;
					num = 45;
				}
				if (num == 47)
				{
					this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
					num = 48;
				}
				if (num == 50)
				{
					this.uninstallModernAppsButton.TabIndex = 330;
					num = 51;
				}
				if (num == 53)
				{
					this.refreshModernAppsButton.CheckedState.Parent = this.refreshModernAppsButton;
					num = 54;
				}
				if (num == 56)
				{
					this.refreshModernAppsButton.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 57;
				}
				if (num == 59)
				{
					this.refreshModernAppsButton.DisabledState.Parent = this.refreshModernAppsButton;
					num = 60;
				}
				if (num == 62)
				{
					this.refreshModernAppsButton.ForeColor = Color.White;
					num = 63;
				}
				if (num == 65)
				{
					this.refreshModernAppsButton.Location = new Point(27, 600);
					num = 66;
				}
				if (num == 68)
				{
					this.refreshModernAppsButton.Size = new Size(173, 38);
					num = 69;
				}
				if (num == 71)
				{
					this.refreshModernAppsButton.Click += this.refresh_Click;
					num = 72;
				}
				if (num == 74)
				{
					this.panelUwp.Name = "panelUwp";
					num = 75;
				}
				if (num == 77)
				{
					this.label3.AutoSize = true;
					num = 78;
				}
				if (num == 80)
				{
					this.label3.Location = new Point(22, 89);
					num = 81;
				}
				if (num == 83)
				{
					this.label3.TabIndex = 326;
					num = 84;
				}
				if (num == 86)
				{
					this.next_btn.BorderRadius = 14;
					num = 87;
				}
				if (num == 89)
				{
					this.next_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 90;
				}
				if (num == 92)
				{
					this.next_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 93;
				}
				if (num == 95)
				{
					this.next_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 96;
				}
				if (num == 98)
				{
					this.next_btn.Location = new Point(876, 53);
					num = 99;
				}
				if (num == 101)
				{
					this.next_btn.Size = new Size(88, 30);
					num = 102;
				}
				if (num == 104)
				{
					this.next_btn.Click += this.back_btn_Click;
					num = 105;
				}
				if (num == 107)
				{
					this.chkOnlyRemovable.Name = "chkOnlyRemovable";
					num = 108;
				}
				if (num == 110)
				{
					this.chkOnlyRemovable.Text = "checkBox1";
					num = 111;
				}
				if (num == 113)
				{
					this.siticoneRoundedButton1.BorderRadius = 14;
					num = 114;
				}
				if (num == 116)
				{
					this.siticoneRoundedButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 117;
				}
				if (num == 119)
				{
					this.siticoneRoundedButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 120;
				}
				if (num == 122)
				{
					this.siticoneRoundedButton1.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 123;
				}
				if (num == 125)
				{
					this.siticoneRoundedButton1.Location = new Point(782, 53);
					num = 126;
				}
				if (num == 128)
				{
					this.siticoneRoundedButton1.Size = new Size(88, 30);
					num = 129;
				}
				if (num == 131)
				{
					this.siticoneRoundedButton1.Click += this.siticoneRoundedButton1_Click_1;
					num = 132;
				}
				if (num == 134)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 135;
				}
				if (num == 137)
				{
					this.siticoneVScrollBar1.LargeChange = 10;
					num = 138;
				}
				if (num == 140)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 141;
				}
				if (num == 143)
				{
					this.siticoneVScrollBar1.TabIndex = 334;
					num = 144;
				}
				if (num == 146)
				{
					this.uni_onedrive.CheckedState.Parent = this.uni_onedrive;
					num = 147;
				}
				if (num == 149)
				{
					this.uni_onedrive.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 150;
				}
				if (num == 152)
				{
					this.uni_onedrive.DisabledState.Parent = this.uni_onedrive;
					num = 153;
				}
				if (num == 154)
				{
					this.uni_onedrive.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 155;
				}
				if (num == 157)
				{
					this.uni_onedrive.ImageSize = new Size(30, 30);
					num = 158;
				}
				if (num == 160)
				{
					this.uni_onedrive.ShadowDecoration.Parent = this.uni_onedrive;
					num = 161;
				}
				if (num == 163)
				{
					this.uni_onedrive.Text = "Uninstall OneDrive";
					num = 164;
				}
				if (num == 166)
				{
					this.uni_edge.CustomImages.Parent = this.uni_edge;
					num = 167;
				}
				if (num == 169)
				{
					this.uni_edge.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 170;
				}
				if (num == 172)
				{
					this.uni_edge.FillColor = Color.DodgerBlue;
					num = 173;
				}
				if (num == 175)
				{
					this.uni_edge.HoverState.Parent = this.uni_edge;
					num = 176;
				}
				if (num == 178)
				{
					this.uni_edge.Name = "uni_edge";
					num = 179;
				}
				if (num == 181)
				{
					this.uni_edge.TabIndex = 335;
					num = 182;
				}
				if (num == 184)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 185;
				}
				if (num == 187)
				{
					base.Controls.Add(this.uni_onedrive);
					num = 188;
				}
				if (num == 190)
				{
					base.Controls.Add(this.siticoneRoundedButton1);
					num = 191;
				}
				if (num == 193)
				{
					base.Controls.Add(this.refreshModernAppsButton);
					num = 194;
				}
				if (num == 196)
				{
					base.Controls.Add(this.next_btn);
					num = 197;
				}
				if (num == 199)
				{
					base.Name = "Debloat";
					num = 200;
				}
				if (num == 202)
				{
					base.ResumeLayout(false);
					num = 203;
				}
				if (num == 203)
				{
					base.PerformLayout();
					num = 204;
				}
				if (num == 201)
				{
					base.Load += this.Debloat_Load;
					num = 202;
				}
				if (num == 200)
				{
					base.Size = new Size(1021, 669);
					num = 201;
				}
				if (num == 198)
				{
					base.Controls.Add(this.label1);
					num = 199;
				}
				if (num == 197)
				{
					base.Controls.Add(this.label37);
					num = 198;
				}
				if (num == 195)
				{
					base.Controls.Add(this.label3);
					num = 196;
				}
				if (num == 194)
				{
					base.Controls.Add(this.panelUwp);
					num = 195;
				}
				if (num == 192)
				{
					base.Controls.Add(this.uninstallModernAppsButton);
					num = 193;
				}
				if (num == 191)
				{
					base.Controls.Add(this.chkOnlyRemovable);
					num = 192;
				}
				if (num == 189)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 190;
				}
				if (num == 188)
				{
					base.Controls.Add(this.uni_edge);
					num = 189;
				}
				if (num == 186)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 187;
				}
				if (num == 185)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 186;
				}
				if (num == 183)
				{
					this.uni_edge.Click += this.uni_edge_Click;
					num = 184;
				}
				if (num == 182)
				{
					this.uni_edge.Text = "Uninstall Edge";
					num = 183;
				}
				if (num == 180)
				{
					this.uni_edge.Size = new Size(173, 38);
					num = 181;
				}
				if (num == 179)
				{
					this.uni_edge.ShadowDecoration.Parent = this.uni_edge;
					num = 180;
				}
				if (num == 177)
				{
					this.uni_edge.Location = new Point(385, 600);
					num = 178;
				}
				if (num == 176)
				{
					this.uni_edge.ImageSize = new Size(30, 30);
					num = 177;
				}
				if (num == 174)
				{
					this.uni_edge.ForeColor = Color.White;
					num = 175;
				}
				if (num == 173)
				{
					this.uni_edge.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 174;
				}
				if (num == 171)
				{
					this.uni_edge.DisabledState.Parent = this.uni_edge;
					num = 172;
				}
				if (num == 170)
				{
					this.uni_edge.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 171;
				}
				if (num == 168)
				{
					this.uni_edge.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 169;
				}
				if (num == 167)
				{
					this.uni_edge.DisabledState.BorderColor = Color.DarkGray;
					num = 168;
				}
				if (num == 165)
				{
					this.uni_edge.CheckedState.Parent = this.uni_edge;
					num = 166;
				}
				if (num == 164)
				{
					this.uni_onedrive.Click += this.uni_onedrive_Click;
					num = 165;
				}
				if (num == 162)
				{
					this.uni_onedrive.TabIndex = 336;
					num = 163;
				}
				if (num == 161)
				{
					this.uni_onedrive.Size = new Size(173, 38);
					num = 162;
				}
				if (num == 159)
				{
					this.uni_onedrive.Name = "uni_onedrive";
					num = 160;
				}
				if (num == 158)
				{
					this.uni_onedrive.Location = new Point(564, 600);
					num = 159;
				}
				if (num == 156)
				{
					this.uni_onedrive.HoverState.Parent = this.uni_onedrive;
					num = 157;
				}
				if (num == 155)
				{
					this.uni_onedrive.ForeColor = Color.White;
					num = 156;
				}
				if (num == 153)
				{
					this.uni_onedrive.FillColor = Color.DodgerBlue;
					num = 154;
				}
				if (num == 151)
				{
					this.uni_onedrive.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 152;
				}
				if (num == 150)
				{
					this.uni_onedrive.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 151;
				}
				if (num == 148)
				{
					this.uni_onedrive.DisabledState.BorderColor = Color.DarkGray;
					num = 149;
				}
				if (num == 147)
				{
					this.uni_onedrive.CustomImages.Parent = this.uni_onedrive;
					num = 148;
				}
				if (num == 145)
				{
					this.siticoneVScrollBar1.ThumbSize = 100f;
					num = 146;
				}
				if (num == 144)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 145;
				}
				if (num == 142)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 455);
					num = 143;
				}
				if (num == 141)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 142;
				}
				if (num == 139)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 140;
				}
				if (num == 138)
				{
					this.siticoneVScrollBar1.Location = new Point(946, 129);
					num = 139;
				}
				if (num == 136)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 137;
				}
				if (num == 135)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 136;
				}
				if (num == 133)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 134;
				}
				if (num == 132)
				{
					this.siticoneVScrollBar1.BindingContainer = this.panelUwp;
					num = 133;
				}
				if (num == 130)
				{
					this.siticoneRoundedButton1.Text = "Back";
					num = 131;
				}
				if (num == 129)
				{
					this.siticoneRoundedButton1.TabIndex = 333;
					num = 130;
				}
				if (num == 127)
				{
					this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
					num = 128;
				}
				if (num == 126)
				{
					this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
					num = 127;
				}
				if (num == 124)
				{
					this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
					num = 125;
				}
				if (num == 123)
				{
					this.siticoneRoundedButton1.ForeColor = Color.White;
					num = 124;
				}
				if (num == 121)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 122;
				}
				if (num == 120)
				{
					this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
					num = 121;
				}
				if (num == 118)
				{
					this.siticoneRoundedButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 119;
				}
				if (num == 117)
				{
					this.siticoneRoundedButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 118;
				}
				if (num == 115)
				{
					this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
					num = 116;
				}
				if (num == 114)
				{
					this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
					num = 115;
				}
				if (num == 112)
				{
					this.siticoneRoundedButton1.BackColor = Color.Transparent;
					num = 113;
				}
				if (num == 111)
				{
					this.chkOnlyRemovable.UseVisualStyleBackColor = true;
					num = 112;
				}
				if (num == 109)
				{
					this.chkOnlyRemovable.TabIndex = 332;
					num = 110;
				}
				if (num == 108)
				{
					this.chkOnlyRemovable.Size = new Size(80, 17);
					num = 109;
				}
				if (num == 106)
				{
					this.chkOnlyRemovable.Location = new Point(1027, 631);
					num = 107;
				}
				if (num == 105)
				{
					this.chkOnlyRemovable.AutoSize = true;
					num = 106;
				}
				if (num == 103)
				{
					this.next_btn.Text = "Next";
					num = 104;
				}
				if (num == 102)
				{
					this.next_btn.TabIndex = 327;
					num = 103;
				}
				if (num == 100)
				{
					this.next_btn.ShadowDecoration.Parent = this.next_btn;
					num = 101;
				}
				if (num == 99)
				{
					this.next_btn.Name = "next_btn";
					num = 100;
				}
				if (num == 97)
				{
					this.next_btn.HoverState.Parent = this.next_btn;
					num = 98;
				}
				if (num == 96)
				{
					this.next_btn.ForeColor = Color.White;
					num = 97;
				}
				if (num == 94)
				{
					this.next_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 95;
				}
				if (num == 93)
				{
					this.next_btn.DisabledState.Parent = this.next_btn;
					num = 94;
				}
				if (num == 91)
				{
					this.next_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 92;
				}
				if (num == 90)
				{
					this.next_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 91;
				}
				if (num == 88)
				{
					this.next_btn.CustomImages.Parent = this.next_btn;
					num = 89;
				}
				if (num == 87)
				{
					this.next_btn.CheckedState.Parent = this.next_btn;
					num = 88;
				}
				if (num == 85)
				{
					this.next_btn.BackColor = Color.Transparent;
					num = 86;
				}
				if (num == 84)
				{
					this.label3.Text = "Remove Bloatware";
					num = 85;
				}
				if (num == 82)
				{
					this.label3.Size = new Size(197, 28);
					num = 83;
				}
				if (num == 81)
				{
					this.label3.Name = "label3";
					num = 82;
				}
				if (num == 79)
				{
					this.label3.ForeColor = Color.White;
					num = 80;
				}
				if (num == 78)
				{
					this.label3.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 79;
				}
				if (num == 76)
				{
					this.panelUwp.TabIndex = 328;
					num = 77;
				}
				if (num == 75)
				{
					this.panelUwp.Size = new Size(937, 455);
					num = 76;
				}
				if (num == 73)
				{
					this.panelUwp.Location = new Point(27, 129);
					num = 74;
				}
				if (num == 72)
				{
					this.panelUwp.AutoScroll = true;
					num = 73;
				}
				if (num == 70)
				{
					this.refreshModernAppsButton.Text = "Refresh";
					num = 71;
				}
				if (num == 69)
				{
					this.refreshModernAppsButton.TabIndex = 329;
					num = 70;
				}
				if (num == 67)
				{
					this.refreshModernAppsButton.ShadowDecoration.Parent = this.refreshModernAppsButton;
					num = 68;
				}
				if (num == 66)
				{
					this.refreshModernAppsButton.Name = "refreshModernAppsButton";
					num = 67;
				}
				if (num == 64)
				{
					this.refreshModernAppsButton.ImageSize = new Size(30, 30);
					num = 65;
				}
				if (num == 63)
				{
					this.refreshModernAppsButton.HoverState.Parent = this.refreshModernAppsButton;
					num = 64;
				}
				if (num == 61)
				{
					this.refreshModernAppsButton.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 62;
				}
				if (num == 60)
				{
					this.refreshModernAppsButton.FillColor = Color.DodgerBlue;
					num = 61;
				}
				if (num == 58)
				{
					this.refreshModernAppsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 59;
				}
				if (num == 57)
				{
					this.refreshModernAppsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 58;
				}
				if (num == 55)
				{
					this.refreshModernAppsButton.DisabledState.BorderColor = Color.DarkGray;
					num = 56;
				}
				if (num == 54)
				{
					this.refreshModernAppsButton.CustomImages.Parent = this.refreshModernAppsButton;
					num = 55;
				}
				if (num == 52)
				{
					this.uninstallModernAppsButton.Click += this.undo_Click;
					num = 53;
				}
				if (num == 51)
				{
					this.uninstallModernAppsButton.Text = "Uninstall";
					num = 52;
				}
				if (num == 49)
				{
					this.uninstallModernAppsButton.Size = new Size(173, 38);
					num = 50;
				}
				if (num == 48)
				{
					this.uninstallModernAppsButton.ShadowDecoration.Parent = this.uninstallModernAppsButton;
					num = 49;
				}
				if (num == 46)
				{
					this.uninstallModernAppsButton.Location = new Point(206, 600);
					num = 47;
				}
				if (num == 45)
				{
					this.uninstallModernAppsButton.ImageSize = new Size(30, 30);
					num = 46;
				}
				if (num == 43)
				{
					this.uninstallModernAppsButton.ForeColor = Color.White;
					num = 44;
				}
				if (num == 42)
				{
					this.uninstallModernAppsButton.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 43;
				}
				if (num == 40)
				{
					this.uninstallModernAppsButton.DisabledState.Parent = this.uninstallModernAppsButton;
					num = 41;
				}
				if (num == 39)
				{
					this.uninstallModernAppsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 40;
				}
				if (num == 37)
				{
					this.uninstallModernAppsButton.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 38;
				}
				if (num == 36)
				{
					this.uninstallModernAppsButton.DisabledState.BorderColor = Color.DarkGray;
					num = 37;
				}
				if (num == 34)
				{
					this.uninstallModernAppsButton.CheckedState.Parent = this.uninstallModernAppsButton;
					num = 35;
				}
				if (num == 33)
				{
					this.Disable_Serv.ForeColor = Color.White;
					num = 34;
				}
				if (num == 31)
				{
					this.label1.Text = "Expert Tweaks";
					num = 32;
				}
				if (num == 30)
				{
					this.label1.TabIndex = 118;
					num = 31;
				}
				if (num == 28)
				{
					this.label1.Name = "label1";
					num = 29;
				}
				if (num == 27)
				{
					this.label1.Location = new Point(18, 0);
					num = 28;
				}
				if (num == 25)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 26;
				}
				if (num == 24)
				{
					this.label1.AutoSize = true;
					num = 25;
				}
				if (num == 22)
				{
					this.label37.TabIndex = 119;
					num = 23;
				}
				if (num == 21)
				{
					this.label37.Size = new Size(215, 19);
					num = 22;
				}
				if (num == 19)
				{
					this.label37.Location = new Point(23, 53);
					num = 20;
				}
				if (num == 18)
				{
					this.label37.ForeColor = Color.Silver;
					num = 19;
				}
				if (num == 16)
				{
					this.label37.AutoSize = true;
					num = 17;
				}
				if (num == 15)
				{
					base.SuspendLayout();
					num = 16;
				}
				if (num == 13)
				{
					this.uni_onedrive = new SiticoneButton();
					num = 14;
				}
				if (num == 12)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 13;
				}
				if (num == 10)
				{
					this.chkOnlyRemovable = new CheckBox();
					num = 11;
				}
				if (num == 9)
				{
					this.next_btn = new SiticoneRoundedButton();
					num = 10;
				}
				if (num == 7)
				{
					this.panelUwp = new Panel();
					num = 8;
				}
				if (num == 6)
				{
					this.refreshModernAppsButton = new SiticoneButton();
					num = 7;
				}
				if (num == 4)
				{
					this.Disable_Serv = new ToolTip(this.components);
					num = 5;
				}
				if (num == 3)
				{
					this.label1 = new Label();
					num = 4;
				}
				if (num == 1)
				{
					this.components = new Container();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 204);
		}

		// Token: 0x04000440 RID: 1088
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000441 RID: 1089
		private string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled :\n";

		// Token: 0x04000442 RID: 1090
		private string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";

		// Token: 0x04000443 RID: 1091
		private int DPI_PREFERENCE;

		// Token: 0x04000444 RID: 1092
		private List<KeyValuePair<string, string>> _modernApps = new List<KeyValuePair<string, string>>();

		// Token: 0x04000445 RID: 1093
		public static Process p = new Process();

		// Token: 0x04000446 RID: 1094
		private static Debloat _instace;

		// Token: 0x04000447 RID: 1095
		private IContainer components = null;

		// Token: 0x04000448 RID: 1096
		private Label label37;

		// Token: 0x04000449 RID: 1097
		private Label label1;

		// Token: 0x0400044A RID: 1098
		private ToolTip Disable_Serv;

		// Token: 0x0400044B RID: 1099
		private SiticoneButton uninstallModernAppsButton;

		// Token: 0x0400044C RID: 1100
		private SiticoneButton refreshModernAppsButton;

		// Token: 0x0400044D RID: 1101
		private Panel panelUwp;

		// Token: 0x0400044E RID: 1102
		private Label label3;

		// Token: 0x0400044F RID: 1103
		private SiticoneRoundedButton next_btn;

		// Token: 0x04000450 RID: 1104
		private CheckBox chkOnlyRemovable;

		// Token: 0x04000451 RID: 1105
		private SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000452 RID: 1106
		private SiticoneVScrollBar siticoneVScrollBar1;

		// Token: 0x04000453 RID: 1107
		private SiticoneButton uni_onedrive;

		// Token: 0x04000454 RID: 1108
		private SiticoneButton uni_edge;
	}
}
