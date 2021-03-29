---
title: Using and Providing Services | Microsoft Docs
description: Learn about the services that the Visual Studio IDE offers for VSPackages to provide and use. These articles describe how to get and provide services.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- examples [Visual Studio SDK], services
- Visual Studio, services
- services
ms.assetid: c0b415ba-b825-4da0-9faf-8a60a663e302
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Using and Providing Services
A service is a contract between two VSPackages. One VSPackage offers a specific set of interfaces for another VSPackage to consume. For example, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] offers the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog> service to any VSPackage it loads. This service provides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog> interface, which can be used to write to the activity log. For more information, see [How to: Use the Activity Log](../extensibility/how-to-use-the-activity-log.md).

 VSPackages can offer services of their own by using the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService> interface..

 Visual Studio offers important services, such as the following:

|IDE service|Description|
|-----------------|-----------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShell>|Provides access to IDE services dealing with basic functionality, VSPackages, and the registry.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>|Provides basic windowing and UI-related functionality in the IDE, such as the ability to create tools and document windows.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution>|Provides basic solution-related functionality, such as the ability to enumerate projects, create new projects, and monitor project changes.|

## In This Section
- [Service Essentials](../extensibility/internals/service-essentials.md)
 Presents the important elements of a Visual Studio service.

- [How to: Get a Service](../extensibility/how-to-get-a-service.md)
 Discusses how to request (consume) a service.

- [How to: Provide a Service](../extensibility/how-to-provide-a-service.md)
 Discusses how to provide a service.

- [How to: Provide an Asynchronous Visual Studio Service](../extensibility/how-to-provide-an-asynchronous-visual-studio-service.md)
 Discusses how to provide an asynchronous service.

- [How to: Troubleshoot Services](../extensibility/how-to-troubleshoot-services.md)
 Discusses common problems and presents solutions to them.

## Related Sections
- [Visual Studio SDK](../extensibility/visual-studio-sdk.md)
