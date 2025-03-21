---
title: How MSBuild builds projects
description: Discover how MSBuild processes your project files, whether you invoke the build tool from Visual Studio or from a command line or script.
ms.date: 02/13/2024
ms.topic: overview
helpviewer_keywords:
- MSBuild, build process overview
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# How MSBuild builds projects

How does MSBuild actually work? In this article, you'll learn how MSBuild processes your project files, whether invoked from Visual Studio, or from a command line or script. Knowing how MSBuild works can help you better diagnose problems and better customize your build process. This article describes the build process and is largely applicable to all project types.

The complete build process consists of [initial startup](#startup), [evaluation](#evaluation-phase), and [execution](#execution-phase) of the targets and tasks that build the project. In addition to these inputs, external imports define the details of the build process, including both [standard imports](#standard-imports) such as *Microsoft.Common.targets* and [user-configurable imports](#user-configurable-imports) at the solution or project level.

## Startup

MSBuild can be invoked from Visual Studio through the MSBuild object model in *Microsoft.Build.dll*, or by invoking the executable (`MSBuild.exe` or `dotnet build`) directly on the command line, or in a script, such as in CI systems. In either case, inputs that affect the build process include the project file (or project object internal to Visual Studio), possibly a solution file, environment variables, and command-line switches or their object model equivalents. During the startup phase, the command-line options or object model equivalents are used to configure MSBuild settings such as configuring loggers. Properties set on the command line using the `-property` or `-p` switch are set as global properties, which override any values that would be set in the project files, even though project files are read in later.

The next sections are about the input files, such as solution files or project files.

### Solutions and projects

MSBuild instances may consist of one project, or many projects as part of a solution. Solution files in the `.slnx` format or the `.sln` format are both supported (in MSBuild 17.12 and later). The solution file (`.sln`) isn't an MSBuild XML file, but MSBuild interprets it to know all the projects that are required to be built for the given configuration and platform settings. When MSBuild processes this input, it's referred to as the solution build. It has some extensible points that allow you to run something at every solution build, but since this build is a separate run from the individual project builds, no settings of properties or target definitions from the solution build are relevant to each project build.

You can find out how to extend the solution build at [Customize the solution build](customize-solution-build.md).

### Visual Studio builds vs. MSBuild.exe builds

There are some significant differences between when projects build in Visual Studio vs. when you invoke MSBuild directly, either through the MSBuild executable, or when you use the MSBuild object model to start a build. Visual Studio manages the project build order for Visual Studio builds; it only calls MSBuild at the individual project level, and when it does, a couple of Boolean properties (`BuildingInsideVisualStudio`, `BuildProjectReferences`) are set that significantly affect what MSBuild does. Inside each project, execution occurs the same as when invoked through MSBuild, but the difference arises with referenced projects. In MSBuild, when referenced projects are required, a build actually occurs; that is, it runs tasks and tools, and generates the output. When a Visual Studio build finds a referenced project, MSBuild only returns the expected outputs from the referenced project; it lets Visual Studio control the building of those other projects. Visual Studio determines the build order and calls into MSBuild separately (as needed), all completely under Visual Studio's control.

Another difference arises when MSBuild is invoked with a solution file, MSBuild parses the solution file, creates a standard XML input file, evaluates it, and executes it as a project. The solution build is executed before any project. When building from Visual Studio, none of this happens; MSBuild never sees the solution file. As a consequence, solution build customization (using *before.SolutionName.sln.targets* and *after.SolutionName.sln.targets*) only applies to MSBuild.exe, `dotnet build`, or object-model-driven builds, not Visual Studio builds.

### Project SDKs

The SDK feature for MSBuild project files is relatively new. Prior to this change, project files explicitly imported the *.targets* and *.props* files that defined the build process for a particular project type.

.NET Core projects import the version of the .NET SDK appropriate to them. See the overview, [.NET Core project SDKs](/dotnet/core/project-sdk/overview), and the reference to the [properties](/dotnet/core/project-sdk/msbuild-props).

## Evaluation phase

This section discusses how these input files are processed and parsed to produce in-memory objects that determine what will be built.

The purpose of the evaluation phase is to create the object structures in memory based on the input XML files and local environment. The evaluation phase consists of six passes that process the input files such as the project XML files or, and the imported XML files, generally named as *.props* or *.targets* files, depending on whether they primarily set properties or define build targets. Each pass builds a part of the in-memory objects that are later used in the execution phase to build the projects, but no actual build actions occur during the evaluation phase. Within each pass, elements are processed in the order in which they appear.

The passes in the evaluation phase are as follows:

- Evaluate environment variables
- Evaluate imports and properties
- Evaluate item definitions
- Evaluate items
- Evaluate [UsingTask](usingtask-element-msbuild.md) elements
- Evaluate targets

Imports and properties are evaluated in the same pass in sequence of appearance, as if imports are expanded in place. Thus, property settings in previously imported files are available within later imported files.

The order of these passes has significant implications and is important to know when customizing the project file. See [Property and item evaluation order](comparing-properties-and-items.md#property-and-item-evaluation-order).

### Evaluate environment variables

In this phase, environment variables are used to set equivalent properties. For example, the PATH environment variable is made available as a property `$(PATH)`. When run from the command line or a script, the command environment is used as normal, and when run from Visual Studio, the environment in effect when Visual Studio launches is used.

### Evaluate imports and properties

In this phase, the entire input XML is read in, including the project files and the entire chain of imports. MSBuild creates an in-memory XML structure that represents the XML of the project and all imported files. At this time, properties that aren't in targets are evaluated and set.

As a consequence of MSBuild reading all the XML input files early on in its process, any changes to those inputs during the build process don't affect the current build.

Properties outside of any target are handled differently from properties within targets. In this phase, only the properties defined outside of any target are evaluated.

Because properties are processed in order in the properties pass, a property at any point in the input can access property values that appear earlier in the input, but not properties that appear later.

Because the properties are processed before items are evaluated, you can't access the value of any item during any part of the properties pass. 

### Evaluate item definitions

In this phase, [item definitions](item-definitions.md) are interpreted and an in-memory representation of these definitions is created.

### Evaluate items

Items defined inside a target are handled differently from items outside any target. In this phase, items outside any target, and their associated metadata, are processed.  Metadata set by item definitions is overridden by metadata set on items. Because items are processed in the order that they appear, you can reference items that have been defined earlier, but not ones that appear later. Because the items pass is after the properties pass, items can access any property if defined outside any targets, regardless of whether the property definition appears later.

### Evaluate `UsingTask` elements

In this phase, [UsingTask](usingtask-element-msbuild.md) elements are read, and the tasks are declared for later use during the execution phase.

### Evaluate targets

In this phase, all target object structures are created in memory, in preparation for execution. No actual execution takes place. 

## Execution phase

In the execution phase, the targets are ordered and run, and all tasks are executed. But first, properties and items that are defined within targets are evaluated together in a single phase in the order in which they appear. The order of processing is notably different from how properties and items that aren't in a target are processed: all properties first, and then all items, in separate passes. Changes to properties and items within a target can be observed after the target where they were changed.

### Target build order

In a single project, targets execute serially. The central issue is how to determine what order to build everything in so that dependencies are used to build the targets in the right order.  

The target build order is determined by the use of the `BeforeTargets`, `DependsOnTargets`, and `AfterTargets` attributes on each target. The order of later targets can be influenced during execution of an earlier target if the earlier target modifies a property that's referenced in these attributes.

The rules for ordering are described in [Determine the target build order](target-build-order.md#determine-the-target-build-order). The process is determined by a stack structure containing targets to build. The target at the top of this task starts execution, and if it depends on anything else, then those targets are pushed onto the top of the stack, and they start executing.  When there's a target without any dependencies, it executes to completion and its parent target resumes.

### Project References

There are two code paths that MSBuild can take, the normal one, described here, and the graph option described in the next section.

Individual projects specify their dependence on other projects through `ProjectReference` items. When a project on the top of the stack begins building, it reaches the point where the `ResolveProjectReferences` target executes, a standard target defined in the common target files.

`ResolveProjectReferences` invokes the MSBuild task with inputs of the `ProjectReference` items to get the outputs. The `ProjectReference` items are transformed to local items such as `Reference`. The MSBuild execution phase for the current project pauses while the execution phase begins to process the referenced project (the evaluation phase is done first as needed). The referenced project only builds after you start building the dependent project, and so this creates a tree of projects building.

Visual Studio allows creating project dependencies in solution (.sln) files. The dependencies are specified in the solution file and are only respected when building a solution, or when building inside Visual Studio. If you build a single project, this type of dependency is ignored. Solution references are transformed by MSBuild into `ProjectReference` items and thereafter are treated in the same manner.

### Graph option

If you specify the graph build switch (`-graphBuild` or `-graph`), the `ProjectReference` becomes a first-class concept used by MSBuild. MSBuild will parse all the projects and construct the build order graph, an actual dependency graph of projects, which is then traversed to determine the build order. As with targets in individual projects, MSBuild ensures that referenced projects are built after the projects they depend on.

## Parallel execution

If using multiprocessor support (`-maxCpuCount` or `-m` switch), MSBuild creates nodes, which are MSBuild processes that use the available CPU cores. Each project is submitted to an available node. Within a node, individual project builds execute serially.

Tasks may be enabled for parallel execution by setting a boolean variable <xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel%2A>, which is set according to the value of the `$(BuildInParallel)` property in MSBuild. For tasks that are enabled for parallel execution, a work scheduler manages nodes and assigns work to nodes.

See [Building multiple projects in parallel with MSBuild](building-multiple-projects-in-parallel-with-msbuild.md)

## Standard imports

*Microsoft.Common.props* and *Microsoft.Common.targets* are both imported by .NET project files (explicitly or implicitly in SDK-style projects) and are located in the *MSBuild\Current\bin* folder in a Visual Studio installation. C++ projects have their own hierarchy of imports; see [MSBuild Internals for C++ projects](/cpp/build/reference/msbuild-visual-cpp-overview).

The *Microsoft.Common.props* file sets defaults you can override. It's imported (explicitly or implicitly) at the beginning of a project file. That way, your project's settings appear after the defaults, so that they override them.

The *Microsoft.Common.targets* file and the target files it imports define the standard build process for .NET projects. It also provides extension points you can use to customize the build.

In implementation, *Microsoft.Common.targets* is a thin wrapper that imports *Microsoft.Common.CurrentVersion.targets*. This file contains settings for standard properties, and defines the actual targets that define the build process. The `Build` target is defined here, but is actually itself empty. However, the `Build` target contains the `DependsOnTargets` attribute that specifies the individual targets that make up the actual build steps, which are `BeforeBuild`, `CoreBuild`, and `AfterBuild`. The `Build` target is defined as follows:

```xml
  <PropertyGroup>
    <BuildDependsOn>
      BeforeBuild;
      CoreBuild;
      AfterBuild
    </BuildDependsOn>
  </PropertyGroup>

  <Target
      Name="Build"
      Condition=" '$(_InvalidConfigurationWarning)' != 'true' "
      DependsOnTargets="$(BuildDependsOn)"
      Returns="@(TargetPathWithTargetPlatformMoniker)" />
```

`BeforeBuild` and `AfterBuild` are extension points. They're empty in the *Microsoft.Common.CurrentVersion.targets* file, but projects can provide their own `BeforeBuild` and `AfterBuild` targets with tasks that need to be performed before or after the main build process. `AfterBuild` is run before the no-op target, `Build`, because `AfterBuild` appears in the `DependsOnTargets` attribute on the `Build` target, but it occurs after `CoreBuild`.

The `CoreBuild` target contains the calls to the build tools, as follows:

```xml
  <PropertyGroup>
    <CoreBuildDependsOn>
      BuildOnlySettings;
      PrepareForBuild;
      PreBuildEvent;
      ResolveReferences;
      PrepareResources;
      ResolveKeySource;
      Compile;
      ExportWindowsMDFile;
      UnmanagedUnregistration;
      GenerateSerializationAssemblies;
      CreateSatelliteAssemblies;
      GenerateManifests;
      GetTargetPath;
      PrepareForRun;
      UnmanagedRegistration;
      IncrementalClean;
      PostBuildEvent
    </CoreBuildDependsOn>
  </PropertyGroup>
  <Target
      Name="CoreBuild"
      DependsOnTargets="$(CoreBuildDependsOn)">

    <OnError ExecuteTargets="_TimeStampAfterCompile;PostBuildEvent" Condition="'$(RunPostBuildEvent)'=='Always' or '$(RunPostBuildEvent)'=='OnOutputUpdated'"/>
    <OnError ExecuteTargets="_CleanRecordFileWrites"/>

  </Target>
```

The following table describes these targets; some targets are applicable only to certain project types.

| Target | Description |
|--------|-------------|
| BuildOnlySettings | Settings for real builds only, not for when MSBuild is invoked on project load by Visual Studio. |
| PrepareForBuild | Prepare the prerequisites for building |
| PreBuildEvent | Extension point for projects to define tasks to execute before build |
| ResolveProjectReferences | Analyze project dependencies and build referenced projects |
| ResolveAssemblyReferences| Locate referenced assemblies. |
| ResolveReferences | Consists of `ResolveProjectReferences` and `ResolveAssemblyReferences` to find all the dependencies |
| PrepareResources | Process resource files |
| ResolveKeySource| Resolve the strong name key used to sign the assembly and the certificate used to sign the [ClickOnce](../deployment/clickonce-security-and-deployment.md) manifests. |
| Compile | Invokes the compiler |
| ExportWindowsMDFile | Generate a [WinMD](/uwp/winrt-cref/winmd-files) file from the WinMDModule files generated by the compiler. |
| UnmanagedUnregistration | Remove/clean the [COM Interop](/dotnet/standard/native-interop/cominterop) registry entries from a previous build |
| GenerateSerializationAssemblies | Generate an XML serialization assembly using [sgen.exe](/dotnet/standard/serialization/xml-serializer-generator-tool-sgen-exe).|
| CreateSatelliteAssemblies | Create one satellite assembly for every unique culture in the resources. |
| Generate Manifests | Generates [ClickOnce](../deployment/clickonce-security-and-deployment.md) application and deployment manifests or a native manifest. |
| GetTargetPath | Return an item containing the build product (executable or assembly) for this project, with metadata. |
| PrepareForRun | Copy the build outputs to the final directory if they've changed. |
| UnmanagedRegistration | Set registry entries for [COM Interop](/dotnet/standard/native-interop/cominterop) |
| IncrementalClean | Remove files that were produced in a prior build but weren't produced in the current build. This is necessary to make `Clean` work in incremental builds. |
| PostBuildEvent | Extension point for projects to define tasks to run after build |

Many of the targets in the previous table are found in language-specific imports, such as *Microsoft.CSharp.targets*. This file defines the steps in the standard build process specific for C# .NET projects. For example, it contains the `Compile` target that actually calls the C# compiler.

## User-configurable imports

In addition to the standard imports, there are several imports that you can add to customize the build process.

- *Directory.Build.props*
- *Directory.Build.targets*

These files are read in by the standard imports for any projects in any subfolder under them. That's commonly at the solution level for settings to control all the projects in the solution, but could also be higher up in the filesystem, up to the root of the drive.

The *Directory.Build.props* file is imported by *Microsoft.Common.props*, so the properties defined therein are available in the project file. They can be redefined in the project file to customize the values on a per-project basis. The *Directory.Build.targets* file is read in after the project file. It typically contains targets, but here you can also define properties that you don't want individual projects to redefine.

## Customizations in a project file

Visual Studio updates your project files as you make changes in **Solution Explorer**, the **Properties** window, or in **Project Properties**, but you can also make your own changes by directly editing the project file.

Many build behaviors can be configured by setting MSBuild properties, either in the project file for settings local to a project, or as mentioned in the previous section, by creating a *Directory.Build.props* file to set properties globally for entire folders of projects and solutions. For ad hoc builds on the command line, or scripts, you can also use the `/p` option on the command line to set properties for a particular invocation of MSBuild. See [Common MSBuild project properties](common-msbuild-project-properties.md) for information about properties you can set.

## Related content

- [Customize your build](customize-your-build.md)
- [How to extend the Visual Studio build process](how-to-extend-the-visual-studio-build-process.md).
- [MSBuild](msbuild.md)
