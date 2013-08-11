// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientUtilsVTable
	{
		public IntPtr GetInstallPath0;
		public IntPtr GetUserBaseFolderInstallImage1;
		public IntPtr GetManagedContentRoot2;
		public IntPtr GetSecondsSinceAppActive3;
		public IntPtr GetSecondsSinceComputerActive4;
		public IntPtr SetComputerActive5;
		public IntPtr GetConnectedUniverse6;
		public IntPtr GetServerRealTime7;
		public IntPtr GetIPCountry8;
		public IntPtr GetImageSize9;
		public IntPtr GetImageRGBA10;
		public IntPtr GetCSERIPPort11;
		public IntPtr GetNumRunningApps12;
		public IntPtr GetCurrentBatteryPower13;
		public IntPtr SetOfflineMode14;
		public IntPtr GetOfflineMode15;
		public IntPtr SetAppIDForCurrentPipe16;
		public IntPtr GetAppID17;
		public IntPtr SetAPIDebuggingActive18;
		public IntPtr IsAPICallCompleted19;
		public IntPtr GetAPICallFailureReason20;
		public IntPtr GetAPICallResult21;
		public IntPtr SignalAppsToShutDown22;
		public IntPtr GetCellID23;
		public IntPtr BIsGlobalInstance24;
		public IntPtr CheckFileSignature25;
		public IntPtr GetBuildID26;
		public IntPtr SetCurrentUIMode27;
		public IntPtr ShowGamepadTextInput28;
		public IntPtr GetEnteredGamepadTextLength29;
		public IntPtr GetEnteredGamepadTextInput30;
		public IntPtr GamepadTextInputClosed31;
		public IntPtr SetSpew32;
		public IntPtr BDownloadsDisabled33;
		public IntPtr SetFocusedWindow34;
		public IntPtr GetSteamUILanguage35;
		private IntPtr DTorIClientUtils36;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTUTILS_INTERFACE_VERSION001")]
	public class IClientUtils : InteropHelp.NativeWrapper<IClientUtilsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetInstallPath( IntPtr thisptr );
		public string GetInstallPath(  ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetInstallPath>( this.Functions.GetInstallPath0 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetUserBaseFolderInstallImage( IntPtr thisptr );
		public string GetUserBaseFolderInstallImage(  ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetUserBaseFolderInstallImage>( this.Functions.GetUserBaseFolderInstallImage1 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetManagedContentRoot( IntPtr thisptr );
		public string GetManagedContentRoot(  ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetManagedContentRoot>( this.Functions.GetManagedContentRoot2 )( this.ObjectAddress ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceAppActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceAppActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceAppActive>( this.Functions.GetSecondsSinceAppActive3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceComputerActive( IntPtr thisptr );
		public UInt32 GetSecondsSinceComputerActive(  ) 
		{
			return this.GetFunction<NativeGetSecondsSinceComputerActive>( this.Functions.GetSecondsSinceComputerActive4 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetComputerActive( IntPtr thisptr );
		public void SetComputerActive(  ) 
		{
			this.GetFunction<NativeSetComputerActive>( this.Functions.SetComputerActive5 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse( IntPtr thisptr );
		public EUniverse GetConnectedUniverse(  ) 
		{
			return this.GetFunction<NativeGetConnectedUniverse>( this.Functions.GetConnectedUniverse6 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetServerRealTime( IntPtr thisptr );
		public UInt32 GetServerRealTime(  ) 
		{
			return this.GetFunction<NativeGetServerRealTime>( this.Functions.GetServerRealTime7 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIPCountry( IntPtr thisptr );
		public string GetIPCountry(  ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetIPCountry>( this.Functions.GetIPCountry8 )( this.ObjectAddress ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageSizeIUU( IntPtr thisptr, Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight );
		public bool GetImageSize( Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight ) 
		{
			return this.GetFunction<NativeGetImageSizeIUU>( this.Functions.GetImageSize9 )( this.ObjectAddress, iImage, ref pnWidth, ref pnHeight ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageRGBAIBI( IntPtr thisptr, Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize );
		public bool GetImageRGBA( Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize ) 
		{
			return this.GetFunction<NativeGetImageRGBAIBI>( this.Functions.GetImageRGBA10 )( this.ObjectAddress, iImage, pubDest, nDestBufferSize ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCSERIPPortUU( IntPtr thisptr, ref UInt32 unIP, ref UInt16 usPort );
		public bool GetCSERIPPort( ref UInt32 unIP, ref UInt16 usPort ) 
		{
			return this.GetFunction<NativeGetCSERIPPortUU>( this.Functions.GetCSERIPPort11 )( this.ObjectAddress, ref unIP, ref usPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumRunningApps( IntPtr thisptr );
		public UInt32 GetNumRunningApps(  ) 
		{
			return this.GetFunction<NativeGetNumRunningApps>( this.Functions.GetNumRunningApps12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Byte NativeGetCurrentBatteryPower( IntPtr thisptr );
		public Byte GetCurrentBatteryPower(  ) 
		{
			return this.GetFunction<NativeGetCurrentBatteryPower>( this.Functions.GetCurrentBatteryPower13 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOfflineModeB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bOffline );
		public void SetOfflineMode( bool bOffline ) 
		{
			this.GetFunction<NativeSetOfflineModeB>( this.Functions.SetOfflineMode14 )( this.ObjectAddress, bOffline ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetOfflineMode( IntPtr thisptr );
		public bool GetOfflineMode(  ) 
		{
			return this.GetFunction<NativeGetOfflineMode>( this.Functions.GetOfflineMode15 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeSetAppIDForCurrentPipeUB( IntPtr thisptr, UInt32 nAppID, [MarshalAs(UnmanagedType.I1)] bool bTrackProcess );
		public UInt32 SetAppIDForCurrentPipe( UInt32 nAppID, bool bTrackProcess ) 
		{
			return this.GetFunction<NativeSetAppIDForCurrentPipeUB>( this.Functions.SetAppIDForCurrentPipe16 )( this.ObjectAddress, nAppID, bTrackProcess ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppID( IntPtr thisptr );
		public UInt32 GetAppID(  ) 
		{
			return this.GetFunction<NativeGetAppID>( this.Functions.GetAppID17 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetAPIDebuggingActiveBB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bActive, [MarshalAs(UnmanagedType.I1)] bool bVerbose );
		public void SetAPIDebuggingActive( bool bActive, bool bVerbose ) 
		{
			this.GetFunction<NativeSetAPIDebuggingActiveBB>( this.Functions.SetAPIDebuggingActive18 )( this.ObjectAddress, bActive, bVerbose ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsAPICallCompletedUB( IntPtr thisptr, UInt64 hSteamAPICall, ref bool pbFailed );
		public bool IsAPICallCompleted( UInt64 hSteamAPICall, ref bool pbFailed ) 
		{
			return this.GetFunction<NativeIsAPICallCompletedUB>( this.Functions.IsAPICallCompleted19 )( this.ObjectAddress, hSteamAPICall, ref pbFailed ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamAPICallFailure NativeGetAPICallFailureReasonU( IntPtr thisptr, UInt64 hSteamAPICall );
		public ESteamAPICallFailure GetAPICallFailureReason( UInt64 hSteamAPICall ) 
		{
			return this.GetFunction<NativeGetAPICallFailureReasonU>( this.Functions.GetAPICallFailureReason20 )( this.ObjectAddress, hSteamAPICall ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAPICallResultUBIIB( IntPtr thisptr, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed );
		public bool GetAPICallResult( UInt64 hSteamAPICall, Byte[] pCallback, Int32 iCallbackExpected, ref bool pbFailed ) 
		{
			return this.GetFunction<NativeGetAPICallResultUBIIB>( this.Functions.GetAPICallResult21 )( this.ObjectAddress, hSteamAPICall, pCallback, (Int32) pCallback.Length, iCallbackExpected, ref pbFailed ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSignalAppsToShutDown( IntPtr thisptr );
		public bool SignalAppsToShutDown(  ) 
		{
			return this.GetFunction<NativeSignalAppsToShutDown>( this.Functions.SignalAppsToShutDown22 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetCellID( IntPtr thisptr );
		public UInt32 GetCellID(  ) 
		{
			return this.GetFunction<NativeGetCellID>( this.Functions.GetCellID23 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsGlobalInstance( IntPtr thisptr );
		public bool BIsGlobalInstance(  ) 
		{
			return this.GetFunction<NativeBIsGlobalInstance>( this.Functions.BIsGlobalInstance24 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCheckFileSignatureS( IntPtr thisptr, string szFileName );
		public UInt64 CheckFileSignature( string szFileName ) 
		{
			return this.GetFunction<NativeCheckFileSignatureS>( this.Functions.CheckFileSignature25 )( this.ObjectAddress, szFileName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetBuildID( IntPtr thisptr );
		public UInt64 GetBuildID(  ) 
		{
			return this.GetFunction<NativeGetBuildID>( this.Functions.GetBuildID26 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCurrentUIModeE( IntPtr thisptr, EUIMode eUIMode );
		public void SetCurrentUIMode( EUIMode eUIMode ) 
		{
			this.GetFunction<NativeSetCurrentUIModeE>( this.Functions.SetCurrentUIMode27 )( this.ObjectAddress, eUIMode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeShowGamepadTextInputEESU( IntPtr thisptr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eInputLineMode, string szText, UInt32 uMaxLength );
		public bool ShowGamepadTextInput( EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eInputLineMode, string szText, UInt32 uMaxLength ) 
		{
			return this.GetFunction<NativeShowGamepadTextInputEESU>( this.Functions.ShowGamepadTextInput28 )( this.ObjectAddress, eInputMode, eInputLineMode, szText, uMaxLength ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetEnteredGamepadTextLength( IntPtr thisptr );
		public UInt32 GetEnteredGamepadTextLength(  ) 
		{
			return this.GetFunction<NativeGetEnteredGamepadTextLength>( this.Functions.GetEnteredGamepadTextLength29 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetEnteredGamepadTextInputSU( IntPtr thisptr, StringBuilder pchValue, UInt32 cchValueMax );
		public bool GetEnteredGamepadTextInput( StringBuilder pchValue ) 
		{
			return this.GetFunction<NativeGetEnteredGamepadTextInputSU>( this.Functions.GetEnteredGamepadTextInput30 )( this.ObjectAddress, pchValue, (UInt32) pchValue.Capacity ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGamepadTextInputClosedIBS( IntPtr thisptr, Int32 hSteamPipe, [MarshalAs(UnmanagedType.I1)] bool arg1, string arg2 );
		public void GamepadTextInputClosed( Int32 hSteamPipe, bool arg1, string arg2 ) 
		{
			this.GetFunction<NativeGamepadTextInputClosedIBS>( this.Functions.GamepadTextInputClosed31 )( this.ObjectAddress, hSteamPipe, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpewEII( IntPtr thisptr, ESpewGroup eSpewGroup, Int32 iSpewLevel, Int32 iLogLevel );
		public void SetSpew( ESpewGroup eSpewGroup, Int32 iSpewLevel, Int32 iLogLevel ) 
		{
			this.GetFunction<NativeSetSpewEII>( this.Functions.SetSpew32 )( this.ObjectAddress, eSpewGroup, iSpewLevel, iLogLevel ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBDownloadsDisabled( IntPtr thisptr );
		public bool BDownloadsDisabled(  ) 
		{
			return this.GetFunction<NativeBDownloadsDisabled>( this.Functions.BDownloadsDisabled33 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetFocusedWindowEU( IntPtr thisptr, EWindowType eWindowType, UInt32 uUnk );
		public void SetFocusedWindow( EWindowType eWindowType, UInt32 uUnk ) 
		{
			this.GetFunction<NativeSetFocusedWindowEU>( this.Functions.SetFocusedWindow34 )( this.ObjectAddress, eWindowType, uUnk ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetSteamUILanguage( IntPtr thisptr );
		public string GetSteamUILanguage(  ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetSteamUILanguage>( this.Functions.GetSteamUILanguage35 )( this.ObjectAddress ) ); 
		}
		
	};
}
