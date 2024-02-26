using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;

namespace Test_Plugin.Handlers
{
    class Player
    {
        public void OnLeft(LeftEventArgs ev)
        {
            string message = TestPlugin.Instance.Config.LeftMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            string message = TestPlugin.Instance.Config.JoinedMessage.Replace("{player}", ev.Player.Nickname);
            Map.Broadcast(6, message);
        }

        public void OnInteractionDoor(InteractingDoorEventArgs ev)
        {
            if(ev.IsAllowed == false)
            {
                ev.Player.Broadcast(duration: 3, message: "You walked into my trap");
                ev.Player.Kill(damageType: DamageType.Scp173);
            }
            else
            {
                ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
            }
        }
    }
}
