using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    internal class AvaAccumulator : AvaDevice
    {
        public override double AmmoSaveChance => .72;
        private readonly int DamageBonus = 5;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AmmoSaveChance * 100, DamageBonus);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(0, 1, 50, 0);
            Item.DefaultToAccessory(22, 27);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.GetDamage(DamageClass.Ranged) += DamageBonus / 100f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<AvaAttractor>()
                .AddRecipeGroup(OSRSAvaDevicesModSystem.RECIPE_GROUP_EVIL_BAR, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
