---
title: "DisplayKind | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "DisplayKind enumeration"
ms.assetid: 940968c5-6065-4bda-8ee6-c31597db4d71
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# DisplayKind
Enumerates the valid values that represent the kinds of information to take from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object and display to the user.

## Syntax

```cpp
enum enum_DisplayKind
{
    DisplayKind_Value = 0x1,
    DisplayKind_Name = 0x2,
    DisplayKind_Type = 0x3,
};
typedef DWORD DisplayKind;
```

```csharp
public enum enum_DisplayKind
{
    DisplayKind_Value = 0x1,
    DisplayKind_Name = 0x2,
    DisplayKind_Type = 0x3,
};
```

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
