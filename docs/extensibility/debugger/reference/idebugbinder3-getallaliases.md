---
description: "This method retrieves a list of aliases from the program."
title: IDebugBinder3::GetAllAliases
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetAllAliases
helpviewer_keywords:
- IDebugBinder3::GetAllAliases method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetAllAliases

This method retrieves a list of aliases from the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAllAliases(
   uint          uRequest,
   IDebugAlias[] ppAliases,
   out uint      puFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAllAliases(
   UINT          uRequest,
   IDebugAlias** ppAliases,
   UINT*         puFetched
);
```
---

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
