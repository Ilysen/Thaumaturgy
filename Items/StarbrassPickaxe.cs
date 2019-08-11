using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class StarbrassPickaxe : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starbrass Pickaxe");
            Tooltip.SetDefault("Deals magic damage\nDispels creatures made of earth");
        }

		public override void SetDefaults()
        {
            item.damage = 11;
            item.magic = true;
            item.autoReuse = true;
            item.useTurn = true;
            item.knockBack = 3;
            item.width = 32;
			item.height = 32;
            item.useTime = 10;
			item.useAnimation = 30;
			item.useStyle = 1;
            item.pick = 80;
            item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 2;
            item.maxStack = 1;
            item.UseSound = SoundID.Item1;
        }

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (target.type == NPCID.MeteorHead || target.type == NPCID.GraniteFlyer || target.type == NPCID.GraniteGolem)
            {
                damage += target.lifeMax * 10; // overkill? what's that?
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 10);
            recipe.AddRecipeGroup("Wood", 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddIngredient(ItemID.NightmarePickaxe);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 10);
            recipe.AddRecipeGroup("Wood", 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("AuricShard"), 5);
            recipe.AddIngredient(ItemID.DeathbringerPickaxe);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}