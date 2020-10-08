---
title: "SuspendTracking | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
api_name: 
  - "SuspendTracking"
api_location: 
  - "filetracker.dll"
api_type: 
  - "COM"
helpviewer_keywords: 
  - "SuspendTracking"
ms.assetid: f5e06e5a-8083-444c-99c1-07ba834226b5
caps.latest.revision: 6
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# SuspendTracking
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Suspends tracking in the current context.  
  
## Syntax  
  
```  
HRESULT WINAPI SuspendTracking(void);  
```  
  
## Return Value  
 An [HRESULT](<!-- TODO: review code entity reference <xref:assetId:///HRESULT?qualifyHint=False&amp;autoUpgrade=True>  -->) with the [SUCCEEDED](<!-- TODO: review code entity reference <xref:assetId:///SUCCEEDED?qualifyHint=False&amp;autoUpgrade=True>  -->) bit set if tracking was suspended.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [ResumeTracking](../msbuild/resumetracking.md)
