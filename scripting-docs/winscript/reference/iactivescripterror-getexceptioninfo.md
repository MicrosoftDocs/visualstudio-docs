---
title: "IActiveScriptError::GetExceptionInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptError.GetExceptionInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptError_GetExceptionInfo"
ms.assetid: 528416cc-8468-4ad7-a6c2-fa1daf6ecf33
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptError::GetExceptionInfo
Retrieves information about an error that occurred while the scripting engine was running a script.  
  
## Syntax  
  
```cpp
HRESULT GetExceptionInfo(  
    EXCEPINFO *pexcepinfo  // structure for exception information  
);  
```  
  
#### Parameters  
 `pexcepinfo`  
 [out] Address of an `EXCEPINFO` structure that receives error information.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if an error occurred.  
  
## See also  
 [IActiveScriptError](../../winscript/reference/iactivescripterror.md)