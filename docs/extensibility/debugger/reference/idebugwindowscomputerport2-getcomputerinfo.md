---
description: "Retrieves information about the computer on which the debugger in running."
title: IDebugWindowsComputerPort2::GetComputerInfo
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetComputerInfo
- IDebugWindowsComputerPort2::GetComputerInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugWindowsComputerPort2::GetComputerInfo

Retrieves information about the computer on which the debugger in running.

## Syntax

### [C#](#tab/csharp)
```csharp
public int GetComputerInfo(
   out COMPUTER_INFO[] pInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetComputerInfo(
   COMPUTER_INFO * pInfo
);
```
---

## Parameters
`pInfo`\
[out] Reference to a structure that contains the computer information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugWindowsComputerPort2](../../../extensibility/debugger/reference/idebugwindowscomputerport2.md)
- [COMPUTER_INFO](../../../extensibility/debugger/reference/computer-info.md)
