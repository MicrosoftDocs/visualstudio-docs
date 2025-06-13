---
description: "Gets the class that encloses this class."
title: IDebugClassField::GetEnclosingClass
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::GetEnclosingClass
helpviewer_keywords:
- IDebugClassField::GetEnclosingClass method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::GetEnclosingClass

Gets the class that encloses this class.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetEnclosingClass(
    out IDebugClassField ppClassField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEnclosingClass(
    IDebugClassField** ppClassField
);
```
---

## Parameters
`ppClassField`\
[out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object representing the enclosing class. Returns a null value if there is no enclosing class.

## Return Value
If successful, returns S_OK; otherwise, returns an error code.

## Remarks
If the class represented by this [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object is a nested class, then the `ppClassField` parameter returns an `IDebugClassField` object representing the enclosing class. For example, given this class definition:

```
class RootClass {
    class NestedClass { }
};
```

Calling the `GetEnclosingClass` method on the `IDebugClassField` object representing the `NestedClass` class returns an `IDebugClassField` object representing the class `RootClass`.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
