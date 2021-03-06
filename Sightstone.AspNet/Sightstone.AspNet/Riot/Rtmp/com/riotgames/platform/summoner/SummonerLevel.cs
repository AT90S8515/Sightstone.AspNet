﻿using System;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.summoner
{
    [Serializable]
    [SerializedName("com.riotgames.platform.summoner.SummonerLevel")]
    public class SummonerLevel : IRiotRtmpObject
    {
        [SerializedName("expTierMod")]
        public double ExpTierMod { get; set; }

        [SerializedName("grantRp")]
        public double GrantRp { get; set; }

        [SerializedName("expForLoss")]
        public double ExpForLoss { get; set; }

        [SerializedName("summonerTier")]
        public double SummonerTier { get; set; }

        [SerializedName("infTierMod")]
        public double InfTierMod { get; set; }

        [SerializedName("expToNextLevel")]
        public double ExpToNextLevel { get; set; }

        [SerializedName("expForWin")]
        public double ExpForWin { get; set; }

        [SerializedName("summonerLevel")]
        public double Level { get; set; }
    }
}
