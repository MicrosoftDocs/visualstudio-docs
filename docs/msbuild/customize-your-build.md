---
title: Customize your build with extensibility hooks
description: Customize your build with several extensibility hooks that you can use to modify MSBuild projects that use the standard build process. 
ms.date: 02/03/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, transforms
- transforms [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Customize your build

MSBuild projects that use the standard build process (importing *Microsoft.Common.props* and *Microsoft.Common.targets*) have several extensibility hooks that you can use to customize your build process.

Many customizable build operations are controlled by properties. It's important to know how and where to set a property value in order to have the desired effect. You can set properties on the command line (and in response files), in special files like *Directory.Build.props*, in imported files, or in the project file. It's important to know where a property is used, set, or changed and the order of imported files, including implicit imports from SDKs like the .NET SDK.

For a list of properties, see [MSBuild common properties](./common-msbuild-project-properties.md).

## Explore customization options

The following customization options are listed in order of increasing complexity and scope of influence. We recommend using the least complex customization option that serves your purpose, starting from the top of this list.

| Customization option | Description |
| - | - |
| [Add arguments to the MSBuild command line](#add-arguments-to-command-line-msbuild-invocations-for-your-project) | Set global properties that affect the main project build and builds of all dependent projects. |
| [Customize the build for a single project](#choose-between-adding-properties-to-a-props-or-targets-file) | Add properties to `.props` or `.targets` files to customize build settings. |
| [Handle generated files in the build process](customize-builds-for-generated-files.md) | How to make sure your generated files are properly included the build output. |
| [Customize the build for one or more projects](customize-by-directory.md) | Add properties to *Directory.Build.props* or add properties and targets to *Directory.Build.targets* to customize the build for all projects under a folder. This technique is useful for setting properties that are set or used by an SDK, as well as scoping customizations so they affect all projects in a folder or subfolder. |
| [Customize your local build](customize-your-local-build.md) | Make changes to the build just on your local machine without affecting shared source files. |
| [Customize all .NET builds](customize-net-builds.md)| Customize the build with system-wide scope, for .NET builds. |
| [Customize C++ builds](customize-cpp-builds.md) | Customize the C++ build, scoped to a project, solution, folder, or all builds governed by an installation of MSBuild on a system. |

## Add arguments to command-line MSBuild invocations for your project

You can set global properties on the command line. Global properties affect all project builds, including dependencies. Recall that building a project automatically triggers a possible build for all project dependencies. The normal behavior of MSBuild is to build any dependent projects that are out-of-date. Those dependent project builds are launched with the same global property settings from the command line as the original project.

A *Directory.Build.rsp* file in or above your source directory is applied to command-line builds of your project. For details, see [MSBuild response files](../msbuild/msbuild-response-files.md#directorybuildrsp).

### Choose between adding properties to a `.props` or `.targets` file

MSBuild is import-order dependent, and the last definition of a property (or a `UsingTask` or target) is the definition used.

When using explicit imports, you can import from a `.props` or `.targets` file at any point. Here's the widely used convention:

- `.props` files are imported early in the import order.

- `.targets`  files are imported late in the build order.

This convention is enforced by `<Project Sdk="SdkName">` imports (that is, the import of *Sdk.props* comes first, before all of the contents of the file, then *Sdk.targets* comes last, after all of the contents of the file).

When deciding where to put the properties, use the following general guidelines:

- For many properties, it doesn't matter where they're defined, because they're not overwritten and are read only at execution time.

- For behavior that might be customized in an individual project, set defaults in `.props` files.

- Avoid setting dependent properties in `.props` files by reading the value of a possibly customized property, because the customization doesn't happen until MSBuild reads the user's project.

- Set dependent properties in `.targets` files, because they pick up customizations from individual projects.

- If you need to override properties, do it in a `.targets` file, after all user-project customizations have had a chance to take effect. Be cautious when using derived properties; derived properties may need to be overridden as well.

- Include items in `.props` files (conditioned on a property). All properties are considered before any item, so user-project property customizations get picked up, and having imported items in `.props` files gives the user's project the opportunity to `Remove` or `Update` any item brought in by the import.

- Define targets in `.targets` files. However, if the `.targets` file is imported by an SDK, remember that this scenario makes overriding the target more difficult because the user's project doesn't have a place to override it by default.

- If possible, prefer customizing properties at evaluation time over changing properties inside a target. This guideline makes it easier to load a project and understand what it's doing.

## Related content

- [MSBuild concepts](../msbuild/msbuild-concepts.md)

- [MSBuild reference](../msbuild/msbuild-reference.md)
