---
description: "Retrieves the primitive type that is associated with this field."
title: IDebugPrimitiveTypeField::GetPrimitiveType
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetPrimitiveType
- IDebugPrimitiveTypeField::GetPrimitiveType
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPrimitiveTypeField::GetPrimitiveType

Retrieves the primitive type that is associated with this field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetPrimitiveType (
   out uint pdwType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPrimitiveType (
   DWORD* pdwType
);
```
---

## Parameters
`pdwType`\
[out] Value from the [CorElementType Enumeration](/dotnet/framework/unmanaged-api/metadata/corelementtype-enumeration) that represents the primitive type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE`.

## See also
- [IDebugPrimitiveTypeField](../../../extensibility/debugger/reference/idebugprimitivetypefield.md)
