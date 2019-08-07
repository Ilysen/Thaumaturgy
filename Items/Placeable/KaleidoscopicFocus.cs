using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
    public class KaleidoscopicFocus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kaleidoscopic Focus");
            Tooltip.SetDefault("A set of rainbow auric crystals\nContains modicums of aura from across the world\nUsed to replicate pre-Hardmode materials\nFunctions as a replication focus");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ReplicationFocus"));
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddIngredient(ItemID.SandBlock);
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddIngredient(ItemID.MudBlock);
            recipe.AddIngredient(ItemID.Granite);
            recipe.AddIngredient(ItemID.Marble);
            recipe.AddIngredient(ItemID.Meteorite);
            recipe.AddIngredient(ItemID.Hellstone);
            recipe.AddIngredient(ItemID.Cloud);
            recipe.AddIngredient(ItemID.PearlstoneBlock);
            recipe.AddRecipeGroup("Thaumaturgy:EvilStone");
            recipe.AddIngredient(mod.ItemType("AuricCore"));
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
            item.rare = 4;
            item.createTile = mod.TileType("KaleidoscopicFocus");
        }
    }
}