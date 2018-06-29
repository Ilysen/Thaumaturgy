using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Outrider : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Outrider's Grit");
            Description.SetDefault("Removes ammo consumption and guarantees critical strikes on all ranged attacks");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.rangedCrit = 100;
        }
    }
}
