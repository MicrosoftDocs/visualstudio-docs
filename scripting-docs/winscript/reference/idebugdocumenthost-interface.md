---
title: "IDebugDocumentHost Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugDocumentHost interface"
ms.assetid: 2fed4220-b6a2-47c6-bf28-daad7dd5c42d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugDocumentHost Interface
Exposes host-specific functionality, such as syntax coloring, to the debugger. The `IDebugDocumentHelper::SetDebugDocumentHost` method takes this interface as an argument.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugDocumentHost` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugDocumentHost::GetDeferredText](../../winscript/reference/idebugdocumenthost-getdeferredtext.md)|Returns a range of characters that were added by using `IDebugDocumentHelper::AddDeferredText`, in the original host document.|  
|[IDebugDocumentHost::GetScriptTextAttributes](../../winscript/reference/idebugdocumenthost-getscripttextattributes.md)|Returns the text attributes for a block of document text.|  
|[IDebugDocumentHost::OnCreateDocumentContext](../../winscript/reference/idebugdocumenthost-oncreatedocumentcontext.md)|Notifies the host that a new document context is being created, and allows the host to optionally return an object that controls the new context.|  
|[IDebugDocumentHost::GetPathName](../../winscript/reference/idebugdocumenthost-getpathname.md)|Returns the full path (including the file name) of the document's source file.|  
|[IDebugDocumentHost::GetFileName](../../winscript/reference/idebugdocumenthost-getfilename.md)|Returns the name of the document, without path information.|  
|[IDebugDocumentHost::NotifyChanged](../../winscript/reference/idebugdocumenthost-notifychanged.md)|Notifies the host that the document's source file has been saved and that its contents should be refreshed.|