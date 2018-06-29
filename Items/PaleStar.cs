using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class PaleStar : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Pale Star");
            Tooltip.SetDefault("A dim star synthesized by magic\nToo weak to use in anything but thaumaturgy");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.SetResult(ItemID.ManaCrystal);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddRecipe();
		}
	}
}
