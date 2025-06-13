---
description: "Sets the response, if any, from the message box."
title: IDebugMessageEvent2::SetResponse
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMessageEvent2::SetResponse
helpviewer_keywords:
- IDebugMessageEvent2::SetResponse method
- SetResponse method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMessageEvent2::SetResponse

Sets the response, if any, from the message box.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetResponse( 
   uint dwResponse
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetResponse( 
   DWORD dwResponse
);
```
---

## Parameters
`dwResponse`\
[in] Specifies the response, using the conventions of the Win32 `MessageBox` function. See the [AfxMessageBox](/cpp/mfc/reference/cstring-formatting-and-message-box-display#afxmessagebox) function for details.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugMessageEvent2](../../../extensibility/debugger/reference/idebugmessageevent2.md)
- [AfxMessageBox](/cpp/mfc/reference/cstring-formatting-and-message-box-display#afxmessagebox)
