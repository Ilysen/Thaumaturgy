using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class TerranBore : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terran Bore");
            Tooltip.SetDefault("An impressive technomagical feat that tunnels through the earth\nUse to start it up, causing it to dig downwards until it reaches the Underworld\nThe bore recycles earth into a shielded, illuminated structure, and leaves a rope for safe descent\nSome extremely hard tiles may break the bore mid-tunnel\nDon't use if there's anything important below you\nMay require you to reload the world in multiplayer");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.rare = 4;
            item.UseSound = SoundID.NPCDeath56;
            item.maxStack = 3;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool UseItem(Player player) //HERE BE DRAGONS
        {
            int x = (int)(player.position.X / 16f);
            int y = (int)(player.position.Y / 16f);
            int prog_x = 0;
            int prog_y = 1;
            for (int i = x - 3; i < x + 4; i++)
            {
                prog_y = 0;
                for (int v = y; v < y + 4000; v++) //this should be more than enough for even the largest worlds
                {
                    if(Main.tile[i, v].type != null)
                    {
                        if(Main.tile[i, v].type == TileID.Ash || Main.tile[i, v].type == TileID.ObsidianBrick || Main.tile[i, v].type == TileID.HellstoneBrick || Main.tile[i, v].type == TileID.LihzahrdBrick) //once we're at the Underworld, stop digging
                        {
                            break;
                        }
                        WorldGen.KillTile(i, v, false, false, false); //destroy each tile as we go down
                        if(Main.tile[i, v].liquid > 0) //and clear out liquids
                        {
                            Main.tile[i, v].lava(false);
                            Main.tile[i, v].liquid = 0;
                            WorldGen.SquareTileFrame(i, v, true);
                        }
                        if(prog_x == 0 || prog_x == 6) //on the borders, we'll put down walls; iridescent brick is made from ash - balance can't be broken by uncrafting mods, and you have to have reached the underworld first
                        {
                            WorldGen.PlaceTile(i, v, TileID.IridescentBrick, false, false, -1, 0);
                        }
                        if(prog_x == 3) //in the center, run a rope down the length
                        {
                            WorldGen.PlaceTile(i, v, TileID.SilkRope, false, false, -1, 0);
                        }
                        if(prog_x > 0 && prog_x < 6) //while not in the borders, smash walls and replace them
                        {
                            WorldGen.KillWall(i, v, false);
                            if(prog_y != 0)
                            {
                                if(prog_x == 3 && prog_y % 20 == 0)
                                {
                                    WorldGen.PlaceWall(i, v, WallID.DiamondGemspark, false); //every 20 tiles, use a diamond gemspark block for lighting and aesthetic
                                }
                                else
                                {
                                    WorldGen.PlaceWall(i, v, WallID.IridescentBrick, false);
                                }
                            }
                        }
                        if(prog_y == 5) //place platforms near the top to catch the player and provide a safety net
                        {
                            WorldGen.PlaceTile(i, v, TileID.Platforms, false, false, -1, 0);
                        }
                    }
                    prog_y++;
                }
                prog_x++;
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IridescentBrick, 300);
            recipe.AddIngredient(ItemID.SilkRopeCoil, 100);
            recipe.AddIngredient(ItemID.DiamondGemsparkBlock, 30);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 30);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 10);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}