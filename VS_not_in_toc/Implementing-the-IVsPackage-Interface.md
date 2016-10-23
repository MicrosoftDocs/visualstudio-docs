---
title: "Implementing the IVsPackage Interface"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0c76b2e1-ce63-47fc-93ee-847cad281fc1
caps.latest.revision: 12
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Implementing the IVsPackage Interface
All VSPackages must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage?qualifyHint=False> interface. Visual Studio calls the methods of <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage?qualifyHint=False> to initialize and close VSPackages, to get associated property pages, and for other reasons. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage?qualifyHint=False> interface is the gateway interface between Visual Studio and a VSPackage.  
  
 You can write a managed VSPackage as a subclass of the <xref:Microsoft.VisualStudio.Shell.Package?qualifyHint=False> class, which implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage?qualifyHint=False> on your behalf. For more information, see [Managed VSPackages](../VS_not_in_toc/Managed-VSPackages.md).  
  
> [!NOTE]
>  Much of the unmanaged sample code in the Visual Studio Integration section of the Visual Studio SDK uses the Active Template Library (ATL). You do not need to use ATL to create VSPackages, but you must understand ATL to understand the sample code.  
  
## See Also  
 [VSPackages](../Topic/VSPackages.md)