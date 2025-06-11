---
description: "Marks the module as being user code or not."
title: IDebugModule3::SetJustMyCodeState
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule3::SetJustMyCodeState
helpviewer_keywords:
- IDebugModule3::SetJustMyCodeState
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModule3::SetJustMyCodeState

Marks the module as being user code or not.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetJustMyCodeState(
   int fIsUserCode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetJustMyCodeState(
   BOOL fIsUserCode
);
```
---

## Parameters
`fIsUserCode`\
[in] Nonzero (`TRUE`) if the module should be considered user code, zero (`FALSE`) if it should not.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)
