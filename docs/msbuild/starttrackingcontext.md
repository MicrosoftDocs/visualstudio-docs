---
title: "StartTrackingContext | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
apiname: 
  - "StartTrackingContext"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "StartTrackingContext"
ms.assetid: 720cd295-38e7-4974-86db-b8106b1207ba
caps.latest.revision: 5
author: "kempb"
ms.author: "kempb"
manager: ghogen
ms.workload: 
  - "multiple"
---
# StartTrackingContext
Start a tracking context.  
  
## Syntax  
  
```cpp
HRESULT WINAPI StartTrackingContext(LPCTSTR intermediateDirectory, LPCTSTR taskName);  
```  
  
#### Parameters  
 [in] `intermediateDirectory`  
 The directory in which to store the tracking log.  
  
 [in] `taskName`  
 Identifies the tracking context. This name is used to create the log file name.  
  
## Return Value  
 An **HRESULT** with the **SUCCEEDED** bit set if the tracking context was created.  
  
## Requirements  
 **Header:** FileTracker.h