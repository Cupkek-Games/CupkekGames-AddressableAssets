# CupkekGames Addressables

Addressables integration: asset loading, prefab loader, Luna UI bindings (UIPrefabLoader, NotificationView).

## What's inside

- **`Addressable/`** (CupkekGames.Systems.Addressables.asmdef) — Addressables wrapper utilities + asset reference helpers.
- **`PrefabLoader/`** (CupkekGames.Systems.PrefabLoader.asmdef) — load/instantiate prefabs by Addressables key with caching.
- **`UI.PrefabLoader/`** (CupkekGames.Systems.UI.PrefabLoader.asmdef + Editor) — Luna UI binding: instantiates prefabs from Addressables keys for UI use.

`UI.Generic` (NotificationView and other generic UI helpers) lives in Luna's `Samples~/GameFull/Scripts/UI.Generic/` rather than here — it's sample-quality scaffolding, not core asset-loading code.

## Dependencies

- `com.cupkekgames.pool` (`AddressableGameObjectPool` extends `GameObjectPoolBase`)
- `com.cupkekgames.keyvaluedatabase` (PrefabLoader chain)
- `com.cupkekgames.prefabloader` (`PrefabLoaderAddressable` extends `PrefabLoader`)
- `com.cupkekgames.luna` (UI bindings)
- `com.unity.addressables`

## Installation

Embedded package. Install dependencies first.
