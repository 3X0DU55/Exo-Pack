using Terraria;
using Terraria.ModLoader;

namespace ExoPack.Webwood.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class WebWoodHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("Is it full of spiders?");
               
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 0;
			item.rare = 2;
			item.defense = 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("WebWoodBreastplate") && legs.type == mod.ItemType("WebWoodLeggings");
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WebWoodPlac", 30);
            recipe.AddTile(mod, "WebWoodWorkbench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}