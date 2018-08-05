using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Projectiles
{
    class VampireScourgeProjectileB : ModProjectile
    {
	public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("VampireScourgeProjectileB");
		}
        public override void SetDefaults()
        {
            //     projectile.name = "Tiny Eater";
            projectile.width = 16;
            projectile.height = 16;
          //  projectile.aiStyle = 36;
            projectile.penetrate = 1;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.melee = true;
            projectile.extraUpdates = 3;
            Main.projFrames[projectile.type] = 2;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (/*projectile.type == 307 && */projectile.ai[1] < 5f)
            {
                projectile.ai[1] += 1f;
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y;
                }
                return false;
            }

            return true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.vampireHeal(damage, target.Center);
        }

        public override bool PreAI()
        {
        //    return base.PreAI();
        //}

        //public override void AI()
        //{
            if (projectile.alpha > 0)
            {
                projectile.alpha -= 50;
            }
            else
            {
                projectile.extraUpdates = 0;
            }
            if (projectile.alpha < 0)
            {
                projectile.alpha = 0;
            }
            projectile.rotation = (float)System.Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) - 1.57f;
            projectile.frameCounter++;
            if (projectile.frameCounter >= 6)
            {
                projectile.frame++;
                projectile.frameCounter = 0;
            }
            if (projectile.frame >= 2)
            {
                projectile.frame = 0;
            }
            for (int num363 = 0; num363 < 3; num363++)
            {
                float num364 = projectile.velocity.X / 3f * (float)num363;
                float num365 = projectile.velocity.Y / 3f * (float)num363;
                int num366 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 184, 0f, 0f, 0, default(Color), 1f);
                Main.dust[num366].position.X = projectile.Center.X - num364;
                Main.dust[num366].position.Y = projectile.Center.Y - num365;
                Main.dust[num366].velocity *= 0f;
                Main.dust[num366].scale = 0.5f;
            }

            float num367 = projectile.position.X;
            float num368 = projectile.position.Y;
            float num369 = 100000f;
            bool flag10 = false;
            projectile.ai[0] += 1f;
            if (projectile.ai[0] > 30f)
            {
                projectile.ai[0] = 30f;
                for (int num370 = 0; num370 < 200; num370++)
                {
                    if (Main.npc[num370].CanBeChasedBy(projectile, false) && (!Main.npc[num370].wet /*|| projectile.type == 307*/))
                    {
                        float num371 = Main.npc[num370].position.X + (float)(Main.npc[num370].width / 2);
                        float num372 = Main.npc[num370].position.Y + (float)(Main.npc[num370].height / 2);
                        float num373 = System.Math.Abs(projectile.position.X + (float)(projectile.width / 2) - num371) + System.Math.Abs(projectile.position.Y + (float)(projectile.height / 2) - num372);
                        if (num373 < 800f && num373 < num369 && Collision.CanHit(projectile.position, projectile.width, projectile.height, Main.npc[num370].position, Main.npc[num370].width, Main.npc[num370].height))
                        {
                            num369 = num373;
                            num367 = num371;
                            num368 = num372;
                            flag10 = true;
                        }
                    }
                }
            }
            if (!flag10)
            {
                num367 = projectile.position.X + (float)(projectile.width / 2) + projectile.velocity.X * 100f;
                num368 = projectile.position.Y + (float)(projectile.height / 2) + projectile.velocity.Y * 100f;
            }
            else /*if (projectile.type == 307)*/
            {
                projectile.friendly = true;
            }
            float num374 = 6f;
            float num375 = 0.1f;

            num374 = 9f;
            num375 = 0.2f;

            Vector2 vector27 = new Vector2(projectile.position.X + (float)projectile.width * 0.5f, projectile.position.Y + (float)projectile.height * 0.5f);
            float num376 = num367 - vector27.X;
            float num377 = num368 - vector27.Y;
            float num378 = (float)System.Math.Sqrt((double)(num376 * num376 + num377 * num377));
            num378 = num374 / num378;
            num376 *= num378;
            num377 *= num378;
            if (projectile.velocity.X < num376)
            {
                projectile.velocity.X = projectile.velocity.X + num375;
                if (projectile.velocity.X < 0f && num376 > 0f)
                {
                    projectile.velocity.X = projectile.velocity.X + num375 * 2f;
                }
            }
            else if (projectile.velocity.X > num376)
            {
                projectile.velocity.X = projectile.velocity.X - num375;
                if (projectile.velocity.X > 0f && num376 < 0f)
                {
                    projectile.velocity.X = projectile.velocity.X - num375 * 2f;
                }
            }
            if (projectile.velocity.Y < num377)
            {
                projectile.velocity.Y = projectile.velocity.Y + num375;
                if (projectile.velocity.Y < 0f && num377 > 0f)
                {
                    projectile.velocity.Y = projectile.velocity.Y + num375 * 2f;
                    return false;
                }
            }
            else if (projectile.velocity.Y > num377)
            {
                projectile.velocity.Y = projectile.velocity.Y - num375;
                if (projectile.velocity.Y > 0f && num377 < 0f)
                {
                    projectile.velocity.Y = projectile.velocity.Y - num375 * 2f;
                    return false;
                }
            }

            return false;
        }
    }
}
