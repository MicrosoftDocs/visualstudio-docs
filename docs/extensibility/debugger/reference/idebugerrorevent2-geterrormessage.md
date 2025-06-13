---
description: "Returns information that allows construction of a human-readable error message."
title: IDebugErrorEvent2::GetErrorMessage
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugErrorEvent2::GetErrorMessage
helpviewer_keywords:
- IDebugErrorEvent2::GetErrorMessage
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugErrorEvent2::GetErrorMessage

Returns information that allows construction of a human-readable error message.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetErrorMessage(
   out enum_MESSAGETYPE   pMessageType,
   out string             pbstrErrorFormat,
   out int                phrErrorReason,
   out uint               pdwType,
   out string             pbstrHelpFileName,
   out uint               pdwHelpId
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetErrorMessage(
   MESSAGETYPE* pMessageType,
   BSTR*        pbstrErrorFormat,
   HRESULT*     hrErrorReason,
   DWORD*       pdwType,
   BSTR*        pbstrHelpFileName,
   DWORD*       pdwHelpId
);
```
---

## Parameters
`pMessageType`\
[out] Returns a value from the [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md) enumeration, describing the type of message.

`pbstrErrorFormat`\
[out] The format of the final message to the user (see "Remarks" for details).

`hrErrorReason`\
[out] The error code the message is about.

`pdwType`\
[out] Severity of the error (use the MB_XXX constants for `MessageBox`; for example, `MB_EXCLAMATION` or `MB_WARNING`).

`pbstrHelpFileName`\
[out] Path to a help file (set to a null value if there is no help file).

`pdwHelpId`\
[out] ID of the help topic to display (set to 0 if there is no help topic).

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The error message should be formatted along the lines of `"What I was doing.  %1"`. The `"%1"` would then be replaced by the caller with the error message derived from the error code (which is returned in `hrErrorReason`). The `pMessageType` parameter tells the caller how the final error message should be displayed.

## See also
- [IDebugErrorEvent2](../../../extensibility/debugger/reference/idebugerrorevent2.md)
- [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md)
