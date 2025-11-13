---
description: "Gets the name of this alias."
title: IDebugAlias::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAlias::GetName
helpviewer_keywords:
- IDebugAlias::GetName method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAlias::GetName

Gets the name of this alias.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName(
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName(
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Name of the alias.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
