using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    public class PathfindersLamp : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pathfinder's Lamp");
            Tooltip.SetDefault("Provides light while worn");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 1;
            item.accessory = true;
            item.defense = 2;
        }

        public override void UpdateEquip(Player player)
        {
            Lighting.AddLight(player.Center, 1f, 0.75f, 1f);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shackle);
            recipe.AddIngredient(ItemID.Chain, 3);
            recipe.AddIngredient(mod.ItemType("ConjurersLamp"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}