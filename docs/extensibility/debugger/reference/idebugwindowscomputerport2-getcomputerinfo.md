---
description: "Retrieves information about the computer on which the debugger in running."
title: IDebugWindowsComputerPort2::GetComputerInfo | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetComputerInfo
- IDebugWindowsComputerPort2::GetComputerInfo
ms.assetid: 654910b2-c239-44c8-92fc-317680a5672f
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugWindowsComputerPort2::GetComputerInfo

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
