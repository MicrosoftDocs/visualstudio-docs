---
description: "This function closes a project, marking the end of a particular session."
title: SccCloseProject Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccCloseProject
helpviewer_keywords:
- SccCloseProject function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccCloseProject function

This function closes a project, marking the end of a particular session.

## Syntax

```cpp
SCCRTN SccCloseProject (
   LPVOID pvContext
);
```

### Parameters
 pvContext
 The source control plug-in context structure.

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The project was successfully closed.|
|SCC_E_PROJNOTOPEN|No project is currently open.|
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|

## Remarks
 The [SccOpenProject](../extensibility/sccopenproject-function.md) is always called before this function. A call to this function is then followed by a call to either the `SccOpenProject` function or the [SccUninitialize](../extensibility/sccuninitialize-function.md), which ends the connection to the source control system completely.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccOpenProject](../extensibility/sccopenproject-function.md)
- [SccInitialize](../extensibility/sccinitialize-function.md)
