---
title: CvLeaveSpan Function | Microsoft Docs
description: See reference information for the Concurrency Visualizer SDK function CvLeaveSpan (C library).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvLeaveSpan
helpviewer_keywords: 
  - CvLeaveSpan method
ms.assetid: 3bf65fdf-a471-4efd-ac7a-03e701bbae5d
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# CvLeaveSpan function
Marks the end of span.

## Syntax

```C
HRESULT CvLeaveSpan(
   _In_ PCV_SPAN pSpan
);
```

#### Parameters
 `pSpan`
 Span object returned by previous call to CvEnterSpan*. Cannot be NULL.

## Return Value
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)