using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class PhoenixRenewal : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Phoenix Renewal");
            Description.SetDefault("Phoenix Down won't work");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = true;
            canBeCleared = false;
        }
    }
}
