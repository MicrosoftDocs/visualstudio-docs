---
title: "EndTrackingContext | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
apiname: 
  - "EndTrackingContext"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "EndTrackingContext"
ms.assetid: c2c5d794-8dc8-4594-8717-70dc79a0e75d
caps.latest.revision: 3
author: "kempb"
ms.author: "kempb"
manager: ghogen
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