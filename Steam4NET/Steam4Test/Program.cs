﻿using System;
using Steam4NET;

namespace Steam4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Steamworks.Load())
                return;

            ISteamClient008 steamclient = Steamworks.CreateInterface<ISteamClient008>("SteamClient008");
            int pipe = steamclient.CreateSteamPipe();
            int user = steamclient.ConnectToGlobalUser(pipe);

            Console.WriteLine(user);
            Console.WriteLine(pipe);

            ISteamUtils004 utils = Steamworks.CastInterface<ISteamUtils004>(steamclient.GetISteamUtils(pipe, "SteamUtils004"));
            ISteamFriends005 friends = Steamworks.CastInterface<ISteamFriends005>(steamclient.GetISteamFriends(user, pipe, "SteamFriends005"));

            Console.WriteLine(utils.GetAppID());
            Console.WriteLine(utils.GetConnectedUniverse());
            Console.WriteLine(utils.GetIPCountry());

            Console.WriteLine(friends.GetPersonaName());

            CSteamID steamid = new CSteamID();// friends.GetFriendByIndex(0, 0);
            
            steamid.SteamID_t.m_unAll64Bits = 76561197983869206;

            Console.WriteLine(friends.GetFriendPersonaName( steamid ));

            Console.ReadKey();

            steamclient.ReleaseUser(pipe, user);

            Console.WriteLine(steamclient.ReleaseSteamPipe(pipe));
        }
    }
}