---
title: QUERYCHANGESFUNC
description: The QUERYCHANGESFUNC callback function is used to enumerate a collection of file names and determine the status of each file.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- QUERYCHANGESFUNC
helpviewer_keywords:
- QUERYCHANGESFUNC callback function
- QUERYCHANGESDATA structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# QUERYCHANGESFUNC

This is a callback function used by the [SccQueryChanges](../extensibility/sccquerychanges-function.md) operation to enumerate a collection of file names and determine each file's status.

 The `SccQueryChanges` function is given a list of files and a pointer to the `QUERYCHANGESFUNC` callback. The source control plug-in enumerates over the given list and provides status (via this callback) for each file in the list.

## Signature

```cpp
typedef BOOL (*QUERYCHANGESFUNC)(
   LPVOID pvCallerData,
   QUERYCHANGESDATA * pChangesData
);
```

## Parameters
 pvCallerData

[in] The `pvCallerData` parameter passed by the caller (the IDE) to [SccQueryChanges](../extensibility/sccquerychanges-function.md). The source control plug-in should make no assumptions about the contents of this value.

 pChangesData

[in] Pointer to a [QUERYCHANGESDATA Structure](#LinkQUERYCHANGESDATA) structure describing the changes to a file.

## Return value
 The IDE returns an appropriate error code:

|Value|Description|
|-----------|-----------------|
|SCC_OK|Continue processing.|
|SCC_I_OPERATIONCANCELED|Stop processing.|
|SCC_E_xxx|Any appropriate SCC error should stop processing.|

## <a name="LinkQUERYCHANGESDATA"></a> QUERYCHANGESDATA Structure
 The structure passed in for each file looks like the following:

```cpp
struct QUERYCHANGESDATA_A
{
    DWORD  dwSize;
    LPCSTR lpFileName;
    DWORD  dwChangeType;
    LPCSTR lpLatestName;
};

typedef struct QUERYCHANGESDATA_A QUERYCHANGESDATA;

struct QUERYCHANGESDATA_W
{
    DWORD   dwSize;
    LPCWSTR lpFileName;
    DWORD   dwChangeType;
    LPCWSTR lpLatestName;
};
```

 dwSize
 Size of this structure (in bytes).

 lpFileName
 The original file name for this item.

 dwChangeType
 Code indicating status of the file:

|Code|Description|
|----------|-----------------|
|`SCC_CHANGE_UNKNOWN`|Cannot tell what has changed.|
|`SCC_CHANGE_UNCHANGED`|No name changes for this file.|
|`SCC_CHANGE_DIFFERENT`|File with a different identity, but the same name exists in the database.|
|`SCC_CHANGE_NONEXISTENT`|File does not exist either in the database or locally.|
|`SCC_CHANGE_DATABASE_DELETED`|File deleted in the database.|
|`SCC_CHANGE_LOCAL_DELETED`|File deleted locally but the file still exists in the database. If this cannot be determined, return `SCC_CHANGE_DATABASE_ADDED`.|
|`SCC_CHANGE_DATABASE_ADDED`|File added to the database but does not exist locally.|
|`SCC_CHANGE_LOCAL_ADDED`|File does not exist in database and is a new local file.|
|`SCC_CHANGE_RENAMED_TO`|File renamed or moved in the database as `lpLatestName`.|
|`SCC_CHANGE_RENAMED_FROM`|File renamed or moved in the database from `lpLatestName`; if this is too expensive to track, return a different flag, such as `SCC_CHANGE_DATABASE_ADDED`.|

 lpLatestName
 The current file name for this item.

## See also
- [Callback functions implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)
- [SccQueryChanges](../extensibility/sccquerychanges-function.md)
- [Error codes](../extensibility/error-codes.md)
