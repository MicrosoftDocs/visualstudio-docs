---
title: "MemoryTypeEnum"
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
  - "MemoryTypeEnum enumeration"
ms.assetid: 8778c047-edeb-4495-8f9f-3f8bbb297099
caps.latest.revision: 7
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
# MemoryTypeEnum
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
 The values in this enumeration are passed to the [IDiaStackWalkHelper::readMemory](../debugger/idiastackwalkhelper--readmemory.md) method to limit access to different types of memory.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../debugger/enumerations-and-structures.md)   
 [IDiaStackWalkHelper::readMemory](../debugger/idiastackwalkhelper--readmemory.md)