---
description: "Retrieves a type given its primitive type."
title: IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive
- GetTypeFromPrimitive
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDynamicFieldCOMPlus::GetTypeFromPrimitive

Retrieves a type given its primitive type.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetTypeFromPrimitive(
   uint            dwCorElementType,
   out IDebugField ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetTypeFromPrimitive(
   DWORD         dwCorElementType,
   IDebugField** ppType
);
```
---

## Parameters
`dwCorElementType`\
[in] Value from the [CorElementType Enumeration](/dotnet/framework/unmanaged-api/metadata/corelementtype-enumeration) that represents the primitive type.

`ppType`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that represents the type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDynamicFieldCOMPlus](../../../extensibility/debugger/reference/idebugdynamicfieldcomplus.md)
