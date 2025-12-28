using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    internal class AvaAttractor : ModItem
    {
        private static readonly double AMMO_SAVE_CHANCE = .6;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AMMO_SAVE_CHANCE * 100);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange;
            Item.DefaultToAccessory(22, 27);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<OSRSAvaDevicesPlayer>().avaDeviceAmmoSaveChance = AMMO_SAVE_CHANCE;
        }
    }
}
