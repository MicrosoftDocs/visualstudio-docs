---
title: "IDebugArrayField::GetNumberOfElements | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugArrayField::GetNumberOfElements"
helpviewer_keywords:
  - "IDebugArrayField::GetNumberOfElements method"
ms.assetid: a1961ef3-d69d-4022-b8c9-b9cfb9811345
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugArrayField::GetNumberOfElements
Gets the number of elements in the array.

## Syntax

```cpp
HRESULT GetNumberOfElements( 
   DWORD* pdwNumElements
);
```

```csharp
int GetNumberOfElements(
   out uint pdwNumElements
);
```

## Parameters
`pdwNumElements`\
[out] Returns the number of elements in the array.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The value returned is the total number of elements in the array, regardless of the number of dimensions.

## See also
- [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)