---
description: "The debug engine (DE) uses this interface to request a document to be loaded."
title: IDebugActivateDocumentEvent2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugActivateDocumentEvent2
helpviewer_keywords:
- IDebugActivateDocumentEvent2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugActivateDocumentEvent2

The debug engine (DE) uses this interface to request a document to be loaded.

## Syntax

```
IDebugActivateDocumentEvent2 : IUnknown
```

## Notes for Implementers
 The DE implements this interface when it needs a source file to be opened. This interface is implemented only by debug engines that work with or are a part of script interpreters. The [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](/cpp/atl/queryinterface) to access the `IDebugEvent2` interface).

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

## See also
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
- [IDebugEventCallback2](../../../extensibility/debugger/reference/idebugeventcallback2.md)
