---
description: "Retrieves a specific port."
title: IDebugCoreServer2::GetPort
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2::GetPort
helpviewer_keywords:
- IDebugCoreServer2::GetPort
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer2::GetPort

Retrieves a specific port.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPort( 
   ref Guid        guidPort,
   out IDebugPort2 ppPort
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPort( 
   REFGUID       guidPort,
   IDebugPort2** ppPort
);
```
---

## Parameters
`guidPort`\
[in] GUID of the port to be retrieved.

`ppPort`\
[out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object representing the desired port.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code. Returns `E_PORTSUPPLIER_NO_PORT` if there is no port with the given identifier.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
- [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
