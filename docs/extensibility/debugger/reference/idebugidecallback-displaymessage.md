---
description: "Sends the specified message string to the debugger's output window."
title: IDebugIDECallback::DisplayMessage
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugIDECallback::DisplayMessage
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugIDECallback::DisplayMessage

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
