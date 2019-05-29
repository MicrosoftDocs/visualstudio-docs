---
title: "IDebugIDECallback::DisplayMessage | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugIDECallback::DisplayMessage"
ms.assetid: c19b48ee-b370-4fce-91fe-f82bf1e63179
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugIDECallback::DisplayMessage
Sends the specified message string to the debugger's output window.

## Syntax

```cpp
HRESULT DisplayMessage (
   LPCOLESTR szMessage
);
```

```csharp
int DisplayMessage (
   string szMessage
);
```

## Parameters
`szMessage`\
[in] Message string to display in the debugger's output window.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugIDECallback](../../../extensibility/debugger/reference/idebugidecallback.md)