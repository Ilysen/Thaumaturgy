using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
    public class UniversalFocus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Universal Focus");
            Tooltip.SetDefault("A conduit to the Aura itself\nFunctions as every focus");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SynthesisFocus"));
            recipe.AddIngredient(mod.ItemType("TransmutationFocus"));
            recipe.AddIngredient(mod.ItemType("CelestialFocus"));
            recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 25);
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
            item.rare = 11;
            item.createTile = mod.TileType("UniversalFocus");
        }
    }
}