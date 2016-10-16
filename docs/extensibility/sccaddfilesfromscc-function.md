---
title: "SccAddFilesFromSCC Function"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SccAddFilesFromSCC"
helpviewer_keywords: 
  - "SccAddFilesFromSCC function"
ms.assetid: f21a3500-ade8-4dd8-8647-10e2179be9c1
caps.latest.revision: 17
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
# SccAddFilesFromSCC Function
This function adds a list of files from source control to the currently opened project.  
  
## Syntax  
  
```cpp  
SCCRTN SccAddFilesFromSCC(  
   LPVOID  pContext,  
   HWND    hWnd,  
   LPSTR   lpUser,  
   LPSTR   lpAuxProjPath,  
   LONG    cFiles,  
   LPCSTR* lpFilePaths,  
   LPCSTR  lpDestination,  
   LPCSTR  lpComment,  
   LPBOOL  pbResults  
);  
```  
  
#### Parameters  
 pContext  
 [in] The source control plug-in context pointer.  
  
 hWnd  
 [in] A handle to the IDE window that the source control plug-in can use as a parent for any dialog boxes that it provides.  
  
 lpUser  
 [in, out] The username (up to SCC_USER_SIZE, including the null terminator).  
  
 lpAuxProjPath  
 [in, out] Auxiliary string identifying the project (up to `SCC_PRJPATH_`SIZE, including the null terminator).  
  
 cFiles  
 [in] Number of files given by `lpFilePaths`.  
  
 lpFilePaths  
 [in, out] Array of file names to add to the current project.  
  
 lpDestination  
 [in] The destination path where the files are to be written.  
  
 lpComment  
 [in] The comment to be applied to each of the files being added.  
  
 pbResults  
 [in, out] Array of flags that are set to indicate success (nonzero or TRUE) or failure (zero or FALSE) for each file (size of the array must be at least `cFiles` long).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_E_PROJNOTOPEN|Project is not open.|  
|SCC_E_OPNOTPERFORMED|Connection is not to the same project as specified by `lpAuxProjPath.`|  
|SCC_E_NOTAUTHORIZED|User is not authorized to update the database.|  
|SCC_E_NONSPECIFICERROR|Unknown error.|  
|SCC_I_RELOADFILE|A file or project needs to be reloaded.|  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)