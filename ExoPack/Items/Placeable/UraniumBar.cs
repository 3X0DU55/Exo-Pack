using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class UraniumBar : ModItem
	{
     				public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Uranium Bar");
			Tooltip.SetDefault("Condensed Radiation");
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
			item.value = 4400;
			item.consumable = true;
			item.createTile = mod.TileType("UraniumBar");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "UraniumOre", 4);
            recipe.AddTile(77);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}