---
title: "What's New in Source Control"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "what's new [Visual Studio SDK], source control"
  - "source control [Visual Studio SDK], what's new"
ms.assetid: bcf85418-18fb-4824-9dae-d14bf3d56a77
caps.latest.revision: 28
ms.author: gregvanl
manager: jillfra
---
# What&#39;s New in Source Control in Visual Studio 2015

[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

In [!INCLUDE[vsipsdk](../../includes/vsipsdk-md.md)] you can provide a deeply integrated source control solution by implementing a source control VSPackage. This section describes the features of source control VSPackages and provides an overview of the implementation steps.  
  
## The Source Control VSPackage  
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] supports two types of source control solutions. In all versions of [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], you can still integrate a Source Control Plug-in API-based plug-in. You can also create a VSPackage for source control which provides a deep-integration, [!INCLUDE[vsipsdk](../../includes/vsipsdk-md.md)] path suitable for source control solutions that require a high level of sophistication and autonomy.  
  
 A VSPackage can add almost any kind of functionality to [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. A source control VSPackage provides a complete source control feature for [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], from the UI presented to the user to the back-end communication with the source control system.  
  
 Implementing a source control VSPackage requires an "all or nothing" strategy. The creator of a source control VSPackage must invest a significant amount of effort in implementing a number of source control interfaces and new UI elements (dialog boxes, menus, and toolbars) to cover the entire source control functionality, as well as interfaces required of any package to integrate successfully with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].  
  
 The following steps give a general overview of what is needed to implement a source control package. For details, see [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md).  
  
1. Create a VSPackage that proffers a private source control service.  
  
2. Implement the interfaces in the source control-related services that are proffered by [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] (for example, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2> and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider> interface).  
  
3. Register your source control VSPackage.  
  
4. Implement all source control UI, including menu items, dialog boxes, toolbars, and context menus.  
  
5. All source control-related events are passed to your source control VSackage when it is active and must be handled by your VSPackage.  
  
6. Your source control VSPackage must listen to events such as those implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3> interface as well as Track Project Document (TPD) events (as implemented by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2> interface) and take necessary action.  
  
## See also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2>   
 [Overview](../../extensibility/internals/source-control-integration-overview.md)   
 [Creating a Source Control VSPackage](../../extensibility/internals/creating-a-source-control-vspackage.md)
