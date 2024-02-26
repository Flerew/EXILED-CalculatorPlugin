using System;
using CommandSystem;
using Exiled.API.Features;

namespace Test_Plugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class Multiply : ICommand
    {
        public string Command { get; } = "multiply";

        public string[] Aliases { get; } = { "" };

        public string Description { get; } = "Command that is multiply two numbers";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            int a = Convert.ToInt32(arguments.Array[1]);
            int b = Convert.ToInt32(arguments.Array[2]);
            int c = a * b;

            response = $"answer: {c}";
            return true;
        }
    }
}
