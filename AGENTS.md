# CupkekGames Addressables — AI Agent Instructions

## Package Overview

**CupkekGames Addressables** (`com.cupkekgames.addressableassets`) wraps Unity's Addressables system with a prefab loader and Luna UI bindings.

## Critical: Do not hand-edit Unity serialized assets or `.meta` files

Apply scene/SO/Addressables-catalog changes in Unity Editor; preserve `.meta` GUIDs.

## Package Structure

```
com.cupkekgames.addressableassets/
  package.json
  README.md
  AGENTS.md
  Addressable/                    ← CupkekGames.AddressableAssets.asmdef
    Runtime/                        (asset reference helpers)
    Test/                           (+ Test/Editor)
  PrefabLoader/                   ← CupkekGames.AddressableAssets.PrefabLoader.asmdef (+ Editor)
    Runtime/                        (load + instantiate prefabs by Addressables key)
    Editor/
  UI.PrefabLoader/                ← CupkekGames.AddressableAssets.UI.PrefabLoader.asmdef (+ Editor)
    Runtime/                        (Luna UIPrefabLoader binding)
    Editor/

(UI.Generic — generic UI helpers like NotificationView — lives in Luna's `Samples~/GameFull/Scripts/UI.Generic/`, not here. It's sample-grade scaffolding.)
```

## Dependencies

- `com.cupkekgames.pool`, `com.cupkekgames.keyvaluedatabases`, `com.cupkekgames.prefabloaders` (foundation for `AddressableGameObjectPool` + `PrefabLoaderAddressable`)
- `com.cupkekgames.luna`
- `com.unity.addressables`

## Coding Conventions

- **Namespaces**: `CupkekGames.AddressableAssets` (runtime + prefab loader), `CupkekGames.AddressableAssets.UI` (UI prefab loader), plus `.Editor` / `.Test` variants
- **Asmdefs**: GUID references; use `versionDefines` for `com.unity.addressables`
- **Strict typing**
