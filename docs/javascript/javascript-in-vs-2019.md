---
title: JavaScript and TypeScript in Visual Studio 2019
description: Learn how Visual Studio 2019 provides rich support for JavaScript development, both using JavaScript directly, and also using the TypeScript programming language.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "03/16/2020"
ms.technology: vs-javascript
ms.topic: conceptual
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: '>= vs-2019'
---
# JavaScript and TypeScript in Visual Studio 2019

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

UWP JavaScript apps are no longer supported in Visual Studio 2019. You cannot create or open JavaScript UWP projects (files with extension *.jsproj*). You can learn more using our documentation on [creating Progressive Web Apps (PWAs)](/microsoft-edge/progressive-web-apps/get-started) that run well on Windows.
