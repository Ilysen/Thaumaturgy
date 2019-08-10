using Terraria;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StarbrassMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass Helmet");
            Tooltip.SetDefault("Mana usage reduced by 10%");
        }

        public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.rare = 2;
			item.defense = 4;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("StarbrassBreastplate") && legs.type == mod.ItemType("StarbrassGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Non-magic damage decreased by 15%\nMagic damage increased by 30%";
            player.allDamageMult -= 0.15f;
            player.magicDamageMult += 0.45f;
        }

        public override void UpdateEquip(Player player)
		{
            player.manaCost -= 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 2);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class StarbrassBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass Breatplate");
            Tooltip.SetDefault("Damage taken reduced by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 2;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.endurance += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 20);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 10);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class StarbrassGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass Greaves");
            Tooltip.SetDefault("Maximum mana increased by 25\nMovement speed increased by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.sellPrice(0, 0, 60, 0);
            item.rare = 2;
            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 25;
            player.moveSpeed += 0.2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 15);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 20);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}