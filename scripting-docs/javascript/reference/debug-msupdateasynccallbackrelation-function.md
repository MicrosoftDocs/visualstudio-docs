---
title: "Debug.msUpdateAsyncCallbackRelation Function | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: ee6a1efc-375c-4ce8-a4e8-8896ee29f849
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug.msUpdateAsyncCallbackRelation Function
Updates the relationship status between a synchronous work item and the associated asynchronous operation.  
  
## Syntax  
  
```  
Debug.msUpdateAsyncCallbackRelation(relatedAsyncOperationId, relationType)  
```  
  
#### Parameters  
 `relatedAsyncOperationId`  
 Required. The ID associated with the asynchronous operation.  
  
 `relationType`  
 Optional. The value that specifies the relationship status.  
  
## Remarks  
 The synchronous work item is typically the callback function for the asynchronous operation. This function may be called when an asynchronous operation is aborted, when a join operation is used, or in other scenarios.  
  
 The possible values for `relationType` include:  
  
-   `Debug.MS_ASYNC_CALLBACK_STATUS_ASSIGN_DELEGATE`  
  
-   `Debug.MS_ASYNC_CALLBACK_STATUS_JOIN`  
  
-   `Debug.MS_ASYNC_CALLBACK_STATUS_CHOOSEANY`  
  
-   `Debug.MS_ASYNC_CALLBACK_STATUS_CANCEL`  
  
-   `Debug.MS_ASYNC_CALLBACK_STATUS_ERROR`  
  
 For more information, see [Debug Constants](../../javascript/reference/debug-constants.md).  
  
> [!NOTE]
>  Some debugging tools do not display the information sent to the debugger by this function.  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]