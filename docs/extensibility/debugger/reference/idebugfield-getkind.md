---
description: "This method gets the kind of field."
title: IDebugField::GetKind
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetKind
helpviewer_keywords:
- IDebugField::GetKind method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetKind

This method gets the kind of field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetKind(
   out enum_FIELD_KIND pdwKind
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetKind( 
   FIELD_KIND* pdwKind
);
```
---

## Parameters
`pdwKind`\
[out] Returns the kind of field as a combination of [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) constants.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md)
