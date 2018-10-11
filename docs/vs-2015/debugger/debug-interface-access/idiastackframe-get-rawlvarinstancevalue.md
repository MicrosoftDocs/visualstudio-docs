---
title: "IDiaStackFrame::get_rawLVarInstanceValue | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_rawLVarInstanceValue method"
ms.assetid: ce526259-85a6-475b-9274-0b3a21d95db2
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackFrame::get_rawLVarInstanceValue
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaStackFrame::get_rawLVarInstanceValue](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiastackframe-get-rawlvarinstancevalue).  
  
This method retrieves the value of the specified local variable as raw bytes.  
  
## Syntax  
  
```cpp#  
HRESULT get_rawLVarInstanceValue(  
   IDiaLVarInstance* pInstance,  
   DWORD             cbDataMax,  
   DWORD*            pcbData,  
   BYTE*             pbData  
);  
```  
  
#### Parameters  
 `pInstance`  
 [in] An `IDiaLVarInstance` object representing an instance of local variable to get the value for.  
  
 `cbDataMax`  
 [in] Maximum number of bytes in the buffer pointed to by `pbData`. This can be a maximum of 8 bytes (`sizeof(ULONGLONG)`).  
  
 `pcbData`  
 [out] Returns the actual number of bytes stored in the buffer.  
  
 `pbData`  
 [out] A buffer to be filled in with data. This cannot be `NULL`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)



