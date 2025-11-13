---
description: "IDebugDynamicFieldCOMPlus::GetTypeFromTypeDef retrieves a type given its token."
title: IDebugDynamicFieldCOMPlus::GetTypeFromTypeDef
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetTypeFromTypeDef
- IDebugDynamicFieldCOMPlus::GetTypeFromTypeDef
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDynamicFieldCOMPlus::GetTypeFromTypeDef

Retrieves a type given its token.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetTypeFromTypeDef(
   uint            ulAppDomainID,
   Guid            guidModule,
   int             tokClass,
   out IDebugField ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetTypeFromTypeDef(
   ULONG32       ulAppDomainID,
   GUID          guidModule,
   _mdToken      tokClass,
   IDebugField** ppType
);
```
---

## Parameters
`ulAppDomainID`\
[in] Identifier of the application domain.

`guidModule`\
[in] Unique identifier of the module.

`tokClass`\
[in] Token that represents the type.

`ppType`\
[out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that contains the type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDynamicFieldCOMPlus](../../../extensibility/debugger/reference/idebugdynamicfieldcomplus.md)
