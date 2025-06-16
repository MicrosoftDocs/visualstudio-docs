---
description: "Represents a position in a source file as a character offset."
title: IDebugDocumentPositionOffset2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugDocumentPositionOffset2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocumentPositionOffset2

Represents a position in a source file as a character offset.

## Syntax

```
IDebugDocumentPositionOffset2 : IUnknown
```

## Notes for Implementers
 Implemented by the IDE and consumed by debug engines.

## Methods
 The following table shows the methods of `IDebugDocumentPositionOffset2`.

|Method|Description|
|------------|-----------------|
|[GetRange](../../../extensibility/debugger/reference/idebugdocumentpositionoffset2-getrange.md)|Retrieves the range for the current document position.|

## Remarks
 This returns the same information as [GetRange](../../../extensibility/debugger/reference/idebugdocumentposition2-getrange.md) but in `char` offsets from the beginning of the document. This presents the document like it would exist on a disk, that is, a one-dimensional array of characters, instead of the line and column information that is ordinarily returned.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
