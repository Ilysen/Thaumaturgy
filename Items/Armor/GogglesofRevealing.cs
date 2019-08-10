using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GogglesofRevealing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Goggles of Revealing");
            Tooltip.SetDefault("Grants true sight");
        }

        public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.rare = 6;
			item.defense = 2;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }

		public override void UpdateEquip(Player player)
        {
            player.nightVision = true;
            player.findTreasure = true;
            player.detectCreature = true;
            player.dangerSense = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Goggles);
            recipe.AddIngredient(ItemID.SpelunkerPotion);
            recipe.AddIngredient(ItemID.HunterPotion);
            recipe.AddIngredient(ItemID.TrapsightPotion);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 2);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}