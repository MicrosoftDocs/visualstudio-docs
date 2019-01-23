---
title: "IDiaStackFrame::get_rawLVarInstanceValue | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_rawLVarInstanceValue method"
ms.assetid: ce526259-85a6-475b-9274-0b3a21d95db2
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackFrame::get_rawLVarInstanceValue
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
