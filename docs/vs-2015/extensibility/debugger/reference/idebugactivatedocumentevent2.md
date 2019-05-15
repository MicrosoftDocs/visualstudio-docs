---
title: "IDebugActivateDocumentEvent2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugActivateDocumentEvent2"
helpviewer_keywords: 
  - "IDebugActivateDocumentEvent2 interface"
ms.assetid: 6f37edd7-a48c-4b41-b160-dff9be63a284
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugActivateDocumentEvent2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The debug engine (DE) uses this interface to request a document to be loaded.  
  
## Syntax  
  
```  
IDebugActivateDocumentEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface when it needs a source file to be opened. This interface is implemented only by debug engines that work with or are a part of script interpreters. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when it needs to have a source file opened. The event is sent by using the [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugActivateDocumentEvent2`.  
  
|Methods|Description|  
|-------------|-----------------|  
|[GetDocument](../../../extensibility/debugger/reference/idebugactivatedocumentevent2-getdocument.md)|Gets the document to activate.|  
|[GetDocumentContext](../../../extensibility/debugger/reference/idebugactivatedocumentevent2-getdocumentcontext.md)|Gets the document context that describes the position within the document.|  
  
## Remarks  
 A typical scenario in which this interface is used is if a parse error occurs in script code on an HTML page, the script DE sends this interface to the SDM so that the document with the parse error can be displayed.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)   
 [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)   
 [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
