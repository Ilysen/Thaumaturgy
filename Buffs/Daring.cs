using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Daring : ModBuff
    {
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Daring");
            Description.SetDefault("Grants true sight, liquid immunity, swimming, and increased mining speed");
            Main.buffNoSave[Type] = true;
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
        }
    }
}
