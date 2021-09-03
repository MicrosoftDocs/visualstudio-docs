---
description: "Resumes execution of a thread."
title: IDebugThread2::Resume | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::Resume
helpviewer_keywords:
- IDebugThread2::Resume
ms.assetid: 36aad682-b0b9-40a2-b3fc-f0e61d41cdbc
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::Resume
Resumes execution of a thread.

## Syntax

```cpp
HRESULT Resume ( 
   DWORD *pdwSuspendCount
);
```

```csharp
int Resume ( 
   out uint pdwSuspendCount
);
```

## Parameters
`pdwSuspendCount`\
[out] Returns the suspend count after the resume operation.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Each call to this method decrements the suspend count until it reaches 0 at which time, execution is actually resumed. This suspend count is displayed in the **Threads** debug window.

 For each call to this method, there must be a previous call to the [Suspend](../../../extensibility/debugger/reference/idebugthread2-suspend.md) method. The suspend count determines how many times the `IDebugThread2::Suspend` method has been called so far.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [Suspend](../../../extensibility/debugger/reference/idebugthread2-suspend.md)
