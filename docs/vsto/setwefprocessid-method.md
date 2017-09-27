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
ms.assetid: 404eec23-a67e-4f5b-b27d-86651f08be03
caps.latest.revision: 8
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
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
  
  