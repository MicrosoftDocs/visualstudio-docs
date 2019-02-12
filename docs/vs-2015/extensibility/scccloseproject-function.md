---
title: "SccCloseProject Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccCloseProject"
helpviewer_keywords: 
  - "SccCloseProject function"
ms.assetid: 259c2069-d349-4814-810f-1c3151b7fb84
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# SccCloseProject Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function closes a project, marking the end of a particular session.  
  
## Syntax  
  
```cpp#  
SCCRTN SccCloseProject (  
   LPVOID pvContext  
);  
```  
  
#### Parameters  
 pvContext  
 The source control plug-in context structure.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The project was successfully closed.|  
|SCC_E_PROJNOTOPEN|No project is currently open.|  
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|  
  
## Remarks  
 The [SccOpenProject](../extensibility/sccopenproject-function.md) is always called before this function. A call to this function is then followed by a call to either the `SccOpenProject` function or the [SccUninitialize](../extensibility/sccuninitialize-function.md), which ends the connection to the source control system completely.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)   
 [SccOpenProject](../extensibility/sccopenproject-function.md)   
 [SccInitialize](../extensibility/sccinitialize-function.md)
