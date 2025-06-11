---
description: "Gets the program's properties."
title: IDebugProgram2::GetDebugProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetDebugProperty
helpviewer_keywords:
- IDebugProgram2::GetDebugProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetDebugProperty

Gets the program's properties.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDebugProperty( 
   out IDebugProperty2 ppProperty
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDebugProperty( 
   IDebugProperty2** ppProperty
);
```
---

## Parameters
`ppProperty`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the program's properties.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The properties returned by this method are specific to the program. If the program needs to return more than one property, then the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object returned by this method is a container of additional properties and calling the [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md) method returns a list of all properties.

 A program may expose any number and type of additional properties that can be described through the `IDebugProperty2` interface. An IDE might display the additional program properties through a generic property browser user interface.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md)
