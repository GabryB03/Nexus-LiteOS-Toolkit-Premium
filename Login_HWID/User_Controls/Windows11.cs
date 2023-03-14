using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Aspose.Zip.SevenZip;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2;
using WindowsFormsApplication2.Dialog_Boxes;
using WindowsFormsApplication2.User_Controls;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200006E RID: 110
	public class Windows11 : UserControl
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0017CE04 File Offset: 0x0017B004
		public static Windows11 Instance
		{
			get
			{
				if (Windows11._instace == null)
				{
					Windows11._instace = new Windows11();
				}
				return Windows11._instace;
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0017CE2C File Offset: 0x0017B02C
		public Windows11()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0017CE8C File Offset: 0x0017B08C
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

		// Token: 0x060009AF RID: 2479 RVA: 0x0017D0D8 File Offset: 0x0017B2D8
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

		// Token: 0x060009B0 RID: 2480 RVA: 0x0017D150 File Offset: 0x0017B350
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

		// Token: 0x060009B1 RID: 2481 RVA: 0x0017D1B4 File Offset: 0x0017B3B4
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.explorer_ribbon.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 6)
				{
					this.tabs.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 5)
				{
					this.tabs.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 6;
				}
				if (num == 3)
				{
					this.explorer_ribbon.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 4;
				}
				if (num == 2)
				{
					this.context_menu.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 1)
				{
					this.context_menu.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0017D338 File Offset: 0x0017B538
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 4)
				{
					this.explorer_ribbon.CheckedState.FillColor = accentColor;
					num = 5;
				}
				if (num == 8)
				{
					this.ProgressBar1.ProgressColor = accentColor;
					num = 9;
				}
				if (num == 9)
				{
					this.ProgressBar1.ProgressColor2 = accentColor;
					num = 10;
				}
				if (num == 7)
				{
					this.tabs.CheckedState.BorderColor = accentColor;
					num = 8;
				}
				if (num == 6)
				{
					this.tabs.CheckedState.FillColor = accentColor;
					num = 7;
				}
				if (num == 5)
				{
					this.explorer_ribbon.CheckedState.BorderColor = accentColor;
					num = 6;
				}
				if (num == 3)
				{
					this.context_menu.CheckedState.BorderColor = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.context_menu.CheckedState.FillColor = accentColor;
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
			while (num != 10);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0017D4FC File Offset: 0x0017B6FC
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 4)
				{
					this.explorer_ribbon.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 6)
				{
					this.tabs.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 7;
				}
				if (num == 5)
				{
					this.tabs.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 6;
				}
				if (num == 3)
				{
					this.explorer_ribbon.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 2)
				{
					this.context_menu.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 1)
				{
					this.context_menu.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0017D680 File Offset: 0x0017B880
		private void windows_11_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num != 4)
				{
					goto IL_0B;
				}
				bool flag;
				if (flag)
				{
					num = 5;
					goto IL_0B;
				}
				goto IL_18E;
				IL_1A7:
				object value;
				if (num == 5)
				{
					this.pkg_location.Text = value.ToString();
					num = 6;
				}
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("Default Packages Location");
					num = 3;
				}
				if (num == 1)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 20)
				{
					break;
				}
				continue;
				IL_18E:
				this.pkg_location.ReadOnly = true;
				num = 7;
				goto IL_1A7;
				IL_0B:
				RegistryKey registryKey2;
				object value2;
				if (num == 8)
				{
					value2 = registryKey2.GetValue("Context_Menu");
					num = 9;
				}
				if (num == 12)
				{
					goto IL_122;
				}
				IL_135:
				if (num == 16)
				{
					goto IL_99;
				}
				IL_AC:
				if (num == 19)
				{
					this.tabs.Checked = true;
					num = 20;
				}
				if (num == 18)
				{
					bool flag2;
					if (!flag2)
					{
						break;
					}
					num = 19;
				}
				object value3;
				if (num == 17)
				{
					bool flag2 = value3 != null;
					num = 18;
				}
				if (num == 15)
				{
					this.explorer_ribbon.Checked = true;
					num = 16;
				}
				if (num == 14)
				{
					bool flag3;
					if (!flag3)
					{
						goto IL_99;
					}
					num = 15;
				}
				object value4;
				if (num == 13)
				{
					bool flag3 = value4 != null;
					num = 14;
				}
				if (num == 11)
				{
					this.context_menu.Checked = true;
					num = 12;
				}
				if (num == 10)
				{
					bool flag4;
					if (!flag4)
					{
						goto IL_122;
					}
					num = 11;
				}
				if (num == 9)
				{
					bool flag4 = value2 != null;
					num = 10;
				}
				if (num == 7)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Tweaks");
					num = 8;
				}
				if (num == 6)
				{
					goto IL_18E;
				}
				goto IL_1A7;
				IL_99:
				value3 = registryKey2.GetValue("Tabs");
				num = 17;
				goto IL_AC;
				IL_122:
				value4 = registryKey2.GetValue("Explorer_Ribbon");
				num = 13;
				goto IL_135;
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0017D8EC File Offset: 0x0017BAEC
		private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 3)
				{
					this.ProgressBar1.Value = e.ProgressPercentage;
					num = 4;
				}
				if (num == 2)
				{
					this.lblDownload.Text = string.Format("{0} MB / {1} MB", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
					num = 3;
				}
				if (num == 1)
				{
					this.lblSpeed.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00"));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0017DA60 File Offset: 0x0017BC60
		private void dl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			int num = 0;
			cancel cancel;
			do
			{
				if (num == 11)
				{
					cancel = new cancel();
					num = 12;
				}
				if (num == 10)
				{
					bool cancelled;
					if (!cancelled)
					{
						goto IL_17A;
					}
					num = 11;
				}
				if (num == 9)
				{
					bool cancelled = e.Cancelled;
					num = 10;
				}
				if (num == 8)
				{
					this.label3.Refresh();
					num = 9;
				}
				if (num == 7)
				{
					this.label3.Text = "Status : Idle...";
					num = 8;
				}
				if (num == 6)
				{
					this.lblDownload.Refresh();
					num = 7;
				}
				if (num == 5)
				{
					this.lblDownload.Text = "";
					num = 6;
				}
				if (num == 4)
				{
					this.lblDownload.Refresh();
					num = 5;
				}
				if (num == 3)
				{
					this.lblSpeed.Text = "";
					num = 4;
				}
				if (num == 2)
				{
					this.ProgressBar1.Value = 0;
					num = 3;
				}
				if (num == 1)
				{
					this.sw.Reset();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
			goto IL_1C6;
			IL_17A:
			if (e.Error != null)
			{
				using (Error error = new Error())
				{
					error.ShowDialog(this);
					return;
				}
			}
			using (custom custom = new custom())
			{
				custom.ShowDialog(this);
				return;
			}
			try
			{
				IL_1C6:
				cancel.ShowDialog(this);
			}
			finally
			{
				if (cancel != null)
				{
					((IDisposable)cancel).Dispose();
				}
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0017DC74 File Offset: 0x0017BE74
		private void dl_DownloadFileCompletedAppx(object sender, AsyncCompletedEventArgs e)
		{
			int num = 0;
			cancel cancel;
			do
			{
				if (num == 11)
				{
					cancel = new cancel();
					num = 12;
				}
				if (num == 10)
				{
					bool cancelled;
					if (!cancelled)
					{
						goto IL_17A;
					}
					num = 11;
				}
				if (num == 9)
				{
					bool cancelled = e.Cancelled;
					num = 10;
				}
				if (num == 8)
				{
					this.label3.Refresh();
					num = 9;
				}
				if (num == 7)
				{
					this.label3.Text = "Status : Idle...";
					num = 8;
				}
				if (num == 6)
				{
					this.lblDownload.Refresh();
					num = 7;
				}
				if (num == 5)
				{
					this.lblDownload.Text = "";
					num = 6;
				}
				if (num == 4)
				{
					this.lblDownload.Refresh();
					num = 5;
				}
				if (num == 3)
				{
					this.lblSpeed.Text = "";
					num = 4;
				}
				if (num == 2)
				{
					this.ProgressBar1.Value = 0;
					num = 3;
				}
				if (num == 1)
				{
					this.sw.Reset();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
			goto IL_1C6;
			IL_17A:
			if (e.Error != null)
			{
				using (Error error = new Error())
				{
					error.ShowDialog(this);
					return;
				}
			}
			using (AppX appX = new AppX())
			{
				appX.ShowDialog(this);
				return;
			}
			try
			{
				IL_1C6:
				cancel.ShowDialog(this);
			}
			finally
			{
				if (cancel != null)
				{
					((IDisposable)cancel).Dispose();
				}
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0017DE88 File Offset: 0x0017C088
		private void framewrks_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoFramework;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0017DF5C File Offset: 0x0017C15C
		private void Worker_DoFramework(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_Framework();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0017DFB8 File Offset: 0x0017C1B8
		private void Download_Framework()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Windows11/Frameworks_Runtimes%20(Win11).7z"), this.pkg_location.Text + "\\Frameworks_Runtimes (Win11).7z");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Required Frameworks/Runtimes...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009BB RID: 2491 RVA: 0x0017E024 File Offset: 0x0017C224
		private void framewrk_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			SevenZipArchive sevenZipArchive;
			do
			{
				if (num == 5)
				{
					sevenZipArchive = new SevenZipArchive(this.pkg_location.Text + "\\Frameworks_Runtimes (Win11).7z");
					num = 6;
				}
				if (num == 4)
				{
					this.label3.Refresh();
					num = 5;
				}
				if (num == 3)
				{
					this.label3.Text = "Please Wait...";
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_116;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\Frameworks_Runtimes (Win11).7z");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			goto IL_13F;
			IL_116:
			using (_404notfound _404notfound = new _404notfound())
			{
				_404notfound.ShowDialog(this);
				return;
			}
			try
			{
				IL_13F:
				sevenZipArchive.ExtractToDirectory(this.pkg_location.Text, null);
			}
			finally
			{
				if (sevenZipArchive != null)
				{
					sevenZipArchive.Dispose();
				}
			}
			Process.Start(this.pkg_location.Text + "\\Installer_11.exe");
			this.label3.Text = "Status : Idle...";
			this.label3.Refresh();
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0017E1F8 File Offset: 0x0017C3F8
		private void codec_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoCODEC;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0017E2CC File Offset: 0x0017C4CC
		private void Worker_DoCODEC(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_CODEC();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0017E328 File Offset: 0x0017C528
		private void Download_CODEC()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/905447438238773259/1054384497510076506/HEVCAV1_Codec.7z"), this.pkg_location.Text + "\\HEVC+AV1 Codec.7z");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading HECV + AV41 Codec...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009BF RID: 2495 RVA: 0x0017E394 File Offset: 0x0017C594
		private void codec_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			SevenZipArchive sevenZipArchive;
			do
			{
				if (num == 3)
				{
					sevenZipArchive = new SevenZipArchive(this.pkg_location.Text + "\\HEVC+AV1 Codec.7z");
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_C6;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\HEVC+AV1 Codec.7z");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			goto IL_F2;
			IL_C6:
			using (_404notfound _404notfound = new _404notfound())
			{
				_404notfound.ShowDialog(this);
				return;
			}
			try
			{
				IL_F2:
				sevenZipArchive.ExtractToDirectory(this.pkg_location.Text, null);
			}
			finally
			{
				if (sevenZipArchive != null)
				{
					sevenZipArchive.Dispose();
				}
			}
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.AV1VideoExtension_1.1.41601.0_x64__8wekyb3d8bbwe.Appx",
				Verb = "runas"
			};
			process.Start();
			process.WaitForExit();
			Process process2 = new Process();
			process2.StartInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.AV1VideoExtension_1.1.41601.0_x86__8wekyb3d8bbwe.Appx",
				Verb = "runas"
			};
			process2.Start();
			process2.WaitForExit();
			Process process3 = new Process();
			process3.StartInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.HEVCVideoExtension_1.0.42701.0_x64__8wekyb3d8bbwe.Appx",
				Verb = "runas"
			};
			process3.Start();
			process3.WaitForExit();
			Process process4 = new Process();
			process4.StartInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.HEVCVideoExtension_1.0.42701.0_x86__8wekyb3d8bbwe.Appx",
				Verb = "runas"
			};
			process4.Start();
			process4.WaitForExit();
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0017E6AC File Offset: 0x0017C8AC
		private void notepad_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoNotepad;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0017E780 File Offset: 0x0017C980
		private void Worker_DoNotepad(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_Notepad();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0017E7DC File Offset: 0x0017C9DC
		private void Download_Notepad()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/905447438238773259/1054386812090585160/Microsoft.WindowsNotepad_11.2112.32.0_neutral__8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.WindowsNotepad_11.2205.11.0_neutral___8wekyb3d8bbwe.Msixbundle");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Notepad...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009C3 RID: 2499 RVA: 0x0017E848 File Offset: 0x0017CA48
		private void notepad_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 12)
				{
					goto IL_145;
				}
				IL_157:
				if (num == 11)
				{
					break;
				}
				Process process;
				if (num == 10)
				{
					process.WaitForExit();
					num = 11;
				}
				if (num == 9)
				{
					process.Start();
					num = 10;
				}
				ProcessStartInfo processStartInfo;
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.WindowsNotepad_11.2205.11.0_neutral___8wekyb3d8bbwe.Msixbundle";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo = new ProcessStartInfo();
					num = 5;
				}
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_145;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\Microsoft.WindowsNotepad_11.2205.11.0_neutral___8wekyb3d8bbwe.Msixbundle");
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
				goto IL_1E6;
				IL_145:
				_404notfound _404notfound = new _404notfound();
				num = 13;
				goto IL_157;
			}
			return;
			IL_1E6:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0017EA6C File Offset: 0x0017CC6C
		private void teams_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 6)
				{
					this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/905447438238773259/1008284114853576715/MicrosoftEdgeWebview2Setup_2.exe"), this.pkg_location.Text + "\\MicrosoftEdgeWebview2Setup_2.exe");
					num = 7;
				}
				if (num == 5)
				{
					this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
					num = 6;
				}
				if (num == 4)
				{
					this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
					num = 5;
				}
				if (num == 3)
				{
					this.dl = new WebClient();
					num = 4;
				}
				if (num == 2)
				{
					this.label3.Refresh();
					num = 3;
				}
				if (num == 1)
				{
					this.label3.Text = "Downloading MicrosoftEdgeWebview2Setup_2.exe...";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 7);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0017EBD0 File Offset: 0x0017CDD0
		private void teams_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_55;
				}
				IL_67:
				if (num == 4)
				{
					break;
				}
				if (num == 3)
				{
					Process.Start(this.pkg_location.Text + "\\MicrosoftEdgeWebview2Setup_2.exe");
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_55;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\MicrosoftEdgeWebview2Setup_2.exe");
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
				goto IL_F3;
				IL_55:
				_404notfound _404notfound = new _404notfound();
				num = 6;
				goto IL_67;
			}
			return;
			IL_F3:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0017ED04 File Offset: 0x0017CF04
		private void paint_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoPaint;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0017EDD8 File Offset: 0x0017CFD8
		private void Worker_DoPaint(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_Paint();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0017EE34 File Offset: 0x0017D034
		private void Download_Paint()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/905447438238773259/1054387295412813834/Microsoft.Paint_11.2110.0.0_neutral__8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.Paint_11.2205.9.0_neutral_~_8wekyb3d8bbwe.Msixbundle");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Microsoft Paint...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009C9 RID: 2505 RVA: 0x0017EEA0 File Offset: 0x0017D0A0
		private void paint_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 12)
				{
					goto IL_145;
				}
				IL_157:
				if (num == 11)
				{
					break;
				}
				Process process;
				if (num == 10)
				{
					process.WaitForExit();
					num = 11;
				}
				if (num == 9)
				{
					process.Start();
					num = 10;
				}
				ProcessStartInfo processStartInfo;
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.Paint_11.2205.9.0_neutral_~_8wekyb3d8bbwe.Msixbundle";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo = new ProcessStartInfo();
					num = 5;
				}
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_145;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\Microsoft.Paint_11.2205.9.0_neutral_~_8wekyb3d8bbwe.Msixbundle");
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
				goto IL_1E6;
				IL_145:
				_404notfound _404notfound = new _404notfound();
				num = 13;
				goto IL_157;
			}
			return;
			IL_1E6:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0017F0C4 File Offset: 0x0017D2C4
		private void snipping_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoSnip;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0017F198 File Offset: 0x0017D398
		private void Worker_DoSnip(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_Snip();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0017F1F4 File Offset: 0x0017D3F4
		private void Download_Snip()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/905447438238773259/1054387669515382844/Microsoft.ScreenSketch_2021.2108.37.0_neutral__8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.ScreenSketch_2021.2108.37.0_neutral_~_8wekyb3d8bbwe.Msixbundle");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Snipping Tool...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009CD RID: 2509 RVA: 0x0017F260 File Offset: 0x0017D460
		private void snipping_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 12)
				{
					goto IL_145;
				}
				IL_157:
				if (num == 11)
				{
					break;
				}
				Process process;
				if (num == 10)
				{
					process.WaitForExit();
					num = 11;
				}
				if (num == 9)
				{
					process.Start();
					num = 10;
				}
				ProcessStartInfo processStartInfo;
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.ScreenSketch_2021.2108.37.0_neutral_~_8wekyb3d8bbwe.Msixbundle";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo = new ProcessStartInfo();
					num = 5;
				}
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_145;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\Microsoft.ScreenSketch_2021.2108.37.0_neutral_~_8wekyb3d8bbwe.Msixbundle");
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
				goto IL_1E6;
				IL_145:
				_404notfound _404notfound = new _404notfound();
				num = 13;
				goto IL_157;
			}
			return;
			IL_1E6:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0017F484 File Offset: 0x0017D684
		private void wsa_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoWSA;
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
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
			while (num != 5);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0017F558 File Offset: 0x0017D758
		private void Worker_DoWSA(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_WSA();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0017F5B4 File Offset: 0x0017D7B4
		private void Download_WSA()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Windows11/WSA_Installer.exe"), "C:\\WSA_Installer.exe");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Windows Subsystem for Android...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009D1 RID: 2513 RVA: 0x0017F620 File Offset: 0x0017D820
		private void wsa_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				Process process;
				if (num == 12)
				{
					process.StartInfo.FileName = "powershell.exe";
					num = 13;
				}
				if (num == 17)
				{
					goto IL_17A;
				}
				IL_186:
				if (num == 16)
				{
					break;
				}
				if (num == 15)
				{
					process.WaitForExit();
					num = 16;
				}
				if (num == 14)
				{
					process.Start();
					num = 15;
				}
				if (num == 13)
				{
					process.StartInfo.Arguments = "Add-AppxPackage -Register C:\\Windows Subsystem for Android\\AppxManifest.xml";
					num = 14;
				}
				if (num == 11)
				{
					process.StartInfo.Verb = "runas";
					num = 12;
				}
				if (num == 10)
				{
					process = new Process();
					num = 11;
				}
				if (num == 9)
				{
					File.Delete("C:\\WSA_Installer.exe");
					num = 10;
				}
				Process process2;
				if (num == 8)
				{
					process2.WaitForExit();
					num = 9;
				}
				if (num == 7)
				{
					process2.Start();
					num = 8;
				}
				if (num == 6)
				{
					process2.StartInfo.FileName = "C:\\WSA_Installer.exe";
					num = 7;
				}
				if (num == 5)
				{
					process2.StartInfo.Verb = "runas";
					num = 6;
				}
				if (num == 4)
				{
					process2 = new Process();
					num = 5;
				}
				if (num == 3)
				{
					Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\Appx", "AllowDevelopmentWithoutDevLicense", 1, RegistryValueKind.DWord);
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_17A;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists("C:\\\\WSA_Installer.exe");
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 18)
				{
					goto Block_18;
				}
				continue;
				IL_17A:
				_404notfound _404notfound = new _404notfound();
				num = 18;
				goto IL_186;
			}
			return;
			Block_18:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0017F854 File Offset: 0x0017DA54
		private void widgets_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.RunWorkerAsync();
					num = 4;
				}
				if (num == 2)
				{
					backgroundWorker.DoWork += this.Worker_DoWidgets;
					num = 3;
				}
				if (num == 1)
				{
					backgroundWorker = new BackgroundWorker();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0017F900 File Offset: 0x0017DB00
		private void Worker_DoWidgets(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_Widgets();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0017F95C File Offset: 0x0017DB5C
		private void Download_Widgets()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.BeginInvoke(new Action(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Windows11/MicrosoftWindows.Client.WebExperience_421.20070.975.0_neutral_~_cw5n1h2txyewy.AppxBundle"), this.pkg_location.Text + "\\MicrosoftWindows.Client.WebExperience_421.20070.975.0_neutral_~_cw5n1h2txyewy.AppxBundle");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label3.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label3.Text = "Downloading Widgets...";
								num2 = 3;
							}
							if (num2 == 1)
							{
								base.Show();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 9);
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

		// Token: 0x060009D5 RID: 2517 RVA: 0x0017F9C8 File Offset: 0x0017DBC8
		private void widgets_install_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 12)
				{
					goto IL_145;
				}
				IL_157:
				if (num == 11)
				{
					break;
				}
				Process process;
				if (num == 10)
				{
					process.WaitForExit();
					num = 11;
				}
				if (num == 9)
				{
					process.Start();
					num = 10;
				}
				ProcessStartInfo processStartInfo;
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 6)
				{
					processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\MicrosoftWindows.Client.WebExperience_421.20070.975.0_neutral_~_cw5n1h2txyewy.AppxBundle";
					num = 7;
				}
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 4)
				{
					processStartInfo = new ProcessStartInfo();
					num = 5;
				}
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				if (num == 2)
				{
					bool flag;
					if (!flag)
					{
						goto IL_145;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool flag = File.Exists(this.pkg_location.Text + "\\MicrosoftWindows.Client.WebExperience_421.20070.975.0_neutral_~_cw5n1h2txyewy.AppxBundle");
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
				goto IL_1E6;
				IL_145:
				_404notfound _404notfound = new _404notfound();
				num = 13;
				goto IL_157;
			}
			return;
			IL_1E6:
			try
			{
				_404notfound _404notfound;
				_404notfound.ShowDialog(this);
			}
			finally
			{
				_404notfound _404notfound;
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0017FBEC File Offset: 0x0017DDEC
		private void context_menu_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 10)
				{
					Error error = new Error();
					num = 11;
				}
				bool flag;
				if (num == 9)
				{
					if (!flag)
					{
						goto IL_138;
					}
					num = 10;
				}
				if (num == 8)
				{
					goto IL_3B;
				}
				IL_58:
				if (num == 7)
				{
					break;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_3B;
					}
					num = 7;
				}
				if (num == 5)
				{
					object value;
					bool flag2 = value != null;
					num = 6;
				}
				if (num == 4)
				{
					RegistryKey registryKey;
					object value = registryKey.GetValue("Context_Menu");
					num = 5;
				}
				if (num == 3)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Tweaks");
					num = 4;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_197;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.context_menu.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					goto Block_13;
				}
				continue;
				IL_3B:
				flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008310937989685328/old_context.reg", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\old.reg");
				num = 9;
				goto IL_58;
			}
			return;
			Block_13:
			try
			{
				Error error;
				error.ShowDialog(this);
			}
			finally
			{
				Error error;
				if (error != null)
				{
					((IDisposable)error).Dispose();
				}
			}
			return;
			IL_138:
			Process process = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Downloads\\old.reg");
			process.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\old.reg");
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey2 != null)
			{
				registryKey2.SetValue("Context_Menu", 1);
				registryKey2.Close();
				return;
			}
			return;
			IL_197:
			if (!Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008310937679298621/new_context.reg", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\new.reg"))
			{
				using (Error error2 = new Error())
				{
					error2.ShowDialog(this);
					return;
				}
			}
			Process process2 = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Downloads\\new.reg");
			process2.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\new.reg");
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey3 != null)
			{
				registryKey3.DeleteValue("Context_Menu", false);
				registryKey3.Close();
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0017FE50 File Offset: 0x0017E050
		private void explorer_ribbon_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 10)
				{
					Error error = new Error();
					num = 11;
				}
				bool flag;
				if (num == 9)
				{
					if (!flag)
					{
						goto IL_138;
					}
					num = 10;
				}
				if (num == 8)
				{
					goto IL_3B;
				}
				IL_58:
				if (num == 7)
				{
					break;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_3B;
					}
					num = 7;
				}
				if (num == 5)
				{
					object value;
					bool flag2 = value != null;
					num = 6;
				}
				if (num == 4)
				{
					RegistryKey registryKey;
					object value = registryKey.GetValue("Explorer_Ribbon");
					num = 5;
				}
				if (num == 3)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Tweaks");
					num = 4;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_197;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.explorer_ribbon.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					goto Block_13;
				}
				continue;
				IL_3B:
				flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008312990526885919/Disable_File_Explorer_command_bar.reg", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\old.reg");
				num = 9;
				goto IL_58;
			}
			return;
			Block_13:
			try
			{
				Error error;
				error.ShowDialog(this);
			}
			finally
			{
				Error error;
				if (error != null)
				{
					((IDisposable)error).Dispose();
				}
			}
			return;
			IL_138:
			Process process = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Downloads\\old.reg");
			process.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\old.reg");
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey2 != null)
			{
				registryKey2.SetValue("Explorer_Ribbon", 1);
				registryKey2.Close();
				return;
			}
			return;
			IL_197:
			if (!Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008312990807883896/Enable_File_Explorer_command_bar.reg", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\new.reg"))
			{
				using (Error error2 = new Error())
				{
					error2.ShowDialog(this);
					return;
				}
			}
			Process process2 = Process.Start("regedit.exe", "/s C:\\Nexus_LiteOS_Toolkit\\Downloads\\new.reg");
			process2.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\new.reg");
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey3 != null)
			{
				registryKey3.DeleteValue("Context_Menu", false);
				registryKey3.Close();
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x001800B4 File Offset: 0x0017E2B4
		private void tabs_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				if (num == 10)
				{
					Error error = new Error();
					num = 11;
				}
				bool flag;
				if (num == 9)
				{
					if (!flag)
					{
						goto IL_138;
					}
					num = 10;
				}
				if (num == 8)
				{
					goto IL_3B;
				}
				IL_58:
				if (num == 7)
				{
					break;
				}
				if (num == 6)
				{
					bool flag2;
					if (!flag2)
					{
						goto IL_3B;
					}
					num = 7;
				}
				if (num == 5)
				{
					object value;
					bool flag2 = value != null;
					num = 6;
				}
				if (num == 4)
				{
					RegistryKey registryKey;
					object value = registryKey.GetValue("Tabs");
					num = 5;
				}
				if (num == 3)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit\\Tweaks");
					num = 4;
				}
				if (num == 2)
				{
					bool @checked;
					if (!@checked)
					{
						goto IL_192;
					}
					num = 3;
				}
				if (num == 1)
				{
					bool @checked = this.tabs.Checked;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 11)
				{
					goto Block_13;
				}
				continue;
				IL_3B:
				flag = !Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008316281046450187/enable.exe", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\Enable.exe");
				num = 9;
				goto IL_58;
			}
			return;
			Block_13:
			try
			{
				Error error;
				error.ShowDialog(this);
			}
			finally
			{
				Error error;
				if (error != null)
				{
					((IDisposable)error).Dispose();
				}
			}
			return;
			IL_138:
			Process process = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Downloads\\Enable.exe");
			process.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\Enable.exe");
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey2 != null)
			{
				registryKey2.SetValue("Tabs", 1);
				registryKey2.Close();
				return;
			}
			return;
			IL_192:
			if (!Utils.DownloadFile("https://cdn.discordapp.com/attachments/901077907043156009/1008316281478459473/disable.exe", "C:\\Nexus_LiteOS_Toolkit\\Downloads\\Disable.exe"))
			{
				using (Error error2 = new Error())
				{
					error2.ShowDialog(this);
					return;
				}
			}
			Process process2 = Process.Start("C:\\Nexus_LiteOS_Toolkit\\Downloads\\Disable.exe");
			process2.WaitForExit();
			File.Delete("C:\\\\Nexus_LiteOS_Toolkit\\\\Downloads\\\\Disable.exe");
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\\\Tweaks");
			if (registryKey3 != null)
			{
				registryKey3.DeleteValue("Tabs", false);
				registryKey3.Close();
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00180310 File Offset: 0x0017E510
		private void cancel_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 8)
				{
					this.dl.CancelAsync();
					num = 9;
				}
				if (num == 7)
				{
					this.label3.Refresh();
					num = 8;
				}
				if (num == 6)
				{
					this.label3.Text = "Status : Idle...";
					num = 7;
				}
				if (num == 5)
				{
					this.lblDownload.Refresh();
					num = 6;
				}
				if (num == 4)
				{
					this.lblDownload.Text = "";
					num = 5;
				}
				if (num == 3)
				{
					this.ProgressBar1.Value = 0;
					num = 4;
				}
				if (num == 2)
				{
					this.lblDownload.Refresh();
					num = 3;
				}
				if (num == 1)
				{
					this.lblSpeed.Text = "";
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00180450 File Offset: 0x0017E650
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

		// Token: 0x060009DB RID: 2523 RVA: 0x001804C8 File Offset: 0x0017E6C8
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 12)
				{
					this.label3 = new Label();
					num = 13;
				}
				if (num == 24)
				{
					this.notepad_install = new Button();
					num = 25;
				}
				if (num == 36)
				{
					this.snipping_install = new Button();
					num = 37;
				}
				if (num == 49)
				{
					base.SuspendLayout();
					num = 50;
				}
				if (num == 61)
				{
					this.context_menu.CheckedState.InnerColor = Color.White;
					num = 62;
				}
				if (num == 73)
				{
					this.context_menu.CheckedChanged += this.context_menu_CheckedChanged;
					num = 74;
				}
				if (num == 86)
				{
					this.explorer_ribbon.CheckedState.Parent = this.explorer_ribbon;
					num = 87;
				}
				if (num == 98)
				{
					this.label2.AutoSize = true;
					num = 99;
				}
				if (num == 110)
				{
					this.tabs.CheckedState.Parent = this.tabs;
					num = 111;
				}
				if (num == 122)
				{
					this.label42.AutoSize = true;
					num = 123;
				}
				if (num == 135)
				{
					this.ProgressBar1.ShadowDecoration.Parent = this.ProgressBar1;
					num = 136;
				}
				if (num == 147)
				{
					this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 148;
				}
				if (num == 159)
				{
					this.label3.TabIndex = 349;
					num = 160;
				}
				if (num == 172)
				{
					this.cancel.Size = new Size(84, 55);
					num = 173;
				}
				if (num == 184)
				{
					this.label40.TabIndex = 356;
					num = 185;
				}
				if (num == 196)
				{
					this.framewrks.Margin = new Padding(1);
					num = 197;
				}
				if (num == 208)
				{
					this.label39.Location = new Point(461, 95);
					num = 209;
				}
				if (num == 221)
				{
					this.codec_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 222;
				}
				if (num == 233)
				{
					this.codec_install.Size = new Size(99, 30);
					num = 234;
				}
				if (num == 245)
				{
					this.codec.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 246;
				}
				if (num == 258)
				{
					this.codec.Click += this.codec_Click;
					num = 259;
				}
				if (num == 270)
				{
					this.label36.Location = new Point(10, 194);
					num = 271;
				}
				ComponentResourceManager componentResourceManager;
				if (num == 282)
				{
					this.framewrk_install.Image = (Image)componentResourceManager.GetObject("framewrk_install.Image");
					num = 283;
				}
				if (num == 294)
				{
					this.label4.AutoSize = true;
					num = 295;
				}
				if (num == 307)
				{
					this.notepad_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 308;
				}
				if (num == 319)
				{
					this.notepad_install.UseVisualStyleBackColor = false;
					num = 320;
				}
				if (num == 331)
				{
					this.notepad.Margin = new Padding(1);
					num = 332;
				}
				if (num == 344)
				{
					this.label5.Name = "label5";
					num = 345;
				}
				if (num == 356)
				{
					this.teams_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 357;
				}
				if (num == 368)
				{
					this.teams_install.Size = new Size(99, 30);
					num = 369;
				}
				if (num == 381)
				{
					this.teams.ForeColor = Color.White;
					num = 382;
				}
				if (num == 393)
				{
					this.teams.Click += this.teams_Click;
					num = 394;
				}
				if (num == 405)
				{
					this.label9.Location = new Point(10, 282);
					num = 406;
				}
				if (num == 417)
				{
					this.wsa_install.Image = (Image)componentResourceManager.GetObject("wsa_install.Image");
					num = 418;
				}
				if (num == 430)
				{
					this.wsa.BackgroundImageLayout = ImageLayout.None;
					num = 431;
				}
				if (num == 442)
				{
					this.wsa.TabIndex = 381;
					num = 443;
				}
				if (num == 454)
				{
					this.label10.TabIndex = 380;
					num = 455;
				}
				if (num == 467)
				{
					this.snipping_install.FlatAppearance.BorderSize = 0;
					num = 468;
				}
				if (num == 479)
				{
					this.snipping_install.Text = "Install";
					num = 480;
				}
				if (num == 491)
				{
					this.snipping.ImageAlign = ContentAlignment.MiddleLeft;
					num = 492;
				}
				if (num == 503)
				{
					this.label12.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 504;
				}
				if (num == 516)
				{
					this.label13.TabIndex = 375;
					num = 517;
				}
				if (num == 528)
				{
					this.paint_install.Margin = new Padding(1);
					num = 529;
				}
				if (num == 540)
				{
					this.paint.FlatAppearance.BorderSize = 0;
					num = 541;
				}
				if (num == 553)
				{
					this.paint.TextAlign = ContentAlignment.MiddleRight;
					num = 554;
				}
				if (num == 565)
				{
					this.label15.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 566;
				}
				if (num == 577)
				{
					this.widgets_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 578;
				}
				if (num == 589)
				{
					this.widgets_install.UseVisualStyleBackColor = false;
					num = 590;
				}
				if (num == 602)
				{
					this.widgets.Name = "widgets";
					num = 603;
				}
				if (num == 614)
				{
					this.label16.Name = "label16";
					num = 615;
				}
				if (num == 626)
				{
					this.pkg_location.Location = new Point(718, 103);
					num = 627;
				}
				if (num == 639)
				{
					base.Controls.Add(this.label10);
					num = 640;
				}
				if (num == 651)
				{
					base.Controls.Add(this.label8);
					num = 652;
				}
				if (num == 663)
				{
					base.Controls.Add(this.label40);
					num = 664;
				}
				if (num == 676)
				{
					base.Controls.Add(this.explorer_ribbon);
					num = 677;
				}
				if (num == 684)
				{
					base.PerformLayout();
					num = 685;
				}
				if (num == 683)
				{
					base.ResumeLayout(false);
					num = 684;
				}
				if (num == 682)
				{
					base.Load += this.windows_11_Load;
					num = 683;
				}
				if (num == 681)
				{
					base.Size = new Size(977, 585);
					num = 682;
				}
				if (num == 680)
				{
					base.Name = "windows_11";
					num = 681;
				}
				if (num == 679)
				{
					base.Controls.Add(this.pkg_location);
					num = 680;
				}
				if (num == 678)
				{
					base.Controls.Add(this.context_menu);
					num = 679;
				}
				if (num == 677)
				{
					base.Controls.Add(this.label7);
					num = 678;
				}
				if (num == 675)
				{
					base.Controls.Add(this.label1);
					num = 676;
				}
				if (num == 674)
				{
					base.Controls.Add(this.tabs);
					num = 675;
				}
				if (num == 673)
				{
					base.Controls.Add(this.label2);
					num = 674;
				}
				if (num == 672)
				{
					base.Controls.Add(this.label42);
					num = 673;
				}
				if (num == 671)
				{
					base.Controls.Add(this.cancel);
					num = 672;
				}
				if (num == 670)
				{
					base.Controls.Add(this.label3);
					num = 671;
				}
				if (num == 669)
				{
					base.Controls.Add(this.lblDownload);
					num = 670;
				}
				if (num == 668)
				{
					base.Controls.Add(this.lblSpeed);
					num = 669;
				}
				if (num == 667)
				{
					base.Controls.Add(this.ProgressBar1);
					num = 668;
				}
				if (num == 666)
				{
					base.Controls.Add(this.label38);
					num = 667;
				}
				if (num == 665)
				{
					base.Controls.Add(this.label39);
					num = 666;
				}
				if (num == 664)
				{
					base.Controls.Add(this.framewrks);
					num = 665;
				}
				if (num == 662)
				{
					base.Controls.Add(this.label36);
					num = 663;
				}
				if (num == 661)
				{
					base.Controls.Add(this.label35);
					num = 662;
				}
				if (num == 660)
				{
					base.Controls.Add(this.codec);
					num = 661;
				}
				if (num == 659)
				{
					base.Controls.Add(this.codec_install);
					num = 660;
				}
				if (num == 658)
				{
					base.Controls.Add(this.framewrk_install);
					num = 659;
				}
				if (num == 657)
				{
					base.Controls.Add(this.label4);
					num = 658;
				}
				if (num == 656)
				{
					base.Controls.Add(this.label6);
					num = 657;
				}
				if (num == 655)
				{
					base.Controls.Add(this.label5);
					num = 656;
				}
				if (num == 654)
				{
					base.Controls.Add(this.notepad);
					num = 655;
				}
				if (num == 653)
				{
					base.Controls.Add(this.notepad_install);
					num = 654;
				}
				if (num == 652)
				{
					base.Controls.Add(this.label9);
					num = 653;
				}
				if (num == 650)
				{
					base.Controls.Add(this.teams);
					num = 651;
				}
				if (num == 649)
				{
					base.Controls.Add(this.teams_install);
					num = 650;
				}
				if (num == 648)
				{
					base.Controls.Add(this.label15);
					num = 649;
				}
				if (num == 647)
				{
					base.Controls.Add(this.label14);
					num = 648;
				}
				if (num == 646)
				{
					base.Controls.Add(this.paint);
					num = 647;
				}
				if (num == 645)
				{
					base.Controls.Add(this.paint_install);
					num = 646;
				}
				if (num == 644)
				{
					base.Controls.Add(this.label13);
					num = 645;
				}
				if (num == 643)
				{
					base.Controls.Add(this.label12);
					num = 644;
				}
				if (num == 642)
				{
					base.Controls.Add(this.snipping);
					num = 643;
				}
				if (num == 641)
				{
					base.Controls.Add(this.snipping_install);
					num = 642;
				}
				if (num == 640)
				{
					base.Controls.Add(this.label11);
					num = 641;
				}
				if (num == 638)
				{
					base.Controls.Add(this.wsa);
					num = 639;
				}
				if (num == 637)
				{
					base.Controls.Add(this.wsa_install);
					num = 638;
				}
				if (num == 636)
				{
					base.Controls.Add(this.label17);
					num = 637;
				}
				if (num == 635)
				{
					base.Controls.Add(this.label16);
					num = 636;
				}
				if (num == 634)
				{
					base.Controls.Add(this.widgets);
					num = 635;
				}
				if (num == 633)
				{
					base.Controls.Add(this.widgets_install);
					num = 634;
				}
				if (num == 632)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 633;
				}
				if (num == 631)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 632;
				}
				if (num == 630)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 631;
				}
				if (num == 629)
				{
					this.pkg_location.TabIndex = 387;
					num = 630;
				}
				if (num == 628)
				{
					this.pkg_location.Size = new Size(25, 20);
					num = 629;
				}
				if (num == 627)
				{
					this.pkg_location.Name = "pkg_location";
					num = 628;
				}
				if (num == 625)
				{
					this.label17.Text = "• Widgets for Windows 11";
					num = 626;
				}
				if (num == 624)
				{
					this.label17.TabIndex = 383;
					num = 625;
				}
				if (num == 623)
				{
					this.label17.Size = new Size(230, 30);
					num = 624;
				}
				if (num == 622)
				{
					this.label17.Name = "label17";
					num = 623;
				}
				if (num == 621)
				{
					this.label17.Location = new Point(10, 458);
					num = 622;
				}
				if (num == 620)
				{
					this.label17.ForeColor = Color.White;
					num = 621;
				}
				if (num == 619)
				{
					this.label17.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 620;
				}
				if (num == 618)
				{
					this.label17.AutoSize = true;
					num = 619;
				}
				if (num == 617)
				{
					this.label16.Text = "| Size : 10MB";
					num = 618;
				}
				if (num == 616)
				{
					this.label16.TabIndex = 384;
					num = 617;
				}
				if (num == 615)
				{
					this.label16.Size = new Size(122, 30);
					num = 616;
				}
				if (num == 613)
				{
					this.label16.Location = new Point(459, 458);
					num = 614;
				}
				if (num == 612)
				{
					this.label16.ForeColor = Color.White;
					num = 613;
				}
				if (num == 611)
				{
					this.label16.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 612;
				}
				if (num == 610)
				{
					this.label16.AutoSize = true;
					num = 611;
				}
				if (num == 609)
				{
					this.widgets.Click += this.widgets_Click;
					num = 610;
				}
				if (num == 608)
				{
					this.widgets.UseVisualStyleBackColor = false;
					num = 609;
				}
				if (num == 607)
				{
					this.widgets.TextAlign = ContentAlignment.MiddleRight;
					num = 608;
				}
				if (num == 606)
				{
					this.widgets.Text = "Download";
					num = 607;
				}
				if (num == 605)
				{
					this.widgets.TabStop = false;
					num = 606;
				}
				if (num == 604)
				{
					this.widgets.TabIndex = 385;
					num = 605;
				}
				if (num == 603)
				{
					this.widgets.Size = new Size(120, 30);
					num = 604;
				}
				if (num == 601)
				{
					this.widgets.Margin = new Padding(1);
					num = 602;
				}
				if (num == 600)
				{
					this.widgets.Location = new Point(661, 458);
					num = 601;
				}
				if (num == 599)
				{
					this.widgets.ImageAlign = ContentAlignment.MiddleLeft;
					num = 600;
				}
				if (num == 598)
				{
					this.widgets.Image = (Image)componentResourceManager.GetObject("widgets.Image");
					num = 599;
				}
				if (num == 597)
				{
					this.widgets.ForeColor = Color.White;
					num = 598;
				}
				if (num == 596)
				{
					this.widgets.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 597;
				}
				if (num == 595)
				{
					this.widgets.FlatStyle = FlatStyle.Flat;
					num = 596;
				}
				if (num == 594)
				{
					this.widgets.FlatAppearance.BorderSize = 0;
					num = 595;
				}
				if (num == 593)
				{
					this.widgets.Cursor = Cursors.Hand;
					num = 594;
				}
				if (num == 592)
				{
					this.widgets.BackgroundImageLayout = ImageLayout.None;
					num = 593;
				}
				if (num == 591)
				{
					this.widgets.BackColor = Color.FromArgb(38, 38, 38);
					num = 592;
				}
				if (num == 590)
				{
					this.widgets_install.Click += this.widgets_install_Click;
					num = 591;
				}
				if (num == 588)
				{
					this.widgets_install.TextAlign = ContentAlignment.MiddleRight;
					num = 589;
				}
				if (num == 587)
				{
					this.widgets_install.Text = "Install";
					num = 588;
				}
				if (num == 586)
				{
					this.widgets_install.TabStop = false;
					num = 587;
				}
				if (num == 585)
				{
					this.widgets_install.TabIndex = 386;
					num = 586;
				}
				if (num == 584)
				{
					this.widgets_install.Size = new Size(99, 30);
					num = 585;
				}
				if (num == 583)
				{
					this.widgets_install.Name = "widgets_install";
					num = 584;
				}
				if (num == 582)
				{
					this.widgets_install.Margin = new Padding(1);
					num = 583;
				}
				if (num == 581)
				{
					this.widgets_install.Location = new Point(851, 458);
					num = 582;
				}
				if (num == 580)
				{
					this.widgets_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 581;
				}
				if (num == 579)
				{
					this.widgets_install.Image = (Image)componentResourceManager.GetObject("widgets_install.Image");
					num = 580;
				}
				if (num == 578)
				{
					this.widgets_install.ForeColor = Color.White;
					num = 579;
				}
				if (num == 576)
				{
					this.widgets_install.FlatStyle = FlatStyle.Flat;
					num = 577;
				}
				if (num == 575)
				{
					this.widgets_install.FlatAppearance.BorderSize = 0;
					num = 576;
				}
				if (num == 574)
				{
					this.widgets_install.Cursor = Cursors.Hand;
					num = 575;
				}
				if (num == 573)
				{
					this.widgets_install.BackgroundImageLayout = ImageLayout.None;
					num = 574;
				}
				if (num == 572)
				{
					this.widgets_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 573;
				}
				if (num == 571)
				{
					this.label15.Text = "• Microsoft Paint";
					num = 572;
				}
				if (num == 570)
				{
					this.label15.TabIndex = 371;
					num = 571;
				}
				if (num == 569)
				{
					this.label15.Size = new Size(160, 30);
					num = 570;
				}
				if (num == 568)
				{
					this.label15.Name = "label15";
					num = 569;
				}
				if (num == 567)
				{
					this.label15.Location = new Point(10, 326);
					num = 568;
				}
				if (num == 566)
				{
					this.label15.ForeColor = Color.White;
					num = 567;
				}
				if (num == 564)
				{
					this.label15.AutoSize = true;
					num = 565;
				}
				if (num == 563)
				{
					this.label14.Text = "| Size : 7MB";
					num = 564;
				}
				if (num == 562)
				{
					this.label14.TabIndex = 372;
					num = 563;
				}
				if (num == 561)
				{
					this.label14.Size = new Size(113, 30);
					num = 562;
				}
				if (num == 560)
				{
					this.label14.Name = "label14";
					num = 561;
				}
				if (num == 559)
				{
					this.label14.Location = new Point(461, 326);
					num = 560;
				}
				if (num == 558)
				{
					this.label14.ForeColor = Color.White;
					num = 559;
				}
				if (num == 557)
				{
					this.label14.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 558;
				}
				if (num == 556)
				{
					this.label14.AutoSize = true;
					num = 557;
				}
				if (num == 555)
				{
					this.paint.Click += this.paint_Click;
					num = 556;
				}
				if (num == 554)
				{
					this.paint.UseVisualStyleBackColor = false;
					num = 555;
				}
				if (num == 552)
				{
					this.paint.Text = "Download";
					num = 553;
				}
				if (num == 551)
				{
					this.paint.TabStop = false;
					num = 552;
				}
				if (num == 550)
				{
					this.paint.TabIndex = 373;
					num = 551;
				}
				if (num == 549)
				{
					this.paint.Size = new Size(120, 30);
					num = 550;
				}
				if (num == 548)
				{
					this.paint.Name = "paint";
					num = 549;
				}
				if (num == 547)
				{
					this.paint.Margin = new Padding(1);
					num = 548;
				}
				if (num == 546)
				{
					this.paint.Location = new Point(661, 328);
					num = 547;
				}
				if (num == 545)
				{
					this.paint.ImageAlign = ContentAlignment.MiddleLeft;
					num = 546;
				}
				if (num == 544)
				{
					this.paint.Image = (Image)componentResourceManager.GetObject("paint.Image");
					num = 545;
				}
				if (num == 543)
				{
					this.paint.ForeColor = Color.White;
					num = 544;
				}
				if (num == 542)
				{
					this.paint.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 543;
				}
				if (num == 541)
				{
					this.paint.FlatStyle = FlatStyle.Flat;
					num = 542;
				}
				if (num == 539)
				{
					this.paint.Cursor = Cursors.Hand;
					num = 540;
				}
				if (num == 538)
				{
					this.paint.BackgroundImageLayout = ImageLayout.None;
					num = 539;
				}
				if (num == 537)
				{
					this.paint.BackColor = Color.FromArgb(38, 38, 38);
					num = 538;
				}
				if (num == 536)
				{
					this.paint_install.Click += this.paint_install_Click;
					num = 537;
				}
				if (num == 535)
				{
					this.paint_install.UseVisualStyleBackColor = false;
					num = 536;
				}
				if (num == 534)
				{
					this.paint_install.TextAlign = ContentAlignment.MiddleRight;
					num = 535;
				}
				if (num == 533)
				{
					this.paint_install.Text = "Install";
					num = 534;
				}
				if (num == 532)
				{
					this.paint_install.TabStop = false;
					num = 533;
				}
				if (num == 531)
				{
					this.paint_install.TabIndex = 374;
					num = 532;
				}
				if (num == 530)
				{
					this.paint_install.Size = new Size(99, 30);
					num = 531;
				}
				if (num == 529)
				{
					this.paint_install.Name = "paint_install";
					num = 530;
				}
				if (num == 527)
				{
					this.paint_install.Location = new Point(851, 328);
					num = 528;
				}
				if (num == 526)
				{
					this.paint_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 527;
				}
				if (num == 525)
				{
					this.paint_install.Image = (Image)componentResourceManager.GetObject("paint_install.Image");
					num = 526;
				}
				if (num == 524)
				{
					this.paint_install.ForeColor = Color.White;
					num = 525;
				}
				if (num == 523)
				{
					this.paint_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 524;
				}
				if (num == 522)
				{
					this.paint_install.FlatStyle = FlatStyle.Flat;
					num = 523;
				}
				if (num == 521)
				{
					this.paint_install.FlatAppearance.BorderSize = 0;
					num = 522;
				}
				if (num == 520)
				{
					this.paint_install.Cursor = Cursors.Hand;
					num = 521;
				}
				if (num == 519)
				{
					this.paint_install.BackgroundImageLayout = ImageLayout.None;
					num = 520;
				}
				if (num == 518)
				{
					this.paint_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 519;
				}
				if (num == 517)
				{
					this.label13.Text = "• Microsoft Snipping Tool";
					num = 518;
				}
				if (num == 515)
				{
					this.label13.Size = new Size(231, 30);
					num = 516;
				}
				if (num == 514)
				{
					this.label13.Name = "label13";
					num = 515;
				}
				if (num == 513)
				{
					this.label13.Location = new Point(10, 370);
					num = 514;
				}
				if (num == 512)
				{
					this.label13.ForeColor = Color.White;
					num = 513;
				}
				if (num == 511)
				{
					this.label13.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 512;
				}
				if (num == 510)
				{
					this.label13.AutoSize = true;
					num = 511;
				}
				if (num == 509)
				{
					this.label12.Text = "| Size : 23MB";
					num = 510;
				}
				if (num == 508)
				{
					this.label12.TabIndex = 376;
					num = 509;
				}
				if (num == 507)
				{
					this.label12.Size = new Size(124, 30);
					num = 508;
				}
				if (num == 506)
				{
					this.label12.Name = "label12";
					num = 507;
				}
				if (num == 505)
				{
					this.label12.Location = new Point(461, 370);
					num = 506;
				}
				if (num == 504)
				{
					this.label12.ForeColor = Color.White;
					num = 505;
				}
				if (num == 502)
				{
					this.label12.AutoSize = true;
					num = 503;
				}
				if (num == 501)
				{
					this.snipping.Click += this.snipping_Click;
					num = 502;
				}
				if (num == 500)
				{
					this.snipping.UseVisualStyleBackColor = false;
					num = 501;
				}
				if (num == 499)
				{
					this.snipping.TextAlign = ContentAlignment.MiddleRight;
					num = 500;
				}
				if (num == 498)
				{
					this.snipping.Text = "Download";
					num = 499;
				}
				if (num == 497)
				{
					this.snipping.TabStop = false;
					num = 498;
				}
				if (num == 496)
				{
					this.snipping.TabIndex = 377;
					num = 497;
				}
				if (num == 495)
				{
					this.snipping.Size = new Size(120, 30);
					num = 496;
				}
				if (num == 494)
				{
					this.snipping.Name = "snipping";
					num = 495;
				}
				if (num == 493)
				{
					this.snipping.Margin = new Padding(1);
					num = 494;
				}
				if (num == 492)
				{
					this.snipping.Location = new Point(661, 370);
					num = 493;
				}
				if (num == 490)
				{
					this.snipping.Image = (Image)componentResourceManager.GetObject("snipping.Image");
					num = 491;
				}
				if (num == 489)
				{
					this.snipping.ForeColor = Color.White;
					num = 490;
				}
				if (num == 488)
				{
					this.snipping.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 489;
				}
				if (num == 487)
				{
					this.snipping.FlatStyle = FlatStyle.Flat;
					num = 488;
				}
				if (num == 486)
				{
					this.snipping.FlatAppearance.BorderSize = 0;
					num = 487;
				}
				if (num == 485)
				{
					this.snipping.Cursor = Cursors.Hand;
					num = 486;
				}
				if (num == 484)
				{
					this.snipping.BackgroundImageLayout = ImageLayout.None;
					num = 485;
				}
				if (num == 483)
				{
					this.snipping.BackColor = Color.FromArgb(38, 38, 38);
					num = 484;
				}
				if (num == 482)
				{
					this.snipping_install.Click += this.snipping_install_Click;
					num = 483;
				}
				if (num == 481)
				{
					this.snipping_install.UseVisualStyleBackColor = false;
					num = 482;
				}
				if (num == 480)
				{
					this.snipping_install.TextAlign = ContentAlignment.MiddleRight;
					num = 481;
				}
				if (num == 478)
				{
					this.snipping_install.TabStop = false;
					num = 479;
				}
				if (num == 477)
				{
					this.snipping_install.TabIndex = 378;
					num = 478;
				}
				if (num == 476)
				{
					this.snipping_install.Size = new Size(99, 30);
					num = 477;
				}
				if (num == 475)
				{
					this.snipping_install.Name = "snipping_install";
					num = 476;
				}
				if (num == 474)
				{
					this.snipping_install.Margin = new Padding(1);
					num = 475;
				}
				if (num == 473)
				{
					this.snipping_install.Location = new Point(851, 370);
					num = 474;
				}
				if (num == 472)
				{
					this.snipping_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 473;
				}
				if (num == 471)
				{
					this.snipping_install.Image = (Image)componentResourceManager.GetObject("snipping_install.Image");
					num = 472;
				}
				if (num == 470)
				{
					this.snipping_install.ForeColor = Color.White;
					num = 471;
				}
				if (num == 469)
				{
					this.snipping_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 470;
				}
				if (num == 468)
				{
					this.snipping_install.FlatStyle = FlatStyle.Flat;
					num = 469;
				}
				if (num == 466)
				{
					this.snipping_install.Cursor = Cursors.Hand;
					num = 467;
				}
				if (num == 465)
				{
					this.snipping_install.BackgroundImageLayout = ImageLayout.None;
					num = 466;
				}
				if (num == 464)
				{
					this.snipping_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 465;
				}
				if (num == 463)
				{
					this.label11.Text = "• Windows Subsystem for Android";
					num = 464;
				}
				if (num == 462)
				{
					this.label11.TabIndex = 379;
					num = 463;
				}
				if (num == 461)
				{
					this.label11.Size = new Size(305, 30);
					num = 462;
				}
				if (num == 460)
				{
					this.label11.Name = "label11";
					num = 461;
				}
				if (num == 459)
				{
					this.label11.Location = new Point(10, 414);
					num = 460;
				}
				if (num == 458)
				{
					this.label11.ForeColor = Color.White;
					num = 459;
				}
				if (num == 457)
				{
					this.label11.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 458;
				}
				if (num == 456)
				{
					this.label11.AutoSize = true;
					num = 457;
				}
				if (num == 455)
				{
					this.label10.Text = "| Size : 677MB";
					num = 456;
				}
				if (num == 453)
				{
					this.label10.Size = new Size(132, 30);
					num = 454;
				}
				if (num == 452)
				{
					this.label10.Name = "label10";
					num = 453;
				}
				if (num == 451)
				{
					this.label10.Location = new Point(461, 414);
					num = 452;
				}
				if (num == 450)
				{
					this.label10.ForeColor = Color.White;
					num = 451;
				}
				if (num == 449)
				{
					this.label10.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 450;
				}
				if (num == 448)
				{
					this.label10.AutoSize = true;
					num = 449;
				}
				if (num == 447)
				{
					this.wsa.Click += this.wsa_Click;
					num = 448;
				}
				if (num == 446)
				{
					this.wsa.UseVisualStyleBackColor = false;
					num = 447;
				}
				if (num == 445)
				{
					this.wsa.TextAlign = ContentAlignment.MiddleRight;
					num = 446;
				}
				if (num == 444)
				{
					this.wsa.Text = "Download";
					num = 445;
				}
				if (num == 443)
				{
					this.wsa.TabStop = false;
					num = 444;
				}
				if (num == 441)
				{
					this.wsa.Size = new Size(120, 30);
					num = 442;
				}
				if (num == 440)
				{
					this.wsa.Name = "wsa";
					num = 441;
				}
				if (num == 439)
				{
					this.wsa.Margin = new Padding(1);
					num = 440;
				}
				if (num == 438)
				{
					this.wsa.Location = new Point(661, 414);
					num = 439;
				}
				if (num == 437)
				{
					this.wsa.ImageAlign = ContentAlignment.MiddleLeft;
					num = 438;
				}
				if (num == 436)
				{
					this.wsa.Image = (Image)componentResourceManager.GetObject("wsa.Image");
					num = 437;
				}
				if (num == 435)
				{
					this.wsa.ForeColor = Color.White;
					num = 436;
				}
				if (num == 434)
				{
					this.wsa.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 435;
				}
				if (num == 433)
				{
					this.wsa.FlatStyle = FlatStyle.Flat;
					num = 434;
				}
				if (num == 432)
				{
					this.wsa.FlatAppearance.BorderSize = 0;
					num = 433;
				}
				if (num == 431)
				{
					this.wsa.Cursor = Cursors.Hand;
					num = 432;
				}
				if (num == 429)
				{
					this.wsa.BackColor = Color.FromArgb(38, 38, 38);
					num = 430;
				}
				if (num == 428)
				{
					this.wsa_install.Click += this.wsa_install_Click;
					num = 429;
				}
				if (num == 427)
				{
					this.wsa_install.UseVisualStyleBackColor = false;
					num = 428;
				}
				if (num == 426)
				{
					this.wsa_install.TextAlign = ContentAlignment.MiddleRight;
					num = 427;
				}
				if (num == 425)
				{
					this.wsa_install.Text = "Install";
					num = 426;
				}
				if (num == 424)
				{
					this.wsa_install.TabStop = false;
					num = 425;
				}
				if (num == 423)
				{
					this.wsa_install.TabIndex = 382;
					num = 424;
				}
				if (num == 422)
				{
					this.wsa_install.Size = new Size(99, 30);
					num = 423;
				}
				if (num == 421)
				{
					this.wsa_install.Name = "wsa_install";
					num = 422;
				}
				if (num == 420)
				{
					this.wsa_install.Margin = new Padding(1);
					num = 421;
				}
				if (num == 419)
				{
					this.wsa_install.Location = new Point(851, 414);
					num = 420;
				}
				if (num == 418)
				{
					this.wsa_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 419;
				}
				if (num == 416)
				{
					this.wsa_install.ForeColor = Color.White;
					num = 417;
				}
				if (num == 415)
				{
					this.wsa_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 416;
				}
				if (num == 414)
				{
					this.wsa_install.FlatStyle = FlatStyle.Flat;
					num = 415;
				}
				if (num == 413)
				{
					this.wsa_install.FlatAppearance.BorderSize = 0;
					num = 414;
				}
				if (num == 412)
				{
					this.wsa_install.Cursor = Cursors.Hand;
					num = 413;
				}
				if (num == 411)
				{
					this.wsa_install.BackgroundImageLayout = ImageLayout.None;
					num = 412;
				}
				if (num == 410)
				{
					this.wsa_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 411;
				}
				if (num == 409)
				{
					this.label9.Text = "• Microsoft Chats/Teams";
					num = 410;
				}
				if (num == 408)
				{
					this.label9.TabIndex = 367;
					num = 409;
				}
				if (num == 407)
				{
					this.label9.Size = new Size(226, 30);
					num = 408;
				}
				if (num == 406)
				{
					this.label9.Name = "label9";
					num = 407;
				}
				if (num == 404)
				{
					this.label9.ForeColor = Color.White;
					num = 405;
				}
				if (num == 403)
				{
					this.label9.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 404;
				}
				if (num == 402)
				{
					this.label9.AutoSize = true;
					num = 403;
				}
				if (num == 401)
				{
					this.label8.Text = "| Size : 1MB";
					num = 402;
				}
				if (num == 400)
				{
					this.label8.TabIndex = 368;
					num = 401;
				}
				if (num == 399)
				{
					this.label8.Size = new Size(110, 30);
					num = 400;
				}
				if (num == 398)
				{
					this.label8.Name = "label8";
					num = 399;
				}
				if (num == 397)
				{
					this.label8.Location = new Point(461, 282);
					num = 398;
				}
				if (num == 396)
				{
					this.label8.ForeColor = Color.White;
					num = 397;
				}
				if (num == 395)
				{
					this.label8.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 396;
				}
				if (num == 394)
				{
					this.label8.AutoSize = true;
					num = 395;
				}
				if (num == 392)
				{
					this.teams.UseVisualStyleBackColor = false;
					num = 393;
				}
				if (num == 391)
				{
					this.teams.TextAlign = ContentAlignment.MiddleRight;
					num = 392;
				}
				if (num == 390)
				{
					this.teams.Text = "Download";
					num = 391;
				}
				if (num == 389)
				{
					this.teams.TabStop = false;
					num = 390;
				}
				if (num == 388)
				{
					this.teams.TabIndex = 369;
					num = 389;
				}
				if (num == 387)
				{
					this.teams.Size = new Size(120, 30);
					num = 388;
				}
				if (num == 386)
				{
					this.teams.Name = "teams";
					num = 387;
				}
				if (num == 385)
				{
					this.teams.Margin = new Padding(1);
					num = 386;
				}
				if (num == 384)
				{
					this.teams.Location = new Point(661, 282);
					num = 385;
				}
				if (num == 383)
				{
					this.teams.ImageAlign = ContentAlignment.MiddleLeft;
					num = 384;
				}
				if (num == 382)
				{
					this.teams.Image = (Image)componentResourceManager.GetObject("teams.Image");
					num = 383;
				}
				if (num == 380)
				{
					this.teams.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 381;
				}
				if (num == 379)
				{
					this.teams.FlatStyle = FlatStyle.Flat;
					num = 380;
				}
				if (num == 378)
				{
					this.teams.FlatAppearance.BorderSize = 0;
					num = 379;
				}
				if (num == 377)
				{
					this.teams.Cursor = Cursors.Hand;
					num = 378;
				}
				if (num == 376)
				{
					this.teams.BackgroundImageLayout = ImageLayout.None;
					num = 377;
				}
				if (num == 375)
				{
					this.teams.BackColor = Color.FromArgb(38, 38, 38);
					num = 376;
				}
				if (num == 374)
				{
					this.teams_install.Click += this.teams_install_Click;
					num = 375;
				}
				if (num == 373)
				{
					this.teams_install.UseVisualStyleBackColor = false;
					num = 374;
				}
				if (num == 372)
				{
					this.teams_install.TextAlign = ContentAlignment.MiddleRight;
					num = 373;
				}
				if (num == 371)
				{
					this.teams_install.Text = "Install";
					num = 372;
				}
				if (num == 370)
				{
					this.teams_install.TabStop = false;
					num = 371;
				}
				if (num == 369)
				{
					this.teams_install.TabIndex = 370;
					num = 370;
				}
				if (num == 367)
				{
					this.teams_install.Name = "teams_install";
					num = 368;
				}
				if (num == 366)
				{
					this.teams_install.Margin = new Padding(1);
					num = 367;
				}
				if (num == 365)
				{
					this.teams_install.Location = new Point(851, 284);
					num = 366;
				}
				if (num == 364)
				{
					this.teams_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 365;
				}
				if (num == 363)
				{
					this.teams_install.Image = (Image)componentResourceManager.GetObject("teams_install.Image");
					num = 364;
				}
				if (num == 362)
				{
					this.teams_install.ForeColor = Color.White;
					num = 363;
				}
				if (num == 361)
				{
					this.teams_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 362;
				}
				if (num == 360)
				{
					this.teams_install.FlatStyle = FlatStyle.Flat;
					num = 361;
				}
				if (num == 359)
				{
					this.teams_install.FlatAppearance.BorderSize = 0;
					num = 360;
				}
				if (num == 358)
				{
					this.teams_install.Cursor = Cursors.Hand;
					num = 359;
				}
				if (num == 357)
				{
					this.teams_install.BackgroundImageLayout = ImageLayout.None;
					num = 358;
				}
				if (num == 355)
				{
					this.label6.Text = "• Notepad";
					num = 356;
				}
				if (num == 354)
				{
					this.label6.TabIndex = 363;
					num = 355;
				}
				if (num == 353)
				{
					this.label6.Size = new Size(104, 30);
					num = 354;
				}
				if (num == 352)
				{
					this.label6.Name = "label6";
					num = 353;
				}
				if (num == 351)
				{
					this.label6.Location = new Point(10, 238);
					num = 352;
				}
				if (num == 350)
				{
					this.label6.ForeColor = Color.White;
					num = 351;
				}
				if (num == 349)
				{
					this.label6.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 350;
				}
				if (num == 348)
				{
					this.label6.AutoSize = true;
					num = 349;
				}
				if (num == 347)
				{
					this.label5.Text = "| Size : 8MB";
					num = 348;
				}
				if (num == 346)
				{
					this.label5.TabIndex = 364;
					num = 347;
				}
				if (num == 345)
				{
					this.label5.Size = new Size(114, 30);
					num = 346;
				}
				if (num == 343)
				{
					this.label5.Location = new Point(461, 238);
					num = 344;
				}
				if (num == 342)
				{
					this.label5.ForeColor = Color.White;
					num = 343;
				}
				if (num == 341)
				{
					this.label5.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 342;
				}
				if (num == 340)
				{
					this.label5.AutoSize = true;
					num = 341;
				}
				if (num == 339)
				{
					this.notepad.Click += this.notepad_Click;
					num = 340;
				}
				if (num == 338)
				{
					this.notepad.UseVisualStyleBackColor = false;
					num = 339;
				}
				if (num == 337)
				{
					this.notepad.TextAlign = ContentAlignment.MiddleRight;
					num = 338;
				}
				if (num == 336)
				{
					this.notepad.Text = "Download";
					num = 337;
				}
				if (num == 335)
				{
					this.notepad.TabStop = false;
					num = 336;
				}
				if (num == 334)
				{
					this.notepad.TabIndex = 365;
					num = 335;
				}
				if (num == 333)
				{
					this.notepad.Size = new Size(120, 30);
					num = 334;
				}
				if (num == 332)
				{
					this.notepad.Name = "notepad";
					num = 333;
				}
				if (num == 330)
				{
					this.notepad.Location = new Point(661, 240);
					num = 331;
				}
				if (num == 329)
				{
					this.notepad.ImageAlign = ContentAlignment.MiddleLeft;
					num = 330;
				}
				if (num == 328)
				{
					this.notepad.Image = (Image)componentResourceManager.GetObject("notepad.Image");
					num = 329;
				}
				if (num == 327)
				{
					this.notepad.ForeColor = Color.White;
					num = 328;
				}
				if (num == 326)
				{
					this.notepad.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 327;
				}
				if (num == 325)
				{
					this.notepad.FlatStyle = FlatStyle.Flat;
					num = 326;
				}
				if (num == 324)
				{
					this.notepad.FlatAppearance.BorderSize = 0;
					num = 325;
				}
				if (num == 323)
				{
					this.notepad.Cursor = Cursors.Hand;
					num = 324;
				}
				if (num == 322)
				{
					this.notepad.BackgroundImageLayout = ImageLayout.None;
					num = 323;
				}
				if (num == 321)
				{
					this.notepad.BackColor = Color.FromArgb(38, 38, 38);
					num = 322;
				}
				if (num == 320)
				{
					this.notepad_install.Click += this.notepad_install_Click;
					num = 321;
				}
				if (num == 318)
				{
					this.notepad_install.TextAlign = ContentAlignment.MiddleRight;
					num = 319;
				}
				if (num == 317)
				{
					this.notepad_install.Text = "Install";
					num = 318;
				}
				if (num == 316)
				{
					this.notepad_install.TabStop = false;
					num = 317;
				}
				if (num == 315)
				{
					this.notepad_install.TabIndex = 366;
					num = 316;
				}
				if (num == 314)
				{
					this.notepad_install.Size = new Size(99, 30);
					num = 315;
				}
				if (num == 313)
				{
					this.notepad_install.Name = "notepad_install";
					num = 314;
				}
				if (num == 312)
				{
					this.notepad_install.Margin = new Padding(1);
					num = 313;
				}
				if (num == 311)
				{
					this.notepad_install.Location = new Point(851, 240);
					num = 312;
				}
				if (num == 310)
				{
					this.notepad_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 311;
				}
				if (num == 309)
				{
					this.notepad_install.Image = (Image)componentResourceManager.GetObject("notepad_install.Image");
					num = 310;
				}
				if (num == 308)
				{
					this.notepad_install.ForeColor = Color.White;
					num = 309;
				}
				if (num == 306)
				{
					this.notepad_install.FlatStyle = FlatStyle.Flat;
					num = 307;
				}
				if (num == 305)
				{
					this.notepad_install.FlatAppearance.BorderSize = 0;
					num = 306;
				}
				if (num == 304)
				{
					this.notepad_install.Cursor = Cursors.Hand;
					num = 305;
				}
				if (num == 303)
				{
					this.notepad_install.BackgroundImageLayout = ImageLayout.None;
					num = 304;
				}
				if (num == 302)
				{
					this.notepad_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 303;
				}
				if (num == 301)
				{
					this.label4.Text = "________________________________________________________________________________________________________________________________________";
					num = 302;
				}
				if (num == 300)
				{
					this.label4.TabIndex = 362;
					num = 301;
				}
				if (num == 299)
				{
					this.label4.Size = new Size(960, 18);
					num = 300;
				}
				if (num == 298)
				{
					this.label4.Name = "label4";
					num = 299;
				}
				if (num == 297)
				{
					this.label4.Location = new Point(12, 165);
					num = 298;
				}
				if (num == 296)
				{
					this.label4.ForeColor = Color.Silver;
					num = 297;
				}
				if (num == 295)
				{
					this.label4.Font = new Font("Gill Sans MT", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 296;
				}
				if (num == 293)
				{
					this.framewrk_install.Click += this.framewrk_install_Click;
					num = 294;
				}
				if (num == 292)
				{
					this.framewrk_install.UseVisualStyleBackColor = false;
					num = 293;
				}
				if (num == 291)
				{
					this.framewrk_install.TextAlign = ContentAlignment.MiddleRight;
					num = 292;
				}
				if (num == 290)
				{
					this.framewrk_install.Text = "Install";
					num = 291;
				}
				if (num == 289)
				{
					this.framewrk_install.TabStop = false;
					num = 290;
				}
				if (num == 288)
				{
					this.framewrk_install.TabIndex = 361;
					num = 289;
				}
				if (num == 287)
				{
					this.framewrk_install.Size = new Size(99, 30);
					num = 288;
				}
				if (num == 286)
				{
					this.framewrk_install.Name = "framewrk_install";
					num = 287;
				}
				if (num == 285)
				{
					this.framewrk_install.Margin = new Padding(1);
					num = 286;
				}
				if (num == 284)
				{
					this.framewrk_install.Location = new Point(851, 95);
					num = 285;
				}
				if (num == 283)
				{
					this.framewrk_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 284;
				}
				if (num == 281)
				{
					this.framewrk_install.ForeColor = Color.White;
					num = 282;
				}
				if (num == 280)
				{
					this.framewrk_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 281;
				}
				if (num == 279)
				{
					this.framewrk_install.FlatStyle = FlatStyle.Flat;
					num = 280;
				}
				if (num == 278)
				{
					this.framewrk_install.FlatAppearance.BorderSize = 0;
					num = 279;
				}
				if (num == 277)
				{
					this.framewrk_install.Cursor = Cursors.Hand;
					num = 278;
				}
				if (num == 276)
				{
					this.framewrk_install.BackgroundImageLayout = ImageLayout.None;
					num = 277;
				}
				if (num == 275)
				{
					this.framewrk_install.BackColor = Color.FromArgb(38, 38, 38);
					num = 276;
				}
				if (num == 274)
				{
					this.label36.Text = "• HEVC + AV1 Video Codec";
					num = 275;
				}
				if (num == 273)
				{
					this.label36.TabIndex = 357;
					num = 274;
				}
				if (num == 272)
				{
					this.label36.Size = new Size(249, 30);
					num = 273;
				}
				if (num == 271)
				{
					this.label36.Name = "label36";
					num = 272;
				}
				if (num == 269)
				{
					this.label36.ForeColor = Color.White;
					num = 270;
				}
				if (num == 268)
				{
					this.label36.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 269;
				}
				if (num == 267)
				{
					this.label36.AutoSize = true;
					num = 268;
				}
				if (num == 266)
				{
					this.label35.Text = "| Size : 4MB";
					num = 267;
				}
				if (num == 265)
				{
					this.label35.TabIndex = 358;
					num = 266;
				}
				if (num == 264)
				{
					this.label35.Size = new Size(114, 30);
					num = 265;
				}
				if (num == 263)
				{
					this.label35.Name = "label35";
					num = 264;
				}
				if (num == 262)
				{
					this.label35.Location = new Point(461, 194);
					num = 263;
				}
				if (num == 261)
				{
					this.label35.ForeColor = Color.White;
					num = 262;
				}
				if (num == 260)
				{
					this.label35.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 261;
				}
				if (num == 259)
				{
					this.label35.AutoSize = true;
					num = 260;
				}
				if (num == 257)
				{
					this.codec.UseVisualStyleBackColor = false;
					num = 258;
				}
				if (num == 256)
				{
					this.codec.TextAlign = ContentAlignment.MiddleRight;
					num = 257;
				}
				if (num == 255)
				{
					this.codec.Text = "Download";
					num = 256;
				}
				if (num == 254)
				{
					this.codec.TabStop = false;
					num = 255;
				}
				if (num == 253)
				{
					this.codec.TabIndex = 359;
					num = 254;
				}
				if (num == 252)
				{
					this.codec.Size = new Size(120, 30);
					num = 253;
				}
				if (num == 251)
				{
					this.codec.Name = "codec";
					num = 252;
				}
				if (num == 250)
				{
					this.codec.Margin = new Padding(1);
					num = 251;
				}
				if (num == 249)
				{
					this.codec.Location = new Point(661, 196);
					num = 250;
				}
				if (num == 248)
				{
					this.codec.ImageAlign = ContentAlignment.MiddleLeft;
					num = 249;
				}
				if (num == 247)
				{
					this.codec.Image = (Image)componentResourceManager.GetObject("codec.Image");
					num = 248;
				}
				if (num == 246)
				{
					this.codec.ForeColor = Color.White;
					num = 247;
				}
				if (num == 244)
				{
					this.codec.FlatStyle = FlatStyle.Flat;
					num = 245;
				}
				if (num == 243)
				{
					this.codec.FlatAppearance.BorderSize = 0;
					num = 244;
				}
				if (num == 242)
				{
					this.codec.Cursor = Cursors.Hand;
					num = 243;
				}
				if (num == 241)
				{
					this.codec.BackgroundImageLayout = ImageLayout.None;
					num = 242;
				}
				if (num == 240)
				{
					this.codec.BackColor = Color.FromArgb(38, 38, 38);
					num = 241;
				}
				if (num == 239)
				{
					this.codec_install.Click += this.codec_install_Click;
					num = 240;
				}
				if (num == 238)
				{
					this.codec_install.UseVisualStyleBackColor = false;
					num = 239;
				}
				if (num == 237)
				{
					this.codec_install.TextAlign = ContentAlignment.MiddleRight;
					num = 238;
				}
				if (num == 236)
				{
					this.codec_install.Text = "Install";
					num = 237;
				}
				if (num == 235)
				{
					this.codec_install.TabStop = false;
					num = 236;
				}
				if (num == 234)
				{
					this.codec_install.TabIndex = 360;
					num = 235;
				}
				if (num == 232)
				{
					this.codec_install.Name = "codec_install";
					num = 233;
				}
				if (num == 231)
				{
					this.codec_install.Margin = new Padding(1);
					num = 232;
				}
				if (num == 230)
				{
					this.codec_install.Location = new Point(851, 196);
					num = 231;
				}
				if (num == 229)
				{
					this.codec_install.ImageAlign = ContentAlignment.MiddleLeft;
					num = 230;
				}
				if (num == 228)
				{
					this.codec_install.Image = (Image)componentResourceManager.GetObject("codec_install.Image");
					num = 229;
				}
				if (num == 227)
				{
					this.codec_install.ForeColor = Color.White;
					num = 228;
				}
				if (num == 226)
				{
					this.codec_install.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 227;
				}
				if (num == 225)
				{
					this.codec_install.FlatStyle = FlatStyle.Flat;
					num = 226;
				}
				if (num == 224)
				{
					this.codec_install.FlatAppearance.BorderSize = 0;
					num = 225;
				}
				if (num == 223)
				{
					this.codec_install.Cursor = Cursors.Hand;
					num = 224;
				}
				if (num == 222)
				{
					this.codec_install.BackgroundImageLayout = ImageLayout.None;
					num = 223;
				}
				if (num == 220)
				{
					this.label38.Text = "• Required Framwork/Runtime/VCLibs";
					num = 221;
				}
				if (num == 219)
				{
					this.label38.TabIndex = 353;
					num = 220;
				}
				if (num == 218)
				{
					this.label38.Size = new Size(343, 30);
					num = 219;
				}
				if (num == 217)
				{
					this.label38.Name = "label38";
					num = 218;
				}
				if (num == 216)
				{
					this.label38.Location = new Point(10, 95);
					num = 217;
				}
				if (num == 215)
				{
					this.label38.ForeColor = Color.White;
					num = 216;
				}
				if (num == 214)
				{
					this.label38.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 215;
				}
				if (num == 213)
				{
					this.label38.AutoSize = true;
					num = 214;
				}
				if (num == 212)
				{
					this.label39.Text = "| Size : 36MB";
					num = 213;
				}
				if (num == 211)
				{
					this.label39.TabIndex = 354;
					num = 212;
				}
				if (num == 210)
				{
					this.label39.Size = new Size(124, 30);
					num = 211;
				}
				if (num == 209)
				{
					this.label39.Name = "label39";
					num = 210;
				}
				if (num == 207)
				{
					this.label39.ForeColor = Color.White;
					num = 208;
				}
				if (num == 206)
				{
					this.label39.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 207;
				}
				if (num == 205)
				{
					this.label39.AutoSize = true;
					num = 206;
				}
				if (num == 204)
				{
					this.framewrks.Click += this.framewrks_Click;
					num = 205;
				}
				if (num == 203)
				{
					this.framewrks.UseVisualStyleBackColor = false;
					num = 204;
				}
				if (num == 202)
				{
					this.framewrks.TextAlign = ContentAlignment.MiddleRight;
					num = 203;
				}
				if (num == 201)
				{
					this.framewrks.Text = "Download";
					num = 202;
				}
				if (num == 200)
				{
					this.framewrks.TabStop = false;
					num = 201;
				}
				if (num == 199)
				{
					this.framewrks.TabIndex = 355;
					num = 200;
				}
				if (num == 198)
				{
					this.framewrks.Size = new Size(120, 30);
					num = 199;
				}
				if (num == 197)
				{
					this.framewrks.Name = "framewrks";
					num = 198;
				}
				if (num == 195)
				{
					this.framewrks.Location = new Point(661, 95);
					num = 196;
				}
				if (num == 194)
				{
					this.framewrks.ImageAlign = ContentAlignment.MiddleLeft;
					num = 195;
				}
				if (num == 193)
				{
					this.framewrks.Image = (Image)componentResourceManager.GetObject("framewrks.Image");
					num = 194;
				}
				if (num == 192)
				{
					this.framewrks.ForeColor = Color.White;
					num = 193;
				}
				if (num == 191)
				{
					this.framewrks.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 192;
				}
				if (num == 190)
				{
					this.framewrks.FlatStyle = FlatStyle.Flat;
					num = 191;
				}
				if (num == 189)
				{
					this.framewrks.FlatAppearance.BorderSize = 0;
					num = 190;
				}
				if (num == 188)
				{
					this.framewrks.Cursor = Cursors.Hand;
					num = 189;
				}
				if (num == 187)
				{
					this.framewrks.BackgroundImageLayout = ImageLayout.None;
					num = 188;
				}
				if (num == 186)
				{
					this.framewrks.BackColor = Color.FromArgb(38, 38, 38);
					num = 187;
				}
				if (num == 185)
				{
					this.label40.Text = "Before downloading any UWP apps from below, download the required frameworks, runtime, and VClibs. Extract the zip file and run installer.bat file";
					num = 186;
				}
				if (num == 183)
				{
					this.label40.Size = new Size(822, 19);
					num = 184;
				}
				if (num == 182)
				{
					this.label40.Name = "label40";
					num = 183;
				}
				if (num == 181)
				{
					this.label40.Location = new Point(19, 137);
					num = 182;
				}
				if (num == 180)
				{
					this.label40.ForeColor = Color.Silver;
					num = 181;
				}
				if (num == 179)
				{
					this.label40.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 180;
				}
				if (num == 178)
				{
					this.label40.AutoSize = true;
					num = 179;
				}
				if (num == 177)
				{
					this.cancel.Click += this.cancel_Click;
					num = 178;
				}
				if (num == 176)
				{
					this.cancel.UseVisualStyleBackColor = false;
					num = 177;
				}
				if (num == 175)
				{
					this.cancel.Text = "Cancel";
					num = 176;
				}
				if (num == 174)
				{
					this.cancel.TabStop = false;
					num = 175;
				}
				if (num == 173)
				{
					this.cancel.TabIndex = 348;
					num = 174;
				}
				if (num == 171)
				{
					this.cancel.Name = "cancel";
					num = 172;
				}
				if (num == 170)
				{
					this.cancel.Margin = new Padding(1);
					num = 171;
				}
				if (num == 169)
				{
					this.cancel.Location = new Point(886, 515);
					num = 170;
				}
				if (num == 168)
				{
					this.cancel.ImageAlign = ContentAlignment.MiddleLeft;
					num = 169;
				}
				if (num == 167)
				{
					this.cancel.ForeColor = Color.White;
					num = 168;
				}
				if (num == 166)
				{
					this.cancel.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 167;
				}
				if (num == 165)
				{
					this.cancel.FlatStyle = FlatStyle.Flat;
					num = 166;
				}
				if (num == 164)
				{
					this.cancel.FlatAppearance.BorderSize = 0;
					num = 165;
				}
				if (num == 163)
				{
					this.cancel.Cursor = Cursors.Hand;
					num = 164;
				}
				if (num == 162)
				{
					this.cancel.BackgroundImageLayout = ImageLayout.None;
					num = 163;
				}
				if (num == 161)
				{
					this.cancel.BackColor = Color.FromArgb(38, 38, 38);
					num = 162;
				}
				if (num == 160)
				{
					this.label3.Text = "Status : Idle....";
					num = 161;
				}
				if (num == 158)
				{
					this.label3.Size = new Size(112, 25);
					num = 159;
				}
				if (num == 157)
				{
					this.label3.Name = "label3";
					num = 158;
				}
				if (num == 156)
				{
					this.label3.Location = new Point(10, 545);
					num = 157;
				}
				if (num == 155)
				{
					this.label3.ForeColor = Color.White;
					num = 156;
				}
				if (num == 154)
				{
					this.label3.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 155;
				}
				if (num == 153)
				{
					this.label3.AutoSize = true;
					num = 154;
				}
				if (num == 152)
				{
					this.lblDownload.TabIndex = 350;
					num = 153;
				}
				if (num == 151)
				{
					this.lblDownload.Size = new Size(0, 25);
					num = 152;
				}
				if (num == 150)
				{
					this.lblDownload.Name = "lblDownload";
					num = 151;
				}
				if (num == 149)
				{
					this.lblDownload.Location = new Point(591, 543);
					num = 150;
				}
				if (num == 148)
				{
					this.lblDownload.ForeColor = Color.White;
					num = 149;
				}
				if (num == 146)
				{
					this.lblDownload.AutoSize = true;
					num = 147;
				}
				if (num == 145)
				{
					this.lblSpeed.TabIndex = 351;
					num = 146;
				}
				if (num == 144)
				{
					this.lblSpeed.Size = new Size(0, 25);
					num = 145;
				}
				if (num == 143)
				{
					this.lblSpeed.Name = "lblSpeed";
					num = 144;
				}
				if (num == 142)
				{
					this.lblSpeed.Location = new Point(381, 545);
					num = 143;
				}
				if (num == 141)
				{
					this.lblSpeed.ForeColor = Color.White;
					num = 142;
				}
				if (num == 140)
				{
					this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 141;
				}
				if (num == 139)
				{
					this.lblSpeed.AutoSize = true;
					num = 140;
				}
				if (num == 138)
				{
					this.ProgressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
					num = 139;
				}
				if (num == 137)
				{
					this.ProgressBar1.TabIndex = 352;
					num = 138;
				}
				if (num == 136)
				{
					this.ProgressBar1.Size = new Size(876, 23);
					num = 137;
				}
				if (num == 134)
				{
					this.ProgressBar1.ProgressColor2 = Color.Gray;
					num = 135;
				}
				if (num == 133)
				{
					this.ProgressBar1.ProgressColor = Color.Gray;
					num = 134;
				}
				if (num == 132)
				{
					this.ProgressBar1.Name = "ProgressBar1";
					num = 133;
				}
				if (num == 131)
				{
					this.ProgressBar1.Location = new Point(10, 514);
					num = 132;
				}
				if (num == 130)
				{
					this.ProgressBar1.BorderRadius = 10;
					num = 131;
				}
				if (num == 129)
				{
					this.label42.Text = "________________________________________________________________________________________________________________________________________";
					num = 130;
				}
				if (num == 128)
				{
					this.label42.TabIndex = 347;
					num = 129;
				}
				if (num == 127)
				{
					this.label42.Size = new Size(960, 18);
					num = 128;
				}
				if (num == 126)
				{
					this.label42.Name = "label42";
					num = 127;
				}
				if (num == 125)
				{
					this.label42.Location = new Point(11, 62);
					num = 126;
				}
				if (num == 124)
				{
					this.label42.ForeColor = Color.Silver;
					num = 125;
				}
				if (num == 123)
				{
					this.label42.Font = new Font("Gill Sans MT", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 124;
				}
				if (num == 121)
				{
					this.tabs.CheckedChanged += this.tabs_CheckedChanged;
					num = 122;
				}
				if (num == 120)
				{
					this.tabs.UncheckedState.Parent = this.tabs;
					num = 121;
				}
				if (num == 119)
				{
					this.tabs.UncheckedState.InnerColor = Color.White;
					num = 120;
				}
				if (num == 118)
				{
					this.tabs.UncheckedState.InnerBorderColor = Color.White;
					num = 119;
				}
				if (num == 117)
				{
					this.tabs.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 118;
				}
				if (num == 116)
				{
					this.tabs.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 117;
				}
				if (num == 115)
				{
					this.tabs.TabIndex = 6;
					num = 116;
				}
				if (num == 114)
				{
					this.tabs.Size = new Size(48, 21);
					num = 115;
				}
				if (num == 113)
				{
					this.tabs.ShadowDecoration.Parent = this.tabs;
					num = 114;
				}
				if (num == 112)
				{
					this.tabs.Name = "tabs";
					num = 113;
				}
				if (num == 111)
				{
					this.tabs.Location = new Point(659, 30);
					num = 112;
				}
				if (num == 109)
				{
					this.tabs.CheckedState.InnerColor = Color.White;
					num = 110;
				}
				if (num == 108)
				{
					this.tabs.CheckedState.InnerBorderColor = Color.White;
					num = 109;
				}
				if (num == 107)
				{
					this.tabs.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 108;
				}
				if (num == 106)
				{
					this.tabs.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 107;
				}
				if (num == 105)
				{
					this.label2.Text = "Enable Tabs in Explorer";
					num = 106;
				}
				if (num == 104)
				{
					this.label2.TabIndex = 7;
					num = 105;
				}
				if (num == 103)
				{
					this.label2.Size = new Size(180, 25);
					num = 104;
				}
				if (num == 102)
				{
					this.label2.Name = "label2";
					num = 103;
				}
				if (num == 101)
				{
					this.label2.Location = new Point(713, 26);
					num = 102;
				}
				if (num == 100)
				{
					this.label2.ForeColor = Color.White;
					num = 101;
				}
				if (num == 99)
				{
					this.label2.Font = new Font("Josefin Sans", 12f);
					num = 100;
				}
				if (num == 97)
				{
					this.explorer_ribbon.CheckedChanged += this.explorer_ribbon_CheckedChanged;
					num = 98;
				}
				if (num == 96)
				{
					this.explorer_ribbon.UncheckedState.Parent = this.explorer_ribbon;
					num = 97;
				}
				if (num == 95)
				{
					this.explorer_ribbon.UncheckedState.InnerColor = Color.White;
					num = 96;
				}
				if (num == 94)
				{
					this.explorer_ribbon.UncheckedState.InnerBorderColor = Color.White;
					num = 95;
				}
				if (num == 93)
				{
					this.explorer_ribbon.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 94;
				}
				if (num == 92)
				{
					this.explorer_ribbon.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 93;
				}
				if (num == 91)
				{
					this.explorer_ribbon.TabIndex = 4;
					num = 92;
				}
				if (num == 90)
				{
					this.explorer_ribbon.Size = new Size(48, 21);
					num = 91;
				}
				if (num == 89)
				{
					this.explorer_ribbon.ShadowDecoration.Parent = this.explorer_ribbon;
					num = 90;
				}
				if (num == 88)
				{
					this.explorer_ribbon.Name = "explorer_ribbon";
					num = 89;
				}
				if (num == 87)
				{
					this.explorer_ribbon.Location = new Point(341, 30);
					num = 88;
				}
				if (num == 85)
				{
					this.explorer_ribbon.CheckedState.InnerColor = Color.White;
					num = 86;
				}
				if (num == 84)
				{
					this.explorer_ribbon.CheckedState.InnerBorderColor = Color.White;
					num = 85;
				}
				if (num == 83)
				{
					this.explorer_ribbon.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 84;
				}
				if (num == 82)
				{
					this.explorer_ribbon.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 83;
				}
				if (num == 81)
				{
					this.label1.Text = "Restore Old Explorer Ribbon";
					num = 82;
				}
				if (num == 80)
				{
					this.label1.TabIndex = 5;
					num = 81;
				}
				if (num == 79)
				{
					this.label1.Size = new Size(219, 25);
					num = 80;
				}
				if (num == 78)
				{
					this.label1.Name = "label1";
					num = 79;
				}
				if (num == 77)
				{
					this.label1.Location = new Point(395, 26);
					num = 78;
				}
				if (num == 76)
				{
					this.label1.ForeColor = Color.White;
					num = 77;
				}
				if (num == 75)
				{
					this.label1.Font = new Font("Josefin Sans", 12f);
					num = 76;
				}
				if (num == 74)
				{
					this.label1.AutoSize = true;
					num = 75;
				}
				if (num == 72)
				{
					this.context_menu.UncheckedState.Parent = this.context_menu;
					num = 73;
				}
				if (num == 71)
				{
					this.context_menu.UncheckedState.InnerColor = Color.White;
					num = 72;
				}
				if (num == 70)
				{
					this.context_menu.UncheckedState.InnerBorderColor = Color.White;
					num = 71;
				}
				if (num == 69)
				{
					this.context_menu.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 70;
				}
				if (num == 68)
				{
					this.context_menu.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 69;
				}
				if (num == 67)
				{
					this.context_menu.TabIndex = 2;
					num = 68;
				}
				if (num == 66)
				{
					this.context_menu.Size = new Size(48, 21);
					num = 67;
				}
				if (num == 65)
				{
					this.context_menu.ShadowDecoration.Parent = this.context_menu;
					num = 66;
				}
				if (num == 64)
				{
					this.context_menu.Name = "context_menu";
					num = 65;
				}
				if (num == 63)
				{
					this.context_menu.Location = new Point(23, 26);
					num = 64;
				}
				if (num == 62)
				{
					this.context_menu.CheckedState.Parent = this.context_menu;
					num = 63;
				}
				if (num == 60)
				{
					this.context_menu.CheckedState.InnerBorderColor = Color.White;
					num = 61;
				}
				if (num == 59)
				{
					this.context_menu.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 60;
				}
				if (num == 58)
				{
					this.context_menu.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 59;
				}
				if (num == 57)
				{
					this.label7.Text = "Restore Old Context Menu";
					num = 58;
				}
				if (num == 56)
				{
					this.label7.TabIndex = 3;
					num = 57;
				}
				if (num == 55)
				{
					this.label7.Size = new Size(206, 25);
					num = 56;
				}
				if (num == 54)
				{
					this.label7.Name = "label7";
					num = 55;
				}
				if (num == 53)
				{
					this.label7.Location = new Point(77, 22);
					num = 54;
				}
				if (num == 52)
				{
					this.label7.ForeColor = Color.White;
					num = 53;
				}
				if (num == 51)
				{
					this.label7.Font = new Font("Josefin Sans", 12f);
					num = 52;
				}
				if (num == 50)
				{
					this.label7.AutoSize = true;
					num = 51;
				}
				if (num == 48)
				{
					this.pkg_location = new TextBox();
					num = 49;
				}
				if (num == 47)
				{
					this.label17 = new Label();
					num = 48;
				}
				if (num == 46)
				{
					this.label16 = new Label();
					num = 47;
				}
				if (num == 45)
				{
					this.widgets = new Button();
					num = 46;
				}
				if (num == 44)
				{
					this.widgets_install = new Button();
					num = 45;
				}
				if (num == 43)
				{
					this.label15 = new Label();
					num = 44;
				}
				if (num == 42)
				{
					this.label14 = new Label();
					num = 43;
				}
				if (num == 41)
				{
					this.paint = new Button();
					num = 42;
				}
				if (num == 40)
				{
					this.paint_install = new Button();
					num = 41;
				}
				if (num == 39)
				{
					this.label13 = new Label();
					num = 40;
				}
				if (num == 38)
				{
					this.label12 = new Label();
					num = 39;
				}
				if (num == 37)
				{
					this.snipping = new Button();
					num = 38;
				}
				if (num == 35)
				{
					this.label11 = new Label();
					num = 36;
				}
				if (num == 34)
				{
					this.label10 = new Label();
					num = 35;
				}
				if (num == 33)
				{
					this.wsa = new Button();
					num = 34;
				}
				if (num == 32)
				{
					this.wsa_install = new Button();
					num = 33;
				}
				if (num == 31)
				{
					this.label9 = new Label();
					num = 32;
				}
				if (num == 30)
				{
					this.label8 = new Label();
					num = 31;
				}
				if (num == 29)
				{
					this.teams = new Button();
					num = 30;
				}
				if (num == 28)
				{
					this.teams_install = new Button();
					num = 29;
				}
				if (num == 27)
				{
					this.label6 = new Label();
					num = 28;
				}
				if (num == 26)
				{
					this.label5 = new Label();
					num = 27;
				}
				if (num == 25)
				{
					this.notepad = new Button();
					num = 26;
				}
				if (num == 23)
				{
					this.label4 = new Label();
					num = 24;
				}
				if (num == 22)
				{
					this.framewrk_install = new Button();
					num = 23;
				}
				if (num == 21)
				{
					this.label36 = new Label();
					num = 22;
				}
				if (num == 20)
				{
					this.label35 = new Label();
					num = 21;
				}
				if (num == 19)
				{
					this.codec = new Button();
					num = 20;
				}
				if (num == 18)
				{
					this.codec_install = new Button();
					num = 19;
				}
				if (num == 17)
				{
					this.label38 = new Label();
					num = 18;
				}
				if (num == 16)
				{
					this.label39 = new Label();
					num = 17;
				}
				if (num == 15)
				{
					this.framewrks = new Button();
					num = 16;
				}
				if (num == 14)
				{
					this.label40 = new Label();
					num = 15;
				}
				if (num == 13)
				{
					this.cancel = new Button();
					num = 14;
				}
				if (num == 11)
				{
					this.lblDownload = new Label();
					num = 12;
				}
				if (num == 10)
				{
					this.lblSpeed = new Label();
					num = 11;
				}
				if (num == 9)
				{
					this.ProgressBar1 = new SiticoneProgressBar();
					num = 10;
				}
				if (num == 8)
				{
					this.label42 = new Label();
					num = 9;
				}
				if (num == 7)
				{
					this.tabs = new SiticoneToggleSwitch();
					num = 8;
				}
				if (num == 6)
				{
					this.label2 = new Label();
					num = 7;
				}
				if (num == 5)
				{
					this.explorer_ribbon = new SiticoneToggleSwitch();
					num = 6;
				}
				if (num == 4)
				{
					this.label1 = new Label();
					num = 5;
				}
				if (num == 3)
				{
					this.context_menu = new SiticoneToggleSwitch();
					num = 4;
				}
				if (num == 2)
				{
					this.label7 = new Label();
					num = 3;
				}
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(Windows11));
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 685);
		}

		// Token: 0x04000996 RID: 2454
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000997 RID: 2455
		private static Windows11 _instace;

		// Token: 0x04000998 RID: 2456
		private WebClient dl;

		// Token: 0x04000999 RID: 2457
		private Stopwatch sw = new Stopwatch();

		// Token: 0x0400099A RID: 2458
		private IContainer components = null;

		// Token: 0x0400099B RID: 2459
		private Label label7;

		// Token: 0x0400099C RID: 2460
		private SiticoneToggleSwitch context_menu;

		// Token: 0x0400099D RID: 2461
		private Label label1;

		// Token: 0x0400099E RID: 2462
		private SiticoneToggleSwitch explorer_ribbon;

		// Token: 0x0400099F RID: 2463
		private Label label2;

		// Token: 0x040009A0 RID: 2464
		private SiticoneToggleSwitch tabs;

		// Token: 0x040009A1 RID: 2465
		private Label label42;

		// Token: 0x040009A2 RID: 2466
		private SiticoneProgressBar ProgressBar1;

		// Token: 0x040009A3 RID: 2467
		private Label lblSpeed;

		// Token: 0x040009A4 RID: 2468
		private Label lblDownload;

		// Token: 0x040009A5 RID: 2469
		private Label label3;

		// Token: 0x040009A6 RID: 2470
		private Button cancel;

		// Token: 0x040009A7 RID: 2471
		private Label label40;

		// Token: 0x040009A8 RID: 2472
		private Button framewrks;

		// Token: 0x040009A9 RID: 2473
		private Label label39;

		// Token: 0x040009AA RID: 2474
		private Label label38;

		// Token: 0x040009AB RID: 2475
		private Button codec_install;

		// Token: 0x040009AC RID: 2476
		private Button codec;

		// Token: 0x040009AD RID: 2477
		private Label label35;

		// Token: 0x040009AE RID: 2478
		private Label label36;

		// Token: 0x040009AF RID: 2479
		private Button framewrk_install;

		// Token: 0x040009B0 RID: 2480
		private Label label4;

		// Token: 0x040009B1 RID: 2481
		private Button notepad_install;

		// Token: 0x040009B2 RID: 2482
		private Button notepad;

		// Token: 0x040009B3 RID: 2483
		private Label label5;

		// Token: 0x040009B4 RID: 2484
		private Label label6;

		// Token: 0x040009B5 RID: 2485
		private Button teams_install;

		// Token: 0x040009B6 RID: 2486
		private Button teams;

		// Token: 0x040009B7 RID: 2487
		private Label label8;

		// Token: 0x040009B8 RID: 2488
		private Label label9;

		// Token: 0x040009B9 RID: 2489
		private Button wsa_install;

		// Token: 0x040009BA RID: 2490
		private Button wsa;

		// Token: 0x040009BB RID: 2491
		private Label label10;

		// Token: 0x040009BC RID: 2492
		private Label label11;

		// Token: 0x040009BD RID: 2493
		private Button snipping_install;

		// Token: 0x040009BE RID: 2494
		private Button snipping;

		// Token: 0x040009BF RID: 2495
		private Label label12;

		// Token: 0x040009C0 RID: 2496
		private Label label13;

		// Token: 0x040009C1 RID: 2497
		private Button paint_install;

		// Token: 0x040009C2 RID: 2498
		private Button paint;

		// Token: 0x040009C3 RID: 2499
		private Label label14;

		// Token: 0x040009C4 RID: 2500
		private Label label15;

		// Token: 0x040009C5 RID: 2501
		private Button widgets_install;

		// Token: 0x040009C6 RID: 2502
		private Button widgets;

		// Token: 0x040009C7 RID: 2503
		private Label label16;

		// Token: 0x040009C8 RID: 2504
		private Label label17;

		// Token: 0x040009C9 RID: 2505
		private TextBox pkg_location;
	}
}
