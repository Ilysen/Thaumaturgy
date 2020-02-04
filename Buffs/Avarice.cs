using Terraria;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Avarice : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Avarice");
            Description.SetDefault("Fortune and coin pickup range are increased");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.goldRing = true;
        }
    }
}
