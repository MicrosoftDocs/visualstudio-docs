---
title: CvReleaseProvider Function
description: See reference information for the Concurrency Visualizer SDK function CvReleaseProvider (C library).
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvReleaseProvider
helpviewer_keywords: 
  - CvReleaseProvider method
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# CvReleaseProvider function

Releases marker provider. Releasing the marker provider will not affect previously created marker series of this provider. Marker series have to be release separately by CvReleaseMarkerSeries call. Failure to release provider causes a memory leak.

## Syntax

```C
HRESULT CvReleaseProvider(
   _In_ PCV_PROVIDER pProvider
);
```

#### Parameters
 `pProvider`
 Provider context. Cannot be NULL.

## Return Value
 S_OK when provider is successfully released or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)