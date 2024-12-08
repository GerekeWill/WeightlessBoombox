using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedicatedBoomboxSlot.Patches
{
    [HarmonyPatch(typeof(GrabbableObject))]
    public class BoomboxWeightPatch
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        public static void ChangeItemWeight(GrabbableObject __instance)
        {
            Plugin.Log("Attempting to edit item...");
            if (__instance == null)
            {
                return;
            }
            if (__instance.itemProperties.itemName == "Boombox")
            {
                __instance.itemProperties.weight = 0f;
                Plugin.Log("Weight Updated Successfully");
            }
            else
            {
                Plugin.Log("Item was not Boombox. Continuing. . .");
            }
        }
    }
}
