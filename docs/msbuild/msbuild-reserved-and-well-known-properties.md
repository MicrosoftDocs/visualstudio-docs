---
title: MSBuild Reserved and Well-known Properties
description: Learn about the MSBuild reserved and well-known properties, predefined properties that store information about the project file and the MSBuild binaries.
ms.date: 10/04/2022
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, reserved properties
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild reserved and well-known properties

MSBuild provides a set of predefined properties that store information about the project file and the MSBuild binaries. These properties are evaluated in the same manner as other MSBuild properties. For example, to use the `MSBuildProjectFile` property, you type `$(MSBuildProjectFile)`.

 MSBuild uses the values in the following table to predefine reserved and well-known properties. Reserved properties cannot be overridden, and most well-known properties shouldn't be overridden except in advanced scenarios.

## Reserved and well-known properties

The table in this section shows the MSBuild predefined properties. The example column in the table relates to the following example project file, assumed to be located at `C:\Source\Repos\ConsoleApp1\ConsoleApp1`, and shows an example of the values these properties have when accessed in the project file, when MSBuild is invoked with no special command-line options.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.1</TargetFramework>
  </PropertyGroup>
</Project>
```

:::moniker range="vs-2019"

| Property | Reserved or well-known | Description | Example |
|----------------------------------|------------------------| - | - |
| `FrameworkSDKRoot` | Well-known | Path to the root folder for .NET Framework tools. | `C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\` |
| `InnerBuildProperty` | Well-known | Specifies the property name that defines the multitargeting build dimension (applicable only if the current build is a [graph build][graph-build]). | TargetFramework |
| `InnerBuildPropertyValues` | Well-known | Specifies the property name that holds the possible values for the `InnerBuildProperty` (applicable only if the current build is a [graph build][graph-build]).| TargetFrameworks |
| `IsGraphBuild` | Well-known | `True` if this is a [graph build][graph-build]; that is, the `-graphBuild` option is in effect. This option means that MSBuild constructs and builds a project graph. Constructing a graph involves identifying project references to form dependencies. Building that graph involves attempting to build project references prior to the projects that reference them, differing from traditional MSBuild scheduling.| |
| `MSBuildAssemblyVersion` | Reserved | The version of MSBuild assemblies used to build the project. | 16.0 |
| `MSBuildBinPath` | Reserved | The absolute path of the folder where the MSBuild binaries that are currently being used are located (for example, *C:\Windows\Microsoft.Net\Framework\\\<versionNumber>*). This property is useful if you have to refer to files in the MSBuild directory.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild\Current\Bin` |
| `MSBuildDisableFeaturesFromVersion` | Reserved | Used by MSBuild and Microsoft SDKs to manage change waves. |
| `MSBuildExtensionsPath` | Well-known | Introduced in the .NET Framework 4: there is no difference between the default values of `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`. You can set the environment variable `MSBUILDLEGACYEXTENSIONSPATH` to a non-null value to enable the behavior of the default value of `MSBuildExtensionsPath` in earlier versions.<br /><br /> In the .NET Framework 3.5 and earlier, the default value of `MSBuildExtensionsPath` points to the path of the MSBuild subfolder under the *\Program Files\\* or *\Program Files (x86)* folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the *\Program Files (x86)* folder. For a 64-bit process on a 64-bit machine, this property points to the *\Program Files* folder.<br /><br /> Do not include the final backslash on this property.<br /><br /> This location is a useful place to put custom target files. For example, your target files could be installed at *\Program Files\MSBuild\MyFiles\Northwind.targets* and then imported in project files by using this XML code:<br /><br /> `<Import Project="$(MSBuildExtensionsPath)\MyFiles\Northwind.targets"/>` | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild`|
| `MSBuildExtensionsPath32` | Well-known | The path of the MSBuild subfolder under the *\Program Files* or *\Program Files (x86)* folder. The path always points to the 32-bit *\Program Files (x86)* folder on a 32-bit machine and *\Program Files* on a 64-bit machine.". See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath64`.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild`|
| `MSBuildExtensionsPath64` | Well-known | The path of the MSBuild subfolder under the *\Program Files* folder. For a 64-bit machine, this path always points to the *\Program Files* folder. For a 32-bit machine, this path is blank. See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files\MSBuild`|
| `MSBuildFileVersion` | Reserved | The 4 part version of MSBuild assemblies used to build the project. | 16.11.0.30701 |
| `MSBuildFrameworkToolsPath` | Well-known | The path to the .NET Framework tools that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\` |
| `MSBuildFrameworkToolsPath32` | Well-known | The path to the 32-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\` |
| `MSBuildFrameworkToolsPath64` | Well-known | The path to the 64-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\` |
| `MSBuildInteractive` | Reserved | `true` if MSBuild is running interactively, allowing user input. This setting is controlled by the `-interactive` command-line option. | `false` |
| `MSBuildLastTaskResult` | Reserved | `true` if the previous task completed without any errors (even if there were warnings), or `false` if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never `false`, except in these scenarios:<br /><br /> - When the `ContinueOnError` attribute of the [Task element (MSBuild)](../msbuild/task-element-msbuild.md) is set to `WarnAndContinue` (or `true`) or `ErrorAndContinue`.<br /><br /> - When the `Target` has an [OnError element (MSBuild)](../msbuild/onerror-element-msbuild.md) as a child element. | `true` |
| `MSBuildNodeCount` | Reserved | The maximum number of concurrent processes that are used when building. This is the value that you specified for **-maxcpucount** on the command line. If you specified **-maxcpucount** without specifying a value, then `MSBuildNodeCount` specifies the number of processors in the computer. For more information, see [Command-line reference](../msbuild/msbuild-command-line-reference.md) and [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md). | 1 |
| `MSBuildOverrideTasksPath` | Well-known | The location to search for `.overridetasks` files, which can be used to provide custom versions of standard tasks. See [MSBuild tasks](msbuild-tasks.md#overridden-tasks).<br /><br /> Do not include the final backslash in the path. |
| `MSBuildProgramFiles32` | Reserved | The location of the 32-bit program folder; for example, *C:\Program Files (x86)*.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files (x86)`|
| `MSBuildProjectDefaultTargets` | Reserved | The complete list of targets that are specified in the `DefaultTargets` attribute of the `Project` element. For example, the following `Project` element would have an `MSBuildDefaultTargets` property value of `A;B;C`:<br /><br /> `<Project DefaultTargets="A;B;C" >` | `Build`|
| `MSBuildProjectDirectory` | Reserved | The absolute path of the directory where the project file is located, for example *C:\MyCompany\MyProduct*.<br /><br /> Do not include the final backslash on this property. | `C:\Source\Repos\ConsoleApp1\ConsoleApp1` |
| `MSBuildProjectDirectoryNoRoot` | Reserved | The value of the `MSBuildProjectDirectory` property, excluding the root drive.<br /><br /> Do not include the final backslash on this property. | `Source\Repos\ConsoleApp1\ConsoleApp1`|
| `MSBuildProjectExtension` | Reserved | The file name extension of the project file, including the period; for example, *.proj*. | `.csproj`|
| `MSBuildProjectFile` | Reserved | The complete file name of the project file, including the file name extension; for example, *MyApp.proj*. | `ConsoleApp1.csproj`|
| `MSBuildProjectFullPath` | Reserved | The absolute path and complete file name of the project file, including the file name extension; for example, *C:\MyCompany\MyProduct\MyApp.proj*. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj`|
| `MSBuildProjectName` | Reserved | The file name of the project file without the file name extension; for example, *MyApp*. | `ConsoleApp1` |
| `MSBuildRuntimeType` | Reserved | The type of the runtime that is currently executing. Introduced in MSBuild 15. Value may be undefined (prior to MSBuild 15), `Full` indicating that MSBuild is running on the desktop .NET Framework, `Core` indicating that MSBuild is running on .NET Core (for example in `dotnet build`), or `Mono` indicating that MSBuild is running on Mono. | `Full` |
| `MSBuildSDKsPath` | Well-known | The path MSBuild uses to find SDKs. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild\Sdks`|
| `MSBuildSemanticVersion` | Reserved | The full semver 2.0 version of MSBuild assemblies used to build the project. | 16.11.0-preview-21302-05+5e37cc992 |
| `MSBuildStartupDirectory` | Reserved | The absolute path of the folder where MSBuild is called. By using this property, you can build everything below a specific point in a project tree without creating *\<dirs>.proj* files in every directory. Instead, you have just one project—for example, *c:\traversal.proj*, as shown here:<br /><br /> `<Project ...>     <ItemGroup>         <ProjectFiles              Include="$            (MSBuildStartupDirectory)            **\*.csproj"/>     </ItemGroup>     <Target Name="build">         <MSBuild             Projects="@(ProjectFiles)"/>     </Target> </Project>`<br /><br /> To build at any point in the tree, type:<br /><br /> `msbuild c:\traversal.proj`<br /><br /> Do not include the final backslash on this property. | `c:\Source\Repos\ConsoleApp1` |
| `MSBuildThisFile` | Reserved | The file name and file extension portion of `MSBuildThisFileFullPath`. | `ConsoleApp1.csproj` |
| `MSBuildThisFileDirectory` | Reserved | The directory portion of `MSBuildThisFileFullPath`.<br /><br /> Include the final backslash in the path. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\` |
| `MSBuildThisFileDirectoryNoRoot` | Reserved | The directory portion of `MSBuildThisFileFullPath`, excluding the root drive.<br /><br /> Include the final backslash in the path. | `Source\Repos\ConsoleApp1\ConsoleApp1\` |
| `MSBuildThisFileExtension` | Reserved | The file name extension portion of `MSBuildThisFileFullPath`. | `.csproj` |
| `MSBuildThisFileFullPath` | Reserved | The absolute path of the project or targets file that contains the target that is running.<br /><br /> Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj` |
| `MSBuildThisFileName` | Reserved | The file name portion of `MSBuildThisFileFullPath`, without the file name extension. | `ConsoleApp1` |
| `MSBuildToolsPath` | Reserved | The installation path of the MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild\Current\Bin\` |
| `MSBuildToolsPath32` | Well-known | The installation path of the 32-bit MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild\Current\Bin` |
| `MSBuildToolsPath64` | Well-known | The installation path of the 64-bit MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files (x86)\Microsoft Visual Studio\2019\MSBuild\Current\Bin\amd64` |
| `MSBuildToolsVersion` | Reserved | The version of the MSBuild Toolset that is used to build the project.<br /><br /> Note: An MSBuild Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as *csc.exe* and *vbc.exe*. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md), and [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md). | `Current` |
| `MSBuildUserExtensionsPath` | Well-known | This path provides the location for MSBuild installation folder. It can be reset to provide local, per-user customizations. See [Customize your local build](customize-your-local-build.md#msbuildextensionspath-and-msbuilduserextensionspath).<br /><br /> Do not include the final backslash in the path.  |
| `MSBuildVersion` | Reserved | The version of MSBuild used to build the project. <br /><br/> This property can't be overridden, otherwise the error message `MSB4004 - The 'MSBuildVersion' property is reserved, and can't be modified.` is returned. | 16.11.0 |
| `MSBuildWarningsAsErrors` | Well-known | A list of warning codes to treat as errors. | `MSB1234;MSB5678`|
| `MSBuildWarningsAsMessages` | Well-known | A list of warning codes to treat as messages. | `MSB1234;MSB5678`|
| `MSBuildWarningsNotAsErrors` | Well-known | A list of warning codes that should not be promoted to errors even if the `-warnAsError` switch is set to promote all other warnings to errors. Note that it has no effect if that is not true. | `MSB1234;MSB5678`|
| `OS` | Well-known | On Windows, this is inherited from the host operating system. Possible values include "Windows_NT" and "Unix"; can be set to different values on operating systems other than Windows. |
| `RoslynTargetsPath` | Well-known | Path to Roslyn compilers. | `C:\Program Files\Microsoft Visual Studio\2019\MSBuild\Current\Bin\Roslyn` |
| `SDK35ToolsPath` | Well-known | Path to .NET Framework 3.5 tools. |  |
| `SDK40ToolsPath` | Well-known | Path to .NET Framework 4.0 tools. |`C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\` |
| `VsInstallRoot` | Well-known | The Visual Studio installation folder. | `C:\Program Files (x86)\Microsoft Visual Studio\2019`|
| `WindowsSDK80Path` | Well-known | | |
:::moniker-end

:::moniker range=">=vs-2022"

| Property | Reserved or well-known | Description | Example |
|----------------------------------|------------------------| - | - |
| `FrameworkSDKRoot` | Well-known | Path to the root folder for .NET Framework tools. | `C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\` |
| `InnerBuildProperty` | Well-known | Specifies the property name that defines the multitargeting build dimension (applicable only if the current build is a [graph build][graph-build]). | TargetFramework |
| `InnerBuildPropertyValues` | Well-known | Specifies the property name that holds the possible values for the `InnerBuildProperty` (applicable only if the current build is a [graph build][graph-build]).| TargetFrameworks |
| `IsGraphBuild` | Well-known | `True` if this is a [graph build][graph-build]; that is, the `-graphBuild` option is in effect. This option means that MSBuild constructs and builds a project graph. Constructing a graph involves identifying project references to form dependencies. Building that graph involves attempting to build project references prior to the projects that reference them, differing from traditional MSBuild scheduling.| |
| `MSBuildAssemblyVersion` | Reserved | The version of MSBuild assemblies used to build the project. | 17.0 |
| `MSBuildBinPath` | Reserved | The absolute path of the folder where the MSBuild binaries that are currently being used are located (for example, *C:\Windows\Microsoft.Net\Framework\\\<versionNumber>*). This property is useful if you have to refer to files in the MSBuild directory.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64` |
| `MSBuildDisableFeaturesFromVersion` | Reserved | Used by MSBuild and Microsoft SDKs to manage change waves. |
| `MSBuildExtensionsPath` | Well-known | Introduced in the .NET Framework 4: there is no difference between the default values of `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`. You can set the environment variable `MSBUILDLEGACYEXTENSIONSPATH` to a non-null value to enable the behavior of the default value of `MSBuildExtensionsPath` in earlier versions.<br /><br /> In the .NET Framework 3.5 and earlier, the default value of `MSBuildExtensionsPath` points to the path of the MSBuild subfolder under the *\Program Files\\* or *\Program Files (x86)* folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the *\Program Files (x86)* folder. For a 64-bit process on a 64-bit machine, this property points to the *\Program Files* folder.<br /><br /> Do not include the final backslash on this property.<br /><br /> This location is a useful place to put custom target files. For example, your target files could be installed at *\Program Files\MSBuild\MyFiles\Northwind.targets* and then imported in project files by using this XML code:<br /><br /> `<Import Project="$(MSBuildExtensionsPath)\MyFiles\Northwind.targets"/>` | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild`|
| `MSBuildExtensionsPath32` | Well-known | The path of the MSBuild subfolder under the *\Program Files* or *\Program Files (x86)* folder. The path always points to the 32-bit *\Program Files (x86)* folder on a 32-bit machine and *\Program Files* on a 64-bit machine.". See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath64`.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild`|
| `MSBuildExtensionsPath64` | Well-known | The path of the MSBuild subfolder under the *\Program Files* folder. For a 64-bit machine, this path always points to the *\Program Files* folder. For a 32-bit machine, this path is blank. See also `MSBuildExtensionsPath` and `MSBuildExtensionsPath32`.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files\MSBuild`|
| `MSBuildFileVersion` | Reserved | The 4 part version of MSBuild assemblies used to build the project. | 17.4.0.46505 |
| `MSBuildFrameworkToolsPath` | Well-known | The path to the .NET Framework tools that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\` |
| `MSBuildFrameworkToolsPath32` | Well-known | The path to the 32-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\` |
| `MSBuildFrameworkToolsPath64` | Well-known | The path to the 64-bit version of the .NET Framework tools for the same framework version that the currently executing MSBuild was built with, with a trailing slash. |`C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\` |
| `MSBuildInteractive` | Reserved | `true` if MSBuild is running interactively, allowing user input. This setting is controlled by the `-interactive` command-line option. | `false` |
| `MSBuildLastTaskResult` | Reserved | `true` if the previous task completed without any errors (even if there were warnings), or `false` if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never `false`, except in these scenarios:<br /><br /> - When the `ContinueOnError` attribute of the [Task element (MSBuild)](../msbuild/task-element-msbuild.md) is set to `WarnAndContinue` (or `true`) or `ErrorAndContinue`.<br /><br /> - When the `Target` has an [OnError element (MSBuild)](../msbuild/onerror-element-msbuild.md) as a child element. | `true` |
| `MSBuildNodeCount` | Reserved | The maximum number of concurrent processes that are used when building. This is the value that you specified for **-maxcpucount** on the command line. If you specified **-maxcpucount** without specifying a value, then `MSBuildNodeCount` specifies the number of processors in the computer. For more information, see [Command-line reference](../msbuild/msbuild-command-line-reference.md) and [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md). | 1 |
| `MSBuildOverrideTasksPath` | Well-known | The location to search for `.overridetasks` files, which can be used to provide custom versions of standard tasks. See [MSBuild tasks](msbuild-tasks.md#overridden-tasks).<br /><br /> Do not include the final backslash in the path.|
| `MSBuildProgramFiles32` | Reserved | The location of the 32-bit program folder; for example, *C:\Program Files (x86)*.<br /><br /> Do not include the final backslash on this property. | `C:\Program Files (x86)`|
| `MSBuildProjectDefaultTargets` | Reserved | The complete list of targets that are specified in the `DefaultTargets` attribute of the `Project` element. For example, the following `Project` element would have an `MSBuildDefaultTargets` property value of `A;B;C`:<br /><br /> `<Project DefaultTargets="A;B;C" >` | `Build`|
| `MSBuildProjectDirectory` | Reserved | The absolute path of the directory where the project file is located, for example *C:\MyCompany\MyProduct*.<br /><br /> Do not include the final backslash on this property. | `C:\Source\Repos\ConsoleApp1\ConsoleApp1` |
| `MSBuildProjectDirectoryNoRoot` | Reserved | The value of the `MSBuildProjectDirectory` property, excluding the root drive.<br /><br /> Do not include the final backslash on this property. | `Source\Repos\ConsoleApp1\ConsoleApp1`|
| `MSBuildProjectExtension` | Reserved | The file name extension of the project file, including the period; for example, *.proj*. | `.csproj`|
| `MSBuildProjectFile` | Reserved | The complete file name of the project file, including the file name extension; for example, *MyApp.proj*. | `ConsoleApp1.csproj`|
| `MSBuildProjectFullPath` | Reserved | The absolute path and complete file name of the project file, including the file name extension; for example, *C:\MyCompany\MyProduct\MyApp.proj*. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj`|
| `MSBuildProjectName` | Reserved | The file name of the project file without the file name extension; for example, *MyApp*. | `ConsoleApp1` |
| `MSBuildRuntimeType` | Reserved | The type of the runtime that is currently executing. Introduced in MSBuild 15. Value may be undefined (prior to MSBuild 15), `Full` indicating that MSBuild is running on the desktop .NET Framework, `Core` indicating that MSBuild is running on .NET Core (for example in `dotnet build`), or `Mono` indicating that MSBuild is running on Mono. | `Full` |
| `MSBuildStartupDirectory` | Reserved | The absolute path of the folder where MSBuild is called. By using this property, you can build everything below a specific point in a project tree without creating *\<dirs>.proj* files in every directory. Instead, you have just one project—for example, *c:\traversal.proj*, as shown here:<br /><br /> `<Project ...>     <ItemGroup>         <ProjectFiles              Include="$            (MSBuildStartupDirectory)            **\*.csproj"/>     </ItemGroup>     <Target Name="build">         <MSBuild             Projects="@(ProjectFiles)"/>     </Target> </Project>`<br /><br /> To build at any point in the tree, type:<br /><br /> `msbuild c:\traversal.proj`<br /><br /> Do not include the final backslash on this property. | `c:\Source\Repos\ConsoleApp1` |
| `MSBuildThisFile` | Reserved | The file name and file extension portion of `MSBuildThisFileFullPath`. | `ConsoleApp1.csproj` |
| `MSBuildThisFileDirectory` | Reserved | The directory portion of `MSBuildThisFileFullPath`.<br /><br /> Include the final backslash in the path. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\` |
| `MSBuildThisFileDirectoryNoRoot` | Reserved | The directory portion of `MSBuildThisFileFullPath`, excluding the root drive.<br /><br /> Include the final backslash in the path. | `Source\Repos\ConsoleApp1\ConsoleApp1\` |
| `MSBuildThisFileExtension` | Reserved | The file name extension portion of `MSBuildThisFileFullPath`. | `.csproj` |
| `MSBuildThisFileFullPath` | Reserved | The absolute path of the project or targets file that contains the target that is running.<br /><br /> Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file. | `c:\Source\Repos\ConsoleApp1\ConsoleApp1\ConsoleApp1.csproj` |
| `MSBuildThisFileName` | Reserved | The file name portion of `MSBuildThisFileFullPath`, without the file name extension. | `ConsoleApp1` |
| `MSBuildToolsPath` | Reserved | The installation path of the MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64` |
| `MSBuildToolsPath32` | Well-known | The installation path of the 32-bit MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin` |
| `MSBuildToolsPath64` | Well-known | The installation path of the 64-bit MSBuild version that's associated with the value of `MSBuildToolsVersion`.<br /><br /> Do not include the final backslash in the path.<br /><br /> This property cannot be overridden. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\amd64` |
| `MSBuildToolsVersion` | Reserved | The version of the MSBuild Toolset that is used to build the project.<br /><br /> Note: An MSBuild Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as *csc.exe* and *vbc.exe*. For more information, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md), and [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md). | `Current` |
| `MSBuildSDKsPath` | Well-known | The path MSBuild uses to find SDKs. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Sdks`|
| `MSBuildSemanticVersion` | Reserved | The full semver 2.0 version of MSBuild assemblies used to build the project. | 17.4.0-preview-22465-05+6033e4c95 |
| `MSBuildUserExtensionsPath` | Well-known | This path provides the location for MSBuild installation folder. It can be reset to provide local, per-user customizations. See [Customize your local build](customize-your-local-build.md#msbuildextensionspath-and-msbuilduserextensionspath).<br /><br /> Do not include the final backslash in the path.  |
| `MSBuildVersion` | Reserved | The version of MSBuild used to build the project. <br /><br/> This property can't be overridden, otherwise the error message `MSB4004 - The 'MSBuildVersion' property is reserved, and can't be modified.` is returned. | 17.4.0 |
| `MSBuildWarningsAsErrors` | Well-known | A list of warning codes to treat as errors. | `MSB1234;MSB5678`|
| `MSBuildWarningsAsMessages` | Well-known | A list of warning codes to treat as messages. | `MSB1234;MSB5678`|
| `MSBuildWarningsNotAsErrors` | Well-known | A list of warning codes that should not be promoted to errors even if the `-warnAsError` switch is set to promote all other warnings to errors. Note that it has no effect if that is not true. | `MSB1234;MSB5678`|
| `OS` | Well-known | On Windows, this is inherited from the host operating system. Possible values include "Windows_NT" and "Unix"; can be set to different values on operating systems other than Windows. |
| `RoslynTargetsPath` | Well-known | Path to targets for Roslyn compilers. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Current\Bin\Roslyn` |
| `SDK35ToolsPath` | Well-known | Path to .NET Framework 3.5 tools. |  |
| `SDK40ToolsPath` | Well-known | Path to .NET Framework 4.0 tools. |`C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\` |
| `VsInstallRoot` | Well-known | The Visual Studio installation folder. | `C:\Program Files\Microsoft Visual Studio\2022`|
| `WindowsSDK80Path` | Well-known | Path to the Windows 8 SDK. | |
:::moniker-end

## Properties specific to C++ projects

The following properties represent the path to the C++ MSBuild import files, such as `.props` and `.targets` files, for various C++ toolset versions and target operating systems. The files in these folders represent the C++ build infrastructure and are essential for building any C++ project with MSBuild.

| Property | Reserved or well-known | Description | Example |
|----------------------------------|------------------------| - | - |
| `AndroidTargetsPath`| Well-known | Path to C++ MSBuild import files for Android builds. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Microsoft\MDD\Android\V150\` |
| `iOSTargetsPath` | Well-known | Path to C++ MSBuild import files for iOS builds. | `C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Microsoft\MDD\iOS\V150\` |
| `VCTargetsPath` | Well-known | Path to C++ MSBuild files that support the C++ build system. | `C:\Program Files\Microsoft Visual Studio\2022\MSBuild\Microsoft\VC\v170\` |
| `VCTargetsPath10` | Well-known | Path to C++ MSBuild files that support the Visual Studio 2010 toolset. | `C:\Program Files (x86)\MSBuild\Microsoft.Cpp\v4.0\` |
| `VCTargetsPath11` | Well-known | Path to the MSBuild import files for the Visual Studio 2012 (V110) toolset. | `C:\Program Files (x86)\MSBuild\Microsoft.Cpp\v4.0\V110\` |
| `VCTargetsPath12` | Well-known | Path to the MSBuild import files for the Visual Studio 2013 (V120) toolset. | `C:\Program Files (x86)\MSBuild\Microsoft.Cpp\v4.0\V120\` |
| `VCTargetsPath14` | Well-known | Path to the MSBuild import files for the Visual Studio 2015 (V140) toolset. | `C:\Program Files (x86)\MSBuild\Microsoft.Cpp\v4.0\V140\`

## Names that conflict with MSBuild elements

In addition to the above, names corresponding to MSBuild language elements cannot be used for user-defined properties, items, or item metadata:

* VisualStudioProject
* Target
* PropertyGroup
* Output
* ItemGroup
* UsingTask
* ProjectExtensions
* OnError
* ImportGroup
* Choose
* When
* Otherwise

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)

- [MSBuild properties](../msbuild/msbuild-properties.md)

[graph-build]: https://github.com/dotnet/msbuild/blob/58c672337b92d9c9975a70ac445a3a4330fa2940/documentation/specs/static-graph.md