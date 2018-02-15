---
title: "ResumeTracking | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: msbuild
ms.tgt_pltfrm: ""
ms.topic: "article"
apiname: 
  - "ResumeTracking"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "ResumeTracking"
ms.assetid: d637e019-7c50-4b0a-812e-bc822001e697
caps.latest.revision: 4
author: Mikejo5000
ms.author: mikejo
manager: ghogen
ms.workload: 
  - "multiple"
---
# ResumeTracking
Resumes tracking in the current context.  
  
## Syntax  
  
```  
HRESULT WINAPI ResumeTracking();  
```  
  
## Return Value  
 An **HRESULT** with the **SUCCEEDED** bit set if tracking was resumed. **E_FAIL** is returned if tracking cannot be resumed because the context was not available.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [SuspendTracking](../msbuild/suspendtracking.md)