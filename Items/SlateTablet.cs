using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class SlateTablet : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slate Tablet");
            Tooltip.SetDefault("Blackened rock seeping with dark energy\nUse to chant the words and call forth the blood moon during nighttime");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 25, 0);
			item.rare = 3;
            item.maxStack = 99;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool CanUseItem(Player player)
        {
            return !Main.dayTime && !Main.bloodMoon;
        }

        public override bool UseItem(Player player)
        {
            Main.bloodMoon = true;
            Main.PlaySound(SoundID.NPCDeath10.WithVolume(.5f), player.Center);
            Main.NewText("The Blood Moon is rising...", 185, 0, 30);
            if (Main.netMode == NetmodeID.Server)
            {
                NetMessage.SendData(MessageID.WorldData);
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Boulder);
            recipe.AddRecipeGroup("Thaumaturgy:CrimtaneOrDemonite", 10);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}