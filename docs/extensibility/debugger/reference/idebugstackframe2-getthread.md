---
description: "Gets the thread associated with a stack frame."
title: IDebugStackFrame2::GetThread
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetThread
helpviewer_keywords:
- IDebugStackFrame2::GetThread
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetThread

Gets the thread associated with a stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetThread ( 
   out IDebugThread2 ppThread
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetThread ( 
   IDebugThread2** ppThread
);
```
---

## Parameters
`ppThread`\
[out] Returns an [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md) object that represents the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
