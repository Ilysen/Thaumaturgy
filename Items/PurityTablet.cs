using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class PurityTablet : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purity Tablet");
            Tooltip.SetDefault("A tablet etched with words of harmony\n" +
                "Prematurely ends events relating to the sun or moon");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 25, 0);
			item.rare = 2;
            item.maxStack = 99;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.bloodMoon || Main.eclipse || Main.pumpkinMoon || Main.snowMoon;
        }

        public override bool UseItem(Player player)
        {
            Main.eclipse = false;
            Main.bloodMoon = false;
            Main.pumpkinMoon = false;
            Main.snowMoon = false;
            if (Main.netMode == NetmodeID.Server)
            {
                NetMessage.SendData(MessageID.WorldData);
            }
            Main.PlaySound(SoundID.Item60.WithVolume(0.5f), player.Center);
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Boulder);
            recipe.AddIngredient(ItemID.GrassSeeds, 3);
            recipe.AddIngredient(ItemID.Acorn);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}