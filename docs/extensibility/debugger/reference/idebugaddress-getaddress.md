---
description: "Returns a structure describing an object and its location within its scope or container."
title: IDebugAddress::GetAddress
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAddress::GetAddress
helpviewer_keywords:
- IDebugAddress:GetAddress method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAddress::GetAddress

Returns a structure describing an object and its location within its scope or container.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAddress(
   DEBUG_ADDRESS[] pAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAddress (
   DEBUG_ADDRESS * pAddress
);
```
---

## Parameters
`pAddress`\
[in, out] A [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure that is filled in by this method.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure is passed to this method, which then fills it in with the appropriate information. How this information is interpreted depends on the kind of information returned and the symbol handler itself. See [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) for more details.

## See also
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)
