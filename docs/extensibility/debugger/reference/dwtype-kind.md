---
description: "Specifies how to interpret the type of an IDebugField object."
title: dwTYPE_KIND
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- dwTYPE_KIND
helpviewer_keywords:
- dwTYPE_KIND enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# dwTYPE_KIND

Specifies how to interpret the type of an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_dwTYPE_KIND {
    TYPE_KIND_METADATA = 0x0001,
    TYPE_KIND_PDB      = 0x0002,
    TYPE_KIND_BUILT    = 0x0003,
};
```
### [C++](#tab/cpp)
```cpp
enum enum_dwTYPE_KIND {
    TYPE_KIND_METADATA = 0x0001,
    TYPE_KIND_PDB      = 0x0002,
    TYPE_KIND_BUILT    = 0x0003,
};

typedef DWORD dwTYPE_KIND;
```
---

## Fields
`TYPE_KIND_METADATA`\
The [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) union should be interpreted as a [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md) structure.

`TYPE_KIND_PDB`\
The `TYPE_INFO` union should be interpreted as a [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md) structure.

`TYPE_KIND_BUILT`\
The `TYPE_INFO` union should be interpreted as a [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md) structure.

## Remarks
The values of this enumeration appear in the `dwKind` field of the [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) structure and are used to determine how to interpret the `type` union member. The `TYPE_INFO` structure is returned by a call to the [GetTypeInfo](../../../extensibility/debugger/reference/idebugfield-gettypeinfo.md) method.

## Requirements
Header: sh.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)
- [GetTypeInfo](../../../extensibility/debugger/reference/idebugfield-gettypeinfo.md)
- [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md)
- [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md)
- [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md)
