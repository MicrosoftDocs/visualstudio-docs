---
title: "StopTrackingAndCleanup | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
apiname: 
  - "StopTrackingAndCleanup"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "StopTrackingAndCleanup"
ms.assetid: 9f8c5994-2dfc-43c3-a5fb-89b2f8990429
caps.latest.revision: 4
author: "kempb"
ms.author: "kempb"
manager: ghogen
ms.workload: 
  - "multiple"
---
# StopTrackingAndCleanup
Stops all tracking and frees any memory used by the tracking session.  
  
## Syntax  
  
```cpp 
HRESULT WINAPI StopTrackingAndCleanup(void);  
```  
  
## Return Value  
 Returns an **HRESULT** with the **SUCCEEDED** bit set if tracking was stopped.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [StartTrackingContext](../msbuild/starttrackingcontext.md)