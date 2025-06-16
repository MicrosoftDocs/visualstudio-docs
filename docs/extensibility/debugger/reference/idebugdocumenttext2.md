---
description: "This interface represents a text document."
title: IDebugDocumentText2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentText2
helpviewer_keywords:
- IDebugDocumentText2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocumentText2

This interface represents a text document.

## Syntax

```
IDebugDocumentText2 : IDebugDocument2
```

## Notes for Implementers
 A debug engine (DE) implements this interface when the source code it needs to supply is in text form. Since this is the most typical case, if a DE implements the [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) interface, it should also implement the `IDebugDocumentText2` interface.

## Notes for Callers
 Use the `QueryInterface` method to obtain this interface from an `IDebugDocument2` interface.

## Methods in Vtable Order
 In addition to the methods on the `IDebugDocument2` interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetSize](../../../extensibility/debugger/reference/idebugdocumenttext2-getsize.md)|Retrieves the size of the text at this position in the document.|
|[GetText](../../../extensibility/debugger/reference/idebugdocumenttext2-gettext.md)|Retrieves the text from the specified position in the document.|

## Remarks
 An object that implements this interface must also implement the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> interface, which supplies the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint> interface for an [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md) object.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
