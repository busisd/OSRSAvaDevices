using System;
using Terraria;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content.Items.Accessories
{
    internal abstract class AvaDevice : ModItem
    {
        public virtual double AmmoSaveChance => 0;

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<OSRSAvaDevicesPlayer>().avaDeviceAmmoSaveChance = AmmoSaveChance;
        }

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            if (equippedItem.ModItem != null && incomingItem.ModItem != null)
            {
                Type incomingType = incomingItem.ModItem.GetType();
                Type equippedType = equippedItem.ModItem.GetType();

                if (incomingType.IsSubclassOf(typeof(AvaDevice)) && equippedType.IsSubclassOf(typeof(AvaDevice)))
                {
                    return false;
                }
            }

            return base.CanAccessoryBeEquippedWith(equippedItem, incomingItem, player);
        }
    }
}
