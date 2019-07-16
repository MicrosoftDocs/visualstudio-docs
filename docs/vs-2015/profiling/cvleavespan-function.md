---
title: "CvLeaveSpan Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvLeaveSpan"
helpviewer_keywords: 
  - "CvLeaveSpan method"
ms.assetid: 3bf65fdf-a471-4efd-ac7a-03e701bbae5d
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvLeaveSpan Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Marks the end of span.  
  
## Syntax  
  
```  
HRESULT CvLeaveSpan(  
   _In_ PCV_SPAN pSpan  
);  
```  
  
#### Parameters  
 `pSpan`  
 Span object returned by previous call to CvEnterSpan*. Cannot be NULL.  
  
## Return Value  
 S_OK when the message is successfully written. Error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
