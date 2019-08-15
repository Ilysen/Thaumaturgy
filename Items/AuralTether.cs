using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Items
{
	public class AuralTether : ModItem
	{
        private Vector2 markedPoint;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aural Tether");
            Tooltip.SetDefault("Left-click to mark a point in space\n" +
                "Left-click again to teleport back and clear the mark\n" +
                "Right-click to clear the mark without teleporting to it\n" +
                "Must be on your hotbar to work");
        }

        public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.useTime = 60;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 25, 0);
			item.rare = 4;
            item.maxStack = 1;
            item.consumable = false;
			item.noMelee = true;
            markedPoint = default;
        }

        public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            Texture2D texture = mod.GetTexture("Items/AuralTether");
            if (markedPoint != default)
            {
                texture = mod.GetTexture("Items/AuralTether_Set");
            }
            spriteBatch.Draw(texture, position, null, Color.White, 0, origin, scale, SpriteEffects.None, 0f);
            return false;
        }

        public override bool UseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
                markedPoint = default;
                Thaumaturgy.NewText(player, "Tether point reset.", 135, 115, 255);
                Main.PlaySound(SoundID.Item73.WithVolume(0.5f), player.Center);
                return true;
            }
            if (markedPoint == default)
            {
                Thaumaturgy.NewText(player, "Tether point marked.", 135, 115, 255);
                markedPoint = player.position;
                Main.PlaySound(SoundID.Item73.WithVolume(0.5f), player.Center);
            }
            else
            {
                Thaumaturgy.NewText(player, "The tether yanks you through space and time.", 135, 115, 255);
                player.Teleport(markedPoint);
                Main.PlaySound(SoundID.Item74.WithVolume(0.5f), player.Center);
                markedPoint = default;
            }
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror);
            recipe.AddIngredient(ItemID.Book, 3);
            recipe.AddIngredient(mod.ItemType("AuricCore"));
            recipe.AddIngredient(mod.ItemType("Starbrass"), 5);
            recipe.AddTile(mod.TileType("Thaumatrestle"));
            recipe.AddTile(mod.TileType("SynthesisFocus"));
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}