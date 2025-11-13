---
description: "Gets the program's exit code."
title: IDebugProgramDestroyEvent2::GetExitCode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramDestroyEvent2::GetExitCode
helpviewer_keywords:
- IDebugProgramDestroyEvent2::GetExitCode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramDestroyEvent2::GetExitCode

Gets the program's exit code.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExitCode( 
   out uint pdwExit
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExitCode( 
   DWORD* pdwExit
);
```
---

## Parameters
`pdwExit`\
[out] Returns the program's exit code.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)
