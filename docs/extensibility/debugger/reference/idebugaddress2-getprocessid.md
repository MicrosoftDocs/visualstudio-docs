---
title: "IDebugAddress2::GetProcessID | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugAddress2::GetProcessID"
helpviewer_keywords:
  - "IDebugAddress2::GetProcessID method"
ms.assetid: 2c18889d-074a-4b95-87b4-bf1a067f44ed
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugAddress2::GetProcessID
Retrieves the ID of the process that owns the object represented by this [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md) interface.

## Syntax

```cpp
HRESULT GetProcessID (
   DWORD* pProcID
);
```

```csharp
int GetProcessID (
   out uint pProcID
);
```

## Parameters
`pProcID`\
[out] The process ID.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md)