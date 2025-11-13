---
description: "Represents a checksum for a debug document and enables passing the checksum between components."
title: IDebugDocumentChecksum2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugDocumentChecksum2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocumentChecksum2

Represents a checksum for a debug document and enables passing the checksum between components.

## Syntax

```
IDebugDocumentChecksum2 : IUnknown
```

## Notes for Implementers
 This interface can be implemented by any component that exposes the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface. However, it is principally implemented by debug engines so that the checksum embedded in a symbol file (*.pdb) can be passed back to the IDE and used when finding a source.

## Methods
 The following table shows the methods of `IDebugDocumentChecksum2`.

|Method|Description|
|------------|-----------------|
|[GetChecksumAndAlgorithmId](../../../extensibility/debugger/reference/idebugdocumentchecksum2-getchecksumandalgorithmid.md)|Retrieves the document checksum and algorithm identifier given the maximum number of bytes to use.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
