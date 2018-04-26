---
title: "marker_series::is_enabled Method | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "cvmarkersobj/Concurrency::diagnostic::marker_series::is_enabled"
helpviewer_keywords: 
  - "Concurrency::diagnostic::marker_series::is_enabled method"
ms.assetid: 8ce4dd50-ca29-4c72-98d6-582693f7d501
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# marker_series::is_enabled Method
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [marker_series::is_enabled Method](https://docs.microsoft.com/visualstudio/profiling/marker-series-is-enabled-method).  
  
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



