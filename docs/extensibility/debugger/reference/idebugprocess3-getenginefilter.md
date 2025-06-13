---
description: "Retrieves an array of unique identifiers for available debug engines."
title: IDebugProcess3::GetEngineFilter
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetEngineFilter
- IDebugProcess3::GetEngineFilter
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess3::GetEngineFilter

Retrieves an array of unique identifiers for available debug engines.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetEngineFilter(
   out GUID_ARRAY[] pEngineArray
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEngineFilter(
   GUID_ARRAY *pEngineArray
);
```
---

## Parameters
`pEngineArray`\
[out] Reference to a structure that contains unique identifiers for debug engines.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [GUID_ARRAY](../../../extensibility/debugger/reference/guid-array.md)
