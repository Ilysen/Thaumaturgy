using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class AuricCore : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Auric Core");
            Tooltip.SetDefault("Amalgam of two fused mana crystals; contains untapped magic\nUsed in major thaumaturgy");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 15, 0);
			item.rare = 1;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PaleStar"), 10);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddRecipe();
		}
	}
}
