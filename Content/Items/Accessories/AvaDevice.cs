using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
