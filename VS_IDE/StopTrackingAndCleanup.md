---
title: "StopTrackingAndCleanup"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - StopTrackingAndCleanup
apilocation: 
  - filetracker.dll
apitype: COM
ms.assetid: 9f8c5994-2dfc-43c3-a5fb-89b2f8990429
caps.latest.revision: 4
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# StopTrackingAndCleanup
Stops all tracking and frees any memory used by the tracking session.  
  
## Syntax  
  
```  
HRESULT WINAPI StopTrackingAndCleanup(void);  
```  
  
## Return Value  
 Returns an [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if tracking was stopped.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [StartTrackingContext](../VS_IDE/StartTrackingContext.md)