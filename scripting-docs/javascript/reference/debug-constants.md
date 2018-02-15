---
title: "Debug Constants | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
ms.assetid: 76b572ee-bad0-404e-9fd4-841c9af35642
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Debug Constants
Debug constants return constant values that are properties of the `Debug` object.  
  
## Debug Object Constants  
 The following table lists constant values that are properties of the [Debug object](../../javascript/reference/debug-object-javascript.md).  
  
|Constant|Description|Value|  
|--------------|-----------------|-----------|  
|`Debug.MS_ASYNC_CALLBACK_STATUS_ASSIGN_DELEGATE`|The synchronous work item assigned a callback or continuation to be run by an asynchronous operation.|0|  
|`Debug.MS_ASYNC_CALLBACK_STATUS_JOIN`|The synchronous work item satisfied part of a join asynchronous operation.|1|  
|`Debug.MS_ASYNC_CALLBACK_STATUS_CHOOSEANY`|The synchronous work item satisfied a choice asynchronous operation.|2|  
|`Debug.MS_ASYNC_CALLBACK_STATUS_CANCEL`|The synchronous work item was canceled.|3|  
|`Debug.MS_ASYNC_CALLBACK_STATUS_ERROR`|The synchronous work item caused an error in an asynchronous operation.|4|  
|`Debug.MS_ASYNC_OP_STATUS_SUCCESS`|The asynchronous operation was successful.|1|  
|`Debug.MS_ASYNC_OP_STATUS_CANCELED`|The asynchronous operation was canceled.|2|  
|`Debug.MS_ASYNC_OP_STATUS_ERROR`|The asynchronous operation resulted in an error.|3|  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [Debug.msTraceAsyncOperationCompleted Function](../../javascript/reference/debug-mstraceasyncoperationcompleted-function.md)   
 [Debug.msUpdateAsyncCallbackRelation Function](../../javascript/reference/debug-msupdateasynccallbackrelation-function.md)