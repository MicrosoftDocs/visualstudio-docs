---
title: Build Events Page, Project Designer (C#)
description: Learn how to specify build configuration instructions. You can also specify the conditions under which any post-build events are run.
ms.custom: SEO-VS-2020
ms.date: 05/05/2022
ms.technology: vs-ide-compile
ms.topic: reference
f1_keywords:
- cs.ProjectPropertiesBuildEvents
helpviewer_keywords:
- build events
- Project Designer, Build Events page
- pre-build events
- post-build events
ms.assetid: 3fff9ae5-213c-46ea-a660-1d70acb6c922
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- dotnet
---
# Build Events Page, Project Designer (C#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use the **Build Events** page of the **Project Designer** to specify build configuration instructions. You can also specify the conditions under which any post-build events are run. For more information, see [How to: Specify Build Events (C#)](../../ide/how-to-specify-build-events-csharp.md) and [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md).

:::moniker range=">=vs-2022"
For projects using .NET 5 and later, the project designer UI is quite different. See the section [Built events properties (.NET 5 and later)](#build-events-properties-net-5-and-later).
:::moniker-end

## Build events properties (.NET Framework and .NET Core 3.x and earlier)

**Configuration**

This control is not editable in this page. For a description of this control, see [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

**Platform**

This control is not editable on this page. For a description of this control, see [Build Page, Project Designer (C#)](../../ide/reference/build-page-project-designer-csharp.md).

**Pre-build event command line**

Specifies any commands to execute before the build starts. To type long commands, click **Edit Pre-build** to display the [Pre-build Event/Post-build Event Command Line Dialog Box](../../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md).

> [!NOTE]
> Pre-build events do not run if the project is up to date and no build is triggered.

**Post-build event command line**

Specifies any commands to execute after the build ends. To type long commands, click **Edit Post-build** to display the **Pre-build Event/Post-build Event Command Line Dialog Box**.

> [!NOTE]
> Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

**Run the post-build event**

Specifies the following conditions for the post-build event to run, as shown in the following table.

|Option|Result|
|------------|------------|
|**Always**|Post-build event will run regardless of whether the build succeeds.|
|**On successful build**|Post-build event will run if the build succeeds. Thus, the event will run even for a project that is up-to-date, as long as the build succeeds.|
|**When the build updates the project output**|Post-build event will only run when the compiler's output file (.exe or .dll) is different than the previous compiler output file. Thus, a post-build event is not run if a project is up-to-date.|

:::moniker range=">=vs-2022"

## Build Events properties (.NET 5 and later)

**Pre-build event**

Specifies any commands to execute before the build starts.

> [!NOTE]
> Pre-build events do not run if the project is up to date and no build is triggered.

**Post-build event**

Specifies any commands to execute after the build ends.

> [!NOTE]
> Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

**When to run the post-build event**

|Option|Result|
|------------|------------|
|**Always**|Post-build event will run regardless of whether the build succeeds.|
|**When the build succeeds**|Post-build event will run if the build succeeds. Thus, the event will run even for a project that is up-to-date, as long as the build succeeds.|
|**When the output is updated**|Post-build event will only run when the compiler's output file (.exe or .dll) is different than the previous compiler output file. Thus, a post-build event is not run if a project is up-to-date.|

:::moniker-end

### Properties available in build events

In a pre-build event or post-build event, you can use a number of properties to specify locations for files, or to get the actual name of the input file in the case of multiple selections. These properties are not case-sensitive.

|Macro|Description|
|-----------|-----------------|
|`$(ConfigurationName)`|The name of the current project configuration, for example, "Debug".|
|`$(OutDir)`|Path to the output file directory, relative to the project directory. This resolves to the value for the Output Directory property. It includes the trailing backslash '\\'.|
|`$(DevEnvDir)`|The installation directory of Visual Studio (defined with drive and path); includes the trailing backslash '\\'.|
|`$(PlatformName)`|The name of the currently targeted platform. For example, "AnyCPU".|
|`$(ProjectDir)`|The directory of the project (defined with drive and path); includes the trailing backslash '\\'.|
|`$(ProjectPath)`|The absolute path name of the project (defined with drive, path, base name, and file extension).|
|`$(ProjectName)`|The base name of the project.|
|`$(ProjectFileName)`|The file name of the project (defined with base name and file extension).|
|`$(ProjectExt)`|The file extension of the project. It includes the '.' before the file extension.|
|`$(SolutionDir)`|The directory of the solution (defined with drive and path); includes the trailing backslash '\\'.|
|`$(SolutionPath)`|The absolute path name of the solution (defined with drive, path, base name, and file extension).|
|`$(SolutionName)`|The base name of the solution.|
|`$(SolutionFileName)`|The file name of the solution (defined with base name and file extension).|
|`$(SolutionExt)`|The file extension of the solution. It includes the '.' before the file extension.|
|`$(TargetDir)`|The directory of the primary output file for the build (defined with drive and path). It includes the trailing backslash '\\'.|
|`$(TargetPath)`|The absolute path name of the primary output file for the build (defined with drive, path, base name, and file extension).|
|`$(TargetName)`|The base name of the primary output file for the build.|
|`$(TargetFileName)`|The file name of the primary output file for the build (defined as base name and file extension).|
|`$(TargetExt)`|The file extension of the primary output file for the build. It includes the '.' before the file extension.|

This is not an exhaustive list of available properties; in fact, these properties are [MSBuild properties](../../msbuild/msbuild-properties.md), and any MSBuild property that is available to be used at the point in the project file where the build event is generated can be used. A number of additional properties that are commonly available are listed at [Common MSBuild project properties](../../msbuild/common-msbuild-project-properties.md). When using these properties,e aware that properties that don't have a value evaluate to an empty string.
:::moniker-end

## In the project file

In earlier versions of Visual Studio, when you change the **PreBuildEvent** or **PostBuildEvent** setting in the IDE, Visual Studio adds a `PreBuildEvent` or `PostBuildEvent` property to the project file. So for example, if your **PreBuildEvent** command line setting in the IDE is follows:

```input
"$(ProjectDir)PreBuildEvent.bat" "$(ProjectDir)..\" "$(ProjectDir)" "$(TargetDir)"
```

then the project file setting is:

```xml
<PropertyGroup>
    <PreBuildEvent>"$(ProjectDir)PreBuildEvent.bat" "$(ProjectDir)..\" "$(ProjectDir)" "$(TargetDir)" />
</PropertyGroup>
```

For .NET Core projects, Visual Studio adds an MSBuild target named `PreBuild` or `PostBuild` for **PreBuildEvent** and **PostBuildEvent** settings. These targets use the **BeforeTargets** and **AfterTargets** attributes, which MSBuild recognizes. For example, for the preceding example, Visual Studio now generates the following code:

```xml
<Target Name="PreBuild" BeforeTargets="PreBuildEvent">
    <Exec Command="&quot;$(ProjectDir)PreBuildEvent.bat&quot; &quot;$(ProjectDir)..\&quot; &quot;$(ProjectDir)&quot; &quot;$(TargetDir)&quot;" />
</Target>
```

For a post-build event, use the name `PostBuild` and set the attribute `AfterTargets` to `PostBuildEvent`.

```xml
<Target Name="PostBuild" AfterTargets="PostBuildEvent">
   <Exec Command="echo Output written to $(TargetDir)" />
</Target>
```

> [!NOTE]
> These project file changes were made to support SDK-style projects. If you are migrating a project file from the old format to the SDK-style format manually, you should delete the `PreBuildEvent` and `PostBuildEvent` properties and replace them with `PreBuild` and `PostBuild` targets as shown in the preceding code. To find out how to tell if your project is an SDK-style project, see [Check project format](/nuget/resources/check-project-format).

## See also

- [How to: Specify Build Events (Visual Basic)](../../ide/how-to-specify-build-events-visual-basic.md)
- [How to: Specify Build Events (C#)](../../ide/how-to-specify-build-events-csharp.md)
- [Project Properties Reference](../../ide/reference/project-properties-reference.md)
- [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)
