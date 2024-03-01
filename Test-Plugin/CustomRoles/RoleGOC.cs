using Exiled.API.Features.Attributes;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Plugin.CustomRoles
{
    [CustomRole(RoleTypeId.Tutorial)]
    public class RoleGOC : CustomRole
    {
        public override uint Id { get; set; } = 21;
        public override int MaxHealth { get; set; } = 110;
        public override string Name { get; set; } = "Global Occult Coalition";
        public override string Description { get; set; } = "You are a soldier of GOC, annihilate anyone!";
        public override string CustomInfo { get; set; }
        public override RoleTypeId Role { get; set; } = RoleTypeId.Tutorial;   
        public override List<string> Inventory { get; set; } = new List<string>() 
        {
            $"{ItemType.KeycardChaosInsurgency}",
            $"{ItemType.ArmorCombat}",
            $"{ItemType.GunCrossvec}",
            $"{ItemType.GunRevolver}",
            $"{ItemType.GrenadeFlash}",
            $"{ItemType.Medkit}"
        };
    }
}
