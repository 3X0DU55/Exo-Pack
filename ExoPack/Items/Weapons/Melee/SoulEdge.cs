using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class SoulEdge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul Edge");
			Tooltip.SetDefault("You can hear the whispers of lost souls.");
		}
		public override void SetDefaults()
		{
			item.damage = 167;
			item.melee = true;
			item.width = 64;
			item.height = 68;
			item.shoot= 297;
			item.shootSpeed = 5;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 260000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(757, 1);
			recipe.AddIngredient(1446, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
