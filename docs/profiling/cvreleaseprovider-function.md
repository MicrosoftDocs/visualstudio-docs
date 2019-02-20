---
title: "CvReleaseProvider Function | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "cvmarkers/CvReleaseProvider"
helpviewer_keywords:
  - "CvReleaseProvider method"
ms.assetid: 8d74379e-295d-452b-bd5f-0769df387d4f
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
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