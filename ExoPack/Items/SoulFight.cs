using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items
{
	public class SoulFight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of Fight");
			Tooltip.SetDefault("'The urge of the jungle's power condensed'");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		// TODO -- Velocity Y smaller, post NewItem?
		public override void SetDefaults()
		{
			Item refItem = new Item();
			refItem.SetDefaults(ItemID.SoulofLight);
			item.width = refItem.width;
			item.height = refItem.height;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 3;
		}
			}
		}