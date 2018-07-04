using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class ThaumostaticHarness : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thaumostatic Harness");
            Tooltip.SetDefault("A chest-strapped contraption that expels magic around it to nullify gravity\nUnreliable, but does not impede movement\n*This item is work-in-progress*");
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
            if(Main.rand.Next(300) == 0 && player.FindBuffIndex(BuffID.VortexDebuff) == -1 && player.wingTime < player.wingTimeMax * 0.75 && player.wingTime != 0)
            {
                Main.PlaySound(SoundID.DD2_GoblinBomb);
                Main.PlaySound(SoundID.Item44);
                player.AddBuff(BuffID.VortexDebuff, 300, true);
                player.AddBuff(BuffID.OnFire, 300, true);
            }
            return false;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Goggles);
            recipe.AddIngredient(ItemID.SpelunkerPotion);
            recipe.AddIngredient(ItemID.HunterPotion);
            recipe.AddIngredient(ItemID.TrapsightPotion);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 2);
            recipe.SetResult(this);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.AddRecipe();
        }*/
    }
}