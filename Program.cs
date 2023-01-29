using Steamworks;
if (!SteamAPI.Init())
{
    Console.Error.WriteLine("[Steamworks.NET] SteamAPI_Init() failed.");
    return;
}
else
{
    Console.Clear();
    Thread.Sleep(1000);
    while (true)
    {
        Console.WriteLine("WARNING: This is app is not in any way affiliated with Steam or Valve. The creator of this app is not responsible for any Steam, VAC, or other bans / punishments.");
        Console.WriteLine("");
        Console.WriteLine("NOTE: You can change the targeted Steam game by changing the Steam app id in the 'steam_appid.txt' file.");
        Console.WriteLine("");
        Console.Write("Give achievement index number: ");
        uint achievementIndex = Convert.ToUInt32(Console.ReadLine());
        SteamUserStats.SetAchievement(SteamUserStats.GetAchievementName(achievementIndex));
        Console.WriteLine("The achievement is now unlocked. Please close this application to get it.");
        Thread.Sleep(2000);
        Console.WriteLine("");
    }
}
