---
description: "Writes a message to the Concurrency Visualizer trace file."
title: marker_series::write_message Method
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersobj/Concurrency, diagnostic::marker_series::write_message
helpviewer_keywords: 
- Concurrency, diagnostic::marker_series::write_message method
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# marker_series::write_message method

Writes a message to the Concurrency Visualizer trace file.

## Syntax

```cpp
void write_message(
   _In_ LPCTSTR _Format,
   ...
);
void write_message(
   marker_importance _Importance,
   _In_ LPCTSTR _Format,
   ...
);
void write_message(
   int _Category,
   _In_ LPCTSTR _Format,
   ...
);
void write_message(
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
 Category.Importance level.

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [marker_series class](../profiling/marker-series-class.md)
