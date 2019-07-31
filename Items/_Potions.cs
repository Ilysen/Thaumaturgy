using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    public class PotionAvarice : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Avarice Potion");
            Tooltip.SetDefault("Increases coin pickup range");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.consumable = true;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("Avarice");
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.SilverCoin);
            recipe.AddIngredient(ItemID.Daybloom);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddIngredient(ItemID.SilverCoin);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }

    public class PotionEvasion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Evasion Potion");
            Tooltip.SetDefault("Enables dashing");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.consumable = true;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("Evasion");
            item.buffTime = 24000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.Moonglow);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddIngredient(ItemID.Gel);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PotionGlacialHighway : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glacial Highway Potion");
            Tooltip.SetDefault("Ice forms beneath you as you walk\nDisclaimer: May not play nice in multiplayer");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.consumable = true;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("GlacialHighway");
            item.buffTime = 24000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.SnowCloudBlock);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddIngredient(ItemID.SnowCloudBlock);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PotionVoid : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Void Potion");
            Tooltip.SetDefault("Life will be consumed to preserve mana");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.consumable = true;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("Void");
            item.buffTime = 18000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }


    public class PotionWateryEmbers : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion of Watery Embers");
            Tooltip.SetDefault("The embers of a water candle\nTremendously increases enemy spawn rate");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.consumable = true;
            item.maxStack = 99;
            item.width = 22;
            item.height = 35;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 1;
            item.buffType = mod.BuffType("WateryEmbers");
            item.buffTime = 18000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Deathweed);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddIngredient(ItemID.Fireblossom);
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddIngredient(ItemID.WaterCandle);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }
}
