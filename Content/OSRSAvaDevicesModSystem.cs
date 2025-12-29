using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace OSRSAvaDevices.Content
{
    internal class OSRSAvaDevicesModSystem : ModSystem
    {
        private static readonly string ANY = "LegacyMisc.37";

        public static readonly string RECIPE_GROUP_EVIL_WOOD = nameof(ItemID.Ebonwood);
        public static readonly string RECIPE_GROUP_EVIL_BAR = nameof(ItemID.DemoniteBar);
        public static readonly string RECIPE_GROUP_COBALT_BAR = nameof(ItemID.CobaltBar);

        public override void AddRecipeGroups()
        {
            RecipeGroup evilWoodGroup = new RecipeGroup(
                    () => $"{Language.GetTextValue(ANY)} {Lang.GetItemNameValue(ItemID.Ebonwood)}",
                    ItemID.Ebonwood,
                    ItemID.Shadewood);
            RecipeGroup.RegisterGroup(RECIPE_GROUP_EVIL_WOOD, evilWoodGroup);

            RecipeGroup evilBarGroup = new RecipeGroup(
                    () => $"{Language.GetTextValue(ANY)} {Lang.GetItemNameValue(ItemID.DemoniteBar)}",
                    ItemID.DemoniteBar,
                    ItemID.CrimtaneBar);
            RecipeGroup.RegisterGroup(RECIPE_GROUP_EVIL_BAR, evilBarGroup);

            RecipeGroup cobaltBarGroup = new RecipeGroup(
                    () => $"{Language.GetTextValue(ANY)} {Lang.GetItemNameValue(ItemID.CobaltBar)}",
                    ItemID.CobaltBar,
                    ItemID.PalladiumBar);
            RecipeGroup.RegisterGroup(RECIPE_GROUP_COBALT_BAR, cobaltBarGroup);
        }
    }
}
