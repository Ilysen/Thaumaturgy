using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Tiles
{
    //This tile is only placed by the Glacial Highway potion, so it's built around deleting itself when it shouldn't be there
	public class GlacialHighway : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
            AddMapEntry(new Color(150, 150, 200));
		}
            
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
            num = 0;
		}

        public override bool KillSound(int i, int j)
        {
            return false;
        }

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.7f;
			g = 0.7f;
			b = 1.0f;
            CheckHighway(i, j); //because ModifyLight is called every tick, we also look every tick to make sure we still exist
		}

        public void CheckHighway(int i, int j) //The way this is handled may not play nicely with multiplayer, but I don't know yet
        {
            int x = (int)(Main.player[0].position.X / 16f);
            int y = (int)(Main.player[0].position.Y / 16f);
            if (!Main.player[0].HasBuff(mod.BuffType("GlacialHighway")) || Main.player[0].controlDown)
            {
                WorldGen.KillTile(i, j, false, false, false); //destroy this tile
            }
            else if (!(j == y + 3 && (i >= x && i <= x + 2)))
            {
                WorldGen.KillTile(i, j, false, false, false); //also destroy this tile
            }
        }
	}
}