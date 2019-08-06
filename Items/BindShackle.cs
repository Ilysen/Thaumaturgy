using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    public class BindShackle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bind-Shackle");
            Tooltip.SetDefault("Increases mining speed by 40%\n'We're all adrift together, together'");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.rare = 1;
            item.accessory = true;
            item.defense = 1;
        }

        public override void UpdateEquip(Player player)
        {
            player.pickSpeed *= 0.6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 1);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}