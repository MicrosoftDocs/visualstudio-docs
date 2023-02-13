---
title: Customize your build | Microsoft Docs
description: Learn about several extensibility hooks you can use to customize MSBuild projects that use the standard build process. 
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
# Customize your build

MSBuild projects that use the standard build process (importing *Microsoft.Common.props* and *Microsoft.Common.targets*) have several extensibility hooks that you can use to customize your build process.

Many customizable build operations are controlled by properties. It is important to know how and where to set a property value in order to have the desired effect. You can set properties on the command line (and in response files), in special files like *Directory.Build.props*, in imported files, or in the project file. It is important to know where a property is used, set, or changed and the order of imported files, including implicit imports from SDKs like the .NET SDK.

For a list of properties, see [MSBuild common properties](./common-msbuild-project-properties.md).

## Add arguments to command-line MSBuild invocations for your project

You can set global properties on the command line. Global properties affect all project builds, including dependencies. Recall that building a project automatically triggers a possible build for all project dependencies. The normal behavior of MSBuild is to build any dependent projects that are out-of-date. Those dependent project builds are launched with the same global property settings from the command line as the original project.

A *Directory.Build.rsp* file in or above your source directory will be applied to command-line builds of your project. For details, see [MSBuild response files](../msbuild/msbuild-response-files.md#directorybuildrsp).

### Choose between adding properties to a .props or .targets file

MSBuild is import-order dependent, and the last definition of a property (or a `UsingTask` or target) is the definition used.

When using explicit imports, you can import from a `.props` or `.targets` file at any point. Here is the widely used convention:

- `.props` files are imported early in the import order.

- `.targets`  files are imported late in the build order.

This convention is enforced by `<Project Sdk="SdkName">` imports (that is, the import of *Sdk.props* comes first, before all of the contents of the file, then *Sdk.targets* comes last, after all of the contents of the file).

When deciding where to put the properties, use the following general guidelines:

- For many properties, it doesn't matter where they're defined, because they're not overwritten and will be read only at execution time.

- For behavior that might be customized in an individual project, set defaults in `.props` files.

- Avoid setting dependent properties in `.props` files by reading the value of a possibly customized property, because the customization won't happen until MSBuild reads the user's project.

- Set dependent properties in `.targets` files, because they'll pick up customizations from individual projects.

- If you need to override properties, do it in a `.targets` file, after all user-project customizations have had a chance to take effect. Be cautious when using derived properties; derived properties may need to be overridden as well.

- Include items in `.props` files (conditioned on a property). All properties are considered before any item, so user-project property customizations get picked up, and this gives the user's project the opportunity to `Remove` or `Update` any item brought in by the import.

- Define targets in `.targets` files. However, if the `.targets` file is imported by an SDK, remember that this scenario makes overriding the target more difficult because the user's project doesn't have a place to override it by default.

- If possible, prefer customizing properties at evaluation time over changing properties inside a target. This guideline makes it easier to load a project and understand what it's doing.


## See also

- [MSBuild concepts](../msbuild/msbuild-concepts.md)

- [MSBuild reference](../msbuild/msbuild-reference.md)
