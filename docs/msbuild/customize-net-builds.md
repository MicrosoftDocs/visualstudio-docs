---
title: Customize .NET builds for computer, VM, container
description: Customize all .NET builds in Visual Studio on a system governed by an installation of MSBuild for a specific computer, virtual machine, or container.
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
# Customize all .NET builds

The techniques in this article are useful when you want to customize all builds run on a specific computer, virtual machine, or container. For example, when you set up a build server, you might need to configure MSBuild settings globally for all builds on the server.  In principle, you could modify the global *Microsoft.Common.Targets* or *Microsoft.Common.Props* files, but there is a better way. You can affect all builds of a certain project type (such as all C# projects) by using certain MSBuild properties and adding certain custom `.targets` and `.props` files.

## Before and after standard .props and .targets files

To affect all C# or Visual Basic builds governed by an installation of MSBuild or Visual Studio, create a file *Custom.Before.Microsoft.Common.Targets* or *Custom.After.Microsoft.Common.Targets* with targets that will run before or after *Microsoft.Common.targets*, or a file *Custom.Before.Microsoft.Common.Props* or *Custom.After.Microsoft.Common.Props* with properties that will be processed before or after *Microsoft.Common.props*.

You can specify the locations of these files by using the following MSBuild properties:

- CustomBeforeMicrosoftCommonProps
- CustomBeforeMicrosoftCommonTargets
- CustomAfterMicrosoftCommonProps
- CustomAfterMicrosoftCommonTargets
- CustomBeforeMicrosoftCSharpTargets
- CustomBeforeMicrosoftVisualBasicTargets
- CustomAfterMicrosoftCSharpTargets
- CustomAfterMicrosoftVisualBasicTargets

The *Common* versions of these properties affect both C# and Visual Basic projects. You can set these properties in the MSBuild command line.

```cmd
msbuild /p:CustomBeforeMicrosoftCommonTargets="C:\build\config\Custom.Before.Microsoft.Common.Targets" MyProject.csproj
```

> [!WARNING]
> Visual Studio uses the custom `.targets` or `.props` files if it finds them in the MSBuild folder whenever it builds any project of the matching type. This can have unintended consequences, and if done incorrectly, can disable the ability of Visual Studio to build on your computer.

## Replace common props file

You can also use the properties `AlternateCommonProps` to specify your own `.props` file to use instead of *Microsoft.Common.props*. If you ever felt the need to customize *Microsoft.Common.props* by modifying it directly, you could instead copy the standard version of that file into another file, and then make your changes only in the alternate version.

The best approach depends on your scenario. Using Visual Studio Extensibility, you can customize the build system and provide a mechanism for installing and managing the customizations.

If you have a dedicated build server and want to ensure that certain targets always execute on all builds of the appropriate project type that execute on that server, then using a global custom `.targets` or `.props` file makes sense.  If you want the custom targets to only execute when certain conditions apply, then use another file location and set the path to that file by setting the appropriate MSBuild property in the MSBuild command line only when needed.

## Related content

- [Customize your build](customize-your-build.md).
