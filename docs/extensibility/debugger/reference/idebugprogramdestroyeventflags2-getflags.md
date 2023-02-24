---
description: "Retrieves the program destroy flags."
title: IDebugProgramDestroyEventFlags2::GetFlags | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetFlags
- IDebugProgramDestroyEventFlags2::GetFlags
ms.assetid: dd53bd0c-459a-4077-ba81-780defb71e87
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
# IDebugProgramDestroyEventFlags2::GetFlags

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
