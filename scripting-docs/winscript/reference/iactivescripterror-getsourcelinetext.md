---
title: "IActiveScriptError::GetSourceLineText | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptError.GetSourceLineText"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptError_GetSourceLineText"
ms.assetid: 64f7f37f-7288-4dbe-b626-a35d90897f36
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptError::GetSourceLineText
Retrieves the line in the source file where an error occurred while a scripting engine was running a script.  
  
## Syntax  
  
```cpp
HRESULT GetSourceLineText(  
    BSTR *pbstrSourceLine  // address of buffer for source line  
);  
```  
  
## Parameter  
 `pbstrSourceLine`  
 [out] Address of a buffer that receives the line of source code in which the error occurred.  
  
## Return Value  
 Returns `S_OK` if successful, or `E_FAIL` if the line in the source file was not retrieved.  
  
## See also  
 [IActiveScriptError](../../winscript/reference/iactivescripterror.md)