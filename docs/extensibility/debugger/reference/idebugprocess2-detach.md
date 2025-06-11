---
description: "Detaches the debugger from this process by detaching all of the programs in the process."
title: IDebugProcess2::Detach
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::Detach
helpviewer_keywords:
- IDebugProcess2::Detach
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::Detach

Detaches the debugger from this process by detaching all of the programs in the process.

## Syntax

### [C#](#tab/csharp)
```csharp
int Detach();
```
### [C++](#tab/cpp)
```cpp
HRESULT Detach( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 All programs and the process continue running, but are no longer part of the debug session. After the detach operation is complete, no more debug events for this process (and its programs) will be sent.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
