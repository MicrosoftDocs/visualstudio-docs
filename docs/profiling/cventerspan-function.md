---
title: "CvEnterSpan Function | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "cvmarkers/CvEnterSpanVA"
  - "cvmarkers/CvEnterSpanW"
  - "cvmarkers/CvEnterSpanExW"
  - "cvmarkers/CvEnterSpanA"
  - "cvmarkers/CvEnterSpanExVW"
  - "cvmarkers/CvEnterSpanExA"
  - "cvmarkers/CvEnterSpanVW"
helpviewer_keywords: 
  - "CvEnterSpanVW method"
  - "CvEnterSpanVA method"
  - "CvEnterSpanExA method"
  - "CvEnterSpanW method"
  - "CvEnterSpanA method"
  - "CvEnterSpanExVW method"
  - "CvEnterSpanExW method"
ms.assetid: 91689e9c-6733-44b9-b36a-8b9b2eef7d1d
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CvEnterSpan Function
Marks the beginning of a new span.  
  
## Syntax  
  
```  
HRESULT CvEnterSpanW(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCWSTR pMessage,  
    ...   
    );   
  
HRESULT CvEnterSpanA(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCSTR pMessage,   
    ...   
    );   
  
HRESULT CvEnterSpanVW(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCWSTR pMessage,  
    _In_ va_list argList  
    );   
  
HRESULT CvEnterSpanVA(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCSTR pMessage,   
    _In_ va_list argList  
    );   
  
HRESULT CvEnterSpanExW(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _In_ CV_IMPORTANCE level,   
    _In_ int category,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCWSTR pMessage,   
    ...   
    );   
  
HRESULT CvEnterSpanExA(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _In_ CV_IMPORTANCE level,   
    _In_ int category,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCSTR pMessage,   
    ...   
    );   
  
HRESULT CvEnterSpanExVW(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _In_ CV_IMPORTANCE level,   
    _In_ int category,   
    _Out_ PCV_SPAN* ppSpan,   
    _In_ PCWSTR pMessage,   
    _In_ va_list argList);   
  
HRESULT CvEnterSpanExVA(  
    _In_reads_bytes_(16) PCV_MARKERSERIES pMarkerSeries,   
    _In_ CV_IMPORTANCE level,   
    _In_ int category,   
    _Out_ PCV_SPAN* ppSpan,   
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
  
 `ppSpan`  
 Address of the variable which will hold resulting span object. Address cannot be NULL, the variable can have any value.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
 **Unicode:** CvEnterSpanW, CvEnterSpanVW, CvEnterSpanExW, CvEnterSpanExVW  
  
 **ANSI:** CvEnterSpanA, CvEnterSpanVA, CvEnterSpanExA, CvEnterSpanExVW  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)