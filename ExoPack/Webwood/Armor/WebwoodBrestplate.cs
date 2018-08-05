using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExoPack.Webwood.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class WebWoodBrestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Web Wood Brestplate");
			Tooltip.SetDefault("Spooky Scary"
				+ "\n+ +1 max minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 0;
			item.rare = 2;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions++;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 60);
            recipe.AddTile(mod, "WebWoodWorkbench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}