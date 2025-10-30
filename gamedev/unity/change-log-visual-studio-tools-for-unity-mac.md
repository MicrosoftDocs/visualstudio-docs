---
title: "Change Log (Visual Studio Tools for Unity, Mac)"
description: View the change log for Visual Studio Tools for Unity, Mac. See changes from version 1.0.0.0 through 2.7.0.0 and beyond.
ms.date: "12/13/2022"
ms.subservice: unity-tools
ms.service: visual-studio
ms.topic: article
author: therealjohn
ms.author: johmil
manager: crdun
---
# Change Log (Visual Studio Tools for Unity, Mac)

Visual Studio Tools for Unity change log.

## 17.5.1.0 
Released December 13, 2022

### New Features

- **Debugging:**

  - Added an error message when using incorrect conditions in breakpoints.

- **Integration:**

  - Updated [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) to support all `OnPostprocessAllAssets` overloads.

  - Added [`UNT0031`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0031.md), Asset operations in `LoadAttribute` method.

  - Added [`UNT0032`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0032.md), Inefficient method to set `localPosition` and `localRotation`.

  - Added [`UNT0033`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0033.md), Incorrect message case.

  - Bumped severity to `Warning` for [`UNT0033`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0033.md), [`UNT0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0015.md) and [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostics.

  - Fixed inline ifs incorrectly processed by [`UNT0026`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0026.md).

### Bug fixes

- **Debugging:**

  - Fixed breakpoint binding before explicit host instruction when using type filters.

## 17.5.0.0
Released November 8, 2022

### New Features

- **Integration:**

  - Moved to .NET 7.

## 17.4.3.0
Released October 18, 2022

### Bug fixes

- **Integration:**

  - Fixed UI issues with UPE.

## 17.4.2.0
Released October 11, 2022

### Bug fixes

- **Integration:**

  - Fixed case where async communication completed synchronously.

  - Fixed running the fast build on the Threadpool. 

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

## 17.3.3.0
Released July 26, 2022

### Bug fixes

- **Integration:**

  - Removed legacy editor extensions.

## 17.3.2.0
Released July 19, 2022

### Bug fixes

- **Integration:**

  - Removed Gtk usages.

## 17.3.1.0
Released July 12, 2022

### Bug fixes

- **Integration:**

  - Fixed UI issues with UPE.

## 17.3.0.0
Released June 14, 2022

### New Features

- **Evaluation:**

  - Added support for fixed array buffers.

## 17.1.0.0
Released April 12, 2022

### New Features

- **Debugging:**

  - Bumped debugger protocol to 2.58.

### Bug fixes

- **Debugging:**

  - Fixed stability issues when handling exceptions.

## 17.0.8.0
Released March 30, 2022

### Bug fixes

- **Integration:**

  - Fixed UPE when working with external packages. This requires a new generation process, fully preserving the folder structure and available with the VS Editor package `2.0.15`.

## 17.0.7.0
Released March 15, 2022

### New Features

- **Integration:**

  - Added [`UNT0026`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0026.md), `GetComponent` always allocates, to use `TryGetComponent` instead.

  - Updated [`UNT0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0003.md), usage of non generic `GetComponent`, to work with `TryGetComponent` as well.

  - Updated [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md), `GetComponent` called with non component/interface, to work with `TryGetComponent` as well.

  - Updated [`USP0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0016.md), Initialization detection with nullable reference types, to work with non-Unity objects.

  - Updated [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md), Incorrect message signature, when checking instance or static methods.

### Bug fixes

- **Integration:**

  - Remove Unity's `RuntimePlatform` from the machine name (player announce).

## 17.0.5.0
Released February, 16 2022

### New Features

- **Integration:**

  - Added `CancelInvoke` support to [`UNT0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0016.md) diagnostic (Unsafe way to get the method name).

  - Added `ScriptedImporter` and `AssetPostprocessor` classes to well known Unity message containers.

  - Updated Unity messages to 2020.3.20f1.

## 17.0.4.1
Released January 25, 2022

### Bug fixes

- **Integration:**

  - Correctly handle overridden messages with the opt-in [`UNT0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0021.md) diagnostic (Unity message should be protected).

## 17.0.3.0
Released November 14, 2021

### Bug fixes

- **Integration:**

  - Improved light-build time, by only running suppressors able to handle CS compiler warnings. All other analyzers will run through solution analysis.

## 17.0.2.0
Released October 13, 2021

### Deprecated Features

- **Integration:**

  - We deprecated our legacy project generator for Unity. Going forward please use the latest [Visual Studio Editor package](https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@2.0/changelog/CHANGELOG.html) in your projects (`Unity > Window > Package Manager`) and make sure Visual Studio 2022 is set as your preferred code editor (`Unity > Edit > Preferences > External Tools`).

## 17.0.1.0
Released September 21, 2021

### New Features

- **Integration:**

  - Updated Unity messages to 2020.3.9f1.

## 17.0.0.0 
Released July 14, 2021

### New Features

- **Integration:**

  - Added support for Visual Studio 2022.

  - Added [`UNT0025`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0025.md) diagnostic. Prefer Input.GetKey overloads with KeyCode argument.

  - Added more invalid usages (static and readonly fields) to [`UNT0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0013.md) diagnostic.

### Bug fixes

- **Integration:**

  - Fixed issues with explicit method implementations and [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic.

  - Optimized allocations with [`USP0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0008.md), [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md), [`USP0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0010.md) and [`USP0011`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0011.md) suppressors.

  - Optimized symbol usage with [`UNT0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0002.md), [`UNT0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0003.md), [`UNT0012`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0012.md), [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md) diagnostics.

  - Fixed supported expression detection with [`UNT0024`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0024.md) diagnostic.

## 2.10.2.0
Released June 2, 2021

### New Features

- **Integration:**

  - Added [`UNT0024`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0024.md) diagnostic. Give priority to scalar calculations over vector calculations.

- **Evaluation:**

  - Added support for using portable pdb symbols to properly filter visible locals.

### Bug fixes

- **Integration:**

  - Fixed player announce parsing with recent Unity versions.

## 2.10.1.0
Released May 11, 2021

### Bug fixes

- **Integration:**

  - Fixed stability issues with [`UNT0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0008.md) quickfix.

  - Fixed performance issues with threads.

  - Fixed filtering suppressed warnings and errors in the errorlist.

  - Fixed filtering Unity background processes.

## 2.10.0.0
Released April 13, 2021

### New Features

- **Integration:**

  - Added [`UNT0019`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0019.md) diagnostic. Unnecessary indirection call for `GameObject.gameObject`.

  - Added [`UNT0020`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0020.md) diagnostic. `MenuItem` attribute used on non-static method.

  - Added [`UNT0021`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0021.md) diagnostic. Unity message should be protected (opt-in).

  - Added [`UNT0022`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0022.md) diagnostic. Inefficient method to set position and rotation.

  - Added [`UNT0023`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0023.md) diagnostic. Coalescing assignment on Unity objects.

  - Added [`USP0017`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0017.md) suppressor for `IDE0074`. Unity objects should not use coalescing assignment.

## 2.9.4.0
Released April 6, 2021

### Bug fixes

- **Integration:**

  - Fix issues with test enumeration

## 2.9.3.0
Released March 30, 2021

### Bug fixes

- **Integration:**

  - Fix issues with test runner 

## 2.9.2.0
Released March 2, 2021

### Bug fixes

- **Integration:**

  - Fixed search highlighting in Unity message dialog.

  - Fixed stability issues with Unity project treeview.

- **Debugging:**

  - Fixed handling of conditional breakpoints.

## 2.9.1.0
Released February 9, 2021

### New Features

- **Integration:**

  - Added support for running and debugging Unity tests from the IDE

- **Evaluation:**

  - Added `Active Scene` to locals, showing root game objects.

  - Added `this.gameObject` to locals, given it's widely used in Unity projects.

  - Added `Children` and `Components` groups to all `GameObject` instances, so that you can easily display all the object hierarchy.

  - Added `Scene Path` to all `GameObject` instances, to show the location in the scene.

  - Added support for `JobEntityBatch`/Lambdas when using Entities with source generators.

  - Improved support for displaying large arrays (using index bucketing).

  - Added missing Unity messages for 2019.4 API.

### Bug fixes

- **Integration:**

  - Fixed stability issues with Unity message dialog

  - Fixed various UI issues for non ENU languages.

  - Fixed stability issues with [`UNT0018`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0018.md) diagnostic.

- **Debugging:**

  - Fixed VM disconnection issues when using `Trace` methods.

- **Evaluation:**

  - Fixed filtering of obsolete properties throwing exceptions.

## 2.9.0.0
Released January 20, 2021

### New Features

- **Integration:**

  - Added support for `raytrace shaders`, `UXML` and `USS` files.

  - Updated Unity messages API (for all methods used as coroutines).

  - Updated Android SDK detection.

### Bug fixes

- **Integration:**

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic, giving wrong warnings for Coroutines and `AssetPostprocessor.OnAssignMaterialModel`.

## 2.8.4.0
Released December 15, 2020

### Bug fixes

- **Integration:**

  - Fixed a reliability issue when closing the Unity Event creation wizard.

## 2.8.3.0
Released November 10, 2020

### Bug fixes

- **Debugger:**

  - Fixed attaching to Unity even if there is no VSTU project in the solution.

## 2.8.2.0
Released October 27, 2020

### New Features

- **Integration:**

  - Improved [`UNT0010`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0010.md) diagnostic to apply to everything inheriting from `Component`, not just `MonoBehaviour`.

## 2.8.1.0
Released October 13, 2020

### New Features

- **Evaluation:**

  - Added support for implicit conversion with invocations. Previously the evaluator enforced strict type checking, resulting in `Failed to find a match for method([parameters...])` warning messages.

- **Integration:**

  - Added [`UNT0018`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0018.md) diagnostic. You should not use `System.Reflection` features in performance critical messages like `Update`, `FixedUpdate`, `LateUpdate`, or `OnGUI`.

  - Improved [`USP0003`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0003.md) and [`USP0005`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0005.md) suppressors, with support for all `AssetPostprocessor` static methods.

  - Added [`USP0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0016.md) suppressor for `CS8618`. `C# 8.0` introduces nullable reference types and non-nullable reference types. Initialization detection of types inheriting from `UnityEngine.Object` is not supported and will result in errors.

  - Now using the same player and asmdef project generation mechanism for both Unity 2019.x and 2020.x+.
  
  - Improved user experience when generating Unity messages with a wizard.

### Bug fixes

- **Integration:**

  - Fixed unexpected completion for messages in comments.

## 2.8.0.0 
Released September 14, 2020

### Bug fixes

- **Integration:**

  - Fixed player project generation with Unity 2019.x.

## 2.7.1.0
Released August 5, 2020

### New Features

- **Integration:**

  - Updated Unity messages API to 2019.4.

  - Added [`USP0013`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0013.md) suppressor for `CA1823`. Private fields with the `SerializeField` or `SerializeReference` attributes should not be marked as unused (FxCop).
  
  - Added [`USP0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0014.md) suppressor for `CA1822`. Unity messages should not be flagged as candidates for `static` modifier (FxCop).

  - Added [`USP0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0015.md) suppressor for `CA1801`. Unused parameters should not be removed from Unity messages (FxCop).
  
  - Added `MenuItem` support to the [`USP0009`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0009.md) suppressor.  

### Bug fixes

- **Integration:**

  - Fixed [`USP0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0001.md) and [`USP0002`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0002.md) suppressors not working with extra parentheses or with method arguments.
  
  - Fixed mandatory asset database refresh even when auto-refresh was disabled in the Unity settings.

## 2.7.0.0
Released June 23, 2020

### New Features

- **Integration:**

  - Added support to persist solution folders when Unity is regenerating solution and projects.

  - Added [`UNT0015`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0015.md) diagnostic. Detect incorrect method signature with `InitializeOnLoadMethod` or `RuntimeInitializeOnLoadMethod` attribute.

  - Added [`UNT0016`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0016.md) diagnostic. Using `Invoke`, `InvokeRepeating`, `StartCoroutine` or `StopCoroutine` with a first argument being a string literal is not type safe.

  - Added [`UNT0017`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0017.md) diagnostic. `SetPixels` invocation is slow.

### Bug fixes

- **Debugger:**

  - Fixed creating breakpoints while the game is running on the old Mono runtime (Trying to bind the breakpoint as soon as it's created). 
  
- **Integration:**

  - Do not reset selection when filtering messages in the Unity message wizard.
  
  - Fixed [`USP0004`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0004.md), [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md) and [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) suppressors with the following rules: suppress `IDE0044` (readonly), `IDE0051` (unused), `CS0649` (never assigned) for all fields decorated with SerializeField attribute. Suppress `CS0649` (never assigned) for public fields of all types extending `Unity.Object`.

  - Fixed generic type parameter checking for [`UNT0014`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0014.md).

- **Evaluation:**

  - Fixed equality comparison with enums.

## 2.6.1.0
Released May 19, 2020

### Bug fixes

- **Integration:**

  - Warn if we are unable to create the messaging server on the Unity side.

  - Properly run analyzers during lightweight compilation.

  - Fixed API documentation with Unity Hub installations.
  
  - Fixed debugger visualizer crashes.

## 2.6.0.0
Released April 14, 2020

### New Features

- **Integration:**

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

  - Do not report [`UNT0001`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0001.md) on methods with polymorphic modifiers.

- **Evaluation:**

  - Fixed handling of aliased usings.
  
  - Fixed handling of null values.  

## 2.5.2.0

Released March 23, 2020

### Bug fixes

- **Debugger:**

  - Fixed registration of threads upon attach.

## 2.5.1.0

Released March 3, 2020

### New Features

- **Integration:**

  - Added [`USP0008`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0008.md) suppressor for `IDE0051`. Private methods used with Invoke, InvokeRepeating, StartCoroutine or StopCoroutine should not be marked as unused.

### Bug fixes

- **Integration:**

  - Fixed OnDrawGizmos/OnDrawGizmosSelected documentation.

- **Evaluation:**

  - Fixed lambda argument inspection.

## 2.5.0.1

Released February 19, 2020

### Bug fixes

- **Integration:**

  - Fixed [`UNT0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/UNT0006.md) diagnostic checking for incorrect message signature. When inspecting types with multiple levels of inheritance, this diagnostic could fail with the following message: `warning AD0001: Analyzer 'Microsoft.Unity.Analyzers.MessageSignatureAnalyzer' threw an exception of type 'System.ArgumentException' with message 'An item with the same key has already been added`.

## 2.5.0.0

Released January 22, 2020

### New Features

- **Integration:**

  - Added support for HLSL files.
  
  - Switched to a new folder dialog UI.
  
  - Switched to a new accessible property grid for settings.

  - Added [`USP0006`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0006.md) suppressor for `IDE0051`. Private fields with the `SerializeField` attribute should not be marked as unused.

  - Added [`USP0007`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0007.md) suppressor for `CS0649`. Fields with the `SerializeField` attribute should not be marked as unassigned.  

### Bug fixes

- **Integration:**

  - Fixed project generation (`GenerateTargetFrameworkMonikerAttribute` target was not always located correctly).

- **Evaluation:**

  - Fixed string evaluation (not using ToString() calls)

## 2.4.2.0

Released December 3, 2019

### Bug fixes

- **Integration:**

  - Fixed diagnostics with user-defined interfaces.

  - Fixed quick tooltips with malformed expressions.
  
## 2.4.1.0

Released November 6, 2019

### New Features

- **Integration:**

  - Added support for Unity background processes. (The debugger is able to auto-connect to the main process instead of a child process).

  - Added a quick tooltip for Unity messages, displaying the associated documentation.

### Bug fixes

- **Integration:**

  - Fixed the tag comparison analyzer `UNT0002` with advanced binary and invocation expressions.

### Deprecated Features

- **Integration:**

  - Going forward, Visual Studio Tools for Unity will only support Visual Studio 2017+.

## 2.4.0.0

Released October 15, 2019

### New Features

- **Integration:**

  - Added [`USP0005`](https://github.com/microsoft/Microsoft.Unity.Analyzers/blob/main/doc/USP0005.md) suppressor for `IDE0060` (unused parameter) for all Unity messages.

  - Added a quick tooltip for fields tagged with `TooltipAttribute`. (This will work for a simple get accessor using this field as well).

## 2.3.3.0

Released September 23, 2019

### New Features

- **Integration:**

  - Added a new suppressor for IDE0060, to prevent the IDE from showing a quick-fix to remove unused parameters.
    - `USP0005` for `IDE0060`: Unity messages are invoked by the Unity runtime.

## 2.3.2.0

Released September 16, 2019

### New Features

- **Integration:**

  - We've deepened the understanding that Visual Studio has for Unity projects by adding new diagnostics specific to Unity. We've also made the IDE smarter by suppressing general C# diagnostics that don't apply to Unity projects. For example, the IDE won't show a quick-fix to change an inspector variable to `readonly` which would prevent you from modifying the variable in the Unity Editor.
    - `UNT0001`: Unity messages are called by the runtime even if they are empty, do not declare them to avoid uncesseray processing by the Unity runtime.
    - `UNT0002`: Tag comparison using string equality is slower than the built-in CompareTag method.
    - `UNT0003`: Usage of the generic form of GetComponent is preferred for type safety.
    - `UNT0004`: Update message is frame-rate dependent, and should use Time.deltaTime instead of Time.fixedDeltaTime.
    - `UNT0005`: FixedUpdate message is frame-rate independent, and should use Time.fixedDeltaTime instead of Time.deltaTime.
    - `UNT0006`: An incorrect method signature was detected for this Unity message.
    - `UNT0007`: Unity overrides the null comparison operator for Unity objects which is incompatible with null coalescing.
    - `UNT0008`: Unity overrides the null comparison operator for Unity objects which is incompatible with null propagation.
    - `UNT0009`: When applying the InitializeOnLoad attribute to a class, you need to provide a static constructor. InitializeOnLoad attribute ensures that it will be called as the editor launches.
    - `UNT0010`: MonoBehaviours should only be created using AddComponent(). MonoBehaviour is a component, and needs to be attached to a GameObject.
    - `UNT0011`: ScriptableObject should only be created using CreateInstance(). ScriptableObject needs to be created by the Unity engine to handle Unity message methods.
    - `USP0001` for `IDE0029`: Unity objects should not use null coalescing.
    - `USP0002` for `IDE0031`: Unity objects should not use null propagation.
    - `USP0003` for `IDE0051`: Unity messages are invoked by the Unity runtime.
    - `USP0004` for `IDE0044`: Fields with a SerializeField attribute should not be made readonly.

## 2.3.1.0

Released September 4, 2019

### New Features

- **Evaluation:**

  - Added support for better type display, i.e. `List<object>` instead of `List'1[[System.Object, <corlib...>]]`.

  - Added support for pointer member access, i.e. `p->data->member`.

  - Added support for implicit conversions in array initializers, i.e. `new byte [] {1,2,3,4}`.

  - Added support for hex editor when inspecting byte arrays and strings.

## 2.3.0.0

Released August 13, 2019

### Bug fixes

- **Evaluation:**

  - Fixed stepping issues with exceptions.

  - Fixed evaluation of pseudo identifiers (like $exception).

  - Prevent crash when dereferencing invalid addresses.  

  - Fixed issue with unloaded appdomains.

## 2.2.0.0

Released July 25, 2019

### Bug fixes

- **Evaluation:**

  - Fixed inspection with IntPtr types.

- **Debugger:**

  - Fixed handling of catchpoints and function breakpoints.

## 2.1.3.0

Released July 9, 2019

### New Features

- **Debugger:**

  - Added support for catching subclasses of exceptions.

  - Added support for MDS protocol 2.51.

- **Integration:**

  - Added support for asmdef files.

  - Switch to rename mode when a file is added from a template (to mimic the Unity Editor behavior).

### Bug fixes

- **Integration:**

  - Fixed handling of malformed messages while communicating with Unity Players.

- **Evaluation:**

  - Fixed handling of namespaces in expressions.

## 2.1.2.0

Released July 2, 2019

### Bug fixes

- **Evaluation:**

  - Fixed error reporting with non parseable expressions.

## 2.1.1.0

Released June 27, 2019

### New Features

- **Integration:**

  - Updated MonoBehaviour API to 2019.1.

### Bug fixes

- **Integration:**

  - Fixed Unity Project Explorer performance.

  - Fixed reporting warnings and errors to output when lightweight build is enabled.

  - Fixed lightweight build performance.

## 2.1.0.0

Released June 20, 2019

### New Features

- **Integration:**

  - Disabled the full build for Unity projects, in favor of using the IntelliSense errors and warnings. Indeed Unity creates a Visual Studio solution with class library projects that represent what Unity is doing internally. That being said, the result of the build in Visual Studio is never used or picked up by Unity as their compilation pipeline is closed. Building in Visual Studio is just consuming resources for nothing. If you need a full build because you have tools or a setup that depends on it, you can disable this optimization (Settings/Tools for Unity/Disable the full build of projects).
  
  - Added support for Unity packages in the UPE. Only Referenced packages (using manifest.json in the `Packages` folder) and Local packages (embedded in the `Packages` folder) are visible.

## 2.0.2.1

Released May 30, 2019

### New Features

- **Integration:**

  - Added custom icon for Unity execution targets.

## 2.0.2.0

Released April 2, 2019

### New Features

- **Integration:**

  - Added support for automatically refreshing Unity's asset database on save. This is enabled by default and will trigger a recompilation on the Unity side when saving a script in Visual Studio. You can disable this feature in Tools\Options\Tools for Unity\Refresh Unity's AssetDatabase on save.

  - Added support for setting preferred unity installation for offline documentation.

  - Added context menu for the new Editor.

### Bug fixes

- **Debugger:**

  - Fixed assembly filtering and frame inspection with empty frames.

## 2.0.1.1
 
 Released March 26, 2019

### Bug fixes

- **Integration:**

  - Temporarily Make Mono the default and only usable debugger for this very specific release.

## 2.0.0.6

Released March 26, 2019

### New Features

- **Integration:**

  - Added support for "Attach to Unity and Play".

## 2.0.0.5

Released March 20, 2019

### New Features

- **Project Generation:**

  - Preserve external properties when processing the solution file.
  
- **Evaluation:**

  - Added support for alias-qualified names (only the global namespace for now). So the expression evaluator is now accepting types using the form global::namespace.type.

  - Added support for `pointer[index]` form, which is semantically identical to pointer dereference `*(pointer+index)` form.

## 2.0.0.4

Released March 5, 2019

### New Features

- **Integration:**

  - Updated the `ScriptableObject` API.

### Bug fixes

- **Integration:**

  - Removed namespaces from templates.

## 2.0.0.3
 
 Released March 5, 2019

### New Features

- **Project Generation:**

  - Public and serialized fields will no longer cause warnings. We've auto-suppressed the `CS0649` and `IDE0051` compiler warnings in Unity projects that created these messages.

- **Integration:**

  - Prompt to attach to a specific instance if more that one Unity process is running.

- **Evaluation:**

  - Added support for local functions.

### Bug fixes

- **Debugger:**

  - Fixed reading custom attribute on named arguments when using old protocol versions.

## 2.0.0.2

Released February 4, 2019

### New Features

- **Integration:**

  - Updated the MonoBehaviour API.

### Bug fixes

- **Debugger:**

  - Fixed setting primitive values in the debugger.

## 2.0.0.1

Released December 4, 2018

### Bug fixes

- **Integration:**

  - Fixed installation package self-containment.

## 2.0.0.0
 Released December 4, 2018

### New Features

- **Debugger:**

  - Replaced the Unity debugger on the Mac with the same core Unity debugger from Windows.

  - Replaced NRefactory in favor of Roslyn for expression evaluation.

  - Added support for pointers: dereference, casting and pointer arithmetic (both Unity 2018.2+ and the new runtime are required for this).

  - Added support for array pointer view (like in C++). Take a pointer expression then append a comma and the number of elements you want to see.

  - Added support for async constructs.

  - Added support for pseudo variables (exception and object identifiers).

### Bug fixes

- **Debugger:**

  - Fixed expression evaluation with malformed or unsupported expressions.

## 1.7.0.0

Released November 13, 2018

### New Features

- **Debugger:**

  - Added more client information (IP, machine name) on the attach dialog.

### Bug fixes

- **Debugger:**

  - Fixed a deadlock in the library used to communicate with Unity’s debugger engine, making Visual Studio or Unity freeze, especially when hitting ‘Attach to Unity’ or restarting game.

- **Integration:**

  - Fixed Unity plugin activation when another default editor was selected.

  - Fixed Unity file template creation.

## 1.6.0.2

Released July 24, 2018

### Bug fixes

- **Integration:**

  - Rolled back the workaround for a Unity performance bug that has been fixed by Unity.

## 1.6.0.1

Released July 10, 2018

### Bug fixes

- **Integration:**

  - Fixed Shader code coloration support.

## 1.6.0.0

Released June 26, 2018

### Bug fixes

- **Wizards:**

  - Fixed typo with OnApplicationFocus message.

- **Project Generation:**

  - Transient workaround for a Unity performance bug: cache MonoIslands when generating projects.

  - Do not convert portable pdb to mdb anymore when using the new Unity runtime.

## 1.5.0.2

Released April 18, 2018

### New Features

- **Integration:**

  - Added support for basic Shader code completion.

  - Added support for toggling comments in Shader files.

## 1.5.0.1

Released March 28, 2018

### New Features

- **Integration:**

  - Added support for extra templates in the Unity Project Explorer.

## 1.5.0.0

Released March 21, 2018

### New Features

- **Integration:**

  - Added support for detecting and attaching to Android players connected through USB.

## 1.4.0.3

Released March 5, 2018

### New Features

- **Project Generation:**

  - Added support for the new project generator in Unity 2018.1.

- **Integration:**

  - Added option panel for dedicated settings.

## 1.4.0.2

Released January 24, 2018

### Bug fixes

- **Project Generation:**

  - Fixed Mono version detection.

- **Integration:**

  - Fixed timing issues with 2018.1 and plugin activation.

  - Fixed notifications when detecting a new player.

## 1.4.0.1

Released January 23, 2018

### Bug fixes

- **Integration:**

  - Fixed Expand/Collapse folders on double-click

## 1.4.0.0

Released December 13, 2017

### New Features

- **Project Generation:**

  - Added support for .NET Standard.

### Bug fixes

- **Integration:**

  - Fixed automatic pdb to mdb debug symbol conversion.

## 1.3.0.1

Released December 12, 2017

### Bug fixes

- **Integration:**

  - Fixed indirect call to EditorPrefs.GetBool impacting the inspector while trying to change array size.

- **Wizards:**

  - Refresh roslyn context before inserting method.

## 1.3.0.0

Released November 20, 2017

### New Features

- **Wizards:**

  - Added "Implement Unity message" wizard.

  - Added support for the new completion API in VS for Mac 7.4.

## 1.2.0.0

Released October 23, 2017

### New Features

- **Debugger:**

  - Added support for portable debug symbol files.

### Bug fixes

- **Project Generation:**

  - Fixed extra .dll extension wrongly added to the assembly filename.

  - Do not force the AllowAttachedDebuggingOfEditor Unity flag as the default is now 'true'.

## 1.1.0.3

Released October 23, 2017

### New Features

- **Project Generation:**

  - Added support for .NET 4.6 profile.

## 1.1.0.2

Released August 8, 2017

### New Features

- **Debugger:**

  - Start the attach to process dialog if not sure which Unity to attach to.

- **Project Generation:**

  - Always enable unsafe compilation switch when Unity 5.6 is used.

## 1.1.0.1

Released July 20, 2017

### New Features

- **Integration:**

  - Added support for localized resources.

## 1.1.0.0

Released July 12, 2017

### New Features

- **Integration:**

  - Added support for attaching to players and editors through the Attach to process window.

- **Project Generation:**

  - Fixed assembly name references with mcs.rsp files.

  - Added support for assembly.json compilation units.

  - Fixed defines with API levels.

### Bug fixes

- **Integration:**

  - Fixed shader error message when compiling.

## 1.0.0.1

Released May 4, 2017

### Bug fixes

- **Integration:**

  - Fixed active document tracking with hybrid and regular projects.

## 1.0.0.0

Released May 3, 2017
