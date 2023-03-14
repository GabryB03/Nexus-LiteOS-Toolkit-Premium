using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32
{
	// Token: 0x02000087 RID: 135
	[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
	[CompilerGenerated]
	[DefaultMember("Title")]
	[TypeIdentifier]
	[ComImport]
	public interface Folder
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000AAF RID: 2735
		[DispId(0)]
		[IndexerName("Title")]
		string Title
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		// Token: 0x06000AB0 RID: 2736
		void _VtblGap1_4();

		// Token: 0x06000AB1 RID: 2737
		[DispId(1610743813)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		FolderItem ParseName([MarshalAs(UnmanagedType.BStr)] [In] string bName);
	}
}
