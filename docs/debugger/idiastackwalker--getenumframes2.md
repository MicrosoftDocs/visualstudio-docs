---
title: "IDiaStackWalker::getEnumFrames2"
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
  - "IDiaStackWalker2::getEnumFrames2 method"
ms.assetid: 73196d3f-112c-4b3a-997b-7c6b815d4afc
caps.latest.revision: 12
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
# IDiaStackWalker::getEnumFrames2
Retrieves a stack frame enumerator for a specific platform type.  
  
## Syntax  
  
```cpp#  
  
      HRESULT getEnumFrames2(   
   enum  CV_CPU_TYPE_e    cpuid,  
   IDiaStackWalkHelper*   pHelper,  
   IDiaEnumStackFrames**  ppEnum  
);  
```  
  
#### Parameters  
 `cpuid`  
 [in] A value from the [CV_CPU_TYPE_e Enumeration](../debugger/cv_cpu_type_e.md) enumeration, specifying the platform type.  
  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../debugger/idiaenumstackframes.md) object containing a list of [IDiaStackFrame](../debugger/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To obtain a stack frame list for just the x86 platform, call the [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md) method.  
  
## See Also  
 [IDiaStackWalker](../debugger/idiastackwalker.md)   
 [CV_CPU_TYPE_e Enumeration](../debugger/cv_cpu_type_e.md)   
 [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md)   
 [IDiaStackFrame](../debugger/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md)