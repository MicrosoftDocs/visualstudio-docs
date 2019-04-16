---
title: "ResumeTracking | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
api_name: 
  - "ResumeTracking"
api_location: 
  - "filetracker.dll"
api_type: 
  - "COM"
helpviewer_keywords: 
  - "ResumeTracking"
ms.assetid: d637e019-7c50-4b0a-812e-bc822001e697
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# ResumeTracking
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Resumes tracking in the current context.  
  
## Syntax  
  
```  
HRESULT WINAPI ResumeTracking();  
```  
  
## Return Value  
 An [HRESULT](<!-- TODO: review code entity reference <xref:assetId:///HRESULT?qualifyHint=False&amp;autoUpgrade=True>  -->) with the [SUCCEEDED](<!-- TODO: review code entity reference <xref:assetId:///SUCCEEDED?qualifyHint=False&amp;autoUpgrade=True>  -->) bit set if tracking was resumed. [E_FAIL](<!-- TODO: review code entity reference <xref:assetId:///E_FAIL?qualifyHint=False&amp;autoUpgrade=True>  -->) is returned if tracking cannot be resumed because the context was not available.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [SuspendTracking](../msbuild/suspendtracking.md)
