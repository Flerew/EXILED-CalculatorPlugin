using CommandSystem;
using System;

namespace Test_Plugin.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class Divide : ICommand
    {
        public string Command { get; } = "dividing";

        public string[] Aliases { get; } = { "" };

        public string Description { get; } = "Command that is dividing two numbers";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            int a = Convert.ToInt32(arguments.Array[1]);
            int b = Convert.ToInt32(arguments.Array[2]);
            if(b != 0)
            {
                int c = a / b;
                response = $"answer: {c}";
                return true;
            }
            else
            {
                response = "You cannot divide by zero!";
                return false;
            }

            
        }
    }
}
