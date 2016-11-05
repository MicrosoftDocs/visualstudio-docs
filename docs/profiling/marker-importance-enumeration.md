---
title: "marker_importance Enumeration | Microsoft Docs"
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
  - "cvmarkersobj/Concurrency::diagnostic::marker_importance"
helpviewer_keywords: 
  - "Concurrency::diagnostic::marker_importance enumeration"
ms.assetid: d5524ea0-0227-4d8e-9122-332291042df5
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
# marker_importance Enumeration
Represents the importance level of a Concurrency Visualizer marker.  
  
## Syntax  
  
```  
enum marker_importance;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`critical_importance`|Specifies that the marker has critical importance.|  
|`high_importance`|Specifies that the marker has high importance.|  
|`low_importance`|Specifies that the marker has low importance.|  
|`normal_importance`|Specifies that the marker has normal importance.|  
  
## Requirements  
 **Header:** cvmarkersobj.h  
  
 **Namespace:** Concurrency::diagnostic  
  
## See Also  
 [diagnostic Namespace](../profiling/diagnostic-namespace.md)