---
title: "SccUninitialize Function | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "SccUninitialize"
helpviewer_keywords: 
  - "SccUninitialize function"
ms.assetid: 17cf5337-d251-4422-bc96-93fe7d48f2ae
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# SccUninitialize Function
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