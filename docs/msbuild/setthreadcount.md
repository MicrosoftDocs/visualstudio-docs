---
title: "SetThreadCount | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: msbuild
ms.topic: "reference"
apiname: 
  - "SetThreadCount"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "SetThreadCount"
ms.assetid: 335335a5-8ca0-4e18-95f5-62aa6a691386
author: mikejo5000
ms.author: mikejo
manager: douge
ms.workload: 
  - "multiple"
---
# SetThreadCount
Sets the global thread count, and assigns that count to the current thread.  
  
## Syntax  
  
```  
HRESULT WINAPI SetThreadCount(int threadCount);  
```  
  
#### Parameters  
 [in] `threadCount`  
 The number of threads to use.  
  
## Return Value  
 An **HRESULT** with the **SUCCEEDED** bit set if the thread count was updated.  
  
## Requirements  
 **Header:** FileTracker.h