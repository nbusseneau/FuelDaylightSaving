using HarmonyLib;

namespace FuelDaylightSaving;

public class Patches
{
  [HarmonyPostfix]
  [HarmonyPatch(typeof(Fireplace), nameof(Fireplace.IsBurning))]
  private static void DisableFireplacesInDaylight(Fireplace __instance, ref bool __result)
  {
    if (!__result || __instance.m_infiniteFuel || Plugin.ExceptionList.Contains(__instance.name)) return;
    if (EnvMan.IsDaylight()) __result = false;
  }
}
