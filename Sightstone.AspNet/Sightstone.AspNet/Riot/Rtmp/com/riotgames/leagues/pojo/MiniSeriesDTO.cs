﻿using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.leagues.pojo
{
    [Serializable]
    [SerializedName("com.riotgames.leagues.pojo.MiniSeriesDTO")]
    public class MiniSeriesDTO : IRiotRtmpObject
    {
        [SerializedName("progress")]
        public String Progress { get; set; }

        [SerializedName("target")]
        public int Target { get; set; }

        [SerializedName("losses")]
        public int Losses { get; set; }

        [SerializedName("timeLeftToPlayMillis")]
        public double TimeLeftToPlayMillis { get; set; }

        [SerializedName("wins")]
        public int Wins { get; set; }
    }
}
