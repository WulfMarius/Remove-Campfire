using Harmony;
using UnityEngine;

namespace RemoveCampfire
{
    [HarmonyPatch(typeof(Panel_FireStart), "OnCharcoalHarvest")]
    internal class Panel_FireStart_OnCharcoalHarvest
    {
        private static void Postfix(Panel_FireStart __instance)
        {
            Campfire m_CampFireInstance = AccessTools.Field(typeof(Panel_FireStart), "m_CampFireInstance").GetValue(__instance) as Campfire;

            if (m_CampFireInstance == null)
            {
                return;
            }

            Fire fire = m_CampFireInstance.GetComponent<Fire>();
            if (fire == null)
            {
                return;
            }

            FireManager.DestroyFireObject(fire);
        }
    }
}