using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
    public class CelestialFocus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Focus");
            Tooltip.SetDefault("A set of luminite crystals from the void\nContains otherworldly power tethered to a forgotten source\nUsed to replicate Hardmode materials");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ReplicationFocus"));
            recipe.AddIngredient(ItemID.LunarOre, 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 14;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 1000;
            item.rare = 1;
            item.createTile = mod.TileType("CelestialFocus");
        }
    }
}