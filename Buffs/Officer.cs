using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Officer : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Officer's Rally");
            Description.SetDefault("Increases minion damage by 1% for each health and mana point you have");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            float damage_increase = 0f;
            damage_increase += player.statLife * 0.01f;
            damage_increase += player.statMana * 0.01f;
            player.minionDamage += damage_increase;
        }
    }
}
