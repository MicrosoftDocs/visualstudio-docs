---
description: "This method obtains an interface to the server that this port is on."
title: IDebugDefaultPort2::GetServer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDefaultPort2::GetServer
helpviewer_keywords:
- IDebugDefaultPort2::GetServer
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDefaultPort2::GetServer

This method obtains an interface to the server that this port is on.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetServer(
   out IDebugCoreServer3 ppServer
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetServer(
   IDebugCoreServer3** ppServer
);
```
---

## Parameters
`ppServer`\
[out] Returns an object implementing the [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md) is implemented by Visual Studio and represents the server that the port is located on.

## See also
- [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
