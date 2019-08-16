using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class ThaumNoms : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thaumic Pie");
            Tooltip.SetDefault("Minor improvements to all stats while in your inventory\n" +
                "Doesn't take up a buff slot; benefits won't be visible as a buff");
        }

		public override void SetDefaults()
        {
            item.maxStack = 1;
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PumpkinPie, 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(TileID.CookingPots);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void UpdateInventory(Player player)
        {
            player.buffImmune[BuffID.WellFed] = true;
            player.wellFed = true;
            player.statDefense += 2;
            player.meleeCrit += 2;
            player.magicCrit += 2;
            player.rangedCrit += 2;
            player.thrownCrit += 2;
            player.meleeDamage += 0.05f;
            player.magicDamage += 0.05f;
            player.rangedDamage += 0.05f;
            player.thrownDamage += 0.05f;
            player.minionDamage += 0.05f;
            player.minionKB += 0.5f;
            player.meleeSpeed += 0.05f;
            player.moveSpeed += 0.2f;
        }
    }
}