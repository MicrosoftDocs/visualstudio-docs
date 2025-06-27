---
title: MSBuild Server
description: Learn how MSBuild Server supports frequent build scenarios by caching build context over multiple builds.
ms.date: 10/11/2022
ms.topic: overview
helpviewer_keywords:
- MSBuild Server
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild Server

MSBuild Server improves the performance of .NET Core builds, which are invoked when you use the `dotnet build` command from the .NET CLI on Windows, Linux, or Mac .NET Core build environments. Instead of starting the build process each time a build is requested, much of the context is cached in a long-running process so it is available to be reused by the next build.  MSBuild Server is not relevant to Visual Studio builds, because Visual Studio acts as a host for MSBuild and already caches all the necessary context.

MSBuild Server is generally not helpful in CI scenarios such as Azure Pipeline builds, because pipelines typically stand up a build environment on demand for each build and then dispose of it when the build is completed.

## Enable MSBuild Server

MSBuild server is not enabled by default; to enable it, set the environment variable `DOTNET_CLI_USE_MSBUILD_SERVER` to `true` or `1`.

Once enabled, for the first time you start a new build process, the build server is launched. When you start the first build, it enables the cache. The cache is persisted after the completion of the first build; the second build therefore proceeds faster since the startup time is significantly reduced due to the cached information. The cache persists after the build is completed, but after an idle time of 15 minutes, it shuts down. Therefore, it is primarily beneficial in repetitive build scenarios where many builds are requested in close succession.

## Shut down or disable MSBuild Server

There are a few different ways to disable the use of MSBuild server. If you just want to shut down the running server, you can issue the command `dotnet build-server shutdown`.

To disable the feature for all builds on a machine, you can set the system environment variable `DOTNET_CLI_USE_MSBUILD_SERVER` to `0` or `false`. You could also set this variable on a per-project basis in a tool like VS Code in `launch.json`.

To disable MSBuild Server for a particular invocation of a command-line build, you can use the option `/nr:false` (or `/node-reuse:false`).

To disable the feature entirely, you can opt out of the change wave that enabled it; `SET MSBuildDisableFeaturesFromVersion="17.4"`. This disabled other features in the same change wave. For more information about change waves, see [MSBuild change waves](change-waves.md).

## Determine the current status of the build server

You can view process status on the machine and look for MSBuild server processes. MSBuild server processes are launched with `dotnet.exe` and show a path to MSBuild.dll and the command option `/nodemode:8`, where `8` indicates MSBuild Server ( `/nodemode:1` indicates the normal MSBuild worker nodes).

## See also

- [dotnet build](/dotnet/core/tools/dotnet-build)
- [MSBuild](msbuild.md)
