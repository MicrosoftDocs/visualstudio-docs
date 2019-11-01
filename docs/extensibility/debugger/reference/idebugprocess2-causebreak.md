---
title: "IDebugProcess2::CauseBreak | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess2::CauseBreak"
helpviewer_keywords:
  - "IDebugProcess2::CauseBreak"
ms.assetid: efda8865-2319-4d53-90bf-6d9d74cd5195
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess2::CauseBreak
Requests that the next program that is running code in this process halt and send an [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event object.

## Syntax

```cpp
HRESULT CauseBreak( 
   void
);
```

```csharp
int CauseBreak();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)