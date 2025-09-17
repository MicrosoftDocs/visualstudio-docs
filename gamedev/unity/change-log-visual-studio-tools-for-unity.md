---
title: "Change Log (Visual Studio Tools for Unity, Windows)"
description: View the change log for Visual Studio Tools for Unity, Windows. See changes from version 1.0.0.0 through 4.7.0.0 and beyond.
ms.date: "9/17/2025"
ms.subservice: unity-tools
ms.service: visual-studio
ms.topic: "conceptual"
author: jbevain
ms.author: jbevain
manager: crdun
---
# Change log (Visual Studio Tools for Unity, Windows)

Visual Studio Tools for Unity change log.

## 18.0.2.0
Released September 9, 2025

### New Features

- **Integration:**

  - Added `Odin` support for serialization attributes in [`USP0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0004.md), [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md), [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) and [`USP0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0013.md) suppressors.

  - Added `UniTask` support for all message-based diagnostics and suppressors.

  - Added [`USP0023`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0023.md) suppressor, Don't flag incorrect naming styles for Unity messages.

  - Added [`UNT0039`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0039.md) diagnostic, Use `RequireComponent` attribute when self-invoking `GetComponent`.

  - Added ignored members to [`UNT0031`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0031.md) diagnostic, Asset operations in `LoadAttribute` method.

### Bug fixes

- **Integration:**

  - Stability fixes when decoding messages coming from the debuggee.

  - Fixed intellisense: Do not commit on '(' or ')' characters.

## 18.0.1.0
Released August 11, 2025

### Bug fixes

- **Integration:**

  - Stability fixes with [`UNT0035`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0035.md) and [`UNT0034`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0034.md) analyzers regarding `Vector` conversions.

  - Stability fixes with [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md) suppressor regarding `ContextMenu` attribute usage.

  - Stability fixes with thread enumeration.

## 18.0.0.0
Released July 7, 2025

### New Features

- **Integration:**

  - Added support for Visual Studio 2026.

  - Added protected scope for the unity message settings.

### Bug fixes

- **Integration:**

  - Minor UI fixes.

## 17.14.1.0
Released May 13, 2025

### New Features

- **Integration:**

  - Added a result view for `IEnumerable` types.

### Bug fixes

- **Integration:**

  - Improved messaging between Unity and Visual Studio.

  - Optimized UPE in the context of large projects. 

## 17.14.0.0
Released March 11, 2025

### New Features

- **Integration:**

  - Added support for `Unity.Properties.CreateProperty` in [`UNT0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0004.md), [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md), [`UNT0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0007.md) and [`UNT0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0013.md) suppressors.
  
### Bug fixes

- **Debugging:**

  - Improved thread management.

- **Integration:**
 
  - Fixed stability issues with debug targets when using SDK-Style projects.

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) diagnostic when a Unity message is wrongly referenced.

## 17.13.1.0
Released February 11, 2025

### New Features

- **Integration:**

  - Add support for `Awaitable` and `Awaitable<T>` in all compatible analyzers and suppressors.

### Bug fixes

- **Integration:**

  - Improved handling of solution events for the UPE.

## 17.13.0.0
Released January 22, 2025

### Bug fixes

- **Debugging:**

  - Properly report line and column information to the IDE.

  - Prevent exception when evaluating on a stackframe that doesn't exist anymore.

  - Fixed stepping issues.

## 17.12.2.0
Released Janary 7, 2025

### Bug fixes

- **Integration:**

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) when a unity message is wrongly referenced.

- **Debugging:**

  - Improved type-filtering stability when debugging.

## 17.12.1.0
Released November 12, 2024

### Bug fixes

- **Integration:**

  - Improved Editor detection (and introduce a new setting to filter background processes).

  - Improved [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) detection consistency.

- **Debugging:**

  - Improved handling of dynamically generated assemblies.

  - Properly display the name of the domain the modules belong to.

## 17.12.0.0
Released September 10, 2024

### New Features

- **Integration:**

  - Added keyboard search to the UPE

### Bug fixes

- **Debugging:**

  - Fixed mapping of package cache files.

  - Properly display the name of the domain the modules belong to.

## 17.11.2.0
Released August 13, 2024

### Bug fixes

- **Integration:**

  - Improve accessibility.

  - Simplify [`UNT0026`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0026.md), to only support variable declaration constructs.

## 17.11.1.0  
Released July 23, 2024

### Bug fixes

- **Integration:**

  - Stability fixes.

  - fix android player detection.

  - improve editor and player detection.

## 17.11.0.0
Released June 11, 2024

### New Features

- **Integration:**

  - Add light-build support for SDK-style projects

## 17.10.1.0
Released May 21, 2024

### New Features

- **Integration:**

  - Added [`USP0022`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0022.md) suppressor, Unity objects should not use if-null-coalescing.

### Bug fixes

- **Integration:**

  - Display keyboard focus as expected when navigating in Unity Messages.

  - Improve player announce parsing.

  - Improve local player detection.

## 17.10.0.0
Released March 12, 2024

### New Features

- **Integration:**

  - Improve [`UNT0024`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0024.md) analyzer, to support `Unity.Mathematics.floatX` types.

### Bug fixes

- **Debugging:**

  - Fix nullable-value-type display when evaluating.

## 17.9.3.0
Released February 13, 2024

### New Features

- **Integration:**

  - Improved accessibility.

  - Display QuickInfo for all symbols using `TooltipAttribute` (only fields previously).

### Bug fixes

- **Integration:**

  - Fixed trivia handling with [`UNT0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0021.md), when using messages without modifiers.

  - Fixed batch provider for all diagnostics.

  - Fixed [`UNT0034`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0034.md) and [`UNT0035`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0035.md) with ambiguous overloads.

## 17.9.2.0
Released January 3, 2024

### Bug fixes

- **Integration:**

  - Fixed a stability issue preventing intellisense to work properly.

## 17.9.1.0
Released December 12, 2023

### Bug fixes

- **Integration:**

  - Fixed language service usage when navigating the UPE.

  - Fixed stability issue with tgz file references in the manifest.

## 17.9.0.0
Released November 28, 2023

### New Features

- **Integration:**

  - Improved support for `EditorInstance.json`.

  - Added initial SDK-Style projects support.

## 17.8.2.0
Released November 14, 2023

### Bug fixes

- **Debugging:**

  - Improved support for consts when evaluating.

- **Localization:**

  - Fixed localization issues.

## 17.8.1.0
Released September 14, 2023

### New Features

- **Integration:**

  - Added [`USP0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0021.md), Prefer reference equality.

  - Added support for `TransformAccess` with [`UNT0022`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0022.md) and [`UNT0032`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0032.md)

  - Added [`UNT0036`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0036.md), Inefficient method to get position and rotation.

  - Added [`UNT0037`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0036.md), Inefficient method to get localPosition and localRotation.

### Bug fixes

- **Integration:**

- Fixed [`USP0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0008.md) with partial types.

## 17.8.0.0
Released August 8, 2023

### New Features

- **Integration:**

  - Improved accessibility.
  
  - Added alternate local player instance detection.

  - Added support for `EditorInstance.json`.

### Bug fixes

- **Integration:**

  - Fixed a performance issue forcing a full evaluation of the project context.

  - Fixed a performance issue with images and the UPE.

- **Debugging:**

  - Fixed namespace lookup to walk the namespace hierarchy.

  - Fixed an issue with symbol file path.

## 17.7.0.0
Released July 25, 2023

### New Features

- **Integration:**

  - Added [`UNT0034`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0034.md), A Vector3 can be converted into a Vector2.

  - Added [`UNT0035`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0034.md), A Vector2 can be converted into a Vector3.

  - Added support for help links for all analyzers.

### Bug fixes

- **Integration:**

  - Fixed localization issues with Russian language.

  - Fixed checkboxes behavior with "Implement Unity Message" dialog.

  - Fixed color and theme issues.

## 17.6.1.0
Released May 22, 2023

### New Features

- **Debugging:**

  - Added support for "Step Into Specific".

## 17.6.0.0
Released May 16, 2023

### Bug fixes

- **Debugging:**

  - Fixed an issue when using 'nq' format specifier with 'DebuggerDisplayAttribute'.

  - Fixed a debugging issue with packages (related to symbol and relative file paths).

## 17.5.1.0
Released Feb 28, 2023

### New Features

- **Integration:**

  - Added [`USP0020`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0020.md), The Unity runtime invokes Unity messages.

### Bug fixes

- **Integration:**

  - Fixed [`UNT0033`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0033.md) to support all `OnPostprocessAllAssets` overloads.

## 17.5.0.0 
Released December 13, 2022

### New Features

- **Debugging:**

  - Added an error message when using incorrect conditions in breakpoints.

  - Cached exception settings when starting up the debugging session.

- **Integration:**

  - Updated [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) to support all `OnPostprocessAllAssets` overloads.

  - Added [`UNT0031`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0031.md), Asset operations in `LoadAttribute` method.

  - Added [`UNT0032`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0032.md), Inefficient method to set `localPosition` and `localRotation`.

  - Added [`UNT0033`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0033.md), Incorrect message case.

  - Bumped severity to `Warning` for [`UNT0033`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0033.md), [`UNT0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0015.md) and [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostics.

  - Fixed inline ifs incorrectly processed by [`UNT0026`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0026.md).

### Bug fixes

- **Debugging:**

  - Fixed exception handling performance.

  - Fixed breakpoint binding before explicit host instruction when using type filters.

## 17.4.3.0
Released November 1, 2022

### Bug fixes

- **Integration:**

  - Run COM code on the main thread in CodeLens callbacks.

## 17.4.2.0
Released October 11, 2022

### Bug fixes

- **Integration:**

  - Fixed case where async communication completed synchronously.

## 17.4.1.0
Released September 14, 2022

### Bug fixes

- **Debugging:**

  - Fixed stability issues when creating breakpoints, preventing unexpected calls to the debugger agent.

## 17.4.0.0
Released August 9, 2022

### New Features

- **Integration:**

  - Added [`UNT0027`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0027.md), Prevent call to default `PropertyDrawer.OnGUI()` implementation.

  - Added [`UNT0028`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0028.md), Use non-allocating physics APIs.

  - Added [`UNT0029`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0029.md), Pattern matching with `null` on Unity objects.

  - Added [`UNT0030`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0030.md), Calling `Destroy` or `DestroyImmediate` on a `Transform`.

## 17.3.0.0
Released June 14, 2022

### New Features

- **Evaluation:**

  - Added support for fixed array buffers.

## 17.2.4.0
Released May 10, 2022

### New Features

- **Integration:**

  - Updated [`UNT0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0015.md) and [`USP0012`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0012.md) to support `DidReloadScripts` attribute.

  - Added [`USP0019`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0019.md), Don't flag private methods decorated with `PreserveAttribute` or `UsedImplicitlyAttribute` as unused.

  - Added [`USP0018`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0018.md), Unity objects shouldn't be used with throw expressions.

## 17.2.3.0
Released April 26, 2022

### Bug fixes

- **Integration:**

  - Fixed stability issues when reporting diagnostics.

  - Fixed stability issues with message protocol.

## 17.2.2.0
Released April 12, 2022

### New Features

- **Debugging:**

  - Bumped debugger protocol to 2.58.

### Bug fixes

- **Debugging:**

  - Fixed stability issues when handling exceptions.

## 17.2.1.0
Released March 16, 2022

### Bug fixes

- **Integration:**

  - Fixed UPE when working with external packages. This fix requires a new generation process, fully preserving the folder structure and available with the VS Editor package `2.0.15`.

## 17.2.0.0
Released February 15, 2022

### New Features

- **Debugging:**

  - Added support for debugging source generators.

- **Integration:**

  - Remember the last IP endpoint used when manually attaching.

  - Added [`UNT0026`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0026.md), `GetComponent` always allocates, to use `TryGetComponent` instead.

  - Updated [`UNT0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0003.md), usage of non generic `GetComponent`, to work with `TryGetComponent` as well.

  - Updated [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md), `GetComponent` called with non component/interface, to work with `TryGetComponent` as well.

  - Updated [`USP0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0016.md), Initialization detection with nullable reference types, to work with non-Unity objects.

  - Updated [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md), Incorrect message signature, when checking instance or static methods.

### Bug fixes

- **Integration:**

  - Remove Unity's `RuntimePlatform` from the machine name (player announce).

## 17.1.0.0
Released January 19, 2022

### New Features

- **Integration:**

  - Added `CancelInvoke` support to [`UNT0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0016.md) diagnostic (Unsafe way to get the method name).

  - Added `ScriptedImporter` and `AssetPostprocessor` classes to well known Unity message containers.

  - Updated Unity messages to 2020.3.20f1.

### Bug fixes

- **Integration:**

  - Fixed dark theme issues with Dialog window and buttons.

  - Correctly handle overridden messages with the opt-in [`UNT0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0021.md) diagnostic (Unity message should be protected).

## 17.0.4.0
Released January 5, 2022

### Bug fixes

- **Integration:**

  - Automatically disable asset-indexing for large Unity projects.

  - Do not warn for compatibility issue when referencing the UnityEngine project.

## 17.0.3.0
Released December 14, 2021

### Bug fixes

- **Integration:**

  - Reduced memory consumption when processing assets.

## 17.0.2.0
Released October 30, 2021

### Bug fixes

- **Integration:**

  - Improved light-build time, by only running suppressors able to handle CS compiler warnings. All other analyzers run through solution analysis.

## 17.0.1.0
Released October 16, 2021

### Bug fixes

- **Integration:**

  - Reduced memory consumption when parsing yaml assets.

## 17.0.0.0
Released October 8, 2021

### New Features

- **Integration:**

  - Added support for Visual Studio 2022.

  - We deprecated our legacy project generator for Unity. Going forward please use the latest [Visual Studio Editor package](https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@2.0/changelog/CHANGELOG.html) in your projects (`Unity > Window > Package Manager`) and make sure Visual Studio 2022 is set as your preferred code editor (`Unity > Edit > Preferences > External Tools`).

  - Updated Unity messages to 2020.3.9f1.

## 4.11.4.0
Released October 4, 2021

### New Features

- **Integration:**

  - [Backported] Automatically disable asset-indexing for large Unity projects.

### Bug fixes

- **Integration:**

  - Fixed supported expression detection with [`UNT0024`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0024.md) diagnostic.

## 4.11.3.0
Released August 10, 2021

### Bug fixes

- **Integration:**

  - [Backported] Reduced memory consumption when processing assets.

  - Optimized allocations with [`USP0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0008.md), [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md), [`USP0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0010.md) and [`USP0011`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0011.md) suppressors.

  - Optimized symbol usage with [`UNT0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0002.md), [`UNT0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0003.md), [`UNT0012`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0012.md), [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) diagnostics.

## 4.11.2.0
Released July 13, 2021

### Bug fixes

- **Integration:**

  - [Backported] Improved light-build time, by only running suppressors able to handle CS compiler warnings. All other analyzers run through solution analysis.

## 4.11.1.0
Released June 15, 2021

### Bug fixes

- **Integration:**

  - [Backported] Reduced memory consumption when parsing yaml assets.

## 4.11.0.0
Released May 25, 2021

### New Features

- **Integration:**

  - Added [`UNT0025`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0025.md) diagnostic. Prefer Input.GetKey overloads with KeyCode argument.

  - Added more invalid usages (static and readonly fields) to [`UNT0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0013.md) diagnostic.

### Bug fixes

- **Integration:**

  - Fixed issues with explicit method implementations and [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic.

## 4.10.3.0
Released June 8, 2021

### Bug fixes

- **Integration:**

  - [Backported] Reduced memory consumption when parsing yaml assets.

## 4.10.2.0
Released May 25, 2021

### New Features

- **Integration:**

  - Added [`UNT0024`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0024.md) diagnostic. Give priority to scalar calculations over vector calculations.

- **Evaluation:**

  - Added support for using portable pdb symbols to properly filter visible locals.

### Bug fixes

- **Integration:**

  - Fixed asset reference search stability.

  - Fixed player announce parsing with recent Unity versions.

## 4.10.1.0
Released May 11, 2021

### Bug fixes

- **Integration:**

  - Fixed stability issues with [`UNT0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0008.md) quickfix.

  - Fixed performance issues with threads.

## 4.10.0.0
Released April 13, 2021

### New Features

- **Integration:**

  - Added [`UNT0019`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0019.md) diagnostic. Unnecessary indirection call for `GameObject.gameObject`.

  - Added [`UNT0020`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0020.md) diagnostic. `MenuItem` attribute used on non-static method.

  - Added [`UNT0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0021.md) diagnostic. Unity message should be protected (opt-in).

  - Added [`UNT0022`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0022.md) diagnostic. Inefficient method to set position and rotation.

  - Added [`UNT0023`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0023.md) diagnostic. Coalescing assignment on Unity objects.

  - Added [`USP0017`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0017.md) suppressor for `IDE0074`. Unity objects shouldn't use coalescing assignment.

  - Added detection of unflavored C# projects targeting Unity.

  - Added Unity asset reference search in CodeLens.

## 4.9.1.0
Released March 2, 2021

### New Features

- **Evaluation:**

  - Added `Active Scene` to locals, showing root game objects.

  - Added `this.gameObject` to locals, given it's common in Unity projects.

  - Added `Children` and `Components` groups to all `GameObject` instances, so that you can easily display all the object hierarchy.

  - Added `Scene Path` to all `GameObject` instances, to show the location in the scene.

  - Added support for `JobEntityBatch`/Lambdas when using Entities with source generators.

  - Improved support for displaying large arrays (using index bucketing).
  
  - Added missing Unity messages for 2019.4 API.

### Bug fixes

- **Integration:**

  - Fixed various UI issues for non ENU languages.

  - Fixed stability issues with [`UNT0018`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0018.md) diagnostic.
  
- **Debugging:**

  - Fixed VM disconnection issues when using `Trace` methods.

- **Evaluation:**

  - Fixed filtering of obsolete properties throwing exceptions.

## 4.9.0.0
Released January 20, 2021

### New Features

- **Integration:**

  - Added support for `raytrace shaders`, `UXML` and `USS` files.

  - Added `.vsconfig` generation support. Visual Studio should now detect which components are missing and prompt you to install them when using Unity projects.

  - Updated Unity messages API (for all methods used as coroutines).

  - Updated Android SDK detection.

### Bug fixes

- **Integration:**

  - Fixed process refresh when using instance selection dialog.

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic, giving wrong warnings for Coroutines and `AssetPostprocessor.OnAssignMaterialModel`.

## 4.8.2.0
Released November 10, 2020

### New Features

- **Integration:**

  - Improved [`UNT0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0010.md) diagnostic to apply to everything inheriting from `Component`, not just `MonoBehaviour`.

### Bug fixes

- **Integration:**

  - Fixed CodeLens message invalidation.

## 4.8.1.0
Released October 13, 2020

### New Features

- **Evaluation:**

  - Added support for implicit conversion with invocations. Previously the evaluator enforced strict type checking, resulting in `Failed to find a match for method([parameters...])` warning messages.

- **Integration:**

  - Added [`UNT0018`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0018.md) diagnostic. You shouldn't use `System.Reflection` features in performance critical messages like `Update`, `FixedUpdate`, `LateUpdate`, or `OnGUI`.

  - Improved [`USP0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0003.md) and [`USP0005`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0005.md) suppressors, with support for all `AssetPostprocessor` static methods.

  - Added [`USP0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0016.md) suppressor for `CS8618`. `C# 8.0` introduces nullable reference types and non-nullable reference types. Initialization detection of types inheriting from `UnityEngine.Object` is not supported.

  - Now using the same player and asmdef project generation mechanism for both Unity 2019.x and 2020.x+.

### Bug fixes

- **Integration:**

  - Fixed unexpected completion for messages in comments.

## 4.8.0.0 
Released September 14, 2020

### Bug fixes

- **Integration:**

  - Fixed player project generation with Unity 2019.x.

## 4.7.1.0
Released August 5, 2020

### New Features

- **Integration:**

  - Added namespace support to default templates.
  
  - Updated Unity messages API to 2019.4.

  - Added [`USP0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0013.md) suppressor for `CA1823`. Private fields with the `SerializeField` or `SerializeReference` attributes shouldn't be marked as unused (FxCop).
  
  - Added [`USP0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0014.md) suppressor for `CA1822`. Unity messages shouldn't be flagged as candidates for `static` modifier (FxCop).

  - Added [`USP0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0015.md) suppressor for `CA1801`. Unused parameters shouldn't be removed from Unity messages (FxCop).
  
  - Added MenuItem support to the [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md) suppressor.  

### Bug fixes

- **Integration:**

  - Fixed [`USP0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0001.md) and [`USP0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0002.md) suppressors not working with extra parentheses or with method arguments.
  
  - Fixed mandatory asset database refresh even when auto-refresh was disabled in the Unity settings.

## 4.7.0.0
Released June 23, 2020

### New Features

- **Integration:**

  - Added support to persist solution folders when Unity is regenerating solution and projects.

  - Added [`UNT0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0015.md) diagnostic. Detect incorrect method signature with `InitializeOnLoadMethod` or `RuntimeInitializeOnLoadMethod` attribute.

  - Added [`UNT0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0016.md) diagnostic. Using `Invoke`, `InvokeRepeating`, `StartCoroutine` or `StopCoroutine` with a first argument being a string literal isn't type safe.

  - Added [`UNT0017`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0017.md) diagnostic. `SetPixels` invocation is slow.

  - Added support for block comment and indentation for Shader files.

### Bug fixes

- **Integration:**

  - Don't reset selection when filtering messages in the Unity message wizard.
  
  - Always use the default browser when opening Unity API documentation.
  
  - Fixed [`USP0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0004.md), [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md) and [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) suppressors with the following rules: suppress `IDE0044` (readonly), `IDE0051` (unused), `CS0649` (never assigned) for all fields decorated with SerializeField attribute. Suppress `CS0649` (never assigned) for public fields of all types extending `Unity.Object`.

  - Fixed generic type parameter checking for [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) diagnostic.

- **Evaluation:**

  - Fixed equality comparison with enums.

## 4.6.1.0
Released May 19, 2020

### Bug fixes

- **Integration:**

  - Warn if we're unable to create the messaging server on the Unity side.
  
  - Properly run analyzers during lightweight compilation.
  
  - Fixed an issue where a MonoBehaviour class created from the UPE didn't match the name of the file.

## 4.6.0.0
Released April 14, 2020

### New Features

- **Integration:**

  - Added support for CodeLens (Unity scripts and messages).
  
  - Added [`UNT0012`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0012.md) diagnostic. Detect and wrap calls to coroutines in `StartCoroutine()`.

  - Added [`UNT0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0013.md) diagnostic. Detect and remove invalid or redundant `SerializeField` attribute.

  - Added [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) diagnostic. Detect `GetComponent()` called with non-Component or non-Interface Type.
  
  - Added [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md) suppressor for `IDE0051`. Don't flag methods with the `ContextMenu` attribute or referenced by a field with the `ContextMenuItem` attribute as unused.

  - Added [`USP0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0010.md) suppressor for `IDE0051`. Don't flag fields with the `ContextMenuItem` attribute as unused.
  
  - Added [`USP0011`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0011.md) suppressor for `IDE0044`. Don't make fields with the `ContextMenuItem` attribute read-only.
  
  - [`USP0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0004.md), [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md) and [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) are now working for both `SerializeReference` and `SerializeField` attributes.
  
### Bug fixes

- **Integration:**

  - Only send start/stop commands to Unity when the Editor is able to communicate.
  
  - Fixed QuickInfo documentation with inherited messages.
  
  - Fixed message scope for `CreateInspectorGUI` message.

  - Don't report [`UNT0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0001.md) on methods with polymorphic modifiers.

- **Evaluation:**

  - Fixed handling of aliased usings.

## 4.5.1.0

Released March 16, 2020

### New Features

- **Integration:**

  - Added [`USP0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0008.md) suppressor for `IDE0051`. Private methods used with Invoke, InvokeRepeating, StartCoroutine or StopCoroutine shouldn't be marked as unused.

### Bug fixes

- **Integration:**

  - Fixed OnDrawGizmos/OnDrawGizmosSelected documentation.

- **Evaluation:**

  - Fixed lambda argument inspection.

## 4.5.0.1

Released February 19, 2020

### Bug fixes

- **Integration:**

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic checking for incorrect message signature. When inspecting types with multiple levels of inheritance, this diagnostic could fail with the following message: `warning AD0001: Analyzer 'Microsoft.Unity.Analyzers.MessageSignatureAnalyzer' threw an exception of type 'System.ArgumentException' with message 'An item with the same key has already been added`.

## 4.5.0.0

Released January 22, 2020

### New Features

- **Integration:**

  - Added support for HLSL files.
  
  - Added [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md) suppressor for `IDE0051`. Private fields with the `SerializeField` attribute shouldn't be marked as unused.
  
  - Added [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) suppressor for `CS0649`. Fields with the `SerializeField` attribute shouldn't be marked as unassigned.  

### Bug fixes

- **Integration:**

  - Fixed project generation (`GenerateTargetFrameworkMonikerAttribute` target wasn't always located correctly).

## 4.4.2.0

Released December 3, 2019

### Bug fixes

- **Integration:**

  - Fixed diagnostics with user-defined interfaces.

  - Fixed quick tooltips with malformed expressions.

## 4.4.1.0

Released November 6, 2019

### New Features

- **Integration:**

  - Added support for Unity background processes. (The debugger is able to auto-connect to the main process instead of a child process).
  
  - Added a quick tooltip for Unity messages, displaying the associated documentation.

### Bug fixes

- **Integration:**

  - Fixed the tag comparison analyzer [`UNT0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0002.md) with advanced binary and invocation expressions.

### Deprecated Features

- **Integration:**

  - Going forward, Visual Studio Tools for Unity will only support Visual Studio 2017+.

## 4.4.0.0

Released October 15, 2019

### New Features

- **Integration:**

  - Added [`USP0005`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0005.md) suppressor for `IDE0060` (unused parameter) for all Unity messages.
  
  - Added a quick tooltip for fields tagged with `TooltipAttribute`. (This feature works for a simple get accessor using this field as well).

## 4.3.3.0

Released September 23, 2019

### Bug fixes

- **Integration:**

  - Fixed error and warning reporting for lightweight builds.

## 4.3.2.0

Released September 16, 2019

### New Features

- **Integration:**

  - We've deepened the understanding that Visual Studio has for Unity projects by adding new diagnostics specific to Unity. We've also made the IDE smarter by suppressing general C# diagnostics that don't apply to Unity projects. For example, the IDE won't show a quick-fix to change an inspector variable to `readonly` which would prevent you from modifying the variable in the Unity Editor.
    - [`UNT0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0001.md): Unity messages are called by the runtime even if they're empty, don't declare them to avoid unnecessary processing by the Unity runtime.
    - [`UNT0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0002.md): Tag comparison using string equality is slower than the built-in CompareTag method.
    - [`UNT0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0003.md): Usage of the generic form of GetComponent is preferred for type safety.
    - [`UNT0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0004.md): Update message is frame-rate dependent, and should use Time.deltaTime instead of Time.fixedDeltaTime.
    - [`UNT0005`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0005.md): FixedUpdate message is frame-rate independent, and should use Time.fixedDeltaTime instead of Time.deltaTime.
    - [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md): An incorrect method signature was detected for this Unity message.
    - [`UNT0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0007.md): Unity overrides the null comparison operator for Unity objects which is incompatible with null coalescing.
    - [`UNT0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0008.md): Unity overrides the null comparison operator for Unity objects which is incompatible with null propagation.
    - [`UNT0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0009.md): When applying the InitializeOnLoad attribute to a class, you need to provide a static constructor. InitializeOnLoad attribute ensures that it will be called as the editor launches.
    - [`UNT0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0010.md): MonoBehaviours should only be created using AddComponent(). MonoBehaviour is a component, and needs to be attached to a GameObject.
    - [`UNT0011`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0011.md): ScriptableObject should only be created using CreateInstance(). ScriptableObject needs to be created by the Unity engine to handle Unity message methods.
    - [`USP0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0001.md) for `IDE0029`: Unity objects shouldn't use null coalescing.
    - [`USP0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0002.md) for `IDE0031`: Unity objects shouldn't use null propagation.
    - [`USP0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0003.md) for `IDE0051`: Unity messages are invoked by the Unity runtime.
    - [`USP0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0004.md) for `IDE0044`: Fields with a SerializeField attribute shouldn't be made readonly.

## 4.3.1.0

Released September 4, 2019

### New Features

- **Evaluation:**

  - Added support for better type display, that is `List<object>` instead of `List'1[[System.Object, <corlib...>]]`.

  - Added support for pointer member access, that is `p->data->member`.

  - Added support for implicit conversions in array initializers, that is `new byte [] {1,2,3,4}`.

## 4.3.0.0

Released August 13, 2019

### New Features

- **Debugger:**

  - Added support for MDS protocol 2.51.

- **Integration:**

  - Improved the "Attach To Unity instance" window with sort, search and refresh features. PID is now displayed even for local players (by querying listening sockets on the system to retrieve the owning process).

  - Added support for asmdef files.

### Bug fixes

- **Integration:**

  - Fixed handling of malformed messages while communicating with Unity Players.

- **Evaluation:**

  - Fixed handling of namespaces in expressions.

  - Fixed inspection with IntPtr types.
  
  - Fixed stepping issues with exceptions.

  - Fixed evaluation of pseudo identifiers (like $exception).

  - Prevent crash when dereferencing invalid addresses.  

  - Fixed issue with unloaded appdomains.

## 4.2.0.1

Released July 24, 2019

### New Features

- **Integration:**

  - Added a new option to create any type of files from the Unity Project Explorer.
  
  - Improve diagnostic caching when using fast builds for Unity projects.

### Bug fixes

- **Integration:**

  - Fixed an issue when the file extension wasn't handled by any well-known editor.

  - Fixed support for custom extensions in the Unity Project Explorer.

  - Fixed saving settings outside of the main dialog.

  - Removed legacy Microsoft.VisualStudio.MPF dependency.

## 4.1.1.0

Released May 24, 2019

### New Features

- **Integration:**

  - Updated MonoBehaviour API to 2019.1.

### Bug fixes

- **Integration:**

  - Fixed reporting warnings and errors to output when lightweight build is enabled.

  - Fixed lightweight build performance.

## 4.1.0.0

Released May 21, 2019

### New Features

- **Integration:**

  - Added support for the new batch API to reload projects faster.

  - Disabled the full build for Unity projects, in favor of using the IntelliSense errors and warnings. Indeed Unity creates a Visual Studio solution with class library projects that represent what Unity is doing internally. That being said, the result of the build in Visual Studio is never used or picked up by Unity as their compilation pipeline is closed. Building in Visual Studio is just consuming resources for nothing. If you need a full build because you have tools or a setup that depends on it, you can disable this optimization (Tools/Options/Tools for Unity/Disable the full build of projects).

  - Automatically show the Unity Project Explorer (UPE) when a Unity project is loaded. The UPE is docked next to the Solution Explorer.

  - Updated project name extraction mechanism with Unity 2019.x.

  - Added support for Unity packages in the UPE. Only Referenced packages (using manifest.json in the `Packages` folder) and Local packages (embedded in the `Packages` folder) are visible.

- **Project Generation:**

  - Preserve external properties when processing the solution file.

- **Evaluation:**

  - Added support for alias-qualified names (only the global namespace for now). So the expression evaluator is now accepting types using the form global::namespace.type.

  - Added support for `pointer[index]` form, which is semantically identical to pointer dereference `*(pointer+index)` form.

### Bug fixes

- **Integration:**

  - Fixed dependency issues with Microsoft.VisualStudio.MPF.

  - Fixed UWP player attach, without any project loaded.

  - Fixed automatic asset database refresh when Visual Studio was not yet attached.

  - Fixed theme issues with labels and checkboxes.

- **Debugger:**

  - Fixed stepping with static constructors.

## 4.0.0.5

Released February 27, 2019

### Bug fixes

- **Integration:**

  - Fixed Visual Studio version detection with the setup package.

  - Removed unused assemblies from the setup package.

## 4.0.0.4

Released February 13, 2019

### New Features

- **Integration:**

  - Added support to properly detect Unity processes during installation and allow setup engine to better handle file locks.

  - Updated the `ScriptableObject` API.

## 4.0.0.3

Released January 31, 2019

### New Features

- **Project Generation:**

  - Public and serialized fields will no longer cause warnings. We've auto-suppressed the `CS0649` and `IDE0051` compiler warnings in Unity projects that created these messages.

- **Integration:**

  - Improved the user experience for displaying Unity editor and player instances (windows are now resizable, use uniform margins and display a resizing grip). Added Process-Id information for Unity editors.

  - Updated the `MonoBehaviour` API.

- **Evaluation:**

  - Added support for local functions.

  - Added support for pseudo variables (exception and object identifiers).

### Bug fixes

- **Integration:**

  - Fixed an issue with moniker images and themes.

  - Only write to Output Window while debugging, when auto-refreshing asset database.

  - Fixed UI delays with the MonoBehaviour wizard filtering.

- **Debugger:**

  - Fixed reading custom attribute on named arguments when using old protocol versions.

## 4.0.0.2

Released January 23, 2019

### Bug fixes

- **Integration:**

  - Fixed experimental build generation.

  - Fixed project file event handling to minimize UI-thread pressure.

  - Fixed completion provider with batched text changes.

- **Debugger:**

  - Fixed the display of user debug messages to the attached debugger.

## 4.0.0.1

Released December 10, 2018

### New Features

- **Evaluation:**

  - Replaced NRefactory in favor of Roslyn for expression evaluation.

  - Added support for pointers: dereference, casting and pointer arithmetic (both Unity 2018.2+ and the new runtime are required for this).

  - Added support for array pointer view (like in C++). Take a pointer expression then append a comma and the number of elements you want to see.

  - Added support for async constructs.

- **Integration:**

  - Added support for automatically refreshing Unity's asset database on save. This feature is enabled by default and will trigger a recompilation on the Unity side when saving a script in Visual Studio. You can disable this feature in Tools\Options\Tools for Unity\Refresh Unity's AssetDatabase on save.

### Bug fixes

- **Integration:**

  - Fixed bridge activation when Visual Studio isn't selected as the preferred external editor.

  - Fixed expression evaluation with malformed or unsupported expressions.

## 4.0.0.0

Released December 4, 2018

### New Features

- **Integration:**

  - Added support for Visual Studio 2019 (you need at least Unity 2018.3 for being able to use Visual Studio 2019 as an external script editor).

  - Adopted the Visual Studio image service and catalog, with full support for HDPI scaling, pixel perfect images and theming.

### Deprecated features

- **Integration:**

  - Going forward, Visual Studio Tools for Unity will only support Unity 5.2+ (with Unity’s built-in Visual Studio integration).

  - Going forward, Visual Studio Tools for Unity will only support Visual Studio 2015+.

  - Removed legacy language service, error list and status bar.

  - Removed the Quick Monobehaviour Wizard (in favor of the dedicated intellisense support).

## 3.9.0.3

Released November 28, 2018

### Bug fixes

- **Integration:**

  - Fixed project reloading and intellisense issues when adding or removing scripts located in the first project.

## 3.9.0.2

Released November 19, 2018

### Bug fixes

- **Debugger:**

  - Fixed a deadlock in the library used to communicate with Unity’s debugger engine, making Visual Studio or Unity freeze, especially when hitting ‘Attach to Unity’ or restarting game.

## 3.9.0.1

Released November 15, 2018

### Bug fixes

- **Integration:**

  - Fixed Unity plugin activation when another default editor was selected.

## 3.9.0.0

Released November 13, 2018

### Bug fixes

- **Project Generation:**

  - Rolled back the workaround for a Unity performance bug that has been fixed by Unity.

## 3.8.0.7

Released September 20, 2018

### Bug fixes

- **Debugger:**

  - (Backported from 3.9.0.2) Fixed a deadlock in the library used to communicate with Unity’s debugger engine, making Visual Studio or Unity freeze, especially when hitting ‘Attach to Unity’ or restarting game.

## 3.8.0.6

Released August 27, 2018

### Bug fixes

- **Integration:**

  - Fixed reloading of projects and solution.

## 3.8.0.5

Released August 20, 2018

### Bug fixes

- **Integration:**

  - Fixed project monitoring subscription disposal.

## 3.8.0.4

Released August 14, 2018

### New Features

- **Evaluation:**

  - Added support for pointer values.

  - Added support for generic methods.

### Bug fixes

- **Integration:**

  - Smart reload with multiple projects changed.

## 3.8.0.3

Released July 24, 2018

### Bug fixes

- **Project Generation:**

  - (Backported from 3.9.0.0) Rolled back the workaround for a Unity performance bug that has been fixed by Unity.

## 3.8.0.2

Released July 7, 2018

### Bug fixes

- **Project Generation:**

  - Transient workaround for a Unity performance bug: cache MonoIslands when generating projects.

## 3.8.0.1

Released June 26, 2018

### New Features

- **Debugging:**

  - Added support for UserLog and UserBreak commands.

  - Added lazy type-load support (optimizing the network load and debugger response latency).

### Bug fixes

- **Evaluation:**

  - Improved binary-operator expression evaluation and method search.

## 3.8.0.0

Released May 30, 2018

### New Features

- **Debugging:**

  - Added support for displaying variables in async constructs.

  - Added support for processing nested types when setting breakpoints, to prevent warnings with compiler constructs.

- **Integration:**

  - Added support for textmate grammars for Shaders (the C++ workload is no longer needed for Shader code coloration).

### Bug fixes

- **Project Generation:**

  - Don't convert portable pdb to mdb anymore when using the new Unity runtime.

## 3.7.0.1

Released May 7, 2018

### Bug fixes

- **Installer:**

  - Fixed dependency issue when using experimental builds.

## 3.7.0.0

Released May 7, 2018

### New Features

- **Debugging:**

  - Added support for orchestrated debugging (debugging multiple players/editor with the same Visual Studio session).

  - Added support for Android USB player debugging.

  - Added support for UWP/IL2CPP player debugging.

- **Evaluation:**

  - Added support for hexadecimal specifiers.

  - Improved watch window evaluation experience.

### Bug fixes

- **Integration:**

  - Fixed usage of exception settings.

- **Project Generation:**

  - Exclude package manager compilation units from generation.

## 3.6.0.5

Released March 13, 2018

### New Features

- **Project Generation:**

  - Added support for the new project generator in Unity 2018.1.

### Bug fixes

- **Integration:**

  - Fixed handling corrupted states with custom projects.

- **Debugger:**

  - Fixed setting the next statement.

## 3.6.0.4

Released March 5, 2018

### Bug fixes

- **Project Generation:**

  - Fixed Mono version detection.

- **Integration:**

  - Fixed timing issues with 2018.1 and plugin activation.

## 3.6.0.3

Released February 23, 2018

### New Features

- **Project Generation:**

  - Added support for .NET Standard.

### Bug fixes

- **Project Generation:**

  - Fixed Unity target framework detection.

- **Debugger:**

  - Fixed breaking on exceptions that are thrown outside of usercode.

## 3.6.0.2

Released February 7, 2018

### New Features

- **Integration:**

  - Update UnityMessage API surface for 2017.3.

### Bug fixes

- **Integration:**

  - Only reload projects on external change (with throttling).

## 3.6.0.1

Released January 24, 2018

### Bug fixes

- **Integration:**

  - Fixed automatic pdb to mdb debug symbol conversion.

  - Fixed indirect call to EditorPrefs.GetBool impacting the inspector while trying to change array size.

## 3.6.0.0

Released January 10, 2018

### New Features

- **Project Generation:**

  - Added support for 2018.1 MonoIsland reference model.

- **Evaluation:**

  - Added support for $exception identifier.

- **Debugger:**

  - Added support for DebuggerHidden/DebuggerStepThrough attributes with the new Unity runtime.

- **Wizards:**

  - Introduce 'Latest' version for wizards.

### Bug fixes

- **Project Generation:**

  - Fixed project guid computation for player projects.

- **Debugger:**

  - Fixed a race in handling breaking events.

- **Wizards:**

  - Refresh roslyn context before inserting method.

## 3.5.0.3

Released January 9, 2018

### Bug fixes

- **Integration:**

  - Fixed automatic pdb to mdb debug symbol conversion.

## 3.5.0.2

Released December 4, 2017

### New Features

- **Integration:**

  - Unity projects are now automatically reloaded in Visual Studio when you add or remove a script from Unity.

- **Debugger:**

  - Added an option to use the Mono debugger shared by Xamarin and Visual Studio for Mac to debug the Unity Editor.

  - Added support for portable debug symbol files.

### Bug fixes

- **Integration:**

  - Fixed setup dependencies issues.

  - Fixed Unity API help menu not showing.

- **Project Generation:**

  - Fixed player project generation when working on a UWP game with the IL2CPP/.NET 4.6 backend.

  - Fixed extra .dll extension wrongly added to the assembly filename.

  - Fixed usage of a specific project API compatibility level instead of the global one.

  - Don't force the AllowAttachedDebuggingOfEditor Unity flag as the default is now 'true'.

## 3.4.0.2

Released September 19, 2017

### New Features

- **Project Generation:**

  - Added support for assembly.json compilation units.

  - Stopped copying Unity assemblies to the project folder.

- **Debugger:**

  - Added support for setting the next statement with the new Unity runtime.

  - Added support for Decimal type with the new Unity runtime.

  - Added support for implicit/explicit conversions.

### Bug fixes

- **Evaluation:**

  - Fixed array creation with implicit size.

  - Fixed compiler generated items with locals.

- **Project Generation:**

  - Fixed reference to Microsoft.CSharp for 4.6 API level.

## 3.3.0.2

Released August 15, 2017

### Bug fixes

- **Project Generation:**

  - Fixed the Visual Studio solution generation on Unity 5.5 and previous versions.

## 3.3.0.0

Released August 14, 2017

### New Features

- **Evaluation:**

  - Added support for creating structs with the new Unity runtime.

  - Added minimalist support for pointers.

### Bug fixes

- **Evaluation:**

  - Fixed method invocation on primitives.

  - Fixed field evaluation with types marked with BeforeFieldInit.

  - Fixed non supported calls with binary operators (subtract).

  - Fixed issues when adding items to the Visual Studio Watch.

- **Project Generation:**

  - Fixed assembly name references with mcs.rsp files.

  - Fixed defines with API levels.

## 3.2.0.0

Released May 10, 2017

### New Features

- **Installer:**

  - Added support for cleaning the MEF cache.

### Bug fixes

- **Code Editor:**

  - Fixed classification/completion with custom attributes.

  - Fixed flickering with Unity messages.

## 3.1.0.0

Released April 7, 2017

### New Features

- **Debugger:**

  - Added support for the new Unity runtime (with .NET 4.6 / C# 6 compatibility).

- **Project Generation:**

  - Added support for .NET 4.6 profile.

  - Added support for mcs.rsp files.

  - Always enable unsafe compilation switch when Unity 5.6 is used.

  - Added support for "Player" project generation when using Windows Store platform and il2cpp backend.

### Bug fixes

- **Code Editor:**

  - Fixed caret position after inserting method with auto-completion.

- **Project Generation:**

  - Removed assembly version post-processing.

## 3.0.0.1

Released March 7, 2017

### This version includes all new features and bug fixes introduced with 2.8.x series.

## 2.8.2.0 - 3.0 Preview 3
Released January 25, 2017

### Bug fixes

- **Project Generation:**

  - Fixed regression where Plugins projects where referenced twice, first as a binary DLL then as a project reference.

## 2.8.1.0 - 3.0 Preview 2
Released January 23, 2017

### Bug fixes

- **Code Editor:**

  - Fixed a crash when starting an attribute declaration without brace completion.

- **Debugger:**

  - Fixed function breakpoints with coroutines under the new Unity compiler/runtime.

  - Added warning if there's an unbindable breakpoint (when no corresponding source-location is found).

- **Project Generation:**

  - Fixed csproj generation with special/localized characters.

  - Fixed references outside of Assets, such as Library (like the Facebook SDK).

- **Misc:**

  - Added check to prevent Unity from running when installing or uninstalling.

  - Switched to https to target the remote Unity documentation.

## 2.8.0.0 - 3.0 Preview
Released November 17, 2016

### New Features

- **General:**

  - Added Visual Studio 2017 installer support.

  - Added Visual Studio 2017 extension support.

  - Added localization support.

- **Code Editor:**

  - Added C# IntelliSense for Unity messages.

  - Added C# code coloration for Unity messages.

- **Debugger:**

  - Added support for `is`, `as`, direct cast, `default`, `new` expressions.

  - Added support for string concat expressions.

  - Added support for hexadecimal display of integer values.

  - Added support for creating new temporary variables (statements).

  - Added support for implicit primitive conversions.

  - Added better error messages when a type is expected or not found.

- **Project Generation:**

  - Removed the CSharp suffix from the project names.

  - Removed reference to a system wide msbuild targets file.

- **Wizards:**

  - Added support for Unity messages in non Behaviour types such as Editor or EditorWindow.

  - Switched to Roslyn to inject and format Unity messages.

### Bug fixes

- **Debugger:**

  - Fixed a bug crashing Unity when evaluating generic types.

  - Fixed handling of nullable types.

  - Fixed handling of enums.

  - Fixed handling of nested member types.

  - Fixed collection indexer access.

  - Fixed support for debugging iterator frames with new C# compiler.

- **Project Generation:**

  - Fixed bug that prevented compilation when targeting the Unity Web player.

  - Fixed bug that prevented compilation when compiling a script with a web encoded file name.

## 2.3.0.0

Released July 14, 2016

### New Features

- **General:**

  - Added an option to disable Unity console logs in Visual Studio's error list.

  - Added an option to allow generated project properties to be modified.

- **Debugger:**

  - Added Text, XML, HTML and JSON string visualizers.

- **Wizards:**

  - Added missing MonoBehaviors.

### Bug fixes

- **General:**

  - Fixed a conflict with ReSharper that prevented controls inside Visual Studio settings from being displayed.

  - Fixed a conflict with Xamarin that  prevented debugging in some cases.

- **Debugger:**

  - Fixed an issue that caused Visual Studio to freeze when debugging.

  - Fixed an issue with function breakpoints in Visual Studio 2015.

  - Fixed several expression evaluation issues.

## 2.2.0.0

Released February 4, 2016

### New Features

- **Wizards:**

  - Added smart search in the **Implement MonoBehavior** wizard.

  - Made wizards context aware; for example, NetworkBehavior messages are only available when working with a NetworkBehavior.

  - Added support for NetworkBehavior messages in the wizards.

- **UI:**

  - Added an option to configure the visibility of MonoBehavior messages.

  - Removed Visual Studio property pages that aren't relevant to Unity projects.

### Bug fixes

- **Project generation:**

  - Fixed references to UnityEngine and UnityEditor on Unity 4.6.

  - Fixed generation of project files when Unity is running on OSX.

  - Fixed handling of project names containing hashmark (#) characters.

  - Restricted generated projects to C# 4.

- **Debugger:**

  - Fixed an issue with expression evaluation when debugging inside a Unity coroutine.

  - Fixed an issue that caused Visual Studio to freeze when debugging.

- **UI:**

  - Fixed an incompatibility with the [Tabs Studio](https://tabsstudio.com/) Visual Studio extension.

- **Installer:**

  - Support machine-wide installation of VSTU (install for all users)  by creating HKLM registry entries.

  - Fixed issues with uninstallation of VSTU when the same version of VSTU is installed for multiple different versions of Visual Studio. For example, when VSTU **2015** 2.1.0.0 and VSTU **2013** 2.1.0.0 were both installed.

## 2.1.0.0

Released September 8, 2015

### New Features

- Support for Unity 5.2

### Bug fixes

- Display menu items on Unity < 4.2

- An error message is no longer displayed when Visual Studio locks XML intellisense files.

- Handle <\<When Changed>> conditional breakpoints when conditional argument isn't a boolean value.

- Fixed references to UnityEngine and UnityEditor assemblies for Windows Store apps.

- Fixed error when stepping in the debugger: Unable to step, general exception.

- Fixed hit-count breakpoints in Visual Studio 2015.

## 2.0.0.0

Released July 20, 2015

### Bug fixes

- **Unity Integration:**

  - Fixed the conversion of debug symbols created with Visual Studio 2015 when importing a DLL and its debug symbols (PDB).

  - Always generate MDB files when importing a DLL and its debug symbols (PDB), except when an MDB file is also provided.

  - Fixed pollution of the Unity project directory with an obj directory.

  - Fixed generation of references to System.Xml.Link and System.Runtime.Serialization.

  - Added support for multiple subscribers to the project file generation API hooks.

  - Always complete project file generation even when one of the files to be generated is locked.

  - Added support for * wildcards in the extension filter when specifying files to be included in the C# project.

- **Visual Studio integration:**

  - Fixed a compatibility issue with the Productivity Power Tools.

  - Fixed generating MonoBehaviors around events and delegates declarations.

- **Debugger:**

  - Fixed a potential freeze when debugging.

  - Fixed an issue where locals wouldn't be displayed in certain stack frames.

  - Fixed inspecting empty arrays.

## 1.9.9.0 - 2.0 Preview 2
Released April 2, 2015

### New features

- **Unity Project Explorer:**

  - Automatically rename class when renaming a file in the Unity Project Explorer (See **Options** dialog).

  - Automatically select newly created scripts in the Unity Project Explorer.

  - Track the active script in the Unity Project Explorer (See **Options** dialog).

  - Dual-synchronize the Visual Studio Solution Explorer (See **Options** dialog).

  - Adopt Visual Studio icons in Unity Project Explorer.

- **Debugger:**

  - Select the active debug target from a list of saved or recently-used debug targets (See **Options** dialog).

  - Create function breakpoints on MonoBehavior methods and apply them to multiple MonoBehavior classes.

  - Support Make Object ID in the debugger.

  - Support breakpoint hit count in the debugger.

  - Support break-on-exception in the debugger (Experimental. See **Options** Dialog).

  - Support creation of objects and arrays when evaluating expressions in the debugger.

  - Support null comparison when evaluation expressions in the debugger.

  - Filter out obsolete members in debugger watch windows.

- **Installer:**

  - Optimized Visual Studio Tools for Unity extension registration.

  - Install Visual Studio Tools for Unity package for Unity 5.

- **Documentation:** Improve performance of documentation generation.

- **Wizards:** Support new MonoBehavior methods for Unity 4.6 and Unity 5.

- **Unity:** Lookup unsafe flags and custom defines in .rsp files during project file generation.

- **UI:** Added Visual Studio Tools for Unity **Options** dialog in Visual Studio.

### Bug fixes

- **Unity Project Explorer:**

  - Refresh the Unity Project Explorer after files are moved or renamed from the Visual Studio Solution Explorer.

  - Preserve selections when renaming files in the Unity Project Explorer.

  - Prevent automatic expand and collapse when files are double clicked in the Unity Project Explorer.

  - Ensure that newly selected files are visible in the Unity Project Explorer.

- **Debugger:**

  - Prevent a possible Visual Studio freeze when evaluating expressions in the debugger.

  - Ensure that method invocations happen on the proper domain in the debugger.

- **Unity:**

  - Correct the location of UnityVS.OpenFile with Unity 5.

  - Correct the location of pdb2mdb with Unity 5.

  - Prevent a possible exception during project file generation.

  - Prevent a possible freeze when running Unity on OSX.

  - Handle internal exceptions.

  - Send Unity console logs to the VS error list.

- **Documentation:** Correct documentation generation for the new unity documentation.

- **Project:** Move and rename Unity .meta files when needed, even in folders.

- **Wizards:** Correct the order of MonoBehavior method parameters when generating code.

- **UI:** Support Visual Studio themes for context menu and icons.

## 1.9.8.0 - 2.0 Preview
Released November 12, 2014

### New features

- Support for Visual Studio 2015.

- Code Coloration for Unity shaders in Visual Studio 2015.

- Improved visualization of values when debugging:

  - Better visualization for ArrayLists, Lists, Hashtables and Dictionaries.

  - Show Non-Public members and Static members as categories in watch and local views.

  - Improved display of Unity's SerializedProperty to only evaluate the value field valid for the property.

  - DebuggerDisplayAttribute support for classes and structs.

  - DebuggerTypeProxyAttribute support.

- Make the insertion of MonoBehaviour methods using our wizards to respect the user coding conventions.

- Implement support for Compile Time Text Templates in UnityVS generated projects.

- Implement support for ResX resources in UnityVS generated projects.

- Support opening shaders in Visual Studio from Unity.

### Bug fixes

- Cleanup sockets before starting the game in Unity after Attach and Play was triggered in Visual Studio. This fixes some issues with the stability of the connection between Unity and VS when using Attach and Play.

- Avoid calling methods in Unity's scripting engine debugger interface that are prone to freeze Unity. This fixes the Unity freeze when attaching the debugger.

- Fix displaying of callstacks when no symbols are available.

- Don't register the log callback if we don't have to.

## 1.9.2.0

Released October 9, 2014

### New features

- Improve detection of Unity players.

- When using our file opener, make Unity pass the line number and the file name.

- Default to the online Unity documentation if there's no local documentation.

### Bug fixes

- Fix potential Unity crash when hitting a breakpoint after a domain reload.

- Fix exceptions shown in the Unity console when closing our Configuration or About windows, after a domain reload.

- Fix detection of 64bits Unity running locally.

- Fix filtering of MonoBehaviours per Unity version in wizards.

- Fix bug where all assets were included in the project files if the extension filter was empty.

## 1.9.1.0

Released September 22, 2014

### New features

- Optimize binding breakpoint to source locations.

- Support for overloaded methods in the Expression Evaluation of the debugger.

- Support for boxing primitives and value types in the Expression Evaluation of the debugger.

- Support recreating the C# local variables environment when debugging anonymous methods.

- Delete and rename .meta files when deleting or renaming files from Visual Studio.

### Bug fixes

- Fix handling of Visual Studio themes. Previously, dialogs on black themes could appear empty.

- Fix Unity freeze when connecting the debugger while Unity is recompiling.

- Fix breakpoints when debugging remote editors or players compiled on another system.

- Fix a possible Visual Studio crash when a breakpoint is hit.

- Fix breakpoints binding to avoid breakpoints showing as unloaded.

- Fix handling of variable scope in the debugger to avoid live variables that appear out of scope.

- Fix lookup of static members in the Expression Evaluation of the debugger.

- Fix displaying of types in the Expression Evaluation of the debugger to show static fields and properties.

- Fix generation of solution when the Unity project names includes special characters that Visual Studio forbids (Connect issue #948666).

- Fix the Visual Studio Tools Unity package to immediately stop sending console events after the option has been unchecked (Connect issue #933357).

- Fix detection of references to properly regenerate references to new APIs like UnityEngine.UI in the UnityVS generated projects.

- Fix installer to require that Visual Studio is closed before installation to avoid corrupted installations.

- Fix installer to install the Unity Reference Assemblies as a proper standalone component, shared between all versions of VSTU.

- Fix opening scripts with VSTU in 64 bits versions of Unity.

## 1.9.0.0

Released July 29, 2014

### New features

- In the Attach Unity Debugger window, add the ability to enter a custom IP and port to debug.

- Add configuration option to set Unity to run in the background or not.

- Add configuration option to generate solution and project files or project files only.

- Startup target: choose to Attach to Unity or Attach to Unity and Play.

- Display of multi-dimensional arrays in the debugger.

- Handle new Unity Player debugging ports.

- Handle references to new Unity assemblies like Unity's 4.6 GUI assemblies.

- Deconstructs closures to properly display local variables when debugging.

- Deconstructs generated iterators variables into arguments when debugging.

- Preserve Unity Project Explorer's state after a project reload.

- Add a command to synchronize the Unity Project Explorer with the current document.

### Bug fixes

- Fix conditional breakpoints whose conditions are set before starting the debugger.

- Fix references to UnityEngine to avoid warnings.

- Fix parsing versions for Unity betas.

- Fix issue where variables wouldn't appear in the local variables window when hitting a breakpoint or stepping.

- Fix variables tooltips in Visual Studio 2013.

- Fix generation of the IntelliSense documentation for Unity 4.5.

- Fix the Unity / Visual Studio communication after a domain reload (play/stop in Unity).

- Fix handling of parts of Visual Studio themes.

> [!IMPORTANT]
> C# being the predominant language in the Unity ecosystem - the new Sample Assets are in C#, the Unity documentation will default to C# - we removed our basic support for UnityScript and Boo to better focus on the C# experience. As a result, VSTU solutions are now C# only and are much faster to load.

## 1.8.2.0

Released January 7, 2014

### New features

- Work around an issue in Unity's scripting engine's network layer on Mavericks for remote discovery of editors.

- Handle new ports to discover remote Unity players.

- Reference the UnityEngine assembly specific to the current build target.

- Add setting to filter files to include in generated projects.

- Add setting to disable sending console logs to Visual Studio error list. This is useful if you're using PlayMaker or Console Pro as there could be only one callback registered in Unity to receive console logs.

- Add setting to disable the generation of mdb debug symbols. This is useful if you're generating the mdb yourself.

### Bug fixes

- Fix a regression when files opened in VS from Unity >= 4.2 would lose IntelliSense.

- Fix our VS dialogs to handle custom themes.

- Fix closing the context menu of the UPE.

- Prevent crash in Unity when the version specific generated assembly if out of sync.

## 1.8.1.0

Released November 21, 2013

### New features

- Adjusted the MonoBehaviour wizards with Unity 4.3 APIs.

- MonoBehaviour wizards are filtering Unity APIs depending on the version you use.

- Add a reference to System.Xml.Linq to the projects for Unity > 4.1.

- Prettify our calls to Debug.Log to not include the beginning of the stacktrace in the message.

### Bug fixes

- Fixed a bug where we would interfere with the default handling of JavaScript files in Visual Studio.

- Fixed a white pixel appearing in VS, for real this time.

- Fixed deletion of the UnityVS.VersionSpecific assembly if it's marked as readonly by an SCM.

- Fixed exceptions when creating sockets in the UnityVS package.

- Fixed a crash in Visual Studio when loading stock images from Visual Studio assemblies.

- Fixed a bug in the generation of the UnityVS.VersionSpecific for source builds of Unity.

- Fixed a possible freeze when opening a socket in the Unity package.

- Fixed the handling of Unity project with a dash (-) in their name.

- Fixed opening scripts from Unity to not confuse the ALT+TAB order for Unity 4.2 and above.

## 1.8.0.0

Released September 24, 2013

### New features

- Drastically improved debugger connection speed.

- Automatically handle navigation to file and line on Unity 4.2 and above.

- Conditional breakpoints.

- Project file generator now handles T4 templates.

- Update MonBehavior wizards with new APIs.

- IntelliSense documentation in C# for Unity types.

- Arithmetic and logical expressions evaluation.

- Better discovery of remote editors for the remote debugging preview.

### Bug fixes

- Fixed a bug where we would leak a thread in VS after disconnecting the debugger.

- Fixed a white pixel appearing in VS.

- Fixed the handling of clicks on the status bar icon.

- Fixed the generation of references with assemblies in Plugins folders.

- Fixed creation of sockets from the UnityVS package if there was exceptions.

- Fixed the detection of new versions of UnityVS.

- Fixed the prompt of the license manager when the license expired.

- Fixed a bug that could render the process list empty in the attach debugger to process window of VS.

- Fixed changing values of Booleans in the local view.

## 1.2.2.0

Released July 9, 2013

### Bug fixes

- Handle fully qualified names in expression evaluator.

- Fixed a freeze related to exception handling where the Unity scripting engine is sending us incorrect stackframe data.

- Fixed build process for Web targets.

- Fixed an error that could happen if Visual Studio was started and that a deleted file was in the list of files to open at startup.

- Fixed UnityVS.OpenFile to handle non script files, like compiled shaders.

- We now reference Boo.Lang and UnityScript.Lang from all the C# projects.

- Fixed generation of references in projects if the project has special characters.

- Workaround a VS issue where method calls to disposed projects would trigger multiple NullReferenceException MessageBox.

- Fixed handling of Unity 4.2 Beta assemblies.

## 1.2.1.0

Released April 9, 2013

### Bug fixes

- Fixed local deployment of Unity assemblies for code completion in the event of an IO error (such as read-only files, or files locked by Visual Studio).

- Fixed a regression where opening a script from Unity wouldn't focus the file if it was already opened in Visual Studio.

- Fixed performance issue of the new exception handling.

- Fixed binding of breakpoints in some external DLLs.

## 1.2.0.0

Released March 25, 2013

### New features

- Drastically improved debugger connection speed.

- Optimized Unity Project Explorer for larger projects.

- Honor the Visual Studio settings to break (or not) on handled and unhandled exceptions.

- Honor the Visual Studio setting to call ToString on local variables.

- Add new menu Debug -> Attach Unity debugger, which you can use to debug Unity players.

- Preserve custom projects added to the UnityVS solution upon solution file generation.

- Add new keyboard shortcut CTRL+ALT+M -> CTRL+H to display the Unity documentation for the Unity function or member at the caret position.

- Take compiler response files (rsp) into account when compiling from Visual Studio.

- Deconstruct compiler generated types to show variables when debugging generator methods.

- Simplify the remote debugging by removing the need to configure a shared folder to Unity. Now you just need to have access to your Unity project from Windows.

- Install a custom Unity profile as a standard .NET target profile. This fixes all false positives that ReSharper could show.

- Work around a Unity scripting engine bug, so the debugger won't break on non properly registered threads.

- Rework the file opener to avoid a race condition in VS where it claimed to be able to open files, while crashing on the file open request.

- UnityVS is now asking to refresh the build when VS is building the project, and not on file save anymore.

### Bug fixes

- Fixed our custom .NET profile

- Fixed the theming integration, this fixes our issues with the VS 2012 dark theme.

- Fixed quick behavior shortcut in VS 2012.

- Fixed a stepping issue that could happen when debugging and a non-main thread would hit a breakpoint.

- Fixed UnityScript and Boo completion of type aliases, such as int.

- Fixed exception when writing a new UnityScript or Boo string.

- Fixed exceptions in Unity menus when a solution wasn't loaded.

- Fixed bug UVS-48: typing double quote sometimes produce error and break all function (code completion, syntax highlight etc).

- Fixed bug UVS-46: Duplicated opened script file (UnityScript) when clicking on the Error List of Visual Studio.

- Fixed bug UVS-42: Unity connectivity logo in the status bar doesn't handle mouse events in VS 2012.

- Fixed bug UVS-44: CTRL+SHIFT+Q isn't available in VS 2012 for Quick MonoBehaviours.

- Fixed bug UVS-40: Selected items in the Unity Project Explorer are unreadable when the window is inactive in VS2012 "dark" theme.

- Fixed bug UVS-39: Issue tokenizing escaped strings.

- Fixed bug UVS-35: Invoke ToString on objects when inspecting variables.

- Fixed bug UVS-27: Goto Symbol window inconsistency with "dark" theme in VS2012.

- Fixed bug UVS-11: Locals in coroutines.

## 1.1.0.0 - Beta release
Released March, 9, 2013

## 1.0.13.0
Released January 21, 2013

### Bug fixes

- Fixed a Visual Studio lockup that could happen if the target debuggee is sending invalid thread events. That would typically happen when debugging a remote Unity on OSX.

- Fixed a Visual Studio lockup that could happen if an exception shuts down the debugger.

- Fixed our MonoBehavior helpers when a C# MonoBehavior is in a namespace.

- Fixed debugger tooltips for UnityScript in Visual Studio 2012.

- Fixed project generation when only debug constants are changed from Unity.

- Fixed keyboard navigation in the Unity Project Explorer.

- Fixed UnityScript colorization for escaped strings.

- Fixed our file opener to guess better the project name when used outside of Unity. That's necessary when the user uses a third part file opener in Unity that delegates to UnityVS.

- Fixed handling of long messages sent from Unity to UnityVS. Before that, long messages could crash our messaging part of UnityVS. As a consequence, sometimes UnityVS wouldn't open a file from Unity.

## 1.0.12.0
Released January 3, 2013

### Bug fixes

- Fixed Visual Studio lockup that could happen when Visual Studio was deleting a breakpoint.

- Fixed a bug where some breakpoints wouldn't be hit after Unity recompiled game scripts.

- Fixed the debugger to properly notify Visual Studio when breakpoints were unbound.

- Fixed a registration issue that could prevent the Visual Studio debugger to debug native programs.

- Fixed an exception that could happen when evaluating UnityScript and Boo expressions.

- Fixed a regression where changing the .NET API level in Unity wouldn't trigger an update of the project files.

- Fixed an API glitch where user code couldn't participate in the log callback handler.

## 1.0.11.0
Released November 28, 2012

### New features

- Official support of Unity 4.

- Manipulation of scripts from the Unity Project Explorer.

- Integration in Visual Studio's Navigate To window.

- Parsing of Info console message, so that clicking in the Error List take you to the first stackframe with symbols.

- Add an API to let user participate in the project generation.

- Add an API to let user participate in the LogCallback.

### Bug fixes

- Fixed regression in the background of the Unity Project Explorer in Visual Studio 2012.

- Fixed project generation for users of the full .NET profile.

- Fixed project generation for users of the Web target.

- Fixed project generation to include DEBUG and TRACE compilation symbols as Unity does.

- Fixed crash when using special characters in our Goto Symbol window.

- Fixed crash if we can't inject our icon in Visual Studio's status bar.

## 1.0.10.0
Released October 9, 2012

### Bug Fixes

- Fixed the background of the Unity Project Explorer in Visual Studio 2010.

- Fixed a Visual Studio freeze that could happen if UnityVS tried to attach the debugger to a Unity whose debugger interface previously crashed.

- Fixed a Visual Studio freeze that could happen when a breakpoint was set and an AppDomain reload would occur.

- Fixed how assemblies are retrieved from Unity to avoid locking files and confuse the Unity build process.

## 1.0.9.0

Released October 3, 2012

### Bug fixes

- Fixed project generation when the Unity project includes actual JavaScript assets.

- Fixed error handling in expression evaluation.

- Fixed setting new values to fields of value types.

- Fixed possible side effects when hovering over expressions from the code editor.

- Fixed how types are searched in loaded assemblies for expression evaluation.

- Fixed bug UVS-21: Evaluation of assignment on Unity objects has no effect.

- Fixed bug UVS-21: Invalid pointer when evaluating a method invocation to Unity Math API.

## 1.0.8.0

Released September 26, 2012

### Bug fixes

- Fixed the way our script opener acquired the path to the project to be sure that it's able to open both Visual Studio and the scripts.

- Fixed a bug with breakpoints created while the debugging session was running that could cause Visual Studio to lock up.

- Fixed how UnityVS is registered on Visual Studio 2010.

## 1.0.7.0

Released September 14, 2012

### New features

- Visual Studio 2012 support.

### Bug fixes

- Fixed generation of Editor and Plugins project files to match Unity's behavior.

- Fixed the translation of .pdb symbols on Unity 4.

> [!IMPORTANT]
> Because of the Visual Studio 2012 support, we had to rename a few files and move some other around. The UnityVS package to import Unity is now named either UnityVS 2010 or UnityVS 2012, for respectively Visual Studio 2010 and Visual Studio 2012. This version also requires that the UnityVS project files are regenerated.

## 1.0.6.0 - Internal build
Released September 12, 2012

## 1.0.5.0

Released September 10, 2012

### Bug fixes

- Fixed generation of project files when scripts or shaders had an invalid xml character.

- Fixed detection of Unity instances when Unity was connected to the Asset server. This triggered failures to open files from Unity and the automatic connection of the Visual Studio debugger.

## 1.0.4.0

Released September 5, 2012

### New features

- Automatic conversion of debug symbols in Unity.

    If you have a .NET .dll assembly with its associated .pdb in your Asset folder, re-import the assembly and UnityVS will convert the .pdb into a debug symbols file that Unity's scripting engine understands, and you'll be able to step into your .NET assemblies from UnityVS.

### Bug fixes

- Fixed UnityVS crash while debugging caused by exceptions thrown by methods or properties inside Unity.

## 1.0.3.0

Released September 4, 2012

### New features

- New configuration option to disable the usage of UnityVS to open files from Unity.

### Bug fixes

- Fixed generation of references to UnityEditor for non editor projects.

- Fixed definition of UNITY_EDITOR symbol for non editor projects.

- Fixed random VS crash caused by our custom status bar.

## 1.0.2.0

Released August 30, 2012

### Bug fixes

- Fixed conflict with the PythonTools debugger.

- Fixed references to Mono.Cecil.

- Fixed bug in how scripting assemblies were retrieved from Unity with Unity 4 b7.

## 1.0.1.0

Released August 28, 2012

### New features

- Preview support for Unity 4.0 Beta.

### Bug fixes

- Fixed the inspection of properties throwing exceptions.

- Fixed descending into base objects when inspecting objects.

- Fixed blank dropdown list for the insertion point in the MonoBehavior wizard.

- Fixed completion for dll inside the Asset folder for UnityScript and Boo.

## 1.0.0.0 - Initial release
Released August 22, 2012
