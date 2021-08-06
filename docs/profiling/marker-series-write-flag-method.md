---
description: "Writes a flag to the Concurrency Visualizer trace file."
title: marker_series::write_flag Method | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersojb/Concurrency, diagnostic::marker_series::write_flag
helpviewer_keywords: 
- Concurrency, diagnostic::marker_series::write_flag method
ms.assetid: ca07f388-e5d5-46fd-b991-fe6e9029a68f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# marker_series::write_flag method
Writes a flag to the Concurrency Visualizer trace file.

## Syntax

```cpp
void write_flag(
   _In_ LPCTSTR _Format,
   ...
);
void write_flag(
   marker_importance _Importance,
   _In_ LPCTSTR _Format,
   ...
);
void write_flag(
   int _Category,
   _In_ LPCTSTR _Format,
   ...
);
void write_flag(
   marker_importance _Importance,
   int _Category,
   _In_ LPCTSTR _Format,
   ...
);
```

#### Parameters
 `_Format`
 A composite format string that contains text intermixed with zero or more format items, which correspond to objects in the argument list.

 `_Importance`
 Importance level.

 `_Category`
 Category.

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [marker_series class](../profiling/marker-series-class.md)
