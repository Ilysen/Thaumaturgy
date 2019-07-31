using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class ThaumNoms : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thaumic Pie");
            Tooltip.SetDefault("Minor improvements to all stats\nSelf-applies from your inventory\n60 minute duration");
        }

		public override void SetDefaults()
        {
            item.maxStack = 1;
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PumpkinPie, 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(TileID.CookingPots);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}