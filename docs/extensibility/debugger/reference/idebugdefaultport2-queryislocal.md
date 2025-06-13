---
description: "This method determines whether this port is on the local machine."
title: IDebugDefaultPort2::QueryIsLocal
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDefaultPort2::QueryIsLocal
helpviewer_keywords:
- IDebugDefaultPort2::QueryIsLocal
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDefaultPort2::QueryIsLocal

This method determines whether this port is on the local machine.

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
 Returns `S_OK` if this port is local (on the same machine as the caller) or `S_FALSE` if the port is on another machine.

## See also
- [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)
