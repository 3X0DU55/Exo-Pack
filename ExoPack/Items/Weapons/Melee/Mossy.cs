using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class Mossy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mossy Cleaver");
			Tooltip.SetDefault("It's really sticky. You should clean it.");
		}
		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 40000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1570, 2);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}