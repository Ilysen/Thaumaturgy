using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Thaumaturgy.NPCs
{
	[AutoloadHead]
	public class Thaumaturge : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "Thaumaturgy/NPCs/Thaumaturge";
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Thaumaturge";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thaumaturge");
			Main.npcFrameCount[npc.type] = 23;
			NPCID.Sets.ExtraFramesCount[npc.type] = 6;
			NPCID.Sets.AttackFrameCount[npc.type] = 2;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 60;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Clothier;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			return (NPC.downedSlimeKing || NPC.downedBoss1) || Main.hardMode || Main.expertMode;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(3))
			{
				case 0:
					return "Checyr";

				case 1:
					return "Vashreen";

				default:
					return "Azanor";
			}
		}

		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();

			if (NPC.CountNPCS(NPCID.MoonLordHead) > 0)
			{
				chat.Add("Don't you have something to worry about right now?");
				return chat;
			}

			int Wizard = NPC.FindFirstNPC(NPCID.Wizard);
			if (Wizard >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add(Main.npc[Wizard].GivenName + " acts aloof, but I see through his masquerade. He's dangerous. You're sheltering a criminal, you know.");
			}

			int Dryad = NPC.FindFirstNPC(NPCID.Dryad);
			if (Dryad >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add("Herbs? Mushrooms? Do you think I drape myself in vines and prance around naked like " + Main.npc[Dryad].GivenName + "? Plants aren't my business. I'm no druid.");
			}

			int Cyborg = NPC.FindFirstNPC(NPCID.Cyborg);
			if (Cyborg >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add("Between you and me, I think " + Main.npc[Cyborg].GivenName + " is an escaped golem.");
			}

			int Angler = NPC.FindFirstNPC(NPCID.Angler);
			if (Angler >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add("Ever since " + Main.npc[Angler].GivenName + " learned that you can transmute fish, he's been pestering me to learn more. He's the most eager student I've ever had, and he can't even read!");
			}

			if (Main.dayTime)
			{
				chat.Add("Something about this place is... special. Different. What did you stumble onto?");
				chat.Add("Is it true that you folks make potions with plants? Isn't it easier to to use aura?");
				chat.Add("Oh, excuse me. Let me just finish this up this pale star, then I can talk.");
				chat.Add("What kind of name is \"thaumatrestle\"? Anyway, what do you need?");
				if (Main.raining)
				{
					chat.Add("Sorry about the rain. I lost track of some bottled lightning and something must've knocked it over.");
				}
				if (!Main.hardMode)
				{
					chat.Add("Even here, synthesizing a fallen star just isn't possible. If you need auromancy supplies, I can sell you pale stars.");
				}
				else
				{
					chat.Add("Looking for pale stars? The guardian's defeat gave me new insight. These ones are much brighter!");
				}
			}
			else
			{
				chat.Add("Fallen stars aren't, you know - actual stars. They're a byproduct of the aura - magical refuse, basically. Each one still has a lot of power.");
				chat.Add("Those specks you see are meteorites in orbit. Imbalance is like a magnet to them; let out enough dark at once, and it will attract them.");
				chat.Add("Thaumatrestles include tools to break down fallen stars into shards without losing their energy. I can make you one, if you want.");
				if (Main.hardMode)
				{
					if (!NPC.downedMoonlord)
					{
						chat.Add("Something's changed since you let loose the spirits. Something's... watching. Be careful, friend.");
					}
					else
					{
						chat.Add("Whatever was lurking behind the moon is gone now. I imagine that was your work?");
						chat.Add("I don't know what you did, but the fabric of reality here is different from anything I've ever seen...");
					}
					chat.Add("The Hallow isn't actually auric in nature, insofar as thaumaturgy goes, at least. Pixies are, though.");
					if (ModLoader.GetMod("CalamityMod") != null)
					{
						chat.Add("Have you visited the crash site of that comet? My instruments say it's a fallen star, but...");
						chat.Add("I keep dreaming about the sun.");
					}
				}
				if (Main.player[Main.myPlayer].statManaMax >= 200)
				{
					chat.Add("Yours is a body more conductive to mana then most. I wonder if that has to do with your ties to this world...");
					chat.Add("Do you feel lightheaded? You're practically glowing with magic.");
				}
				else
				{
					chat.Add("Are you sure you're cut out for this kind of work? You aren't very... in-tune.");
				}
			}
			return chat;
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			if (NPC.CountNPCS(NPCID.MoonLordHead) == 0)
			{
				button = Language.GetTextValue("LegacyInterface.28");
			}
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("Thaumatrestle"));
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1, 0, 0);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SynthesisFocus"));
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50, 0); ;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("ReplicationFocus"));
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50, 0); ;
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("TransmutationFocus"));
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50, 0);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("PaleStar"));
			if (!Main.hardMode)
			{
				shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10, 0);
			}
			else
			{
				shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
			}
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Bottle);
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 0, 75);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BottledWater); // Convenience fee!
			shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1, 0);
			nextSlot++;
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("SpellboundWater"));
				shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5, 0);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("Starbrass"));
				shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10, 0);
				nextSlot++;
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("GogglesofRevealing"));
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 30;
			knockback = 2f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = ProjectileID.LostSoulFriendly;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}