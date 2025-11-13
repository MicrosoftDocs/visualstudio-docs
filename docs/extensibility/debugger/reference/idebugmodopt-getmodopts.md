---
description: "Retrieves a list of optional modifiers."
title: IDebugModOpt::GetModOpts
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugModOpt::GetModOpts
- GetModOpts
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModOpt::GetModOpts

Retrieves a list of optional modifiers.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetModOpts(
   uint         celt,
   out string[] rgelt,
   ref uint     pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetModOpts(
   ULONG  celt,
   BSTR*  rgelt,
   ULONG* pceltFetched
);
```
---

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
