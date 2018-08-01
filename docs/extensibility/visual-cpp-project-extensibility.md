---
title: "Visual C++ project extensibility"
ms.custom: ""
ms.date: "08/01/2018"
ms.technology: vs-ide-mobile
ms.topic: "conceptual"
dev_langs: 
  - "C++"
author: "corob-msft"
ms.author: "corob"
manager: douge
ms.workload: ["vssdk"]
---
# Visual Studio C++ project extensibility and toolset integration

The C++ workloads in Visual Studio all use the extensible *VC Project* system, a project build system that's integrated into the Visual Studio IDE, and also works on the command line. The VC Project system is designed to allow you to easily plug in new toolsets and build architectures. Currently, all C++ projects use the same base VC Project system, whether they use MSVC, Intel, gcc, or Clang toolsets, or whether they target Windows, Linux, Android, or iOS platforms. Visual Studio supplies toolset-specific components to modify project behavior. You can follow the same patterns to extend VC Project to invoke new toolsets on new platforms inside Visual Studio or at the command line.

## What VC Project does

The VC Project system sits between a .vcxproj project file on disk and various Visual Studio features, such as Solution Explorer, designers, the debugger, language services, and build tools. You can create project property pages to control all aspects of your project. Almost all interaction that occurs between the files contained in a project file, the IDE, and the toolset, happens through the VC Project system.

Many technologies come together to make up the VC Project system:

- The Microsoft Build System ([MSBuild](../msbuild/msbuild.md)) provides the build engine and the extensible XML-based format for project files. You should be familiar with basic [MSBuild concepts](../msbuild/msbuild-concepts.md) and with how [MSBuild for Visual C++](/cpp/build/msbuild-visual-cpp-overview) works in order to extend the VC Project system.

- The Visual Studio Common Project System ([CPS](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/Index.md)) provides the building blocks for the project system including the project tree, build and debugger coordination, and Visual Studio integration. For more information about how it's used in the VC Project system, see [VC Project extensibility in the Visual Studio IDE](#vc-project-extensibility-in-the-visual-studio-ide).

- The Managed Extensibility Framework ([MEF](/dotnet/framework/mef/)) provides the extension APIs that are used by CPS and VC Project. For an overview of how MEF is used by CPS, see [MEF](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/overview/mef.md).

You can customize the existing VC Project build system to add build steps or new file types. For more information, see [MSBuild (Visual C++) Overview](/cpp/build/msbuild-visual-cpp-overview) and [Working with project properties](/cpp/ide/working-with-project-properties).

## C++ MSBuild targets extensibility

The MSBuild engine reads .vcxproj files to determine all of the items, targets, and properties needed to build a particular configuration of your project. At a minimum, MSBuild expects .vcxproj files to have a small set of groups and imports, as in this example:

```xml
<Project DefaultTargets="Build" ToolsVersion="15.0" xmlns="<http://schemas.microsoft.com/developer/msbuild/2003>">
  <ItemGroup Label="ProjectConfigurations">
    <ProjectConfiguration Include="Debug|Win32">  
      <Configuration>Debug</Configuration>  
      <Platform>Win32</Platform>  
    </ProjectConfiguration>
  </ItemGroup>
  <PropertyGroup Label="Globals">
    <ApplicationType>Windows Store</ApplicationType>  
    <ApplicationTypeRevision>10.0</ApplicationTypeRevision>
  </PropertyGroup>
  <Import Project="$(VCTargetsPath)\Microsoft.Cpp.Default.props" />
  <PropertyGroup Label="Configuration">
    <PlatformToolset>v141</PlatformToolset>
  </PropertyGroup>
  <Import Project="$(VCTargetsPath)\Microsoft.Cpp.props" />
  <!-- ... -->
  <Import Project="$(VCTargetsPath)\Microsoft.Cpp.targets" />
</Project>
```

Most of the properties, targets, and toolsets a project file depends on are specific to the platforms and architectures used. The VC Project system supplies a large set of Microsoft C++ *props* and *targets* files, files with a .props or .targets extension, that control how the MSBuild system creates a product. At the top level, these included files don't define anything themselves, but import other files depending on the `$(ApplicationType)`, `$(ApplicationTypeRevision)`, `$(Platform)` and `$(PlatformToolset)` properties values. These properties match folder names under a common root directory, stored in the `$(VCTargetsPath)` property.

In a Developer command prompt window, the Visual Studio installation directory is recorded in the **VSINSTALLDIR** environment variable. In Visual Studio 2017, the `$(VSInstallDir)` property holds the installation directory. A typical location is C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\. the `$(VCTargetsPath)` folder is found underneath the Visual Studio installation directory, in \\Common7\\IDE\\VC\\VCTargets.

Other important directories include the \\MSBuild subdirectory of the Visual Studio installation, which is stored in the `$(MSBuildExtensionsPath)` property. This folder in turn has a versioned subfolder, stored in the `$(MSBuildToolsVersion)` property, which holds the Microsoft.Common.props file used by many other files.

The `$(VCTargetsPath)` folder is the root of a hierarchy of subfolders for each combination of toolset and application type. The hierarchy is shown here in plain text for literal folder names and as `$(PropertyName)` for folder names that depend on the platform, app type, version, or toolset:

> `$(VCTargetsPath)`\\  
> &nbsp;&nbsp;&nbsp;&nbsp;Platforms\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(PlatformFolder)`\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PlatformToolsets\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(PlatformToolset)`  
> &nbsp;&nbsp;&nbsp;&nbsp;Application Type\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(ApplicationType)`\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(ApplicationTypeRevision)`\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Platforms\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PlatformToolsets\\  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(PlatformToolset)`  

The Platforms folder at the top level contains the folders and files used for Windows Desktop applications. All other application types have their files under the Application Type folder, in an application-type-specific folder whose name is stored in the `$(ApplicationType)` property. This folder has versioned subfolders, and the active version name is stored in the `$(ApplicationTypeRevision)` property. Each versioned folder has a Platforms subfolder.

Within each Platforms folder, you'll find platform-specific folders, whose names are stored in the `$(_PlatformFolder)` property. These folders in turn have a PlatformToolsets folder, which contains one or more folders for supported toolset versions, stored in the `$(PlatformToolset)` property. This folder has the app type- and toolset-specific Toolset.props and Toolset.targets files.

As an example, the folder for Windows Store apps for Windows 10 on Win32 that use the Visual Studio 2017 (v141) platform toolset is:

> `$(VCTargetsPath)`\\Application Type\\Windows Store\\10.0\\Platforms\\Win32\\PlatformToolsets\\v141

Additional folders, namely the ImportBefore, ImportAfter, and PlatformUpgrade folders, may be found in some Platform folders. These folders also have corresponding property names.

For non-Windows Desktop apps, the tree of imports for Microsoft C++ props and targets files looks like:

> `$(VCTargetsPath)`\\Microsoft.Cpp.Default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(MSBuildExtensionsPath)`\\`$(MSBuildToolsVersion)`\\Microsoft.Common.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\ImportBefore\\Default\\\*.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\Application Type\\`$(ApplicationType)`\\Default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\Application Type\\`$(ApplicationType)`\\`$(ApplicationTypeRevision)`\\Default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\Application Type\\`$(ApplicationType)`\\`$(ApplicationTypeRevision)`\\Platforms\\`$(Platform)`\\Platform.default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\ImportAfter\\Default\\\*.props  

or for Windows Desktop apps,

> `$(VCTargetsPath)`\\Microsoft.Cpp.Default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(MSBuildExtensionsPath)`\\`$(MSBuildToolsVersion)`\\Microsoft.Common.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\ImportBefore\\Default\\\*.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\Platforms\\`$(Platform)`\\Platform.default.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\ImportAfter\\Default\\\*.props  

The `$(_PlatformFolder)` property holds the platform folder location. The props files are imported in this order:

> `$(VCTargetsPath)`\\Microsoft.Cpp.props  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\\Platform.props  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\\Microsoft.Cpp.Platform.props  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\\ImportBefore\\\*.props  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\\PlatformToolsets\\`$(PlatformToolset)`\\Toolset.props  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\\ImportAfter\\\*.props  

The targets files are imported in this order:

> `$(VCTargetsPath)`\Microsoft.Cpp.targets  
> &nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\Microsoft.Cpp.Current.targets  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\Platform.targets  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(VCTargetsPath)`\Microsoft.Cpp.Platform.targets  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\ImportBefore\*.targets  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\PlatformToolsets\`$(PlatformToolset)`\Toolset.target  
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;`$(_PlatformFolder)`\ImportAfter \*.targets  

### Where to add toolset and platform files

To add a new "MyToolset" `$(PlatformToolset)` folder for the Win32 platform, you must create a `$(VCTargetsPath)`\\Platforms\\Win32\\PlatformToolsets\\MyToolset folder, and create Toolset.props and Toolset.targets files in it. Create similar folders and Toolset.props and Toolset.targets files in each platform folder this toolset supports.

To add a new "MyPlatform" `$(Platform)` folder, create a `$(VCTargetsPath)`\\Platforms\\MyPlatform folder, and create Platform.props and Platform.targets files in it.

Follow a similar process for `$(ApplicationType)` and `$(ApplicationTypeRevision)` folders. The `$(ApplicationTypeRevision)` folder name must be a valid version string, of the form *major*.*minor*\[.*build*\[.*revision*\]\], not an arbitrary string.

If you need to define some default properties for your toolset, you can add files to the appropriate ImportBefore and ImportAfter folders.

### Toolset props and targets files

Your toolset props and targets files have full control over what happens during a build when this toolset is used. They can also control the content in the **Property Pages** dialog, what debuggers are available, and some other aspects of project behavior.

### Toolset build

The VC Project system has split MSBuild constructs into props and targets files. For a given configuration, the props file provides default values for all build properties, and allows each project to override any of them before they are used in targets files. Although there are no formal restrictions or enforcement of what goes in a props file, your Toolset.props file isn't expected to contain any targets, just properties.

Toolset targets files define build processes, and use the properties defined in props and .vcxproj files.

Usually you don't want your toolset to override the whole build process, although it can. You just want to modify or add some build steps, or to use different build tools. To accomplish this goal, there are a number of common props and targets files your toolset can import. These files are the most useful ones to use as imports or as examples:

- `$(VCTargetsPath)`\\Microsoft.Cpp.WindowsSDK.props  
   This file determines the Windows SDK location, and defines some important properties for apps targeting Windows.

- `$(VCTargetsPath)`\\Microsoft.Cpp.Common.props  
   Sets defaults for toolsets that use the Microsoft compilers and target Windows.

- `$(VCTargetsPath)`\\Microsoft.CppCommon.targets  
   This file defines the main parts of the native build process, and also imports these additional targets files:

   - `$(VCTargetsPath)`\\Microsoft.CppBuild.targets  
   - `$(VCTargetsPath)`\\Microsoft.BuildSteps.targets  
   - `$(MSBuildToolsPath)`\\Microsoft.Common.Targets  

   Most user-defined toolsets should use this file, as it defines the C++ build process.

### MSBuild C++ build process

The C++ build follows three major steps, referenced by the `BuildSteps` property group:

- `BuildGenerateSources`

- `BuildCompile`

- `BuildLink`

Each step can be executed separately, so targets running in one step can't rely on the item groups and properties defined in the targets that run as a part of a different step. This division allows certain build performance optimizations, and although it's not used by default, you're still encouraged to honor this separation.

The order of the targets inside each step is controlled by the usual MSBuild ordering, that is, the `DependsOn`, `BeforeTargets` and `AfterTargets` attributes. However, to give you more control, there are a number of properties you can add to a new target:

```xml
<Target
  Name="_BuildGenerateSourcesAction"
  DependsOnTargets="$(CommonBuildOnlyTargets);$(BeforeBuildGenerateSourcesTargets);$(BuildGenerateSourcesTargets);$(AfterBuildGenerateSourcesTargets)" />

<Target
  Name="\_BuildCompileAction"
  DependsOnTargets="$(CommonBuildOnlyTargets);$(BeforeBuildCompileTargets);$(BuildCompileTargets);$(AfterBuildCompileTargets)" />

<Target
  Name="\_BuildLinkAction"
  DependsOnTargets="$(CommonBuildOnlyTargets);$(BeforeBuildLinkTargets);$(BuildLinkTargets);$(AfterBuildLinkTargets)" />
```

See the Microsoft.CppBuild.targets file for examples of the targets that are included in each step.

Here is an example that creates the compilation targets, compiles, generates and compiles resources, and then builds .lib files:

```xml
<BuildCompileTargets Condition="'$(ConfigurationType)'\!='Utility'">
  $(BuildCompileTargets);
  _ClCompile;
  _ResGen;
  _ResourceCompile;
  $(BuildLibTargets);
</BuildCompileTargets>
```

Targets that produce .lib files run as part of the `BuildCompile` step.

If you look at the targets, such as `_ClCompile`, they don't do anything directly by themselves, but instead depend on other targets:

```xml
<Target Name="_ClCompile"
  DependsOnTargets="$(BeforeClCompileTargets);$(ComputeCompileInputsTargets);MakeDirsForCl;ClCompile;$(AfterClCompileTargets)" >
</Target>
```

`ClCompile` and other build tool-specific targets are defined as empty targets in Microsoft.CppBuild.targets. `ClCompile` is used here as an example, but the definition is similar for other build tools, LINK, LIB, MIDL, RC, and so on.

```xml
<Target Name="ClCompile"/>
```

Since this target is empty, by default, no action is performed.

The toolset targets can override the `ClCompile` target, that is, they can contain another `ClCompile` definition after importing Microsoft.CppBuild.targets:

```xml
<Target Name="ClCompile"
  Condition="'@(ClCompile)' != ''"
  DependsOnTargets="SelectClCompile">
  <!-- call some MSBuild tasks -->
</Target>
```

Despite its name, which was created before Visual Studio implemented cross-platform support, the `ClCompile` target does not have to call CL.exe. It can also call Clang, gcc, or other compilers by using appropriate MSBuild tasks.

In this case, the `ClCompile` target does not have any dependencies except the `SelectClCompile` target. This dependency is required for the single file compile command to work in the IDE.

If you want to add a new target to the build process for your toolset, you can add it to any of the properties used in `DependsOnTargets`, or use `AfterTargets` or `BeforeTargets` attributes.

The targets included in `$(ComputeCompileInputsTargets)` are also used by the design-time build to get IntelliSense information. For more information, see the [Design-time targets for IntelliSense information](#design-time-targets-for-intellisense-information) section.

### MSBuild tasks

To invoke an actual build tool, the target needs to call an MSBuild task. There is a basic [Exec task](../msbuild/exec-task.md) that allows you to specify a command line to run. However, build tools usually have many options, inputs. and outputs to track for incremental builds, so it makes more sense to have special tasks for them. For instance, the `CL` task translates MSBuild properties into CL.exe switches, writes them into a response file, and calls CL.exe. It also tracks all input and output files for later incremental builds. For more information, see [incremental build and up-to-date check](#incremental-build-and-up-to-date-check).

The Microsoft.Cpp.Common.Tasks.dll implements these tasks:

- `BSCMake`

- `CL`

- `ClangCompile` (clang-gcc switches)

- `LIB`

- `LINK`

- `MIDL`

- `Mt`

- `RC`

- `XDCMake`

- `CustomBuild` (similar to Exec but with inputs/outputs tracking)

- `SetEnv`

If you have a tool that performs the same action, and that has similar command-line switches (as clang-cl and CL do), you can use the same task for both of them.

If you need to create a new task for a build tool, you can choose from the following options:

1. If you use this task rarely, or if a few seconds don't matter for your build, you can use MSBuild 'inline' tasks:

   - Xaml task (a custom build rule)

     For an example of a Xaml task declaration, see `$(VCTargetsPath)`\\BuildCustomizations\\masm.xml, and for an example of usage, see `$(VCTargetsPath)`\\BuildCustomizations\\masm.targets.

   - [Code task](../msbuild/msbuild-inline-tasks.md)

1. If you want better task performance or just need more complex functionality, use the regular MSBuild [task writing](../msbuild/task-writing.md) process.

   If not all inputs and outputs of the tool are listed on the tool command line, as in the `CL`, `MIDL`, and `RC` cases, and if you want automatic input and output file tracking and tlog file creation, derive your task from `TrackedVCToolTask`.

### Incremental build and up-to-date check

MSBuild targets have `Inputs` and `Outputs` attributes. If you specify them, MSBuild calls the target only if any of the inputs has a newer timestamp than all outputs. However, source files often include or import other files, and build tools produce different outputs depending on the tool options. As a result, it is hard to specify all possible inputs and outputs in MSBuild targets.

To manage this problem, a different technique supports incremental builds. During the build, most targets don't specify inputs and outputs, and therefore always run. The tasks called by targets write information about all inputs and outputs into *tlog* files that have a .tlog extension. The tlog files are used by later builds to check what has changed and needs to be rebuilt, and what is up-to-date.

To determine all the inputs and outputs, VC Project tasks use tracker.exe and the [FileTracker](/dotnet/api/microsoft.build.utilities.filetracker) class provided by MSBuild.

Microsoft.Build.CPPTasks.Common.dll defines the `TrackedVCToolTask` public abstract base class. Most VC Project tasks are derived from this class.

## Use of tlog files

There are three types of tlog files: *read*, *write*, and *command-line*. Read and write tlog files are used by incremental builds and by the up-to-date check in the IDE. Command-line tlog files are only used in incremental builds.

MSBuild provides these helper classes to read and write tlog files:

- [CanonicalTrackedInputFiles](/dotnet/api/microsoft.build.utilities.canonicaltrackedinputfiles)

- [CanonicalTrackedOutputFiles](/dotnet/api/microsoft.build.utilities.canonicaltrackedoutputfiles)

The [FlatTrackingData](/dotnet/api/microsoft.build.utilities.flattrackingdata) class can be used to access both read and write tlog files and identify inputs that are newer than outputs, or if an output is missing. It's used in the up-to-date check.

Command-line tlog files contain information about command lines used in the build. They are only used for incremental builds, not up-to-date checks, so the internal format is determined by the MSBuild task that produces them.

If tlog files are created by a task, it's best to use these helper classes to create them. However, because the default VC Project up-to-date check now relies solely on tlog files, sometimes it's more convenient to produce them in a target without a task. You can write them by using the `WriteLinesToFile` task. For an example, see the `_WriteMasmTlogs` target in `$(VCTargetsPath)`\\BuildCustomizations\\masm.targets.

### Read tlog format

*Read* tlog files (\*.read.\*.tlog) contain information about source files, or *sources*, and the files they require, their *dependencies*.

A caret (`^`) at the beginning of a line indicates one or more sources. Multiple sources that share the same dependencies are separated by a vertical bar (`|`).

Dependency files are listed after the sources, each on its own line. All file names are full paths.

For example, assume your project sources are found in F:\test\ConsoleApplication1\ConsoleApplication1\. If your source file, Class1.cpp, has these includes,

```cpp
#include "stdafx.h" //precompiled header
#include "Class1.h"
```

then the CL.read.1.tlog contains the source file followed by its two dependencies:

```tlog
^F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\CLASS1.CPP
F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\DEBUG\CONSOLEAPPLICATION1.PCH
F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\CLASS1.H
```

It's not required to have file names in upper case, but it's a convenience for some tools.

### Write tlog format

*Write* tlog (\*.write.\*.tlog) files connect sources and outputs.

A caret (`^`) at the beginning of the line indicates sources. Multiple source files should be separated by a vertical bar ('|').

The output files built from the sources should be listed after the sources, each on its own line. All file names must be full paths.

For example, for a simple ConsoleApplication project that has an additional source file Class1.cpp, link.write.1.tlog may have:

```tlog
^F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\DEBUG\CLASS1.OBJ|F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\DEBUG\CONSOLEAPPLICATION1.OBJ|F:\TEST\CONSOLEAPPLICATION1\CONSOLEAPPLICATION1\DEBUG\STDAFX.OBJ
F:\TEST\CONSOLEAPPLICATION1\DEBUG\CONSOLEAPPLICATION1.ILK
F:\TEST\CONSOLEAPPLICATION1\DEBUG\CONSOLEAPPLICATION1.EXE
F:\TEST\CONSOLEAPPLICATION1\DEBUG\CONSOLEAPPLICATION1.PDB
```

### Design-time build

In the IDE, projects use a set of MSBuild targets to get additional information that isn't available from the MSBuild evaluation model [Project class](/dotnet/api/microsoft.build.evaluation.project). They also use targets to generate output files when their source files change. Some of these targets are only used in design-time builds, but many of them are used in both regular builds and design-time builds.

For general information about design-time builds, see the CPS documentation for [Design-time builds](https://github.com/dotnet/project-system/blob/master/docs/design-time-builds.md).

The `CompileDesignTime` and `Compile` targets mentioned in the design-time builds documentation never run for VC projects. VC projects use different design-time targets to get IntelliSense information.

### Design-time targets for IntelliSense information

The design-time targets used in VC projects are defined in `$(VCTargetsPath)`\\Microsoft.Cpp.DesignTime.targets

The `GetClCommandLines` target collects compile options for IntelliSense:

```xml
<Target
  Name="GetClCommandLines"
  Returns="@(ClCommandLines)"
  DependsOnTargets="$(DesignTimeBuildInitTargets);$(ComputeCompileInputsTargets)">
```

`DesignTimeBuildInitTargets` – design-time only targets, required for design-time build initialization. Among other things, these targets disable some of the regular build functionality to improve performance.

`ComputeCompileInputsTargets` – a set of targets that modifies compiler options and items. These targets run in both design-time and regular builds.

The target calls the `CLCommandLine` task to create the command line to use for IntelliSense. Again, despite its name, it can handle not only CL options, but Clang and gcc options as well. The type of the compiler switches is controlled by the `ClangMode` property.

Currently, the command line produced by the `CLCommandLine` task always uses CL switches (even in Clang mode) because they're easier for the IntelliSense engine to parse.

If you're adding a target that runs before compilation, whether regular or design-time, make sure it does not break design-time builds or affect performance. The simplest way to test your target is to open a Developer command prompt and run this command:

> msbuild /p:SolutionDir=*solution-directory-with-trailing-backslash*;Configuration=Debug;Platform=Win32;BuildingInsideVisualStudio=true;DesignTimebuild=true /t:\_PerfIntellisenseInfo /v:d /fl /fileloggerparameters:PerformanceSummary \*.vcxproj`

This command produces a detailed build log, msbuild.log, that has a performance summary for the targets and tasks at the end.

Make sure to use `Condition ="'$(DesignTimeBuild)' != 'true'"` in all operations that only make sense for regular builds and not for design-time builds.

### Design-time targets that generate sources

*This feature is disabled by default for Desktop native projects and is not currently supported on cached projects*.

If `GeneratorTarget` metadata is defined for a project item, the target is run automatically both when the project is loaded and when the source file is changed.

For instance, to automatically generate .cpp or .h files from .xaml files, the `$(VSInstallDir)`\\MSBuild\\Microsoft\\WindowsXaml\\v15.0\\\*\\Microsoft.Windows.UI.Xaml.CPP.Targets files define these entities:

```xml
<ItemDefinitionGroup>
  <Page>
    <GeneratorTarget>DesignTimeMarkupCompilation</GeneratorTarget>
  </Page>
  <ApplicationDefinition>
    <GeneratorTarget>DesignTimeMarkupCompilation</GeneratorTarget>
  </ApplicationDefinition>
</ItemDefinitionGroup>
<Target Name="DesignTimeMarkupCompilation">
  <!-- BuildingProject is used in Managed builds (always true in Native) -->
  <!-- DesignTimeBuild is used in Native builds (always false in Managed) -->
  <CallTarget Condition="'$(BuildingProject)' != 'true' Or $(DesignTimeBuild) == 'true'" Targets="DesignTimeMarkupCompilationCT" />
</Target>
```

To use `Task.HostObject` to get the unsaved content of source files, the targets and task should be registered as [MsbuildHostObjects](/dotnet/api/microsoft.visualstudio.shell.interop.ivsmsbuildhostobject?view=visualstudiosdk-2017) for the given projects in a pkgdef:

```reg
\[$RootKey$\\Projects\\{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}\\MSBuildHostObjects\]
\[$RootKey$\\Projects\\{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}\\MSBuildHostObjects\\DesignTimeMarkupCompilationCT;CompileXaml\]
@="{83046B3F-8984-444B-A5D2-8029DEE2DB70}"
```

## VC Project extensibility in the Visual Studio IDE

The VC Project system is based on the [VS Project System](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/Index.md), and uses its extensibility points. However, the VC Project hierarchy implementation is VC-specific and not based on CPS, so extensibility is limited to project items.

VC Project supports these extensibility points:

### Project property pages

For general design information, see [Platform Extensibility - Part 1](http://blogs.msdn.com/b/vsproject/archive/2009/06/10/platform-extensibility-part-1.aspx) and [Platform extensibility - Part 2](http://blogs.msdn.com/b/vsproject/archive/2009/06/18/platform-extensibility-part-2.aspx).

In simple terms, what you see in the Project Properties UI for VC Projects is defined by *rule* files. A rule file specifies a set of properties to show on a property page, and how and where they should be saved in the project file. Rule files are .xml files that use Xaml format, and the types used for their serialization are described in [Microsoft.Build.Framework.XamlTypes](/dotnet/api/microsoft.build.framework.xamltypes). For more information about the use of rule files in VC Projects, see [Property Page XML rule files](/cpp/ide/property-page-xml-files).

The rule files must be added to the `PropertyPageSchema` item group:

```xml
<ItemGroup>
  <PropertyPageSchema Include="$(VCTargetsPath)$(LangID)\general.xml;"/>
  <PropertyPageSchema Include="$(VCTargetsPath)$(LangID)\\general\_file.xml">
    <Context>File</Context>
  </PropertyPageSchema>
</ItemGroup>
```

`Context` metadata limits rule visibility, which is also controlled by rule type, and can have one of these values:

> `Project` | `File` | `PropertySheet`

CPS supports other values for context type, but they are not used in VC projects.

If the rule should be visible in more than one context, use semi-colons (`;`) to separate the context values, as shown here:

```xml
<PropertyPageSchema Include="$(MyFolder)\MyRule.xml">
  <Context>Project;PropertySheet</Context>
</PropertyPageSchema>
```

### Extending a rule

If you want to use an existing rule, but need to add or remove (that is, hide) just a few properties, you can create an [Extension rule](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/extending_rules.md).

### Override a rule

Perhaps you want your toolset to use most of the VC Project default rules, but to replace just one or a few of them. For example, say you only want to change the C/C++ rule to show different compiler switches. You can provide a new rule with the same name and display name as the existing rule, and include it in the `PropertyPageSchema` item group after the import of default cpp targets. Only one rule with a given name is used in the project, and the last one included into the `PropertyPageSchema` item group wins.

### Rule format and main types

The rule format is straightforward, so this section only describes the
attributes that affect how the rule looks in the UI.

```xml
<Rule
  Name="ConfigurationGeneral"
  DisplayName="General"
  PageTemplate="generic"
  Description="General"
  xmlns="http://schemas.microsoft.com/build/2009/properties">
```

The `PageTemplate` attribute defines how the rule is displayed in the Property Pages UI. The attribute can have one of these values:

|Attribute|Description|
|-|-|
`generic`|All properties are shown on one page under Category headings<br/>The rule can be visible for `Project` and `PropertySheet` contexts, but not `File`.<br/><br/> Example: `$(VCTargetsPath)`\\1033\\general.xml
`tool`|Categories are shown as subpages.<br/>The rule can be visible in all contexts, `Project`, `PropertySheet` and `File`.<br/>The rule is visible in Project Properties only if the project has items with the `ItemType` defined in `Rule.DataSource`, unless the rule name is included in the `ProjectTools` item group.<br/><br/>Example: `$(VCTargetsPath)`\\1033\\clang.xml
`debugger`|The page is shown as a part of the Debugging page.<br/>Categories are currently ignored.<br/>The rule name should match the Debug Launcher MEF object's `ExportDebugger` attribute.<br/><br/>Example: `$(VCTargetsPath)`\\1033\\debugger\_local\_windows.xml
*custom*| Custom template. The name of the template should match the `ExportPropertyPageUIFactoryProvider` attribute of the `PropertyPageUIFactoryProvider` MEF object. See Microsoft.VisualStudio.ProjectSystem.Designers.Properties.IPropertyPageUIFactoryProvider.<br/><br/> Example: `$(VCTargetsPath)`\\1033\\userMacros.xml

If the rule uses one of the Property Grid-based templates, it can use these extensibility points for its properties:

- [Property value editors](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/property_value_editors.md)

- [Dynamic enum values provider](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/IDynamicEnumValuesProvider.md)

### Project items

The ProjectItemsSchema file defines the `ContentType` and `ItemType` values for Items that are treated as Project Items, and defines `FileExtension` elements to determine which Item group a new file is added to.

The default VC ProjectItemsSchema is found in the `$(VCTargetsPath)`\\1033\\ProjectItemsSchema.xml file. To extend it, you must create a schema file with a new name, such as MyProjectItemsSchema.xml:

```xml
<ProjectSchemaDefinitions xmlns="http://schemas.microsoft.com/build/2009/properties">

  <ItemType Name="MyItemType" DisplayName="C/C++ compiler"/>

  <ContentType
    Name="MyItems"
    DisplayName="My items"
    ItemType=" MyItemType ">
  </ContentType>

  <FileExtension Name=".abc" ContentType=" MyItems"/>

</ProjectSchemaDefinitions>
```

Then in the targets file, add:

```xml
<ItemGroup>
  <PropertyPageSchema Include="MyProjectItemsSchema.xml"/>
</ItemGroup>
```

Example: `$(VCTargetsPath)`\\BuildCustomizations\\masm.xml

### Debuggers

The Debug service in Visual Studio supports extensibility for the Debug engine. For more information, see these samples:

- [MIEngine, open source project that supports lldb debugging](https://github.com/Microsoft/MIEngine)

- [VS debug engine sample](https://code.msdn.microsoft.com/windowsdesktop/Visual-Studio-Debug-Engine-c2e21c0e)

To specify the Debug engines and other properties for the debug session, you must implement a [Debug Launcher](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/IDebugLaunchProvider.md) MEF component, and add a `debugger` rule. For an example, see the `$(VCTargetsPath)`\\1033\\debugger\_local\_windows.xml file.

### Deploy

VC projects use VS Project System extensibility for [Deploy Providers](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/IDeployProvider.md).

### Up-To-date check

By default, the VC Project up-to-date check requires Read tlog and Write tlog files to be created in the `$(TlogLocation)` folder during build for all build inputs and outputs.

To create a custom up-to-date check:

1. Disable the default VC Projects check by adding the `NoVCDefaultBuildUpToDateCheckProvider` capability in the Toolset.targets file:

   ```xml
   <ItemGroup>
     <ProjectCapability Include="NoVCDefaultBuildUpToDateCheckProvider" />
   </ItemGroup>
   ```

1. Implement your own [IBuildUpToDateCheckProvider](https://github.com/Microsoft/VSProjectSystem/blob/master/doc/extensibility/IBuildUpToDateCheckProvider.md).

## Project upgrade

### Default VC Project upgrader

The default VC Project upgrader changes the `PlatformToolset`, `ApplicationTypeRevision`, MSBuild toolset version and .Net framework. The last two are always changed to the Visual Studio version defaults, but `PlatformToolset` and `ApplicationTypeRevision` can be controlled by special MSBuild properties.

The decision whether a project can be upgraded or not is based on these criteria:

For projects that don't define `ApplicationTypeRevision`, property `_UpgradePlatformToolsetFor_<safe_toolset_name>` is defined for the current toolset, and its value is not equal to the current toolset.

For projects that define `ApplicationTypeRevision`,

1. A higher revision folder exists. For example, in a Windows Store project the revision folders under the `$(VCTargetPath)`\\Application Type\\Windows Store folder are checked. If a version number (say, 8.1) exists that's higher than the version currently defined in the project (say, 8.0), then that project can be upgraded.

1. Property `_UpgradePlatformToolsetFor_<safe_toolset_name>` is defined for the current toolset, and its value is not equal to the current toolset.

In the property names above, \<safe_toolset_name> represents the toolset name with all non-alphanumeric characters replaced by an underscore (`_`).

If the upgrade toolset is always the same for a given old toolset, you can define `_UpgradePlatformToolsetFor_*` properties in a props file and install it under `$(VCTargetsPath)`\\ImportBefore\\Default or `$(VCTargetsPath)`\\ImportAfter\\Default folders. Make sure the name of this props file is unique.

If the upgrade toolset is different for different AppTypes or platforms, you can use

`$(VCTargetPath)\ApplicationType\<MyAppType>\Default.props`

and

`\Platforms\<MyPlatform>\Default.props`

files, if these files belong to your toolset, or use

`$(VCTargetPath)\ApplicationType\Windows Store\ImportBefore\*.props`

or

`\Platforms\Win32\ImportBefore\*.props`

if you're extending the existing ones. You can also use an ImportAfter folder in all these locations.

For an example definition of `_UpgradePlatformToolsetFor_*`, see `$(VCTargetPath)`\\Platforms\\Win32\\Platform.Default.props.

You only need to define `_UpgradePlatformToolsetFor_v150` as v150 to log a message that upgrade isn't required, instead of 'not available', if a project or config already uses this toolset.

When a project can be upgraded, it participates in *Solution Retargeting*. For more information, see [IVsTrackProjectRetargeting2](/dotnet/api/microsoft.visualstudio.shell.interop.ivstrackprojectretargeting2?view=visualstudiosdk-2017).

If you want to adorn project names in **Solution Explorer** when projects use a particular toolset, define

`_PlatformToolsetShortNameFor_<toolset_name>`

where \<*toolset_name*> is the short name for the toolset. Short names are only used in Visual C++ for old toolsets, but you can use one for any toolset. For examples of short name definitions, see the Microsoft.Cpp.Default.props file. For examples of usage, see the Microsoft.Cpp.Platform.targets file.

### Custom project upgrade

VC Project supports MEF extensibility for 'project upgrader' objects. The upgrader object to use should be also defined in targets:

```xml
<PropertyGroup>
  <VCProjectUpgraderObjectName>MyProjectUpgrader</VCProjectUpgraderObjectName>
</PropertyGroup>
```

To disable upgrade, use a `NoUpgrade` value:

`<VCProjectUpgraderObjectName>NoUpgrade</VCProjectUpgraderObjectName>`

Define your upgrader class implementation by using these properties and the `IProjectRetargetHandler` interface:

```csharp
/// </summary>
[Export("MyProjectUpgrader", typeof(IProjectRetargetHandler))]
[Export(typeof(IProjectRetargetHandler))]
[ExportMetadata("Name", "MyProjectUpgrader")]
[OrderPrecedence(20)]
[PartMetadata(ProjectCapabilities.Requires, ProjectCapabilities.VisualC)]

internal class MyProjectUpgrader: IProjectRetargetHandler
```

The default VC Project upgrader is `VCDefaultProjectUpgrader`. It can be imported and called as desired:

```csharp
[Import("VCDefaultProjectUpgrader")]

IProjectRetargetHandler Lazy<IProjectRetargetHandler>
VCDefaultProjectUpgrader {get;set; }
```

`IProjectRetargetHandler` is defined in Microsoft.VisualStudio.ProjectSystem.VS.dll and is similar to `IVsRetargetProjectAsync`.

## VC Project Cache and extensibility

To improve performance when working with large C++ solutions in VS 2017, the [VC Project cache](https://blogs.msdn.microsoft.com/vcblog/2016/10/05/faster-c-solution-load-with-vs-15/) was introduced. It's implemented as a SQLite database populated with project data, and then used to load VC projects without loading MSBuild or CPS projects into memory.

However, because there are no CPS objects present for VC projects loaded from cache, the extension's MEF components that import `UnconfiguredProject` or `ConfiguredProject` cannot be created. To support extensibility, the VC Project cache isn't used when Visual Studio detects that a project uses (or is likely to use) MEF extensions.

These project types are always fully loaded:

- Startup projects, because Debugger MEF extensions are always created for them

- Projects that have a custom project upgrader, that is, they define a 'VCProjectUpgraderObjectName' property

- Projects that don't target Desktop Windows, that is, they define an 'ApplicationType' property

- Shared Items projects (.vcxitems) and any projects that reference them by import of .vcxitems projects.

If none of the above conditions are detected, a project cache is created that includes all the data from the MSBuild project required to answer 'get' questions of `VCProjectEngine` interfaces. This means all modifications at the MSBuild props and targets file level done by an extension should just work in projects loaded from cache.

## Shipping your extension

For information on how to create VSIX files, see [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md). For information on how to add files to special install locations, for example, to add files under `$(VCTargetsPath)`, see [Installing outside the extensions folder](../extensibility/set-install-root.md).
