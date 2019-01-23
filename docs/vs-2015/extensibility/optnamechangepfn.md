---
title: "OPTNAMECHANGEPFN | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "OPTNAMECHANGEPFN"
helpviewer_keywords: 
  - "OPTNAMECHANGEPFN callback function"
ms.assetid: 147303f3-c7f1-438a-81b7-db891ea3d076
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# OPTNAMECHANGEPFN
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This is a callback function specified in a call to the [SccSetOption](../extensibility/sccsetoption-function.md) (using option `SCC_OPT_NAMECHANGEPFN`) and is used to communicate name changes made by the source control plug-in back to the IDE.  
  
## Signature  
  
```cpp#  
typedef void (*OPTNAMECHANGEPFN)(  
   LPVOID pvCallerData,  
   LPCSTR pszOldName,  
   LPCSTR pszNewName  
);  
```  
  
## Parameters  
 pvCallerData  
 [in] User value specified in a previous call to the [SccSetOption](../extensibility/sccsetoption-function.md) (using option `SCC_OPT_USERDATA`).  
  
 pszOldName  
 [in] The original name of the file.  
  
 pszNewName  
 [in] The name the file was renamed to.  
  
## Return Value  
 None.  
  
## Remarks  
 If a file is renamed during a source control operation, the source control plug-in can notify the IDE about the name change through this callback.  
  
 If the IDE does not support this callback, it will not call the [SccSetOption](../extensibility/sccsetoption-function.md) to specify it. If the plug-in does not support this callback, it will return `SCC_E_OPNOTSUPPORTED` from the `SccSetOption` function when the IDE attempts to set the callback.  
  
## See Also  
 [Callback Functions Implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)   
 [SccSetOption](../extensibility/sccsetoption-function.md)
