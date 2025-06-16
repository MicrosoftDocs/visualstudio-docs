---
description: "Determines if the array has base indices (lower bounds) defined."
title: IDebugArrayObject2::HasBaseIndices
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- HasBaseIndices
- IDebugArrayObject2::HasBaseIndices
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject2::HasBaseIndices

Determines if the array has base indices (lower bounds) defined.

## Syntax

### [C#](#tab/csharp)
```csharp
int HasBaseIndices (
   out bool pfHasBaseIndices
);
```
### [C++](#tab/cpp)
```cpp
HRESULT HasBaseIndices (
   BOOL* pfHasBaseIndices
);
```
---

## Parameters
`pfHasBaseIndices`\
[out] TRUE to specify that the array has base indices (lower bounds); otherwise, FALSE.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.
