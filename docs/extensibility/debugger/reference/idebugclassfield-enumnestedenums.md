---
description: "Creates an enumerator for the nested enumerators of this class."
title: IDebugClassField::EnumNestedEnums
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::EnumNestedEnums
helpviewer_keywords:
- IDebugClassField::EnumNestedEnums method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::EnumNestedEnums

Creates an enumerator for the nested enumerators of this class.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumNestedEnums(
    out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumNestedEnums(
    IEnumDebugFields** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of nested enumerations. Returns a null value if there are no nested enumerations.

## Return Value
If successful, returns S_OK or returns S_FALSE if there are no nested enumerators. Otherwise, returns an error code.

## Remarks
Each element of the enumeration is an [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md) object describing a nested enumeration.

An enumeration declared inside a class is considered a nested enumeration. For example, given:

```
class RootClass {
    enum NestedEnum { EnumValue = 0 }
};
```

The `EnumNestedEnums` method would return an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object that contains one [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md) object that represents the `NestedEnum` enumeration.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
- [IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)
