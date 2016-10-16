---
title: "IDebugMemoryBytes2::WriteAt"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugMemoryBytes2::WriteAt"
helpviewer_keywords: 
  - "IDebugMemoryBytes2::WriteAt method"
  - "WriteAt method"
ms.assetid: 61cc3704-47fa-4d9b-aa62-bb4585ac8fb1
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugMemoryBytes2::WriteAt
Writes the specified number of bytes of memory, starting at the specified address.  
  
## Syntax  
  
```cpp#  
HRESULT WriteAt(   
   IDebugMemoryContext2* pStartContext,  
   DWORD                 dwCount,  
   BYTE*                 rgbMemory  
);  
```  
  
```c#  
int WriteAt(  
   IDebugMemoryContext2 pStartContext,  
   uint                 dwCount,  
   byte[]               rgbMemory  
);  
```  
  
#### Parameters  
 `pStartContext`  
 [in] The [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md) object that specifies where to start writing bytes.  
  
 `dwCount`  
 [in] The number of bytes to write.  
  
 `rgbMemory`  
 [in] The bytes to write. This array is assumed to be at least `dwCount` bytes in size.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if not all bytes could be written or returns an error code (typically `E_FAIL`).  
  
## Remarks  
 If the starting address is not within the memory window represented by this [IDebugMemoryBytes2](../extensibility/idebugmemorybytes2.md) object, no writing occurs and an error code of `E_FAIL` is returned — even if the amount to write overlaps into the memory space.  
  
## See Also  
 [IDebugMemoryBytes2](../extensibility/idebugmemorybytes2.md)   
 [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md)