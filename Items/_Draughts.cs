using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Draughts are combinations of elixirs that grant all their benefits. //
namespace Thaumaturgy.Items
{
	public class DraughtDetermination : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Alchemy/DraughtDetermination";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Draught of Determination");
			Tooltip.SetDefault("Grants a wide array of combat benefits\nNot consumed upon use");
		}

		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
			item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
			item.maxStack = 1;
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.rare = 10;
			item.buffType = mod.BuffType("Determination");
			item.buffTime = 216000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CrystalPhial"));
			recipe.AddIngredient(mod.ItemType("ElixirFortitude"));
			recipe.AddIngredient(mod.ItemType("ElixirVigor"));
			recipe.AddIngredient(mod.ItemType("ElixirAlacrity"));
			recipe.AddIngredient(mod.ItemType("ElixirDeadlyFocus"));
			recipe.AddIngredient(mod.ItemType("ElixirHuntersPrecision"));
			recipe.AddIngredient(mod.ItemType("ElixirSorcerersAusterity"));
			recipe.AddIngredient(mod.ItemType("ElixirGeneralsRally"));
			recipe.AddIngredient(mod.ItemType("SpellboundWater"));
			recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
			recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddTile(mod.TileType("SynthesisFocus"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DraughtDaring : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Alchemy/DraughtDaring";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Draught of Daring");
			Tooltip.SetDefault("Grants a wide array of exploration benefits\nNot consumed upon use");
		}

		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
			item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
			item.maxStack = 1;
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(1, 0, 0, 0);
			item.rare = 10;
			item.buffType = mod.BuffType("Daring");
			item.buffTime = 216000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CrystalPhial"));
			recipe.AddIngredient(mod.ItemType("ElixirSubmersion"));
			recipe.AddIngredient(mod.ItemType("ElixirDelving"));
			recipe.AddIngredient(mod.ItemType("ElixirTruesight"));
			recipe.AddIngredient(mod.ItemType("ElixirAvarice"));
			recipe.AddIngredient(mod.ItemType("SpellboundWater"));
			recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
			recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddTile(mod.TileType("SynthesisFocus"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DraughtDaredevilry : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Alchemy/DraughtDaredevilry";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Draught of Daredevilry");
			Tooltip.SetDefault("Grants almost all vanilla potion benefits\nNot consumed upon use");
		}

		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
			item.useStyle = 2;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useTime = 17;
			item.maxStack = 1;
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(2, 50, 0, 0);
			item.rare = 11;
			item.buffType = mod.BuffType("Daredevilry");
			item.buffTime = 216000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("CrystalPhial"));
			recipe.AddIngredient(mod.ItemType("DraughtDaring"));
			recipe.AddIngredient(mod.ItemType("DraughtDetermination"));
			recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
			recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddTile(mod.TileType("SynthesisFocus"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}