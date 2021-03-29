---
description: "This interface is an extension interface implemented by IDebugProcess2 implementers."
title: IDebugProcessQueryProperties | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessQueryProperties
ms.assetid: ce29a248-81a0-42c0-99a7-1606e8c548ec
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProcessQueryProperties
This interface is an extension interface implemented by [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md) implementers. It allows the implementer to get information on the debugging process environment.

## Syntax

```
IDebugProcessQueryProperties: IUnknown
```

## Notes for Implementers
 Implement this interface to get information on the execution environment of a debugging process.

## Methods in Vtable Order
 The following table shows the methods of `IDebugProcessQueryProperties`.

|Method|Description|
|------------|-----------------|
|[QueryProperty](../../../extensibility/debugger/reference/idebugprocessqueryproperties-queryproperty.md)|Queries for a property value.|
|[QueryProperties](../../../extensibility/debugger/reference/idebugprocessqueryproperties-queryproperties.md)|Queries for property values.|

## Remarks
 This interface is seldom implemented.

## Requirements
 Header: Portpriv.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
