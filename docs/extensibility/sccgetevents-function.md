---
description: "This function retrieves a queued status event."
title: SccGetEvents Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetEvents
helpviewer_keywords:
- SccGetEvents function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGetEvents function

This function retrieves a queued status event.

## Syntax

```cpp
SCCRTN SccGetEvents (
   LPVOID pvContext,
   LPSTR  lpFileName,
   LPLONG lpStatus,
   LPLONG pnEventsRemaining
);
```

### Parameters
 pvContext

[in] The source control plug-in context structure.

 lpFileName

[in, out] Buffer where the source control plug-in puts the returned file name (up to _MAX_PATH characters).

 lpStatus

[in, out] Returns status code (see [File status code](../extensibility/file-status-code-enumerator.md) for possible values).

 pnEventsRemaining

[in, out] Returns number of entries left in the queue after this call. If this number is large, the caller may decide to call the [SccQueryInfo](../extensibility/sccqueryinfo-function.md) to get all the information at once.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Get events succeeded.|
|SCC_E_OPNOTSUPPORTED|This function is not supported.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|

## Remarks
 This function is called during idle processing to see if there have been any status updates for files under source control. The source control plug-in maintains status of all the files it knows about, and whenever a change of status is noted by the plug-in, the status and the associated file are stored in a queue. When `SccGetEvents` is called, the top element of the queue is retrieved and returned. This function is constrained to return only previously cached information and must have a very quick turnaround (that is, no reading of the disk or asking the source control system for status); otherwise the performance of the IDE may start to degrade.

 If there is no status update to report, the source control plug-in stores an empty string in the buffer pointed to by `lpFileName`. Otherwise, the plug-in stores the full path name of the file for which the status information has changed and returns the appropriate status code (one of the values detailed in [File status code](../extensibility/file-status-code-enumerator.md)).

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [File status code](../extensibility/file-status-code-enumerator.md)
