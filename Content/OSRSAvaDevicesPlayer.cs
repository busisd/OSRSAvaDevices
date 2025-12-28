using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content
{
    internal class OSRSAvaDevicesPlayer : ModPlayer
    {
        public double avaDeviceAmmoSaveChance = 0;
        private static readonly Random random = new();

        public override void ResetEffects()
        {
            this.avaDeviceAmmoSaveChance = 0;
        }

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            if (random.NextDouble() < avaDeviceAmmoSaveChance)
            {
                return false;
            }
            return base.CanConsumeAmmo(weapon, ammo);
        }
    }
}
