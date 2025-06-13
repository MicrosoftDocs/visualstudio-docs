---
description: "Gets the name of a thread."
title: IDebugThread2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::GetName
helpviewer_keywords:
- IDebugThread2::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::GetName

Gets the name of a thread.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName ( 
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName ( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The retrieved name is always a name that can be displayed and this name describes the thread. The thread name might be derived from a run-time architecture that supports named threads, or it might be a name derived from the debug engine. Alternatively, the name of the thread can be set by a call to the [SetThreadName](../../../extensibility/debugger/reference/idebugthread2-setthreadname.md) method.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [SetThreadName](../../../extensibility/debugger/reference/idebugthread2-setthreadname.md)
