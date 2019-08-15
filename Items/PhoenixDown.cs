using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class PhoenixDown : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Phoenix Down");
            Tooltip.SetDefault("If held in your inventory, saves you once from death, then shrivels\nMultiple phoenix downs won't help in a short timespan");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
            item.consumable = true;
			item.value = Item.sellPrice(0, 25, 0, 0);
			item.rare = 4;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Feather, 10);
            recipe.AddIngredient(ItemID.SoulofFlight, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireFeather);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 10);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
	}
}
