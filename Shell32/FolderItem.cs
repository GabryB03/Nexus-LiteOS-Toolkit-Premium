using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32
{
	// Token: 0x02000088 RID: 136
	[CompilerGenerated]
	[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
	[DefaultMember("Name")]
	[TypeIdentifier]
	[ComImport]
	public interface FolderItem
	{
		// Token: 0x06000AB2 RID: 2738
		void _VtblGap1_2();

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000AB3 RID: 2739
		// (set) Token: 0x06000AB4 RID: 2740
		[DispId(0)]
		[IndexerName("Name")]
		string Name
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			[param: In]
			set;
		}

		// Token: 0x06000AB5 RID: 2741
		void _VtblGap2_1();

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000AB6 RID: 2742
		[DispId(1610743813)]
		object GetLink
		{
			[DispId(1610743813)]
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.IDispatch)]
			get;
		}
	}
}
