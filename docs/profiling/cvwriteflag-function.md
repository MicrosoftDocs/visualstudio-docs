---
title: "CvWriteFlag Function | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "cvmarkers/CvWriteFlagExVA"
  - "cvmarkers/CvWriteFlagExW"
  - "cvmarkers/CvWriteFlagExVW"
  - "cvmarkers/CvWriteFlagExA"
helpviewer_keywords:
  - "CvWriteFlagExW method"
  - "CvWriteFlagExVA method"
  - "CvWriteFlagExA method"
  - "CvWriteFlagExVW method"
ms.assetid: ee9da1e2-7b34-4cba-81e2-215d25d32e4d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# CvWriteFlag function
Writes a flag to the Concurrency Visualizer trace file.

## Syntax

```C
HRESULT CvWriteFlagExW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCWSTR pMessage,
    ...
    );

HRESULT CvWriteFlagExA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCSTR pMessage,
    ...
    );

HRESULT CvWriteFlagExVW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCWSTR pMessage,
    _In_ va_list argList);

HRESULT CvWriteFlagExVA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCSTR pMessage,
    _In_ va_list argList);
```

#### Parameters
 `argList`
 List of arguments.

 `category`
 Category.

 `level`
 Importance level.

 `pMarkerSeries`
 Valid marker series context. Cannot be NULL.

 `pMessage`
 Message format string. Cannot be NULL.

## Return value
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

 **Unicode:** CvWriteFlagExW, CvWriteFlagExVW

 <strong>ANSI:</strong>CvWriteFlagExA, CvWriteFlagExVA

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)