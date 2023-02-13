---
title: Customize C++ builds | Microsoft Docs
description: Learn about several extensibility hooks you can use to customize MSBuild projects that use the standard build process. 
ms.date: 02/28/2023
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
ms.assetid: d0bceb3b-14fb-455c-805a-63acefa4b3ed
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Customize C++ builds

...

For C++ projects, the previously mentioned custom `.targets` and `.props` files cannot be used in the same way to override default settings. *Directory.Build.props* is imported by *Microsoft.Common.props*, which is imported in `Microsoft.Cpp.Default.props` while most of the defaults are defined in *Microsoft.Cpp.props* and for a number of properties a "if not yet defined" condition cannot be used, as the property is already defined, but the default needs to be different for particular project properties defined in `PropertyGroup` with `Label="Configuration"` (see [.vcxproj and .props file structure](/cpp/build/reference/vcxproj-file-structure)).

But, you can use the following properties to specify `.props` file(s) to be automatically imported before/after *Microsoft.Cpp.\** files:

- ForceImportAfterCppDefaultProps
- ForceImportBeforeCppProps
- ForceImportAfterCppProps
- ForceImportBeforeCppTargets
- ForceImportAfterCppTargets

To customize the default values of properties for all C++ builds, create another `.props` file (say, *MyProps.props*), and define the `ForceImportAfterCppProps` property in `Directory.Build.props` pointing to it:

```xml
<PropertyGroup>
  <ForceImportAfterCppProps>$(MsbuildThisFileDirectory)\MyProps.props</ForceImportAfterCppProps>
</PropertyGroup>
```

*MyProps.props* will be automatically imported at the very end of *Microsoft.Cpp.props*.

## Customize all C++ builds

Customizing the Visual Studio installation isn't recommended, since it's not easy to keep track of such customizations, but if you're extending Visual Studio to customize C++ builds for a particular platform, you can create `.targets` files for each platform and place them in the appropriate import folders for those platforms as part of a Visual Studio extension.

The `.targets` file for the Win32 platform, *Microsoft.Cpp.Win32.targets*, contains the following `Import` element:

```xml
<Import Project="$(VCTargetsPath)\Platforms\Win32\ImportBefore\*.targets"
        Condition="Exists('$(VCTargetsPath)\Platforms\Win32\ImportBefore')"
/>
```

There's a similar element near the end of the same file:

```xml
<Import Project="$(VCTargetsPath)\Platforms\Win32\ImportAfter\*.targets"
        Condition="Exists('$(VCTargetsPath)\Platforms\Win32\ImportAfter')"
/>
```

Similar import elements exist for other target platforms in *%ProgramFiles32%\MSBuild\Microsoft.Cpp\v{version}\Platforms\*.

Once you place the `.targets` file in the appropriate `ImportAfter` folder according to the platform, MSBuild imports your file into every C++ build for that platform. You can put multiple `.targets` files there, if needed. 

Using Visual Studio Extensibility, further customizations are possible, such as defining a new platform. For more information, see [C++ project extensibility](../extensibility/visual-cpp-project-extensibility.md).

### Specify a custom import on the command line

For custom `.targets` that you want to include for a specific build of a C++ project, set one or both of the properties `ForceImportBeforeCppTargets` and `ForceImportAfterCppTargets` on the command line.

```cmd
msbuild /p:ForceImportBeforeCppTargets="C:\build\config\Custom.Before.Microsoft.Cpp.Targets" MyCppProject.vcxproj
```

For a global setting (to affect, say, all C++ builds for a platform on a build server), there are two methods. First, you can set these properties using a system environment variable that is always set. This works because MSBuild always reads the environment and creates (or overrides) properties for all the environment variables.
