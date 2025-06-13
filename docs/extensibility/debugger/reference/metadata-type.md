---
description: "The METADATA_TYPE structure specifies information about a field type taken from metadata."
title: METADATA_TYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- METADATA_TYPE
helpviewer_keywords:
- METADATA_TYPE structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# METADATA_TYPE

This structure specifies information about a field type taken from metadata.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct METADATA_TYPE {
   public uint ulAppDomainID;
   public Guid guidModule;
   public int  tokClass;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagTYPE_METADATA {
   ULONG32  ulAppDomainID;
   GUID     guidModule;
   _mdToken tokClass;
} METADATA_TYPE;
```
---

## Parameters
 `ulAppDomainID`\
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.

 `guidModule`\
 The GUID of the module that contains this field.

 `tokClass`\
 The metadata token ID of this type.

 [C++] `_mdToken` is a `typedef` for a 32-bit `int`.

## Remarks
 This structure appears as part of the union in the [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_METADATA` (a value from the [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md) enumeration).

 The `tokClass` value is a metadata token that uniquely identifies a type. For details on how to interpret the upper bits of the metadata token ID, see the `CorTokenType` enumeration in the corhdr.h file in the .NET Framework SDK.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)
- [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md)
