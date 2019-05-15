---
title: "VSCodeWindow Object | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "VSCodeWindow"
helpviewer_keywords: 
  - "views [Visual Studio SDK], VSCodeWindow object"
  - "VsCodeWindow object"
ms.assetid: cf5fe926-e784-4098-bc01-cac49c7c55c6
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# VSCodeWindow Object
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A code window is a specialized document window that can include one or more text views, usually the <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextView> object.  
  
 Architecturally, the code window is a document window that is within a window frame. Functionally, the code window is simply a document window with additional features. In the multiple-document interface (MDI) mode, the code window is the MDI child frame. For more information, see [Customizing Code Windows by Using the Legacy API](../extensibility/customizing-code-windows-by-using-the-legacy-api.md).  
  
 The following table includes the interfaces in the <xref:Microsoft.VisualStudio.TextManager.Interop.VsCodeWindow> object.  
  
|Method|Description|  
|------------|-----------------|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>|Provides a generic access mechanism to locate a service that a globally unique identifier (GUID) identifies.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow>|Represents a multiple document interface (MDI) child containing one or more code views.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane>|Fills a window frame.|  
  
## See Also  
 <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider>   
 [Figures Edit](https://msdn.microsoft.com/f08872bd-fd9c-4e36-8cf2-a2a2622ef986)
