---
title: "marker_series::is_enabled Method | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "cvmarkersobj/Concurrency::diagnostic::marker_series::is_enabled"
helpviewer_keywords: 
  - "Concurrency::diagnostic::marker_series::is_enabled method"
ms.assetid: 8ce4dd50-ca29-4c72-98d6-582693f7d501
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# marker_series::is_enabled Method
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Determines if any session has enabled the provider.  
  
## Syntax  
  
```  
bool is_enabled();  
bool is_enabled(  
   marker_importance _Importance,  
   int _Category  
);  
```  
  
#### Parameters  
 `_Importance`  
 Importance level.  
  
 `_Category`  
 Category.  
  
## Return Value  
  
## Requirements  
 **Header:** cvmarkersobj.h  
  
 **Namespace:** Concurrency::diagnostic  
  
## See Also  
 [marker_series Class](../profiling/marker-series-class.md)
