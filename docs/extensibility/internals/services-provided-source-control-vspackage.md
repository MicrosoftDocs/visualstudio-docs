---
title: Services Provided (Source Control VSPackage)
description: Learn how VSPackages share functionality through services, including interacting with the Visual Studio IDE and its VSPackages.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- services, source control packages
- source control packages, services
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Services Provided (Source Control VSPackage)

Services are the primary mechanism through which functionality is shared among VSPackages and between the Visual Studio integrated development environment (IDE) and its installed VSPackages. For detailed description of services and their importance in the Visual Studio IDE, see [Using and Providing Services](../../extensibility/using-and-providing-services.md).

## The Source Control Service
 Visual Studio provides two layers of services, IDE-level services and package-level services. The Visual Studio IDE natively provides IDE-level services. The source control package consumes some of these services. The source control package as a VSPackage shares its source control functionality by providing a private source control service of its own. The source control package encapsulates the set of source control-related interfaces implemented by it in the form of a contract that can be used by the Visual Studio IDE.

## Related content
- [Design Elements](../../extensibility/internals/source-control-vspackage-design-elements.md)
