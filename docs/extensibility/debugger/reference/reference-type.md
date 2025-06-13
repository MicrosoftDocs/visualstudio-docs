---
description: "Specifies the reference type."
title: REFERENCE_TYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- REFERENCE_TYPE
helpviewer_keywords:
- REFERENCE_TYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# REFERENCE_TYPE

Specifies the reference type.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_REFERENCE_TYPE { 
   REF_TYPE_WEAK   = 0x0001,
   REF_TYPE_STRONG = 0x0002
};
```
### [C++](#tab/cpp)
```cpp
enum enum_REFERENCE_TYPE { 
   REF_TYPE_WEAK   = 0x0001,
   REF_TYPE_STRONG = 0x0002
};
typedef DWORD REFERENCE_TYPE;
```
---

## Fields
 `REF_TYPE_WEAK`\
 Specifies a weak reference. Cannot be combined with `REF_TYPE_STRONG`.

 `REF_TYPE_STRONG`\
 Specifies a strong reference. Cannot be combined with `REF_TYPE_WEAK`.

## Remarks
 Used as the `dwRefType` member of the [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) structure.

 Passed as a parameter to the [SetReferenceType](../../../extensibility/debugger/reference/idebugreference2-setreferencetype.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)
- [SetReferenceType](../../../extensibility/debugger/reference/idebugreference2-setreferencetype.md)
