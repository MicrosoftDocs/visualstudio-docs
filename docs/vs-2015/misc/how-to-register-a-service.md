---
title: "How to: Register a Service | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "services, registering"
ms.assetid: d086be78-ec3c-43cc-b799-5180a71e19f1
caps.latest.revision: 16
manager: jillfra
---
# How to: Register a Service
The managed package framework (MPF) provides attributes to control the registration of managed services. The RegPkg utility uses these attributes to register a service with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
## Example  
 The code that follows is from [VSSDK Samples](../misc/vssdk-samples.md).  
  
 [!code-csharp[VSSDKRegisterService#1](../snippets/csharp/VS_Snippets_VSSDK/vssdkregisterservice/cs/vssdkregisterservicepackage.cs#1)]
 [!code-vb[VSSDKRegisterService#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkregisterservice/vb/vssdkregisterservicepackage.vb#1)]  
  
 The <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute> registers the SMyGlobalService service with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. For more information about <xref:Microsoft.VisualStudio.Shell.DefaultRegistryRootAttribute> and <xref:Microsoft.VisualStudio.Shell.PackageRegistrationAttribute>, see [Registering and Unregistering VSPackages](../extensibility/registering-and-unregistering-vspackages.md).  
  
 To register a service that replaces another service with the same name, use the <xref:Microsoft.VisualStudio.Shell.ProvideServiceOverrideAttribute> instead of the <xref:Microsoft.VisualStudio.Shell.ProvideServiceAttribute>.  
  
## Robust Programming  
 To make it easier to recompile a service provider without changing the service client, or vice versa, you can define the service and its interfaces in a separate assembly module. The following code is from the IMyGlobalService.cs file in the Reference.Services (C#) sample.  
  
 [!code-csharp[VSSDKRegisterService#2](../snippets/csharp/VS_Snippets_VSSDK/vssdkregisterservice/cs/vssdkregisterservicepackage.cs#2)]
 [!code-vb[VSSDKRegisterService#2](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkregisterservice/vb/vssdkregisterservicepackage.vb#2)]  
  
 The <xref:System.Runtime.InteropServices.ComVisibleAttribute> is required to obtain the interface from unmanaged code.  
  
> [!NOTE]
> Although you could use the same type or GUID for both the service and the interface, we recommend that you separate the two because a service can expose different interfaces.  
  
## See also  
 [Registering VSPackages](../extensibility/internals/registering-vspackages.md)   
 [Service Essentials](../extensibility/internals/service-essentials.md)