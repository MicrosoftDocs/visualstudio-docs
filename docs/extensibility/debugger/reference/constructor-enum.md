---
description: "Selects different types of constructors."
title: CONSTRUCTOR_ENUM
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- CONSTRUCTOR_ENUM
helpviewer_keywords:
- CONSTRUCTOR_ENUM enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# CONSTRUCTOR_ENUM

Selects different types of constructors.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum ConstructorMatchOptions {
    crAll       = 0,
    crNonStatic = 1,
    crStatic    = 2
};
```
### [C++](#tab/cpp)
```cpp
typedef enum ConstructorMatchOptions {
    crAll       = 0,
    crNonStatic = 1,
    crStatic    = 2
} CONSTRUCTOR_ENUM;
```
---

## Fields
`crAll`\
Selects all constructors.

`crNonStatic`\
Selects non-static constructors.

`crStatic`\
Selects static constructors.

## Remarks
Passed as an argument to the [EnumConstructors](../../../extensibility/debugger/reference/idebugclassfield-enumconstructors.md) method.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetReason](../../../extensibility/debugger/reference/idebugcanstopevent2-getreason.md)
