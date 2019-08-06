using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Flasks are short-term buff potions that cause potion sickness. //
namespace Thaumaturgy.Items
{
    public class FlaskOutrider : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flask of the Outrider");
            Tooltip.SetDefault("Reduces ammo consumption chance by 100%\nRanged hits will always critically strike\nCauses potion sickness for 30 seconds\n5 second duration");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item122;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.consumable = true;
            item.rare = 4;
        }

        public override bool CanUseItem(Player player)
        {
            return !player.HasBuff(BuffID.PotionSickness);
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Outrider"), 300);
            player.AddBuff(BuffID.PotionSickness, 2100);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ArcheryPotion);
            recipe.AddIngredient(ItemID.AmmoReservationPotion);
            recipe.AddIngredient(ItemID.BlackLens);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public class FlaskOccultist : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Flask of the Occultist");
                Tooltip.SetDefault("Engulfs you in thaumic flames and suppresses life regeneration\nIncreases magic damage by 300% and reduces mana use to 0%\nCauses potion sickness for 30 seconds\n5 second duration");
            }

            public override void SetDefaults()
            {
                item.UseSound = SoundID.Item123;
                item.useStyle = 2;
                item.useTurn = true;
                item.useAnimation = 17;
                item.useTime = 17;
                item.maxStack = 99;
                item.width = 20;
                item.height = 20;
                item.value = Item.sellPrice(0, 10, 0, 0);
                item.consumable = true;
                item.rare = 4;
            }

            public override bool CanUseItem(Player player)
            {
                return !player.HasBuff(BuffID.PotionSickness);
            }

            public override bool UseItem(Player player)
            {
                player.AddBuff(mod.BuffType("Occultist"), 300);
                player.AddBuff(BuffID.PotionSickness, 2100);
                return true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MagicPowerPotion);
                recipe.AddIngredient(ItemID.ManaRegenerationPotion);
                recipe.AddIngredient(ItemID.Meteorite);
                recipe.AddIngredient(mod.ItemType("SpellboundWater"));
                recipe.AddIngredient(mod.ItemType("AuricShard"));
                recipe.AddTile(mod.TileType("Thaumatrestle"));
                recipe.AddTile(mod.TileType("SynthesisFocus"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

        public class FlaskOfficer : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Flask of the Officer");
                Tooltip.SetDefault("Increases minion damage by 1% for every point of health and mana you have\nCauses potion sickness for 30 seconds\n5 second duration");
            }

            public override void SetDefaults()
            {
                item.UseSound = SoundID.Item119;
                item.useStyle = 2;
                item.useTurn = true;
                item.useAnimation = 17;
                item.useTime = 17;
                item.maxStack = 99;
                item.width = 20;
                item.height = 20;
                item.value = Item.sellPrice(0, 10, 0, 0);
                item.consumable = true;
                item.rare = 4;
            }

            public override bool CanUseItem(Player player)
            {
                return !player.HasBuff(BuffID.PotionSickness);
            }

            public override bool UseItem(Player player)
            {
                player.AddBuff(mod.BuffType("Officer"), 300);
                player.AddBuff(BuffID.PotionSickness, 2100);
                return true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SummoningPotion);
                recipe.AddIngredient(ItemID.Hellstone);
                recipe.AddIngredient(mod.ItemType("SpellboundWater"));
                recipe.AddIngredient(mod.ItemType("AuricShard"));
                recipe.AddTile(mod.TileType("Thaumatrestle"));
                recipe.AddTile(mod.TileType("SynthesisFocus"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

        public class FlaskOnslaught : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Flask of the Onslaught");
                Tooltip.SetDefault("Increases defense and melee damage as health decreases\nCauses potion sickness for 30 seconds\n5 second duration");
            }

            public override void SetDefaults()
            {
                item.UseSound = SoundID.Item84;
                item.useStyle = 2;
                item.useTurn = true;
                item.useAnimation = 17;
                item.useTime = 17;
                item.maxStack = 99;
                item.width = 20;
                item.height = 20;
                item.value = Item.sellPrice(0, 10, 0, 0);
                item.consumable = true;
                item.rare = 4;
            }

            public override bool CanUseItem(Player player)
            {
                return !player.HasBuff(BuffID.PotionSickness);
            }

            public override bool UseItem(Player player)
            {
                player.AddBuff(mod.BuffType("Onslaught"), 300);
                player.AddBuff(BuffID.PotionSickness, 2100);
                return true;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.IronskinPotion);
                recipe.AddIngredient(ItemID.TitanPotion);
                recipe.AddIngredient(ItemID.Obsidian);
                recipe.AddIngredient(mod.ItemType("SpellboundWater"));
                recipe.AddIngredient(mod.ItemType("AuricShard"));
                recipe.AddTile(mod.TileType("Thaumatrestle"));
                recipe.AddTile(mod.TileType("SynthesisFocus"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
