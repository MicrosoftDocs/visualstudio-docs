---
title: "Service Essentials | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "services, essentials"
ms.assetid: fbe84ad9-efe1-48b1-aba3-b50b90424d47
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Service Essentials
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A service is a contract between two VSPackages. One VSPackage provides a specific set of interfaces for another VSPackage to consume. [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] is itself a collection of VSPackages that provides services to other VSPackages.  
  
 For example, you can use the SVsActivityLog service to obtain an IVsActivityLog interface, which you can use to write to the activity log. For more information, see [How to: Use the Activity Log](../../extensibility/how-to-use-the-activity-log.md).  
  
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] also provides some built-in services which are not registered. VSPackages can replace built-in or other services by providing a service override. Only one service override is permitted for any service.  
  
 Services have no discoverability. Therefore, you must know the service identifier (SID) of a service that you want to consume, and you must know which interfaces it provides. The reference documentation for the service provides this information.  
  
- VSPackages that provide services are called service providers.  
  
- Services that are provided to other VSPackages are called global services.  
  
- Services that are available only to the VSPackage that implements them, or to any object it creates, are called local services.  
  
- Services that replace built-in services or services provided by other packages, are called service overrides.  
  
- Services, or service overrides, are loaded on demand, that is, the service provider is loaded when the service it provides is requested by another VSPackage.  
  
- To support on-demand loading, a service provider registers its global services with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. For more information, see [Registering Services](../../misc/registering-services.md).  
  
- After you obtain a service, use [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) (unmanaged code) or casting (managed code) to get the desired interface, for example:  
  
    ```vb  
    TryCast(GetService(GetType(SVsActivityLog)), IVsActivityLog)  
    ```  
  
    ```csharp  
    GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
  
    ```  
  
- Managed code refers to a service by its type, whereas unmanaged code refers to a service by its GUID.  
  
- When [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] loads a VSPackage, it passes a service provider to the VSPackage to give the VSPackage access to global services. This is referred to as "siting" the VSPackage.  
  
- VSPackages can be service providers for the objects they create. For example, a form might send a request for a color service to its frame, which might pass the request to [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].  
  
- Managed objects that are deeply nested, or not sited at all, may call <xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService%2A> for direct access to global services. For more information, see [How to: Use GetGlobalService](../../misc/how-to-use-getglobalservice.md).  
  
## See Also  
 [List of Available Services](../../extensibility/internals/list-of-available-services.md)   
 [Using and Providing Services](../../extensibility/using-and-providing-services.md)   
 [Casting and Type Conversions](https://msdn.microsoft.com/library/568df58a-d292-4b55-93ba-601578722878)   
 [Casting](https://msdn.microsoft.com/library/3dbeb06e-2f4b-4693-832d-624bc8ec95de)
