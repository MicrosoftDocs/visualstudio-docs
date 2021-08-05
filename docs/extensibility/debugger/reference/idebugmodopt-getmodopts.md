---
description: "Retrieves a list of optional modifiers."
title: IDebugModOpt::GetModOpts | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugModOpt::GetModOpts
- GetModOpts
ms.assetid: cb513fa9-d521-4a65-b968-f55f53a368df
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
# IDebugModOpt::GetModOpts
Retrieves a list of optional modifiers.

## Syntax

```cpp
HRESULT GetModOpts(
   ULONG  celt,
   BSTR*  rgelt,
   ULONG* pceltFetched
);
```

```csharp
int GetModOpts(
   uint         celt,
   out string[] rgelt,
   ref uint     pceltFetched
);
```

## Parameters
`celt`\
[in] Number of elements to be returned.

`rgelt`\
[out] Returns an array that contains the options.

`pceltFetched`\
[in, out] Number of elements returned in the `rgelt` array.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugModOpt](../../../extensibility/debugger/reference/idebugmodopt.md)
