using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    [AutoloadEquip(EquipType.Shoes)]
    public class TerraTreads : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Treads");
            Tooltip.SetDefault("Allows flight, super fast running, and extra mobility on ice and liquids\n" +
                "Protects from fire blocks, lava, and falls\n" +
                "10% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.accRunSpeed = 6.75f;
            player.rocketBoots = 2;
            player.moveSpeed += 0.10f;
            player.noFallDmg = true;
            player.iceSkate = true;
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 600;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
            recipe.AddIngredient(ItemID.LavaWaders, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 2);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}