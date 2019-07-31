using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Thaumaturgy.Items
{
    //////////////
    // HEALING //
    /////////////

    public class ElixirHealing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Healing Elixir");
            Tooltip.SetDefault("Not consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 3;
            item.potion = true;
            item.healLife = 100;
        }

        public override bool ConsumeItem(Player player)
        {
            return false; //This override is necessary for quick heal
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HealingPotion, 20);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirHealingGreater : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greater Healing Elixir");
            Tooltip.SetDefault("Not consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 25, 0, 0);
            item.rare = 3;
            item.potion = true;
            item.healLife = 150;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 20);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 6);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirHealingSuper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Healing Elixir");
            Tooltip.SetDefault("Not consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 75, 0, 0);
            item.rare = 3;
            item.potion = true;
            item.healLife = 200;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuperHealingPotion, 20);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 9);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirPanacea : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Max Healing Elixir");
            Tooltip.SetDefault("Healing amount will change on use to half your maximum health\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 3;
            item.healLife = 200;
            item.potion = true;
        }

        public override bool ConsumeItem(Player player)
        {
            return false;
        }

        public override bool CanUseItem(Player player) //we'll assign the amount to heal here
        {
            int totalHealth = Main.player[Main.myPlayer].statLifeMax2;
            item.healLife = (int)(totalHealth * 0.5f);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ElixirHealing"));
            recipe.AddIngredient(mod.ItemType("ElixirHealingGreater"));
            recipe.AddIngredient(mod.ItemType("ElixirHealingSuper"));
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 25);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    ///////////////////
    // VANILLA BUFFS //
    ///////////////////

    public class ElixirFortitude : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Auric Elixir of Fortitude");
			Tooltip.SetDefault("Increases defense by 8\nDecreases damage taken by 10%\nNot consumed upon use");
		}    

		public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Ironskin;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronskinPotion, 5);
            recipe.AddIngredient(ItemID.EndurancePotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Endurance, 36000);
            return true;
        }
    }

    public class ElixirVigor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Vigor");
            Tooltip.SetDefault("Increases life regeneration\nIncreases maximum life by 20%\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Regeneration;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RegenerationPotion, 5);
            recipe.AddIngredient(ItemID.LifeforcePotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Lifeforce, 36000);
            return true;
        }
    }

    public class ElixirAlacrity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Alacrity");
            Tooltip.SetDefault("Boosts movement speed by 25%\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Swiftness;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirSubmersion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Submersion");
            Tooltip.SetDefault("Grants the ability to breathe underwater\nMovement speed is unaffected by liquids\nGrants the ability to swim\nGrants water walking\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Gills;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GillsPotion, 5);
            recipe.AddIngredient(ItemID.FlipperPotion, 5);
            recipe.AddIngredient(ItemID.WaterWalkingPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Flipper, 36000);
            player.AddBuff(BuffID.WaterWalking, 36000);
            return true;
        }
    }

    public class ElixirDelving : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Delving");
            Tooltip.SetDefault("Increases mining speed by 25%\nIncreases night vision\nCompletely protects from lava\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Mining;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MiningPotion, 5);
            recipe.AddIngredient(ItemID.NightOwlPotion, 5);
            recipe.AddIngredient(ItemID.ObsidianSkinPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.NightOwl, 36000);
            player.AddBuff(BuffID.ObsidianSkin, 36000);
            return true;
        }
    }

    public class ElixirTruesight : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Truesight");
            Tooltip.SetDefault("Grants vision of treasure, enemies, and danger through walls\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Spelunker;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpelunkerPotion, 5);
            recipe.AddIngredient(ItemID.HunterPotion, 5);
            recipe.AddIngredient(ItemID.TrapsightPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            if (ModLoader.GetMod("CalamityMod") != null)
            {
                var Calamity = ModLoader.GetMod("CalamityMod");
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(Calamity.ItemType("PotionofOmniscience"), 5);
                recipe.AddIngredient(mod.ItemType("SpellboundWater"));
                recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
                recipe.AddIngredient(mod.ItemType("AuricCore"));
                recipe.AddTile(mod.TileType("Thaumatrestle"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Hunter, 36000);
            player.AddBuff(BuffID.Dangersense, 36000);
            return true;
        }
    }

    public class ElixirTrawling : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Trawling");
            Tooltip.SetDefault("Increases fishing power\nIncreases chance to catch crates\nDetects hooked catches\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Fishing;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FishingPotion, 5);
            recipe.AddIngredient(ItemID.CratePotion, 5);
            recipe.AddIngredient(ItemID.SonarPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Crate, 36000);
            player.AddBuff(BuffID.Sonar, 36000);
            return true;
        }
    }

    public class ElixirDeadlyFocus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Deadly Focus");
            Tooltip.SetDefault("Increases all damage dealt by 10%\nIncreases critical strike chance by 10%\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Wrath;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WrathPotion, 5);
            recipe.AddIngredient(ItemID.RagePotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Rage, 36000);
            return true;
        }
    }

    public class ElixirHuntersPrecision : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of the Hunter's Precision");
            Tooltip.SetDefault("Increases arrow speed and damage by 20%\nDecreases ammo consumption by 20%\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Archery;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ArcheryPotion, 5);
            recipe.AddIngredient(ItemID.AmmoReservationPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.AmmoReservation, 36000);
            return true;
        }
    }

    public class ElixirSorcerersAusterity : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of the Sorcerer's Austerity");
            Tooltip.SetDefault("Increases magic damage dealt by 20%\nIncreases mana regeneration speed and decreases its delay\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.MagicPower;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicPowerPotion, 5);
            recipe.AddIngredient(ItemID.ManaRegenerationPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.ManaRegeneration, 36000);
            return true;
        }
    }

    public class ElixirGeneralsRally : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of the General's Rally");
            Tooltip.SetDefault("Increases maximum minions by +1\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Summoning;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SummoningPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirTradewinds : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Tradewinds");
            Tooltip.SetDefault("Allows control of gravity\nAllows control of falling speed\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = BuffID.Gravitation;
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GravitationPotion, 5);
            recipe.AddIngredient(ItemID.FeatherfallPotion, 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.Featherfall, 36000);
            return true;
        }
    }

    ///////////////////////
    // THAUMATURGY BUFFS //
    ///////////////////////

    public class ElixirAvarice : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of the Baron's Hoard");
            Tooltip.SetDefault("Increases coin pickup range\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("Avarice");
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionAvarice"), 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirEvasion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Nimbleness");
            Tooltip.SetDefault("Enables dashing\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("Evasion");
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionEvasion"), 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirFloes : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Ice Floes");
            Tooltip.SetDefault("Ice forms beneath you as you walk\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("GlacialHighway");
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionGlacialHighway"), 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirVoid : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Entwined Tendrils");
            Tooltip.SetDefault("Life will be consumed to preserve mana\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("Void");
            item.buffTime = 36000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionVoid"), 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ElixirWateryEmbers : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Elixir of Paradoxical Candleflame");
            Tooltip.SetDefault("Tremendously increases enemy spawns\nNot consumed upon use");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.buffType = mod.BuffType("WateryEmbers");
            item.buffTime = 18000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionWateryEmbers"), 5);
            recipe.AddIngredient(mod.ItemType("SpellboundWater"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
