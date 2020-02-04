using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class StabilizedStar : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/StabilizedStar";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rising Star");
            Tooltip.SetDefault("An ensouled flame with infinite uses\n" +
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
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = ItemRarityID.Pink;
            item.UseSound = SoundID.Item62;
            item.maxStack = 1;
            item.consumable = false;
			item.noMelee = true;
        }

        public override bool UseItem(Player player)
        {
            player.velocity.X += player.direction <= 0 ? -100 : 100;
			player.velocity.X.Clamp(-200, 200);
            player.velocity.Y -= 25;
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FallingFlame"));
            recipe.AddIngredient(ItemID.SoulofFlight, 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}