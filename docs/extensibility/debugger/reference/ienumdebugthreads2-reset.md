---
description: "Resets the threads enumeration to the first element."
title: IEnumDebugThreads2::Reset
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugThreads2::Reset
helpviewer_keywords:
- IEnumDebugThreads2::Reset
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugThreads2::Reset

Resets the enumeration to the first element.

## Syntax

### [C#](#tab/csharp)
```csharp
int Reset();
```
### [C++](#tab/cpp)
```cpp
HRESULT Reset(
   void
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugthreads2-next.md) method returns the first element of the enumeration.

## See also
- [IEnumDebugThreads2](../../../extensibility/debugger/reference/ienumdebugthreads2.md)
