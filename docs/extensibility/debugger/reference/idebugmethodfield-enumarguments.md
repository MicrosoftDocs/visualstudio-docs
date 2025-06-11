---
description: "Creates an enumerator for the type of each argument required to call the method."
title: IDebugMethodField::EnumArguments
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::EnumArguments
helpviewer_keywords:
- IDebugMethodField::EnumArguments method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::EnumArguments

Creates an enumerator for the type of each argument required to call the method.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumArguments(
   out IEnumDebugFields ppParams
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumArguments( 
   IEnumDebugFields** ppParams
);
```
---

## Parameters
`ppParams`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of argument types. Returns a null value if there are no arguments.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no arguments. Otherwise, returns an error code.

## Remarks
 Each element is an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object representing the types of each parameter. Call the [GetInfo](../../../extensibility/debugger/reference/idebugfield-getinfo.md) method to retrieve information about the type of each parameter.

 If the name of the parameter is needed along with the type, then call the [EnumParameters](../../../extensibility/debugger/reference/idebugmethodfield-enumparameters.md) method.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [EnumParameters](../../../extensibility/debugger/reference/idebugmethodfield-enumparameters.md)
