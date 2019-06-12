---
title: "SccUncheckout Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "SccUncheckout"
helpviewer_keywords: 
  - "SccUncheckout function"
ms.assetid: 6d498b70-29c7-44b7-ae1c-7e99e488bb09
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# SccUncheckout Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This function undoes a previous checkout operation, thereby restoring the contents of the selected file or files to the state prior to the checkout. All changes made to the file since the checkout are lost.  
  
## Syntax  
  
```cpp#  
SCCRTN SccUncheckout (  
   LPVOID    pvContext,  
   HWND      hWnd,  
   LONG      nFiles,  
   LPCSTR*   lpFileNames,  
   LONG      fOptions,  
   LPCMDOPTS pvOptions  
);  
```  
  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 nFiles  
 [in] Number of files specified in the `lpFileNames` array.  
  
 lpFileNames  
 [in] Array of fully qualified local path names of files for which to undo a checkout.  
  
 fOptions  
 [in] Command flags (not used).  
  
 pvOptions  
 [in] Source control plug-in-specific options.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Undo checkout was successful.|  
|SCC_E_FILENOTCONTROLLED|The selected file is not under source code control.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues. A retry is recommended.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure. Undo checkout did not succeed.|  
|SCC_E_NOTCHECKEDOUT|The user does not have the file checked out.|  
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|  
|SCC_E_PROJNOTOPEN|The project has not been opened from source control.|  
|SCC_I_OPERATIONCANCELED|The operation was cancelled before completion.|  
  
## Remarks  
 After this operation, the `SCC_STATUS_CHECKEDOUT` and `SCC_STATUS_MODIFIED` flags will both be cleared for the files on which the undo checkout was performed.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
