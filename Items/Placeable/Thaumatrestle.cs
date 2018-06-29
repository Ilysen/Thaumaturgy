using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
	public class Thaumatrestle : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thaumatrestle");
            Tooltip.SetDefault("Tools, instruments, and devices for all your thaumaturgy needs\nCounts as a regular workbench");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 1000;
            item.rare = 1;
			item.createTile = mod.TileType("Thaumatrestle");
		}
	}
}