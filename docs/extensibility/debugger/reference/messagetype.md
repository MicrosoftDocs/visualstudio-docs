---
description: "Specifies the message type and reason."
title: MESSAGETYPE
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- MESSAGETYPE
helpviewer_keywords:
- MESSAGETYPE enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# MESSAGETYPE

Specifies the message type and reason.

## Syntax

### [C#](#tab/csharp)
```csharp
public enum enum_MESSAGETYPE { 
   MT_OUTPUTSTRING      = 0x0000001,
   MT_MESSAGEBOX        = 0x00000002,
   MT_TYPE_MASK         = 0x000000FF,
   MT_REASON_EXCEPTION  = 0x00000100,
   MT_REASON_TRACEPOINT = 0x00000200,
   MT_REASON_MASK       = 0x0000FF00
};
```
### [C++](#tab/cpp)
```cpp
enum enum_MESSAGETYPE { 
   MT_OUTPUTSTRING      = 0x0000001,
   MT_MESSAGEBOX        = 0x00000002,
   MT_TYPE_MASK         = 0x000000FF,
   MT_REASON_EXCEPTION  = 0x00000100,
   MT_REASON_TRACEPOINT = 0x00000200,
   MT_REASON_MASK       = 0x0000FF00
};
typedef DWORD MESSAGETYPE;
```
---

## Fields
 `MT_OUTPUTSTRING`\
 Indicates that the message should be sent to the output window. This is mutually exclusive from `MT_MESSAGEBOX`.

 `MT_MESSAGEBOX`\
 Indicates that the message should be shown in a message box. This is mutually exclusive from `MT_OUTPUTSTRING`.

 `MT_TYPE_MASK`\
 A mask value to isolate the destination for the message.

 `MT_REASON_EXCEPTION`\
 Indicates that a message box is being shown as a result of an exception. This is mutually exclusive from `MT_REASON_TRACEPOINT`.

 `MT_REASON_TRACEPOINT`\
 Indicates that a message box is being shown as a result of hitting a tracepoint. This is mutually exclusive to `MT_REASON_EXCEPTION`.

 `MT_REASON_MASK`\
 A mask value to isolate the reason for the message being shown.

## Remarks
 These values are returned from the [GetMessage](../../../extensibility/debugger/reference/idebugmessageevent2-getmessage.md) and [GetErrorMessage](../../../extensibility/debugger/reference/idebugerrorevent2-geterrormessage.md) methods.

 One of the reason values can be combined with one of the output destination values using a bitwise `OR`.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [GetMessage](../../../extensibility/debugger/reference/idebugmessageevent2-getmessage.md)
- [GetErrorMessage](../../../extensibility/debugger/reference/idebugerrorevent2-geterrormessage.md)
