---
title: "IDebugExtendedField::GetExtendedKind | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugExtendedField::GetExtendedKind"
  - "GetExtendedKind"
ms.assetid: 20dc1c13-3cc0-4bb4-9c99-fa85587c86c3
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExtendedField::GetExtendedKind
Retrieves the specified extended field kind.

## Syntax

```cpp
HRESULT GetExtendedKind(
   FIELD_KIND_EX* pdwKind
);
```

```csharp
int GetExtendedKind(
   ref enum_FIELD_KIND_EX pdwKind
);
```

## Parameters
`pdwKind`\
[in, out] Value from the [FIELD_KIND_EX](../../../extensibility/debugger/reference/field-kind-ex.md) enumeration that defines the kind of field.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)