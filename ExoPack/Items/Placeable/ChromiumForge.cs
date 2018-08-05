using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ExoPack.Items.Placeable
{
	public class ChromiumForge : ModItem
	{
		     			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chromium Forge");
		}
		
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 10000;
			item.createTile = mod.TileType("ChromiumForge");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChromiumOre", 30);
			recipe.AddIngredient(221);
			recipe.AddTile(null, "UraniumAnvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}