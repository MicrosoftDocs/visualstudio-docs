---
title: CvCreateDefaultMarkerSeriesOfDefaultProvider Function | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords: 
  - cvmarkers/CvCreateDefaultMarkerSeriesOfDefaultProvider
helpviewer_keywords: 
  - CvCreateDefaultMarkerSeriesOfDefaultProvider method
ms.assetid: 24eb80f8-8fca-4c47-93b5-bb1eb8ffdffd
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# CvCreateDefaultMarkerSeriesOfDefaultProvider function
Creates default marker series of a default provider.

## Syntax

```C
HRESULT CvCreateDefaultMarkerSeriesOfDefaultProvider(
   _Out_ PCV_PROVIDER* ppProvider,
   _Out_ PCV_MARKERSERIES* ppMarkerSeries
);
```

#### Parameters
 `ppProvider`
 Address of provider object variable. Address cannot be NULL, the variable can have any value.

 `ppMarkerSeries`
 Address of marker series object variable. Address cannot be NULL, the variable can have any value.

## Return value
 S_OK when both provider and marker series are successfully created or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.

## Requirements
 **Header:** *cvmarkers.h*

## See also
- [C++ library reference](../profiling/cpp-library-reference.md)