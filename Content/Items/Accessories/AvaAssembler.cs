using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Back)]
    internal class AvaAssembler : AvaDevice
    {
        public override double AmmoSaveChance => .8;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AmmoSaveChance * 100);

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange;
            Item.DefaultToAccessory(24, 28);
        }

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            return incomingItem.ModItem is not AvaAttractor && incomingItem.ModItem is not AvaAccumulator;
        }

    }
}
