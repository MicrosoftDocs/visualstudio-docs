---
description: "Determines if the array has base indices (lower bounds) defined."
title: IDebugArrayObject2::HasBaseIndices | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- HasBaseIndices
- IDebugArrayObject2::HasBaseIndices
ms.assetid: 51a5d145-ea53-422c-b5cf-c800cf64b8e6
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugArrayObject2::HasBaseIndices

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
