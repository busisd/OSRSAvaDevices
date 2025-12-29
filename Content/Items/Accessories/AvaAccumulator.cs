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

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AmmoSaveChance * 100);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange;
            Item.DefaultToAccessory(22, 27);
        }
    }
}
