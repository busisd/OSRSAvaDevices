using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    internal class DizanaQuiver : AvaDevice
    {
        public override double AmmoSaveChance => .8;
        private readonly int DamageCritBonus = 12;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AmmoSaveChance * 100, DamageCritBonus);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(0, 7, 50, 0);
            Item.DefaultToAccessory(29, 28);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.magicQuiver = true;
            player.GetDamage(DamageClass.Ranged) += DamageCritBonus / 100f;
            player.GetCritChance(DamageClass.Ranged) += DamageCritBonus;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<AvaAssembler>()
                .AddIngredient(ItemID.MagicQuiver)
                .AddIngredient(ItemID.LunarTabletFragment, 5)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}
