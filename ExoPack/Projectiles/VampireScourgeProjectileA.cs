using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Projectiles
{
    class VampireScourgeProjectileA : ModProjectile
    {
	public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("VampireScourgeProjectileA");
		}
        public override void SetDefaults()
        {
         //   projectile.name = "Eater's Bite";
            projectile.alpha = 255;
            projectile.width = 14;
            projectile.height = 14;
         //   projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.melee = true;
            projectile.ignoreWater = true;
            projectile.extraUpdates = 1;

        }

        public override bool PreAI()
        {
            if (projectile.alpha <= 200)
            {
                for (int num19 = 0; num19 < 4; num19++)
                {
                    float num20 = projectile.velocity.X / 4f * (float)num19;
                    float num21 = projectile.velocity.Y / 4f * (float)num19;
                    int num22 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 184, 0f, 0f, 0, default(Color), 1f);
                    Main.dust[num22].position.X = projectile.Center.X - num20;
                    Main.dust[num22].position.Y = projectile.Center.Y - num21;
                    Main.dust[num22].velocity *= 0f;
                    Main.dust[num22].scale = 0.7f;
                }
            }
            projectile.alpha -= 50;
            if (projectile.alpha < 0)
            {
                projectile.alpha = 0;
            }
            projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.785f;

            return false;
        }

        public override void AI()
        {
            //if (projectile.alpha <= 200)
            //{
            //    for (int num19 = 0; num19 < 4; num19++)
            //    {
            //        float num20 = projectile.velocity.X / 4f * (float)num19;
            //        float num21 = projectile.velocity.Y / 4f * (float)num19;
            //        int num22 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 184, 0f, 0f, 0, default(Color), 1f);
            //        Main.dust[num22].position.X = projectile.Center.X - num20;
            //        Main.dust[num22].position.Y = projectile.Center.Y - num21;
            //        Main.dust[num22].velocity *= 0f;
            //        Main.dust[num22].scale = 0.7f;
            //    }
            //}
            //projectile.alpha -= 50;
            //if (projectile.alpha < 0)
            //{
            //    projectile.alpha = 0;
            //}
            //projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 0.785f;
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(3, (int)projectile.position.X, (int)projectile.position.Y, 1);
            for (int num508 = 0; num508 < 20; num508++)
            {
                int num509 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 184, 0f, 0f, 0, default(Color), 1f);
                Main.dust[num509].scale *= 1.1f;
                Main.dust[num509].noGravity = true;
            }
            for (int num510 = 0; num510 < 30; num510++)
            {
                int num511 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 184, 0f, 0f, 0, default(Color), 1f);
                Main.dust[num511].velocity *= 2.5f;
                Main.dust[num511].scale *= 0.8f;
                Main.dust[num511].noGravity = true;
            }
            if (projectile.owner == Main.myPlayer)
            {
                int num512 = 2;
                if (Main.rand.Next(10) == 0)
                {
                    num512++;
                }
                if (Main.rand.Next(10) == 0)
                {
                    num512++;
                }
                if (Main.rand.Next(10) == 0)
                {
                    num512++;
                }
                for (int num513 = 0; num513 < num512; num513++)
                {
                    float num514 = (float)Main.rand.Next(-35, 36) * 0.02f;
                    float num515 = (float)Main.rand.Next(-35, 36) * 0.02f;
                    num514 *= 10f;
                    num515 *= 10f;
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, num514, num515, mod.ProjectileType("VampireScourgeProjectileB")/*307*/, (int)((double)projectile.damage * 0.7), (float)((int)((double)projectile.knockBack * 0.35)), Main.myPlayer, 0f, 0f);
                }
            }
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            SpriteEffects spriteEffects = SpriteEffects.None;
            if (projectile.spriteDirection == -1)
            {
                spriteEffects = SpriteEffects.FlipHorizontally;
            }

            Main.spriteBatch.Draw(Main.projectileTexture[projectile.type], 
                new Vector2(projectile.position.X - Main.screenPosition.X + (float)(projectile.width / 2), 
                projectile.position.Y - Main.screenPosition.Y + (float)(projectile.height / 2)), 
                new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, Main.projectileTexture[projectile.type].Width, Main.projectileTexture[projectile.type].Height)), 
                projectile.GetAlpha(lightColor), 
                projectile.rotation, 
                new Vector2((float)(Main.projectileTexture[projectile.type].Width / 2), (float)(Main.projectileTexture[projectile.type].Height / 2)), 
                projectile.scale, 
                spriteEffects, 
                0f);

            return false;
        }



        //public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        //{
        //    projectile.vampireHeal(damage, target.Center);
        //}
    }
}
