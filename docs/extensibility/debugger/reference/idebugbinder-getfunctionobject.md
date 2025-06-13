---
description: "This method gets an IDebugFunctionObject object used to create function parameters."
title: IDebugBinder::GetFunctionObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::GetFunctionObject
helpviewer_keywords:
- IDebugBinder::GetFunctionObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder::GetFunctionObject

This method gets an [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object used to create function parameters.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetFunctionObject(
   out IDebugFunctionObject ppFunction
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFunctionObject( 
   IDebugFunctionObject **ppFunction
);
```
---

## Parameters
`ppFunction`\
[out] Returns the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface that is used to create function parameters.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
