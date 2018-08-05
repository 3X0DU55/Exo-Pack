using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class WebWoodPlatform : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Platform");
			Tooltip.SetDefault("Sticky!");
		}

		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 10;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("WebWoodPlatform");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWood");
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}