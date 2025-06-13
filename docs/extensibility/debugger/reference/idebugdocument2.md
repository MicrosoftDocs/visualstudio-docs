---
description: "This interface represents a source document."
title: IDebugDocument2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocument2
helpviewer_keywords:
- IDebugDocument2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocument2

This interface represents a source document.

## Syntax

```
IDebugDocument2 : IUnknown
```

## Notes for Implementers
 Visual Studio typically implements this interface. A debug engine (DE) can also implement this interface when it needs to supply the source code and the source does not exist on disk.  In such cases, the DE would also implement [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) and [IDebugActivateDocumentEvent2](../../../extensibility/debugger/reference/idebugactivatedocumentevent2.md) interfaces, as well as some additional methods on the [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md) and [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md) interfaces.

## Notes for Callers
 Methods on the `IDebugDocumentContext2`, `IDebugDisassemblyStream2`, `IDebugDocumentPosition2`, and `IDebugActivateDocumentEvent2` interfaces return this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugDocument2`.

|Method|Description|
|------------|-----------------|
|[GetName](../../../extensibility/debugger/reference/idebugdocument2-getname.md)|Gets the name of the document in one of several forms.|
|[GetDocumentClassID](../../../extensibility/debugger/reference/idebugdocument2-getdocumentclassid.md)|Gets the class identifier of the document.|

## Remarks
 This interface is implemented only when the DE supplies the source code. For example, when you are debugging script on an HTML page, the DE supplies the source code because the source is downloaded or generated dynamically and does not exist as a disk file. When debugging traditional languages, such as C++, this interface does not need to be implemented.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IsPositionInDocument](../../../extensibility/debugger/reference/idebugdocumentposition2-ispositionindocument.md)
- [GetDocument](../../../extensibility/debugger/reference/idebugactivatedocumentevent2-getdocument.md)
- [GetDocument](../../../extensibility/debugger/reference/idebugdocumentcontext2-getdocument.md)
- [GetDocument](../../../extensibility/debugger/reference/idebugdocumentposition2-getdocument.md)
- [GetDocument](../../../extensibility/debugger/reference/idebugdisassemblystream2-getdocument.md)
