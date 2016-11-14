---
title: "IDebugProgramNode2::GetHostPid | Microsoft Docs"
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
  - "IDebugProgramNode2::GetHostPid"
helpviewer_keywords: 
  - "IDebugProgramNode2::GetHostPid"
ms.assetid: e65b4b15-46d8-4ca7-9456-2b4c078f7cf9
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
# IDebugProgramNode2::GetHostPid
Gets the system process identifier for the process hosting the program.  
  
## Syntax  
  
```cpp#  
HRESULT GetHostPid (   
   AD_PROCESS_ID * pdwHostPid  
);  
```  
  
```c#  
int GetHostPid (   
   out AD_PROCESS_ID pdwHostPid  
);  
```  
  
#### Parameters  
 `pdwHostPid`  
 [out] Returns the system process identifier for the hosting process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a simple `CProgram` object that implements the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface.  
  
```cpp#  
HRESULT CProgram::GetHostPid(DWORD* pdwHostPid) {    
    // Check for valid argument.    
   if (pdwHostPid)    
    {    
        // Get the process identifier of the calling process.    
      *pdwHostPid = GetCurrentProcessId();    
  
        return S_OK;    
    }    
  
    return E_INVALIDARG;    
}    
```  
  
## See Also  
 [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)