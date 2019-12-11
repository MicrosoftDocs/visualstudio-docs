---
title: "IActiveScriptErrorDebug::GetStackFrame | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptErrorDebug.GetStackFrame"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IActiveScriptErrorDebug::GetStackFrame"
ms.assetid: a6f43102-68c5-46f5-a4df-fa3aaf53a967
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptErrorDebug::GetStackFrame
Provides the stack frame that is in effect for runtime errors.  
  
## Syntax  
  
```cpp
HRESULT GetStackFrame(  
   IDebugStackFrame**  ppdsf  
);  
```  
  
#### Parameters  
 `ppdsf`  
 [out] The stack frame for the error.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method provides the stack frame that is in effect for run-time errors.  
  
## See also  
 [IActiveScriptErrorDebug Interface](../../winscript/reference/iactivescripterrordebug-interface.md)