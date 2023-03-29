---
title: Inside Visual Studio Extensibility SDK
description: Description of components that make up the SDK.
date: 2021-8-16
---

# Inside Visual Studio Extensibility SDK

The new Visual Studio Extensibility SDK is built on top of brokered services infrastructure that was introduced in Visual Studio 2019. It primarily involves of:

* A `VisualStudioExtensibility` object that acts as the entry point for the extensibility API. This object will have extension methods on it such as `Views()` or `Languages()` that exposes extensibility points of the IDE.

* Wrappers and extension methods around brokered services exposed by [IServiceBroker](https://docs.microsoft.com/en-us/dotnet/api/microsoft.servicehub.framework.iservicebroker?view=visualstudiosdk-2019) infrastructure with the goal of making services easy to use. In some cases, extension methods will return the contract interface directly.

* Base classes for extension parts, commands and the extension itself which are used to expose brokered services from extension to Visual Studio IDE. These services are the primary method that Visual Studio calls in to the extension.

* A code generator framework to generate `.vsextension/extension.json` metadata file based on extension parts and its attributes. This file declares the services, extension parts and other services exposed by the extension.

## Nuget Packages

The new extensibilty model for Visual Studio depends on a set of new nuget packages to provide APIs, build tooling, code generation and analyzers.

### Microsoft.VisualStudio.Extensibility.Sdk

Link: [Microsoft.VisualStudio.Extensibility.Sdk 17.xxxxx](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility.Sdk/17.6.28-preview-1)

This is the primary package that contains dependencies to all pre-requisite packages mentioned below. We strongly recommend extension developers to have a reference to this meta-package instead of individual references.

#### Microsoft.VisualStudio.Extensibility.Build

Link: [Microsoft.VisualStudio.Extensibility.Build 17.xxxxx](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility.Build/17.6.28-preview-1)

This package contains the build tooling, project capabilities code generators that is necessary for extension to work with F5 debugging in Visual Studio IDE.

### Dependencies

#### Microsoft.VisualStudio.Extensibility

This package contains the SDK APIs and utility libraries to help develop extensions using the out-of-process extensibility model. Every extension should include a reference to this package as a starting point.

#### Microsoft.VisualStudio.Extensibility.JsonGenerators.Sdk

This package contains the code generators that is necessary for extension metadata to be generated during build. Without this package, a compiled extension may not work correctly as it will not contain the necessary metadata files.

#### Microsoft.VisualStudio.Extensibility.Editor

This package contains the editor related SDK APIs and utilities and is included as a dependency from `Microsoft.VisualStudio.Extensibility`.

### Optional packages

In future previews, we may have nuget packages that are not included as a required dependency from `Microsoft.VisualStudio.Extensibility.Sdk` package but can be added as needed to provide APIs for certain feature areas such as debugger, source control.