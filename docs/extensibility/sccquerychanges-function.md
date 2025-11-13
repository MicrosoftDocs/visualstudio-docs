---
description: "This function enumerates a given list of files, providing information about name changes for each file via a callback function."
title: SccQueryChanges Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccQueryChanges
helpviewer_keywords:
- SccQueryChanges function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccQueryChanges Function

This function enumerates a given list of files, providing information about name changes for each file via a callback function.

## Syntax

```cpp
SCCRTN SccQueryChanges(
   LPVOID           pContext,
   LONG             nFiles,
   LPCSTR*          lpFileNames,
   QUERYCHANGESFUNC pfnCallback,
   LPVOID           pvCallerData
);
```

#### Parameters
 pContext

[in] The source control plug-in context pointer.

 nFiles

[in] Number of files in `lpFileNames` array.

 lpFileNames

[in] Array of file names to get information about.

 pfnCallback

[in] Callback function to call for each file name in the list (see [QUERYCHANGESFUNC](../extensibility/querychangesfunc.md) for details).

 pvCallerData

[in] Value that will be passed unchanged to the callback function.

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The query process completed successfully.|
|SCC_E_PROJNOTOPEN|The project has not been opened in source control.|
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|
|SCC_E_NONSPECIFICERROR|An unspecified or general error occurred.|

## Remarks
 Changes being queried for are to the namespace: specifically, renaming, adding, and removing a file.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [QUERYCHANGESFUNC](../extensibility/querychangesfunc.md)
- [Error Codes](../extensibility/error-codes.md)
