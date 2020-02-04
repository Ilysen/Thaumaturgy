using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class RiggedStopwatch : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/RiggedStopwatch";

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rigged Stopwatch");
			Tooltip.SetDefault("Control the flow of time for your body and mind!\n" +
				"Use to fast-forward time to dawn or dusk, whichever is closer");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 2, 0, 0);
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item74;
			item.maxStack = 1;
			item.consumable = false;
			item.noMelee = true;
		}

		public override bool CanUseItem(Player player)
		{
			return base.CanUseItem(player) && !player.HasBuff(mod.BuffType("Stasis"));
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("Stasis"), 6000);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FastClock);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(mod.ItemType("AuricCore"), 3);
			recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
			recipe.AddTile(mod.TileType("Thaumatrestle"));
			recipe.AddTile(mod.TileType("SynthesisFocus"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}