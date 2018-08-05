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
	public class ChromiumBar : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = false;
			Main.tileMergeDirt[Type] = false;
			drop = mod.ItemType("ChromiumBar");
			AddMapEntry(new Color(200, 200, 200));
		}
	}
}