using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    public class ChampionsCrest : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/ChampionsCrest";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Champion's Crest");
            Tooltip.SetDefault("Most slimes become friendly\n" +
                "Grants a charging dash attack\n" +
                "Reduces damage taken by 17%\n" +
                "Being struck may confuse nearby enemies\n" +
                "Friendly bees are stronger\n" +
                "Summons damaging spores around you\n" +
                "Greatly increases life regen while stationary");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 8;
            item.defense = 2;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.dash = 2;
            player.endurance += 0.17f;
            player.brainOfConfusion = true;
            player.strongBees = true;
            player.sporeSac = true;
            player.shinyStone = true;
            player.SporeSac();

            // THIS IS VANILLA CODE. YEAH.
            player.npcTypeNoAggro[1] = true;
            player.npcTypeNoAggro[16] = true;
            player.npcTypeNoAggro[59] = true;
            player.npcTypeNoAggro[71] = true;
            player.npcTypeNoAggro[81] = true;
            player.npcTypeNoAggro[138] = true;
            player.npcTypeNoAggro[121] = true;
            player.npcTypeNoAggro[122] = true;
            player.npcTypeNoAggro[141] = true;
            player.npcTypeNoAggro[147] = true;
            player.npcTypeNoAggro[183] = true;
            player.npcTypeNoAggro[184] = true;
            player.npcTypeNoAggro[204] = true;
            player.npcTypeNoAggro[225] = true;
            player.npcTypeNoAggro[244] = true;
            player.npcTypeNoAggro[302] = true;
            player.npcTypeNoAggro[333] = true;
            player.npcTypeNoAggro[335] = true;
            player.npcTypeNoAggro[334] = true;
            player.npcTypeNoAggro[336] = true;
            player.npcTypeNoAggro[537] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RoyalGel);
            recipe.AddIngredient(ItemID.EoCShield);
            recipe.AddIngredient(ItemID.WormScarf);
			recipe.AddIngredient(ItemID.HiveBackpack);
			recipe.AddIngredient(ItemID.SporeSac);
            recipe.AddIngredient(ItemID.ShinyStone);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
			recipe.AddIngredient(mod.ItemType("Starbrass"));
			recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RoyalGel);
            recipe.AddIngredient(ItemID.EoCShield);
            recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddIngredient(ItemID.HiveBackpack);
			recipe.AddIngredient(ItemID.SporeSac);
            recipe.AddIngredient(ItemID.ShinyStone);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}