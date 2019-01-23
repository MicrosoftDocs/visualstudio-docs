---
title: "CvReleaseMarkerSeries Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvReleaseMarkerSeries"
helpviewer_keywords: 
  - "CvReleaseMarkerSeries method"
ms.assetid: 3b4711ee-e534-411d-9128-f69cd7932a48
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvReleaseMarkerSeries Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Releases marker series. Do not use marker series object after releasing otherwise the application might crash. Failure to release marker series causes a memory leak.  
  
## Syntax  
  
```  
HRESULT CvReleaseMarkerSeries(  
   _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries  
);  
```  
  
#### Parameters  
 `pMarkerSeries`  
 Address of provider object variable. Address cannot be NULL, the variable can have any value.  
  
## Return Value  
 S_OK when marker series is successfully released or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
