using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Void : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Void");
            Description.SetDefault("Life will be drained to preserve mana");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if(player.statMana <= player.statManaMax2 * 0.5)
            {
                player.statLife--;
                player.statMana = (int)(player.statManaMax * 0.5);
                if(player.statLife <= 0)
                {
                    PlayerDeathReason damageSource = PlayerDeathReason.ByCustomReason(player.name + " was eaten by hungry shadows.");
                    player.KillMe(damageSource, 1.0, 0, false);
                }
            }
        }
    }
}
