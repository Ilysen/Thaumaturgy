using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items.Weapons
{
	public class AuricGunshell : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Auric Gunshell");
            Tooltip.SetDefault("An infinite source of ethereal bullets\nVery low knockback, but can pierce");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = false;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 2;
			item.shoot = mod.ProjectileType("EtherealBullet");
			item.shootSpeed = 16f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EndlessMusketPouch);
            recipe.AddIngredient(mod.ItemType("Starbrass"));
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 2);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
