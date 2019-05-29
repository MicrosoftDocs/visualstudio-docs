---
title: "IDebugProcess2::GetPhysicalProcessId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess2::GetPhysicalProcessId"
helpviewer_keywords:
  - "IDebugProcess2::GetPhysicalProcessId"
ms.assetid: 77da6e10-75af-4308-97dd-c44416ca52d7
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess2::GetPhysicalProcessId
Gets the system process identifier.

## Syntax

```cpp
HRESULT GetPhysicalProcessId(
   AD_PROCESS_ID* pdwProcessId
);
```

```csharp
int GetPhysicalProcessId(
   AD_PROCESS_ID[] pdwProcessId
);
```

## Parameters
`pdwProcessId`\
[out] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that is filled in with the system process identifier information.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)