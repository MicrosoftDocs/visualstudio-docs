---
title: "IDebugProcess2::Detach | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProcess2::Detach"
helpviewer_keywords:
  - "IDebugProcess2::Detach"
ms.assetid: ee2b9084-2db1-4e49-a1d9-387284b7c3f8
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProcess2::Detach
Detaches the debugger from this process by detaching all of the programs in the process.

## Syntax

```cpp
HRESULT Detach( 
   void 
);
```

```csharp
int Detach();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 All programs and the process continue running, but are no longer part of the debug session. After the detach operation is complete, no more debug events for this process (and its programs) will be sent.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)