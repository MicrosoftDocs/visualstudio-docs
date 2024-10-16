---
description: "Determines if any session has enabled the provider."
title: marker_series::is_enabled Method
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersobj/Concurrency, diagnostic::marker_series::is_enabled
helpviewer_keywords: 
- Concurrency, diagnostic::marker_series::is_enabled method
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# marker_series::is_enabled method

Determines if any session has enabled the provider.

## Syntax

```cpp
bool is_enabled();
bool is_enabled(
   marker_importance _Importance,
   int _Category
);
```

#### Parameters
 `_Importance`
 Importance level.

 `_Category`
 Category.

## Return value

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [marker_series class](../profiling/marker-series-class.md)
