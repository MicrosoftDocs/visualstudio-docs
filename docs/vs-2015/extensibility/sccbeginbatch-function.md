---
title: "SccBeginBatch Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccBeginBatch"
helpviewer_keywords: 
  - "SccBeginBatch function"
ms.assetid: 33968183-2e15-4e0d-955b-ca12212d1c25
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# SccBeginBatch Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function starts a batch sequence of source control operations. The [SccEndBatch](../extensibility/sccendbatch-function.md) will be called to end the batch. These batches may not be nested.  
  
## Syntax  
  
```cpp#  
SCCRTN SccBeginBatch(void);  
```  
  
#### Parameters  
 None.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Batch of operations successfully began.|  
|SCC_E_UNKNOWNERROR|Nonspecific failure.|  
  
## Remarks  
 Source control batches are used to execute the same operations across multiple projects or multiple contexts. Batches can be used to eliminate redundant per-project dialog boxes from the user experience during a batched operation. The `SccBeginBatch` function and the [SccEndBatch](../extensibility/sccendbatch-function.md) are used as a function pair to indicate the beginning and end of an operation. They cannot be nested. `SccBeginBatch` sets a flag indicating that a batch operation is in progress.  
  
 While a batch operation is in effect, the source control plug-in should present at most one dialog box for any question to the user and apply the response from that dialog box on all subsequent operations.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)   
 [SccEndBatch](../extensibility/sccendbatch-function.md)
