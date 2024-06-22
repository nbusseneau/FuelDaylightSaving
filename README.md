# Fuel Daylight Saving

Very simple [Valheim](https://store.steampowered.com/app/892970/Valheim/) mod that disables fuel-based fireplaces in daylight.
Configurable exception list (default: never disable campfires and hearths, for cooking and comfort purposes).
Client-side.

![showcase](https://github.com/nbusseneau/FuelDaylightSaving/assets/4659919/18650599-6092-4a31-8234-d93ec2b7b95d)

## But why?

**Fuel Daylight Saving** helps you ~~reduce your CO₂ emissions~~ save on precious fuel by disabling most fireplaces in daylight, except those specified in a configurable exception list and infinite fuel fireplaces (e.g. Haldor / Hildir fire pits).
By default, the exception list includes only campfires and hearths, as these are necessary either for cooking stations or as comfort providers (usually temporarily for campfires, and permanently for hearths as top of their comfort group).

Incidentally, **Fuel Daylight Saving** also helps you ~~fight against climate change~~ save on FPS, as lit fireplaces are resource hogs in Valheim.

Note that **Fuel Daylight Saving** uses the game's daylight detection mechanism, which means fireplaces may still stay lit during the day if Valheim considers the environment / weather to be dark enough that it's not "daylight" (e.g. during rains or thunderstorms).

## Compatibility with other mods

**Fuel Daylight Saving** hooks onto the `Fireplace` component itself and should work transparently with all mods, including those that add new fireplaces (buildable or not, infinite fuel or not).
However, it cannot automatically detect if any modded fireplace should be added to the exception list: your help is appreciated in editing the default exception list such that **Fuel Daylight Saving** remains pain-free with most modpacks 🙇
Feel free to [report any issue you find](https://github.com/nbusseneau/FuelDaylightSaving/issues/new).

## Install

This is a client-side mod.
It does not need to be installed on the server.

### Thunderstore (recommended)

- **[Prerequisite]** Install [**r2modman**](https://thunderstore.io/c/valheim/p/ebkr/r2modman/).
- Click **Install with Mod Manager** from the [mod page](https://thunderstore.io/c/valheim/p/nbusseneau/Fuel_Daylight_Saving/).

### Manually (not recommended)

- **[Prerequisites]**
  - Install [**BepInExPack Valheim**](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/).
- Download [nbusseneau-Fuel_Daylight_Saving-0.0.1.zip](https://github.com/nbusseneau/FuelDaylightSaving/releases/latest/download/nbusseneau-Fuel_Daylight_Saving-0.0.1.zip).
- Extract the archive and move everything to your `BepInEx/plugins/` directory. It should look like this:
  ```
  BepInEx/
  └── plugins/
      └── nbusseneau-Fuel_Daylight_Saving/
          ├── CHANGELOG.md
          ├── icon.png
          ├── manifest.json
          ├── plugins/
          └── README.md
  ```

### Special thanks

**Fuel Daylight Saving** is a reimplementation of a mod initially created by [warpalicious](https://thunderstore.io/c/valheim/p/warpalicious/).
Check out their POI content mods, you won't regret it 👍
