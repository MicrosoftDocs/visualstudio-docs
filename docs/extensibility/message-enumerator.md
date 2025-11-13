---
title: Message Enumerator
description: The members of this enumerator are used for the TEXTOUTPROC function, which is a callback function that the IDE provides when it calls the SccOpenProject.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- message enumerator
- source control plug-ins, message enumeration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Message enumerator

The following flags are used for the `TEXTOUTPROC` function, which is a callback function that the IDE provides when it calls the [SccOpenProject](../extensibility/sccopenproject-function.md) (see [LPTEXTOUTPROC](../extensibility/lptextoutproc.md) for details on the callback function).

 If the IDE is asked to cancel the process, it may get one of the cancel messages. In this case, the source control plug-in uses `SCC_MSG_STARTCANCEL` to ask the IDE to display the **Cancel** button. After this, any set of normal messages may be sent. If any of these returns `SCC_MSG_RTN_CANCEL`, then the plug-in quits the operation and returns. The plug-in also polls `SCC_MSG_DOCANCEL` periodically to determine if the user has canceled the operation. When all operations are done, or if the user has canceled, the plug-in sends `SCC_MSG_STOPCANCEL`. The `SCC_MSG_INFO`, SCC_MSG_WARNING, and SCC_MSG_ERROR types are used for messages that get displayed in the scrolling list of messages. `SCC_MSG_STATUS` is a special type that indicates that the text should show up in a status bar or temporary display area. It does not remain permanently in the list.

## Syntax

```
enum { 
   SCC_MSG_RTN_CANCEL = -1, 
   SCC_MSG_RTN_OK = 0, 
   SCC_MSG_INFO = 1 
   SCC_MSG_WARNING, 
   SCC_MSG_ERROR, 
   SCC_MSG_STATUS, 
   SCC_MSG_DOCANCEL, 
   SCC_MSG_STARTCANCEL, 
   SCC_MSG_STOPCANCEL 
};
```

## Members
 SCC_MSG_RTN_CANCEL
 Return from callback to indicate cancel.

 SCC_MSG_RTN_OK
 Return from callback to continue.

 SCC_MSG_INFO
 Message is informational.

 SCC_MSG_WARNING
 Message is a warning.

 SCC_MSG_ERROR
 Message is an error.

 SCC_MSG_STATUS
 Message is meant for status bar.

 SCC_MSG_DOCANCEL
 No text; IDE returns `SCC_MSG_RTN_OK` or `SCC_MSG_RTN_CANCEL`.

 SCC_MSG_STARTCANCEL
 Starts a cancel loop.

 SCC_MSG_STOPCANCEL
 Stops the cancel loop.

## See also
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
- [LPTEXTOUTPROC](../extensibility/lptextoutproc.md)
