using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    public class Sundew : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/Sundew";
		public override void SetStaticDefaults()
        {
			// I would have named it Stardew, but then I'd get sued
            DisplayName.SetDefault("Sundew");
            Tooltip.SetDefault("Slightly increases movement speed and decreases enemy spawns");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 1;
            item.consumable = true;
            item.buffType = BuffID.Sunflower;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Sunflower);
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
