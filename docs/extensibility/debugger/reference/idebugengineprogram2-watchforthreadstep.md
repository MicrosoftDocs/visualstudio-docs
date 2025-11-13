---
description: "Watches for execution (or stops watching for execution) to occur on the given thread."
title: IDebugEngineProgram2::WatchForThreadStep
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngineProgram2::WatchForThreadStep
helpviewer_keywords:
- IDebugEngineProgram2::WatchForThreadStep
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngineProgram2::WatchForThreadStep

Watches for execution (or stops watching for execution) to occur on the given thread.

## Syntax

### [C#](#tab/csharp)
```csharp
int WatchForThreadStep( 
   IDebugProgram2 pOriginatingProgram,
   uint           dwTid,
   int            fWatch,
   uint           dwFrame
);
```
### [C++](#tab/cpp)
```cpp
HRESULT WatchForThreadStep( 
   IDebugProgram2* pOriginatingProgram,
   DWORD           dwTid,
   BOOL            fWatch,
   DWORD           dwFrame
);
```
---

## Parameters
`pOriginatingProgram`\
[in] An [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object representing the program being stepped.

`dwTid`\
[in] Specifies the identifier of the thread to watch.

`fWatch`\
[in] Non-zero (`TRUE`) means start watching for execution on the thread identified by `dwTid`; otherwise, zero (`FALSE`) means stop watching for execution on `dwTid`.

`dwFrame`\
[in] Specifies a frame index that controls the step type. When this is value is zero (0), the step type is "step into" and the program should stop whenever the thread identified by `dwTid` executes. When `dwFrame` is non-zero, the step type is "step over" and the program should stop only if the thread identified by `dwTid` is running in a frame whose index is equal to or higher on the stack than `dwFrame`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When the session debug manager (SDM) steps a program, identified by the `pOriginatingProgram` parameter, it notifies all other attached programs by calling this method.

 This method is applicable only to same-thread stepping.

## See also
- [IDebugEngineProgram2](../../../extensibility/debugger/reference/idebugengineprogram2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
