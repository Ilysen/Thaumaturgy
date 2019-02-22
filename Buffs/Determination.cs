using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Determination : ModBuff
	{
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Determination");
            Description.SetDefault("Grants heightened defensive and offensive capabilities, and reduces chance to consume ammo");
            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
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

            //And make us immune to the vanilla buffs to prevent duplication
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
        }
    }
}
