using HarmonyLib;

namespace FuelDaylightSaving;

public class Patches
{
  [HarmonyPostfix]
  [HarmonyPatch(typeof(Fireplace), nameof(Fireplace.IsBurning))]
  private static void DisableFireplacesInDaylight(Fireplace __instance, ref bool __result)
  {
    // ignore infinite fuel fireplaces and exceptions
    if (!__result || __instance.m_infiniteFuel || Plugin.ExceptionList.Contains(__instance.name)) return;

    // imitate EnvMan.CalculateDaylight() behaviour (i.e. when environment is considered dark, e.g. thunderstorms), but
    // with an additional small margin w.r.t. to day time to account for low light during sunrise and sunset
    if (EnvMan.instance.GetCurrentEnvironment() is { } currentEnvironment && currentEnvironment.m_alwaysDark) return;
    var dayFraction = EnvMan.instance.GetDayFraction();
    if (dayFraction >= 0.28f && dayFraction <= 0.72f) __result = false;
  }
}
