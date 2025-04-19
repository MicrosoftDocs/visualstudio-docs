---
title: Use the MSBuild XML schema to control builds
description: Explore how the Microsoft Build Engine (MSBuild) platform provides a project file with an XML schema to control builds with properties, items, tasks, and targets.
ms.date: 11/14/2024
ms.topic: overview
helpviewer_keywords:
- MSBuild, about MSBuild
- MSBuild, overview
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild

The Microsoft Build Engine is a platform for building applications. This engine, which is also known as MSBuild, provides an XML schema for a project file that controls how the build platform processes and builds software. Visual Studio uses MSBuild, but MSBuild doesn't depend on Visual Studio. By invoking *msbuild.exe* or *dotnet build* on your project or solution file, you can orchestrate and build products in environments where Visual Studio isn't installed.

Visual Studio uses MSBuild to load and build managed projects. The project files in Visual Studio (*.csproj*, *.vbproj*, *.vcxproj*, and others) contain MSBuild XML code that executes when you build a project in the IDE. Visual Studio projects import all the necessary settings and build processes to do typical development work, but you can extend or modify them from within Visual Studio or by using a text editor.

To install MSBuild on a Windows system that doesn't have Visual Studio, go to **Build Tools for Visual Studio** on the [downloads page](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta). Installing MSBuild by this method gives you *MSBuild.exe*.

For .NET Core and .NET 5 or later, another way of getting the equivalent to MSBuild is to install the [.NET SDK](/dotnet/core/sdk#acquiring-the-net-sdk). The .NET build command `dotnet build` is available with the .NET SDK on macOS, Windows, or Linux. The .NET build command `dotnet build` is a thin wrapper over the .NET Core version of *MSBuild.exe*. You can use the [.NET Core command-line interface (CLI)](/dotnet/core/tools/), which uses MSBuild, to build projects that target .NET Core and .NET 5 and later. 

::: moniker range=">=vs-2022"
Starting with Visual Studio 2022, when you build in Visual Studio, the 64-bit version of MSBuild is used.
::: moniker-end

For information about MSBuild for C++, see [MSBuild (C++)](/cpp/build/msbuild-visual-cpp).

The following examples illustrate when you might run builds by invoking MSBuild from the command line instead of the Visual Studio IDE.

- Visual Studio isn't installed.

- You want to use the 64-bit version of MSBuild, and you're using Visual Studio 2019 or earlier. This version of MSBuild is usually unnecessary, but it allows MSBuild to access more memory.

- You want to run a build in multiple processes. However, you can use the IDE to achieve the same result on projects in C++ and C#.

- You want to modify the build system. For example, you might want to enable the following actions:

  - Preprocess files before they reach the compiler.

  - Copy the build outputs to a different place.

  - Create compressed files from build outputs.

  - Do a post-processing step. For example, you might want to stamp an assembly with a different version.

You can write code in the Visual Studio IDE but run builds by using MSBuild. As another alternative, you can build code in the IDE on a development computer but run MSBuild from the command line to build code that's integrated from a source repo with collaboration from multiple developers.

> [!NOTE]
> You can use Azure Pipelines to automatically compile, test, and deploy your application. Your build system can automatically run builds when developers check in code (for example, as part of a Continuous Integration strategy) or according to a schedule (for example, a nightly Build Verification Test build). Azure Pipelines compiles your code by using MSBuild. For more information, see [Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true).

For an introductory tutorial for MSBuild on Windows, see [Walkthrough: Using MSBuild](../msbuild/walkthrough-using-msbuild.md).

## Use MSBuild at a command prompt

 To run MSBuild at a command prompt, pass a project file to *MSBuild.exe*, together with the appropriate command-line options. Command-line options let you set properties, execute specific targets, and set other options that control the build process. For example, you would use the following command-line syntax to build the file *MyProj.proj* with the `Configuration` property set to `Debug`.

```cmd
MSBuild.exe MyProj.proj -property:Configuration=Debug
```

MSBuild does not change its behavior based on the file extension, but the convention is to use extensions ending in `proj` such as `.csproj`, `.vcxproj`, or `.vbproj`, for the main MSBuild input file, called the "project file."

 For more information about MSBuild command-line options, see [Command-line reference](../msbuild/msbuild-command-line-reference.md).

> [!IMPORTANT]
> Before you download a project, determine the trustworthiness of the code.

For .NET Core and .NET 5 or later, you typically use `dotnet build` to invoke MSBuild. See [dotnet build](/dotnet/core/tools/dotnet-build). If you install only the .NET SDK, and not Visual Studio or the Visual Studio Build Tools, then you have MSBuild only through `dotnet build`.

The command line `dotnet build --help` lists the command-line options specific to `dotnet build`, not all the options of *MSBuild.exe*, but you can still use all the command line options listed in the MSBuild command line reference. The options that are not processed by `dotnet build` are passed on to MSBuild.

## Project file

 MSBuild uses an XML-based project file format that's straightforward and extensible. The MSBuild project file format lets developers describe the items that are to be built, and also how they are to be built for different operating systems and configurations. In addition, the project file format lets developers author reusable build rules that can be factored into separate files so that builds can be performed consistently across different projects in the product.

 The Visual Studio build system stores project-specific logic in the project file itself, and uses imported MSBuild XML files with extensions like `.props` and `.targets` to define the standard build logic. The `.props` files define MSBuild properties, and `.targets` files define MSBuild targets. These imports are sometimes visible in the Visual Studio project file, but in newer projects such as .NET Core, .NET 5 and .NET 6 projects, you don't see the imports in the project file; instead, you see an SDK reference, which looks like this:

```xml
<Project Sdk="Microsoft.Net.Sdk">
```

 These are called SDK-style projects. When you reference an SDK such as the .NET SDK, the imports of `.props` and `.target` files are implicitly specified by the SDK.

 The following sections describe some of the basic elements of the MSBuild project file format. For a tutorial about how to create a basic project file, see [Walkthrough: Creating an MSBuild project file from scratch](../msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch.md).

### <a name="BKMK_Properties"></a> Properties

 Properties represent key/value pairs that can be used to configure builds. Properties are declared by creating an element that has the name of the property as a child of a [PropertyGroup](../msbuild/propertygroup-element-msbuild.md) element. For example, the following code creates a property named `BuildDir` that has a value of `Build`.

```xml
<PropertyGroup>
    <BuildDir>Build</BuildDir>
</PropertyGroup>
```

 You can define a property conditionally by placing a `Condition` attribute in the element. The contents of conditional elements are ignored unless the condition evaluates to `true`. In the following example, the `Configuration` property is defined if it hasn't yet been defined.

```xml
<Configuration  Condition=" '$(Configuration)' == '' ">DefaultValue</Configuration>
```

 Properties can be referenced throughout the project file by using the syntax $(\<PropertyName>). For example, you can reference the properties in the previous examples by using `$(BuildDir)` and `$(Configuration)`.

 For more information about properties, see [MSBuild properties](../msbuild/msbuild-properties.md).

### <a name="BKMK_Items"></a> Items

 Items are inputs into the build system and typically represent files. Items are grouped into item types based on user-defined item names. These item types can be used as parameters for tasks, which use the individual items to perform the steps of the build process.

 Items are declared in the project file by creating an element that has the name of the item type as a child of an [ItemGroup](../msbuild/itemgroup-element-msbuild.md) element. For example, the following code creates an item type named `Compile`, which includes two files.

```xml
<ItemGroup>
    <Compile Include = "file1.cs"/>
    <Compile Include = "file2.cs"/>
</ItemGroup>
```

 Item types can be referenced throughout the project file by using the syntax @(\<ItemType>). For example, the item type in the example would be referenced by using `@(Compile)`.

 In MSBuild, element and attribute names are case-sensitive. However, property, item, and metadata names are not. The following example creates the item type `Compile`, `comPile`, or any other case variation, and gives the item type the value "one.cs;two.cs".

```xml
<ItemGroup>
  <Compile Include="one.cs" />
  <Compile Include="two.cs" />
</ItemGroup>
```

 Items can be declared by using wildcard characters and may contain additional metadata for more advanced build scenarios. For more information about items, see [Items](../msbuild/msbuild-items.md).

### <a name="BKMK_Tasks"></a> Tasks

 Tasks are units of executable code that MSBuild projects use to perform build operations. For example, a task might compile input files or run an external tool. Tasks can be reused, and they can be shared by different developers in different projects.

 The execution logic of a task is written in managed code and mapped to MSBuild by using the [UsingTask](../msbuild/usingtask-element-msbuild.md) element. You can write your own task by authoring a managed type that implements the <xref:Microsoft.Build.Framework.ITask> interface. For more information about how to write tasks, see [Task writing](../msbuild/task-writing.md).

 MSBuild includes common tasks that you can modify to suit your requirements. Examples are [Copy](../msbuild/copy-task.md), which copies files, [MakeDir](../msbuild/makedir-task.md), which creates directories, and [Csc](../msbuild/csc-task.md), which compiles Visual C# source code files. For a list of available tasks together with usage information, see [Task reference](../msbuild/msbuild-task-reference.md).

 A task is executed in an MSBuild project file by creating an element that has the name of the task as a child of a [Target](../msbuild/target-element-msbuild.md) element. Tasks typically accept parameters, which are passed as attributes of the element. Both MSBuild properties and items can be used as parameters. For example, the following code calls the [MakeDir](../msbuild/makedir-task.md) task and passes it the value of the `BuildDir` property that was declared in the earlier example.

```xml
<Target Name="MakeBuildDirectory">
    <MakeDir  Directories="$(BuildDir)" />
</Target>
```

 For more information about tasks, see [Tasks](../msbuild/msbuild-tasks.md).

### <a name="BKMK_Targets"></a> Targets

 Targets group tasks together in a particular order and expose sections of the project file as entry points into the build process. Targets are often grouped into logical sections to increase readability and to allow for expansion. Breaking the build steps into targets lets you call one piece of the build process from other targets without copying that section of code into every target. For example, if several entry points into the build process require references to be built, you can create a target that builds references and then run that target from every entry point where it's required.

 Targets are declared in the project file by using the [Target](../msbuild/target-element-msbuild.md) element. For example, the following code creates a target named `Compile`, which then calls the [Csc](../msbuild/csc-task.md) task that has the item list that was declared in the earlier example.

```xml
<Target Name="Compile">
    <Csc Sources="@(Compile)" />
</Target>
```

 In more advanced scenarios, targets can be used to describe relationships among one another and perform dependency analysis so that whole sections of the build process can be skipped if that target is up-to-date. For more information about targets, see [Targets](../msbuild/msbuild-targets.md).

## Build logs

 You can log build errors, warnings, and messages to the console or another output device. For more information, see [Obtaining build logs with MSBuild](../msbuild/obtaining-build-logs-with-msbuild.md).

## Use MSBuild in Visual Studio

 Visual Studio uses the MSBuild project file format to store build information about managed projects. Project settings that are added or changed by using the Visual Studio interface are reflected in the *.\*proj* file that's generated for every project. Visual Studio uses a hosted instance of MSBuild to build managed projects. This means that a managed project can be built in Visual Studio or at a command prompt (even if Visual Studio isn't installed), and the results will be identical.

 For a tutorial about how to use MSBuild in Visual Studio, see [Walkthrough: Using MSBuild](../msbuild/walkthrough-using-msbuild.md).

## <a name="BKMK_Multitargeting"></a> Multitargeting

 By using Visual Studio, you can compile an application to run on any one of several versions of .NET Framework or .NET Core, including .NET 5 and later. For example, you can compile an application to run on .NET Framework 4 on a 32-bit platform, and you can compile the same application to run on .NET Framework 4.8 on a 64-bit platform. The ability to compile to more than one framework is named multitargeting.

 These are some of the benefits of multitargeting:

- You can develop applications that target earlier versions of .NET Framework, for example, versions 3.5 and 4.7.2.

- You can target a *framework profile*, which is a predefined subset of a target framework.

- If a service pack for the current version of .NET Framework is released, you could target it.

- Multitargeting guarantees that an application uses only the functionality that's available in the target framework and platform.

For more information, see [Multitargeting](../msbuild/msbuild-multitargeting-overview.md).

## Customizing the build

MSBuild provides support for a wide range of custom build scenarios. Most built-in functionality can be overridden or extended. See [Customize your build](./customize-your-build.md).

## Accessing MSBuild programmatically

If you're developing a build tool, you might want to invoke MSBuild programmatically from a .NET application. By using the MSBuild API, you can control all aspect of a complex build system. MSBuild provides a NuGet package with a full API (the Microsoft.Build namespace) that you can use from a .NET application for these purposes. See [Use the MSBuild API](msbuild-api.md).

## MSBuild is open source

MSBuild is an open-source project that accepts user contributions at the [MSBuild GitHub repo](https://github.com/dotnet/msbuild).

## See also

| Title | Description |
| - | - |
| [Walkthrough: Creating an MSBuild project file from scratch](../msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch.md) | Shows how to create a basic project file incrementally, by using only a text editor. |
| [Walkthrough: Using MSBuild](../msbuild/walkthrough-using-msbuild.md) | Introduces the building blocks of MSBuild and shows how to write, manipulate, and debug MSBuild projects without closing the Visual Studio IDE. |
| [MSBuild concepts](../msbuild/msbuild-concepts.md) | Presents the four building blocks of MSBuild: properties, items, targets, and tasks. |
| [Items](../msbuild/msbuild-items.md) | Describes the general concepts behind the MSBuild file format and how the pieces fit together. |
| [MSBuild properties](../msbuild/msbuild-properties.md) | Introduces properties and property collections. Properties are key/value pairs that can be used to configure builds. |
| [Targets](../msbuild/msbuild-targets.md) | Explains how to group tasks together in a particular order and enable sections of the build process to be called on the command line. |
| [Tasks](../msbuild/msbuild-tasks.md) | Shows how to create a unit of executable code that can be used by MSBuild to perform atomic build operations. |
| [Conditions](../msbuild/msbuild-conditions.md) | Discusses how to use the `Condition` attribute in an MSBuild element. |
| [Batching](../msbuild/msbuild-batching.md) | Discusses how MSBuild categorizes item lists by metadata for execution in tasks and targets. |
| [Multitargeting](../msbuild/msbuild-multitargeting-overview.md) | Shows how to target multiple .NET versions and/or multiple platforms. |
| [Obtaining build logs](obtaining-build-logs-with-msbuild.md) | Describes how to log build events, messages, and errors. |
| [How MSBuild builds projects](build-process-overview.md) | Describes the internal build process used within MSBuild |
| [Secure MSBuild usage best practices](msbuild-security-best-practices.md) | Describes the best practices to configure and run your builds with MSBuild |
| [Create a custom task for code generation](tutorial-custom-task-code-generation.md) | Shows how to create a custom task, with a code example. |
| [Use MSBuild to generate a REST API client](tutorial-rest-api-client-msbuild.md) | Shows how to extend the build to handle REST API client generation, with a code example. |
| [Additional resources](https://social.msdn.microsoft.com/forums/vstudio/home?forum=msbuild) | Lists community and support resources for more information about MSBuild. |

## Reference

- [MSBuild reference](../msbuild/msbuild-reference.md)\
 Links to topics that contain reference information.

- [Glossary](msbuild-glossary.md)\
 Defines common MSBuild terms.
