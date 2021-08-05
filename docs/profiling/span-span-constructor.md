---
description: "Initializes a new instance of the span class."
title: "span::span Constructor | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "cvmarkersobj/Concurrency::diagnostic::span::span"
helpviewer_keywords:
  - "Concurrency::diagnostic::span constructor"
ms.assetid: 8b5578aa-5e5c-4ac7-87c7-ce87c4246e2c
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
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
