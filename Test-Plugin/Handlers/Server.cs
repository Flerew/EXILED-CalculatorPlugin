using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Plugin.Handlers
{
    class Server
    {
        public void OnWaitingPlayers()
        {
            Log.Info(message:"Plugin waiting for players...");
        }

        public void OnRoundStarted()
        {
            string message = TestPlugin.Instance.Config.RoundStartMessage;
            Map.Broadcast(6, message);
        }
    }
}
