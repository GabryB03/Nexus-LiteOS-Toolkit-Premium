using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_HWID.Class;
using Microsoft.Win32;
using Newtonsoft.Json;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.User_Controls;

namespace Login_HWID.User_Controls
{
	// Token: 0x0200005B RID: 91
	public class Downloads : UserControl
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000A5DB4 File Offset: 0x000A3FB4
		public static Downloads Instance
		{
			get
			{
				if (Downloads._instace == null)
				{
					Downloads._instace = new Downloads();
				}
				return Downloads._instace;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000A5DDC File Offset: 0x000A3FDC
		public Downloads()
		{
			this.InitializeComponent();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000A5EC4 File Offset: 0x000A40C4
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
				this.Halloween_theme();
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x000A6118 File Offset: 0x000A4318
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x000A6190 File Offset: 0x000A4390
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x000A61F4 File Offset: 0x000A43F4
		private void Halloween_theme()
		{
			int num = 0;
			IEnumerator<DlAppCard> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.panel1.Controls.OfType<DlAppCard>().GetEnumerator();
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
					DlAppCard dlAppCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in dlAppCard.Controls.OfType<SiticoneCheckBox>())
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
			this.progressBar1.ProgressColor = Color.FromArgb(255, 128, 0);
			this.progressBar1.ProgressColor2 = Color.FromArgb(255, 128, 0);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000A6340 File Offset: 0x000A4540
		private void AccentColor()
		{
			int num = 0;
			Color accentColor;
			IEnumerator<DlAppCard> enumerator;
			do
			{
				if (num == 2)
				{
					this.progressBar1.ProgressColor = accentColor;
					num = 3;
				}
				if (num == 4)
				{
					enumerator = this.panel1.Controls.OfType<DlAppCard>().GetEnumerator();
					num = 5;
				}
				if (num == 3)
				{
					this.progressBar1.ProgressColor2 = accentColor;
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
			while (num != 5);
			try
			{
				while (enumerator.MoveNext())
				{
					DlAppCard dlAppCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in dlAppCard.Controls.OfType<SiticoneCheckBox>())
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x000A64DC File Offset: 0x000A46DC
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<DlAppCard> enumerator;
			do
			{
				if (num == 2)
				{
					this.progressBar1.ProgressColor2 = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 3)
				{
					enumerator = this.panel1.Controls.OfType<DlAppCard>().GetEnumerator();
					num = 4;
				}
				if (num == 1)
				{
					this.progressBar1.ProgressColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			try
			{
				while (enumerator.MoveNext())
				{
					DlAppCard dlAppCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in dlAppCard.Controls.OfType<SiticoneCheckBox>())
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

		// Token: 0x060003F8 RID: 1016 RVA: 0x000A6650 File Offset: 0x000A4850
		private void downloads_Load(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				object value;
				if (num == 2)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("Default Downloads Location");
					num = 3;
				}
				if (num == 5)
				{
					this.dl_location = value.ToString();
					num = 6;
				}
				if (num == 7)
				{
					base.BeginInvoke(new MethodInvoker(delegate
					{
						int num2 = 0;
						do
						{
							if (num2 == 1)
							{
								this.GetFeed();
								num2 = 2;
							}
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 2);
					}));
					num = 8;
				}
				if (num == 6)
				{
					goto IL_73;
				}
				IL_9E:
				if (num == 4)
				{
					bool flag;
					if (!flag)
					{
						goto IL_73;
					}
					num = 5;
				}
				if (num == 3)
				{
					bool flag = value != null;
					num = 4;
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
				if (num != 8)
				{
					continue;
				}
				break;
				IL_73:
				this.DPI_PREFERENCE = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ThemeManager", "LastLoadedDPI", "96"));
				num = 7;
				goto IL_9E;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000A67B4 File Offset: 0x000A49B4
		public void GetFeed()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					CS$<>8__locals1.<>4__this = this;
					num = 3;
				}
				if (num == 5)
				{
					base.BeginInvoke(new MethodInvoker(delegate
					{
						try
						{
							string tmpImageFileName = string.Empty;
							byte[] array = CS$<>8__locals1.client.DownloadData(CS$<>8__locals1.<>4__this._feedImages);
							using (ZipArchive zipArchive = new ZipArchive(new MemoryStream(array)))
							{
								ReadOnlyCollection<ZipArchiveEntry> entries = zipArchive.Entries;
								try
								{
									string text = CS$<>8__locals1.client.DownloadString(CS$<>8__locals1.<>4__this._feedLink);
									CS$<>8__locals1.<>4__this.AppsFromFeed = JsonConvert.DeserializeObject<List<FeedApp>>(text);
									CS$<>8__locals1.<>4__this.panel1.Controls.Clear();
									Func<ZipArchiveEntry, bool> <>9__1;
									foreach (FeedApp feedApp in CS$<>8__locals1.<>4__this.AppsFromFeed)
									{
										DlAppCard dlAppCard = new DlAppCard();
										dlAppCard.AutoSize = -3 + sizeof(float) != 0;
										dlAppCard.Anchor = ~(AnchorStyles.Top | AnchorStyles.Bottom) + sizeof(float);
										dlAppCard.Anchor = AnchorStyles.Top + sizeof(float);
										dlAppCard.appTitle.Text = feedApp.Title;
										dlAppCard.appTitle.Name = feedApp.Tag;
										dlAppCard.appImage.SizeMode = (PictureBoxSizeMode)(-3) + sizeof(float);
										dlAppCard.version.Text = feedApp.version;
										dlAppCard.type.Text = feedApp.type;
										dlAppCard.size.Text = feedApp.size;
										tmpImageFileName = feedApp.Image.Substring(feedApp.Image.LastIndexOf("/") + (-3 + sizeof(float)), feedApp.Image.Length - (feedApp.Image.LastIndexOf("/") + (-3 + sizeof(float))));
										PictureBox appImage = dlAppCard.appImage;
										IEnumerable<ZipArchiveEntry> enumerable = entries;
										Func<ZipArchiveEntry, bool> func;
										if ((func = <>9__1) == null)
										{
											func = (<>9__1 = (ZipArchiveEntry ifn) => ifn.Name == tmpImageFileName);
										}
										appImage.Image = Image.FromStream(enumerable.First(func).Open());
										dlAppCard.Location = new Point(-4 + sizeof(float), (int)((double)CS$<>8__locals1.<>4__this.panel1.Controls.Count * ((double)CS$<>8__locals1.<>4__this.DPI_PREFERENCE / CS$<>8__locals1.<>4__this.result)));
										CS$<>8__locals1.<>4__this.panel1.Controls.Add(dlAppCard);
										CS$<>8__locals1.<>4__this.LoadTheme();
									}
								}
								catch (Exception ex)
								{
									MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButtons)(-4) + sizeof(float), (MessageBoxIcon)12 + sizeof(float));
								}
							}
						}
						catch (Exception ex2)
						{
							MessageBox.Show("Error: " + ex2.Message, "Error", (MessageBoxButtons)(-4) + sizeof(float), (MessageBoxIcon)12 + sizeof(float));
						}
					}));
					num = 6;
				}
				if (num == 4)
				{
					CS$<>8__locals1.client.Headers.Add("Cache-Control", "no-cache");
					num = 5;
				}
				if (num == 3)
				{
					CS$<>8__locals1.client = new WebClient
					{
						Encoding = Encoding.UTF8
					};
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

		// Token: 0x060003FA RID: 1018 RVA: 0x000A68D0 File Offset: 0x000A4AD0
		private void RenderAppDownloaderBusy()
		{
			int num = 0;
			IEnumerator<DlAppCard> enumerator;
			do
			{
				if (num == 2)
				{
					enumerator = this.panel1.Controls.OfType<DlAppCard>().GetEnumerator();
					num = 3;
				}
				if (num == 1)
				{
					this.btnDownloadApps.Enabled = false;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					DlAppCard dlAppCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in dlAppCard.Controls.OfType<SiticoneCheckBox>())
					{
						siticoneCheckBox.Enabled = false;
					}
					foreach (Label label in dlAppCard.Controls.OfType<Label>())
					{
						label.ForeColor = Color.Black;
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

		// Token: 0x060003FB RID: 1019 RVA: 0x000A6A1C File Offset: 0x000A4C1C
		private void RenderAppDownloaderFree()
		{
			int num = 0;
			IEnumerator<DlAppCard> enumerator;
			do
			{
				if (num == 2)
				{
					this.progressBar1.Value = 0;
					num = 3;
				}
				if (num == 5)
				{
					this.lblDownload.Text = "";
					num = 6;
				}
				if (num == 8)
				{
					this.label2.Refresh();
					num = 9;
				}
				if (num == 10)
				{
					enumerator = this.panel1.Controls.OfType<DlAppCard>().GetEnumerator();
					num = 11;
				}
				if (num == 9)
				{
					this.btnDownloadApps.Enabled = true;
					num = 10;
				}
				if (num == 7)
				{
					this.label2.Text = "Status : Idle...";
					num = 8;
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
				if (num == 3)
				{
					this.lblSpeed.Text = "";
					num = 4;
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
			while (num != 11);
			try
			{
				while (enumerator.MoveNext())
				{
					DlAppCard dlAppCard = enumerator.Current;
					foreach (SiticoneCheckBox siticoneCheckBox in dlAppCard.Controls.OfType<SiticoneCheckBox>())
					{
						siticoneCheckBox.Enabled = true;
						siticoneCheckBox.Checked = false;
					}
					foreach (Label label in dlAppCard.Controls.OfType<Label>())
					{
						label.ForeColor = Color.White;
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

		// Token: 0x060003FC RID: 1020 RVA: 0x000A6C80 File Offset: 0x000A4E80
		[DebuggerStepThrough]
		private void btnDownloadApps_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					<btnDownloadApps_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
					num = 3;
				}
				if (num == 5)
				{
					<btnDownloadApps_Click>d__.e = e2;
					num = 6;
				}
				if (num == 7)
				{
					<btnDownloadApps_Click>d__.<>t__builder.Start<Downloads.<btnDownloadApps_Click>d__34>(ref <btnDownloadApps_Click>d__);
					num = 8;
				}
				if (num == 6)
				{
					<btnDownloadApps_Click>d__.<>1__state = -1;
					num = 7;
				}
				if (num == 4)
				{
					<btnDownloadApps_Click>d__.sender = sender2;
					num = 5;
				}
				if (num == 3)
				{
					<btnDownloadApps_Click>d__.<>4__this = this;
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
			while (num != 8);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000A6D74 File Offset: 0x000A4F74
		[DebuggerStepThrough]
		private Task DownloadApp(FeedApp app)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					<DownloadApp>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
					num = 3;
				}
				if (num == 5)
				{
					<DownloadApp>d__.<>1__state = -1;
					num = 6;
				}
				if (num == 6)
				{
					<DownloadApp>d__.<>t__builder.Start<Downloads.<DownloadApp>d__35>(ref <DownloadApp>d__);
					num = 7;
				}
				if (num == 4)
				{
					<DownloadApp>d__.app = app2;
					num = 5;
				}
				if (num == 3)
				{
					<DownloadApp>d__.<>4__this = this;
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
			while (num != 7);
			return <DownloadApp>d__.<>t__builder.Task;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000A6E58 File Offset: 0x000A5058
		public void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					CS$<>8__locals1.e = e2;
					num = 3;
				}
				if (num == 5)
				{
					base.BeginInvoke(new MethodInvoker(delegate
					{
						if (CS$<>8__locals1.e.Cancelled)
						{
							CS$<>8__locals1.<>4__this.RenderAppDownloaderFree();
							using (cancel cancel = new cancel())
							{
								cancel.ShowDialog(CS$<>8__locals1.<>4__this);
							}
						}
						if (CS$<>8__locals1.<>4__this.downloadCount == CS$<>8__locals1.<>4__this.maxCount)
						{
							if (((CS$<>8__locals1.e.Error == null) ? (-4 + sizeof(float)) : (((CS$<>8__locals1.e.Cancelled ? 1 : 0) == -4 + sizeof(float)) ? 1 : 0)) != 0)
							{
								CS$<>8__locals1.<>4__this.RenderAppDownloaderFree();
								DlError_DB dlError_DB = new DlError_DB(CS$<>8__locals1.<>4__this.downloadLog);
								dlError_DB.ShowDialog(CS$<>8__locals1.<>4__this);
							}
							else if ((CS$<>8__locals1.<>4__this.cancelled ? 1 : 0) == -4 + sizeof(float))
							{
								CS$<>8__locals1.<>4__this.RenderAppDownloaderFree();
								DlFinished_DB dlFinished_DB = new DlFinished_DB(CS$<>8__locals1.<>4__this.downloadLog);
								dlFinished_DB.ShowDialog(CS$<>8__locals1.<>4__this);
							}
						}
					}));
					num = 6;
				}
				if (num == 4)
				{
					this.downloadCount++;
					num = 5;
				}
				if (num == 3)
				{
					CS$<>8__locals1.<>4__this = this;
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

		// Token: 0x060003FF RID: 1023 RVA: 0x000A6F2C File Offset: 0x000A512C
		private void Downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					CS$<>8__locals1.<>4__this = this;
					num = 3;
				}
				if (num == 4)
				{
					base.BeginInvoke(new Action(delegate
					{
						CS$<>8__locals1.<>4__this.label2.Text = string.Format("({1}/{2}) - {0} ...", CS$<>8__locals1.<>4__this.appNameTemp, CS$<>8__locals1.<>4__this.count, CS$<>8__locals1.<>4__this.maxCount);
						CS$<>8__locals1.<>4__this.lblSpeed.Text = string.Format("{0} kb/s", ((double)CS$<>8__locals1.e.BytesReceived / 1024.0 / CS$<>8__locals1.<>4__this.sw.Elapsed.TotalSeconds).ToString("0.00"));
						CS$<>8__locals1.<>4__this.lblDownload.Text = string.Format("{0} MB / {1} MB", ((double)CS$<>8__locals1.e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)CS$<>8__locals1.e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
						CS$<>8__locals1.<>4__this.progressBar1.Value = CS$<>8__locals1.e.ProgressPercentage;
					}));
					num = 5;
				}
				if (num == 3)
				{
					CS$<>8__locals1.e = e2;
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
			while (num != 5);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000A7008 File Offset: 0x000A5208
		private void button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				bool flag;
				if (num == 2)
				{
					flag = this._webClient != null;
					num = 3;
				}
				if (num == 4)
				{
					this._webClient.CancelAsync();
					num = 5;
				}
				if (num == 3)
				{
					if (!flag)
					{
						break;
					}
					num = 4;
				}
				if (num == 1)
				{
					this.cancelled = true;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000A70AC File Offset: 0x000A52AC
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

		// Token: 0x06000402 RID: 1026 RVA: 0x000A7124 File Offset: 0x000A5324
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 5)
				{
					this.progressBar1 = new SiticoneProgressBar();
					num = 6;
				}
				if (num == 8)
				{
					this.label2 = new Label();
					num = 9;
				}
				if (num == 11)
				{
					base.SuspendLayout();
					num = 12;
				}
				if (num == 14)
				{
					this.label266.ForeColor = Color.Silver;
					num = 15;
				}
				if (num == 17)
				{
					this.label266.Size = new Size(270, 19);
					num = 18;
				}
				if (num == 20)
				{
					this.label1.AutoSize = true;
					num = 21;
				}
				if (num == 23)
				{
					this.label1.Location = new Point(18, 0);
					num = 24;
				}
				if (num == 26)
				{
					this.label1.TabIndex = 93;
					num = 27;
				}
				if (num == 29)
				{
					this.panel1.Location = new Point(23, 81);
					num = 30;
				}
				if (num == 32)
				{
					this.panel1.TabIndex = 95;
					num = 33;
				}
				if (num == 35)
				{
					this.siticoneVScrollBar1.FillColor = Color.Transparent;
					num = 36;
				}
				if (num == 38)
				{
					this.siticoneVScrollBar1.LargeChange = 10;
					num = 39;
				}
				if (num == 41)
				{
					this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
					num = 42;
				}
				if (num == 44)
				{
					this.siticoneVScrollBar1.TabIndex = 337;
					num = 45;
				}
				if (num == 47)
				{
					this.progressBar1.BorderRadius = 10;
					num = 48;
				}
				if (num == 50)
				{
					this.progressBar1.ProgressColor = Color.Gray;
					num = 51;
				}
				if (num == 53)
				{
					this.progressBar1.Size = new Size(756, 23);
					num = 54;
				}
				if (num == 56)
				{
					this.lblSpeed.AutoSize = true;
					num = 57;
				}
				if (num == 59)
				{
					this.lblSpeed.Location = new Point(408, 630);
					num = 60;
				}
				if (num == 62)
				{
					this.lblSpeed.TabIndex = 341;
					num = 63;
				}
				if (num == 65)
				{
					this.lblDownload.ForeColor = Color.White;
					num = 66;
				}
				if (num == 68)
				{
					this.lblDownload.Size = new Size(0, 25);
					num = 69;
				}
				if (num == 71)
				{
					this.label2.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 72;
				}
				if (num == 74)
				{
					this.label2.Name = "label2";
					num = 75;
				}
				if (num == 77)
				{
					this.label2.Text = "Status : Idle....";
					num = 78;
				}
				if (num == 80)
				{
					this.btnDownloadApps.Cursor = Cursors.Hand;
					num = 81;
				}
				if (num == 83)
				{
					this.btnDownloadApps.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 84;
				}
				if (num == 86)
				{
					this.btnDownloadApps.Location = new Point(787, 596);
					num = 87;
				}
				if (num == 89)
				{
					this.btnDownloadApps.Size = new Size(101, 35);
					num = 90;
				}
				if (num == 92)
				{
					this.btnDownloadApps.Text = "Download";
					num = 93;
				}
				if (num == 95)
				{
					this.button1.BackColor = Color.FromArgb(38, 38, 38);
					num = 96;
				}
				if (num == 98)
				{
					this.button1.FlatAppearance.BorderSize = 0;
					num = 99;
				}
				if (num == 101)
				{
					this.button1.ForeColor = Color.White;
					num = 102;
				}
				if (num == 104)
				{
					this.button1.Margin = new Padding(1);
					num = 105;
				}
				if (num == 107)
				{
					this.button1.TabIndex = 343;
					num = 108;
				}
				if (num == 110)
				{
					this.button1.UseVisualStyleBackColor = false;
					num = 111;
				}
				if (num == 113)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 114;
				}
				if (num == 116)
				{
					base.Controls.Add(this.button1);
					num = 117;
				}
				if (num == 119)
				{
					base.Controls.Add(this.lblDownload);
					num = 120;
				}
				if (num == 122)
				{
					base.Controls.Add(this.panel1);
					num = 123;
				}
				if (num == 125)
				{
					base.Name = "Downloads";
					num = 126;
				}
				if (num == 128)
				{
					base.ResumeLayout(false);
					num = 129;
				}
				if (num == 129)
				{
					base.PerformLayout();
					num = 130;
				}
				if (num == 127)
				{
					base.Load += this.downloads_Load;
					num = 128;
				}
				if (num == 126)
				{
					base.Size = new Size(1032, 669);
					num = 127;
				}
				if (num == 124)
				{
					base.Controls.Add(this.label1);
					num = 125;
				}
				if (num == 123)
				{
					base.Controls.Add(this.label266);
					num = 124;
				}
				if (num == 121)
				{
					base.Controls.Add(this.btnDownloadApps);
					num = 122;
				}
				if (num == 120)
				{
					base.Controls.Add(this.label2);
					num = 121;
				}
				if (num == 118)
				{
					base.Controls.Add(this.lblSpeed);
					num = 119;
				}
				if (num == 117)
				{
					base.Controls.Add(this.progressBar1);
					num = 118;
				}
				if (num == 115)
				{
					base.Controls.Add(this.siticoneVScrollBar1);
					num = 116;
				}
				if (num == 114)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 115;
				}
				if (num == 112)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 113;
				}
				if (num == 111)
				{
					this.button1.Click += this.button1_Click;
					num = 112;
				}
				if (num == 109)
				{
					this.button1.Text = "Cancel";
					num = 110;
				}
				if (num == 108)
				{
					this.button1.TabStop = false;
					num = 109;
				}
				if (num == 106)
				{
					this.button1.Size = new Size(101, 35);
					num = 107;
				}
				if (num == 105)
				{
					this.button1.Name = "button1";
					num = 106;
				}
				if (num == 103)
				{
					this.button1.Location = new Point(890, 596);
					num = 104;
				}
				if (num == 102)
				{
					this.button1.ImageAlign = ContentAlignment.MiddleLeft;
					num = 103;
				}
				if (num == 100)
				{
					this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 101;
				}
				if (num == 99)
				{
					this.button1.FlatStyle = FlatStyle.Flat;
					num = 100;
				}
				if (num == 97)
				{
					this.button1.Cursor = Cursors.Hand;
					num = 98;
				}
				if (num == 96)
				{
					this.button1.BackgroundImageLayout = ImageLayout.None;
					num = 97;
				}
				if (num == 94)
				{
					this.btnDownloadApps.Click += this.btnDownloadApps_Click;
					num = 95;
				}
				if (num == 93)
				{
					this.btnDownloadApps.UseVisualStyleBackColor = false;
					num = 94;
				}
				if (num == 91)
				{
					this.btnDownloadApps.TabStop = false;
					num = 92;
				}
				if (num == 90)
				{
					this.btnDownloadApps.TabIndex = 338;
					num = 91;
				}
				if (num == 88)
				{
					this.btnDownloadApps.Name = "btnDownloadApps";
					num = 89;
				}
				if (num == 87)
				{
					this.btnDownloadApps.Margin = new Padding(1);
					num = 88;
				}
				if (num == 85)
				{
					this.btnDownloadApps.ImageAlign = ContentAlignment.MiddleLeft;
					num = 86;
				}
				if (num == 84)
				{
					this.btnDownloadApps.ForeColor = Color.White;
					num = 85;
				}
				if (num == 82)
				{
					this.btnDownloadApps.FlatStyle = FlatStyle.Flat;
					num = 83;
				}
				if (num == 81)
				{
					this.btnDownloadApps.FlatAppearance.BorderSize = 0;
					num = 82;
				}
				if (num == 79)
				{
					this.btnDownloadApps.BackgroundImageLayout = ImageLayout.None;
					num = 80;
				}
				if (num == 78)
				{
					this.btnDownloadApps.BackColor = Color.FromArgb(38, 38, 38);
					num = 79;
				}
				if (num == 76)
				{
					this.label2.TabIndex = 339;
					num = 77;
				}
				if (num == 75)
				{
					this.label2.Size = new Size(112, 25);
					num = 76;
				}
				if (num == 73)
				{
					this.label2.Location = new Point(22, 630);
					num = 74;
				}
				if (num == 72)
				{
					this.label2.ForeColor = Color.White;
					num = 73;
				}
				if (num == 70)
				{
					this.label2.AutoSize = true;
					num = 71;
				}
				if (num == 69)
				{
					this.lblDownload.TabIndex = 340;
					num = 70;
				}
				if (num == 67)
				{
					this.lblDownload.Name = "lblDownload";
					num = 68;
				}
				if (num == 66)
				{
					this.lblDownload.Location = new Point(618, 628);
					num = 67;
				}
				if (num == 64)
				{
					this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 65;
				}
				if (num == 63)
				{
					this.lblDownload.AutoSize = true;
					num = 64;
				}
				if (num == 61)
				{
					this.lblSpeed.Size = new Size(0, 25);
					num = 62;
				}
				if (num == 60)
				{
					this.lblSpeed.Name = "lblSpeed";
					num = 61;
				}
				if (num == 58)
				{
					this.lblSpeed.ForeColor = Color.White;
					num = 59;
				}
				if (num == 57)
				{
					this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 58;
				}
				if (num == 55)
				{
					this.progressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
					num = 56;
				}
				if (num == 54)
				{
					this.progressBar1.TabIndex = 342;
					num = 55;
				}
				if (num == 52)
				{
					this.progressBar1.ShadowDecoration.Parent = this.progressBar1;
					num = 53;
				}
				if (num == 51)
				{
					this.progressBar1.ProgressColor2 = Color.Gray;
					num = 52;
				}
				if (num == 49)
				{
					this.progressBar1.Name = "progressBar1";
					num = 50;
				}
				if (num == 48)
				{
					this.progressBar1.Location = new Point(27, 596);
					num = 49;
				}
				if (num == 46)
				{
					this.siticoneVScrollBar1.ThumbSize = 80f;
					num = 47;
				}
				if (num == 45)
				{
					this.siticoneVScrollBar1.ThumbColor = Color.Gray;
					num = 46;
				}
				if (num == 43)
				{
					this.siticoneVScrollBar1.Size = new Size(18, 496);
					num = 44;
				}
				if (num == 42)
				{
					this.siticoneVScrollBar1.ScrollbarSize = 18;
					num = 43;
				}
				if (num == 40)
				{
					this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
					num = 41;
				}
				if (num == 39)
				{
					this.siticoneVScrollBar1.Location = new Point(979, 81);
					num = 40;
				}
				if (num == 37)
				{
					this.siticoneVScrollBar1.InUpdate = false;
					num = 38;
				}
				if (num == 36)
				{
					this.siticoneVScrollBar1.HoverState.Parent = null;
					num = 37;
				}
				if (num == 34)
				{
					this.siticoneVScrollBar1.BorderRadius = 8;
					num = 35;
				}
				if (num == 33)
				{
					this.siticoneVScrollBar1.BindingContainer = this.panel1;
					num = 34;
				}
				if (num == 31)
				{
					this.panel1.Size = new Size(974, 496);
					num = 32;
				}
				if (num == 30)
				{
					this.panel1.Name = "panel1";
					num = 31;
				}
				if (num == 28)
				{
					this.panel1.AutoScroll = true;
					num = 29;
				}
				if (num == 27)
				{
					this.label1.Text = "Downloads";
					num = 28;
				}
				if (num == 25)
				{
					this.label1.Size = new Size(193, 53);
					num = 26;
				}
				if (num == 24)
				{
					this.label1.Name = "label1";
					num = 25;
				}
				if (num == 22)
				{
					this.label1.ForeColor = Color.White;
					num = 23;
				}
				if (num == 21)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 22;
				}
				if (num == 19)
				{
					this.label266.Text = "Download over 100+ software cracked/freeware";
					num = 20;
				}
				if (num == 18)
				{
					this.label266.TabIndex = 94;
					num = 19;
				}
				if (num == 16)
				{
					this.label266.Name = "label266";
					num = 17;
				}
				if (num == 15)
				{
					this.label266.Location = new Point(23, 53);
					num = 16;
				}
				if (num == 13)
				{
					this.label266.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 14;
				}
				if (num == 12)
				{
					this.label266.AutoSize = true;
					num = 13;
				}
				if (num == 10)
				{
					this.button1 = new Button();
					num = 11;
				}
				if (num == 9)
				{
					this.btnDownloadApps = new Button();
					num = 10;
				}
				if (num == 7)
				{
					this.lblDownload = new Label();
					num = 8;
				}
				if (num == 6)
				{
					this.lblSpeed = new Label();
					num = 7;
				}
				if (num == 4)
				{
					this.siticoneVScrollBar1 = new SiticoneVScrollBar();
					num = 5;
				}
				if (num == 3)
				{
					this.panel1 = new Panel();
					num = 4;
				}
				if (num == 1)
				{
					this.label266 = new Label();
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 130);
		}

		// Token: 0x04000469 RID: 1129
		private string appNameTemp = string.Empty;

		// Token: 0x0400046A RID: 1130
		private int maxCount = 0;

		// Token: 0x0400046B RID: 1131
		private int count = 0;

		// Token: 0x0400046C RID: 1132
		private bool cancelled = false;

		// Token: 0x0400046D RID: 1133
		private WebClient _webClient;

		// Token: 0x0400046E RID: 1134
		private Task _downloadTask;

		// Token: 0x0400046F RID: 1135
		private string downloadLog = string.Empty;

		// Token: 0x04000470 RID: 1136
		private static int a = 25;

		// Token: 0x04000471 RID: 1137
		private static int b = 10;

		// Token: 0x04000472 RID: 1138
		private double result = (double)Downloads.a / (double)Downloads.b;

		// Token: 0x04000473 RID: 1139
		private readonly string _feedLink = "https://cdn.discordapp.com/attachments/1072496745839345664/1081156038620880906/Downloads.json";

		// Token: 0x04000474 RID: 1140
		private readonly string _feedImages = "https://cdn.discordapp.com/attachments/1072496745839345664/1081156038293733418/icons.zip";

		// Token: 0x04000475 RID: 1141
		public List<FeedApp> AppsFromFeed = new List<FeedApp>();

		// Token: 0x04000476 RID: 1142
		private int downloadCount = 0;

		// Token: 0x04000477 RID: 1143
		private string fileExtension = ".exe";

		// Token: 0x04000478 RID: 1144
		private List<SiticoneCheckBox> checkBoxes = new List<SiticoneCheckBox>();

		// Token: 0x04000479 RID: 1145
		private int DPI_PREFERENCE;

		// Token: 0x0400047A RID: 1146
		private string dl_location;

		// Token: 0x0400047B RID: 1147
		private Stopwatch sw = new Stopwatch();

		// Token: 0x0400047C RID: 1148
		private static Downloads _instace;

		// Token: 0x0400047D RID: 1149
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x0400047E RID: 1150
		private IContainer components = null;

		// Token: 0x0400047F RID: 1151
		private Label label266;

		// Token: 0x04000480 RID: 1152
		private Label label1;

		// Token: 0x04000481 RID: 1153
		private SiticoneVScrollBar siticoneVScrollBar1;

		// Token: 0x04000482 RID: 1154
		private SiticoneProgressBar progressBar1;

		// Token: 0x04000483 RID: 1155
		private Label lblSpeed;

		// Token: 0x04000484 RID: 1156
		private Label lblDownload;

		// Token: 0x04000485 RID: 1157
		private Label label2;

		// Token: 0x04000486 RID: 1158
		private Button btnDownloadApps;

		// Token: 0x04000487 RID: 1159
		private Button button1;

		// Token: 0x04000488 RID: 1160
		private Panel panel1;
	}
}
