using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Onslaught : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Onslaught's Descent");
            Description.SetDefault("Increases defense and melee damage with missing health");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            int missing_health = player.statLifeMax - player.statLife;
            player.statDefense += (int)(missing_health * 0.5f);
            player.meleeDamage += missing_health * 0.02f;
        }
    }
}
