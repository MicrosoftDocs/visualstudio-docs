---
title: "IDiaStackWalker::getEnumFrames2"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 73196d3f-112c-4b3a-997b-7c6b815d4afc
caps.latest.revision: 12
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
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
 [in] A value from the [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md) enumeration, specifying the platform type.  
  
 `pHelper`  
 [in] The helper [IDiaStackWalkHelper](../VS_debugger/IDiaStackWalkHelper.md) object.  
  
 `ppEnum`  
 [out] Returns an [IDiaEnumStackFrames](../VS_debugger/IDiaEnumStackFrames.md) object containing a list of [IDiaStackFrame](../VS_debugger/IDiaStackFrame.md) objects.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To obtain a stack frame list for just the x86 platform, call the [IDiaStackWalker::getEnumFrames](../VS_debugger/IDiaStackWalker--getEnumFrames.md) method.  
  
## See Also  
 [IDiaStackWalker](../VS_debugger/IDiaStackWalker.md)   
 [CV_CPU_TYPE_e Enumeration](../VS_debugger/CV_CPU_TYPE_e.md)   
 [IDiaStackWalkHelper](../VS_debugger/IDiaStackWalkHelper.md)   
 [IDiaStackFrame](../VS_debugger/IDiaStackFrame.md)   
 [IDiaStackWalker::getEnumFrames](../VS_debugger/IDiaStackWalker--getEnumFrames.md)