---
title: "CvCreateMarkerSeries Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvCreateMarkerSeriesA"
  - "cvmarkers/CvCreateMarkerSeriesW"
helpviewer_keywords: 
  - "CvCreateMarkerSeriesA method"
  - "CvCreateMarkerSeriesW method"
ms.assetid: e280530b-137a-43a7-8643-aa514ab86ed7
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvCreateMarkerSeries Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Creates marker series for a given provider.  
  
## Syntax  
  
```  
_Check_return_ HRESULT CvCreateMarkerSeriesW(  
    _In_ PCV_PROVIDER  pProvider,  
    _In_ LPCWSTR pSeriesName,  
    _Out_ PCV_MARKERSERIES* ppMarkerSeries);  
  
_Check_return_ HRESULT CvCreateMarkerSeriesA(  
    _In_ PCV_PROVIDER  pProvider,  
    _In_ LPCSTR pSeriesName,  
    _Out_ PCV_MARKERSERIES* ppMarkerSeries);  
```  
  
#### Parameters  
 `pProvider`  
 Provider object previously initialized by CvInitProvider. Cannot be NULL.  
  
 `pSeriesName`  
 Marker series name. Cannot be NULL but empty string is allowed.  
  
 `ppMarkerSeries`  
 Address of an output variable which will store marker series context. Cannot be NULL.  
  
## Return Value  
 S_OK when marker series is successfully created or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvCreateMarkerSeriesW  
  
 **ANSI:** CvCreateMarkerSeriesA  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
