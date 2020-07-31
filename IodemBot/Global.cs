﻿using System;
using Discord.WebSocket;

namespace IodemBot
{
    internal static class Global
    {
        public static DateTime RunningSince { get; internal set; }
        internal static DiscordSocketClient Client { get; set; }
        internal static ulong MessageIdToTrack { get; set; }
        internal static Random Random { get; set; } = new Random();
        internal static DateTime UpSince { get; set; }

        internal static string DateString
        {
            get
            {
                return DateTime.Now.ToString("MM_dd_HH-mm-ss");
            }
        }
    }
}