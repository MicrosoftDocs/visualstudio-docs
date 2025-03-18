---
title: Find MSBuild and use its API
description: Create a programmatic build app on different machines with the same MSBuild version, and ensure builds from your app match builds in Visual Studio or MSBuild.exe. 
ms.date: 3/10/2025
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Find and use a version of MSBuild

To ensure that programmatic builds from your application match builds done within Visual Studio or *MSBuild.exe*, you might need to load the same version of the MSBuild assemblies that were installed with a specific version of Visual Studio and use the same SDKs that are available within that version of Visual Studio. Or, when you're creating a build application that will be run on machines that might have various installed versions of MSBuild, .NET, and Visual Studio, you might also want to find and use a consistent version of MSBuild. The [Microsoft.Build.Locator](/dotnet/api/microsoft.build.locator) API streamlines this process.

## Use Microsoft.Build.Locator

The [Microsoft.Build.Locator package](https://www.nuget.org/packages/Microsoft.Build.Locator) is relevant to situations where your application runs on client machines, virtual machines, or within containers, either where Visual Studio is installed or in environments where only the Visual Studio Build Tools, or just the .NET SDK is installed, such as when builds are requested with the `dotnet build` command line. In any case, your application needs to find the desired version of MSBuild. That version of MSBuild could be the version that matches Visual Studio, MSBuild.exe, or `dotnet build`, or a particular consistent version regardless of the varying machine configurations in environments where your application might be used.

> [!WARNING]
> The Microsoft.Build.Locator package contains assemblies for .NET Framework and .NET Core (also applicable to .NET 5 and later). In a .NET Framework application, the .NET Framework version of Microsoft.Build.Locator is used, and in a .NET Core application, the .NET Core version is used. However, the .NET Core version can only find instances of MSBuild built with .NET Core, the MSBuild used by `dotnet.exe` in .NET SDK installations, not Visual Studio installations or Visual Studio Build Tools installations. The .NET Framework version of Microsoft.Build.Locator can only see Visual Studio installations, Visual Studio Build Tools installations, not .NET SDK installations. Therefore, it might be necessary to build a tool in two different target framework configurations to target both.

If you redistribute *Microsoft.Build.Locator.dll* with your application, you don't need to distribute other MSBuild assemblies.

Using the locator API requires a few changes in your project, described below. To see an example of the changes required to update a project, see [the commits made to an example project in the MSBuildLocator repository](https://github.com/Microsoft/MSBuildLocator/commits/example-updating-to-msbuild-15).

## Change MSBuild references

To make sure that MSBuild loads from a central location, you must not distribute its assemblies with your application.

The mechanism for changing your project to avoid loading MSBuild from a central location depends on how you reference MSBuild.

### Use NuGet packages (preferred)

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

If you can't use NuGet packages, you can reference MSBuild assemblies that are distributed with Visual Studio. If you reference MSBuild directly, ensure that it isn't copied to your output directory by setting `Copy Local` to `False`. In the project file, this setting resembles the following code:

```xml
    <Reference Include="Microsoft.Build, Version=15.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <Private>False</Private>
    </Reference>
```

> [!NOTE]
> If you're updating from a version of MSBuild prior to 15, MSBuild requires binding redirects for certain assemblies (`Microsoft.Build` assemblies), but if you reference the `Microsoft.Build.Locator` package, you ensure that your application automatically uses the required binding redirects to version 15.1.0.0. Binding redirects to this version support MSBuild 15.x, 16.x, and 17.x.

## Ensure output is clean

Build your project and inspect the output directory to make sure that it doesn't contain any `Microsoft.Build.*.dll` assemblies other than `Microsoft.Build.Locator.dll`, added in the next step.

## Add package reference for Microsoft.Build.Locator

Add a NuGet package reference for [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/).

```xml
    <PackageReference Include="Microsoft.Build.Locator">
      <Version>1.1.2</Version>
    </PackageReference>
```

Don't specify `ExcludeAssets=runtime` for the Microsoft.Build.Locator package.

## Register instance before calling MSBuild

When you're creating a build application for general use, you don't know what versions of Visual Studio, .NET, and MSBuild might be installed on a machine your application is being executed on. The purpose of MSBuildLocator is to find an appropriate installation of MSBuild to use on machines with diverse installation environments. MSBuildLocator allows you to specify some logic to determine which MSBuild to use, but you as the developer of your application need to determine what MSBuild version it requires or can accept, or else provide a way for your users to specify a version, and include logic to translate that choice into appropriate calls to the MSBuildLocator API.

The simplest way to add the call to the Locator API is to add a call to `MSBuildLocator.RegisterInstance`
in your application startup code. One example is to pick the latest version, as shown here, but your application might have it own requirements.

You can't reference any MSBuild types (from the `Microsoft.Build` namespace) in the method that calls MSBuildLocator. For example, you can't use code like the following:

 ```csharp
 void ThisWillFail()
 {
     // Register the most recent version of MSBuild
     RegisterInstance(MSBuildLocator.QueryVisualStudioInstances().OrderByDescending(
        instance => instance.Version).First());
     Project p = new Project(SomePath); // Could be any MSBuild type
     // Code that uses the MSBuild type
 }
 ```

 Instead, write code like this:

 ```csharp
 void MethodThatDoesNotDirectlyCallMSBuild()
 {
     var instance = ... // select which of the installed instances to use
     
     // Register a specific instance of MSBuild
     MSBuildLocator.RegisterInstance(instance);
     MethodThatCallsMSBuild();
 }
 
 void MethodThatCallsMSBuild()
 {
     Project p = new Project(SomePath);
     // Code that uses the MSBuild type
 }
 ```

To specify an MSBuild instance, you can select a result of `MSBuildLocator.QueryVisualStudioInstances` to pass to `MSBuildLocator.RegisterInstance` using the custom logic you need.

## Related content

Learn about MSBuild APIs by consulting the MSBuild API Reference:

- [Microsoft.Build.Evaluation](/dotnet/api/microsoft.build.evaluation)
- [Microsoft.Build.Execution](/dotnet/api/microsoft.build.execution)
- [Microsoft.Build.Framework](/dotnet/api/microsoft.build.framework)
- [Microsoft.Build.Logging](/dotnet/api/microsoft.build.logging)
- [Microsoft.Build.Tasks](/dotnet/api/microsoft.build.tasks)
- [Microsoft.Build.Utilities](/dotnet/api/microsoft.build.utilities)
