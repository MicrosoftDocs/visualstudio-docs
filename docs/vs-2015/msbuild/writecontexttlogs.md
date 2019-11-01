---
title: "WriteContextTLogs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
api_name: 
  - "WriteContextTLogs"
api_location: 
  - "filetracker.dll"
api_type: 
  - "COM"
helpviewer_keywords: 
  - "WriteContextTLogs"
ms.assetid: ffc6c7be-3f22-4624-9ffc-0122fe72b6ec
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# WriteContextTLogs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Writes logs files for the current context.  
  
## Syntax  
  
```  
HRESULT WINAPI WriteContextTLogs(LPCTSTR intermediateDirectory, LPCTSTR tlogRootName);  
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
 [WriteAllTLogs](../msbuild/writealltlogs.md)
