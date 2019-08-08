---
title: "MSBuild Toolset (ToolsVersion) | Microsoft Docs"
ms.date: "01/31/2018"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, multitargeting"
  - "targeting a specific .NET framework [MSBuild]"
  - "MSBuild, targeting a specific .NET framework"
  - "multitargeting [MSBuild]"
ms.assetid: 40040ee7-4620-4043-a6d8-ccba921421d1
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# MSBuild Toolset (ToolsVersion)

MSBuild uses a Toolset of tasks, targets, and tools to build an application. Typically, a MSBuild Toolset includes a *microsoft.common.tasks* file, a *microsoft.common.targets* file, and compilers such as *csc.exe* and *vbc.exe*. Most Toolsets can be used to compile applications to more than one version of the .NET Framework and more than one system platform. However, the MSBuild 2.0 Toolset can be used to target only the .NET Framework 2.0.

## ToolsVersion attribute
::: moniker range=">=vs-2019"
 Specify the Toolset in the `ToolsVersion` attribute on the [Project](../msbuild/project-element-msbuild.md) element in the project file. The following example specifies that the project should be built by using the MSBuild "Current" Toolset.

```xml
<Project ToolsVersion="Current" ... </Project>
```

::: moniker-end

::: moniker range="vs-2017"
 Specify the Toolset in the `ToolsVersion` attribute on the [Project](../msbuild/project-element-msbuild.md) element in the project file. The following example specifies that the project should be built by using the MSBuild 15.0 Toolset.

```xml
<Project ToolsVersion="15.0" ... </Project>
```

::: moniker-end

> [!NOTE]
> Some project types use the `sdk` attribute instead of `ToolsVersion`. For more information, see [Packages, metadata, and frameworks](/dotnet/core/packages) and [Additions to the csproj format for .NET Core](/dotnet/core/tools/csproj).

## How the ToolsVersion attribute works

 When you create a project in Visual Studio, or upgrade an existing project, an attribute named `ToolsVersion` is automatically included in the project file and its value corresponds to the version of MSBuild that is included in the Visual Studio edition. For more information, see [Framework targeting overview](../ide/visual-studio-multi-targeting-overview.md).

 When a `ToolsVersion` value is defined in a project file, MSBuild uses that value to determine the values of the Toolset properties that are available to the project. One Toolset property is `$(MSBuildToolsPath)`, which specifies the path of the .NET Framework tools. Only that Toolset property (or `$(MSBuildBinPath)`), is required.

 Starting in Visual Studio 2013, the MSBuild Toolset version is the same as the Visual Studio version number. MSBuild defaults to this Toolset within Visual Studio and on the command line, regardless of the Toolset version specified in the project file.  This behavior can be overridden by using the -ToolsVersion flag. For more information, see [Override ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).

 In the following example, MSBuild finds the *Microsoft.CSharp.targets* file by using the `MSBuildToolsPath` reserved property.

```xml
<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
```

 You can modify the value of `MSBuildToolsPath` by defining a custom Toolset. For more information, see [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md).

 When you build a solution on the command line and specify a `ToolsVersion` for *msbuild.exe*, all projects and their project-to-project dependencies are built according to that `ToolsVersion`, even if each project in the solution specifies its own `ToolsVersion`. To define the `ToolsVersion` value on a per project basis, see [Overriding ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).

 The `ToolsVersion` attribute is also used for project migration. For example, if you open a Visual Studio 2008 project in Visual Studio 2010, the project file is updated to include ToolsVersion="4.0". If you then try to open that project in Visual Studio 2008, it doesn't recognize the upgraded `ToolsVersion` and therefore builds the project as though the attribute was still set to 3.5.

 Visual Studio 2010 and Visual Studio 2012 use a ToolsVersion of 4.0. Visual Studio 2013 uses a ToolsVersion of 12.0. Visual Studio 2015 uses ToolsVersion 14.0, and Visual Studio 2017 uses ToolsVersion 15.0. In many cases, you can open the project in multiple versions of Visual Studio without modification. Visual Studio always uses the correct Toolset, but you will be notified if the version used does not match the version in the project file. In almost all cases, this warning is benign as the Toolsets are compatible in most cases.

 Sub-toolsets, which are described later in this topic, allow MSBuild to automatically switch which set of tools to use based on the context in which the build is being run. For example, MSBuild uses a newer set of tools when it's run in Visual Studio 2012 than when it's run in Visual Studio 2010, without your having to explicitly change the project file.

## Toolset implementation

 Implement a Toolset by selecting the paths of the various tools, targets, and tasks that make up the Toolset. The tools in the Toolset that MSBuild defines come from the following sources:

- The .NET Framework folder.

- Additional managed tools.

  The managed tools include *ResGen.exe* and *TlbImp.exe*.

MSBuild provides two ways to access the Toolset:

- By using Toolset properties

- By using <xref:Microsoft.Build.Utilities.ToolLocationHelper> methods

Toolset properties specify the paths of the tools. Starting in Visual Studio 2017, MSBuild no longer has a fixed location. By default, it is located in the *MSBuild\15.0\Bin* folder relative to the Visual Studio installation location. In earlier versions, MSBuild uses the value of the `ToolsVersion` attribute in the project file to locate the corresponding registry key, and then uses the information in the registry key to set the Toolset properties. For example, if `ToolsVersion` has the value `12.0`, then MSBuild sets the Toolset properties according to this registry key: **HKLM\Software\Microsoft\MSBuild\ToolsVersions\12.0**.

 These are Toolset properties:

- `MSBuildToolsPath` specifies the path of the MSBuild binaries.

- `SDK40ToolsPath` specifies the path of additional managed tools for MSBuild 4.x (which could be 4.0 or 4.5).

- `SDK35ToolsPath` specifies the path of additional managed tools for MSBuild 3.5.

Alternately, you can determine the Toolset programmatically by calling the methods of the <xref:Microsoft.Build.Utilities.ToolLocationHelper> class. The class includes these methods:

- <xref:Microsoft.Build.Utilities.ToolLocationHelper.GetPathToDotNetFramework%2A> returns the path of the .NET Framework folder.

- <xref:Microsoft.Build.Utilities.ToolLocationHelper.GetPathToDotNetFrameworkFile%2A> returns the path of a file in the .NET Framework folder.

- <xref:Microsoft.Build.Utilities.ToolLocationHelper.GetPathToDotNetFrameworkSdk%2A> returns the path of the managed tools folder.

- <xref:Microsoft.Build.Utilities.ToolLocationHelper.GetPathToDotNetFrameworkSdkFile%2A> returns the path of a file, which is typically located in the managed tools folder.

- [GetPathToBuildTools](/previous-versions/visualstudio/visual-studio-2013/dn251121(v=vs.121)) returns the path of the build tools.

### Sub-toolsets

 For versions MSBuild prior to 15.0, MSBuild uses a registry key to specify the path of the basic tools. If the key has a subkey, MSBuild uses it to specify the path of a sub-toolset that contains additional tools. In this case, the Toolset is defined by combining the property definitions that are defined in both keys.

> [!NOTE]
> If Toolset property names collide, the value that's defined for the subkey path overrides the value that's defined for the root key path.

 Sub-toolsets become active in the presence of the `VisualStudioVersion` build property. This property may take one of these values:

- "10.0" specifies the .NET Framework 4 sub-toolset

- "11.0" specifies the .NET Framework 4.5 sub-toolset

- "12.0" specifies the .NET Framework 4.5.1 sub-toolset

Sub-toolsets 10.0 and 11.0 should be used with ToolsVersion 4.0. In later versions, the sub-toolset version and the ToolsVersion should match.

During a build, MSBuild automatically determines and sets a default value for the `VisualStudioVersion` property if it's not already defined.

MSBuild provides overloads for the `ToolLocationHelper` methods that add a `VisualStudioVersion` enumerated value as a parameter

Sub-toolsets were introduced in the .NET Framework 4.5.

## See also

- [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md)
- [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
