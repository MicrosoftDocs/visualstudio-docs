---
description: "This function cleans up any allocations or open connections created by a previous call to the SccInitialize in preparation for shutting down the source control plug-in."
title: SccUninitialize Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccUninitialize
helpviewer_keywords:
- SccUninitialize function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccUninitialize Function

This function cleans up any allocations or open connections created by a previous call to the [SccInitialize](../extensibility/sccinitialize-function.md) in preparation for shutting down the source control plug-in.

## Syntax

```cpp
SCCRTN SccUninitialize (
   LPVOID pvContext
);
```

#### Parameters
 pvContext

[in] The pointer to the source control plug-in context structure created in the [SccInitialize](../extensibility/sccinitialize-function.md).

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The clean-up completed successfully.|

## Remarks
 The source control plug-in is responsible for preparing to be shut down and for freeing memory that the plug-in has allocated for the context structure. The function is called once for each given instance of a plug-in. A call to the [SccInitialize](../extensibility/sccinitialize-function.md) precedes this call. No projects can still be open at the time of the call to `SccUninitialize`.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
- [SccInitialize](../extensibility/sccinitialize-function.md)
