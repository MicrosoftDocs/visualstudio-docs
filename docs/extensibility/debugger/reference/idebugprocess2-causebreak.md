---
description: "Requests that the next program that is running code in this process halt and send an IDebugBreakEvent2 event object."
title: IDebugProcess2::CauseBreak | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::CauseBreak
helpviewer_keywords:
- IDebugProcess2::CauseBreak
ms.assetid: efda8865-2319-4d53-90bf-6d9d74cd5195
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::CauseBreak

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
