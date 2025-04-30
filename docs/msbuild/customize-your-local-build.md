---
title: Customize local builds
description: Customize the build process for local builds without affecting shared files in source code repositories.
ms.date: 04/29/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild

#customer intent: As a builder, I want to customize local builds, so that I can reproduce bugs or test configurations without affecting shared source code files.

---

# Customize your local build

When you work with shared code in a code repository like GitHub, in source control, or with any shared codebase, you can use MSBuild to temporarily customize builds on your local machine. You might want to temporarily reproduce a bug or test a different configuration, and keep those customizations separate from the files in the shared code repository. This article describes some build extensions available in MSBuild that let you make user-specific or local-only custom build configurations.

## Prerequisites

- A Visual Studio project that builds with MSBuild.

## Use the user file

You can use `$(MSBuildProjectFullPath).user`, also called the *user* file in this context, to store extensions, options, or variables that are specific to your local machine. The user file isn't intended to be uploaded to source control, and is automatically checked on `.gitignore`. For more extensive changes, change the project itself, so future maintainers don't have to know about this extension mechanism.

On supported multitargeted projects, the user file is automatically imported in inner builds and outer builds, so you can create this file within the solution. If you're working on another type of build, you can use the user file by creating it within your solution and then importing it in your project file, as follows:

```xml
<Import Project="$(MSBuildProjectFullPath).user" Condition="Exists('$(MSBuildProjectFullPath).user')"/>
```

<a name="msbuildextensionspath-and-msbuilduserextensionspath"></a>
## Use MSBuildExtensionsPath and MSBuildUserExtensionsPath

By convention, many core build logic files import the `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\TargetFileName\ImportBefore\*.targets` file before their contents, and the `$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\TargetFileName\ImportAfter\*.targets` file afterwards. This convention allows installed SDKs to augment the build logic of common project types.

The same directory structure is searched in `$(MSBuildUserExtensionsPath)`, which is the per-user folder *%LOCALAPPDATA%\\Microsoft\\MSBuild*. Files placed in that folder are imported for all builds of the corresponding project type run under that user's credentials.

You can disable the user extensions by setting properties named after the importing file, in the pattern `ImportUserLocationsByWildcardBefore\<ImportingFileNameWithNoDots>`. For example, setting `ImportUserLocationsByWildcardBeforeMicrosoftCommonProps` to `false` prevents importing `$(MSBuildUserExtensionsPath\$(MSBuildToolsVersion)\Imports\Microsoft.Common.props\ImportBefore\*`.

## Create custom conditions based on project language

If you need different behaviors depending on the .NET language: C#, Visual Basic, or F#, you can add property groups with conditions that depend on the project file extension in `<MSBuildProjectExtension>` to define language-specific properties and their values.

```xml
<PropertyGroup Condition="'$(MSBuildProjectExtension)' == '.vbproj'">
   <!-- Put VB-only property definitions here -->
</PropertyGroup>
<PropertyGroup Condition="'$(MSBuildProjectExtension)' == '.fsproj'">
   <!-- Put F#-only property definitions here -->
</PropertyGroup>
<PropertyGroup Condition="'$(MSBuildProjectExtension)' == '.csproj'">
   <!-- Put C#-only property definitions here -->
</PropertyGroup>
```

## Related content

- [Customize your build](customize-your-build.md)
- [Customize solution builds](customize-solution-build.md)
