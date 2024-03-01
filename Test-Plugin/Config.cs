using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test_Plugin.ConfigObjects;

namespace Test_Plugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

        [Description("Sets the message when someone joins the server. {player} will be replaced with the players name")]
        public string JoinedMessage { get; set; } = "{player} has joined the server";

        [Description("Sets the message when someone leaves the server. {player} will be replaced with the players name")]
        public string LeftMessage { get; set; } = "{player} has leaves the server";

        public string RoundStartMessage { get; set; } = "Get ready!";

        [Description("The configs for playable instances of GOC")]
        public PlayableConfig PlayableConfig { get; set; } = new PlayableConfig();

        public string PlayerGOCMessage { get; set; } = "Annihilate anyone!";
        public string PlayerGOCMessageCassie { get; set; } = "Unauthorized personal has entered of the facility";

        public List<ItemType> playerGOCItems = new List<ItemType>() 
        { 
            ItemType.KeycardChaosInsurgency,
            ItemType.ArmorCombat,
            ItemType.GunCrossvec,
            ItemType.GunRevolver, 
            ItemType.GrenadeFlash,
            ItemType.Medkit
        };
        public Dictionary<AmmoType, ushort> playerGOCAmmo = new Dictionary<AmmoType, ushort>()
        {
            { AmmoType.Ammo44Cal, 16 },
            { AmmoType.Nato9, 90 }
        };
    }
}
