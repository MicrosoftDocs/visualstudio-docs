---
title: "Source Control VSPackage Design Elements | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "source control packages, design elements"
ms.assetid: edd3f2ff-ca32-4465-8ace-4330493b67bb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Source Control VSPackage Design Elements
The topics in this section outline the structure the source control VSPackage must implement for deep integration. It also lists the interfaces and services that the source control VSPackage can implement, and the interfaces and services the source control VSPackage can use from other [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] components to support its source control model and functionality.

## In This Section
- [VSPackage Structure](../../extensibility/internals/vspackage-structure-source-control-vspackage.md)

 Defines the structure of the source control VSPackage.

- [Related Services and Interfaces](../../extensibility/internals/related-services-and-interfaces-source-control-vspackage.md)

 Lists source control package-related interfaces and services.

- [Services Provided](../../extensibility/internals/services-provided-source-control-vspackage.md)

 Describes the source control service provided by the source control VSPackage.

## Related Sections
- [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md)

 Discusses how to create a source control VSPackage that not only supplies source control functionality but can be used to customize the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] source control UI.