---
title: "SccQueryChanges Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccQueryChanges"
helpviewer_keywords: 
  - "SccQueryChanges function"
ms.assetid: 4cd58eb3-6952-49b1-9620-8682e3eaa604
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# SccQueryChanges Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function enumerates a given list of files, providing information about name changes for each file via a callback function.  
  
## Syntax  
  
```cpp  
SCCRTN SccQueryChanges(  
   LPVOID           pContext,  
   LONG             nFiles,  
   LPCSTR*          lpFileNames,  
   QUERYCHANGESFUNC pfnCallback,  
   LPVOID           pvCallerData  
);  
```  
  
#### Parameters  
 pContext  
 [in] The source control plug-in context pointer.  
  
 nFiles  
 [in] Number of files in `lpFileNames` array.  
  
 lpFileNames  
 [in] Array of file names to get information about.  
  
 pfnCallback  
 [in] Callback function to call for each file name in the list (see [QUERYCHANGESFUNC](../extensibility/querychangesfunc.md) for details).  
  
 pvCallerData  
 [in] Value that will be passed unchanged to the callback function.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The query process completed successfully.|  
|SCC_E_PROJNOTOPEN|The project has not been opened in source control.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|  
|SCC_E_NONSPECIFICERROR|An unspecified or general error occurred.|  
  
## Remarks  
 Changes being queried for are to the namespace: specifically, renaming, adding, and removing a file.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)   
 [QUERYCHANGESFUNC](../extensibility/querychangesfunc.md)   
 [Error Codes](../extensibility/error-codes.md)
