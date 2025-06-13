---
description: "Retrieves the number of type parameters that are associated with the generic field."
title: IDebugGenericFieldDefinition::TypeParamCount
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- TypeParamCount
- IDebugGenericFieldDefinition::TypeParamCount
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericFieldDefinition::TypeParamCount

Retrieves the number of type parameters that are associated with the generic field.

## Syntax

### [C#](#tab/csharp)
```csharp
int TypeParamCount(
   ref uint pcParams
);
```
### [C++](#tab/cpp)
```cpp
HRESULT TypeParamCount(
   ULONG32* pcParams
);
```
---

## Parameters
`pcParams`\
[in, out] Number of type parameters.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 If List\<T>, this method returns 1, and, if List\<T1,T2>, this method returns 2. This method returns 0 if there are no type parameters.

## See also
- [IDebugGenericFieldDefinition](../../../extensibility/debugger/reference/idebuggenericfielddefinition.md)
