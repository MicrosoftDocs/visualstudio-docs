---
description: "This interface represents an abstract position in a source file."
title: IDebugDocumentPosition2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2
helpviewer_keywords:
- IDebugDocumentPosition2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocumentPosition2

This interface represents an abstract position in a source file.

## Syntax

```
IDebugDocumentPosition2 : IUnknown
```

## Notes for Implementers
 Visual Studio typically implements this interface. A debug engine (DE) would also implement this interface if it must supply its own source code (as when the DE implements the [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) interface).

## Notes for Callers
 This interface is passed in as an argument to [EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md). It is also supplied as part of a [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) union (specifically, a [BP_LOCATION_CODE_FILE_LINE](../../../extensibility/debugger/reference/bp-location-code-file-line.md) structure) that is in turn part of the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure, that is used in creating a pending breakpoint.

## Methods in Vtable Order
 The following table shows the methods of `IDebugDocumentPosition2`.

|Method|Description|
|------------|-----------------|
|[GetFileName](../../../extensibility/debugger/reference/idebugdocumentposition2-getfilename.md)|Gets the file name of the source file that contains this document position.|
|[GetDocument](../../../extensibility/debugger/reference/idebugdocumentposition2-getdocument.md)|Gets the containing document.|
|[IsPositionInDocument](../../../extensibility/debugger/reference/idebugdocumentposition2-ispositionindocument.md)|Determines if this position is contained in the given document.|
|[GetRange](../../../extensibility/debugger/reference/idebugdocumentposition2-getrange.md)|Gets the range for this document position.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [EnumCodeContexts](../../../extensibility/debugger/reference/idebugprogram2-enumcodecontexts.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [BP_LOCATION_CODE_FILE_LINE](../../../extensibility/debugger/reference/bp-location-code-file-line.md)
