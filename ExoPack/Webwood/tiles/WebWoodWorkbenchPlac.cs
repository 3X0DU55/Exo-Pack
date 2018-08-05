using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.WebWood.tiles
{
	public class WebWoodWorkbenchPlac : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Workbench");
			Tooltip.SetDefault("Sticky!");
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
			item.value = 150;
			item.createTile = mod.TileType("WebWoodWorkbench");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWood", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}