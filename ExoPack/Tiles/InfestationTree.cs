using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace ExoPack.Tiles
{
	public class InfestationTree : ModTree
	{
		private Mod mod
		{
			get
			{
				return ModLoader.GetMod("ExoPack");
			}
		}

		public override int DropWood()
		{
			return mod.ItemType("WebWood");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/InfestationTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/InfestationTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/InfestationTree_Branches");
		}
	}
}