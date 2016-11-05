---
title: "VSCodeWindow Object | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VSCodeWindow"
helpviewer_keywords: 
  - "views [Visual Studio SDK], VSCodeWindow object"
  - "VsCodeWindow object"
ms.assetid: cf5fe926-e784-4098-bc01-cac49c7c55c6
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# VSCodeWindow Object
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
 [Figures Edit](http://msdn.microsoft.com/en-us/f08872bd-fd9c-4e36-8cf2-a2a2622ef986)