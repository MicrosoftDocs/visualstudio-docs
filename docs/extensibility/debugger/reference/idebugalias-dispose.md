---
description: "Marks this alias for removal."
title: IDebugAlias::Dispose
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAlias::Dispose
helpviewer_keywords:
- IDebugAlias::Dispose method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAlias::Dispose

Marks this alias for removal.

## Syntax

### [C#](#tab/csharp)
```csharp
int Dispose();
```
### [C++](#tab/cpp)
```cpp
HRESULT Dispose();
```
---

## Parameters
 None.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Once this method is called, the alias is no longer available.

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
