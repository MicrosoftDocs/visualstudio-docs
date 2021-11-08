---
description: "This function gets the version number of the Source Control Plug-in API supported by the source control plug-in."
title: SccGetVersion Function | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetVersion
helpviewer_keywords:
- SccGetVersion function
ms.assetid: a6e786bf-744e-4272-9e21-0be44d23b1a1
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
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
