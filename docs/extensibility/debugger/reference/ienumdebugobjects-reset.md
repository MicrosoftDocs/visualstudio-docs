---
description: "This method resets the enumeration to the first IDebugObject element."
title: IEnumDebugObjects::Reset
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugObjects::Reset
helpviewer_keywords:
- IEnumDebugObjects::Reset method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IEnumDebugObjects::Reset

This method resets the enumeration to the first element.

## Syntax

### [C#](#tab/csharp)
```csharp
int Reset();
```
### [C++](#tab/cpp)
```cpp
HRESULT Reset(void);
```
---

## Parameters
 None

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 After this method is called, the next call to [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md) returns the first element of the enumeration.

## See also
- [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md)
- [Next](../../../extensibility/debugger/reference/ienumdebugobjects-next.md)
