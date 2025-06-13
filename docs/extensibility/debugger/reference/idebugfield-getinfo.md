---
description: "This method gets displayable information about the field."
title: IDebugField::GetInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetInfo
helpviewer_keywords:
- IDebugField::GetInfo method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetInfo

This method gets displayable information about the field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInfo(
   enum_FIELD_INFO_FIELDS dwFields,
   FIELD_INFO[] pFieldInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInfo( 
   FIELD_INFO_FIELDS dwFields,
   FIELD_INFO* pFieldInfo
);
```
---

## Parameters
`dwFields`\
[in] A combination of [FIELD_INFO_FIELDS](../../../extensibility/debugger/reference/field-info-fields.md) constants that selects the information to be displayed. If the field represents a symbol, this is typically the symbol name and type.

`pFieldInfo`\
[out] Returns the information in the supplied [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) structure.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md)
