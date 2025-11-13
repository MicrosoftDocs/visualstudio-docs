---
title: Specify which MSBuild target to build first
description: Learn how to specify the initial targets or the default targets to build first in MSBuild project files.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
ms.topic: how-to
ms.date: 02/28/2025
helpviewer_keywords:
- DefaultTargets attribute [MSBuild]
- MSBuild, specifying the default target
- MSBuild, DefaultTargets attribute

# Customer intent: As a developer, I want to understand how to specify which MSBuild targets to build first so I can control how my project is built.
---

# Specify which MSBuild target to build first

MSBuild project files can contain one or more targets that define how the project is built.
MSBuild builds the first target it finds, and any dependencies, unless:

- The `Project` element contains an `InitialTargets` attribute.
- The `Project` element contains a `DefaultTargets` attribute.
- The MSBuild command has a `-target` switch that specifies a target.

## Use the InitialTargets attribute

The `InitialTargets` attribute of the `Project` element specifies the initial target that runs first. It overrides any targets that you specify with MSBuild on the command line or in the `DefaultTargets` attribute of the `Project` element.

### Specify a single initial target

Specify the default target in the `InitialTargets` attribute of the `Project` element. For example:

```xml
<Project InitialTargets="Clean">
```

### Specify multiple initial targets

You can specify more than one initial target in the `InitialTargets` attribute of the `Project` element. List the targets in order and use a semicolon to separate each target. The targets in the list are run sequentially.

For example, to run the `Clean` target and then the `Compile` target, enter:

```xml
<Project InitialTargets="Clean;Compile">
```

## Use the DefaultTargets attribute

The `DefaultTargets` attribute of the `Project` element specifies which target or targets are built if a target isn't specified explicitly on the command line.

If targets are specified in both the `InitialTargets` and `DefaultTargets` attributes of the `Project` element, and no target is specified on the command line, MSBuild runs the targets specified in the `InitialTargets` attribute followed by the targets specified in the `DefaultTargets` attribute.

### Specify a single default target

Specify the default target in the `DefaultTargets` attribute of the `Project` element. For example:

```xml
<Project DefaultTargets="Compile">`
```

### Specify multiple default targets

You can specify more than one default target in the `DefaultTargets` attribute of the `Project` element. List the default targets in order and use a semicolon to separate each target. The targets in the list are run sequentially.

For example, to run the `Clean` target and then the `Compile` target, enter:

```xml
<Project DefaultTargets="Clean;Compile">
```

## Use the -target switch to override the default target

If a default target isn't defined in the project file, or if you don't want to use the defined default target, you can use the command line switch `-target` to specify a different target. The target or targets specified with the `-target` switch are run instead of the targets specified by the `DefaultTargets` attribute of the `Project` element. Targets specified in the `InitialTargets` attribute always run first.

### Override the default target with a single target

Specify the target to use as the first target by using the `-target` command-line switch with a colon (:) and the name of the target. For example:

```cmd
msbuild file.proj -target:Clean
```

### Override the default target with multiple targets

Specify a list of targets to use as the first targets and separate them by semicolons with the `-target` command-line switch. For example:

```cmd
msbuild <file name>.proj -t:Clean;Compile
```

## Related content

- [MSBuild overview](../msbuild/msbuild.md)
- [MSBuild targets](../msbuild/msbuild-targets.md)
- [Clean a build](../msbuild/how-to-clean-a-build.md)
