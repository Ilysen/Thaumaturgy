using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Daredevilry : ModBuff
    {
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Daredevilry");
            Description.SetDefault("Grants most vanilla potion benefits");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //Spelunker, Hunter, and Dangersense
            player.findTreasure = true;
            player.detectCreature = true;
            player.dangerSense = true;

            //Night Owl
            player.nightVision = true;

            //Obsidian Skin
            player.lavaImmune = true;

            //Gills, Flipper, and Water Walking
            player.gills = true;
            player.ignoreWater = true;
            player.accFlipper = true;
            player.waterWalk = true;
            player.fireWalk = true;

            //Mining
            player.pickSpeed -= 0.25f;

            //Avarice
            player.goldRing = true;

            //Ironskin
            player.statDefense += 8;

            //Endurance
            player.endurance += 0.1f;

            //Regeneration
            player.lifeRegen += 4;

            //Lifeforce
            player.lifeForce = true;
            player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20;

            //Swiftness
            player.moveSpeed += 0.25f;

            //Wrath
            player.thrownDamage += 0.1f;
            player.meleeDamage += 0.1f;
            player.rangedDamage += 0.1f;
            player.magicDamage += 0.1f;
            player.minionDamage += 0.1f;

            //Rage
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.magicCrit += 10;
            player.thrownCrit += 10;

            //Archery
            player.archery = true;

            //Ammo Reservation
            player.ammoPotion = true;

            //Magic Power
            player.magicDamage += 0.2f;

            //Mana Regeneration
            player.manaRegenBuff = true;

            //Summoning
            player.maxMinions++;

            //And prevent duplicates from vanilla buffs
            player.buffImmune[BuffID.Spelunker] = true;
            player.buffImmune[BuffID.Hunter] = true;
            player.buffImmune[BuffID.Dangersense] = true;
            player.buffImmune[BuffID.NightOwl] = true;
            player.buffImmune[BuffID.ObsidianSkin] = true;
            player.buffImmune[BuffID.Gills] = true;
            player.buffImmune[BuffID.Flipper] = true;
            player.buffImmune[BuffID.WaterWalking] = true;
            player.buffImmune[BuffID.Mining] = true;
            player.buffImmune[BuffID.Ironskin] = true;
            player.buffImmune[BuffID.Endurance] = true;
            player.buffImmune[BuffID.Regeneration] = true;
            player.buffImmune[BuffID.Lifeforce] = true;
            player.buffImmune[BuffID.Swiftness] = true;
            player.buffImmune[BuffID.Wrath] = true;
            player.buffImmune[BuffID.Rage] = true;
            player.buffImmune[BuffID.Archery] = true;
            player.buffImmune[BuffID.AmmoReservation] = true;
            player.buffImmune[BuffID.MagicPower] = true;
            player.buffImmune[BuffID.ManaRegeneration] = true;
            player.buffImmune[BuffID.Summoning] = true;
            player.buffImmune[mod.BuffType("Avarice")] = true;
            player.buffImmune[mod.BuffType("Daring")] = true;
            player.buffImmune[mod.BuffType("Determination")] = true;
        }
    }
}
