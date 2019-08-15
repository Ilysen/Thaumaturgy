using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Placeable
{
	public class ConjurersLamp : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Conjurer's Lamp");
            Tooltip.SetDefault("Creates glimmer lights using mana\nUses 2 mana");
        }

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 28;
			item.maxStack = 1;
			item.noWet = true;
			item.useTurn = true;
			item.autoReuse = true;
            item.consumable = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.createTile = mod.TileType("AuricTorch");
            item.tileBoost = 10;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 1;
		}

		public override void PostUpdate()
		{
			Lighting.AddLight((int)((item.position.X + item.width / 2) / 16f), (int)((item.position.Y + item.height / 2) / 16f), 1f, 0.75f, 1f  );
        }

        public override bool CanUseItem(Player player)
        {
            if(player.statMana < 2)
            {
                return false;
            }
            return base.CanUseItem(player);
        }

        public override bool ConsumeItem(Player player)
        {
            if (player.statMana >= 2)
            {
                player.statMana -= 2;
                Main.PlaySound(SoundID.Item10.WithVolume(0.25f), player.Center);
            }
            return false;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Torch, 5);
            recipe.AddIngredient(mod.ItemType("AuricShard"), 10);
            recipe.AddRecipeGroup("Thaumaturgy:IronBar", 3);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}