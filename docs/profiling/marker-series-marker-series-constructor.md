---
description: "Initializes a new instance of the marker_series class."
title: marker_series::marker_series Constructor | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersobj/Concurrency, diagnostic::marker_series::marker_series
helpviewer_keywords: 
- Concurrency, diagnostic::marker_series constructor
ms.assetid: 042c7d23-f1d8-4e09-9e76-a21c30243790
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# marker_series::marker_series constructor
Initializes a new instance of the `marker_series` class.

## Syntax

```cpp
marker_series();
marker_series(
   _In_ LPCTSTR _SeriesName
);
marker_series(
   _In_ const GUID* _ProviderGuid
);
marker_series(
   _In_ const GUID* _ProviderGuid,
   _In_ LPCTSTR _SeriesName
);
```

#### Parameters
 `_SeriesName`
 The name of the series to create.

 `_ProviderGuid`
 The GUID of the series provider.

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [marker_series class](../profiling/marker-series-class.md)
