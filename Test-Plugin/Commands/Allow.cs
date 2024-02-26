using System;
using CommandSystem;

namespace Test_Plugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class Allow : ICommand
    {
        public string Command { get; } = "allow";

        public string[] Aliases { get; } = { "" };

        public string Description { get; } = "Command that is allowed";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "This command was a success";
            return true;
        }
    }
}
