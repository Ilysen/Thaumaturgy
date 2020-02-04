using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class SpellboundWater : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Ingredients/SpellboundWater";
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Spellbound Water");
            Tooltip.SetDefault("Water imbued with aura\nUsed in thaumic alchemy");
        }

		public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.rare = 2;
            item.potion = true;
            item.healLife = 50;
            item.healMana = 25;
            item.consumable = true;
        }
	}
}
