---
description: "Removes a port."
title: IDebugPortSupplier2::RemovePort
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::RemovePort
helpviewer_keywords:
- IDebugPortSupplier2::RemovePort
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::RemovePort

Removes a port.

## Syntax

### [C#](#tab/csharp)
```csharp
int RemovePort( 
   IDebugPort2 pPort
);
```
### [C++](#tab/cpp)
```cpp
HRESULT RemovePort( 
   IDebugPort2* pPort
);
```
---

## Parameters
`pPort`\
[in] An [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port to be removed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method removes the port from the port supplier's internal list of active ports.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
