---
description: "Gets the program in which a thread is running."
title: IDebugThread2::GetProgram
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::GetProgram
helpviewer_keywords:
- IDebugThread2::GetProgram
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThread2::GetProgram

Gets the program in which a thread is running.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProgram ( 
   out IDebugProgram2 ppProgram
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProgram ( 
   IDebugProgram2** ppProgram
);
```
---

## Parameters
`ppProgram`\
[out] Returns an [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program this thread is running in.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
