---
description: "This method gets the Edit and Continue (ENC) update for this program."
title: IDebugProgram2::GetENCUpdate | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetENCUpdate
helpviewer_keywords:
- IDebugProgram2::GetENCUpdate
ms.assetid: 9832aac8-6320-4fd8-91dd-2a0852febb00
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetENCUpdate
This method gets the Edit and Continue (ENC) update for this program. A custom debug engine always returns `E_NOTIMPL`.

## Syntax

```cpp
HRESULT GetENCUpdate( 
   IUnknown** ppUpdate
);
```

```csharp
int GetENCUpdate(
   out object ppUpdate
);
```

## Parameters
`ppUpdate`\
[out] Returns an internal interface that can be used to update this program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A custom debug engine should always return `E_NOTIMPL`.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
