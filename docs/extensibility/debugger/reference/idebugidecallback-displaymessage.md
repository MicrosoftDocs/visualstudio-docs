---
description: "Sends the specified message string to the debugger's output window."
title: IDebugIDECallback::DisplayMessage | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugIDECallback::DisplayMessage
ms.assetid: c19b48ee-b370-4fce-91fe-f82bf1e63179
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
# IDebugIDECallback::DisplayMessage

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Sends the specified message string to the debugger's output window.

## Syntax

### [C#](#tab/csharp)
```csharp
int DisplayMessage (
   string szMessage
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DisplayMessage (
   LPCOLESTR szMessage
);
```
---

## Parameters
`szMessage`\
[in] Message string to display in the debugger's output window.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugIDECallback](../../../extensibility/debugger/reference/idebugidecallback.md)
