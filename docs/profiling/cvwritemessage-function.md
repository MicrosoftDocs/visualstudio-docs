---
title: CvWriteMessage Function
description: See reference information for the Concurrency Visualizer SDK function CvWriteMessage (C library).
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvWriteMessageW
  - cvmarkers/CvWriteMessageExW
  - cvmarkers/CvWriteMessageVA
  - cvmarkers/CvWriteMessageExVW
  - cvmarkers/CvWriteMessageExA
  - cvmarkers/CvWriteMessageA
  - cvmarkers/CvWriteMessageExVA
  - cvmarkers/CvWriteMessageVW
helpviewer_keywords: 
  - CvWriteMessageExVA method
  - CvWriteMessageW method
  - CvWriteMessageVW method
  - CvWriteMessageExVW method
  - CvWriteMessageExW method
  - CvWriteMessageA method
  - CvWriteMessageVA method
  - CvWriteMessageExA method
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# CvWriteMessage function

Writes a message to the Concurrency Visualizer trace file.

## Syntax

```C
HRESULT CvWriteMessageW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCWSTR pMessage,
    ...
    );

HRESULT CvWriteMessageA(
    PCV_MARKERSERIES pMarkerSeries,
    _In_ PCSTR pMessage,
    ...
    );

HRESULT CvWriteMessageVW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCWSTR pMessage,
    _In_ va_list argList);

HRESULT CvWriteMessageVA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCSTR pMessage,
    _In_ va_list argList);

HRESULT CvWriteMessageExW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCWSTR pMessage,
    ...
    );

HRESULT CvWriteMessageExA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCSTR pMessage,
    ...
    );

HRESULT CvWriteMessageExVW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ CV_IMPORTANCE level,
    _In_ int category,
    _In_ PCWSTR pMessage,
    _In_ va_list argList);

HRESULT CvWriteMessageExVA(
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
 Category of the span

 `level`
 Importance level of the span.

 `pMarkerSeries`
 Valid marker series context. Cannot be NULL.

 `pMessage`
 Message format string. Cannot be NULL.

## Return value
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

 **Unicode:** CvWriteMessageW, CvWriteMessageVW, CvWriteMessageExW, CvWriteMessageExVW

 **ANSI:** CvWriteMessageA, CvWriteMessageVA, CvWriteMessageExA, CvWriteMessageExVA

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)