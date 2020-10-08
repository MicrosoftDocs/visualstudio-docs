---
title: "IDiaStackWalker::getEnumFrames2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalker2::getEnumFrames2 method"
ms.assetid: 73196d3f-112c-4b3a-997b-7c6b815d4afc
caps.latest.revision: 15
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackWalker::getEnumFrames2
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [in] A value from the [CV_CPU_TYPE_e Enumeration](../../debugger/debug-interface-access/cv-cpu-type-e.md) enumeration, specifying the platform type.  
  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../../debugger/debug-interface-access/idiaenumstackframes.md) object containing a list of [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To obtain a stack frame list for just the x86 platform, call the [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) method.  
  
## See Also  
 [IDiaStackWalker](../../debugger/debug-interface-access/idiastackwalker.md)   
 [CV_CPU_TYPE_e Enumeration](../../debugger/debug-interface-access/cv-cpu-type-e.md)   
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)   
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)   
 [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
