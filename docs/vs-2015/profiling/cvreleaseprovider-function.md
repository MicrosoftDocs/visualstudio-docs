---
title: "CvReleaseProvider Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvReleaseProvider"
helpviewer_keywords: 
  - "CvReleaseProvider method"
ms.assetid: 8d74379e-295d-452b-bd5f-0769df387d4f
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvReleaseProvider Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Releases marker provider. Releasing the marker provider will not affect previously created marker series of this provider. Marker series have to be release separately by CvReleaseMarkerSeries call. Failure to release provider causes a memory leak.  
  
## Syntax  
  
```  
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
 **Header:** cvmarkers.h  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
