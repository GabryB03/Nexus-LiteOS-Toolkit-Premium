using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Login_HWID.Properties
{
	// Token: 0x02000052 RID: 82
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00002090 File Offset: 0x00000290
		internal Resources()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00091654 File Offset: 0x0008F854
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("Login_HWID.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00091694 File Offset: 0x0008F894
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000263D File Offset: 0x0000083D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000916A8 File Offset: 0x0008F8A8
		internal static Bitmap _149
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("149", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040003EC RID: 1004
		private static ResourceManager resourceMan;

		// Token: 0x040003ED RID: 1005
		private static CultureInfo resourceCulture;
	}
}
