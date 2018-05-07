---
title: "EndTrackingContext | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: msbuild
ms.topic: "conceptual"
apiname: 
  - "EndTrackingContext"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "EndTrackingContext"
ms.assetid: c2c5d794-8dc8-4594-8717-70dc79a0e75d
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload: 
  - "multiple"
---
# EndTrackingContext
End the current tracking context.  
  
## Syntax  
  
```  
HRESULT WINAPI EndTrackingContext();  
```  
  
## Return Value  
 An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was ended.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [StartTrackingContext](../msbuild/starttrackingcontext.md)