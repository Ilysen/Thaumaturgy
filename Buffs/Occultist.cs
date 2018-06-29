using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Occultist : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Occultist's Acumen");
            Description.SetDefault("Removes mana cost and tremendously increases magic damage at the cost of life");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaCost = 0;
            player.magicDamage += 3.0f;
            player.lifeRegen = 0;
            player.AddBuff(BuffID.OnFire, 2);
            player.AddBuff(BuffID.Frostburn, 2);
            player.AddBuff(BuffID.CursedInferno, 2);
        }
    }
}
