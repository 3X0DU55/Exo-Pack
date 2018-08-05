using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ExoPack.Items.Weapons.Melee
{
    class ScourgeOfTheVampires : ModItem
    {
	public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scourge Of The Vampires");
			Tooltip.SetDefault("Little overkill don't you think?");
		}
        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("VampireScourgeProjectileA");//305;

            item.autoReuse = true;
            item.useStyle = 1;
            // this.name = "Eater's Bite";
            item.shootSpeed = 14f;
          //  this.shoot = 306;
            item.damage = 64;
            item.width = 18;
            item.height = 20;
            item.useAnimation = 20;
            item.useTime = 20;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = 400000;
            item.knockBack = 5f;
            item.melee = true;
            item.rare = 8;
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float spread = 58f * 0.0174f;
            float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
            double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
            double deltaAngle = spread / 5f;
            double offsetAngle;
            int i;
            for (i = 0; i < 5; i++)
            {
                offsetAngle = startAngle + deltaAngle * i;
                Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), mod.ProjectileType("VampireScourgeProjectileA"), damage, knockBack, item.owner);
            }
            return false;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1569, 1);
                        recipe.AddIngredient(1571, 1);
                        recipe.AddTile(134);
                        recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
