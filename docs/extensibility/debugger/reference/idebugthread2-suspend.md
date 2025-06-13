---
description: "Suspends a thread."
title: IDebugThread2::Suspend
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::Suspend
helpviewer_keywords:
- IDebugThread2::Suspend
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::Suspend

Suspends a thread.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT Suspend ( 
   out uint pdwSuspendCount
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Suspend ( 
   DWORD *pdwSuspendCount
);
```
---

## Parameters
`pdwSuspendCount`\
[out] Returns the suspend count after the suspend operation.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Each call to this method increments the suspend count above 0. This suspend count is displayed in the **Threads** debug window.

 For each call to this method, there must be a later call to the [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md) method.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [Resume](../../../extensibility/debugger/reference/idebugthread2-resume.md)
