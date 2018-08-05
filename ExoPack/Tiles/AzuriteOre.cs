using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Tiles
{
	public class AzuriteOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("AzuriteOre");
			AddMapEntry(new Color(0, 0, 200));
            minPick = 100;
		}
	}
}