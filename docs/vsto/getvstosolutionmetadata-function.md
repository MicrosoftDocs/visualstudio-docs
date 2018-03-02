---
title: "GetVstoSolutionMetadata Function | Microsoft Docs"
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
# GetVstoSolutionMetadata Function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```  
HRESULT WINAPI GetVstoSolutionMetadata(  
    LPCWSTR lpwszSolutionMetadataKey,  
    ISolutionMetadata** ppSolutionInfo  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*lpwszSolutionMetadataKey*|Don't use.|  
|*ppSolutionInfo*|Don't use.|  
  
## Return Value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  