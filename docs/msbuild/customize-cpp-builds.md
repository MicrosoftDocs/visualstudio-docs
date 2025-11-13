---
title: Customize C++ builds for MSBuild
description: Customize C++ builds done with MSBuild, including how to customize all builds created on a given system, such as a build server.
ms.date: 11/13/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Customize C++ builds

You can use *Directory.Build.props* and *Directory.Build.targets* to customize all the C++ projects under a common parent folder. See [Customize by folder](customize-by-directory.md). In addition, C++ projects provide the following extensibility points. You can use properties to specify `.props` or `.targets` file(s) to be automatically imported before or after *Microsoft.Cpp.\** files:

- ForceImportAfterCppDefaultProps
- ForceImportBeforeCppProps
- ForceImportAfterCppProps
- ForceImportBeforeCppTargets
- ForceImportAfterCppTargets

These imports provide control over the sequence of the definitions of properties that depend on other properties, or targets that depend on other targets. The sequence of imports in a `.vcxproj` looks like this:

&emsp;&emsp;&emsp;vcxproj<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Microsoft.Cpp.default.props<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Microsoft.Common.props<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Directory.Build.props<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Microsoft.Cpp.props<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Microsoft.Cpp.targets<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Microsoft.Common.targets<br/>
&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Directory.Build.targets<br/>

See [.vcxproj and .props file structure](/cpp/build/reference/vcxproj-file-structure). If you need to define properties that use other properties defined in *Microsoft.Cpp.default.props* or *Microsoft.Cpp.props*, you can create another `.props` file (say, *MyProps.props*), and define the `ForceImportAfterCppProps` property in `Directory.Build.props` pointing to it:

```xml
<PropertyGroup>
  <ForceImportAfterCppProps>$(MSBuildThisFileDirectory)\MyProps.props</ForceImportAfterCppProps>
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

For a global setting (to affect, say, all C++ builds for a platform on a build server), there are two methods. First, you can set these properties using a system environment variable that is always set. This technique works because MSBuild always reads the environment and creates (or overrides) properties for all the environment variables.

## Related content

- [Customize your build](customize-your-build.md).
