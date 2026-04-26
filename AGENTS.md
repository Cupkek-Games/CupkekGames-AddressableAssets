# CupkekGames Addressables — AI Agent Instructions

## Package Overview

**CupkekGames Addressables** (`com.cupkekgames.addressables`) wraps Unity's Addressables system with a prefab loader and Luna UI bindings.

## Critical: Do not hand-edit Unity serialized assets or `.meta` files

Apply scene/SO/Addressables-catalog changes in Unity Editor; preserve `.meta` GUIDs.

## Package Structure

```
com.cupkekgames.addressables/
  package.json
  README.md
  AGENTS.md
  Addressable/                    ← CupkekGames.Systems.Addressables.asmdef
    Runtime/                        (asset reference helpers)
  PrefabLoader/                   ← CupkekGames.Systems.PrefabLoader.asmdef
    Runtime/                        (load + instantiate prefabs by Addressables key)
    Editor/
  UI.PrefabLoader/                ← CupkekGames.Systems.UI.PrefabLoader.asmdef (+ Editor)
    Runtime/                        (Luna UIPrefabLoader binding)
    Editor/

(UI.Generic — generic UI helpers like NotificationView — lives in Luna's `Samples~/GameFull/Scripts/UI.Generic/`, not here. It's sample-grade scaffolding.)
```

## Dependencies

- `com.cupkekgames.core`
- `com.cupkekgames.luna`
- `com.unity.addressables`

## Coding Conventions

- **Namespaces**: `CupkekGames.Systems.Addressables`, `CupkekGames.Systems.PrefabLoader`, `CupkekGames.Systems.UI.PrefabLoader`, `CupkekGames.Systems.UI.Generic`
- **Asmdefs**: GUID references; use `versionDefines` for `com.unity.addressables`
- **Strict typing**
