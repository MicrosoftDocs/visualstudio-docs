---
description: "Creates an enumerator for the base classes of this class."
title: IDebugClassField::EnumBaseClasses
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::EnumBaseClasses
helpviewer_keywords:
- IDebugClassField::EnumBaseClasses method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::EnumBaseClasses

Creates an enumerator for the base classes of this class.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumBaseClasses(
   out IEnumDebugFields ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumBaseClasses( 
   IEnumDebugFields** ppEnum
);
```
---

## Parameters
`ppEnum`\

[out] Returns an [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md) object representing the list of base classes. Returns a null value if there are no base classes.

## Return Value
 If successful, returns S_OK, returns S_SH_NO_BASE_CLASSES if there are no base classes (and the `ppEnum` parameter is set to a null value); otherwise, returns an error code.

## Remarks
 The base classes in the enumerator object are specified in order of the most immediate (or most derived) base class to the most remote base class. For example, given the C++ classes:

```
class Root { }
class Level1 : Root { }
class Level2 : Level1 { }
class MyClass : Level2 { }
```

 The enumeration would return the base classes in the order `Level2`, `Level1`, `Root`.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)
