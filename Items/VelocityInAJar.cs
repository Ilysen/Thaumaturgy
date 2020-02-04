using Terraria;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class VelocityInAJar : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/VelocityInAJar";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Velocity in a Jar");
            Tooltip.SetDefault("Greatly boosts max move speed");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 34;
			item.value = Item.sellPrice(0, 0, 15, 0);
			item.rare = 4;
            item.maxStack = 99;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.maxRunSpeed += 6;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FallingFlame"));
            recipe.AddIngredient(mod.ItemType("TreatedFlask"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}