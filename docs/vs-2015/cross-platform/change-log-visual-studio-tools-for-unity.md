---
title: "Change Log (Visual Studio Tools for Unity) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-unity-tools
ms.topic: conceptual
ms.assetid: ea490b7e-fc0d-44b1-858a-a725ce20e396
caps.latest.revision: 14
author: conceptdev
ms.author: crdun
manager: jillfra
---
# Change Log (Visual Studio Tools for Unity)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio Tools for Unity change log.

## 2.3

Released 2016-07-14

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

## 2.2

Released 2016-02-04

### New Features

- **Wizards:**

  - Added smart search in the **Implement MonoBehavior** wizard.

  - Made wizards context aware; for example, NetworkBehavior messages are only available when working with a NetworkBehavior.

  - Added support for NetworkBehavior messages in the wizards.

- **UI:**

  - Added an option to configure the visibility of MonoBehavior messages.

  - Removed Visual Studio property pages that are not relevent to Unity projects.

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

## 2.1

Released 2015-09-08

### New Features

- Support for Unity 5.2

### Bug fixes

- Display menu items on Unity < 4.2

- An error message is no longer displayed when Visual Studio locks XML intellisense files.

- Handle <\<When Changed>> conditional breakpoints when conditional argument is not a boolean value.

- Fixed references to UnityEngine and UnityEditor assemblies for Windows Store apps.

- Fixed error when stepping in the debugger: Unable to step, general exception.

- Fixed hit-count breakpoints in Visual Studio 2015.

## 2.0

Released 2015-07-20

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

  - Fixed an issue where locals would not be displayed in certain stack frames.

  - Fixed inspecting empty arrays.

## 2.0 Preview 2
Released 2015-04-02

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

## 2.0 Preview
Released 2014-11-12

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

- Do not register the log callback if we don't have to.

## 1.9.2

Released 2014-10-09

### New features

- Improve detection of Unity players.

- When using our file opener, make Unity pass the line number as well as the file name.

- Default to the online Unity documentation if there's no local documentation.

### Bug fixes

- Fix potential Unity crash when hitting a breakpoint after a domain reload.

- Fix exceptions shown in the Unity console when closing our Configuration or About windows, after a domain reload.

- Fix detection of 64bits Unity running locally.

- Fix filtering of MonoBehaviours per Unity version in wizards.

- Fix bug where all assets were included in the project files if the extension filter was empty.

## 1.9.1

Released 2014-09-22

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

## 1.9

Released 2014-07-29

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

- Fix issue where variables would not appear in the local variables window when hitting a breakpoint or stepping.

- Fix variables tooltips in Visual Studio 2013.

- Fix generation of the IntelliSense documentation for Unity 4.5.

- Fix the Unity / Visual Studio communication after a domain reload (play/stop in Unity).

- Fix handling of parts of Visual Studio themes.

> [!IMPORTANT]
> C# being the predominant language in the Unity ecosystem - the new Sample Assets are in C#, the Unity documentation will default to C# - we removed our basic support for UnityScript and Boo to better focus on the C# experience. As a result, VSTU solutions are now C# only and are much faster to load.

## 1.8.2

Released 2014-01-07

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

## 1.8.1

Released 2013-11-21

### New features

- Adjusted the MonoBehaviour wizards with Unity 4.3 APIs.

- MonoBehaviour wizards are filtering Unity APIs depending on the version you use.

- Add a reference to System.Xml.Linq to the projects for Unity > 4.1.

- Prettify our calls to Debug.Log to not include the beginning of the stacktrace in the message.

### Bug fixes

- Fixed a bug where we would interfere with the default handling of JavaScript files in Visual Studio.

- Fixed a white pixel appearing in VS, for real this time.

- Fixed deletion of the UnityVS.VersionSpecific assembly if it's marked as readonly by a SCM.

- Fixed exceptions when creating sockets in the UnityVS package.

- Fixed a crash in Visual Studio when loading stock images from Visual Studio assemblies.

- Fixed a bug in the generation of the UnityVS.VersionSpecific for source builds of Unity.

- Fixed a possible freeze when opening a socket in the Unity package.

- Fixed the handling of Unity project with a dash (-) in their name.

- Fixed opening scripts from Unity to not confuse the ALT+TAB order for Unity 4.2 and above.

## 1.8.0

Released 2013-09-24

### New features

- Drastically improved debugger connection speed.

- Automatically handle navigation to file and line on Unity 4.2 and above.

- Conditional breakpoints.

- Project file generator now handles T4 templates.

- Update MonBehavior wizards with new APIs.

- Intellisense documentation in C# for Unity types.

- Arithmetic and logical expressions evaluation.

- Better discovery of remote editors for the remote debugging preview.

### Bug fixes

- Fixed a bug where we would leak a thread in VS after disconnecting the debugger.

- Fixed a white pixel appearing in VS.

- Fixed the handling of clicks on the status bar icon.

- Fixed the generation of references with assemblies in Plugins folders.

- Fixed creation of sockets from the UnityVS package in case of exceptions.

- Fixed the detection of new versions of UnityVS.

- Fixed the prompt of the license manager when the license expired.

- Fixed a bug that could render the process list empty in the attach debugger to process window of VS.

- Fixed changing values of Booleans in the local view.

## 1.2.2

Released 2013-07-09

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

## 1.2.1

Released 2013-04-09

### Bug fixes

- Fixed local deployment of Unity assemblies for code completion in the event of an IO error (such as read-only files, or files locked by Visual Studio).

- Fixed a regression where opening a script from Unity would not focus the file if it was already opened in Visual Studio.

- Fixed performance issue of the new exception handling.

- Fixed binding of breakpoints in some external DLLs.

## 1.2

Released 2013-03-25

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

- Install a custom Unity profile as a standard .net target profile. This fixes all false positives that ReSharper could show.

- Work around a Unity scripting engine bug, so the debugger won't break on non properly registered threads.

- Rework the file opener to avoid a race condition in VS where it claimed to be able to open files, while crashing on the file open request.

- UnityVS is now asking to refresh the build when VS is building the project, and not on file save anymore.

### Bug fixes

- Fixed our custom .net profile

- Fixed the theming integration, this fixes our issues with the VS 2012 dark theme.

- Fixed quick behavior shortcut in VS 2012.

- Fixed a stepping issue that could happen when debugging and a non-main thread would hit a breakpoint.

- Fixed UnityScript and Boo completion of type aliases, such as int.

- Fixed exception when writing a new UnityScript or Boo string.

- Fixed exceptions in Unity menus when a solution was not loaded.

- Fixed bug UVS-48: typing double quote sometimes produce error and break all function (code completion, syntax highlight etc).

- Fixed bug UVS-46: Duplicated opened script file (UnityScript) when clicking on the Error List of Visual Studio.

- Fixed bug UVS-42: Unity connectivity logo in the status bar doesn't handle mouse events in VS 2012.

- Fixed bug UVS-44: CTRL+SHIFT+Q is not available in VS 2012 for Quick MonoBehaviours.

- Fixed bug UVS-40: Selected items in the Unity Project Explorer are unreadable when the window is inactive in VS2012 "dark" theme.

- Fixed bug UVS-39: Issue tokenizing escaped strings.

- Fixed bug UVS-35: Invoke ToString on objects when inspecting variables.

- Fixed bug UVS-27: Goto Symbol window inconsistency with "dark" theme in VS2012.

- Fixed bug UVS-11: Locals in coroutines.

## 1.1 – Beta release
Released 2014-10-09

## 1.0.13
Released 2013-01-21

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

## 1.0.12
Released 2013-01-03

### Bug fixes

- Fixed Visual Studio lockup that could happen when Visual Studio was deleting a breakpoint.

- Fixed a bug where some breakpoints would not be hit after Unity recompiled game scripts.

- Fixed the debugger to properly notify Visual Studio when breakpoints were unbound.

- Fixed a registration issue that could prevent the Visual Studio debugger to debug native programs.

- Fixed an exception that could happen when evaluating UnityScript and Boo expressions.

- Fixed a regression where changing the .net API level in Unity would not trigger an update of the project files.

- Fixed an API glitch where user code could not participate in the log callback handler.

## 1.0.11
Released 2012-11-28

### New features

- Official support of Unity 4.

- Manipulation of scripts from the Unity Project Explorer.

- Integration in Visual Studio's Navigate To window.

- Parsing of Info console message, so that clicking in the Error List take you to the first stackframe with symbols.

- Add an [API](../cross-platform/customize-project-files-created-by-vstu.md) to let user participate in the project generation.

- Add an [API](../cross-platform/share-the-unity-log-callback-with-vstu.md) to let user participate in the LogCallback.

### Bug fixes

- Fixed regression in the background of the Unity Project Explorer in Visual Studio 2012.

- Fixed project generation for users of the full .net profile.

- Fixed project generation for users of the Web target.

- Fixed project generation to include DEBUG and TRACE compilation symbols as Unity does.

- Fixed crash when using special characters in our Goto Symbol window.

- Fixed crash if we can't inject our icon in Visual Studio's status bar.

## 1.0.10
Released 2012-10-09

### Bug Fixes

- Fixed the background of the Unity Project Explorer in Visual Studio 2010.

- Fixed a Visual Studio freeze that could happen if UnityVS tried to attach the debugger to a Unity whose debugger interface previously crashed.

- Fixed a Visual Studio freeze that could happen when a breakpoint was set and a AppDomain reload would occur.

- Fixed how assemblies are retrieved from Unity to avoid locking files and confuse the Unity build process.

## 1.0.9

Released 2012-10-03

### Bug fixes

- Fixed project generation when the Unity project includes actual JavaScript assets.

- Fixed error handling in expression evaluation.

- Fixed setting new values to fields of value types.

- Fixed possible side effects when hovering over expressions from the code editor.

- Fixed how types are searched in loaded assemblies for expression evaluation.

- Fixed bug UVS-21: Evaluation of assignment on Unity objects has no effect.

- Fixed bug UVS-21: Invalid pointer when evaluating a method invocation to Unity Math API.

## 1.0.8

Released 2012-09-26

### Bug fixes

- Fixed the way our script opener acquired the path to the project to be sure that it is able to open both Visual Studio and the scripts.

- Fixed a bug with breakpoints created while the debugging session was running that could cause Visual Studio to lock up.

- Fixed how UnityVS is registered on Visual Studio 2010.

## 1.0.7

Released 2012-09-14

### New features

- Visual Studio 2012 support.

### Bug fixes

- Fixed generation of Editor and Plugins project files to match Unity's behavior.

- Fixed the translation of .pdb symbols on Unity 4.

> [!IMPORTANT]
> Because of the Visual Studio 2012 support, we had to rename a few files and move some other around. The UnityVS package to import Unity is now named either UnityVS 2010 or UnityVS 2012, for respectively Visual Studio 2010 and Visual Studio 2012. This version also requires that the UnityVS project files are regenerated.

## 1.0.6 - Internal build
Released 2012-09-12

## 1.0.5

Released 2012-09-10

### Bug fixes

- Fixed generation of project files when scripts or shaders had an invalid xml character.

- Fixed detection of Unity instances when Unity was connected to the Asset server. This triggered failures to open files from Unity and the automatic connection of the Visual Studio debugger.

## 1.0.4

Released 2012-09-05

### New features

- Automatic conversion of debug symbols in Unity.

    If you have a .NET .dll assembly with its associated .pdb in your Asset folder, simply re-import the assembly and UnityVS will convert the .pdb into a debug symbols file that Unity's scripting engine understands, and you'll be able to step into your .NET assemblies from UnityVS.

### Bug fixes

- Fixed UnityVS crash while debugging caused by exceptions thrown by methods or properties inside Unity.

## 1.0.3

Released 2012-09-04

### New features

- New configuration option to disable the usage of UnityVS to open files from Unity.

### Bug fixes

- Fixed generation of references to UnityEditor for non editor projects.

- Fixed definition of UNITY_EDITOR symbol for non editor projects.

- Fixed random VS crash caused by our custom status bar.

## 1.0.2

Released 2012-08-30

### Bug fixes

- Fixed conflict with the PythonTools debugger.

- Fixed references to Mono.Cecil.

- Fixed bug in how scripting assemblies were retrieved from Unity with Unity 4 b7.

## 1.0.1

Released 2012-08-28

### New features

- Preview support for Unity 4.0 Beta.

### Bug fixes

- Fixed the inspection of properties throwing exceptions.

- Fixed descending into base objects when inspecting objects.

- Fixed blank dropdown list for the insertion point in the MonoBehavior wizard.

- Fixed completion for dll inside the Asset folder for UnityScript and Boo.

## 1.0 – Initial release
Released 2012-08-22
