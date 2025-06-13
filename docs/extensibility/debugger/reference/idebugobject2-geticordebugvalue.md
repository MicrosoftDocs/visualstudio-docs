---
description: "Gets a managed code object representing the value associated with this object."
title: IDebugObject2::GetICorDebugValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2::GetICorDebugValue
helpviewer_keywords:
- IDebugObject2::GetICorDebugValue method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject2::GetICorDebugValue

Gets a managed code object representing the value associated with this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetICorDebugValue(
   out object ppUnk
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetICorDebugValue(
   IUnknown** ppUnk
);
```
---

## Parameters
`ppUnk`\
[out] `IUnknown` interface that represents this alias. This interface can be queried for the `ICorDebugValue` interface.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The `ICorDebugValue` object is a Common Language Runtime interface that represents a value.

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
