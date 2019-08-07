using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
    public class ReplicationFocus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Replication Focus");
            Tooltip.SetDefault("A set of green auric crystals\nUsed to replicate mundane items");
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
            item.createTile = mod.TileType("ReplicationFocus");
        }
    }
}