---
description: "Requests that the program stop execution the next time one of its threads attempts to run."
title: IDebugProgram2::CauseBreak | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::CauseBreak
helpviewer_keywords:
- IDebugProgram2::CauseBreak
ms.assetid: 07d353fc-68ab-4297-a18f-3d3c7a80e121
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
# IDebugProgram2::CauseBreak
Requests that the program stop execution the next time one of its threads attempts to run.

## Syntax

```cpp
HRESULT CauseBreak( 
   void 
);
```

```csharp
int CauseBreak();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 An [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event is sent when the program next attempts to run code after this method is called.

 This method is asynchronous in that the method returns immediately without necessarily waiting for the program to stop.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md)
