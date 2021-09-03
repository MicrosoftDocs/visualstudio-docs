---
description: "Retrieves an array of unique identifiers for available debug engines."
title: IDebugProcess3::GetEngineFilter | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetEngineFilter
- IDebugProcess3::GetEngineFilter
ms.assetid: ccb7ecb0-f189-4e80-b5b2-221a095e01f5
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
# IDebugProcess3::GetEngineFilter
Retrieves an array of unique identifiers for available debug engines.

## Syntax

```cpp
HRESULT GetEngineFilter(
   GUID_ARRAY *pEngineArray
);
```

```csharp
public int GetEngineFilter(
   out GUID_ARRAY[] pEngineArray
);
```

## Parameters
`pEngineArray`\
[out] Reference to a structure that contains unique identifiers for debug engines.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess3](../../../extensibility/debugger/reference/idebugprocess3.md)
- [GUID_ARRAY](../../../extensibility/debugger/reference/guid-array.md)
