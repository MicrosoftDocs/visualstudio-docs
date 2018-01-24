---
title: "MemoryTypeEnum | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MemoryTypeEnum enumeration"
ms.assetid: 8778c047-edeb-4495-8f9f-3f8bbb297099
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# MemoryTypeEnum
Specifies the type of memory to access.  
  
## Syntax  
  
```C++  
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