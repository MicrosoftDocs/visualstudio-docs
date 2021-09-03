---
description: "Writes an alert to the Concurrency Visualizer trace file."
title: marker_series::write_alert Method | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersobj/Concurrency, diagnostic:marker_series::write_alert
helpviewer_keywords: 
- Concurrency, diagnostic:marker_series::write_alert method
ms.assetid: 9d5465c7-f862-47a7-b249-4116605075a6
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# marker_series::write_alert method
Writes an alert to the Concurrency Visualizer trace file.

## Syntax

```cpp
void write_alert(
   _In_ LPCTSTR _Format,
   ...
);
```

#### Parameters
 `_Format`
 A composite format string that contains text intermixed with zero or more format items, which correspond to objects in the argument list.

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [marker_series class](../profiling/marker-series-class.md)
