---
description: "Initializes a new instance of the span class."
title: "span::span Constructor"
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "cvmarkersobj/Concurrency::diagnostic::span::span"
helpviewer_keywords:
  - "Concurrency::diagnostic::span constructor"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# span::span Constructor

Initializes a new instance of the `span` class.

## Syntax

```cpp
span(
   const marker_series& _Series,
   _In_ LPCTSTR _Format,
   ...
);
span(
   const marker_series& _Series,
   marker_importance _Importance,
   _In_ LPCTSTR _Format,
   ...
);
span(
   const marker_series& _Series,
   int _Category,
   _In_ LPCTSTR _Format,
   ...
);
span(
   const marker_series& _Series,
   marker_importance _Importance,
   int _Category,
   _In_ LPCTSTR _Format,
   ...
);
```

#### Parameters

`_Series`
Valid marker series context.

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

- [span class](../profiling/span-class.md)
