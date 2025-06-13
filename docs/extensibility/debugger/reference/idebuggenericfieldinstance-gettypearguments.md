---
description: "Retrieves the type parameter arguments for this instance."
title: IDebugGenericFieldInstance::GetTypeArguments
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetTypeArguments
- IDebugGenericFieldInstance::GetTypeArguments
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugGenericFieldInstance::GetTypeArguments

Retrieves the type parameter arguments for this instance.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetTypeArguments(
   uint              cArgs,
   out IDebugField[] ppArgs,
   ref uint          pcArgs
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetTypeArguments(
   ULONG32       cArgs,
   IDebugField** ppArgs,
   ULONG32*      pcArgs
);
```
---

## Parameters
`cArgs`\
[in] Number of type parameters.

`ppArgs`\
[out] Returns an array of type parameters.

`pcArgs`\
[in, out] Number of members in the `ppArgs` array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)
