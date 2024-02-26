using Exiled.API.Interfaces;
using System;
using System.ComponentModel;

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
    }
}
