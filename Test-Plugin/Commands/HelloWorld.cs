using System;
using CommandSystem;
using RemoteAdmin;

namespace Test_Plugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class HelloWorld : ICommand
    {
        public string Command { get; } = "hello";

        public string[] Aliases { get; } = { "helloworld" };

        public string Description { get; } = "A command that says hello to the world";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if(sender is PlayerCommandSender player)
            {
                response = $"Hello {player.Nickname}";
                return false;
            }
            else
            {
                response = "World";
                return true;
            }
        }
    }
}
