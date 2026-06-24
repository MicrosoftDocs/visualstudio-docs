---
title: JavaScript and TypeScript in Visual Studio
description: Learn how Visual Studio provides rich support for JavaScript development, both using JavaScript directly, and also using the TypeScript programming language.
titleSuffix: ""
ms.date: "06/09/2026"
ms.subservice: javascript-typescript
ms.topic: concept-article
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
author: "mikejo5000"
ms.author: "mikejo"
ms.custom: awp-ai
---
# JavaScript and TypeScript in Visual Studio

::: moniker range="visualstudio"
Visual Studio provides rich support for JavaScript development, both using JavaScript directly and also using the [TypeScript programming language](https://www.typescriptlang.org/). TypeScript was developed to provide a more productive and enjoyable JavaScript development experience, especially when developing projects at scale. You can write JavaScript or TypeScript code in Visual Studio for many application types and services.

## JavaScript and TypeScript language service

By default, Visual Studio powers the JavaScript and TypeScript experience with a built-in TypeScript SDK that provides the compiler and language service. This SDK is primarily for JavaScript editing scenarios where your project doesn't have its own TypeScript version installed.

Starting in Visual Studio 2026, the built-in SDK uses the [TypeScript 7 native compiler](https://devblogs.microsoft.com/visualstudio/typescript-7-beta-now-enabled-by-default-in-visual-studio-2026-18-6-insiders-3/), a native port of the TypeScript compiler and tools that brings significant performance improvements. You see faster IntelliSense and completions, quicker error diagnostics, faster project load times, and improved responsiveness for features like Find All References and Go to Definition. For more information, see [TypeScript 7 Beta Now Enabled by Default](https://devblogs.microsoft.com/visualstudio/typescript-7-beta-now-enabled-by-default-in-visual-studio-2026-18-6-insiders-3/).

### Use a different TypeScript version for the language service

If your project has a local TypeScript version installed (via npm or NuGet), Visual Studio uses that version for the language service instead of the built-in SDK.

- To use TypeScript 6.x (GA), install the TypeScript npm package in your project:

  ```bash
  npm install -D typescript@^6.0.0
  ```

- To pin a specific TypeScript 7 native preview version, install the `@typescript/native-preview` package:

  ```bash
  npm install -D @typescript/native-preview@beta
  ```

To disable the TypeScript 7 native language service entirely, go to **Tools** > **Options** > **Preview Features**, and search for "native preview". Disable **Enable JavaScript/TypeScript Native Language Service Preview**, and then restart Visual Studio.

## TypeScript support

By default, Visual Studio provides language support for JavaScript and TypeScript files to power IntelliSense without any specific project configuration. For compiling TypeScript, Visual Studio gives you the flexibility to choose which version of TypeScript to use on a per-project basis.

In MSBuild compilation scenarios such as ASP.NET Core, the [TypeScript NuGet package](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild) is the recommended method of adding TypeScript compilation support to your project. Visual Studio gives you the option to add this package the first time you add a TypeScript file to your project. You can also add this package at any time through the NuGet package manager. When you use the NuGet package, the corresponding language service version is used for language support in your project.

Projects configured for npm, such as Node.js projects, can specify their own version of the TypeScript language service by adding the [TypeScript npm package](https://www.npmjs.com/package/typescript). You can specify the version by using the npm manager in supported projects.

The separately downloadable TypeScript SDK is no longer available from the Visual Studio Marketplace. Use the NuGet or npm package instead.

> [!TIP]
> Use the TypeScript NuGet or the TypeScript npm package for greater portability across different platforms and environments. For more information, see [Compile TypeScript code using NuGet](../javascript/compile-typescript-code-nuget.md) and [Compile TypeScript code using npm](../javascript/compile-typescript-code-npm.md).

## Project templates

Visual Studio includes a JavaScript/TypeScript project type (.esproj), called the JavaScript Project System (JSPS), which you can use to create standalone Angular, React, and Vue projects in Visual Studio. These front-end projects are created by using the framework CLI tools you install on your local machine, so you choose the version of the template. To migrate from existing Node.js projects to the new project system, see [Migrate Node.js projects](../javascript/migrate-nodejs-projects.md). For MSBuild information for the new project type, see [MSBuild properties for JSPS](../javascript/javascript-project-system-msbuild-reference.md).

Within these new projects, you can run JavaScript and TypeScript unit tests, easily add and connect ASP.NET Core API projects, and download your npm modules by using the npm manager. Check out some of the quickstarts and tutorials to get started. For more information, see [Visual Studio tutorials | JavaScript and TypeScript](/visualstudio/javascript).

::: moniker-end

::: moniker range="vs-2022"
Visual Studio 2022 provides rich support for JavaScript development, both using JavaScript directly, and also using the [TypeScript programming language](https://www.typescriptlang.org/), which was developed to provide a more productive and enjoyable JavaScript development experience, especially when developing projects at scale. You can write JavaScript or TypeScript code in Visual Studio for many application types and services.

## JavaScript language service

The JavaScript experience in Visual Studio 2022 is powered by the same engine that provides TypeScript support. This engine gives you better feature support, richness, and integration immediately out-of-the-box.

The option to restore to the legacy JavaScript language service is no longer available. Users have the new JavaScript language service out-of-the-box. The new language service is solely based on the TypeScript language service, which is powered by static analysis. This service enables us to provide you with better tooling, so your JavaScript code can benefit from richer IntelliSense based on type definitions. The new service is lightweight and consumes less memory than the legacy service, providing you with better performance as your code scales. We also improved performance of the language service to handle larger projects.

## TypeScript support

By default, Visual Studio 2022 provides language support for JavaScript and TypeScript files to power IntelliSense without any specific project configuration.  

For compiling TypeScript, Visual Studio gives you the flexibility to choose which version of TypeScript to use on a per-project basis.

In MSBuild compilation scenarios such as ASP.NET Core, the [TypeScript NuGet package](https://www.nuget.org/packages/Microsoft.TypeScript.MSBuild) is the recommended method of adding TypeScript compilation support to your project. Visual Studio will give you the option to add this package the first time you add a TypeScript file to your project. This package is also available at any time through the NuGet package manager. When the NuGet package is used, the corresponding language service version will be used for language support in your project. Note: The minimum supported version of this package is 3.6.

Projects configured for npm, such as Node.js projects, can specify their own version of the TypeScript language service by adding the [TypeScript npm package](https://www.npmjs.com/package/typescript). You can specify the version using the npm manager in supported projects. Note: The minimum supported version of this package is 2.1.

The separately downloadable TypeScript SDK is no longer available from the Visual Studio Marketplace. Existing projects that rely on the SDK should be upgraded to use the NuGet package.

> [!TIP]
> For projects developed in Visual Studio 2022, we encourage you to use the TypeScript NuGet or the TypeScript npm package for greater portability across different platforms and environments. For more information, see [Compile TypeScript code using NuGet](../javascript/compile-typescript-code-nuget.md) and [Compile TypeScript code using npm](../javascript/compile-typescript-code-npm.md).

## Project templates

Starting in Visual Studio 2022, there is a new JavaScript/TypeScript project type (.esproj), called the JavaScript Project System (JSPS), which allows you to create standalone Angular, React, and Vue projects in Visual Studio. These front-end projects are created using the framework CLI tools you have installed on your local machine, so the version of the template is up to you. To migrate from existing Node.js projects to the new project system, see [Migrate Node.js projects](../javascript/migrate-nodejs-projects.md). For MSBuild information for the new project type, see [MSBuild properties for JSPS](../javascript/javascript-project-system-msbuild-reference.md)

Within these new projects, you can run JavaScript and TypeScript unit tests, easily add and connect ASP.NET Core API projects and download your npm modules using the npm manager. Check out some of the quickstarts and tutorials to get started. For more information, see [Visual Studio tutorials | JavaScript and TypeScript](/visualstudio/javascript).

>[!NOTE]
> A simplified, updated template is available starting in Visual Studio 2022 version 17.5. Compared to the ASP.NET SPA templates available in Visual Studio, the *.esproj* SPA templates for ASP.NET Core provide better npm dependency management, and better build and publish support.

::: moniker-end

