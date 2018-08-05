using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class ChromiumBar : ModItem
	{
     				public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chromium Bar");
			Tooltip.SetDefault("FUUUUUUUTUURRE");
		}
		
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.value = 7500;
			item.consumable = true;
			item.createTile = mod.TileType("ChromiumBar");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ChromiumOre", 5);
            recipe.AddTile(133);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}