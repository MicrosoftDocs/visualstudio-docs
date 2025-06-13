---
description: "Retrieves the type parameters given the number of parameters."
title: IDebugGenericFieldDefinition::GetFormalTypeParams
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetFormalTypeParams
- IDebugGenericFieldDefinition::GetFormalTypeParams
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericFieldDefinition::GetFormalTypeParams

Retrieves the type parameters given the number of parameters.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetFormalTypeParams(
   uint                          cParams,
   out IDebugGenericParamField[] ppParams,
   ref uint                      pcParams
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetFormalTypeParams(
   ULONG32                   cParams,
   IDebugGenericParamField** ppParams,
   ULONG32*                  pcParams
);
```
---

## Parameters
`cParams`\
[in] Number of parameters.

`ppParams`\
[out] Array of type parameters.

`pcParams`\
[in, out] Number of parameters in the `ppParams` array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Return the type parameters in order from left to right. For example, Dictionary\<K,V> returns IDebugFormalGenericParameters {K,V}.

## See also
- [IDebugGenericFieldDefinition](../../../extensibility/debugger/reference/idebuggenericfielddefinition.md)
