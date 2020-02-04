using Terraria;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class SoothingEmbers : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Soothing Embers");
            Description.SetDefault("Enemy spawn rate tremendously reduced");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }
    }
}
