---
description: "Represents a document checksum for a breakpoint request."
title: IDebugBreakpointChecksumRequest2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugBreakpointChecksumRequest2 interface
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
---
# IDebugBreakpointChecksumRequest2

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Represents a document checksum for a breakpoint request.

## Syntax

```
IDebugBreakpointChecksumRequest2 : IUnknown
```

## Notes for Implementers
 Implemented by the Visual Studio Debug package and consumed by debug engines.

## Methods
 The following table shows the methods of `IDebugBreakpointChecksumRequest2`.

|Method|Description|
|------------|-----------------|
|[GetChecksum](../../../extensibility/debugger/reference/idebugbreakpointchecksumrequest2-getchecksum.md)|Retrieves the document checksum for a breakpoint request given the unique identifier of the checksum algorithm to use.|
|[IsChecksumEnabled](../../../extensibility/debugger/reference/idebugbreakpointchecksumrequest2-ischecksumenabled.md)|Determines if the checksum is enabled for this document.|

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
