---
description: "This method locates an alias, given a name."
title: IDebugBinder3::FindAlias
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::FindAlias
helpviewer_keywords:
- IDebugBinder3::FindAlias method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::FindAlias

This method locates an alias, given a name. This will search all aliases in the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int FindAlias(
   string          pcstrName,
   out IDebugAlias ppAlias
);
```
### [C++](#tab/cpp)
```cpp
HRESULT FindAlias(
   LPCOLESTR     pcstrName,
   IDebugAlias** ppAlias
);
```
---

## Parameters
`pcstrName`\
[in] Name of alias to find.

`ppAlias`\
[out] Alias found (if any) represented by the [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) interface.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` (if alias is not found) or an error code.

## Remarks
 This method initializes the destination object to null before calling; then it tests for a null value afterward to determine whether or not the alias was found.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
