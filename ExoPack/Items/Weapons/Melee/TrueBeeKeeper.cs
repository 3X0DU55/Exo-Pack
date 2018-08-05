using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class TrueBeeKeeper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Bee Keeper");
			Tooltip.SetDefault("BUZZ");
		}
		public override void SetDefaults()
		{
			item.damage = 75;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.shoot = 566;
			item.shootSpeed = 15;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 25400;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1123, 1);
            recipe.AddIngredient(1570, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
