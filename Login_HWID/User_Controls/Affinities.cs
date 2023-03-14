using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Login_HWID.Dialog_Boxes;
using Microsoft.Win32;
using Siticone.Desktop.UI.WinForms;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace Login_HWID.User_Controls
{
	// Token: 0x02000054 RID: 84
	public class Affinities : UserControl
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000916E8 File Offset: 0x0008F8E8
		public static Affinities Instance
		{
			get
			{
				if (Affinities._instace == null)
				{
					Affinities._instace = new Affinities();
				}
				return Affinities._instace;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00091710 File Offset: 0x0008F910
		public Affinities()
		{
			this.InitializeComponent();
			CheckBox[] array = new CheckBox[]
			{
				this.cpu0, this.cpu1, this.cpu2, this.cpu3, this.cpu4, this.cpu5, this.cpu6, this.cpu7, this.cpu8, this.cpu9,
				this.cpu10, this.cpu11, this.cpu12, this.cpu13, this.cpu14, this.cpu15, this.cpu16, this.cpu17, this.cpu18, this.cpu19,
				this.cpu20, this.cpu21, this.cpu22, this.cpu23, this.cpu24, this.cpu25, this.cpu26, this.cpu27, this.cpu28, this.cpu29,
				this.cpu30, this.cpu31, this.cpu32, this.cpu33, this.cpu34, this.cpu35, this.cpu36, this.cpu37, this.cpu38, this.cpu39,
				this.cpu40, this.cpu41, this.cpu42, this.cpu43, this.cpu44, this.cpu45, this.cpu46, this.cpu47, this.cpu48, this.cpu49,
				this.cpu50, this.cpu51, this.cpu52, this.cpu53, this.cpu54, this.cpu55, this.cpu56, this.cpu57, this.cpu58, this.cpu59,
				this.cpu60, this.cpu61, this.cpu62, this.cpu63
			};
			foreach (int num in Enumerable.Range(0, Environment.ProcessorCount))
			{
				CheckBox checkBox = array[num];
				checkBox.Enabled = true;
			}
			this.loadDevices();
			this.LoadTheme();
			this.UserPreferenceChanged = new UserPreferenceChangedEventHandler(this.SystemEvents_UserPreferenceChanged);
			SystemEvents.UserPreferenceChanged += this.UserPreferenceChanged;
			base.Disposed += this.Form_Disposed;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00091B28 File Offset: 0x0008FD28
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
				string text;
				if (num == 5)
				{
					object obj2;
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
					goto IL_BC;
				}
				if (!(text == "Xmas"))
				{
					num = 8;
					goto IL_BC;
				}
				goto IL_102;
				IL_173:
				if (num == 9)
				{
					if (text == "Accent Color")
					{
						goto IL_190;
					}
					num = 10;
				}
				if (num == 4)
				{
					object obj2 = obj;
					num = 5;
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
				IL_1A2:
				if (num == 16)
				{
					break;
				}
				if (num == 17)
				{
					break;
				}
				if (num == 13)
				{
					goto IL_161;
				}
				goto IL_173;
				IL_114:
				if (num == 12 || num == 14)
				{
					break;
				}
				if (num == 15)
				{
					goto IL_190;
				}
				goto IL_1A2;
				IL_BC:
				if (num == 8)
				{
					if (text == "Halloween")
					{
						goto IL_161;
					}
					num = 9;
				}
				if (num == 10)
				{
					break;
				}
				if (num == 11)
				{
					goto IL_102;
				}
				goto IL_114;
				IL_161:
				this.Halloween();
				num = 14;
				goto IL_173;
				IL_190:
				this.AccentColor();
				num = 16;
				goto IL_1A2;
				IL_102:
				this.Xmas_theme();
				num = 12;
				goto IL_114;
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00091D68 File Offset: 0x0008FF68
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

		// Token: 0x060003BA RID: 954 RVA: 0x00091DE0 File Offset: 0x0008FFE0
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

		// Token: 0x060003BB RID: 955 RVA: 0x00091E44 File Offset: 0x00090044
		private void Halloween()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					enumerator = this.groupBox1.Controls.OfType<CheckBox>().GetEnumerator();
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
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(255, 128, 0);
					siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(255, 128, 0);
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

		// Token: 0x060003BC RID: 956 RVA: 0x00091F14 File Offset: 0x00090114
		private void AccentColor()
		{
			int num = 0;
			Color accentColor;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					accentColor = Theme.GetAccentColor();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = this.groupBox1.Controls.OfType<CheckBox>().GetEnumerator();
					num = 3;
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
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = accentColor;
					siticoneCheckBox.CheckedState.FillColor = accentColor;
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

		// Token: 0x060003BD RID: 957 RVA: 0x0009200C File Offset: 0x0009020C
		private void Xmas_theme()
		{
			int num = 0;
			IEnumerator<CheckBox> enumerator;
			do
			{
				if (num == 1)
				{
					Theme.GetAccentColor();
					num = 2;
				}
				if (num == 2)
				{
					enumerator = this.groupBox1.Controls.OfType<CheckBox>().GetEnumerator();
					num = 3;
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
					CheckBox checkBox = enumerator.Current;
					SiticoneCheckBox siticoneCheckBox = (SiticoneCheckBox)checkBox;
					siticoneCheckBox.CheckedState.BorderColor = Color.FromArgb(29, 158, 255);
					siticoneCheckBox.CheckedState.FillColor = Color.FromArgb(29, 158, 255);
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

		// Token: 0x060003BE RID: 958 RVA: 0x000920F0 File Offset: 0x000902F0
		private void loadDevices()
		{
			int num = 0;
			for (;;)
			{
				List<string> list;
				if (num == 1)
				{
					list = new List<string>();
					num = 2;
				}
				string[] subKeyNames;
				if (num == 2)
				{
					subKeyNames = this.DevicesPath.GetSubKeyNames();
					num = 3;
				}
				if (num == 3)
				{
					num = 4;
				}
				if (num == 5)
				{
					goto IL_2FB;
				}
				if (num == 6)
				{
					goto IL_51;
				}
				IL_5C:
				string text;
				RegistryKey registryKey;
				if (num == 7)
				{
					registryKey = this.DevicesPath.OpenSubKey(text);
					num = 8;
				}
				string[] subKeyNames2;
				if (num == 8)
				{
					subKeyNames2 = registryKey.GetSubKeyNames();
					num = 9;
				}
				int num2;
				if (num == 10)
				{
					num2 = 0;
					num = 11;
				}
				if (num == 11)
				{
					goto IL_2E8;
				}
				if (num == 12)
				{
					goto IL_C5;
				}
				IL_D2:
				RegistryKey registryKey2;
				string[] subKeyNames3;
				if (num == 14)
				{
					subKeyNames3 = registryKey2.GetSubKeyNames();
					num = 15;
				}
				if (num == 15)
				{
					num = 16;
				}
				int num3;
				if (num == 16)
				{
					num3 = 0;
					num = 17;
				}
				if (num == 17)
				{
					goto IL_2D3;
				}
				string text2;
				RegistryKey registryKey3;
				if (num == 19)
				{
					registryKey3 = registryKey2.OpenSubKey(text2);
					num = 20;
				}
				bool flag;
				if (num == 20)
				{
					if (registryKey3.OpenSubKey("Device Parameters\\Interrupt Management\\Affinity Policy") == null)
					{
						flag = false;
						goto IL_1E8;
					}
					num = 21;
				}
				if (num == 18)
				{
					goto IL_16E;
				}
				IL_17B:
				string text3;
				if (num == 13)
				{
					registryKey2 = registryKey.OpenSubKey(text3);
					num = 14;
				}
				if (num == 9)
				{
					num = 10;
				}
				int num4;
				if (num == 4)
				{
					num4 = 0;
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 21)
				{
					flag = registryKey3.OpenSubKey("Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties") != null;
					goto IL_1E8;
				}
				continue;
				IL_16E:
				text2 = subKeyNames3[num3];
				num = 19;
				goto IL_17B;
				IL_2D3:
				if (num3 >= subKeyNames3.Length)
				{
					num2++;
					goto IL_2E8;
				}
				goto IL_16E;
				IL_1E8:
				if (flag)
				{
					string deviceName = registryKey3.GetValue("DeviceDesc").ToString().Split(new char[] { ';' })[1];
					list.Add(deviceName);
					int num5 = list.Where((string x) => x.Equals(deviceName)).Count<string>();
					if (num5 > 1)
					{
						deviceName = deviceName + " (" + num5.ToString() + ")";
					}
					this.DevicesPathList.Add(registryKey3.ToString().Replace("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\", ""), deviceName);
					this.deviceNameBox.Items.Add(deviceName);
				}
				num3++;
				goto IL_2D3;
				IL_C5:
				text3 = subKeyNames2[num2];
				num = 13;
				goto IL_D2;
				IL_2E8:
				if (num2 >= subKeyNames2.Length)
				{
					num4++;
					goto IL_2FB;
				}
				goto IL_C5;
				IL_51:
				text = subKeyNames[num4];
				num = 7;
				goto IL_5C;
				IL_2FB:
				if (num4 < subKeyNames.Length)
				{
					goto IL_51;
				}
				break;
			}
			this.deviceNameBox.SelectedIndex = 0;
			string text4 = this.DevicesPathList.First<KeyValuePair<string, string>>().Key;
			if (text4.Contains("REV_"))
			{
				text4 = text4.Remove(text4.IndexOf("REV_"));
			}
			if (text4.Contains("SUBSYS_"))
			{
				text4 = text4.Remove(text4.IndexOf("SUBSYS_"));
			}
			this.devicePathLabel.Text = "Device Path : " + text4;
			this.updateCores();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000924B8 File Offset: 0x000906B8
		private void updateDevicePath()
		{
			int num = 0;
			for (;;)
			{
				KeyValuePair<string, string> keyValuePair;
				if (num == 1)
				{
					keyValuePair = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
					{
						int num2 = 0;
						do
						{
							if (num2 == 0)
							{
								num2 = 1;
							}
						}
						while (num2 != 1);
						return x.Value == this.deviceNameBox.Text;
					});
					num = 2;
				}
				string text;
				if (num == 2)
				{
					text = keyValuePair.Key;
					num = 3;
				}
				bool flag;
				if (num == 3)
				{
					flag = text.Contains("REV_");
					num = 4;
				}
				if (num == 5)
				{
					text = text.Remove(text.IndexOf("REV_"));
					num = 6;
				}
				if (num == 6)
				{
					goto IL_113;
				}
				IL_13E:
				if (num != 7)
				{
					goto IL_9D;
				}
				bool flag2;
				if (flag2)
				{
					num = 8;
					goto IL_9D;
				}
				goto IL_DB;
				IL_100:
				if (num == 4)
				{
					if (!flag)
					{
						goto IL_113;
					}
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 10)
				{
					continue;
				}
				break;
				IL_9D:
				if (num == 8)
				{
					text = text.Remove(text.IndexOf("SUBSYS_"));
					num = 9;
				}
				if (num != 9)
				{
					goto IL_100;
				}
				IL_DB:
				this.devicePathLabel.Text = "Device Path : " + text;
				num = 10;
				goto IL_100;
				IL_113:
				flag2 = text.Contains("SUBSYS_");
				num = 7;
				goto IL_13E;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00092688 File Offset: 0x00090888
		private void updateCores()
		{
			int num = 0;
			object value;
			IEnumerator<int> enumerator;
			CheckBox[] array;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				KeyValuePair<string, string> keyValuePair;
				if (num == 3)
				{
					keyValuePair = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
					{
						int num6 = 0;
						do
						{
							if (num6 == 0)
							{
								num6 = 1;
							}
						}
						while (num6 != 1);
						return x.Value == this.deviceNameBox.Text;
					});
					num = 4;
				}
				string text;
				if (num == 4)
				{
					text = keyValuePair.Key + "\\Device Parameters\\Interrupt Management\\Affinity Policy";
					num = 5;
				}
				if (num == 6)
				{
					RegistryKey registryKey;
					value = registryKey.GetValue("AssignmentSetOverride");
					num = 7;
				}
				if (num == 8)
				{
					bool flag;
					if (!flag)
					{
						goto IL_55E;
					}
					num = 9;
				}
				if (num == 9)
				{
					num = 10;
				}
				if (num == 10)
				{
					enumerator = Enumerable.Range(0, Environment.ProcessorCount).GetEnumerator();
					num = 11;
				}
				if (num == 7)
				{
					bool flag = value == null;
					num = 8;
				}
				if (num == 5)
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + text, true);
					num = 6;
				}
				if (num == 2)
				{
					array = new CheckBox[]
					{
						this.cpu0, this.cpu1, this.cpu2, this.cpu3, this.cpu4, this.cpu5, this.cpu6, this.cpu7, this.cpu8, this.cpu9,
						this.cpu10, this.cpu11, this.cpu12, this.cpu13, this.cpu14, this.cpu15, this.cpu16, this.cpu17, this.cpu18, this.cpu19,
						this.cpu20, this.cpu21, this.cpu22, this.cpu23, this.cpu24, this.cpu25, this.cpu26, this.cpu27, this.cpu28, this.cpu29,
						this.cpu30, this.cpu31, this.cpu32, this.cpu33, this.cpu34, this.cpu35, this.cpu36, this.cpu37, this.cpu38, this.cpu39,
						this.cpu40, this.cpu41, this.cpu42, this.cpu43, this.cpu44, this.cpu45, this.cpu46, this.cpu47, this.cpu48, this.cpu49,
						this.cpu50, this.cpu51, this.cpu52, this.cpu53, this.cpu54, this.cpu55, this.cpu56, this.cpu57, this.cpu58, this.cpu59,
						this.cpu60, this.cpu61, this.cpu62, this.cpu63
					};
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 11);
			goto IL_5D3;
			IL_55E:
			int num2 = int.Parse(value.ToString());
			using (IEnumerator<int> enumerator2 = Enumerable.Range(0, Environment.ProcessorCount).GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					int num3 = enumerator2.Current;
					int num4 = 1 << num3;
					if ((num2 & num4) == num4)
					{
						CheckBox checkBox = array[num3];
						checkBox.Checked = true;
					}
				}
				return;
			}
			try
			{
				IL_5D3:
				while (enumerator.MoveNext())
				{
					int num5 = enumerator.Current;
					CheckBox checkBox2 = array[num5];
					checkBox2.Checked = false;
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00092CBC File Offset: 0x00090EBC
		private void updateMsiMode()
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
			try
			{
				string text = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
				{
					int num2 = 0;
					do
					{
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 1);
					return x.Value == this.deviceNameBox.Text;
				}).Key + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + text, true);
				if (registryKey.GetValue("MSISupported") == null)
				{
					this.msiMode.Checked = false;
				}
				if (registryKey.GetValue("MSISupported").ToString() == "1")
				{
					this.msiMode.Checked = true;
				}
				else
				{
					this.msiMode.Checked = false;
				}
			}
			catch
			{
				this.msiMode.Checked = false;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00092DCC File Offset: 0x00090FCC
		private void deviceNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					this.updateDevicePath();
					num = 2;
				}
				if (num == 3)
				{
					this.updateMsiMode();
					num = 4;
				}
				if (num == 2)
				{
					this.updateCores();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00018F88 File Offset: 0x00017188
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

		// Token: 0x060003C4 RID: 964 RVA: 0x00092E6C File Offset: 0x0009106C
		private void msiMode_CheckedChanged(object sender, EventArgs e)
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
			try
			{
				string text = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
				{
					int num2 = 0;
					do
					{
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 1);
					return x.Value == this.deviceNameBox.Text;
				}).Key + "\\Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + text, true);
				if (this.msiMode.Checked)
				{
					registryKey.SetValue("MSISupported", 1);
				}
				else
				{
					registryKey.SetValue("MSISupported", 0);
				}
			}
			catch
			{
				MessageBox.Show("An error happened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
			}
			this.updateMsiMode();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00092F64 File Offset: 0x00091164
		private void save_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2;
			IEnumerator<int> enumerator;
			List<bool> list;
			CheckBox[] array;
			do
			{
				if (num == 1)
				{
					num = 2;
				}
				if (num == 3)
				{
					num = 4;
				}
				if (num == 4)
				{
					num2 = 0;
					num = 5;
				}
				if (num == 6)
				{
					num = 7;
				}
				if (num == 7)
				{
					enumerator = Enumerable.Range(0, Environment.ProcessorCount).GetEnumerator();
					num = 8;
				}
				if (num == 5)
				{
					list = new List<bool>();
					num = 6;
				}
				if (num == 2)
				{
					array = new CheckBox[]
					{
						this.cpu0, this.cpu1, this.cpu2, this.cpu3, this.cpu4, this.cpu5, this.cpu6, this.cpu7, this.cpu8, this.cpu9,
						this.cpu10, this.cpu11, this.cpu12, this.cpu13, this.cpu14, this.cpu15, this.cpu16, this.cpu17, this.cpu18, this.cpu19,
						this.cpu20, this.cpu21, this.cpu22, this.cpu23, this.cpu24, this.cpu25, this.cpu26, this.cpu27, this.cpu28, this.cpu29,
						this.cpu30, this.cpu31, this.cpu32, this.cpu33, this.cpu34, this.cpu35, this.cpu36, this.cpu37, this.cpu38, this.cpu39,
						this.cpu40, this.cpu41, this.cpu42, this.cpu43, this.cpu44, this.cpu45, this.cpu46, this.cpu47, this.cpu48, this.cpu49,
						this.cpu50, this.cpu51, this.cpu52, this.cpu53, this.cpu54, this.cpu55, this.cpu56, this.cpu57, this.cpu58, this.cpu59,
						this.cpu60, this.cpu61, this.cpu62, this.cpu63
					};
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 8);
			try
			{
				while (enumerator.MoveNext())
				{
					int num3 = enumerator.Current;
					CheckBox checkBox = array[num3];
					if (checkBox.Checked)
					{
						num2 |= 1 << num3;
						list.Add(checkBox.Checked);
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
			if (list.Count<bool>() < 1)
			{
				using (affinities_error affinities_error = new affinities_error())
				{
					affinities_error.ShowDialog(this);
					return;
				}
			}
			try
			{
				string text = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
				{
					int num4 = 0;
					do
					{
						if (num4 == 0)
						{
							num4 = 1;
						}
					}
					while (num4 != 1);
					return x.Value == this.deviceNameBox.Text;
				}).Key + "\\Device Parameters\\Interrupt Management\\Affinity Policy";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + text, true);
				registryKey.SetValue("DevicePolicy", 4);
				registryKey.SetValue("AssignmentSetOverride", num2);
				using (applied applied = new applied())
				{
					applied.ShowDialog(this);
				}
				this.updateCores();
			}
			catch
			{
				using (coming_soon coming_soon = new coming_soon())
				{
					coming_soon.ShowDialog(this);
				}
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000935CC File Offset: 0x000917CC
		private void siticoneButton1_Click(object sender, EventArgs e)
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
			try
			{
				string text = this.DevicesPathList.FirstOrDefault(delegate(KeyValuePair<string, string> x)
				{
					int num2 = 0;
					do
					{
						if (num2 == 0)
						{
							num2 = 1;
						}
					}
					while (num2 != 1);
					return x.Value == this.deviceNameBox.Text;
				}).Key + "\\Device Parameters\\Interrupt Management\\Affinity Policy";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\" + text, true);
				registryKey.DeleteValue("DevicePolicy");
				registryKey.DeleteValue("AssignmentSetOverride");
				using (reverted reverted = new reverted())
				{
					reverted.ShowDialog(this);
				}
				this.updateCores();
			}
			catch
			{
				using (coming_soon coming_soon = new coming_soon())
				{
					coming_soon.ShowDialog(this);
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003804 File Offset: 0x00001A04
		private void affinities_Load(object sender, EventArgs e)
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

		// Token: 0x060003C8 RID: 968 RVA: 0x000936DC File Offset: 0x000918DC
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00093754 File Offset: 0x00091954
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
					this.siticoneButton1 = new SiticoneButton();
					num = 5;
				}
				if (num == 5)
				{
					this.msiMode = new SiticoneCheckBox();
					num = 6;
				}
				if (num == 6)
				{
					this.label2 = new Label();
					num = 7;
				}
				if (num == 7)
				{
					this.devicePathLabel = new Label();
					num = 8;
				}
				if (num == 8)
				{
					this.cpu63 = new SiticoneCheckBox();
					num = 9;
				}
				if (num == 9)
				{
					this.cpu61 = new SiticoneCheckBox();
					num = 10;
				}
				if (num == 10)
				{
					this.cpu62 = new SiticoneCheckBox();
					num = 11;
				}
				if (num == 11)
				{
					this.cpu60 = new SiticoneCheckBox();
					num = 12;
				}
				if (num == 12)
				{
					this.cpu59 = new SiticoneCheckBox();
					num = 13;
				}
				if (num == 13)
				{
					this.cpu58 = new SiticoneCheckBox();
					num = 14;
				}
				if (num == 14)
				{
					this.cpu56 = new SiticoneCheckBox();
					num = 15;
				}
				if (num == 15)
				{
					this.cpu57 = new SiticoneCheckBox();
					num = 16;
				}
				if (num == 16)
				{
					this.cpu55 = new SiticoneCheckBox();
					num = 17;
				}
				if (num == 17)
				{
					this.cpu54 = new SiticoneCheckBox();
					num = 18;
				}
				if (num == 18)
				{
					this.cpu53 = new SiticoneCheckBox();
					num = 19;
				}
				if (num == 19)
				{
					this.cpu51 = new SiticoneCheckBox();
					num = 20;
				}
				if (num == 20)
				{
					this.cpu52 = new SiticoneCheckBox();
					num = 21;
				}
				if (num == 21)
				{
					this.cpu50 = new SiticoneCheckBox();
					num = 22;
				}
				if (num == 22)
				{
					this.cpu49 = new SiticoneCheckBox();
					num = 23;
				}
				if (num == 23)
				{
					this.cpu48 = new SiticoneCheckBox();
					num = 24;
				}
				if (num == 24)
				{
					this.cpu46 = new SiticoneCheckBox();
					num = 25;
				}
				if (num == 25)
				{
					this.cpu47 = new SiticoneCheckBox();
					num = 26;
				}
				if (num == 26)
				{
					this.cpu45 = new SiticoneCheckBox();
					num = 27;
				}
				if (num == 27)
				{
					this.cpu44 = new SiticoneCheckBox();
					num = 28;
				}
				if (num == 28)
				{
					this.cpu43 = new SiticoneCheckBox();
					num = 29;
				}
				if (num == 29)
				{
					this.cpu41 = new SiticoneCheckBox();
					num = 30;
				}
				if (num == 30)
				{
					this.cpu42 = new SiticoneCheckBox();
					num = 31;
				}
				if (num == 31)
				{
					this.cpu40 = new SiticoneCheckBox();
					num = 32;
				}
				if (num == 32)
				{
					this.cpu39 = new SiticoneCheckBox();
					num = 33;
				}
				if (num == 33)
				{
					this.cpu38 = new SiticoneCheckBox();
					num = 34;
				}
				if (num == 34)
				{
					this.cpu36 = new SiticoneCheckBox();
					num = 35;
				}
				if (num == 35)
				{
					this.cpu37 = new SiticoneCheckBox();
					num = 36;
				}
				if (num == 36)
				{
					this.cpu35 = new SiticoneCheckBox();
					num = 37;
				}
				if (num == 37)
				{
					this.cpu34 = new SiticoneCheckBox();
					num = 38;
				}
				if (num == 38)
				{
					this.cpu33 = new SiticoneCheckBox();
					num = 39;
				}
				if (num == 39)
				{
					this.cpu31 = new SiticoneCheckBox();
					num = 40;
				}
				if (num == 40)
				{
					this.cpu32 = new SiticoneCheckBox();
					num = 41;
				}
				if (num == 41)
				{
					this.cpu30 = new SiticoneCheckBox();
					num = 42;
				}
				if (num == 43)
				{
					this.cpu28 = new SiticoneCheckBox();
					num = 44;
				}
				if (num == 44)
				{
					this.cpu26 = new SiticoneCheckBox();
					num = 45;
				}
				if (num == 45)
				{
					this.cpu27 = new SiticoneCheckBox();
					num = 46;
				}
				if (num == 46)
				{
					this.cpu25 = new SiticoneCheckBox();
					num = 47;
				}
				if (num == 47)
				{
					this.cpu24 = new SiticoneCheckBox();
					num = 48;
				}
				if (num == 48)
				{
					this.cpu23 = new SiticoneCheckBox();
					num = 49;
				}
				if (num == 49)
				{
					this.cpu21 = new SiticoneCheckBox();
					num = 50;
				}
				if (num == 50)
				{
					this.cpu22 = new SiticoneCheckBox();
					num = 51;
				}
				if (num == 51)
				{
					this.cpu20 = new SiticoneCheckBox();
					num = 52;
				}
				if (num == 52)
				{
					this.cpu19 = new SiticoneCheckBox();
					num = 53;
				}
				if (num == 53)
				{
					this.cpu18 = new SiticoneCheckBox();
					num = 54;
				}
				if (num == 54)
				{
					this.cpu16 = new SiticoneCheckBox();
					num = 55;
				}
				if (num == 55)
				{
					this.cpu17 = new SiticoneCheckBox();
					num = 56;
				}
				if (num == 56)
				{
					this.cpu15 = new SiticoneCheckBox();
					num = 57;
				}
				if (num == 57)
				{
					this.cpu14 = new SiticoneCheckBox();
					num = 58;
				}
				if (num == 58)
				{
					this.cpu13 = new SiticoneCheckBox();
					num = 59;
				}
				if (num == 59)
				{
					this.cpu11 = new SiticoneCheckBox();
					num = 60;
				}
				if (num == 60)
				{
					this.cpu12 = new SiticoneCheckBox();
					num = 61;
				}
				if (num == 61)
				{
					this.cpu10 = new SiticoneCheckBox();
					num = 62;
				}
				if (num == 62)
				{
					this.cpu9 = new SiticoneCheckBox();
					num = 63;
				}
				if (num == 63)
				{
					this.cpu8 = new SiticoneCheckBox();
					num = 64;
				}
				if (num == 64)
				{
					this.cpu6 = new SiticoneCheckBox();
					num = 65;
				}
				if (num == 65)
				{
					this.cpu7 = new SiticoneCheckBox();
					num = 66;
				}
				if (num == 66)
				{
					this.cpu5 = new SiticoneCheckBox();
					num = 67;
				}
				if (num == 67)
				{
					this.save = new SiticoneButton();
					num = 68;
				}
				if (num == 68)
				{
					this.cpu4 = new SiticoneCheckBox();
					num = 69;
				}
				if (num == 69)
				{
					this.cpu3 = new SiticoneCheckBox();
					num = 70;
				}
				if (num == 70)
				{
					this.cpu1 = new SiticoneCheckBox();
					num = 71;
				}
				if (num == 71)
				{
					this.cpu2 = new SiticoneCheckBox();
					num = 72;
				}
				if (num == 72)
				{
					this.cpu0 = new SiticoneCheckBox();
					num = 73;
				}
				if (num == 73)
				{
					this.deviceNameBox = new ComboBox();
					num = 74;
				}
				if (num == 74)
				{
					this.devicePath = new Label();
					num = 75;
				}
				if (num == 75)
				{
					this.back_btn = new SiticoneRoundedButton();
					num = 76;
				}
				if (num == 76)
				{
					this.groupBox1.SuspendLayout();
					num = 77;
				}
				if (num == 77)
				{
					base.SuspendLayout();
					num = 78;
				}
				if (num == 78)
				{
					this.label37.AutoSize = true;
					num = 79;
				}
				if (num == 79)
				{
					this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 80;
				}
				if (num == 80)
				{
					this.label37.ForeColor = Color.Silver;
					num = 81;
				}
				if (num == 81)
				{
					this.label37.Location = new Point(23, 53);
					num = 82;
				}
				if (num == 82)
				{
					this.label37.Name = "label37";
					num = 83;
				}
				if (num == 83)
				{
					this.label37.Size = new Size(197, 19);
					num = 84;
				}
				if (num == 84)
				{
					this.label37.TabIndex = 123;
					num = 85;
				}
				if (num == 86)
				{
					this.label1.AutoSize = true;
					num = 87;
				}
				if (num == 87)
				{
					this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
					num = 88;
				}
				if (num == 88)
				{
					this.label1.ForeColor = Color.White;
					num = 89;
				}
				if (num == 89)
				{
					this.label1.Location = new Point(18, 0);
					num = 90;
				}
				if (num == 90)
				{
					this.label1.Name = "label1";
					num = 91;
				}
				if (num == 91)
				{
					this.label1.Size = new Size(248, 53);
					num = 92;
				}
				if (num == 92)
				{
					this.label1.TabIndex = 122;
					num = 93;
				}
				if (num == 93)
				{
					this.label1.Text = "Expert Tweaks";
					num = 94;
				}
				if (num == 94)
				{
					this.groupBox1.Controls.Add(this.siticoneButton1);
					num = 95;
				}
				if (num == 95)
				{
					this.groupBox1.Controls.Add(this.msiMode);
					num = 96;
				}
				if (num == 96)
				{
					this.groupBox1.Controls.Add(this.label2);
					num = 97;
				}
				if (num == 97)
				{
					this.groupBox1.Controls.Add(this.devicePathLabel);
					num = 98;
				}
				if (num == 98)
				{
					this.groupBox1.Controls.Add(this.cpu63);
					num = 99;
				}
				if (num == 99)
				{
					this.groupBox1.Controls.Add(this.cpu61);
					num = 100;
				}
				if (num == 100)
				{
					this.groupBox1.Controls.Add(this.cpu62);
					num = 101;
				}
				if (num == 101)
				{
					this.groupBox1.Controls.Add(this.cpu60);
					num = 102;
				}
				if (num == 102)
				{
					this.groupBox1.Controls.Add(this.cpu59);
					num = 103;
				}
				if (num == 103)
				{
					this.groupBox1.Controls.Add(this.cpu58);
					num = 104;
				}
				if (num == 104)
				{
					this.groupBox1.Controls.Add(this.cpu56);
					num = 105;
				}
				if (num == 105)
				{
					this.groupBox1.Controls.Add(this.cpu57);
					num = 106;
				}
				if (num == 106)
				{
					this.groupBox1.Controls.Add(this.cpu55);
					num = 107;
				}
				if (num == 107)
				{
					this.groupBox1.Controls.Add(this.cpu54);
					num = 108;
				}
				if (num == 108)
				{
					this.groupBox1.Controls.Add(this.cpu53);
					num = 109;
				}
				if (num == 109)
				{
					this.groupBox1.Controls.Add(this.cpu51);
					num = 110;
				}
				if (num == 110)
				{
					this.groupBox1.Controls.Add(this.cpu52);
					num = 111;
				}
				if (num == 111)
				{
					this.groupBox1.Controls.Add(this.cpu50);
					num = 112;
				}
				if (num == 112)
				{
					this.groupBox1.Controls.Add(this.cpu49);
					num = 113;
				}
				if (num == 113)
				{
					this.groupBox1.Controls.Add(this.cpu48);
					num = 114;
				}
				if (num == 114)
				{
					this.groupBox1.Controls.Add(this.cpu46);
					num = 115;
				}
				if (num == 115)
				{
					this.groupBox1.Controls.Add(this.cpu47);
					num = 116;
				}
				if (num == 116)
				{
					this.groupBox1.Controls.Add(this.cpu45);
					num = 117;
				}
				if (num == 117)
				{
					this.groupBox1.Controls.Add(this.cpu44);
					num = 118;
				}
				if (num == 118)
				{
					this.groupBox1.Controls.Add(this.cpu43);
					num = 119;
				}
				if (num == 119)
				{
					this.groupBox1.Controls.Add(this.cpu41);
					num = 120;
				}
				if (num == 120)
				{
					this.groupBox1.Controls.Add(this.cpu42);
					num = 121;
				}
				if (num == 121)
				{
					this.groupBox1.Controls.Add(this.cpu40);
					num = 122;
				}
				if (num == 122)
				{
					this.groupBox1.Controls.Add(this.cpu39);
					num = 123;
				}
				if (num == 123)
				{
					this.groupBox1.Controls.Add(this.cpu38);
					num = 124;
				}
				if (num == 124)
				{
					this.groupBox1.Controls.Add(this.cpu36);
					num = 125;
				}
				if (num == 125)
				{
					this.groupBox1.Controls.Add(this.cpu37);
					num = 126;
				}
				if (num == 126)
				{
					this.groupBox1.Controls.Add(this.cpu35);
					num = 127;
				}
				if (num == 127)
				{
					this.groupBox1.Controls.Add(this.cpu34);
					num = 128;
				}
				if (num == 129)
				{
					this.groupBox1.Controls.Add(this.cpu31);
					num = 130;
				}
				if (num == 130)
				{
					this.groupBox1.Controls.Add(this.cpu32);
					num = 131;
				}
				if (num == 131)
				{
					this.groupBox1.Controls.Add(this.cpu30);
					num = 132;
				}
				if (num == 132)
				{
					this.groupBox1.Controls.Add(this.cpu29);
					num = 133;
				}
				if (num == 133)
				{
					this.groupBox1.Controls.Add(this.cpu28);
					num = 134;
				}
				if (num == 134)
				{
					this.groupBox1.Controls.Add(this.cpu26);
					num = 135;
				}
				if (num == 135)
				{
					this.groupBox1.Controls.Add(this.cpu27);
					num = 136;
				}
				if (num == 136)
				{
					this.groupBox1.Controls.Add(this.cpu25);
					num = 137;
				}
				if (num == 137)
				{
					this.groupBox1.Controls.Add(this.cpu24);
					num = 138;
				}
				if (num == 138)
				{
					this.groupBox1.Controls.Add(this.cpu23);
					num = 139;
				}
				if (num == 139)
				{
					this.groupBox1.Controls.Add(this.cpu21);
					num = 140;
				}
				if (num == 140)
				{
					this.groupBox1.Controls.Add(this.cpu22);
					num = 141;
				}
				if (num == 141)
				{
					this.groupBox1.Controls.Add(this.cpu20);
					num = 142;
				}
				if (num == 142)
				{
					this.groupBox1.Controls.Add(this.cpu19);
					num = 143;
				}
				if (num == 143)
				{
					this.groupBox1.Controls.Add(this.cpu18);
					num = 144;
				}
				if (num == 144)
				{
					this.groupBox1.Controls.Add(this.cpu16);
					num = 145;
				}
				if (num == 145)
				{
					this.groupBox1.Controls.Add(this.cpu17);
					num = 146;
				}
				if (num == 146)
				{
					this.groupBox1.Controls.Add(this.cpu15);
					num = 147;
				}
				if (num == 147)
				{
					this.groupBox1.Controls.Add(this.cpu14);
					num = 148;
				}
				if (num == 148)
				{
					this.groupBox1.Controls.Add(this.cpu13);
					num = 149;
				}
				if (num == 149)
				{
					this.groupBox1.Controls.Add(this.cpu11);
					num = 150;
				}
				if (num == 150)
				{
					this.groupBox1.Controls.Add(this.cpu12);
					num = 151;
				}
				if (num == 151)
				{
					this.groupBox1.Controls.Add(this.cpu10);
					num = 152;
				}
				if (num == 152)
				{
					this.groupBox1.Controls.Add(this.cpu9);
					num = 153;
				}
				if (num == 153)
				{
					this.groupBox1.Controls.Add(this.cpu8);
					num = 154;
				}
				if (num == 154)
				{
					this.groupBox1.Controls.Add(this.cpu6);
					num = 155;
				}
				if (num == 155)
				{
					this.groupBox1.Controls.Add(this.cpu7);
					num = 156;
				}
				if (num == 156)
				{
					this.groupBox1.Controls.Add(this.cpu5);
					num = 157;
				}
				if (num == 157)
				{
					this.groupBox1.Controls.Add(this.save);
					num = 158;
				}
				if (num == 158)
				{
					this.groupBox1.Controls.Add(this.cpu4);
					num = 159;
				}
				if (num == 159)
				{
					this.groupBox1.Controls.Add(this.cpu3);
					num = 160;
				}
				if (num == 160)
				{
					this.groupBox1.Controls.Add(this.cpu1);
					num = 161;
				}
				if (num == 161)
				{
					this.groupBox1.Controls.Add(this.cpu2);
					num = 162;
				}
				if (num == 162)
				{
					this.groupBox1.Controls.Add(this.cpu0);
					num = 163;
				}
				if (num == 163)
				{
					this.groupBox1.Controls.Add(this.deviceNameBox);
					num = 164;
				}
				if (num == 164)
				{
					this.groupBox1.Controls.Add(this.devicePath);
					num = 165;
				}
				if (num == 165)
				{
					this.groupBox1.Font = new Font("Josefin Sans Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 166;
				}
				if (num == 166)
				{
					this.groupBox1.ForeColor = Color.White;
					num = 167;
				}
				if (num == 167)
				{
					this.groupBox1.Location = new Point(27, 89);
					num = 168;
				}
				if (num == 168)
				{
					this.groupBox1.Name = "groupBox1";
					num = 169;
				}
				if (num == 169)
				{
					this.groupBox1.Size = new Size(949, 551);
					num = 170;
				}
				if (num == 170)
				{
					this.groupBox1.TabIndex = 124;
					num = 171;
				}
				if (num == 172)
				{
					this.groupBox1.Text = "Affinities";
					num = 173;
				}
				if (num == 173)
				{
					this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
					num = 174;
				}
				if (num == 174)
				{
					this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
					num = 175;
				}
				if (num == 175)
				{
					this.siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
					num = 176;
				}
				if (num == 176)
				{
					this.siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 177;
				}
				if (num == 177)
				{
					this.siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 178;
				}
				if (num == 178)
				{
					this.siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 179;
				}
				if (num == 179)
				{
					this.siticoneButton1.DisabledState.Parent = this.siticoneButton1;
					num = 180;
				}
				if (num == 180)
				{
					this.siticoneButton1.FillColor = Color.FromArgb(38, 38, 38);
					num = 181;
				}
				if (num == 181)
				{
					this.siticoneButton1.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 182;
				}
				if (num == 182)
				{
					this.siticoneButton1.ForeColor = Color.White;
					num = 183;
				}
				if (num == 183)
				{
					this.siticoneButton1.HoverState.Parent = this.siticoneButton1;
					num = 184;
				}
				if (num == 184)
				{
					this.siticoneButton1.ImageSize = new Size(30, 30);
					num = 185;
				}
				if (num == 185)
				{
					this.siticoneButton1.Location = new Point(633, 470);
					num = 186;
				}
				if (num == 186)
				{
					this.siticoneButton1.Name = "siticoneButton1";
					num = 187;
				}
				if (num == 187)
				{
					this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
					num = 188;
				}
				if (num == 188)
				{
					this.siticoneButton1.Size = new Size(135, 38);
					num = 189;
				}
				if (num == 189)
				{
					this.siticoneButton1.TabIndex = 380;
					num = 190;
				}
				if (num == 190)
				{
					this.siticoneButton1.Text = "Delete Mask";
					num = 191;
				}
				if (num == 191)
				{
					this.siticoneButton1.Click += this.siticoneButton1_Click;
					num = 192;
				}
				if (num == 192)
				{
					this.msiMode.AutoSize = true;
					num = 193;
				}
				if (num == 193)
				{
					this.msiMode.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 194;
				}
				if (num == 194)
				{
					this.msiMode.CheckedState.BorderRadius = 0;
					num = 195;
				}
				if (num == 195)
				{
					this.msiMode.CheckedState.BorderThickness = 0;
					num = 196;
				}
				if (num == 196)
				{
					this.msiMode.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 197;
				}
				if (num == 197)
				{
					this.msiMode.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 198;
				}
				if (num == 198)
				{
					this.msiMode.ForeColor = Color.White;
					num = 199;
				}
				if (num == 199)
				{
					this.msiMode.Location = new Point(517, 475);
					num = 200;
				}
				if (num == 200)
				{
					this.msiMode.Name = "msiMode";
					num = 201;
				}
				if (num == 201)
				{
					this.msiMode.Size = new Size(101, 28);
					num = 202;
				}
				if (num == 202)
				{
					this.msiMode.TabIndex = 379;
					num = 203;
				}
				if (num == 203)
				{
					this.msiMode.Text = "MSI Mode";
					num = 204;
				}
				if (num == 204)
				{
					this.msiMode.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 205;
				}
				if (num == 205)
				{
					this.msiMode.UncheckedState.BorderRadius = 0;
					num = 206;
				}
				if (num == 206)
				{
					this.msiMode.UncheckedState.BorderThickness = 0;
					num = 207;
				}
				if (num == 207)
				{
					this.msiMode.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 208;
				}
				if (num == 208)
				{
					this.msiMode.CheckedChanged += this.msiMode_CheckedChanged;
					num = 209;
				}
				if (num == 209)
				{
					this.label2.AutoSize = true;
					num = 210;
				}
				if (num == 210)
				{
					this.label2.Font = new Font("Josefin Sans Light", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 211;
				}
				if (num == 211)
				{
					this.label2.Location = new Point(26, 133);
					num = 212;
				}
				if (num == 212)
				{
					this.label2.Name = "label2";
					num = 213;
				}
				if (num == 213)
				{
					this.label2.Size = new Size(110, 25);
					num = 214;
				}
				if (num == 215)
				{
					this.label2.Text = "Affinity Mask :";
					num = 216;
				}
				if (num == 216)
				{
					this.devicePathLabel.AutoSize = true;
					num = 217;
				}
				if (num == 217)
				{
					this.devicePathLabel.Font = new Font("Josefin Sans Light", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 218;
				}
				if (num == 218)
				{
					this.devicePathLabel.Location = new Point(26, 91);
					num = 219;
				}
				if (num == 219)
				{
					this.devicePathLabel.Name = "devicePathLabel";
					num = 220;
				}
				if (num == 220)
				{
					this.devicePathLabel.Size = new Size(102, 25);
					num = 221;
				}
				if (num == 221)
				{
					this.devicePathLabel.TabIndex = 377;
					num = 222;
				}
				if (num == 222)
				{
					this.devicePathLabel.Text = "Device Path :";
					num = 223;
				}
				if (num == 223)
				{
					this.cpu63.AutoSize = true;
					num = 224;
				}
				if (num == 224)
				{
					this.cpu63.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 225;
				}
				if (num == 225)
				{
					this.cpu63.CheckedState.BorderRadius = 0;
					num = 226;
				}
				if (num == 226)
				{
					this.cpu63.CheckedState.BorderThickness = 0;
					num = 227;
				}
				if (num == 227)
				{
					this.cpu63.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 228;
				}
				if (num == 228)
				{
					this.cpu63.Enabled = false;
					num = 229;
				}
				if (num == 229)
				{
					this.cpu63.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 230;
				}
				if (num == 230)
				{
					this.cpu63.ForeColor = Color.White;
					num = 231;
				}
				if (num == 231)
				{
					this.cpu63.Location = new Point(302, 375);
					num = 232;
				}
				if (num == 232)
				{
					this.cpu63.Name = "cpu63";
					num = 233;
				}
				if (num == 233)
				{
					this.cpu63.Size = new Size(80, 28);
					num = 234;
				}
				if (num == 234)
				{
					this.cpu63.TabIndex = 376;
					num = 235;
				}
				if (num == 235)
				{
					this.cpu63.Text = "CPU 63";
					num = 236;
				}
				if (num == 236)
				{
					this.cpu63.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 237;
				}
				if (num == 237)
				{
					this.cpu63.UncheckedState.BorderRadius = 0;
					num = 238;
				}
				if (num == 238)
				{
					this.cpu63.UncheckedState.BorderThickness = 0;
					num = 239;
				}
				if (num == 239)
				{
					this.cpu63.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 240;
				}
				if (num == 240)
				{
					this.cpu61.AutoSize = true;
					num = 241;
				}
				if (num == 241)
				{
					this.cpu61.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 242;
				}
				if (num == 242)
				{
					this.cpu61.CheckedState.BorderRadius = 0;
					num = 243;
				}
				if (num == 243)
				{
					this.cpu61.CheckedState.BorderThickness = 0;
					num = 244;
				}
				if (num == 244)
				{
					this.cpu61.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 245;
				}
				if (num == 245)
				{
					this.cpu61.Enabled = false;
					num = 246;
				}
				if (num == 246)
				{
					this.cpu61.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 247;
				}
				if (num == 247)
				{
					this.cpu61.ForeColor = Color.White;
					num = 248;
				}
				if (num == 248)
				{
					this.cpu61.Location = new Point(123, 375);
					num = 249;
				}
				if (num == 249)
				{
					this.cpu61.Name = "cpu61";
					num = 250;
				}
				if (num == 250)
				{
					this.cpu61.Size = new Size(77, 28);
					num = 251;
				}
				if (num == 251)
				{
					this.cpu61.TabIndex = 375;
					num = 252;
				}
				if (num == 252)
				{
					this.cpu61.Text = "CPU 61";
					num = 253;
				}
				if (num == 253)
				{
					this.cpu61.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 254;
				}
				if (num == 254)
				{
					this.cpu61.UncheckedState.BorderRadius = 0;
					num = 255;
				}
				if (num == 255)
				{
					this.cpu61.UncheckedState.BorderThickness = 0;
					num = 256;
				}
				if (num == 256)
				{
					this.cpu61.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 257;
				}
				if (num == 258)
				{
					this.cpu62.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 259;
				}
				if (num == 259)
				{
					this.cpu62.CheckedState.BorderRadius = 0;
					num = 260;
				}
				if (num == 260)
				{
					this.cpu62.CheckedState.BorderThickness = 0;
					num = 261;
				}
				if (num == 261)
				{
					this.cpu62.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 262;
				}
				if (num == 262)
				{
					this.cpu62.Enabled = false;
					num = 263;
				}
				if (num == 263)
				{
					this.cpu62.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 264;
				}
				if (num == 264)
				{
					this.cpu62.ForeColor = Color.White;
					num = 265;
				}
				if (num == 265)
				{
					this.cpu62.Location = new Point(211, 375);
					num = 266;
				}
				if (num == 266)
				{
					this.cpu62.Name = "cpu62";
					num = 267;
				}
				if (num == 267)
				{
					this.cpu62.Size = new Size(80, 28);
					num = 268;
				}
				if (num == 268)
				{
					this.cpu62.TabIndex = 374;
					num = 269;
				}
				if (num == 269)
				{
					this.cpu62.Text = "CPU 62";
					num = 270;
				}
				if (num == 270)
				{
					this.cpu62.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 271;
				}
				if (num == 271)
				{
					this.cpu62.UncheckedState.BorderRadius = 0;
					num = 272;
				}
				if (num == 272)
				{
					this.cpu62.UncheckedState.BorderThickness = 0;
					num = 273;
				}
				if (num == 273)
				{
					this.cpu62.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 274;
				}
				if (num == 274)
				{
					this.cpu60.AutoSize = true;
					num = 275;
				}
				if (num == 275)
				{
					this.cpu60.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 276;
				}
				if (num == 276)
				{
					this.cpu60.CheckedState.BorderRadius = 0;
					num = 277;
				}
				if (num == 277)
				{
					this.cpu60.CheckedState.BorderThickness = 0;
					num = 278;
				}
				if (num == 278)
				{
					this.cpu60.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 279;
				}
				if (num == 279)
				{
					this.cpu60.Enabled = false;
					num = 280;
				}
				if (num == 280)
				{
					this.cpu60.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 281;
				}
				if (num == 281)
				{
					this.cpu60.ForeColor = Color.White;
					num = 282;
				}
				if (num == 282)
				{
					this.cpu60.Location = new Point(31, 375);
					num = 283;
				}
				if (num == 283)
				{
					this.cpu60.Name = "cpu60";
					num = 284;
				}
				if (num == 284)
				{
					this.cpu60.Size = new Size(81, 28);
					num = 285;
				}
				if (num == 285)
				{
					this.cpu60.TabIndex = 373;
					num = 286;
				}
				if (num == 286)
				{
					this.cpu60.Text = "CPU 60";
					num = 287;
				}
				if (num == 287)
				{
					this.cpu60.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 288;
				}
				if (num == 288)
				{
					this.cpu60.UncheckedState.BorderRadius = 0;
					num = 289;
				}
				if (num == 289)
				{
					this.cpu60.UncheckedState.BorderThickness = 0;
					num = 290;
				}
				if (num == 290)
				{
					this.cpu60.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 291;
				}
				if (num == 291)
				{
					this.cpu59.AutoSize = true;
					num = 292;
				}
				if (num == 292)
				{
					this.cpu59.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 293;
				}
				if (num == 293)
				{
					this.cpu59.CheckedState.BorderRadius = 0;
					num = 294;
				}
				if (num == 294)
				{
					this.cpu59.CheckedState.BorderThickness = 0;
					num = 295;
				}
				if (num == 295)
				{
					this.cpu59.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 296;
				}
				if (num == 296)
				{
					this.cpu59.Enabled = false;
					num = 297;
				}
				if (num == 297)
				{
					this.cpu59.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 298;
				}
				if (num == 298)
				{
					this.cpu59.ForeColor = Color.White;
					num = 299;
				}
				if (num == 299)
				{
					this.cpu59.Location = new Point(846, 341);
					num = 300;
				}
				if (num == 301)
				{
					this.cpu59.Size = new Size(80, 28);
					num = 302;
				}
				if (num == 302)
				{
					this.cpu59.TabIndex = 372;
					num = 303;
				}
				if (num == 303)
				{
					this.cpu59.Text = "CPU 59";
					num = 304;
				}
				if (num == 304)
				{
					this.cpu59.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 305;
				}
				if (num == 305)
				{
					this.cpu59.UncheckedState.BorderRadius = 0;
					num = 306;
				}
				if (num == 306)
				{
					this.cpu59.UncheckedState.BorderThickness = 0;
					num = 307;
				}
				if (num == 307)
				{
					this.cpu59.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 308;
				}
				if (num == 308)
				{
					this.cpu58.AutoSize = true;
					num = 309;
				}
				if (num == 309)
				{
					this.cpu58.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 310;
				}
				if (num == 310)
				{
					this.cpu58.CheckedState.BorderRadius = 0;
					num = 311;
				}
				if (num == 311)
				{
					this.cpu58.CheckedState.BorderThickness = 0;
					num = 312;
				}
				if (num == 312)
				{
					this.cpu58.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 313;
				}
				if (num == 313)
				{
					this.cpu58.Enabled = false;
					num = 314;
				}
				if (num == 314)
				{
					this.cpu58.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 315;
				}
				if (num == 315)
				{
					this.cpu58.ForeColor = Color.White;
					num = 316;
				}
				if (num == 316)
				{
					this.cpu58.Location = new Point(755, 341);
					num = 317;
				}
				if (num == 317)
				{
					this.cpu58.Name = "cpu58";
					num = 318;
				}
				if (num == 318)
				{
					this.cpu58.Size = new Size(80, 28);
					num = 319;
				}
				if (num == 319)
				{
					this.cpu58.TabIndex = 371;
					num = 320;
				}
				if (num == 320)
				{
					this.cpu58.Text = "CPU 58";
					num = 321;
				}
				if (num == 321)
				{
					this.cpu58.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 322;
				}
				if (num == 322)
				{
					this.cpu58.UncheckedState.BorderRadius = 0;
					num = 323;
				}
				if (num == 323)
				{
					this.cpu58.UncheckedState.BorderThickness = 0;
					num = 324;
				}
				if (num == 324)
				{
					this.cpu58.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 325;
				}
				if (num == 325)
				{
					this.cpu56.AutoSize = true;
					num = 326;
				}
				if (num == 326)
				{
					this.cpu56.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 327;
				}
				if (num == 327)
				{
					this.cpu56.CheckedState.BorderRadius = 0;
					num = 328;
				}
				if (num == 328)
				{
					this.cpu56.CheckedState.BorderThickness = 0;
					num = 329;
				}
				if (num == 329)
				{
					this.cpu56.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 330;
				}
				if (num == 330)
				{
					this.cpu56.Enabled = false;
					num = 331;
				}
				if (num == 331)
				{
					this.cpu56.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 332;
				}
				if (num == 332)
				{
					this.cpu56.ForeColor = Color.White;
					num = 333;
				}
				if (num == 333)
				{
					this.cpu56.Location = new Point(576, 341);
					num = 334;
				}
				if (num == 334)
				{
					this.cpu56.Name = "cpu56";
					num = 335;
				}
				if (num == 335)
				{
					this.cpu56.Size = new Size(80, 28);
					num = 336;
				}
				if (num == 336)
				{
					this.cpu56.TabIndex = 370;
					num = 337;
				}
				if (num == 337)
				{
					this.cpu56.Text = "CPU 56";
					num = 338;
				}
				if (num == 338)
				{
					this.cpu56.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 339;
				}
				if (num == 339)
				{
					this.cpu56.UncheckedState.BorderRadius = 0;
					num = 340;
				}
				if (num == 340)
				{
					this.cpu56.UncheckedState.BorderThickness = 0;
					num = 341;
				}
				if (num == 341)
				{
					this.cpu56.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 342;
				}
				if (num == 342)
				{
					this.cpu57.AutoSize = true;
					num = 343;
				}
				if (num == 344)
				{
					this.cpu57.CheckedState.BorderRadius = 0;
					num = 345;
				}
				if (num == 345)
				{
					this.cpu57.CheckedState.BorderThickness = 0;
					num = 346;
				}
				if (num == 346)
				{
					this.cpu57.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 347;
				}
				if (num == 347)
				{
					this.cpu57.Enabled = false;
					num = 348;
				}
				if (num == 348)
				{
					this.cpu57.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 349;
				}
				if (num == 349)
				{
					this.cpu57.ForeColor = Color.White;
					num = 350;
				}
				if (num == 350)
				{
					this.cpu57.Location = new Point(664, 341);
					num = 351;
				}
				if (num == 351)
				{
					this.cpu57.Name = "cpu57";
					num = 352;
				}
				if (num == 352)
				{
					this.cpu57.Size = new Size(79, 28);
					num = 353;
				}
				if (num == 353)
				{
					this.cpu57.TabIndex = 369;
					num = 354;
				}
				if (num == 354)
				{
					this.cpu57.Text = "CPU 57";
					num = 355;
				}
				if (num == 355)
				{
					this.cpu57.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 356;
				}
				if (num == 356)
				{
					this.cpu57.UncheckedState.BorderRadius = 0;
					num = 357;
				}
				if (num == 357)
				{
					this.cpu57.UncheckedState.BorderThickness = 0;
					num = 358;
				}
				if (num == 358)
				{
					this.cpu57.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 359;
				}
				if (num == 359)
				{
					this.cpu55.AutoSize = true;
					num = 360;
				}
				if (num == 360)
				{
					this.cpu55.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 361;
				}
				if (num == 361)
				{
					this.cpu55.CheckedState.BorderRadius = 0;
					num = 362;
				}
				if (num == 362)
				{
					this.cpu55.CheckedState.BorderThickness = 0;
					num = 363;
				}
				if (num == 363)
				{
					this.cpu55.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 364;
				}
				if (num == 364)
				{
					this.cpu55.Enabled = false;
					num = 365;
				}
				if (num == 365)
				{
					this.cpu55.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 366;
				}
				if (num == 366)
				{
					this.cpu55.ForeColor = Color.White;
					num = 367;
				}
				if (num == 367)
				{
					this.cpu55.Location = new Point(484, 341);
					num = 368;
				}
				if (num == 368)
				{
					this.cpu55.Name = "cpu55";
					num = 369;
				}
				if (num == 369)
				{
					this.cpu55.Size = new Size(80, 28);
					num = 370;
				}
				if (num == 370)
				{
					this.cpu55.TabIndex = 368;
					num = 371;
				}
				if (num == 371)
				{
					this.cpu55.Text = "CPU 55";
					num = 372;
				}
				if (num == 372)
				{
					this.cpu55.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 373;
				}
				if (num == 373)
				{
					this.cpu55.UncheckedState.BorderRadius = 0;
					num = 374;
				}
				if (num == 374)
				{
					this.cpu55.UncheckedState.BorderThickness = 0;
					num = 375;
				}
				if (num == 375)
				{
					this.cpu55.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 376;
				}
				if (num == 376)
				{
					this.cpu54.AutoSize = true;
					num = 377;
				}
				if (num == 377)
				{
					this.cpu54.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 378;
				}
				if (num == 378)
				{
					this.cpu54.CheckedState.BorderRadius = 0;
					num = 379;
				}
				if (num == 379)
				{
					this.cpu54.CheckedState.BorderThickness = 0;
					num = 380;
				}
				if (num == 380)
				{
					this.cpu54.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 381;
				}
				if (num == 381)
				{
					this.cpu54.Enabled = false;
					num = 382;
				}
				if (num == 382)
				{
					this.cpu54.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 383;
				}
				if (num == 383)
				{
					this.cpu54.ForeColor = Color.White;
					num = 384;
				}
				if (num == 384)
				{
					this.cpu54.Location = new Point(393, 341);
					num = 385;
				}
				if (num == 386)
				{
					this.cpu54.Size = new Size(80, 28);
					num = 387;
				}
				if (num == 387)
				{
					this.cpu54.TabIndex = 367;
					num = 388;
				}
				if (num == 388)
				{
					this.cpu54.Text = "CPU 54";
					num = 389;
				}
				if (num == 389)
				{
					this.cpu54.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 390;
				}
				if (num == 390)
				{
					this.cpu54.UncheckedState.BorderRadius = 0;
					num = 391;
				}
				if (num == 391)
				{
					this.cpu54.UncheckedState.BorderThickness = 0;
					num = 392;
				}
				if (num == 392)
				{
					this.cpu54.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 393;
				}
				if (num == 393)
				{
					this.cpu53.AutoSize = true;
					num = 394;
				}
				if (num == 394)
				{
					this.cpu53.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 395;
				}
				if (num == 395)
				{
					this.cpu53.CheckedState.BorderRadius = 0;
					num = 396;
				}
				if (num == 396)
				{
					this.cpu53.CheckedState.BorderThickness = 0;
					num = 397;
				}
				if (num == 397)
				{
					this.cpu53.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 398;
				}
				if (num == 398)
				{
					this.cpu53.Enabled = false;
					num = 399;
				}
				if (num == 399)
				{
					this.cpu53.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 400;
				}
				if (num == 400)
				{
					this.cpu53.ForeColor = Color.White;
					num = 401;
				}
				if (num == 401)
				{
					this.cpu53.Location = new Point(302, 341);
					num = 402;
				}
				if (num == 402)
				{
					this.cpu53.Name = "cpu53";
					num = 403;
				}
				if (num == 403)
				{
					this.cpu53.Size = new Size(80, 28);
					num = 404;
				}
				if (num == 404)
				{
					this.cpu53.TabIndex = 366;
					num = 405;
				}
				if (num == 405)
				{
					this.cpu53.Text = "CPU 53";
					num = 406;
				}
				if (num == 406)
				{
					this.cpu53.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 407;
				}
				if (num == 407)
				{
					this.cpu53.UncheckedState.BorderRadius = 0;
					num = 408;
				}
				if (num == 408)
				{
					this.cpu53.UncheckedState.BorderThickness = 0;
					num = 409;
				}
				if (num == 409)
				{
					this.cpu53.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 410;
				}
				if (num == 410)
				{
					this.cpu51.AutoSize = true;
					num = 411;
				}
				if (num == 411)
				{
					this.cpu51.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 412;
				}
				if (num == 412)
				{
					this.cpu51.CheckedState.BorderRadius = 0;
					num = 413;
				}
				if (num == 413)
				{
					this.cpu51.CheckedState.BorderThickness = 0;
					num = 414;
				}
				if (num == 414)
				{
					this.cpu51.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 415;
				}
				if (num == 415)
				{
					this.cpu51.Enabled = false;
					num = 416;
				}
				if (num == 416)
				{
					this.cpu51.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 417;
				}
				if (num == 417)
				{
					this.cpu51.ForeColor = Color.White;
					num = 418;
				}
				if (num == 418)
				{
					this.cpu51.Location = new Point(123, 341);
					num = 419;
				}
				if (num == 419)
				{
					this.cpu51.Name = "cpu51";
					num = 420;
				}
				if (num == 420)
				{
					this.cpu51.Size = new Size(77, 28);
					num = 421;
				}
				if (num == 421)
				{
					this.cpu51.TabIndex = 365;
					num = 422;
				}
				if (num == 422)
				{
					this.cpu51.Text = "CPU 51";
					num = 423;
				}
				if (num == 423)
				{
					this.cpu51.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 424;
				}
				if (num == 424)
				{
					this.cpu51.UncheckedState.BorderRadius = 0;
					num = 425;
				}
				if (num == 425)
				{
					this.cpu51.UncheckedState.BorderThickness = 0;
					num = 426;
				}
				if (num == 426)
				{
					this.cpu51.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 427;
				}
				if (num == 427)
				{
					this.cpu52.AutoSize = true;
					num = 428;
				}
				if (num == 429)
				{
					this.cpu52.CheckedState.BorderRadius = 0;
					num = 430;
				}
				if (num == 430)
				{
					this.cpu52.CheckedState.BorderThickness = 0;
					num = 431;
				}
				if (num == 431)
				{
					this.cpu52.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 432;
				}
				if (num == 432)
				{
					this.cpu52.Enabled = false;
					num = 433;
				}
				if (num == 433)
				{
					this.cpu52.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 434;
				}
				if (num == 434)
				{
					this.cpu52.ForeColor = Color.White;
					num = 435;
				}
				if (num == 435)
				{
					this.cpu52.Location = new Point(211, 341);
					num = 436;
				}
				if (num == 436)
				{
					this.cpu52.Name = "cpu52";
					num = 437;
				}
				if (num == 437)
				{
					this.cpu52.Size = new Size(80, 28);
					num = 438;
				}
				if (num == 438)
				{
					this.cpu52.TabIndex = 364;
					num = 439;
				}
				if (num == 439)
				{
					this.cpu52.Text = "CPU 52";
					num = 440;
				}
				if (num == 440)
				{
					this.cpu52.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 441;
				}
				if (num == 441)
				{
					this.cpu52.UncheckedState.BorderRadius = 0;
					num = 442;
				}
				if (num == 442)
				{
					this.cpu52.UncheckedState.BorderThickness = 0;
					num = 443;
				}
				if (num == 443)
				{
					this.cpu52.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 444;
				}
				if (num == 444)
				{
					this.cpu50.AutoSize = true;
					num = 445;
				}
				if (num == 445)
				{
					this.cpu50.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 446;
				}
				if (num == 446)
				{
					this.cpu50.CheckedState.BorderRadius = 0;
					num = 447;
				}
				if (num == 447)
				{
					this.cpu50.CheckedState.BorderThickness = 0;
					num = 448;
				}
				if (num == 448)
				{
					this.cpu50.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 449;
				}
				if (num == 449)
				{
					this.cpu50.Enabled = false;
					num = 450;
				}
				if (num == 450)
				{
					this.cpu50.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 451;
				}
				if (num == 451)
				{
					this.cpu50.ForeColor = Color.White;
					num = 452;
				}
				if (num == 452)
				{
					this.cpu50.Location = new Point(31, 341);
					num = 453;
				}
				if (num == 453)
				{
					this.cpu50.Name = "cpu50";
					num = 454;
				}
				if (num == 454)
				{
					this.cpu50.Size = new Size(81, 28);
					num = 455;
				}
				if (num == 455)
				{
					this.cpu50.TabIndex = 363;
					num = 456;
				}
				if (num == 456)
				{
					this.cpu50.Text = "CPU 50";
					num = 457;
				}
				if (num == 457)
				{
					this.cpu50.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 458;
				}
				if (num == 458)
				{
					this.cpu50.UncheckedState.BorderRadius = 0;
					num = 459;
				}
				if (num == 459)
				{
					this.cpu50.UncheckedState.BorderThickness = 0;
					num = 460;
				}
				if (num == 460)
				{
					this.cpu50.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 461;
				}
				if (num == 461)
				{
					this.cpu49.AutoSize = true;
					num = 462;
				}
				if (num == 462)
				{
					this.cpu49.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 463;
				}
				if (num == 463)
				{
					this.cpu49.CheckedState.BorderRadius = 0;
					num = 464;
				}
				if (num == 464)
				{
					this.cpu49.CheckedState.BorderThickness = 0;
					num = 465;
				}
				if (num == 465)
				{
					this.cpu49.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 466;
				}
				if (num == 466)
				{
					this.cpu49.Enabled = false;
					num = 467;
				}
				if (num == 467)
				{
					this.cpu49.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 468;
				}
				if (num == 468)
				{
					this.cpu49.ForeColor = Color.White;
					num = 469;
				}
				if (num == 469)
				{
					this.cpu49.Location = new Point(846, 307);
					num = 470;
				}
				if (num == 470)
				{
					this.cpu49.Name = "cpu49";
					num = 471;
				}
				if (num == 472)
				{
					this.cpu49.TabIndex = 362;
					num = 473;
				}
				if (num == 473)
				{
					this.cpu49.Text = "CPU 49";
					num = 474;
				}
				if (num == 474)
				{
					this.cpu49.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 475;
				}
				if (num == 475)
				{
					this.cpu49.UncheckedState.BorderRadius = 0;
					num = 476;
				}
				if (num == 476)
				{
					this.cpu49.UncheckedState.BorderThickness = 0;
					num = 477;
				}
				if (num == 477)
				{
					this.cpu49.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 478;
				}
				if (num == 478)
				{
					this.cpu48.AutoSize = true;
					num = 479;
				}
				if (num == 479)
				{
					this.cpu48.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 480;
				}
				if (num == 480)
				{
					this.cpu48.CheckedState.BorderRadius = 0;
					num = 481;
				}
				if (num == 481)
				{
					this.cpu48.CheckedState.BorderThickness = 0;
					num = 482;
				}
				if (num == 482)
				{
					this.cpu48.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 483;
				}
				if (num == 483)
				{
					this.cpu48.Enabled = false;
					num = 484;
				}
				if (num == 484)
				{
					this.cpu48.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 485;
				}
				if (num == 485)
				{
					this.cpu48.ForeColor = Color.White;
					num = 486;
				}
				if (num == 486)
				{
					this.cpu48.Location = new Point(755, 307);
					num = 487;
				}
				if (num == 487)
				{
					this.cpu48.Name = "cpu48";
					num = 488;
				}
				if (num == 488)
				{
					this.cpu48.Size = new Size(80, 28);
					num = 489;
				}
				if (num == 489)
				{
					this.cpu48.TabIndex = 361;
					num = 490;
				}
				if (num == 490)
				{
					this.cpu48.Text = "CPU 48";
					num = 491;
				}
				if (num == 491)
				{
					this.cpu48.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 492;
				}
				if (num == 492)
				{
					this.cpu48.UncheckedState.BorderRadius = 0;
					num = 493;
				}
				if (num == 493)
				{
					this.cpu48.UncheckedState.BorderThickness = 0;
					num = 494;
				}
				if (num == 494)
				{
					this.cpu48.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 495;
				}
				if (num == 495)
				{
					this.cpu46.AutoSize = true;
					num = 496;
				}
				if (num == 496)
				{
					this.cpu46.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 497;
				}
				if (num == 497)
				{
					this.cpu46.CheckedState.BorderRadius = 0;
					num = 498;
				}
				if (num == 498)
				{
					this.cpu46.CheckedState.BorderThickness = 0;
					num = 499;
				}
				if (num == 499)
				{
					this.cpu46.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 500;
				}
				if (num == 500)
				{
					this.cpu46.Enabled = false;
					num = 501;
				}
				if (num == 501)
				{
					this.cpu46.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 502;
				}
				if (num == 502)
				{
					this.cpu46.ForeColor = Color.White;
					num = 503;
				}
				if (num == 503)
				{
					this.cpu46.Location = new Point(576, 307);
					num = 504;
				}
				if (num == 504)
				{
					this.cpu46.Name = "cpu46";
					num = 505;
				}
				if (num == 505)
				{
					this.cpu46.Size = new Size(80, 28);
					num = 506;
				}
				if (num == 506)
				{
					this.cpu46.TabIndex = 360;
					num = 507;
				}
				if (num == 507)
				{
					this.cpu46.Text = "CPU 46";
					num = 508;
				}
				if (num == 508)
				{
					this.cpu46.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 509;
				}
				if (num == 509)
				{
					this.cpu46.UncheckedState.BorderRadius = 0;
					num = 510;
				}
				if (num == 510)
				{
					this.cpu46.UncheckedState.BorderThickness = 0;
					num = 511;
				}
				if (num == 511)
				{
					this.cpu46.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 512;
				}
				if (num == 512)
				{
					this.cpu47.AutoSize = true;
					num = 513;
				}
				if (num == 513)
				{
					this.cpu47.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 514;
				}
				if (num == 515)
				{
					this.cpu47.CheckedState.BorderThickness = 0;
					num = 516;
				}
				if (num == 516)
				{
					this.cpu47.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 517;
				}
				if (num == 517)
				{
					this.cpu47.Enabled = false;
					num = 518;
				}
				if (num == 518)
				{
					this.cpu47.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 519;
				}
				if (num == 519)
				{
					this.cpu47.ForeColor = Color.White;
					num = 520;
				}
				if (num == 520)
				{
					this.cpu47.Location = new Point(664, 307);
					num = 521;
				}
				if (num == 521)
				{
					this.cpu47.Name = "cpu47";
					num = 522;
				}
				if (num == 522)
				{
					this.cpu47.Size = new Size(79, 28);
					num = 523;
				}
				if (num == 523)
				{
					this.cpu47.TabIndex = 359;
					num = 524;
				}
				if (num == 524)
				{
					this.cpu47.Text = "CPU 47";
					num = 525;
				}
				if (num == 525)
				{
					this.cpu47.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 526;
				}
				if (num == 526)
				{
					this.cpu47.UncheckedState.BorderRadius = 0;
					num = 527;
				}
				if (num == 527)
				{
					this.cpu47.UncheckedState.BorderThickness = 0;
					num = 528;
				}
				if (num == 528)
				{
					this.cpu47.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 529;
				}
				if (num == 529)
				{
					this.cpu45.AutoSize = true;
					num = 530;
				}
				if (num == 530)
				{
					this.cpu45.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 531;
				}
				if (num == 531)
				{
					this.cpu45.CheckedState.BorderRadius = 0;
					num = 532;
				}
				if (num == 532)
				{
					this.cpu45.CheckedState.BorderThickness = 0;
					num = 533;
				}
				if (num == 533)
				{
					this.cpu45.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 534;
				}
				if (num == 534)
				{
					this.cpu45.Enabled = false;
					num = 535;
				}
				if (num == 535)
				{
					this.cpu45.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 536;
				}
				if (num == 536)
				{
					this.cpu45.ForeColor = Color.White;
					num = 537;
				}
				if (num == 537)
				{
					this.cpu45.Location = new Point(484, 307);
					num = 538;
				}
				if (num == 538)
				{
					this.cpu45.Name = "cpu45";
					num = 539;
				}
				if (num == 539)
				{
					this.cpu45.Size = new Size(80, 28);
					num = 540;
				}
				if (num == 540)
				{
					this.cpu45.TabIndex = 358;
					num = 541;
				}
				if (num == 541)
				{
					this.cpu45.Text = "CPU 45";
					num = 542;
				}
				if (num == 542)
				{
					this.cpu45.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 543;
				}
				if (num == 543)
				{
					this.cpu45.UncheckedState.BorderRadius = 0;
					num = 544;
				}
				if (num == 544)
				{
					this.cpu45.UncheckedState.BorderThickness = 0;
					num = 545;
				}
				if (num == 545)
				{
					this.cpu45.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 546;
				}
				if (num == 546)
				{
					this.cpu44.AutoSize = true;
					num = 547;
				}
				if (num == 547)
				{
					this.cpu44.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 548;
				}
				if (num == 548)
				{
					this.cpu44.CheckedState.BorderRadius = 0;
					num = 549;
				}
				if (num == 549)
				{
					this.cpu44.CheckedState.BorderThickness = 0;
					num = 550;
				}
				if (num == 550)
				{
					this.cpu44.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 551;
				}
				if (num == 551)
				{
					this.cpu44.Enabled = false;
					num = 552;
				}
				if (num == 552)
				{
					this.cpu44.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 553;
				}
				if (num == 553)
				{
					this.cpu44.ForeColor = Color.White;
					num = 554;
				}
				if (num == 554)
				{
					this.cpu44.Location = new Point(393, 307);
					num = 555;
				}
				if (num == 555)
				{
					this.cpu44.Name = "cpu44";
					num = 556;
				}
				if (num == 556)
				{
					this.cpu44.Size = new Size(80, 28);
					num = 557;
				}
				if (num == 558)
				{
					this.cpu44.Text = "CPU 44";
					num = 559;
				}
				if (num == 559)
				{
					this.cpu44.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 560;
				}
				if (num == 560)
				{
					this.cpu44.UncheckedState.BorderRadius = 0;
					num = 561;
				}
				if (num == 561)
				{
					this.cpu44.UncheckedState.BorderThickness = 0;
					num = 562;
				}
				if (num == 562)
				{
					this.cpu44.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 563;
				}
				if (num == 563)
				{
					this.cpu43.AutoSize = true;
					num = 564;
				}
				if (num == 564)
				{
					this.cpu43.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 565;
				}
				if (num == 565)
				{
					this.cpu43.CheckedState.BorderRadius = 0;
					num = 566;
				}
				if (num == 566)
				{
					this.cpu43.CheckedState.BorderThickness = 0;
					num = 567;
				}
				if (num == 567)
				{
					this.cpu43.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 568;
				}
				if (num == 568)
				{
					this.cpu43.Enabled = false;
					num = 569;
				}
				if (num == 569)
				{
					this.cpu43.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 570;
				}
				if (num == 570)
				{
					this.cpu43.ForeColor = Color.White;
					num = 571;
				}
				if (num == 571)
				{
					this.cpu43.Location = new Point(302, 307);
					num = 572;
				}
				if (num == 572)
				{
					this.cpu43.Name = "cpu43";
					num = 573;
				}
				if (num == 573)
				{
					this.cpu43.Size = new Size(80, 28);
					num = 574;
				}
				if (num == 574)
				{
					this.cpu43.TabIndex = 356;
					num = 575;
				}
				if (num == 575)
				{
					this.cpu43.Text = "CPU 43";
					num = 576;
				}
				if (num == 576)
				{
					this.cpu43.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 577;
				}
				if (num == 577)
				{
					this.cpu43.UncheckedState.BorderRadius = 0;
					num = 578;
				}
				if (num == 578)
				{
					this.cpu43.UncheckedState.BorderThickness = 0;
					num = 579;
				}
				if (num == 579)
				{
					this.cpu43.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 580;
				}
				if (num == 580)
				{
					this.cpu41.AutoSize = true;
					num = 581;
				}
				if (num == 581)
				{
					this.cpu41.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 582;
				}
				if (num == 582)
				{
					this.cpu41.CheckedState.BorderRadius = 0;
					num = 583;
				}
				if (num == 583)
				{
					this.cpu41.CheckedState.BorderThickness = 0;
					num = 584;
				}
				if (num == 584)
				{
					this.cpu41.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 585;
				}
				if (num == 585)
				{
					this.cpu41.Enabled = false;
					num = 586;
				}
				if (num == 586)
				{
					this.cpu41.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 587;
				}
				if (num == 587)
				{
					this.cpu41.ForeColor = Color.White;
					num = 588;
				}
				if (num == 588)
				{
					this.cpu41.Location = new Point(123, 307);
					num = 589;
				}
				if (num == 589)
				{
					this.cpu41.Name = "cpu41";
					num = 590;
				}
				if (num == 590)
				{
					this.cpu41.Size = new Size(77, 28);
					num = 591;
				}
				if (num == 591)
				{
					this.cpu41.TabIndex = 355;
					num = 592;
				}
				if (num == 592)
				{
					this.cpu41.Text = "CPU 41";
					num = 593;
				}
				if (num == 593)
				{
					this.cpu41.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 594;
				}
				if (num == 594)
				{
					this.cpu41.UncheckedState.BorderRadius = 0;
					num = 595;
				}
				if (num == 595)
				{
					this.cpu41.UncheckedState.BorderThickness = 0;
					num = 596;
				}
				if (num == 596)
				{
					this.cpu41.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 597;
				}
				if (num == 597)
				{
					this.cpu42.AutoSize = true;
					num = 598;
				}
				if (num == 598)
				{
					this.cpu42.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 599;
				}
				if (num == 599)
				{
					this.cpu42.CheckedState.BorderRadius = 0;
					num = 600;
				}
				if (num == 601)
				{
					this.cpu42.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 602;
				}
				if (num == 602)
				{
					this.cpu42.Enabled = false;
					num = 603;
				}
				if (num == 603)
				{
					this.cpu42.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 604;
				}
				if (num == 604)
				{
					this.cpu42.ForeColor = Color.White;
					num = 605;
				}
				if (num == 605)
				{
					this.cpu42.Location = new Point(211, 307);
					num = 606;
				}
				if (num == 606)
				{
					this.cpu42.Name = "cpu42";
					num = 607;
				}
				if (num == 607)
				{
					this.cpu42.Size = new Size(80, 28);
					num = 608;
				}
				if (num == 608)
				{
					this.cpu42.TabIndex = 354;
					num = 609;
				}
				if (num == 609)
				{
					this.cpu42.Text = "CPU 42";
					num = 610;
				}
				if (num == 610)
				{
					this.cpu42.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 611;
				}
				if (num == 611)
				{
					this.cpu42.UncheckedState.BorderRadius = 0;
					num = 612;
				}
				if (num == 612)
				{
					this.cpu42.UncheckedState.BorderThickness = 0;
					num = 613;
				}
				if (num == 613)
				{
					this.cpu42.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 614;
				}
				if (num == 614)
				{
					this.cpu40.AutoSize = true;
					num = 615;
				}
				if (num == 615)
				{
					this.cpu40.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 616;
				}
				if (num == 616)
				{
					this.cpu40.CheckedState.BorderRadius = 0;
					num = 617;
				}
				if (num == 617)
				{
					this.cpu40.CheckedState.BorderThickness = 0;
					num = 618;
				}
				if (num == 618)
				{
					this.cpu40.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 619;
				}
				if (num == 619)
				{
					this.cpu40.Enabled = false;
					num = 620;
				}
				if (num == 620)
				{
					this.cpu40.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 621;
				}
				if (num == 621)
				{
					this.cpu40.ForeColor = Color.White;
					num = 622;
				}
				if (num == 622)
				{
					this.cpu40.Location = new Point(31, 307);
					num = 623;
				}
				if (num == 623)
				{
					this.cpu40.Name = "cpu40";
					num = 624;
				}
				if (num == 624)
				{
					this.cpu40.Size = new Size(81, 28);
					num = 625;
				}
				if (num == 625)
				{
					this.cpu40.TabIndex = 353;
					num = 626;
				}
				if (num == 626)
				{
					this.cpu40.Text = "CPU 40";
					num = 627;
				}
				if (num == 627)
				{
					this.cpu40.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 628;
				}
				if (num == 628)
				{
					this.cpu40.UncheckedState.BorderRadius = 0;
					num = 629;
				}
				if (num == 629)
				{
					this.cpu40.UncheckedState.BorderThickness = 0;
					num = 630;
				}
				if (num == 630)
				{
					this.cpu40.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 631;
				}
				if (num == 631)
				{
					this.cpu39.AutoSize = true;
					num = 632;
				}
				if (num == 632)
				{
					this.cpu39.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 633;
				}
				if (num == 633)
				{
					this.cpu39.CheckedState.BorderRadius = 0;
					num = 634;
				}
				if (num == 634)
				{
					this.cpu39.CheckedState.BorderThickness = 0;
					num = 635;
				}
				if (num == 635)
				{
					this.cpu39.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 636;
				}
				if (num == 636)
				{
					this.cpu39.Enabled = false;
					num = 637;
				}
				if (num == 637)
				{
					this.cpu39.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 638;
				}
				if (num == 638)
				{
					this.cpu39.ForeColor = Color.White;
					num = 639;
				}
				if (num == 639)
				{
					this.cpu39.Location = new Point(846, 273);
					num = 640;
				}
				if (num == 640)
				{
					this.cpu39.Name = "cpu39";
					num = 641;
				}
				if (num == 641)
				{
					this.cpu39.Size = new Size(80, 28);
					num = 642;
				}
				if (num == 642)
				{
					this.cpu39.TabIndex = 352;
					num = 643;
				}
				if (num == 644)
				{
					this.cpu39.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 645;
				}
				if (num == 645)
				{
					this.cpu39.UncheckedState.BorderRadius = 0;
					num = 646;
				}
				if (num == 646)
				{
					this.cpu39.UncheckedState.BorderThickness = 0;
					num = 647;
				}
				if (num == 647)
				{
					this.cpu39.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 648;
				}
				if (num == 648)
				{
					this.cpu38.AutoSize = true;
					num = 649;
				}
				if (num == 649)
				{
					this.cpu38.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 650;
				}
				if (num == 650)
				{
					this.cpu38.CheckedState.BorderRadius = 0;
					num = 651;
				}
				if (num == 651)
				{
					this.cpu38.CheckedState.BorderThickness = 0;
					num = 652;
				}
				if (num == 652)
				{
					this.cpu38.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 653;
				}
				if (num == 653)
				{
					this.cpu38.Enabled = false;
					num = 654;
				}
				if (num == 654)
				{
					this.cpu38.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 655;
				}
				if (num == 655)
				{
					this.cpu38.ForeColor = Color.White;
					num = 656;
				}
				if (num == 656)
				{
					this.cpu38.Location = new Point(755, 273);
					num = 657;
				}
				if (num == 657)
				{
					this.cpu38.Name = "cpu38";
					num = 658;
				}
				if (num == 658)
				{
					this.cpu38.Size = new Size(80, 28);
					num = 659;
				}
				if (num == 659)
				{
					this.cpu38.TabIndex = 351;
					num = 660;
				}
				if (num == 660)
				{
					this.cpu38.Text = "CPU 38";
					num = 661;
				}
				if (num == 661)
				{
					this.cpu38.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 662;
				}
				if (num == 662)
				{
					this.cpu38.UncheckedState.BorderRadius = 0;
					num = 663;
				}
				if (num == 663)
				{
					this.cpu38.UncheckedState.BorderThickness = 0;
					num = 664;
				}
				if (num == 664)
				{
					this.cpu38.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 665;
				}
				if (num == 665)
				{
					this.cpu36.AutoSize = true;
					num = 666;
				}
				if (num == 666)
				{
					this.cpu36.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 667;
				}
				if (num == 667)
				{
					this.cpu36.CheckedState.BorderRadius = 0;
					num = 668;
				}
				if (num == 668)
				{
					this.cpu36.CheckedState.BorderThickness = 0;
					num = 669;
				}
				if (num == 669)
				{
					this.cpu36.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 670;
				}
				if (num == 670)
				{
					this.cpu36.Enabled = false;
					num = 671;
				}
				if (num == 671)
				{
					this.cpu36.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 672;
				}
				if (num == 672)
				{
					this.cpu36.ForeColor = Color.White;
					num = 673;
				}
				if (num == 673)
				{
					this.cpu36.Location = new Point(576, 273);
					num = 674;
				}
				if (num == 674)
				{
					this.cpu36.Name = "cpu36";
					num = 675;
				}
				if (num == 675)
				{
					this.cpu36.Size = new Size(80, 28);
					num = 676;
				}
				if (num == 676)
				{
					this.cpu36.TabIndex = 350;
					num = 677;
				}
				if (num == 677)
				{
					this.cpu36.Text = "CPU 36";
					num = 678;
				}
				if (num == 678)
				{
					this.cpu36.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 679;
				}
				if (num == 679)
				{
					this.cpu36.UncheckedState.BorderRadius = 0;
					num = 680;
				}
				if (num == 680)
				{
					this.cpu36.UncheckedState.BorderThickness = 0;
					num = 681;
				}
				if (num == 681)
				{
					this.cpu36.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 682;
				}
				if (num == 682)
				{
					this.cpu37.AutoSize = true;
					num = 683;
				}
				if (num == 683)
				{
					this.cpu37.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 684;
				}
				if (num == 684)
				{
					this.cpu37.CheckedState.BorderRadius = 0;
					num = 685;
				}
				if (num == 685)
				{
					this.cpu37.CheckedState.BorderThickness = 0;
					num = 686;
				}
				if (num == 687)
				{
					this.cpu37.Enabled = false;
					num = 688;
				}
				if (num == 688)
				{
					this.cpu37.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 689;
				}
				if (num == 689)
				{
					this.cpu37.ForeColor = Color.White;
					num = 690;
				}
				if (num == 690)
				{
					this.cpu37.Location = new Point(664, 273);
					num = 691;
				}
				if (num == 691)
				{
					this.cpu37.Name = "cpu37";
					num = 692;
				}
				if (num == 692)
				{
					this.cpu37.Size = new Size(79, 28);
					num = 693;
				}
				if (num == 693)
				{
					this.cpu37.TabIndex = 349;
					num = 694;
				}
				if (num == 694)
				{
					this.cpu37.Text = "CPU 37";
					num = 695;
				}
				if (num == 695)
				{
					this.cpu37.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 696;
				}
				if (num == 696)
				{
					this.cpu37.UncheckedState.BorderRadius = 0;
					num = 697;
				}
				if (num == 697)
				{
					this.cpu37.UncheckedState.BorderThickness = 0;
					num = 698;
				}
				if (num == 698)
				{
					this.cpu37.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 699;
				}
				if (num == 699)
				{
					this.cpu35.AutoSize = true;
					num = 700;
				}
				if (num == 700)
				{
					this.cpu35.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 701;
				}
				if (num == 701)
				{
					this.cpu35.CheckedState.BorderRadius = 0;
					num = 702;
				}
				if (num == 702)
				{
					this.cpu35.CheckedState.BorderThickness = 0;
					num = 703;
				}
				if (num == 703)
				{
					this.cpu35.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 704;
				}
				if (num == 704)
				{
					this.cpu35.Enabled = false;
					num = 705;
				}
				if (num == 705)
				{
					this.cpu35.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 706;
				}
				if (num == 706)
				{
					this.cpu35.ForeColor = Color.White;
					num = 707;
				}
				if (num == 707)
				{
					this.cpu35.Location = new Point(484, 273);
					num = 708;
				}
				if (num == 708)
				{
					this.cpu35.Name = "cpu35";
					num = 709;
				}
				if (num == 709)
				{
					this.cpu35.Size = new Size(80, 28);
					num = 710;
				}
				if (num == 710)
				{
					this.cpu35.TabIndex = 348;
					num = 711;
				}
				if (num == 711)
				{
					this.cpu35.Text = "CPU 35";
					num = 712;
				}
				if (num == 712)
				{
					this.cpu35.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 713;
				}
				if (num == 713)
				{
					this.cpu35.UncheckedState.BorderRadius = 0;
					num = 714;
				}
				if (num == 714)
				{
					this.cpu35.UncheckedState.BorderThickness = 0;
					num = 715;
				}
				if (num == 715)
				{
					this.cpu35.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 716;
				}
				if (num == 716)
				{
					this.cpu34.AutoSize = true;
					num = 717;
				}
				if (num == 717)
				{
					this.cpu34.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 718;
				}
				if (num == 718)
				{
					this.cpu34.CheckedState.BorderRadius = 0;
					num = 719;
				}
				if (num == 719)
				{
					this.cpu34.CheckedState.BorderThickness = 0;
					num = 720;
				}
				if (num == 720)
				{
					this.cpu34.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 721;
				}
				if (num == 721)
				{
					this.cpu34.Enabled = false;
					num = 722;
				}
				if (num == 722)
				{
					this.cpu34.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 723;
				}
				if (num == 723)
				{
					this.cpu34.ForeColor = Color.White;
					num = 724;
				}
				if (num == 724)
				{
					this.cpu34.Location = new Point(393, 273);
					num = 725;
				}
				if (num == 725)
				{
					this.cpu34.Name = "cpu34";
					num = 726;
				}
				if (num == 726)
				{
					this.cpu34.Size = new Size(80, 28);
					num = 727;
				}
				if (num == 727)
				{
					this.cpu34.TabIndex = 347;
					num = 728;
				}
				if (num == 728)
				{
					this.cpu34.Text = "CPU 34";
					num = 729;
				}
				if (num == 730)
				{
					this.cpu34.UncheckedState.BorderRadius = 0;
					num = 731;
				}
				if (num == 731)
				{
					this.cpu34.UncheckedState.BorderThickness = 0;
					num = 732;
				}
				if (num == 732)
				{
					this.cpu34.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 733;
				}
				if (num == 733)
				{
					this.cpu33.AutoSize = true;
					num = 734;
				}
				if (num == 734)
				{
					this.cpu33.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 735;
				}
				if (num == 735)
				{
					this.cpu33.CheckedState.BorderRadius = 0;
					num = 736;
				}
				if (num == 736)
				{
					this.cpu33.CheckedState.BorderThickness = 0;
					num = 737;
				}
				if (num == 737)
				{
					this.cpu33.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 738;
				}
				if (num == 738)
				{
					this.cpu33.Enabled = false;
					num = 739;
				}
				if (num == 739)
				{
					this.cpu33.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 740;
				}
				if (num == 740)
				{
					this.cpu33.ForeColor = Color.White;
					num = 741;
				}
				if (num == 741)
				{
					this.cpu33.Location = new Point(302, 273);
					num = 742;
				}
				if (num == 742)
				{
					this.cpu33.Name = "cpu33";
					num = 743;
				}
				if (num == 743)
				{
					this.cpu33.Size = new Size(80, 28);
					num = 744;
				}
				if (num == 744)
				{
					this.cpu33.TabIndex = 346;
					num = 745;
				}
				if (num == 745)
				{
					this.cpu33.Text = "CPU 33";
					num = 746;
				}
				if (num == 746)
				{
					this.cpu33.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 747;
				}
				if (num == 747)
				{
					this.cpu33.UncheckedState.BorderRadius = 0;
					num = 748;
				}
				if (num == 748)
				{
					this.cpu33.UncheckedState.BorderThickness = 0;
					num = 749;
				}
				if (num == 749)
				{
					this.cpu33.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 750;
				}
				if (num == 750)
				{
					this.cpu31.AutoSize = true;
					num = 751;
				}
				if (num == 751)
				{
					this.cpu31.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 752;
				}
				if (num == 752)
				{
					this.cpu31.CheckedState.BorderRadius = 0;
					num = 753;
				}
				if (num == 753)
				{
					this.cpu31.CheckedState.BorderThickness = 0;
					num = 754;
				}
				if (num == 754)
				{
					this.cpu31.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 755;
				}
				if (num == 755)
				{
					this.cpu31.Enabled = false;
					num = 756;
				}
				if (num == 756)
				{
					this.cpu31.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 757;
				}
				if (num == 757)
				{
					this.cpu31.ForeColor = Color.White;
					num = 758;
				}
				if (num == 758)
				{
					this.cpu31.Location = new Point(123, 273);
					num = 759;
				}
				if (num == 759)
				{
					this.cpu31.Name = "cpu31";
					num = 760;
				}
				if (num == 760)
				{
					this.cpu31.Size = new Size(77, 28);
					num = 761;
				}
				if (num == 761)
				{
					this.cpu31.TabIndex = 345;
					num = 762;
				}
				if (num == 762)
				{
					this.cpu31.Text = "CPU 31";
					num = 763;
				}
				if (num == 763)
				{
					this.cpu31.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 764;
				}
				if (num == 764)
				{
					this.cpu31.UncheckedState.BorderRadius = 0;
					num = 765;
				}
				if (num == 765)
				{
					this.cpu31.UncheckedState.BorderThickness = 0;
					num = 766;
				}
				if (num == 766)
				{
					this.cpu31.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 767;
				}
				if (num == 767)
				{
					this.cpu32.AutoSize = true;
					num = 768;
				}
				if (num == 768)
				{
					this.cpu32.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 769;
				}
				if (num == 769)
				{
					this.cpu32.CheckedState.BorderRadius = 0;
					num = 770;
				}
				if (num == 770)
				{
					this.cpu32.CheckedState.BorderThickness = 0;
					num = 771;
				}
				if (num == 772)
				{
					this.cpu32.Enabled = false;
					num = 773;
				}
				if (num == 773)
				{
					this.cpu32.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 774;
				}
				if (num == 774)
				{
					this.cpu32.ForeColor = Color.White;
					num = 775;
				}
				if (num == 775)
				{
					this.cpu32.Location = new Point(211, 273);
					num = 776;
				}
				if (num == 776)
				{
					this.cpu32.Name = "cpu32";
					num = 777;
				}
				if (num == 777)
				{
					this.cpu32.Size = new Size(80, 28);
					num = 778;
				}
				if (num == 778)
				{
					this.cpu32.TabIndex = 344;
					num = 779;
				}
				if (num == 779)
				{
					this.cpu32.Text = "CPU 32";
					num = 780;
				}
				if (num == 780)
				{
					this.cpu32.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 781;
				}
				if (num == 781)
				{
					this.cpu32.UncheckedState.BorderRadius = 0;
					num = 782;
				}
				if (num == 782)
				{
					this.cpu32.UncheckedState.BorderThickness = 0;
					num = 783;
				}
				if (num == 783)
				{
					this.cpu32.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 784;
				}
				if (num == 784)
				{
					this.cpu30.AutoSize = true;
					num = 785;
				}
				if (num == 785)
				{
					this.cpu30.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 786;
				}
				if (num == 786)
				{
					this.cpu30.CheckedState.BorderRadius = 0;
					num = 787;
				}
				if (num == 787)
				{
					this.cpu30.CheckedState.BorderThickness = 0;
					num = 788;
				}
				if (num == 788)
				{
					this.cpu30.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 789;
				}
				if (num == 789)
				{
					this.cpu30.Enabled = false;
					num = 790;
				}
				if (num == 790)
				{
					this.cpu30.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 791;
				}
				if (num == 791)
				{
					this.cpu30.ForeColor = Color.White;
					num = 792;
				}
				if (num == 792)
				{
					this.cpu30.Location = new Point(31, 273);
					num = 793;
				}
				if (num == 793)
				{
					this.cpu30.Name = "cpu30";
					num = 794;
				}
				if (num == 794)
				{
					this.cpu30.Size = new Size(81, 28);
					num = 795;
				}
				if (num == 795)
				{
					this.cpu30.TabIndex = 343;
					num = 796;
				}
				if (num == 796)
				{
					this.cpu30.Text = "CPU 30";
					num = 797;
				}
				if (num == 797)
				{
					this.cpu30.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 798;
				}
				if (num == 798)
				{
					this.cpu30.UncheckedState.BorderRadius = 0;
					num = 799;
				}
				if (num == 799)
				{
					this.cpu30.UncheckedState.BorderThickness = 0;
					num = 800;
				}
				if (num == 800)
				{
					this.cpu30.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 801;
				}
				if (num == 801)
				{
					this.cpu29.AutoSize = true;
					num = 802;
				}
				if (num == 802)
				{
					this.cpu29.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 803;
				}
				if (num == 803)
				{
					this.cpu29.CheckedState.BorderRadius = 0;
					num = 804;
				}
				if (num == 804)
				{
					this.cpu29.CheckedState.BorderThickness = 0;
					num = 805;
				}
				if (num == 805)
				{
					this.cpu29.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 806;
				}
				if (num == 806)
				{
					this.cpu29.Enabled = false;
					num = 807;
				}
				if (num == 807)
				{
					this.cpu29.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 808;
				}
				if (num == 808)
				{
					this.cpu29.ForeColor = Color.White;
					num = 809;
				}
				if (num == 809)
				{
					this.cpu29.Location = new Point(846, 239);
					num = 810;
				}
				if (num == 810)
				{
					this.cpu29.Name = "cpu29";
					num = 811;
				}
				if (num == 811)
				{
					this.cpu29.Size = new Size(80, 28);
					num = 812;
				}
				if (num == 812)
				{
					this.cpu29.TabIndex = 342;
					num = 813;
				}
				if (num == 813)
				{
					this.cpu29.Text = "CPU 29";
					num = 814;
				}
				if (num == 815)
				{
					this.cpu29.UncheckedState.BorderRadius = 0;
					num = 816;
				}
				if (num == 816)
				{
					this.cpu29.UncheckedState.BorderThickness = 0;
					num = 817;
				}
				if (num == 817)
				{
					this.cpu29.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 818;
				}
				if (num == 818)
				{
					this.cpu28.AutoSize = true;
					num = 819;
				}
				if (num == 819)
				{
					this.cpu28.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 820;
				}
				if (num == 820)
				{
					this.cpu28.CheckedState.BorderRadius = 0;
					num = 821;
				}
				if (num == 821)
				{
					this.cpu28.CheckedState.BorderThickness = 0;
					num = 822;
				}
				if (num == 822)
				{
					this.cpu28.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 823;
				}
				if (num == 823)
				{
					this.cpu28.Enabled = false;
					num = 824;
				}
				if (num == 824)
				{
					this.cpu28.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 825;
				}
				if (num == 825)
				{
					this.cpu28.ForeColor = Color.White;
					num = 826;
				}
				if (num == 826)
				{
					this.cpu28.Location = new Point(755, 239);
					num = 827;
				}
				if (num == 827)
				{
					this.cpu28.Name = "cpu28";
					num = 828;
				}
				if (num == 828)
				{
					this.cpu28.Size = new Size(80, 28);
					num = 829;
				}
				if (num == 829)
				{
					this.cpu28.TabIndex = 341;
					num = 830;
				}
				if (num == 830)
				{
					this.cpu28.Text = "CPU 28";
					num = 831;
				}
				if (num == 831)
				{
					this.cpu28.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 832;
				}
				if (num == 832)
				{
					this.cpu28.UncheckedState.BorderRadius = 0;
					num = 833;
				}
				if (num == 833)
				{
					this.cpu28.UncheckedState.BorderThickness = 0;
					num = 834;
				}
				if (num == 834)
				{
					this.cpu28.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 835;
				}
				if (num == 835)
				{
					this.cpu26.AutoSize = true;
					num = 836;
				}
				if (num == 836)
				{
					this.cpu26.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 837;
				}
				if (num == 837)
				{
					this.cpu26.CheckedState.BorderRadius = 0;
					num = 838;
				}
				if (num == 838)
				{
					this.cpu26.CheckedState.BorderThickness = 0;
					num = 839;
				}
				if (num == 839)
				{
					this.cpu26.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 840;
				}
				if (num == 840)
				{
					this.cpu26.Enabled = false;
					num = 841;
				}
				if (num == 841)
				{
					this.cpu26.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 842;
				}
				if (num == 842)
				{
					this.cpu26.ForeColor = Color.White;
					num = 843;
				}
				if (num == 843)
				{
					this.cpu26.Location = new Point(576, 239);
					num = 844;
				}
				if (num == 844)
				{
					this.cpu26.Name = "cpu26";
					num = 845;
				}
				if (num == 845)
				{
					this.cpu26.Size = new Size(80, 28);
					num = 846;
				}
				if (num == 846)
				{
					this.cpu26.TabIndex = 340;
					num = 847;
				}
				if (num == 847)
				{
					this.cpu26.Text = "CPU 26";
					num = 848;
				}
				if (num == 848)
				{
					this.cpu26.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 849;
				}
				if (num == 849)
				{
					this.cpu26.UncheckedState.BorderRadius = 0;
					num = 850;
				}
				if (num == 850)
				{
					this.cpu26.UncheckedState.BorderThickness = 0;
					num = 851;
				}
				if (num == 851)
				{
					this.cpu26.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 852;
				}
				if (num == 852)
				{
					this.cpu27.AutoSize = true;
					num = 853;
				}
				if (num == 853)
				{
					this.cpu27.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 854;
				}
				if (num == 854)
				{
					this.cpu27.CheckedState.BorderRadius = 0;
					num = 855;
				}
				if (num == 855)
				{
					this.cpu27.CheckedState.BorderThickness = 0;
					num = 856;
				}
				if (num == 856)
				{
					this.cpu27.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 857;
				}
				if (num == 858)
				{
					this.cpu27.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 859;
				}
				if (num == 859)
				{
					this.cpu27.ForeColor = Color.White;
					num = 860;
				}
				if (num == 860)
				{
					this.cpu27.Location = new Point(664, 239);
					num = 861;
				}
				if (num == 861)
				{
					this.cpu27.Name = "cpu27";
					num = 862;
				}
				if (num == 862)
				{
					this.cpu27.Size = new Size(79, 28);
					num = 863;
				}
				if (num == 863)
				{
					this.cpu27.TabIndex = 339;
					num = 864;
				}
				if (num == 864)
				{
					this.cpu27.Text = "CPU 27";
					num = 865;
				}
				if (num == 865)
				{
					this.cpu27.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 866;
				}
				if (num == 866)
				{
					this.cpu27.UncheckedState.BorderRadius = 0;
					num = 867;
				}
				if (num == 867)
				{
					this.cpu27.UncheckedState.BorderThickness = 0;
					num = 868;
				}
				if (num == 868)
				{
					this.cpu27.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 869;
				}
				if (num == 869)
				{
					this.cpu25.AutoSize = true;
					num = 870;
				}
				if (num == 870)
				{
					this.cpu25.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 871;
				}
				if (num == 871)
				{
					this.cpu25.CheckedState.BorderRadius = 0;
					num = 872;
				}
				if (num == 872)
				{
					this.cpu25.CheckedState.BorderThickness = 0;
					num = 873;
				}
				if (num == 873)
				{
					this.cpu25.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 874;
				}
				if (num == 874)
				{
					this.cpu25.Enabled = false;
					num = 875;
				}
				if (num == 875)
				{
					this.cpu25.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 876;
				}
				if (num == 876)
				{
					this.cpu25.ForeColor = Color.White;
					num = 877;
				}
				if (num == 877)
				{
					this.cpu25.Location = new Point(484, 239);
					num = 878;
				}
				if (num == 878)
				{
					this.cpu25.Name = "cpu25";
					num = 879;
				}
				if (num == 879)
				{
					this.cpu25.Size = new Size(80, 28);
					num = 880;
				}
				if (num == 880)
				{
					this.cpu25.TabIndex = 338;
					num = 881;
				}
				if (num == 881)
				{
					this.cpu25.Text = "CPU 25";
					num = 882;
				}
				if (num == 882)
				{
					this.cpu25.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 883;
				}
				if (num == 883)
				{
					this.cpu25.UncheckedState.BorderRadius = 0;
					num = 884;
				}
				if (num == 884)
				{
					this.cpu25.UncheckedState.BorderThickness = 0;
					num = 885;
				}
				if (num == 885)
				{
					this.cpu25.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 886;
				}
				if (num == 886)
				{
					this.cpu24.AutoSize = true;
					num = 887;
				}
				if (num == 887)
				{
					this.cpu24.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 888;
				}
				if (num == 888)
				{
					this.cpu24.CheckedState.BorderRadius = 0;
					num = 889;
				}
				if (num == 889)
				{
					this.cpu24.CheckedState.BorderThickness = 0;
					num = 890;
				}
				if (num == 890)
				{
					this.cpu24.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 891;
				}
				if (num == 891)
				{
					this.cpu24.Enabled = false;
					num = 892;
				}
				if (num == 892)
				{
					this.cpu24.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 893;
				}
				if (num == 893)
				{
					this.cpu24.ForeColor = Color.White;
					num = 894;
				}
				if (num == 894)
				{
					this.cpu24.Location = new Point(393, 239);
					num = 895;
				}
				if (num == 895)
				{
					this.cpu24.Name = "cpu24";
					num = 896;
				}
				if (num == 896)
				{
					this.cpu24.Size = new Size(80, 28);
					num = 897;
				}
				if (num == 897)
				{
					this.cpu24.TabIndex = 337;
					num = 898;
				}
				if (num == 898)
				{
					this.cpu24.Text = "CPU 24";
					num = 899;
				}
				if (num == 899)
				{
					this.cpu24.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 900;
				}
				if (num == 901)
				{
					this.cpu24.UncheckedState.BorderThickness = 0;
					num = 902;
				}
				if (num == 902)
				{
					this.cpu24.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 903;
				}
				if (num == 903)
				{
					this.cpu23.AutoSize = true;
					num = 904;
				}
				if (num == 904)
				{
					this.cpu23.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 905;
				}
				if (num == 905)
				{
					this.cpu23.CheckedState.BorderRadius = 0;
					num = 906;
				}
				if (num == 906)
				{
					this.cpu23.CheckedState.BorderThickness = 0;
					num = 907;
				}
				if (num == 907)
				{
					this.cpu23.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 908;
				}
				if (num == 908)
				{
					this.cpu23.Enabled = false;
					num = 909;
				}
				if (num == 909)
				{
					this.cpu23.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 910;
				}
				if (num == 910)
				{
					this.cpu23.ForeColor = Color.White;
					num = 911;
				}
				if (num == 911)
				{
					this.cpu23.Location = new Point(302, 239);
					num = 912;
				}
				if (num == 912)
				{
					this.cpu23.Name = "cpu23";
					num = 913;
				}
				if (num == 913)
				{
					this.cpu23.Size = new Size(80, 28);
					num = 914;
				}
				if (num == 914)
				{
					this.cpu23.TabIndex = 336;
					num = 915;
				}
				if (num == 915)
				{
					this.cpu23.Text = "CPU 23";
					num = 916;
				}
				if (num == 916)
				{
					this.cpu23.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 917;
				}
				if (num == 917)
				{
					this.cpu23.UncheckedState.BorderRadius = 0;
					num = 918;
				}
				if (num == 918)
				{
					this.cpu23.UncheckedState.BorderThickness = 0;
					num = 919;
				}
				if (num == 919)
				{
					this.cpu23.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 920;
				}
				if (num == 920)
				{
					this.cpu21.AutoSize = true;
					num = 921;
				}
				if (num == 921)
				{
					this.cpu21.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 922;
				}
				if (num == 922)
				{
					this.cpu21.CheckedState.BorderRadius = 0;
					num = 923;
				}
				if (num == 923)
				{
					this.cpu21.CheckedState.BorderThickness = 0;
					num = 924;
				}
				if (num == 924)
				{
					this.cpu21.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 925;
				}
				if (num == 925)
				{
					this.cpu21.Enabled = false;
					num = 926;
				}
				if (num == 926)
				{
					this.cpu21.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 927;
				}
				if (num == 927)
				{
					this.cpu21.ForeColor = Color.White;
					num = 928;
				}
				if (num == 928)
				{
					this.cpu21.Location = new Point(123, 239);
					num = 929;
				}
				if (num == 929)
				{
					this.cpu21.Name = "cpu21";
					num = 930;
				}
				if (num == 930)
				{
					this.cpu21.Size = new Size(77, 28);
					num = 931;
				}
				if (num == 931)
				{
					this.cpu21.TabIndex = 335;
					num = 932;
				}
				if (num == 932)
				{
					this.cpu21.Text = "CPU 21";
					num = 933;
				}
				if (num == 933)
				{
					this.cpu21.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 934;
				}
				if (num == 934)
				{
					this.cpu21.UncheckedState.BorderRadius = 0;
					num = 935;
				}
				if (num == 935)
				{
					this.cpu21.UncheckedState.BorderThickness = 0;
					num = 936;
				}
				if (num == 936)
				{
					this.cpu21.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 937;
				}
				if (num == 937)
				{
					this.cpu22.AutoSize = true;
					num = 938;
				}
				if (num == 938)
				{
					this.cpu22.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 939;
				}
				if (num == 939)
				{
					this.cpu22.CheckedState.BorderRadius = 0;
					num = 940;
				}
				if (num == 940)
				{
					this.cpu22.CheckedState.BorderThickness = 0;
					num = 941;
				}
				if (num == 941)
				{
					this.cpu22.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 942;
				}
				if (num == 942)
				{
					this.cpu22.Enabled = false;
					num = 943;
				}
				if (num == 944)
				{
					this.cpu22.ForeColor = Color.White;
					num = 945;
				}
				if (num == 945)
				{
					this.cpu22.Location = new Point(211, 239);
					num = 946;
				}
				if (num == 946)
				{
					this.cpu22.Name = "cpu22";
					num = 947;
				}
				if (num == 947)
				{
					this.cpu22.Size = new Size(80, 28);
					num = 948;
				}
				if (num == 948)
				{
					this.cpu22.TabIndex = 334;
					num = 949;
				}
				if (num == 949)
				{
					this.cpu22.Text = "CPU 22";
					num = 950;
				}
				if (num == 950)
				{
					this.cpu22.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 951;
				}
				if (num == 951)
				{
					this.cpu22.UncheckedState.BorderRadius = 0;
					num = 952;
				}
				if (num == 952)
				{
					this.cpu22.UncheckedState.BorderThickness = 0;
					num = 953;
				}
				if (num == 953)
				{
					this.cpu22.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 954;
				}
				if (num == 954)
				{
					this.cpu20.AutoSize = true;
					num = 955;
				}
				if (num == 955)
				{
					this.cpu20.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 956;
				}
				if (num == 956)
				{
					this.cpu20.CheckedState.BorderRadius = 0;
					num = 957;
				}
				if (num == 957)
				{
					this.cpu20.CheckedState.BorderThickness = 0;
					num = 958;
				}
				if (num == 958)
				{
					this.cpu20.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 959;
				}
				if (num == 959)
				{
					this.cpu20.Enabled = false;
					num = 960;
				}
				if (num == 960)
				{
					this.cpu20.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 961;
				}
				if (num == 961)
				{
					this.cpu20.ForeColor = Color.White;
					num = 962;
				}
				if (num == 962)
				{
					this.cpu20.Location = new Point(31, 239);
					num = 963;
				}
				if (num == 963)
				{
					this.cpu20.Name = "cpu20";
					num = 964;
				}
				if (num == 964)
				{
					this.cpu20.Size = new Size(81, 28);
					num = 965;
				}
				if (num == 965)
				{
					this.cpu20.TabIndex = 333;
					num = 966;
				}
				if (num == 966)
				{
					this.cpu20.Text = "CPU 20";
					num = 967;
				}
				if (num == 967)
				{
					this.cpu20.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 968;
				}
				if (num == 968)
				{
					this.cpu20.UncheckedState.BorderRadius = 0;
					num = 969;
				}
				if (num == 969)
				{
					this.cpu20.UncheckedState.BorderThickness = 0;
					num = 970;
				}
				if (num == 970)
				{
					this.cpu20.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 971;
				}
				if (num == 971)
				{
					this.cpu19.AutoSize = true;
					num = 972;
				}
				if (num == 972)
				{
					this.cpu19.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 973;
				}
				if (num == 973)
				{
					this.cpu19.CheckedState.BorderRadius = 0;
					num = 974;
				}
				if (num == 974)
				{
					this.cpu19.CheckedState.BorderThickness = 0;
					num = 975;
				}
				if (num == 975)
				{
					this.cpu19.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 976;
				}
				if (num == 976)
				{
					this.cpu19.Enabled = false;
					num = 977;
				}
				if (num == 977)
				{
					this.cpu19.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 978;
				}
				if (num == 978)
				{
					this.cpu19.ForeColor = Color.White;
					num = 979;
				}
				if (num == 979)
				{
					this.cpu19.Location = new Point(846, 205);
					num = 980;
				}
				if (num == 980)
				{
					this.cpu19.Name = "cpu19";
					num = 981;
				}
				if (num == 981)
				{
					this.cpu19.Size = new Size(77, 28);
					num = 982;
				}
				if (num == 982)
				{
					this.cpu19.TabIndex = 332;
					num = 983;
				}
				if (num == 983)
				{
					this.cpu19.Text = "CPU 19";
					num = 984;
				}
				if (num == 984)
				{
					this.cpu19.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 985;
				}
				if (num == 985)
				{
					this.cpu19.UncheckedState.BorderRadius = 0;
					num = 986;
				}
				if (num == 987)
				{
					this.cpu19.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 988;
				}
				if (num == 988)
				{
					this.cpu18.AutoSize = true;
					num = 989;
				}
				if (num == 989)
				{
					this.cpu18.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 990;
				}
				if (num == 990)
				{
					this.cpu18.CheckedState.BorderRadius = 0;
					num = 991;
				}
				if (num == 991)
				{
					this.cpu18.CheckedState.BorderThickness = 0;
					num = 992;
				}
				if (num == 992)
				{
					this.cpu18.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 993;
				}
				if (num == 993)
				{
					this.cpu18.Enabled = false;
					num = 994;
				}
				if (num == 994)
				{
					this.cpu18.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 995;
				}
				if (num == 995)
				{
					this.cpu18.ForeColor = Color.White;
					num = 996;
				}
				if (num == 996)
				{
					this.cpu18.Location = new Point(755, 205);
					num = 997;
				}
				if (num == 997)
				{
					this.cpu18.Name = "cpu18";
					num = 998;
				}
				if (num == 998)
				{
					this.cpu18.Size = new Size(77, 28);
					num = 999;
				}
				if (num == 999)
				{
					this.cpu18.TabIndex = 331;
					num = 1000;
				}
				if (num == 1000)
				{
					this.cpu18.Text = "CPU 18";
					num = 1001;
				}
				if (num == 1001)
				{
					this.cpu18.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1002;
				}
				if (num == 1002)
				{
					this.cpu18.UncheckedState.BorderRadius = 0;
					num = 1003;
				}
				if (num == 1003)
				{
					this.cpu18.UncheckedState.BorderThickness = 0;
					num = 1004;
				}
				if (num == 1004)
				{
					this.cpu18.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1005;
				}
				if (num == 1005)
				{
					this.cpu16.AutoSize = true;
					num = 1006;
				}
				if (num == 1006)
				{
					this.cpu16.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1007;
				}
				if (num == 1007)
				{
					this.cpu16.CheckedState.BorderRadius = 0;
					num = 1008;
				}
				if (num == 1008)
				{
					this.cpu16.CheckedState.BorderThickness = 0;
					num = 1009;
				}
				if (num == 1009)
				{
					this.cpu16.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1010;
				}
				if (num == 1010)
				{
					this.cpu16.Enabled = false;
					num = 1011;
				}
				if (num == 1011)
				{
					this.cpu16.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1012;
				}
				if (num == 1012)
				{
					this.cpu16.ForeColor = Color.White;
					num = 1013;
				}
				if (num == 1013)
				{
					this.cpu16.Location = new Point(576, 205);
					num = 1014;
				}
				if (num == 1014)
				{
					this.cpu16.Name = "cpu16";
					num = 1015;
				}
				if (num == 1015)
				{
					this.cpu16.Size = new Size(77, 28);
					num = 1016;
				}
				if (num == 1016)
				{
					this.cpu16.TabIndex = 330;
					num = 1017;
				}
				if (num == 1017)
				{
					this.cpu16.Text = "CPU 16";
					num = 1018;
				}
				if (num == 1018)
				{
					this.cpu16.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1019;
				}
				if (num == 1019)
				{
					this.cpu16.UncheckedState.BorderRadius = 0;
					num = 1020;
				}
				if (num == 1020)
				{
					this.cpu16.UncheckedState.BorderThickness = 0;
					num = 1021;
				}
				if (num == 1021)
				{
					this.cpu16.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1022;
				}
				if (num == 1022)
				{
					this.cpu17.AutoSize = true;
					num = 1023;
				}
				if (num == 1023)
				{
					this.cpu17.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1024;
				}
				if (num == 1024)
				{
					this.cpu17.CheckedState.BorderRadius = 0;
					num = 1025;
				}
				if (num == 1025)
				{
					this.cpu17.CheckedState.BorderThickness = 0;
					num = 1026;
				}
				if (num == 1026)
				{
					this.cpu17.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1027;
				}
				if (num == 1027)
				{
					this.cpu17.Enabled = false;
					num = 1028;
				}
				if (num == 1028)
				{
					this.cpu17.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1029;
				}
				if (num == 1030)
				{
					this.cpu17.Location = new Point(664, 205);
					num = 1031;
				}
				if (num == 1031)
				{
					this.cpu17.Name = "cpu17";
					num = 1032;
				}
				if (num == 1032)
				{
					this.cpu17.Size = new Size(76, 28);
					num = 1033;
				}
				if (num == 1033)
				{
					this.cpu17.TabIndex = 329;
					num = 1034;
				}
				if (num == 1034)
				{
					this.cpu17.Text = "CPU 17";
					num = 1035;
				}
				if (num == 1035)
				{
					this.cpu17.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1036;
				}
				if (num == 1036)
				{
					this.cpu17.UncheckedState.BorderRadius = 0;
					num = 1037;
				}
				if (num == 1037)
				{
					this.cpu17.UncheckedState.BorderThickness = 0;
					num = 1038;
				}
				if (num == 1038)
				{
					this.cpu17.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1039;
				}
				if (num == 1039)
				{
					this.cpu15.AutoSize = true;
					num = 1040;
				}
				if (num == 1040)
				{
					this.cpu15.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1041;
				}
				if (num == 1041)
				{
					this.cpu15.CheckedState.BorderRadius = 0;
					num = 1042;
				}
				if (num == 1042)
				{
					this.cpu15.CheckedState.BorderThickness = 0;
					num = 1043;
				}
				if (num == 1043)
				{
					this.cpu15.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1044;
				}
				if (num == 1044)
				{
					this.cpu15.Enabled = false;
					num = 1045;
				}
				if (num == 1045)
				{
					this.cpu15.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1046;
				}
				if (num == 1046)
				{
					this.cpu15.ForeColor = Color.White;
					num = 1047;
				}
				if (num == 1047)
				{
					this.cpu15.Location = new Point(484, 205);
					num = 1048;
				}
				if (num == 1048)
				{
					this.cpu15.Name = "cpu15";
					num = 1049;
				}
				if (num == 1049)
				{
					this.cpu15.Size = new Size(77, 28);
					num = 1050;
				}
				if (num == 1050)
				{
					this.cpu15.TabIndex = 328;
					num = 1051;
				}
				if (num == 1051)
				{
					this.cpu15.Text = "CPU 15";
					num = 1052;
				}
				if (num == 1052)
				{
					this.cpu15.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1053;
				}
				if (num == 1053)
				{
					this.cpu15.UncheckedState.BorderRadius = 0;
					num = 1054;
				}
				if (num == 1054)
				{
					this.cpu15.UncheckedState.BorderThickness = 0;
					num = 1055;
				}
				if (num == 1055)
				{
					this.cpu15.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1056;
				}
				if (num == 1056)
				{
					this.cpu14.AutoSize = true;
					num = 1057;
				}
				if (num == 1057)
				{
					this.cpu14.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1058;
				}
				if (num == 1058)
				{
					this.cpu14.CheckedState.BorderRadius = 0;
					num = 1059;
				}
				if (num == 1059)
				{
					this.cpu14.CheckedState.BorderThickness = 0;
					num = 1060;
				}
				if (num == 1060)
				{
					this.cpu14.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1061;
				}
				if (num == 1061)
				{
					this.cpu14.Enabled = false;
					num = 1062;
				}
				if (num == 1062)
				{
					this.cpu14.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1063;
				}
				if (num == 1063)
				{
					this.cpu14.ForeColor = Color.White;
					num = 1064;
				}
				if (num == 1064)
				{
					this.cpu14.Location = new Point(393, 205);
					num = 1065;
				}
				if (num == 1065)
				{
					this.cpu14.Name = "cpu14";
					num = 1066;
				}
				if (num == 1066)
				{
					this.cpu14.Size = new Size(77, 28);
					num = 1067;
				}
				if (num == 1067)
				{
					this.cpu14.TabIndex = 327;
					num = 1068;
				}
				if (num == 1068)
				{
					this.cpu14.Text = "CPU 14";
					num = 1069;
				}
				if (num == 1069)
				{
					this.cpu14.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1070;
				}
				if (num == 1070)
				{
					this.cpu14.UncheckedState.BorderRadius = 0;
					num = 1071;
				}
				if (num == 1071)
				{
					this.cpu14.UncheckedState.BorderThickness = 0;
					num = 1072;
				}
				if (num == 1073)
				{
					this.cpu13.AutoSize = true;
					num = 1074;
				}
				if (num == 1074)
				{
					this.cpu13.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1075;
				}
				if (num == 1075)
				{
					this.cpu13.CheckedState.BorderRadius = 0;
					num = 1076;
				}
				if (num == 1076)
				{
					this.cpu13.CheckedState.BorderThickness = 0;
					num = 1077;
				}
				if (num == 1077)
				{
					this.cpu13.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1078;
				}
				if (num == 1078)
				{
					this.cpu13.Enabled = false;
					num = 1079;
				}
				if (num == 1079)
				{
					this.cpu13.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1080;
				}
				if (num == 1080)
				{
					this.cpu13.ForeColor = Color.White;
					num = 1081;
				}
				if (num == 1081)
				{
					this.cpu13.Location = new Point(302, 205);
					num = 1082;
				}
				if (num == 1082)
				{
					this.cpu13.Name = "cpu13";
					num = 1083;
				}
				if (num == 1083)
				{
					this.cpu13.Size = new Size(77, 28);
					num = 1084;
				}
				if (num == 1084)
				{
					this.cpu13.TabIndex = 326;
					num = 1085;
				}
				if (num == 1085)
				{
					this.cpu13.Text = "CPU 13";
					num = 1086;
				}
				if (num == 1086)
				{
					this.cpu13.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1087;
				}
				if (num == 1087)
				{
					this.cpu13.UncheckedState.BorderRadius = 0;
					num = 1088;
				}
				if (num == 1088)
				{
					this.cpu13.UncheckedState.BorderThickness = 0;
					num = 1089;
				}
				if (num == 1089)
				{
					this.cpu13.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1090;
				}
				if (num == 1090)
				{
					this.cpu11.AutoSize = true;
					num = 1091;
				}
				if (num == 1091)
				{
					this.cpu11.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1092;
				}
				if (num == 1092)
				{
					this.cpu11.CheckedState.BorderRadius = 0;
					num = 1093;
				}
				if (num == 1093)
				{
					this.cpu11.CheckedState.BorderThickness = 0;
					num = 1094;
				}
				if (num == 1094)
				{
					this.cpu11.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1095;
				}
				if (num == 1095)
				{
					this.cpu11.Enabled = false;
					num = 1096;
				}
				if (num == 1096)
				{
					this.cpu11.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1097;
				}
				if (num == 1097)
				{
					this.cpu11.ForeColor = Color.White;
					num = 1098;
				}
				if (num == 1098)
				{
					this.cpu11.Location = new Point(123, 205);
					num = 1099;
				}
				if (num == 1099)
				{
					this.cpu11.Name = "cpu11";
					num = 1100;
				}
				if (num == 1100)
				{
					this.cpu11.Size = new Size(74, 28);
					num = 1101;
				}
				if (num == 1101)
				{
					this.cpu11.TabIndex = 325;
					num = 1102;
				}
				if (num == 1102)
				{
					this.cpu11.Text = "CPU 11";
					num = 1103;
				}
				if (num == 1103)
				{
					this.cpu11.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1104;
				}
				if (num == 1104)
				{
					this.cpu11.UncheckedState.BorderRadius = 0;
					num = 1105;
				}
				if (num == 1105)
				{
					this.cpu11.UncheckedState.BorderThickness = 0;
					num = 1106;
				}
				if (num == 1106)
				{
					this.cpu11.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1107;
				}
				if (num == 1107)
				{
					this.cpu12.AutoSize = true;
					num = 1108;
				}
				if (num == 1108)
				{
					this.cpu12.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1109;
				}
				if (num == 1109)
				{
					this.cpu12.CheckedState.BorderRadius = 0;
					num = 1110;
				}
				if (num == 1110)
				{
					this.cpu12.CheckedState.BorderThickness = 0;
					num = 1111;
				}
				if (num == 1111)
				{
					this.cpu12.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1112;
				}
				if (num == 1112)
				{
					this.cpu12.Enabled = false;
					num = 1113;
				}
				if (num == 1113)
				{
					this.cpu12.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1114;
				}
				if (num == 1114)
				{
					this.cpu12.ForeColor = Color.White;
					num = 1115;
				}
				if (num == 1116)
				{
					this.cpu12.Name = "cpu12";
					num = 1117;
				}
				if (num == 1117)
				{
					this.cpu12.Size = new Size(77, 28);
					num = 1118;
				}
				if (num == 1118)
				{
					this.cpu12.TabIndex = 324;
					num = 1119;
				}
				if (num == 1119)
				{
					this.cpu12.Text = "CPU 12";
					num = 1120;
				}
				if (num == 1120)
				{
					this.cpu12.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1121;
				}
				if (num == 1121)
				{
					this.cpu12.UncheckedState.BorderRadius = 0;
					num = 1122;
				}
				if (num == 1122)
				{
					this.cpu12.UncheckedState.BorderThickness = 0;
					num = 1123;
				}
				if (num == 1123)
				{
					this.cpu12.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1124;
				}
				if (num == 1124)
				{
					this.cpu10.AutoSize = true;
					num = 1125;
				}
				if (num == 1125)
				{
					this.cpu10.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1126;
				}
				if (num == 1126)
				{
					this.cpu10.CheckedState.BorderRadius = 0;
					num = 1127;
				}
				if (num == 1127)
				{
					this.cpu10.CheckedState.BorderThickness = 0;
					num = 1128;
				}
				if (num == 1128)
				{
					this.cpu10.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1129;
				}
				if (num == 1129)
				{
					this.cpu10.Enabled = false;
					num = 1130;
				}
				if (num == 1130)
				{
					this.cpu10.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1131;
				}
				if (num == 1131)
				{
					this.cpu10.ForeColor = Color.White;
					num = 1132;
				}
				if (num == 1132)
				{
					this.cpu10.Location = new Point(31, 205);
					num = 1133;
				}
				if (num == 1133)
				{
					this.cpu10.Name = "cpu10";
					num = 1134;
				}
				if (num == 1134)
				{
					this.cpu10.Size = new Size(78, 28);
					num = 1135;
				}
				if (num == 1135)
				{
					this.cpu10.TabIndex = 323;
					num = 1136;
				}
				if (num == 1136)
				{
					this.cpu10.Text = "CPU 10";
					num = 1137;
				}
				if (num == 1137)
				{
					this.cpu10.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1138;
				}
				if (num == 1138)
				{
					this.cpu10.UncheckedState.BorderRadius = 0;
					num = 1139;
				}
				if (num == 1139)
				{
					this.cpu10.UncheckedState.BorderThickness = 0;
					num = 1140;
				}
				if (num == 1140)
				{
					this.cpu10.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1141;
				}
				if (num == 1141)
				{
					this.cpu9.AutoSize = true;
					num = 1142;
				}
				if (num == 1142)
				{
					this.cpu9.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1143;
				}
				if (num == 1143)
				{
					this.cpu9.CheckedState.BorderRadius = 0;
					num = 1144;
				}
				if (num == 1144)
				{
					this.cpu9.CheckedState.BorderThickness = 0;
					num = 1145;
				}
				if (num == 1145)
				{
					this.cpu9.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1146;
				}
				if (num == 1146)
				{
					this.cpu9.Enabled = false;
					num = 1147;
				}
				if (num == 1147)
				{
					this.cpu9.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1148;
				}
				if (num == 1148)
				{
					this.cpu9.ForeColor = Color.White;
					num = 1149;
				}
				if (num == 1149)
				{
					this.cpu9.Location = new Point(846, 171);
					num = 1150;
				}
				if (num == 1150)
				{
					this.cpu9.Name = "cpu9";
					num = 1151;
				}
				if (num == 1151)
				{
					this.cpu9.Size = new Size(72, 28);
					num = 1152;
				}
				if (num == 1152)
				{
					this.cpu9.TabIndex = 322;
					num = 1153;
				}
				if (num == 1153)
				{
					this.cpu9.Text = "CPU 9";
					num = 1154;
				}
				if (num == 1154)
				{
					this.cpu9.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1155;
				}
				if (num == 1155)
				{
					this.cpu9.UncheckedState.BorderRadius = 0;
					num = 1156;
				}
				if (num == 1156)
				{
					this.cpu9.UncheckedState.BorderThickness = 0;
					num = 1157;
				}
				if (num == 1158)
				{
					this.cpu8.AutoSize = true;
					num = 1159;
				}
				if (num == 1159)
				{
					this.cpu8.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1160;
				}
				if (num == 1160)
				{
					this.cpu8.CheckedState.BorderRadius = 0;
					num = 1161;
				}
				if (num == 1161)
				{
					this.cpu8.CheckedState.BorderThickness = 0;
					num = 1162;
				}
				if (num == 1162)
				{
					this.cpu8.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1163;
				}
				if (num == 1163)
				{
					this.cpu8.Enabled = false;
					num = 1164;
				}
				if (num == 1164)
				{
					this.cpu8.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1165;
				}
				if (num == 1165)
				{
					this.cpu8.ForeColor = Color.White;
					num = 1166;
				}
				if (num == 1166)
				{
					this.cpu8.Location = new Point(755, 171);
					num = 1167;
				}
				if (num == 1167)
				{
					this.cpu8.Name = "cpu8";
					num = 1168;
				}
				if (num == 1168)
				{
					this.cpu8.Size = new Size(72, 28);
					num = 1169;
				}
				if (num == 1169)
				{
					this.cpu8.TabIndex = 321;
					num = 1170;
				}
				if (num == 1170)
				{
					this.cpu8.Text = "CPU 8";
					num = 1171;
				}
				if (num == 1171)
				{
					this.cpu8.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1172;
				}
				if (num == 1172)
				{
					this.cpu8.UncheckedState.BorderRadius = 0;
					num = 1173;
				}
				if (num == 1173)
				{
					this.cpu8.UncheckedState.BorderThickness = 0;
					num = 1174;
				}
				if (num == 1174)
				{
					this.cpu8.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1175;
				}
				if (num == 1175)
				{
					this.cpu6.AutoSize = true;
					num = 1176;
				}
				if (num == 1176)
				{
					this.cpu6.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1177;
				}
				if (num == 1177)
				{
					this.cpu6.CheckedState.BorderRadius = 0;
					num = 1178;
				}
				if (num == 1178)
				{
					this.cpu6.CheckedState.BorderThickness = 0;
					num = 1179;
				}
				if (num == 1179)
				{
					this.cpu6.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1180;
				}
				if (num == 1180)
				{
					this.cpu6.Enabled = false;
					num = 1181;
				}
				if (num == 1181)
				{
					this.cpu6.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1182;
				}
				if (num == 1182)
				{
					this.cpu6.ForeColor = Color.White;
					num = 1183;
				}
				if (num == 1183)
				{
					this.cpu6.Location = new Point(576, 171);
					num = 1184;
				}
				if (num == 1184)
				{
					this.cpu6.Name = "cpu6";
					num = 1185;
				}
				if (num == 1185)
				{
					this.cpu6.Size = new Size(72, 28);
					num = 1186;
				}
				if (num == 1186)
				{
					this.cpu6.TabIndex = 320;
					num = 1187;
				}
				if (num == 1187)
				{
					this.cpu6.Text = "CPU 6";
					num = 1188;
				}
				if (num == 1188)
				{
					this.cpu6.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1189;
				}
				if (num == 1189)
				{
					this.cpu6.UncheckedState.BorderRadius = 0;
					num = 1190;
				}
				if (num == 1190)
				{
					this.cpu6.UncheckedState.BorderThickness = 0;
					num = 1191;
				}
				if (num == 1191)
				{
					this.cpu6.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1192;
				}
				if (num == 1192)
				{
					this.cpu7.AutoSize = true;
					num = 1193;
				}
				if (num == 1193)
				{
					this.cpu7.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1194;
				}
				if (num == 1194)
				{
					this.cpu7.CheckedState.BorderRadius = 0;
					num = 1195;
				}
				if (num == 1195)
				{
					this.cpu7.CheckedState.BorderThickness = 0;
					num = 1196;
				}
				if (num == 1196)
				{
					this.cpu7.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1197;
				}
				if (num == 1197)
				{
					this.cpu7.Enabled = false;
					num = 1198;
				}
				if (num == 1198)
				{
					this.cpu7.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1199;
				}
				if (num == 1199)
				{
					this.cpu7.ForeColor = Color.White;
					num = 1200;
				}
				if (num == 1201)
				{
					this.cpu7.Name = "cpu7";
					num = 1202;
				}
				if (num == 1202)
				{
					this.cpu7.Size = new Size(71, 28);
					num = 1203;
				}
				if (num == 1203)
				{
					this.cpu7.TabIndex = 319;
					num = 1204;
				}
				if (num == 1204)
				{
					this.cpu7.Text = "CPU 7";
					num = 1205;
				}
				if (num == 1205)
				{
					this.cpu7.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1206;
				}
				if (num == 1206)
				{
					this.cpu7.UncheckedState.BorderRadius = 0;
					num = 1207;
				}
				if (num == 1207)
				{
					this.cpu7.UncheckedState.BorderThickness = 0;
					num = 1208;
				}
				if (num == 1208)
				{
					this.cpu7.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1209;
				}
				if (num == 1209)
				{
					this.cpu5.AutoSize = true;
					num = 1210;
				}
				if (num == 1210)
				{
					this.cpu5.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1211;
				}
				if (num == 1211)
				{
					this.cpu5.CheckedState.BorderRadius = 0;
					num = 1212;
				}
				if (num == 1212)
				{
					this.cpu5.CheckedState.BorderThickness = 0;
					num = 1213;
				}
				if (num == 1213)
				{
					this.cpu5.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1214;
				}
				if (num == 1214)
				{
					this.cpu5.Enabled = false;
					num = 1215;
				}
				if (num == 1215)
				{
					this.cpu5.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1216;
				}
				if (num == 1216)
				{
					this.cpu5.ForeColor = Color.White;
					num = 1217;
				}
				if (num == 1217)
				{
					this.cpu5.Location = new Point(484, 171);
					num = 1218;
				}
				if (num == 1218)
				{
					this.cpu5.Name = "cpu5";
					num = 1219;
				}
				if (num == 1219)
				{
					this.cpu5.Size = new Size(72, 28);
					num = 1220;
				}
				if (num == 1220)
				{
					this.cpu5.TabIndex = 318;
					num = 1221;
				}
				if (num == 1221)
				{
					this.cpu5.Text = "CPU 5";
					num = 1222;
				}
				if (num == 1222)
				{
					this.cpu5.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1223;
				}
				if (num == 1223)
				{
					this.cpu5.UncheckedState.BorderRadius = 0;
					num = 1224;
				}
				if (num == 1224)
				{
					this.cpu5.UncheckedState.BorderThickness = 0;
					num = 1225;
				}
				if (num == 1225)
				{
					this.cpu5.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1226;
				}
				if (num == 1226)
				{
					this.save.CheckedState.Parent = this.save;
					num = 1227;
				}
				if (num == 1227)
				{
					this.save.CustomImages.Parent = this.save;
					num = 1228;
				}
				if (num == 1228)
				{
					this.save.DisabledState.BorderColor = Color.DarkGray;
					num = 1229;
				}
				if (num == 1229)
				{
					this.save.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 1230;
				}
				if (num == 1230)
				{
					this.save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 1231;
				}
				if (num == 1231)
				{
					this.save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 1232;
				}
				if (num == 1232)
				{
					this.save.DisabledState.Parent = this.save;
					num = 1233;
				}
				if (num == 1233)
				{
					this.save.FillColor = Color.FromArgb(38, 38, 38);
					num = 1234;
				}
				if (num == 1234)
				{
					this.save.Font = new Font("Josefin Sans", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1235;
				}
				if (num == 1235)
				{
					this.save.ForeColor = Color.White;
					num = 1236;
				}
				if (num == 1236)
				{
					this.save.HoverState.Parent = this.save;
					num = 1237;
				}
				if (num == 1237)
				{
					this.save.ImageSize = new Size(30, 30);
					num = 1238;
				}
				if (num == 1238)
				{
					this.save.Location = new Point(783, 470);
					num = 1239;
				}
				if (num == 1239)
				{
					this.save.Name = "save";
					num = 1240;
				}
				if (num == 1240)
				{
					this.save.ShadowDecoration.Parent = this.save;
					num = 1241;
				}
				if (num == 1241)
				{
					this.save.Size = new Size(135, 38);
					num = 1242;
				}
				if (num == 1242)
				{
					this.save.TabIndex = 317;
					num = 1243;
				}
				if (num == 1244)
				{
					this.save.Click += this.save_Click;
					num = 1245;
				}
				if (num == 1245)
				{
					this.cpu4.AutoSize = true;
					num = 1246;
				}
				if (num == 1246)
				{
					this.cpu4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1247;
				}
				if (num == 1247)
				{
					this.cpu4.CheckedState.BorderRadius = 0;
					num = 1248;
				}
				if (num == 1248)
				{
					this.cpu4.CheckedState.BorderThickness = 0;
					num = 1249;
				}
				if (num == 1249)
				{
					this.cpu4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1250;
				}
				if (num == 1250)
				{
					this.cpu4.Enabled = false;
					num = 1251;
				}
				if (num == 1251)
				{
					this.cpu4.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1252;
				}
				if (num == 1252)
				{
					this.cpu4.ForeColor = Color.White;
					num = 1253;
				}
				if (num == 1253)
				{
					this.cpu4.Location = new Point(393, 171);
					num = 1254;
				}
				if (num == 1254)
				{
					this.cpu4.Name = "cpu4";
					num = 1255;
				}
				if (num == 1255)
				{
					this.cpu4.Size = new Size(72, 28);
					num = 1256;
				}
				if (num == 1256)
				{
					this.cpu4.TabIndex = 152;
					num = 1257;
				}
				if (num == 1257)
				{
					this.cpu4.Text = "CPU 4";
					num = 1258;
				}
				if (num == 1258)
				{
					this.cpu4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1259;
				}
				if (num == 1259)
				{
					this.cpu4.UncheckedState.BorderRadius = 0;
					num = 1260;
				}
				if (num == 1260)
				{
					this.cpu4.UncheckedState.BorderThickness = 0;
					num = 1261;
				}
				if (num == 1261)
				{
					this.cpu4.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1262;
				}
				if (num == 1262)
				{
					this.cpu3.AutoSize = true;
					num = 1263;
				}
				if (num == 1263)
				{
					this.cpu3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1264;
				}
				if (num == 1264)
				{
					this.cpu3.CheckedState.BorderRadius = 0;
					num = 1265;
				}
				if (num == 1265)
				{
					this.cpu3.CheckedState.BorderThickness = 0;
					num = 1266;
				}
				if (num == 1266)
				{
					this.cpu3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1267;
				}
				if (num == 1267)
				{
					this.cpu3.Enabled = false;
					num = 1268;
				}
				if (num == 1268)
				{
					this.cpu3.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1269;
				}
				if (num == 1269)
				{
					this.cpu3.ForeColor = Color.White;
					num = 1270;
				}
				if (num == 1270)
				{
					this.cpu3.Location = new Point(302, 171);
					num = 1271;
				}
				if (num == 1271)
				{
					this.cpu3.Name = "cpu3";
					num = 1272;
				}
				if (num == 1272)
				{
					this.cpu3.Size = new Size(72, 28);
					num = 1273;
				}
				if (num == 1273)
				{
					this.cpu3.TabIndex = 151;
					num = 1274;
				}
				if (num == 1274)
				{
					this.cpu3.Text = "CPU 3";
					num = 1275;
				}
				if (num == 1275)
				{
					this.cpu3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1276;
				}
				if (num == 1276)
				{
					this.cpu3.UncheckedState.BorderRadius = 0;
					num = 1277;
				}
				if (num == 1277)
				{
					this.cpu3.UncheckedState.BorderThickness = 0;
					num = 1278;
				}
				if (num == 1278)
				{
					this.cpu3.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1279;
				}
				if (num == 1279)
				{
					this.cpu1.AutoSize = true;
					num = 1280;
				}
				if (num == 1280)
				{
					this.cpu1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1281;
				}
				if (num == 1281)
				{
					this.cpu1.CheckedState.BorderRadius = 0;
					num = 1282;
				}
				if (num == 1282)
				{
					this.cpu1.CheckedState.BorderThickness = 0;
					num = 1283;
				}
				if (num == 1283)
				{
					this.cpu1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1284;
				}
				if (num == 1284)
				{
					this.cpu1.Enabled = false;
					num = 1285;
				}
				if (num == 1285)
				{
					this.cpu1.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1286;
				}
				if (num == 1287)
				{
					this.cpu1.Location = new Point(123, 171);
					num = 1288;
				}
				if (num == 1288)
				{
					this.cpu1.Name = "cpu1";
					num = 1289;
				}
				if (num == 1289)
				{
					this.cpu1.Size = new Size(69, 28);
					num = 1290;
				}
				if (num == 1290)
				{
					this.cpu1.TabIndex = 150;
					num = 1291;
				}
				if (num == 1291)
				{
					this.cpu1.Text = "CPU 1";
					num = 1292;
				}
				if (num == 1292)
				{
					this.cpu1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1293;
				}
				if (num == 1293)
				{
					this.cpu1.UncheckedState.BorderRadius = 0;
					num = 1294;
				}
				if (num == 1294)
				{
					this.cpu1.UncheckedState.BorderThickness = 0;
					num = 1295;
				}
				if (num == 1295)
				{
					this.cpu1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1296;
				}
				if (num == 1296)
				{
					this.cpu2.AutoSize = true;
					num = 1297;
				}
				if (num == 1297)
				{
					this.cpu2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1298;
				}
				if (num == 1298)
				{
					this.cpu2.CheckedState.BorderRadius = 0;
					num = 1299;
				}
				if (num == 1299)
				{
					this.cpu2.CheckedState.BorderThickness = 0;
					num = 1300;
				}
				if (num == 1300)
				{
					this.cpu2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1301;
				}
				if (num == 1301)
				{
					this.cpu2.Enabled = false;
					num = 1302;
				}
				if (num == 1302)
				{
					this.cpu2.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1303;
				}
				if (num == 1303)
				{
					this.cpu2.ForeColor = Color.White;
					num = 1304;
				}
				if (num == 1304)
				{
					this.cpu2.Location = new Point(211, 171);
					num = 1305;
				}
				if (num == 1305)
				{
					this.cpu2.Name = "cpu2";
					num = 1306;
				}
				if (num == 1306)
				{
					this.cpu2.Size = new Size(72, 28);
					num = 1307;
				}
				if (num == 1307)
				{
					this.cpu2.TabIndex = 149;
					num = 1308;
				}
				if (num == 1308)
				{
					this.cpu2.Text = "CPU 2";
					num = 1309;
				}
				if (num == 1309)
				{
					this.cpu2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1310;
				}
				if (num == 1310)
				{
					this.cpu2.UncheckedState.BorderRadius = 0;
					num = 1311;
				}
				if (num == 1311)
				{
					this.cpu2.UncheckedState.BorderThickness = 0;
					num = 1312;
				}
				if (num == 1312)
				{
					this.cpu2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1313;
				}
				if (num == 1313)
				{
					this.cpu0.AutoSize = true;
					num = 1314;
				}
				if (num == 1314)
				{
					this.cpu0.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 1315;
				}
				if (num == 1315)
				{
					this.cpu0.CheckedState.BorderRadius = 0;
					num = 1316;
				}
				if (num == 1316)
				{
					this.cpu0.CheckedState.BorderThickness = 0;
					num = 1317;
				}
				if (num == 1317)
				{
					this.cpu0.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 1318;
				}
				if (num == 1318)
				{
					this.cpu0.Enabled = false;
					num = 1319;
				}
				if (num == 1319)
				{
					this.cpu0.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1320;
				}
				if (num == 1320)
				{
					this.cpu0.ForeColor = Color.White;
					num = 1321;
				}
				if (num == 1321)
				{
					this.cpu0.Location = new Point(31, 171);
					num = 1322;
				}
				if (num == 1322)
				{
					this.cpu0.Name = "cpu0";
					num = 1323;
				}
				if (num == 1323)
				{
					this.cpu0.Size = new Size(73, 28);
					num = 1324;
				}
				if (num == 1324)
				{
					this.cpu0.TabIndex = 148;
					num = 1325;
				}
				if (num == 1325)
				{
					this.cpu0.Text = "CPU 0";
					num = 1326;
				}
				if (num == 1326)
				{
					this.cpu0.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1327;
				}
				if (num == 1327)
				{
					this.cpu0.UncheckedState.BorderRadius = 0;
					num = 1328;
				}
				if (num == 1328)
				{
					this.cpu0.UncheckedState.BorderThickness = 0;
					num = 1329;
				}
				if (num == 1330)
				{
					this.deviceNameBox.Font = new Font("Gill Sans MT", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1331;
				}
				if (num == 1331)
				{
					this.deviceNameBox.FormattingEnabled = true;
					num = 1332;
				}
				if (num == 1332)
				{
					this.deviceNameBox.Location = new Point(146, 47);
					num = 1333;
				}
				if (num == 1333)
				{
					this.deviceNameBox.Name = "deviceNameBox";
					num = 1334;
				}
				if (num == 1334)
				{
					this.deviceNameBox.Size = new Size(378, 29);
					num = 1335;
				}
				if (num == 1335)
				{
					this.deviceNameBox.TabIndex = 1;
					num = 1336;
				}
				if (num == 1336)
				{
					this.deviceNameBox.SelectedIndexChanged += this.deviceNameBox_SelectedIndexChanged;
					num = 1337;
				}
				if (num == 1337)
				{
					this.devicePath.AutoSize = true;
					num = 1338;
				}
				if (num == 1338)
				{
					this.devicePath.Font = new Font("Josefin Sans Light", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1339;
				}
				if (num == 1339)
				{
					this.devicePath.Location = new Point(26, 47);
					num = 1340;
				}
				if (num == 1340)
				{
					this.devicePath.Name = "devicePath";
					num = 1341;
				}
				if (num == 1341)
				{
					this.devicePath.Size = new Size(114, 25);
					num = 1342;
				}
				if (num == 1342)
				{
					this.devicePath.TabIndex = 0;
					num = 1343;
				}
				if (num == 1343)
				{
					this.devicePath.Text = "Device Name :";
					num = 1344;
				}
				if (num == 1344)
				{
					this.back_btn.BackColor = Color.Transparent;
					num = 1345;
				}
				if (num == 1345)
				{
					this.back_btn.BorderRadius = 14;
					num = 1346;
				}
				if (num == 1346)
				{
					this.back_btn.CheckedState.Parent = this.back_btn;
					num = 1347;
				}
				if (num == 1347)
				{
					this.back_btn.CustomImages.Parent = this.back_btn;
					num = 1348;
				}
				if (num == 1348)
				{
					this.back_btn.DisabledState.BorderColor = Color.DarkGray;
					num = 1349;
				}
				if (num == 1349)
				{
					this.back_btn.DisabledState.CustomBorderColor = Color.DarkGray;
					num = 1350;
				}
				if (num == 1350)
				{
					this.back_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
					num = 1351;
				}
				if (num == 1351)
				{
					this.back_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 1352;
				}
				if (num == 1352)
				{
					this.back_btn.DisabledState.Parent = this.back_btn;
					num = 1353;
				}
				if (num == 1353)
				{
					this.back_btn.FillColor = Color.FromArgb(38, 38, 38);
					num = 1354;
				}
				if (num == 1354)
				{
					this.back_btn.Font = new Font("Josefin Sans SemiBold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
					num = 1355;
				}
				if (num == 1355)
				{
					this.back_btn.ForeColor = Color.White;
					num = 1356;
				}
				if (num == 1356)
				{
					this.back_btn.HoverState.Parent = this.back_btn;
					num = 1357;
				}
				if (num == 1357)
				{
					this.back_btn.Location = new Point(876, 53);
					num = 1358;
				}
				if (num == 1358)
				{
					this.back_btn.Name = "back_btn";
					num = 1359;
				}
				if (num == 1359)
				{
					this.back_btn.ShadowDecoration.Parent = this.back_btn;
					num = 1360;
				}
				if (num == 1360)
				{
					this.back_btn.Size = new Size(88, 30);
					num = 1361;
				}
				if (num == 1361)
				{
					this.back_btn.TabIndex = 125;
					num = 1362;
				}
				if (num == 1362)
				{
					this.back_btn.Text = "Back";
					num = 1363;
				}
				if (num == 1363)
				{
					this.back_btn.Click += this.back_btn_Click;
					num = 1364;
				}
				if (num == 1364)
				{
					base.AutoScaleDimensions = new SizeF(6f, 13f);
					num = 1365;
				}
				if (num == 1365)
				{
					base.AutoScaleMode = AutoScaleMode.Font;
					num = 1366;
				}
				if (num == 1366)
				{
					this.BackColor = Color.FromArgb(38, 38, 38);
					num = 1367;
				}
				if (num == 1367)
				{
					base.Controls.Add(this.back_btn);
					num = 1368;
				}
				if (num == 1368)
				{
					base.Controls.Add(this.groupBox1);
					num = 1369;
				}
				if (num == 1369)
				{
					base.Controls.Add(this.label37);
					num = 1370;
				}
				if (num == 1370)
				{
					base.Controls.Add(this.label1);
					num = 1371;
				}
				if (num == 1371)
				{
					this.ForeColor = SystemColors.ControlText;
					num = 1372;
				}
				if (num == 1373)
				{
					base.Size = new Size(1006, 669);
					num = 1374;
				}
				if (num == 1374)
				{
					base.Load += this.affinities_Load;
					num = 1375;
				}
				if (num == 1375)
				{
					this.groupBox1.ResumeLayout(false);
					num = 1376;
				}
				if (num == 1376)
				{
					this.groupBox1.PerformLayout();
					num = 1377;
				}
				if (num == 1377)
				{
					base.ResumeLayout(false);
					num = 1378;
				}
				if (num == 1378)
				{
					base.PerformLayout();
					num = 1379;
				}
				if (num == 1372)
				{
					base.Name = "affinities";
					num = 1373;
				}
				if (num == 1329)
				{
					this.cpu0.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1330;
				}
				if (num == 1286)
				{
					this.cpu1.ForeColor = Color.White;
					num = 1287;
				}
				if (num == 1243)
				{
					this.save.Text = "Set Mask";
					num = 1244;
				}
				if (num == 1200)
				{
					this.cpu7.Location = new Point(664, 171);
					num = 1201;
				}
				if (num == 1157)
				{
					this.cpu9.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1158;
				}
				if (num == 1115)
				{
					this.cpu12.Location = new Point(211, 205);
					num = 1116;
				}
				if (num == 1072)
				{
					this.cpu14.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 1073;
				}
				if (num == 1029)
				{
					this.cpu17.ForeColor = Color.White;
					num = 1030;
				}
				if (num == 986)
				{
					this.cpu19.UncheckedState.BorderThickness = 0;
					num = 987;
				}
				if (num == 943)
				{
					this.cpu22.Font = new Font("Josefin Sans", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 944;
				}
				if (num == 900)
				{
					this.cpu24.UncheckedState.BorderRadius = 0;
					num = 901;
				}
				if (num == 857)
				{
					this.cpu27.Enabled = false;
					num = 858;
				}
				if (num == 814)
				{
					this.cpu29.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 815;
				}
				if (num == 771)
				{
					this.cpu32.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 772;
				}
				if (num == 729)
				{
					this.cpu34.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 730;
				}
				if (num == 686)
				{
					this.cpu37.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
					num = 687;
				}
				if (num == 643)
				{
					this.cpu39.Text = "CPU 39";
					num = 644;
				}
				if (num == 600)
				{
					this.cpu42.CheckedState.BorderThickness = 0;
					num = 601;
				}
				if (num == 557)
				{
					this.cpu44.TabIndex = 357;
					num = 558;
				}
				if (num == 514)
				{
					this.cpu47.CheckedState.BorderRadius = 0;
					num = 515;
				}
				if (num == 471)
				{
					this.cpu49.Size = new Size(80, 28);
					num = 472;
				}
				if (num == 428)
				{
					this.cpu52.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 429;
				}
				if (num == 385)
				{
					this.cpu54.Name = "cpu54";
					num = 386;
				}
				if (num == 343)
				{
					this.cpu57.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 344;
				}
				if (num == 300)
				{
					this.cpu59.Name = "cpu59";
					num = 301;
				}
				if (num == 257)
				{
					this.cpu62.AutoSize = true;
					num = 258;
				}
				if (num == 214)
				{
					this.label2.TabIndex = 378;
					num = 215;
				}
				if (num == 171)
				{
					this.groupBox1.TabStop = false;
					num = 172;
				}
				if (num == 128)
				{
					this.groupBox1.Controls.Add(this.cpu33);
					num = 129;
				}
				if (num == 85)
				{
					this.label37.Text = "Change Device Affinities with ease!";
					num = 86;
				}
				if (num == 42)
				{
					this.cpu29 = new SiticoneCheckBox();
					num = 43;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1379);
		}

		// Token: 0x040003EF RID: 1007
		private UserPreferenceChangedEventHandler UserPreferenceChanged;

		// Token: 0x040003F0 RID: 1008
		private RegistryKey DevicesPath = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum\\");

		// Token: 0x040003F1 RID: 1009
		private Dictionary<string, string> DevicesPathList = new Dictionary<string, string>();

		// Token: 0x040003F2 RID: 1010
		private static Affinities _instace;

		// Token: 0x040003F3 RID: 1011
		private IContainer components = null;

		// Token: 0x040003F4 RID: 1012
		private Label label37;

		// Token: 0x040003F5 RID: 1013
		private Label label1;

		// Token: 0x040003F6 RID: 1014
		private GroupBox groupBox1;

		// Token: 0x040003F7 RID: 1015
		private SiticoneButton save;

		// Token: 0x040003F8 RID: 1016
		private SiticoneCheckBox cpu4;

		// Token: 0x040003F9 RID: 1017
		private SiticoneCheckBox cpu3;

		// Token: 0x040003FA RID: 1018
		private SiticoneCheckBox cpu1;

		// Token: 0x040003FB RID: 1019
		private SiticoneCheckBox cpu2;

		// Token: 0x040003FC RID: 1020
		private SiticoneCheckBox cpu0;

		// Token: 0x040003FD RID: 1021
		private ComboBox deviceNameBox;

		// Token: 0x040003FE RID: 1022
		private Label devicePath;

		// Token: 0x040003FF RID: 1023
		private SiticoneCheckBox cpu9;

		// Token: 0x04000400 RID: 1024
		private SiticoneCheckBox cpu8;

		// Token: 0x04000401 RID: 1025
		private SiticoneCheckBox cpu6;

		// Token: 0x04000402 RID: 1026
		private SiticoneCheckBox cpu7;

		// Token: 0x04000403 RID: 1027
		private SiticoneCheckBox cpu5;

		// Token: 0x04000404 RID: 1028
		private SiticoneCheckBox cpu63;

		// Token: 0x04000405 RID: 1029
		private SiticoneCheckBox cpu61;

		// Token: 0x04000406 RID: 1030
		private SiticoneCheckBox cpu62;

		// Token: 0x04000407 RID: 1031
		private SiticoneCheckBox cpu60;

		// Token: 0x04000408 RID: 1032
		private SiticoneCheckBox cpu59;

		// Token: 0x04000409 RID: 1033
		private SiticoneCheckBox cpu58;

		// Token: 0x0400040A RID: 1034
		private SiticoneCheckBox cpu56;

		// Token: 0x0400040B RID: 1035
		private SiticoneCheckBox cpu57;

		// Token: 0x0400040C RID: 1036
		private SiticoneCheckBox cpu55;

		// Token: 0x0400040D RID: 1037
		private SiticoneCheckBox cpu54;

		// Token: 0x0400040E RID: 1038
		private SiticoneCheckBox cpu53;

		// Token: 0x0400040F RID: 1039
		private SiticoneCheckBox cpu51;

		// Token: 0x04000410 RID: 1040
		private SiticoneCheckBox cpu52;

		// Token: 0x04000411 RID: 1041
		private SiticoneCheckBox cpu50;

		// Token: 0x04000412 RID: 1042
		private SiticoneCheckBox cpu49;

		// Token: 0x04000413 RID: 1043
		private SiticoneCheckBox cpu48;

		// Token: 0x04000414 RID: 1044
		private SiticoneCheckBox cpu46;

		// Token: 0x04000415 RID: 1045
		private SiticoneCheckBox cpu47;

		// Token: 0x04000416 RID: 1046
		private SiticoneCheckBox cpu45;

		// Token: 0x04000417 RID: 1047
		private SiticoneCheckBox cpu44;

		// Token: 0x04000418 RID: 1048
		private SiticoneCheckBox cpu43;

		// Token: 0x04000419 RID: 1049
		private SiticoneCheckBox cpu41;

		// Token: 0x0400041A RID: 1050
		private SiticoneCheckBox cpu42;

		// Token: 0x0400041B RID: 1051
		private SiticoneCheckBox cpu40;

		// Token: 0x0400041C RID: 1052
		private SiticoneCheckBox cpu39;

		// Token: 0x0400041D RID: 1053
		private SiticoneCheckBox cpu38;

		// Token: 0x0400041E RID: 1054
		private SiticoneCheckBox cpu36;

		// Token: 0x0400041F RID: 1055
		private SiticoneCheckBox cpu37;

		// Token: 0x04000420 RID: 1056
		private SiticoneCheckBox cpu35;

		// Token: 0x04000421 RID: 1057
		private SiticoneCheckBox cpu34;

		// Token: 0x04000422 RID: 1058
		private SiticoneCheckBox cpu33;

		// Token: 0x04000423 RID: 1059
		private SiticoneCheckBox cpu31;

		// Token: 0x04000424 RID: 1060
		private SiticoneCheckBox cpu32;

		// Token: 0x04000425 RID: 1061
		private SiticoneCheckBox cpu30;

		// Token: 0x04000426 RID: 1062
		private SiticoneCheckBox cpu29;

		// Token: 0x04000427 RID: 1063
		private SiticoneCheckBox cpu28;

		// Token: 0x04000428 RID: 1064
		private SiticoneCheckBox cpu26;

		// Token: 0x04000429 RID: 1065
		private SiticoneCheckBox cpu27;

		// Token: 0x0400042A RID: 1066
		private SiticoneCheckBox cpu25;

		// Token: 0x0400042B RID: 1067
		private SiticoneCheckBox cpu24;

		// Token: 0x0400042C RID: 1068
		private SiticoneCheckBox cpu23;

		// Token: 0x0400042D RID: 1069
		private SiticoneCheckBox cpu21;

		// Token: 0x0400042E RID: 1070
		private SiticoneCheckBox cpu22;

		// Token: 0x0400042F RID: 1071
		private SiticoneCheckBox cpu20;

		// Token: 0x04000430 RID: 1072
		private SiticoneCheckBox cpu19;

		// Token: 0x04000431 RID: 1073
		private SiticoneCheckBox cpu18;

		// Token: 0x04000432 RID: 1074
		private SiticoneCheckBox cpu16;

		// Token: 0x04000433 RID: 1075
		private SiticoneCheckBox cpu17;

		// Token: 0x04000434 RID: 1076
		private SiticoneCheckBox cpu15;

		// Token: 0x04000435 RID: 1077
		private SiticoneCheckBox cpu14;

		// Token: 0x04000436 RID: 1078
		private SiticoneCheckBox cpu13;

		// Token: 0x04000437 RID: 1079
		private SiticoneCheckBox cpu11;

		// Token: 0x04000438 RID: 1080
		private SiticoneCheckBox cpu12;

		// Token: 0x04000439 RID: 1081
		private SiticoneCheckBox cpu10;

		// Token: 0x0400043A RID: 1082
		private Label devicePathLabel;

		// Token: 0x0400043B RID: 1083
		private Label label2;

		// Token: 0x0400043C RID: 1084
		private SiticoneCheckBox msiMode;

		// Token: 0x0400043D RID: 1085
		private SiticoneButton siticoneButton1;

		// Token: 0x0400043E RID: 1086
		private SiticoneRoundedButton back_btn;
	}
}
