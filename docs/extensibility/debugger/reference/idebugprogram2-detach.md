---
description: "Detaches a debug engine from the program."
title: IDebugProgram2::Detach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::Detach
helpviewer_keywords:
- IDebugProgram2::Detach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::Detach

Detaches a debug engine from the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int Detach();
```
### [C++](#tab/cpp)
```cpp
HRESULT Detach( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A detached program continues running, but it is no longer part of the debug session. No more program debug events are sent once the debug engine is detached.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
