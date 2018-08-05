using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace ExoPack.Tiles
{
	public class UraniumBar : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileMergeDirt[Type] = false;
			drop = mod.ItemType("UraniumBar");
			AddMapEntry(new Color(1, 200, 1));
		}
	}
}