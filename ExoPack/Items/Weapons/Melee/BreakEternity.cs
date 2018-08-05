using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace ExoPack.Items.Weapons.Melee
{
	public class BreakEternity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Break Eternal");
			Tooltip.SetDefault("Chi flows through the blade");
		}
		public override void SetDefaults()
		{
			item.damage = 175;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.shootSpeed = 7;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 201800;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(528, 1);
            recipe.AddIngredient(527, 1);
            recipe.AddIngredient(757, 1);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

	}
}
