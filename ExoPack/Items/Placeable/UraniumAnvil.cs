using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class UraniumAnvil : ModItem
	{
		     			public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Uranium Anvil");
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
			item.value = 5000;
			item.createTile = mod.TileType("UraniumAnvil");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "UraniumBar", 10);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}