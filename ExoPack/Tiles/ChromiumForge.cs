using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ExoPack.Tiles
{
	public class ChromiumForge : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.CoordinateHeights = new int[]{ 18 , 18 , 18 };
			TileObjectData.addTile(Type);
			adjTiles = new int[]{ TileID.AdamantiteForge, TileID.Furnaces, TileID.Hellforge };
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			disableSmartCursor = true;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("ChromiumForge"));
		}
	}
}