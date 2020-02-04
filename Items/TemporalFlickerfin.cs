using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class TemporalFlickerfin : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/TemporalFlickerfin";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Temporal Flickerfin");
            Tooltip.SetDefault("It shimmers as if trying to phase away\nUse to release it, rewinding time to reset the Angler's quest status\nCan only be used if you've already completed today's quest");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.rare = 3;
            item.UseSound = SoundID.Item21;
            item.maxStack = 99;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.anglerQuestFinished;
        }

        public override bool UseItem(Player player)
        {
            Main.anglerQuestFinished = false;
            Thaumaturgy.NewText(player, "Time seems to slow for a moment.", 100, 100, 255);
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("TransmutationFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}