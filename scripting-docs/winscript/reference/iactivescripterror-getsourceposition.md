---
title: "IActiveScriptError::GetSourcePosition | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptError.GetSourcePosition"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptError_GetSourcePosition"
ms.assetid: ae9b26b1-82a7-4645-9686-3261d8248664
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptError::GetSourcePosition
Retrieves the location in the source code where an error occurred while the scripting engine was running a script.  
  
## Syntax  
  
```cpp
HRESULT GetSourcePosition(  
    DWORD *pdwSourceContext,  // context cookie  
    ULONG *pulLineNumber,     // line number of error  
    LONG *pichCharPosition    // character position of error  
);  
```  
  
#### Parameters  
 `pdwSourceContext`  
 [out] Address of a variable that receives a cookie that identifies the context. The interpretation of this parameter depends on the host application.  
  
 `pulLineNumber`  
 [out] Address of a variable that receives the line number in the source file where the error occurred.  
  
 `pichCharPosition`  
 [out] Address of a variable that receives the character position in the line where the error occurred.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if the location was not retrieved.  
  
## See also  
 [IActiveScriptError](../../winscript/reference/iactivescripterror.md)