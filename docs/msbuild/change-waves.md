---
title: Change waves
description: Learn how to enable or disable features in MSBuild that are potentially disruptive.
ms.date: 5/22/2026
ms.topic: whats-new
helpviewer_keywords:
- Change waves [MSBuild]
- MSBuildDisableFeaturesFromVersion environment variable
author: nitinme
ms.author: nitinme

ms.subservice: msbuild
---
# Change waves

A *change wave* is a set of behavior changes in MSBuild that you can opt out of by specifying a particular flag as an environment variable. The purpose of this is to warn you of potentially disruptive changes so that you have flexibility in adapting to these changes before they become standard functionality. All the features in a specific change wave can only be enabled or disabled together, not individually.

When you upgrade to a new version of MSBuild, changes that are potentially breaking are enabled by default, but if a feature affects your build negatively, you can easily disable that wave of changes. Each change wave is identified by an MSBuild version number (for example, 16.8), but setting the change wave only controls certain features that have the potential to affect the build process, not all the changes in that MSBuild version. A list of the features in each change wave appears [later in this article](#change-waves-and-associated-features). Disabling a change wave also disables change waves of higher versions.

## Opt out of change wave features

To disable the features in a change wave, set the environment variable `MSBuildDisableFeaturesFromVersion` to the change wave (or MSBuild version) that contains the feature you want **disabled**. This is the version of MSBuild that the features were developed for. See the mapping of change waves to features below.

### MSBuildDisableFeaturesFromVersion Values

You will receive a warning and/or default to a specific wave if you don't set `MSBuildDisableFeaturesFromVersion` to a valid change wave. The following table shows the possible settings:

| `MSBuildDisableFeaturesFromVersion` Value                         | Result        | Receive Warning? |
| :-------------                                                    | :----------   | :----------: |
| Unset                                                             | Enable all change waves, meaning all features behind each change wave are enabled.               | No   |
| Any valid and current change wave (for example, `16.8`)                      | Disable all features behind change wave `16.8` **and higher**.                                           | No   |
| Invalid Value (for example, `16.9` when valid waves are `16.8` and `16.10`)| Default to the closest valid value (ascending). For example, setting `16.9` will default you to `16.10`.               | No   |
| Out of Rotation (for example, `17.1` when the highest wave is `17.0`)      | Clamp to the closest valid value. For example, `17.1` clamps to `17.0`, and `16.5` clamps to `16.8`                    | Yes  |
| Invalid Format (for example, `16x8`, `17_0`, `garbage`)                    | Enable all change waves, meaning all features behind each change wave are enabled.               | Yes  |

## Change waves and associated features

### Current Rotation of Change Waves

#### 18.8
- [RAR task: across multiple input properties, resolve relative paths against the project directory (not the process current directory)](https://github.com/dotnet/msbuild/pull/13319)

#### 18.7
- [Copy task retries on ERROR_ACCESS_DENIED on non-Windows platforms to handle transient lock conflicts (e.g. macOS CoW filesystems)](https://github.com/dotnet/msbuild/issues/13463)
- [Fix ASP.NET WebSite projects to resolve netstandard2.0 dependencies](https://github.com/dotnet/msbuild/pull/13058) - Pass TargetFrameworkVersion to RAR task and copy netstandard.dll facade for .NET Framework 4.7.1+ web projects.

#### 18.6
- [AbsolutePath.GetCanonicalForm optimization - avoid expensive Path.GetFullPath calls when paths don't need canonicalization](https://github.com/dotnet/msbuild/pull/13369)
- [TaskHostTask forwards request-level global properties (e.g. MSBuildRestoreSessionId) to out-of-proc TaskHost in -mt mode](https://github.com/dotnet/msbuild/pull/13443)
- [Fix ShouldTreatWarningAsError in OOP TaskHost checking wrong collection (WarningsAsMessages instead of WarningsAsErrors)](https://github.com/dotnet/msbuild/issues/11952)
- [Fix ToolTask hang when tool spawns grandchild processes that inherit stdout/stderr pipe handles](https://github.com/dotnet/msbuild/issues/2981)

#### 18.5
- [FindUnderPath and AssignTargetPath tasks no longer throw on invalid path characters when using TaskEnvironment.GetAbsolutePath](https://github.com/dotnet/msbuild/pull/13069)
- [AssignTargetPath on Linux respects case sensitivity of the file system instead of always ignoring case](https://github.com/dotnet/msbuild/pull/13069)

#### 18.4
- [Start throwing on null or empty paths in MultiProcess and MultiThreaded Task Environment Drivers.](https://github.com/dotnet/msbuild/pull/12914)

### Change waves that will be removed in the release accompanying .NET 11

#### 18.3
- [Replace Transactional property with ChangeWave control, implement atomic file replacement with retry logic, and update tests.](https://github.com/dotnet/msbuild/pull/12627)

#### 17.14
- ~[.SLNX support - use the new parser for .sln and .slnx](https://github.com/dotnet/msbuild/pull/10836)~ reverted after compat problems discovered
- ~~[Support custom culture in RAR](https://github.com/dotnet/msbuild/pull/11000)~~ - see [11607](https://github.com/dotnet/msbuild/pull/11607) for details
- [VS Telemetry](https://github.com/dotnet/msbuild/pull/11255)

#### 17.12
- [Log TaskParameterEvent for scalar parameters](https://github.com/dotnet/msbuild/pull/9908)
- [Convert.ToString during a property evaluation uses the InvariantCulture for all types](https://github.com/dotnet/msbuild/pull/9874)
- [Fix oversharing of build results in ResultsCache](https://github.com/dotnet/msbuild/pull/9987)
- [Add ParameterName and PropertyName to TaskParameterEventArgs](https://github.com/dotnet/msbuild/pull/10130)
- [Emit eval props if requested by any sink](https://github.com/dotnet/msbuild/pull/10243)
- [Load Microsoft.DotNet.MSBuildSdkResolver into default load context (MSBuild.exe only)](https://github.com/dotnet/msbuild/pull/10603)

#### 17.10
- [AppDomain configuration is serialized without using BinFmt](https://github.com/dotnet/msbuild/pull/9320) - feature can be opted out only if [BinaryFormatter](/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter) is allowed at runtime by editing `MSBuild.runtimeconfig.json`. **Please note that [any usage of BinaryFormatter is insecure](/dotnet/standard/serialization/binaryformatter-security-guide).**
- [Warning on serialization custom events by default in .NET framework](https://github.com/dotnet/msbuild/pull/9318)
- [Cache SDK resolver data process-wide](https://github.com/dotnet/msbuild/pull/9335)
- [Target parameters will be unquoted](https://github.com/dotnet/msbuild/pull/9452), meaning  the ';' symbol in the parameter target name will always be treated as separator
- [Add Link metadata to Resources in AssignLinkMetadata target](https://github.com/dotnet/msbuild/pull/9464)
- [Change Version switch output to finish with a newline](https://github.com/dotnet/msbuild/pull/9485)
- [Load NuGet.Frameworks into secondary AppDomain (MSBuild.exe only)](https://github.com/dotnet/msbuild/pull/9446)
- [Update Traits when environment has been changed](https://github.com/dotnet/msbuild/pull/9655)
- [Exec task does not trim leading whitespaces for ConsoleOutput](https://github.com/dotnet/msbuild/pull/9722)
- [Introduce [MSBuild]::StableStringHash overloads](https://github.com/dotnet/msbuild/issues/9519)
- [Keep the encoding of standard output & error consistent with the console code page for ToolTask](https://github.com/dotnet/msbuild/pull/9539)

### Change Waves No Longer In Rotation

#### 16.8
- [Enable NoWarn](https://github.com/dotnet/msbuild/pull/5671)
- [Truncate Target/Task skipped log messages to 1024 chars](https://github.com/dotnet/msbuild/pull/5553)
- [Don't expand full drive globs with false condition](https://github.com/dotnet/msbuild/pull/5669)

#### 16.10
- [Error when a property expansion in a condition has whitespace](https://github.com/dotnet/msbuild/pull/5672)
- [Allow Custom CopyToOutputDirectory Location With TargetPath](https://github.com/dotnet/msbuild/pull/6237)
- [Allow users that have certain special characters in their username to build successfully when using exec](https://github.com/dotnet/msbuild/pull/6223)
- [Fail restore operations when an SDK is unresolveable](https://github.com/dotnet/msbuild/pull/6430)
- [Optimize glob evaluation](https://github.com/dotnet/msbuild/pull/6151)

#### 17.0
- [Scheduler should honor BuildParameters.DisableInprocNode](https://github.com/dotnet/msbuild/pull/6400)
- [Don't compile globbing regexes on .NET Framework](https://github.com/dotnet/msbuild/pull/6632)
- [Default to transitively copying content items](https://github.com/dotnet/msbuild/pull/6622)
- [Reference assemblies are now no longer placed in the `bin` directory by default](https://github.com/dotnet/msbuild/pull/6560) (reverted [here](https://github.com/dotnet/msbuild/pull/6718) and brought back [here](https://github.com/dotnet/msbuild/pull/7075))
- [Improve debugging experience: add global switch MSBuildDebugEngine; Inject binary logger from BuildManager; print static graph as .dot file](https://github.com/dotnet/msbuild/pull/6639)
- [Fix deadlock in BuildManager vs LoggingService](https://github.com/dotnet/msbuild/pull/6837)
- [Optimize diag level for file logger and console logger](https://github.com/dotnet/msbuild/pull/7026)
- [Optimized immutable files up to date checks](https://github.com/dotnet/msbuild/pull/6974)
- [Add Microsoft.IO.Redist for directory enumeration](https://github.com/dotnet/msbuild/pull/6771)
- [Process-wide caching of ToolsetConfigurationSection](https://github.com/dotnet/msbuild/pull/6832)
- [Normalize RAR output paths](https://github.com/dotnet/msbuild/pull/6533)

#### 17.4

- [Respect deps.json when loading assemblies](https://github.com/dotnet/msbuild/pull/7520)
- [Consider `Platform` as default during Platform Negotiation](https://github.com/dotnet/msbuild/pull/7511)
- [Adding accepted SDK name match pattern to SDK manifests](https://github.com/dotnet/msbuild/pull/7597)
- [Throw warning indicating invalid project types](https://github.com/dotnet/msbuild/pull/7708)
- [MSBuild server](https://github.com/dotnet/msbuild/pull/7634)

#### 17.6

- [Parse invalid property under target](https://github.com/dotnet/msbuild/pull/8190)
- [Eliminate project string cache](https://github.com/dotnet/msbuild/pull/7965)
- [Log an error when no provided search path for an import exists](https://github.com/dotnet/msbuild/pull/8095)
- [Log assembly loads](https://github.com/dotnet/msbuild/pull/8316)
- [AnyHaveMetadataValue returns false when passed an empty list](https://github.com/dotnet/msbuild/pull/8603)
- [Log item self-expansion](https://github.com/dotnet/msbuild/pull/8581)

#### 17.8

- [[RAR] Don't do I/O on SDK-provided references](https://github.com/dotnet/msbuild/pull/8688)
- [Delete destination file before copy](https://github.com/dotnet/msbuild/pull/8685)
- [Moving from SHA1 to SHA256 for Hash task](https://github.com/dotnet/msbuild/pull/8812)
- [Deprecating custom derived BuildEventArgs](https://github.com/dotnet/msbuild/pull/8917) - feature can be opted out only if [BinaryFormatter](/dotnet/api/system.runtime.serialization.formatters.binary.binaryformatter) is allowed at runtime by editing `MSBuild.runtimeconfig.json`

## FAQ

**Why target every other release for rotating change waves out?**

We believe this is enough time to have discussions with those affected and assist with adapting to the changes.

**Why an environment variable and not a project property?**

There are scenarios where we want to place a feature under a change wave before MSBuild has loaded the project. For that reason, change waves require using environment variables.

**Why opt-out over opt-in?**

Opt-out is a better approach for us, otherwise we'd likely get limited feedback when a feature impacts customer builds.

## Related content

- [MSBuild](msbuild.md)
- [What's new in MSBuild 16](whats-new-msbuild-16-0.md)
