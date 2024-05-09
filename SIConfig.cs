using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCEOStaffImprovements;

internal class SIConfig
{
    internal static ConfigEntry<bool> UseTrainAllButton { get; private set; }

    internal static void SetUpConfig()
    {
        UseTrainAllButton = AirportCEOStaffImprovements.ConfigReference.Bind("General", "Create Train All Button", true, "Create a button to train all staff with.");
    }
}
