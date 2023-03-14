using System;

namespace Login_HWID.Class
{
	// Token: 0x0200007F RID: 127
	public class SettingsPage
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00193A0C File Offset: 0x00191C0C
		public SettingsPage()
		{
			this._mssettings = new TreeData<string>("Settings");
			TreeData<string> treeData = new TreeData<string>("System");
			TreeData<string> treeData2 = this.AddChildTreeNode(treeData, "Display", "ms-settings:display");
			this.AddChildTreeNode(treeData2, "Night light settings", "ms-settings:nightlight");
			this.AddChildTreeNode(treeData2, "Advanced scaling settings", "ms-settings:display-advanced");
			this.AddChildTreeNode(treeData2, "Connect to a wireless display", "ms-settings-connectabledevices:devicediscovery");
			this.AddChildTreeNode(treeData2, "Graphics settings", "ms-settings:display-advancedgraphics");
			this.AddChildTreeNode(treeData2, "Display orientation", "ms-settings:screenrotation");
			if (this.BuildNumber >= 17063)
			{
				TreeData<string> treeData3 = this.AddChildTreeNode(treeData, "Sound", "ms-settings:sound");
				this.AddChildTreeNode(treeData3, "Manage sound devices", "ms-settings:sound-devices");
				this.AddChildTreeNode(treeData3, "App volume and device preferences", "ms-settings:apps-volume");
			}
			this.AddChildTreeNode(treeData, "Notifications & actions", "ms-settings:notifications");
			if (this.BuildNumber >= 17074)
			{
				TreeData<string> treeData4 = this.AddChildTreeNode(treeData, "Focus assist", "ms-settings:quiethours");
				this.AddChildTreeNode(treeData4, "During these hours", "ms-settings:quietmomentsscheduled");
				this.AddChildTreeNode(treeData4, "Duplicating my display (When I'm duplicating my display)", "ms-settings:quietmomentspresentation");
				this.AddChildTreeNode(treeData4, "Playing a game full screen (When I'm playing a game)", "ms-settings:quietmomentsgame");
			}
			this.AddChildTreeNode(treeData, "Power & sleep", "ms-settings:powersleep");
			TreeData<string> treeData5 = this.AddChildTreeNode(treeData, "Battery", "ms-settings:batterysaver");
			this.AddChildTreeNode(treeData5, "See which apps are affecting your battery life", "ms-settings:batterysaver-usagedetails");
			this.AddChildTreeNode(treeData5, "Battery Saver settings\t", "ms-settings:batterysaver-settings");
			TreeData<string> treeData6 = this.AddChildTreeNode(treeData, "Storage", "ms-settings:storagesense");
			this.AddChildTreeNode(treeData6, "Configure Storage Sense or run it now", "ms-settings:storagepolicies");
			this.AddChildTreeNode(treeData6, "Change where new content is saved", "ms-settings:savelocations");
			this.AddChildTreeNode(treeData, "Tablet mode", "ms-settings:tabletmode");
			this.AddChildTreeNode(treeData, "Multitasking", "ms-settings:multitasking");
			this.AddChildTreeNode(treeData, "Projecting to this PC", "ms-settings:project");
			this.AddChildTreeNode(treeData, "Shared experiences", "ms-settings:crossdevice");
			if (this.BuildNumber >= 17666)
			{
				this.AddChildTreeNode(treeData, "Clipboard", "ms-settings:clipboard");
			}
			this.AddChildTreeNode(treeData, "Remote Desktop", "ms-settings:remotedesktop");
			this.AddChildTreeNode(treeData, "Device Encryption (where available)", "ms-settings:deviceencryption");
			this.AddChildTreeNode(treeData, "About", "ms-settings:about");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Devices");
			this.AddChildTreeNode(treeData, "Bluetooth & other devices", "ms-settings:bluetooth");
			this.AddChildTreeNode(treeData, "Printers & scanners", "ms-settings:printers");
			this.AddChildTreeNode(treeData, "Mouse", "ms-settings:mousetouchpad");
			this.AddChildTreeNode(treeData, "Touchpad", "ms-settings:devices-touchpad");
			TreeData<string> treeData7 = this.AddChildTreeNode(treeData, "Typing", "ms-settings:typing");
			this.AddChildTreeNode(treeData7, "Hardware keyboard - Text suggestions", "ms-settings:devicestyping-hwkbtextsuggestions");
			this.AddChildTreeNode(treeData, "Wheel (where available)", "ms-settings:wheel");
			this.AddChildTreeNode(treeData, "Pen & Windows Ink", "ms-settings:pen");
			this.AddChildTreeNode(treeData, "AutoPlay", "ms-settings:autoplay");
			this.AddChildTreeNode(treeData, "USB", "ms-settings:usb");
			this._mssettings.Children.Add(treeData);
			if (this.BuildNumber >= 16251)
			{
				treeData = new TreeData<string>("Phone");
				TreeData<string> treeData8 = this.AddChildTreeNode(treeData, "Phone", "ms-settings:mobile-devices");
				this.AddChildTreeNode(treeData8, "Add a phone", "ms-settings:mobile-devices-addphone");
				this.AddChildTreeNode(treeData8, "Your Phone (opens app)", "ms-settings:mobile-devices-addphone-direct");
			}
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Network & Internet");
			TreeData<string> treeData9 = this.AddChildTreeNode(treeData, "Status", "ms-settings:network-status");
			this.AddChildTreeNode(treeData9, "Show available networks", "ms-availablenetworks:");
			this.AddChildTreeNode(treeData, "Cellular & SIM", "ms-settings:network-cellular");
			TreeData<string> treeData10 = this.AddChildTreeNode(treeData, "Wi-Fi", "ms-settings:network-wifi");
			this.AddChildTreeNode(treeData10, "Show available networks", "ms-availablenetworks:");
			this.AddChildTreeNode(treeData10, "Manage known networks", "ms-settings:network-wifisettings");
			this.AddChildTreeNode(treeData, "Wi-Fi Calling", "ms-settings:network-wificalling");
			this.AddChildTreeNode(treeData, "Ethernet", "ms-settings:network-ethernet");
			this.AddChildTreeNode(treeData, "Dial-up", "ms-settings:network-dialup");
			this.AddChildTreeNode(treeData, "DirectAccess (where available)", "ms-settings:network-directaccess");
			this.AddChildTreeNode(treeData, "VPN", "ms-settings:network-vpn");
			this.AddChildTreeNode(treeData, "Airplane mode", "ms-settings:network-airplanemode or proximity");
			this.AddChildTreeNode(treeData, "Mobile hotspot", "ms-settings:network-mobilehotspot");
			this.AddChildTreeNode(treeData, "NFC", "ms-settings:nfctransactions");
			this.AddChildTreeNode(treeData, "Data usage", "ms-settings:datausage");
			this.AddChildTreeNode(treeData, "Proxy", "ms-settings:network-proxy");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Personalization");
			this.AddChildTreeNode(treeData, "Background", "ms-settings:personalization-background");
			this.AddChildTreeNode(treeData, "Colors", "ms-settings:personalization-colors or colors");
			this.AddChildTreeNode(treeData, "Lock screen", "ms-settings:lockscreen");
			this.AddChildTreeNode(treeData, "Themes", "ms-settings:themes");
			if (this.BuildNumber >= 17083)
			{
				this.AddChildTreeNode(treeData, "Fonts", "ms-settings:fonts");
			}
			TreeData<string> treeData11 = this.AddChildTreeNode(treeData, "Start", "ms-settings:personalization-start");
			this.AddChildTreeNode(treeData11, "Choose which folders appear on Start", "ms-settings:personalization-start-places");
			this.AddChildTreeNode(treeData, "Taskbar", "ms-settings:taskbar");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Apps");
			TreeData<string> treeData12 = this.AddChildTreeNode(treeData, "Apps & features", "ms-settings:appsfeatures");
			this.AddChildTreeNode(treeData12, "Manage optional features", "ms-settings:optionalfeatures");
			this.AddChildTreeNode(treeData, "Default apps", "ms-settings:defaultapps");
			TreeData<string> treeData13 = this.AddChildTreeNode(treeData, "Offline maps", "ms-settings:maps");
			this.AddChildTreeNode(treeData13, "Download maps", "ms-settings:maps-downloadmaps");
			this.AddChildTreeNode(treeData, "Apps for websites", "ms-settings:appsforwebsites");
			if (this.BuildNumber >= 16215)
			{
				this.AddChildTreeNode(treeData, "Video playback", "ms-settings:videoplayback");
			}
			if (this.BuildNumber >= 17017)
			{
				this.AddChildTreeNode(treeData, "Startup", "ms-settings:startupapps");
			}
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Accounts");
			this.AddChildTreeNode(treeData, "Your info", "ms-settings:yourinfo");
			this.AddChildTreeNode(treeData, "Email & accounts", "ms-settings:emailandaccounts");
			TreeData<string> treeData14 = this.AddChildTreeNode(treeData, "Sign-in options", "ms-settings:signinoptions");
			this.AddChildTreeNode(treeData14, "Windows Hello face setup", "ms-settings:signinoptions-launchfaceenrollment");
			this.AddChildTreeNode(treeData14, "Windows Hello fingerprint setup", "ms-settings:signinoptions-launchfingerprintenrollment");
			this.AddChildTreeNode(treeData14, "Security Key setup", "ms-settings:signinoptions-launchsecuritykeyenrollment");
			this.AddChildTreeNode(treeData14, "Dynamic Lock", "ms-settings:signinoptions-dynamiclock");
			this.AddChildTreeNode(treeData, "Access work or school", "ms-settings:workplace");
			TreeData<string> treeData15 = this.AddChildTreeNode(treeData, "Family & other people", "ms-settings:otherusers");
			this.AddChildTreeNode(treeData15, "Set up a kiosk", "ms-settings:assignedaccess");
			this.AddChildTreeNode(treeData, "Sync your settings", "ms-settings:sync");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Time & language");
			this.AddChildTreeNode(treeData, "Date & time", "ms-settings:dateandtime");
			this.AddChildTreeNode(treeData, "Region", "ms-settings:regionformatting");
			this.AddChildTreeNode(treeData, "Japan IME settings (available if installed)", "ms-settings:regionlanguage-jpnime");
			this.AddChildTreeNode(treeData, "Pinyin IME settings (available if installed)", "ms-settings:regionlanguage-chsime-pinyin");
			this.AddChildTreeNode(treeData, "Wubi IME settings (available if installed)", "ms-settings:regionlanguage-chsime-wubi");
			this.AddChildTreeNode(treeData, "Korean IME settings (available if installed)", "ms-settings:regionlanguage-korime");
			TreeData<string> treeData16 = this.AddChildTreeNode(treeData, "Language", "ms-settings:regionlanguage");
			this.AddChildTreeNode(treeData16, "Windows Display language", "ms-settings:regionlanguage-setdisplaylanguage");
			this.AddChildTreeNode(treeData16, "Add Display language", "ms-settings:regionlanguage-adddisplaylanguage");
			if (this.BuildNumber >= 17083)
			{
				this.AddChildTreeNode(treeData, "Keyboard", "ms-settings:keyboard");
			}
			this.AddChildTreeNode(treeData, "Speech", "ms-settings:speech");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Gaming");
			this.AddChildTreeNode(treeData, "Game bar", "ms-settings:gaming-gamebar");
			this.AddChildTreeNode(treeData, "Captures", "ms-settings:gaming-gamedvr");
			this.AddChildTreeNode(treeData, "Broadcasting", "ms-settings:gaming-broadcasting");
			this.AddChildTreeNode(treeData, "Game Mode", "ms-settings:gaming-gamemode");
			if (this.OSVersion < WinVer.WindowsVersion.Windows10_1809_RS5_October2018Update)
			{
				this.AddChildTreeNode(treeData, "TruePlay", "ms-settings:gaming-trueplay");
			}
			if (this.BuildNumber >= 16226)
			{
				this.AddChildTreeNode(treeData, "Xbox Networking", "ms-settings:gaming-xboxnetworking");
			}
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Ease of Access");
			if (this.BuildNumber >= 17025)
			{
				this.AddChildTreeNode(treeData, "Display", "ms-settings:easeofaccess-display");
			}
			if (this.BuildNumber >= 17040)
			{
				this.AddChildTreeNode(treeData, "Cursor & pointer", "ms-settings:easeofaccess-cursorandpointersize");
			}
			this.AddChildTreeNode(treeData, "Text cursor", "ms-settings:easeofaccess-cursor");
			this.AddChildTreeNode(treeData, "Magnifier", "ms-settings:easeofaccess-magnifier");
			if (this.BuildNumber >= 17025)
			{
				this.AddChildTreeNode(treeData, "Color Filters", "ms-settings:easeofaccess-colorfilter");
			}
			this.AddChildTreeNode(treeData, "High Contrast", "ms-settings:easeofaccess-highcontrast");
			TreeData<string> treeData17 = this.AddChildTreeNode(treeData, "Narrator", "ms-settings:easeofaccess-narrator");
			this.AddChildTreeNode(treeData17, "Start Narratorafter sign-in for me", "ms-settings:easeofaccess-narrator-isautostartenabled");
			if (this.BuildNumber >= 17035)
			{
				this.AddChildTreeNode(treeData, "Audio", "ms-settings:easeofaccess-audio");
			}
			this.AddChildTreeNode(treeData, "Closed captions", "ms-settings:easeofaccess-closedcaptioning");
			if (this.BuildNumber >= 17035)
			{
				this.AddChildTreeNode(treeData, "Speech", "ms-settings:easeofaccess-speechrecognition");
			}
			this.AddChildTreeNode(treeData, "Keyboard", "ms-settings:easeofaccess-keyboard");
			this.AddChildTreeNode(treeData, "Mouse", "ms-settings:easeofaccess-mouse");
			if (this.BuildNumber >= 17035)
			{
				this.AddChildTreeNode(treeData, "Eye Control", "ms-settings:easeofaccess-eyecontrol");
			}
			if (this.OSVersion < WinVer.WindowsVersion.Windows10_1809_RS5_October2018Update)
			{
				this.AddChildTreeNode(treeData, "Other options", "ms-settings:easeofaccess-otheroptions");
			}
			this._mssettings.Children.Add(treeData);
			if (this.OSVersion >= WinVer.WindowsVersion.Windows10_1903_19H1_May2019Update)
			{
				treeData = new TreeData<string>("Search");
				this.AddChildTreeNode(treeData, "Permissions & history", "ms-settings:search-permissions");
				this.AddChildTreeNode(treeData, "Searching Windows", "ms-settings:cortana-windowssearch");
				this.AddChildTreeNode(treeData, "More details", "ms-settings:search-moredetails");
				this._mssettings.Children.Add(treeData);
			}
			if (this.BuildNumber >= 16188 && this.OSVersion < WinVer.WindowsVersion.Windows10_2004_20H1_May2020Udate)
			{
				treeData = new TreeData<string>("Cortana");
				this.AddChildTreeNode(treeData, "Talk to Cortana", "ms-settings:cortana-talktocortana");
				this.AddChildTreeNode(treeData, "Permissions", "ms-settings:cortana-permissions");
				this.AddChildTreeNode(treeData, "More details", "ms-settings:cortana-moredetails");
				this._mssettings.Children.Add(treeData);
			}
			treeData = new TreeData<string>("Privacy");
			this.AddChildTreeNode(treeData, "General", "ms-settings:privacy");
			this.AddChildTreeNode(treeData, "Speech", "ms-settings:privacy-speech");
			this.AddChildTreeNode(treeData, "Inking & typing personalization", "ms-settings:privacy-speechtyping");
			TreeData<string> treeData18 = this.AddChildTreeNode(treeData, "Diagnostics & feedback", "ms-settings:privacy-feedback");
			this.AddChildTreeNode(treeData18, "View Diagnostic Data", "ms-settings:privacy-feedback-telemetryviewergroup");
			if (this.BuildNumber >= 17040)
			{
				this.AddChildTreeNode(treeData, "Activity history", "ms-settings:privacy-activityhistory");
			}
			this.AddChildTreeNode(treeData, "Location", "ms-settings:privacy-location");
			this.AddChildTreeNode(treeData, "Camera", "ms-settings:privacy-webcam");
			this.AddChildTreeNode(treeData, "Microphone", "ms-settings:privacy-microphone");
			this.AddChildTreeNode(treeData, "Voice activation", "ms-settings:privacy-voiceactivation");
			this.AddChildTreeNode(treeData, "Notifications", "ms-settings:privacy-notifications");
			this.AddChildTreeNode(treeData, "Account info", "ms-settings:privacy-accountinfo");
			this.AddChildTreeNode(treeData, "Contacts", "ms-settings:privacy-contacts");
			this.AddChildTreeNode(treeData, "Calendar", "ms-settings:privacy-calendar");
			if (this.OSVersion < WinVer.WindowsVersion.Windows10_1809_RS5_October2018Update)
			{
				this.AddChildTreeNode(treeData, "Phone calls", "ms-settings:privacy-phonecalls");
			}
			this.AddChildTreeNode(treeData, "Call history", "ms-settings:privacy-callhistory");
			this.AddChildTreeNode(treeData, "Email", "ms-settings:privacy-email");
			this.AddChildTreeNode(treeData, "Eye tracker (where available)", "ms-settings:privacy-eyetracker");
			this.AddChildTreeNode(treeData, "Tasks", "ms-settings:privacy-tasks");
			this.AddChildTreeNode(treeData, "Messaging", "ms-settings:privacy-messaging");
			this.AddChildTreeNode(treeData, "Radios", "ms-settings:privacy-radios");
			this.AddChildTreeNode(treeData, "Other devices", "ms-settings:privacy-customdevices");
			this.AddChildTreeNode(treeData, "Background apps", "ms-settings:privacy-backgroundapps");
			this.AddChildTreeNode(treeData, "App diagnostics", "ms-settings:privacy-appdiagnostics");
			this.AddChildTreeNode(treeData, "Automatic file downloads", "ms-settings:privacy-automaticfiledownloads");
			this.AddChildTreeNode(treeData, "Documents", "ms-settings:privacy-documents");
			this.AddChildTreeNode(treeData, "Pictures", "ms-settings:privacy-pictures");
			this.AddChildTreeNode(treeData, "Videos", "ms-settings:privacy-documents");
			this.AddChildTreeNode(treeData, "File system", "ms-settings:privacy-broadfilesystemaccess");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Update & security");
			TreeData<string> treeData19 = this.AddChildTreeNode(treeData, "Windows Update", "ms-settings:windowsupdate");
			this.AddChildTreeNode(treeData19, "Check for updates", "ms-settings:windowsupdate-action");
			this.AddChildTreeNode(treeData19, "View update history", "ms-settings:windowsupdate-history");
			this.AddChildTreeNode(treeData19, "Restart options", "ms-settings:windowsupdate-restartoptions");
			this.AddChildTreeNode(treeData19, "Advanced options", "ms-settings:windowsupdate-options");
			this.AddChildTreeNode(treeData19, "Change active hours", "ms-settings:windowsupdate-activehours");
			this.AddChildTreeNode(treeData19, "Optional updates", "ms-settings:windowsupdate-optionalupdates");
			this.AddChildTreeNode(treeData, "Delivery Optimization", "ms-settings:delivery-optimization");
			TreeData<string> treeData20 = this.AddChildTreeNode(treeData, "Windows Security (Defender)", "ms-settings:windowsdefender");
			this.AddChildTreeNode(treeData20, "Open Windows Security", "windowsdefender:");
			this.AddChildTreeNode(treeData, "Backup", "ms-settings:backup");
			this.AddChildTreeNode(treeData, "Troubleshoot", "ms-settings:troubleshoot");
			this.AddChildTreeNode(treeData, "Recovery", "ms-settings:recovery");
			this.AddChildTreeNode(treeData, "Activation", "ms-settings:activation");
			this.AddChildTreeNode(treeData, "Find My Device", "ms-settings:findmydevice");
			this.AddChildTreeNode(treeData, "For developers", "ms-settings:developers");
			this.AddChildTreeNode(treeData, "Windows Insider Program", "ms-settings:windowsinsider");
			this._mssettings.Children.Add(treeData);
			treeData = new TreeData<string>("Mixed reality");
			this.AddChildTreeNode(treeData, "Audio and speech", "ms-settings:holographic-audio");
			this.AddChildTreeNode(treeData, "Environment", "ms-settings:privacy-holographic-environment");
			this.AddChildTreeNode(treeData, "Headset display", "ms-settings:holographic-headset");
			this.AddChildTreeNode(treeData, "Uninstall", "ms-settings:holographic-management");
			this._mssettings.Children.Add(treeData);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00194A08 File Offset: 0x00192C08
		private TreeData<string> AddChildTreeNode(TreeData<string> root, string ChildNodeTitle, string URICommand)
		{
			int num = 0;
			TreeData<string> treeData2;
			do
			{
				TreeData<string> treeData;
				if (num == 2)
				{
					treeData.Name = URICommand;
					num = 3;
				}
				if (num == 4)
				{
					break;
				}
				if (num == 3)
				{
					treeData2 = treeData;
					num = 4;
				}
				if (num == 1)
				{
					treeData = root.AddChild(ChildNodeTitle);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			return treeData2;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00194ACC File Offset: 0x00192CCC
		public TreeData<string> GetURICommandList()
		{
			int num = 0;
			TreeData<string> mssettings;
			while (num != 2)
			{
				if (num == 1)
				{
					mssettings = this._mssettings;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return mssettings;
		}

		// Token: 0x04000A61 RID: 2657
		private TreeData<string> _mssettings;

		// Token: 0x04000A62 RID: 2658
		private WinVer.WindowsVersion OSVersion = WinVer.GetWindowsVersion();

		// Token: 0x04000A63 RID: 2659
		private int BuildNumber = WinVer.GetOSBuildNumber();
	}
}
