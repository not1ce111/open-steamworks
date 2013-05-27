// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientDeviceAuthVTable
	{
		public IntPtr AuthorizeLocalDevice0;
		public IntPtr DeauthorizeLocalDevice1;
		public IntPtr GetDeviceAuthorizations2;
		public IntPtr GetDeviceAuthorizationInfo3;
		private IntPtr DTorIClientDeviceAuth4;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTDEVICEAUTH_INTERFACE_VERSION001")]
	public class IClientDeviceAuth : InteropHelp.NativeWrapper<IClientDeviceAuthVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeAuthorizeLocalDeviceSU( IntPtr thisptr, string pubUnk, UInt32 cubUnk );
		public UInt64 AuthorizeLocalDevice( string pubUnk, UInt32 cubUnk ) 
		{
			return this.GetFunction<NativeAuthorizeLocalDeviceSU>( this.Functions.AuthorizeLocalDevice0 )( this.ObjectAddress, pubUnk, cubUnk ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDeauthorizeLocalDeviceU( IntPtr thisptr, UInt32 uUnk );
		public UInt64 DeauthorizeLocalDevice( UInt32 uUnk ) 
		{
			return this.GetFunction<NativeDeauthorizeLocalDeviceU>( this.Functions.DeauthorizeLocalDevice1 )( this.ObjectAddress, uUnk ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetDeviceAuthorizationsUU( IntPtr thisptr, ref UInt32 puUnk, UInt32 uUnk );
		public UInt32 GetDeviceAuthorizations( ref UInt32 puUnk, UInt32 uUnk ) 
		{
			return this.GetFunction<NativeGetDeviceAuthorizationsUU>( this.Functions.GetDeviceAuthorizations2 )( this.ObjectAddress, ref puUnk, uUnk ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDeviceAuthorizationInfoUUBSI( IntPtr thisptr, UInt32 uUnk, ref UInt32 puUnk, ref bool pbUnk, StringBuilder pubUnk, Int32 cubUnk );
		public bool GetDeviceAuthorizationInfo( UInt32 uUnk, ref UInt32 puUnk, ref bool pbUnk, StringBuilder pubUnk ) 
		{
			return this.GetFunction<NativeGetDeviceAuthorizationInfoUUBSI>( this.Functions.GetDeviceAuthorizationInfo3 )( this.ObjectAddress, uUnk, ref puUnk, ref pbUnk, pubUnk, (Int32) pubUnk.Capacity ); 
		}
		
	};
}
