using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Thaumaturgy.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class AurelianHarness : ModItem
    {
        int soundtimer = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aurelian Harness");
            Tooltip.SetDefault("A chest-strapped cylinder with two exhaust ports mounted on its sides\nChannels magic through meteorite, obsidian-sealed pipes to allow flight\nCruder than wings, and prone to malfunction");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
            item.defense = 1;
        }
        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 100;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.1f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 8f;
            acceleration *= 1f;
        }

        public override bool WingUpdate(Player player, bool inUse)
        {
            if(Main.rand.Next(500) == 0 && player.FindBuffIndex(BuffID.OnFire) == -1 && player.wingTime < player.wingTimeMax * 0.75 && player.wingTime != 0)
            {
                Main.PlaySound(SoundID.DD2_GoblinBomb);
                Main.PlaySound(SoundID.Item44);
                player.AddBuff(BuffID.VortexDebuff, 300, true);
                player.AddBuff(BuffID.OnFire, 300, true);
            }
            if(player.velocity.Y < 0)
            {
                Vector2 position = player.Center;
                position.X -= (player.direction == 1 ? 30f : 0f * player.direction);
                Dust.NewDust(position, 30, 30, 15, 0f, 10f, 0, default(Color), 1.447368f);
                if (soundtimer < 5)
                {
                    soundtimer++;
                }
                else
                {
                    Main.PlaySound(SoundID.Item9.WithVolume(0.5f), player.Center);
                    soundtimer = 0;
                }
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Wood", 25);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddIngredient(ItemID.Wire, 30);
            recipe.AddIngredient(ItemID.MeteoriteBar, 3);
            recipe.AddIngredient(ItemID.Obsidian, 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 5);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 25);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }
    }
}