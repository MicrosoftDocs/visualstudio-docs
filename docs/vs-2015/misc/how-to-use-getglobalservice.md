---
title: "How to: Use GetGlobalService | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "services, GetGlobalService"
ms.assetid: 4cdf5ab5-9f09-4caf-9011-2dcb2c62f1b7
caps.latest.revision: 14
manager: jillfra
---
# How to: Use GetGlobalService
Sometimes you may need to get a service from a tool window or control container that has not been sited, or else has been sited with a service provider that does not know about the service you want. For example, you might want to write to the activity log from within a control. For more information about these and other scenarios, see [How to: Troubleshoot Services](../extensibility/how-to-troubleshoot-services.md).  
  
 You can get most [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] services by calling the static <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> method.  
  
 <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> relies on a cached service provider that is initialized the first time any VSPackage derived from <xref:Microsoft.VisualStudio.Shell.Package> is sited. You must guarantee that this condition is met, or else be prepared for a null service.  
  
 Fortunately, <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> works correctly most of the time.  
  
- If a VSPackage provides a service known only to another VSPackage, the VSPackage requesting the service is sited before the VSPackage providing the service is loaded.  
  
- If a tool window is created by a VSPackage, the VSPackage is sited before the tool window is created.  
  
- If a control container is hosted by a tool window created by a VSPackage, the VSPackage is sited before the control container is created.  
  
### To get a service from within a tool window or control container  
  
- Insert this code in the constructor, tool window, or control container:  
  
     [!code-csharp[UseGetGlobalService#1](../snippets/csharp/VS_Snippets_VSSDK/usegetglobalservice/cs/getglobalservicepackage.cs#1)]
     [!code-vb[UseGetGlobalService#1](../snippets/visualbasic/VS_Snippets_VSSDK/usegetglobalservice/vb/getglobalservicepackage.vb#1)]  
  
     This code obtains an SVsActivityLog service and casts it to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog> interface, which can be used to write to the activity log. For an example, see [How to: Use the Activity Log](../extensibility/how-to-use-the-activity-log.md).  
  
## See also  
 [How to: Troubleshoot Services](../extensibility/how-to-troubleshoot-services.md)   
 [Using and Providing Services](../extensibility/using-and-providing-services.md)   
 [Service Essentials](../extensibility/internals/service-essentials.md)