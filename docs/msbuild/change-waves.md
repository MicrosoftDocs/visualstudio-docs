---
title: Change waves
description: Learn how to enable or disable features in MSBuild that are potentially disruptive.
ms.date: 11/10/2020
ms.topic: conceptual
helpviewer_keywords:
- Change waves [MSBuild]
- MSBuildDisableFeaturesFromVersion environment variable
author: ghogen
ms.author: ghogen
manager: jillfra
monikerRange: ">=vs-2019"
ms.workload:
- multiple
---
# Change waves

A *change wave* is a set of behavior changes in MSBuild that you can opt out of by specifying a particular flag as an environment variable. The purpose of this is to warn you of potentially disruptive changes that will become standard functionality later, so that you have a time period of flexibility for adapting to these changes before they become standard functionality. All the features in a specific change wave can only be enabled or disabled together, not individually.

When you upgrade to a new version of MSBuild, changes that are potentially breaking are enabled by default, but if a feature affects your build negatively, you can easily disable that wave of changes. Each change wave is identified by an MSBuild version number (for example, 16.8). Disabling a change wave also disables change waves of higher versions.

## Opt out of change wave features

To disable the features in a change wave, set the environment variable `MSBuildDisableFeaturesFromVersion` to the change wave (or MSBuild version) that contains the feature you want **disabled**. This version happens to be the version of MSBuild that the features were developed for. See the mapping of change waves to features below.

### MSBuildDisableFeaturesFromVersion Values

When you set `MSBuildDisableFeaturesFromVersion` to a particular value, you might get a warning if you don't set it to a specific change wave. The following table shows the possible settings:

| `MSBuildDisableFeaturesFromVersion` Value                         | Result        | Receive Warning? |
| :-------------                                                    | :----------   | :----------: |
| Unset                                                             | Enable all change waves, meaning all features behind each change wave are enabled.               | No   |
| Any valid and current change Wave (for example, `16.8`)                      | Disable all features behind change wave `16.8` **and higher**.                                           | No   |
| Invalid Value (for example, `16.9` when valid waves are `16.8` and `16.10`)| Default to the closest valid value (ascending). For example, setting `16.9` will default you to `16.10`.               | No   |
| Out of Rotation (for example, `17.1` when the highest wave is `17.0`)      | Clamp to the closest valid value. For example, `17.1` clamps to `17.0`, and `16.5` clamps to `16.8`                    | Yes  |
| Invalid Format (for example, `16x8`, `17_0`, `garbage`)                    | Enable all change waves, meaning all features behind each change wave are enabled.               | Yes  |

## Change waves and associated features

The links in the list below go to the GitHub PR for the feature.

### 16.8

- [Enable NoWarn](https://github.com/dotnet/msbuild/pull/5671)
- [Truncate Target/Task skipped log messages to 1024 chars](https://github.com/dotnet/msbuild/pull/5553)
- [Don't expand full drive globs with false condition](https://github.com/dotnet/msbuild/pull/5669)

### 16.10

- [Error when a property expansion in a condition has whitespace](https://github.com/dotnet/msbuild/pull/5672)

### 17.0

There are no entries yet in this change wave.

## Change waves that are out of rotation

There are no out of rotation change waves at this time.

## See also

- [MSBuild](msbuild.md)
- [What's new in MSBuild 16](whats-new-msbuild-16-0.md)