using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class AuricShard : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Auric Shard");
            Tooltip.SetDefault("Small part of a fallen star; contains latent magic\nUsed in minor thaumaturgy");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 2, 0);
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.SetResult(this, 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PaleStar"));
            recipe.SetResult(this, 2);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddRecipe();
        }
	}
}
