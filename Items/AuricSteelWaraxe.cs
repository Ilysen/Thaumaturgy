using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class AuricSteelWaraxe : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Steel Waraxe");
            Tooltip.SetDefault("Deals magic damage");
        }

		public override void SetDefaults()
        {
            item.damage = 28;
            item.magic = true;
            item.autoReuse = true;
            item.useTurn = true;
            item.knockBack = 7;
            item.width = 38;
			item.height = 34;
            item.useTime = 15;
			item.useAnimation = 24;
			item.useStyle = 1;
            item.axe = 10;
            item.scale = 1.3f;
            item.value = Item.sellPrice(0, 0, 40, 0);
			item.rare = 1;
            item.crit = 25;
            item.maxStack = 1;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AuricSteel"), 15);
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