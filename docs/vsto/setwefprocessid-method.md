---
title: "SetWefProcessId Method | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# SetWefProcessId Method
  Provides the process identifier that will run Web Extensions Framework (WEF) content.  
  
## Syntax  
  
```  
HRESULT SetWefProcessId(  
    [in] DWORD dwProcessId  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*dwProcessId*|The process identifier that will be used to run WEF content.|  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 This method must be called after the WEF content process is created but before any WEF content runs.  
  
 If you want the development environment to attach a debugger to the WEF content process, the environment must perform this operation in your implementation of this method.  
  
  