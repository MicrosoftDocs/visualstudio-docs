---
description: "Determines if the field represents a closed type."
title: IDebugExtendedField::IsClosedType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IsClosedType
- IDebugExtendedField::IsClosedType
ms.assetid: 9136fc57-74ff-4fe4-a6e2-b137cb9d5b08
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugExtendedField::IsClosedType
Determines if the field represents a closed type.

## Syntax

```cpp
HRESULT IsClosedType(
   void
);
```

```csharp
int IsClosedType();
```

## Return Value
 If the field is a closed type, returns `S_OK`; otherwise, returns `S_FALSE`.

## See also
- [IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)
