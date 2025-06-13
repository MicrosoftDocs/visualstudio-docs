---
description: "Requests that the program stop execution the next time one of its threads attempts to run."
title: IDebugProgram2::CauseBreak
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::CauseBreak
helpviewer_keywords:
- IDebugProgram2::CauseBreak
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::CauseBreak

Requests that the program stop execution the next time one of its threads attempts to run.

## Syntax

### [C#](#tab/csharp)
```csharp
int CauseBreak();
```
### [C++](#tab/cpp)
```cpp
HRESULT CauseBreak( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 An [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event is sent when the program next attempts to run code after this method is called.

 This method is asynchronous in that the method returns immediately without necessarily waiting for the program to stop.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md)
