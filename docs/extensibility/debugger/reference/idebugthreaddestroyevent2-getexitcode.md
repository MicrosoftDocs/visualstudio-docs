---
description: "Gets the exit code for a thread."
title: IDebugThreadDestroyEvent2::GetExitCode | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThreadDestroyEvent2::GetExitCode
helpviewer_keywords:
- IDebugThreadDestroyEvent2::GetExitCode
ms.assetid: 8bf47a17-f811-4d9b-bcea-7488908830ff
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugThreadDestroyEvent2::GetExitCode

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
