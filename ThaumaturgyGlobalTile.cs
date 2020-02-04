using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy
{
	public class ThaumaturgyGlobalTile : GlobalTile
	{
		public override bool Drop(int i, int j, int type)
		{
			bool baseDropped = base.Drop(i, j, type);
			bool avariceActive = false;
			if (Main.netMode == NetmodeID.Server)
			{
				foreach (Player ourPlayer in Main.player)
				{
					if (ourPlayer.active && (ourPlayer.HasBuff(mod.BuffType("Avarice")) || ourPlayer.buffImmune[mod.BuffType("Avarice")]))
					{
						avariceActive = true;
						break;
					}
				}
			}
			else
			{
				Player ourPlayer = Main.LocalPlayer;
				if (ourPlayer.HasBuff(mod.BuffType("Avarice")) || ourPlayer.buffImmune[mod.BuffType("Avarice")])
				{
					avariceActive = true;
				}
			}

			// only Daring and Daredevilry provide immunity to Avarice - and they both require its elixir - so we apply the effects either way
			if (avariceActive && baseDropped)
			{
				int extraGems = Main.rand.Next(1, 3);
				switch (type)
				{
					case TileID.Amethyst:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Amethyst, extraGems);
						break;

					case TileID.Topaz:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Topaz, extraGems);
						break;

					case TileID.Emerald:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Emerald, extraGems);
						break;

					case TileID.Sapphire:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Sapphire, extraGems);
						break;

					case TileID.Ruby:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Ruby, extraGems);
						break;

					case TileID.Diamond:
						Item.NewItem(i * 16, j * 16, 16, 16, ItemID.Diamond, extraGems);
						break;
				}
			}
			return baseDropped;
		}
	}
}