---
description: "Retrieves the specified extended field kind."
title: IDebugExtendedField::GetExtendedKind
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugExtendedField::GetExtendedKind
- GetExtendedKind
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExtendedField::GetExtendedKind

Retrieves the specified extended field kind.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExtendedKind(
   ref enum_FIELD_KIND_EX pdwKind
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExtendedKind(
   FIELD_KIND_EX* pdwKind
);
```
---

## Parameters
`pdwKind`\
[in, out] Value from the [FIELD_KIND_EX](../../../extensibility/debugger/reference/field-kind-ex.md) enumeration that defines the kind of field.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)
