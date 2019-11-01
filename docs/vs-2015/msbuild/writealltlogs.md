---
title: "WriteAllTLogs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
api_name: 
  - "WriteAllTLogs"
api_location: 
  - "filetracker.dll"
api_type: 
  - "COM"
helpviewer_keywords: 
  - "WriteAllTLogs"
ms.assetid: 1fa3e10b-263c-4960-a9ad-485c02a7a872
caps.latest.revision: 9
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# WriteAllTLogs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Writes tracking logs for all threads and contexts.  
  
## Syntax  
  
```  
HRESULT WINAPI WriteAllTLogs(LPCTSTR intermediateDirectory, LPCTSTR tlogRootName);  
```  
  
#### Parameters  
 [in] `intermediateDirectory`  
 The directory in which to store the tracking log.  
  
 [in] `tlogRootName`  
 The root name of the log file name.  
  
## Return Value  
 An [HRESULT](<!-- TODO: review code entity reference <xref:assetId:///HRESULT?qualifyHint=False&amp;autoUpgrade=True>  -->) with the [SUCCEEDED](<!-- TODO: review code entity reference <xref:assetId:///SUCCEEDED?qualifyHint=False&amp;autoUpgrade=True>  -->) bit set if the tracking context was created.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [WriteContextTLogs](../msbuild/writecontexttlogs.md)
