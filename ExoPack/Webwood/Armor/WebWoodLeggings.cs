using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Webwood.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class WebWoodLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Strangely Comfortable.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 0;
			item.rare = 2;
			item.defense = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 45);
            recipe.AddTile(mod, "WebWoodWorkbench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}