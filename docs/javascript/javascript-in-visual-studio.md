---
title: JavaScript and TypeScript in Visual Studio
description: Learn how Visual Studio provides rich support for JavaScript development, both using JavaScript directly, and also using the TypeScript programming language.
titleSuffix: ""
ms.date: "01/23/2023"
ms.technology: vs-javascript
ms.topic: conceptual
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
---
# JavaScript and TypeScript in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

::: moniker range=">=vs-2022"
## Overview

Visual Studio 2022 provides rich support for JavaScript development, both using JavaScript directly, and also using the [TypeScript programming language](http://www.typescriptlang.org/), which was developed to provide a more productive and enjoyable JavaScript development experience, especially when developing projects at scale. You can write JavaScript or TypeScript code in Visual Studio for many application types and services. 

## JavaScript Language Service

The JavaScript experience in Visual Studio 2022 is powered by the same engine that provides TypeScript support. This engine gives you better feature support, richness, and integration immediately out-of-the-box.

The option to restore to the legacy JavaScript language service is no longer available. Users have the new JavaScript language service out-of-the-box. The new language service is solely based on the TypeScript language service, which is powered by static analysis. This service enables us to provide you with better tooling, so your JavaScript code can benefit from richer IntelliSense based on type definitions. The new service is lightweight and consumes less memory than the legacy service, providing you with better performance as your code scales. We also improved performance of the language service to handle larger projects.

## TypeScript support

By default, Visual Studio 2022 provides language support for JavaScript and TypeScript files to power IntelliSense without any specific project configuration.  

For compiling TypeScript, Visual Studio gives you the flexibility to choose which version of TypeScript to use on a per-project basis.

In MSBuild compilation scenarios, the [TypeScript NuGet package](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild) is the recommended method of adding TypeScript compilation support to your project. Visual Studio will give you the option to add this package the first time you add a TypeScript file to your project. This package is also available at any time through the NuGet package manager. When the NuGet package is used, the corresponding language service version will be used for language support in your project. Note: The minimum supported version of this package is 3.6.

Projects configured for npm can specify their own version of the TypeScript language service by adding the [TypeScript npm package](https://www.npmjs.com/package/typescript). You can specify the version using the npm manager in supported projects. Note: The minimum supported version of this package is 2.1.

The TypeScript SDK has been deprecated in Visual Studio 2022. Existing projects that rely on the SDK should be upgraded to use the NuGet package. For projects that cannot be upgraded immediately, the SDK is still available on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.typescript-442) and as an optional component in the Visual Studio installer.

> [!TIP] 
> For projects developed in Visual Studio 2022, we encourage you to use the TypeScript NuGet or the TypeScript npm package for greater portability across different platforms and environments. For more information, see [Compile TypeScript code using NuGet](../javascript/compile-typescript-code-nuget.md) and [Compile TypeScript code using tsc](../javascript/compile-typescript-code-npm.md).

## Project Templates 

Starting in Visual Studio 2022, there is a new JavaScript/TypeScript project type (.esproj) that allows you to create standalone Angular, React, and Vue projects in Visual Studio. These front-end projects are created using the framework CLI tools you have installed on your local machine, so the version of the template is up to you.  

Within these new projects, you can run JavaScript and TypeScript unit tests, easily add and connect ASP.NET Core API projects and download your npm modules using the npm manager. Check out some of the quickstarts and tutorials to get started. For more information, see [Visual Studio tutorials | JavaScript and TypeScript](/visualstudio/javascript).
::: moniker-end

::: moniker range="vs-2019"
## Overview

Visual Studio 2019 provides rich support for JavaScript development, both using JavaScript directly, and also using
the [TypeScript programming language](http://www.typescriptlang.org/), which was developed to provide a more
productive and enjoyable JavaScript development experience, especially when developing projects at scale. You can write JavaScript or TypeScript code in Visual Studio for many application types and services.

## JavaScript Language Service

The JavaScript experience in Visual Studio 2019 is powered by the same engine that provides TypeScript support. This gives you better feature support, richness, and integration immediately out-of-the-box.

The option to restore to the legacy JavaScript language service is no longer available. Users now have the new JavaScript language service out-of-the-box. The new language service is solely based on the TypeScript language service, which is powered by static analysis. This enables us to provide you with better tooling, so your JavaScript code can benefit from richer IntelliSense based on type definitions. The new service is lightweight and consumes less memory than the legacy service, providing you with better performance as your code scales. We also improved performance of the language service to handle larger projects.

## TypeScript support

Visual Studio 2019 provides several options for integrating TypeScript compilation into your project:

* The [TypeScript NuGet package](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild). When the NuGet package for TypeScript 3.2 or higher is installed into your project, the corresponding version of the TypeScript language service gets loaded in the editor.
* The [TypeScript npm package](https://www.npmjs.com/package/typescript). When the npm package for TypeScript 2.1 or higher is installed into your project, the corresponding version of the TypeScript language service gets loaded in the editor.
* The TypeScript SDK, available by default in the Visual Studio installer, as well as a standalone SDK download from the [VS Marketplace](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.typescript-395).

> [!TIP]
> For projects developed in Visual Studio 2019, we encourage you to use the TypeScript NuGet or the TypeScript npm package for greater portability across different platforms and environments. For more information, see [Compile TypeScript code using NuGet](../javascript/compile-typescript-code-nuget.md) and [Compile TypeScript code using tsc](../javascript/compile-typescript-code-npm.md).

## Projects

UWP JavaScript apps are no longer supported in Visual Studio 2019. You cannot create or open JavaScript UWP projects (files with extension *.jsproj*). You can learn more using our documentation on [creating Progressive Web Apps (PWAs)](/microsoft-edge/progressive-web-apps-chromium) that run well on Windows.
::: moniker-end
