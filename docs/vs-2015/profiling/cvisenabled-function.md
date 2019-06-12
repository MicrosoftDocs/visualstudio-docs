---
title: "CvIsEnabled Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmarkers/CvIsEnabledEx"
  - "cvmarkers/CvIsEnabled"
helpviewer_keywords: 
  - "CvIsEnabled method"
  - "CvIsEnabledEx method"
ms.assetid: 2e4fea6d-758d-4150-8744-6102a1d58c1c
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvIsEnabled Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Determines whether any session has enabled the specified ETW provider.  
  
## Syntax  
  
```  
HRESULT CvIsEnabled(  
   _In_ PCV_PROVIDER pProvider  
);  
HRESULT CvIsEnabledEx(  
   _In_ PCV_PROVIDER pProvider,  
   _In_ CV_IMPORTANCE level,  
   _In_ int category  
);  
```  
  
#### Parameters  
 `category`  
 Category.  
  
 `level`  
 Importance level.  
  
 `pProvider`  
 Valid provider object. Cannot be NULL.  
  
## Return Value  
 S_OK if provider is currently enabled. S_FALSE if provider is currently disabled. Error code in case there were any errors. Use FAILED macro to check for error condition and then check for S_OK/S_FALSE.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
