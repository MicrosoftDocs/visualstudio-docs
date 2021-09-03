---
description: "Gets the GUID for this process."
title: IDebugProcess2::GetProcessId | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::GetProcessId
helpviewer_keywords:
- IDebugProcess2::GetProcessId
ms.assetid: d5b6f03c-d49d-4b83-b072-016ac3124f5f
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
# IDebugProcess2::GetProcessId
Gets the GUID for this process.

## Syntax

```cpp
HRESULT GetProcessId(
   GUID* pguidProcessId
);
```

```csharp
int GetProcessId(
   out Guid pguidProcessId
);
```

## Parameters
`pguidProcessId`\
[out] Returns the GUID for this process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The Globally Unique IDentifier (GUID) identifies this process from all other processes running in the system.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
