---
description: "This method sets the state of all outstanding exceptions."
title: IDebugEngine3::SetAllExceptions
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::SetAllExceptions
helpviewer_keywords:
- IDebugEngine3::SetAllExceptions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::SetAllExceptions

This method sets the state of all outstanding exceptions.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetAllExceptions(
   enum_EXCEPTION_STATE dwState
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetAllExceptions(
   EXCEPTION_STATE dwState
);
```
---

## Parameters
`dwState`\
[in] One of the [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md) values.

## Return Value
 If successful, returns `S_OK`; otherwise, returns error code.

## See also
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
- [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md)
