using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class EternalOrdeal : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eternal Ordeal");
            Tooltip.SetDefault("Prevents invasions from ending while worn\n" +
                "May fail if you kill huge amounts of enemies extremely fast\n" +
                "'Truth, beauty, and hatred'");
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.rare = 9;
            item.value = Item.sellPrice(0, 0, 10, 0);
            item.maxStack = 1;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            if (Main.invasionType != 0)
            {
                if (Main.invasionSize < 25)
                {
                    Main.invasionSize = 25;
                }
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 5);
            recipe.AddIngredient(ItemID.FlintlockPistol);
            recipe.AddIngredient(ItemID.EbonwoodSword);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 5);
            recipe.AddIngredient(ItemID.FlintlockPistol);
            recipe.AddIngredient(ItemID.ShadewoodSword);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}