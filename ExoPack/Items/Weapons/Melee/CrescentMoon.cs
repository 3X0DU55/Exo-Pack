using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class CrescentMoon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crescent Moon");
			Tooltip.SetDefault("Eternal darkness comes from this blade");
		}
		public override void SetDefaults()
		{
			item.damage = 125;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.shoot = 45;
			item.shootSpeed = 5;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 80000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1327, 1);
			recipe.AddIngredient(485, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
