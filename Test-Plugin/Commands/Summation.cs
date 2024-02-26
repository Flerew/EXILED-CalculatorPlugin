using System;
using CommandSystem;

namespace Test_Plugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class Summation : ICommand
    {
        public string Command { get; } = "sum";

        public string[] Aliases { get; } = { "" };

        public string Description { get; } = "Command that is sum two numbers";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            int a = Convert.ToInt32(arguments.Array[1]);
            int b = Convert.ToInt32(arguments.Array[2]);
            int c = a + b;

            response = $"answer: {c}";
            return true;
        }
    }
}
