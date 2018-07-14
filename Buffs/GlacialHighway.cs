using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class GlacialHighway : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Glacial Highway");
            Description.SetDefault("Hold DOWN to prevent ice from forming; falling on ice will not damage you");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if(player.controlDown)
            {
                return; //Don't place tiles if we're holding down
            }
            player.noFallDmg = true; //only disable fall damage if ice is being placed, to prevent cheese

            int x = (int)(player.position.X / 16f);
            int y = (int)(player.position.Y / 16f);

            for (int i = x; i < x + 2; i++) //Place a set of glacial highway tiles below the player
            {
                WorldGen.PlaceTile(i, y + 3, mod.TileType("GlacialHighway"), true, false, -1, 0);
            }
        }
    }
}
