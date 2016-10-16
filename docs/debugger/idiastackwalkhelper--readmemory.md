---
title: "IDiaStackWalkHelper::readMemory"
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
  - "IDiaStackWalkHelper2::readMemory method"
ms.assetid: e1eb90aa-49b7-476c-9e70-7e8f08994cbe
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
# IDiaStackWalkHelper::readMemory
Reads a block of data from the executable's image in memory.  
  
## Syntax  
  
```cpp#  
HRESULT readMemory(   
   enum MemoryTypeEnum type,  
   ULONGLONG           va,  
   DWORD               cbData,  
   DWORD*              pcbData,  
   BYTE*               pbData  
);  
```  
  
#### Parameters  
 `type`  
 [in] A value from the [MemoryTypeEnum Enumeration](../debugger/memorytypeenum.md) enumeration specifying the type of memory to read.  
  
 va  
 [in] Virtual address in the image from which to begin reading.  
  
 `cbData`  
 [in] The size of the data buffer in bytes.  
  
 `pcbData`  
 [out] Returns the number of bytes actually read. If `pbData` is `NULL`, then this is the total number of bytes of data available.  
  
 `pbData`  
 [in, out] A buffer that is filled in with the memory read.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md)   
 [MemoryTypeEnum Enumeration](../debugger/memorytypeenum.md)