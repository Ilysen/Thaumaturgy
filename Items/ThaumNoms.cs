using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class ThaumNoms : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thaum Noms");
            Tooltip.SetDefault("Minor improvements to all stats");
        }

		public override void SetDefaults()
        {
            item.UseSound = SoundID.Item2;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.consumable = true;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 3;
            item.buffType = BuffID.WellFed;
            item.buffTime = 216000;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrassSeeds);
            recipe.AddIngredient(ItemID.Pumpkin, 5);
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddTile(TileID.CookingPots);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}