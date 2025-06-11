---
description: "This method retrieves a list of argument types associated with this object."
title: IDebugBinder3::GetTypeArguments
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetTypeArguments
helpviewer_keywords:
- IDebugBinder3::GetTypeArguments method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetTypeArguments

This method retrieves a list of argument types associated with this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetTypeArguments(
   uint          skip,
   uint          count,
   IDebugField[] ppFields,
   out uint      pFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetTypeArguments(
   UINT          skip,
   UINT          count,
   IDebugField** ppFields,
   UINT*         pFetched
);
```
---

## Parameters
`skip`\
[in]Number of fields to skip before getting argument types.

`count`\
[in] The number of argument fields to return (also specifies the size of the `ppFields` array).

`ppFields`\
[in, out] An array of fields that will be filled in on return of this method.

`pFetched`\
[out] \(optional) The number of argument type fields actually returned.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The number of argument types can be obtained beforehand with [GetTypeArgumentCount](../../../extensibility/debugger/reference/idebugbinder3-gettypeargumentcount.md).

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [GetTypeArgumentCount](../../../extensibility/debugger/reference/idebugbinder3-gettypeargumentcount.md)
