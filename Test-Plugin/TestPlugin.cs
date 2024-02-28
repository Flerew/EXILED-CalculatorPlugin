using Exiled.API.Enums;
using Exiled.API.Features;
using System;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace Test_Plugin
{
    public class TestPlugin : Plugin<Config>
    {
        public static TestPlugin Instance { get; } = new TestPlugin();

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.PlayerHandler player;
        private Handlers.ServerHandler server;

        private TestPlugin() 
        { 

        }

        public override void OnEnabled()
        {
            RegisterEvents();

            for (int i = 0; i < 10; i++)
            {
                Log.Info("My plugin has been enabled!");
            }
        }
        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.PlayerHandler();
            server = new Handlers.ServerHandler();      

            Server.WaitingForPlayers += server.OnWaitingPlayers;
            Server.RoundStarted += server.OnRoundStarted;
            Server.RespawningTeam += server.OnRespawningTeam;

            Player.Left += player.OnLeft;
            Player.Joined += player.OnJoined;
            Player.InteractingDoor += player.OnInteractionDoor;
        }

        public void UnregisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingPlayers;
            Server.RoundStarted -= server.OnRoundStarted;

            Player.Left -= player.OnLeft;
            Player.Joined -= player.OnJoined;
            Player.InteractingDoor -= player.OnInteractionDoor;

            player = null;
            server = null;
        }
    }
}
