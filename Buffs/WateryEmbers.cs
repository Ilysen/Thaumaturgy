using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class WateryEmbers : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Watery Embers");
            Description.SetDefault("Enemy spawn rate tremendously increased");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }
    }
}
