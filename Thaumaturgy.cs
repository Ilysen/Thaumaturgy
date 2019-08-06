using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy
{
    class Thaumaturgy : Mod
    {
        public Thaumaturgy()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => "Iron or Lead Ore", new int[]
            {
                    ItemID.IronOre,
                    ItemID.LeadOre
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:IronOrLead", group);

            group = new RecipeGroup(() => "Gold or Platinum Ore", new int[]
            {
                    ItemID.GoldOre,
                    ItemID.PlatinumOre
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:GoldOrPlatinum", group);

            group = new RecipeGroup(() => "Iron or Lead Bar", new int[]
            {
                    ItemID.IronBar,
                    ItemID.LeadBar
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:IronBar", group);

            group = new RecipeGroup(() => "Gold or Platinum Bar", new int[]
            {
                    ItemID.GoldBar,
                    ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:GoldBar", group);

            group = new RecipeGroup(() => "Crimtane or Demonite Ore", new int[]
            {
                    ItemID.CrimtaneOre,
                    ItemID.DemoniteOre
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:CrimtaneOrDemonite", group);

            group = new RecipeGroup(() => "Vile or Vicious Mushroom", new int[]
            {
                    ItemID.VileMushroom,
                    ItemID.ViciousMushroom
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:EvilMushroom", group);

            group = new RecipeGroup(() => "Any Normal Fish", new int[]
            {
                    ItemID.Bass,
                    ItemID.Trout,
                    ItemID.Salmon,
                    ItemID.AtlanticCod,
                    ItemID.Tuna,
                    ItemID.RedSnapper
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:PreyFish", group);

            group = new RecipeGroup(() => "Ichor or Cursed Flames", new int[]
            {
                    ItemID.Ichor,
                    ItemID.CursedFlame
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:IchororCursedFlames", group);

            group = new RecipeGroup(() => "Any Evil Seed", new int[]
            {
                    ItemID.CrimsonSeeds,
                    ItemID.CorruptSeeds
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:EvilSeeds", group);

            group = new RecipeGroup(() => "Any Evil Stone", new int[]
            {
                    ItemID.CrimstoneBlock,
                    ItemID.EbonstoneBlock
            });
            RecipeGroup.RegisterGroup("Thaumaturgy:EvilStone", group);
        }

        public override void AddRecipes() //vanilla items are craftable using thaumaturgy!
        {
            ///////////////////////
            // ACCESSORIES/ITEMS //
            ///////////////////////

            //Magic Mirror - 5 recall potions, 3 iron bars, 5 glass, and 3 auric shards
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.RecallPotion, 5);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddIngredient(ItemID.Glass, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"), 3);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.MagicMirror);
            recipe.AddRecipe();

            //Cloud in a Bottle - 1 bottle, 20 clouds, and 3 auric shards
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Cloud, 20);
            recipe.AddIngredient(this.ItemType("AuricShard"), 3);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.CloudinaBottle);
            recipe.AddRecipe();

            //Blizzard in a Bottle - 1 cloud in a bottle, 30 snow, and 6 auric shards
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CloudinaBottle);
            recipe.AddIngredient(ItemID.SnowBlock, 30);
            recipe.AddIngredient(this.ItemType("AuricShard"), 6);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.BlizzardinaBottle);
            recipe.AddRecipe();

            //Sandstorm in a Bottle - 1 blizzard in a bottle, 50 sand, and 1 auric core
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.BlizzardinaBottle);
            recipe.AddIngredient(ItemID.SandBlock, 50);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.SandstorminaBottle);
            recipe.AddRecipe();

            //Hermes Boots - 10 silk, 1 potion of swiftness, and 3 auric shards
            recipe = new ModRecipe(this); 
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SwiftnessPotion);
            recipe.AddIngredient(this.ItemType("AuricShard"), 3);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.HermesBoots);
            recipe.AddRecipe();

            //Aglet - 5 iron bars and 1 auric shard
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.Aglet);
            recipe.AddRecipe();

            //Anklet of the Wind - 1 aglet, 5 jungle spores, 2 vines, and 3 auric shards
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Aglet, 1);
            recipe.AddIngredient(ItemID.JungleSpores, 5);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddIngredient(this.ItemType("AuricShard"), 3);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.AnkletoftheWind);
            recipe.AddRecipe();

            //Ice Skates - 3 leather, 5 iron bars, and 1 auric shard
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Leather, 3);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.IceSkates);
            recipe.AddRecipe();

            //Fish Finder - 5 iron bars, 2 gold bars, 10 wire, 1 radar, 3 crystal shards, 5 sapphires, 1 mechanical lens, and 1 auric core
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddRecipeGroup("Thaumaturgy:GoldBar", 2);
            recipe.AddIngredient(ItemID.Wire, 10);
            recipe.AddIngredient(ItemID.Radar, 1);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddIngredient(ItemID.Sapphire, 5);
            recipe.AddIngredient(ItemID.MechanicalLens, 1);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.FishFinder);
            recipe.AddRecipe();

            //Goblin Tech - 10 iron bars, 15 wire, 50 spiky balls, 2 hellstone, and 1 auric core
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemID.Wire, 15);
            recipe.AddIngredient(ItemID.SpikyBall, 50);
            recipe.AddIngredient(ItemID.Hellstone, 2);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.GoblinTech);
            recipe.AddRecipe();

            //GPS - 3 iron bars, 3 gold bars, 20 wire, 2 sapphires, and 1 auric core
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddRecipeGroup("Thaumaturgy:GoldBar", 3);
            recipe.AddIngredient(ItemID.Wire, 20);
            recipe.AddIngredient(ItemID.Sapphire, 2);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.GPS);
            recipe.AddRecipe();

            //R.E.K. 3000 - 5 iron bars, 1 gold bar, 30 wire, 2 books, and 1 auric core
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddRecipeGroup("Thaumaturgy:GoldBar", 1);
            recipe.AddIngredient(ItemID.Wire, 30);
            recipe.AddIngredient(ItemID.Book, 2);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.REK);
            recipe.AddRecipe();

            //Ankh Charm - 30 pixie dust, 30 ichor/cursed flames, 10 hallow seeds, 10 crimson/corruption seeds, 100 bones, 15 of each soul, 5 mana crystals, 5 life crystals, and 25 auric shards
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PixieDust, 30);
            recipe.AddRecipeGroup("Thaumaturgy:IchororCursedFlames", 30);
            recipe.AddIngredient(ItemID.HallowedSeeds, 10);
            recipe.AddRecipeGroup("Thaumaturgy:EvilSeeds", 10);
            recipe.AddIngredient(ItemID.Bone, 100);
            recipe.AddIngredient(ItemID.SoulofFlight, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddIngredient(ItemID.ManaCrystal, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"), 25);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.AnkhCharm);
            recipe.AddRecipe();

            //Rod of Discord - 25 pixie dust, 1 unicorn horn, 15 souls of light, 3 crystal shards, 5 hallowed bars, and 10 auric cores
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PixieDust, 25);
            recipe.AddIngredient(ItemID.UnicornHorn, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(this.ItemType("AuricCore"), 10);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.RodofDiscord);
            recipe.AddRecipe();

            //Endless Quiver - Same materials as vanilla, plus an auric core
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenArrow, 3996);
            recipe.AddIngredient(this.ItemType("AuricCore"), 1);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.EndlessQuiver);
            recipe.AddRecipe();

            //Endless Musket Pouch - See above
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MusketBall, 3996);
            recipe.AddIngredient(this.ItemType("AuricCore"), 1);
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("SynthesisFocus"));
            recipe.SetResult(ItemID.EndlessMusketPouch);
            recipe.AddRecipe();

            /////////////
            // POTIONS //
            /////////////
            // Auric conversion ratios are different between potions. //
            // These recipes require a transmutation focus. //

            // Low-tier combat potions - 3/shard //
            //Ironskin
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Thaumaturgy:IronOrLead");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.IronskinPotion, 3);
            recipe.AddRecipe();

            //Regeneration
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Mushroom);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.RegenerationPotion, 3);
            recipe.AddRecipe();

            //Swiftness
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Cactus);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.SwiftnessPotion, 3);
            recipe.AddRecipe();

            // Low-tier exploration potions - 3/shard //
            //Dangersense
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Cobweb);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.TrapsightPotion, 3);
            recipe.AddRecipe();

            //Featherfall
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Cloud);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.FeatherfallPotion, 3);
            recipe.AddRecipe();

            //Flipper
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.FlipperPotion, 3);
            recipe.AddRecipe();

            //Gills
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.GillsPotion, 3);
            recipe.AddRecipe();

            //Hunter
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.GlowingMushroom);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.HunterPotion, 3);
            recipe.AddRecipe();

            //Night Owl
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Lens);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.NightOwlPotion, 3);
            recipe.AddRecipe();

            //Shine
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Torch);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.ShinePotion, 3);
            recipe.AddRecipe();

            //Water Walking
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Glass);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.WaterWalkingPotion, 3);
            recipe.AddRecipe();

            //Recall
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Wood");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.RecallPotion, 3);
            recipe.AddRecipe();

            //Wormhole
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Glass);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.WormholePotion, 3);
            recipe.AddRecipe();

            // Mid-tier combat potions - 2/shard //
            //Ammo Reservation
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.MusketBall);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.AmmoReservationPotion, 2);
            recipe.AddRecipe();

            //Archery
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.FlamingArrow);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.ArcheryPotion, 2);
            recipe.AddRecipe();

            //Battle
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Thaumaturgy:EvilMushroom");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.BattlePotion, 2);
            recipe.AddRecipe();

            //Calm
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.PurificationPowder);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.CalmingPotion, 2);
            recipe.AddRecipe();

            //Endurance
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("IronBar");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.EndurancePotion, 2);
            recipe.AddRecipe();

            //Inferno
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.SandBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.InfernoPotion, 2);
            recipe.AddRecipe();

            //Magic Power
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.MagicPowerPotion, 2);
            recipe.AddRecipe();

            //Mana Regeneration
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.FallenStar);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.ManaRegenerationPotion, 2);
            recipe.AddRecipe();

            //Summoning
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.ClayBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.SummoningPotion, 2);
            recipe.AddRecipe();

            //Titan
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Stinger);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.TitanPotion, 2);
            recipe.AddRecipe();

            //Thorns
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Cactus);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.ThornsPotion, 2);
            recipe.AddRecipe();

            //Warmth
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.SandBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.WarmthPotion, 2);
            recipe.AddRecipe();

            // High-tier exploration potions - 1/shard //
            //Gravitation
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Silk);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.GravitationPotion);
            recipe.AddRecipe();

            //Mining
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.MiningPotion);
            recipe.AddRecipe();

            //Obsidian Skin
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.ObsidianSkinPotion);
            recipe.AddRecipe();

            //Spelunker
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Thaumaturgy:GoldOrPlatinum");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.SpelunkerPotion);
            recipe.AddRecipe();

            // High-tier combat potions - 1/shard //
            //Heartreach
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Sunflower);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.HeartreachPotion);
            recipe.AddRecipe();

            //Invisibility
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Glass);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.InvisibilityPotion);
            recipe.AddRecipe();

            //Lifeforce
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.HealingPotion);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.LifeforcePotion);
            recipe.AddRecipe();

            //Rage
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.RagePotion);
            recipe.AddRecipe();

            //Wrath
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.IceBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.WrathPotion);
            recipe.AddRecipe();

            // Fishing potions - 2/shard //
            //Fishing
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Thaumaturgy:IronOrLead");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.FishingPotion, 2);
            recipe.AddRecipe();

            //Crate
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddRecipeGroup("Wood");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.CratePotion, 2);
            recipe.AddRecipe();

            //Sonar
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.Lens);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.SonarPotion, 2);
            recipe.AddRecipe();

            // Other potions - 2/shard //
            //Builder
            recipe = new ModRecipe(this);
            recipe.AddIngredient(this.ItemType("SpellboundWater"));
            recipe.AddIngredient(ItemID.RedBrick);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(ItemID.BuilderPotion, 2);
            recipe.AddRecipe();

            // Calamity potions - 1/shard //
            var Calamity = ModLoader.GetMod("CalamityMod"); //we'll cache this for efficiency
            if (Calamity != null)
            {
                //Cadence
                recipe = new ModRecipe(this);
                recipe.AddIngredient(this.ItemType("SpellboundWater"));
                recipe.AddIngredient(ItemID.PinkGel);
                recipe.AddIngredient(this.ItemType("AuricShard"));
                recipe.AddTile(this.TileType("Thaumatrestle"));
                recipe.AddTile(this.TileType("TransmutationFocus"));
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(Calamity.ItemType("CadencePotion"));
                recipe.AddRecipe();

                //Omniscience
                recipe = new ModRecipe(this);
                recipe.AddIngredient(this.ItemType("SpellboundWater"));
                recipe.AddIngredient(ItemID.BlackLens);
                recipe.AddIngredient(this.ItemType("AuricShard"));
                recipe.AddTile(this.TileType("Thaumatrestle"));
                recipe.AddTile(this.TileType("TransmutationFocus"));
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(Calamity.ItemType("PotionofOmniscience"));
                recipe.AddRecipe();

                //Yharim's Stimulants
                recipe = new ModRecipe(this);
                recipe.AddIngredient(this.ItemType("SpellboundWater"));
                recipe.AddIngredient(Calamity.ItemType("AerialiteBar"));
                recipe.AddIngredient(this.ItemType("AuricShard"));
                recipe.AddTile(this.TileType("Thaumatrestle"));
                recipe.AddTile(this.TileType("TransmutationFocus"));
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(Calamity.ItemType("YharimsStimulants"));
                recipe.AddRecipe();

                //Zerg
                recipe = new ModRecipe(this);
                recipe.AddIngredient(this.ItemType("SpellboundWater"));
                recipe.AddIngredient(ItemID.Shuriken);
                recipe.AddIngredient(this.ItemType("AuricShard"));
                recipe.AddTile(this.TileType("Thaumatrestle"));
                recipe.AddTile(this.TileType("TransmutationFocus"));
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(Calamity.ItemType("ZergPotion"));
                recipe.AddRecipe();

                //Zen
                recipe = new ModRecipe(this);
                recipe.AddIngredient(this.ItemType("SpellboundWater"));
                recipe.AddIngredient(ItemID.Cloud);
                recipe.AddIngredient(this.ItemType("AuricShard"));
                recipe.AddTile(this.TileType("Thaumatrestle"));
                recipe.AddTile(this.TileType("TransmutationFocus"));
                recipe.AddTile(TileID.Bottles);
                recipe.SetResult(Calamity.ItemType("ZenPotion"));
                recipe.AddRecipe();
            }

            //////////
            // FISH //
            //////////
            // Prey fish can be combined with ingredients and auric shards to make Angler quest fish. //
            // These recipes require a transmutation focus. //

            //Amanitia Fungifin
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.GlowingMushroom, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.AmanitiaFungifin);
            recipe.AddRecipe();

            //Angelfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.RainCloud, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Angelfish);
            recipe.AddRecipe();

            //Batfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddRecipeGroup("Thaumaturgy:GoldOrPlatinum", 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Batfish);
            recipe.AddRecipe();

            //Bloody Man-o-War
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.BloodyManowar);
            recipe.AddRecipe();

            //Bonefish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Bonefish);
            recipe.AddRecipe();

            //Bumblebee Tuna
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.BumblebeeTuna);
            recipe.AddRecipe();

            //Bunnyfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Bunny);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Bunnyfish);
            recipe.AddRecipe();

            //Cap'n Tunabeard
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SharkFin);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.CapnTunabeard);
            recipe.AddRecipe();

            //Catfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish", 6);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Catfish);
            recipe.AddRecipe();

            //Cloudfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Cloud, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Cloudfish);
            recipe.AddRecipe();

            //Clownfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SandBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Clownfish);
            recipe.AddRecipe();

            //Cursedfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.CursedFlame, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Cursedfish);
            recipe.AddRecipe();

            //Demonic Hellfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.AshBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.DemonicHellfish);
            recipe.AddRecipe();

            //Derpfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.JungleGrassSeeds);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Derpfish);
            recipe.AddRecipe();

            //Dirtfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Dirtfish);
            recipe.AddRecipe();

            //Dynamite Fish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Dynamite);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.DynamiteFish);
            recipe.AddRecipe();

            //Eater of Plankton
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.EaterofPlankton);
            recipe.AddRecipe();

            //Fallen Starfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.FallenStarfish);
            recipe.AddRecipe();

            //Fish of Cthulhu
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Lens, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TheFishofCthulu);
            recipe.AddRecipe();

            //Fishotron
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Bone, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Fishotron);
            recipe.AddRecipe();

            //Fishron
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.HallowedSeeds);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Fishron);
            recipe.AddRecipe();

            //Guide Voodoo Fish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.WorkBench);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.GuideVoodooFish);
            recipe.AddRecipe();

            //Harpyfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Harpyfish);
            recipe.AddRecipe();

            //Hungerfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.AshBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Hungerfish);
            recipe.AddRecipe();

            //Ichorfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Ichor, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Ichorfish);
            recipe.AddRecipe();

            //Infected Scabbardfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.EbonstoneBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.InfectedScabbardfish);
            recipe.AddRecipe();

            //Jewelfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Amethyst);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Jewelfish);
            recipe.AddRecipe();

            //Mirage Fish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.MirageFish);
            recipe.AddRecipe();

            //Mudfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.MudBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Mudfish);
            recipe.AddRecipe();

            //Mutant Flinxfin
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SnowBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.MutantFlinxfin);
            recipe.AddRecipe();

            //Pengfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SnowBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Pengfish);
            recipe.AddRecipe();

            //Pixiefish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.PixieDust, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Pixiefish);
            recipe.AddRecipe();

            //Slimefish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Slimefish);
            recipe.AddRecipe();

            //Spiderfish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.Cobweb, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Spiderfish);
            recipe.AddRecipe();

            //Tropical Barracuda
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SilverCoin, 2); //not quite platinum
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TropicalBarracuda);
            recipe.AddRecipe();

            //Tundra Trout
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.IceBlock, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TundraTrout);
            recipe.AddRecipe();

            //Unicorn Fish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.UnicornHorn);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.UnicornFish);
            recipe.AddRecipe();

            //Wyverntail
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddIngredient(ItemID.SoulofFlight, 1);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Wyverntail);
            recipe.AddRecipe();

            //Zombie Fish
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Thaumaturgy:PreyFish");
            recipe.AddRecipeGroup("IronBar"); //shackle!
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.ZombieFish);
            recipe.AddRecipe();

            ////////////////
            // TRANSMUTES //
            ////////////////
            // Transmutation involves turning items into their rough equivalents, usually corruption to crimson and vice-versa. //
            // These recipes require a transmutation focus. //

            //Copper <-> Tin, Iron <-> Lead, Silver <-> Tungsten, Gold <-> Platinum
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CopperOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TinOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TinOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.CopperOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.LeadOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.IronOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TungstenOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.SilverOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GoldOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.PlatinumOre, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PlatinumOre, 10);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.GoldOre, 10);
            recipe.AddRecipe();

            //Rotten Chunks <-> Vertebrae
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.RottenChunk, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Vertebrae, 5);
            recipe.AddRecipe();

            //Ebonstone <-> Crimstone
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.CrimstoneBlock, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.EbonstoneBlock, 25);
            recipe.AddRecipe();

            //Demonite <-> Crimtane
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DemoniteOre, 3);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.CrimtaneOre, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CrimtaneOre, 3);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.DemoniteOre, 3);
            recipe.AddRecipe();

            //Shadow Scales <-> Tissue Samples
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ShadowScale, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.TissueSample, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TissueSample, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.ShadowScale, 5);
            recipe.AddRecipe();

            //Cursed Flames <-> Ichor
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CursedFlame, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Ichor, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ichor, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.CursedFlame, 5);
            recipe.AddRecipe();

            //Purple Solution <-> Red Solution
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PurpleSolution, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.RedSolution, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.RedSolution, 5);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.PurpleSolution, 5);
            recipe.AddRecipe();

            //Ebonkoi <-> Hemopiranha
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ebonkoi);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Hemopiranha);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Hemopiranha);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Ebonkoi);
            recipe.AddRecipe();

            //Lens -> Black Lens
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Lens);
            recipe.AddIngredient(ItemID.BlackInk);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.BlackLens);
            recipe.AddRecipe();

            //Wood types between one another
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Wood, 25);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.BorealWood, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.RichMahogany, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Shadewood, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Ebonwood, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.PalmWood, 25);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("TransmutationFocus"));
            recipe.SetResult(ItemID.Pearlwood, 25);
            recipe.AddRecipe();

            /////////////////
            // REPLICATION //
            /////////////////
            // These recipes use auric power to replicate materials. //
            // Mundane materials require a replication focus. //
            // Valuable pre-Hardmode materials require a kaleidoscopic focus. //
            // Valuable Hardmode materials require a celestial focus. //

            // MUNDANE //
            //Dirt x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.DirtBlock, 25);
            recipe.AddRecipe();

            //Stone x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.StoneBlock, 25);
            recipe.AddRecipe();

            //Clay x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ClayBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.ClayBlock, 25);
            recipe.AddRecipe();

            //Wood x 25
            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood");
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.Wood, 25);
            recipe.AddRecipe();

            //Sand x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SandBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.SandBlock, 25);
            recipe.AddRecipe();

            //Mud x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MudBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.MudBlock, 25);
            recipe.AddRecipe();

            //Snow x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SnowBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.SnowBlock, 25);
            recipe.AddRecipe();

            //Ice x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IceBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.IceBlock, 25);
            recipe.AddRecipe();

            //Ash x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.AshBlock);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.AshBlock, 25);
            recipe.AddRecipe();

            //Granite x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Granite);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.Granite, 25);
            recipe.AddRecipe();

            //Marble x 25
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Marble);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.Marble, 25);
            recipe.AddRecipe();

            //Gel x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Gel);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.Gel, 20);
            recipe.AddRecipe();

            //Pink Gel x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PinkGel);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.PinkGel, 5);
            recipe.AddRecipe();

            //Glowing Mushroom x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GlowingMushroom);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("ReplicationFocus"));
            recipe.SetResult(ItemID.GlowingMushroom, 3);
            recipe.AddRecipe();





            // KALEIDOSCOPIC //
            //Copper Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CopperOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.CopperOre, 3);
            recipe.AddRecipe();

            //Tin Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TinOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.TinOre, 3);
            recipe.AddRecipe();

            //Iron Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.IronOre, 3);
            recipe.AddRecipe();

            //Lead Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.LeadOre, 3);
            recipe.AddRecipe();

            //Silver Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SilverOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.SilverOre, 3);
            recipe.AddRecipe();

            //Tungsten Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TungstenOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.TungstenOre, 3);
            recipe.AddRecipe();

            //Gold Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TinOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.GoldOre, 3);
            recipe.AddRecipe();

            //Platinum Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.PlatinumOre, 3);
            recipe.AddRecipe();

            //Meteorite x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Meteorite);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Meteorite, 3);
            recipe.AddRecipe();

            //Obsidian x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Obsidian, 3);
            recipe.AddRecipe();

            //Hellstone x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Hellstone);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Hellstone, 2);
            recipe.AddRecipe();

            //Topaz x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Topaz);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Topaz, 5);
            recipe.AddRecipe();

            //Amethyst x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Amethyst);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Amethyst, 5);
            recipe.AddRecipe();

            //Sapphire x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Sapphire);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Sapphire, 5);
            recipe.AddRecipe();

            //Ruby x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ruby);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Ruby, 5);
            recipe.AddRecipe();

            //Emerald x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Emerald);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Emerald, 5);
            recipe.AddRecipe();

            //Diamond x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Diamond);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Diamond, 5);
            recipe.AddRecipe();

            //Life Crystal x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.LifeCrystal, 2);
            recipe.AddRecipe();

            //Cloud x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Cloud);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("KaleidoscopicFocus"));
            recipe.SetResult(ItemID.Cloud, 5);
            recipe.AddRecipe();





            // CELESTIAL //
            //Cobalt Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.CobaltOre, 3);
            recipe.AddRecipe();

            //Palladium Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PalladiumOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.PalladiumOre, 3);
            recipe.AddRecipe();

            //Mythril Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MythrilOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.MythrilOre, 3);
            recipe.AddRecipe();

            //Orichalcum Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.OrichalcumOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.OrichalcumOre, 3);
            recipe.AddRecipe();

            //Adamantite Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.AdamantiteOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.AdamantiteOre, 3);
            recipe.AddRecipe();

            //Titanium Ore x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.TitaniumOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.TitaniumOre, 3);
            recipe.AddRecipe();

            //Soul of Light x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofLight, 5);
            recipe.AddRecipe();

            //Soul of Night x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofNight, 5);
            recipe.AddRecipe();

            //Soul of Flight x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofFlight, 5);
            recipe.AddRecipe();

            //Soul of Fright x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofFright, 3);
            recipe.AddRecipe();

            //Soul of Might x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofMight, 3);
            recipe.AddRecipe();

            //Soul of Sight x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.SoulofSight, 3);
            recipe.AddRecipe();

            //Hallowed Bar x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HallowedBar);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.HallowedBar, 3);
            recipe.AddRecipe();

            //Crystal Shard x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CrystalShard);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.CrystalShard, 5);
            recipe.AddRecipe();

            //Cursed Flames x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CursedFlame);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.CursedFlame, 5);
            recipe.AddRecipe();

            //Ichor x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ichor);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.Ichor, 5);
            recipe.AddRecipe();

            //Chlorophyte x 3
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.ChlorophyteOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.ChlorophyteOre, 3);
            recipe.AddRecipe();

            //Vortex Fragment x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FragmentVortex);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.FragmentVortex, 2);
            recipe.AddRecipe();

            //Nebula Fragment x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FragmentNebula);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.FragmentNebula, 2);
            recipe.AddRecipe();

            //Solar Fragment x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FragmentSolar);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.FragmentSolar, 2);
            recipe.AddRecipe();

            //Stardust Fragment x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.FragmentStardust);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.FragmentStardust, 2);
            recipe.AddRecipe();

            //Luminite x 5
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LunarOre);
            recipe.AddIngredient(this.ItemType("AuricShard"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.LunarOre, 5);
            recipe.AddRecipe();

            //Life Fruit x 2
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LifeFruit);
            recipe.AddIngredient(this.ItemType("AuricCore"));
            recipe.AddTile(this.TileType("Thaumatrestle"));
            recipe.AddTile(this.TileType("CelestialFocus"));
            recipe.SetResult(ItemID.LifeFruit, 2);
            recipe.AddRecipe();
        }
    }

    class ThaumaturgyGlobalNPC : GlobalNPC
    {
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.FindBuffIndex(mod.BuffType("WateryEmbers")) != -1)
            {
                spawnRate = (int)(spawnRate / 25f);
                maxSpawns = (int)(maxSpawns * 25f);
            }
        }
    }
}
