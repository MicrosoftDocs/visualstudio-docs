---
description: "Determines if the field represents a closed type."
title: IDebugExtendedField::IsClosedType
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IsClosedType
- IDebugExtendedField::IsClosedType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExtendedField::IsClosedType

Determines if the field represents a closed type.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsClosedType();
```
### [C++](#tab/cpp)
```cpp
HRESULT IsClosedType(
   void
);
```
---

## Return Value
 If the field is a closed type, returns `S_OK`; otherwise, returns `S_FALSE`.

## See also
- [IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)
