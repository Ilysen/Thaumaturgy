using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Evasion : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Evasion");
            Description.SetDefault("Dash by double-tapping left or right");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.dash == 0)
            {
                player.dash = 1;
            }
        }
    }
}
