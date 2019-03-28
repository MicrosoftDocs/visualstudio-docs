---
title: "Using and Providing Services | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "examples [Visual Studio SDK], services"
  - "Visual Studio, services"
  - "services"
ms.assetid: c0b415ba-b825-4da0-9faf-8a60a663e302
caps.latest.revision: 42
ms.author: gregvanl
manager: jillfra
---
# Using and Providing Services
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A service is a contract between two VSPackages. One VSPackage offers a specific set of interfaces for another VSPackage to consume. For example, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] offers the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog> service to any VSPackage it loads. This service provides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog> interface, which can be used to write to the activity log. For more information, see [How to: Use the Activity Log](../extensibility/how-to-use-the-activity-log.md).  
  
 VSPackages can offer services of their own by using the <xref:Microsoft.VisualStudio.Shell.Interop.IProfferService> interface..  
  
 Visual Studio offers important services, such as the following:  
  
|IDE service|Description|  
|-----------------|-----------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShell>|Provides access to IDE services dealing with basic functionality, VSPackages, and the registry.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>|Provides basic windowing and UI-related functionality in the IDE, such as the ability to create tools and document windows.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution>|Provides basic solution-related functionality, such as the ability to enumerate projects, create new projects, and monitor project changes.|  
  
## In This Section  
 [Service Essentials](../extensibility/internals/service-essentials.md)  
 Presents the important elements of a Visual Studio service.  
  
 [How to: Get a Service](../extensibility/how-to-get-a-service.md)  
 Discusses how to request (consume) a service.  
  
 [How to: Provide a Service](../extensibility/how-to-provide-a-service.md)  
 Discusses how to provide a service.  
  
 [How to: Provide an Asynchronous Visual Studio Service](../extensibility/how-to-provide-an-asynchronous-visual-studio-service.md)  
 Discusses how to provide an asynchronous service.  
  
 [How to: Troubleshoot Services](../extensibility/how-to-troubleshoot-services.md)  
 Discusses common problems and presents solutions to them.  
  
## Related Sections  
 [Visual Studio SDK](../extensibility/visual-studio-sdk.md)
