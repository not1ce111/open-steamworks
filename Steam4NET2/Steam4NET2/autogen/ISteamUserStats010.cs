// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUserStats010VTable
	{
		public IntPtr RequestCurrentStats0;
		public IntPtr GetStat1;
		public IntPtr GetStat2;
		public IntPtr SetStat3;
		public IntPtr SetStat4;
		public IntPtr UpdateAvgRateStat5;
		public IntPtr GetAchievement6;
		public IntPtr SetAchievement7;
		public IntPtr ClearAchievement8;
		public IntPtr GetAchievementAndUnlockTime9;
		public IntPtr StoreStats10;
		public IntPtr GetAchievementIcon11;
		public IntPtr GetAchievementDisplayAttribute12;
		public IntPtr IndicateAchievementProgress13;
		public IntPtr RequestUserStats14;
		public IntPtr GetUserStat15;
		public IntPtr GetUserStat16;
		public IntPtr GetUserAchievement17;
		public IntPtr GetUserAchievementAndUnlockTime18;
		public IntPtr ResetAllStats19;
		public IntPtr FindOrCreateLeaderboard20;
		public IntPtr FindLeaderboard21;
		public IntPtr GetLeaderboardName22;
		public IntPtr GetLeaderboardEntryCount23;
		public IntPtr GetLeaderboardSortMethod24;
		public IntPtr GetLeaderboardDisplayType25;
		public IntPtr DownloadLeaderboardEntries26;
		public IntPtr DownloadLeaderboardEntriesForUsers27;
		public IntPtr GetDownloadedLeaderboardEntry28;
		public IntPtr UploadLeaderboardScore29;
		public IntPtr AttachLeaderboardUGC30;
		public IntPtr GetNumberOfCurrentPlayers31;
		public IntPtr RequestGlobalAchievementPercentages32;
		public IntPtr GetMostAchievedAchievementInfo33;
		public IntPtr GetNextMostAchievedAchievementInfo34;
		public IntPtr GetAchievementAchievedPercent35;
		public IntPtr RequestGlobalStats36;
		public IntPtr GetGlobalStat37;
		public IntPtr GetGlobalStat38;
		public IntPtr GetGlobalStatHistory39;
		public IntPtr GetGlobalStatHistory40;
		private IntPtr DTorISteamUserStats01041;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION010")]
	public class ISteamUserStats010 : InteropHelp.NativeWrapper<ISteamUserStats010VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestCurrentStats( IntPtr thisptr );
		public bool RequestCurrentStats(  ) 
		{
			return this.GetFunction<NativeRequestCurrentStats>( this.Functions.RequestCurrentStats0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSF( IntPtr thisptr, string pchName, ref float pData );
		public bool GetStat( string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetStatSF>( this.Functions.GetStat1 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetStatSI( IntPtr thisptr, string pchName, ref Int32 pData );
		public bool GetStat( string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetStatSI>( this.Functions.GetStat2 )( this.ObjectAddress, pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSF( IntPtr thisptr, string pchName, float fData );
		public bool SetStat( string pchName, float fData ) 
		{
			return this.GetFunction<NativeSetStatSF>( this.Functions.SetStat3 )( this.ObjectAddress, pchName, fData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStatSI( IntPtr thisptr, string pchName, Int32 nData );
		public bool SetStat( string pchName, Int32 nData ) 
		{
			return this.GetFunction<NativeSetStatSI>( this.Functions.SetStat4 )( this.ObjectAddress, pchName, nData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateAvgRateStatSFD( IntPtr thisptr, string pchName, float flCountThisSession, double dSessionLength );
		public bool UpdateAvgRateStat( string pchName, float flCountThisSession, double dSessionLength ) 
		{
			return this.GetFunction<NativeUpdateAvgRateStatSFD>( this.Functions.UpdateAvgRateStat5 )( this.ObjectAddress, pchName, flCountThisSession, dSessionLength ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementSB( IntPtr thisptr, string pchName, ref bool pbAchieved );
		public bool GetAchievement( string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetAchievementSB>( this.Functions.GetAchievement6 )( this.ObjectAddress, pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAchievementS( IntPtr thisptr, string pchName );
		public bool SetAchievement( string pchName ) 
		{
			return this.GetFunction<NativeSetAchievementS>( this.Functions.SetAchievement7 )( this.ObjectAddress, pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearAchievementS( IntPtr thisptr, string pchName );
		public bool ClearAchievement( string pchName ) 
		{
			return this.GetFunction<NativeClearAchievementS>( this.Functions.ClearAchievement8 )( this.ObjectAddress, pchName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementAndUnlockTimeSBU( IntPtr thisptr, string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime );
		public bool GetAchievementAndUnlockTime( string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime ) 
		{
			return this.GetFunction<NativeGetAchievementAndUnlockTimeSBU>( this.Functions.GetAchievementAndUnlockTime9 )( this.ObjectAddress, pchName, ref pbAchieved, ref punUnlockTime ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeStoreStats( IntPtr thisptr );
		public bool StoreStats(  ) 
		{
			return this.GetFunction<NativeStoreStats>( this.Functions.StoreStats10 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAchievementIconS( IntPtr thisptr, string pchName );
		public Int32 GetAchievementIcon( string pchName ) 
		{
			return this.GetFunction<NativeGetAchievementIconS>( this.Functions.GetAchievementIcon11 )( this.ObjectAddress, pchName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetAchievementDisplayAttributeSS( IntPtr thisptr, string pchName, string pchKey );
		public string GetAchievementDisplayAttribute( string pchName, string pchKey ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetAchievementDisplayAttributeSS>( this.Functions.GetAchievementDisplayAttribute12 )( this.ObjectAddress, pchName, pchKey ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIndicateAchievementProgressSUU( IntPtr thisptr, string pchName, UInt32 nCurProgress, UInt32 nMaxProgress );
		public bool IndicateAchievementProgress( string pchName, UInt32 nCurProgress, UInt32 nMaxProgress ) 
		{
			return this.GetFunction<NativeIndicateAchievementProgressSUU>( this.Functions.IndicateAchievementProgress13 )( this.ObjectAddress, pchName, nCurProgress, nMaxProgress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsC( IntPtr thisptr, UInt64 steamIDUser );
		public UInt64 RequestUserStats( CSteamID steamIDUser ) 
		{
			return this.GetFunction<NativeRequestUserStatsC>( this.Functions.RequestUserStats14 )( this.ObjectAddress, steamIDUser.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSF( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref float pData );
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref float pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSF>( this.Functions.GetUserStat15 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCSI( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref Int32 pData );
		public bool GetUserStat( CSteamID steamIDUser, string pchName, ref Int32 pData ) 
		{
			return this.GetFunction<NativeGetUserStatCSI>( this.Functions.GetUserStat16 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCSB( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved );
		public bool GetUserAchievement( CSteamID steamIDUser, string pchName, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetUserAchievementCSB>( this.Functions.GetUserAchievement17 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementAndUnlockTimeCSBU( IntPtr thisptr, UInt64 steamIDUser, string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime );
		public bool GetUserAchievementAndUnlockTime( CSteamID steamIDUser, string pchName, ref bool pbAchieved, ref UInt32 punUnlockTime ) 
		{
			return this.GetFunction<NativeGetUserAchievementAndUnlockTimeCSBU>( this.Functions.GetUserAchievementAndUnlockTime18 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchName, ref pbAchieved, ref punUnlockTime ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeResetAllStatsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bAchievementsToo );
		public bool ResetAllStats( bool bAchievementsToo ) 
		{
			return this.GetFunction<NativeResetAllStatsB>( this.Functions.ResetAllStats19 )( this.ObjectAddress, bAchievementsToo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindOrCreateLeaderboardSEE( IntPtr thisptr, string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType );
		public UInt64 FindOrCreateLeaderboard( string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType ) 
		{
			return this.GetFunction<NativeFindOrCreateLeaderboardSEE>( this.Functions.FindOrCreateLeaderboard20 )( this.ObjectAddress, pchLeaderboardName, eLeaderboardSortMethod, eLeaderboardDisplayType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFindLeaderboardS( IntPtr thisptr, string pchLeaderboardName );
		public UInt64 FindLeaderboard( string pchLeaderboardName ) 
		{
			return this.GetFunction<NativeFindLeaderboardS>( this.Functions.FindLeaderboard21 )( this.ObjectAddress, pchLeaderboardName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLeaderboardNameU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public string GetLeaderboardName( UInt64 hSteamLeaderboard ) 
		{
			return Marshal.PtrToStringAnsi( this.GetFunction<NativeGetLeaderboardNameU>( this.Functions.GetLeaderboardName22 )( this.ObjectAddress, hSteamLeaderboard ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLeaderboardEntryCountU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public Int32 GetLeaderboardEntryCount( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardEntryCountU>( this.Functions.GetLeaderboardEntryCount23 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardSortMethod NativeGetLeaderboardSortMethodU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardSortMethod GetLeaderboardSortMethod( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardSortMethodU>( this.Functions.GetLeaderboardSortMethod24 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELeaderboardDisplayType NativeGetLeaderboardDisplayTypeU( IntPtr thisptr, UInt64 hSteamLeaderboard );
		public ELeaderboardDisplayType GetLeaderboardDisplayType( UInt64 hSteamLeaderboard ) 
		{
			return this.GetFunction<NativeGetLeaderboardDisplayTypeU>( this.Functions.GetLeaderboardDisplayType25 )( this.ObjectAddress, hSteamLeaderboard ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesUEII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd );
		public UInt64 DownloadLeaderboardEntries( UInt64 hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, Int32 nRangeStart, Int32 nRangeEnd ) 
		{
			return this.GetFunction<NativeDownloadLeaderboardEntriesUEII>( this.Functions.DownloadLeaderboardEntries26 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadLeaderboardEntriesForUsersUCI( IntPtr thisptr, UInt64 hSteamLeaderboard, ref UInt64 prgUsers, Int32 cUsers );
		public UInt64 DownloadLeaderboardEntriesForUsers( UInt64 hSteamLeaderboard, ref CSteamID prgUsers, Int32 cUsers ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeDownloadLeaderboardEntriesForUsersUCI>( this.Functions.DownloadLeaderboardEntriesForUsers27 )( this.ObjectAddress, hSteamLeaderboard, ref s0, cUsers ); prgUsers = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetDownloadedLeaderboardEntryUILII( IntPtr thisptr, UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax );
		public bool GetDownloadedLeaderboardEntry( UInt64 hSteamLeaderboardEntries, Int32 index, ref LeaderboardEntry002_t pLeaderboardEntry, ref Int32 pDetails, Int32 cDetailsMax ) 
		{
			return this.GetFunction<NativeGetDownloadedLeaderboardEntryUILII>( this.Functions.GetDownloadedLeaderboardEntry28 )( this.ObjectAddress, hSteamLeaderboardEntries, index, ref pLeaderboardEntry, ref pDetails, cDetailsMax ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUploadLeaderboardScoreUEIII( IntPtr thisptr, UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount );
		public UInt64 UploadLeaderboardScore( UInt64 hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, Int32 nScore, ref Int32 pScoreDetails, Int32 cScoreDetailsCount ) 
		{
			return this.GetFunction<NativeUploadLeaderboardScoreUEIII>( this.Functions.UploadLeaderboardScore29 )( this.ObjectAddress, hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, ref pScoreDetails, cScoreDetailsCount ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeAttachLeaderboardUGCUU( IntPtr thisptr, UInt64 hSteamLeaderboard, UInt64 hUGC );
		public UInt64 AttachLeaderboardUGC( UInt64 hSteamLeaderboard, UInt64 hUGC ) 
		{
			return this.GetFunction<NativeAttachLeaderboardUGCUU>( this.Functions.AttachLeaderboardUGC30 )( this.ObjectAddress, hSteamLeaderboard, hUGC ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetNumberOfCurrentPlayers( IntPtr thisptr );
		public UInt64 GetNumberOfCurrentPlayers(  ) 
		{
			return this.GetFunction<NativeGetNumberOfCurrentPlayers>( this.Functions.GetNumberOfCurrentPlayers31 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestGlobalAchievementPercentages( IntPtr thisptr );
		public UInt64 RequestGlobalAchievementPercentages(  ) 
		{
			return this.GetFunction<NativeRequestGlobalAchievementPercentages>( this.Functions.RequestGlobalAchievementPercentages32 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMostAchievedAchievementInfoSUFB( IntPtr thisptr, StringBuilder pchName, UInt32 unNameBufLen, ref float pflPercent, ref bool pbAchieved );
		public Int32 GetMostAchievedAchievementInfo( StringBuilder pchName, ref float pflPercent, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetMostAchievedAchievementInfoSUFB>( this.Functions.GetMostAchievedAchievementInfo33 )( this.ObjectAddress, pchName, (UInt32) pchName.Capacity, ref pflPercent, ref pbAchieved ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNextMostAchievedAchievementInfoISUFB( IntPtr thisptr, Int32 iIteratorPrevious, StringBuilder pchName, UInt32 unNameBufLen, ref float pflPercent, ref bool pbAchieved );
		public Int32 GetNextMostAchievedAchievementInfo( Int32 iIteratorPrevious, StringBuilder pchName, ref float pflPercent, ref bool pbAchieved ) 
		{
			return this.GetFunction<NativeGetNextMostAchievedAchievementInfoISUFB>( this.Functions.GetNextMostAchievedAchievementInfo34 )( this.ObjectAddress, iIteratorPrevious, pchName, (UInt32) pchName.Capacity, ref pflPercent, ref pbAchieved ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAchievementAchievedPercentSF( IntPtr thisptr, string pchName, ref float pflPercent );
		public bool GetAchievementAchievedPercent( string pchName, ref float pflPercent ) 
		{
			return this.GetFunction<NativeGetAchievementAchievedPercentSF>( this.Functions.GetAchievementAchievedPercent35 )( this.ObjectAddress, pchName, ref pflPercent ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestGlobalStatsI( IntPtr thisptr, Int32 nHistoryDays );
		public UInt64 RequestGlobalStats( Int32 nHistoryDays ) 
		{
			return this.GetFunction<NativeRequestGlobalStatsI>( this.Functions.RequestGlobalStats36 )( this.ObjectAddress, nHistoryDays ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGlobalStatSD( IntPtr thisptr, string pchStatName, ref double pData );
		public bool GetGlobalStat( string pchStatName, ref double pData ) 
		{
			return this.GetFunction<NativeGetGlobalStatSD>( this.Functions.GetGlobalStat37 )( this.ObjectAddress, pchStatName, ref pData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetGlobalStatSI( IntPtr thisptr, string pchStatName, ref Int64 pData );
		public bool GetGlobalStat( string pchStatName, ref Int64 pData ) 
		{
			return this.GetFunction<NativeGetGlobalStatSI>( this.Functions.GetGlobalStat38 )( this.ObjectAddress, pchStatName, ref pData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetGlobalStatHistorySDU( IntPtr thisptr, string pchStatName, ref double pData, UInt32 cubData );
		public Int32 GetGlobalStatHistory( string pchStatName, ref double pData, UInt32 cubData ) 
		{
			return this.GetFunction<NativeGetGlobalStatHistorySDU>( this.Functions.GetGlobalStatHistory39 )( this.ObjectAddress, pchStatName, ref pData, cubData ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetGlobalStatHistorySIU( IntPtr thisptr, string pchStatName, ref Int64 pData, UInt32 cubData );
		public Int32 GetGlobalStatHistory( string pchStatName, ref Int64 pData, UInt32 cubData ) 
		{
			return this.GetFunction<NativeGetGlobalStatHistorySIU>( this.Functions.GetGlobalStatHistory40 )( this.ObjectAddress, pchStatName, ref pData, cubData ); 
		}
		
	};
}
