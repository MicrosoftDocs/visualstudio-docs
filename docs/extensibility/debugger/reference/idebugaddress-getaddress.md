---
title: "IDebugAddress::GetAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugAddress::GetAddress"
helpviewer_keywords:
  - "IDebugAddress:GetAddress method"
ms.assetid: 2590387b-5d36-4116-9a75-737957b8898e
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugAddress::GetAddress
Returns a structure describing an object and its location within its scope or container.

## Syntax

```cpp
HRESULT GetAddress (
   DEBUG_ADDRESS * pAddress
);
```

```csharp
int GetAddress(
   DEBUG_ADDRESS[] pAddress
);
```

## Parameters
`pAddress`\
[in, out] A [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure that is filled in by this method.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure is passed to this method, which then fills it in with the appropriate information. How this information is interpreted depends on the kind of information returned and the symbol handler itself. See [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) for more details.

## See also
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)