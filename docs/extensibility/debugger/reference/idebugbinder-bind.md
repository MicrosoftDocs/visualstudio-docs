---
description: "This method gets the memory context or object that contains the symbol's current value."
title: IDebugBinder::Bind
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::Bind
helpviewer_keywords:
- IDebugBinder::Bind method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder::Bind

This method gets the memory context or object that contains the symbol's current value.

## Syntax

### [C#](#tab/csharp)
```csharp
int Bind(
   IDebugObject     pContainer,
   IDebugField      pField,
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Bind( 
   IDebugObject*  pContainer,
   IDebugField*   pField,
   IDebugObject** ppObject
);
```
---

## Parameters
`pContainer`\
[in] The [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) that contains the child referenced by `pField`.

`pField`\
[in] The [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the symbol.

`ppObject`\
[out] Returns the `IDebugObject` that represents the instance of the symbol.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
