// This file is automatically generated!

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamUserStats {
		public static bool RequestCurrentStats() {
			return NativeMethods.ISteamUserStats_RequestCurrentStats();
		}

		public static bool GetStat(string pchName, out int pData) {
			return NativeMethods.ISteamUserStats_GetStat(new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool GetStat(string pchName, out float pData) {
			return NativeMethods.ISteamUserStats_GetStat_(new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool SetStat(string pchName, int nData) {
			return NativeMethods.ISteamUserStats_SetStat(new InteropHelp.UTF8String(pchName), nData);
		}

		public static bool SetStat(string pchName, float fData) {
			return NativeMethods.ISteamUserStats_SetStat_(new InteropHelp.UTF8String(pchName), fData);
		}

		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) {
			return NativeMethods.ISteamUserStats_UpdateAvgRateStat(new InteropHelp.UTF8String(pchName), flCountThisSession, dSessionLength);
		}

		public static bool GetAchievement(string pchName, out bool pbAchieved) {
			return NativeMethods.ISteamUserStats_GetAchievement(new InteropHelp.UTF8String(pchName), out pbAchieved);
		}

		public static bool SetAchievement(string pchName) {
			return NativeMethods.ISteamUserStats_SetAchievement(new InteropHelp.UTF8String(pchName));
		}

		public static bool ClearAchievement(string pchName) {
			return NativeMethods.ISteamUserStats_ClearAchievement(new InteropHelp.UTF8String(pchName));
		}

		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) {
			return NativeMethods.ISteamUserStats_GetAchievementAndUnlockTime(new InteropHelp.UTF8String(pchName), out pbAchieved, out punUnlockTime);
		}

		public static bool StoreStats() {
			return NativeMethods.ISteamUserStats_StoreStats();
		}

		public static int GetAchievementIcon(string pchName) {
			return NativeMethods.ISteamUserStats_GetAchievementIcon(new InteropHelp.UTF8String(pchName));
		}

		public static string GetAchievementDisplayAttribute(string pchName, string pchKey) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementDisplayAttribute(new InteropHelp.UTF8String(pchName), new InteropHelp.UTF8String(pchKey)));
		}

		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) {
			return NativeMethods.ISteamUserStats_IndicateAchievementProgress(new InteropHelp.UTF8String(pchName), nCurProgress, nMaxProgress);
		}

		public static uint GetNumAchievements() {
			return NativeMethods.ISteamUserStats_GetNumAchievements();
		}

		public static string GetAchievementName(uint iAchievement) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementName(iAchievement));
		}

		public static ulong RequestUserStats(ulong steamIDUser) {
			return NativeMethods.ISteamUserStats_RequestUserStats(steamIDUser);
		}

		public static bool GetUserStat(ulong steamIDUser, string pchName, out int pData) {
			return NativeMethods.ISteamUserStats_GetUserStat(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool GetUserStat(ulong steamIDUser, string pchName, out float pData) {
			return NativeMethods.ISteamUserStats_GetUserStat_(steamIDUser, new InteropHelp.UTF8String(pchName), out pData);
		}

		public static bool GetUserAchievement(ulong steamIDUser, string pchName, out bool pbAchieved) {
			return NativeMethods.ISteamUserStats_GetUserAchievement(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved);
		}

		public static bool GetUserAchievementAndUnlockTime(ulong steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) {
			return NativeMethods.ISteamUserStats_GetUserAchievementAndUnlockTime(steamIDUser, new InteropHelp.UTF8String(pchName), out pbAchieved, out punUnlockTime);
		}

		public static bool ResetAllStats(bool bAchievementsToo) {
			return NativeMethods.ISteamUserStats_ResetAllStats(bAchievementsToo);
		}

		public static ulong FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) {
			return NativeMethods.ISteamUserStats_FindOrCreateLeaderboard(new InteropHelp.UTF8String(pchLeaderboardName), eLeaderboardSortMethod, eLeaderboardDisplayType);
		}

		public static ulong FindLeaderboard(string pchLeaderboardName) {
			return NativeMethods.ISteamUserStats_FindLeaderboard(new InteropHelp.UTF8String(pchLeaderboardName));
		}

		public static string GetLeaderboardName(ulong hSteamLeaderboard) {
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetLeaderboardName(hSteamLeaderboard));
		}

		public static int GetLeaderboardEntryCount(ulong hSteamLeaderboard) {
			return NativeMethods.ISteamUserStats_GetLeaderboardEntryCount(hSteamLeaderboard);
		}

		public static ELeaderboardSortMethod GetLeaderboardSortMethod(ulong hSteamLeaderboard) {
			return NativeMethods.ISteamUserStats_GetLeaderboardSortMethod(hSteamLeaderboard);
		}

		public static ELeaderboardDisplayType GetLeaderboardDisplayType(ulong hSteamLeaderboard) {
			return NativeMethods.ISteamUserStats_GetLeaderboardDisplayType(hSteamLeaderboard);
		}

		public static ulong DownloadLeaderboardEntries(ulong hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) {
			return NativeMethods.ISteamUserStats_DownloadLeaderboardEntries(hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
		}

		public static ulong DownloadLeaderboardEntriesForUsers(ulong hSteamLeaderboard, IntPtr prgUsers, int cUsers) {
			return NativeMethods.ISteamUserStats_DownloadLeaderboardEntriesForUsers(hSteamLeaderboard, prgUsers, cUsers);
		}

		public static bool GetDownloadedLeaderboardEntry(ulong hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, out int pDetails, int cDetailsMax) {
			return NativeMethods.ISteamUserStats_GetDownloadedLeaderboardEntry(hSteamLeaderboardEntries, index, out pLeaderboardEntry, out pDetails, cDetailsMax);
		}

		public static ulong UploadLeaderboardScore(ulong hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, IntPtr pScoreDetails, int cScoreDetailsCount) {
			return NativeMethods.ISteamUserStats_UploadLeaderboardScore(hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
		}

		public static ulong AttachLeaderboardUGC(ulong hSteamLeaderboard, ulong hUGC) {
			return NativeMethods.ISteamUserStats_AttachLeaderboardUGC(hSteamLeaderboard, hUGC);
		}

		public static ulong GetNumberOfCurrentPlayers() {
			return NativeMethods.ISteamUserStats_GetNumberOfCurrentPlayers();
		}

		public static ulong RequestGlobalAchievementPercentages() {
			return NativeMethods.ISteamUserStats_RequestGlobalAchievementPercentages();
		}

		public static int GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) {
			return NativeMethods.ISteamUserStats_GetMostAchievedAchievementInfo(pchName, unNameBufLen, out pflPercent, out pbAchieved);
		}

		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) {
			return NativeMethods.ISteamUserStats_GetNextMostAchievedAchievementInfo(iIteratorPrevious, pchName, unNameBufLen, out pflPercent, out pbAchieved);
		}

		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) {
			return NativeMethods.ISteamUserStats_GetAchievementAchievedPercent(new InteropHelp.UTF8String(pchName), out pflPercent);
		}

		public static ulong RequestGlobalStats(int nHistoryDays) {
			return NativeMethods.ISteamUserStats_RequestGlobalStats(nHistoryDays);
		}

		public static bool GetGlobalStat(string pchStatName, out long pData) {
			return NativeMethods.ISteamUserStats_GetGlobalStat(new InteropHelp.UTF8String(pchStatName), out pData);
		}

		public static bool GetGlobalStat(string pchStatName, out double pData) {
			return NativeMethods.ISteamUserStats_GetGlobalStat_(new InteropHelp.UTF8String(pchStatName), out pData);
		}

		public static int GetGlobalStatHistory(string pchStatName, out long pData, uint cubData) {
			return NativeMethods.ISteamUserStats_GetGlobalStatHistory(new InteropHelp.UTF8String(pchStatName), out pData, cubData);
		}

		public static int GetGlobalStatHistory(string pchStatName, out double pData, uint cubData) {
			return NativeMethods.ISteamUserStats_GetGlobalStatHistory_(new InteropHelp.UTF8String(pchStatName), out pData, cubData);
		}
#if _PS3
		public static bool InstallPS3Trophies() {
			return NativeMethods.ISteamUserStats_InstallPS3Trophies();
		}

		public static ulong GetTrophySpaceRequiredBeforeInstall() {
			return NativeMethods.ISteamUserStats_GetTrophySpaceRequiredBeforeInstall();
		}

		public static bool SetUserStatsData(IntPtr pvData, uint cubData) {
			return NativeMethods.ISteamUserStats_SetUserStatsData(pvData, cubData);
		}

		public static bool GetUserStatsData(IntPtr pvData, uint cubData, out uint pcubWritten) {
			return NativeMethods.ISteamUserStats_GetUserStatsData(pvData, cubData, out pcubWritten);
		}
#endif
	}
}