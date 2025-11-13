---
description: "Creates an enumerator for all local variables of the method, including those generated internally by a compiler."
title: IDebugMethodField::EnumAllLocals
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMethodField::EnumAllLocals
helpviewer_keywords:
- IDebugMethodField::EnumAllLocals method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMethodField::EnumAllLocals

Creates an enumerator for all local variables of the method, including those generated internally by a compiler.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumAllLocals(
   IDebugAddress        pAddress,
   out IEnumDebugFields ppLocals
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumAllLocals( 
   IDebugAddress*     pAddress,
   IEnumDebugFields** ppLocals
);
```
---

## Parameters
`pAddress`\
[in] An [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object representing a debug address within the method, pointing to a particular scope or context.

`ppLocals`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of all locals in the specified scope; otherwise, returns a null value indicating no locals.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there are no locals. Otherwise, returns an error code.

## Remarks
 Only the variables defined within the block that contains the given debug address are enumerated. This method includes any compiler-generated locals. If all that is needed are the locals explicitly defined in the source, call the [EnumLocals](../../../extensibility/debugger/reference/idebugmethodfield-enumlocals.md) method.

 A method can contain multiple scoping contexts or blocks.

## See also
- [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [EnumLocals](../../../extensibility/debugger/reference/idebugmethodfield-enumlocals.md)
