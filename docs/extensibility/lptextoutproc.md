---
title: LPTEXTOUTPROC
description: Learn about the LPTEXTOUTPROC function pointer. The Visual Studio IDE implements the function for displaying error and status.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- LPTEXTOUTPROC
helpviewer_keywords:
- SccMsgDataOnMessage structure
- SccMsgDataOnBeforeGetFile structure
- SccMsgDataIsCancelled structure
- LPTEXTOUTPROC callback function
- SccMsgDataOnAfterGetFile structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# LPTEXTOUTPROC

When the user executes a source control operation from inside the integrated development environment (IDE), the source control plug-in might want to convey error or status messages relating to the operation. The plug-in can display its own message boxes for this purpose. However, for more seamless integration, the plug-in can pass strings to the IDE, which then displays them in its native way of displaying status information. The mechanism for this is the `LPTEXTOUTPROC` function pointer. The IDE implements this function (described in more detail below) for displaying error and status.

The IDE passes to the source control plug-in a function pointer to this function, as the `lpTextOutProc` parameter, when calling the [SccOpenProject](../extensibility/sccopenproject-function.md). During an SCC operation, for example, in the middle of a call to the [SccGet](../extensibility/sccget-function.md) involving many files, the plug-in can call the `LPTEXTOUTPROC` function, periodically passing strings to display. The IDE may display these strings on a status bar, in an output window, or in a separate message box, as appropriate. Optionally, the IDE may be able to display certain messages with a **Cancel** button. This enables the user to cancel the operation, and it gives the IDE the ability to pass this information back to the plug-in.

## Signature
 The IDE's output function has the following signature:

```cpp
typedef LONG (*LPTEXTOUTPROC) (
   LPSTR display_string,
   LONG mesg_type
);
```

## Parameters

display_string

A text string to display. This string should not be terminated with a carriage return or a line feed.

mesg_type

The type of message. The following table lists the supported values for this parameter.

|Value|Description|
|-----------|-----------------|
|`SCC_MSG_INFO, SCC_MSG_WARNING, SCC_MSG_ERROR`|The message is considered Information, Warning, or Error.|
|`SCC_MSG_STATUS`|The message shows status and can be displayed in the status bar.|
|`SCC_MSG_DOCANCEL`|Sent with no message string.|
|`SCC_MSG_STARTCANCEL`|Begins displaying a **Cancel** button.|
|`SCC_MSG_STOPCANCEL`|Stops displaying a **Cancel** button.|
|`SCC_MSG_BACKGROUND_IS_CANCELLED`|Asks IDE if the background operation is to be cancelled: IDE returns `SCC_MSG_RTN_CANCEL` if operation was cancelled; otherwise, returns `SCC_MSG_RTN_OK`. The `display_string` parameter is cast as an [SccMsgDataIsCancelled](#LinkSccMsgDataIsCancelled) structure, which is supplied by the source control plug-in.|
|`SCC_MSG_BACKGROUND_ON_BEFORE_GET_FILE`|Tells the IDE about a file before it is retrieved from version control. The `display_string` parameter is cast as an [SccMsgDataOnBeforeGetFile](#LinkSccMsgDataOnBeforeGetFile) structure, which is supplied by the source control plug-in.|
|`SCC_MSG_BACKGROUND_ON_AFTER_GET_FILE`|Tells the IDE about a file after it has been retrieved from version control. The `display_string` parameter is cast as an [SccMsgDataOnAfterGetFile](#LinkSccMsgDataOnAfterGetFile) structure, which is supplied by the source control plug-in.|
|`SCC_MSG_BACKGROUND_ON_MESSAGE`|Tells the IDE of the current status of a background operation. The `display_string` parameter is cast as an [SccMsgDataOnMessage](#LinkSccMsgDataOnMessage) structure, which is supplied by the source control plug-in.|

## Return value

|Value|Description|
|-----------|-----------------|
|SCC_MSG_RTN_OK|The string was displayed or the operation was completed successfully.|
|SCC_MSG_RTN_CANCEL|The user wants to cancel the operation.|

## Example
 Suppose the IDE calls the [SccGet](../extensibility/sccget-function.md) with twenty file names. The source control plug-in wants to prevent canceling the operation in the middle of a file get. After getting each file, it calls `lpTextOutProc`, passing it the status information on each file, and sends a `SCC_MSG_DOCANCEL` message if it has no status to report. If at any time the plug-in receives a return value of `SCC_MSG_RTN_CANCEL` from the IDE, it cancels the get operation immediately, so that no more files are retrieved.

## Structures

### <a name="LinkSccMsgDataIsCancelled"></a> SccMsgDataIsCancelled

```cpp
typedef struct {
   DWORD dwBackgroundOperationID;
} SccMsgDataIsCancelled;
```

 This structure is sent with the `SCC_MSG_BACKGROUND_IS_CANCELLED` message. It is used to communicate the ID of the background operation that was canceled.

### <a name="LinkSccMsgDataOnBeforeGetFile"></a> SccMsgDataOnBeforeGetFile

```cpp
typedef struct {
   DWORD dwBackgroundOperationID;
   PCSTR szFile;
} SccMsgDataOnBeforeGetFile;
```

 This structure is sent with the `SCC_MSG_BACKGROUND_ON_BEFORE_GET_FILE` message. It is used to communicate the name of the file about to be retrieved and the ID of the background operation that is doing the retrieving.

### <a name="LinkSccMsgDataOnAfterGetFile"></a> SccMsgDataOnAfterGetFile

```cpp
typedef struct {
   DWORD dwBackgroundOperationID;
   PCSTR szFile;
   SCCRTN sResult;
} SccMsgDataOnAfterGetFile;
```

 This structure is sent with the `SCC_MSG_BACKGROUND_ON_AFTER_GET_FILE` message. It is used to communicate the result of retrieving the specified file as well as the ID of the background operation that did the retrieving. See the return values for the [SccGet](../extensibility/sccget-function.md) for what can be given as a result.

### <a name="LinkSccMsgDataOnMessage"></a> SccMsgDataOnMessage

```cpp
typedef struct {
   DWORD dwBackgroundOperationID;
   PCSTR szMessage;
   BOOL bIsError;
} SccMsgDataOnMessage;
```

 This structure is sent with the `SCC_MSG_BACKGROUND_ON_MESSAGE` message. It is used to communicate the current status of a background operation. The status is expressed as a string to be displayed by the IDE, and `bIsError` indicates the severity of the message (`TRUE` for an error message; `FALSE` for a warning or for an informational message). The ID of the background operation sending the status is also given.

## Code example
 Here is a brief example of calling `LPTEXTOUTPROC` to send the `SCC_MSG_BACKGROUND_ON_MESSAGE` message, showing how to cast the structure for the call.

```cpp
LONG SendStatusMessage(
    LPTEXTOUTPROC pTextOutProc,
    DWORD         dwBackgroundID,
    LPCTSTR       pStatusMsg,
    BOOL          bIsError)
{
    SccMsgDataOnMessage msgData = { 0 };
    LONG                result  = 0;

    msgData.dwBackgroundOperationID = dwBackgroundID;
    msgData.szMessage               = pStatusMsg;
    msgData.bIsError                = bIsError;

    result = pTextOutProc(reinterpret_cast<LPCTSTR>(&msgData), SCC_MSG_BACKGROUND_ON_MESSAGE);
    return result;
}
```

## See also
- [Callback functions implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
