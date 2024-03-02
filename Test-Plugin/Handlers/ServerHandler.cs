using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using System.Collections.Generic;
using PlayerRoles;
using UnityEngine;
using System.Linq;
using Exiled.CustomRoles.API;
using Exiled.API.Extensions;
using Exiled.CustomRoles.API.Features;
using Test_Plugin.CustomRoles;
using Test_Plugin.ConfigObjects;

namespace Test_Plugin.Handlers
{
    internal sealed class ServerHandler
    {
        private Config config = new Config();
        private PlayableConfig playableConfig = new PlayableConfig();

        public void OnWaitingPlayers()
        {
            Log.Info(message:"Plugin waiting for players...");
        }

        public void OnRoundStarted()
        {
            string message = TestPlugin.Instance.Config.RoundStartMessage;
            Map.Broadcast(6, message);
        }

        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            ev.IsAllowed = false;
            RespawnGOC(ev.Players);
        }

        private void RespawnGOC(List<Player> players)
        {
            foreach(var player in players)
            {
                SpawnPlayerGOC(player);
            }
            Cassie.MessageTranslated(config.PlayerGOCMessageCassie, config.PlayerGOCMessageCassie);
        }

        private void SpawnPlayerGOC(Player player)
        {
            player.Role.Set(playableConfig.RoleGOC.Role);

            player.Health = 110f;
            player.Position = new Vector3(29, 992, -26);
            player.ClearInventory();

            foreach (ItemType item in config.playerGOCItems)
            {
                player.AddItem(item);
            }
            for (int i = 0; i < config.playerGOCAmmo.Count; i++)
            {
                player.AddAmmo(config.playerGOCAmmo.Keys.ElementAt(i), config.playerGOCAmmo.Values.ElementAt(i));
            }

            player.Broadcast(4, config.PlayerGOCMessage);
        }
    }
}
