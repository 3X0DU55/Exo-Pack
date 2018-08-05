using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Webwood.tiles
{
	public class WebWood : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("WebWood");
			AddMapEntry(new Color(85, 68, 57));
		}
	}
}