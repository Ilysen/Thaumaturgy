using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class BottledLightning : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Items/BottledLightning";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bottled Lightning");
            Tooltip.SetDefault("Crackling ball lightning flickers and sparks against the glass\nUse to unleash the lightning into the atmosphere and start a thunderstorm\nCan also be used to disrupt and stop existing thunderstorms");
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
            item.UseSound = SoundID.Item21;
            item.maxStack = 99;
            item.consumable = true;
			item.noMelee = true;
        }

        public override bool UseItem(Player player)
        {
            if (!Main.raining)
            {
                Main.raining = true;
                Main.NewText("Lightning roars from the bottle and into the sky!", 100, 100, 255);
                int num = 86400;
                int num2 = num / 24;
                Main.rainTime = Main.rand.Next(num2 * 8, num);
                Main.raining = true;
                Main.maxRaining = Main.rand.Next(20, 60) * 0.01f;
            }
            else
            {
                Main.NewText("The stormclouds shudder and begin to break apart.", 100, 255, 100);
                Main.rainTime = 0;
                Main.raining = false;
                Main.maxRaining = 0f;
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Goldfish, 3);
            recipe.AddIngredient(mod.ItemType("AuricShard"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}