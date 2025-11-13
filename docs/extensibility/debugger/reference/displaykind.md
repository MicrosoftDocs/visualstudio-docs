---
description: "Enumerates the valid values that represent the kinds of information to take from an IDebugField object and display to the user."
title: DisplayKind
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- DisplayKind enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DisplayKind

Enumerates the valid values that represent the kinds of information to take from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object and display to the user.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_DisplayKind
{
    DisplayKind_Value = 0x1,
    DisplayKind_Name = 0x2,
    DisplayKind_Type = 0x3,
};
```
### [C++](#tab/cpp)
```cpp
enum enum_DisplayKind
{
    DisplayKind_Value = 0x1,
    DisplayKind_Name = 0x2,
    DisplayKind_Type = 0x3,
};
typedef DWORD DisplayKind;
```
---

## Fields
`DisplayKind_Value`\
Value of the field.

`DisplayKind_Name`\
Name of the field.

`DisplayKind_Type`\
Type of field.

## Requirements
Header: Ee.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetValueDisplayStringCount](../../../extensibility/debugger/reference/ieevisualizerservice-getvaluedisplaystringcount.md)
