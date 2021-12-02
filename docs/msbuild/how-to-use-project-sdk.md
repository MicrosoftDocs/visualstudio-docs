---
title: 'How to: Reference an MSBuild Project SDK | Microsoft Docs'
description: Learn how to use MSBuild project SDKs to simplify using software development kits that require properties and targets to be imported.
ms.custom: SEO-VS-2020
ms.date: 01/25/2018
ms.topic: how-to
helpviewer_keywords:
- MSBuild, SDKs, SDK
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# How to: Use MSBuild project SDKs

MSBuild 15.0 introduced the concept of the "project SDK", which simplifies using software development kits that require properties and targets to be imported.

```xml
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <TargetFramework>net46</TargetFramework>
    </PropertyGroup>
</Project>
```

During evaluation of the project, MSBuild adds implicit imports at the top and bottom of the project file:

```xml
<Project>
    <!-- Implicit top import -->
    <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk" />

    <PropertyGroup>
        <TargetFramework>net46</TargetFramework>
    </PropertyGroup>

    <!-- Implicit bottom import -->
    <Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />
</Project>
```

## Reference a project SDK

There are three ways to reference a project SDK:

- Use the `Sdk` attribute on the `<Project/>` element:

    ```xml
    <Project Sdk="My.Custom.Sdk">
        ...
    </Project>
    ```

    An implicit import is added to the top and bottom of the project as discussed previously.
    
    To specify a specific version of the SDK, append it to the `Sdk` attribute:

    ```xml
    <Project Sdk="My.Custom.Sdk/1.2.3">
        ...
    </Project>
    ```

- Use the top-level `<Sdk/>` element:

    ```xml
    <Project>
        <Sdk Name="My.Custom.Sdk" Version="1.2.3" />
        ...
    </Project>
   ```

   An implicit import is added to the top and bottom of the project as discussed previously.
   
   The `Version` attribute is not required.

- Use the `<Import/>` element anywhere in your project:

    ```xml
    <Project>
        <PropertyGroup>
            <MyProperty>Value</MyProperty>
        </PropertyGroup>
        <Import Project="Sdk.props" Sdk="My.Custom.Sdk" />
        ...
        <Import Project="Sdk.targets" Sdk="My.Custom.Sdk" />
    </Project>
   ```

   Explicitly including the imports in your project allows you full control over the order.

   When using the `<Import/>` element, you can specify an optional `Version` attribute as well. For example, you can specify `<Import Project="Sdk.props" Sdk="My.Custom.Sdk" Version="1.2.3" />`.

## How project SDKs are resolved

When evaluating the import, MSBuild dynamically resolves the path to the project SDK based on the name and version you specified.  MSBuild also has a list of registered SDK resolvers, which are plug-ins that locate project SDKs on your machine. These plug-ins include:

- A NuGet-based resolver that queries your configured package feeds for NuGet packages that match the ID and version of the SDK you specified.

   This resolver is only active if you specified an optional version. It can be used for any custom project SDK.
   
- A .NET SDK resolver that resolves MSBuild SDKs that are installed with the [.NET SDK](/dotnet/core/sdk/).

   This resolver locates project SDKs such as `Microsoft.NET.Sdk` and `Microsoft.NET.Sdk.Web` that are part of the product.
   
- A default resolver that resolves SDKs that were installed with MSBuild.

The NuGet-based SDK resolver supports specifying a version in the [global.json](/dotnet/core/tools/global-json) file, which allows you to control the project SDK version in one place rather than in each individual project:

```json
{
    "msbuild-sdks": {
        "My.Custom.Sdk": "5.0.0",
        "My.Other.Sdk": "1.0.0-beta"
    }
}
```

Only one version of each project SDK can be used during a build. If you reference two different versions of the same project SDK, MSBuild emits a warning. It is recommended to **not** specify a version in your projects if a version is specified in the *global.json* file.

## See also

- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [Customize your build](../msbuild/customize-your-build.md)
- [Packages, metadata, and frameworks](/dotnet/core/packages)
- [Additions to the csproj format for .NET Core](/dotnet/core/tools/csproj)
