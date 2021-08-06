---
description: "Terminates the process."
title: IDebugProcess2::Terminate | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::Terminate
helpviewer_keywords:
- IDebugProcess2::Terminate
ms.assetid: 5e6bf373-0fe9-4321-b04a-473a65f664d9
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
# IDebugProcess2::Terminate
Terminates the process.

## Syntax

```cpp
HRESULT Terminate( 
   void 
);
```

```csharp
int Terminate();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When a process is terminated, all programs within that process are terminated; none are allowed to run any more code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
