---
title: "IDebugArrayObject::GetDimensions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugArrayObject::GetDimensions"
helpviewer_keywords:
  - "IDebugArrayObject::GetDimensions method"
ms.assetid: 113e0aff-9028-49d6-b104-9fe7be4772d7
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugArrayObject::GetDimensions
Gets the dimensions of the array.

## Syntax

```cpp
HRESULT GetDimensions( 
   DWORD dwCount,
   DWORD dwDimensions[]
);
```

```csharp
int GetDimensions(
   [In] uint    dwCount,
   [Out] uint[] dwDimensions
);
```

## Parameters
`dwCount`\
[in] The number of dimensions to retrieve.

`dwDimensions`\
[in, out] An array that is filled in with the sizes of each dimension. `dwCount` specifies the maximum size of the `dwDimensions` array.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 A multi-dimensional array can have different sizes for each dimension. For example, given the three-dimensional array `myarray[3][2][6]`, this method would return 3, 2, and 6 in the `dwDimensions` parameter in that order.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)