---
description: "Requests that the next program that is running code in this process halt and send an IDebugBreakEvent2 event object."
title: IDebugProcess2::CauseBreak
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::CauseBreak
helpviewer_keywords:
- IDebugProcess2::CauseBreak
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::CauseBreak

Requests that the next program that is running code in this process halt and send an [IDebugBreakEvent2](../../../extensibility/debugger/reference/idebugbreakevent2.md) event object.

## Syntax

### [C#](#tab/csharp)
```csharp
int CauseBreak();
```
### [C++](#tab/cpp)
```cpp
HRESULT CauseBreak( 
   void
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
