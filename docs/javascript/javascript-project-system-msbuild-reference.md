---
title: "MSBuild properties for JavaScript Project System (JSPS)"
description: Reference for the MSBuild properties and items that are understood by JSPS projects.
ms.date: 11/07/2024
ms.custom: updateeachrelease
ms.topic: reference
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'
---

# MSBuild reference for the JavaScript Project System

This article provides reference information for the MSBuild properties and items that you can use to configure projects based on the JavaScript Project System (JSPS), which use the *.esproj* format.

> [!NOTE]
> The properties described in this article extend the properties MSBuild provides by default. For a list of common MSBuild properties, see [Common MSBuild properties](/visualstudio/msbuild/common-msbuild-project-properties).

## ShouldRun properties

The following MSBuild properties are documented in this section:

- [ShouldRunNpmInstall](#shouldrunnpminstall)
- [ShouldRunBuildScript](#shouldrunbuildscript)

### ShouldRunNpmInstall

The `ShouldRunNpmInstall` property specifies whether to run or not run `npm install` on Build and Restore commands. The default value for the property is `true` if unset.

```xml
<PropertyGroup>
  <ShouldRunNpmInstall>false</ShouldRunNpmInstall>
</PropertyGroup>
```

Two common scenarios where not running `npm install` is desirable are:

1. When a non-npm package manager (such as yarn or pnpm) is used. In this scenario, the best solution is to create a target that runs before `BeforeRestore` to manually run the installation.
2. When a global package installation mechanism exists in the solution that makes running individual installations unnecessary.

### ShouldRunBuildScript

The `ShouldRunBuildScript` property specifies whether or not to run `npm run build` on Build commands. The default value for the property is `true` if unset.

```xml
<PropertyGroup>
  <ShouldRunBuildScript>false</ShouldRunBuildScript>
</PropertyGroup>
```

For projects containing only JavaScript that don't require building, set this property to `false`. Newly created React, Vue, and Angular projects usually fall in this category. In this scenario, build is used for production and not for debugging. Note that the `Build` and `Publish` commands are separate in JSPS projects, and `Publish` still runs even if this property is set.

## Command Properties

Command properties are properties intended to map common *package.json* scripts to MSBuild targets. Default values are supported for all of these properties, as described in this section.

Set these properties when using package managers other than npm, or scripting engines such as `gulp`.

The following MSBuild properties are described in this section:

- [BuildCommand](#buildcommand)
- [StartupCommand](#startupcommand)
- [TestCommand](#testcommand)
- [CleanCommand](#cleancommand)
- [PublishCommand](#publishcommand)

### BuildCommand

The `BuildCommand` property specifies the behavior for the `build` target. If the associated *package.json* contains a `build` or `compile` script, the default `BuildCommand` value is already set to run them.

To modify the command, include `npm run` when using `npm`.

```xml
<PropertyGroup>
  <BuildCommand>npm run build</BuildCommand>
</PropertyGroup>
```

### StartupCommand

The `StartupCommand` property specifies the behavior for the `dotnet run` target. If the associated `package.json` contains a `start`, `server`, or `dev` script, the default `StartupCommand` value is already set to run these scripts.

If you modify the command, include `npm run` when using `npm`.

```xml
<PropertyGroup>
  <StartupCommand>npm run serve</StartupCommand>
</PropertyGroup>
```

### TestCommand

The `TestCommand` property specifies the behavior for the `test` target. If the associated `package.json` contains a `test` script, the default `TestCommand` value is already set to run this script.

If you modify the command, include `npm run` when using `npm`.

```xml
<PropertyGroup>
  <TestCommand>ng test</TestCommand>
</PropertyGroup>
```

### CleanCommand

The `CleanCommand` property specifies the behavior for the `clean` target. If the associated `package.json` contains a `clean` script, the default `CleanCommand` value is already set to run this script.

If you modify the command, include `npm run` when using `npm`.

```xml
<PropertyGroup>
  <CleanCommand>npm run clean</CleanCommand>
</PropertyGroup>
```

### PublishCommand

The `PublishCommand` property specifies the behavior for the `publish` target. If the associated `package.json` contains a `publish` script, the default `PublishCommand` value is already set to run this script. In npm, it's common to have pre- and post- publish scripts, which will also run.

If you modify the command, include `npm run` when using `npm`.

```xml
<PropertyGroup>
  <PublishCommand>npm run publish</PublishCommand>
</PropertyGroup>
```

## See also

- [MSBuild schema reference](/visualstudio/msbuild/msbuild-project-file-schema-reference)
- [Common MSBuild properties](/visualstudio/msbuild/common-msbuild-project-properties)
- [MSBuild properties for NuGet pack](/nuget/reference/msbuild-targets#pack-target)
- [MSBuild properties for NuGet restore](/nuget/reference/msbuild-targets#restore-properties)
- [Customize a build](/visualstudio/msbuild/customize-your-build)
