using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000065 RID: 101
	public class IPv4 : UserControl
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00155994 File Offset: 0x00153B94
		public static IPv4 Instance
		{
			get
			{
				if (IPv4._instace == null)
				{
					IPv4._instace = new IPv4();
				}
				return IPv4._instace;
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x001559BC File Offset: 0x00153BBC
		public IPv4()
		{
			this.InitializeComponent();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00155A14 File Offset: 0x00153C14
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
				object value;
				if (num == 2)
				{
					value = registryKey.GetValue("Theme");
					num = 3;
				}
				object obj;
				if (num == 3)
				{
					obj = value;
					num = 4;
				}
				object obj2;
				if (num == 4)
				{
					obj2 = obj;
					num = 5;
				}
				string text;
				if (num == 5)
				{
					text = obj2 as string;
					num = 6;
				}
				if (num == 6)
				{
					if (text == null)
					{
						break;
					}
					num = 7;
				}
				if (num != 7)
				{
					goto IL_DA;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_DA;
				}
				goto IL_11D;
				IL_16E:
				if (num == 16 || num == 17)
				{
					break;
				}
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_1AB;
					}
					num = 9;
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
				IL_1BD:
				if (num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_15C;
				}
				goto IL_16E;
				IL_12F:
				if (num == 12)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_1AB;
				}
				goto IL_1BD;
				IL_DA:
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_15C;
					}
					num = 10;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 11)
				{
					goto IL_11D;
				}
				goto IL_12F;
				IL_15C:
				this.AccentColor();
				num = 16;
				goto IL_16E;
				IL_1AB:
				this.Halloween();
				num = 14;
				goto IL_1BD;
				IL_11D:
				this.Xmas_theme();
				num = 12;
				goto IL_12F;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00155C50 File Offset: 0x00153E50
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

		// Token: 0x06000910 RID: 2320 RVA: 0x00155CC8 File Offset: 0x00153EC8
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

		// Token: 0x06000911 RID: 2321 RVA: 0x00155D2C File Offset: 0x00153F2C
		private void Halloween()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.save.FillColor = Color.FromArgb(255, 128, 0);
					num = 2;
				}
				if (num == 2)
				{
					this.custom_ip.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 3;
				}
				if (num == 3)
				{
					this.custom_ip.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 4;
				}
				if (num == 4)
				{
					this.subnet_mask.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 5;
				}
				if (num == 5)
				{
					this.subnet_mask.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 6;
				}
				if (num == 6)
				{
					this.default_gateway.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 7;
				}
				if (num == 7)
				{
					this.default_gateway.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 8;
				}
				if (num == 9)
				{
					this.DNS_server1.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 10;
				}
				if (num == 10)
				{
					this.DNS_server2.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 11;
				}
				if (num == 11)
				{
					this.DNS_server2.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					num = 12;
				}
				if (num == 8)
				{
					this.DNS_server1.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00155FC0 File Offset: 0x001541C0
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
				if (num == 2)
				{
					this.save.FillColor = accentColor;
					num = 3;
				}
				if (num == 3)
				{
					this.custom_ip.CheckedState.FillColor = accentColor;
					num = 4;
				}
				if (num == 4)
				{
					this.custom_ip.CheckedState.BorderColor = accentColor;
					num = 5;
				}
				if (num == 5)
				{
					this.subnet_mask.CheckedState.FillColor = accentColor;
					num = 6;
				}
				if (num == 6)
				{
					this.subnet_mask.CheckedState.BorderColor = accentColor;
					num = 7;
				}
				if (num == 7)
				{
					this.default_gateway.CheckedState.FillColor = accentColor;
					num = 8;
				}
				if (num == 9)
				{
					this.DNS_server1.CheckedState.FillColor = accentColor;
					num = 10;
				}
				if (num == 10)
				{
					this.DNS_server1.CheckedState.BorderColor = accentColor;
					num = 11;
				}
				if (num == 11)
				{
					this.DNS_server2.CheckedState.FillColor = accentColor;
					num = 12;
				}
				if (num == 12)
				{
					this.DNS_server2.CheckedState.BorderColor = accentColor;
					num = 13;
				}
				if (num == 8)
				{
					this.default_gateway.CheckedState.BorderColor = accentColor;
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 13);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00156210 File Offset: 0x00154410
		private void Xmas_theme()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.save.FillColor = Color.FromArgb(29, 158, 255);
					num = 2;
				}
				if (num == 2)
				{
					this.custom_ip.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 3;
				}
				if (num == 3)
				{
					this.custom_ip.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 4;
				}
				if (num == 4)
				{
					this.subnet_mask.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 5;
				}
				if (num == 5)
				{
					this.subnet_mask.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 6;
				}
				if (num == 6)
				{
					this.default_gateway.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 7;
				}
				if (num == 7)
				{
					this.default_gateway.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 8;
				}
				if (num == 9)
				{
					this.DNS_server1.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 10;
				}
				if (num == 10)
				{
					this.DNS_server2.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 11;
				}
				if (num == 11)
				{
					this.DNS_server2.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					num = 12;
				}
				if (num == 8)
				{
					this.DNS_server1.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 12);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x001564A4 File Offset: 0x001546A4
		private void IPv4_Load(object sender, EventArgs e)
		{
			int num = 0;
			NetworkInterface networkInterface2;
			IPAddressCollection dnsAddresses;
			IEnumerator<UnicastIPAddressInformation> enumerator;
			for (;;)
			{
				NetworkInterface[] allNetworkInterfaces;
				if (num == 1)
				{
					allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					num = 2;
				}
				if (num == 2)
				{
					num = 3;
				}
				int num2;
				if (num == 3)
				{
					num2 = 0;
					num = 4;
				}
				bool flag;
				if (num == 4)
				{
					flag = num2 < allNetworkInterfaces.Length;
					num = 5;
				}
				if (num != 5)
				{
					goto IL_5E;
				}
				if (flag)
				{
					num = 6;
					goto IL_5E;
				}
				goto IL_1DF;
				IL_1EC:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					break;
				}
				continue;
				IL_5E:
				NetworkInterface networkInterface;
				if (num == 6)
				{
					networkInterface = allNetworkInterfaces[num2];
					num = 7;
				}
				if (num == 7)
				{
					this.cmbox.Text = networkInterface.Name;
					num = 8;
				}
				if (num == 9)
				{
					num = 10;
				}
				int num3;
				if (num == 10)
				{
					num3 = 0;
					num = 11;
				}
				if (num == 11)
				{
					goto IL_12F;
				}
				if (num == 12)
				{
					goto IL_D3;
				}
				goto IL_E0;
				IL_13D:
				if (num == 16)
				{
					this.cmbox.Items.Remove("Loopback Pseudo-Interface 1");
					num = 17;
				}
				if (num == 18)
				{
					goto IL_1AA;
				}
				IL_1B5:
				if (num == 19)
				{
					dnsAddresses = networkInterface2.GetIPProperties().DnsAddresses;
					num = 20;
				}
				if (num == 20)
				{
					enumerator = networkInterface2.GetIPProperties().UnicastAddresses.GetEnumerator();
					num = 21;
				}
				if (num == 17)
				{
					if (num2 >= allNetworkInterfaces.Length)
					{
						return;
					}
				}
				else
				{
					if (num == 8)
					{
						goto IL_1DF;
					}
					goto IL_1EC;
				}
				IL_1AA:
				networkInterface2 = allNetworkInterfaces[num2];
				num = 19;
				goto IL_1B5;
				IL_E0:
				NetworkInterface networkInterface3;
				if (num == 13)
				{
					this.cmbox.Items.Add(networkInterface3.Name);
					num = 14;
				}
				if (num == 14)
				{
					num3++;
					num = 15;
				}
				if (num != 15)
				{
					goto IL_13D;
				}
				IL_12F:
				NetworkInterface[] allNetworkInterfaces2;
				if (num3 >= allNetworkInterfaces2.Length)
				{
					num = 16;
					goto IL_13D;
				}
				IL_D3:
				networkInterface3 = allNetworkInterfaces2[num3];
				num = 13;
				goto IL_E0;
				IL_1DF:
				allNetworkInterfaces2 = NetworkInterface.GetAllNetworkInterfaces();
				num = 9;
				goto IL_1EC;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					UnicastIPAddressInformation unicastIPAddressInformation = enumerator.Current;
					if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						this.ip.Text = unicastIPAddressInformation.Address.ToString();
						this.subnetmask.Text = unicastIPAddressInformation.IPv4Mask.ToString();
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
			foreach (GatewayIPAddressInformation gatewayIPAddressInformation in networkInterface2.GetIPProperties().GatewayAddresses)
			{
				if (gatewayIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
				{
					this.defaultgateway.Text = gatewayIPAddressInformation.Address.ToString();
				}
			}
			using (IEnumerator<IPAddress> enumerator3 = dnsAddresses.GetEnumerator())
			{
				if (enumerator3.MoveNext())
				{
					IPAddress ipaddress = enumerator3.Current;
					this.dns1.Text = ipaddress.ToString();
				}
			}
			foreach (IPAddress ipaddress2 in dnsAddresses)
			{
				if (!this.dns1.Text.Contains(ipaddress2.ToString()))
				{
					this.dns2.Text = ipaddress2.ToString();
				}
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00156880 File Offset: 0x00154A80
		private void custom_ip_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.custom_ip.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_55;
				IL_6E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 3)
				{
					this.ip.ReadOnly = false;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_6E;
				}
				IL_55:
				this.ip.ReadOnly = true;
				num = 6;
				goto IL_6E;
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00156940 File Offset: 0x00154B40
		private void subnet_mask_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.subnet_mask.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_55;
				IL_6E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 3)
				{
					this.subnetmask.ReadOnly = false;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_6E;
				}
				IL_55:
				this.subnetmask.ReadOnly = true;
				num = 6;
				goto IL_6E;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00156A00 File Offset: 0x00154C00
		private void default_gateway_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.default_gateway.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_55;
				IL_6E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 3)
				{
					this.defaultgateway.ReadOnly = false;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_6E;
				}
				IL_55:
				this.defaultgateway.ReadOnly = true;
				num = 6;
				goto IL_6E;
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00156AC0 File Offset: 0x00154CC0
		private void DNS_server1_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.DNS_server1.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_55;
				IL_6E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 3)
				{
					this.dns1.ReadOnly = false;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_6E;
				}
				IL_55:
				this.dns1.ReadOnly = true;
				num = 6;
				goto IL_6E;
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00156B80 File Offset: 0x00154D80
		private void DNS_server2_CheckedChanged(object sender, EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				bool @checked;
				if (num == 1)
				{
					@checked = this.DNS_server2.Checked;
					num = 2;
				}
				if (num != 2)
				{
					goto IL_1E;
				}
				if (@checked)
				{
					num = 3;
					goto IL_1E;
				}
				goto IL_55;
				IL_6E:
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1E:
				if (num == 3)
				{
					this.dns2.ReadOnly = false;
					num = 4;
				}
				if (num == 4)
				{
					break;
				}
				if (num != 5)
				{
					goto IL_6E;
				}
				IL_55:
				this.dns2.ReadOnly = true;
				num = 6;
				goto IL_6E;
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00156C40 File Offset: 0x00154E40
		private void save_Click(object sender, EventArgs e)
		{
			int num = 0;
			applied applied;
			do
			{
				if (num == 1)
				{
					IPv4.p.StartInfo.FileName = "netsh.exe";
					num = 2;
				}
				if (num == 2)
				{
					IPv4.p.StartInfo.Arguments = string.Concat(new string[]
					{
						"interface ip set address \"",
						this.cmbox.Text,
						"\" static ",
						this.ip.Text,
						" ",
						this.subnetmask.Text,
						" ",
						this.defaultgateway.Text
					});
					num = 3;
				}
				if (num == 3)
				{
					IPv4.p.Start();
					num = 4;
				}
				if (num == 4)
				{
					IPv4.p.WaitForExit();
					num = 5;
				}
				if (num == 5)
				{
					IPv4.p.StartInfo.FileName = "netsh.exe";
					num = 6;
				}
				if (num == 6)
				{
					ProcessStartInfo startInfo = IPv4.p.StartInfo;
					string text = "interface ip add dns \"";
					string text2 = this.cmbox.Text;
					string text3 = "\" ";
					SiticoneTextBox siticoneTextBox = this.dns1;
					startInfo.Arguments = text + text2 + text3 + ((siticoneTextBox != null) ? siticoneTextBox.ToString() : null);
					num = 7;
				}
				if (num == 7)
				{
					IPv4.p.Start();
					num = 8;
				}
				if (num == 9)
				{
					IPv4.p.StartInfo.FileName = "netsh.exe";
					num = 10;
				}
				if (num == 10)
				{
					IPv4.p.StartInfo.Arguments = string.Concat(new string[]
					{
						"interface ip add dns \"",
						this.cmbox.Text,
						"\" ",
						this.dns2.Text,
						" index=2"
					});
					num = 11;
				}
				if (num == 11)
				{
					IPv4.p.Start();
					num = 12;
				}
				if (num == 12)
				{
					IPv4.p.WaitForExit();
					num = 13;
				}
				if (num == 13)
				{
					IPv4.p.StartInfo.FileName = "netsh.exe";
					num = 14;
				}
				if (num == 14)
				{
					IPv4.p.StartInfo.Arguments = "int tcp set heuristics disabled";
					num = 15;
				}
				if (num == 15)
				{
					IPv4.p.Start();
					num = 16;
				}
				if (num == 16)
				{
					IPv4.p.WaitForExit();
					num = 17;
				}
				if (num == 17)
				{
					applied = new applied();
					num = 18;
				}
				if (num == 8)
				{
					IPv4.p.WaitForExit();
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 18);
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

		// Token: 0x0600091B RID: 2331 RVA: 0x00018F88 File Offset: 0x00017188
		private void back_btn_Click(object sender, EventArgs e)
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

		// Token: 0x0600091C RID: 2332 RVA: 0x00156FC4 File Offset: 0x001551C4
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					base.Controls.Add(Affinities.Instance);
					num = 2;
				}
				if (num == 2)
				{
					Affinities.Instance.Dock = DockStyle.Fill;
					num = 3;
				}
				if (num == 3)
				{
					Affinities.Instance.BringToFront();
					num = 4;
				}
				if (num == 4)
				{
					Affinities.Instance.Show();
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00157070 File Offset: 0x00155270
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

		// Token: 0x0600091E RID: 2334 RVA: 0x001570E8 File Offset: 0x001552E8
		private void InitializeComponent()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.label37 = new Label();
					num = 2;
				}
				if (num == 2)
				{
					this.label1 = new Label();
					num = 3;
				}
				if (num == 3)
				{
					this.groupBox1 = new GroupBox();
					num = 4;
				}
				if (num == 4)
				{
					this.save = new SiticoneButton();
					num = 5;
				}
				if (num == 5)
				{
					this.dns2 = new SiticoneTextBox();
					num = 6;
				}
				if (num == 6)
				{
					this.dns1 = new SiticoneTextBox();
					num = 7;
				}
				if (num == 7)
				{
					this.defaultgateway = new SiticoneTextBox();
					num = 8;
				}
				if (num == 9)
				{
					this.ip = new SiticoneTextBox();
					num = 10;
				}
				if (num == 10)
				{
					this.DNS_server2 = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 11)
				{
					this.DNS_server1 = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 12)
				{
					this.subnet_mask = new SiticoneCheckBox();
					num = 13;
				}
				if (num == 13)
				{
					this.default_gateway = new SiticoneCheckBox();
					num = 14;
				}
				if (num == 14)
				{
					this.custom_ip = new SiticoneCheckBox();
					num = 15;
				}
				if (num == 15)
				{
					this.cmbox = new ComboBox();
					num = 16;
				}
				if (num == 16)
				{
					this.label2 = new Label();
					num = 17;
				}
				if (num == 18)
				{
					this.siticoneRoundedButton1 = new SiticoneRoundedButton();
					num = 19;
				}
				if (num == 19)
				{
					this.groupBox1.SuspendLayout();
					num = 20;
				}
				if (num == 20)
				{
					base.SuspendLayout();
					num = 21;
				}
				if (num == 21)
				{
					this.label37.AutoSize = true;
					num = 22;
				}
				if (num == 22)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 23;
				}
				if (num == 23)
				{
					this.label37.ForeColor = Color.Silver;
					num = 24;
				}
				if (num == 24)
				{
					this.label37.Location = new Point(23, 53);
					num = 25;
				}
				if (num == 25)
				{
					this.label37.Name = "label37";
					num = 26;
				}
				if (num == 27)
				{
					this.label37.TabIndex = 121;
					num = 28;
				}
				if (num == 28)
				{
					this.label37.Text = "Configure IPv4 settings with ease!";
					num = 29;
				}
				if (num == 29)
				{
					this.label1.AutoSize = true;
					num = 30;
				}
				if (num == 30)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 31;
				}
				if (num == 31)
				{
					this.label1.ForeColor = Color.White;
					num = 32;
				}
				if (num == 32)
				{
					this.label1.Location = new Point(18, 0);
					num = 33;
				}
				if (num == 33)
				{
					this.label1.Name = "label1";
					num = 34;
				}
				if (num == 34)
				{
					this.label1.Size = new Size(248, 53);
					num = 35;
				}
				if (num == 36)
				{
					this.label1.Text = "Expert Tweaks";
					num = 37;
				}
				if (num == 37)
				{
					this.groupBox1.Controls.Add(this.save);
					num = 38;
				}
				if (num == 38)
				{
					this.groupBox1.Controls.Add(this.dns2);
					num = 39;
				}
				if (num == 39)
				{
					this.groupBox1.Controls.Add(this.dns1);
					num = 40;
				}
				if (num == 40)
				{
					this.groupBox1.Controls.Add(this.defaultgateway);
					num = 41;
				}
				if (num == 41)
				{
					this.groupBox1.Controls.Add(this.subnetmask);
					num = 42;
				}
				if (num == 42)
				{
					this.groupBox1.Controls.Add(this.ip);
					num = 43;
				}
				if (num == 44)
				{
					this.groupBox1.Controls.Add(this.DNS_server1);
					num = 45;
				}
				if (num == 45)
				{
					this.groupBox1.Controls.Add(this.subnet_mask);
					num = 46;
				}
				if (num == 46)
				{
					this.groupBox1.Controls.Add(this.default_gateway);
					num = 47;
				}
				if (num == 47)
				{
					this.groupBox1.Controls.Add(this.custom_ip);
					num = 48;
				}
				if (num == 48)
				{
					this.groupBox1.Controls.Add(this.cmbox);
					num = 49;
				}
				if (num == 49)
				{
					this.groupBox1.Controls.Add(this.label2);
					num = 50;
				}
				if (num == 50)
				{
					this.groupBox1.Font = new Font("Josefin Sans Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 51;
				}
				if (num == 51)
				{
					this.groupBox1.ForeColor = Color.White;
					num = 52;
				}
				if (num == 53)
				{
					this.groupBox1.Name = "groupBox1";
					num = 54;
				}
				if (num == 54)
				{
					this.groupBox1.Size = new Size(949, 551);
					num = 55;
				}
				if (num == 55)
				{
					this.groupBox1.TabIndex = 122;
					num = 56;
				}
				if (num == 56)
				{
					this.groupBox1.TabStop = false;
					num = 57;
				}
				if (num == 57)
				{
					this.groupBox1.Text = "IPv4 Settings";
					num = 58;
				}
				if (num == 58)
				{
					this.save.CheckedState.Parent = this.save;
					num = 59;
				}
				if (num == 59)
				{
					this.save.CustomImages.Parent = this.save;
					num = 60;
				}
				if (num == 60)
				{
					this.save.DisabledState.BorderColor = Color.DarkGray;
					num = 61;
				}
				if (num == 62)
				{
					this.save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 63;
				}
				if (num == 63)
				{
					this.save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 64;
				}
				if (num == 64)
				{
					this.save.DisabledState.Parent = this.save;
					num = 65;
				}
				if (num == 65)
				{
					this.save.FillColor = Color.DodgerBlue;
					num = 66;
				}
				if (num == 66)
				{
					this.save.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 67;
				}
				if (num == 67)
				{
					this.save.ForeColor = Color.White;
					num = 68;
				}
				if (num == 68)
				{
					this.save.HoverState.Parent = this.save;
					num = 69;
				}
				if (num == 69)
				{
					this.save.ImageSize = new Size(30, 30);
					num = 70;
				}
				if (num == 71)
				{
					this.save.Name = "save";
					num = 72;
				}
				if (num == 72)
				{
					this.save.ShadowDecoration.Parent = this.save;
					num = 73;
				}
				if (num == 73)
				{
					this.save.Size = new Size(135, 38);
					num = 74;
				}
				if (num == 74)
				{
					this.save.TabIndex = 317;
					num = 75;
				}
				if (num == 75)
				{
					this.save.Text = "Apply";
					num = 76;
				}
				if (num == 76)
				{
					this.save.Click += this.save_Click;
					num = 77;
				}
				if (num == 77)
				{
					this.dns2.BackColor = Color.Transparent;
					num = 78;
				}
				if (num == 78)
				{
					this.dns2.Cursor = Cursors.IBeam;
					num = 79;
				}
				if (num == 80)
				{
					this.dns2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 81;
				}
				if (num == 81)
				{
					this.dns2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 82;
				}
				if (num == 82)
				{
					this.dns2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 83;
				}
				if (num == 83)
				{
					this.dns2.DisabledState.Parent = this.dns2;
					num = 84;
				}
				if (num == 84)
				{
					this.dns2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 85;
				}
				if (num == 85)
				{
					this.dns2.FillColor = Color.FromArgb(38, 38, 38);
					num = 86;
				}
				if (num == 86)
				{
					this.dns2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 87;
				}
				if (num == 88)
				{
					this.dns2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 89;
				}
				if (num == 89)
				{
					this.dns2.ForeColor = Color.White;
					num = 90;
				}
				if (num == 90)
				{
					this.dns2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 91;
				}
				if (num == 91)
				{
					this.dns2.HoverState.Parent = this.dns2;
					num = 92;
				}
				if (num == 92)
				{
					this.dns2.Location = new Point(511, 369);
					num = 93;
				}
				if (num == 93)
				{
					this.dns2.Name = "dns2";
					num = 94;
				}
				if (num == 94)
				{
					this.dns2.PasswordChar = '\0';
					num = 95;
				}
				if (num == 95)
				{
					this.dns2.PlaceholderText = "";
					num = 96;
				}
				if (num == 97)
				{
					this.dns2.SelectedText = "";
					num = 98;
				}
				if (num == 98)
				{
					this.dns2.ShadowDecoration.Parent = this.dns2;
					num = 99;
				}
				if (num == 99)
				{
					this.dns2.Size = new Size(368, 28);
					num = 100;
				}
				if (num == 100)
				{
					this.dns2.TabIndex = 316;
					num = 101;
				}
				if (num == 101)
				{
					this.dns1.BackColor = Color.Transparent;
					num = 102;
				}
				if (num == 102)
				{
					this.dns1.Cursor = Cursors.IBeam;
					num = 103;
				}
				if (num == 103)
				{
					this.dns1.DefaultText = "";
					num = 104;
				}
				if (num == 104)
				{
					this.dns1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 105;
				}
				if (num == 106)
				{
					this.dns1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 107;
				}
				if (num == 107)
				{
					this.dns1.DisabledState.Parent = this.dns1;
					num = 108;
				}
				if (num == 108)
				{
					this.dns1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 109;
				}
				if (num == 109)
				{
					this.dns1.FillColor = Color.FromArgb(38, 38, 38);
					num = 110;
				}
				if (num == 110)
				{
					this.dns1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 111;
				}
				if (num == 111)
				{
					this.dns1.FocusedState.Parent = this.dns1;
					num = 112;
				}
				if (num == 112)
				{
					this.dns1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 113;
				}
				if (num == 113)
				{
					this.dns1.ForeColor = Color.White;
					num = 114;
				}
				if (num == 115)
				{
					this.dns1.HoverState.Parent = this.dns1;
					num = 116;
				}
				if (num == 116)
				{
					this.dns1.Location = new Point(511, 320);
					num = 117;
				}
				if (num == 117)
				{
					this.dns1.Name = "dns1";
					num = 118;
				}
				if (num == 118)
				{
					this.dns1.PasswordChar = '\0';
					num = 119;
				}
				if (num == 119)
				{
					this.dns1.PlaceholderText = "";
					num = 120;
				}
				if (num == 120)
				{
					this.dns1.ReadOnly = true;
					num = 121;
				}
				if (num == 121)
				{
					this.dns1.SelectedText = "";
					num = 122;
				}
				if (num == 123)
				{
					this.dns1.Size = new Size(368, 28);
					num = 124;
				}
				if (num == 124)
				{
					this.dns1.TabIndex = 315;
					num = 125;
				}
				if (num == 125)
				{
					this.defaultgateway.BackColor = Color.Transparent;
					num = 126;
				}
				if (num == 126)
				{
					this.defaultgateway.Cursor = Cursors.IBeam;
					num = 127;
				}
				if (num == 127)
				{
					this.defaultgateway.DefaultText = "";
					num = 128;
				}
				if (num == 128)
				{
					this.defaultgateway.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 129;
				}
				if (num == 129)
				{
					this.defaultgateway.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 130;
				}
				if (num == 130)
				{
					this.defaultgateway.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 131;
				}
				if (num == 132)
				{
					this.defaultgateway.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 133;
				}
				if (num == 133)
				{
					this.defaultgateway.FillColor = Color.FromArgb(38, 38, 38);
					num = 134;
				}
				if (num == 134)
				{
					this.defaultgateway.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 135;
				}
				if (num == 135)
				{
					this.defaultgateway.FocusedState.Parent = this.defaultgateway;
					num = 136;
				}
				if (num == 136)
				{
					this.defaultgateway.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 137;
				}
				if (num == 137)
				{
					this.defaultgateway.ForeColor = Color.White;
					num = 138;
				}
				if (num == 138)
				{
					this.defaultgateway.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 139;
				}
				if (num == 139)
				{
					this.defaultgateway.HoverState.Parent = this.defaultgateway;
					num = 140;
				}
				if (num == 141)
				{
					this.defaultgateway.Name = "defaultgateway";
					num = 142;
				}
				if (num == 142)
				{
					this.defaultgateway.PasswordChar = '\0';
					num = 143;
				}
				if (num == 143)
				{
					this.defaultgateway.PlaceholderText = "";
					num = 144;
				}
				if (num == 144)
				{
					this.defaultgateway.ReadOnly = true;
					num = 145;
				}
				if (num == 145)
				{
					this.defaultgateway.SelectedText = "";
					num = 146;
				}
				if (num == 146)
				{
					this.defaultgateway.ShadowDecoration.Parent = this.defaultgateway;
					num = 147;
				}
				if (num == 147)
				{
					this.defaultgateway.Size = new Size(368, 28);
					num = 148;
				}
				if (num == 148)
				{
					this.defaultgateway.TabIndex = 314;
					num = 149;
				}
				if (num == 150)
				{
					this.subnetmask.Cursor = Cursors.IBeam;
					num = 151;
				}
				if (num == 151)
				{
					this.subnetmask.DefaultText = "";
					num = 152;
				}
				if (num == 152)
				{
					this.subnetmask.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 153;
				}
				if (num == 153)
				{
					this.subnetmask.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 154;
				}
				if (num == 154)
				{
					this.subnetmask.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 155;
				}
				if (num == 155)
				{
					this.subnetmask.DisabledState.Parent = this.subnetmask;
					num = 156;
				}
				if (num == 156)
				{
					this.subnetmask.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 157;
				}
				if (num == 157)
				{
					this.subnetmask.FillColor = Color.FromArgb(38, 38, 38);
					num = 158;
				}
				if (num == 159)
				{
					this.subnetmask.FocusedState.Parent = this.subnetmask;
					num = 160;
				}
				if (num == 160)
				{
					this.subnetmask.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 161;
				}
				if (num == 161)
				{
					this.subnetmask.ForeColor = Color.White;
					num = 162;
				}
				if (num == 162)
				{
					this.subnetmask.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 163;
				}
				if (num == 163)
				{
					this.subnetmask.HoverState.Parent = this.subnetmask;
					num = 164;
				}
				if (num == 164)
				{
					this.subnetmask.Location = new Point(511, 222);
					num = 165;
				}
				if (num == 165)
				{
					this.subnetmask.Name = "subnetmask";
					num = 166;
				}
				if (num == 167)
				{
					this.subnetmask.PlaceholderText = "";
					num = 168;
				}
				if (num == 168)
				{
					this.subnetmask.ReadOnly = true;
					num = 169;
				}
				if (num == 169)
				{
					this.subnetmask.SelectedText = "";
					num = 170;
				}
				if (num == 170)
				{
					this.subnetmask.ShadowDecoration.Parent = this.subnetmask;
					num = 171;
				}
				if (num == 171)
				{
					this.subnetmask.Size = new Size(368, 28);
					num = 172;
				}
				if (num == 172)
				{
					this.subnetmask.TabIndex = 313;
					num = 173;
				}
				if (num == 173)
				{
					this.ip.BackColor = Color.Transparent;
					num = 174;
				}
				if (num == 174)
				{
					this.ip.Cursor = Cursors.IBeam;
					num = 175;
				}
				if (num == 176)
				{
					this.ip.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 177;
				}
				if (num == 177)
				{
					this.ip.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 178;
				}
				if (num == 178)
				{
					this.ip.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
					num = 179;
				}
				if (num == 179)
				{
					this.ip.DisabledState.Parent = this.ip;
					num = 180;
				}
				if (num == 180)
				{
					this.ip.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
					num = 181;
				}
				if (num == 181)
				{
					this.ip.FillColor = Color.FromArgb(38, 38, 38);
					num = 182;
				}
				if (num == 182)
				{
					this.ip.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 183;
				}
				if (num == 183)
				{
					this.ip.FocusedState.Parent = this.ip;
					num = 184;
				}
				if (num == 185)
				{
					this.ip.ForeColor = Color.White;
					num = 186;
				}
				if (num == 186)
				{
					this.ip.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 187;
				}
				if (num == 187)
				{
					this.ip.HoverState.Parent = this.ip;
					num = 188;
				}
				if (num == 188)
				{
					this.ip.Location = new Point(511, 173);
					num = 189;
				}
				if (num == 189)
				{
					this.ip.Name = "ip";
					num = 190;
				}
				if (num == 190)
				{
					this.ip.PasswordChar = '\0';
					num = 191;
				}
				if (num == 191)
				{
					this.ip.PlaceholderText = "";
					num = 192;
				}
				if (num == 192)
				{
					this.ip.ReadOnly = true;
					num = 193;
				}
				if (num == 194)
				{
					this.ip.ShadowDecoration.Parent = this.ip;
					num = 195;
				}
				if (num == 195)
				{
					this.ip.Size = new Size(368, 28);
					num = 196;
				}
				if (num == 196)
				{
					this.ip.TabIndex = 312;
					num = 197;
				}
				if (num == 197)
				{
					this.DNS_server2.AutoSize = true;
					num = 198;
				}
				if (num == 198)
				{
					this.DNS_server2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 199;
				}
				if (num == 199)
				{
					this.DNS_server2.CheckedState.BorderRadius = 0;
					num = 200;
				}
				if (num == 200)
				{
					this.DNS_server2.CheckedState.BorderThickness = 0;
					num = 201;
				}
				if (num == 201)
				{
					this.DNS_server2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 202;
				}
				if (num == 203)
				{
					this.DNS_server2.ForeColor = Color.White;
					num = 204;
				}
				if (num == 204)
				{
					this.DNS_server2.Location = new Point(31, 369);
					num = 205;
				}
				if (num == 205)
				{
					this.DNS_server2.Name = "DNS_server2";
					num = 206;
				}
				if (num == 206)
				{
					this.DNS_server2.Size = new Size(285, 28);
					num = 207;
				}
				if (num == 207)
				{
					this.DNS_server2.TabIndex = 152;
					num = 208;
				}
				if (num == 208)
				{
					this.DNS_server2.Text = "Custom Static Secondary DNS Server";
					num = 209;
				}
				if (num == 209)
				{
					this.DNS_server2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 210;
				}
				if (num == 211)
				{
					this.DNS_server2.UncheckedState.BorderThickness = 0;
					num = 212;
				}
				if (num == 212)
				{
					this.DNS_server2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 213;
				}
				if (num == 213)
				{
					this.DNS_server2.CheckedChanged += this.DNS_server2_CheckedChanged;
					num = 214;
				}
				if (num == 214)
				{
					this.DNS_server1.AutoSize = true;
					num = 215;
				}
				if (num == 215)
				{
					this.DNS_server1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 216;
				}
				if (num == 216)
				{
					this.DNS_server1.CheckedState.BorderRadius = 0;
					num = 217;
				}
				if (num == 217)
				{
					this.DNS_server1.CheckedState.BorderThickness = 0;
					num = 218;
				}
				if (num == 218)
				{
					this.DNS_server1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 219;
				}
				if (num == 220)
				{
					this.DNS_server1.ForeColor = Color.White;
					num = 221;
				}
				if (num == 221)
				{
					this.DNS_server1.Location = new Point(31, 320);
					num = 222;
				}
				if (num == 222)
				{
					this.DNS_server1.Name = "DNS_server1";
					num = 223;
				}
				if (num == 223)
				{
					this.DNS_server1.Size = new Size(267, 28);
					num = 224;
				}
				if (num == 224)
				{
					this.DNS_server1.TabIndex = 151;
					num = 225;
				}
				if (num == 225)
				{
					this.DNS_server1.Text = "Custom Static Primary DNS Server";
					num = 226;
				}
				if (num == 226)
				{
					this.DNS_server1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 227;
				}
				if (num == 227)
				{
					this.DNS_server1.UncheckedState.BorderRadius = 0;
					num = 228;
				}
				if (num == 229)
				{
					this.DNS_server1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 230;
				}
				if (num == 230)
				{
					this.DNS_server1.CheckedChanged += this.DNS_server1_CheckedChanged;
					num = 231;
				}
				if (num == 231)
				{
					this.subnet_mask.AutoSize = true;
					num = 232;
				}
				if (num == 232)
				{
					this.subnet_mask.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 233;
				}
				if (num == 233)
				{
					this.subnet_mask.CheckedState.BorderRadius = 0;
					num = 234;
				}
				if (num == 234)
				{
					this.subnet_mask.CheckedState.BorderThickness = 0;
					num = 235;
				}
				if (num == 235)
				{
					this.subnet_mask.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 236;
				}
				if (num == 236)
				{
					this.subnet_mask.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 237;
				}
				if (num == 238)
				{
					this.subnet_mask.Location = new Point(31, 222);
					num = 239;
				}
				if (num == 239)
				{
					this.subnet_mask.Name = "subnet_mask";
					num = 240;
				}
				if (num == 240)
				{
					this.subnet_mask.Size = new Size(215, 28);
					num = 241;
				}
				if (num == 241)
				{
					this.subnet_mask.TabIndex = 150;
					num = 242;
				}
				if (num == 242)
				{
					this.subnet_mask.Text = "Custom Static Subnet Mask";
					num = 243;
				}
				if (num == 243)
				{
					this.subnet_mask.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 244;
				}
				if (num == 244)
				{
					this.subnet_mask.UncheckedState.BorderRadius = 0;
					num = 245;
				}
				if (num == 246)
				{
					this.subnet_mask.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 247;
				}
				if (num == 247)
				{
					this.subnet_mask.CheckedChanged += this.subnet_mask_CheckedChanged;
					num = 248;
				}
				if (num == 248)
				{
					this.default_gateway.AutoSize = true;
					num = 249;
				}
				if (num == 249)
				{
					this.default_gateway.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 250;
				}
				if (num == 250)
				{
					this.default_gateway.CheckedState.BorderRadius = 0;
					num = 251;
				}
				if (num == 251)
				{
					this.default_gateway.CheckedState.BorderThickness = 0;
					num = 252;
				}
				if (num == 252)
				{
					this.default_gateway.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 253;
				}
				if (num == 253)
				{
					this.default_gateway.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 254;
				}
				if (num == 255)
				{
					this.default_gateway.Location = new Point(31, 271);
					num = 256;
				}
				if (num == 256)
				{
					this.default_gateway.Name = "default_gateway";
					num = 257;
				}
				if (num == 257)
				{
					this.default_gateway.Size = new Size(242, 28);
					num = 258;
				}
				if (num == 258)
				{
					this.default_gateway.TabIndex = 149;
					num = 259;
				}
				if (num == 259)
				{
					this.default_gateway.Text = "Custom Static Default Gateway";
					num = 260;
				}
				if (num == 260)
				{
					this.default_gateway.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 261;
				}
				if (num == 261)
				{
					this.default_gateway.UncheckedState.BorderRadius = 0;
					num = 262;
				}
				if (num == 262)
				{
					this.default_gateway.UncheckedState.BorderThickness = 0;
					num = 263;
				}
				if (num == 264)
				{
					this.default_gateway.CheckedChanged += this.default_gateway_CheckedChanged;
					num = 265;
				}
				if (num == 265)
				{
					this.custom_ip.AutoSize = true;
					num = 266;
				}
				if (num == 266)
				{
					this.custom_ip.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 267;
				}
				if (num == 267)
				{
					this.custom_ip.CheckedState.BorderRadius = 0;
					num = 268;
				}
				if (num == 268)
				{
					this.custom_ip.CheckedState.BorderThickness = 0;
					num = 269;
				}
				if (num == 269)
				{
					this.custom_ip.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 270;
				}
				if (num == 270)
				{
					this.custom_ip.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 271;
				}
				if (num == 271)
				{
					this.custom_ip.ForeColor = Color.White;
					num = 272;
				}
				if (num == 273)
				{
					this.custom_ip.Name = "custom_ip";
					num = 274;
				}
				if (num == 274)
				{
					this.custom_ip.Size = new Size(141, 28);
					num = 275;
				}
				if (num == 275)
				{
					this.custom_ip.TabIndex = 148;
					num = 276;
				}
				if (num == 276)
				{
					this.custom_ip.Text = "Custom Static IP";
					num = 277;
				}
				if (num == 277)
				{
					this.custom_ip.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 278;
				}
				if (num == 278)
				{
					this.custom_ip.UncheckedState.BorderRadius = 0;
					num = 279;
				}
				if (num == 279)
				{
					this.custom_ip.UncheckedState.BorderThickness = 0;
					num = 280;
				}
				if (num == 280)
				{
					this.custom_ip.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 281;
				}
				if (num == 282)
				{
					this.cmbox.Font = new Font("Gill Sans MT", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 283;
				}
				if (num == 283)
				{
					this.cmbox.FormattingEnabled = true;
					num = 284;
				}
				if (num == 284)
				{
					this.cmbox.Location = new Point(31, 87);
					num = 285;
				}
				if (num == 285)
				{
					this.cmbox.Name = "cmbox";
					num = 286;
				}
				if (num == 286)
				{
					this.cmbox.Size = new Size(378, 29);
					num = 287;
				}
				if (num == 287)
				{
					this.cmbox.TabIndex = 1;
					num = 288;
				}
				if (num == 288)
				{
					this.label2.AutoSize = true;
					num = 289;
				}
				if (num == 290)
				{
					this.label2.Location = new Point(26, 50);
					num = 291;
				}
				if (num == 291)
				{
					this.label2.Name = "label2";
					num = 292;
				}
				if (num == 292)
				{
					this.label2.Size = new Size(143, 25);
					num = 293;
				}
				if (num == 293)
				{
					this.label2.TabIndex = 0;
					num = 294;
				}
				if (num == 294)
				{
					this.label2.Text = "Connection Name :";
					num = 295;
				}
				if (num == 295)
				{
					this.back_btn.BackColor = Color.Transparent;
					num = 296;
				}
				if (num == 296)
				{
					this.back_btn.BorderRadius = 14;
					num = 297;
				}
				if (num == 297)
				{
					this.back_btn.CheckedState.Parent = this.back_btn;
					num = 298;
				}
				if (num == 299)
				{
					this.back_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 300;
				}
				if (num == 300)
				{
					this.back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 301;
				}
				if (num == 301)
				{
					this.back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 302;
				}
				if (num == 302)
				{
					this.back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 303;
				}
				if (num == 303)
				{
					this.back_btn.DisabledState.Parent = this.back_btn;
					num = 304;
				}
				if (num == 304)
				{
					this.back_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 305;
				}
				if (num == 305)
				{
					this.back_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 306;
				}
				if (num == 306)
				{
					this.back_btn.ForeColor = Color.White;
					num = 307;
				}
				if (num == 308)
				{
					this.back_btn.Location = new Point(782, 53);
					num = 309;
				}
				if (num == 309)
				{
					this.back_btn.Name = "back_btn";
					num = 310;
				}
				if (num == 310)
				{
					this.back_btn.ShadowDecoration.Parent = this.back_btn;
					num = 311;
				}
				if (num == 311)
				{
					this.back_btn.Size = new Size(88, 30);
					num = 312;
				}
				if (num == 312)
				{
					this.back_btn.TabIndex = 123;
					num = 313;
				}
				if (num == 313)
				{
					this.back_btn.Text = "Back";
					num = 314;
				}
				if (num == 314)
				{
					this.back_btn.Click += this.back_btn_Click;
					num = 315;
				}
				if (num == 315)
				{
					this.siticoneRoundedButton1.BackColor = Color.Transparent;
					num = 316;
				}
				if (num == 317)
				{
					this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
					num = 318;
				}
				if (num == 318)
				{
					this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
					num = 319;
				}
				if (num == 319)
				{
					this.siticoneRoundedButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 320;
				}
				if (num == 320)
				{
					this.siticoneRoundedButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 321;
				}
				if (num == 321)
				{
					this.siticoneRoundedButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 322;
				}
				if (num == 322)
				{
					this.siticoneRoundedButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 323;
				}
				if (num == 323)
				{
					this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
					num = 324;
				}
				if (num == 324)
				{
					this.siticoneRoundedButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 325;
				}
				if (num == 326)
				{
					this.siticoneRoundedButton1.ForeColor = Color.White;
					num = 327;
				}
				if (num == 327)
				{
					this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
					num = 328;
				}
				if (num == 328)
				{
					this.siticoneRoundedButton1.Location = new Point(876, 53);
					num = 329;
				}
				if (num == 329)
				{
					this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
					num = 330;
				}
				if (num == 330)
				{
					this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
					num = 331;
				}
				if (num == 331)
				{
					this.siticoneRoundedButton1.Size = new Size(88, 30);
					num = 332;
				}
				if (num == 332)
				{
					this.siticoneRoundedButton1.TabIndex = 314;
					num = 333;
				}
				if (num == 334)
				{
					this.siticoneRoundedButton1.Click += this.siticoneRoundedButton1_Click;
					num = 335;
				}
				if (num == 335)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 336;
				}
				if (num == 336)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 337;
				}
				if (num == 337)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 338;
				}
				if (num == 338)
				{
					base.Controls.Add(this.siticoneRoundedButton1);
					num = 339;
				}
				if (num == 339)
				{
					base.Controls.Add(this.back_btn);
					num = 340;
				}
				if (num == 340)
				{
					base.Controls.Add(this.groupBox1);
					num = 341;
				}
				if (num == 341)
				{
					base.Controls.Add(this.label37);
					num = 342;
				}
				if (num == 343)
				{
					base.Name = "IPv4";
					num = 344;
				}
				if (num == 344)
				{
					base.Size = new Size(1006, 669);
					num = 345;
				}
				if (num == 345)
				{
					base.Load += this.IPv4_Load;
					num = 346;
				}
				if (num == 346)
				{
					this.groupBox1.ResumeLayout(false);
					num = 347;
				}
				if (num == 347)
				{
					this.groupBox1.PerformLayout();
					num = 348;
				}
				if (num == 348)
				{
					base.ResumeLayout(false);
					num = 349;
				}
				if (num == 349)
				{
					base.PerformLayout();
					num = 350;
				}
				if (num == 342)
				{
					base.Controls.Add(this.label1);
					num = 343;
				}
				if (num == 333)
				{
					this.siticoneRoundedButton1.Text = "Next";
					num = 334;
				}
				if (num == 325)
				{
					this.siticoneRoundedButton1.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 326;
				}
				if (num == 316)
				{
					this.siticoneRoundedButton1.BorderRadius = 14;
					num = 317;
				}
				if (num == 307)
				{
					this.back_btn.HoverState.Parent = this.back_btn;
					num = 308;
				}
				if (num == 298)
				{
					this.back_btn.CustomImages.Parent = this.back_btn;
					num = 299;
				}
				if (num == 289)
				{
					this.label2.Font = new Font("Josefin Sans Light", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 290;
				}
				if (num == 281)
				{
					this.custom_ip.CheckedChanged += this.custom_ip_CheckedChanged;
					num = 282;
				}
				if (num == 272)
				{
					this.custom_ip.Location = new Point(31, 173);
					num = 273;
				}
				if (num == 263)
				{
					this.default_gateway.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 264;
				}
				if (num == 254)
				{
					this.default_gateway.ForeColor = Color.White;
					num = 255;
				}
				if (num == 245)
				{
					this.subnet_mask.UncheckedState.BorderThickness = 0;
					num = 246;
				}
				if (num == 237)
				{
					this.subnet_mask.ForeColor = Color.White;
					num = 238;
				}
				if (num == 228)
				{
					this.DNS_server1.UncheckedState.BorderThickness = 0;
					num = 229;
				}
				if (num == 219)
				{
					this.DNS_server1.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 220;
				}
				if (num == 210)
				{
					this.DNS_server2.UncheckedState.BorderRadius = 0;
					num = 211;
				}
				if (num == 202)
				{
					this.DNS_server2.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 203;
				}
				if (num == 193)
				{
					this.ip.SelectedText = "";
					num = 194;
				}
				if (num == 184)
				{
					this.ip.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = 185;
				}
				if (num == 175)
				{
					this.ip.DefaultText = "";
					num = 176;
				}
				if (num == 166)
				{
					this.subnetmask.PasswordChar = '\0';
					num = 167;
				}
				if (num == 158)
				{
					this.subnetmask.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 159;
				}
				if (num == 149)
				{
					this.subnetmask.BackColor = Color.Transparent;
					num = 150;
				}
				if (num == 140)
				{
					this.defaultgateway.Location = new Point(511, 271);
					num = 141;
				}
				if (num == 131)
				{
					this.defaultgateway.DisabledState.Parent = this.defaultgateway;
					num = 132;
				}
				if (num == 122)
				{
					this.dns1.ShadowDecoration.Parent = this.dns1;
					num = 123;
				}
				if (num == 114)
				{
					this.dns1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 115;
				}
				if (num == 105)
				{
					this.dns1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
					num = 106;
				}
				if (num == 96)
				{
					this.dns2.ReadOnly = true;
					num = 97;
				}
				if (num == 87)
				{
					this.dns2.FocusedState.Parent = this.dns2;
					num = 88;
				}
				if (num == 79)
				{
					this.dns2.DefaultText = "";
					num = 80;
				}
				if (num == 70)
				{
					this.save.Location = new Point(744, 448);
					num = 71;
				}
				if (num == 61)
				{
					this.save.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 62;
				}
				if (num == 52)
				{
					this.groupBox1.Location = new Point(27, 89);
					num = 53;
				}
				if (num == 43)
				{
					this.groupBox1.Controls.Add(this.DNS_server2);
					num = 44;
				}
				if (num == 35)
				{
					this.label1.TabIndex = 120;
					num = 36;
				}
				if (num == 26)
				{
					this.label37.Size = new Size(191, 19);
					num = 27;
				}
				if (num == 17)
				{
					this.back_btn = new SiticoneRoundedButton();
					num = 18;
				}
				if (num == 8)
				{
					this.subnetmask = new SiticoneTextBox();
					num = 9;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 350);
		}

		// Token: 0x040008B5 RID: 2229
		private static IPv4 _instace;

		// Token: 0x040008B6 RID: 2230
		public static Process p = new Process();

		// Token: 0x040008B7 RID: 2231
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040008B8 RID: 2232
		private IContainer components = null;

		// Token: 0x040008B9 RID: 2233
		private Label label37;

		// Token: 0x040008BA RID: 2234
		private Label label1;

		// Token: 0x040008BB RID: 2235
		private GroupBox groupBox1;

		// Token: 0x040008BC RID: 2236
		private Label label2;

		// Token: 0x040008BD RID: 2237
		private ComboBox cmbox;

		// Token: 0x040008BE RID: 2238
		private SiticoneCheckBox custom_ip;

		// Token: 0x040008BF RID: 2239
		private SiticoneCheckBox DNS_server2;

		// Token: 0x040008C0 RID: 2240
		private SiticoneCheckBox DNS_server1;

		// Token: 0x040008C1 RID: 2241
		private SiticoneCheckBox subnet_mask;

		// Token: 0x040008C2 RID: 2242
		private SiticoneCheckBox default_gateway;

		// Token: 0x040008C3 RID: 2243
		private SiticoneTextBox ip;

		// Token: 0x040008C4 RID: 2244
		private SiticoneTextBox dns2;

		// Token: 0x040008C5 RID: 2245
		private SiticoneTextBox dns1;

		// Token: 0x040008C6 RID: 2246
		private SiticoneTextBox defaultgateway;

		// Token: 0x040008C7 RID: 2247
		private SiticoneTextBox subnetmask;

		// Token: 0x040008C8 RID: 2248
		private SiticoneButton save;

		// Token: 0x040008C9 RID: 2249
		private SiticoneRoundedButton back_btn;

		// Token: 0x040008CA RID: 2250
		private SiticoneRoundedButton siticoneRoundedButton1;
	}
}
