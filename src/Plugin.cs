using System.Collections.Generic;
using System.IO;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace FuelDaylightSaving;

[BepInPlugin(ModGUID, ModName, ModVersion)]
public class Plugin : BaseUnityPlugin
{
  private const string ModGUID = "nbusseneau.FuelDaylightSaving";
  private const string ModName = "FuelDaylightSaving";
  private const string ModVersion = "0.0.1";

  private static readonly List<string> s_defaultExceptionList = [
    "fire_pit",
    "hearth",
    "BRP_RefinedStone_Hearth", // blacks7ar-RefinedStonePieces
  ];
  private static ConfigEntry<string> s_exceptionList;
  public static HashSet<string> ExceptionList => s_exceptionList.Value.Split(',').Select(prefabName => $"{prefabName.Trim()}(Clone)").ToHashSet();

  public void Awake()
  {
    s_exceptionList = Config.Bind("Behaviour", "Exception list", s_defaultExceptionList.Join(), "List of piece names whose fireplace should be kept lit at all times (e.g. because you want to use them for cooking stations or as comfort providers).");
    SetUpConfigWatcher();

    Harmony harmony = new(ModGUID);
    harmony.PatchAll(typeof(Patches));
  }

  public void OnDestroy() => Config.Save();

  private void SetUpConfigWatcher()
  {
    FileSystemWatcher watcher = new(Paths.ConfigPath, Path.GetFileName(Config.ConfigFilePath));
    watcher.Changed += ReadConfigValues;
    watcher.Created += ReadConfigValues;
    watcher.Renamed += ReadConfigValues;
    watcher.IncludeSubdirectories = true;
    watcher.SynchronizingObject = ThreadingHelper.SynchronizingObject;
    watcher.EnableRaisingEvents = true;
  }

  private void ReadConfigValues(object sender, FileSystemEventArgs e)
  {
    if (!File.Exists(Config.ConfigFilePath)) return;
    try
    {
      Logger.LogDebug("Attempting to reload configuration...");
      Config.Reload();
    }
    catch
    {
      Logger.LogError($"There was an issue loading {Config.ConfigFilePath}");
    }
  }
}
