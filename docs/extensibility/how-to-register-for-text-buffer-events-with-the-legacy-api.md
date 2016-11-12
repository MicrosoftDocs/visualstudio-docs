---
title: "How to: Register for Text Buffer Events with the Legacy API | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - register for text buffer events"
ms.assetid: 5fc00ced-882c-4b48-b46c-1fa5a2469f94
caps.latest.revision: 13
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
# How to: Register for Text Buffer Events with the Legacy API
If you are accessing the text buffer by using the legacy API, you should register for text buffer events as shown in the following procedure.  
  
### To advise text buffer events  
  
1.  From a pointer to one of the interfaces on <xref:Microsoft.VisualStudio.TextManager.Interop.VsTextBuffer>, call `QueryInterface` for a pointer to <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer>.  
  
2.  Call the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPointContainer.FindConnectionPoint%2A> method, and pass in the interface ID of the events for which you want to register.  
  
     For example, if you want to register for <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLinesEvents>, then pass in an interface ID of IID_IVsTextLinesEvents.  
  
     The text buffer returns a pointer to the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint> interface for the appropriate connection point object.  
  
3.  Using this pointer, call the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.Advise%2A> method, passing in a pointer to your implementation of the events interface for which you want to register, for example, the `IVsTextLinesEvents` interface.  
  
     The environment returns a cookie that you can then use to stop listening to events by calling the <xref:Microsoft.VisualStudio.OLE.Interop.IConnectionPoint.Unadvise%2A> method.  
  
## See Also  
 [Text Buffer Events in the Legacy API](../extensibility/text-buffer-events-in-the-legacy-api.md)