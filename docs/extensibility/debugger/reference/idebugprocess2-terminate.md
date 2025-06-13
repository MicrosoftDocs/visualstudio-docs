---
description: "Terminates the process."
title: IDebugProcess2::Terminate
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::Terminate
helpviewer_keywords:
- IDebugProcess2::Terminate
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::Terminate

Terminates the process.

## Syntax

### [C#](#tab/csharp)
```csharp
int Terminate();
```
### [C++](#tab/cpp)
```cpp
HRESULT Terminate( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When a process is terminated, all programs within that process are terminated; none are allowed to run any more code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
