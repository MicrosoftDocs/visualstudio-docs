---
description: "Gets the name of a thread."
title: IDebugThread2::GetName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugThread2::GetName
helpviewer_keywords:
- IDebugThread2::GetName
ms.assetid: eec54b8f-4a0e-4919-b0f9-81d4bd1e0b6f
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
# IDebugThread2::GetName
Gets the name of a thread.

## Syntax

```cpp
HRESULT GetName ( 
   BSTR* pbstrName
);
```

```csharp
int GetName ( 
   out string pbstrName
);
```

## Parameters
`pbstrName`\
[out] Returns the name of the thread.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The retrieved name is always a name that can be displayed and this name describes the thread. The thread name might be derived from a run-time architecture that supports named threads, or it might be a name derived from the debug engine. Alternatively, the name of the thread can be set by a call to the [SetThreadName](../../../extensibility/debugger/reference/idebugthread2-setthreadname.md) method.

## See also
- [IDebugThread2](../../../extensibility/debugger/reference/idebugthread2.md)
- [SetThreadName](../../../extensibility/debugger/reference/idebugthread2-setthreadname.md)
