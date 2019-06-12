---
title: "SccUninitialize Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccUninitialize"
helpviewer_keywords: 
  - "SccUninitialize function"
ms.assetid: 17cf5337-d251-4422-bc96-93fe7d48f2ae
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# SccUninitialize Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function cleans up any allocations or open connections created by a previous call to the [SccInitialize](../extensibility/sccinitialize-function.md) in preparation for shutting down the source control plug-in.  
  
## Syntax  
  
```cpp#  
SCCRTN SccUninitialize (  
   LPVOID pvContext  
);  
```  
  
#### Parameters  
 pvContext  
 [in] The pointer to the source control plug-in context structure created in the [SccInitialize](../extensibility/sccinitialize-function.md).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The clean-up completed successfully.|  
  
## Remarks  
 The source control plug-in is responsible for preparing to be shut down and for freeing memory that the plug-in has allocated for the context structure. The function is called once for each given instance of a plug-in. A call to the [SccInitialize](../extensibility/sccinitialize-function.md) precedes this call. No projects can still be open at the time of the call to `SccUninitialize`.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)   
 [SccInitialize](../extensibility/sccinitialize-function.md)
