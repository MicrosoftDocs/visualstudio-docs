---
title: Customize your local build | Microsoft Docs
description: Learn about how you can modify the build process just for your own local build, without affecting files that you share with a source code repository.
ms.date: 02/28/2023
ms.topic: conceptual
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

# Customize your local build

When you work in a team that used a code repository like GitHub, source control, or any shared codebase, but you want to customize your builds on your local machine, perhaps temporarily to reproduce a bug or test a different configuration, it can be convenient to keep those customizations separate from the shared project files that are shared with the shared code repository. This article describes some build extensions available in MSBuild that let you make user-specific or local-only custom configurations.

## .user file

*Microsoft.Common.CurrentVersion.targets* imports `$(MSBuildProjectFullPath).user` if it exists, so you can create a file next to your project with that additional extension. For long-term changes you plan to check into source control, prefer changing the project itself, so that future maintainers do not have to know about this extension mechanism.

## MSBuildExtensionsPath and MSBuildUserExtensionsPath

By convention, many core build logic files import

```xml
$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\{TargetFileName}\ImportBefore\*.targets
```

before their contents, and

```xml
$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\{TargetFileName}\ImportAfter\*.targets
```

afterward. This convention allows installed SDKs to augment the build logic of common project types.

The same directory structure is searched in `$(MSBuildUserExtensionsPath)`, which is the per-user folder *%LOCALAPPDATA%\Microsoft\MSBuild*. Files placed in that folder will be imported for all builds of the corresponding project type run under that user's credentials. You can disable the user extensions by setting properties named after the importing file in the pattern `ImportUserLocationsByWildcardBefore{ImportingFileNameWithNoDots}`. For example, setting `ImportUserLocationsByWildcardBeforeMicrosoftCommonProps` to `false` would prevent importing `$(MSBuildUserExtensionsPath)\$(MSBuildToolsVersion)\Imports\Microsoft.Common.props\ImportBefore\*`.

## Custom configuration based on project language

If you need different behaviors depending on the .NET language (C#, Visual Basic, or F#), you can add property groups with conditions that depend on the project file extension in `$(MSBuildProjectExtension)` to define language-specific properties and their values.

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

## Next steps

Explore other possible customization scenarios at [Customize your build](customize-your-build.md).
