---
title: "IDebugBinder3::GetTypeArguments | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords:
  - "IDebugBinder3::GetTypeArguments"
helpviewer_keywords:
  - "IDebugBinder3::GetTypeArguments method"
ms.assetid: fa0c37a7-327f-463e-9a9d-bb3f534584cb
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugBinder3::GetTypeArguments
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]
This method retrieves a list of argument types associated with this object.

## Syntax

```cpp
HRESULT GetTypeArguments(
   UINT          skip,
   UINT          count,
   IDebugField** ppFields,
   UINT*         pFetched
);
```

```csharp
int GetTypeArguments(
   uint          skip,
   uint          count,
   IDebugField[] ppFields,
   out uint      pFetched
);
```

#### Parameters

 `skip`

 [in] Number of fields to skip before getting argument types.

 `count`

 [in] The number of argument fields to return (also specifies the size of the `ppFields` array).

 `ppFields`

 [in, out] An array of fields that will be filled in on return of this method.

 `pFetched`

 [out] The number of argument type fields actually returned (optional).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The number of argument types can be obtained beforehand with [GetTypeArgumentCount](../../../extensibility/debugger/reference/idebugbinder3-gettypeargumentcount.md).

## See Also

- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [GetTypeArgumentCount](../../../extensibility/debugger/reference/idebugbinder3-gettypeargumentcount.md)