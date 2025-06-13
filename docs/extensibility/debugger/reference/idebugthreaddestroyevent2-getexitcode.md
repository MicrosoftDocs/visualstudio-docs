---
description: "Gets the exit code for a thread."
title: IDebugThreadDestroyEvent2::GetExitCode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThreadDestroyEvent2::GetExitCode
helpviewer_keywords:
- IDebugThreadDestroyEvent2::GetExitCode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugThreadDestroyEvent2::GetExitCode

Gets the exit code for a thread.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExitCode ( 
   out uint pdwExit
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExitCode ( 
   DWORD* pdwExit
);
```
---

## Parameters
`pdwExit`\
[out] Returns the thread's exit code.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugThreadDestroyEvent2](../../../extensibility/debugger/reference/idebugthreaddestroyevent2.md)
