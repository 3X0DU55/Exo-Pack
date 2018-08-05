using Terraria.ModLoader;

namespace ExoPack.Items.Placeable
{
	public class WebWoodWalls : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Wall");
			Tooltip.SetDefault("Sticky~");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("WebWoodWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWood");
			recipe.AddTile(18);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}