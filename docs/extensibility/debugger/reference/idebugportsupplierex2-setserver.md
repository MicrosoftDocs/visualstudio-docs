---
description: "Sets the core server for the port supplier."
title: IDebugPortSupplierEx2::SetServer
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortSupplierEx2::SetServer
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplierEx2::SetServer

Sets the core server for the port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetServer(
   IDebugCoreServer2 pServer
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetServer(
   IDebugCoreServer2* pServer
);
```
---

## Parameters
`pServer`\
Core server to set for the port supplier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplierEx2](../../../extensibility/debugger/reference/idebugportsupplierex2.md)
