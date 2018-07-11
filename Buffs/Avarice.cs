using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Avarice : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Avarice");
            Description.SetDefault("Coin pickup range is increased");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.goldRing = true;
        }
    }
}
