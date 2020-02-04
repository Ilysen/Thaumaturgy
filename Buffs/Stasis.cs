using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class Stasis : ModBuff
	{
		private bool targetTimeSet, targetTime;
		public override void SetDefaults()
        {
            DisplayName.SetDefault("Stasis");
            Description.SetDefault("Frozen in time...");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			if (!targetTimeSet)
			{
				targetTime = !Main.dayTime;
				targetTimeSet = true;
			}
			player.frozen = true;
			Main.fastForwardTime = true;
			if (targetTime == Main.dayTime)
			{
				Main.fastForwardTime = false;
				player.ClearBuff(mod.BuffType("Stasis"));
				targetTime = false;
				targetTimeSet = false;
			}
        }
    }
}
