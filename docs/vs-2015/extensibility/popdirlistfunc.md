---
title: "POPDIRLISTFUNC | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "POPLISTFUNC"
helpviewer_keywords: 
  - "POPDIRLISTFUNC callback function"
ms.assetid: 0ee90fd2-5467-4154-ab4c-7eb02ac3a14c
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# POPDIRLISTFUNC
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This is a callback function given to the [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md) function to update a collection of directories and (optionally) file names to find out which are under source control.  
  
 The `POPDIRLISTFUNC` callback should be called only for those directories and file names (in the list given to the `SccPopulateDirList` function) that are actually under source control.  
  
## Signature  
  
```cpp#  
typedef BOOL (*POPDIRLISTFUNC)(  
   LPVOID pvCallerData,  
   BOOL bFolder,  
   LPCSTR lpDirectoryOrFileName  
);  
```  
  
## Parameters  
 pvCallerData  
 [in] User value given to [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md).  
  
 bFolder  
 [in] `TRUE` if the name in `lpDirectoryOrFileName` is a directory; otherwise the name is a file name.  
  
 lpDirectoryOrFileName  
 [in] Full local path to a directory or file name that is under source code control.  
  
## Return Value  
 The IDE returns an appropriate error code:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Continue processing.|  
|SCC_I_OPERATIONCANCELED|Stop processing.|  
|SCC_E_xxx|Any appropriate source control error should stop processing.|  
  
## Remarks  
 If the `fOptions` parameter of the `SccPopulateDirList` function contains the `SCC_PDL_INCLUDEFILES` flag, then the list will possibly contain file names as well as directory names.  
  
## See Also  
 [Callback Functions Implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)   
 [SccPopulateDirList](../extensibility/sccpopulatedirlist-function.md)   
 [Error Codes](../extensibility/error-codes.md)
