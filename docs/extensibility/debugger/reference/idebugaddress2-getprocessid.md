---
description: "Retrieves the ID of the process that owns the object represented by this IDebugAddress2 interface."
title: IDebugAddress2::GetProcessID | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAddress2::GetProcessID
helpviewer_keywords:
- IDebugAddress2::GetProcessID method
ms.assetid: 2c18889d-074a-4b95-87b4-bf1a067f44ed
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
# IDebugAddress2::GetProcessID

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves the ID of the process that owns the object represented by this [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md) interface.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProcessID (
   out uint pProcID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProcessID (
   DWORD* pProcID
);
```
---

## Parameters
`pProcID`\
[out] The process ID.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md)
