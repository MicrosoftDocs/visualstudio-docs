---
title: Customize your local build
description: Customize the build process just for your own local build without affecting files that you share with a source code repository.
ms.date: 02/28/2023
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---

# Customize your local build

When you work in a team that used a code repository like GitHub, source control, or any shared codebase, but you want to customize your builds on your local machine, perhaps temporarily to reproduce a bug or test a different configuration, it can be convenient to keep those customizations separate from the shared project files that are shared with the shared code repository. This article describes some build extensions available in MSBuild that let you make user-specific or local-only custom configurations.

## .user file

Using `$(MSBuildProjectFullPath).user`, also referred as `.user` file in this context, is also an option. This file is intended to keep extensions, options, or variables that are specific to your local machine. It is not intended to be uploaded to source control, and it is automatically checked on `.gitignore`. For more extensive changes prefer changing the project itself, so that future maintainers do not have to know about this extension mechanism.

On supported multitargeted projects the `.user` file is automatically imported in inner builds and outer builds, so you can just create the file within the solution. If you are working on another type of build, you can still use the `.user` file. You can create it within your solution and then import it in your project file.
```xml
<Import Project="$(MSBuildProjectFullPath).user" Condition="Exists('$(MSBuildProjectFullPath).user')"/>
```

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

## Related content

- [Customize your build](customize-your-build.md).
