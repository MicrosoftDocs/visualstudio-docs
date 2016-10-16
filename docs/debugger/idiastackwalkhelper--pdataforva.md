---
title: "IDiaStackWalkHelper::pdataForVA"
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
  - "IDiaStackWalkHelper2::pdataByVA method"
ms.assetid: fafc38fe-74dc-4726-9a51-eebf3a673d7f
caps.latest.revision: 11
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
# IDiaStackWalkHelper::pdataForVA
Returns the PDATA data block associated with the virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT pdataForVA(   
   ULONGLONG  va,  
   DWORD      cbData,  
   DWORD*     pcbData,  
   BYTE*      pbData  
);  
```  
  
#### Parameters  
 `va`  
 [in] Specifies the virtual address of the data to obtain.  
  
 `cbData`  
 [in] The size of data in bytes to obtain.  
  
 `pcbData`  
 [out] Returns the actual size of data in bytes that was obtained.  
  
 `pbData`  
 [in, out] A buffer that is filled in with the requested data. Cannot be `NULL`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there is no PDATA for the specified address. Otherwise, returns an error code.  
  
## Remarks  
 The PDATA (the section named ".pdata") of a compiland contains information about exception handling for functions.  
  
 The caller knows how much data is to be returned so the caller has no need to ask for how much data is available. Therefore, it is acceptable for an implementation of this method to return an error if the `pbData` parameter is `NULL`.  
  
## See Also  
 [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md)