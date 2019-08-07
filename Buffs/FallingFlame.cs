using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Buffs
{
	public class FallingFlame : ModBuff
    {
        int soundtimer = 0;
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Falling Star");
            Description.SetDefault("Wheeeeeeeee!");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.velocity.Y >= 0 && player.velocity.X == 0)
            {
                player.ClearBuff(Type);
            }
            Dust.NewDust(player.Center, 30, 30, 15, 0, 0, 0, default(Color), 1.5f);

            soundtimer++;
            if (soundtimer <= 0)
            {
                Main.PlaySound(SoundID.Item9.WithVolume(0.25f), player.Center);
                soundtimer = 3;
            }
        }
    }
}
