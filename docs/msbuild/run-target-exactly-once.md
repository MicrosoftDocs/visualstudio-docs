---
title: Run an MSBuild target exactly once
description: Configure a .NET project to run a target once and once only, regardless of whether the project is built for multiple frameworks or only one.
ms.date: 1/27/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
# Customer intent: Configure a .NET project to run a target exactly once whether or not you're building for multiple frameworks for only one, for example to increment a version number.
---

# Run a target exactly once

If you're building a .NET project for multiple frameworks using .NET SDK multitargeting, generally each build is a complete build of all relevant targets. However, in some cases, you want a certain target to only run once, for example, a target that increments a version.

## Set up the targets

The solution shown here runs the `MyBeforeBuildTarget` onece and once only regardless of whether a single framework is being built, or if multiple frameworks are being built, without a change in the target itself.

1. Add `Condition` expressions that use the `Multitarget` property to determine whether to build multiple frameworks, or just one.

   ```xml
   <PropertyGroup>
    <TargetFrameworks Condition=" '$(Multitarget)' == 'true' ">net7.0;net8.0</TargetFrameworks>
    <TargetFramework  Condition=" '$(Multitarget)' != 'true' ">net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <SuppressNETCoreSdkPreviewMessage>true</SuppressNETCoreSdkPreviewMessage>
   </PropertyGroup>
   ```

1. Add three targets to the project, yours that you want to run just once (`MyBeforeBuildTarget`), the other two as shown here:

    ```xml
    <Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFrameworks Condition=" '$(Multitarget)' == 'true' ">net7.0;net8.0</TargetFrameworks>
        <TargetFramework  Condition=" '$(Multitarget)' != 'true' ">net8.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
        <SuppressNETCoreSdkPreviewMessage>true</SuppressNETCoreSdkPreviewMessage>
    </PropertyGroup>

    <Target Name="MyBeforeBuildTarget">
        <Warning Text="MyBeforeBuildTarget" />
    </Target>

    <Target Name="TieMyBeforeBuildTargetToOuterBuild"
            DependsOnTargets="MyBeforeBuildTarget"
            BeforeTargets="DispatchToInnerBuilds"
            />

    <Target Name="TieMyBeforeBuildTargetToInnerBuild"
            DependsOnTargets="MyBeforeBuildTarget"
            BeforeTargets="BeforeBuild"
            Condition=" '$(TargetFrameworks)' == '' "
            />
    
    </Project>
    ```

## Build the project

1. From the command line, build without multitargeting:

   `dotnet msbuild -nologo -tl:false -bl -clp:nosummary -p:Multitarget=false`

   ```output
   ExtendMaybeMultitargeted.csproj(12,5): warning : MyBeforeBuildThing
   ExtendMaybeMultitargeted -> ExtendMaybeMultitargeted\bin\Debug\net8.0\ExtendMaybeMultitargeted.dll
   ```

1. Now try building with multitargeting:

   `dotnet msbuild -nologo -tl:false -bl -clp:nosummary -p:Multitarget=true`

   ```output
   ExtendMaybeMultitargeted\ExtendMaybeMultitargeted.csproj(12,5): warning : MyBeforeBuildThing
     ExtendMaybeMultitargeted -> ExtendMaybeMultitargeted\bin\Debug\net8.0\ExtendMaybeMultitargeted.dll
     ExtendMaybeMultitargeted -> ExtendMaybeMultitargeted\bin\Debug\net7.0\ExtendMaybeMultitargeted.dll
   ```

As you can see in the output, the warning was only emitted once regardless of whether multitargeting was used or not.

The solution shown here works because the target you want to run once, `MyBeforeBuildTarget`, is tied to a different target  using`BeforeTargets`, but regardless of whether multitargeting is true or false, the target it's attached to is always one that runs once. The outer build is a single target, `DispatchToInnerBuilds`, that runs the inner build for all the different frameworks specified in `TargetFrameworks`. `DispatchToInnerBuilds` itself only runs once for a multitargeted build, but for a single targeted build, it doesn't run at all. For a single targeted build, you set `BeforeTargets` to `BeforeBuild` as usual to run your target, but the `Condition` makes sure that it's only attached to `BeforeBuild` in the single-targeted case.

## Related content

[.NET SDK multitargeting](net-sdk-multitargeting.md)