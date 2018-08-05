using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Webwood.tiles
{
	public class WebDoorPlac : ModItem
	{
		public override void SetStaticDefaults()
		{
		    DisplayName.SetDefault("Web Wood Door");
			Tooltip.SetDefault("Sticky!");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("WebDoorClosed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "WebWoodPlac", 6);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}