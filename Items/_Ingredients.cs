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

    public class Starbrass : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass");
            Tooltip.SetDefault("A strong, mana-conductive alloy\nPioneered by a thaumaturge from an ancient land");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 1;
        }
    }

    public class TreatedFlask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treated Flask");
            Tooltip.SetDefault("A flask treated to contain aura\nRequired to contain the power of elixirs");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Meteorite);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(ItemID.Obsidian, 1);
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }

    public class CrystalPhial : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Phial");
            Tooltip.SetDefault("An imbued potion bottle made of fused crystal\nRequired to contain the power of draughts");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.CrystalShard, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}
