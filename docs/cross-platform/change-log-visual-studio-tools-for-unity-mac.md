---
title: "Change Log (Visual Studio Tools for Unity, Mac) | Microsoft Docs"
ms.custom: ""
ms.date: "12/02/2019"
ms.technology: vs-unity-tools
ms.topic: "conceptual"
ms.assetid: 33a6ac54-d997-4308-b5a0-af7387460849
author: therealjohn
ms.author: johmil
manager: crdun
ms.workload:
  - "unity"
---
# Change Log (Visual Studio Tools for Unity, Mac)

Visual Studio Tools for Unity change log.

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

  - Added a suppressor for `IDE0060` (unused parameter) for all Unity messages.

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
