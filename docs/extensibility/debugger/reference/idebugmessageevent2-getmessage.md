---
description: "Gets the message to be displayed."
title: IDebugMessageEvent2::GetMessage
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMessageEvent2::GetMessage
helpviewer_keywords:
- GetMessage method
- IDebugMessageEvent2::GetMessage method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMessageEvent2::GetMessage

Gets the message to be displayed.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMessage( 
   out enum_MESSAGETYPE pMessageType,
   out string           pbstrMessage,
   out uint             pdwType,
   out string           pbstrHelpFileName,
   out uint             dwHelpId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMessage( 
   MESSAGETYPE* pMessageType,
   BSTR*        pbstrMessage,
   DWORD*       pdwType,
   BSTR*        pbstrHelpFileName,
   DWORD*       pdwHelpId
);
```
---

## Parameters
`pMessageType`\
[out] Returns a value from the [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md) enumeration that describes the type of the message.

`pbstrMessage`\
[out] Returns the message.

`pdwType`\
[out] Returns the type of the message, using the conventions of the Win32 `MessageBox` function. See the [AfxMessageBox](/cpp/mfc/reference/cstring-formatting-and-message-box-display#afxmessagebox) function for details.

`pbstrHelpFileName`\
[in, out] Returns the help file name. May be a null (C++) or empty (C#) value if there is no help file.

`pdwHelpId`\
[in, out] Returns the help identifier. May be 0 if there is no help associated with this message.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugMessageEvent2](../../../extensibility/debugger/reference/idebugmessageevent2.md)
- [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md)
- [AfxMessageBox](/cpp/mfc/reference/cstring-formatting-and-message-box-display#afxmessagebox)
