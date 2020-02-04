using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class AuraAegis : ModItem
	{
		public override string Texture => "Thaumaturgy/Textures/Wearable/AuraAegis";
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aura Aegis");
            Tooltip.SetDefault("Grants immunity to knockback and fire blocks" +
                "\nGrants immunity to most standard debuffs" +
				"\nProtects from Stoned, Chilled, and Frozen" +
				"\nDouble tap a direction to dash into enemies" +
				"\nHide this accessory to disable its dash effect");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = ItemRarityID.Expert;
			item.accessory = true;
			item.defense = 6;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (!hideVisual)
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
        }

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EoCShield);
            recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(ItemID.SoulofMight, 15);
			recipe.AddIngredient(mod.ItemType("AuricSteel"), 5);
            recipe.AddIngredient(mod.ItemType("Starbrass"), 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}