using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy
{
    public class ThaumaturgyPlayer : ModPlayer
    {
        public override bool ConsumeAmmo(Item weapon, Item ammo)
        {
            if (player.FindBuffIndex(mod.BuffType("Outrider")) > -1)
            {
                return false;
            }
            return true;
        }
    }
}
