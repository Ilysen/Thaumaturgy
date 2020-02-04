using Terraria;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class AuromechanicalHelmet : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Wearable/AuromechanicalHelmet";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auromechanical Helmet");
            Tooltip.SetDefault("Grants true sight\nMana usage reduced by 20%");
        }

        public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 50, 0);
			item.rare = 3;
			item.defense = 5;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AuromechanicalPlate") && legs.type == mod.ItemType("AuromechanicalGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Enhanced mobility in water and the air\nAll damage increased by 5%";
            player.ignoreWater = true;
            player.accFlipper = true;
            player.jumpSpeedBoost += 1f;
            player.allDamageMult += 0.05f;
        }

        public override void UpdateEquip(Player player)
		{
            player.nightVision = true;
            player.findTreasure = true;
            player.detectCreature = true;
            player.dangerSense = true;
            player.manaCost -= 0.2f;
        }

        public override void AddRecipes()
        {
            // NOTE FOR CODE READERS.
            // IT'S "GogglesofRevealing", NOT "GogglesOfRevealing"
            // THIS TOOK ME AN HOUR TO FIND OUT WHY THE RECIPE WASN'T WORKING AND I WAS TEARING MY HAIR OUT.
            // I HOPE IT WAS WORTH IT.
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("GogglesofRevealing"));
            recipe.AddIngredient(mod.ItemType("StarbrassMask"));
            recipe.AddIngredient(mod.ItemType("AuricSteel"), 3);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class AuromechanicalPlate : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Wearable/AuromechanicalPlate";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auromechanical Plate");
            Tooltip.SetDefault("Magic damage increased by 20%\nDamage taken reduced by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 3;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamageMult += 0.2f;
            player.endurance += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("StarbrassBreastplate"));
            recipe.AddIngredient(mod.ItemType("AuricSteel"), 9);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class AuromechanicalGreaves : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Wearable/AuromechanicalGreaves";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auromechanical Greaves");
            Tooltip.SetDefault("Maximum mana increased by 50\nProtects from fall damage");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.sellPrice(0, 0, 60, 0);
            item.rare = 3;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 50;
            player.noFallDmg = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("StarbrassGreaves"));
            recipe.AddIngredient(mod.ItemType("AuricSteel"), 6);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}