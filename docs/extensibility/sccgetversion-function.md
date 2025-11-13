---
description: "This function gets the version number of the Source Control Plug-in API supported by the source control plug-in."
title: SccGetVersion Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetVersion
helpviewer_keywords:
- SccGetVersion function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGetVersion Function

This function gets the version number of the Source Control Plug-in API supported by the source control plug-in.

## Syntax

```cpp
LONG SccGetVersion(void);
```

#### Parameters
 None.

## Return Value
 A `LONG` data type that contains the version number of the supported Source Control Plug-in API:

|WORD|Description|
|----------|-----------------|
|HIWORD|Major version|
|LOWORD|Minor version|

## Remarks
 For example, if a source control plug-in supports version 1.3 of the Source Control Plug-in API, this function would return 0x0103.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
