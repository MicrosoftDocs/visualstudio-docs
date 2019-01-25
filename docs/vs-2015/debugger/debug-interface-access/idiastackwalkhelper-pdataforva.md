---
title: "IDiaStackWalkHelper::pdataForVA | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalkHelper2::pdataByVA method"
ms.assetid: fafc38fe-74dc-4726-9a51-eebf3a673d7f
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackWalkHelper::pdataForVA
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
