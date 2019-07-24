---
title: "CONSTRUCTOR_ENUM | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "CONSTRUCTOR_ENUM"
helpviewer_keywords:
  - "CONSTRUCTOR_ENUM enumeration"
ms.assetid: 6d335b2c-66bc-460c-a4a6-4f3f1b697c2c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# CONSTRUCTOR_ENUM
Selects different types of constructors.

## Syntax

```cpp
typedef enum ConstructorMatchOptions {
    crAll       = 0,
    crNonStatic = 1,
    crStatic    = 2
} CONSTRUCTOR_ENUM;
```

```csharp
public enum ConstructorMatchOptions {
    crAll       = 0,
    crNonStatic = 1,
    crStatic    = 2
};
```

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
