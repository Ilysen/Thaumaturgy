using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
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

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            Item item;
            if (!player.HasBuff(mod.BuffType("PhoenixRenewal")))
            {
                for (int i = 0; i < 58; i++)
                {
                    item = player.inventory[i];
                    if (item.type == mod.ItemType("PhoenixDown"))
                    {
                        player.statLife = (int)(player.statLifeMax2 * 0.5f);
                        Main.PlaySound(SoundID.Item67.WithVolume(0.5f), player.Center);
                        player.immune = true;
                        player.immuneTime = 60;
                        player.AddBuff(mod.BuffType("PhoenixRenewal"), 36000);
                        if(ItemLoader.ConsumeItem(item, player));
                        {
                            for (int f = -100; f < 100; f++)
                            {
                                Dust.NewDust(player.position, 30, 30, 6, f);
                            }
                            item.TurnToAir(); // Should only stack to 1
                        }
                        return false;
                    }
                }
            }
            return base.PreKill(damage, hitDirection, pvp, ref playSound, ref genGore, ref damageSource);
        }
    }
}
