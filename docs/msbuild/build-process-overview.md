---
title: How MSBuild builds projects
ms.date: 05/18/2020
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, build process overview
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# MSBuild process overview

How does MSBuild actually work? In this article, you'll learn how MSBuild processes your project files, whether invoked from Visual Studio, or from a command line or script. Knowing how MSBuild works can help you better diagnose problems and better customize your build process. This article describes the build process and is largely applicable to all project types.

The complete build process consists of [initial startup](#startup), [evaluation](#evaluation-phase), and [execution](#execution-phase) of the targets and tasks that build the project. In addition to these inputs, external imports define the details of the build process, including both [standard imports](#standard-imports) such as *Microsoft.Common.targets* and [user-configurable imports](#user-configurable-imports) at the solution or project level.

## Startup

MSBuild may be invoked from Visual Studio through the MSBuild object model in *Microsoft.Build.dll*, or by invoking the executable directly on the command line, or in a script, such as in CI systems. In either case, inputs that effect the build process include the project file (or project object internal to Visual Studio), possibly a solution file, environment variables, and command-line switches or their object model equivalents. During the startup phase, the command-line options or object model equivalents are used to configure MSBuild settings such as configuring loggers. Properties set on the command line using the `-property` or `-p` switch are set as global properties, which override any values that would be set in the project files, even though project files are read in later.

The next sections are about the input files, such as solution files or project files.

### Solutions and projects

MSBuild instances may consist of one project, or many projects as part of a solution. The solution file is not an MSBuild XML file, but MSBuild interprets it to know all the projects that are required to be built for the given configuration and platform settings. This is referred to as the solution build. It has some extensible points that allow you to run something at every solution build, but since this build is a separate run from the individual project builds, no settings of properties or target definitions from the solution build are relevant to each project build.

You can find out how to extend the solution build at [Customize the solution build](customize-your-build.md#customize-the-solution-build).

### Project SDKs

The SDK feature for MSBuild project files is relatively new. Prior to this, project files explicitly imported the *.targets* and *.props* files that defined the build process for a particular project type. Project SDKs make this implicit with syntax with the `Sdk` attribute on the Project element:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  ...
</Project>
```

or with the `Sdk` element:

```xml
<Project>
  <Sdk Name="Microsoft.NET.Sdk" />
  ...
</Project>
```

This syntax is expanded to first line (*sdk.props*) and last line (*sdk.targets*). SDK's define a lot of their SDK-specific functionality in their *.props* and *.targets* files, including many configurable settings that you can override in project files. 

<Project>
  <!-- Implicit top import -->
  <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk" />
  ...
  <!-- Implicit bottom import -->
  <Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />
</Project>

This results in smaller, simpler project files that are easier to read, but is otherwise equivalent to importing the *.props* and *.targets* files directly.

.NET Core projects import the version of the .NET SDK appropriate to them. See the overview, [.NET Core project SDKs](/dotnet/core/project-sdk/overview), and the reference to the [properties](/dotnet/core/project-sdk/msbuild-props).

## Evaluation phase

This section discusses how these input files are processed and parsed to produce in-memory objects that determine what will be built.

The purpose of the evaluation phase is to create the object structures in memory based on the input XML files and local environment. The evaluation phase consists of five passes that process the input files such as the project XML files or solution file, and the imported XML files, generally named as *.props* or *.targets* files, depending on whether they primarily set properties or define build targets. Each pass builds a part of the in-memory objects that are later used in the execution phase to build the projects, but no actual build actions occur during the evaluation phase. Within each pass, elements are processed in the order in which they appear.

The passes in the evaluation phase are as follows:

- Evaluate environment variables
- Evaluate imports and properties
- Evaluate item definitions
- Evaluate items
- Evaluate [UsingTask](usingtask-element-msbuild.md) elements
- Evaluate targets

The order of these passes has significant implications and is important to know when customize the project file. See [Property and item evaluation order](comparing-properties-and-items.md#property-and-item-evaluation-order).

### Evaluate environment variables

In this phase, environment variables are used to set equivalent properties. For example, the PATH environment variable is made available as a property `$(PATH)`. When run from the command line or a script, the command environment is used as normal, and when run from Visual Studio, the environment in effect when Visual Studio launches is used.

### Evaluate imports and properties

In this phase, the entire input XML is read in, including the project files and the entire chain of imports. MSBuild creates an in-memory XML structure that represents the XML of the project and all imported files. At this time, static properties are evaluated and set.  Static properties are properties set outside of any target.

As a consequence of MSBuild reading all the XML input files early on in its process, any changes to those inputs during the build process do not affect the current build.

### Evaluate item definitions

In this phase, [item definitions](item-definitions.md) are interpreted and an in-memory representation of these definitions is created.

### Evaluate items

In this phase, items and their associated metadata are processed.  Metadata set by item definitions is overridden by metadata setting on items.

### Evaluate `UsingTask` elements

In this phase, [UsingTask](usingtask-element-msbuild.md) elements are read, and the tasks are instantiated and ready to be used later during the execution phase.

### Evaluate targets

In this phase, all target object structures are created in memory, in preparation for execution. No actual execution takes place. 

## Execution phase

In the execution phase, the targets are ordered and run, and all tasks are executed. But first, properties and items that are defined within targets (known as dynamic properties and items) are evaluated together in a single phase in the order in which they appear. The order of processing is notably different from how static properties are processed: all properties first, and then all items, in separate passes.

In a single project, targets execute serially. The central issue is how to determine what order to build everything in so that dependencies are used to build the targets in the right order.  There are two code paths that MSBuild can take, the normal one, described here, and the graph option described in the next section.

The execution phase begins with determining the target build order. The rules for ordering are described in [Determine the target build order](target-build-order.md#determine-the-target-build-order). The normal process is determined by a stack structure containing targets to build. The target at the top of this task starts execution, and if it depends on anything else, then those targets are pushed onto the top of the stack, and they start executing.  When there's a target without any dependencies, it executes to completion and its parent target resumes.

As with targets in individual projects, MSBuild ensures that dependent projects are built after the projects they depend on. Individual projects specify their dependence on other projects through `ProjectReference` items. When a project on the top of the stack begins building, it reaches the point where the `ResolveProjectReferences` target executes, a standard target defined in the common target files.

`ResolveProjectReferences` invokes the MSBuild task with inputs of the `ProjectReference` items to get the outputs. The `ProjectReference` items are transformed to local items such as `Reference`. This only happens after you start building the project, and so this create a the tree of projects building.

Visual Studio allows creating project dependencies in solution (.sln) files. These are stored in the solution file and are only respected when building a solution or inside Visual Studio. If you build a single project, this type of dependency is ignored. Solution references are transformed by MSBuild into `ProjectReference` items and thereafter are treated in the same manner.

### Graph option

If you specify the graph build switch (`-graphBuild` or `-graph`), the `ProjectReference` becomes a first-class concept used by MSBuild. MSBuild will parse all the projects and construct the build order graph, an actual dependency graph of projects, which is then traversed to determine the build order.

## Parallel execution

If using multiprocessor support (`-maxCpuCount` or `-m` switch), MSBuild creates nodes, which are MSBuild processes that utilize the available CPU cores. Each project is submitted to an available node. Within a node, individual project builds execute serially.

Tasks may be enabled for parallel execution by setting a boolean variable <xref:Microsoft.Build.Tasks.MSBuild.BuildInParallel%2A>, which is set according to the value of the `$(BuildInParallel)` property in MSBuild. For tasks that are enabled for parallel execution, a work scheduler manages nodes and assigns work to nodes.

See [Building multiple projects in parallel with MSBuild](building-multiple-projects-in-parallel-with-msbuild.md)

## Standard imports

*Microsoft.Common.props* and *Microsoft.Common.targets* are both imported by .NET project files (explicitly or implicitly in SDK-style projects) and are located in the *MSBuild\Current\bin* folder in a Visual Studio installation. C++ projects have their own hierarchy of imports; see [MSBuild Internals for C++ projects](/cpp/build/reference/msbuild-visual-cpp-overview).

The *Microsoft.Common.props* file sets defaults you can override. It is imported (explicitly or implicitly) at the beginning of a project file. That way, your project's settings appear after the defaults, so that they override them.

The *Microsoft.Common.targets* file and the target files it imports defines the standard build process for .NET projects. It also provides extension points you can use to customize the build.

In implementation, *Microsoft.Common.targets* is a thin wrapper that imports *Microsoft.Common.CurrentVersion.targets*. This file contains settings for standard properties, and defines the actual targets that define the build process. The `Build` target is defined here, but is actually itself empty. However, the `Build` target contains the `DependsOn` attribute that specifies the individual targets that make up the actual build steps, which are `BeforeBuild`, `CoreBuild`, `AfterBuild`. The `Build` target is defined as follows:

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

`BeforeBuild` and `AfterBuild` are extension points. They are empty in the *Microsoft.Common.CurrentVersion.targets* file, but projects can provide their own `BeforeBuild` and `AfterBuild` targets with tasks that need to be performed before or after the main build process. `AfterBuild` is run before the no-op target, `Build`, because `AfterBuild` appears in the DependsOn attribute on the `Build` target, but it occurs after `CoreBuild`.

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
| ResolveProjectReferences | Analyze project dependencies and build dependent projects |
| ResolveAssemblyReferences| Locate dependent assemblies. |
| ResolveReferences | Consists of `ResolveProjectReferences` and `ResolveAssemblyReferences` to find all the dependencies |
| PrepareResources | Process resource files |
| ResolveKeySource| Resolve the strong name key used to sign the assembly as well as the certificate used to sign the [ClickOnce](../deployment/clickonce-security-and-deployment.md) manifests. |
| Compile | Invokes the compiler |
| ExportWindowsMDFile | Generate a [WinMD](/uwp/winrt-cref/winmd-files) file from the WinMDModule files generated by the compiler. |
| UnmanagedUnregistration | Remove/clean the [COM Interop](/dotnet/standard/native-interop/cominterop) registry entries from a previous build |
| GenerateSerializationAssemblies | Generate an XML serialization assembly using [sgen.exe](/dotnet/standard/serialization/xml-serializer-generator-tool-sgen-exe).|
| CreateSatelliteAssemblies | Create one satellite assembly for every unique culture in the resources. |
| Generate Manifests | Generates [ClickOnce](../deployment/clickonce-security-and-deployment.md) application and deployment manifests or a native manifest. |
| GetTargetPath | Return an item containing the build product (executable or assembly) for this project, with metadata. |
| PrepareForRun | Copy the build outputs to the final directory if they have changed. |
| UnmanagedRegistration | Set registry entries for [COM Interop](/dotnet/standard/native-interop/cominterop) |
| IncrementalClean | Remove files that were produced in a prior build but weren't produced in the current build. This is necessary to make `Clean` work in incremental builds. |
| PostBuildEvent | Extension point for projects to define tasks to run after build |

Many of the targets in the previous table are found in language-specific imports, such as *Microsoft.CSharp.targets*. This file defines the steps in the standard build process specific for C# .NET projects. For example, it contains the `Compile` target that actually calls the C# compiler.

## Next steps

The MSBuild process has several other extension points other than the ones described here that you can use to customize and extend the build process. See [Customize your build](customize-your-build.md). and [How to extend the Visual Studio build process](how-to-extend-the-visual-studio-build-process.md).

## See also

[MSBuild](msbuild.md)