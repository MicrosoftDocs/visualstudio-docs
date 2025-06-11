---
description: "IDebugFunctionObject2::Evaluate calls the function and returns the resulting value as an object."
title: IDebugFunctionObject2::Evaluate
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugFunctionObject2::Evaluate
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionObject2::Evaluate

Calls the function and returns the resulting value as an object.

## Syntax

### [C#](#tab/csharp)
```csharp
int Evaluate (
   IDebugObject     ppParams,
   uint             dwParams,
   uint             dwEvalFlags,
   uint             dwTimeout,
   out IDebugObject ppResult
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Evaluate (
   IDebugObject** ppParams,
   DWORD          dwParams,
   DWORD          dwEvalFlags,
   DWORD          dwTimeout,
   IDebugObject** ppResult
);
```
---

## Parameters
`ppParams`\
[in] An array of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects that represents the input parameters. Each of these parameters was created by using one of the Create methods in this interface.

`dwParams`\
[in] The number of parameters in the `ppParams` array.

`dwEvalFlags`\
[in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that specify how the evaluation is to be performed.

`dwTimeout`\
[in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.

`ppResult`\
[out] Returns an **IDebugObject** that represents the value of the function as an object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)
