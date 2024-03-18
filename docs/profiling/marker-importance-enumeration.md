---
description: "Represents the importance level of a Concurrency Visualizer marker."
title: marker_importance Enumeration
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
- cvmarkersobj/Concurrency, diagnostic::marker_importance
helpviewer_keywords: 
- Concurrency, diagnostic::marker_importance enumeration
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# marker_importance enumeration

Represents the importance level of a Concurrency Visualizer marker.

## Syntax

```cpp
enum marker_importance;
```

## Members

### Values

|Name|Description|
|----------|-----------------|
|`critical_importance`|Specifies that the marker has critical importance.|
|`high_importance`|Specifies that the marker has high importance.|
|`low_importance`|Specifies that the marker has low importance.|
|`normal_importance`|Specifies that the marker has normal importance.|

## Requirements
 **Header:** *cvmarkersobj.h*

 **Namespace:** Concurrency::diagnostic

## See also
- [diagnostic namespace](../profiling/diagnostic-namespace.md)
