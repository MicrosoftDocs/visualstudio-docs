---
title: "FIELD_KIND_EX | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "FIELD_KIND_EX enumeration"
ms.assetid: 922c3208-1e94-485f-b70a-3bc96affeff8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# FIELD_KIND_EX
Enumerates additional kinds of fields that an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object can contain. This enumeration extends the [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) enumeration.

## Syntax

```cpp
enum enum_FIELD_KIND_EX
{
    FIELD_KIND_EX_NONE = 0,
    FIELD_TYPE_EX_METHODVAR = 0x1,
    FIELD_TYPE_EX_CLASSVAR = 0x2
};
typedef DWORD FIELD_KIND_EX;
```

```csharp
public enum enum_FIELD_KIND_EX
{
    FIELD_KIND_EX_NONE = 0,
    FIELD_TYPE_EX_METHODVAR = 0x1,
    FIELD_TYPE_EX_CLASSVAR = 0x2
};
```

## Fields
`FIELD_KIND_EX_NONE`\
Field does not contain an extended type.

`FIELD_TYPE_EX_METHODVAR`\
Field contains a method variable.

`FIELD_TYPE_EX_CLASSVAR`\
Field contains a class variable.

## Requirements
Header: Sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetExtendedKind](../../../extensibility/debugger/reference/idebugextendedfield-getextendedkind.md)
