---
title: "IDebugProgram2::Detach | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgram2::Detach"
helpviewer_keywords:
  - "IDebugProgram2::Detach"
ms.assetid: 5e8d88b0-a8d4-4746-88c0-ad332ee73f33
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgram2::Detach
Detaches a debug engine from the program.

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
 A detached program continues running, but it is no longer part of the debug session. No more program debug events are sent once the debug engine is detached.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)