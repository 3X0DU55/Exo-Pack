using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Tiles
{
	public class InfestationGrass : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = (2);
			AddMapEntry(new Color(200, 200, 200));
			SetModTree(new InfestationTree());
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override int SaplingGrowthType(ref int style)
		{
			style = 0;
			return mod.TileType("InfestationSapling");
		}
	}
}