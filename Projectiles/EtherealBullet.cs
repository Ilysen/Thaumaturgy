using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Thaumaturgy.Projectiles
{
	public class EtherealBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ethereal Bullet");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Bullet);
			projectile.penetrate = 5;
			projectile.alpha = 255;
			projectile.ignoreWater = true;
			aiType = ProjectileID.Bullet;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Main.PlaySound(SoundID.Item10, projectile.position);
            for (var i = 0; i < 3; i++)
            {
                Dust.NewDust(projectile.Center, 30, 30, 15, 0, 0, 0, default(Color), 1.5f);
            }
            return true;
        }

        public override void AI()
        {
            Dust.NewDust(projectile.Center, 5, 5, 15, 0, 0, 0, default(Color), 0.5f);
            Lighting.AddLight(projectile.Center, 1f, 0.75f, 1f);
            base.AI();
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}
