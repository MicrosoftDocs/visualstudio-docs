---
title: "IJsDebug::OpenVirtualProcess Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IJSDebug.OpenVirtualProcess"
apilocation: 
  - "jscript9diag.dll"
ms.assetid: 5612bf1b-a4e3-4eaf-ac5e-c2e1f147c395
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IJsDebug::OpenVirtualProcess Method
Factory method used to create a new virtual process object.  
  
## Syntax  
  
```cpp
HRESULT OpenVirtualProcess(  
   DWORD processId,  
   UINT64 runtimeJsBaseAddress,  
   IJsDebugDataTarget *pDataTarget,  
   IJsDebugProcess **ppProcess  
);  
```  
  
#### Parameters  
 `processId`  
 [in] Process Id to attach the debugger to.  
  
 `runtimeJsBaseAddress`  
 [in] The base address at which the JavaScript runtime has loaded into the target process.  
  
 `pDataTarget`  
 [in] Debugger supplied interface to query for state of the process.  
  
 `ppProcess`  
 [out] New debug process object  
  
## Return Value  
  
## Remarks  
 Returns E_JsDEBUG_MISMATCHED_RUNTIME if Jscript9diag and Jscript9 do not match.  
  
## Requirements  
 **Header:** jscript9diag.h  
  
## See also  
 [IJsDebug Interface](../../winscript/reference/ijsdebug-interface.md)