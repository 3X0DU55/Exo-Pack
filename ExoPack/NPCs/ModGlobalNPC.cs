using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace ExoPack.NPCs
{
	public class ModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			
			if (Main.hardMode && !npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.position.Y > Main.rockLayer * 16.0 && npc.value > 0f && Main.rand.NextBool(Main.expertMode ? 2 : 1, 5))
			{
				if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("SoulFight"));
			    }
			}
		}
	}
}