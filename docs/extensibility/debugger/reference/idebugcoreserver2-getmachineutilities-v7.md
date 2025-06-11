---
description: "This method gets the machine utilities for a server."
title: IDebugCoreServer2::GetMachineUtilities_V7
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCoreServer2::GetMachineUtilities_V7
helpviewer_keywords:
- IDebugCoreServer2::GetMachineUtilities_V7
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCoreServer2::GetMachineUtilities_V7

This method gets the machine utilities for a server.

> [!NOTE]
> This method is obsolete: do not use (Visual Studio always returns `E_NOTIMPL` if this method is called). It is retained for historical reasons.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMachineUtilities_V7(
   out IDebugMDMUtil2_V7 ppUtil
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMachineUtilities_V7(
   IDebugMDMUtil2_V7** ppUtil
);
```
---

## Parameters
`ppUtil`\
[out] Returns an `IDebugMDMUtil2_V7` interface that represents the machine utilities information.

## Return Value
 Always returns `E_NOTIMPL`, indicating that the method is not implemented.

## Remarks
 Visual Studio always returns `E_NOTIMPL` if this method is called.

## See also
- [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)
