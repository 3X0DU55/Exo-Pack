using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Tiles
{
	public class ChromiumOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("ChromiumOre");
			AddMapEntry(new Color(200, 200, 200));
            minPick = 150;
		}
	}
}