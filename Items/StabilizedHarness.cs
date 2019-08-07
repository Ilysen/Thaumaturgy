using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Thaumaturgy.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class StabilizedHarness : ModItem
    {
        int soundtimer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stabilized Harness");
            Tooltip.SetDefault("Allows flight and slow fall\nStabilised using souls of flight - won't malfunction");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(0, 50, 0, 0);
            item.rare = 6;
            item.accessory = true;
            item.defense = 1;
        }
        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 150;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 2f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 8f;
            acceleration *= 1.5f;
        }

        public override bool WingUpdate(Player player, bool inUse)
        {
            if(player.controlJump && player.velocity.Y != 0)
            {
                Vector2 position = player.Center;
                position.X -= (player.direction == 1 ? 30f : 0f * player.direction);
                Lighting.AddLight(position, 0.5f, 0.5f, 1f);
                float horizontalSpread = Main.rand.Next(-3, 3);
                if (player.wingTime > 0)
                {
                    Dust.NewDust(position, 30, 30, 15, horizontalSpread, 10f, 0, default(Color), 1.447368f);
                }
                else
                {
                    Dust.NewDust(position, 30, 30, 15, horizontalSpread, 5f, 0, default(Color), 1.447368f);
                }
                if (soundtimer <= 0)
                {
                    horizontalSpread = Main.rand.Next(-5, 5);
                    Main.PlaySound(SoundID.Item9.WithVolume(0.25f), player.Center);
                    soundtimer = 3;
                }
                else
                {
                    soundtimer--;
                }
                player.wingFrameCounter++;
                if (player.wingFrameCounter > 4)
                {
                    player.wingFrame++;
                    player.wingFrameCounter = 0;
                    if (player.wingFrame >= 3)
                    {
                        player.wingFrame = 1;
                    }
                }
            }
            else
            {
                player.wingFrame = 0;
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("AurelianHarness"));
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}