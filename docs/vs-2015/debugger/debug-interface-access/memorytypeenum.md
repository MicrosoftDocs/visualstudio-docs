---
title: "MemoryTypeEnum | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MemoryTypeEnum enumeration"
ms.assetid: 8778c047-edeb-4495-8f9f-3f8bbb297099
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# MemoryTypeEnum
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies the type of memory to access.  
  
## Syntax  
  
```cpp#  
enum MemoryTypeEnum {  
   MemTypeCode,  
   MemTypeData,  
   MemTypeStack,  
   MemTypeAny = -1  
};  
```  
  
#### Parameters  
 `MemTypeCode`  
 Accesses only code memory.  
  
 `MemTypeData`  
 Accesses data or stack memory.  
  
 `MemTypeStack`  
 Accesses only stack memory.  
  
 `MemTypeAny`  
 Accesses any kind of memory.  
  
## Remarks  
 The values in this enumeration are passed to the [IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md) method to limit access to different types of memory.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaStackWalkHelper::readMemory](../../debugger/debug-interface-access/idiastackwalkhelper-readmemory.md)
