using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class AuraAegis : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aura Aegis");
            Tooltip.SetDefault("Double tap a direction to dash into enemies\nGrants immunity to knockback and fire blocks" +
                "\nGrants immunity to almost all debuffs");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
            item.value = Item.sellPrice(0, 25, 0, 0);
            item.rare = 9;
			item.accessory = true;
			item.defense = 6;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.dash = 2;
            player.noKnockback = true;
            player.fireWalk = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.Gravitation] = true;
        }

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EoCShield);
            recipe.AddIngredient(ItemID.AnkhShield);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 5);
            recipe.AddIngredient(mod.ItemType("AuricCore"), 3);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}