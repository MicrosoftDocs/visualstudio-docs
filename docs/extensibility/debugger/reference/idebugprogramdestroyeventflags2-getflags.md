---
description: "Retrieves the program destroy flags."
title: IDebugProgramDestroyEventFlags2::GetFlags
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetFlags
- IDebugProgramDestroyEventFlags2::GetFlags
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramDestroyEventFlags2::GetFlags

Retrieves the program destroy flags.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetFlags(
   out enum_PROGRAM_DESTROY_FLAGS pdwFlags
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFlags(
   PROGRAM_DESTROY_FLAGS* pdwFlags
);
```
---

## Parameters
`pdwFlags`\
[out] Represents the program destroy flags.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProgramDestroyEventFlags2](../../../extensibility/debugger/reference/idebugprogramdestroyeventflags2.md)
- [PROGRAM_DESTROY_FLAGS](../../../extensibility/debugger/reference/program-destroy-flags.md)
