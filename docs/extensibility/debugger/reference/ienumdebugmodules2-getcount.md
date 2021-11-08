---
description: "Returns the number of elements in the modules enumeration."
title: IEnumDebugModules2::GetCount | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IEnumDebugModules2::GetCount
helpviewer_keywords:
- IEnumDebugModules2::GetCount
ms.assetid: f4def3d2-7cc9-4cd2-9649-3b7e00a76220
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
# IEnumDebugModules2::GetCount
Returns the number of elements in the enumeration.

## Syntax

```cpp
HRESULT GetCount(
   ULONG* pcelt
);
```

```csharp
int GetCount(
   out uint pcelt
);
```

## Parameters
`pcelt`\
[out] Returns the number of elements in the enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.

## See also
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
