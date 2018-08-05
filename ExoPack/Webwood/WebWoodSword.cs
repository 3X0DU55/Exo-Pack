using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Webwood
{
	public class WebWoodSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Sword");
			Tooltip.SetDefault("Sticky!");
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 12;
			item.rare = 1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 7);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}