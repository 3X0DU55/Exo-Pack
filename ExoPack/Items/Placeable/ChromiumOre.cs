using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class ChromiumOre : ModItem
	{
				public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chromium Ore");
			Tooltip.SetDefault("Fuuuuture");
		}
		
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.value = 1500;
			item.consumable = true;
			item.createTile = mod.TileType("ChromiumOre");
		}
	}
}