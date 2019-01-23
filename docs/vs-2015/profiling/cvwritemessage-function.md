---
title: "CvWriteMessage Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvWriteMessageW"
  - "cvmarkers/CvWriteMessageExW"
  - "cvmarkers/CvWriteMessageVA"
  - "cvmarkers/CvWriteMessageExVW"
  - "cvmarkers/CvWriteMessageExA"
  - "cvmarkers/CvWriteMessageA"
  - "cvmarkers/CvWriteMessageExVA"
  - "cvmarkers/CvWriteMessageVW"
helpviewer_keywords: 
  - "CvWriteMessageExVA method"
  - "CvWriteMessageW method"
  - "CvWriteMessageVW method"
  - "CvWriteMessageExVW method"
  - "CvWriteMessageExW method"
  - "CvWriteMessageA method"
  - "CvWriteMessageVA method"
  - "CvWriteMessageExA method"
ms.assetid: e20ae7be-bfa7-437a-b8c1-fa0f1baa7f83
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvWriteMessage Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Writes a message to the Concurrency Visualizer trace file.  
  
## Syntax  
  
```  
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
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvWriteMessageW, CvWriteMessageVW, CvWriteMessageExW, CvWriteMessageExVW  
  
 **ANSI:** CvWriteMessageA, CvWriteMessageVA, CvWriteMessageExA, CvWriteMessageExVA  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
