---
title: Creating a Source Control VSPackage
description: Learn how to create a source control VSPackage that creates a deep integration path for source control to integrate with Visual Studio.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- source control [Visual Studio SDK], creating source control packages
- source control packages
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a source control VSPackage

This documentation includes links to the architecture overview of a source-control package integrated with Visual Studio, the API that is defined by the interfaces to be implemented and the services to be consumed, and a sample that illustrates a simple source control package implementation.

 With a source control VSPackage, you can create a deep integration path for source control to integrate with Visual Studio. It enables the package to bypass the default source control UI hosted by Visual Studio, respond to source control requests from the project system, and interact with Visual Studio components such as **Solution Explorer**. The Visual Studio SDK empowers Visual Studio partners with a mechanism to create a VSPackage that can integrate with Visual Studio using a service model.

## In this section
- [Get started](../../extensibility/internals/getting-started-with-source-control-vspackages.md)

 Discusses the source control package, which is a more advanced alternative to the source control plug-in for implementing source control features in Visual Studio.

- [Architecture](../../extensibility/internals/source-control-vspackage-architecture.md)

 Presents a diagram and explains the components of a source control package.

- [Features](../../extensibility/internals/source-control-vspackage-features.md)

 Describes the various features of a source control package.

- [Design elements](../../extensibility/internals/source-control-vspackage-design-elements.md)

 Describes the structure of the VSPackage that a source control package must implement for deep integration.

## Related sections
- [Create a source control plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)

 Discusses how to create a source control plug-in that supplies source control functionality in the Visual Studio source control user interface (UI).

- [Source control](../../extensibility/internals/source-control.md)

 Discusses the options for implementing source control as an integrated feature of Visual Studio.
