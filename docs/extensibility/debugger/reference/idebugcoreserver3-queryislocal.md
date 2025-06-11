---
description: "Determines if the server is local to the caller."
title: IDebugCoreServer3::QueryIsLocal
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer3::QueryIsLocal
helpviewer_keywords:
- IDebugCoreServer3::QueryIsLocal
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer3::QueryIsLocal

Determines if the server is local to the caller.

## Syntax

### [C#](#tab/csharp)
```csharp
int QueryIsLocal();
```
### [C++](#tab/cpp)
```cpp
HRESULT QueryIsLocal(
   void
);
```
---

## Return Value
 Returns `S_OK` to indicate the server is local. Returns `S_FALSE` if the server is running from an instance of msvsmon.exe, which is typically used for remote debugging.

## See also
- [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)
