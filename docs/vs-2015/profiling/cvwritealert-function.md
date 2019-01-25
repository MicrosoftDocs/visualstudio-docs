---
title: "CvWriteAlert Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvWriteAlertVA"
  - "cvmarkers/CvWriteAlertVW"
  - "cvmarkers/CvWriteAlertA"
  - "cvmarkers/CvWriteAlertW"
helpviewer_keywords: 
  - "CvWriteAlertVW method"
  - "CvWriteAlertA method"
  - "CvWriteAlertVA method"
  - "CvWriteAlertW method"
ms.assetid: 937aa9d6-278a-4df3-bef7-151441df16d5
caps.latest.revision: 9
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvWriteAlert Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Writes an alert to the Concurrency Visualizer trace file.  
  
## Syntax  
  
```  
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
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvWriteAlertW, CvWriteAlertVW  
  
 **ANSI:** CvWriteAlertA, CvWriteAlertVA  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
