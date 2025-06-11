---
description: "IDebugFunctionObject::Evaluate calls the function and returns the resulting value as an object."
title: IDebugFunctionObject::Evaluate
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugFunctionObject::Evaluate
helpviewer_keywords:
- IDebugFunctionObject::Evaluate method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionObject::Evaluate

Calls the function and returns the resulting value as an object.

## Syntax

### [C#](#tab/csharp)
```csharp
int Evaluate(
   IDebugObject[]   ppParams,
   IntPtr           dwParams,
   uint             dwTimeout,
   out IDebugObject ppResult
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Evaluate( 
   IDebugObject** ppParams,
   DWORD          dwParams,
   DWORD          dwTimeout,
   IDebugObject** ppResult
);
```
---

## Parameters
`ppParams`\
[in] An array of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects representing the input parameters. Each of these parameters was created with one of the `Create` methods in the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) interface.

`dwParams`\
[in] The number of parameters in the `ppParams` array.

`dwTimeout`\
[in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`ppResult`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) representing the value of the function as an object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method sets up and executes a call to the function represented by the [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object.

## See also
- [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md)
