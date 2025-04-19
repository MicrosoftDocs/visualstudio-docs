---
title: Secure MSBuild usage best practices
description: Learn about best practices for configuring and running your builds with MSBuild securely.
ms.date: 02/24/2025
ms.topic: how-to
helpviewer_keywords:
- best practices, MSBuild
- MSBuild, best practices
author: jankrivanek
ms.author: jankrivanek
manager: tkapin
ms.subservice: msbuild
---
# Secure MSBuild usage best practices

MSBuild is highly customizable and extendable (see [Customize your build](./customize-your-build.md) for details), so special care should be paid to the proper configuration of the environment and build.

## Restrict Write access to the install location

Install MSBuild (whether with Visual Studio, the .NET SDK, or standalone) into a location where only trusted users have write access.

You can change the build logic by altering or adding various binary and XML files placed next to the MSBuild executable, and to the subfolders of the MSBuild executable. Therefore, only trusted users should be allowed to write to the folder.

### Related configurations
 * [MSBuildExtensionsPath and MSBuildUserExtensionsPath](./customize-your-local-build.md#msbuildextensionspath-and-msbuilduserextensionspath) - specifically `ImportUserLocationsByWildcardBefore{ImportingFileNameWithNoDots}` property that can be used to opt out of the extension logic

## Run build only on sources you know and reviewed

Run MSBuild (for building and restoring projects, but also for opening projects in Visual Studio) only on sources that you fully trust.

MSBuild logic can be extended within the build script files, including your project files, so unknown build logic should be assumed to be capable of executing arbitrary code in the build environment.

### Related configurations
 * [Visual Studio Trust Settings](./../ide/reference/trust-settings.md)
 * [Disabling response files](./msbuild-response-files.md#disabling-response-files)

## Run your build in a verified, dedicated location 

MSBuild can automatically include logic from a folder of your project or solution and any parent folder up to the root of the drive. This includes `.user` files, `[before|after].{solution}.targets` files, `Directory.Build.[props|targets|rsp]` files and others.

Make sure only the authorized users or accounts have write access to the location with your build-related files and any folder in a hierarchic structure up to the root of the drive.

To prevent the unintended inclusion of `Directory.Build.[props|targets|rsp]`, you can include such files in the root of your sources. The file can be an empty MSBuild `Project` element.

### Related configurations 
 * [Customize the build by folder](./customize-by-directory.md)

## Know and review referenced packages and originating feeds

Build logic can be automatically extended by NuGet packages. Such logic is executed upon restore, which includes the logic into your build or compilation execution. Make sure you're familiar with the [NuGet package asset types](/nuget/consume-packages/package-references-in-project-files#controlling-dependency-assets) and their role during the build, compilation and runtime. Specifically the `build`, `buildTransitive`, `buildMultitargeting` and `analyzers` assets are being automatically plugged into (and so automatically executed during) the build, unless they're being explicitly opted out.

Use `ExcludeAssets` whenever you don't need the build or compiler extension logic from a referenced package (or even better, only explicitly `IncludeAssets` the build logic if you want it).

Make sure you're familiar with the current documentation and guidance from the NuGet team. Refer to the [`PackageReference` in project files](/nuget/consume-packages/package-references-in-project-files) document as an authoritative source for this problem.

### Related configurations
 * [Controlling dependency assets](/nuget/consume-packages/package-references-in-project-files#controlling-dependency-assets)

## Know and review build starting script/process

Build logic can be affected by command-line arguments or environment variables, especially those that can result in the injection of plugins (for example, custom loggers) or build logic (for example, build scripts in `MSBuildUserExtensionsPath`). Ensure that you know what command-line arguments and environment variables are applied to the MSBuild process. That way you will better understand how the build logic is affected.

## Use dedicated user account and session to run your build

Don't run under an account that could be used on a same system to previously run unknown processes or scripts, including a different build. Especially if the unrelated build under same user account might have run on sources that aren't fully trusted and known.

MSBuild can source logic from various locations from the user profile (specifically MSBuild SDK automatically includes build logic located in [MSBuildUserExtensionsPath](./customize-your-local-build.md#msbuildextensionspath-and-msbuilduserextensionspath) location), or from locations injectable by environment variables (you can customize `MSBuildUserExtensionsPath` with a MSBuild property with the same name. Such property doesn't have a default value, so it can be sourced from the environment variable with the same name).

### Related configurations 
 * [MSBuildExtensionsPath and MSBuildUserExtensionsPath](./customize-your-local-build.md#msbuildextensionspath-and-msbuilduserextensionspath):  you can set the `ImportUserLocationsByWildcardBefore{ImportingFileNameWithNoDots}` property to `false` to opt out of the auto-inclusion of the specific extension build logic.
