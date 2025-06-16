---
description: "Determines if the session debug manager (SDM) can detach the process."
title: IDebugProcess2::CanDetach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::CanDetach
helpviewer_keywords:
- IDebugProcess2::CanDetach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::CanDetach

Determines if the session debug manager (SDM) can detach the process.

## Syntax

### [C#](#tab/csharp)
```csharp
int CanDetach();
```
### [C++](#tab/cpp)
```cpp
HRESULT CanDetach(
   void
);
```
---

## Return Value
 If successful, returns `S_OK.` Returns `S_FALSE` if the debugger cannot detach from the process. Otherwise, returns an error code.

## See also
- [CanDetach](../../../extensibility/debugger/reference/idebugprogram2-candetach.md)
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
