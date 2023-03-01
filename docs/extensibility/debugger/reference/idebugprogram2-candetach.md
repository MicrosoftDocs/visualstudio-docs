---
description: "Determines if a debug engine (DE) can detach from the program."
title: IDebugProgram2::CanDetach | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::CanDetach
helpviewer_keywords:
- IDebugProgram2::CanDetach
ms.assetid: dcd9ab6c-49e5-447e-aa7c-89f571f4a052
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
# IDebugProgram2::CanDetach

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Determines if a debug engine (DE) can detach from the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanDetach();
```
### [C++](#tab/cpp)
```cpp
HRESULT CanDetach(
   void
);
```
---

## Return Value
 If can detach, returns `S_OK`; otherwise, returns an error code. Returns `S_FALSE` if the DE cannot detach from the program.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
