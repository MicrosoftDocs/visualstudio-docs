---
description: "This structure specifies various kinds of information about a field's type."
title: TYPE_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- TYPE_INFO
helpviewer_keywords:
- TYPE_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# TYPE_INFO

This structure specifies various kinds of information about a field's type.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct TYPE_INFO {
   public uint   dwKind;
   public IntPtr unionmember;
};
```
### [C++](#tab/cpp)
```cpp
struct _tagTYPE_INFO_UNION {
   dwTYPE_KIND dwKind;
   union {
      METADATA_TYPE typeMeta;
      PDB_TYPE      typePdb;
      BUILT_TYPE    typeBuilt;
      DWORD         unused;
   } type;
} TYPE_INFO;
```
---

## Members
 `dwKind`\
 A value from the [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md) enumeration that determines how to interpret the union.

 `type.typeMeta`\
 [C++ only] Contains a [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md) structure if `dwKind` is `TYPE_KIND_METADATA`.

 `type.typePdb`\
 [C++ only] Contains a [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md) structure if `dwKind` is `TYPE_KIND_PDB`.

 `type.typeBuilt`\
 [C++ only] Contains a [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md) structure if `dwKind` is `TYPE_KIND_BUILT`.

 `type.unused`\
 Unused padding.

 `type`\
 Name of the union.

 `unionmember`\
 [C# only] Marshal this to the appropriate structure type based on `dwKind`.

## Remarks
 This structure is passed to the [GetTypeInfo](../../../extensibility/debugger/reference/idebugfield-gettypeinfo.md) method where it is filled in. How the contents of the structure are interpreted is based on the `dwKind` field.

> [!NOTE]
> [C++ only] If `dwKind` equals `TYPE_KIND_BUILT`, then it is necessary to release the underlying [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object when destroying the `TYPE_INFO` structure. This is done by calling `typeInfo.type.typeBuilt.pUnderlyingField->Release()`.

 [C# only] The following table shows how to interpret the `unionmember` member for each kind of type. The Example shows how this is done for one kind of type.

|`dwKind`|`unionmember` interpreted as|
|--------------|----------------------------------|
|`TYPE_KIND_METADATA`|[METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md)|
|`TYPE_KIND_PDB`|[PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md)|
|`TYPE_KIND_BUILT`|[BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md)|

## Example
 This example shows how to interpret the `unionmember` member of the `TYPE_INFO` structure in C#. This example shows interpreting only one type (`TYPE_KIND_METADATA`) but the others are interpreted in exactly the same way.

```csharp
using System;
using System.Runtime.Interop.Services;
using Microsoft.VisualStudio.Debugger.Interop;

namespace MyPackage
{
    public class MyClass
    {
        public void Interpret(TYPE_INFO ti)
        {
            if (ti.dwKind == (uint)enum_dwTypeKind.TYPE_KIND_METADATA)
            {
                 METADATA_TYPE dataType = (METADATA_TYPE)Marshal.PtrToStructure(ti.unionmember,
                                               typeof(METADATA_TYPE));
            }
        }
    }
}
```

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md)
- [GetTypeInfo](../../../extensibility/debugger/reference/idebugfield-gettypeinfo.md)
- [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md)
- [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md)
- [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md)
