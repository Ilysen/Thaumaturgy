using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class FallingFlame : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Falling Flame");
            Tooltip.SetDefault("An overloaded fallen star\n" +
                "Use to hurl you far into the distance\n" +
                "Falling protection not included");
        }

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 3;
            item.UseSound = SoundID.Item62;
            item.maxStack = 99;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("FallingFlame"), 3000);
            player.velocity.X += player.direction <= 0 ? -100 : 100;
            player.velocity.Y -= 25;
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddIngredient(ItemID.Torch, 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this, 10);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PaleStar"), 2);
            recipe.AddIngredient(ItemID.Torch, 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
	}
}