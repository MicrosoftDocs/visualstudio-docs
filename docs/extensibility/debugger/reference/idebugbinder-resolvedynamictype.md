---
description: "This method returns the exact type of a variable."
title: IDebugBinder::ResolveDynamicType
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::ResolveDynamicType
helpviewer_keywords:
- IDebugBinder::ResolveDynamicType method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder::ResolveDynamicType

This method returns the exact type of a variable.

## Syntax

### [C#](#tab/csharp)
```csharp
int ResolveDynamicType(
   IDebugDynamicField pDynamic,
   out IDebugField    ppResolved
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ResolveDynamicType (
   IDebugDynamicField *pDynamic,
   IDebugField       **ppResolved
);
```
---

## Parameters
`pDynamic`\
[in] An [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md) representing a type of a variable.

`ppResolved`\
[out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) giving specific information about the variable's type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md)
