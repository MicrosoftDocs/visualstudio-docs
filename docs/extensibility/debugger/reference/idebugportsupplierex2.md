---
title: "IDebugPortSupplierEx2 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugPortSupplierEx2 interface"
ms.assetid: dae0050a-a50a-4f35-bfbd-e538f537b20f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugPortSupplierEx2
Provides support for a port supplier to select and interact with a core server.

## Syntax

```
IDebugPortSupplierEx2 : IUnknown
```

## Notes for Implementers
 A custom port supplier implements this interface so that it can select the core server to use.

## Methods
 The following table shows the methods of **IDebugPortSupplierEx2**.

|Method|Description|
|------------|-----------------|
|[SetServer](../../../extensibility/debugger/reference/idebugportsupplierex2-setserver.md)|Sets the core server for the port supplier.|

## Requirements
 Header: Portpriv.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugPortSupplier3](../../../extensibility/debugger/reference/idebugportsupplier3.md)