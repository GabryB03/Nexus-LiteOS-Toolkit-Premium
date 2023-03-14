using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Aspose.Zip.SevenZip;
using Login_HWID;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000019 RID: 25
	public class WindowsApp : UserControl
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0006A870 File Offset: 0x00068A70
		public static WindowsApp Instance
		{
			get
			{
				if (WindowsApp._instace == null)
				{
					WindowsApp._instace = new WindowsApp();
				}
				return WindowsApp._instace;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0006A898 File Offset: 0x00068A98
		public WindowsApp()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0006A8F8 File Offset: 0x00068AF8
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0006A924 File Offset: 0x00068B24
		private void LoadTheme()
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\\\Nexus LiteOS Toolkit\\");
					num = 2;
				}
				object obj;
				if (num == 3)
				{
					object value;
					obj = value;
					num = 4;
				}
				string text;
				if (num == 5)
				{
					object obj2;
					text = obj2 as string;
					num = 6;
				}
				if (num != 7)
				{
					goto IL_78;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_78;
				}
				goto IL_11D;
				IL_12F:
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_14C;
					}
					num = 10;
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
					object obj2 = obj;
					num = 5;
				}
				if (num == 2)
				{
					object value = registryKey.GetValue("Theme");
					num = 3;
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
				IL_110:
				if (num == 11)
				{
					goto IL_11D;
				}
				goto IL_12F;
				IL_15E:
				if (num == 17)
				{
					break;
				}
				if (num == 16)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_FE;
				}
				goto IL_110;
				IL_78:
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_FE;
					}
					num = 9;
				}
				if (num == 10 || num == 12 || num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_14C;
				}
				goto IL_15E;
				IL_11D:
				this.Xmas_theme();
				num = 12;
				goto IL_12F;
				IL_FE:
				this.Halloween_theme();
				num = 14;
				goto IL_110;
				IL_14C:
				this.AccentColor();
				num = 16;
				goto IL_15E;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0006AB6C File Offset: 0x00068D6C
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

		// Token: 0x060001A6 RID: 422 RVA: 0x0006ABE4 File Offset: 0x00068DE4
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

		// Token: 0x060001A7 RID: 423 RVA: 0x0006AC48 File Offset: 0x00068E48
		private void Halloween_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.ProgressBar1.ProgressColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 2)
				{
					this.ProgressBar1.ProgressColor2 = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0006ACE0 File Offset: 0x00068EE0
		private void AccentColor()
		{
			int num = 0;
			do
			{
				Color accentColor;
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 3)
				{
					this.ProgressBar1.ProgressColor2 = accentColor;
					num = 4;
				}
				if (num == 2)
				{
					this.ProgressBar1.ProgressColor = accentColor;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0006AD90 File Offset: 0x00068F90
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.ProgressBar1.ProgressColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 2)
				{
					this.ProgressBar1.ProgressColor2 = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0006AE28 File Offset: 0x00069028
		private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.lblSpeed.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00"));
					num = 2;
				}
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
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0006AF9C File Offset: 0x0006919C
		private void dl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			int num = 0;
			cancel cancel;
			do
			{
				if (num == 1)
				{
					this.sw.Reset();
					num = 2;
				}
				if (num == 3)
				{
					this.lblSpeed.Text = "";
					num = 4;
				}
				if (num == 5)
				{
					this.lblDownload.Text = "";
					num = 6;
				}
				if (num == 7)
				{
					this.label2.Text = "Status : Idle...";
					num = 8;
				}
				if (num == 8)
				{
					this.label2.Refresh();
					num = 9;
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
				if (num == 11)
				{
					cancel = new cancel();
					num = 12;
				}
				if (num == 9)
				{
					bool cancelled = e.Cancelled;
					num = 10;
				}
				if (num == 6)
				{
					this.lblDownload.Refresh();
					num = 7;
				}
				if (num == 4)
				{
					this.lblDownload.Refresh();
					num = 5;
				}
				if (num == 2)
				{
					this.ProgressBar1.Value = 0;
					num = 3;
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

		// Token: 0x060001AC RID: 428 RVA: 0x0006B1B0 File Offset: 0x000693B0
		private void dl_DownloadFileCompletedAppx(object sender, AsyncCompletedEventArgs e)
		{
			int num = 0;
			cancel cancel;
			do
			{
				if (num == 1)
				{
					this.sw.Reset();
					num = 2;
				}
				if (num == 3)
				{
					this.lblSpeed.Text = "";
					num = 4;
				}
				if (num == 5)
				{
					this.lblDownload.Text = "";
					num = 6;
				}
				if (num == 7)
				{
					this.label2.Text = "Status : Idle...";
					num = 8;
				}
				if (num == 8)
				{
					this.label2.Refresh();
					num = 9;
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
				if (num == 11)
				{
					cancel = new cancel();
					num = 12;
				}
				if (num == 9)
				{
					bool cancelled = e.Cancelled;
					num = 10;
				}
				if (num == 6)
				{
					this.lblDownload.Refresh();
					num = 7;
				}
				if (num == 4)
				{
					this.lblDownload.Refresh();
					num = 5;
				}
				if (num == 2)
				{
					this.ProgressBar1.Value = 0;
					num = 3;
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

		// Token: 0x060001AD RID: 429 RVA: 0x0006B3C4 File Offset: 0x000695C4
		private void button3_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.lblSpeed.Text = "";
					num = 2;
				}
				if (num == 3)
				{
					this.ProgressBar1.Value = 0;
					num = 4;
				}
				if (num == 5)
				{
					this.lblDownload.Refresh();
					num = 6;
				}
				if (num == 7)
				{
					this.label2.Refresh();
					num = 8;
				}
				if (num == 8)
				{
					this.dl.CancelAsync();
					num = 9;
				}
				if (num == 6)
				{
					this.label2.Text = "Status : Idle...";
					num = 7;
				}
				if (num == 4)
				{
					this.lblDownload.Text = "";
					num = 5;
				}
				if (num == 2)
				{
					this.lblDownload.Refresh();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 9);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0006B504 File Offset: 0x00069704
		private void button34_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoDX9;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0006B5D8 File Offset: 0x000697D8
		private void Worker_DoDX9(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_DX9();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0006B634 File Offset: 0x00069834
		private void Download_DX9()
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
								this.dl.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Ryan2159/Stuff/main/DirectX_9c.7z"), this.dl_location.Text + "\\DirectX_9c.7z");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading DirectX 9c...";
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

		// Token: 0x060001B1 RID: 433 RVA: 0x0006B6A0 File Offset: 0x000698A0
		private void button35_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoDX11;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0006B774 File Offset: 0x00069974
		private void Worker_DoDX11(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_DX11();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0006B7D0 File Offset: 0x000699D0
		private void Download_DX11()
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
								this.dl.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Ryan2159/Stuff/main/DirectX_11.7z"), this.dl_location.Text + "\\DirectX_11.7z");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading DirectX 11...";
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

		// Token: 0x060001B4 RID: 436 RVA: 0x0006B83C File Offset: 0x00069A3C
		private void button36_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoDXWEB;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0006B910 File Offset: 0x00069B10
		private void Worker_DoDXWEB(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_DXWEB();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0006B96C File Offset: 0x00069B6C
		private void Download_DXWEB()
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
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/901077907043156009/974622562774581248/dxwebsetup.exe"), this.dl_location.Text + "\\dxwebsetup.exe");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading DirectX Web Installer...";
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

		// Token: 0x060001B7 RID: 439 RVA: 0x0006B9D8 File Offset: 0x00069BD8
		private void button37_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoCLAC;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0006BAAC File Offset: 0x00069CAC
		private void Worker_DoCLAC(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_CLAC();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0006BB08 File Offset: 0x00069D08
		private void Download_CLAC()
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
								this.dl.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Ryan2159/Stuff/main/Old%20Calculator%20for%20Windows%2010.exe"), this.dl_location.Text + "\\Old.Calculator.for.Win10.exe");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Calculator (Classic)...";
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

		// Token: 0x060001BA RID: 442 RVA: 0x0006BB74 File Offset: 0x00069D74
		private void button38_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoEDGE;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0006BC48 File Offset: 0x00069E48
		private void Worker_DoEDGE(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_EDGE();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0006BCA4 File Offset: 0x00069EA4
		private void Download_EDGE()
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
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/901077907043156009/974621299831889971/MicrosoftEdgeSetup.exe"), this.dl_location.Text + "\\MicrosoftEdgeSetup.exe");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Edge Chromium...";
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

		// Token: 0x060001BD RID: 445 RVA: 0x0006BD10 File Offset: 0x00069F10
		private void button39_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoPAINT;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0006BDE4 File Offset: 0x00069FE4
		private void Worker_DoPAINT(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_PAINT();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0006BE40 File Offset: 0x0006A040
		private void Download_PAINT()
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
								this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/901077907043156009/974623032133955584/ClassicPaint-1.0-setup.exe"), this.dl_location.Text + "\\Microsoft.Paint.Classic.exe");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Paint (Classic)...";
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

		// Token: 0x060001C0 RID: 448 RVA: 0x0006BEAC File Offset: 0x0006A0AC
		private void button40_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoVC;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0006BF80 File Offset: 0x0006A180
		private void Worker_DoVC(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_VC();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0006BFDC File Offset: 0x0006A1DC
		private void Download_VC()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/Others/VisualCppRedist_AIO_x86_x64.zip"), this.dl_location.Text + "\\VisualCppRedist_AIO_x86_x64.zip");
								num2 = 8;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Visual C++ AIO Redist...";
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

		// Token: 0x060001C3 RID: 451 RVA: 0x0006C048 File Offset: 0x0006A248
		private void button7_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoCORTANA;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0006C11C File Offset: 0x0006A31C
		private void Worker_DoCORTANA(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_CORTANA();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0006C178 File Offset: 0x0006A378
		private void Download_CORTANA()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.549981C3F5F10_4.2203.4603.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.549981C3F5F10.Msixbundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Cortana...";
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

		// Token: 0x060001C6 RID: 454 RVA: 0x0006C1E4 File Offset: 0x0006A3E4
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.549981C3F5F10.Msixbundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.549981C3F5F10.Msixbundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0006C3F4 File Offset: 0x0006A5F4
		private void button8_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoGROOVE;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0006C4C8 File Offset: 0x0006A6C8
		private void Worker_DoGROOVE(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_GROOVE();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0006C524 File Offset: 0x0006A724
		private void Download_GROOVE()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.ZuneMusic_2019.22031.10096.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), this.pkg_location.Text + "\\Microsoft.ZuneMusic.AppxBundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Windows Media Player...";
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

		// Token: 0x060001CA RID: 458 RVA: 0x0006C590 File Offset: 0x0006A790
		private void button6_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.ZuneMusic.AppxBundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.ZuneMusic.AppxBundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0006C7A0 File Offset: 0x0006A9A0
		private void button11_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoINTEL;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0006C874 File Offset: 0x0006AA74
		private void Worker_DoINTEL(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_INTEL();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0006C8D0 File Offset: 0x0006AAD0
		private void Download_INTEL()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/AppUp.IntelGraphicsExperience_1.100.4232.0_neutral_~_8j3eq9eme6ctt.AppxBundle"), this.pkg_location.Text + "\\AppUp.IntelGraphicsExperience.AppxBundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Intel Command Center...";
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

		// Token: 0x060001CE RID: 462 RVA: 0x0006C93C File Offset: 0x0006AB3C
		private void button10_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\AppUp.IntelGraphicsExperience.AppxBundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\AppUp.IntelGraphicsExperience.AppxBundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0006CB4C File Offset: 0x0006AD4C
		private void button14_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoUWPCALC;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0006CC20 File Offset: 0x0006AE20
		private void Worker_DoUWPCALC(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_UWPCALC();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0006CC7C File Offset: 0x0006AE7C
		private void Download_UWPCALC()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.WindowsCalculator_2021.2209.0.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.WindowsCalculator.AppxBundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Calculator...";
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

		// Token: 0x060001D2 RID: 466 RVA: 0x0006CCE8 File Offset: 0x0006AEE8
		private void button13_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.WindowsCalculator.AppxBundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.WindowsCalculator.AppxBundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0006CEF8 File Offset: 0x0006B0F8
		private void button17_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoPICS;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0006CFCC File Offset: 0x0006B1CC
		private void Worker_DoPICS(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_PICS();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0006D028 File Offset: 0x0006B228
		private void Download_PICS()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.Windows.Photos_2022.30120.12006.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), this.pkg_location.Text + "\\Microsoft.Windows.Photos.AppxBundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Photos...";
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

		// Token: 0x060001D6 RID: 470 RVA: 0x0006D094 File Offset: 0x0006B294
		private void button16_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.Windows.Photos.AppxBundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.Windows.Photos.AppxBundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0006D2A4 File Offset: 0x0006B4A4
		private void button20_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoSTORE;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0006D378 File Offset: 0x0006B578
		private void Worker_DoSTORE(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_STORE();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		private void Download_STORE()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/MicrosoftStore.appxbundle"), this.pkg_location.Text + "\\Microsoft.WindowsStore.appxbundle");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Microsoft Store...";
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

		// Token: 0x060001DA RID: 474 RVA: 0x0006D440 File Offset: 0x0006B640
		private void button19_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.WindowsStore.appxbundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.WindowsStore.appxbundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0006D650 File Offset: 0x0006B850
		private void button27_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoNVIDIA;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0006D724 File Offset: 0x0006B924
		private void Worker_DoNVIDIA(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_NVIDIA();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0006D780 File Offset: 0x0006B980
		private void Download_NVIDIA()
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
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/NVIDIACorp.NVIDIAControlPanel_8.1.963.0_x64__56jybvy8sckqj.Appx"), this.pkg_location.Text + "\\NVIDIACorp.NVIDIAControlPanel.Appx");
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
								this.label2.Refresh();
								num2 = 4;
							}
							if (num2 == 2)
							{
								this.label2.Text = "Downloading NVIDIA Control Panel...";
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

		// Token: 0x060001DE RID: 478 RVA: 0x0006D7EC File Offset: 0x0006B9EC
		private void button26_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\NVIDIACorp.NVIDIAControlPanel.Appx");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\NVIDIACorp.NVIDIAControlPanel.Appx";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0006D9FC File Offset: 0x0006BBFC
		private void button30_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoTERM;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0006DAD0 File Offset: 0x0006BCD0
		private void Worker_DoTERM(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_TERM();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		private void Download_TERM()
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
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Windows Terminal...";
								num2 = 3;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.WindowsTerminal_3001.15.3465.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), this.pkg_location.Text + "\\Microsoft.WindowsTerminal.Msixbundle");
								num2 = 8;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
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

		// Token: 0x060001E2 RID: 482 RVA: 0x0006DB98 File Offset: 0x0006BD98
		private void button29_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.WindowsTerminal.Msixbundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.WindowsTerminal.Msixbundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0006DDA8 File Offset: 0x0006BFA8
		private void button33_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoXBOX;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0006DE7C File Offset: 0x0006C07C
		private void Worker_DoXBOX(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_XBOX();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0006DED8 File Offset: 0x0006C0D8
		private void Download_XBOX()
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
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Xbox Game Bar...";
								num2 = 3;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Microsoft.XboxGamingOverlay_5.822.11281.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), this.pkg_location.Text + "\\Microsoft.GamingApp.Msixbundle");
								num2 = 8;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
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

		// Token: 0x060001E6 RID: 486 RVA: 0x0006DF44 File Offset: 0x0006C144
		private void button32_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Microsoft.GamingApp.Msixbundle");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\Microsoft.GamingApp.Msixbundle";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0006E154 File Offset: 0x0006C354
		private void button4_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoAMD;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0006E228 File Offset: 0x0006C428
		private void Worker_DoAMD(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_AMD();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0006E284 File Offset: 0x0006C484
		private void Download_AMD()
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
							if (num2 == 2)
							{
								this.label2.Text = "Downloading AMD Radeon Software...";
								num2 = 3;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/AdvancedMicroDevicesInc-2.AMDRadeonSoftware_10.22.40024.0_x64__0a9344xs7nr4m.msix"), this.pkg_location.Text + "\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx");
								num2 = 8;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompletedAppx;
								num2 = 6;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
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

		// Token: 0x060001EA RID: 490 RVA: 0x0006E2F0 File Offset: 0x0006C4F0
		private void button2_Click(object sender, EventArgs e)
		{
			int num = 0;
			_404notfound _404notfound;
			for (;;)
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx");
					num = 2;
				}
				Process process;
				if (num == 3)
				{
					process = new Process();
					num = 4;
				}
				ProcessStartInfo processStartInfo;
				if (num == 5)
				{
					processStartInfo.FileName = "powershell.exe";
					num = 6;
				}
				if (num == 7)
				{
					processStartInfo.Verb = "runas";
					num = 8;
				}
				if (num == 8)
				{
					process.StartInfo = processStartInfo;
					num = 9;
				}
				if (num != 10)
				{
					if (num == 11)
					{
						goto IL_129;
					}
					IL_13B:
					if (num == 9)
					{
						process.Start();
						num = 10;
					}
					if (num == 6)
					{
						processStartInfo.Arguments = "add-appxpackage -p " + this.pkg_location.Text + "\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx";
						num = 7;
					}
					if (num == 4)
					{
						processStartInfo = new ProcessStartInfo();
						num = 5;
					}
					if (num == 2)
					{
						if (!flag)
						{
							goto IL_129;
						}
						num = 3;
					}
					if (num == 0)
					{
						num = 1;
					}
					if (num == 12)
					{
						break;
					}
					continue;
					IL_129:
					_404notfound = new _404notfound();
					num = 12;
					goto IL_13B;
				}
				return;
			}
			try
			{
				_404notfound.ShowDialog(this);
			}
			finally
			{
				if (_404notfound != null)
				{
					((IDisposable)_404notfound).Dispose();
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0006E500 File Offset: 0x0006C700
		private void button9_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Hide();
					num = 2;
				}
				BackgroundWorker backgroundWorker;
				if (num == 3)
				{
					backgroundWorker.DoWork += this.Worker_DoRUNTIME;
					num = 4;
				}
				if (num == 4)
				{
					backgroundWorker.RunWorkerAsync();
					num = 5;
				}
				if (num == 2)
				{
					backgroundWorker = new BackgroundWorker();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
		private void Worker_DoRUNTIME(object sender, DoWorkEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.Download_RUNTIME();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0006E630 File Offset: 0x0006C830
		private void Download_RUNTIME()
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
							if (num2 == 2)
							{
								this.label2.Text = "Downloading Required Runtimes...";
								num2 = 3;
							}
							if (num2 == 4)
							{
								this.dl = new WebClient();
								num2 = 5;
							}
							if (num2 == 6)
							{
								this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
								num2 = 7;
							}
							if (num2 == 8)
							{
								this.sw.Start();
								num2 = 9;
							}
							if (num2 == 7)
							{
								this.dl.DownloadFileAsync(new Uri("https://nexus-toolkit.epubg691.workers.dev/?file=/Toolkit/UWP/Appx_Packages.7z"), this.pkg_location.Text + "\\Appx_Packages.7z");
								num2 = 8;
							}
							if (num2 == 5)
							{
								this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
								num2 = 6;
							}
							if (num2 == 3)
							{
								this.label2.Refresh();
								num2 = 4;
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

		// Token: 0x060001EE RID: 494 RVA: 0x0006E69C File Offset: 0x0006C89C
		private void button5_Click_1(object sender, EventArgs e)
		{
			int num = 0;
			SevenZipArchive sevenZipArchive;
			do
			{
				bool flag;
				if (num == 1)
				{
					flag = File.Exists(this.pkg_location.Text + "\\Appx_Packages.7z");
					num = 2;
				}
				if (num == 3)
				{
					this.label2.Text = "Please Wait...";
					num = 4;
				}
				if (num == 5)
				{
					sevenZipArchive = new SevenZipArchive(this.pkg_location.Text + "\\Appx_Packages.7z");
					num = 6;
				}
				if (num == 4)
				{
					this.label2.Refresh();
					num = 5;
				}
				if (num == 2)
				{
					if (!flag)
					{
						goto IL_113;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 6);
			goto IL_13C;
			IL_113:
			using (_404notfound _404notfound = new _404notfound())
			{
				_404notfound.ShowDialog(this);
				return;
			}
			try
			{
				IL_13C:
				sevenZipArchive.ExtractToDirectory(this.pkg_location.Text, null);
			}
			finally
			{
				if (sevenZipArchive != null)
				{
					sevenZipArchive.Dispose();
				}
			}
			Process.Start(this.pkg_location.Text + "\\Appx_Packages\\Installer.exe");
			this.label2.Text = "Status : Idle...";
			this.label2.Refresh();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0006E86C File Offset: 0x0006CA6C
		private void windowsapp_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				RegistryKey registryKey;
				if (num == 1)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Nexus LiteOS Toolkit");
					num = 2;
				}
				object value;
				bool flag;
				if (num == 3)
				{
					flag = value != null;
					num = 4;
				}
				if (num == 5)
				{
					this.pkg_location.Text = value.ToString();
					num = 6;
				}
				object value2;
				if (num == 7)
				{
					value2 = registryKey.GetValue("Default Downloads Location");
					num = 8;
				}
				bool flag2;
				if (num == 8)
				{
					flag2 = value2 != null;
					num = 9;
				}
				if (num == 10)
				{
					this.dl_location.Text = value2.ToString();
					num = 11;
				}
				if (num == 11)
				{
					goto IL_A8;
				}
				IL_C1:
				if (num == 9)
				{
					if (!flag2)
					{
						goto IL_A8;
					}
					num = 10;
				}
				if (num == 6)
				{
					goto IL_E0;
				}
				IL_F9:
				if (num == 4)
				{
					if (!flag)
					{
						goto IL_E0;
					}
					num = 5;
				}
				if (num == 2)
				{
					value = registryKey.GetValue("Default Packages Location");
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 12)
				{
					continue;
				}
				break;
				IL_E0:
				this.pkg_location.ReadOnly = true;
				num = 7;
				goto IL_F9;
				IL_A8:
				this.dl_location.ReadOnly = true;
				num = 12;
				goto IL_C1;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
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

		// Token: 0x060001F1 RID: 497 RVA: 0x0006EA5C File Offset: 0x0006CC5C
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				ComponentResourceManager componentResourceManager;
				if (num == 1)
				{
					componentResourceManager = new ComponentResourceManager(typeof(WindowsApp));
					num = 2;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 3)
				{
					this.lblSpeed = new Label();
					num = 4;
				}
				if (num == 4)
				{
					this.lblDownload = new Label();
					num = 5;
				}
				if (num == 5)
				{
					this.label2 = new Label();
					num = 6;
				}
				if (num == 6)
				{
					this.button3 = new Button();
					num = 7;
				}
				if (num == 7)
				{
					this.panel1 = new Panel();
					num = 8;
				}
				if (num == 8)
				{
					this.button5 = new Button();
					num = 9;
				}
				if (num == 9)
				{
					this.label42 = new Label();
					num = 10;
				}
				if (num == 10)
				{
					this.label41 = new Label();
					num = 11;
				}
				if (num == 11)
				{
					this.label40 = new Label();
					num = 12;
				}
				if (num == 12)
				{
					this.button9 = new Button();
					num = 13;
				}
				if (num == 14)
				{
					this.label38 = new Label();
					num = 15;
				}
				if (num == 15)
				{
					this.button2 = new Button();
					num = 16;
				}
				if (num == 16)
				{
					this.button4 = new Button();
					num = 17;
				}
				if (num == 17)
				{
					this.label35 = new Label();
					num = 18;
				}
				if (num == 18)
				{
					this.label36 = new Label();
					num = 19;
				}
				if (num == 19)
				{
					this.button40 = new Button();
					num = 20;
				}
				if (num == 20)
				{
					this.label33 = new Label();
					num = 21;
				}
				if (num == 21)
				{
					this.label34 = new Label();
					num = 22;
				}
				if (num == 22)
				{
					this.button39 = new Button();
					num = 23;
				}
				if (num == 23)
				{
					this.label31 = new Label();
					num = 24;
				}
				if (num == 24)
				{
					this.label32 = new Label();
					num = 25;
				}
				if (num == 25)
				{
					this.button38 = new Button();
					num = 26;
				}
				if (num == 27)
				{
					this.label30 = new Label();
					num = 28;
				}
				if (num == 28)
				{
					this.button37 = new Button();
					num = 29;
				}
				if (num == 29)
				{
					this.label27 = new Label();
					num = 30;
				}
				if (num == 30)
				{
					this.label28 = new Label();
					num = 31;
				}
				if (num == 31)
				{
					this.button36 = new Button();
					num = 32;
				}
				if (num == 32)
				{
					this.label25 = new Label();
					num = 33;
				}
				if (num == 33)
				{
					this.label26 = new Label();
					num = 34;
				}
				if (num == 34)
				{
					this.button35 = new Button();
					num = 35;
				}
				if (num == 35)
				{
					this.label23 = new Label();
					num = 36;
				}
				if (num == 36)
				{
					this.label24 = new Label();
					num = 37;
				}
				if (num == 37)
				{
					this.button34 = new Button();
					num = 38;
				}
				if (num == 38)
				{
					this.label21 = new Label();
					num = 39;
				}
				if (num == 40)
				{
					this.label20 = new Label();
					num = 41;
				}
				if (num == 41)
				{
					this.button32 = new Button();
					num = 42;
				}
				if (num == 42)
				{
					this.button33 = new Button();
					num = 43;
				}
				if (num == 43)
				{
					this.label18 = new Label();
					num = 44;
				}
				if (num == 44)
				{
					this.label19 = new Label();
					num = 45;
				}
				if (num == 45)
				{
					this.button29 = new Button();
					num = 46;
				}
				if (num == 46)
				{
					this.button30 = new Button();
					num = 47;
				}
				if (num == 47)
				{
					this.label16 = new Label();
					num = 48;
				}
				if (num == 48)
				{
					this.label17 = new Label();
					num = 49;
				}
				if (num == 49)
				{
					this.button26 = new Button();
					num = 50;
				}
				if (num == 50)
				{
					this.button27 = new Button();
					num = 51;
				}
				if (num == 51)
				{
					this.label14 = new Label();
					num = 52;
				}
				if (num == 53)
				{
					this.button19 = new Button();
					num = 54;
				}
				if (num == 54)
				{
					this.button20 = new Button();
					num = 55;
				}
				if (num == 55)
				{
					this.label12 = new Label();
					num = 56;
				}
				if (num == 56)
				{
					this.label13 = new Label();
					num = 57;
				}
				if (num == 57)
				{
					this.button16 = new Button();
					num = 58;
				}
				if (num == 58)
				{
					this.button17 = new Button();
					num = 59;
				}
				if (num == 59)
				{
					this.label10 = new Label();
					num = 60;
				}
				if (num == 60)
				{
					this.label11 = new Label();
					num = 61;
				}
				if (num == 61)
				{
					this.button13 = new Button();
					num = 62;
				}
				if (num == 62)
				{
					this.button14 = new Button();
					num = 63;
				}
				if (num == 63)
				{
					this.label8 = new Label();
					num = 64;
				}
				if (num == 64)
				{
					this.label9 = new Label();
					num = 65;
				}
				if (num == 65)
				{
					this.button10 = new Button();
					num = 66;
				}
				if (num == 67)
				{
					this.label5 = new Label();
					num = 68;
				}
				if (num == 68)
				{
					this.label7 = new Label();
					num = 69;
				}
				if (num == 69)
				{
					this.button6 = new Button();
					num = 70;
				}
				if (num == 70)
				{
					this.button8 = new Button();
					num = 71;
				}
				if (num == 71)
				{
					this.label3 = new Label();
					num = 72;
				}
				if (num == 72)
				{
					this.label4 = new Label();
					num = 73;
				}
				if (num == 73)
				{
					this.button1 = new Button();
					num = 74;
				}
				if (num == 74)
				{
					this.button7 = new Button();
					num = 75;
				}
				if (num == 75)
				{
					this.label81 = new Label();
					num = 76;
				}
				if (num == 76)
				{
					this.label6 = new Label();
					num = 77;
				}
				if (num == 77)
				{
					this.label37 = new Label();
					num = 78;
				}
				if (num == 78)
				{
					this.pkg_location = new TextBox();
					num = 79;
				}
				if (num == 80)
				{
					this.ProgressBar1 = new SiticoneProgressBar();
					num = 81;
				}
				if (num == 81)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 82;
				}
				if (num == 82)
				{
					this.panel1.SuspendLayout();
					num = 83;
				}
				if (num == 83)
				{
					base.SuspendLayout();
					num = 84;
				}
				if (num == 84)
				{
					this.label1.AutoSize = true;
					num = 85;
				}
				if (num == 85)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 86;
				}
				if (num == 86)
				{
					this.label1.ForeColor = Color.White;
					num = 87;
				}
				if (num == 87)
				{
					this.label1.Location = new Point(18, 0);
					num = 88;
				}
				if (num == 88)
				{
					this.label1.Name = "label1";
					num = 89;
				}
				if (num == 89)
				{
					this.label1.Size = new Size(251, 53);
					num = 90;
				}
				if (num == 90)
				{
					this.label1.TabIndex = 4;
					num = 91;
				}
				if (num == 91)
				{
					this.label1.Text = "Windows Apps";
					num = 92;
				}
				if (num == 93)
				{
					this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 94;
				}
				if (num == 94)
				{
					this.lblSpeed.ForeColor = Color.White;
					num = 95;
				}
				if (num == 95)
				{
					this.lblSpeed.Location = new Point(408, 630);
					num = 96;
				}
				if (num == 96)
				{
					this.lblSpeed.Name = "lblSpeed";
					num = 97;
				}
				if (num == 97)
				{
					this.lblSpeed.Size = new Size(0, 25);
					num = 98;
				}
				if (num == 98)
				{
					this.lblSpeed.TabIndex = 102;
					num = 99;
				}
				if (num == 99)
				{
					this.lblDownload.AutoSize = true;
					num = 100;
				}
				if (num == 100)
				{
					this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 101;
				}
				if (num == 101)
				{
					this.lblDownload.ForeColor = Color.White;
					num = 102;
				}
				if (num == 102)
				{
					this.lblDownload.Location = new Point(618, 628);
					num = 103;
				}
				if (num == 103)
				{
					this.lblDownload.Name = "lblDownload";
					num = 104;
				}
				if (num == 104)
				{
					this.lblDownload.Size = new Size(0, 25);
					num = 105;
				}
				if (num == 106)
				{
					this.label2.AutoSize = true;
					num = 107;
				}
				if (num == 107)
				{
					this.label2.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 108;
				}
				if (num == 108)
				{
					this.label2.ForeColor = Color.White;
					num = 109;
				}
				if (num == 109)
				{
					this.label2.Location = new Point(22, 630);
					num = 110;
				}
				if (num == 110)
				{
					this.label2.Name = "label2";
					num = 111;
				}
				if (num == 111)
				{
					this.label2.Size = new Size(112, 25);
					num = 112;
				}
				if (num == 112)
				{
					this.label2.TabIndex = 100;
					num = 113;
				}
				if (num == 113)
				{
					this.label2.Text = "Status : Idle....";
					num = 114;
				}
				if (num == 114)
				{
					this.button3.BackColor = Color.FromArgb(38, 38, 38);
					num = 115;
				}
				if (num == 115)
				{
					this.button3.BackgroundImageLayout = ImageLayout.None;
					num = 116;
				}
				if (num == 116)
				{
					this.button3.Cursor = Cursors.Hand;
					num = 117;
				}
				if (num == 117)
				{
					this.button3.FlatAppearance.BorderSize = 0;
					num = 118;
				}
				if (num == 119)
				{
					this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 120;
				}
				if (num == 120)
				{
					this.button3.ForeColor = Color.White;
					num = 121;
				}
				if (num == 121)
				{
					this.button3.ImageAlign = ContentAlignment.MiddleLeft;
					num = 122;
				}
				if (num == 122)
				{
					this.button3.Location = new Point(907, 598);
					num = 123;
				}
				if (num == 123)
				{
					this.button3.Margin = new Padding(1);
					num = 124;
				}
				if (num == 124)
				{
					this.button3.Name = "button3";
					num = 125;
				}
				if (num == 125)
				{
					this.button3.Size = new Size(84, 55);
					num = 126;
				}
				if (num == 126)
				{
					this.button3.TabIndex = 99;
					num = 127;
				}
				if (num == 127)
				{
					this.button3.TabStop = false;
					num = 128;
				}
				if (num == 128)
				{
					this.button3.Text = "Cancel";
					num = 129;
				}
				if (num == 129)
				{
					this.button3.UseVisualStyleBackColor = false;
					num = 130;
				}
				if (num == 130)
				{
					this.button3.Click += this.button3_Click;
					num = 131;
				}
				if (num == 131)
				{
					this.panel1.AutoScroll = true;
					num = 132;
				}
				if (num == 133)
				{
					this.panel1.Controls.Add(this.label42);
					num = 134;
				}
				if (num == 134)
				{
					this.panel1.Controls.Add(this.label41);
					num = 135;
				}
				if (num == 135)
				{
					this.panel1.Controls.Add(this.label40);
					num = 136;
				}
				if (num == 136)
				{
					this.panel1.Controls.Add(this.button9);
					num = 137;
				}
				if (num == 137)
				{
					this.panel1.Controls.Add(this.label39);
					num = 138;
				}
				if (num == 138)
				{
					this.panel1.Controls.Add(this.label38);
					num = 139;
				}
				if (num == 139)
				{
					this.panel1.Controls.Add(this.button2);
					num = 140;
				}
				if (num == 140)
				{
					this.panel1.Controls.Add(this.button4);
					num = 141;
				}
				if (num == 141)
				{
					this.panel1.Controls.Add(this.label35);
					num = 142;
				}
				if (num == 142)
				{
					this.panel1.Controls.Add(this.label36);
					num = 143;
				}
				if (num == 143)
				{
					this.panel1.Controls.Add(this.button40);
					num = 144;
				}
				if (num == 144)
				{
					this.panel1.Controls.Add(this.label33);
					num = 145;
				}
				if (num == 146)
				{
					this.panel1.Controls.Add(this.button39);
					num = 147;
				}
				if (num == 147)
				{
					this.panel1.Controls.Add(this.label31);
					num = 148;
				}
				if (num == 148)
				{
					this.panel1.Controls.Add(this.label32);
					num = 149;
				}
				if (num == 149)
				{
					this.panel1.Controls.Add(this.button38);
					num = 150;
				}
				if (num == 150)
				{
					this.panel1.Controls.Add(this.label29);
					num = 151;
				}
				if (num == 151)
				{
					this.panel1.Controls.Add(this.label30);
					num = 152;
				}
				if (num == 152)
				{
					this.panel1.Controls.Add(this.button37);
					num = 153;
				}
				if (num == 153)
				{
					this.panel1.Controls.Add(this.label27);
					num = 154;
				}
				if (num == 154)
				{
					this.panel1.Controls.Add(this.label28);
					num = 155;
				}
				if (num == 155)
				{
					this.panel1.Controls.Add(this.button36);
					num = 156;
				}
				if (num == 156)
				{
					this.panel1.Controls.Add(this.label25);
					num = 157;
				}
				if (num == 157)
				{
					this.panel1.Controls.Add(this.label26);
					num = 158;
				}
				if (num == 159)
				{
					this.panel1.Controls.Add(this.label23);
					num = 160;
				}
				if (num == 160)
				{
					this.panel1.Controls.Add(this.label24);
					num = 161;
				}
				if (num == 161)
				{
					this.panel1.Controls.Add(this.button34);
					num = 162;
				}
				if (num == 162)
				{
					this.panel1.Controls.Add(this.label21);
					num = 163;
				}
				if (num == 163)
				{
					this.panel1.Controls.Add(this.label22);
					num = 164;
				}
				if (num == 164)
				{
					this.panel1.Controls.Add(this.label20);
					num = 165;
				}
				if (num == 165)
				{
					this.panel1.Controls.Add(this.button32);
					num = 166;
				}
				if (num == 166)
				{
					this.panel1.Controls.Add(this.button33);
					num = 167;
				}
				if (num == 167)
				{
					this.panel1.Controls.Add(this.label18);
					num = 168;
				}
				if (num == 168)
				{
					this.panel1.Controls.Add(this.label19);
					num = 169;
				}
				if (num == 169)
				{
					this.panel1.Controls.Add(this.button29);
					num = 170;
				}
				if (num == 170)
				{
					this.panel1.Controls.Add(this.button30);
					num = 171;
				}
				if (num == 172)
				{
					this.panel1.Controls.Add(this.label17);
					num = 173;
				}
				if (num == 173)
				{
					this.panel1.Controls.Add(this.button26);
					num = 174;
				}
				if (num == 174)
				{
					this.panel1.Controls.Add(this.button27);
					num = 175;
				}
				if (num == 175)
				{
					this.panel1.Controls.Add(this.label14);
					num = 176;
				}
				if (num == 176)
				{
					this.panel1.Controls.Add(this.label15);
					num = 177;
				}
				if (num == 177)
				{
					this.panel1.Controls.Add(this.button19);
					num = 178;
				}
				if (num == 178)
				{
					this.panel1.Controls.Add(this.button20);
					num = 179;
				}
				if (num == 179)
				{
					this.panel1.Controls.Add(this.label12);
					num = 180;
				}
				if (num == 180)
				{
					this.panel1.Controls.Add(this.label13);
					num = 181;
				}
				if (num == 181)
				{
					this.panel1.Controls.Add(this.button16);
					num = 182;
				}
				if (num == 182)
				{
					this.panel1.Controls.Add(this.button17);
					num = 183;
				}
				if (num == 183)
				{
					this.panel1.Controls.Add(this.label10);
					num = 184;
				}
				if (num == 184)
				{
					this.panel1.Controls.Add(this.label11);
					num = 185;
				}
				if (num == 186)
				{
					this.panel1.Controls.Add(this.button14);
					num = 187;
				}
				if (num == 187)
				{
					this.panel1.Controls.Add(this.label8);
					num = 188;
				}
				if (num == 188)
				{
					this.panel1.Controls.Add(this.label9);
					num = 189;
				}
				if (num == 189)
				{
					this.panel1.Controls.Add(this.button10);
					num = 190;
				}
				if (num == 190)
				{
					this.panel1.Controls.Add(this.button11);
					num = 191;
				}
				if (num == 191)
				{
					this.panel1.Controls.Add(this.label5);
					num = 192;
				}
				if (num == 192)
				{
					this.panel1.Controls.Add(this.label7);
					num = 193;
				}
				if (num == 193)
				{
					this.panel1.Controls.Add(this.button6);
					num = 194;
				}
				if (num == 194)
				{
					this.panel1.Controls.Add(this.button8);
					num = 195;
				}
				if (num == 195)
				{
					this.panel1.Controls.Add(this.label3);
					num = 196;
				}
				if (num == 196)
				{
					this.panel1.Controls.Add(this.label4);
					num = 197;
				}
				if (num == 197)
				{
					this.panel1.Controls.Add(this.button1);
					num = 198;
				}
				if (num == 199)
				{
					this.panel1.Controls.Add(this.label81);
					num = 200;
				}
				if (num == 200)
				{
					this.panel1.Controls.Add(this.label6);
					num = 201;
				}
				if (num == 201)
				{
					this.panel1.Location = new Point(0, 81);
					num = 202;
				}
				if (num == 202)
				{
					this.panel1.Name = "panel1";
					num = 203;
				}
				if (num == 203)
				{
					this.panel1.Size = new Size(991, 496);
					num = 204;
				}
				if (num == 204)
				{
					this.panel1.TabIndex = 103;
					num = 205;
				}
				if (num == 205)
				{
					this.button5.BackColor = Color.FromArgb(38, 38, 38);
					num = 206;
				}
				if (num == 206)
				{
					this.button5.BackgroundImageLayout = ImageLayout.None;
					num = 207;
				}
				if (num == 207)
				{
					this.button5.Cursor = Cursors.Hand;
					num = 208;
				}
				if (num == 208)
				{
					this.button5.FlatAppearance.BorderSize = 0;
					num = 209;
				}
				if (num == 209)
				{
					this.button5.FlatStyle = FlatStyle.Flat;
					num = 210;
				}
				if (num == 210)
				{
					this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 211;
				}
				if (num == 212)
				{
					this.button5.Image = (Image)componentResourceManager.GetObject("button5.Image");
					num = 213;
				}
				if (num == 213)
				{
					this.button5.ImageAlign = ContentAlignment.MiddleLeft;
					num = 214;
				}
				if (num == 214)
				{
					this.button5.Location = new Point(812, 23);
					num = 215;
				}
				if (num == 215)
				{
					this.button5.Margin = new Padding(1);
					num = 216;
				}
				if (num == 216)
				{
					this.button5.Name = "button5";
					num = 217;
				}
				if (num == 217)
				{
					this.button5.Size = new Size(99, 30);
					num = 218;
				}
				if (num == 218)
				{
					this.button5.TabIndex = 347;
					num = 219;
				}
				if (num == 219)
				{
					this.button5.TabStop = false;
					num = 220;
				}
				if (num == 220)
				{
					this.button5.Text = "Install";
					num = 221;
				}
				if (num == 221)
				{
					this.button5.TextAlign = ContentAlignment.MiddleRight;
					num = 222;
				}
				if (num == 222)
				{
					this.button5.UseVisualStyleBackColor = false;
					num = 223;
				}
				if (num == 223)
				{
					this.button5.Click += this.button5_Click_1;
					num = 224;
				}
				if (num == 225)
				{
					this.label42.Font = new Font("Gill Sans MT", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 226;
				}
				if (num == 226)
				{
					this.label42.ForeColor = Color.Silver;
					num = 227;
				}
				if (num == 227)
				{
					this.label42.Location = new Point(16, 93);
					num = 228;
				}
				if (num == 228)
				{
					this.label42.Name = "label42";
					num = 229;
				}
				if (num == 229)
				{
					this.label42.Size = new Size(932, 18);
					num = 230;
				}
				if (num == 230)
				{
					this.label42.TabIndex = 346;
					num = 231;
				}
				if (num == 231)
				{
					this.label42.Text = "____________________________________________________________________________________________________________________________________";
					num = 232;
				}
				if (num == 232)
				{
					this.label41.AutoSize = true;
					num = 233;
				}
				if (num == 233)
				{
					this.label41.Font = new Font("Josefin Sans SemiBold", 20f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 234;
				}
				if (num == 234)
				{
					this.label41.ForeColor = Color.White;
					num = 235;
				}
				if (num == 235)
				{
					this.label41.Location = new Point(14, 123);
					num = 236;
				}
				if (num == 236)
				{
					this.label41.Name = "label41";
					num = 237;
				}
				if (num == 238)
				{
					this.label41.TabIndex = 345;
					num = 239;
				}
				if (num == 239)
				{
					this.label41.Text = "UWP Apps";
					num = 240;
				}
				if (num == 240)
				{
					this.label40.AutoSize = true;
					num = 241;
				}
				if (num == 241)
				{
					this.label40.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 242;
				}
				if (num == 242)
				{
					this.label40.ForeColor = Color.Silver;
					num = 243;
				}
				if (num == 243)
				{
					this.label40.Location = new Point(23, 65);
					num = 244;
				}
				if (num == 244)
				{
					this.label40.Name = "label40";
					num = 245;
				}
				if (num == 245)
				{
					this.label40.Size = new Size(822, 19);
					num = 246;
				}
				if (num == 246)
				{
					this.label40.TabIndex = 344;
					num = 247;
				}
				if (num == 247)
				{
					this.label40.Text = "Before downloading any UWP apps from below, download the required frameworks, runtime, and VClibs. Extract the zip file and run installer.bat file";
					num = 248;
				}
				if (num == 248)
				{
					this.button9.BackColor = Color.FromArgb(38, 38, 38);
					num = 249;
				}
				if (num == 249)
				{
					this.button9.BackgroundImageLayout = ImageLayout.None;
					num = 250;
				}
				if (num == 250)
				{
					this.button9.Cursor = Cursors.Hand;
					num = 251;
				}
				if (num == 252)
				{
					this.button9.FlatStyle = FlatStyle.Flat;
					num = 253;
				}
				if (num == 253)
				{
					this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 254;
				}
				if (num == 254)
				{
					this.button9.ForeColor = Color.White;
					num = 255;
				}
				if (num == 255)
				{
					this.button9.Image = (Image)componentResourceManager.GetObject("button9.Image");
					num = 256;
				}
				if (num == 256)
				{
					this.button9.ImageAlign = ContentAlignment.MiddleLeft;
					num = 257;
				}
				if (num == 257)
				{
					this.button9.Location = new Point(632, 23);
					num = 258;
				}
				if (num == 258)
				{
					this.button9.Margin = new Padding(1);
					num = 259;
				}
				if (num == 259)
				{
					this.button9.Name = "button9";
					num = 260;
				}
				if (num == 260)
				{
					this.button9.Size = new Size(120, 30);
					num = 261;
				}
				if (num == 261)
				{
					this.button9.TabIndex = 343;
					num = 262;
				}
				if (num == 262)
				{
					this.button9.TabStop = false;
					num = 263;
				}
				if (num == 263)
				{
					this.button9.Text = "Download";
					num = 264;
				}
				if (num == 265)
				{
					this.button9.UseVisualStyleBackColor = false;
					num = 266;
				}
				if (num == 266)
				{
					this.button9.Click += this.button9_Click;
					num = 267;
				}
				if (num == 267)
				{
					this.label39.AutoSize = true;
					num = 268;
				}
				if (num == 268)
				{
					this.label39.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 269;
				}
				if (num == 269)
				{
					this.label39.ForeColor = Color.White;
					num = 270;
				}
				if (num == 270)
				{
					this.label39.Location = new Point(457, 23);
					num = 271;
				}
				if (num == 271)
				{
					this.label39.Name = "label39";
					num = 272;
				}
				if (num == 272)
				{
					this.label39.Size = new Size(124, 30);
					num = 273;
				}
				if (num == 273)
				{
					this.label39.TabIndex = 342;
					num = 274;
				}
				if (num == 274)
				{
					this.label39.Text = "| Size : 52MB";
					num = 275;
				}
				if (num == 275)
				{
					this.label38.AutoSize = true;
					num = 276;
				}
				if (num == 276)
				{
					this.label38.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 277;
				}
				if (num == 278)
				{
					this.label38.Location = new Point(14, 23);
					num = 279;
				}
				if (num == 279)
				{
					this.label38.Name = "label38";
					num = 280;
				}
				if (num == 280)
				{
					this.label38.Size = new Size(343, 30);
					num = 281;
				}
				if (num == 281)
				{
					this.label38.TabIndex = 341;
					num = 282;
				}
				if (num == 282)
				{
					this.label38.Text = "• Required Framwork/Runtime/VCLibs";
					num = 283;
				}
				if (num == 283)
				{
					this.button2.BackColor = Color.FromArgb(38, 38, 38);
					num = 284;
				}
				if (num == 284)
				{
					this.button2.BackgroundImageLayout = ImageLayout.None;
					num = 285;
				}
				if (num == 285)
				{
					this.button2.Cursor = Cursors.Hand;
					num = 286;
				}
				if (num == 286)
				{
					this.button2.FlatAppearance.BorderSize = 0;
					num = 287;
				}
				if (num == 287)
				{
					this.button2.FlatStyle = FlatStyle.Flat;
					num = 288;
				}
				if (num == 288)
				{
					this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 289;
				}
				if (num == 289)
				{
					this.button2.ForeColor = Color.White;
					num = 290;
				}
				if (num == 291)
				{
					this.button2.ImageAlign = ContentAlignment.MiddleLeft;
					num = 292;
				}
				if (num == 292)
				{
					this.button2.Location = new Point(812, 182);
					num = 293;
				}
				if (num == 293)
				{
					this.button2.Margin = new Padding(1);
					num = 294;
				}
				if (num == 294)
				{
					this.button2.Name = "button2";
					num = 295;
				}
				if (num == 295)
				{
					this.button2.Size = new Size(99, 30);
					num = 296;
				}
				if (num == 296)
				{
					this.button2.TabIndex = 340;
					num = 297;
				}
				if (num == 297)
				{
					this.button2.TabStop = false;
					num = 298;
				}
				if (num == 298)
				{
					this.button2.Text = "Install";
					num = 299;
				}
				if (num == 299)
				{
					this.button2.TextAlign = ContentAlignment.MiddleRight;
					num = 300;
				}
				if (num == 300)
				{
					this.button2.UseVisualStyleBackColor = false;
					num = 301;
				}
				if (num == 301)
				{
					this.button2.Click += this.button2_Click;
					num = 302;
				}
				if (num == 302)
				{
					this.button4.BackColor = Color.FromArgb(38, 38, 38);
					num = 303;
				}
				if (num == 303)
				{
					this.button4.BackgroundImageLayout = ImageLayout.None;
					num = 304;
				}
				if (num == 305)
				{
					this.button4.FlatAppearance.BorderSize = 0;
					num = 306;
				}
				if (num == 306)
				{
					this.button4.FlatStyle = FlatStyle.Flat;
					num = 307;
				}
				if (num == 307)
				{
					this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 308;
				}
				if (num == 308)
				{
					this.button4.ForeColor = Color.White;
					num = 309;
				}
				if (num == 309)
				{
					this.button4.Image = (Image)componentResourceManager.GetObject("button4.Image");
					num = 310;
				}
				if (num == 310)
				{
					this.button4.ImageAlign = ContentAlignment.MiddleLeft;
					num = 311;
				}
				if (num == 311)
				{
					this.button4.Location = new Point(632, 182);
					num = 312;
				}
				if (num == 312)
				{
					this.button4.Margin = new Padding(1);
					num = 313;
				}
				if (num == 313)
				{
					this.button4.Name = "button4";
					num = 314;
				}
				if (num == 314)
				{
					this.button4.Size = new Size(120, 30);
					num = 315;
				}
				if (num == 315)
				{
					this.button4.TabIndex = 339;
					num = 316;
				}
				if (num == 316)
				{
					this.button4.TabStop = false;
					num = 317;
				}
				if (num == 318)
				{
					this.button4.TextAlign = ContentAlignment.MiddleRight;
					num = 319;
				}
				if (num == 319)
				{
					this.button4.UseVisualStyleBackColor = false;
					num = 320;
				}
				if (num == 320)
				{
					this.button4.Click += this.button4_Click;
					num = 321;
				}
				if (num == 321)
				{
					this.label35.AutoSize = true;
					num = 322;
				}
				if (num == 322)
				{
					this.label35.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 323;
				}
				if (num == 323)
				{
					this.label35.ForeColor = Color.White;
					num = 324;
				}
				if (num == 324)
				{
					this.label35.Location = new Point(457, 182);
					num = 325;
				}
				if (num == 325)
				{
					this.label35.Name = "label35";
					num = 326;
				}
				if (num == 326)
				{
					this.label35.Size = new Size(126, 30);
					num = 327;
				}
				if (num == 327)
				{
					this.label35.TabIndex = 338;
					num = 328;
				}
				if (num == 328)
				{
					this.label35.Text = "| Size : 211MB";
					num = 329;
				}
				if (num == 329)
				{
					this.label36.AutoSize = true;
					num = 330;
				}
				if (num == 331)
				{
					this.label36.ForeColor = Color.White;
					num = 332;
				}
				if (num == 332)
				{
					this.label36.Location = new Point(14, 182);
					num = 333;
				}
				if (num == 333)
				{
					this.label36.Name = "label36";
					num = 334;
				}
				if (num == 334)
				{
					this.label36.Size = new Size(227, 30);
					num = 335;
				}
				if (num == 335)
				{
					this.label36.TabIndex = 337;
					num = 336;
				}
				if (num == 336)
				{
					this.label36.Text = "• AMD Radeon Software";
					num = 337;
				}
				if (num == 337)
				{
					this.button40.BackColor = Color.FromArgb(38, 38, 38);
					num = 338;
				}
				if (num == 338)
				{
					this.button40.BackgroundImageLayout = ImageLayout.None;
					num = 339;
				}
				if (num == 339)
				{
					this.button40.Cursor = Cursors.Hand;
					num = 340;
				}
				if (num == 340)
				{
					this.button40.FlatAppearance.BorderSize = 0;
					num = 341;
				}
				if (num == 341)
				{
					this.button40.FlatStyle = FlatStyle.Flat;
					num = 342;
				}
				if (num == 342)
				{
					this.button40.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 343;
				}
				if (num == 344)
				{
					this.button40.Image = (Image)componentResourceManager.GetObject("button40.Image");
					num = 345;
				}
				if (num == 345)
				{
					this.button40.ImageAlign = ContentAlignment.MiddleLeft;
					num = 346;
				}
				if (num == 346)
				{
					this.button40.Location = new Point(773, 990);
					num = 347;
				}
				if (num == 347)
				{
					this.button40.Margin = new Padding(1);
					num = 348;
				}
				if (num == 348)
				{
					this.button40.Name = "button40";
					num = 349;
				}
				if (num == 349)
				{
					this.button40.Size = new Size(120, 30);
					num = 350;
				}
				if (num == 350)
				{
					this.button40.TabIndex = 336;
					num = 351;
				}
				if (num == 351)
				{
					this.button40.TabStop = false;
					num = 352;
				}
				if (num == 352)
				{
					this.button40.Text = "Download";
					num = 353;
				}
				if (num == 353)
				{
					this.button40.TextAlign = ContentAlignment.MiddleRight;
					num = 354;
				}
				if (num == 354)
				{
					this.button40.UseVisualStyleBackColor = false;
					num = 355;
				}
				if (num == 355)
				{
					this.button40.Click += this.button40_Click;
					num = 356;
				}
				if (num == 357)
				{
					this.label33.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 358;
				}
				if (num == 358)
				{
					this.label33.ForeColor = Color.White;
					num = 359;
				}
				if (num == 359)
				{
					this.label33.Location = new Point(513, 990);
					num = 360;
				}
				if (num == 360)
				{
					this.label33.Name = "label33";
					num = 361;
				}
				if (num == 361)
				{
					this.label33.Size = new Size(124, 30);
					num = 362;
				}
				if (num == 362)
				{
					this.label33.TabIndex = 335;
					num = 363;
				}
				if (num == 363)
				{
					this.label33.Text = "| Size : 95MB";
					num = 364;
				}
				if (num == 364)
				{
					this.label34.AutoSize = true;
					num = 365;
				}
				if (num == 365)
				{
					this.label34.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 366;
				}
				if (num == 366)
				{
					this.label34.ForeColor = Color.White;
					num = 367;
				}
				if (num == 367)
				{
					this.label34.Location = new Point(14, 990);
					num = 368;
				}
				if (num == 368)
				{
					this.label34.Name = "label34";
					num = 369;
				}
				if (num == 369)
				{
					this.label34.Size = new Size(306, 30);
					num = 370;
				}
				if (num == 371)
				{
					this.label34.Text = "• Visual C++ AIO Redistributables";
					num = 372;
				}
				if (num == 372)
				{
					this.button39.BackColor = Color.FromArgb(38, 38, 38);
					num = 373;
				}
				if (num == 373)
				{
					this.button39.BackgroundImageLayout = ImageLayout.None;
					num = 374;
				}
				if (num == 374)
				{
					this.button39.Cursor = Cursors.Hand;
					num = 375;
				}
				if (num == 375)
				{
					this.button39.FlatAppearance.BorderSize = 0;
					num = 376;
				}
				if (num == 376)
				{
					this.button39.FlatStyle = FlatStyle.Flat;
					num = 377;
				}
				if (num == 377)
				{
					this.button39.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 378;
				}
				if (num == 378)
				{
					this.button39.ForeColor = Color.White;
					num = 379;
				}
				if (num == 379)
				{
					this.button39.Image = (Image)componentResourceManager.GetObject("button39.Image");
					num = 380;
				}
				if (num == 380)
				{
					this.button39.ImageAlign = ContentAlignment.MiddleLeft;
					num = 381;
				}
				if (num == 381)
				{
					this.button39.Location = new Point(773, 946);
					num = 382;
				}
				if (num == 382)
				{
					this.button39.Margin = new Padding(1);
					num = 383;
				}
				if (num == 384)
				{
					this.button39.Size = new Size(120, 30);
					num = 385;
				}
				if (num == 385)
				{
					this.button39.TabIndex = 333;
					num = 386;
				}
				if (num == 386)
				{
					this.button39.TabStop = false;
					num = 387;
				}
				if (num == 387)
				{
					this.button39.Text = "Download";
					num = 388;
				}
				if (num == 388)
				{
					this.button39.TextAlign = ContentAlignment.MiddleRight;
					num = 389;
				}
				if (num == 389)
				{
					this.button39.UseVisualStyleBackColor = false;
					num = 390;
				}
				if (num == 390)
				{
					this.button39.Click += this.button39_Click;
					num = 391;
				}
				if (num == 391)
				{
					this.label31.AutoSize = true;
					num = 392;
				}
				if (num == 392)
				{
					this.label31.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 393;
				}
				if (num == 393)
				{
					this.label31.ForeColor = Color.White;
					num = 394;
				}
				if (num == 394)
				{
					this.label31.Location = new Point(513, 946);
					num = 395;
				}
				if (num == 395)
				{
					this.label31.Name = "label31";
					num = 396;
				}
				if (num == 397)
				{
					this.label31.TabIndex = 332;
					num = 398;
				}
				if (num == 398)
				{
					this.label31.Text = "| Size : 3MB";
					num = 399;
				}
				if (num == 399)
				{
					this.label32.AutoSize = true;
					num = 400;
				}
				if (num == 400)
				{
					this.label32.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 401;
				}
				if (num == 401)
				{
					this.label32.ForeColor = Color.White;
					num = 402;
				}
				if (num == 402)
				{
					this.label32.Location = new Point(14, 946);
					num = 403;
				}
				if (num == 403)
				{
					this.label32.Name = "label32";
					num = 404;
				}
				if (num == 404)
				{
					this.label32.Size = new Size(241, 30);
					num = 405;
				}
				if (num == 405)
				{
					this.label32.TabIndex = 331;
					num = 406;
				}
				if (num == 406)
				{
					this.label32.Text = "• Microsoft Paint (Classic)";
					num = 407;
				}
				if (num == 407)
				{
					this.button38.BackColor = Color.FromArgb(38, 38, 38);
					num = 408;
				}
				if (num == 408)
				{
					this.button38.BackgroundImageLayout = ImageLayout.None;
					num = 409;
				}
				if (num == 410)
				{
					this.button38.FlatAppearance.BorderSize = 0;
					num = 411;
				}
				if (num == 411)
				{
					this.button38.FlatStyle = FlatStyle.Flat;
					num = 412;
				}
				if (num == 412)
				{
					this.button38.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 413;
				}
				if (num == 413)
				{
					this.button38.ForeColor = Color.White;
					num = 414;
				}
				if (num == 414)
				{
					this.button38.Image = (Image)componentResourceManager.GetObject("button38.Image");
					num = 415;
				}
				if (num == 415)
				{
					this.button38.ImageAlign = ContentAlignment.MiddleLeft;
					num = 416;
				}
				if (num == 416)
				{
					this.button38.Location = new Point(773, 902);
					num = 417;
				}
				if (num == 417)
				{
					this.button38.Margin = new Padding(1);
					num = 418;
				}
				if (num == 418)
				{
					this.button38.Name = "button38";
					num = 419;
				}
				if (num == 419)
				{
					this.button38.Size = new Size(120, 30);
					num = 420;
				}
				if (num == 420)
				{
					this.button38.TabIndex = 330;
					num = 421;
				}
				if (num == 421)
				{
					this.button38.TabStop = false;
					num = 422;
				}
				if (num == 423)
				{
					this.button38.TextAlign = ContentAlignment.MiddleRight;
					num = 424;
				}
				if (num == 424)
				{
					this.button38.UseVisualStyleBackColor = false;
					num = 425;
				}
				if (num == 425)
				{
					this.button38.Click += this.button38_Click;
					num = 426;
				}
				if (num == 426)
				{
					this.label29.AutoSize = true;
					num = 427;
				}
				if (num == 427)
				{
					this.label29.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 428;
				}
				if (num == 428)
				{
					this.label29.ForeColor = Color.White;
					num = 429;
				}
				if (num == 429)
				{
					this.label29.Location = new Point(513, 902);
					num = 430;
				}
				if (num == 430)
				{
					this.label29.Name = "label29";
					num = 431;
				}
				if (num == 431)
				{
					this.label29.Size = new Size(110, 30);
					num = 432;
				}
				if (num == 432)
				{
					this.label29.TabIndex = 329;
					num = 433;
				}
				if (num == 433)
				{
					this.label29.Text = "| Size : 1MB";
					num = 434;
				}
				if (num == 434)
				{
					this.label30.AutoSize = true;
					num = 435;
				}
				if (num == 435)
				{
					this.label30.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 436;
				}
				if (num == 437)
				{
					this.label30.Location = new Point(14, 902);
					num = 438;
				}
				if (num == 438)
				{
					this.label30.Name = "label30";
					num = 439;
				}
				if (num == 439)
				{
					this.label30.Size = new Size(253, 30);
					num = 440;
				}
				if (num == 440)
				{
					this.label30.TabIndex = 328;
					num = 441;
				}
				if (num == 441)
				{
					this.label30.Text = "• Microsoft Edge Chromium";
					num = 442;
				}
				if (num == 442)
				{
					this.button37.BackColor = Color.FromArgb(38, 38, 38);
					num = 443;
				}
				if (num == 443)
				{
					this.button37.BackgroundImageLayout = ImageLayout.None;
					num = 444;
				}
				if (num == 444)
				{
					this.button37.Cursor = Cursors.Hand;
					num = 445;
				}
				if (num == 445)
				{
					this.button37.FlatAppearance.BorderSize = 0;
					num = 446;
				}
				if (num == 446)
				{
					this.button37.FlatStyle = FlatStyle.Flat;
					num = 447;
				}
				if (num == 447)
				{
					this.button37.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 448;
				}
				if (num == 448)
				{
					this.button37.ForeColor = Color.White;
					num = 449;
				}
				if (num == 450)
				{
					this.button37.ImageAlign = ContentAlignment.MiddleLeft;
					num = 451;
				}
				if (num == 451)
				{
					this.button37.Location = new Point(773, 858);
					num = 452;
				}
				if (num == 452)
				{
					this.button37.Margin = new Padding(1);
					num = 453;
				}
				if (num == 453)
				{
					this.button37.Name = "button37";
					num = 454;
				}
				if (num == 454)
				{
					this.button37.Size = new Size(120, 30);
					num = 455;
				}
				if (num == 455)
				{
					this.button37.TabIndex = 327;
					num = 456;
				}
				if (num == 456)
				{
					this.button37.TabStop = false;
					num = 457;
				}
				if (num == 457)
				{
					this.button37.Text = "Download";
					num = 458;
				}
				if (num == 458)
				{
					this.button37.TextAlign = ContentAlignment.MiddleRight;
					num = 459;
				}
				if (num == 459)
				{
					this.button37.UseVisualStyleBackColor = false;
					num = 460;
				}
				if (num == 460)
				{
					this.button37.Click += this.button37_Click;
					num = 461;
				}
				if (num == 461)
				{
					this.label27.AutoSize = true;
					num = 462;
				}
				if (num == 463)
				{
					this.label27.ForeColor = Color.White;
					num = 464;
				}
				if (num == 464)
				{
					this.label27.Location = new Point(513, 858);
					num = 465;
				}
				if (num == 465)
				{
					this.label27.Name = "label27";
					num = 466;
				}
				if (num == 466)
				{
					this.label27.Size = new Size(110, 30);
					num = 467;
				}
				if (num == 467)
				{
					this.label27.TabIndex = 326;
					num = 468;
				}
				if (num == 468)
				{
					this.label27.Text = "| Size : 1MB";
					num = 469;
				}
				if (num == 469)
				{
					this.label28.AutoSize = true;
					num = 470;
				}
				if (num == 470)
				{
					this.label28.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 471;
				}
				if (num == 471)
				{
					this.label28.ForeColor = Color.White;
					num = 472;
				}
				if (num == 472)
				{
					this.label28.Location = new Point(14, 858);
					num = 473;
				}
				if (num == 473)
				{
					this.label28.Name = "label28";
					num = 474;
				}
				if (num == 474)
				{
					this.label28.Size = new Size(284, 30);
					num = 475;
				}
				if (num == 476)
				{
					this.label28.Text = "• Microsoft Calculator (Classic)";
					num = 477;
				}
				if (num == 477)
				{
					this.button36.BackColor = Color.FromArgb(38, 38, 38);
					num = 478;
				}
				if (num == 478)
				{
					this.button36.BackgroundImageLayout = ImageLayout.None;
					num = 479;
				}
				if (num == 479)
				{
					this.button36.Cursor = Cursors.Hand;
					num = 480;
				}
				if (num == 480)
				{
					this.button36.FlatAppearance.BorderSize = 0;
					num = 481;
				}
				if (num == 481)
				{
					this.button36.FlatStyle = FlatStyle.Flat;
					num = 482;
				}
				if (num == 482)
				{
					this.button36.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 483;
				}
				if (num == 483)
				{
					this.button36.ForeColor = Color.White;
					num = 484;
				}
				if (num == 484)
				{
					this.button36.Image = (Image)componentResourceManager.GetObject("button36.Image");
					num = 485;
				}
				if (num == 485)
				{
					this.button36.ImageAlign = ContentAlignment.MiddleLeft;
					num = 486;
				}
				if (num == 486)
				{
					this.button36.Location = new Point(773, 814);
					num = 487;
				}
				if (num == 487)
				{
					this.button36.Margin = new Padding(1);
					num = 488;
				}
				if (num == 488)
				{
					this.button36.Name = "button36";
					num = 489;
				}
				if (num == 490)
				{
					this.button36.TabIndex = 324;
					num = 491;
				}
				if (num == 491)
				{
					this.button36.TabStop = false;
					num = 492;
				}
				if (num == 492)
				{
					this.button36.Text = "Download";
					num = 493;
				}
				if (num == 493)
				{
					this.button36.TextAlign = ContentAlignment.MiddleRight;
					num = 494;
				}
				if (num == 494)
				{
					this.button36.UseVisualStyleBackColor = false;
					num = 495;
				}
				if (num == 495)
				{
					this.button36.Click += this.button36_Click;
					num = 496;
				}
				if (num == 496)
				{
					this.label25.AutoSize = true;
					num = 497;
				}
				if (num == 497)
				{
					this.label25.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 498;
				}
				if (num == 498)
				{
					this.label25.ForeColor = Color.White;
					num = 499;
				}
				if (num == 499)
				{
					this.label25.Location = new Point(513, 814);
					num = 500;
				}
				if (num == 500)
				{
					this.label25.Name = "label25";
					num = 501;
				}
				if (num == 501)
				{
					this.label25.Size = new Size(129, 30);
					num = 502;
				}
				if (num == 611)
				{
					this.button33.Cursor = Cursors.Hand;
					num = 612;
				}
				if (num == 612)
				{
					this.button33.FlatAppearance.BorderSize = 0;
					num = 613;
				}
				if (num == 613)
				{
					this.button33.FlatStyle = FlatStyle.Flat;
					num = 614;
				}
				if (num == 615)
				{
					this.button33.ForeColor = Color.White;
					num = 616;
				}
				if (num == 616)
				{
					this.button33.Image = (Image)componentResourceManager.GetObject("button33.Image");
					num = 617;
				}
				if (num == 617)
				{
					this.button33.ImageAlign = ContentAlignment.MiddleLeft;
					num = 618;
				}
				if (num == 619)
				{
					this.button33.Margin = new Padding(1);
					num = 620;
				}
				if (num == 620)
				{
					this.button33.Name = "button33";
					num = 621;
				}
				if (num == 621)
				{
					this.button33.Size = new Size(120, 30);
					num = 622;
				}
				if (num == 623)
				{
					this.button33.TabStop = false;
					num = 624;
				}
				if (num == 624)
				{
					this.button33.Text = "Download";
					num = 625;
				}
				if (num == 625)
				{
					this.button33.TextAlign = ContentAlignment.MiddleRight;
					num = 626;
				}
				if (num == 627)
				{
					this.button33.Click += this.button33_Click;
					num = 628;
				}
				if (num == 628)
				{
					this.label18.AutoSize = true;
					num = 629;
				}
				if (num == 629)
				{
					this.label18.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 630;
				}
				if (num == 630)
				{
					this.label18.ForeColor = Color.White;
					num = 631;
				}
				if (num == 632)
				{
					this.label18.Name = "label18";
					num = 633;
				}
				if (num == 633)
				{
					this.label18.Size = new Size(124, 30);
					num = 634;
				}
				if (num == 634)
				{
					this.label18.TabIndex = 311;
					num = 635;
				}
				if (num == 636)
				{
					this.label19.AutoSize = true;
					num = 637;
				}
				if (num == 637)
				{
					this.label19.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 638;
				}
				if (num == 638)
				{
					this.label19.ForeColor = Color.White;
					num = 639;
				}
				if (num == 640)
				{
					this.label19.Name = "label19";
					num = 641;
				}
				if (num == 641)
				{
					this.label19.Size = new Size(164, 30);
					num = 642;
				}
				if (num == 642)
				{
					this.label19.TabIndex = 310;
					num = 643;
				}
				if (num == 644)
				{
					this.button29.BackColor = Color.FromArgb(38, 38, 38);
					num = 645;
				}
				if (num == 645)
				{
					this.button29.BackgroundImageLayout = ImageLayout.None;
					num = 646;
				}
				if (num == 646)
				{
					this.button29.Cursor = Cursors.Hand;
					num = 647;
				}
				if (num == 648)
				{
					this.button29.FlatStyle = FlatStyle.Flat;
					num = 649;
				}
				if (num == 649)
				{
					this.button29.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 650;
				}
				if (num == 650)
				{
					this.button29.ForeColor = Color.White;
					num = 651;
				}
				if (num == 652)
				{
					this.button29.ImageAlign = ContentAlignment.MiddleLeft;
					num = 653;
				}
				if (num == 653)
				{
					this.button29.Location = new Point(812, 517);
					num = 654;
				}
				if (num == 654)
				{
					this.button29.Margin = new Padding(1);
					num = 655;
				}
				if (num == 655)
				{
					this.button29.Name = "button29";
					num = 656;
				}
				if (num == 657)
				{
					this.button29.TabIndex = 308;
					num = 658;
				}
				if (num == 658)
				{
					this.button29.TabStop = false;
					num = 659;
				}
				if (num == 659)
				{
					this.button29.Text = "Install";
					num = 660;
				}
				if (num == 661)
				{
					this.button29.UseVisualStyleBackColor = false;
					num = 662;
				}
				if (num == 662)
				{
					this.button29.Click += this.button29_Click;
					num = 663;
				}
				if (num == 663)
				{
					this.button30.BackColor = Color.FromArgb(38, 38, 38);
					num = 664;
				}
				if (num == 665)
				{
					this.button30.Cursor = Cursors.Hand;
					num = 666;
				}
				if (num == 666)
				{
					this.button30.FlatAppearance.BorderSize = 0;
					num = 667;
				}
				if (num == 667)
				{
					this.button30.FlatStyle = FlatStyle.Flat;
					num = 668;
				}
				if (num == 669)
				{
					this.button30.ForeColor = Color.White;
					num = 670;
				}
				if (num == 670)
				{
					this.button30.Image = (Image)componentResourceManager.GetObject("button30.Image");
					num = 671;
				}
				if (num == 671)
				{
					this.button30.ImageAlign = ContentAlignment.MiddleLeft;
					num = 672;
				}
				if (num == 673)
				{
					this.button30.Margin = new Padding(1);
					num = 674;
				}
				if (num == 674)
				{
					this.button30.Name = "button30";
					num = 675;
				}
				if (num == 675)
				{
					this.button30.Size = new Size(120, 30);
					num = 676;
				}
				if (num == 676)
				{
					this.button30.TabIndex = 307;
					num = 677;
				}
				if (num == 678)
				{
					this.button30.Text = "Download";
					num = 679;
				}
				if (num == 679)
				{
					this.button30.TextAlign = ContentAlignment.MiddleRight;
					num = 680;
				}
				if (num == 680)
				{
					this.button30.UseVisualStyleBackColor = false;
					num = 681;
				}
				if (num == 682)
				{
					this.label16.AutoSize = true;
					num = 683;
				}
				if (num == 683)
				{
					this.label16.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 684;
				}
				if (num == 684)
				{
					this.label16.ForeColor = Color.White;
					num = 685;
				}
				if (num == 686)
				{
					this.label16.Name = "label16";
					num = 687;
				}
				if (num == 687)
				{
					this.label16.Size = new Size(123, 30);
					num = 688;
				}
				if (num == 688)
				{
					this.label16.TabIndex = 306;
					num = 689;
				}
				if (num == 690)
				{
					this.label17.AutoSize = true;
					num = 691;
				}
				if (num == 691)
				{
					this.label17.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 692;
				}
				if (num == 692)
				{
					this.label17.ForeColor = Color.White;
					num = 693;
				}
				if (num == 694)
				{
					this.label17.Name = "label17";
					num = 695;
				}
				if (num == 695)
				{
					this.label17.Size = new Size(185, 30);
					num = 696;
				}
				if (num == 696)
				{
					this.label17.TabIndex = 305;
					num = 697;
				}
				if (num == 698)
				{
					this.button26.BackColor = Color.FromArgb(38, 38, 38);
					num = 699;
				}
				if (num == 699)
				{
					this.button26.BackgroundImageLayout = ImageLayout.None;
					num = 700;
				}
				if (num == 700)
				{
					this.button26.Cursor = Cursors.Hand;
					num = 701;
				}
				if (num == 701)
				{
					this.button26.FlatAppearance.BorderSize = 0;
					num = 702;
				}
				if (num == 703)
				{
					this.button26.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 704;
				}
				if (num == 704)
				{
					this.button26.ForeColor = Color.White;
					num = 705;
				}
				if (num == 705)
				{
					this.button26.Image = (Image)componentResourceManager.GetObject("button26.Image");
					num = 706;
				}
				if (num == 707)
				{
					this.button26.Location = new Point(812, 469);
					num = 708;
				}
				if (num == 708)
				{
					this.button26.Margin = new Padding(1);
					num = 709;
				}
				if (num == 709)
				{
					this.button26.Name = "button26";
					num = 710;
				}
				if (num == 711)
				{
					this.button26.TabIndex = 303;
					num = 712;
				}
				if (num == 712)
				{
					this.button26.TabStop = false;
					num = 713;
				}
				if (num == 713)
				{
					this.button26.Text = "Install";
					num = 714;
				}
				if (num == 715)
				{
					this.button26.UseVisualStyleBackColor = false;
					num = 716;
				}
				if (num == 716)
				{
					this.button26.Click += this.button26_Click;
					num = 717;
				}
				if (num == 717)
				{
					this.button27.BackColor = Color.FromArgb(38, 38, 38);
					num = 718;
				}
				if (num == 719)
				{
					this.button27.Cursor = Cursors.Hand;
					num = 720;
				}
				if (num == 720)
				{
					this.button27.FlatAppearance.BorderSize = 0;
					num = 721;
				}
				if (num == 721)
				{
					this.button27.FlatStyle = FlatStyle.Flat;
					num = 722;
				}
				if (num == 722)
				{
					this.button27.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 723;
				}
				if (num == 724)
				{
					this.button27.Image = (Image)componentResourceManager.GetObject("button27.Image");
					num = 725;
				}
				if (num == 725)
				{
					this.button27.ImageAlign = ContentAlignment.MiddleLeft;
					num = 726;
				}
				if (num == 726)
				{
					this.button27.Location = new Point(632, 469);
					num = 727;
				}
				if (num == 728)
				{
					this.button27.Name = "button27";
					num = 729;
				}
				if (num == 729)
				{
					this.button27.Size = new Size(120, 30);
					num = 730;
				}
				if (num == 730)
				{
					this.button27.TabIndex = 302;
					num = 731;
				}
				if (num == 732)
				{
					this.button27.Text = "Download";
					num = 733;
				}
				if (num == 733)
				{
					this.button27.TextAlign = ContentAlignment.MiddleRight;
					num = 734;
				}
				if (num == 734)
				{
					this.button27.UseVisualStyleBackColor = false;
					num = 735;
				}
				if (num == 736)
				{
					this.label14.AutoSize = true;
					num = 737;
				}
				if (num == 737)
				{
					this.label14.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 738;
				}
				if (num == 738)
				{
					this.label14.ForeColor = Color.White;
					num = 739;
				}
				if (num == 740)
				{
					this.label14.Name = "label14";
					num = 741;
				}
				if (num == 741)
				{
					this.label14.Size = new Size(114, 30);
					num = 742;
				}
				if (num == 742)
				{
					this.label14.TabIndex = 301;
					num = 743;
				}
				if (num == 744)
				{
					this.label15.AutoSize = true;
					num = 745;
				}
				if (num == 745)
				{
					this.label15.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 746;
				}
				if (num == 746)
				{
					this.label15.ForeColor = Color.White;
					num = 747;
				}
				if (num == 747)
				{
					this.label15.Location = new Point(14, 469);
					num = 748;
				}
				if (num == 749)
				{
					this.label15.Size = new Size(220, 30);
					num = 750;
				}
				if (num == 750)
				{
					this.label15.TabIndex = 300;
					num = 751;
				}
				if (num == 751)
				{
					this.label15.Text = "• NVIDIA Control Panel";
					num = 752;
				}
				if (num == 753)
				{
					this.button19.BackgroundImageLayout = ImageLayout.None;
					num = 754;
				}
				if (num == 754)
				{
					this.button19.Cursor = Cursors.Hand;
					num = 755;
				}
				if (num == 755)
				{
					this.button19.FlatAppearance.BorderSize = 0;
					num = 756;
				}
				if (num == 757)
				{
					this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 758;
				}
				if (num == 758)
				{
					this.button19.ForeColor = Color.White;
					num = 759;
				}
				if (num == 759)
				{
					this.button19.Image = (Image)componentResourceManager.GetObject("button19.Image");
					num = 760;
				}
				if (num == 761)
				{
					this.button19.Location = new Point(812, 421);
					num = 762;
				}
				if (num == 762)
				{
					this.button19.Margin = new Padding(1);
					num = 763;
				}
				if (num == 763)
				{
					this.button19.Name = "button19";
					num = 764;
				}
				if (num == 765)
				{
					this.button19.TabIndex = 298;
					num = 766;
				}
				if (num == 766)
				{
					this.button19.TabStop = false;
					num = 767;
				}
				if (num == 767)
				{
					this.button19.Text = "Install";
					num = 768;
				}
				if (num == 769)
				{
					this.button19.UseVisualStyleBackColor = false;
					num = 770;
				}
				if (num == 770)
				{
					this.button19.Click += this.button19_Click;
					num = 771;
				}
				if (num == 771)
				{
					this.button20.BackColor = Color.FromArgb(38, 38, 38);
					num = 772;
				}
				if (num == 772)
				{
					this.button20.BackgroundImageLayout = ImageLayout.None;
					num = 773;
				}
				if (num == 774)
				{
					this.button20.FlatAppearance.BorderSize = 0;
					num = 775;
				}
				if (num == 775)
				{
					this.button20.FlatStyle = FlatStyle.Flat;
					num = 776;
				}
				if (num == 776)
				{
					this.button20.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 777;
				}
				if (num == 778)
				{
					this.button20.Image = (Image)componentResourceManager.GetObject("button20.Image");
					num = 779;
				}
				if (num == 779)
				{
					this.button20.ImageAlign = ContentAlignment.MiddleLeft;
					num = 780;
				}
				if (num == 780)
				{
					this.button20.Location = new Point(632, 421);
					num = 781;
				}
				if (num == 782)
				{
					this.button20.Name = "button20";
					num = 783;
				}
				if (num == 783)
				{
					this.button20.Size = new Size(120, 30);
					num = 784;
				}
				if (num == 784)
				{
					this.button20.TabIndex = 297;
					num = 785;
				}
				if (num == 786)
				{
					this.button20.Text = "Download";
					num = 787;
				}
				if (num == 787)
				{
					this.button20.TextAlign = ContentAlignment.MiddleRight;
					num = 788;
				}
				if (num == 788)
				{
					this.button20.UseVisualStyleBackColor = false;
					num = 789;
				}
				if (num == 790)
				{
					this.label12.AutoSize = true;
					num = 791;
				}
				if (num == 791)
				{
					this.label12.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 792;
				}
				if (num == 792)
				{
					this.label12.ForeColor = Color.White;
					num = 793;
				}
				if (num == 793)
				{
					this.label12.Location = new Point(457, 421);
					num = 794;
				}
				if (num == 795)
				{
					this.label12.Size = new Size(123, 30);
					num = 796;
				}
				if (num == 796)
				{
					this.label12.TabIndex = 296;
					num = 797;
				}
				if (num == 797)
				{
					this.label12.Text = "| Size : 57MB";
					num = 798;
				}
				if (num == 799)
				{
					this.label13.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 800;
				}
				if (num == 800)
				{
					this.label13.ForeColor = Color.White;
					num = 801;
				}
				if (num == 801)
				{
					this.label13.Location = new Point(14, 421);
					num = 802;
				}
				if (num == 803)
				{
					this.label13.Size = new Size(160, 30);
					num = 804;
				}
				if (num == 804)
				{
					this.label13.TabIndex = 295;
					num = 805;
				}
				if (num == 805)
				{
					this.label13.Text = "• Microsoft Store";
					num = 806;
				}
				if (num == 807)
				{
					this.button16.BackgroundImageLayout = ImageLayout.None;
					num = 808;
				}
				if (num == 808)
				{
					this.button16.Cursor = Cursors.Hand;
					num = 809;
				}
				if (num == 809)
				{
					this.button16.FlatAppearance.BorderSize = 0;
					num = 810;
				}
				if (num == 811)
				{
					this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 812;
				}
				if (num == 812)
				{
					this.button16.ForeColor = Color.White;
					num = 813;
				}
				if (num == 813)
				{
					this.button16.Image = (Image)componentResourceManager.GetObject("button16.Image");
					num = 814;
				}
				if (num == 815)
				{
					this.button16.Location = new Point(812, 373);
					num = 816;
				}
				if (num == 816)
				{
					this.button16.Margin = new Padding(1);
					num = 817;
				}
				if (num == 817)
				{
					this.button16.Name = "button16";
					num = 818;
				}
				if (num == 818)
				{
					this.button16.Size = new Size(99, 30);
					num = 819;
				}
				if (num == 820)
				{
					this.button16.TabStop = false;
					num = 821;
				}
				if (num == 821)
				{
					this.button16.Text = "Install";
					num = 822;
				}
				if (num == 822)
				{
					this.button16.TextAlign = ContentAlignment.MiddleRight;
					num = 823;
				}
				if (num == 824)
				{
					this.button16.Click += this.button16_Click;
					num = 825;
				}
				if (num == 825)
				{
					this.button17.BackColor = Color.FromArgb(38, 38, 38);
					num = 826;
				}
				if (num == 826)
				{
					this.button17.BackgroundImageLayout = ImageLayout.None;
					num = 827;
				}
				if (num == 828)
				{
					this.button17.FlatAppearance.BorderSize = 0;
					num = 829;
				}
				if (num == 829)
				{
					this.button17.FlatStyle = FlatStyle.Flat;
					num = 830;
				}
				if (num == 830)
				{
					this.button17.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 831;
				}
				if (num == 832)
				{
					this.button17.Image = (Image)componentResourceManager.GetObject("button17.Image");
					num = 833;
				}
				if (num == 833)
				{
					this.button17.ImageAlign = ContentAlignment.MiddleLeft;
					num = 834;
				}
				if (num == 834)
				{
					this.button17.Location = new Point(632, 373);
					num = 835;
				}
				if (num == 836)
				{
					this.button17.Name = "button17";
					num = 837;
				}
				if (num == 837)
				{
					this.button17.Size = new Size(120, 30);
					num = 838;
				}
				if (num == 838)
				{
					this.button17.TabIndex = 292;
					num = 839;
				}
				if (num == 839)
				{
					this.button17.TabStop = false;
					num = 840;
				}
				if (num == 841)
				{
					this.button17.TextAlign = ContentAlignment.MiddleRight;
					num = 842;
				}
				if (num == 842)
				{
					this.button17.UseVisualStyleBackColor = false;
					num = 843;
				}
				if (num == 843)
				{
					this.button17.Click += this.button17_Click;
					num = 844;
				}
				if (num == 845)
				{
					this.label10.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 846;
				}
				if (num == 846)
				{
					this.label10.ForeColor = Color.White;
					num = 847;
				}
				if (num == 847)
				{
					this.label10.Location = new Point(457, 373);
					num = 848;
				}
				if (num == 849)
				{
					this.label10.Size = new Size(132, 30);
					num = 850;
				}
				if (num == 850)
				{
					this.label10.TabIndex = 291;
					num = 851;
				}
				if (num == 851)
				{
					this.label10.Text = "| Size : 210MB";
					num = 852;
				}
				if (num == 853)
				{
					this.label11.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 854;
				}
				if (num == 854)
				{
					this.label11.ForeColor = Color.White;
					num = 855;
				}
				if (num == 855)
				{
					this.label11.Location = new Point(14, 373);
					num = 856;
				}
				if (num == 857)
				{
					this.label11.Size = new Size(172, 30);
					num = 858;
				}
				if (num == 858)
				{
					this.label11.TabIndex = 290;
					num = 859;
				}
				if (num == 859)
				{
					this.label11.Text = "• Microsoft Photos";
					num = 860;
				}
				if (num == 861)
				{
					this.button13.BackgroundImageLayout = ImageLayout.None;
					num = 862;
				}
				if (num == 862)
				{
					this.button13.Cursor = Cursors.Hand;
					num = 863;
				}
				if (num == 863)
				{
					this.button13.FlatAppearance.BorderSize = 0;
					num = 864;
				}
				if (num == 864)
				{
					this.button13.FlatStyle = FlatStyle.Flat;
					num = 865;
				}
				if (num == 866)
				{
					this.button13.ForeColor = Color.White;
					num = 867;
				}
				if (num == 867)
				{
					this.button13.Image = (Image)componentResourceManager.GetObject("button13.Image");
					num = 868;
				}
				if (num == 868)
				{
					this.button13.ImageAlign = ContentAlignment.MiddleLeft;
					num = 869;
				}
				if (num == 870)
				{
					this.button13.Margin = new Padding(1);
					num = 871;
				}
				if (num == 871)
				{
					this.button13.Name = "button13";
					num = 872;
				}
				if (num == 872)
				{
					this.button13.Size = new Size(99, 30);
					num = 873;
				}
				if (num == 874)
				{
					this.button13.TabStop = false;
					num = 875;
				}
				if (num == 875)
				{
					this.button13.Text = "Install";
					num = 876;
				}
				if (num == 876)
				{
					this.button13.TextAlign = ContentAlignment.MiddleRight;
					num = 877;
				}
				if (num == 878)
				{
					this.button13.Click += this.button13_Click;
					num = 879;
				}
				if (num == 879)
				{
					this.button14.BackColor = Color.FromArgb(38, 38, 38);
					num = 880;
				}
				if (num == 880)
				{
					this.button14.BackgroundImageLayout = ImageLayout.None;
					num = 881;
				}
				if (num == 882)
				{
					this.button14.FlatAppearance.BorderSize = 0;
					num = 883;
				}
				if (num == 883)
				{
					this.button14.FlatStyle = FlatStyle.Flat;
					num = 884;
				}
				if (num == 884)
				{
					this.button14.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 885;
				}
				if (num == 885)
				{
					this.button14.ForeColor = Color.White;
					num = 886;
				}
				if (num == 887)
				{
					this.button14.ImageAlign = ContentAlignment.MiddleLeft;
					num = 888;
				}
				if (num == 888)
				{
					this.button14.Location = new Point(632, 325);
					num = 889;
				}
				if (num == 889)
				{
					this.button14.Margin = new Padding(1);
					num = 890;
				}
				if (num == 891)
				{
					this.button14.Size = new Size(120, 30);
					num = 892;
				}
				if (num == 892)
				{
					this.button14.TabIndex = 287;
					num = 893;
				}
				if (num == 893)
				{
					this.button14.TabStop = false;
					num = 894;
				}
				if (num == 895)
				{
					this.button14.TextAlign = ContentAlignment.MiddleRight;
					num = 896;
				}
				if (num == 896)
				{
					this.button14.UseVisualStyleBackColor = false;
					num = 897;
				}
				if (num == 897)
				{
					this.button14.Click += this.button14_Click;
					num = 898;
				}
				if (num == 899)
				{
					this.label8.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 900;
				}
				if (num == 900)
				{
					this.label8.ForeColor = Color.White;
					num = 901;
				}
				if (num == 901)
				{
					this.label8.Location = new Point(457, 325);
					num = 902;
				}
				if (num == 903)
				{
					this.label8.Size = new Size(124, 30);
					num = 904;
				}
				if (num == 904)
				{
					this.label8.TabIndex = 286;
					num = 905;
				}
				if (num == 905)
				{
					this.label8.Text = "| Size : 28MB";
					num = 906;
				}
				if (num == 907)
				{
					this.label9.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 908;
				}
				if (num == 908)
				{
					this.label9.ForeColor = Color.White;
					num = 909;
				}
				if (num == 909)
				{
					this.label9.Location = new Point(14, 325);
					num = 910;
				}
				if (num == 910)
				{
					this.label9.Name = "label9";
					num = 911;
				}
				if (num == 912)
				{
					this.label9.TabIndex = 285;
					num = 913;
				}
				if (num == 913)
				{
					this.label9.Text = "• Microsoft Calculator";
					num = 914;
				}
				if (num == 914)
				{
					this.button10.BackColor = Color.FromArgb(38, 38, 38);
					num = 915;
				}
				if (num == 916)
				{
					this.button10.Cursor = Cursors.Hand;
					num = 917;
				}
				if (num == 917)
				{
					this.button10.FlatAppearance.BorderSize = 0;
					num = 918;
				}
				if (num == 918)
				{
					this.button10.FlatStyle = FlatStyle.Flat;
					num = 919;
				}
				if (num == 920)
				{
					this.button10.ForeColor = Color.White;
					num = 921;
				}
				if (num == 921)
				{
					this.button10.Image = (Image)componentResourceManager.GetObject("button10.Image");
					num = 922;
				}
				if (num == 922)
				{
					this.button10.ImageAlign = ContentAlignment.MiddleLeft;
					num = 923;
				}
				if (num == 924)
				{
					this.button10.Margin = new Padding(1);
					num = 925;
				}
				if (num == 925)
				{
					this.button10.Name = "button10";
					num = 926;
				}
				if (num == 926)
				{
					this.button10.Size = new Size(99, 30);
					num = 927;
				}
				if (num == 928)
				{
					this.button10.TabStop = false;
					num = 929;
				}
				if (num == 929)
				{
					this.button10.Text = "Install";
					num = 930;
				}
				if (num == 930)
				{
					this.button10.TextAlign = ContentAlignment.MiddleRight;
					num = 931;
				}
				if (num == 932)
				{
					this.button10.Click += this.button10_Click;
					num = 933;
				}
				if (num == 933)
				{
					this.button11.BackColor = Color.FromArgb(38, 38, 38);
					num = 934;
				}
				if (num == 934)
				{
					this.button11.BackgroundImageLayout = ImageLayout.None;
					num = 935;
				}
				if (num == 935)
				{
					this.button11.Cursor = Cursors.Hand;
					num = 936;
				}
				if (num == 937)
				{
					this.button11.FlatStyle = FlatStyle.Flat;
					num = 938;
				}
				if (num == 938)
				{
					this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 939;
				}
				if (num == 939)
				{
					this.button11.ForeColor = Color.White;
					num = 940;
				}
				if (num == 941)
				{
					this.button11.ImageAlign = ContentAlignment.MiddleLeft;
					num = 942;
				}
				if (num == 942)
				{
					this.button11.Location = new Point(632, 277);
					num = 943;
				}
				if (num == 943)
				{
					this.button11.Margin = new Padding(1);
					num = 944;
				}
				if (num == 945)
				{
					this.button11.Size = new Size(120, 30);
					num = 946;
				}
				if (num == 946)
				{
					this.button11.TabIndex = 282;
					num = 947;
				}
				if (num == 947)
				{
					this.button11.TabStop = false;
					num = 948;
				}
				if (num == 949)
				{
					this.button11.TextAlign = ContentAlignment.MiddleRight;
					num = 950;
				}
				if (num == 950)
				{
					this.button11.UseVisualStyleBackColor = false;
					num = 951;
				}
				if (num == 951)
				{
					this.button11.Click += this.button11_Click;
					num = 952;
				}
				if (num == 953)
				{
					this.label5.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 954;
				}
				if (num == 954)
				{
					this.label5.ForeColor = Color.White;
					num = 955;
				}
				if (num == 955)
				{
					this.label5.Location = new Point(457, 277);
					num = 956;
				}
				if (num == 956)
				{
					this.label5.Name = "label5";
					num = 957;
				}
				if (num == 958)
				{
					this.label5.TabIndex = 281;
					num = 959;
				}
				if (num == 959)
				{
					this.label5.Text = "| Size : 97MB";
					num = 960;
				}
				if (num == 960)
				{
					this.label7.AutoSize = true;
					num = 961;
				}
				if (num == 962)
				{
					this.label7.ForeColor = Color.White;
					num = 963;
				}
				if (num == 963)
				{
					this.label7.Location = new Point(14, 277);
					num = 964;
				}
				if (num == 964)
				{
					this.label7.Name = "label7";
					num = 965;
				}
				if (num == 966)
				{
					this.label7.TabIndex = 280;
					num = 967;
				}
				if (num == 967)
				{
					this.label7.Text = "• Intel Command Center";
					num = 968;
				}
				if (num == 968)
				{
					this.button6.BackColor = Color.FromArgb(38, 38, 38);
					num = 969;
				}
				if (num == 970)
				{
					this.button6.Cursor = Cursors.Hand;
					num = 971;
				}
				if (num == 971)
				{
					this.button6.FlatAppearance.BorderSize = 0;
					num = 972;
				}
				if (num == 972)
				{
					this.button6.FlatStyle = FlatStyle.Flat;
					num = 973;
				}
				if (num == 974)
				{
					this.button6.ForeColor = Color.White;
					num = 975;
				}
				if (num == 975)
				{
					this.button6.Image = (Image)componentResourceManager.GetObject("button6.Image");
					num = 976;
				}
				if (num == 976)
				{
					this.button6.ImageAlign = ContentAlignment.MiddleLeft;
					num = 977;
				}
				if (num == 978)
				{
					this.button6.Margin = new Padding(1);
					num = 979;
				}
				if (num == 979)
				{
					this.button6.Name = "button6";
					num = 980;
				}
				if (num == 980)
				{
					this.button6.Size = new Size(99, 30);
					num = 981;
				}
				if (num == 981)
				{
					this.button6.TabIndex = 278;
					num = 982;
				}
				if (num == 983)
				{
					this.button6.Text = "Install";
					num = 984;
				}
				if (num == 984)
				{
					this.button6.TextAlign = ContentAlignment.MiddleRight;
					num = 985;
				}
				if (num == 985)
				{
					this.button6.UseVisualStyleBackColor = false;
					num = 986;
				}
				if (num == 987)
				{
					this.button8.BackColor = Color.FromArgb(38, 38, 38);
					num = 988;
				}
				if (num == 988)
				{
					this.button8.BackgroundImageLayout = ImageLayout.None;
					num = 989;
				}
				if (num == 989)
				{
					this.button8.Cursor = Cursors.Hand;
					num = 990;
				}
				if (num == 991)
				{
					this.button8.FlatStyle = FlatStyle.Flat;
					num = 992;
				}
				if (num == 992)
				{
					this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 993;
				}
				if (num == 993)
				{
					this.button8.ForeColor = Color.White;
					num = 994;
				}
				if (num == 995)
				{
					this.button8.ImageAlign = ContentAlignment.MiddleLeft;
					num = 996;
				}
				if (num == 996)
				{
					this.button8.Location = new Point(632, 566);
					num = 997;
				}
				if (num == 997)
				{
					this.button8.Margin = new Padding(1);
					num = 998;
				}
				if (num == 999)
				{
					this.button8.Size = new Size(120, 30);
					num = 1000;
				}
				if (num == 1000)
				{
					this.button8.TabIndex = 277;
					num = 1001;
				}
				if (num == 1001)
				{
					this.button8.TabStop = false;
					num = 1002;
				}
				if (num == 1002)
				{
					this.button8.Text = "Download";
					num = 1003;
				}
				if (num == 1004)
				{
					this.button8.UseVisualStyleBackColor = false;
					num = 1005;
				}
				if (num == 1005)
				{
					this.button8.Click += this.button8_Click;
					num = 1006;
				}
				if (num == 1006)
				{
					this.label3.AutoSize = true;
					num = 1007;
				}
				if (num == 1008)
				{
					this.label3.ForeColor = Color.White;
					num = 1009;
				}
				if (num == 1009)
				{
					this.label3.Location = new Point(457, 566);
					num = 1010;
				}
				if (num == 1010)
				{
					this.label3.Name = "label3";
					num = 1011;
				}
				if (num == 1012)
				{
					this.label3.TabIndex = 276;
					num = 1013;
				}
				if (num == 1013)
				{
					this.label3.Text = "| Size : 40MB";
					num = 1014;
				}
				if (num == 1014)
				{
					this.label4.AutoSize = true;
					num = 1015;
				}
				if (num == 1016)
				{
					this.label4.ForeColor = Color.White;
					num = 1017;
				}
				if (num == 1017)
				{
					this.label4.Location = new Point(14, 566);
					num = 1018;
				}
				if (num == 1018)
				{
					this.label4.Name = "label4";
					num = 1019;
				}
				if (num == 1020)
				{
					this.label4.TabIndex = 275;
					num = 1021;
				}
				if (num == 1021)
				{
					this.label4.Text = "• Windows Media Player (UWP)";
					num = 1022;
				}
				if (num == 1022)
				{
					this.button1.BackColor = Color.FromArgb(38, 38, 38);
					num = 1023;
				}
				if (num == 1024)
				{
					this.button1.Cursor = Cursors.Hand;
					num = 1025;
				}
				if (num == 1025)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 1026;
				}
				if (num == 1026)
				{
					this.button1.FlatStyle = FlatStyle.Flat;
					num = 1027;
				}
				if (num == 1027)
				{
					this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 1028;
				}
				if (num == 1029)
				{
					this.button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
					num = 1030;
				}
				if (num == 1030)
				{
					this.button1.ImageAlign = ContentAlignment.MiddleLeft;
					num = 1031;
				}
				if (num == 1031)
				{
					this.button1.Location = new Point(812, 230);
					num = 1032;
				}
				if (num == 1033)
				{
					this.button1.Name = "button1";
					num = 1034;
				}
				if (num == 1034)
				{
					this.button1.Size = new Size(99, 30);
					num = 1035;
				}
				if (num == 1035)
				{
					this.button1.TabIndex = 272;
					num = 1036;
				}
				if (num == 1037)
				{
					this.button1.Text = "Install";
					num = 1038;
				}
				if (num == 1038)
				{
					this.button1.TextAlign = ContentAlignment.MiddleRight;
					num = 1039;
				}
				if (num == 1039)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 1040;
				}
				if (num == 1041)
				{
					this.button7.BackColor = Color.FromArgb(38, 38, 38);
					num = 1042;
				}
				if (num == 1042)
				{
					this.button7.BackgroundImageLayout = ImageLayout.None;
					num = 1043;
				}
				if (num == 1043)
				{
					this.button7.Cursor = Cursors.Hand;
					num = 1044;
				}
				if (num == 1045)
				{
					this.button7.FlatStyle = FlatStyle.Flat;
					num = 1046;
				}
				if (num == 1046)
				{
					this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 1047;
				}
				if (num == 1047)
				{
					this.button7.ForeColor = Color.White;
					num = 1048;
				}
				if (num == 1049)
				{
					this.button7.ImageAlign = ContentAlignment.MiddleLeft;
					num = 1050;
				}
				if (num == 1050)
				{
					this.button7.Location = new Point(632, 230);
					num = 1051;
				}
				if (num == 1051)
				{
					this.button7.Margin = new Padding(1);
					num = 1052;
				}
				if (num == 1052)
				{
					this.button7.Name = "button7";
					num = 1053;
				}
				if (num == 1054)
				{
					this.button7.TabIndex = 271;
					num = 1055;
				}
				if (num == 1055)
				{
					this.button7.TabStop = false;
					num = 1056;
				}
				if (num == 1056)
				{
					this.button7.Text = "Download";
					num = 1057;
				}
				if (num == 1058)
				{
					this.button7.UseVisualStyleBackColor = false;
					num = 1059;
				}
				if (num == 1059)
				{
					this.button7.Click += this.button7_Click;
					num = 1060;
				}
				if (num == 1060)
				{
					this.label81.AutoSize = true;
					num = 1061;
				}
				if (num == 1062)
				{
					this.label81.ForeColor = Color.White;
					num = 1063;
				}
				if (num == 1063)
				{
					this.label81.Location = new Point(457, 230);
					num = 1064;
				}
				if (num == 1064)
				{
					this.label81.Name = "label81";
					num = 1065;
				}
				if (num == 1066)
				{
					this.label81.TabIndex = 270;
					num = 1067;
				}
				if (num == 1067)
				{
					this.label81.Text = "| Size : 57MB";
					num = 1068;
				}
				if (num == 1068)
				{
					this.label6.AutoSize = true;
					num = 1069;
				}
				if (num == 1070)
				{
					this.label6.ForeColor = Color.White;
					num = 1071;
				}
				if (num == 1071)
				{
					this.label6.Location = new Point(14, 230);
					num = 1072;
				}
				if (num == 1072)
				{
					this.label6.Name = "label6";
					num = 1073;
				}
				if (num == 1073)
				{
					this.label6.Size = new Size(98, 30);
					num = 1074;
				}
				if (num == 1075)
				{
					this.label6.Text = "• Cortana";
					num = 1076;
				}
				if (num == 1076)
				{
					this.label37.AutoSize = true;
					num = 1077;
				}
				if (num == 1077)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1078;
				}
				if (num == 1079)
				{
					this.label37.Location = new Point(23, 53);
					num = 1080;
				}
				if (num == 1080)
				{
					this.label37.Name = "label37";
					num = 1081;
				}
				if (num == 1081)
				{
					this.label37.Size = new Size(559, 19);
					num = 1082;
				}
				if (num == 1083)
				{
					this.label37.Text = "Download Microsoft Store and some UWP Apps with essential software like DirectX, VC++ and more";
					num = 1084;
				}
				if (num == 1084)
				{
					this.pkg_location.Location = new Point(57, 27);
					num = 1085;
				}
				if (num == 1085)
				{
					this.pkg_location.Name = "pkg_location";
					num = 1086;
				}
				if (num == 1087)
				{
					this.pkg_location.TabIndex = 107;
					num = 1088;
				}
				if (num == 1088)
				{
					this.dl_location.Location = new Point(111, 27);
					num = 1089;
				}
				if (num == 1089)
				{
					this.dl_location.Name = "dl_location";
					num = 1090;
				}
				if (num == 1091)
				{
					this.dl_location.TabIndex = 108;
					num = 1092;
				}
				if (num == 1092)
				{
					this.ProgressBar1.BorderRadius = 10;
					num = 1093;
				}
				if (num == 1093)
				{
					this.ProgressBar1.Location = new Point(27, 596);
					num = 1094;
				}
				if (num == 1095)
				{
					this.ProgressBar1.ProgressColor = Color.Gray;
					num = 1096;
				}
				if (num == 1096)
				{
					this.ProgressBar1.ProgressColor2 = Color.Gray;
					num = 1097;
				}
				if (num == 1097)
				{
					this.ProgressBar1.ShadowDecoration.Parent = this.ProgressBar1;
					num = 1098;
				}
				if (num == 1098)
				{
					this.ProgressBar1.Size = new Size(876, 23);
					num = 1099;
				}
				if (num == 1100)
				{
					this.ProgressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
					num = 1101;
				}
				if (num == 1101)
				{
					this.siticoneVScrollBar1.BindingContainer = this.panel1;
					num = 1102;
				}
				if (num == 1102)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 1103;
				}
				if (num == 1104)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 1105;
				}
				if (num == 1105)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 1106;
				}
				if (num == 1106)
				{
					this.siticoneVScrollBar1.LargeChange = 479;
					num = 1107;
				}
				if (num == 1108)
				{
					this.siticoneVScrollBar1.Maximum = 1019;
					num = 1109;
				}
				if (num == 1109)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 1110;
				}
				if (num == 1110)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 1111;
				}
				if (num == 1112)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 496);
					num = 1113;
				}
				if (num == 1113)
				{
					this.siticoneVScrollBar1.SmallChange = 5;
					num = 1114;
				}
				if (num == 1114)
				{
					this.siticoneVScrollBar1.TabIndex = 338;
					num = 1115;
				}
				if (num == 1116)
				{
					this.siticoneVScrollBar1.ThumbSize = 240f;
					num = 1117;
				}
				if (num == 1117)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 1118;
				}
				if (num == 1118)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 1119;
				}
				if (num == 1119)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 1120;
				}
				if (num == 1121)
				{
					base.Controls.Add(this.ProgressBar1);
					num = 1122;
				}
				if (num == 1122)
				{
					base.Controls.Add(this.label37);
					num = 1123;
				}
				if (num == 1123)
				{
					base.Controls.Add(this.panel1);
					num = 1124;
				}
				if (num == 1125)
				{
					base.Controls.Add(this.lblDownload);
					num = 1126;
				}
				if (num == 1126)
				{
					base.Controls.Add(this.label2);
					num = 1127;
				}
				if (num == 1127)
				{
					base.Controls.Add(this.button3);
					num = 1128;
				}
				if (num == 1129)
				{
					base.Controls.Add(this.dl_location);
					num = 1130;
				}
				if (num == 1130)
				{
					base.Controls.Add(this.pkg_location);
					num = 1131;
				}
				if (num == 1131)
				{
					base.Name = "windowsapp";
					num = 1132;
				}
				if (num == 1133)
				{
					base.Load += this.windowsapp_Load;
					num = 1134;
				}
				if (num == 1134)
				{
					this.panel1.ResumeLayout(false);
					num = 1135;
				}
				if (num == 1135)
				{
					this.panel1.PerformLayout();
					num = 1136;
				}
				if (num == 1137)
				{
					base.PerformLayout();
					num = 1138;
				}
				if (num == 1136)
				{
					base.ResumeLayout(false);
					num = 1137;
				}
				if (num == 1132)
				{
					base.Size = new Size(1006, 669);
					num = 1133;
				}
				if (num == 1128)
				{
					base.Controls.Add(this.label1);
					num = 1129;
				}
				if (num == 1124)
				{
					base.Controls.Add(this.lblSpeed);
					num = 1125;
				}
				if (num == 1120)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 1121;
				}
				if (num == 1115)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 1116;
				}
				if (num == 1111)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 1112;
				}
				if (num == 1107)
				{
					this.siticoneVScrollBar1.Location = new Point(973, 81);
					num = 1108;
				}
				if (num == 1103)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 1104;
				}
				if (num == 1099)
				{
					this.ProgressBar1.TabIndex = 109;
					num = 1100;
				}
				if (num == 1094)
				{
					this.ProgressBar1.Name = "ProgressBar1";
					num = 1095;
				}
				if (num == 1090)
				{
					this.dl_location.Size = new Size(36, 20);
					num = 1091;
				}
				if (num == 1086)
				{
					this.pkg_location.Size = new Size(36, 20);
					num = 1087;
				}
				if (num == 1082)
				{
					this.label37.TabIndex = 105;
					num = 1083;
				}
				if (num == 1078)
				{
					this.label37.ForeColor = Color.Silver;
					num = 1079;
				}
				if (num == 1074)
				{
					this.label6.TabIndex = 269;
					num = 1075;
				}
				if (num == 1069)
				{
					this.label6.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1070;
				}
				if (num == 1065)
				{
					this.label81.Size = new Size(123, 30);
					num = 1066;
				}
				if (num == 1061)
				{
					this.label81.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1062;
				}
				if (num == 1057)
				{
					this.button7.TextAlign = ContentAlignment.MiddleRight;
					num = 1058;
				}
				if (num == 1053)
				{
					this.button7.Size = new Size(120, 30);
					num = 1054;
				}
				if (num == 1048)
				{
					this.button7.Image = (Image)componentResourceManager.GetObject("button7.Image");
					num = 1049;
				}
				if (num == 1044)
				{
					this.button7.FlatAppearance.BorderSize = 0;
					num = 1045;
				}
				if (num == 1040)
				{
					this.button1.Click += this.button1_Click;
					num = 1041;
				}
				if (num == 1036)
				{
					this.button1.TabStop = false;
					num = 1037;
				}
				if (num == 1032)
				{
					this.button1.Margin = new Padding(1);
					num = 1033;
				}
				if (num == 1028)
				{
					this.button1.ForeColor = Color.White;
					num = 1029;
				}
				if (num == 1023)
				{
					this.button1.BackgroundImageLayout = ImageLayout.None;
					num = 1024;
				}
				if (num == 1019)
				{
					this.label4.Size = new Size(291, 30);
					num = 1020;
				}
				if (num == 1015)
				{
					this.label4.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1016;
				}
				if (num == 1011)
				{
					this.label3.Size = new Size(126, 30);
					num = 1012;
				}
				if (num == 1007)
				{
					this.label3.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1008;
				}
				if (num == 1003)
				{
					this.button8.TextAlign = ContentAlignment.MiddleRight;
					num = 1004;
				}
				if (num == 998)
				{
					this.button8.Name = "button8";
					num = 999;
				}
				if (num == 994)
				{
					this.button8.Image = (Image)componentResourceManager.GetObject("button8.Image");
					num = 995;
				}
				if (num == 990)
				{
					this.button8.FlatAppearance.BorderSize = 0;
					num = 991;
				}
				if (num == 986)
				{
					this.button6.Click += this.button6_Click;
					num = 987;
				}
				if (num == 982)
				{
					this.button6.TabStop = false;
					num = 983;
				}
				if (num == 977)
				{
					this.button6.Location = new Point(812, 566);
					num = 978;
				}
				if (num == 973)
				{
					this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 974;
				}
				if (num == 969)
				{
					this.button6.BackgroundImageLayout = ImageLayout.None;
					num = 970;
				}
				if (num == 965)
				{
					this.label7.Size = new Size(225, 30);
					num = 966;
				}
				if (num == 961)
				{
					this.label7.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 962;
				}
				if (num == 957)
				{
					this.label5.Size = new Size(123, 30);
					num = 958;
				}
				if (num == 952)
				{
					this.label5.AutoSize = true;
					num = 953;
				}
				if (num == 948)
				{
					this.button11.Text = "Download";
					num = 949;
				}
				if (num == 944)
				{
					this.button11.Name = "button11";
					num = 945;
				}
				if (num == 940)
				{
					this.button11.Image = (Image)componentResourceManager.GetObject("button11.Image");
					num = 941;
				}
				if (num == 936)
				{
					this.button11.FlatAppearance.BorderSize = 0;
					num = 937;
				}
				if (num == 931)
				{
					this.button10.UseVisualStyleBackColor = false;
					num = 932;
				}
				if (num == 927)
				{
					this.button10.TabIndex = 283;
					num = 928;
				}
				if (num == 923)
				{
					this.button10.Location = new Point(812, 277);
					num = 924;
				}
				if (num == 919)
				{
					this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 920;
				}
				if (num == 915)
				{
					this.button10.BackgroundImageLayout = ImageLayout.None;
					num = 916;
				}
				if (num == 911)
				{
					this.label9.Size = new Size(203, 30);
					num = 912;
				}
				if (num == 906)
				{
					this.label9.AutoSize = true;
					num = 907;
				}
				if (num == 902)
				{
					this.label8.Name = "label8";
					num = 903;
				}
				if (num == 898)
				{
					this.label8.AutoSize = true;
					num = 899;
				}
				if (num == 894)
				{
					this.button14.Text = "Download";
					num = 895;
				}
				if (num == 890)
				{
					this.button14.Name = "button14";
					num = 891;
				}
				if (num == 886)
				{
					this.button14.Image = (Image)componentResourceManager.GetObject("button14.Image");
					num = 887;
				}
				if (num == 881)
				{
					this.button14.Cursor = Cursors.Hand;
					num = 882;
				}
				if (num == 877)
				{
					this.button13.UseVisualStyleBackColor = false;
					num = 878;
				}
				if (num == 873)
				{
					this.button13.TabIndex = 288;
					num = 874;
				}
				if (num == 869)
				{
					this.button13.Location = new Point(812, 325);
					num = 870;
				}
				if (num == 865)
				{
					this.button13.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 866;
				}
				if (num == 860)
				{
					this.button13.BackColor = Color.FromArgb(38, 38, 38);
					num = 861;
				}
				if (num == 856)
				{
					this.label11.Name = "label11";
					num = 857;
				}
				if (num == 852)
				{
					this.label11.AutoSize = true;
					num = 853;
				}
				if (num == 848)
				{
					this.label10.Name = "label10";
					num = 849;
				}
				if (num == 844)
				{
					this.label10.AutoSize = true;
					num = 845;
				}
				if (num == 840)
				{
					this.button17.Text = "Download";
					num = 841;
				}
				if (num == 835)
				{
					this.button17.Margin = new Padding(1);
					num = 836;
				}
				if (num == 831)
				{
					this.button17.ForeColor = Color.White;
					num = 832;
				}
				if (num == 827)
				{
					this.button17.Cursor = Cursors.Hand;
					num = 828;
				}
				if (num == 823)
				{
					this.button16.UseVisualStyleBackColor = false;
					num = 824;
				}
				if (num == 819)
				{
					this.button16.TabIndex = 293;
					num = 820;
				}
				if (num == 814)
				{
					this.button16.ImageAlign = ContentAlignment.MiddleLeft;
					num = 815;
				}
				if (num == 810)
				{
					this.button16.FlatStyle = FlatStyle.Flat;
					num = 811;
				}
				if (num == 806)
				{
					this.button16.BackColor = Color.FromArgb(38, 38, 38);
					num = 807;
				}
				if (num == 802)
				{
					this.label13.Name = "label13";
					num = 803;
				}
				if (num == 798)
				{
					this.label13.AutoSize = true;
					num = 799;
				}
				if (num == 794)
				{
					this.label12.Name = "label12";
					num = 795;
				}
				if (num == 789)
				{
					this.button20.Click += this.button20_Click;
					num = 790;
				}
				if (num == 785)
				{
					this.button20.TabStop = false;
					num = 786;
				}
				if (num == 781)
				{
					this.button20.Margin = new Padding(1);
					num = 782;
				}
				if (num == 777)
				{
					this.button20.ForeColor = Color.White;
					num = 778;
				}
				if (num == 773)
				{
					this.button20.Cursor = Cursors.Hand;
					num = 774;
				}
				if (num == 768)
				{
					this.button19.TextAlign = ContentAlignment.MiddleRight;
					num = 769;
				}
				if (num == 764)
				{
					this.button19.Size = new Size(99, 30);
					num = 765;
				}
				if (num == 760)
				{
					this.button19.ImageAlign = ContentAlignment.MiddleLeft;
					num = 761;
				}
				if (num == 756)
				{
					this.button19.FlatStyle = FlatStyle.Flat;
					num = 757;
				}
				if (num == 752)
				{
					this.button19.BackColor = Color.FromArgb(38, 38, 38);
					num = 753;
				}
				if (num == 748)
				{
					this.label15.Name = "label15";
					num = 749;
				}
				if (num == 743)
				{
					this.label14.Text = "| Size : 8MB";
					num = 744;
				}
				if (num == 739)
				{
					this.label14.Location = new Point(457, 469);
					num = 740;
				}
				if (num == 735)
				{
					this.button27.Click += this.button27_Click;
					num = 736;
				}
				if (num == 731)
				{
					this.button27.TabStop = false;
					num = 732;
				}
				if (num == 727)
				{
					this.button27.Margin = new Padding(1);
					num = 728;
				}
				if (num == 723)
				{
					this.button27.ForeColor = Color.White;
					num = 724;
				}
				if (num == 718)
				{
					this.button27.BackgroundImageLayout = ImageLayout.None;
					num = 719;
				}
				if (num == 714)
				{
					this.button26.TextAlign = ContentAlignment.MiddleRight;
					num = 715;
				}
				if (num == 710)
				{
					this.button26.Size = new Size(99, 30);
					num = 711;
				}
				if (num == 706)
				{
					this.button26.ImageAlign = ContentAlignment.MiddleLeft;
					num = 707;
				}
				if (num == 702)
				{
					this.button26.FlatStyle = FlatStyle.Flat;
					num = 703;
				}
				if (num == 697)
				{
					this.label17.Text = "• Windows Terminal";
					num = 698;
				}
				if (num == 693)
				{
					this.label17.Location = new Point(14, 517);
					num = 694;
				}
				if (num == 689)
				{
					this.label16.Text = "| Size : 37MB";
					num = 690;
				}
				if (num == 685)
				{
					this.label16.Location = new Point(457, 517);
					num = 686;
				}
				if (num == 681)
				{
					this.button30.Click += this.button30_Click;
					num = 682;
				}
				if (num == 677)
				{
					this.button30.TabStop = false;
					num = 678;
				}
				if (num == 672)
				{
					this.button30.Location = new Point(632, 517);
					num = 673;
				}
				if (num == 668)
				{
					this.button30.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 669;
				}
				if (num == 664)
				{
					this.button30.BackgroundImageLayout = ImageLayout.None;
					num = 665;
				}
				if (num == 660)
				{
					this.button29.TextAlign = ContentAlignment.MiddleRight;
					num = 661;
				}
				if (num == 656)
				{
					this.button29.Size = new Size(99, 30);
					num = 657;
				}
				if (num == 651)
				{
					this.button29.Image = (Image)componentResourceManager.GetObject("button29.Image");
					num = 652;
				}
				if (num == 647)
				{
					this.button29.FlatAppearance.BorderSize = 0;
					num = 648;
				}
				if (num == 643)
				{
					this.label19.Text = "• Xbox Game Bar";
					num = 644;
				}
				if (num == 639)
				{
					this.label19.Location = new Point(14, 614);
					num = 640;
				}
				if (num == 635)
				{
					this.label18.Text = "| Size : 49MB";
					num = 636;
				}
				if (num == 631)
				{
					this.label18.Location = new Point(457, 614);
					num = 632;
				}
				if (num == 626)
				{
					this.button33.UseVisualStyleBackColor = false;
					num = 627;
				}
				if (num == 622)
				{
					this.button33.TabIndex = 312;
					num = 623;
				}
				if (num == 618)
				{
					this.button33.Location = new Point(632, 614);
					num = 619;
				}
				if (num == 614)
				{
					this.button33.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 615;
				}
				if (num == 610)
				{
					this.button33.BackgroundImageLayout = ImageLayout.None;
					num = 611;
				}
				if (num == 503)
				{
					this.label25.Text = "| Size : 285KB";
					num = 504;
				}
				if (num == 504)
				{
					this.label26.AutoSize = true;
					num = 505;
				}
				if (num == 505)
				{
					this.label26.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 506;
				}
				if (num == 506)
				{
					this.label26.ForeColor = Color.White;
					num = 507;
				}
				if (num == 507)
				{
					this.label26.Location = new Point(14, 814);
					num = 508;
				}
				if (num == 508)
				{
					this.label26.Name = "label26";
					num = 509;
				}
				if (num == 509)
				{
					this.label26.Size = new Size(213, 30);
					num = 510;
				}
				if (num == 510)
				{
					this.label26.TabIndex = 322;
					num = 511;
				}
				if (num == 511)
				{
					this.label26.Text = "• DirectX Web Installer";
					num = 512;
				}
				if (num == 512)
				{
					this.button35.BackColor = Color.FromArgb(38, 38, 38);
					num = 513;
				}
				if (num == 513)
				{
					this.button35.BackgroundImageLayout = ImageLayout.None;
					num = 514;
				}
				if (num == 514)
				{
					this.button35.Cursor = Cursors.Hand;
					num = 515;
				}
				if (num == 516)
				{
					this.button35.FlatStyle = FlatStyle.Flat;
					num = 517;
				}
				if (num == 517)
				{
					this.button35.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 518;
				}
				if (num == 518)
				{
					this.button35.ForeColor = Color.White;
					num = 519;
				}
				if (num == 519)
				{
					this.button35.Image = (Image)componentResourceManager.GetObject("button35.Image");
					num = 520;
				}
				if (num == 520)
				{
					this.button35.ImageAlign = ContentAlignment.MiddleLeft;
					num = 521;
				}
				if (num == 521)
				{
					this.button35.Location = new Point(773, 770);
					num = 522;
				}
				if (num == 522)
				{
					this.button35.Margin = new Padding(1);
					num = 523;
				}
				if (num == 523)
				{
					this.button35.Name = "button35";
					num = 524;
				}
				if (num == 524)
				{
					this.button35.Size = new Size(120, 30);
					num = 525;
				}
				if (num == 525)
				{
					this.button35.TabIndex = 321;
					num = 526;
				}
				if (num == 526)
				{
					this.button35.TabStop = false;
					num = 527;
				}
				if (num == 527)
				{
					this.button35.Text = "Download";
					num = 528;
				}
				if (num == 529)
				{
					this.button35.UseVisualStyleBackColor = false;
					num = 530;
				}
				if (num == 530)
				{
					this.button35.Click += this.button35_Click;
					num = 531;
				}
				if (num == 531)
				{
					this.label23.AutoSize = true;
					num = 532;
				}
				if (num == 532)
				{
					this.label23.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 533;
				}
				if (num == 533)
				{
					this.label23.ForeColor = Color.White;
					num = 534;
				}
				if (num == 534)
				{
					this.label23.Location = new Point(513, 770);
					num = 535;
				}
				if (num == 535)
				{
					this.label23.Name = "label23";
					num = 536;
				}
				if (num == 536)
				{
					this.label23.Size = new Size(124, 30);
					num = 537;
				}
				if (num == 537)
				{
					this.label23.TabIndex = 320;
					num = 538;
				}
				if (num == 538)
				{
					this.label23.Text = "| Size : 96MB";
					num = 539;
				}
				if (num == 539)
				{
					this.label24.AutoSize = true;
					num = 540;
				}
				if (num == 540)
				{
					this.label24.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 541;
				}
				if (num == 542)
				{
					this.label24.Location = new Point(14, 770);
					num = 543;
				}
				if (num == 543)
				{
					this.label24.Name = "label24";
					num = 544;
				}
				if (num == 544)
				{
					this.label24.Size = new Size(111, 30);
					num = 545;
				}
				if (num == 545)
				{
					this.label24.TabIndex = 319;
					num = 546;
				}
				if (num == 546)
				{
					this.label24.Text = "• DirectX 11";
					num = 547;
				}
				if (num == 547)
				{
					this.button34.BackColor = Color.FromArgb(38, 38, 38);
					num = 548;
				}
				if (num == 548)
				{
					this.button34.BackgroundImageLayout = ImageLayout.None;
					num = 549;
				}
				if (num == 549)
				{
					this.button34.Cursor = Cursors.Hand;
					num = 550;
				}
				if (num == 550)
				{
					this.button34.FlatAppearance.BorderSize = 0;
					num = 551;
				}
				if (num == 551)
				{
					this.button34.FlatStyle = FlatStyle.Flat;
					num = 552;
				}
				if (num == 552)
				{
					this.button34.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 553;
				}
				if (num == 553)
				{
					this.button34.ForeColor = Color.White;
					num = 554;
				}
				if (num == 554)
				{
					this.button34.Image = (Image)componentResourceManager.GetObject("button34.Image");
					num = 555;
				}
				if (num == 556)
				{
					this.button34.Location = new Point(773, 726);
					num = 557;
				}
				if (num == 557)
				{
					this.button34.Margin = new Padding(1);
					num = 558;
				}
				if (num == 558)
				{
					this.button34.Name = "button34";
					num = 559;
				}
				if (num == 559)
				{
					this.button34.Size = new Size(120, 30);
					num = 560;
				}
				if (num == 560)
				{
					this.button34.TabIndex = 318;
					num = 561;
				}
				if (num == 561)
				{
					this.button34.TabStop = false;
					num = 562;
				}
				if (num == 562)
				{
					this.button34.Text = "Download";
					num = 563;
				}
				if (num == 563)
				{
					this.button34.TextAlign = ContentAlignment.MiddleRight;
					num = 564;
				}
				if (num == 564)
				{
					this.button34.UseVisualStyleBackColor = false;
					num = 565;
				}
				if (num == 565)
				{
					this.button34.Click += this.button34_Click;
					num = 566;
				}
				if (num == 566)
				{
					this.label21.AutoSize = true;
					num = 567;
				}
				if (num == 567)
				{
					this.label21.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 568;
				}
				if (num == 569)
				{
					this.label21.Location = new Point(513, 726);
					num = 570;
				}
				if (num == 570)
				{
					this.label21.Name = "label21";
					num = 571;
				}
				if (num == 571)
				{
					this.label21.Size = new Size(134, 30);
					num = 572;
				}
				if (num == 572)
				{
					this.label21.TabIndex = 317;
					num = 573;
				}
				if (num == 573)
				{
					this.label21.Text = "| Size : 100MB";
					num = 574;
				}
				if (num == 574)
				{
					this.label22.AutoSize = true;
					num = 575;
				}
				if (num == 575)
				{
					this.label22.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 576;
				}
				if (num == 576)
				{
					this.label22.ForeColor = Color.White;
					num = 577;
				}
				if (num == 577)
				{
					this.label22.Location = new Point(14, 726);
					num = 578;
				}
				if (num == 578)
				{
					this.label22.Name = "label22";
					num = 579;
				}
				if (num == 579)
				{
					this.label22.Size = new Size(118, 30);
					num = 580;
				}
				if (num == 580)
				{
					this.label22.TabIndex = 316;
					num = 581;
				}
				if (num == 582)
				{
					this.label20.AutoSize = true;
					num = 583;
				}
				if (num == 583)
				{
					this.label20.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 584;
				}
				if (num == 584)
				{
					this.label20.ForeColor = Color.White;
					num = 585;
				}
				if (num == 585)
				{
					this.label20.Location = new Point(14, 661);
					num = 586;
				}
				if (num == 586)
				{
					this.label20.Name = "label20";
					num = 587;
				}
				if (num == 587)
				{
					this.label20.Size = new Size(121, 53);
					num = 588;
				}
				if (num == 588)
				{
					this.label20.TabIndex = 315;
					num = 589;
				}
				if (num == 589)
				{
					this.label20.Text = "Extras";
					num = 590;
				}
				if (num == 590)
				{
					this.button32.BackColor = Color.FromArgb(38, 38, 38);
					num = 591;
				}
				if (num == 591)
				{
					this.button32.BackgroundImageLayout = ImageLayout.None;
					num = 592;
				}
				if (num == 592)
				{
					this.button32.Cursor = Cursors.Hand;
					num = 593;
				}
				if (num == 593)
				{
					this.button32.FlatAppearance.BorderSize = 0;
					num = 594;
				}
				if (num == 595)
				{
					this.button32.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 596;
				}
				if (num == 596)
				{
					this.button32.ForeColor = Color.White;
					num = 597;
				}
				if (num == 597)
				{
					this.button32.Image = (Image)componentResourceManager.GetObject("button32.Image");
					num = 598;
				}
				if (num == 598)
				{
					this.button32.ImageAlign = ContentAlignment.MiddleLeft;
					num = 599;
				}
				if (num == 599)
				{
					this.button32.Location = new Point(812, 614);
					num = 600;
				}
				if (num == 600)
				{
					this.button32.Margin = new Padding(1);
					num = 601;
				}
				if (num == 601)
				{
					this.button32.Name = "button32";
					num = 602;
				}
				if (num == 602)
				{
					this.button32.Size = new Size(99, 30);
					num = 603;
				}
				if (num == 603)
				{
					this.button32.TabIndex = 313;
					num = 604;
				}
				if (num == 604)
				{
					this.button32.TabStop = false;
					num = 605;
				}
				if (num == 605)
				{
					this.button32.Text = "Install";
					num = 606;
				}
				if (num == 606)
				{
					this.button32.TextAlign = ContentAlignment.MiddleRight;
					num = 607;
				}
				if (num == 607)
				{
					this.button32.UseVisualStyleBackColor = false;
					num = 608;
				}
				if (num == 609)
				{
					this.button33.BackColor = Color.FromArgb(38, 38, 38);
					num = 610;
				}
				if (num == 608)
				{
					this.button32.Click += this.button32_Click;
					num = 609;
				}
				if (num == 594)
				{
					this.button32.FlatStyle = FlatStyle.Flat;
					num = 595;
				}
				if (num == 581)
				{
					this.label22.Text = "• DirectX 9c";
					num = 582;
				}
				if (num == 568)
				{
					this.label21.ForeColor = Color.White;
					num = 569;
				}
				if (num == 555)
				{
					this.button34.ImageAlign = ContentAlignment.MiddleLeft;
					num = 556;
				}
				if (num == 541)
				{
					this.label24.ForeColor = Color.White;
					num = 542;
				}
				if (num == 528)
				{
					this.button35.TextAlign = ContentAlignment.MiddleRight;
					num = 529;
				}
				if (num == 515)
				{
					this.button35.FlatAppearance.BorderSize = 0;
					num = 516;
				}
				if (num == 502)
				{
					this.label25.TabIndex = 323;
					num = 503;
				}
				if (num == 489)
				{
					this.button36.Size = new Size(120, 30);
					num = 490;
				}
				if (num == 475)
				{
					this.label28.TabIndex = 325;
					num = 476;
				}
				if (num == 462)
				{
					this.label27.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 463;
				}
				if (num == 449)
				{
					this.button37.Image = (Image)componentResourceManager.GetObject("button37.Image");
					num = 450;
				}
				if (num == 436)
				{
					this.label30.ForeColor = Color.White;
					num = 437;
				}
				if (num == 422)
				{
					this.button38.Text = "Download";
					num = 423;
				}
				if (num == 409)
				{
					this.button38.Cursor = Cursors.Hand;
					num = 410;
				}
				if (num == 396)
				{
					this.label31.Size = new Size(114, 30);
					num = 397;
				}
				if (num == 383)
				{
					this.button39.Name = "button39";
					num = 384;
				}
				if (num == 370)
				{
					this.label34.TabIndex = 334;
					num = 371;
				}
				if (num == 356)
				{
					this.label33.AutoSize = true;
					num = 357;
				}
				if (num == 343)
				{
					this.button40.ForeColor = Color.White;
					num = 344;
				}
				if (num == 330)
				{
					this.label36.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 331;
				}
				if (num == 317)
				{
					this.button4.Text = "Download";
					num = 318;
				}
				if (num == 304)
				{
					this.button4.Cursor = Cursors.Hand;
					num = 305;
				}
				if (num == 290)
				{
					this.button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
					num = 291;
				}
				if (num == 277)
				{
					this.label38.ForeColor = Color.White;
					num = 278;
				}
				if (num == 264)
				{
					this.button9.TextAlign = ContentAlignment.MiddleRight;
					num = 265;
				}
				if (num == 251)
				{
					this.button9.FlatAppearance.BorderSize = 0;
					num = 252;
				}
				if (num == 237)
				{
					this.label41.Size = new Size(153, 43);
					num = 238;
				}
				if (num == 224)
				{
					this.label42.AutoSize = true;
					num = 225;
				}
				if (num == 211)
				{
					this.button5.ForeColor = Color.White;
					num = 212;
				}
				if (num == 198)
				{
					this.panel1.Controls.Add(this.button7);
					num = 199;
				}
				if (num == 185)
				{
					this.panel1.Controls.Add(this.button13);
					num = 186;
				}
				if (num == 171)
				{
					this.panel1.Controls.Add(this.label16);
					num = 172;
				}
				if (num == 158)
				{
					this.panel1.Controls.Add(this.button35);
					num = 159;
				}
				if (num == 145)
				{
					this.panel1.Controls.Add(this.label34);
					num = 146;
				}
				if (num == 132)
				{
					this.panel1.Controls.Add(this.button5);
					num = 133;
				}
				if (num == 118)
				{
					this.button3.FlatStyle = FlatStyle.Flat;
					num = 119;
				}
				if (num == 105)
				{
					this.lblDownload.TabIndex = 101;
					num = 106;
				}
				if (num == 92)
				{
					this.lblSpeed.AutoSize = true;
					num = 93;
				}
				if (num == 79)
				{
					this.dl_location = new TextBox();
					num = 80;
				}
				if (num == 66)
				{
					this.button11 = new Button();
					num = 67;
				}
				if (num == 52)
				{
					this.label15 = new Label();
					num = 53;
				}
				if (num == 39)
				{
					this.label22 = new Label();
					num = 40;
				}
				if (num == 26)
				{
					this.label29 = new Label();
					num = 27;
				}
				if (num == 13)
				{
					this.label39 = new Label();
					num = 14;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1138);
		}

		// Token: 0x04000232 RID: 562
		private WebClient dl;

		// Token: 0x04000233 RID: 563
		private Stopwatch sw = new Stopwatch();

		// Token: 0x04000234 RID: 564
		private static WindowsApp _instace;

		// Token: 0x04000235 RID: 565
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x04000236 RID: 566
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000237 RID: 567
		private IContainer components = null;

		// Token: 0x04000238 RID: 568
		private Label label1;

		// Token: 0x04000239 RID: 569
		private Label lblSpeed;

		// Token: 0x0400023A RID: 570
		private Label lblDownload;

		// Token: 0x0400023B RID: 571
		private Label label2;

		// Token: 0x0400023C RID: 572
		private Button button3;

		// Token: 0x0400023D RID: 573
		private Panel panel1;

		// Token: 0x0400023E RID: 574
		private Button button7;

		// Token: 0x0400023F RID: 575
		private Label label81;

		// Token: 0x04000240 RID: 576
		private Label label6;

		// Token: 0x04000241 RID: 577
		private Button button1;

		// Token: 0x04000242 RID: 578
		private Button button6;

		// Token: 0x04000243 RID: 579
		private Button button8;

		// Token: 0x04000244 RID: 580
		private Label label3;

		// Token: 0x04000245 RID: 581
		private Label label4;

		// Token: 0x04000246 RID: 582
		private Button button10;

		// Token: 0x04000247 RID: 583
		private Button button11;

		// Token: 0x04000248 RID: 584
		private Label label5;

		// Token: 0x04000249 RID: 585
		private Label label7;

		// Token: 0x0400024A RID: 586
		private Button button13;

		// Token: 0x0400024B RID: 587
		private Button button14;

		// Token: 0x0400024C RID: 588
		private Label label8;

		// Token: 0x0400024D RID: 589
		private Label label9;

		// Token: 0x0400024E RID: 590
		private Button button16;

		// Token: 0x0400024F RID: 591
		private Button button17;

		// Token: 0x04000250 RID: 592
		private Label label10;

		// Token: 0x04000251 RID: 593
		private Label label11;

		// Token: 0x04000252 RID: 594
		private Button button19;

		// Token: 0x04000253 RID: 595
		private Button button20;

		// Token: 0x04000254 RID: 596
		private Label label12;

		// Token: 0x04000255 RID: 597
		private Label label13;

		// Token: 0x04000256 RID: 598
		private Button button26;

		// Token: 0x04000257 RID: 599
		private Button button27;

		// Token: 0x04000258 RID: 600
		private Label label14;

		// Token: 0x04000259 RID: 601
		private Label label15;

		// Token: 0x0400025A RID: 602
		private Button button29;

		// Token: 0x0400025B RID: 603
		private Button button30;

		// Token: 0x0400025C RID: 604
		private Label label16;

		// Token: 0x0400025D RID: 605
		private Label label17;

		// Token: 0x0400025E RID: 606
		private Button button32;

		// Token: 0x0400025F RID: 607
		private Button button33;

		// Token: 0x04000260 RID: 608
		private Label label18;

		// Token: 0x04000261 RID: 609
		private Label label19;

		// Token: 0x04000262 RID: 610
		private Label label20;

		// Token: 0x04000263 RID: 611
		private Button button34;

		// Token: 0x04000264 RID: 612
		private Label label21;

		// Token: 0x04000265 RID: 613
		private Label label22;

		// Token: 0x04000266 RID: 614
		private Button button35;

		// Token: 0x04000267 RID: 615
		private Label label23;

		// Token: 0x04000268 RID: 616
		private Label label24;

		// Token: 0x04000269 RID: 617
		private Button button36;

		// Token: 0x0400026A RID: 618
		private Label label25;

		// Token: 0x0400026B RID: 619
		private Label label26;

		// Token: 0x0400026C RID: 620
		private Button button37;

		// Token: 0x0400026D RID: 621
		private Label label27;

		// Token: 0x0400026E RID: 622
		private Label label28;

		// Token: 0x0400026F RID: 623
		private Button button38;

		// Token: 0x04000270 RID: 624
		private Label label29;

		// Token: 0x04000271 RID: 625
		private Label label30;

		// Token: 0x04000272 RID: 626
		private Button button39;

		// Token: 0x04000273 RID: 627
		private Label label31;

		// Token: 0x04000274 RID: 628
		private Label label32;

		// Token: 0x04000275 RID: 629
		private Button button40;

		// Token: 0x04000276 RID: 630
		private Label label33;

		// Token: 0x04000277 RID: 631
		private Label label34;

		// Token: 0x04000278 RID: 632
		private Button button2;

		// Token: 0x04000279 RID: 633
		private Button button4;

		// Token: 0x0400027A RID: 634
		private Label label35;

		// Token: 0x0400027B RID: 635
		private Label label36;

		// Token: 0x0400027C RID: 636
		private Label label37;

		// Token: 0x0400027D RID: 637
		private Label label38;

		// Token: 0x0400027E RID: 638
		private Button button9;

		// Token: 0x0400027F RID: 639
		private Label label39;

		// Token: 0x04000280 RID: 640
		private Label label40;

		// Token: 0x04000281 RID: 641
		private Label label41;

		// Token: 0x04000282 RID: 642
		private Label label42;

		// Token: 0x04000283 RID: 643
		private TextBox pkg_location;

		// Token: 0x04000284 RID: 644
		private TextBox dl_location;

		// Token: 0x04000285 RID: 645
		private SiticoneProgressBar ProgressBar1;

		// Token: 0x04000286 RID: 646
		private Button button5;

		// Token: 0x04000287 RID: 647
		private SiticoneVScrollBar siticoneVScrollBar1;
	}
}
