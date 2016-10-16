---
title: "IDiaStackFrame::get_rawLVarInstanceValue"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_rawLVarInstanceValue method"
ms.assetid: ce526259-85a6-475b-9274-0b3a21d95db2
caps.latest.revision: 10
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaStackFrame::get_rawLVarInstanceValue
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
 [IDiaStackFrame](../debugger/idiastackframe.md)