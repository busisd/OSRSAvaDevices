using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    internal class AvaAttractor : AvaDevice
    {
        public override double AmmoSaveChance => .6;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AmmoSaveChance * 100);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Green;
            Item.value = Item.sellPrice(0, 0, 50, 0);
            Item.DefaultToAccessory(22, 27);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ZombieArm)
                .AddRecipeGroup(OSRSAvaDevicesModSystem.RECIPE_GROUP_EVIL_WOOD, 12)
                .AddRecipeGroup(RecipeGroupID.IronBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
