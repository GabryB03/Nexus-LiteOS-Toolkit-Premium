using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Login_HWID.Properties
{
	// Token: 0x02000053 RID: 83
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x000916D4 File Offset: 0x0008F8D4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040003EE RID: 1006
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
