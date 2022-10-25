---
title: Find and use a specific version of MSBuild | Microsoft Docs
description: Learn how to ensure that programmatic builds from your application match builds done within Visual Studio or MSBuild.exe, and learn how to locate and use a consistent version on MSBuild when developing a programmatic build application on different machines.
ms.custom: SEO-VS-2020
ms.date: 10/25/2022
ms.topic: conceptual
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Find and use a version of MSBuild

To ensure that programmatic builds from your application match builds done within Visual Studio or *MSBuild.exe*, you might need to load the same version of the MSBuild assemblies that were installed with a specific version of Visual Studio and use the same SDKs that are available within that version of Visual Studio. Or, when you're creating a build application that will be run on machines that might have various installed versions of MSBuild, .NET, and Visual Studio, you might also want to find and use a consistent version of MSBuild. The Microsoft.Build.Locator NuGet package streamlines this process.

## Use Microsoft.Build.Locator

If you redistribute *Microsoft.Build.Locator.dll* with your application, you won't need to distribute other MSBuild assemblies.

Using the locator API requires a few changes in your project, described below. To see an example of the changes required to update a project, see [the commits made to an example project in the MSBuildLocator repository](https://github.com/Microsoft/MSBuildLocator/commits/example-updating-to-msbuild-15).

### Change MSBuild references

To make sure that MSBuild loads from a central location, you must not distribute its assemblies with your application.

The mechanism for changing your project to avoid loading MSBuild from a central location depends on how you reference MSBuild.

#### Use NuGet packages (preferred)

These instructions assume that you're using [PackageReference-style NuGet references](/nuget/consume-packages/package-references-in-project-files).

Change your project file(s) to reference MSBuild assemblies from their NuGet packages. Specify `ExcludeAssets=runtime` to tell NuGet that the assemblies are needed only at build time, and shouldn't be copied to the output directory.

The major and minor version of the MSBuild packages must be less than or equal to the minimum version of Visual Studio you wish to support. For example, if you wish to support Visual Studio 2017 and later versions, reference package version `15.1.548`.

For example, you can use this XML:

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.Build" Version="15.1.548" ExcludeAssets="runtime" />
  <PackageReference Include="Microsoft.Build.Utilities.Core" Version="15.1.548" ExcludeAssets="runtime" />
</ItemGroup>
```

#### Use extension assemblies

If you can't use NuGet packages, you can reference MSBuild assemblies that are distributed with Visual Studio. If you reference MSBuild directly, ensure that it won't be copied to your output directory by setting `Copy Local` to `False`. In the project file, this setting will look like the following code:

```xml
    <Reference Include="Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <Private>False</Private>
    </Reference>
```

> [!NOTE]
> If you're updating from a version of MSBuild prior to 15, MSBuild requires binding redirects for certain assemblies (Microsoft.Build assemblies), but if you reference the Microsoft.Build.Locator package, you ensure that your application automatically uses the required binding redirects to version 15.1.0.0. Binding redirects to this version support MSBuild 15.x, 16.x, and 17.x.

### Ensure output is clean

Build your project and inspect the output directory to make sure that it doesn't contain any *Microsoft.Build.\*.dll* assemblies other than *Microsoft.Build.Locator.dll*, added in the next step.

### Add package reference for Microsoft.Build.Locator

Add a NuGet package reference for [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/).

```xml
    <PackageReference Include="Microsoft.Build.Locator">
      <Version>1.1.2</Version>
    </PackageReference>
```

Do not specify `ExcludeAssets=runtime` for the Microsoft.Build.Locator package.

### Register instance before calling MSBuild

> [!IMPORTANT]
> You cannot reference any MSBuild types (from the `Microsoft.Build` namespace) in the method that calls MSBuildLocator. For example, you cannot do this:
>
> ```csharp
> void ThisWillFail()
> {
>     // Register the most recent version of MSBuild
>     RegisterInstance(QueryVisualStudioInstances.OrderByDescending(version).First())
>     Project p = new Project(SomePath); // Could be any MSBuild type
>     // Code that uses the MSBuild type
> }
> ```
>
> Instead, you must do this:
>
> ```csharp
> void MethodThatDoesNotDirectlyCallMSBuild()
> {
>     // Register the most recent version of MSBuild
>     RegisterInstance(QueryVisualStudioInstances.OrderByDescending(version).First())
>     MethodThatCallsMSBuild();
> }
> 
> void MethodThatCallsMSBuild()
> {
>     Project p = new Project(SomePath);
>     // Code that uses the MSBuild type
> }
> ```

The simplest way to add the call to the Locator API is to add a call to `MSBuildLocator.RegisterInstance`
in your application startup code.

If you would like finer-grained control over the loading of MSBuild, you can select a result of `MSBuildLocator.QueryVisualStudioInstances` to pass to `MSBuildLocator.RegisterInstance` using the custom logic you need. You can also register a specific instance of MSBuild using `MSBuildLocator.RegisterMSBuildPath`.
