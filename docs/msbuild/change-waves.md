---
title: Change waves
ms.date: 11/6/2020
ms.topic: conceptual
helpviewer_keywords:
- Change waves [MSBuild]
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# Change waves

A *change wave* is a set of behavior changes in MSBuild that you can opt out of by specifying a particular flag as an environment variable. The purpose of this is to warn you of potentially disruptive changes that will become standard functionality later. You can choose to disable the features in a change wave by setting an environment variable. All the features in a specific change wave can only be enabled or disabled together, not individually.

When you upgrade to a new version of MSBuild, changes that are potentially breaking are enabled by default, but if a feature does affect your build in a way that you don't want, you can easily disable that wave of changes, which allows you more time to update your build before enabling the new features. The ability to disable change waves smooths the transition to a new version of MSBuild.

## Opt out of change wave features

To disable the features in a change wave, set the environment variable `MSBuildDisableFeaturesFromVersion` to the change wave (or MSBuild version) that contains the feature you want **disabled**. This version happens to be the version of MSBuild that the features were developed for. See the mapping of change waves to features below.

### MSBuildDisableFeaturesFromVersion Values

| `MSBuildDisableFeaturesFromVersion` Value                         | Result        | Receive Warning? |
| :-------------                                                    | :----------   | :----------: |
| Unset                                                             | All Change Waves will be enabled, meaning all features behind each Change Wave will be enabled.               | No   |
| Any valid & current Change Wave (Ex: `16.8`)                      | All features behind Change Wave `16.8` and higher will be disabled.                                           | No   |
| Invalid Value (Ex: `16.9` when valid waves are `16.8` and `16.10`)| Default to the closest valid value (ascending). Ex: Setting `16.9` will default you to `16.10`.               | No   |
| Out of Rotation (Ex: `17.1` when the highest wave is `17.0`)      | Clamp to the closest valid value. Ex: `17.1` clamps to `17.0`, and `16.5` clamps to `16.8`                    | Yes  |
| Invalid Format (Ex: `16x8`, `17_0`, `garbage`)                    | All Change Waves will be enabled, meaning all features behind each Change Wave will be enabled.               | Yes  |

## Change waves and associated features

## Current Rotation of Change Waves

### 16.8

- [Enable NoWarn](https://github.com/dotnet/msbuild/pull/5671)
- [Truncate Target/Task skipped log messages to 1024 chars](https://github.com/dotnet/msbuild/pull/5553)
- [Don't expand full drive globs with false condition](https://github.com/dotnet/msbuild/pull/5669)

### 16.10

- [Error when a property expansion in a condition has whitespace](https://github.com/dotnet/msbuild/pull/5672)
