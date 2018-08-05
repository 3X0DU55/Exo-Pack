using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Webwood
{
	public class WebWoodHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Web Wood Hammer");
			Tooltip.SetDefault("Sticky!");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;		//How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 40;		//How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10;
			item.rare = 2;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 8);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}
