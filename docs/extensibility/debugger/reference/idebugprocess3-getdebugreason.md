---
description: "This method returns the reason that the process was launched for debugging."
title: IDebugProcess3::GetDebugReason
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess3::GetDebugReason
helpviewer_keywords:
- IDebugProcess3::GetDebugReason
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::GetDebugReason

This method returns the reason that the process was launched for debugging.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDebugReason(
   out enum_DEBUG_REASON pReason
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDebugReason(
   DEBUG_REASON* pReason
);
```
---

## Parameters
`pReason`\
[out] Returns a value from the [DEBUG_REASON](../../../extensibility/debugger/reference/debug-reason.md) enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [DEBUG_REASON](../../../extensibility/debugger/reference/debug-reason.md)
