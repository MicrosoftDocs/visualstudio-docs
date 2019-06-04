---
title: "IDebugClassField::EnumNestedClasses | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugClassField::EnumNestedClasses"
helpviewer_keywords:
  - "IDebugClassField::EnumNestedClasses method"
ms.assetid: 2ba5ef0c-395e-4006-9e3c-9b06e1d711d0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugClassField::EnumNestedClasses
Creates an enumerator for the classes nested in this class.

## Syntax

```cpp
HRESULT EnumNestedClasses(
    IEnumDebugFields** ppEnum
);
```

```csharp
int EnumNestedClasses(
    out IEnumDebugFields ppEnum
);
```

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of nested classes. Returns a null value if there are no nested classes.

## Return Value
If successful, returns S_OK or returns S_FALSE if there are no nested classes. Otherwise, returns an error code.

## Remarks
Each element of the enumeration is an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object describing a nested class.

A nested class is a class defined inside another class. For example:

```
class RootClass {
   class NestedClass { }
};
```

The [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) enumeration would contain one object representing the `NestedClass` class.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
