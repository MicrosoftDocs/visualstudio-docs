---
description: "Gets a description of the properties of a stack frame."
title: IDebugStackFrame2::GetDebugProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugStackFrame2::GetDebugProperty
helpviewer_keywords:
- IDebugStackFrame2::GetDebugProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugStackFrame2::GetDebugProperty

Gets a description of the properties of a stack frame.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDebugProperty ( 
   out IDebugProperty2 ppDebugProp
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDebugProperty ( 
   IDebugProperty2** ppDebugProp
);
```
---

## Parameters
`ppDebugProp`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that describes the properties of this stack frame.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Calling the [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method with appropriate filters can retrieve the local variables, method parameters, registers, and "this" pointer associated with the stack frame.

## See also
- [IDebugStackFrame2](../../../extensibility/debugger/reference/idebugstackframe2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
