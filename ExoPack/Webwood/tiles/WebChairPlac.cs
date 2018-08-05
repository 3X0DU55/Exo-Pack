using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Webwood.tiles
{
	public class WebChairPlac : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Chair");
			Tooltip.SetDefault("This is a modded chair.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("WebChair");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 4);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}