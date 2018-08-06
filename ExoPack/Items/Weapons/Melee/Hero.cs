using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class Hero : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hero Sword");
			Tooltip.SetDefault("It is said to have been wielded by gods.");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 60000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Mossy");
			recipe.AddIngredient(886, 1);
			recipe.needWater = true;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
