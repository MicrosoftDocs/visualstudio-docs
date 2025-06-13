---
description: "Debug engines do not implement this method."
title: IDebugThread2::GetLogicalThread
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::GetLogicalThread
helpviewer_keywords:
- IDebugThread2::GetLogicalThread
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::GetLogicalThread

Debug engines do not implement this method.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetLogicalThread( 
   IDebugStackFrame2        pStackFrame,
   out IDebugLogicalThread2 ppLogicalThread
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetLogicalThread( 
   IDebugStackFrame2*     pStackFrame,
   IDebugLogicalThread2** ppLogicalThread
);
```
---

## Parameters
`pStackFrame`\
[in] An [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md) object that represents the stack frame.

`ppLogicalThread`\
[out] Returns an `IDebugLogicalThread2` interface that represents the associated logical thread. A debug engine implementation should set this to a null value.

## Return Value
 Debug engine implementations always return `E_NOTIMPL`.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
