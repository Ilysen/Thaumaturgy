using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class StarbrassHamaxe : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/StarbrassHamaxe";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass Hamaxe");
            Tooltip.SetDefault("Deals magic damage");
        }

		public override void SetDefaults()
        {
            item.damage = 20;
            item.magic = true;
            item.autoReuse = true;
            item.useTurn = true;
            item.knockBack = 7;
            item.width = 38;
			item.height = 34;
            item.useTime = 15;
			item.useAnimation = 30;
			item.useStyle = 1;
            item.hammer = 70;
            item.axe = 40;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 2;
            item.maxStack = 1;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 15);
            recipe.AddRecipeGroup("Wood", 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddIngredient(ItemID.MeteorHamaxe);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}