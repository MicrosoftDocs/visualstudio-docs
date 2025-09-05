---
title: Inside Visual Studio Extensibility SDK
description: Learn about the components that make up the VisualStudio.Extensibility SDK.
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Inside Visual Studio Extensibility SDK

The new Visual Studio Extensibility SDK is built on top of brokered services infrastructure that was introduced in Visual Studio 2019. It primarily consists of:

* A [VisualStudioExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) object that acts as the entry point for the extensibility API. This object has extension methods on it such as `Views()` or `Languages()` that exposes extensibility points of the IDE.

* Wrappers and extension methods around brokered services exposed by [IServiceBroker](/dotnet/api/microsoft.servicehub.framework.iservicebroker) infrastructure with the goal of making services easy to use. In some cases, extension methods should return the contract interface directly.

* Base classes for extension parts, commands and the extension itself, which are used to expose brokered services from extension to Visual Studio IDE. These services are the primary method that Visual Studio calls in to the extension.

* A code generator framework to generate `.vsextension/extension.json` metadata file based on extension parts and its attributes. This file declares the services, extension parts and other services exposed by the extension.

## NuGet packages

The new extensibility model for Visual Studio depends on a set of new NuGet packages to provide APIs, build tooling, code generation and analyzers.

### Microsoft.VisualStudio.Extensibility.Sdk

Link: [Microsoft.VisualStudio.Extensibility.Sdk 17.xxxxx](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility.Sdk/)

This is the primary package that contains dependencies to all prerequisite packages mentioned in the following sections. We strongly recommend extension developers to have a reference to this meta-package instead of individual references.

#### Microsoft.VisualStudio.Extensibility.Build

Link: [Microsoft.VisualStudio.Extensibility.Build 17.xxxxx](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility.Build/)

This package contains the build tooling, project capabilities code generators that are necessary for building the extension and for it to work with F5 debugging in the Visual Studio IDE.

### Dependencies

#### Microsoft.VisualStudio.Extensibility

This package contains the SDK APIs and utility libraries to help develop extensions using the out-of-process extensibility model. Every extension should include a reference to this package as a starting point.

#### Microsoft.VisualStudio.Extensibility.JsonGenerators.Sdk

This package contains the code generators that are necessary for extension metadata to be generated during build. Without this package, a compiled extension may not work correctly as it will not contain the necessary metadata files.

### Optional packages

In future previews, we may have NuGet packages that are not included as a required dependency from `Microsoft.VisualStudio.Extensibility.Sdk` package but can be added as needed to provide APIs for certain feature areas such as debugger, source control.

## Related content

- [Components of a VisualStudio.Extensibility extension](./extension-anatomy.md).
