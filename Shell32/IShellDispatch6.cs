using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32
{
	// Token: 0x0200008E RID: 142
	[TypeIdentifier]
	[CompilerGenerated]
	[Guid("286E6F1B-7113-4355-9562-96B7E9D64C54")]
	[ComImport]
	public interface IShellDispatch6 : IShellDispatch5
	{
		// Token: 0x06000AB7 RID: 2743
		void _VtblGap1_2();

		// Token: 0x06000AB8 RID: 2744
		[DispId(1610743810)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Folder NameSpace([MarshalAs(UnmanagedType.Struct)] [In] object vDir);
	}
}
