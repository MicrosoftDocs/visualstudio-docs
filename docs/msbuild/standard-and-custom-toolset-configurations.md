---
title: Create a Custom Toolset Configuration
description: Explore the standard and custom MSBuild Toolsets, which contain references to tasks, targets, and tools you can use to build an application project.
ms.date: 11/10/2022
ms.topic: how-to
helpviewer_keywords:
- MSBuild, custom toolset configurations
- MSBuild, msbuild.exe.config
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Create a custom Toolset configuration

An MSBuild toolset contains references to tasks, targets, and tools that you can use to build an application project. MSBuild includes a standard toolset, but you can also create custom toolsets.

## Standard toolset configurations

MSBuild contains the standard toolset `Current` that references the current version of MSBuild, which is installed to the folder *MSBuild\Current\Bin* under the Visual Studio installation directory.

## Custom toolset definitions

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

## Related content

- [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)
