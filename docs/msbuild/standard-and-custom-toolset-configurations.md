---
title: Standard and Custom Toolset Configurations | Microsoft Docs
description: Learn about standard and custom MSBuild Toolsets, which contain references to tasks, targets, and tools you can use to build an application project.
ms.custom: SEO-VS-2020
ms.date: 01/31/2018
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, custom toolset configurations
- MSBuild, msbuild.exe.config
ms.assetid: 15a048c8-5ad3-448e-b6e9-e3c5d7147ed2
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Standard and custom Toolset configurations

An MSBuild Toolset contains references to tasks, targets, and tools that you can use to build an application project. MSBuild includes a standard Toolset, but you can also create custom Toolsets. For information about how to specify a Toolset, see [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)

## Standard Toolset configurations

::: moniker range=">=vs-2022"
 MSBuild 17.0 includes the following standard Toolsets:

|ToolsVersion|Toolset path (as specified in the MSBuildToolsPath or MSBuildBinPath build property)|
|------------------| - |
|2.0|*\<Windows installation path>\Microsoft.Net\Framework\v2.0.50727\\*|
|3.5|*\<Windows installation path>\Microsoft.NET\Framework\v3.5\\*|
|4.0|*\<Windows installation path>\Microsoft.NET\Framework\v4.0.30319\\*|
|Current|*\<Visual Studio installation path>\MSBuild\Current\Bin*|

 The `ToolsVersion` value determines which Toolset is used by a project that Visual Studio generates. In Visual Studio 2022, the default value is "Current" (no matter what the version specified in the project file), but you can override that attribute by using the **/toolsversion** switch at a command prompt. For information about this attribute and other ways to specify the `ToolsVersion`, see [Overriding ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).

 ::: moniker-end


::: moniker range="vs-2019"
 MSBuild 16.0 includes the following standard Toolsets:

|ToolsVersion|Toolset path (as specified in the MSBuildToolsPath or MSBuildBinPath build property)|
|------------------| - |
|2.0|*\<Windows installation path>\Microsoft.Net\Framework\v2.0.50727\\*|
|3.5|*\<Windows installation path>\Microsoft.NET\Framework\v3.5\\*|
|4.0|*\<Windows installation path>\Microsoft.NET\Framework\v4.0.30319\\*|
|Current|*\<Visual Studio installation path>\MSBuild\Current\bin*|

 The `ToolsVersion` value determines which Toolset is used by a project that Visual Studio generates. In Visual Studio 2019, the default value is "Current" (no matter what the version specified in the project file), but you can override that attribute by using the **/toolsversion** switch at a command prompt. For information about this attribute and other ways to specify the `ToolsVersion`, see [Overriding ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).

 ::: moniker-end

::: moniker range="vs-2017"
 MSBuild 15.0 includes the following standard Toolsets:

|ToolsVersion|Toolset path (as specified in the MSBuildToolsPath or MSBuildBinPath build property)|
|------------------| - |
|2.0|*\<Windows installation path>\Microsoft.Net\Framework\v2.0.50727\\*|
|3.5|*\<Windows installation path>\Microsoft.NET\Framework\v3.5\\*|
|4.0|*\<Windows installation path>\Microsoft.NET\Framework\v4.0.30319\\*|
|15.0|*\<Visual Studio installation path>\MSBuild\15.0\bin*|

 The `ToolsVersion` value determines which Toolset is used by a project that Visual Studio generates. In Visual Studio 2017, the default value is "15.0" (no matter what the version specified in the project file), but you can override that attribute by using the **/toolsversion** switch at a command prompt. For information about this attribute and other ways to specify the `ToolsVersion`, see [Overriding ToolsVersion settings](../msbuild/overriding-toolsversion-settings.md).
 ::: moniker-end

Visual Studio 2017 and later versions do not use a registry key for the path to MSBuild. For versions of MSBuild prior to 15.0 that are installed with Visual Studio 2017, the following registry keys specify the installation path of MSBuild.exe.

|Registry key|Key name|String key value|
|------------------|--------------|----------------------|
|**\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\2.0\\** |**MSBuildToolsPath**|**.NET Framework 2.0 Install Path**|
|**\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\3.5\\** |**MSBuildToolsPath**|**.NET Framework 3.5 Install Path**|
|**\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ MSBuild\ToolsVersions\4.0\\** |**MSBuildToolsPath**|**.NET Framework 4 Install Path**|

### Sub-toolsets

 If the registry key in the previous table has a subkey, MSBuild uses it to determine the path of a sub-toolset that overrides the path in the parent Toolset. The following subkey is an example:

 **\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\12.0\12.0**

 If any properties are defined in both the base Toolset and the selected sub-toolset, the property definitions in the sub-toolset are used. For example, the MSBuild 4.0 Toolset defines `SDK40ToolsPath` to point to the 7.0A SDK, but the MSBuild 4.0\11.0 Toolset defines the same property to point to the 8.0A SDK. If `VisualStudioVersion` is unset, `SDK40ToolsPath` would point to 7.0A, but if `VisualStudioVersion` is set to 11.0, the property would instead point to 8.0A.

 The `VisualStudioVersion` build property indicates whether a sub-toolset becomes active. For example, a `VisualStudioVersion` value of "12.0" specifies the MSBuild 12.0 sub-toolset. For more information, see the Sub-toolsets section of [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md).

> [!NOTE]
> We recommend that you avoid changing these settings. Nevertheless, you can add your own settings and define computer-wide custom Toolset definitions, as the next section describes.

## Custom Toolset definitions

 When a standard Toolset does not fulfill your build requirements, you can create a custom `Toolset`. For example, you may have a build lab scenario in which you must have a separate system for building C++ projects. By using a custom `Toolset`, you can assign custom values to the `ToolsVersion` attribute when run *MSBuild.exe* by using the `/toolsVersion` command-line switch. If you specify the `ToolsVersion` attribute in the project file, it is ignored.

 By doing this, you can also use the `$(MSBuildToolsPath)` property to import *.targets* files from that directory, as well as defining your own custom Toolset properties that can be used for any project that uses that Toolset.

 Specify a custom Toolset in the configuration file for *MSBuild.exe* (or for the custom tool that hosts the MSBuild engine if that is what you are using). For example, the configuration file for *MSBuild.exe* could include the following `Toolset` definition if you wished to define a toolset named *MyCustomToolset*.

```xml
<msbuildToolsets default="MyCustomToolset">
   <toolset toolsVersion="MyCustomToolset">
      <property name="MSBuildToolsPath"
        value="C:\SpecialPath" />
   </toolset>
</msbuildToolsets>
```

 `<msbuildToolsets>` must also be defined in the configuration file, as follows.

```xml
<configSections>
   <section name="msbuildToolsets"
       type="Microsoft.Build.BuildEngine.ToolsetConfigurationSection,
       Microsoft.Build, Version=15.1.0.0, Culture=neutral,
       PublicKeyToken=b03f5f7f11d50a3a">
   </section>
</configSections>
```

> [!NOTE]
> To be read correctly, `<configSections>` must be the first subsection in the `<configuration>` section.

 `ToolsetConfigurationSection` is a custom configuration section that can be used by any MSBuild host for custom configuration. If you use a custom Toolset, a host does not have to do anything to initialize the build engine except provide the configuration file entries.

 The following properties are specific to the value of `ToolsVersion` that is used in projects:

- **$(MSBuildBinPath)** is set to the `ToolsPath` value that is specified either in the registry or in the configuration file where the `ToolsVersion` is defined. The `$(MSBuildToolsPath)` setting in the registry or the configuration file specifies the location of the core tasks and targets. In the project file, this maps to the $(MSBuildBinPath) property, and also to the $(MSBuildToolsPath) property.

- `$(MSBuildToolsPath)` is a reserved property that is supplied by the MSBuildToolsPath property that is specified in the configuration file. (This property replaces `$(MSBuildBinPath)`. However, `$(MSBuildBinPath)` is carried forward for compatibility.) A custom Toolset must define either `$(MSBuildToolsPath)` or `$(MSBuildBinPath)` but not both, unless they both have the same value.

  You can also add custom, ToolsVersion-specific properties to the configuration file by using the same syntax that you use to add the MSBuildToolsPath property. To make these custom properties available to the project file, use the same name as the name of the value that is specified in the configuration file. You may define Toolsets but not sub-toolsets in the configuration file.

## See also

- [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)
