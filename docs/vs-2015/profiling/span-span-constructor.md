---
title: "span::span Constructor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords:
  - "cvmarkersobj/Concurrency::diagnostic::span::span"
helpviewer_keywords:
  - "Concurrency::diagnostic::span constructor"
ms.assetid: 8b5578aa-5e5c-4ac7-87c7-ce87c4246e2c
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---

# span::span Constructor

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Initializes a new instance of the `span` class.

## Syntax

```
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

**Header:** cvmarkersobj.h

**Namespace:** Concurrency::diagnostic

## See Also

[span Class](../profiling/span-class.md)
