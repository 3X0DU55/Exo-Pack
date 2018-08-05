using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Tiles
{
	public class WebWood : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("WebWood");
			AddMapEntry(new Color(0, 200, 0));
		}
	}
}