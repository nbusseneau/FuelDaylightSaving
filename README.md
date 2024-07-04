# Fuel Daylight Saving™

Very simple [Valheim](https://store.steampowered.com/app/892970/Valheim/) mod that disables fuel-based **fireplaces** in daylight.
Configurable **exception list** (default: never disable campfires and hearths, for cooking and comfort purposes), enforceable server-side.

![showcase](https://github.com/nbusseneau/FuelDaylightSaving/assets/4659919/18650599-6092-4a31-8234-d93ec2b7b95d)

## Video showcase

https://github.com/nbusseneau/FuelDaylightSaving/assets/4659919/9d8dd94b-0af3-4770-9ce5-ebd5b0f6bd50

## Features

- Fuel-based **fireplaces** are disabled in daylight, except those specified in a configurable **exception list**.
- By default, the **exception list** includes campfires and hearths, as these are necessary either for cooking stations or as comfort providers (usually temporarily for campfires, and permanently for hearths as top of their comfort group).
- Uses Valheim's daylight detection mechanism, which means **fireplaces** may still stay lit during the day if the environment / weather is dark enough that it's not "daylight" (e.g. during rains or thunderstorms).
- Infinite (no fuel) **fireplaces** are ignored and stay enabled at all times (e.g. Haldor / Hildir fire pits).

## But why?

**Fuel Daylight Saving™** helps you ~~reduce your CO₂ emissions~~ save on precious fuel and reduce the frequency of annoying refueling rounds.
Incidentally, it also helps you ~~fight against climate change~~ save on FPS when in daylight, as lit **fireplaces** are resource hogs in Valheim.

## Compatibility

### With vanilla clients / clients not using the mod

**Fireplaces** are managed by the current zone owner (usually the first person to enter a zone).
In other words, if multiple players are in the same zone:

- **Fireplaces** will be disabled in daylight if the zone owner uses the mod, regardless of if anyone else uses the mod.
- **Fireplaces** will not be disabled in daylight if the zone owner does not use the mod, even if absolutely everyone else uses the mod.

### With other mods

**Fuel Daylight Saving™** hooks onto the `Fireplace` component itself and should work transparently with all mods, including those that add new **fireplaces**.
However, it cannot automatically detect if any modded **fireplace** should be added to the **exception list**.
While you can always configure it yourself, if you are a mod author or user and think a modded **fireplace** should be added to the default **exception list**, please do contact me: I'm more than happy to extend it.
Feel free to [report any issue you find](https://github.com/nbusseneau/FuelDaylightSaving/issues/new).

## Install

- This is a client-side mod, which can also be installed server-side.
  - While possible, mixing clients using the mod and clients not using the mod on the same server is not recommended, as it will result in an inconsistent experience ([see above for details](#with-vanilla-clients--clients-not-using-the-mod)).
- If installed on the server, server configuration will be enforced to all clients, however clients will not be forced to have the mod installed.

In other words:

- This mod can be installed on servers intended for Xbox crossplay, and all clients will still be able to join.
- This mod can be installed on your side as a client, and you will still be able to join any server (even vanilla ones).
  However, since this mod is not only cosmetic but impacts gameplay, you should probably ask the admin and other players first out of courtesy.

### Thunderstore (recommended)

- **[Prerequisite]** Install [**r2modman**](https://thunderstore.io/c/valheim/p/ebkr/r2modman/).
- Click **Install with Mod Manager** from the [mod page](https://thunderstore.io/c/valheim/p/nbusseneau/Fuel_Daylight_Saving/).

### Manually (not recommended)

- **[Prerequisites]**
  - Install [**BepInExPack Valheim**](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/).
- Download [nbusseneau-Fuel_Daylight_Saving-0.2.0.zip](https://github.com/nbusseneau/FuelDaylightSaving/releases/latest/download/nbusseneau-Fuel_Daylight_Saving-0.2.0.zip).
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

## Special thanks

**Fuel Daylight Saving™** is a reimplementation of a mod initially created by [warpalicious](https://thunderstore.io/c/valheim/p/warpalicious/).
Check out their POI content mods, you won't regret it 👍
