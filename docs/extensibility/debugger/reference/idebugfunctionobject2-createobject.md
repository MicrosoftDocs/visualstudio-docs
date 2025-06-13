---
description: "Creates an object that uses a constructor given evaluation flag settings and a timeout value."
title: IDebugFunctionObject2::CreateObject
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugFunctionObject2::CreateObject
- CreateObject
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionObject2::CreateObject

Creates an object that uses a constructor given evaluation flag settings and a timeout value.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateObject (
   IDebugFunctionObject pConstructor,
   uint                 dwArgs,
   IDebugObject[]       pArgs,
   uint                 dwEvalFlags,
   uint                 dwTimeout,
   out IDebugObject**   ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateObject (
   IDebugFunctionObject* pConstructor,
   DWORD                 dwArgs,
   IDebugObject*         pArgs[],
   DWORD                 dwEvalFlags,
   DWORD                 dwTimeout,
   IDebugObject**        ppObject
);
```
---

## Parameters
`pConstructor`\
[in] An [IDebugFunctionObject](../../../extensibility/debugger/reference/idebugfunctionobject.md) object that represents the constructor of the object to be created.

`dwArgs`\
[in] The number of parameters in the `pArg` array. Represents the number of parameters passed to the constructor.

`pArgs`\
[in] An array of [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) objects that represents the parameters passed to the constructor.

`dwEvalFlags`\
[in] A combination of flags from the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration that specify how the evaluation is to be performed.

`dwTimeout`\
[in] Maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.

`ppObject`\
[out] Returns an **IDebugObject** representing the newly created object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Call this method to create an object that represents an instance of a class, or other complex type that requires a constructor, that is a parameter.

## See also
- [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)
