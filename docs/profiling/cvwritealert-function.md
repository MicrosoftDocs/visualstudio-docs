---
title: CvWriteAlert Function | Microsoft Docs
description: See reference information for the Concurrency Visualizer SDK function CvWriteAlert (C library).
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvWriteAlertVA
  - cvmarkers/CvWriteAlertVW
  - cvmarkers/CvWriteAlertA
  - cvmarkers/CvWriteAlertW
helpviewer_keywords: 
  - CvWriteAlertVW method
  - CvWriteAlertA method
  - CvWriteAlertVA method
  - CvWriteAlertW method
ms.assetid: 937aa9d6-278a-4df3-bef7-151441df16d5
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# CvWriteAlert function
Writes an alert to the Concurrency Visualizer trace file.

## Syntax

```C
HRESULT CvWriteAlertW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCWSTR pMessage,
    ...
    );

HRESULT CvWriteAlertA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCSTR pMessage,
    ...
    );

HRESULT CvWriteAlertVW(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCWSTR pMessage,
    _In_ va_list argList);

HRESULT CvWriteAlertVA(
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,
    _In_ PCSTR pMessage,
    _In_ va_list argList);
```

#### Parameters
 `argList`
 List of arguments.

 `pMarkerSeries`
 Valid marker series context. Cannot be NULL.

 `pMessage`
 Message format string. Cannot be NULL.

## Return value
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

 **Unicode:** CvWriteAlertW, CvWriteAlertVW

 **ANSI:** CvWriteAlertA, CvWriteAlertVA

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)