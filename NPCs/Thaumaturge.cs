tusing System.Linq;
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
        private bool sellsFallenStars = false;
        private bool sellsSpellboundWater = false;
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
            sellsFallenStars = Main.hardMode;
            sellsSpellboundWater = NPC.downedBoss3;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
            return NPC.downedBoss1 || Main.expertMode;
        }

		public override string TownNPCName()
		{
			switch(WorldGen.genRand.Next(3))
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
                chat.Add("...");
                return chat;
            }

            if (NPC.downedAncientCultist && !NPC.downedMoonlord)
            {
                chat.Add("It's coming closer. Leave me alone. I need to protect my work.");
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
                chat.Add("Between you and me, I think " + Main.npc[Cyborg].GivenName + " was someone's first golem. They escape all the time at the Academy, since people forget to bind them.");
            }

            int Angler = NPC.FindFirstNPC(NPCID.Angler);
            if (Angler >= 0 && Main.rand.Next(4) == 0)
            {
                chat.Add("Ever since " + Main.npc[Angler].GivenName + " learned that you can transmute fish, he's been pestering me to learn more. He's the most eager student I've ever seen outside the Academy, and he can't even read!");
            }

            if (Main.dayTime)
            {
                chat.Add("The aura's veil is very thin here. No wonder half of my instruments overload.");
                chat.Add("Is it true that you folks make potions with plants? Isn't it easier to blend aura with a base liquid?");
                chat.Add("Do you know how auric shards work? They're sort of like magical batteries. Good for a quick jolt of magic.");
                chat.Add("I've been trying to see if I can make mana crystals from auric shards. No luck yet.");
                chat.Add("What kind of name is \"thaumatrestle\" anyways? Who named that thing?");
                if (Main.raining)
                {
                    chat.Add("Sorry about the rain. I lost track of some bottled lightning and something must've knocked it over.");
                }
                if (!Main.hardMode)
                {
                    chat.Add("I'm sorry, but pale stars just aren't as strong as the real thing. We've been trying for years.");
                }
                else
                {
                    chat.Add("Pale stars? No, I don't have those anymore. Just take the normal ones. Please.");
                    chat.Add("I can't stop having nightmares.", 0.1);
                }
            }
            else
            {
                chat.Add("Fallen stars are fundamentally different from the stars in the sky. They're a manifestation of the aura - sort of like magical refuse.");
                chat.Add("Those specks you see are meteorites in orbit. They're attracted to dark; if you let out enough at once, one might come crashing down.");
                chat.Add("Thaumatrestles include tools to break down fallen stars into shards without losing their energy. I can make you one, if you want.");
                if (Main.hardMode)
                {
                    if (!NPC.downedMoonlord)
                    {
                        chat.Add("Something's changed since you let loose the spirits. Something's... watching? Be careful, friend.");
                    }
                    else
                    {
                        chat.Add("Whatever was lurking behind the aura is gone now. I imagine that was your work?");
                        chat.Add("I don't know what you did, but the fabric of reality here is different from anything I've ever seen...");
                    }
                    chat.Add("The Hallow isn't actually magical in nature, insofar as thaumaturgy goes, at least. Pixies are, though.");
                    if (ModLoader.GetLoadedMods().Contains("CalamityMod"))
                    {
                        chat.Add("Do you see the streaks in the sky? Those are the Astrum Deus. They started showing up when that comet landed. I don't like the look of them.");
                        chat.Add("Have you visited the crash site of that comet? My instruments say it's a fallen star, but something about it has twisted the land...");
                        chat.Add("I keep dreaming about the sun.");
                    }
                }
                if (Main.player[Main.myPlayer].statManaMax >= 200)
                {
                    chat.Add("You're very in-tune with the aura. At least you understand half the things I say.");
                }
                else
                {
                    chat.Add("I hope I'm not making you bored with all my academic talk.");
                }
            }
			return chat;
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
            if (!(NPC.downedAncientCultist && !NPC.downedMoonlord) && NPC.CountNPCS(NPCID.MoonLordHead) == 0)
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
            shop.item[nextSlot].shopCustomPrice = 10000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("SynthesisFocus"));
            shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ReplicationFocus"));
            shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("TransmutationFocus"));
            shop.item[nextSlot].shopCustomPrice = 5000;
            nextSlot++;
            if (!Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("PaleStar"));
                shop.item[nextSlot].shopCustomPrice = 1000;
            }
            else
            {
                shop.item[nextSlot].SetDefaults(ItemID.FallenStar);
                shop.item[nextSlot].shopCustomPrice = 2500;
            }
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.Bottle);
            shop.item[nextSlot].shopCustomPrice = 75;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.BottledWater);
            shop.item[nextSlot].shopCustomPrice = 100;
            nextSlot++;
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("SpellboundWater"));
                shop.item[nextSlot].shopCustomPrice = 500;
                nextSlot++;
            }
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("GogglesofRevealing"));
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