---
description: "Gets a port from a port supplier."
title: IDebugPortSupplier2::GetPort
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::GetPort
helpviewer_keywords:
- IDebugPortSupplier2::GetPort
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::GetPort

Gets a port from a port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPort( 
   ref Guid        guidPort,
   out IDebugPort2 ppPort
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPort( 
   REFGUID       guidPort,
   IDebugPort2** ppPort
);
```
---

## Parameters
`guidPort`\
[in] Globally unique identifier (GUID) of the port.

`ppPort`\
[out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_PORTSUPPLIER_NO_PORT` if no port exists with the given identifier.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
