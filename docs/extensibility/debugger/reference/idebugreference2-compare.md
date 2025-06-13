---
description: "Compares one reference to another."
title: IDebugReference2::Compare
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::Compare
helpviewer_keywords:
- IDebugReference2::Compare
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::Compare

Compares one reference to another. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int Compare ( 
   enum_REFERENCE_COMPARE dwCompare,
   IDebugReference2       pReference
);
```
### [C++](#tab/cpp)
```cpp
HRESULT Compare ( 
   REFERENCE_COMPARE dwCompare,
   IDebugReference2* pReference
);
```
---

## Parameters
`dwCompare`\
[in] A value from the [REFERENCE_COMPARE](../../../extensibility/debugger/reference/reference-compare.md) enumeration that specifies the comparison operation, for example, equal to, less than, or greater than.

`pReference`\
[in] An [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object representing the reference to be compared to.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [REFERENCE_COMPARE](../../../extensibility/debugger/reference/reference-compare.md)
