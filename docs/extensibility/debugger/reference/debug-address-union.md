---
title: DEBUG_ADDRESS_UNION
description: "Describes different kinds of addresses."
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DEBUG_ADDRESS_UNION
helpviewer_keywords:
- DEBUG_ADDRESS_UNION union
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DEBUG_ADDRESS_UNION

Describes different kinds of addresses.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct DEBUG_ADDRESS_UNION {
   public ADDRESS_KIND dwKind;
   public IntPtr       unionmember;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagDEBUG_ADDRESS_UNION {
   ADDRESS_KIND dwKind;
   union {
      NATIVE_ADDRESS                  addrNative;
      UNMANAGED_ADDRESS_THIS_RELATIVE addrThisRel;
      UNMANAGED_ADDRESS_PHYSICAL      addrUPhysical;
      METADATA_ADDRESS_METHOD         addrMethod;
      METADATA_ADDRESS_FIELD          addrField;
      METADATA_ADDRESS_LOCAL          addrLocal;
      METADATA_ADDRESS_PARAM          addrParam;
      METADATA_ADDRESS_ARRAYELEM      addrArrayElem;
      METADATA_ADDRESS_RETVAL         addrRetVal;
      DWORD                           unused;
   } addr;
} DEBUG_ADDRESS_UNION;
```
---

## Members
`dwKind`\
A value from the [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) enumeration, specifying how to interpret the union.

`addr.addrNative`\
[C++ only] Contains the [NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md) structure if `dwKind` = ADDRESS_KIND_NATIVE.

`addr.addrThisRel`\
[C++ only] Contains the [UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md) structure if `dwKind` = ADDRESS_KIND_UNMANAGED_THIS_RELATIVE.

`addr.addUPhysical`\
[C++ only] Contains the [UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md) structure if `dwKind` = ADDRESS_KIND_UNMANAGED_PHYSICAL.

`addr.addrMethod`\
[C++ only] Contains the [METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md) structure if `dwKind` = ADDRESS_KIND_METHOD.

`addr.addrField`\
[C++ only] Contains the [METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md) structure if `dwKind` = ADDRESS_KIND_FIELD.

`addr.addrLocal`\
[C++ only] Contains the [METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md) structure if `dwKind` = ADDRESS_KIND_LOCAL.

`addr.addrParam`\
[C++ only] Contains the [METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md) structure if `dwKind` = ADDRESS_KIND_PARAM.

`addr.addrArrayElem`\
[C++ only] Contains the [METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md) structure if `dwKind` = ADDRESS_KIND_ARRAYELEM.

`addr.addrRetVal`\
[C++ only] Contains the [METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md) structure if `dwKind` = ADDRESS_KIND_RETVAL.

`addr.unused`\
[C++ only] padding.

`addr`\
[C++ only] The name of the union.

`unionmember`\
[C# only] This value needs to be marshaled to the appropriate structure type based on `dwKind`. See Remarks for the association between `dwKind` and interpretation of the union.

## Remarks
This structure is part of the [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure and represents one of a number of different kinds of addresses (the `DEBUG_ADDRESS` structure is filled in by a call to the [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md) method).

 [C# only] The following table shows how to interpret the `unionmember` member for each kind of address. The Example shows how this is done for one kind of address.

|`dwKind`|`unionmember` interpreted as|
|--------------|----------------------------------|
|`ADDRESS_KIND_NATIVE`|[NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md)|
|`ADDRESS_KIND_UNMANAGED_THIS_RELATIVE`|[UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md)|
|`ADDRESS_KIND_UNMANAGED_PHYSICAL`|[UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md)|
|`ADDRESS_KIND_METHOD`|[METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md)|
|`ADDRESS_KIND_FIELD`|[METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md)|
|`ADDRESS_KIND_LOCAL`|[METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md)|
|`ADDRESS_KIND_PARAM`|[METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md)|
|`ADDRESS_KIND_ARRAYELEM`|[METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md)|
|`ADDRESS_KIND_RETVAL`|[METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md)|

## Example
This example shows how to interpret one kind of address (`METADATA_ADDRESS_ARRAYELEM`) of the `DEBUG_ADDRESS_UNION` structure in C#. The remaining elements can be interpreted in exactly the same way.

```csharp
using System;
using System.Runtime.Interop.Services;
using Microsoft.VisualStudio.Debugger.Interop;

namespace MyPackage
{
    public class MyClass
    {
        public void Interpret(DEBUG_ADDRESS_UNION dau)
        {
            if (dau.dwKind == (uint)enum_ADDRESS_KIND.ADDRESS_KIND_METADATA_ARRAYELEM)
            {
                 METADATA_ADDRESS_ARRAYELEM arrayElem =
                     (METADATA_ADDRESS_ARRAYELEM)Marshal.PtrToStructure(dau.unionmember,
                                 typeof(METADATA_ADDRESS_ARRAYELEM));
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
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)
- [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md)
- [GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)
