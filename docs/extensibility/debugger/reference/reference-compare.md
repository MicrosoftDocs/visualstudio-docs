---
description: "Specifies the type of comparison for references."
title: REFERENCE_COMPARE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- REFERENCE_COMPARE
helpviewer_keywords:
- REFERENCE_COMPARE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# REFERENCE_COMPARE

Specifies the type of comparison for references.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_REFERENCE_COMPARE { 
   REF_COMPARE_EQUAL        = 0x0001,
   REF_COMPARE_LESS_THAN    = 0x0002,
   REF_COMPARE_GREATER_THAN = 0x0003
};
```
### [C++](#tab/cpp)
```cpp
enum enum_REFERENCE_COMPARE { 
   REF_COMPARE_EQUAL        = 0x0001,
   REF_COMPARE_LESS_THAN    = 0x0002,
   REF_COMPARE_GREATER_THAN = 0x0003
};
typedef DWORD REFERENCE_COMPARE;
```
---

## Fields
 `REF_COMPARE_EQUAL`\
 Specifies an equal-to comparison.

 `REF_COMPARE_LESS_THAN`\
 Specifies a less-than comparison.

 `REF_COMPARE_GREATER_THAN`\
 Specifies a greater-than comparison.

## Remarks
 Passed as an argument to the [Compare](../../../extensibility/debugger/reference/idebugreference2-compare.md) method.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [Compare](../../../extensibility/debugger/reference/idebugreference2-compare.md)
