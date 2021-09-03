---
description: "This method retrieves a list of aliases from the program."
title: IDebugBinder3::GetAllAliases | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetAllAliases
helpviewer_keywords:
- IDebugBinder3::GetAllAliases method
ms.assetid: 1f9ab2ee-2ab3-4a61-8b99-95dd7fdf3511
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetAllAliases
This method retrieves a list of aliases from the program.

## Syntax

```cpp
HRESULT GetAllAliases(
   UINT          uRequest,
   IDebugAlias** ppAliases,
   UINT*         puFetched
);
```

```csharp
int GetAllAliases(
   uint          uRequest,
   IDebugAlias[] ppAliases,
   out uint      puFetched
);
```

## Parameters
`uRequest`\
[in] The maximum number of aliases to return (specifies the length of the array passed into `ppAliases`).

`ppAliases`\
[in, out] Array to fill in with aliases (if this is a null value and `uRequest` is 0, the count of aliases that can be returned will be returned by `puFetched`).

`puFetched`\
[out] Returns the number of aliases obtained.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
