---
title: "SccEndBatch Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccEndBatch"
helpviewer_keywords: 
  - "SccEndBatch function"
ms.assetid: 100e7833-fe0a-45c0-9fca-3e61fd1165b7
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# SccEndBatch Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function concludes a batch of source control operations. These batches may not be nested.  
  
## Syntax  
  
```cpp#  
SCCRTN SccEndBatch(void);  
```  
  
#### Parameters  
 None.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Batch of operations successfully concluded.|  
|SCC_E_UNKNOWNERROR|Nonspecific failure.|  
  
## Remarks  
 Source control batches are used to execute the same source control operations across multiple projects or multiple contexts. Batches can be used to eliminate redundant dialog boxes from the user experience during a batched operation. The [SccBeginBatch](../extensibility/sccbeginbatch-function.md) and the `SccEndBatch` function are used as a pair to indicate the beginning and end of an operation. They cannot be nested.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)   
 [SccBeginBatch](../extensibility/sccbeginbatch-function.md)
